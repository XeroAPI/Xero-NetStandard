using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.HistoryAndNotes
{
    public class HistoryAndNotesTest : ApiWrapperTest
    {
        private Contact _contact;
        private IEnumerable<HistoryRecord> _historyRecords;

        protected async Task Given_a_contact()
        {
            _contact = await Api.Contacts.CreateAsync(new Contact { Name = Guid.NewGuid().ToString() });
        }

        protected async Task Given_a_note_with_this_date_and_details(string details)
        {
            await Api.HistoryAndNotes.CreateNoteAsync(HistoryAndNotesEndpointCreateType.Contacts, _contact.Id,
                new HistoryRecord
                {
                    Details = details
                });
        }

        protected async Task When_I_retrieve_history_and_notes_for_the_contact()
        {
            _historyRecords = await Api.HistoryAndNotes.FindAsync(HistoryAndNotesEndpointRetrieveType.Contacts, _contact.Id);
        }

        protected void Then_there_are_some_history_records()
        {
            Assert.True(_historyRecords.Any(), "Expected some history records to be returned, but there were none");
        }

        protected void Then_there_is_a_note_with_the_correct_details(string details)
        {
            Assert.True(_historyRecords.Any(it => it.Details == details), "Expected a note with the expected details to be retunred but it was not");
        }
    }
}