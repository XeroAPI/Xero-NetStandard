using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Payroll.Australia.Model;
using Xero.Api.Payroll.Australia.Model.Status;

namespace PayrollTests.AU.Integration.LeaveApplications
{
    [TestFixture]
    public class Create : LeaveApplicationTest
    {
        [Test]
        public async Task create_leave_application()
        {
            var la = await Api.CreateAsync(new LeaveApplication
            {
                EmployeeId = (await Given_an_employee()).Id,
                LeaveTypeId = await the_leavetype_id(),
                Title = "Annual",
                StartDate = DateTime.Today.AddDays(2),
                EndDate = DateTime.Today.AddDays(4),
                LeavePeriods = new List<LeavePeriod>
                {
                    new LeavePeriod
                    {
                        PayPeriodStartDate = DateTime.Today.AddDays(-5),
                        PayPeriodEndDate = DateTime.Today.AddDays(9),
                        NumberOfUnits = 5,
                        LeavePeriodStatus = LeavePeriodStatus.Processed
                    }
                }
            });

            Assert.IsTrue(la.Id != Guid.Empty);
        }
    }
}
