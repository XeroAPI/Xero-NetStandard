using System;
using NUnit.Framework;
using Xero.Api.Payroll.America.Model;
using Xero.Api.Payroll.America.Model.Types;

namespace PayrollTests.US.Integration.PaySchedules
{
    [TestFixture]
    public class Create : ApiWrapperTest
    {
        [Test]
        public void create_payschedule()
        {
            Assert.DoesNotThrowAsync(() => Api.CreateAsync(new PaySchedule
            {
                Name = "New Schedule",
                ScheduleType = ScheduleType.Weekly,
                StartDate = DateTime.Today,
                PaymentDate = DateTime.Today.AddDays(8)
            }));
        }

    }
}
