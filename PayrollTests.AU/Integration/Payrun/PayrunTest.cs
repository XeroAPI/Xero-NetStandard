using System;
using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Payroll.Australia.Model;
using Xero.Api.Payroll.Australia.Model.Types;

namespace PayrollTests.AU.Integration.Payrun
{
    public abstract class PayrunTest : ApiWrapperTest
    {

        public async Task<PayRun> Given_a_payrun()
        {
            return await Api.CreateAsync(new PayRun
            {
                PayrollCalendarId = await the_payroll_calendar_id(),
            });
        }



        public async Task<Guid> the_payroll_calendar_id()
        {
            var pc = await Api.PayrollCalendars.FindAsync();
            if (pc.FirstOrDefault().Id != Guid.Empty)
            {
                return pc.FirstOrDefault().Id;
            }
            else
            {
                return (await Api.CreateAsync(new PayrollCalendar
                {
                    Name = "New Calendar",
                    CalendarType = CalendarType.Weekly,
                    StartDate = DateTime.Today,
                    PaymentDate = DateTime.Today.AddDays(7)
                })).Id;
            }
        }

    }
}
