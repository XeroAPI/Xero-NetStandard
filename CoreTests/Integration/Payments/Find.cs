using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.Payments
{
    public class Find : PaymentsTest
    {
        [OneTimeSetUp]
        public async Task PaymentsSetUp()
        {
            await SetUp();
        }

        [Test]
        public async Task find_single_payment()
        {
            var expected = await Given_a_payment(200, DateTime.Today.AddDays(-10), 150);

            var found = await Api.Payments.FindAsync(expected.Id);

            Assert.AreEqual(expected.Id, found.Id);
            Assert.AreEqual(expected.Amount, found.Amount);
        }

        [Test]
        public async Task find_payments()
        {
            var date = DateTime.Today.AddDays(-10).Date;

            await Given_a_payment(200, date, 150);
            await Given_a_payment(500, date, 150);
        
            var found = (await Api.Payments
                .ModifiedSince(DateTime.Now.AddSeconds(-1))
                .Where("Amount == 150")
                .FindAsync())
                .ToList();

            Assert.IsTrue(found.Count() >= 2);
            Assert.IsTrue(found.Count(p => p.Date == date) >= 2);
        }
    }
}
