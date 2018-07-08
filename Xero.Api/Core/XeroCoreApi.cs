using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Common;
using Xero.Api.Core.Endpoints;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Setup;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Infrastructure.RateLimiter;
using Organisation = Xero.Api.Core.Model.Organisation;

namespace Xero.Api.Core
{
    public class XeroCoreApi : XeroApi, IXeroCoreApi
    {
        

        public XeroCoreApi(IAuthenticator auth, IXeroApiSettings applicationSettings, IUser user = null, IRateLimiter rateLimiter = null)
            : base(applicationSettings.BaseUrl, auth, new Consumer(applicationSettings.ConsumerKey, applicationSettings.ConsumerSecret), user, rateLimiter)
        {
            Connect();
        }

        public XeroCoreApi(IAuthenticator auth, IUser user = null, IRateLimiter rateLimiter = null)
            : this(auth, new XeroApiSettings(), user, rateLimiter)
        {
            Connect();
        }

        public XeroCoreApi(string baseUrl, IAuthenticator auth, IConsumer consumer, IUser user = null, IRateLimiter rateLimiter = null)
            : base(baseUrl, auth, consumer, user, rateLimiter)
        {
            Connect();
        }

        public IAccountsEndpoint Accounts { get; private set; }
        public AllocationsEndpoint Allocations { get; private set; }
        public AttachmentsEndpoint Attachments { get; private set; }
        public IBankTransactionsEndpoint BankTransactions { get; private set; }
        public IBankTransfersEndpoint BankTransfers { get; private set; }
        public IBrandingThemesEndpoint BrandingThemes { get; private set; }
        public IContactsEndpoint Contacts { get; private set; }
        public IContactGroupsEndpoint ContactGroups { get; private set;}
        public ICreditNotesEndpoint CreditNotes { get; private set; }
        public ICurrenciesEndpoint Currencies { get; set; }
        public IEmployeesEndpoint Employees { get; private set; }
        public IExpenseClaimsEndpoint ExpenseClaims { get; private set; }
        public IFilesEndpoint Files { get; private set; }
        public IFoldersEndpoint Folders { get; private set; }
        public IHistoryAndNotesEndpoint HistoryAndNotes { get; private set; }
        public IInboxEndpoint Inbox { get; private set; }
        public IAssociationsEndpoint Associations { get; private set; }
        public IInvoicesEndpoint Invoices { get; private set; }
        public IItemsEndpoint Items { get; private set; }
        public IJournalsEndpoint Journals { get; protected set; }
        public ILinkedTransactionsEndpoint LinkedTransactions { get; private set; }
        public IManualJournalsEndpoint ManualJournals { get; private set; }
        public IOrganisationEndpoint Organisations { get; set; }
        public IOverpaymentsEndpoint Overpayments { get; private set; }
        public IPaymentsEndpoint Payments { get; private set; }
        public PdfEndpoint PdfFiles { get; private set; }
        public IPrepaymentsEndpoint Prepayments { get; private set; }
        public IPurchaseOrdersEndpoint PurchaseOrders { get; private set; }
        public IReceiptsEndpoint Receipts { get; private set; }
        public IRepeatingInvoicesEndpoint RepeatingInvoices { get; private set; }
        public IReportsEndpoint Reports { get; private set; }
        public ISetupEndpoint Setup { get; private set; }
        public ITaxRatesEndpoint TaxRates { get; private set; }
        public ITrackingCategoriesEndpoint TrackingCategories { get; private set; }
        public IUsersEndpoint Users { get; private set; }


