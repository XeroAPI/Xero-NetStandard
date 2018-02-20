using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.HistoryAndNotes
{
    public class CreateNotes : HistoryAndNotesTest
    {
        [Test]
        public async Task Can_create_notes()
        {
            var date = DateTime.UtcNow;
            const string details = "Details";

            await Given_a_contact();

            await Given_a_note_with_this_date_and_details(date, details);

            await When_I_retrieve_history_and_notes_for_the_contact();

            Then_there_is_a_note_with_the_correct_details(date, details);
        }
    }
}
