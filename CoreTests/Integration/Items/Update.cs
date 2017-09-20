using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;

namespace CoreTests.Integration.Items
{
    [TestFixture]
    public class Update : ApiWrapperTest
    {
        [Test]
        public async Task update_an_item()
        {
            var code = "Woo-hoo " + Random.GetRandomString(10);
            var the_item = await Api.CreateAsync(new Item
            {
                Code = code
            });

            var updated_item = await Api.UpdateAsync(new Item
            {
                Id = the_item.Id,
                Code = code,
                Description = "The Woo-hoo item",
                SalesDetails = new SalesDetails
                {
                    AccountCode = "200",
                    UnitPrice = 25.00m
                }                
            });

            Assert.IsTrue(Guid.Empty != updated_item.Id);
            Assert.AreEqual(code, the_item.Code);
            Assert.AreEqual(25.00m, updated_item.SalesDetails.UnitPrice);
        }
    }
}
