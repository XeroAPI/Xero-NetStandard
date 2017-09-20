using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Payroll.Australia.Model;
using Xero.Api.Payroll.Australia.Model.Types;

namespace PayrollTests.AU.Integration.SuperFunds
{
    [TestFixture]
    public class Create : ApiWrapperTest
    {
        [Test]
        public async Task create_superfund()
        {
            var sf = await Api.CreateAsync(new SuperFund
            {
                Type = SuperfundType.Regulated,
                Abn = "08984178687",
            });

            Assert.IsTrue(sf.Id != Guid.Empty);
        }
    }
}
