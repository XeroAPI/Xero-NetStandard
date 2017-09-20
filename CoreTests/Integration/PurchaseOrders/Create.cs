using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Status;

namespace CoreTests.Integration.PurchaseOrders
{
    public class Create : ApiWrapperTest
    {
        [Test]
        public async Task Create_minimal_draft_purchase_order()
        {

            var purchaseOrder = await Api.PurchaseOrders.CreateAsync(
                new PurchaseOrder
                {
                    Date = DateTime.Today,
                    Contact = new Contact { Id = await ContactId() }
                }
            );

            Assert.True(purchaseOrder.Id != Guid.Empty);
            Assert.True(purchaseOrder.Status == PurchaseOrderStatus.Draft);
        }

        [Test]
        public async Task Create_authorised_purchase_order()
        {
            var purchaseOrder = await Api.PurchaseOrders.CreateAsync(
                new PurchaseOrder
                {
                    Status = PurchaseOrderStatus.Authorised,
                    Date = DateTime.Today,
                    Contact = new Contact{Id = await ContactId()},
                    LineItems = new List<LineItem>()
                    {
                        new LineItem
                        {
                            Description = "An item I want to purchase",
                            UnitAmount = 1,
                            Quantity = 1,

                        }
                    }
                }
            );

            Assert.True(purchaseOrder.Id != Guid.Empty);
            Assert.True(purchaseOrder.Status == PurchaseOrderStatus.Authorised);
        }

        private async Task<Guid> ContactId()
        {
            return (await Api.Contacts.FindAsync()).First().Id;
        }

        public async Task<PurchaseOrder> Given_a_purchase_order()
        {
            return await Api.PurchaseOrders.CreateAsync(
                new PurchaseOrder
                {
                    Status = PurchaseOrderStatus.Authorised,
                    Date = DateTime.Today,
                    Contact = new Contact { Id = await ContactId() },
                    LineItems = new List<LineItem>()
                    {
                        new LineItem
                        {
                            Description = "An item I want to purchase",
                            UnitAmount = 1,
                            Quantity = 1,

                        }
                    }
                }
            );
        }
    }
}
