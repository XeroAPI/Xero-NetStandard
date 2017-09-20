using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.Contacts
{
    public class Update : ContactsTest
    {
        [Test]
        public async Task update_contact()
        {
            var id = (await Given_a_contact()).Id;

            var changes = new Contact
            {
                Id = id,

                ContactNumber = "ID001" + Guid.NewGuid().ToString("N"),
                Name = "ABC Limited " + Guid.NewGuid().ToString("N"),
                FirstName = "John",
                LastName = "Smith",
                EmailAddress = "john.smith@gmail.com",
                BankAccountDetails = "01-0123-0123456-00",
                TaxNumber = "12-345-678",
                AccountsReceivableTaxType = "OUTPUT",
                AccountsPayableTaxType = "INPUT",
                DefaultCurrency = "NZD",
                Addresses = new List<Address>
                    {
                        new Address
                        {
                            AddressType = AddressType.PostOfficeBox,
                            AddressLine1 = "P O Box 123",
                            City = "Wellington",
                            PostalCode = "6011"
                        }
                    }
            };

            var updated = await Api.UpdateAsync(changes);

            Assert.IsTrue(updated.Name.StartsWith("ABC"));
            Assert.IsTrue(updated.ContactNumber.StartsWith("ID001"));
            Assert.AreEqual("John", updated.FirstName);
            Assert.AreEqual("Smith", updated.LastName);
            Assert.AreEqual("john.smith@gmail.com", updated.EmailAddress);
            Assert.AreEqual("01-0123-0123456-00", updated.BankAccountDetails);
            Assert.AreEqual("NZD", updated.DefaultCurrency);
            Assert.AreEqual("Wellington", updated.Addresses.Single(p => p.AddressType == AddressType.PostOfficeBox).City);
        }
    }
}
