using System;
using Xunit;
using System.IO;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Model;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Generic;
using Bogus;
using AutoBogus;

namespace Xero.NetStandard.OAuth2.Tests
{
    public class AccountsTests
    {

        private AccountingApi _accountingApi;
        private const string AccessToken = "XeroNetStandardAccessToken";
        private const string TenantId = "XeroNetStandardTenantId";


        public AccountsTests()
        {
            var directory = Directory.GetCurrentDirectory();
            var configuration = TestHelper.GetApplicationConfiguration(directory);
            var config = new Xero.NetStandard.OAuth2.Client.Configuration();
            config.BasePath = configuration.AccountingBaseUrl;
            _accountingApi = new AccountingApi(config);
        }
        [Trait("Type", "Attachment")]
        [Fact]
        public async Task GetAccountsDeserializesResponse()
        {
            var response = await _accountingApi.GetAccountsAsync(AccessToken, TenantId);
            Assert.IsType<Accounts>(response);
        }

        [Fact]

        public async Task GetAccountDeserializesName()
        {
            var accountId = Guid.NewGuid();
            var fakeAccount = AutoFaker.Generate<Account>();
            var response = await _accountingApi.GetAccountAsync(AccessToken, TenantId, accountId);
            Assert.IsType<Account>(response._Accounts[0]);
        }
    }
}
