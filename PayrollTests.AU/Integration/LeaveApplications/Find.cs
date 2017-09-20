using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PayrollTests.AU.Integration.LeaveApplications
{
    [TestFixture]
    public class Find : LeaveApplicationTest
    {
        [Test]
        public async Task find_all()
        {
            await Given_a_leave_application();
            var la = await Api.LeaveApplications.FindAsync();
            Assert.IsTrue(la.FirstOrDefault().Id != Guid.Empty);
        }


        [Test]
        public async Task find_by_id()
        {
            var the_la_id = (await Given_a_leave_application()).Id;
            var la = await Api.LeaveApplications.FindAsync(the_la_id);
            Assert.AreEqual(the_la_id, la.Id);
        }


        [Test]
        public async Task find_by_date()
        {
            await Given_a_leave_application();
            var start_date = DateTime.Today;
            var la = await Api.LeaveApplications
                .Where(string.Format("StartDate <= DateTime.Parse(\"{0}\")", start_date.ToString("yyyy-MM-dd"))).FindAsync();
            Assert.IsEmpty(la);

        }

        [Test]
        public async Task find_paged()
        {
            await Given_a_leave_application();
            var la = await Api.LeaveApplications.Page(1).FindAsync();
            Assert.IsTrue(la.FirstOrDefault().Id != Guid.Empty);
        }
    }
}
