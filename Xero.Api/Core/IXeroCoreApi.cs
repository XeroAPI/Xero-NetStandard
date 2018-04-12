using System.Collections.Generic;
using System.Threading.Tasks;
using Xero.Api.Core.Endpoints;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Setup;
using Organisation = Xero.Api.Core.Model.Organisation;

namespace Xero.Api.Core
{
    public interface IXeroCoreApi
    {
        IAccountsEndpoint Accounts { get; }
        AllocationsEndpoint Allocations { get; }
        AttachmentsEndpoint Attachments { get; }
        IBankTransactionsEndpoint BankTransactions { get; }
        IBankTransfersEndpoint BankTransfers { get; }
        IBrandingThemesEndpoint BrandingThemes { get; }
        IContactsEndpoint Contacts { get; }
        IContactGroupsEndpoint ContactGroups { get; }
        ICreditNotesEndpoint CreditNotes { get; }
        ICurrenciesEndpoint Currencies { get; set; }
        IEmployeesEndpoint Employees { get; }
        IExpenseClaimsEndpoint ExpenseClaims { get; }
        IFilesEndpoint Files { get; }
        IFoldersEndpoint Folders { get; }
        IHistoryAndNotesEndpoint HistoryAndNotes { get; }
        IInboxEndpoint Inbox { get; }
        IAssociationsEndpoint Associations { get; }
        IInvoicesEndpoint Invoices { get; }
        IItemsEndpoint Items { get; }
        IJournalsEndpoint Journals { get; }
        ILinkedTransactionsEndpoint LinkedTransactions { get; }
        IManualJournalsEndpoint ManualJournals { get; }
        IOrganisationEndpoint Organisations { get; }
        IOverpaymentsEndpoint Overpayments { get; }
        IPaymentsEndpoint Payments { get; }
        PdfEndpoint PdfFiles { get; }
        IPrepaymentsEndpoint Prepayments { get; }
        IPurchaseOrdersEndpoint PurchaseOrders { get; }
        IReceiptsEndpoint Receipts { get; }
        IRepeatingInvoicesEndpoint RepeatingInvoices { get; }
        IReportsEndpoint Reports { get; }
        ISetupEndpoint Setup { get; }
        ITaxRatesEndpoint TaxRates { get; }
        ITrackingCategoriesEndpoint TrackingCategories { get; }
        IUsersEndpoint Users { get; }
        string BaseUri { get; }
        string UserAgent { get; }

        Task<Organisation> FindOrganisationAsync();


        //Accounts
        Task<IEnumerable<Account>> CreateAsync(IEnumerable<Account> items);
        Task<IEnumerable<Account>> UpdateAsync(IEnumerable<Account> items);
        Task<Account> CreateAsync(Account item);
        Task<Account> UpdateAsync(Account item);

        //BankTransactions
        Task<IEnumerable<BankTransaction>> CreateAsync(IEnumerable<BankTransaction> items);
        Task<IEnumerable<BankTransaction>> UpdateAsync(IEnumerable<BankTransaction> items);
        Task<BankTransaction> CreateAsync(BankTransaction item);
        Task<BankTransaction> UpdateAsync(BankTransaction item);

        //BankTransfers
        Task<IEnumerable<BankTransfer>> CreateAsync(IEnumerable<BankTransfer> items);
        Task<BankTransfer> CreateAsync(BankTransfer item);

        //Contacts
        Task<IEnumerable<Contact>> CreateAsync(IEnumerable<Contact> items);
        Task<IEnumerable<Contact>> UpdateAsync(IEnumerable<Contact> items);
        Task<Contact> CreateAsync(Contact item);
        Task<Contact> UpdateAsync(Contact item);

        //ContactGroups
        Task<IEnumerable<ContactGroup>> CreateAsync(IEnumerable<ContactGroup> items);
        Task<IEnumerable<ContactGroup>> UpdateAsync(IEnumerable<ContactGroup> items);
        Task<ContactGroup> CreateAsync(ContactGroup item);
        Task<ContactGroup> UpdateAsync(ContactGroup item);

        //CreditNotes
        Task<IEnumerable<CreditNote>> CreateAsync(IEnumerable<CreditNote> items);
        Task<IEnumerable<CreditNote>> UpdateAsync(IEnumerable<CreditNote> items);
        Task<CreditNote> CreateAsync(CreditNote item);
        Task<CreditNote> UpdateAsync(CreditNote item);

