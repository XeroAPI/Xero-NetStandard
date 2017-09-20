using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.CreditNotes
{
    [TestFixture]
    public class Find : CreditNotesTest
    {
        [Test]
        public async Task find_all_creditnotes()
        {
            await Given_a_creditnote();

            Assert.True((await Api.CreditNotes.FindAsync()).Any());
        }

        [Test]
        public async Task find_by_id()
        {
            var expected = (await Given_a_creditnote()).Id;
            var id = (await Api.CreditNotes.FindAsync(expected)).Id;

            Assert.AreEqual(expected, id);
        }

        [Test]
        public async Task find_by_value()
        {
            await Given_a_creditnote();

            var creditnote = (await Api.CreditNotes
                .Where("Type == \"ACCPAYCREDIT\"")
                .FindAsync())
                .First()
                .Type;

            Assert.AreEqual(CreditNoteType.AccountsPayable, creditnote);
        }

        [Test]
        public async Task find_orderby_value()
        {
            await Given_a_creditnote();

            var creditNote = (await Api.CreditNotes
                .OrderBy("Type")
                .FindAsync())
                .First()
                .Type;

            Assert.AreEqual(CreditNoteType.AccountsPayable, creditNote);
        }
    }
}
