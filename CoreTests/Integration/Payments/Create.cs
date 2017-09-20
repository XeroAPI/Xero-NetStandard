using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;

namespace CoreTests.Integration.Payments
{
    [TestFixture]
    public class Create : PaymentsTest
    {
        [OneTimeSetUp]
        public async Task CreatePaymentsSetUp()
        {
            await SetUp();
        }

        [Test]
        public async Task create_simple_payment()
        {
            var date = DateTime.UtcNow;
            const decimal expected = 32.6m;
            const decimal invoiceAmount = 100;

            var payment = await Given_a_payment(invoiceAmount, date, expected);

            Assert.AreEqual(expected, payment.Amount);
        }

        [Test]
        public async Task create_multiple_payments()
        {
            var date = DateTime.UtcNow;

            var payments = (await Api.CreateAsync(
                new List<Payment>
                {
                    await CreatePayment(4000, date, 3375),
                    await CreatePayment(393.75m, date, 393.75m),
                    await CreatePayment(450, date, 398),
                })).ToList();

            Assert.AreEqual(3, payments.Count());

            Assert.IsNotNull(payments.Single(p => p.Amount == 393.75m));
            Assert.IsNotNull(payments.Single(p => p.Amount == 3375));
            Assert.IsNotNull(payments.Single(p => p.Amount == 398));
        }

        [Test]
        public async Task create_reconciled_payment()
        {
            var date = DateTime.UtcNow;
            const decimal amount = 32.6m;
            const decimal invoiceAmount = 32.6m;
            
            var payment = await Api.CreateAsync(await CreatePayment(invoiceAmount, date, amount, true));

            Assert.AreEqual(amount, payment.Amount);
            Assert.True(payment.IsReconciled.HasValue);
            Assert.True(payment.IsReconciled.Value);
        }

        [Test]
        public async Task create_refund_on_credit_note()
        {
            const int amount = 50;
            var note = await Given_an_credit_note(amount, Account.Code);
            var date = DateTime.UtcNow;
            const string reference = "Full refund as we couldn't replace item";

            var payment = await Api.CreateAsync(new Payment
            {
                CreditNote = new CreditNote { Number = note.Number },
                Account = new Account { Code = BankAccount.Code },
                Date = date,
                Amount = amount,
                Reference = reference
            });

            Assert.AreEqual(reference, payment.Reference);
            Assert.AreEqual(amount, payment.Amount);
        }

        [Test]
        public async Task create_refund_on_Prepayment()
        {
            const int amount = 50;
            var transaction = await Given_a_prepayment(BankAccount.Code, amount, Account.Code);
            var date = DateTime.UtcNow;
            const string reference = "Full refund on the prepayment";

            //NOTE: When refunding a prepayment, you create the payment with a Prepayment object (payment.Prepayment). The resulting payment will have the Prepayment stored as an Invoice eg. payment.Invoice rather than payment.Prepayment
            var payment = await Api.CreateAsync(new Payment
            {
                Prepayment = new Prepayment { Id = transaction.PrepaymentID.GetValueOrDefault() },
                Account = new Account { Code = BankAccount.Code },
                Date = date,
                Amount = amount,
                Reference = reference
            });

            Assert.AreEqual(reference, payment.Reference);
            Assert.AreEqual(amount, payment.Amount);
        }

        [Test]
        public async Task create_refund_on_Overpayment()
        {
            //This may differ if you have changed the code of your accounts receivable
            var accountsReceivable = (await Api.Accounts.Where("Code == \"610\"").FindAsync()).First();

            const int amount = 50;
            var transaction = await Given_an_overpayment(BankAccount.Code, amount, accountsReceivable.Code);
            var date = DateTime.UtcNow;
            const string reference = "Full refund on the overpayment";

            //NOTE: When refunding an overpayment, you create the payment with an Overpayment object (payment.Overpayment). The resulting payment will have the Overpayment stored as an Invoice eg. payment.Invoice rather than payment.Overpayment
            var payment = await Api.CreateAsync(new Payment
            {
                Overpayment = new Overpayment { Id = transaction.OverpaymentID.GetValueOrDefault() },
                Account = new Account { Code = BankAccount.Code },
                Date = date,
                Amount = amount,
                Reference = reference
            });

            Assert.AreEqual(reference, payment.Reference);
            Assert.AreEqual(amount, payment.Amount);
        }
    }
}
