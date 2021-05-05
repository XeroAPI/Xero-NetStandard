using Xero.Api.Common;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IPaymentsEndpoint : IXeroUpdateEndpoint<PaymentsEndpoint, Payment, PaymentsRequest, PaymentsResponse>, IPageableEndpoint<IPaymentsEndpoint>
    {

    }

    public class PaymentsEndpoint
        : FourDecimalPlacesEndpoint<PaymentsEndpoint, Payment, PaymentsRequest, PaymentsResponse>, IPaymentsEndpoint
    {
        public PaymentsEndpoint(XeroHttpClient client) :
            this(client, "/api.xro/2.0")
        {
        }

        public PaymentsEndpoint(XeroHttpClient client, string endpointBase) :
            base(client, $"{endpointBase}/Payments")
        {
        }

        public IPaymentsEndpoint Page(int page)
        {
            return AddParameter("page", page);
        }
    }
}