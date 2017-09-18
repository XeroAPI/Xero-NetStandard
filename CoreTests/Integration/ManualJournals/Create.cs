using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Xero.Api.Core.Model;

namespace CoreTests.Integration.ManualJournals
{
    [TestFixture]
    public class Create : ManualJournalsTest
    {
        [OneTimeSetUp]
        public void CreateSetUp()
        {
            ManualJournalsSetUp();
        }

        [Test]
        public void create_manual_journal()
        {
            const string narration = "We know what we want to do";
            const int amount = 50;

            var manual = Given_a_manual_journal(narration, amount);

            Assert.AreEqual(DateTime.Now.Date, manual.Date);
            Assert.AreEqual(narration, manual.Narration);
            Assert.True(manual.Lines.All(p => amount == Math.Abs(p.Amount)));
            Assert.NotNull(manual.Lines.Single(p => Revenue.Code == p.AccountCode));
            Assert.NotNull(manual.Lines.Single(p => Sales.Code == p.AccountCode));
        }

        [Test]
        public void create_complex_manual_journal()
        {
            const string narration = "We know what we want to do";

            var manual = Api.Create(new ManualJournal
            {
                Narration = narration,
                Lines = new List<Line>
                {
                    new Line
                    {
                        Amount = 12.5m,
                        AccountCode = Revenue.Code
                    },
                    new Line
                    {
                        Amount = 25,
                        AccountCode = Revenue.Code
                    },
                    new Line
                    {
                        Amount = 12.5m,
                        AccountCode = Sales.Code
                    },
                    new Line
                    {
                        Amount = -50m,
                        AccountCode = Sales.Code
                    }
                }
            });

            Assert.AreEqual(0, manual.Lines.Sum(p => p.Amount));
            Assert.AreEqual(DateTime.Now.Date, manual.Date);
            Assert.AreEqual(narration, manual.Narration);
        }        
    }
}
