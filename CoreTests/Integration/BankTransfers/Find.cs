using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.BankTransfers
{
    [TestFixture]
    public class Find : BankTransfersTest
    {
        [Test]
        public async Task find_bank_transfers()
        {
            await Given_a_bank_transfer(10m);

            var allTransfers = await Api.BankTransfers.FindAsync();

            Assert.Greater(allTransfers.Count(), 0);
        }

        [Test]
        public async Task find_bank_transfers_individual()
        {
            var expected = (await Given_a_bank_transfer(25m)).Id;

            var id = (await Api.BankTransfers.FindAsync(expected)).Id;

            Assert.AreEqual(expected, id);
        }

        [Test]
        public async Task find_bank_transfers_ifmodifiedsince()
        {
            await Given_a_bank_transfer(25m);

            var date = DateTime.Today.AddDays(-4);
            var bankTransfers = await Api.BankTransfers.ModifiedSince(date).FindAsync();

            Assert.Greater(bankTransfers.Count(), 0);
        }
    }
}
