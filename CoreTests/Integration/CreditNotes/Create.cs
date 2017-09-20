using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.CreditNotes
{
    [TestFixture]
    public class Create : CreditNotesTest
    {
        [Test]
        public async Task create_creditnote()
        {
            const CreditNoteType expected = CreditNoteType.AccountsReceivable;

            var type = (await Given_a_creditnote(type: expected)).Type;

            Assert.AreEqual(expected, type);
        }
    }
}
   
