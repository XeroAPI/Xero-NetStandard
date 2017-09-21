using Xero.Api.Common;
using Xero.Api.Core.Model;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IRepeatingInvoicesEndpoint : IXeroReadEndpoint<RepeatingInvoicesEndpoint, RepeatingInvoice, RepeatingInvoicesResponse>
    {
    }

    public class RepeatingInvoicesEndpoint
        : XeroReadEndpoint<RepeatingInvoicesEndpoint, RepeatingInvoice, RepeatingInvoicesResponse>, IRepeatingInvoicesEndpoint
    {
        public RepeatingInvoicesEndpoint(XeroHttpClient client) :
            base(client, "/api.xro/2.0/RepeatingInvoices")
        {
            Apply4Dp(true, false);
        }

        public override void ClearQueryString()
        {
            base.ClearQueryString();
            Apply4Dp(true, false);
        }
    }
}