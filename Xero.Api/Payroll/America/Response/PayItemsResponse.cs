using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Payroll.America.Model;

namespace Xero.Api.Payroll.America.Response
{
    public class PayItemsResponse : XeroResponse<PayItems>
    {
        public IList<PayItems> PayItems { get; set; }

        public override IList<PayItems> Values
        {
            get { return PayItems; }
        }
    }
}