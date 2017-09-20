using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PayrollTests.US.Integration.PaySchedules
{
    [TestFixture]
    public class Find : PaySchedulesTest
    {
        [Test]
        public async Task find_all()
        {
            await Given_a_payschedule();
            var ps = await Api.PaySchedules.FindAsync();
            Assert.IsTrue(ps.FirstOrDefault().Id != Guid.Empty);
        }

        [Test]
        public async Task find_by_page()
        {
            await Given_a_payschedule();
            var ps = await Api.PaySchedules.Page(1).FindAsync();
            Assert.IsTrue(ps.FirstOrDefault().Id != Guid.Empty);
        }

        [Test]
        public async Task find_by_id()
        {
            var ps_id = (await Given_a_payschedule()).Id;
            var ps = Api.PaySchedules.FindAsync(ps_id);
            Assert.AreEqual(ps_id, ps.Id);
        }
    }
}
