using NUnit.Framework;

namespace CoreTests.Integration.General
{
    [TestFixture]
    public class FindingAllItems : ApiWrapperTest
    {
        [Test]
        public void get_accounts()
        {
            Assert.DoesNotThrowAsync(() => Api.Accounts.FindAsync());
        }

        [Test]
        public void get_bank_transactions()
        {
            Assert.DoesNotThrowAsync(() => Api.BankTransactions.FindAsync());
        }

        [Test]
        public void get_bank_transfers()
        {
            Assert.DoesNotThrowAsync(() => Api.BankTransfers.FindAsync());
        }

        [Test]
        public void get_branding_themes()
        {
            Assert.DoesNotThrowAsync(() => Api.BrandingThemes.FindAsync());
        }

        [Test]
        public void get_contacts()
        {
            Assert.DoesNotThrowAsync(() => Api.Contacts.FindAsync());
        }

        [Test]
        public void get_credit_notes()
        {
            Assert.DoesNotThrowAsync(() => Api.CreditNotes.FindAsync());
        }

        [Test]
        public void get_currencies()
        {
            Assert.DoesNotThrowAsync(() => Api.Currencies.FindAsync());
        }

        [Test]
        public void get_employees()
        {
            Assert.DoesNotThrowAsync(() => Api.Employees.FindAsync());
        }

        [Test]
        public void get_expense_claims()
        {
            Assert.DoesNotThrowAsync(() => Api.ExpenseClaims.FindAsync());
        }

        [Test]
        public void get_invoices()
        {
            Assert.DoesNotThrowAsync(() => Api.Invoices.FindAsync());
        }

        [Test]
        public void get_items()
        {
            Assert.DoesNotThrowAsync(() => Api.Items.FindAsync());
        }

        [Test]
        public void get_journals()
        {
            Assert.DoesNotThrowAsync(() => Api.Journals.FindAsync());
        }

        [Test]
        public void get_manual_journals()
        {
            Assert.DoesNotThrowAsync(() => Api.ManualJournals.FindAsync());
        }

        [Test]
        public void get_payments()
        {
            Assert.DoesNotThrowAsync(() => Api.Payments.FindAsync());
        }

        [Test]
        public void get_receipts()
        {
            Assert.DoesNotThrowAsync(() => Api.Receipts.FindAsync());
        }

        [Test]
        public void get_repeating_invoices()
        {
            Assert.DoesNotThrowAsync(() => Api.RepeatingInvoices.FindAsync());
        }

        [Test]
        public void get_tax_rates()
        {
            Assert.DoesNotThrowAsync(() => Api.TaxRates.FindAsync());
        }

        [Test]
        public void get_tracking_categories()
        {
            Assert.DoesNotThrowAsync(() => Api.TrackingCategories.FindAsync());
        }

        [Test]
        public void get_users()
        {
            Assert.DoesNotThrowAsync(() => Api.Users.FindAsync());
        }        
    }
}
