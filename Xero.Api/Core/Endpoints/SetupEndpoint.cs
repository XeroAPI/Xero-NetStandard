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
        private readonly string _endpointBase;

        public SetupEndpoint(XeroHttpClient client) :
            this(client, "/api.xro/2.0")
        {
        }

        public SetupEndpoint(XeroHttpClient client, string endpointBase)
        {
            _client = client;
            _endpointBase = endpointBase;
        }

        public async Task<ImportSummary> UpdateAsync(Setup setup)
        {
            var response = await _client.PostAsync($"{_endpointBase}/Setup", setup).ConfigureAwait(false);

            return await HandleResponseAsync(response).ConfigureAwait(false);
        }

        public async Task<ImportSummary> CreateAsync(Setup setup)
        {
            var response = await _client.PutAsync($"{_endpointBase}/Setup", setup).ConfigureAwait(false);

            return await HandleResponseAsync(response).ConfigureAwait(false);
        }

        private async Task<ImportSummary> HandleResponseAsync(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                return _client.JsonMapper.From<SetupResponse>(body).ImportSummary;
            }

            await _client.HandleErrorsAsync(response).ConfigureAwait(false);

            return null;
        }
    }
}
