using NUnit.Framework;
using Xero.Api.Common;
using Xero.Api.Core.Endpoints;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Interfaces;

namespace CoreTests.Unit
{
    [TestFixture]
    public class FourDecimalPlaces : ApiWrapperTest
    {
        [Test]
        public void explict_four_decimal_places_invoices()
        {
            ExplictUse4Dp((FourDecimalPlacesEndpoint<InvoicesEndpoint, Invoice, InvoicesRequest, InvoicesResponse>)Api.Invoices, "unitdp=4&page=1");
        }

        [Test]
        public void implict_four_decimal_places_invoice()
        {
            ImplicitUse4Dp((FourDecimalPlacesEndpoint<InvoicesEndpoint, Invoice, InvoicesRequest, InvoicesResponse>)Api.Invoices, "unitdp=4&page=1");
        }

        [Test]
        public void no_four_decimal_places_invoice()
        {
            ExplicitNotUse4Dp((FourDecimalPlacesEndpoint<InvoicesEndpoint, Invoice, InvoicesRequest, InvoicesResponse>)Api.Invoices, "page=1");
        }

        [Test]
        public void no_four_decimal_places_bank_transactions()
        {
            ExplicitNotUse4Dp((FourDecimalPlacesEndpoint<BankTransactionsEndpoint, BankTransaction, BankTransactionsRequest, BankTransactionsResponse>)Api.BankTransactions, "page=1");
        }

        [Test]
        public void explict_four_decimal_places_bank_transactions()
        {
            ExplictUse4Dp((FourDecimalPlacesEndpoint<BankTransactionsEndpoint, BankTransaction, BankTransactionsRequest, BankTransactionsResponse>)Api.BankTransactions, "unitdp=4&page=1");
        }

        [Test]
        public void implict_four_decimal_places_bank_transactions()
        {
            ImplicitUse4Dp((FourDecimalPlacesEndpoint<BankTransactionsEndpoint, BankTransaction, BankTransactionsRequest, BankTransactionsResponse>)Api.BankTransactions, "unitdp=4&page=1");
        }

        [Test]
        public void no_four_decimal_places_credit_notes()
        {
            ExplicitNotUse4Dp((FourDecimalPlacesEndpoint<CreditNotesEndpoint, CreditNote, CreditNotesRequest, CreditNotesResponse>)Api.CreditNotes, "page=1");
        }

        [Test]
        public void explict_four_decimal_places_credit_notes()
        {
            ExplictUse4Dp((FourDecimalPlacesEndpoint<CreditNotesEndpoint, CreditNote, CreditNotesRequest, CreditNotesResponse>)Api.CreditNotes, "unitdp=4&page=1");
        }

        [Test]
        public void implict_four_decimal_places_credit_notes()
        {
            ImplicitUse4Dp((FourDecimalPlacesEndpoint<CreditNotesEndpoint, CreditNote, CreditNotesRequest, CreditNotesResponse>)Api.CreditNotes, "unitdp=4&page=1");
        }

        [Test]
        public void no_four_decimal_places_reciepts()
        {
            ExplicitNotUse4Dp((FourDecimalPlacesEndpoint<ReceiptsEndpoint, Receipt, ReceiptsRequest, ReceiptsResponse>)Api.Receipts);
        }

        [Test]
        public void explict_four_decimal_places_reciepts()
        {
            ExplictUse4Dp((FourDecimalPlacesEndpoint<ReceiptsEndpoint, Receipt, ReceiptsRequest, ReceiptsResponse>)Api.Receipts);
        }

        [Test]
        public void implict_four_decimal_places_reciepts()
        {
            ImplicitUse4Dp((FourDecimalPlacesEndpoint<ReceiptsEndpoint, Receipt, ReceiptsRequest, ReceiptsResponse>)Api.Receipts);
        }

        [Test]
        public void no_four_decimal_places_payments()
        {
            ExplicitNotUse4Dp((FourDecimalPlacesEndpoint<PaymentsEndpoint, Payment, PaymentsRequest, PaymentsResponse>)Api.Payments);
        }

        [Test]
        public void explict_four_decimal_places_payments()
        {
            ExplictUse4Dp((FourDecimalPlacesEndpoint<PaymentsEndpoint, Payment, PaymentsRequest, PaymentsResponse>)Api.Payments);
        }

        [Test]
        public void implict_four_decimal_places_payments()
        {
            ImplicitUse4Dp((FourDecimalPlacesEndpoint<PaymentsEndpoint, Payment, PaymentsRequest, PaymentsResponse>)Api.Payments);
        }

        [Test]
        public void no_four_decimal_places_items()
        {
            ExplicitNotUse4Dp((FourDecimalPlacesEndpoint<ItemsEndpoint, Item, ItemsRequest, ItemsResponse>)Api.Items);
        }

        [Test]
        public void explict_four_decimal_places_items()
        {
            ExplictUse4Dp((FourDecimalPlacesEndpoint< ItemsEndpoint, Item, ItemsRequest, ItemsResponse>) Api.Items);
        }

        [Test]
        public void implict_four_decimal_places_items()
        {
            ImplicitUse4Dp((FourDecimalPlacesEndpoint<ItemsEndpoint, Item, ItemsRequest, ItemsResponse>)Api.Items);
        }

        [Test]
        public void no_four_decimal_places_repeat_invoice()
        {
            Assert.AreEqual("", Api.RepeatingInvoices.UseFourDecimalPlaces(false).QueryString);            
        }

        [Test]
        public void explict_four_decimal_repeat_invoice()
        {
            Assert.AreEqual("unitdp=4", Api.RepeatingInvoices.UseFourDecimalPlaces(true).QueryString);            
        }

        [Test]
        public void implict_four_decimal_repeat_invoice()
        {
            Assert.AreEqual("unitdp=4", Api.RepeatingInvoices.QueryString);            
        }

        private void ExplictUse4Dp<T, TResult, TRequest, TResponse>(FourDecimalPlacesEndpoint<T, TResult, TRequest, TResponse> endpoint, string expected = "unitdp=4")
            where T : XeroReadEndpoint<T, TResult, TResponse>
            where TResponse : IXeroResponse<TResult>, new()
            where TRequest : IXeroRequest<TResult>, new()
        {
            var e = endpoint.UseFourDecimalPlaces(true);
            Assert.AreEqual(expected, e.QueryString);
        }

        private void ImplicitUse4Dp<T, TResult, TRequest, TResponse>(FourDecimalPlacesEndpoint<T, TResult, TRequest, TResponse> endpoint, string expected = "unitdp=4")
            where T : XeroReadEndpoint<T, TResult, TResponse>
            where TResponse : IXeroResponse<TResult>, new()
            where TRequest : IXeroRequest<TResult>, new()
        {
            Assert.AreEqual(expected, endpoint.QueryString);
        }

        private void ExplicitNotUse4Dp<T, TResult, TRequest, TResponse>(FourDecimalPlacesEndpoint<T, TResult, TRequest, TResponse> endpoint, string expected = "")
            where T : XeroReadEndpoint<T, TResult, TResponse>
            where TResponse : IXeroResponse<TResult>, new()
            where TRequest : IXeroRequest<TResult>, new()
        {
            var e = endpoint.UseFourDecimalPlaces(false);
            Assert.AreEqual(expected, e.QueryString);
        }
    }
}
