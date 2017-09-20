using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Payroll.Australia.Model;
using Xero.Api.Payroll.Australia.Model.Types;

namespace PayrollTests.AU.Integration.PayrollCalendars
{
    [TestFixture]
    public class Create : ApiWrapperTest
    {
        [Test]
        public async Task create_payroll_calendar()
        {
            var pc = await Api.CreateAsync(new PayrollCalendar
            {
                Name = "New Calendar",
                CalendarType = CalendarType.Weekly,
                StartDate = DateTime.Today,
                PaymentDate = DateTime.Today.AddDays(14)
            });

            Assert.IsTrue(pc.Id != Guid.Empty);
        }
    }
}
