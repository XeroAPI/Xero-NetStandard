using System;
using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Payroll.Australia.Model;
using Xero.Api.Payroll.Australia.Model.Types;

namespace PayrollTests.AU.Integration.Employees
{
    public abstract class EmployeesTest : ApiWrapperTest
    {
        protected async Task<Employee> Given_an_employee(bool terminated = false)
        {
            var employee = await Api.CreateAsync(new Employee
            {
                FirstName = "John " + Guid.NewGuid().ToString("N"),
                LastName = "Smith",
                TerminationDate = terminated ? (DateTime?)DateTime.Now.Date : null
            });

            return employee;
        }

        protected async Task<Employee> given_terminated_employee()
        {
            return await Given_an_employee(true);
        }

        protected async Task<Guid> earnings_rate_id()
        {
            return (await Api.PayItems.FindAsync()).FirstOrDefault().EarningsRates.FirstOrDefault().Id;
        }


        protected async Task<Guid> deduction_type_id()
        {
            return (await Api.PayItems.FindAsync()).FirstOrDefault().DeductionTypes.FirstOrDefault().Id;
        }

        protected async Task<Guid> reimbersment_type_id()
        {
            return (await Api.PayItems.FindAsync()).FirstOrDefault().ReimbursementTypes.FirstOrDefault().Id;
        }


        protected async Task<Guid> leave_type_id()
        {
            return (await Api.PayItems.FindAsync()).FirstOrDefault().LeaveTypes.FirstOrDefault().Id;
        }


        protected async Task<Guid> super_fund_id()
        {
            var sf = await Api.SuperFunds.FindAsync();
            
            if (sf.FirstOrDefault().Id != Guid.Empty)
            {
                return sf.FirstOrDefault().Id;
            }
            else
            {
                return (await Api.CreateAsync(new SuperFund
                {
                    Type = SuperfundType.Regulated,
                    Abn = "78984178687",
                })).Id;
            }
        }

    }
}