        private void Connect()
        {
            Organisations = new OrganisationEndpoint(Client);

            Accounts = new AccountsEndpoint(Client);
            Allocations = new AllocationsEndpoint(Client);
            Attachments = new AttachmentsEndpoint(Client);
            BankTransactions = new BankTransactionsEndpoint(Client);
            BankTransfers = new BankTransfersEndpoint(Client);
            BrandingThemes = new BrandingThemesEndpoint(Client);
            Contacts = new ContactsEndpoint(Client);
            ContactGroups = new ContactGroupsEndpoint(Client);
            CreditNotes = new CreditNotesEndpoint(Client);
            Currencies = new CurrenciesEndpoint(Client);
            Employees = new EmployeesEndpoint(Client);
            ExpenseClaims = new ExpenseClaimsEndpoint(Client);
            Files = new FilesEndpoint(Client);
            Folders = new FoldersEndpoint(Client);
            HistoryAndNotes = new HistoryAndNotesEndpoint(Client);
            Inbox = new InboxEndpoint(Client);
            Associations = new AssociationsEndpoint(Client);
            Invoices = new InvoicesEndpoint(Client);
            Items = new ItemsEndpoint(Client);
            Journals = new JournalsEndpoint(Client);
            LinkedTransactions = new LinkedTransactionsEndpoint(Client);
            ManualJournals = new ManualJournalsEndpoint(Client);
            Overpayments = new OverpaymentsEndpoint(Client);
            Payments = new PaymentsEndpoint(Client);
            PdfFiles = new PdfEndpoint(Client);
            Prepayments = new PrepaymentsEndpoint(Client);
            PurchaseOrders = new PurchaseOrdersEndpoint(Client);
            Receipts = new ReceiptsEndpoint(Client);
            RepeatingInvoices = new RepeatingInvoicesEndpoint(Client);
            Reports = new ReportsEndpoint(Client);
            Setup = new SetupEndpoint(Client);
            TaxRates = new TaxRatesEndpoint(Client);
            TrackingCategories = new TrackingCategoriesEndpoint(Client);
            Users = new UsersEndpoint(Client);
        }

        public async Task<Organisation> FindOrganisationAsync()
        {
            return (await Organisations.FindAsync().ConfigureAwait(false)).FirstOrDefault();
        }

        // Note: Due to the immutability of endpoints, If you want to use filtering etc you will need to make requests via the endpoints themselves, not using the sugar methods below

        #region Accounts

        public Task<IEnumerable<Account>> CreateAsync(IEnumerable<Account> items)
        {
            return Accounts.CreateAsync(items);
        }

        public Task<IEnumerable<Account>> UpdateAsync(IEnumerable<Account> items)
        {
            return Accounts.UpdateAsync(items);
        }

        public Task<Account> CreateAsync(Account item)
        {
            return Accounts.CreateAsync(item);
        }

        public Task<Account> UpdateAsync(Account item)
        {
            return Accounts.UpdateAsync(item);
        }

        #endregion

        #region BankTransactions

        public Task<IEnumerable<BankTransaction>> CreateAsync(IEnumerable<BankTransaction> items)
        {
            return BankTransactions.CreateAsync(items);
        }

        public Task<IEnumerable<BankTransaction>> UpdateAsync(IEnumerable<BankTransaction> items)
        {
            return BankTransactions.UpdateAsync(items);
        }

        public Task<BankTransaction> CreateAsync(BankTransaction item)
        {
            return BankTransactions.CreateAsync(item);
        }

        public Task<BankTransaction> UpdateAsync(BankTransaction item)
        {
            return BankTransactions.UpdateAsync(item);
        }

        #endregion

        #region BankTransfers

        public Task<IEnumerable<BankTransfer>> CreateAsync(IEnumerable<BankTransfer> items)
        {
            return BankTransfers.CreateAsync(items);
        }

        public Task<BankTransfer> CreateAsync(BankTransfer item)
        {
            return BankTransfers.CreateAsync(item);
        }

        #endregion

        #region Contacts

        public Task<IEnumerable<Contact>> CreateAsync(IEnumerable<Contact> items)
        {
            return Contacts.CreateAsync(items);
        }

        public Task<IEnumerable<Contact>> UpdateAsync(IEnumerable<Contact> items)
        {
            return Contacts.UpdateAsync(items);
        }

        public Task<Contact> CreateAsync(Contact item)
        {
            return Contacts.CreateAsync(item);
        }

        public Task<Contact> UpdateAsync(Contact item)
        {
            return Contacts.UpdateAsync(item);
        }

        #endregion
        
        #region ContactGroups

        public Task<IEnumerable<ContactGroup>> CreateAsync(IEnumerable<ContactGroup> items)
        {
            return ContactGroups.CreateAsync(items);
        }

