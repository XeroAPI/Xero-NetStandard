using System;
using System.Threading.Tasks;
using Xero.Api.Core.Model;

namespace CoreTests.Integration.ContactGroups
{
    public abstract class ContactGroupsTest : ApiWrapperTest
    {
        // need a contact in the system to use contact groups with.
        protected async Task<Contact> Given_a_contact()
        {
            return await Api.CreateAsync(new Contact
            {
                Name = "Peter " + Guid.NewGuid().ToString("N")
            });
        }
        protected async Task<ContactGroup> Given_a_contactgroup()
        {
            return await Api.ContactGroups.CreateAsync(new ContactGroup
            {
                Name = "Nice People " + Guid.NewGuid()

            });
        }
    }
}

