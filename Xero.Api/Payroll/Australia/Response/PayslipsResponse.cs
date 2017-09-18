using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Payroll.Australia.Model;

namespace Xero.Api.Payroll.Australia.Response
{
    public class PayslipsResponse : XeroResponse<Payslip>
    {
		//When getting a single payslip xero payroll binds to just payslip
        public IList<Payslip> Payslip { get; set; }

		//When updating payslips xero payroll binds to payslips
        public IList<Payslip> Payslips { get; set; }

        public override IList<Payslip> Values
        {
            get { return Payslip ?? Payslips; }
        }
    }
}