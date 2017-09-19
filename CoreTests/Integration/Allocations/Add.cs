using System;
using System.Linq;
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
        public void allocation_to_invoice()
        {
            var creditNote = new CreditNotes.CreditNotesTest().Given_an_authorised_creditnote(CreditNoteType.AccountsReceivable);
            var invoice = new Create().Given_an_authorised_invoice(InvoiceType.AccountsReceivable);
            var expected = Math.Min(creditNote.Total.GetValueOrDefault(), invoice.Total.GetValueOrDefault());

            var result = Api.Allocations.Add(new Allocation
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
        public void allocation_to_invoice_minimal()
        {            
            var creditNote = new CreditNotes.CreditNotesTest().Given_an_authorised_creditnote();
            var invoice = new Create().Given_an_authorised_invoice();
            var expected = Math.Min(creditNote.Total.GetValueOrDefault(), invoice.Total.GetValueOrDefault());

            var result = Api.Allocations.Add(new Allocation
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
        public void allocation_on_creditnote()
        {
            var creditNote = new CreditNotes.CreditNotesTest().Given_an_authorised_creditnote();
            var invoice = new Create().Given_an_authorised_invoice();
            var expected = Math.Min(creditNote.Total.GetValueOrDefault(), invoice.Total.GetValueOrDefault());

            Api.Allocations.Add(new Allocation
            {
                AppliedAmount = expected,
                CreditNote = new CreditNote { Id = creditNote.Id },
                Invoice = new Invoice { Id = invoice.Id }
            });

            creditNote = Api.CreditNotes.Find(creditNote.Id);
            
            Assert.AreEqual(1, creditNote.Allocations.Count);
            Assert.AreEqual(expected, creditNote.Allocations.First().Amount);
        }

        [Test]
        public void allocation_on_prepayment()
        {
            var transaction = new BankTransactions.BankTransactionTest().Given_a_bank_transaction(BankTransactionType.SpendPrepayment, "310");
            var invoice = new Create().Given_an_authorised_invoice();
            var expected = Math.Min(transaction.Total.GetValueOrDefault(), invoice.Total.GetValueOrDefault());

            Api.Allocations.Add(new PrepaymentAllocation
            {
                AppliedAmount = expected,
                Prepayment = new Prepayment { Id = transaction.PrepaymentID.GetValueOrDefault() },
                Invoice = new Invoice { Id = invoice.Id }
            });

            var prepayment = Api.Prepayments.Find(transaction.PrepaymentID.GetValueOrDefault());

            Assert.AreEqual(1, prepayment.Allocations.Count);
            Assert.AreEqual(expected, prepayment.Allocations.First().Amount);
        }

        [Test]
        public void allocation_on_overpayment()
        {
            var transaction = new BankTransactions.BankTransactionTest().Given_an_overpayment(BankTransactionType.SpendOverpayment);
            var invoice = new Create().Given_an_authorised_invoice();
            var expected = Math.Min(transaction.Total.GetValueOrDefault(), invoice.Total.GetValueOrDefault());

            Api.Allocations.Add(new OverpaymentAllocation
            {
                AppliedAmount = expected,
                Overpayment = new Overpayment { Id = transaction.OverpaymentID.GetValueOrDefault() },
                Invoice = new Invoice { Id = invoice.Id }
            });

            var overpayment = Api.Overpayments.Find(transaction.OverpaymentID.GetValueOrDefault());

            Assert.AreEqual(1, overpayment.Allocations.Count);
            Assert.AreEqual(expected, overpayment.Allocations.First().Amount);
        }

        [Test]
        public void Credit_notes_show_up_on_invoices()
        {
            var creditNote = new CreditNotes.CreditNotesTest().Given_an_authorised_creditnote();
            var invoice = new Create().Given_an_authorised_invoice();
            var amount = Math.Min(creditNote.Total.GetValueOrDefault(), invoice.Total.GetValueOrDefault());

            Api.Allocations.Add(new Allocation
            {
                AppliedAmount = amount,
                CreditNote = new CreditNote { Id = creditNote.Id },
                Invoice = new Invoice { Id = invoice.Id }
            });

            invoice = Api.Invoices.Find(invoice.Id);

            Assert.AreEqual(1, invoice.CreditNotes.Count);
            Assert.AreEqual(creditNote.Id, invoice.CreditNotes.First().Id);
            
        }

        [Test]
        public void Prepayments_show_on_invoices()
        {
            var transaction = new BankTransactions.BankTransactionTest().Given_a_bank_transaction(BankTransactionType.SpendPrepayment, "310");
            var invoice = new Create().Given_an_authorised_invoice();
            var expected = Math.Min(transaction.Total.GetValueOrDefault(), invoice.Total.GetValueOrDefault());

            Api.Allocations.Add(new PrepaymentAllocation
            {
                AppliedAmount = expected,
                Prepayment = new Prepayment { Id = transaction.PrepaymentID.GetValueOrDefault() },
                Invoice = new Invoice { Id = invoice.Id }
            });

            invoice = Api.Invoices.Find(invoice.Id);

            Assert.AreEqual(1, invoice.Prepayments.Count);
            Assert.AreEqual(transaction.PrepaymentID.GetValueOrDefault(), invoice.Prepayments.First().Id);
        }

        [Test]
        public void Overpayments_show_on_invoices()
        {
            var transaction = new BankTransactions.BankTransactionTest().Given_an_overpayment(BankTransactionType.SpendOverpayment);
            var invoice = new Create().Given_an_authorised_invoice();
            var expected = Math.Min(transaction.Total.GetValueOrDefault(), invoice.Total.GetValueOrDefault());

            Api.Allocations.Add(new OverpaymentAllocation
            {
                AppliedAmount = expected,
                Overpayment = new Overpayment { Id = transaction.OverpaymentID.GetValueOrDefault() },
                Invoice = new Invoice { Id = invoice.Id }
            });

            invoice = Api.Invoices.Find(invoice.Id);

            Assert.AreEqual(1, invoice.Overpayments.Count);
            Assert.AreEqual(transaction.OverpaymentID.GetValueOrDefault(), invoice.Overpayments.First().Id);
        }
    }
}
