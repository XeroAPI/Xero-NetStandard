using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.ManualJournals
{
    [TestFixture]
    public class Find : ManualJournalsTest
    {
        [OneTimeSetUp]
        public async Task UpdateSet()
        {
            await ManualJournalsSetUp();
        }

        [Test]
        public async Task find_by_id()
        {
            const string expected = "We know what we want to do";
            var manual = await Given_a_manual_journal(expected, 50);

            var found = await Api.ManualJournals.FindAsync(manual.Id);

            Assert.AreEqual(DateTime.Now.Date, found.Date);
            Assert.AreEqual(expected, found.Narration);
        }

        [Test]
        public async Task find_by_value()
        {
            const string expected = "We know what we want to do";
            
            await Given_a_manual_journal(expected, 50);

            var found = await Api.ManualJournals
                .Where(string.Format("Narration == \"{0}\"", expected))
                .FindAsync();

            Assert.True(found.All(p => p.Narration == expected));
        }

        [Test]
        public async Task find_by_page()
        {
            const string expected = "We know what we want to do";

            await Given_a_manual_journal(expected, 50);

            var manualJournals = await Api.ManualJournals.Page(1).FindAsync();

            Assert.Greater(manualJournals.Count(), 0);
        }
    }
}