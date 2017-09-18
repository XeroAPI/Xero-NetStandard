using System;
using System.Net;
using Xero.Api.Core.File;
using Xero.Api.Core.Model.Types;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public class PdfEndpoint
    {
        private XeroHttpClient Client { get; set; }

        public PdfEndpoint(XeroHttpClient client)
        {
            Client = client;
        }

        public BinaryFile Get(PdfEndpointType type, Guid parent)
        {
            var response = Client.GetRaw(string.Format("/api.xro/2.0/{0}/{1}", type, parent.ToString("D")), "application/pdf");

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stream = response.Content.ReadAsStreamAsync().Result;

                return new BinaryFile(stream, parent.ToString("D") + ".pdf", response.Content.Headers.ContentType.ToString(), (int)stream.Length);
            }

            Client.HandleErrors(response);

            return null;
        }
    }
}
