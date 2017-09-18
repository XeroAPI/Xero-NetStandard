using System;
using NUnit.Framework;
using Xero.Api.Core.Model.Status;

namespace CoreTests.Integration.Payments
{
    [TestFixture]
    public class Delete : PaymentsTest
    {
        [OneTimeSetUp]
        public void CreatePaymentsSetUp()
        {
            SetUp();
        }

        [Test]
        public void can_delete_payments()
        {
            var date = DateTime.UtcNow;
            const decimal expected = 32.6m;
            const decimal invoiceAmount = 100;

            var payment = Given_a_payment(invoiceAmount, date, expected);

            Given_this_payment_is_deleted(payment);

            var found = Api.Payments.Find(payment.Id);

            Assert.True(found.Status == PaymentStatus.Deleted);
        }

    }
}
