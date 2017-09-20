using NUnit.Framework;
using System;
using System.Threading.Tasks;
using Xero.Api.Core.Model;
using Xero.Api.Infrastructure.Exceptions;

namespace CoreTests.Integration.ContactGroups
{
    [TestFixture]
    public class Add_Contact : ContactGroupsTest
    {
        [Test]
        public async Task Can_I_add_a_contact_to_a_contactgroup()
        {
            var contactgroup = await Given_a_contactgroup();

            var contact = await Given_a_contact();

            Assert.DoesNotThrowAsync(() => Api.ContactGroups.AddContactAsync(contactgroup, contact));
        }

        [Test]
        public void But_not_with_a_group_like_this()
        {
            var nonexistentContactGroup = new ContactGroup
            {
                Id = Guid.Empty
            };

            Assert.ThrowsAsync<NotFoundException>(() => Api.ContactGroups.AddContactAsync(nonexistentContactGroup, new Contact {Id = Guid.NewGuid()}));
        }

    }
}
