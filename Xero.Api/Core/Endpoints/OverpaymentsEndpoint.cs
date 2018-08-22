using Xero.Api.Common;
using Xero.Api.Core.Model;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IOverpaymentsEndpoint : IXeroReadEndpoint<OverpaymentsEndpoint, Overpayment, OverpaymentsResponse>, IPageableEndpoint<IOverpaymentsEndpoint>
    {
    }

    public class OverpaymentsEndpoint : XeroReadEndpoint<OverpaymentsEndpoint, Overpayment, OverpaymentsResponse>, IOverpaymentsEndpoint
    {
        public OverpaymentsEndpoint(XeroHttpClient client)
            : this(client, "/api.xro/2.0")
        {
        }

        public OverpaymentsEndpoint(XeroHttpClient client, string endpointResponse)
            : base(client, $"{endpointResponse}/Overpayments")
        {
        }

        public IOverpaymentsEndpoint Page(int page)
        {
            return AddParameter("page", page);
        }
    }
}
