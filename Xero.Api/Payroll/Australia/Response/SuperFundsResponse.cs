using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Payroll.Australia.Model;

namespace Xero.Api.Payroll.Australia.Response
{
    public class SuperFundsResponse : XeroResponse<SuperFund>
    {
        public IList<SuperFund> SuperFunds { get; set; }

        public override IList<SuperFund> Values
        {
            get { return SuperFunds; }
        }
    }
}