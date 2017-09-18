using System.Net;
using System.Net.Http;
using Xero.Api.Core.Model.Setup;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface ISetupEndpoint
    {
        ImportSummary Update(Setup setup);
        ImportSummary Create(Setup setup);
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

        public ImportSummary Update(Setup setup)
        {
            return HandleResponse(_client
                .Post(_apiEndpointUrl, setup));
        }

        public ImportSummary Create(Setup setup)
        {
            return HandleResponse(_client
                .Put(_apiEndpointUrl, setup));
        }

        private ImportSummary HandleResponse(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var body = response.Content.ReadAsStringAsync().Result;

                return _client.JsonMapper.From<SetupResponse>(body).ImportSummary;                
            }

            _client.HandleErrors(response);

            return null;
        }
    }
}
