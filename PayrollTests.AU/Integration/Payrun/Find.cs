using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PayrollTests.AU.Integration.Payrun
{
    [TestFixture]
    public class Find : PayrunTest
    {
        [Test]
        public async Task find_all()
        {
            await Given_a_payrun();
            var payruns = await Api.PayRuns.FindAsync();
            Assert.IsNotNull(payruns);
            Assert.IsTrue(payruns.FirstOrDefault().Id != Guid.Empty);
        }
        
        [Test]
        public async Task find_by_id()
        {
            var the_pr_id = (await Given_a_payrun()).Id;
            var payrun = await Api.PayRuns.FindAsync(the_pr_id);
            Assert.AreEqual(the_pr_id, payrun.Id);
        }

        [Test]
        public async Task find_paged()
        {
            await Given_a_payrun();
            var payruns = await Api.PayRuns.Page(1).FindAsync();
            Assert.IsNotNull(payruns);
            Assert.IsTrue(payruns.FirstOrDefault().Id != Guid.Empty);
        }
    }
}
