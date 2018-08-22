using System;
using System.Net;
using System.Threading.Tasks;
using Xero.Api.Core.File;
using Xero.Api.Core.Model.Types;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public class PdfEndpoint
    {
        private readonly string _endpointBase;
        private XeroHttpClient Client { get; set; }

        public PdfEndpoint(XeroHttpClient client)
            : this(client, "/api.xro/2.0")
        {
            Client = client;
        }

        public PdfEndpoint(XeroHttpClient client, string endpointBase)
        {
            _endpointBase = endpointBase;
            Client = client;
        }

        public async Task<BinaryFile> GetAsync(PdfEndpointType type, Guid parent)
        {
            var response = await Client.GetRawAsync($"{_endpointBase}/{type}/{parent:D}", "application/pdf").ConfigureAwait(false);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                return new BinaryFile(stream, parent.ToString("D") + ".pdf", response.Content.Headers.ContentType.ToString(), (int)stream.Length);
            }

            await Client.HandleErrorsAsync(response).ConfigureAwait(false);

            return null;
        }
    }
}
