using System;
using System.Linq;
using Xero.Api.Payroll.Australia.Model;
using Xero.Api.Payroll.Australia.Model.Status;
using Xero.Api.Payroll.Australia.Model.Types;
using PayRun = Xero.Api.Payroll.Australia.Model.PayRun;

namespace PayrollTests.AU.Integration.TimeSheets
{
    public abstract class TimesheetTest : ApiWrapperTest
    {

        public Timesheet Given_a_timesheet()
        {
            return Api.Create(new Timesheet
            {
                EmployeeId = the_employee_id(),
                StartDate = timesheet_start_date(),
                EndDate = timesheet_start_date().AddDays(6),
                Status = TimesheetStatus.Draft
            });
        }




        public Guid the_employee_id()
        {
            var emp = Api.Create(new Employee
            {
                FirstName = "Jack",
                LastName = "Gray",
                PayrollCalendarID = employee_payroll_calendar_id(),
                OrdinaryEarningsRateID = earning_rates_id()
            });
            return emp.Id;
        }



        public Guid employee_payroll_calendar_id()
        {
            var payruns = Api.PayRuns.Where("PayRunStatus == \"DRAFT\"").Find();
            if (payruns.Any())
            {
                return payruns.FirstOrDefault().PayrollCalendarId;
            }
            else
            {
                var payroll_calendar_id = Api.Create(new PayrollCalendar
                {
                    Name = "New Calendar",
                    CalendarType = CalendarType.Weekly,
                    StartDate = DateTime.Today,
                    PaymentDate = DateTime.Today.AddDays(14)
                }).Id;

                Api.Create(new PayRun
                  {
                      PayrollCalendarId = payroll_calendar_id
                  });
                return payroll_calendar_id;
            }
        }



        public Guid earning_rates_id()
        {
            var er = Api.PayItems.Find();
            return er.FirstOrDefault().EarningsRates.FirstOrDefault().Id;
        }



        public DateTime timesheet_start_date()
        {
            return Api.PayrollCalendars.Find(employee_payroll_calendar_id()).StartDate.GetValueOrDefault();
        }


    }
}
