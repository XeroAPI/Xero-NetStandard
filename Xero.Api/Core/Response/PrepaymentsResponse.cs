using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Core.Model;

namespace Xero.Api.Core.Response
{
    public class PrepaymentsResponse : XeroResponse<Prepayment>
    {
        public IList<Prepayment> Prepayments { get; set; }


        public override IList<Prepayment> Values
        {
            get { return Prepayments; }
        }
    }
}