using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xero.Api.Core.Model.Setup;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface ISetupEndpoint
    {
        Task<ImportSummary> UpdateAsync(Setup setup);
        Task<ImportSummary> CreateAsync(Setup setup);
    }

    public class SetupEndpoint : ISetupEndpoint
    {
        private readonly XeroHttpClient _client;
        private readonly string _apiEndpointUrl;

        public SetupEndpoint(XeroHttpClient client) :
            this(client, "/api.xro/2.0/Setup")
        {
        }

        protected SetupEndpoint(XeroHttpClient client, string apiEndpointUrl)
        {
            _client = client;
            _apiEndpointUrl = apiEndpointUrl;
        }

        public async Task<ImportSummary> UpdateAsync(Setup setup)
        {
            var response = await _client.PostAsync(_apiEndpointUrl, setup);

            return await HandleResponseAsync(response);
        }

        public async Task<ImportSummary> CreateAsync(Setup setup)
        {
            var response = await _client.PutAsync(_apiEndpointUrl, setup);

            return await HandleResponseAsync(response);
        }

        private async Task<ImportSummary> HandleResponseAsync(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var body = await response.Content.ReadAsStringAsync();

                return _client.JsonMapper.From<SetupResponse>(body).ImportSummary;                
            }

            await _client.HandleErrorsAsync(response);

            return null;
        }
    }
}
