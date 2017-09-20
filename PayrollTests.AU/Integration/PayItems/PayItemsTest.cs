using System.Collections.Generic;
using System.Threading.Tasks;
using Xero.Api.Payroll.Australia.Model;
using Xero.Api.Payroll.Australia.Model.Types;

namespace PayrollTests.AU.Integration.PayItems
{
    public class PayItemsTest : ApiWrapperTest
    {
        public async Task<Xero.Api.Payroll.Australia.Model.PayItems> Given_some_payitems()
        {
            return await Api.CreateAsync(new Xero.Api.Payroll.Australia.Model.PayItems
            {
                DeductionTypes = new List<DeductionType>
                {
                    new DeductionType
                    {
                        Name = "Union Fees",
                        AccountCode = "826",
                        ReducesSuper = false,
                        ReducesTax = false
                    }
                },
                EarningsRates = new List<EarningsRate>
                {
                    new EarningsRate
                    {
                        Name = "Ordinary Hours",
                        AccountCode = "477",
                        AccrueLeave = false,
                        IsExemptFromSuper = false,
                        IsExemptFromTax = false,
                        RateType = RateType.Fixed,
                        TypeOfUnits = "Hours"
                    }
                },
                ReimbursementTypes = new List<ReimbursementType>
                {
                    new ReimbursementType
                    {
                        Name = "Travel National Costs",
                        AccountCode = "493"
                    }
                },
                LeaveTypes = new List<LeaveType>
                {
                    new LeaveType
                    {
                        Name = "Annual Leave",
                        TypeOfUnits = "Hours",
                        IsPaidLeave = true,
                        ShowOnPayslip = true
                    }
                }
            });
        }
    }
}