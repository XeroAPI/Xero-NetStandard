using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IAccountsEndpoint
        : IXeroUpdateEndpoint<AccountsEndpoint, Account, AccountsRequest, AccountsResponse>
    {
    }

    public class AccountsEndpoint
        : XeroUpdateEndpoint<AccountsEndpoint, Account, AccountsRequest, AccountsResponse>, IAccountsEndpoint
    {
        public AccountsEndpoint(XeroHttpClient client) :
            this(client, "/api.xro/2.0")
        {
        }

        public AccountsEndpoint(XeroHttpClient client, string endpointBase) :
            base(client, $"{endpointBase}/Accounts")
        {
        }
    }
}