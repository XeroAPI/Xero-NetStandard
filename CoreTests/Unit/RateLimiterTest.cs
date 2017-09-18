using System;
using System.Diagnostics;
using NUnit.Framework;
using Xero.Api.Infrastructure.RateLimiter;

namespace CoreTests.Unit
{
    [TestFixture]
    public class RateLimiterTest
    {
        [Test]
        public void TestRateLimiter()
        {
            RateLimiter rate = new RateLimiter(TimeSpan.FromSeconds(5), 5);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Assert.IsFalse(rate.CheckLimit());
            rate.WaitUntilLimit();
            Assert.IsFalse(rate.CheckLimit());
            rate.WaitUntilLimit();
            Assert.IsFalse(rate.CheckLimit());
            rate.WaitUntilLimit();
            Assert.IsFalse(rate.CheckLimit());
            rate.WaitUntilLimit();
            Assert.IsFalse(rate.CheckLimit());
            rate.WaitUntilLimit();
            Assert.IsTrue(rate.CheckLimit());
            rate.WaitUntilLimit();
            sw.Stop();
            Assert.IsTrue(sw.Elapsed > TimeSpan.FromSeconds(5));
        }
    }
}
