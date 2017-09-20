using System;
using System.Collections.Generic;
using System.Linq;
using Xero.Api.Core;

namespace Xero.Api.Example.Counts
{
    internal class Lister
    {
        private readonly IXeroCoreApi _api;

        public Lister(IXeroCoreApi api)
        {
            _api = api;
        }

        public void List()
        {
            Console.WriteLine("Your organisation is called {0}", _api.FindOrganisationAsync().Result.LegalName);

            Console.WriteLine("There are {0} accounts", _api.Accounts.FindAsync().Result.Count());
            Console.WriteLine("There are {0} bank transactions", _api.BankTransactions.FindAsync().Result.Count());
            Console.WriteLine("There are {0} bank transfers", _api.BankTransfers.FindAsync().Result.Count());
            Console.WriteLine("There are {0} branding themes", _api.BrandingThemes.FindAsync().Result.Count());
            Console.WriteLine("There are {0} contacts", GetTotalContactCount());
            Console.WriteLine("There are {0} credit notes", _api.CreditNotes.FindAsync().Result.Count());
            Console.WriteLine("There are {0} currencies", _api.Currencies.FindAsync().Result.Count());
            Console.WriteLine("There are {0} employees", _api.Employees.FindAsync().Result.Count());
            Console.WriteLine("There are {0} expense claims", _api.ExpenseClaims.FindAsync().Result.Count());
            Console.WriteLine("There are {0} defined items", _api.Items.FindAsync().Result.Count());
            Console.WriteLine("There are {0} invoices", GetTotalInvoiceCount());
            Console.WriteLine("There are {0} journal entries", _api.Journals.FindAsync().Result.Count());
            Console.WriteLine("There are {0} manual journal entries", _api.ManualJournals.FindAsync().Result.Count());
            Console.WriteLine("There are {0} payments", _api.Payments.FindAsync().Result.Count());
            Console.WriteLine("There are {0} receipts", _api.Receipts.FindAsync().Result.Count());
            Console.WriteLine("There are {0} repeating invoices", _api.RepeatingInvoices.FindAsync().Result.Count());
            Console.WriteLine("There are {0} tax rates", _api.TaxRates.FindAsync().Result.Count());
            Console.WriteLine("There are {0} tracking categories", _api.TrackingCategories.FindAsync().Result.Count());
            Console.WriteLine("There are {0} users", _api.Users.FindAsync().Result.Count());

            
            ListReports(_api.Reports.Named(), "named");
            ListReports(_api.Reports.PublishedAsync().Result, "published");

            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        private int GetTotalContactCount()
        {
            int count = _api.Contacts.FindAsync().Result.Count();
            int total = count;
            int page = 2;

            while(count == 100)
            {
                count = _api.Contacts.Page(page++).FindAsync().Result.Count();
                total += count;
            }

            return total;
        }

        private int GetTotalInvoiceCount()
        {
            int count = _api.Invoices.FindAsync().Result.Count();
            int total = count;
            int page = 2;

            while (count == 100)
            {
                count = _api.Invoices.Page(page++).FindAsync().Result.Count();
                total += count;
            }

            return total;
        }

        private void ListReports(IEnumerable<string> reports, string name)
        {
            var enumerable = reports as IList<string> ?? reports.ToList();
            Console.WriteLine("There are {0} {1} reports", enumerable.Count(), name);
                
            if (enumerable.Any())
            {
                Console.WriteLine("Named:");
                foreach (var r in enumerable)
                {
                    Console.WriteLine("\t{0}", r);
                }
            }
        }
    }
}