        public Task<IEnumerable<ContactGroup>> UpdateAsync(IEnumerable<ContactGroup> items)
        {
            return ContactGroups.UpdateAsync(items);
        }

        public Task<ContactGroup> CreateAsync(ContactGroup item)
        {
            return ContactGroups.CreateAsync(item);
        }

        public Task<ContactGroup> UpdateAsync(ContactGroup item)
        {
            return ContactGroups.UpdateAsync(item);
        }

        #endregion

        #region CreditNotes

        public Task<IEnumerable<CreditNote>> CreateAsync(IEnumerable<CreditNote> items)
        {
            return CreditNotes.CreateAsync(items);
        }

        public Task<IEnumerable<CreditNote>> UpdateAsync(IEnumerable<CreditNote> items)
        {
            return CreditNotes.UpdateAsync(items);
        }

        public Task<CreditNote> CreateAsync(CreditNote item)
        {
            return CreditNotes.CreateAsync(item);
        }

        public Task<CreditNote> UpdateAsync(CreditNote item)
        {
            return CreditNotes.UpdateAsync(item);
        }

        #endregion

        #region Employees

        public Task<IEnumerable<Employee>> CreateAsync(IEnumerable<Employee> items)
        {
            return Employees.CreateAsync(items);
        }

        public Task<IEnumerable<Employee>> UpdateAsync(IEnumerable<Employee> items)
        {
            return Employees.UpdateAsync(items);
        }

        public Task<Employee> CreateAsync(Employee item)
        {
            return Employees.CreateAsync(item);
        }

        public Task<Employee> UpdateAsync(Employee item)
        {
            return Employees.UpdateAsync(item);
        }

        #endregion

        #region ExpenseClaims

        public Task<IEnumerable<ExpenseClaim>> CreateAsync(IEnumerable<ExpenseClaim> items)
        {
            return ExpenseClaims.CreateAsync(items);
        }

        public Task<IEnumerable<ExpenseClaim>> UpdateAsync(IEnumerable<ExpenseClaim> items)
        {
            return ExpenseClaims.UpdateAsync(items);
        }

        public Task<ExpenseClaim> CreateAsync(ExpenseClaim item)
        {
            return ExpenseClaims.CreateAsync(item);
        }

        public Task<ExpenseClaim> UpdateAsync(ExpenseClaim item)
        {
            return ExpenseClaims.UpdateAsync(item);
        }

        #endregion

        #region Invoices

        public Task<IEnumerable<Invoice>> CreateAsync(IEnumerable<Invoice> items)
        {
            return Invoices.CreateAsync(items);
        }

        public Task<IEnumerable<Invoice>> UpdateAsync(IEnumerable<Invoice> items)
        {
            return Invoices.UpdateAsync(items);
        }

        public Task<Invoice> CreateAsync(Invoice item)
        {
            return Invoices.CreateAsync(item);
        }

        public Task<Invoice> UpdateAsync(Invoice item)
        {
            return Invoices.UpdateAsync(item);
        }

        #endregion

        #region Items

        public Task<IEnumerable<Item>> CreateAsync(IEnumerable<Item> items)
        {
            return Items.CreateAsync(items);
        }

        public Task<IEnumerable<Item>> UpdateAsync(IEnumerable<Item> items)
        {
            return Items.UpdateAsync(items);
        }

        public Task<Item> CreateAsync(Item item)
        {
            return Items.CreateAsync(item);
        }

        public Task<Item> UpdateAsync(Item item)
        {
            return Items.UpdateAsync(item);
        }

        #endregion

        #region LinkedTransactions

        public Task<IEnumerable<LinkedTransaction>> CreateAsync(IEnumerable<LinkedTransaction> items)
        {
            return LinkedTransactions.CreateAsync(items);
        }

        public Task<IEnumerable<LinkedTransaction>> UpdateAsync(IEnumerable<LinkedTransaction> items)
        {
            return LinkedTransactions.UpdateAsync(items);
        }

        public Task<LinkedTransaction> CreateAsync(LinkedTransaction item)
        {
            return LinkedTransactions.CreateAsync(item);
        }

        public Task<LinkedTransaction> UpdateAsync(LinkedTransaction item)
        {
            return LinkedTransactions.UpdateAsync(item);
        }

