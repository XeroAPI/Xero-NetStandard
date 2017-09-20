using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model.Status;

namespace CoreTests.Integration.Payments
{
    [TestFixture]
    public class Delete : PaymentsTest
    {
        [OneTimeSetUp]
        public async Task CreatePaymentsSetUp()
        {
            await SetUp();
        }

        [Test]
        public async Task can_delete_payments()
        {
            var date = DateTime.UtcNow;
            const decimal expected = 32.6m;
            const decimal invoiceAmount = 100;

            var payment = await Given_a_payment(invoiceAmount, date, expected);

            await Given_this_payment_is_deleted(payment);

            var found = await Api.Payments.FindAsync(payment.Id);

            Assert.True(found.Status == PaymentStatus.Deleted);
        }

    }
}
