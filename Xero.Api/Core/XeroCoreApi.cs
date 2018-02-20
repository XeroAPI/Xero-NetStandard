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
        private IOrganisationEndpoint OrganisationEndpoint { get; set; }

        public XeroCoreApi(IAuthenticator auth,ApplicationSettings applicationSettings, IUser user = null, IRateLimiter rateLimiter = null)
            : base(applicationSettings.BaseUrl, auth, new Consumer(applicationSettings.Key, applicationSettings.Secret), user, rateLimiter)
        {
            Connect();
        }

        public XeroCoreApi(IAuthenticator auth, IUser user = null, IRateLimiter rateLimiter = null)
            : this(auth, new ApplicationSettings(), user, rateLimiter)
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
            OrganisationEndpoint = new OrganisationEndpoint(Client);

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
            return (await OrganisationEndpoint.FindAsync()).FirstOrDefault();
        }

        // Note: Due to the immutability of endpoints, If you want to use filtering etc you will need to make requests via the endpoints themselves, not using the sugar methods below

        #region Accounts

        public async Task<IEnumerable<Account>> CreateAsync(IEnumerable<Account> items)
        {
            return await Accounts.CreateAsync(items);
        }

        public async Task<IEnumerable<Account>> UpdateAsync(IEnumerable<Account> items)
        {
            return await Accounts.UpdateAsync(items);
        }

        public async Task<Account> CreateAsync(Account item)
        {
            return await Accounts.CreateAsync(item);
        }

        public async Task<Account> UpdateAsync(Account item)
        {
            return await Accounts.UpdateAsync(item);
        }

        #endregion

        #region BankTransactions

        public async Task<IEnumerable<BankTransaction>> CreateAsync(IEnumerable<BankTransaction> items)
        {
            return await BankTransactions.CreateAsync(items);
        }

        public async Task<IEnumerable<BankTransaction>> UpdateAsync(IEnumerable<BankTransaction> items)
        {
            return await BankTransactions.UpdateAsync(items);
        }

        public async Task<BankTransaction> CreateAsync(BankTransaction item)
        {
            return await BankTransactions.CreateAsync(item);
        }

        public async Task<BankTransaction> UpdateAsync(BankTransaction item)
        {
            return await BankTransactions.UpdateAsync(item);
        }

        #endregion

        #region BankTransfers

        public async Task<IEnumerable<BankTransfer>> CreateAsync(IEnumerable<BankTransfer> items)
        {
            return await BankTransfers.CreateAsync(items);
        }

        public async Task<BankTransfer> CreateAsync(BankTransfer item)
        {
            return await BankTransfers.CreateAsync(item);
        }

        #endregion

        #region Contacts

        public async Task<IEnumerable<Contact>> CreateAsync(IEnumerable<Contact> items)
        {
            return await Contacts.CreateAsync(items);
        }

        public async Task<IEnumerable<Contact>> UpdateAsync(IEnumerable<Contact> items)
        {
            return await Contacts.UpdateAsync(items);
        }

        public async Task<Contact> CreateAsync(Contact item)
        {
            return await Contacts.CreateAsync(item);
        }

        public async Task<Contact> UpdateAsync(Contact item)
        {
            return await Contacts.UpdateAsync(item);
        }

        #endregion
        
        #region ContactGroups

        public async Task<IEnumerable<ContactGroup>> CreateAsync(IEnumerable<ContactGroup> items)
        {
            return await ContactGroups.CreateAsync(items);
        }

        public async Task<IEnumerable<ContactGroup>> UpdateAsync(IEnumerable<ContactGroup> items)
        {
            return await ContactGroups.UpdateAsync(items);
        }

        public async Task<ContactGroup> CreateAsync(ContactGroup item)
        {
            return await ContactGroups.CreateAsync(item);
        }

        public async Task<ContactGroup> UpdateAsync(ContactGroup item)
        {
            return await ContactGroups.UpdateAsync(item);
        }

        #endregion

        #region CreditNotes

        public async Task<IEnumerable<CreditNote>> CreateAsync(IEnumerable<CreditNote> items)
        {
            return await CreditNotes.CreateAsync(items);
        }

        public async Task<IEnumerable<CreditNote>> UpdateAsync(IEnumerable<CreditNote> items)
        {
            return await CreditNotes.UpdateAsync(items);
        }

        public async Task<CreditNote> CreateAsync(CreditNote item)
        {
            return await CreditNotes.CreateAsync(item);
        }

        public async Task<CreditNote> UpdateAsync(CreditNote item)
        {
            return await CreditNotes.UpdateAsync(item);
        }

        #endregion

        #region Employees

        public async Task<IEnumerable<Employee>> CreateAsync(IEnumerable<Employee> items)
        {
            return await Employees.CreateAsync(items);
        }

        public async Task<IEnumerable<Employee>> UpdateAsync(IEnumerable<Employee> items)
        {
            return await Employees.UpdateAsync(items);
        }

        public async Task<Employee> CreateAsync(Employee item)
        {
            return await Employees.CreateAsync(item);
        }

        public async Task<Employee> UpdateAsync(Employee item)
        {
            return await Employees.UpdateAsync(item);
        }

        #endregion

        #region ExpenseClaims

        public async Task<IEnumerable<ExpenseClaim>> CreateAsync(IEnumerable<ExpenseClaim> items)
        {
            return await ExpenseClaims.CreateAsync(items);
        }

        public async Task<IEnumerable<ExpenseClaim>> UpdateAsync(IEnumerable<ExpenseClaim> items)
        {
            return await ExpenseClaims.UpdateAsync(items);
        }

        public async Task<ExpenseClaim> CreateAsync(ExpenseClaim item)
        {
            return await ExpenseClaims.CreateAsync(item);
        }

        public async Task<ExpenseClaim> UpdateAsync(ExpenseClaim item)
        {
            return await ExpenseClaims.UpdateAsync(item);
        }

        #endregion

        #region Invoices

        public async Task<IEnumerable<Invoice>> CreateAsync(IEnumerable<Invoice> items)
        {
            return await Invoices.CreateAsync(items);
        }

        public async Task<IEnumerable<Invoice>> UpdateAsync(IEnumerable<Invoice> items)
        {
            return await Invoices.UpdateAsync(items);
        }

        public async Task<Invoice> CreateAsync(Invoice item)
        {
            return await Invoices.CreateAsync(item);
        }

        public async Task<Invoice> UpdateAsync(Invoice item)
        {
            return await Invoices.UpdateAsync(item);
        }

        #endregion

        #region Items

        public async Task<IEnumerable<Item>> CreateAsync(IEnumerable<Item> items)
        {
            return await Items.CreateAsync(items);
        }

        public async Task<IEnumerable<Item>> UpdateAsync(IEnumerable<Item> items)
        {
            return await Items.UpdateAsync(items);
        }

        public async Task<Item> CreateAsync(Item item)
        {
            return await Items.CreateAsync(item);
        }

        public async Task<Item> UpdateAsync(Item item)
        {
            return await Items.UpdateAsync(item);
        }

        #endregion

        #region LinkedTransactions

        public async Task<IEnumerable<LinkedTransaction>> CreateAsync(IEnumerable<LinkedTransaction> items)
        {
            return await LinkedTransactions.CreateAsync(items);
        }

        public async Task<IEnumerable<LinkedTransaction>> UpdateAsync(IEnumerable<LinkedTransaction> items)
        {
            return await LinkedTransactions.UpdateAsync(items);
        }

        public async Task<LinkedTransaction> CreateAsync(LinkedTransaction item)
        {
            return await LinkedTransactions.CreateAsync(item);
        }

        public async Task<LinkedTransaction> UpdateAsync(LinkedTransaction item)
        {
            return await LinkedTransactions.UpdateAsync(item);
        }

        #endregion

        #region ManualJournals

        public async Task<IEnumerable<ManualJournal>> CreateAsync(IEnumerable<ManualJournal> items)
        {
            return await ManualJournals.CreateAsync(items);
        }

        public async Task<IEnumerable<ManualJournal>> UpdateAsync(IEnumerable<ManualJournal> items)
        {
            return await ManualJournals.UpdateAsync(items);
        }

        public async Task<ManualJournal> CreateAsync(ManualJournal item)
        {
            return await ManualJournals.CreateAsync(item);
        }

        public async Task<ManualJournal> UpdateAsync(ManualJournal item)
        {
            return await ManualJournals.UpdateAsync(item);
        }

        #endregion

        #region Payments

        public async Task<IEnumerable<Payment>> CreateAsync(IEnumerable<Payment> items)
        {
            return await Payments.CreateAsync(items);
        }

        public async Task<IEnumerable<Payment>> UpdateAsync(IEnumerable<Payment> items)
        {
            return await Payments.UpdateAsync(items);
        }

        public async Task<Payment> CreateAsync(Payment item)
        {
            return await Payments.CreateAsync(item);
        }

        public async Task<Payment> UpdateAsync(Payment item)
        {
            return await Payments.UpdateAsync(item);
        }

        #endregion

        #region PurchaseOrders

        public async Task<IEnumerable<PurchaseOrder>> CreateAsync(IEnumerable<PurchaseOrder> items)
        {
            return await PurchaseOrders.CreateAsync(items);
        }

        public async Task<IEnumerable<PurchaseOrder>> UpdateAsync(IEnumerable<PurchaseOrder> items)
        {
            return await PurchaseOrders.UpdateAsync(items);
        }

        public async Task<PurchaseOrder> CreateAsync(PurchaseOrder item)
        {
            return await PurchaseOrders.CreateAsync(item);
        }

        public async Task<PurchaseOrder> UpdateAsync(PurchaseOrder item)
        {
            return await PurchaseOrders.UpdateAsync(item);
        }

        #endregion

        #region Receipts

        public async Task<IEnumerable<Receipt>> CreateAsync(IEnumerable<Receipt> items)
        {
            return await Receipts.CreateAsync(items);
        }

        public async Task<IEnumerable<Receipt>> UpdateAsync(IEnumerable<Receipt> items)
        {
            return await Receipts.UpdateAsync(items);
        }

        public async Task<Receipt> CreateAsync(Receipt item)
        {
            return await Receipts.CreateAsync(item);
        }

        public async Task<Receipt> UpdateAsync(Receipt item)
        {
            return await Receipts.UpdateAsync(item);
        }

        #endregion

        #region Setups

        public async Task<ImportSummary> CreateAsync(Setup item)
        {
            return await Setup.CreateAsync(item);
        }

        public async Task<ImportSummary> UpdateAsync(Setup item)
        {
            return await Setup.UpdateAsync(item);
        }

        #endregion

        #region TaxRates

        public async Task<IEnumerable<TaxRate>> CreateAsync(IEnumerable<TaxRate> items)
        {
            return await TaxRates.CreateAsync(items);
        }

        public async Task<IEnumerable<TaxRate>> UpdateAsync(IEnumerable<TaxRate> items)
        {
            return await TaxRates.UpdateAsync(items);
        }

        public async Task<TaxRate> CreateAsync(TaxRate item)
        {
            return await TaxRates.CreateAsync(item);
        }

        public async Task<TaxRate> UpdateAsync(TaxRate item)
        {
            return await TaxRates.UpdateAsync(item);
        }

        #endregion

        #region TrackingCategories

        public async Task<IEnumerable<TrackingCategory>> CreateAsync(IEnumerable<TrackingCategory> items)
        {
            return await TrackingCategories.CreateAsync(items);
        }

        public async Task<IEnumerable<TrackingCategory>> UpdateAsync(IEnumerable<TrackingCategory> items)
        {
            return await TrackingCategories.UpdateAsync(items);
        }

        public async Task<TrackingCategory> CreateAsync(TrackingCategory item)
        {
            return await TrackingCategories.CreateAsync(item);
        }

        public async Task<TrackingCategory> UpdateAsync(TrackingCategory item)
        {
            return await TrackingCategories.UpdateAsync(item);
        }

        #endregion
    }
}