        #endregion

        #region ManualJournals

        public Task<IEnumerable<ManualJournal>> CreateAsync(IEnumerable<ManualJournal> items)
        {
            return ManualJournals.CreateAsync(items);
        }

        public Task<IEnumerable<ManualJournal>> UpdateAsync(IEnumerable<ManualJournal> items)
        {
            return ManualJournals.UpdateAsync(items);
        }

        public Task<ManualJournal> CreateAsync(ManualJournal item)
        {
            return ManualJournals.CreateAsync(item);
        }

        public Task<ManualJournal> UpdateAsync(ManualJournal item)
        {
            return ManualJournals.UpdateAsync(item);
        }

        #endregion

        #region Payments

        public Task<IEnumerable<Payment>> CreateAsync(IEnumerable<Payment> items)
        {
            return Payments.CreateAsync(items);
        }

        public Task<IEnumerable<Payment>> UpdateAsync(IEnumerable<Payment> items)
        {
            return Payments.UpdateAsync(items);
        }

        public Task<Payment> CreateAsync(Payment item)
        {
            return Payments.CreateAsync(item);
        }

        public Task<Payment> UpdateAsync(Payment item)
        {
            return Payments.UpdateAsync(item);
        }

        #endregion

        #region PurchaseOrders

        public Task<IEnumerable<PurchaseOrder>> CreateAsync(IEnumerable<PurchaseOrder> items)
        {
            return PurchaseOrders.CreateAsync(items);
        }

        public Task<IEnumerable<PurchaseOrder>> UpdateAsync(IEnumerable<PurchaseOrder> items)
        {
            return PurchaseOrders.UpdateAsync(items);
        }

        public Task<PurchaseOrder> CreateAsync(PurchaseOrder item)
        {
            return PurchaseOrders.CreateAsync(item);
        }

        public Task<PurchaseOrder> UpdateAsync(PurchaseOrder item)
        {
            return PurchaseOrders.UpdateAsync(item);
        }

        #endregion

        #region Receipts

        public Task<IEnumerable<Receipt>> CreateAsync(IEnumerable<Receipt> items)
        {
            return Receipts.CreateAsync(items);
        }

        public Task<IEnumerable<Receipt>> UpdateAsync(IEnumerable<Receipt> items)
        {
            return Receipts.UpdateAsync(items);
        }

        public Task<Receipt> CreateAsync(Receipt item)
        {
            return Receipts.CreateAsync(item);
        }

        public Task<Receipt> UpdateAsync(Receipt item)
        {
            return Receipts.UpdateAsync(item);
        }

        #endregion

        #region Setups

        public Task<ImportSummary> CreateAsync(Setup item)
        {
            return Setup.CreateAsync(item);
        }

        public Task<ImportSummary> UpdateAsync(Setup item)
        {
            return Setup.UpdateAsync(item);
        }

        #endregion

        #region TaxRates

        public Task<IEnumerable<TaxRate>> CreateAsync(IEnumerable<TaxRate> items)
        {
            return TaxRates.CreateAsync(items);
        }

        public Task<IEnumerable<TaxRate>> UpdateAsync(IEnumerable<TaxRate> items)
        {
            return TaxRates.UpdateAsync(items);
        }

        public Task<TaxRate> CreateAsync(TaxRate item)
        {
            return TaxRates.CreateAsync(item);
        }

        public Task<TaxRate> UpdateAsync(TaxRate item)
        {
            return TaxRates.UpdateAsync(item);
        }

        #endregion

        #region TrackingCategories

        public Task<IEnumerable<TrackingCategory>> CreateAsync(IEnumerable<TrackingCategory> items)
        {
            return TrackingCategories.CreateAsync(items);
        }

        public Task<IEnumerable<TrackingCategory>> UpdateAsync(IEnumerable<TrackingCategory> items)
        {
            return TrackingCategories.UpdateAsync(items);
        }

        public Task<TrackingCategory> CreateAsync(TrackingCategory item)
        {
            return TrackingCategories.CreateAsync(item);
        }

        public Task<TrackingCategory> UpdateAsync(TrackingCategory item)
        {
            return TrackingCategories.UpdateAsync(item);
        }

        #endregion
    }
}
