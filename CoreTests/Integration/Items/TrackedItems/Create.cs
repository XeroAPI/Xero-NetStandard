using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;

namespace CoreTests.Integration.Items.TrackedItems
{
    public class Create : TrackedInventoryTest
    {


        [Test]
        public async Task Can_create_an_item_with_minimal_properties()
        {
            await Given_an_inventory_account();
            await Given_a_direct_cost_account();

            var item = await Api.Items.CreateAsync(new Item
            {
                Code = "Tracked Item " + Random.GetRandomString(10),
                InventoryAssetAccountCode = InventoryAccountCode,
                PurchaseDetails = new PurchaseDetails
                {
                    COGSAccountCode = DirectCostsAccountCode
                }

            });

            Assert.True(item.IsTrackedAsInventory,
                "Expected the item to be tracked as inventory, but IsTrackedAsInventory is false");
        }

        [Test]
        public async Task Can_create_an_item_with_full_details()
        {
            await Given_an_inventory_account();
            await Given_a_direct_cost_account();
            await Given_a_revenue_account();

            var code = "Tracked Item " + Random.GetRandomString(10);

            var item = await Api.Items.CreateAsync(new Item
            {
                Code = code,
                Description = "Sell me",
                PurchaseDescription = "Purchase me",
                PurchaseDetails = new PurchaseDetails
                {
                    UnitPrice = 75.5555m,
                    TaxType = "INPUT2",
                    COGSAccountCode = DirectCostsAccountCode
                },
                SalesDetails = new SalesDetails
                {
                    UnitPrice = 1020.5555m,
                    AccountCode = RevenueAccountCode,
                    TaxType = "OUTPUT2"
                },

                Name = "Full Tracked Item",
                InventoryAssetAccountCode = InventoryAccountCode,
                IsSold = true,
                IsPurchased = true
            });

            Assert.True(item.Id != Guid.Empty);
            Assert.True(item.IsTrackedAsInventory = true);
            Assert.AreEqual(item.Code, code,
                string.Format("Expected the create item's code '{0}' to equal '{1}', but were not equal", item.Code,
                    code));
        }
    }

}
