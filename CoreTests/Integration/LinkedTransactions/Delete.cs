using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Infrastructure.Exceptions;

namespace CoreTests.Integration.LinkedTransactions
{
    public class Delete : LinkedTransactionTest
    {
        [Test]
        public async Task can_delete_linked_transactions()
        {
            await Given_a_basic_linked_transaction();

            var id = LinkedTransactionId;

            await Api.LinkedTransactions.DeleteAsync(LinkedTransaction);

            //After deleting the linked transaction, it no longer exists so we exopect to get a 404 NotFound when looking for it.
            Assert.ThrowsAsync<NotFoundException>(() => Api.LinkedTransactions.FindAsync(id));
        }
    }
}
