using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.Items.TrackedItems
{
    public class TrackedInventoryTest : ApiWrapperTest
    {
        protected Item CreatedItem;
        protected Invoice CreatedAccpayInvoice { get; set; }
        protected Invoice CreatedAccrecInvoice { get; set; }
        protected string InventoryAccountCode;
        protected string DirectCostsAccountCode;
        protected string RevenueAccountCode;

        public async Task Given_a_tracked_item()
        {
            if (string.IsNullOrEmpty(InventoryAccountCode))
            {
                await Given_an_inventory_account();
            }

            if (string.IsNullOrEmpty(DirectCostsAccountCode))
            {
                await Given_a_direct_cost_account();
            }

            if (string.IsNullOrEmpty(RevenueAccountCode))
            {
                await Given_a_revenue_account();
            }

            var code = "Tracked Item" + Random.GetRandomString(10);

            var item = await Api.Items.CreateAsync(new Item
            {
                Code = code,
                Description = "Sell me",
                PurchaseDescription = "Purchase me",
                PurchaseDetails = new PurchaseDetails
                {
                    UnitPrice = 75.5555m,
                    TaxType = "INPUT2",
                    COGSAccountCode = DirectCostsAccountCode
                },
                SalesDetails = new SalesDetails
                {
                    UnitPrice = 1020.5555m,
                    AccountCode = RevenueAccountCode,
                    TaxType = "OUTPUT2"
                },

                Name = "Full Tracked Item",
                InventoryAssetAccountCode = InventoryAccountCode,
                IsSold = true,
                IsPurchased = true
            });

            CreatedItem = item;
        }

        public async Task Given_an_untracked_item()
        {
            if (string.IsNullOrEmpty(DirectCostsAccountCode))
            {
                await Given_a_direct_cost_account();
            }

            if (string.IsNullOrEmpty(RevenueAccountCode))
            {
                await Given_a_revenue_account();
            }

            var code = "Untracked Item" + Random.GetRandomString(10);

            var item = await Api.Items.CreateAsync(new Item
            {
                Code = code,
                Description = "Sell me",
                PurchaseDescription = "Purchase me",
                PurchaseDetails = new PurchaseDetails
                {
                    UnitPrice = 75.5555m,
                    TaxType = "INPUT2",
                    AccountCode = DirectCostsAccountCode
                },
                SalesDetails = new SalesDetails
                {
                    UnitPrice = 1020.5555m,
                    AccountCode = RevenueAccountCode,
                    TaxType = "OUTPUT2"
                },

                Name = "Untracked Item",
                IsSold = true,
                IsPurchased = true
            });

            CreatedItem = item;
        }

        protected async Task Given_a_direct_cost_account()
        {
            var directCostsAccount = (await Api.Accounts.Where("Type == \"DIRECTCOSTS\"").FindAsync()).FirstOrDefault();

            if (directCostsAccount == null)
            {
                directCostsAccount = await Api.Accounts.CreateAsync(new Account
                {
                    Code = Random.GetRandomString(10),
                    Type = AccountType.DirectCosts,
                    Description = "Direct costs account",
                    Name = "Direct costs account"
                });
            }

            DirectCostsAccountCode = directCostsAccount.Code;
        }

        protected async Task Given_a_revenue_account()
        {
            var revenueAccount = (await Api.Accounts.Where("Type == \"REVENUE\"").FindAsync()).FirstOrDefault();

            if (revenueAccount == null)
            {
                revenueAccount = await Api.Accounts.CreateAsync(new Account
                {
                    Code = Random.GetRandomString(10),
                    Type = AccountType.Revenue,
                    Description = "Revenue account",
                    Name = "Revenue account"
                });
            }

            RevenueAccountCode = revenueAccount.Code;
        }

        protected async Task Given_an_inventory_account()
        {
            var inventoryAccount = (await Api.Accounts.Where("Type == \"INVENTORY\"").FindAsync()).FirstOrDefault();

            if (inventoryAccount == null)
            {
                inventoryAccount = await Api.Accounts.CreateAsync(new Account
                {
                    Code = Random.GetRandomString(10),
                    Type = AccountType.Inventory,
                    Description = "The account to hold all the things",
                    Name = "My inventory account"
                });
            }

            InventoryAccountCode = inventoryAccount.Code;
        }

        protected async Task Given_an_ACCPAY_invoice_using_the_item_with_code(string code)
        {
            var invoice = new Invoice
            {
                Contact = new Contact { Name = "ABC Bank" },
                Type = InvoiceType.AccountsPayable,
                Date = DateTime.UtcNow,
                DueDate = DateTime.UtcNow.AddDays(90),
                LineAmountTypes = LineAmountType.Inclusive,
                Status = InvoiceStatus.Authorised,
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        ItemCode = code,
                        AccountCode = InventoryAccountCode,
                        Quantity = 2
                    }
                }

            };

            CreatedAccpayInvoice = await Api.Invoices.CreateAsync(invoice);
        }


        protected async Task Given_a_zero_total_ACCPAY_invoice_using_the_item_with_code(string code)
        {
            var invoice = new Invoice
            {
                Contact = new Contact { Name = "ABC Bank" },
                Type = InvoiceType.AccountsPayable,
                Date = DateTime.UtcNow,
                DueDate = DateTime.UtcNow.AddDays(90),
                LineAmountTypes = LineAmountType.Inclusive,
                Status = InvoiceStatus.Authorised,
				LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        ItemCode = code,
                        AccountCode = InventoryAccountCode,
                        Quantity = 2
                    },
                    new LineItem
                    {
                        Description = "Inventory Adjustment",
                        AccountCode = DirectCostsAccountCode, //Using this account for the example. You would probably have your own inventory adjustments account
                        Quantity = 2,
                        UnitAmount = CreatedItem.PurchaseDetails.UnitPrice * -1
                    }
                }
                
            };

            CreatedAccpayInvoice = await Api.Invoices.CreateAsync(invoice);
        }

        protected async Task Given_an_ACCREC_invoice_using_the_item_with_code(string code)
        {
            var invoice = new Invoice
            {
                Contact = new Contact { Name = "ABC Bank" },
                Type = InvoiceType.AccountsReceivable,
                Date = DateTime.UtcNow,
                DueDate = DateTime.UtcNow.AddDays(90),
                LineAmountTypes = LineAmountType.Inclusive,
                Status = InvoiceStatus.Authorised,
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        ItemCode = code,
                        AccountCode = RevenueAccountCode,
                        Quantity = 2
                    }
                }
            };

            CreatedAccrecInvoice = await Api.Invoices.CreateAsync(invoice);
        }

        protected async Task Given_a_zero_total_ACCREC_invoice_using_the_item_with_code(string code)
        {
            var invoice = new Invoice
            {
                Contact = new Contact { Name = "ABC Bank" },
                Type = InvoiceType.AccountsReceivable,
                Date = DateTime.UtcNow,
                DueDate = DateTime.UtcNow.AddDays(90),
                LineAmountTypes = LineAmountType.Inclusive,
                Status = InvoiceStatus.Authorised,
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        ItemCode = code,
                        AccountCode = RevenueAccountCode,
                        Quantity = 2
                    },
                    new LineItem
                    {
                        Description = "Inventory Adjustment",
                        AccountCode = DirectCostsAccountCode, //Using this account for the example. You would probably want to have your own inventory adjustments account
                        Quantity = 2,
                        UnitAmount = CreatedItem.PurchaseDetails.UnitPrice * -1
                    }
                }

            };

            CreatedAccrecInvoice = await Api.Invoices.CreateAsync(invoice);
        }
    }
}