using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xero.Api.Common;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface ILinkedTransactionsEndpoint : IXeroUpdateEndpoint<LinkedTransactionsEndpoint, LinkedTransaction, LinkedTransactionsRequest, LinkedTransactionsResponse>, IPageableEndpoint<ILinkedTransactionsEndpoint>
    {
        Task DeleteAsync(LinkedTransaction linkedTransaction);
        LinkedTransactionsEndpoint WhereSourceId(Guid sourceId);
        LinkedTransactionsEndpoint WhereContactId(Guid contactId);
        LinkedTransactionsEndpoint WhereTargetId(Guid targetId);
    }

    public class LinkedTransactionsEndpoint
        : XeroUpdateEndpoint<LinkedTransactionsEndpoint, LinkedTransaction, LinkedTransactionsRequest, LinkedTransactionsResponse>, ILinkedTransactionsEndpoint
    {
        internal LinkedTransactionsEndpoint(XeroHttpClient client) 
            : base(client, "/api.xro/2.0/LinkedTransactions")
        {
            AddParameter("page", 1, false);
        }

        public async Task DeleteAsync(LinkedTransaction linkedTransaction)
        {
            var endpoint = string.Format("/api.xro/2.0/LinkedTransactions/{0}", linkedTransaction.Id);

            var response = await Client.DeleteAsync(endpoint).ConfigureAwait(false);

            await HandleResponseAsync(response).ConfigureAwait(false);
        }

        public ILinkedTransactionsEndpoint Page(int page)
        {
            return AddParameter("page", page);
        }

        public LinkedTransactionsEndpoint WhereSourceId(Guid sourceId)
        {
            return AddParameter("SourceTransactionID", sourceId.ToString());
        }

        public LinkedTransactionsEndpoint WhereContactId(Guid contactId)
        {
            return AddParameter("ContactID", contactId.ToString());
        }

        public LinkedTransactionsEndpoint WhereTargetId(Guid targetId)
        {
            return AddParameter("TargetTransactionID", targetId.ToString());
        }

        public override void ClearQueryString()
        {
            base.ClearQueryString();
            AddParameter("page", 1, false);
        }

        private async Task<LinkedTransactionsResponse> HandleResponseAsync(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                var result = Client.JsonMapper.From<LinkedTransactionsResponse>(body);
                return result;
            }

            await Client.HandleErrorsAsync(response).ConfigureAwait(false);

            return null;
        }
    }
}
