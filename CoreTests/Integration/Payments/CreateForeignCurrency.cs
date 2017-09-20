using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.Payments
{
    [TestFixture]
    public class CreateForeignCurrency : PaymentsTest
    {
        private Account Foreign { get; set; }

        [OneTimeSetUp]
        [Ignore("The user needs to have foreign currency subscription on their account")]
        public async Task SetUpForeignCurrency()
        {
            await SetUp();
        }

        [Test]
        [Ignore("The user needs to have foreign currency subscription on their account")]
        public async Task create_refund_on_credit_note_with_foreign_currency()
        {
            Foreign = await Given_a_foreign_currency_account();

            const int amount = 50;
            var accountCode = Account.Code;
            var note = await Given_an_credit_note(amount, accountCode);
            var date = DateTime.UtcNow;
            const string reference = "Full refund as we couldn't replace item";

            var payment = await Api.CreateAsync(new Payment
            {
                CreditNote = new CreditNote { Number = note.Number },
                Account = new Account { Code = Foreign.Code },
                CurrencyRate = 0.8m,
                Date = date,
                Amount = amount,
                Reference = reference
            });

            Assert.AreEqual(reference, payment.Reference);
            Assert.AreEqual(amount, payment.Amount);
        }

        private async Task<Account> Given_a_foreign_currency_account()
        {
            return (await Api.Accounts
                .Where("Type == \"BANK\"")
                .And("CurrencyCode != \"NZD\"")
                .FindAsync())
                .FirstOrDefault() 
                ??
                await Create_foreign_currency_account();
        }

        private async Task<Account> Create_foreign_currency_account()
        {
            return await Api.CreateAsync(new Account
            {
                Code = Random.GetRandomString(10),
                Name = "Foreign Currency",
                CurrencyCode = "AUD",
                BankAccountNumber = "121-121-1234567",
                Type = AccountType.Bank
            });
        }

    }
}