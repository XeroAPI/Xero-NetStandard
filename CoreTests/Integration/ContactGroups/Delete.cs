using System.Collections.Generic;
using NUnit.Framework;
using Xero.Api.Core.Model;

namespace CoreTests.Integration.ContactGroups
{
    [TestFixture]
    public class Delete : ContactGroupsTest
    {
        [Test]
        public void Can_I_remove_the_contactgroup()
        {
            var contactgroup = Given_a_contactgroup();

            contactgroup.Status = "DELETED";

            var group = Api.Update(contactgroup);

            Assert.IsTrue(group.Status == "DELETED" );
        }

        [Test]
        public void Can_I_empty_the_contactgroup_of_contacts()
        {
            var contactgroup = Given_a_contactgroup();

            List<Contact> contacts = new List<Contact>();
            contacts.Add(Given_a_contact());
            contacts.Add(Given_a_contact());
            contacts.Add(Given_a_contact());
            contacts.Add(Given_a_contact());
            contacts.Add(Given_a_contact());

            Api.ContactGroups[contactgroup.Id].AddRange(contacts);

            Api.ContactGroups[contactgroup.Id].Clear();
        }
    }
}
