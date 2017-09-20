using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.TaxRates
{
    [TestFixture]
    public class Create : TaxRateTest
    {
        [Test]
        public async Task create_tax_rate()
        {
            var name = Random.GetRandomString(10);
            var state = Random.GetRandomString(5);
            var local = Random.GetRandomString(5);

            const decimal stateRate = 7.5m;
            const decimal localRate = 0.625m;
            const ReportTaxType taxType = ReportTaxType.Input;

            var taxRate = await Given_a_tax_rate(name, taxType, state, stateRate, local, localRate);

            Assert.That(name == taxRate.Name);
            Assert.That(taxType == taxRate.ReportTaxType);

            AssertContainsRate(taxRate, state, stateRate);
            AssertContainsRate(taxRate, local, localRate);
        }

        private void AssertContainsRate(TaxRate taxRate, string name, decimal rate)
        {
            var taxComponent = taxRate.TaxComponents.SingleOrDefault(p => name == p.Name);

            Assert.IsNotNull(taxComponent);
            Assert.AreEqual(taxComponent.Rate, rate);
        }
    }
}
