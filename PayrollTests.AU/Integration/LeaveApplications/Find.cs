using System;
using System.Linq;
using NUnit.Framework;

namespace PayrollTests.AU.Integration.LeaveApplications
{
    [TestFixture]
    public class Find : LeaveApplicationTest
    {
        [Test]
        public void find_all()
        {
            Given_a_leave_application();
            var la = Api.LeaveApplications.Find();
            Assert.IsTrue(la.FirstOrDefault().Id != Guid.Empty);
        }


        [Test]
        public void find_by_id()
        {
            var the_la_id = Given_a_leave_application().Id;
            var la = Api.LeaveApplications.Find(the_la_id);
            Assert.AreEqual(the_la_id, la.Id);
        }


        [Test]
        public void find_by_date()
        {
            var the_la = Given_a_leave_application();
            var start_date = DateTime.Today;
            var la = Api.LeaveApplications
                .Where(string.Format("StartDate <= DateTime.Parse(\"{0}\")", start_date.ToString("yyyy-MM-dd"))).Find();
            Assert.IsEmpty(la);

        }

        [Test]
        public void find_paged()
        {
            Given_a_leave_application();
            var la = Api.LeaveApplications.Page(1).Find();
            Assert.IsTrue(la.FirstOrDefault().Id != Guid.Empty);
        }
    }
}
