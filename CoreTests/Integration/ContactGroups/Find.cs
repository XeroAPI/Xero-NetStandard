using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.ContactGroups
{
    [TestFixture]
    public class Find : ContactGroupsTest
    {
        [Test]
        public async Task Can_Find_Contact_Group()
        {
            var contactGroup = await Given_a_contactgroup();

            var foundContactGroup = await Api.ContactGroups.FindAsync(contactGroup.Id);

            Assert.IsTrue(foundContactGroup.Name.StartsWith("Nice People"));
        }

        [Test]
        public async Task Can_Find_Contacts_in_Contact_Group()
        {
            var contactGroup = await Given_a_contactgroup();

            var contact = await Given_a_contact();

            await Api.ContactGroups.AddContactAsync(contactGroup, contact);

            var foundContactGroup = await Api.ContactGroups.FindAsync(contactGroup.Id);

            Assert.IsTrue(foundContactGroup.Name.StartsWith("Nice People"));
            Assert.IsTrue(foundContactGroup.Contacts.FirstOrDefault().Name.StartsWith("Peter"));
        }
    }
}
