using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.Invoices
{
    [TestFixture]
    public class Create : InvoicesTest
    {
        [Test]
        public async Task simple_create_works()
        {
            var invoice = await Given_an_invoice();

            Assert.True(invoice.Id != Guid.Empty);
        }

        [Test]
        public async Task description_only_items_work()
        {
            const InvoiceType expected = InvoiceType.AccountsPayable;
            var type = (await Given_a_description_only_invoice()).Type;

            Assert.AreEqual(expected, type);
        }

        [Test]
        public async Task accounts_receivable()
        {
            const InvoiceType expected = InvoiceType.AccountsReceivable;
            var type = (await Given_a_description_only_invoice(expected)).Type;

            Assert.AreEqual(expected, type);
        }

        [Test]
        public async Task lineItemId_is_returned()
        {
            var invoce = await Given_an_invoice();

            Assert.NotNull(invoce.LineItems.FirstOrDefault().LineItemId);
        }

        [Test]
        public async Task multiple_lineitems()
        {
            var invoice = await Api.CreateAsync(new Invoice
            {
                Contact = new Contact { Name = "ABC Limited" },
                Type = InvoiceType.AccountsReceivable,
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        AccountCode = "200",
                        Description = "Good value item",
                        UnitAmount = 25.6m,
                        Quantity = 1m
                    },
                    new LineItem
                    {
                        AccountCode = "200",
                        Description = "Another good value item",
                        UnitAmount = 125.65m,
                        Quantity = 5m
                    }
                }
            });

            Assert.True(invoice.Id != Guid.Empty);
            Assert.AreEqual(InvoiceType.AccountsReceivable, invoice.Type);
			Assert.AreEqual(2, invoice.LineItems.Count());
        }

        [Test]
        public async Task multiple_invoices()
        {
            var invoices = (await Api.CreateAsync(new[]
            {
                new Invoice
                {
                    Contact = new Contact { Name = "ABC Limited" },
                    Type = InvoiceType.AccountsReceivable,
                    LineItems = new List<LineItem>
                    {
                        new LineItem
                        {
                            AccountCode = "200",
                            Description = "Good value item",
                            UnitAmount = 25.6m,
                            Quantity = 1m
                        }
                    }
                },
                new Invoice
                {
                    Contact = new Contact { Name = "Jack" },
                    Type = InvoiceType.AccountsReceivable,
                    LineItems = new List<LineItem>
                    {
                        new LineItem
                        {
                            AccountCode = "150",
                            Description = "Other Sales Item",
                            UnitAmount = 120.5m,
                            Quantity = 5m
                        }
                    }
                }
            })).ToList();

            Assert.AreEqual(2, invoices.Count());
            Assert.AreEqual(2, invoices.Select(p => p.Id).Count());
        }

        [Test]
        public async Task high_precision_unit()
        {
            var invoice = await Api.CreateAsync(
                new Invoice
                {
                    Contact = new Contact { Name = "ABC Limited" },
                    Type = InvoiceType.AccountsReceivable,
                    LineItems = new List<LineItem>
                    {
                        new LineItem
                        {
                            AccountCode = "200",
                            Description = "Good value item",
                            UnitAmount = 25.6591m,
                            Quantity = 1m
                        }
                    }
                });

			Assert.AreEqual(25.6591m, invoice.LineItems.First().UnitAmount);
        }

        [Test]
        public async Task low_precision_unit()
        {
            var invoices = (await Api.Invoices.UseFourDecimalPlaces(false).CreateAsync(new[]
            {
                new Invoice
                {
                    Contact = new Contact { Name = "ABC Limited" },
                    Type = InvoiceType.AccountsReceivable,
                    LineItems = new List<LineItem>
                    {
                        new LineItem
                        {
                            AccountCode = "200",
                            Description = "Good value item",
                            UnitAmount = 25.6591m,
                            Quantity = 1m
                        }
                    }
                }                
            })).ToList();

			Assert.AreEqual(25.66m, invoices.First().LineItems.First().UnitAmount);
        }

        [Test]
        public async Task full_example_line_items_with_tracking_categories()
        {
            const string name = "Region";
            const string option = "North";
            const string currency = "NZD";
            const string url = "http://accounting20.com/";

            var category = new Guid("351953c4-8127-4009-88c3-f9cd8c9cbe9f");
            var dueDate = DateTime.Now.AddDays(30).Date;
            var paymentDate = DateTime.Now.AddDays(20).Date;
            var reference = "Ref:" + Random.GetRandomString(10);
            
            var invoices = (await Api.Invoices.CreateAsync(new[]
            {
                new Invoice
                {
                    Contact = new Contact { Name = "Ariki Properties" },
                    DueDate = dueDate,
                    ExpectedPaymentDate = paymentDate,
                    Type = InvoiceType.AccountsReceivable,
                    LineAmountTypes = LineAmountType.Inclusive,
                    CurrencyCode = currency,
                    Number = Random.GetRandomString(10),
                    Reference = reference,
                    BrandingThemeId = new Guid("4c82c365-35cb-467f-bb11-dce1f2f2f67c"),
                    Url = url,
                    Status = InvoiceStatus.Submitted,
                    TotalTax = 10.89m,
                    SubTotal = 87.11m,
                    Total = 98.00m,
                    LineItems = new List<LineItem>
                    {
                        new LineItem
                        {
                            AccountCode = "200",
                            Description = "3 copies of OS X 10.6 Snow Leopard",
                            UnitAmount = 59.00m,
                            Quantity = 3m,
                            TaxAmount = 19.97m,
                            TaxType = "OUTPUT2",
                            LineAmount = 177.00m,
                            Tracking = new ItemTracking
                            {
                                new ItemTrackingCategory
                                {
                                    Id = category,
                                    Name = name,
                                    Option = option
                                }
                            }
                        },
                        new LineItem
                        {
                            AccountCode = "200",
                            Description = "Returned Apple Keyboard with Numeric Keypad (faulty)",
                            UnitAmount = -79.00m,
                            Quantity = 1m,
                            TaxAmount = -8.78m,
                            TaxType = "OUTPUT2",                            
                        }
                    }
                }                
            })).ToList();

            var invoice = await Api.Invoices.FindAsync(invoices.First().Id);

			Assert.AreEqual(category, invoice.LineItems.First().Tracking[0].Id);
			Assert.AreEqual(name, invoice.LineItems.First().Tracking[0].Name);
			Assert.AreEqual(option, invoice.LineItems.First().Tracking[0].Option);
            Assert.AreEqual(dueDate, invoice.DueDate);
            Assert.AreEqual(paymentDate, invoice.ExpectedPaymentDate);
            Assert.AreEqual(reference, invoice.Reference);
            Assert.AreEqual(currency, invoice.CurrencyCode);
            Assert.AreEqual(url, invoice.Url);
        }

        [Test]
        public async Task lineitems_without_account_code()
        {
            var item = (await Api.Items
                .Where("Code.StartsWith(\"Woo-hoo\")")
                .And("Description != null")
                .FindAsync())
                .FirstOrDefault();

            if (item == null)
            {
                Assert.False(false, "No items");
            }

            var invoice = await Api.CreateAsync(new Invoice
            {
                Contact = new Contact { Name = "ABC Limited" },
                Type = InvoiceType.AccountsReceivable,
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        Description = item.Description,
                        ItemCode = item.Code
                    }
                }
            });

            Assert.True(invoice.Id != Guid.Empty);
            Assert.AreEqual(InvoiceType.AccountsReceivable, invoice.Type);
			Assert.AreEqual(1, invoice.LineItems.Count());
        }
    }
}