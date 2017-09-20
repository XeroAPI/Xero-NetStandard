using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Common;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IInvoicesEndpoint : IXeroUpdateEndpoint<InvoicesEndpoint, Invoice, InvoicesRequest, InvoicesResponse>, IPageableEndpoint<IInvoicesEndpoint>
    {
        Task<OnlineInvoice> RetrieveOnlineInvoiceUrlAsync(Guid invoiceId);
        IInvoicesEndpoint Ids(IEnumerable<Guid> ids);
        IInvoicesEndpoint ContactIds(IEnumerable<Guid> contactIds);
        IInvoicesEndpoint Statuses(IEnumerable<InvoiceStatus> statuses);
        IInvoicesEndpoint InvoiceNumbers(IEnumerable<string> invoiceNumbers);
    }

    public class InvoicesEndpoint
        : FourDecimalPlacesEndpoint<InvoicesEndpoint, Invoice, InvoicesRequest, InvoicesResponse>, IInvoicesEndpoint
    {
        internal InvoicesEndpoint(XeroHttpClient client)
            : base(client, "/api.xro/2.0/Invoices")
        {
            Page(1);
        }

        public IInvoicesEndpoint Page(int page)
        {
            AddParameter("page", page);
            return this;
        }

        public IInvoicesEndpoint Ids(IEnumerable<Guid> ids)
        {
            AddParameter("ids", string.Join(",", ids));
            return this;
        }

        public IInvoicesEndpoint ContactIds(IEnumerable<Guid> contactIds)
        {
            AddParameter("contactids", string.Join(",", contactIds));
            return this;
        }

        public IInvoicesEndpoint Statuses(IEnumerable<InvoiceStatus> statuses)
        {
            AddParameter("statuses", string.Join(",", statuses.Select(it => it.GetEnumMemberValue())));
            return this;
        }

        public IInvoicesEndpoint InvoiceNumbers(IEnumerable<string> invoiceNumbers)
        {
            AddParameter("invoicenumbers", string.Join(",", invoiceNumbers));
            return this;
        }

        public override void ClearQueryString()
        {
            base.ClearQueryString();
            Page(1);
        }

        public async Task<OnlineInvoice> RetrieveOnlineInvoiceUrlAsync(Guid invoiceId)
        {
            return (await Client.GetAsync<OnlineInvoice, OnlineInvoicesResponse>(string.Format("/api.xro/2.0/Invoices/{0}/OnlineInvoice", invoiceId))).FirstOrDefault();
        }
    }
}
