using System;
using System.Linq;
using NUnit.Framework;

namespace PayrollTests.AU.Integration.TimeSheets
{
    [TestFixture]public class Find : TimesheetTest
    {
        [Test]
        public void find_all()
        {
            Given_a_timesheet();
            var ts = Api.Timesheets.Find();
            Assert.IsNotNull(ts);
            Assert.IsTrue(ts.FirstOrDefault().Id != Guid.Empty);
        }

        [Test]
        public void find_by_id()
        {
            var the_timesheet_id=Given_a_timesheet().Id;
            var ts = Api.Timesheets.Find(the_timesheet_id);
            Assert.AreEqual(the_timesheet_id, ts.Id);
        }

        [Test]
        public void find_by_page()
        {
            Given_a_timesheet();
            var ts = Api.Timesheets.Page(1).Find();
            Assert.IsNotNull(ts);
            Assert.IsTrue(ts.FirstOrDefault().Id != Guid.Empty);
        }
    }
}
