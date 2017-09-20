using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.Overpayments
{
    [TestFixture]
    public class Find : ApiWrapperTest
    {
        [Test]
        public async Task find_all()
        {
            var overpayments = await Api.Overpayments.FindAsync();
            Assert.Greater(overpayments.Count(), 0);
        }

        [Test]
        public async Task find_all_receive_overpayments()
        {
            var overpayments = await Api.Overpayments.Where("Type == \"RECEIVE-OVERPAYMENT\"").FindAsync();
            Assert.True(overpayments.All(p => p.Type == OverpaymentType.ReceiveOverpayment));
        }

        [Test]
        public async Task find_all_spend_overpayments()
        {
            var overpayments = await Api.Overpayments.Where("Type == \"SPEND-OVERPAYMENT\"").FindAsync();
            Assert.True(overpayments.All(p => p.Type == OverpaymentType.SpendOverpayment));
        }
    }
}
