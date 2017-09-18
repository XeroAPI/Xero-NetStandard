using System.Collections.Generic;
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
        public void create_a_valid_setup()
        {
            var import = Api.Setup.Create(new Xero.Api.Core.Model.Setup.Setup
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
            Assert.Throws<ValidationException>(() => Api.Setup.Create(new Xero.Api.Core.Model.Setup.Setup
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
        public void providing_nothing_is_not_an_error()
        {
            var import = Api.Setup.Create(new Xero.Api.Core.Model.Setup.Setup());

            Assert.False(import.Accounts.Present);
            Assert.False(import.Organisation.Present);
        }        
    }
}
