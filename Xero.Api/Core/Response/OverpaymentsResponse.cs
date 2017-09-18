using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Core.Model;

namespace Xero.Api.Core.Response
{
    public class OverpaymentsResponse : XeroResponse<Overpayment>
    {
        public IList<Overpayment> Overpayments { get; set; }


        public override IList<Overpayment> Values
        {
            get { return Overpayments; }
        }
    }
}