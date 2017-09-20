using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.ManualJournals
{
    [TestFixture]
    public class Update : ManualJournalsTest
    {
        [OneTimeSetUp]
        public async Task UpdateSet()
        {
            await ManualJournalsSetUp();
        }

        [Test]
        public async Task create_manual_journal()
        {
            const string expected = "We got that wrong";

            var manual = await Given_a_manual_journal("We know what we want to do", 50);

            manual.Narration = expected;

            var updated = await Api.UpdateAsync(manual);

            Assert.AreEqual(DateTime.Now.Date, updated.Date);
            Assert.AreEqual(expected, updated.Narration);            
        }
    };
}