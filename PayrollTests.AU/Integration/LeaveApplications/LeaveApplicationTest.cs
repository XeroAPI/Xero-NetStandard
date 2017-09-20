using System;
using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Payroll.Australia.Model;

namespace PayrollTests.AU.Integration.LeaveApplications
{
    public abstract class LeaveApplicationTest :ApiWrapperTest
    {

        public async Task<LeaveApplication> Given_a_leave_application()
        {
            return await Api.CreateAsync(new LeaveApplication
            {
                EmployeeId = (await Given_an_employee()).Id,
                LeaveTypeId = await the_leavetype_id(),
                Title = "Annual",
                StartDate = DateTime.Today.AddDays(2),
                EndDate = DateTime.Today.AddDays(4),
            });
        }

        public async Task<Employee> Given_an_employee()
        {
            return await Api.CreateAsync(new Employee
            {
                FirstName = "Keith " + Guid.NewGuid().ToString("N"),
                LastName = "Morgan",
                PayrollCalendarID = await employee_payroll_calendar_id(),
                OrdinaryEarningsRateID = await earning_rates_id()
            });
        }



        public async Task<Guid> the_leavetype_id()
        {
            return (await Api.PayItems.FindAsync()).FirstOrDefault().LeaveTypes.FirstOrDefault().Id;
        }



        public async Task<Guid> employee_payroll_calendar_id()
        {
            var payruns = await Api.PayRuns.Where("PayRunStatus == \"DRAFT\"").FindAsync();
            if (payruns.FirstOrDefault().Id != Guid.Empty)
            {
                return payruns.FirstOrDefault().PayrollCalendarId;
            }
            else
            {
                var payroll_calendar_id = (await Api.PayrollCalendars.FindAsync()).First().Id;
                await Api.CreateAsync(new PayRun
                {
                    PayrollCalendarId = payroll_calendar_id
                });
                return payroll_calendar_id;
            }
        }



        public async Task<Guid> earning_rates_id()
        {
            var er = await Api.PayItems.FindAsync();
            return er.FirstOrDefault().EarningsRates.FirstOrDefault().Id;
        }

    }
}
