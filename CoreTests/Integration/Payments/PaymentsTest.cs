using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.Payments
{
    public abstract class PaymentsTest : ApiWrapperTest
    {
        protected async Task<Payment> Given_a_payment(decimal invoiceAmount, DateTime date, decimal amount, bool isReconciled = false)
        {
            var payment = await CreatePayment(invoiceAmount, date, amount, isReconciled);

            return await Api.CreateAsync(payment);
        }

        protected async Task<Payment> CreatePayment(decimal invoiceAmount, DateTime date, decimal amount, bool isReconciled = false)
        {
            var invoice = await Given_an_invoice(invoiceAmount, Account.Code);
            var bankCode = BankAccount.Code;

            var payment = new Payment
            {
                Invoice = new Invoice { Number = invoice.Number },
                Account = new Account { Code = bankCode },
                Date = date,
                Amount = amount
            };

            if (isReconciled)
            {
                payment.IsReconciled = true;
            }

            return payment;
        }

        private async Task<Invoice> Given_an_invoice(decimal amount = 100m, string accountCode = "100")
        {
            return await Api.CreateAsync(new Invoice
            {
                Contact = new Contact { Name = "Richard" },
                Number = Random.GetRandomString(10),
                Type = InvoiceType.AccountsPayable,
                Date = DateTime.UtcNow,
                DueDate = DateTime.UtcNow.AddDays(90),
                LineAmountTypes = LineAmountType.Inclusive,
                Status = InvoiceStatus.Authorised,
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        AccountCode = accountCode,
                        Description = "Good value item",
                        LineAmount = amount
                    }
                }
            });
        }

        protected async Task<CreditNote> Given_an_credit_note(decimal amount = 100m, string accountCode = "100")
        {
            return await Api.CreateAsync(new CreditNote
            {
                Contact = new Contact { Name = "Richard" },
                Number = Random.GetRandomString(10),
                Type = CreditNoteType.AccountsPayable,
                Date = DateTime.UtcNow,
                DueDate = DateTime.UtcNow.AddDays(90),
                LineAmountTypes = LineAmountType.Inclusive,
                Status = InvoiceStatus.Authorised,
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        AccountCode = accountCode,
                        Description = "Good value item",
                        LineAmount = amount
                    }
                }
            });
        }

        protected async Task<BankTransaction> Given_a_prepayment(string bankAccountCode, decimal amount = 100m, string accountCode = "100")
        {
            return await Api.CreateAsync(new BankTransaction
            {
                Contact = new Contact { Name = "Richard" },
                Type = BankTransactionType.ReceivePrepayment,
                Date = DateTime.UtcNow,
                BankAccount = new Account
                {
                    Code = bankAccountCode
                },
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        AccountCode = accountCode,
                        Description = "Good value item",
                        LineAmount = amount
                    }
                }
            });
        }

        protected async Task<BankTransaction> Given_an_overpayment(string bankAccountCode, decimal amount = 100m, string accountCode = "100")
        {
            return await Api.CreateAsync(new BankTransaction
            {
                Contact = new Contact { Name = "Richard" },
                Type = BankTransactionType.ReceiveOverpayment,
                Date = DateTime.UtcNow,
                LineAmountTypes = LineAmountType.NoTax,
                BankAccount = new Account
                {
                    Code = bankAccountCode
                },
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        AccountCode = accountCode,
                        Description = "Good value item",
                        LineAmount = amount
                    }
                }
            });
        }

        protected async Task Given_this_payment_is_deleted(Payment payment)
        {
            var deleteThisPayment = new Payment { Status = PaymentStatus.Deleted, Id = payment.Id };

            await Api.Payments.UpdateAsync(deleteThisPayment);
        }
    }
}