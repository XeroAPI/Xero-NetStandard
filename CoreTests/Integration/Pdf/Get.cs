using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model.Types;
using Xero.Api.Infrastructure.Exceptions;

namespace CoreTests.Integration.Pdf
{
    [TestFixture]
    public class Get : ApiWrapperTest
    {
        [Test]
        public async Task can_get_invoice_as_pdf()
        {
            await AssertOk(PdfEndpointType.Invoices, (await new Invoices.Create().Given_an_invoice()).Id);
        }

        [Test]
        public async Task can_get_credit_note_as_pdf()
        {
            await AssertOk(PdfEndpointType.CreditNotes, (await new CreditNotes.Create().Given_a_creditnote()).Id);
        }

        [Test]
        public async Task can_get_purchase_order_as_pdf()
        {
            await AssertOk(PdfEndpointType.PurchaseOrders, (await new PurchaseOrders.Create().Given_a_purchase_order()).Id);
        }

        [Test]
        public void invoice_gives_404_when_not_found()
        {
            Assert.ThrowsAsync<NotFoundException>(() => Api.PdfFiles.GetAsync(PdfEndpointType.Invoices, Guid.NewGuid()));
        }

        [Test]
        public void credit_note_gives_404_when_not_found()
        {
            Assert.ThrowsAsync<NotFoundException>(() => Api.PdfFiles.GetAsync(PdfEndpointType.CreditNotes, Guid.NewGuid()));
        }

        [Test]
        public void purchase_order_gives_404_when_not_found()
        {
            Assert.ThrowsAsync<NotFoundException>(() => Api.PdfFiles.GetAsync(PdfEndpointType.PurchaseOrders, Guid.NewGuid()));
        }

        private async Task AssertOk(PdfEndpointType type, Guid id)
        {
            var pdf = await Api.PdfFiles.GetAsync(type, id);
            var expected = id.ToString("D") + ".pdf";

            Assert.NotNull(pdf);
            Assert.AreEqual(expected, pdf.FileName);
        }
    }    
}
