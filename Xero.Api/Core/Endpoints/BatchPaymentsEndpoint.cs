using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IBatchPaymentsEndpoint
        : IXeroCreateEndpoint<BatchPaymentsEndpoint, BatchPayment, BatchPaymentsRequest, BatchPaymentsResponse>
    {

    }

    public class BatchPaymentsEndpoint
        : XeroCreateEndpoint<BatchPaymentsEndpoint, BatchPayment, BatchPaymentsRequest, BatchPaymentsResponse>, IBatchPaymentsEndpoint
    {
        public BatchPaymentsEndpoint(XeroHttpClient client) :
            base(client, "/api.xro/2.0/BatchPayments")
        {
        }
    }
}