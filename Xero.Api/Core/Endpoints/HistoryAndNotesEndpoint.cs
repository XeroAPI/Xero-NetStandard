using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IHistoryAndNotesEndpoint
    {
        Task<IEnumerable<HistoryRecord>> FindAsync(HistoryAndNotesEndpointRetrieveType type, Guid parent);
        Task CreateNoteAsync(HistoryAndNotesEndpointCreateType type, Guid parent, HistoryRecord note);
    }

    public class HistoryAndNotesEndpoint : IHistoryAndNotesEndpoint
    {
        private XeroHttpClient Client { get; set; }

        public HistoryAndNotesEndpoint(XeroHttpClient client)
        {
            Client = client;
        }

        public async Task<IEnumerable<HistoryRecord>> FindAsync(HistoryAndNotesEndpointRetrieveType type, Guid parent)
        {
            return await Client.GetAsync<HistoryRecord, HistoryRecordsResponse>($"api.xro/2.0/{type}/{parent:D}/history");
        }

        public async Task CreateNoteAsync(HistoryAndNotesEndpointCreateType type, Guid parent, HistoryRecord note)
        {
            var response = await Client.PutAsync($"api.xro/2.0/{type}/{parent:D}/history", note);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                await Client.HandleErrorsAsync(response);
            }
        }
    }
}