using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;

namespace CoreTests.Integration.Items
{
    [TestFixture]
    public class Create : ApiWrapperTest
    {
        [Test]
        public async Task create_simple_item()
        {
            var code = "Woo-hoo " + Random.GetRandomString(10);

            var item = await Api.CreateAsync(new Item
            {
                Code = code
            });

            Assert.IsTrue(Guid.Empty != item.Id);
            Assert.AreEqual(code, item.Code);
        }

        [Test]
        public async Task create_full_item()
        {
            var code = "Woo-hoo " + Random.GetRandomString(10);

            var item = await Api.CreateAsync(new Item
            {
                Code = code,
                Description = "Buy cheap sell high",
                SalesDetails = new SalesDetails
                {
                    AccountCode = "200",
                    UnitPrice = 25.00m
                },
                PurchaseDetails = new PurchaseDetails
                {
                    AccountCode = "200",
                    UnitPrice = 15.0m
                }
            });

            Assert.IsTrue(Guid.Empty != item.Id);
            Assert.AreEqual(code, item.Code);
        }
    }
}
