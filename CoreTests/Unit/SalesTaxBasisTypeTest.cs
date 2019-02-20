using NUnit.Framework;
using Xero.Api.Core.Model.Types;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Serialization;

namespace CoreTests.Unit
{
    [TestFixture]
    public class SalesTaxBasisTypeTest
    {
        private IJsonObjectMapper _mapper;

        [OneTimeSetUp]
        public void SetUp()
        {
            _mapper = new DefaultMapper();
        }

        [Test]
        public void is_case_insensitive()
        {
            const SalesTaxBasisType expected = SalesTaxBasisType.Accural;

            Assert.True(expected == _mapper.From<SalesTaxBasisType>("accural"));
            Assert.True(expected == _mapper.From<SalesTaxBasisType>("AccuRAL"));
            Assert.True(expected == _mapper.From<SalesTaxBasisType>("ACCURAL"));
        }

        [Test]
        public void accrual_options()
        {
            const SalesTaxBasisType expected = SalesTaxBasisType.Accural;

            Assert.True(expected == _mapper.From<SalesTaxBasisType>("ACCURAL"));
            Assert.True(expected == _mapper.From<SalesTaxBasisType>("ACCURALS"));
            Assert.True(expected == _mapper.From<SalesTaxBasisType>("ACCRUALS"));
        }

        [Test]
        public void cash_options()
        {
            Test(SalesTaxBasisType.Cash, "CASH");
        }

        [Test]
        public void flat_rate_accrual_options()
        {
            Test(SalesTaxBasisType.FlatRateAccrual, "FlatRateAccrual");
        }

        [Test]
        public void flat_rate_cash_options()
        {
            Test(SalesTaxBasisType.FlatRateCash, "FlatRateCash");
        }

        [Test]
        public void invoice_options()
        {
            Test(SalesTaxBasisType.Invoice, "Invoice");
        }

        [Test]
        public void none_options()
        {
            Test(SalesTaxBasisType.None, "NONE");
        }

        [Test]
        public void payments_options()
        {
            Test(SalesTaxBasisType.Payments, "Payments");
        }

        private void Test(SalesTaxBasisType type, string value)
        {
            Assert.True(type == _mapper.From<SalesTaxBasisType>(value));
        }
    }
}