using System;
using System.Linq;
using NUnit.Framework;

namespace CoreTests.Integration.Payments
{
    public class Find : PaymentsTest
    {
        [OneTimeSetUp]
        public void PaymentsSetUp()
        {
            SetUp();
        }

        [Test]
        public void find_single_payment()
        {
            var expected = Given_a_payment(200, DateTime.Today.AddDays(-10), 150);

            var found = Api.Payments.Find(expected.Id);

            Assert.AreEqual(expected.Id, found.Id);
            Assert.AreEqual(expected.Amount, found.Amount);
        }

        [Test]
        public void find_payments()
        {
            var date = DateTime.Today.AddDays(-10).Date;

            Given_a_payment(200, date, 150);
            Given_a_payment(500, date, 150);
        
            var found = Api.Payments
                .ModifiedSince(DateTime.Now.AddSeconds(-1))
                .Where("Amount == 150")
                .Find()
                .ToList();

            Assert.IsTrue(found.Count() >= 2);
            Assert.IsTrue(found.Count(p => p.Date == date) >= 2);
        }
    }
}
