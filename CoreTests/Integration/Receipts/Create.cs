using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.Receipts
{
    [TestFixture]
    public class Create : ReceiptTest
    {
        [Test]
        public async Task create_receipt()
        {
            var contact = Random.GetRandomString(10);
            var description = Random.GetRandomString(30);
            const decimal value = 13.8m;

            var user = await Api.Users.FindAsync();

            var receipt = await Given_a_receipt(user.First().Id, contact, description, value, "420");

            Assert.AreEqual(receipt.Total, value);
            Assert.AreEqual(receipt.Contact.Name, contact);
            Assert.AreEqual(receipt.LineItems[0].Description, description);
        }
    }
}

