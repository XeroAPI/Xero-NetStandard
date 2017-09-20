using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;
using Xero.Api.Infrastructure.Exceptions;

namespace CoreTests.Integration.Setup
{
    [TestFixture(Ignore = "These test will remove all accounts! You have been warned.")]
    public class Create : ApiWrapperTest
    {
        [Test]
        public async Task create_a_valid_setup()
        {
            var import = await Api.Setup.CreateAsync(new Xero.Api.Core.Model.Setup.Setup
            {
                Accounts = new List<Account>(new[] {
                    new Account
                    {
                        Code = "POS " + Random.GetRandomString(10),
                        Name = "POS Clearing" + Random.GetRandomString(10),
                        Type = AccountType.Current,
                        Description = "A test for the setup"
                    }
                })
            });

            Assert.True(import.Accounts.New == 1);
        }

        [Test]
        public void missing_account_code_will_error()
        {
            Assert.ThrowsAsync<ValidationException>(() => Api.Setup.CreateAsync(new Xero.Api.Core.Model.Setup.Setup
            {
                Accounts = new List<Account>(new[]
                {
                    new Account
                    {
                        Name = "No account code",
                        Type = AccountType.Current,
                    }
                })
            }));            
        }

        [Test]
        public async Task providing_nothing_is_not_an_error()
        {
            var import = await Api.Setup.CreateAsync(new Xero.Api.Core.Model.Setup.Setup());

            Assert.False(import.Accounts.Present);
            Assert.False(import.Organisation.Present);
        }        
    }
}
