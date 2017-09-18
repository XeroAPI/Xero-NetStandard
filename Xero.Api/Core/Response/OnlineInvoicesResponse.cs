using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Core.Model;

namespace Xero.Api.Core.Response
{
    public class OnlineInvoicesResponse : XeroResponse<OnlineInvoice>
    {
        public List<OnlineInvoice> OnlineInvoices { get; set; }

        public override IList<OnlineInvoice> Values
        {
            get { return OnlineInvoices; }
        }
    }
}