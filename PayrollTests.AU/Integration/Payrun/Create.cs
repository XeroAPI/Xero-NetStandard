using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Payroll.Australia.Model;
using Xero.Api.Payroll.Australia.Model.Types;
using Xero.Api.Payroll.Common.Model.Status;

namespace PayrollTests.AU.Integration.Payrun
{
    [TestFixture]
    public class Create : PayrunTest
    {
        [Test]
        public async Task create_scheduled_payrun()
        {
            var payrun = await Api.CreateAsync(new PayRun
            {
                PayrollCalendarId = await the_payroll_calendar_id()
            });
            Assert.True(payrun.Id != Guid.Empty);
        }



        [Test]
        public async Task create_unscheduled_payrun()
        {
            var payrun = await Api.CreateAsync(new PayRun
            {
                PayrollCalendarId = await the_payroll_calendar_id(),
                PayRunPeriodEndDate = DateTime.Today.AddDays(12)
            });
            Assert.True(payrun.Id != Guid.Empty);
        }



        [Test]
        public async Task post_payrun()
        {
            var payroll_calendar_id = (await Api.CreateAsync(new PayrollCalendar
            {
                Name = "Weekly Calendar",
                CalendarType = CalendarType.Weekly,
                StartDate = DateTime.Today,
                PaymentDate = DateTime.Today.AddDays(7)
            })).Id;

            var payrun = await Api.CreateAsync(new PayRun
            {
                PayrollCalendarId = payroll_calendar_id,
                PayRunPeriodEndDate = DateTime.Today.AddDays(13),
                PayRunStatus = PayRunStatus.Posted
            });
            Assert.True(payrun.Id != Guid.Empty);
        }

    }
}
