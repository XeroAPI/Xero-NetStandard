using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.BankTransactions
{
    [TestFixture]
    public class Create : BankTransactionTest
    {
        [Test]
        public async Task create_bank_transactions()
        {
            var name = (await Given_a_bank_transaction())
                .Contact
                .Name;

            Assert.AreEqual("ABC Bank", name);
        }
    }
}
