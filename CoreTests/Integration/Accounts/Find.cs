using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.Accounts
{
    [TestFixture]
    public class Find : ApiWrapperTest
    {
        [Test]
        public async Task find_by_value()
        {
            var type = (await Api.Accounts
                .Where("Type == \"OVERHEADS\"")
                .FindAsync())
                .ToList().First().Type;

            Assert.AreEqual(AccountType.Overheads, type);
        }

        [Test]
        public async Task find_by_id()
        {
            var expected = (await Api.Accounts
                .Where("Type == \"REVENUE\"")
                .FindAsync())
                .First()
                .Id;
          
            var id = (await Api.Accounts.FindAsync(expected)).Id;
            
            Assert.AreEqual(expected, id);
        }

        [Test]
        public async Task finding_a_non_system_account_has_null_SystemAccount()
        {
            var newNonSystemAccount = await Api.CreateAsync(new Account
            {
                Code = Random.GetRandomString(10),
                Type = AccountType.OtherIncome,
                Description = "Consultation " + Random.GetRandomString(10),
                Name = "Consultation " + Random.GetRandomString(10)             
            });

            var account = await Api.Accounts.FindAsync(newNonSystemAccount.Id);

            Assert.AreEqual(null, account.SystemAccount);
        }

         [Test]
        public async Task find_accounts_ifmodifiedsince()
        {
            await Api.CreateAsync(new Account
            {
                Code = Random.GetRandomString(10),
                Type = AccountType.OtherIncome,
                Description = "Consultation " + Random.GetRandomString(10),
                Name = "Consultation " + Random.GetRandomString(10)
            });

            var accounts = await Api.Accounts
                .ModifiedSince(DateTime.Now.AddMinutes(-1))
                .FindAsync();

            Assert.True(accounts.Any());
        }
    }
}