        //Employees
        Task<IEnumerable<Employee>> CreateAsync(IEnumerable<Employee> items);
        Task<IEnumerable<Employee>> UpdateAsync(IEnumerable<Employee> items);
        Task<Employee> CreateAsync(Employee item);
        Task<Employee> UpdateAsync(Employee item);

        //ExpenseClaims
        Task<IEnumerable<ExpenseClaim>> CreateAsync(IEnumerable<ExpenseClaim> items);
        Task<IEnumerable<ExpenseClaim>> UpdateAsync(IEnumerable<ExpenseClaim> items);
        Task<ExpenseClaim> CreateAsync(ExpenseClaim item);
        Task<ExpenseClaim> UpdateAsync(ExpenseClaim item);

        //Invoices
        Task<IEnumerable<Invoice>> CreateAsync(IEnumerable<Invoice> items);
        Task<IEnumerable<Invoice>> UpdateAsync(IEnumerable<Invoice> items);
        Task<Invoice> CreateAsync(Invoice item);
        Task<Invoice> UpdateAsync(Invoice item);

        //Items
        Task<IEnumerable<Item>> CreateAsync(IEnumerable<Item> items);
        Task<IEnumerable<Item>> UpdateAsync(IEnumerable<Item> items);
        Task<Item> CreateAsync(Item item);
        Task<Item> UpdateAsync(Item item);

        //LinkedTransactions
        Task<IEnumerable<LinkedTransaction>> CreateAsync(IEnumerable<LinkedTransaction> items);
        Task<IEnumerable<LinkedTransaction>> UpdateAsync(IEnumerable<LinkedTransaction> items);
        Task<LinkedTransaction> CreateAsync(LinkedTransaction item);
        Task<LinkedTransaction> UpdateAsync(LinkedTransaction item);

        //ManualJournals
        Task<IEnumerable<ManualJournal>> CreateAsync(IEnumerable<ManualJournal> items);
        Task<IEnumerable<ManualJournal>> UpdateAsync(IEnumerable<ManualJournal> items);
        Task<ManualJournal> CreateAsync(ManualJournal item);
        Task<ManualJournal> UpdateAsync(ManualJournal item);

        
        //Payments
        Task<IEnumerable<Payment>> CreateAsync(IEnumerable<Payment> items);
        Task<IEnumerable<Payment>> UpdateAsync(IEnumerable<Payment> items);
        Task<Payment> CreateAsync(Payment item);
        Task<Payment> UpdateAsync(Payment item);
        
        //PurchaseOrders
        Task<IEnumerable<PurchaseOrder>> CreateAsync(IEnumerable<PurchaseOrder> items);
        Task<IEnumerable<PurchaseOrder>> UpdateAsync(IEnumerable<PurchaseOrder> items);
        Task<PurchaseOrder> CreateAsync(PurchaseOrder item);
        Task<PurchaseOrder> UpdateAsync(PurchaseOrder item);

        //Receipts
        Task<IEnumerable<Receipt>> CreateAsync(IEnumerable<Receipt> items);
        Task<IEnumerable<Receipt>> UpdateAsync(IEnumerable<Receipt> items);
        Task<Receipt> CreateAsync(Receipt item);
        Task<Receipt> UpdateAsync(Receipt item);

        //Setups
        Task<ImportSummary> CreateAsync(Setup item);
        Task<ImportSummary> UpdateAsync(Setup item);

        //TaxRates
        Task<IEnumerable<TaxRate>> CreateAsync(IEnumerable<TaxRate> items);
        Task<IEnumerable<TaxRate>> UpdateAsync(IEnumerable<TaxRate> items);
        Task<TaxRate> CreateAsync(TaxRate item);
        Task<TaxRate> UpdateAsync(TaxRate item);

        //TrackingCategories
        Task<IEnumerable<TrackingCategory>> CreateAsync(IEnumerable<TrackingCategory> items);
        Task<IEnumerable<TrackingCategory>> UpdateAsync(IEnumerable<TrackingCategory> items);
        Task<TrackingCategory> CreateAsync(TrackingCategory item);
        Task<TrackingCategory> UpdateAsync(TrackingCategory item);
    }
}