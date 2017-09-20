using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.Invoices
{
    [TestFixture]
    public class OnlineInvoiceUrl : InvoicesTest
    {

        [Test]
        public async Task find_the_online_invoice_url_for_an_accrec_invoice()
        {
            var invoice = await Given_an_invoice(InvoiceType.AccountsReceivable, InvoiceStatus.Authorised);

            var onlineInvoiceUrl = await Api.Invoices.RetrieveOnlineInvoiceUrlAsync(invoice.Id);

            Assert.True(!string.IsNullOrEmpty(onlineInvoiceUrl.OnlineInvoiceUrl));
        }
    }
}
