using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model.Status;

namespace CoreTests.Integration.Contacts
{
    [TestFixture]
    public class Find : ContactsTest
    {
        [Test]
        public async Task find_by_page()
        {
            await Given_a_contact();

            Assert.True((await Api.Contacts.Page(1).FindAsync()).Any());
        }

        [Test]
        public async Task find_by_id()
        {
            var expected = (await Given_a_contact()).Id;
            
            var id = (await Api.Contacts
                .FindAsync(expected))
                .Id;

            Assert.AreEqual(expected, id);
        }

        [Test]
        public async Task find_by_value()
        {
            var expected = (await Given_a_contact()).Name;

            var name = (await Api.Contacts
                .Where(string.Format("Name == \"{0}\"", expected))
                .FindAsync())
                .Select(p => p.Name);                

            Assert.True(name.All(p => p == expected));
        }

        [Test]
        public async Task find_by_contains_value()
        {
            var expected = (await Given_a_contact()).Name;

            var contacts = (await Api.Contacts
                .Where(string.Format("Name.Contains(\"{0}\")", expected))
                .FindAsync())
                .Select(p => p.Name);

            Assert.True(contacts.All(p => p.Contains(expected)));            
        }

        [Test]
        public async Task find_by_status()
        {
            await Given_a_contact();

            var status = (await Api.Contacts
                .Where("ContactStatus == \"ACTIVE\"")
                .FindAsync())
                .Select(p => p.ContactStatus);                

            Assert.True(status.All(p => p == ContactStatus.Active));
        }

        [Test]
        public async Task find_by_updated_date()
        {
            var expected = (await Given_a_contact()).Id;
            var date = DateTime.Today.AddDays(-5);

            var contacts = (await Api.Contacts
                .ModifiedSince(date)
                .OrderByDescending("UpdatedDateUTC")                
                .FindAsync())
                .Select(p => p.Id)
                .ToList();

            Assert.Greater(contacts.Count(), 0);
            Assert.Contains(expected, contacts);
        }
        
        [Test]
        public async Task find_by_dateRange()
        {
            var expected = (await Given_a_contact()).Id;
            var fromDate = DateTime.Today.AddDays(-1);
            var toDate = DateTime.Today.AddDays(1);

            var contacts = (await Api.Contacts
                .Where(string.Format("UpdatedDateUTC >= DateTime.Parse(\"{0}\")", fromDate.ToString("yyyy-MM-dd")))
                .And(string.Format("UpdatedDateUTC <= DateTime.Parse(\"{0}\")", toDate.ToString("yyyy-MM-dd")))
                .OrderByDescending("UpdatedDateUTC")
                .FindAsync())
                .Select(p => p.Id)
                .ToList();

            Assert.Greater(contacts.Count(), 0);
            Assert.Contains(expected, contacts);
        }

        [Test]
        public async Task find_by_id_list()
        {
            var contact = await Given_a_contact();
            var contacts = (await Api.Contacts.Ids(new[] { contact.Id }).FindAsync()).ToList();

            Assert.AreEqual(1, contacts.Count());
            Assert.AreEqual(contact.Id, contacts.First().Id);
        }
    }
}
