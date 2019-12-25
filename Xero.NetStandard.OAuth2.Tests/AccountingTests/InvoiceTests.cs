using System;
using Xunit;
using System.IO;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Model;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Generic;

namespace Xero.NetStandard.OAuth2.Tests
{
    public class InvoiceTests
    {

        private AccountingApi _accountingApi;
        private const string AccessToken = "XeroNetStandardAccessToken";
        private const string TenantId = "XeroNetStandardTenantId";


        public InvoiceTests()
        {
            var directory = Directory.GetCurrentDirectory();
            var configuration = TestHelper.GetApplicationConfiguration(directory);
            var config = new Xero.NetStandard.OAuth2.Client.Configuration();
            config.BasePath = configuration.AccountingBaseUrl;
            _accountingApi = new AccountingApi(config);
        }

        [Fact]
        public async Task GetInvoiceDeserializesResponse()
        {
            Guid invoiceID = Guid.NewGuid();
            var response = await _accountingApi.GetInvoiceAsync(AccessToken, TenantId, invoiceID);

            Assert.IsType<Invoices>(response);
        }
        [Fact]
        public async Task GetInvoiceDeserializesDate()
        {
            Guid invoiceID = Guid.NewGuid();
            var response = await _accountingApi.GetInvoiceAsync(AccessToken, TenantId, invoiceID);
            Assert.True(response._Invoices[0].DueDate > DateTime.MinValue);
        }
        [Fact]
        public async Task GetInvoiceReturnsLineItem()
        {
            Guid invoiceID = Guid.NewGuid();
            var response = await _accountingApi.GetInvoiceAsync(AccessToken, TenantId, invoiceID);
            Assert.IsType<List<LineItem>>(response._Invoices[0].LineItems);
        }

        [Fact]
        public async Task GetInvoiceReturnsContact()
        {
            Guid invoiceID = Guid.NewGuid();
            var response = await _accountingApi.GetInvoiceAsync(AccessToken, TenantId, invoiceID);
            Assert.IsType<Contact>(response._Invoices[0].Contact);
        }

        [Fact]
        public async Task CreateInvoiceReturns200Response()
        {
            var invoice = new Invoice();
            invoice.InvoiceNumber = "123";
            var response = await _accountingApi.CreateInvoiceAsyncWithHttpInfo(AccessToken, TenantId, invoice);
            Assert.True(response.StatusCode.Equals(HttpStatusCode.OK));
        }

    }
}
