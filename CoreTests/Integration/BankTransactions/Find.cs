using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.BankTransactions
{
    [TestFixture]
    public class Find : BankTransactionTest
    {
        [Test]
        public void find_bank_transactions_where_filter()
        {
            Assert.DoesNotThrowAsync(() => Api.BankTransactions
                .Where("Type == \"SPEND\"")
                .And("Status == \"AUTHORISED\"")
                .FindAsync());
        }

        [Test]
        public async Task find_bank_transactions_ifmodifiedsince()
        {
            await Given_a_bank_transaction();

            var bankTransaction = await Api.BankTransactions
                .ModifiedSince(DateTime.Today.AddDays(-1).Date)
                .FindAsync();

            Assert.IsNotNull(bankTransaction);
        }

        [Test]
        public async Task find_bank_transactions_individual()
        {
            var expected = (await Given_a_bank_transaction()).Id;

            var id = (await Api.BankTransactions.FindAsync(expected)).Id;

            Assert.AreEqual(expected, id);
        }

        [Test]
        public async Task find_by_page()
        {
            await Given_a_bank_transaction();
            var bankTrans = await Api.BankTransactions.Page(1).FindAsync();

            Assert.Greater(bankTrans.Count(), 0);
        }
    }
}
