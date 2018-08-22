using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xero.Api.Core.Model;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public class AllocationsEndpoint
    {
        private readonly XeroHttpClient _client;
        private readonly string _endpointBase;

        public AllocationsEndpoint(XeroHttpClient client)
            : this(client, "/api.xro/2.0")
        {
        }

        public AllocationsEndpoint(XeroHttpClient client, string endpointBase)
        {
            _client = client;
            _endpointBase = endpointBase;
        }

        public async Task<CreditNoteAllocation> AddAsync(CreditNoteAllocation allocation)
        {
            var endpoint = $"{_endpointBase}/CreditNotes/{allocation.CreditNote.Id}/Allocations";

            return await AddAsync(allocation, endpoint).ConfigureAwait(false) as CreditNoteAllocation;
        }

        public async Task<PrepaymentAllocation> AddAsync(PrepaymentAllocation allocation)
        {
            var endpoint = $"{_endpointBase}/Prepayments/{allocation.Prepayment.Id}/Allocations";

            return await AddAsync(allocation, endpoint).ConfigureAwait(false) as PrepaymentAllocation;
        }

        public async Task<OverpaymentAllocation> AddAsync(OverpaymentAllocation allocation)
        {
            var endpoint = $"{_endpointBase}/Overpayments/{allocation.Overpayment.Id}/Allocations";

            return await AddAsync(allocation, endpoint).ConfigureAwait(false) as OverpaymentAllocation;
        }

        private async Task<AllocationsResponse<T>> HandleResponseAsync<T>(HttpResponseMessage response)
            where T : AllocationBase
        {
            var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = _client.JsonMapper.From<AllocationsResponse<T>>(body);
                return result;
            }

            await _client.HandleErrorsAsync(response).ConfigureAwait(false);

            return null;
        }

        public async Task<AllocationBase> AddAsync<T>(T allocation, string endpoint)
            where T : AllocationBase
        {
            var response = await _client.PutAsync(endpoint, new List<T> {allocation}).ConfigureAwait(false);

            var result = await HandleResponseAsync<T>(response).ConfigureAwait(false);

            return result.Allocations.FirstOrDefault();
        }
    }
}
