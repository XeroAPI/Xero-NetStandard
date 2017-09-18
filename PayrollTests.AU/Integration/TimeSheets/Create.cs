using System.Collections.Generic;
using NUnit.Framework;
using Xero.Api.Payroll.Australia.Model.Status;
using Xero.Api.Payroll.Australia.Model;
using Xero.Api.Payroll.Common.Model;

namespace PayrollTests.AU.Integration.TimeSheets
{
    [TestFixture]
    public class Create : TimesheetTest
    {
        [OneTimeSetUp]
        public void CreateSetUp()
        {
            
        }

        [Test]
        public void create_timesheet()
        {
            var timesheet = Api.Create(new Timesheet
            {
                EmployeeId = the_employee_id(),
                StartDate = timesheet_start_date(),
                EndDate = timesheet_start_date().AddDays(6),
                Status = TimesheetStatus.Draft
            });
        }

        [Test]
        public void timesheet_with_lines()
        {
            var timesheet = Api.Create(new Timesheet
            {
                EmployeeId = the_employee_id(),
                StartDate = timesheet_start_date(),
                EndDate = timesheet_start_date().AddDays(6),
                Status = TimesheetStatus.Draft,
                TimesheetLines = new List<TimesheetLine>
                {
                    new TimesheetLine
                    {
                        EarningsRateId = earning_rates_id(),
                        NumberOfUnits = new NumberOfUnits
                        {
                            7.5m, 7.5m, 7.5m, 7.5m, 7.5m, 0, 0
                        }
                    }
                }
            });
        }
    }
}
