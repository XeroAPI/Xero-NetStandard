using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Model.Types;
using Xero.Api.Infrastructure.Exceptions;

namespace CoreTests.Integration.Invoices
{
    [TestFixture]
    public class SummarizeErrors : InvoicesTest
    {
        [Test]
        public async Task summariseErrors_gives_200()
        {
            var invoices = (await Given_a_bad_invoice(summariseErrors: false)).ToList();

            Assert.True(invoices.Count(p => p.ValidationStatus == ValidationStatus.Error) == 1);
            Assert.True(invoices.Count(p => p.ValidationStatus == ValidationStatus.Ok) == 1);
        }

        [Test]
        public void errors_gives_validation_exception()
        {
            Assert.ThrowsAsync<ValidationException>(() => Given_a_bad_invoice());
        }

        private async Task<IEnumerable<Invoice>> Given_a_bad_invoice(InvoiceType type = InvoiceType.AccountsPayable, InvoiceStatus status = InvoiceStatus.Draft, bool summariseErrors = true)
        {
            return await Api.Invoices.SummarizeErrors(summariseErrors).CreateAsync(new[]
            {
                new Invoice
                {
                    Contact = new Contact {Name = "ABC Bank"},
                    Type = type,
                    Date = DateTime.UtcNow,
                    DueDate = DateTime.UtcNow.AddDays(90),
                    LineAmountTypes = LineAmountType.Inclusive,
                    Status = status,
                    LineItems = new List<LineItem>
                    {
                        new LineItem
                        {
                            AccountCode = "200",
                            Description = "Good value item",
                            LineAmount = 100m
                        }
                    }
                },
                new Invoice
                {
                    Contact = new Contact
                    {
                        Name = "ABC Bank",
                        EmailAddress = "this_is_!_valid"
                    },
                    Type = type,
                    Date = DateTime.UtcNow,
                    DueDate = DateTime.UtcNow.AddDays(90),
                    LineAmountTypes = LineAmountType.Inclusive,
                    Status = status,
                    LineItems = new List<LineItem>
                    {
                        new LineItem
                        {
                            AccountCode = "200",
                            Description = "Good value item",
                            LineAmount = 100m
                        }
                    }
                }
            });
        }
    }
}
