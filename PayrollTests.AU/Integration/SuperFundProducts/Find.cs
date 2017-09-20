using NUnit.Framework;

namespace PayrollTests.AU.Integration.SuperFundProducts
{
    [TestFixture]
    public class Find : ApiWrapperTest
    {
        [Test]
        public void find_all()
        {
            var sfp = Api.SuperFundProducts.FindAsync();
            Assert.IsNotNull(sfp);
        }

        [Test]
        public void find_by_page()
        {
            var sfp = Api.SuperFundProducts.FindAsync();
            Assert.IsNotNull(sfp);
        }
    }
}
