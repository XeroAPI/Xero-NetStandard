using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.LinkedTransactions
{
    public class Find : LinkedTransactionTest
    {
        [Test]
        public async Task find_by_page()
        {
            await Given_a_basic_linked_transaction();
            var linkedTransactions = await Api.LinkedTransactions.Page(1).FindAsync();

            Assert.Greater(linkedTransactions.Count(), 0);
        }

        [Test]
        public async Task find_by_id()
        {
            await Given_a_basic_linked_transaction();
            var expected = LinkedTransactionId;

            var linkedTransaction = await Api.LinkedTransactions.FindAsync(expected);

            Assert.AreEqual(expected, linkedTransaction.Id);
        }

        [Test]
        public async Task find_by_source_transaction_id()
        {
            await Given_a_basic_linked_transaction();
            var sourceTransactionId = SourceId;

            var linkedTransactions = (await Api.LinkedTransactions.WhereSourceId(sourceTransactionId).FindAsync()).ToList();
            
            Assert.Greater(linkedTransactions.Count(), 0);
            Assert.AreEqual(sourceTransactionId, linkedTransactions.First().SourceTransactionID);
        }

        [Test]
        public async Task find_by_contact_id()
        {
            await Given_a_linked_transaction_assigned_to_a_contact();
            var contactId = ContactId;

            var linkedTransactions = (await Api.LinkedTransactions.WhereContactId(contactId).FindAsync()).ToList();

            Assert.Greater(linkedTransactions.Count(), 0);
            Assert.AreEqual(contactId, linkedTransactions.First().ContactID);
        }

        [Test]
        public async Task find_by_target_transaction_id()
        {
            await Given_a_fully_allocated_linked_transaction();
            var targetTransactionId = TargetId;

            var linkedTransactions = (await Api.LinkedTransactions.WhereTargetId(targetTransactionId).FindAsync()).ToList();

            Assert.Greater(linkedTransactions.Count(), 0);
            Assert.AreEqual(targetTransactionId, linkedTransactions.First().TargetTransactionID);
        }
    }
}
