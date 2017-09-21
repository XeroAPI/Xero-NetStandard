using NUnit.Framework;

namespace CoreTests.Unit
{
    [TestFixture]
    public class Contacts : ApiWrapperTest
    {
        [Test]
        public void include_archived()
        {
            const string expected = "page=1&includeArchived=true";

            var query = Api.Contacts.IncludeArchived(true)
                .QueryString;

            Assert.AreEqual(expected, query);
        }

        [Test]
        public void exclude_archived_explict()
        {
            const string expected = "page=1";

            var query = Api.Contacts.IncludeArchived(false)
                .QueryString;

            Assert.AreEqual(expected, query);
        }

        [Test]
        public void exclude_archived_implict()
        {
            const string expected = "page=1";

            var query = Api.Contacts.QueryString;

            Assert.AreEqual(expected, query);
        }

        [Test]
        public void Concurrent_requests_can_use_different_query_strings()
        {
            const string expected1 = "page=2&includeArchived=true";
            const string expected2 = "page=3&includeArchived=true";

            var query1 = Api.Contacts.Page(2).IncludeArchived(true).QueryString;
            var query2 = Api.Contacts.Page(3).IncludeArchived(true).QueryString;

            Assert.AreEqual(expected1, query1);
            Assert.AreEqual(expected2, query2);
        }
    }
}