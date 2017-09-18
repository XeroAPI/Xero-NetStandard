using System;
using System.Linq;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.Accounts
{
    [TestFixture]
    public class Find : ApiWrapperTest
    {
        [Test]
        public void find_by_value()
        {
            var type = Api.Accounts
                .Where("Type == \"OVERHEADS\"")
                .Find()
                .ToList().First().Type;

            Assert.AreEqual(AccountType.Overheads, type);
        }

        [Test]
        public void find_by_id()
        {
            var expected = Api.Accounts
                .Where("Type == \"REVENUE\"")
                .Find()
                .First()
                .Id;
          
            var id = Api.Accounts.Find(expected).Id;
            
            Assert.AreEqual(expected, id);
        }

        [Test]
        public void finding_a_non_system_account_has_null_SystemAccount()
        {
            var newNonSystemAccount = Api.Create(new Account
            {
                Code = Random.GetRandomString(10),
                Type = AccountType.OtherIncome,
                Description = "Consultation " + Random.GetRandomString(10),
                Name = "Consultation " + Random.GetRandomString(10)             
            });

            var account = Api.Accounts.Find(newNonSystemAccount.Id);

            Assert.AreEqual(null, account.SystemAccount);
        }

         [Test]
        public void find_accounts_ifmodifiedsince()
        {
            Api.Create(new Account
            {
                Code = Random.GetRandomString(10),
                Type = AccountType.OtherIncome,
                Description = "Consultation " + Random.GetRandomString(10),
                Name = "Consultation " + Random.GetRandomString(10)
            });

            var accounts = Api.Accounts
                .ModifiedSince(DateTime.Now.AddMinutes(-1))
                .Find();

            Assert.True(accounts.Any());
        }
    }
}
