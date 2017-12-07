using NUnit.Framework;

namespace PayrollTests.AU.Integration.PayItems
{
    [TestFixture]
    public class Find : ApiWrapperTest
    {
        [Test]
        public async void find_all()
        {
            var items = await Api.PayItems.FindAsync();
            Assert.IsNotNull(items);
        }

        [Test]
        public async void find_paged()
        {
            var items = await Api.PayItems.Page(1).FindAsync();
            Assert.IsNotNull(items);
        }

        [Test]
        public async void Find_EarningRates()
        {
            var items = await Api.PayItems.FindAsync();

            foreach (var payItem in items)
            {
                Assert.IsNotNull(payItem.EarningsRates);
            }
        }
    }
}
