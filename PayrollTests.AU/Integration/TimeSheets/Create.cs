using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task create_timesheet()
        {
            var timesheet = await Api.CreateAsync(new Timesheet
            {
                EmployeeId = await the_employee_id(),
                StartDate = await timesheet_start_date(),
                EndDate = (await timesheet_start_date()).AddDays(6),
                Status = TimesheetStatus.Draft
            });
        }

        [Test]
        public async Task timesheet_with_lines()
        {
            var employeeId = await the_employee_id();
            var timesheetStartDate = await timesheet_start_date();
            var earningsRateId = await earning_rates_id();

            Assert.DoesNotThrowAsync(() => Api.CreateAsync(new Timesheet
            {
                EmployeeId = employeeId,
                StartDate = timesheetStartDate,
                EndDate = timesheetStartDate.AddDays(6),
                Status = TimesheetStatus.Draft,
                TimesheetLines = new List<TimesheetLine>
                {
                    new TimesheetLine
                    {
                        EarningsRateId = earningsRateId,
                        NumberOfUnits = new NumberOfUnits
                        {
                            7.5m, 7.5m, 7.5m, 7.5m, 7.5m, 0, 0
                        }
                    }
                }
            }));
        }
    }
}
