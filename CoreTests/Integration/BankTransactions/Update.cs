using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;

namespace CoreTests.Integration.BankTransactions
{
    [TestFixture]
    public class Update : BankTransactionTest
    {
        [Test]
        public async Task update_bank_transaction()
        {
            var bt = await Given_a_bank_transaction();

            var updatedTransaction = await Api.UpdateAsync(new BankTransaction
            {
                Id = bt.Id,
                BankAccount = new Account { Id = await FindBankAccountGuid() },
                LineItems = new List<LineItem>
                    {
                        new LineItem
                        {
                            UnitAmount = 100m,
                            Quantity = 2m,
                            Description = bt.LineItems[0].Description,
                            AccountCode = bt.LineItems[0].AccountCode
                        }
                    }
            });

            Assert.AreEqual(100, updatedTransaction.LineItems[0].UnitAmount);
            Assert.AreEqual(2, updatedTransaction.LineItems[0].Quantity);
            Assert.AreEqual(200, updatedTransaction.LineItems[0].LineAmount);
        }
    }
}
