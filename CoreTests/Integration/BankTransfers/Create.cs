using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.BankTransfers
{
    [TestFixture]
    public class Create : BankTransfersTest
    {
        [Test]
        public async Task create_bank_transfer()
        {
            const decimal expected = 10m;
            var accounts = await get_bankaccount_ids();

            var bankTransfer = await Given_a_bank_transfer(expected);
            
            Assert.AreEqual(expected, bankTransfer.Amount);
            Assert.AreEqual(accounts[0], bankTransfer.FromBankAccount.Id);
            Assert.AreEqual(accounts[1], bankTransfer.ToBankAccount.Id);
        }
    }
}
