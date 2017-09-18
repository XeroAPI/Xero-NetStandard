using System;
using NUnit.Framework;

namespace CoreTests.Integration.ManualJournals
{
    [TestFixture]
    public class Update : ManualJournalsTest
    {
        [OneTimeSetUp]
        public void UpdateSet()
        {
            ManualJournalsSetUp();
        }

        [Test]
        public void create_manual_journal()
        {
            const string expected = "We got that wrong";

            var manual = Given_a_manual_journal("We know what we want to do", 50);

            manual.Narration = expected;

            var updated = Api.Update(manual);

            Assert.AreEqual(DateTime.Now.Date, updated.Date);
            Assert.AreEqual(expected, updated.Narration);            
        }
    };
}