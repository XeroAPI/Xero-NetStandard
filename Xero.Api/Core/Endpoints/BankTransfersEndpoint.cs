using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IBankTransfersEndpoint :
        IXeroCreateEndpoint<BankTransfersEndpoint, BankTransfer, BankTransfersRequest, BankTransfersResponse>
    {
        
    }
    public class BankTransfersEndpoint : XeroCreateEndpoint<BankTransfersEndpoint, BankTransfer, BankTransfersRequest, BankTransfersResponse>, 
        IBankTransfersEndpoint
    {
        public BankTransfersEndpoint(XeroHttpClient client)
            : this(client, "/api.xro/2.0")
        {
        }

        public BankTransfersEndpoint(XeroHttpClient client, string endpointBase)
            : base(client, $"{endpointBase}/BankTransfers")
        {
        }
    }
}