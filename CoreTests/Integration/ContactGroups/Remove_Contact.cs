using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.ContactGroups
{
    [TestFixture]
    public class Remove_Contact : ContactGroupsTest
    {
        [Test]
        public async Task Can_remove_a_contact_from_a_contact_group()
        {
            var contactgroup = await Given_a_contactgroup();

            var contact = await Given_a_contact();

            await Api.ContactGroups.AddContactAsync(contactgroup, contact);

            Assert.DoesNotThrowAsync(() => Api.ContactGroups.RemoveContactAsync(contactgroup, contact));
        }
    }
}
