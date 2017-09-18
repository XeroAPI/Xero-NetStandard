using System.Collections.Generic;
using System.Linq;
using Xero.Api.Common;
using Xero.Api.Core.Endpoints;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Setup;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.RateLimiter;
using Xero.Api.Serialization;
using Organisation = Xero.Api.Core.Model.Organisation;

namespace Xero.Api.Core
{
    public class XeroCoreApi : XeroApi, IXeroCoreApi
    {
        private IOrganisationEndpoint OrganisationEndpoint { get; set; }

        public XeroCoreApi(string baseUri, IAuthenticator auth, IConsumer consumer, IUser user,
            IJsonObjectMapper readMapper, IXmlObjectMapper writeMapper)
            : this(baseUri, auth, consumer, user, readMapper, writeMapper, null)
        {
        }

        public XeroCoreApi(string baseUri, IAuthenticator auth, IConsumer consumer, IUser user, IJsonObjectMapper readMapper, IXmlObjectMapper writeMapper, IRateLimiter rateLimiter)
            : base(baseUri, auth, consumer, user, readMapper, writeMapper, rateLimiter)
        {
            Connect();
        }
        
        public XeroCoreApi(string baseUri, IAuthenticator auth, IConsumer consumer, IUser user)
            : this(baseUri, auth, consumer, user, null)
        {
        }

