using System;
using System.Collections.Generic;
using System.Linq;
using Xero.Api.Core;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;
using Xero.Api.Example.Creation.Creator;

namespace Xero.Api.Example.Creation
{
    internal class ApiDataCreation
    {
        private readonly XeroCoreApi _api;

        public ApiDataCreation(XeroCoreApi api)
        {
            _api = api;
        }

        public void Create(int invoiceCount, int maxLineItems, IEnumerable<Name> peopleNames, IEnumerable<Address> places, IEnumerable<string> descriptions)
        {
            var contacts = CreateContacts(peopleNames, places).ToList();
            PopulateContacts(contacts);

            var invoices = CreateInvoices(invoiceCount, maxLineItems, contacts, descriptions).ToList();
            PopulateInvoices(invoices);

            Console.WriteLine("There are {0} contacts", GetTotalContactCount());
            Console.WriteLine("Created {0} contacts in last 24 hours", _api.Contacts.ModifiedSince(DateTime.UtcNow.AddDays(-1)).FindAsync().Result.Count());
            Console.WriteLine("There are {0} invoicess", GetTotalInvoiceCount());
            Console.WriteLine("Created {0} invoices in last 24 hours", _api.Invoices.ModifiedSince(DateTime.UtcNow.AddDays(-1)).FindAsync().Result.Count());            
            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        private int GetTotalContactCount()
        {
            int count = _api.Contacts.FindAsync().Result.Count();
            int total = count;
            int page = 2;

            while (count == 100)
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

        private void PopulateInvoices(IEnumerable<Invoice> invoices)
        {
            var invoiceCount = invoices.Count();

            const int pageSize = 20;
            var pages = (invoiceCount / pageSize) + 1;

            Console.WriteLine("Creating invoices");
            for (var i = 0; i < pages; i++)
            {
                var items = _api.CreateAsync(invoices.Skip(i * pageSize).Take(pageSize)).Result;
                Console.WriteLine("Created {0} invoices", items.Count());
            }

            Console.WriteLine("Finished creating {0} invoices", invoiceCount);
        }

        private void PopulateContacts(IEnumerable<Contact> contacts)
        {
            var contactCount = contacts.Count();
            const int pageSize = 20;
            var pages = (contactCount / pageSize) + 1;

            Console.WriteLine("Creating contacts");
            for (var i = 0; i < pages; i++)
            {
                var items = _api.CreateAsync(contacts.Skip(i * pageSize).Take(pageSize)).Result;
                Console.WriteLine("Created {0} contacts", items.Count());
            }

            Console.WriteLine("Finished creating {0} contacts", contactCount);
        }

        private IEnumerable<Invoice> CreateInvoices(int invoiceCount, int maxLineItems, IEnumerable<Contact> contacts, IEnumerable<string> descriptions)
        {
            var items = new List<Invoice>();

            var rnd = new Random();

            var contactList = contacts.ToList();

            for (var i = 0; i < invoiceCount; i++)
            {
                var date = DateTime.UtcNow.AddDays(-rnd.Next(1, 600)).Date;

                var contact = contactList[rnd.Next(1, contactList.Count)];

                items.Add(new Invoice
                {
                    Contact = new Contact { Name = contact.Name },
                    Type = Heads(rnd) ? InvoiceType.AccountsPayable : InvoiceType.AccountsReceivable,
                    Date = date,
                    DueDate = date.AddDays(90),
                    LineAmountTypes = Heads(rnd) ? LineAmountType.Inclusive : LineAmountType.Exclusive,
                    LineItems = CreateLineItems(maxLineItems, descriptions).ToList()
                });
            }

            return items;
        }

        private static IEnumerable<LineItem> CreateLineItems(int max, IEnumerable<string> descriptions)
        {
            var items = new List<LineItem>();

            var descriptionList = descriptions.ToList();

            var rnd = new Random();
            var count = rnd.Next(1, max);

            for (var i = 0; i < count; i++)
            {
                items.Add(new LineItem
                {
                    Quantity = rnd.Next(1, 10),
                    AccountCode = "200",
                    Description = descriptionList[rnd.Next(1, descriptionList.Count)],
                    UnitAmount = (decimal)(rnd.NextDouble() * 100) + 1
                });
            }

            return items;
        }

        private static IEnumerable<Contact> CreateContacts(IEnumerable<Name> names, IEnumerable<Address> places)
        {
            var contacts = new List<Contact>();

            var nameList = names.ToList();
            var placeList = places.ToList();

            for (var i = 0; i < placeList.Count(); i++)
            {
                var person = nameList[i];
                contacts.Add(new Contact
                {
                    FirstName = person.Given,
                    LastName = person.Family,
                    Name = string.Format("{0} {1}", person.Given, person.Family),
                    Addresses = new List<Address>(new[] { placeList[i] })
                });
            }

            return contacts;
        }

        public bool Heads(Random rnd)
        {
            return rnd.NextDouble() * 2 >= 1;
        }
    }
}
