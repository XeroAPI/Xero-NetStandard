using System;
using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Payroll.Australia.Model;
using Xero.Api.Payroll.Australia.Model.Status;
using Xero.Api.Payroll.Australia.Model.Types;
using PayRun = Xero.Api.Payroll.Australia.Model.PayRun;

namespace PayrollTests.AU.Integration.TimeSheets
{
    public abstract class TimesheetTest : ApiWrapperTest
    {

        public async Task<Timesheet> Given_a_timesheet()
        {
            return await Api.CreateAsync(new Timesheet
            {
                EmployeeId = await the_employee_id(),
                StartDate = await timesheet_start_date(),
                EndDate = (await timesheet_start_date()).AddDays(6),
                Status = TimesheetStatus.Draft
            });
        }




        public async Task<Guid> the_employee_id()
        {
            var emp = await Api.CreateAsync(new Employee
            {
                FirstName = "Jack",
                LastName = "Gray",
                PayrollCalendarID = await employee_payroll_calendar_id(),
                OrdinaryEarningsRateID = await earning_rates_id()
            });
            return emp.Id;
        }



        public async Task<Guid> employee_payroll_calendar_id()
        {
            var payruns = await Api.PayRuns.Where("PayRunStatus == \"DRAFT\"").FindAsync();
            if (payruns.Any())
            {
                return payruns.FirstOrDefault().PayrollCalendarId;
            }
            else
            {
                var payroll_calendar_id = (await Api.CreateAsync(new PayrollCalendar
                {
                    Name = "New Calendar",
                    CalendarType = CalendarType.Weekly,
                    StartDate = DateTime.Today,
                    PaymentDate = DateTime.Today.AddDays(14)
                })).Id;

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



        public async Task<DateTime> timesheet_start_date()
        {
            var calendarId = await employee_payroll_calendar_id();

            return (await Api.PayrollCalendars.FindAsync(calendarId)).StartDate.GetValueOrDefault();
        }


    }
}
