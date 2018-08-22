using Xero.Api.Common;
using Xero.Api.Core.Model;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IPrepaymentsEndpoint : IXeroReadEndpoint<PrepaymentsEndpoint, Prepayment, PrepaymentsResponse>, IPageableEndpoint<PrepaymentsEndpoint>
    {
    }

    public class PrepaymentsEndpoint : XeroReadEndpoint<PrepaymentsEndpoint, Prepayment, PrepaymentsResponse>, IPrepaymentsEndpoint
    {
        public PrepaymentsEndpoint(XeroHttpClient client)
            : this(client, "/api.xro/2.0")
        {
        }

        public PrepaymentsEndpoint(XeroHttpClient client, string endpointBase)
            : base(client, $"{endpointBase}/Prepayments")
        {
        }

        public PrepaymentsEndpoint Page(int page)
        {
            return AddParameter("page", page);
        }
    }
}
