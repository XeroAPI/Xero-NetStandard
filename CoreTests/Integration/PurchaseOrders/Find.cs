using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Status;

namespace CoreTests.Integration.PurchaseOrders
{
    public class Find : ApiWrapperTest
    {
        [Test]
        public async Task Find_a_purchase_order_by_Id()
        {
            var purchaseOrder = await Given_a_minimum_PurchaseOrder();

            var foundPurchaseOrder = await Api.PurchaseOrders.FindAsync(purchaseOrder.Id);

            Assert.AreEqual(purchaseOrder.Id, foundPurchaseOrder.Id);
        }

        [Test]
        public async Task Find_purchase_orders()
        {
            await Given_a_minimum_PurchaseOrder();

            var foundPurchaseOrders = await Api.PurchaseOrders.FindAsync();

            Assert.GreaterOrEqual(foundPurchaseOrders.Count(), 1);
        }

        [Test]
        public async Task Find_page_X_of_purchase_orders()
        {
            await Given_a_minimum_PurchaseOrder();

            var foundPurchaseOrders = await Api.PurchaseOrders.Page(1).FindAsync();

            Assert.GreaterOrEqual(foundPurchaseOrders.Count(), 1);
        }

        [Test]
        public async Task Filter_purchase_orders_by_status()
        {
            await Given_an_authorised_PurchaseOrder();

            var authorisedPurchaseOrders = await Api.PurchaseOrders.Status(PurchaseOrderStatus.Authorised).FindAsync();

            Assert.IsTrue(authorisedPurchaseOrders.All(p => p.Status == PurchaseOrderStatus.Authorised), "Expected all retrieved purchase orders to have status of Authorised");
        }

        [Test]
        public async Task Filter_purchase_orders_by_ModifiedSince()
        {
            var oldPurchaseOrder = await Given_a_minimum_PurchaseOrder();

            Thread.Sleep(1000);

            var date = DateTime.UtcNow;

            Thread.Sleep(1000);

            var newPurchaseOrder = await Given_a_minimum_PurchaseOrder();

            var retrievedPurchaseOrders = (await Api.PurchaseOrders.ModifiedSince(date).FindAsync()).ToList();

            Assert.True(retrievedPurchaseOrders.All(p => p.Id != oldPurchaseOrder.Id));
            Assert.True(retrievedPurchaseOrders.Any(p => p.Id == newPurchaseOrder.Id));
        }

        [Test]
        public async Task Filter_purchase_orders_by_DateFrom()
        {
            var oldPurchaseOrder = await Given_a_minimum_PurchaseOrder(DateTime.Today.AddDays(-7));

            var newPurchaseOrder = await Given_a_minimum_PurchaseOrder(DateTime.Today);

            var inbetweenDate = DateTime.Today.AddDays(-3);
            
            var retrievedPurchaseOrders = (await Api.PurchaseOrders.DateFrom(inbetweenDate).FindAsync()).ToList();

            Assert.True(retrievedPurchaseOrders.All(p => p.Id != oldPurchaseOrder.Id));
            Assert.True(retrievedPurchaseOrders.Any(p => p.Id == newPurchaseOrder.Id));
        }

        [Test]
        public async Task Filter_purchase_orders_by_DateTo()
        {
            var oldPurchaseOrder = await Given_a_minimum_PurchaseOrder(DateTime.Today.AddDays(-7));

            var newPurchaseOrder = await Given_a_minimum_PurchaseOrder(DateTime.Today);

            var inbetweenDate = DateTime.Today.AddDays(-3);

            var retrievedPurchaseOrders = (await Api.PurchaseOrders.DateTo(inbetweenDate).FindAsync()).ToList();

            Assert.True(retrievedPurchaseOrders.All(p => p.Id != newPurchaseOrder.Id));
            Assert.True(retrievedPurchaseOrders.Any(p => p.Id == oldPurchaseOrder.Id));
        }

        [Test]
        public async Task Filter_purchase_orders_by_a_DateFrom_DateTo_date_range()
        {
            var oldPurchaseOrder = await Given_a_minimum_PurchaseOrder(DateTime.Today.AddDays(-7));

            var midPurchaseOrder = await Given_a_minimum_PurchaseOrder(DateTime.Today.AddDays(-4));

            var newPurchaseOrder = await Given_a_minimum_PurchaseOrder(DateTime.Today);

            var dateFrom = DateTime.Today.AddDays(-5);
            var dateTo = DateTime.Today.AddDays(-3);

            var retrievedPurchaseOrders = (await Api.PurchaseOrders
                .DateFrom(dateFrom)
                .DateTo(dateTo)
                .FindAsync()).ToList();

            Assert.True(retrievedPurchaseOrders.All(p => p.Id != newPurchaseOrder.Id));
            Assert.True(retrievedPurchaseOrders.All(p => p.Id != oldPurchaseOrder.Id));

            Assert.True(retrievedPurchaseOrders.Any(p => p.Id == midPurchaseOrder.Id));

        }

        [Test]
        public async Task Use_multiple_filters_to_find_Purchase_orders()
        {
            var purchaseOrders = await Api.PurchaseOrders
                .DateFrom(DateTime.Today.AddDays(-7))
                .DateTo(DateTime.Today.AddDays(-1))
                .Status(PurchaseOrderStatus.Authorised)
                .Page(1)
                .FindAsync();

            Assert.GreaterOrEqual(purchaseOrders.Count(), 1);
        }

        private async Task<PurchaseOrder> Given_a_minimum_PurchaseOrder(DateTime? date = null)
        {
            var purchaseOrder = await Api.PurchaseOrders.CreateAsync(new PurchaseOrder
            {
                Date = date ?? DateTime.Today,
                Contact = (await Api.Contacts.FindAsync()).First()
            });
            return purchaseOrder;
        }

        private async Task<PurchaseOrder> Given_an_authorised_PurchaseOrder()
        {
            var purchaseOrder = await Api.PurchaseOrders.CreateAsync(new PurchaseOrder
            {
                Status = PurchaseOrderStatus.Authorised,
                Date = DateTime.Today,
                Contact = (await Api.Contacts.FindAsync()).First(),
                LineItems = new List<LineItem>()
                {
                    new LineItem
                    {
                        Description = "An item I want to purchase",
                        UnitAmount = 1,
                        Quantity = 1,

                    }
                }
            });
            return purchaseOrder;
        }



    }
}
