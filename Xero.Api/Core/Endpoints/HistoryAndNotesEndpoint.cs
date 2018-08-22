using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IHistoryAndNotesEndpoint
    {
        Task<IEnumerable<HistoryRecord>> FindAsync(HistoryAndNotesEndpointRetrieveType type, Guid parent);
        Task<HistoryRecord> CreateNoteAsync(HistoryAndNotesEndpointCreateType type, Guid parent, HistoryRecord note);
    }

    public class HistoryAndNotesEndpoint : IHistoryAndNotesEndpoint
    {
        private readonly string _endpointBase;
        private XeroHttpClient Client { get; set; }

        public HistoryAndNotesEndpoint(XeroHttpClient client)
            : this(client, "/api.xro/2.0")
        {
        }

        public HistoryAndNotesEndpoint(XeroHttpClient client, string endpointBase)
        {
            _endpointBase = endpointBase;
            Client = client;
        }

        public Task<IEnumerable<HistoryRecord>> FindAsync(HistoryAndNotesEndpointRetrieveType type, Guid parent)
        {
            return Client.GetAsync<HistoryRecord, HistoryRecordsResponse>($"{_endpointBase}/{type}/{parent:D}/history");
        }

        public async Task<HistoryRecord> CreateNoteAsync(HistoryAndNotesEndpointCreateType type, Guid parent, HistoryRecord note)
        {
            var request = new HistoryRecordsRequest{note};

            var historyRecords = await Client.PutAsync<HistoryRecord, HistoryRecordsResponse>($"{_endpointBase}/{type}/{parent:D}/history", request).ConfigureAwait(false);
            return historyRecords.FirstOrDefault();
        }
    }
}