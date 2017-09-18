using NUnit.Framework;

namespace CoreTests.Integration.ContactGroups
{
    [TestFixture]
    public class Remove_Contact : ContactGroupsTest
    {
        [Test]
        public void Can_remove_a_contact_from_a_contact_group()
        {
            var contactgroup = Given_a_contactgroup();

            var contact = Given_a_contact();

            Api.ContactGroups[contactgroup.Id].Add(contact);
            
            Api.ContactGroups[contactgroup.Id].Remove(contact.Id);

        }
    }
}
