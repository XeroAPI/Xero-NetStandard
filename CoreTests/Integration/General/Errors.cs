using System.Collections.Generic;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Infrastructure.Exceptions;

namespace CoreTests.Integration.General
{
    [TestFixture]
    public class Errors : ApiWrapperTest
    {
        [Test]
        public void not_found()
        {
            Assert.ThrowsAsync<NotFoundException>(() => Api.Invoices.FindAsync("ThisIsNotThere"));
        }

        [Test]
        public void bad_query()
        {
            Assert.ThrowsAsync<BadRequestException>(() => Api.Invoices.Where("Bob == Robert").FindAsync());
        }

        [Test]
        public void validation_error()
        {
            Assert.ThrowsAsync<ValidationException>(() => Api.Invoices.CreateAsync(new Invoice
            {
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        LineAmount = 101.01M
                    }
                }
            }));
        }
    }
}
