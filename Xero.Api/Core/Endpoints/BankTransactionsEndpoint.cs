using Xero.Api.Common;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IBankTransactionsEndpoint : IXeroUpdateEndpoint<BankTransactionsEndpoint, BankTransaction, BankTransactionsRequest, BankTransactionsResponse>, IPageableEndpoint<IBankTransactionsEndpoint>
    {
    }

    public class BankTransactionsEndpoint : 
        FourDecimalPlacesEndpoint<BankTransactionsEndpoint, BankTransaction, BankTransactionsRequest, BankTransactionsResponse>,
        IBankTransactionsEndpoint
    {
        public BankTransactionsEndpoint(XeroHttpClient client)
            : this(client, "/api.xro/2.0")
        {
        }

        public BankTransactionsEndpoint(XeroHttpClient client, string endpointBase)
            : base(client, $"{endpointBase}/BankTransactions")
        {
            AddParameter("page", 1, false);
        }

        public IBankTransactionsEndpoint Page(int page)
        {
            return AddParameter("page", page);
        }

        public override void ClearQueryString()
        {
            base.ClearQueryString();
            AddParameter("page", 1, false);
        }
    }
}