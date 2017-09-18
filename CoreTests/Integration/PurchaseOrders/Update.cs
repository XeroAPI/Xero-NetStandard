using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Status;

namespace CoreTests.Integration.PurchaseOrders
{
    public class Update : ApiWrapperTest
    {
        [Test]
        public void Can_update_a_PurchaseOrder_like_this()
        {
            var purchaseOrder = Given_a_PurchaseOrder();

            purchaseOrder.LineItems.Add(new LineItem
            {
                Description = "Another item I want to purchase",
                UnitAmount = 10,
                Quantity = 10
            });

            var updatedPurchaseOrder = Api.PurchaseOrders.Update(purchaseOrder);

            Assert.AreEqual(2, updatedPurchaseOrder.LineItems.Count);
        }


        public PurchaseOrder Given_a_PurchaseOrder()
        {
            return Api.PurchaseOrders.Create(
                new PurchaseOrder
                {
                    Status = PurchaseOrderStatus.Authorised,
                    Date = DateTime.Today,
                    Contact = new Contact { Id = ContactId },
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

        private Guid ContactId
        {
            get
            {
                return Api.Contacts.Find().First().Id;
            }
        }
    }
}
