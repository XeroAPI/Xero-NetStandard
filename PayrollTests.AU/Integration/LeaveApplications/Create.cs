using System;
using System.Collections.Generic;
using NUnit.Framework;
using Xero.Api.Payroll.Australia.Model;
using Xero.Api.Payroll.Australia.Model.Status;

namespace PayrollTests.AU.Integration.LeaveApplications
{
    [TestFixture]
    public class Create : LeaveApplicationTest
    {
        [Test]
        public void create_leave_application()
        {
            var la = Api.Create(new LeaveApplication
            {
                EmployeeId = Given_an_employee().Id,
                LeaveTypeId = the_leavetype_id(),
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
