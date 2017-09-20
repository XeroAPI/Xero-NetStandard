using System;
using System.Linq;
using System.Threading.Tasks;
using CoreTests.Integration.Invoices;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.Allocations
{
    [TestFixture]
    public class Add : ApiWrapperTest
    {
        [Test]
        public async Task allocation_to_invoice()
        {
            var creditNote = await new CreditNotes.CreditNotesTest().Given_an_authorised_creditnote(CreditNoteType.AccountsReceivable);
            var invoice = await new Create().Given_an_authorised_invoice(InvoiceType.AccountsReceivable);
            var expected = Math.Min(creditNote.Total.GetValueOrDefault(), invoice.Total.GetValueOrDefault());

            var result = await Api.Allocations.AddAsync(new CreditNoteAllocation
                {
                    AppliedAmount = expected,
                    CreditNote = creditNote,
                    Invoice = invoice
                });

            Assert.AreEqual(expected, result.Amount);
            Assert.AreEqual(invoice.Id, result.Invoice.Id);
            Assert.AreEqual(creditNote.Id, result.CreditNote.Id);
        }

        [Test]
        public async Task allocation_to_invoice_minimal()
        {            
            var creditNote = await new CreditNotes.CreditNotesTest().Given_an_authorised_creditnote();
            var invoice = await new Create().Given_an_authorised_invoice();
            var expected = Math.Min(creditNote.Total.GetValueOrDefault(), invoice.Total.GetValueOrDefault());

            var result = await Api.Allocations.AddAsync(new CreditNoteAllocation
            {
                AppliedAmount = expected,
                CreditNote = new CreditNote { Id = creditNote.Id },
                Invoice = new Invoice { Id = invoice.Id }
            });

            Assert.AreEqual(expected, result.Amount);
            Assert.AreEqual(invoice.Id, result.Invoice.Id);
            Assert.AreEqual(creditNote.Id, result.CreditNote.Id);
        }


        [Test]
        public async Task allocation_on_creditnote()
        {
            var creditNote = await new CreditNotes.CreditNotesTest().Given_an_authorised_creditnote();
            var invoice = await new Create().Given_an_authorised_invoice();
            var expected = Math.Min(creditNote.Total.GetValueOrDefault(), invoice.Total.GetValueOrDefault());

            await Api.Allocations.AddAsync(new CreditNoteAllocation
            {
                AppliedAmount = expected,
                CreditNote = new CreditNote { Id = creditNote.Id },
                Invoice = new Invoice { Id = invoice.Id }
            });

            creditNote = await Api.CreditNotes.FindAsync(creditNote.Id);
            
            Assert.AreEqual(1, creditNote.Allocations.Count);
            Assert.AreEqual(expected, creditNote.Allocations.First().Amount);
        }

        [Test]
        public async Task allocation_on_prepayment()
        {
            var transaction = await new BankTransactions.BankTransactionTest().Given_a_bank_transaction(BankTransactionType.SpendPrepayment, "310");
            var invoice = await new Create().Given_an_authorised_invoice();
            var expected = Math.Min(transaction.Total.GetValueOrDefault(), invoice.Total.GetValueOrDefault());

            await Api.Allocations.AddAsync(new PrepaymentAllocation
            {
                AppliedAmount = expected,
                Prepayment = new Prepayment { Id = transaction.PrepaymentID.GetValueOrDefault() },
                Invoice = new Invoice { Id = invoice.Id }
            });

            var prepayment = await Api.Prepayments.FindAsync(transaction.PrepaymentID.GetValueOrDefault());

            Assert.AreEqual(1, prepayment.Allocations.Count);
            Assert.AreEqual(expected, prepayment.Allocations.First().Amount);
        }

        [Test]
        public async Task allocation_on_overpayment()
        {
            var transaction = await new BankTransactions.BankTransactionTest().Given_an_overpayment(BankTransactionType.SpendOverpayment);
            var invoice = await new Create().Given_an_authorised_invoice();
            var expected = Math.Min(transaction.Total.GetValueOrDefault(), invoice.Total.GetValueOrDefault());

            await Api.Allocations.AddAsync(new OverpaymentAllocation
            {
                AppliedAmount = expected,
                Overpayment = new Overpayment { Id = transaction.OverpaymentID.GetValueOrDefault() },
                Invoice = new Invoice { Id = invoice.Id }
            });

            var overpayment = await Api.Overpayments.FindAsync(transaction.OverpaymentID.GetValueOrDefault());

            Assert.AreEqual(1, overpayment.Allocations.Count);
            Assert.AreEqual(expected, overpayment.Allocations.First().Amount);
        }

        [Test]
        public async Task Credit_notes_show_up_on_invoices()
        {
            var creditNote = await new CreditNotes.CreditNotesTest().Given_an_authorised_creditnote();
            var invoice = await new Create().Given_an_authorised_invoice();
            var amount = Math.Min(creditNote.Total.GetValueOrDefault(), invoice.Total.GetValueOrDefault());

            await Api.Allocations.AddAsync(new CreditNoteAllocation
            {
                AppliedAmount = amount,
                CreditNote = new CreditNote { Id = creditNote.Id },
                Invoice = new Invoice { Id = invoice.Id }
            });

            invoice = await Api.Invoices.FindAsync(invoice.Id);

            Assert.AreEqual(1, invoice.CreditNotes.Count);
            Assert.AreEqual(creditNote.Id, invoice.CreditNotes.First().Id);
            
        }

        [Test]
        public async Task Prepayments_show_on_invoices()
        {
            var transaction = await new BankTransactions.BankTransactionTest().Given_a_bank_transaction(BankTransactionType.SpendPrepayment, "310");
            var invoice = await new Create().Given_an_authorised_invoice();
            var expected = Math.Min(transaction.Total.GetValueOrDefault(), invoice.Total.GetValueOrDefault());

            await Api.Allocations.AddAsync(new PrepaymentAllocation
            {
                AppliedAmount = expected,
                Prepayment = new Prepayment { Id = transaction.PrepaymentID.GetValueOrDefault() },
                Invoice = new Invoice { Id = invoice.Id }
            });

            invoice = await Api.Invoices.FindAsync(invoice.Id);

            Assert.AreEqual(1, invoice.Prepayments.Count);
            Assert.AreEqual(transaction.PrepaymentID.GetValueOrDefault(), invoice.Prepayments.First().Id);
        }

        [Test]
        public async Task Overpayments_show_on_invoices()
        {
            var transaction = await new BankTransactions.BankTransactionTest().Given_an_overpayment(BankTransactionType.SpendOverpayment);
            var invoice = await new Create().Given_an_authorised_invoice();
            var expected = Math.Min(transaction.Total.GetValueOrDefault(), invoice.Total.GetValueOrDefault());

            await Api.Allocations.AddAsync(new OverpaymentAllocation
            {
                AppliedAmount = expected,
                Overpayment = new Overpayment { Id = transaction.OverpaymentID.GetValueOrDefault() },
                Invoice = new Invoice { Id = invoice.Id }
            });

            invoice = await Api.Invoices.FindAsync(invoice.Id);

            Assert.AreEqual(1, invoice.Overpayments.Count);
            Assert.AreEqual(transaction.OverpaymentID.GetValueOrDefault(), invoice.Overpayments.First().Id);
        }
    }
}
