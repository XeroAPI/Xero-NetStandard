using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Payroll.Australia.Model;
using Xero.Api.Payroll.Australia.Model.Types;

namespace PayrollTests.AU.Integration.SuperFunds
{
    [TestFixture]
    public class Update : ApiWrapperTest
    {
        [Test]
        public async Task update_superfund()
        {
            var sf = await Api.CreateAsync(new SuperFund
            {
                Type = SuperfundType.SelfManaged,
                Abn = "01001032511",
                Name = "Clive Monk Superannuation Fund",
                BankStateBranch = "159357",
                AccountName = "Clive Monk Superannuation Fund",
                AccountNumber = "111222333",
            });

            Assert.DoesNotThrowAsync(() => Api.UpdateAsync(new SuperFund
            {
                Id = sf.Id,
                Type = SuperfundType.SelfManaged,
                Abn = "11001032511",
                Name = "Clive Superannuation Fund",
                BankStateBranch = "059357",
                AccountName = "Test",
                AccountNumber = "654645645",
            }));

        }
    }
}
