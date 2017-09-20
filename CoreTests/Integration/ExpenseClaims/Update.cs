using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Status;

namespace CoreTests.Integration.ExpenseClaims
{
    [TestFixture]
    public class Update : ExpenseClaimTest
    {
        [Test]
        public async Task authorise_expense_claim()
        {
            var user = (await Api.Users.FindAsync()).First();

            var receipt1 = await Given_a_receipt(user.Id, Random.GetRandomString(10), Random.GetRandomString(30), 20m, "420");
            var receipt2 = await Given_a_receipt(user.Id, Random.GetRandomString(10), Random.GetRandomString(30), 50m, "420");

            var claim = await Given_an_expense_claim(user.Id, receipt1.Id, receipt2.Id);

            var authorised = await Api.UpdateAsync(
                new ExpenseClaim
                {
                    Id = claim.Id,
                    Status = ExpenseClaimStatus.Authorised
                });

            Assert.AreEqual(ExpenseClaimStatus.Authorised, authorised.Status);
        }

        [Test]
        public async Task void_expense_claim()
        {
            var user = (await Api.Users.FindAsync()).First();

            var receipt1 = await Given_a_receipt(user.Id, Random.GetRandomString(10), Random.GetRandomString(30), 20m, "420");
            var receipt2 = await Given_a_receipt(user.Id, Random.GetRandomString(10), Random.GetRandomString(30), 50m, "420");

            var claim = await Given_an_expense_claim(user.Id, receipt1.Id, receipt2.Id);

            var authorised = await Api.UpdateAsync(
                new ExpenseClaim
                {
                    Id = claim.Id,
                    Status = ExpenseClaimStatus.Authorised
                });

            var voided = await Api.UpdateAsync(
                new ExpenseClaim
                {
                    Id = authorised.Id,
                    Status = ExpenseClaimStatus.Voided
                });

            Assert.AreEqual(ExpenseClaimStatus.Voided, voided.Status);
        }
    }
}