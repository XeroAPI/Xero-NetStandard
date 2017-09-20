using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PayrollTests.AU.Integration.PayItems
{
    [TestFixture]
    public class Create : PayItemsTest
    {
        [Test]
        public async Task create_payitem()
        {
            var pi = await Given_some_payitems();
            Assert.Contains("Ordinary Hours", pi.EarningsRates.Select(p => p.Name).ToList());
            Assert.Contains("Union Fees", pi.DeductionTypes.Select(p => p.Name).ToList());
            Assert.Contains("Annual Leave", pi.LeaveTypes.Select(p => p.Name).ToList());
            Assert.Contains("Travel National Costs", pi.ReimbursementTypes.Select(p => p.Name).ToList());
        }
    }
}
