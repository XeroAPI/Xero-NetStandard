using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.Accounts
{
    public class Update : ApiWrapperTest
    {
        [Test]
        public async Task Update_account()
        {
            var expectedDescription = "Updated Account" + Guid.NewGuid();

            var account = await CreateAccount();

            account.Description = expectedDescription;

            await Api.Accounts.UpdateAsync(account);

            var updated = await Api.Accounts.FindAsync(account.Id);

            Assert.True(updated.Description == expectedDescription);
        }


        [Test]
        public async Task Archive_account()
        {
            var account = await CreateAccount();

            await Api.Accounts.UpdateAsync(new Account
            {
                Id = account.Id,
                Status = AccountStatus.Archived
            });

            var updated = await Api.Accounts.FindAsync(account.Id);

            Assert.True(updated.Status == AccountStatus.Archived);
        }

        private async Task<Account> CreateAccount()
        {
            var code = "1234" + Guid.NewGuid();

            return await Api.Accounts.CreateAsync(new Account
            {
                Code = code.Substring(0, 10),
                Name = "New Account " + Guid.NewGuid(),
                Type = AccountType.Sales
            });
        }

    }
}