        public XeroCoreApi(string baseUri, IAuthenticator auth, IConsumer consumer, IUser user, IRateLimiter rateLimiter)
            : this(baseUri, auth, consumer, user, new DefaultMapper(), new DefaultMapper(), rateLimiter)
        {
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

        public Organisation Organisation
        {
            get
            {
                return OrganisationEndpoint.Find().FirstOrDefault();
            }
        }

        #region Accounts

        public IEnumerable<Account> Create(IEnumerable<Account> items)
        {
            return Accounts.Create(items);
        }

        public IEnumerable<Account> Update(IEnumerable<Account> items)
        {
            return Accounts.Update(items);
        }

        public Account Create(Account item)
        {
            return Accounts.Create(item);
        }

        public Account Update(Account item)
        {
            return Accounts.Update(item);
        }

        #endregion

        #region BankTransactions

        public IEnumerable<BankTransaction> Create(IEnumerable<BankTransaction> items)
        {
            return BankTransactions.Create(items);
        }

        public IEnumerable<BankTransaction> Update(IEnumerable<BankTransaction> items)
        {
            return BankTransactions.Update(items);
        }

        public BankTransaction Create(BankTransaction item)
        {
            return BankTransactions.Create(item);
        }

        public BankTransaction Update(BankTransaction item)
        {
            return BankTransactions.Update(item);
        }

        #endregion

        #region BankTransfers

        public IEnumerable<BankTransfer> Create(IEnumerable<BankTransfer> items)
        {
            return BankTransfers.Create(items);
        }

        public BankTransfer Create(BankTransfer item)
        {
            return BankTransfers.Create(item);
        }

        #endregion

        #region Contacts

        public IEnumerable<Contact> Create(IEnumerable<Contact> items)
        {
            return Contacts.Create(items);
        }

        public IEnumerable<Contact> Update(IEnumerable<Contact> items)
        {
            return Contacts.Update(items);
        }

        public Contact Create(Contact item)
        {
            return Contacts.Create(item);
        }

        public Contact Update(Contact item)
        {
            return Contacts.Update(item);
        }

        #endregion
        
        #region ContactGroups

        public IEnumerable<ContactGroup> Create(IEnumerable<ContactGroup> items)
        {
            return ContactGroups.Create(items);
        }

        public IEnumerable<ContactGroup> Update(IEnumerable<ContactGroup> items)
        {
            return ContactGroups.Update(items);
        }

        public ContactGroup Create(ContactGroup item)
        {
            return ContactGroups.Create(item);
        }

        public ContactGroup Update(ContactGroup item)
        {
            return ContactGroups.Update(item);
        }

        #endregion

        #region CreditNotes

        public IEnumerable<CreditNote> Create(IEnumerable<CreditNote> items)
        {
            return CreditNotes.Create(items);
        }

        public IEnumerable<CreditNote> Update(IEnumerable<CreditNote> items)
        {
            return CreditNotes.Update(items);
        }

        public CreditNote Create(CreditNote item)
        {
            return CreditNotes.Create(item);
        }

        public CreditNote Update(CreditNote item)
        {
            return CreditNotes.Update(item);
        }

        #endregion

        #region Employees

        public IEnumerable<Employee> Create(IEnumerable<Employee> items)
        {
            return Employees.Create(items);
        }

        public IEnumerable<Employee> Update(IEnumerable<Employee> items)
        {
            return Employees.Update(items);
        }

        public Employee Create(Employee item)
        {
            return Employees.Create(item);
        }

        public Employee Update(Employee item)
        {
            return Employees.Update(item);
        }

        #endregion

        #region ExpenseClaims

        public IEnumerable<ExpenseClaim> Create(IEnumerable<ExpenseClaim> items)
        {
            return ExpenseClaims.Create(items);
        }

        public IEnumerable<ExpenseClaim> Update(IEnumerable<ExpenseClaim> items)
        {
            return ExpenseClaims.Update(items);
        }

        public ExpenseClaim Create(ExpenseClaim item)
        {
            return ExpenseClaims.Create(item);
        }

        public ExpenseClaim Update(ExpenseClaim item)
        {
            return ExpenseClaims.Update(item);
        }

        #endregion

        #region Invoices

        public IEnumerable<Invoice> Create(IEnumerable<Invoice> items)
        {
            return Invoices.Create(items);
        }

        public IEnumerable<Invoice> Update(IEnumerable<Invoice> items)
        {
            return Invoices.Update(items);
        }

        public Invoice Create(Invoice item)
        {
            return Invoices.Create(item);
        }

        public Invoice Update(Invoice item)
        {
            return Invoices.Update(item);
        }

        #endregion

        #region Items

        public IEnumerable<Item> Create(IEnumerable<Item> items)
        {
            return Items.Create(items);
        }

        public IEnumerable<Item> Update(IEnumerable<Item> items)
        {
            return Items.Update(items);
        }

        public Item Create(Item item)
        {
            return Items.Create(item);
        }

        public Item Update(Item item)
        {
            return Items.Update(item);
        }

        #endregion

        #region LinkedTransactions

        public IEnumerable<LinkedTransaction> Create(IEnumerable<LinkedTransaction> items)
        {
            return LinkedTransactions.Create(items);
        }

        public IEnumerable<LinkedTransaction> Update(IEnumerable<LinkedTransaction> items)
        {
            return LinkedTransactions.Update(items);
        }

        public LinkedTransaction Create(LinkedTransaction item)
        {
            return LinkedTransactions.Create(item);
        }

        public LinkedTransaction Update(LinkedTransaction item)
        {
            return LinkedTransactions.Update(item);
        }

        #endregion

        #region ManualJournals

        public IEnumerable<ManualJournal> Create(IEnumerable<ManualJournal> items)
        {
            return ManualJournals.Create(items);
        }

        public IEnumerable<ManualJournal> Update(IEnumerable<ManualJournal> items)
        {
            return ManualJournals.Update(items);
        }

        public ManualJournal Create(ManualJournal item)
        {
            return ManualJournals.Create(item);
        }

        public ManualJournal Update(ManualJournal item)
        {
            return ManualJournals.Update(item);
        }

        #endregion

        #region Payments

        public IEnumerable<Payment> Create(IEnumerable<Payment> items)
        {
            return Payments.Create(items);
        }

        public IEnumerable<Payment> Update(IEnumerable<Payment> items)
        {
            return Payments.Update(items);
        }

        public Payment Create(Payment item)
        {
            return Payments.Create(item);
        }

        public Payment Update(Payment item)
        {
            return Payments.Update(item);
        }

        #endregion

        #region PurchaseOrders

        public IEnumerable<PurchaseOrder> Create(IEnumerable<PurchaseOrder> items)
        {
            return PurchaseOrders.Create(items);
        }

        public IEnumerable<PurchaseOrder> Update(IEnumerable<PurchaseOrder> items)
        {
            return PurchaseOrders.Update(items);
        }

        public PurchaseOrder Create(PurchaseOrder item)
        {
            return PurchaseOrders.Create(item);
        }

        public PurchaseOrder Update(PurchaseOrder item)
        {
            return PurchaseOrders.Update(item);
        }

        #endregion

        #region Receipts

        public IEnumerable<Receipt> Create(IEnumerable<Receipt> items)
        {
            return Receipts.Create(items);
        }

        public IEnumerable<Receipt> Update(IEnumerable<Receipt> items)
        {
            return Receipts.Update(items);
        }

        public Receipt Create(Receipt item)
        {
            return Receipts.Create(item);
        }

        public Receipt Update(Receipt item)
        {
            return Receipts.Update(item);
        }

        #endregion

        #region Setups

        public ImportSummary Create(Setup item)
        {
            return Setup.Create(item);
        }

        public ImportSummary Update(Setup item)
        {
            return Setup.Update(item);
        }

        #endregion

        #region TaxRates

        public IEnumerable<TaxRate> Create(IEnumerable<TaxRate> items)
        {
            return TaxRates.Create(items);
        }

        public IEnumerable<TaxRate> Update(IEnumerable<TaxRate> items)
        {
            return TaxRates.Update(items);
        }

        public TaxRate Create(TaxRate item)
        {
            return TaxRates.Create(item);
        }

        public TaxRate Update(TaxRate item)
        {
            return TaxRates.Update(item);
        }

        #endregion

        #region TrackingCategories

        public IEnumerable<TrackingCategory> Create(IEnumerable<TrackingCategory> items)
        {
            return TrackingCategories.Create(items);
        }

        public IEnumerable<TrackingCategory> Update(IEnumerable<TrackingCategory> items)
        {
            return TrackingCategories.Update(items);
        }

        public TrackingCategory Create(TrackingCategory item)
        {
            return TrackingCategories.Create(item);
        }

        public TrackingCategory Update(TrackingCategory item)
        {
            return TrackingCategories.Update(item);
        }

        #endregion

        public void SummarizeErrors(bool summarize)
        {
            Accounts.SummarizeErrors(summarize);
            BankTransactions.SummarizeErrors(summarize);
            BankTransfers.SummarizeErrors(summarize);
            Contacts.SummarizeErrors(summarize);
            ContactGroups.SummarizeErrors(summarize);
            CreditNotes.SummarizeErrors(summarize);
            Employees.SummarizeErrors(summarize);
            Employees.SummarizeErrors(summarize);
            Files.SummarizeErrors(summarize);
            Folders.SummarizeErrors(summarize);
            Inbox.SummarizeErrors(summarize);
            Invoices.SummarizeErrors(summarize);
            Items.SummarizeErrors(summarize);
            LinkedTransactions.SummarizeErrors(summarize);
            ManualJournals.SummarizeErrors(summarize);
            Payments.SummarizeErrors(summarize);
            PurchaseOrders.SummarizeErrors(summarize);
            Receipts.SummarizeErrors(summarize);
            TaxRates.SummarizeErrors(summarize);
            TrackingCategories.SummarizeErrors(summarize);
        }
    }
}
