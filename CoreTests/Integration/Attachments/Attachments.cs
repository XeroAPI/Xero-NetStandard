using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;
using File = System.IO.File;

namespace CoreTests.Integration.Attachments
{
    public class Attachments : ApiWrapperTest
    {
        private const string ImagePath = @"resources\images\connect_xero_button_blue.png";
        private const string ImageWithSpacesPath = @"resources\images\connect_xero_button_blue - Copy.png";

        [Test]
        public async Task adding_attachment_to_invoice()
        {
            var attachment = await Given_attachment_on_invoice();
            
            Assert.IsTrue(attachment.Id != Guid.Empty);
        }

        [Test]
        public async Task listing_attachments()
        {
            var id = await Given_invoice_with_no_attachments();
            await CreateAttachment(id, AttachmentEndpointType.Invoices);

            var attachments = (await Api.Attachments.ListAsync(AttachmentEndpointType.Invoices, id)).ToList();

            Assert.IsTrue(attachments.Any());
            Assert.IsTrue(attachments.First().Id != Guid.Empty);
        }

        [Test]
        public async Task getting_attachment()
        {
            var id = await Given_invoice_with_no_attachments();
            var sourceFile = new FileInfo(ImagePath);

            var attachment = await CreateAttachment(id, AttachmentEndpointType.Invoices, sourceFile);

            Assert.AreEqual(attachment.ContentLength, sourceFile.Length);
            Assert.AreEqual(attachment.FileName, sourceFile.Name);
        }

        [Test]
        public async Task saving_attachments()
        {
            var sourceFile = new FileInfo(ImagePath);

            var id = await Given_invoice_with_no_attachments();
            var attachment = await CreateAttachment(id, AttachmentEndpointType.Invoices);

            attachment = await GetAttachment(id, AttachmentEndpointType.Invoices, attachment.FileName);
            
            var path = Path.GetTempFileName();
            attachment.Save(path);
            
            var targetFile = new FileInfo(path);

            Assert.AreEqual(sourceFile.Length, targetFile.Length);

            // Clean up after yourself!
            File.Delete(path);
        }

        [Test]
        public async Task saving_attachment_online_invoice_accrec()
        {
            var attachment = await Given_attachment_on_invoice(true);
            
            Assert.AreEqual(true, attachment.IncludeOnline);
        }

        [Test]
        public async Task saving_attachment_online_invoice_accpay()
        {
            var attachment = await Given_attachment_on_invoice();

            Assert.AreEqual(false, attachment.IncludeOnline);
        }

        [Test]
        public async Task saving_attachment_online_credit_note()
        {
            var attachment = await Given_attachment_on_credit_note(true);

            Assert.AreEqual(true, attachment.IncludeOnline);
        }

        [Test]
        public async Task saving_attachment_credit_note()
        {
            var attachment = await Given_attachment_on_credit_note();

            Assert.AreEqual(false, attachment.IncludeOnline);
        }

        [Test]
        public async Task can_save_attachments_with_spaces_in_the_name()
        {
            var attachment = await Given_an_attachment_with_a_space_in_the_name_on_an_invoice();

            Assert.AreEqual(false, attachment.IncludeOnline);
        }

        private async Task<Attachment> Given_attachment_on_invoice(bool includeOnline = false)
        {
            var invoice = await Given_invoice_with_no_attachments(includeOnline);

            return await CreateAttachment(invoice, AttachmentEndpointType.Invoices, includeOnline);
        }

        private async Task<Attachment> Given_an_attachment_with_a_space_in_the_name_on_an_invoice(bool includeOnline = false)
        {
            var invoice = await Given_invoice_with_no_attachments(includeOnline);

            return await CreateAttachment(invoice, AttachmentEndpointType.Invoices, new FileInfo(ImageWithSpacesPath), includeOnline);
        }

        private async Task<Attachment> Given_attachment_on_credit_note(bool includeOnline = false)
        {
            var invoice = await Given_credit_note_with_no_attachments();
            return await CreateAttachment(invoice, AttachmentEndpointType.CreditNotes, includeOnline);
        }


        private async Task<Attachment> CreateAttachment(Guid id, AttachmentEndpointType type, bool includeOnline = false)
        {
            return await CreateAttachment(id, type, new FileInfo(ImagePath), includeOnline);
        }

        private async Task<Attachment> CreateAttachment(Guid id, AttachmentEndpointType type, FileInfo sourceFile, bool includeOnline = false)
        {
            return await Api.Attachments.AddOrReplaceAsync(new Attachment(sourceFile), type, id, includeOnline);            
        }

        private async Task<Attachment> GetAttachment(Guid id, AttachmentEndpointType type, string fileName)
        {
            return await Api.Attachments.GetAsync(type, id, fileName);
        }

        private async Task<Guid> Given_invoice_with_no_attachments(bool accRec = false)
        {
            return (await Api.CreateAsync(new Invoice
            {
                Contact = new Contact { Name = "Richard" },
                Type = accRec ? InvoiceType.AccountsReceivable : InvoiceType.AccountsPayable,
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        Description = "Nothing to see",
                        LineAmount = 100.0m
                    }
                }
            })).Id;
        }

        private async Task<Guid> Given_credit_note_with_no_attachments()
        {
            return (await Api.CreditNotes.CreateAsync(new CreditNote
            {
                Contact = new Contact {Name = "Apple Computers Ltd"},
                Type = CreditNoteType.AccountsReceivable,
                LineAmountTypes = LineAmountType.Exclusive,
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        AccountCode = "720",
                        Description = "MacBook - White",
                        UnitAmount = 1995.00m
                    }
                }
            })).Id;
        }
    }
}
