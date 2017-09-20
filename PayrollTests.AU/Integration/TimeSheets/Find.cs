using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PayrollTests.AU.Integration.TimeSheets
{
    [TestFixture]
    public class Find : TimesheetTest
    {
        [Test]
        public async Task find_all()
        {
            await Given_a_timesheet();
            var ts = await Api.Timesheets.FindAsync();
            Assert.IsNotNull(ts);
            Assert.IsTrue(ts.FirstOrDefault().Id != Guid.Empty);
        }

        [Test]
        public async Task find_by_id()
        {
            var the_timesheet_id = (await Given_a_timesheet()).Id;
            var ts = await Api.Timesheets.FindAsync(the_timesheet_id);
            Assert.AreEqual(the_timesheet_id, ts.Id);
        }

        [Test]
        public async Task find_by_page()
        {
            await Given_a_timesheet();
            var ts = await Api.Timesheets.Page(1).FindAsync();
            Assert.IsNotNull(ts);
            Assert.IsTrue(ts.FirstOrDefault().Id != Guid.Empty);
        }
    }
}
