using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;

namespace Xero.NetStandard.OAuth2.Test.Api.Client
{
    /// <summary>
    /// Tests for supplying an externally managed HttpClient (e.g. from IHttpClientFactory) to the SDK.
    /// </summary>
    public class HttpClientInjectionTests
    {
        private sealed class RecordingHandler : HttpMessageHandler
        {
            public List<HttpRequestMessage> Requests { get; } = new List<HttpRequestMessage>();

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                Requests.Add(request);
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("{\"Accounts\":[]}", Encoding.UTF8, "application/json")
                });
            }
        }

        private sealed class CountingDelegatingHandler : DelegatingHandler
        {
            public int Calls;

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                Interlocked.Increment(ref Calls);
                return base.SendAsync(request, cancellationToken);
            }
        }

        [Fact]
        public async Task AccountingApi_UsesInjectedHttpClient_WithDefaultBasePath()
        {
            var handler = new RecordingHandler();
            var api = new AccountingApi(new HttpClient(handler));

            Assert.Equal("https://api.xero.com/api.xro/2.0", api.GetBasePath());

            var accounts = await api.GetAccountsAsync("token", "tenant");

            Assert.NotNull(accounts);
            var request = Assert.Single(handler.Requests);
            Assert.Equal("https://api.xero.com/api.xro/2.0/Accounts", request.RequestUri.GetLeftPart(UriPartial.Path));
            Assert.Equal("Bearer", request.Headers.Authorization.Scheme);
            Assert.Equal("token", request.Headers.Authorization.Parameter);
        }

        [Fact]
        public void ApiClasses_WithInjectedHttpClient_KeepTheirOwnDefaultBasePath()
        {
            var httpClient = new HttpClient(new RecordingHandler());

            Assert.Equal("https://api.xero.com/projects.xro/2.0", new ProjectApi(httpClient).GetBasePath());
            Assert.Equal("https://api.xero.com/payroll.xro/1.0", new PayrollAuApi(httpClient).GetBasePath());
            Assert.Equal("https://api.xero.com", new IdentityApi(httpClient).GetBasePath());
        }

        [Fact]
        public async Task AccountingApi_WithInjectedHttpClientAndConfiguration_UsesConfiguredBasePath()
        {
            var handler = new RecordingHandler();
            var api = new AccountingApi(new HttpClient(handler), new Configuration { BasePath = "http://localhost:4010" });

            await api.GetAccountsAsync("token", "tenant");

            var request = Assert.Single(handler.Requests);
            Assert.Equal("http://localhost:4010/Accounts", request.RequestUri.GetLeftPart(UriPartial.Path));
        }

        [Fact]
        public void Constructors_RejectNullHttpClient()
        {
            Assert.Throws<ArgumentNullException>(() => new AccountingApi((HttpClient)null));
            Assert.Throws<ArgumentNullException>(() => new ApiClient((HttpClient)null, "https://api.xero.com"));
        }

        [Fact]
        public async Task ApiClient_Dispose_DoesNotDisposeInjectedHttpClient()
        {
            var handler = new RecordingHandler();
            var httpClient = new HttpClient(handler);

            using (var apiClient = new ApiClient(httpClient, "https://api.xero.com/api.xro/2.0"))
            {
            }

            // Would throw ObjectDisposedException if the SDK had disposed the caller's client
            var response = await httpClient.GetAsync("https://api.xero.com/api.xro/2.0/Accounts");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task AccountingApi_AsTypedHttpClient_RunsRequestsThroughFactoryHandlers()
        {
            var primary = new RecordingHandler();
            var counting = new CountingDelegatingHandler();

            var services = new ServiceCollection();
            services.AddHttpClient<AccountingApi>()
                .ConfigurePrimaryHttpMessageHandler(() => primary)
                .AddHttpMessageHandler(() => counting);

            using (var provider = services.BuildServiceProvider())
            {
                var api = provider.GetRequiredService<AccountingApi>();

                Assert.Equal("https://api.xero.com/api.xro/2.0", api.GetBasePath());

                await api.GetAccountsAsync("token", "tenant");

                Assert.Equal(1, counting.Calls);
                Assert.Single(primary.Requests);
            }
        }
    }
}
