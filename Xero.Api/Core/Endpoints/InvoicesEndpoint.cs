using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        Task EmailInvoiceAsync(Guid id);
        Task<OnlineInvoice> RetrieveOnlineInvoiceUrlAsync(Guid invoiceId);
        IInvoicesEndpoint Ids(IEnumerable<Guid> ids);
        IInvoicesEndpoint ContactIds(IEnumerable<Guid> contactIds);
        IInvoicesEndpoint Statuses(IEnumerable<InvoiceStatus> statuses);
        IInvoicesEndpoint InvoiceNumbers(IEnumerable<string> invoiceNumbers);
        IInvoicesEndpoint CreatedByMyApp();
    }

    public class InvoicesEndpoint
        : FourDecimalPlacesEndpoint<InvoicesEndpoint, Invoice, InvoicesRequest, InvoicesResponse>, IInvoicesEndpoint
    {
        internal InvoicesEndpoint(XeroHttpClient client)
            : base(client, "/api.xro/2.0/Invoices")
        {
            AddParameter("page", 1, false);
        }

        public IInvoicesEndpoint Page(int page)
        {
            return AddParameter("page", page);
        }

        public IInvoicesEndpoint Ids(IEnumerable<Guid> ids)
        {
            return AddParameter("ids", string.Join(",", ids));
        }

        public IInvoicesEndpoint ContactIds(IEnumerable<Guid> contactIds)
        {
            return AddParameter("contactids", string.Join(",", contactIds));
        }

        public IInvoicesEndpoint Statuses(IEnumerable<InvoiceStatus> statuses)
        {
            return AddParameter("statuses", string.Join(",", statuses.Select(it => it.GetEnumMemberValue())));
        }

        public IInvoicesEndpoint InvoiceNumbers(IEnumerable<string> invoiceNumbers)
        {
            return AddParameter("invoicenumbers", string.Join(",", invoiceNumbers));
        }

        public IInvoicesEndpoint CreatedByMyApp()
        {
            return AddParameter("createdByMyApp", true);
        }

        public async Task<OnlineInvoice> RetrieveOnlineInvoiceUrlAsync(Guid invoiceId)
        {
            return (await Client.GetAsync<OnlineInvoice, OnlineInvoicesResponse>(string.Format("/api.xro/2.0/Invoices/{0}/OnlineInvoice", invoiceId)).ConfigureAwait(false)).FirstOrDefault();
        }

        public async Task EmailInvoiceAsync(Guid id)
        {
            var response =  await Client.PostAsync($"/api.xro/2.0/invoices/{id}/emails", new byte[]{}).ConfigureAwait(false);

            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return;
            }

            await Client.HandleErrorsAsync(response).ConfigureAwait(false);
        }

        public override void ClearQueryString()
        {
            base.ClearQueryString();
            AddParameter("page", 1, false);
        }
    }
}
