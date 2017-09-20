using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xero.Api.Core.Model;

namespace CoreTests.Integration.ContactGroups
{
    [TestFixture]
    public class Update : ContactGroupsTest
    {
        [Test]
        public async Task Can_I_change_the_name_of_a_contactgroup()
        {
            var contactgroup = await Given_a_contactgroup();

            var newName = "Marketing Group" + Guid.NewGuid();

            contactgroup.Name = newName;
            
            var result =  await Api.UpdateAsync(contactgroup);

            Assert.IsTrue(result.Name.StartsWith("Marketing Group"));
        }

        [Test]
        public async Task Can_I_append_contacts_to_a_contactgroup()
        {
            var contactgroup = await Given_a_contactgroup();

            var contact = await Given_a_contact();

            await Api.ContactGroups.AddContactAsync(contactgroup, contact);
            
            List<Contact> assign_4_more_contacts = new List<Contact>();
            assign_4_more_contacts.Add(await Given_a_contact());
            assign_4_more_contacts.Add(await Given_a_contact());
            assign_4_more_contacts.Add(await Given_a_contact());
            assign_4_more_contacts.Add(await Given_a_contact());

            Assert.DoesNotThrowAsync(() => Api.ContactGroups.AddContactsAsync(contactgroup, assign_4_more_contacts));
            
        }
    }
}
