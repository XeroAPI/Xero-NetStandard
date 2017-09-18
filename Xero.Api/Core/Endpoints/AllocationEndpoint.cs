using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Xero.Api.Common;
using Xero.Api.Core.Model;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public class AllocationsEndpoint
    {
        private readonly XeroHttpClient _client;
        
        public AllocationsEndpoint(XeroHttpClient client)
        {
            _client = client;
        }

        public Allocation Add(Allocation allocation)
        {
            var endpoint = string.Format("/api.xro/2.0/CreditNotes/{0}/Allocations", allocation.CreditNote.Id);

            return (Allocation)Add(allocation, endpoint);
        }

        public CreditNoteAllocation Add(CreditNoteAllocation allocation)
        {
            var endpoint = string.Format("/api.xro/2.0/CreditNotes/{0}/Allocations", allocation.CreditNote.Id);

            return (CreditNoteAllocation)Add(allocation, endpoint);
        }

        public PrepaymentAllocation Add(PrepaymentAllocation allocation)
        {
            var endpoint = string.Format("/api.xro/2.0/Prepayments/{0}/Allocations", allocation.Prepayment.Id);

            return (PrepaymentAllocation)Add(allocation, endpoint);
        }

        public OverpaymentAllocation Add(OverpaymentAllocation allocation)
        {
            var endpoint = string.Format("/api.xro/2.0/Overpayments/{0}/Allocations", allocation.Overpayment.Id);

            return (OverpaymentAllocation)Add(allocation, endpoint);
        }

        private AllocationsResponse<T> HandleResponse<T>(HttpResponseMessage response)
            where T : AllocationBase
        {
            var body = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = _client.JsonMapper.From<AllocationsResponse<T>>(body);
                return result;
            }

            _client.HandleErrors(response);

            return null;
        }

        public AllocationBase Add<T>(T allocation, string endpoint)
            where T : AllocationBase
        {
            var allocations = HandleResponse<T>(_client
                .Put(endpoint, _client.XmlMapper.To(new List<T> { allocation })))
                .Allocations;

            return allocations.FirstOrDefault();
        }
    }

    public class AllocationsResponse<T> : XeroResponse<T>
    {
        public List<T> Allocations { get; set; }

        public override IList<T> Values
        {
            get { return Allocations; }
        }
    }     
}
