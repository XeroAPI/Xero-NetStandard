using System;
using System.Threading.Tasks;
using CoreTests.Integration.Items.TrackedItems;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Infrastructure.Exceptions;

namespace CoreTests.Integration.Items
{
    [TestFixture]
    public class Delete : TrackedInventoryTest
    {
        [Test]
        public async Task you_can_delete_an_item()
        {
            await Given_a_tracked_item();

            await Api.Items.DeleteAsync(CreatedItem);

            Its_not_there_when_I_try_to_find_it(CreatedItem);
        }

        [Test]
        public async Task but_not_if_its_involved_in_a_transaction()
        {
            await Given_a_tracked_item();

            await Given_an_ACCPAY_invoice_using_the_item_with_code(CreatedItem.Code);

            When_I_try_to_Delete_it_400s();
        }

        [Test]
        public void and_it_will_404_if_you_try_to_delete_a_item_thats_not_there()
        {
            CreatedItem = new Item
            {
                Id = Guid.NewGuid()
            };

            When_I_try_to_Delete_it_404s();
        }


        private void When_I_try_to_Delete_it_404s()
        {
            Assert.ThrowsAsync<NotFoundException>(() => Api.Items.DeleteAsync(CreatedItem));
        }

        private void When_I_try_to_Delete_it_400s()
        {
            Assert.ThrowsAsync<ValidationException>(() => Api.Items.DeleteAsync(CreatedItem));
        }

        private void Its_not_there_when_I_try_to_find_it(Item theItem)
        {
            Assert.ThrowsAsync<NotFoundException>(() => Api.Items.FindAsync(theItem.Id));
        }
    }
}
