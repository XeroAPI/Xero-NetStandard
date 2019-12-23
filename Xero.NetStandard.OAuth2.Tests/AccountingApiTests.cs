using System;
using Xunit;
using System.IO;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Model;
using System.Threading.Tasks;


namespace Xero.NetStandard.OAuth2.Tests
{
  public class AccountingApiTests
  {

    private AccountingApi _accountingApi;
    private XeroConfiguration _xeroConfig;
    private const string AccessToken = "XeroNetStandardAccessToken";
    private const string TenantId = "XeroNetStandardTenantId";


    public AccountingApiTests()
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
    public async Task GetAccountDeserializesResponse()
    {
      var response = await _accountingApi.GetAccountsAsync(AccessToken, TenantId);
      Assert.IsType<Accounts>(response);
    }

    [Fact]
    public async Task test()
    {
      var invoice = new Invoice();
      invoice.Reference = "blahblah";
      var response = await _accountingApi.CreateInvoiceAsync(AccessToken, TenantId, invoice);
      // var test2 = AutoFaker.Generate<Invoice>();

    }
  }
}
