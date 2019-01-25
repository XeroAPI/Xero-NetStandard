using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Core.Model;

namespace Xero.Api.Core.Response
{
    public class BatchPaymentsResponse : XeroResponse<BatchPayment>
    {
        public List<BatchPayment> BatchPayments { get; set; }

        public override IList<BatchPayment> Values
        {
            get { return BatchPayments; }
        }
    }
}