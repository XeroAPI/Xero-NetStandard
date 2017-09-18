using NUnit.Framework;
using Xero.Api.Core.Model.Types;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Serialization;

namespace CoreTests.Unit
{
    [TestFixture]
    public class SalesTaxPeriodTypeTest
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
            const SalesTaxPeriodType expected = SalesTaxPeriodType.Quarterly;

            Assert.True(expected == _mapper.From<SalesTaxPeriodType>("QUARTERLY"));
            Assert.True(expected == _mapper.From<SalesTaxPeriodType>("QuarterLY"));
            Assert.True(expected == _mapper.From<SalesTaxPeriodType>("quarterly"));
        }

        [Test]
        public void monthly_options()
        {
            const SalesTaxPeriodType expected = SalesTaxPeriodType.Monthly;

            Assert.True(expected == _mapper.From<SalesTaxPeriodType>("MONTHLY"));
            Assert.True(expected == _mapper.From<SalesTaxPeriodType>("ONEMONTHS"));
            Assert.True(expected == _mapper.From<SalesTaxPeriodType>("1MONTHLY"));
        }

        [Test]
        public void two_monthly_options()
        {
            const SalesTaxPeriodType expected = SalesTaxPeriodType.TwoMonths;

            Assert.True(expected == _mapper.From<SalesTaxPeriodType>("2MONTHLY"));
            Assert.True(expected == _mapper.From<SalesTaxPeriodType>("TWOMONTHS"));            
        }

        [Test]
        public void annual_options()
        {
            const SalesTaxPeriodType expected = SalesTaxPeriodType.Annually;

            Assert.True(expected == _mapper.From<SalesTaxPeriodType>("YEARLY"));
            Assert.True(expected == _mapper.From<SalesTaxPeriodType>("ANNUALLY"));
        }

        [Test]
        public void semi_annual_options()
        {
            const SalesTaxPeriodType expected = SalesTaxPeriodType.SixMonths;

            Assert.True(expected == _mapper.From<SalesTaxPeriodType>("6MONTHLY"));
            Assert.True(expected == _mapper.From<SalesTaxPeriodType>("SIXMONTHS"));
        }

        [Test]
        public void quarterly_options()
        {
            const SalesTaxPeriodType expected = SalesTaxPeriodType.Quarterly;

            Assert.True(expected == _mapper.From<SalesTaxPeriodType>("3MONTHLY"));
            Assert.True(expected == _mapper.From<SalesTaxPeriodType>("QUARTERLY"));
            Assert.True(SalesTaxPeriodType.QuarterlyOne == _mapper.From<SalesTaxPeriodType>("QUARTERLY1"));
            Assert.True(SalesTaxPeriodType.QuarterlyTwo == _mapper.From<SalesTaxPeriodType>("QUARTERLY2"));
            Assert.True(SalesTaxPeriodType.QuarterlyThree == _mapper.From<SalesTaxPeriodType>("QUARTERLY3"));
        }
    }
}
