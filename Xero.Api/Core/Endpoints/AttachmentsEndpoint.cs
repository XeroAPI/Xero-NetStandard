using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xero.Api.Common;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public class AttachmentsEndpoint
    {
        private readonly string _endpointBase;
        private XeroHttpClient Client { get; set; }

        public AttachmentsEndpoint(XeroHttpClient client)
            : this(client, "/api.xro/2.0")
        {
        }

        public AttachmentsEndpoint(XeroHttpClient client, string endpointBase)
        {
            _endpointBase = endpointBase;
            Client = client;
        }

        public Task<IEnumerable<Attachment>> ListAsync(AttachmentEndpointType type, Guid parent)
        {
            return Client.GetAsync<Attachment, AttachmentsResponse>($"{_endpointBase}/{type}/{parent:D}/Attachments");
        }

        public async Task<Attachment> GetAsync(AttachmentEndpointType type, Guid parent, string fileName)
        {
            var response = await Client.GetAsync($"{_endpointBase}/{type}/{parent:D}/Attachments/{fileName}").ConfigureAwait(false);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                return new Attachment(stream, fileName, response.Content.Headers.ContentType.ToString(), (int)stream.Length);
            }

            await Client.HandleErrorsAsync(response).ConfigureAwait(false);
            return null;
        }

        public async Task<Attachment> AddOrReplaceAsync(Attachment attachment, AttachmentEndpointType type, Guid parent, bool includeOnline = false)
        {
            var mimeType = MimeTypes.GetMimeType(attachment.FileName);

            var url = $"{_endpointBase}/{type}/{parent:D}/Attachments/{attachment.FileName}";

            var parameters = new NameValueCollection();

            if (SupportsOnline(type) && includeOnline)
            {
                parameters.AddIfNotNull("IncludeOnline", true);
            }

            var result = await Client.PostAsync<Attachment, AttachmentsResponse>(url, attachment.Content, mimeType, parameters).ConfigureAwait(false);

            return result.FirstOrDefault();
        }

        private static bool SupportsOnline(AttachmentEndpointType type)
        {
            return type == AttachmentEndpointType.Invoices || type == AttachmentEndpointType.CreditNotes;
        }
    }
}
