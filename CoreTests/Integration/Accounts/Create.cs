using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;
using Xero.Api.Infrastructure.Exceptions;

namespace CoreTests.Integration.Accounts
{
    [TestFixture]
    public class Create : ApiWrapperTest
    {
        [Test]
        public void create_account()
        {
            Assert.DoesNotThrowAsync(() => Api.CreateAsync(new Account
            {
              Code = Random.GetRandomString(10),
              Type = AccountType.Overheads,
              Description = "Consultant charges",
              Name = "Consultation " + Random.GetRandomString(10)
            }));

        }

        [Test]
        public void create_bank_account()
        {
            Assert.DoesNotThrowAsync(() => Api.CreateAsync(new Account
            {
                Code = Random.GetRandomString(10),
                Name = "Cheque " + Random.GetRandomString(10),
                Type = AccountType.Bank,
                BankAccountNumber = "02-3467-474288",
            }));
        }

        [Test]
        public void incorrect_types_are_rejected()
        {
            Assert.ThrowsAsync<ValidationException>(() => Api.CreateAsync(new Account
            {
                Code = Random.GetRandomString(10),
                Type = AccountType.Expense,
                Description = "Income from other sales",
                Name = "Other Sales",
                TaxType = "OUTPUT2"
            }));
        }
    }
}
