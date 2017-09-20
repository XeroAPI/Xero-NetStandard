using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.Prepayments
{
    [TestFixture]
    public class Find : ApiWrapperTest
    {
        [Test]
        public async Task find_all()
        {
            var prepayments = await Api.Prepayments.FindAsync();
            Assert.Greater(prepayments.Count(), 0);
        }

        [Test]
        public async Task find_all_receive_prepayments()
        {
            var prepayments = await Api.Prepayments.Where("Type == \"RECEIVE-PREPAYMENT\"").FindAsync();
            Assert.True(prepayments.All(p => p.Type == PrepaymentType.ReceivePrepayment));
        }

        [Test]
        public async Task find_all_spend_prepayments()
        {
            var prepayments = await Api.Prepayments.Where("Type == \"SPEND-PREPAYMENT\"").FindAsync();
            Assert.True(prepayments.All(p => p.Type == PrepaymentType.SpendPrepayment));
        }
    }
}
