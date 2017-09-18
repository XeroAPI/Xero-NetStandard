using System;
using System.Linq;
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
        public void SetUpForeignCurrency()
        {
            SetUp();
        }

        [Test]
        [Ignore("The user needs to have foreign currency subscription on their account")]
        public void create_refund_on_credit_note_with_foreign_currency()
        {
            Foreign = Given_a_foreign_currency_account();

            const int amount = 50;
            var accountCode = Account.Code;
            var note = Given_an_credit_note(amount, accountCode);
            var date = DateTime.UtcNow;
            const string reference = "Full refund as we couldn't replace item";

            var payment = Api.Create(new Payment
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

        private Account Given_a_foreign_currency_account()
        {
            return Api.Accounts
                .Where("Type == \"BANK\"")
                .And("CurrencyCode != \"NZD\"")
                .Find().FirstOrDefault() ??
                   Create_foreign_currency_account();
        }

        private Account Create_foreign_currency_account()
        {
            return Api.Create(new Account
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