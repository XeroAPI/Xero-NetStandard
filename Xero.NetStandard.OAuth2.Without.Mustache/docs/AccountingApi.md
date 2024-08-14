# Org.OpenAPITools.Api.AccountingApi

All URIs are relative to *https://api.xero.com/api.xro/2.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAccount**](AccountingApi.md#createaccount) | **PUT** /Accounts | Creates a new chart of accounts |
| [**CreateAccountAttachmentByFileName**](AccountingApi.md#createaccountattachmentbyfilename) | **PUT** /Accounts/{AccountID}/Attachments/{FileName} | Creates an attachment on a specific account |
| [**CreateBankTransactionAttachmentByFileName**](AccountingApi.md#createbanktransactionattachmentbyfilename) | **PUT** /BankTransactions/{BankTransactionID}/Attachments/{FileName} | Creates an attachment for a specific bank transaction by filename |
| [**CreateBankTransactionHistoryRecord**](AccountingApi.md#createbanktransactionhistoryrecord) | **PUT** /BankTransactions/{BankTransactionID}/History | Creates a history record for a specific bank transactions |
| [**CreateBankTransactions**](AccountingApi.md#createbanktransactions) | **PUT** /BankTransactions | Creates one or more spent or received money transaction |
| [**CreateBankTransfer**](AccountingApi.md#createbanktransfer) | **PUT** /BankTransfers | Creates a bank transfer |
| [**CreateBankTransferAttachmentByFileName**](AccountingApi.md#createbanktransferattachmentbyfilename) | **PUT** /BankTransfers/{BankTransferID}/Attachments/{FileName} |  |
| [**CreateBankTransferHistoryRecord**](AccountingApi.md#createbanktransferhistoryrecord) | **PUT** /BankTransfers/{BankTransferID}/History | Creates a history record for a specific bank transfer |
| [**CreateBatchPayment**](AccountingApi.md#createbatchpayment) | **PUT** /BatchPayments | Creates one or many batch payments for invoices |
| [**CreateBatchPaymentHistoryRecord**](AccountingApi.md#createbatchpaymenthistoryrecord) | **PUT** /BatchPayments/{BatchPaymentID}/History | Creates a history record for a specific batch payment |
| [**CreateBrandingThemePaymentServices**](AccountingApi.md#createbrandingthemepaymentservices) | **POST** /BrandingThemes/{BrandingThemeID}/PaymentServices | Creates a new custom payment service for a specific branding theme |
| [**CreateContactAttachmentByFileName**](AccountingApi.md#createcontactattachmentbyfilename) | **PUT** /Contacts/{ContactID}/Attachments/{FileName} |  |
| [**CreateContactGroup**](AccountingApi.md#createcontactgroup) | **PUT** /ContactGroups | Creates a contact group |
| [**CreateContactGroupContacts**](AccountingApi.md#createcontactgroupcontacts) | **PUT** /ContactGroups/{ContactGroupID}/Contacts | Creates contacts to a specific contact group |
| [**CreateContactHistory**](AccountingApi.md#createcontacthistory) | **PUT** /Contacts/{ContactID}/History | Creates a new history record for a specific contact |
| [**CreateContacts**](AccountingApi.md#createcontacts) | **PUT** /Contacts | Creates multiple contacts (bulk) in a Xero organisation |
| [**CreateCreditNoteAllocation**](AccountingApi.md#createcreditnoteallocation) | **PUT** /CreditNotes/{CreditNoteID}/Allocations | Creates allocation for a specific credit note |
| [**CreateCreditNoteAttachmentByFileName**](AccountingApi.md#createcreditnoteattachmentbyfilename) | **PUT** /CreditNotes/{CreditNoteID}/Attachments/{FileName} | Creates an attachment for a specific credit note |
| [**CreateCreditNoteHistory**](AccountingApi.md#createcreditnotehistory) | **PUT** /CreditNotes/{CreditNoteID}/History | Retrieves history records of a specific credit note |
| [**CreateCreditNotes**](AccountingApi.md#createcreditnotes) | **PUT** /CreditNotes | Creates a new credit note |
| [**CreateCurrency**](AccountingApi.md#createcurrency) | **PUT** /Currencies | Create a new currency for a Xero organisation |
| [**CreateEmployees**](AccountingApi.md#createemployees) | **PUT** /Employees | Creates new employees used in Xero payrun |
| [**CreateExpenseClaimHistory**](AccountingApi.md#createexpenseclaimhistory) | **PUT** /ExpenseClaims/{ExpenseClaimID}/History | Creates a history record for a specific expense claim |
| [**CreateExpenseClaims**](AccountingApi.md#createexpenseclaims) | **PUT** /ExpenseClaims | Creates expense claims |
| [**CreateInvoiceAttachmentByFileName**](AccountingApi.md#createinvoiceattachmentbyfilename) | **PUT** /Invoices/{InvoiceID}/Attachments/{FileName} | Creates an attachment for a specific invoice or purchase bill by filename |
| [**CreateInvoiceHistory**](AccountingApi.md#createinvoicehistory) | **PUT** /Invoices/{InvoiceID}/History | Creates a history record for a specific invoice |
| [**CreateInvoices**](AccountingApi.md#createinvoices) | **PUT** /Invoices | Creates one or more sales invoices or purchase bills |
| [**CreateItemHistory**](AccountingApi.md#createitemhistory) | **PUT** /Items/{ItemID}/History | Creates a history record for a specific item |
| [**CreateItems**](AccountingApi.md#createitems) | **PUT** /Items | Creates one or more items |
| [**CreateLinkedTransaction**](AccountingApi.md#createlinkedtransaction) | **PUT** /LinkedTransactions | Creates linked transactions (billable expenses) |
| [**CreateManualJournalAttachmentByFileName**](AccountingApi.md#createmanualjournalattachmentbyfilename) | **PUT** /ManualJournals/{ManualJournalID}/Attachments/{FileName} | Creates a specific attachment for a specific manual journal by file name |
| [**CreateManualJournalHistoryRecord**](AccountingApi.md#createmanualjournalhistoryrecord) | **PUT** /ManualJournals/{ManualJournalID}/History | Creates a history record for a specific manual journal |
| [**CreateManualJournals**](AccountingApi.md#createmanualjournals) | **PUT** /ManualJournals | Creates one or more manual journals |
| [**CreateOverpaymentAllocations**](AccountingApi.md#createoverpaymentallocations) | **PUT** /Overpayments/{OverpaymentID}/Allocations | Creates a single allocation for a specific overpayment |
| [**CreateOverpaymentHistory**](AccountingApi.md#createoverpaymenthistory) | **PUT** /Overpayments/{OverpaymentID}/History | Creates a history record for a specific overpayment |
| [**CreatePayment**](AccountingApi.md#createpayment) | **POST** /Payments | Creates a single payment for invoice or credit notes |
| [**CreatePaymentHistory**](AccountingApi.md#createpaymenthistory) | **PUT** /Payments/{PaymentID}/History | Creates a history record for a specific payment |
| [**CreatePaymentService**](AccountingApi.md#createpaymentservice) | **PUT** /PaymentServices | Creates a payment service |
| [**CreatePayments**](AccountingApi.md#createpayments) | **PUT** /Payments | Creates multiple payments for invoices or credit notes |
| [**CreatePrepaymentAllocations**](AccountingApi.md#createprepaymentallocations) | **PUT** /Prepayments/{PrepaymentID}/Allocations | Allows you to create an Allocation for prepayments |
| [**CreatePrepaymentHistory**](AccountingApi.md#createprepaymenthistory) | **PUT** /Prepayments/{PrepaymentID}/History | Creates a history record for a specific prepayment |
| [**CreatePurchaseOrderAttachmentByFileName**](AccountingApi.md#createpurchaseorderattachmentbyfilename) | **PUT** /PurchaseOrders/{PurchaseOrderID}/Attachments/{FileName} | Creates attachment for a specific purchase order |
| [**CreatePurchaseOrderHistory**](AccountingApi.md#createpurchaseorderhistory) | **PUT** /PurchaseOrders/{PurchaseOrderID}/History | Creates a history record for a specific purchase orders |
| [**CreatePurchaseOrders**](AccountingApi.md#createpurchaseorders) | **PUT** /PurchaseOrders | Creates one or more purchase orders |
| [**CreateQuoteAttachmentByFileName**](AccountingApi.md#createquoteattachmentbyfilename) | **PUT** /Quotes/{QuoteID}/Attachments/{FileName} | Creates attachment for a specific quote |
| [**CreateQuoteHistory**](AccountingApi.md#createquotehistory) | **PUT** /Quotes/{QuoteID}/History | Creates a history record for a specific quote |
| [**CreateQuotes**](AccountingApi.md#createquotes) | **PUT** /Quotes | Create one or more quotes |
| [**CreateReceipt**](AccountingApi.md#createreceipt) | **PUT** /Receipts | Creates draft expense claim receipts for any user |
| [**CreateReceiptAttachmentByFileName**](AccountingApi.md#createreceiptattachmentbyfilename) | **PUT** /Receipts/{ReceiptID}/Attachments/{FileName} | Creates an attachment on a specific expense claim receipts by file name |
| [**CreateReceiptHistory**](AccountingApi.md#createreceipthistory) | **PUT** /Receipts/{ReceiptID}/History | Creates a history record for a specific receipt |
| [**CreateRepeatingInvoiceAttachmentByFileName**](AccountingApi.md#createrepeatinginvoiceattachmentbyfilename) | **PUT** /RepeatingInvoices/{RepeatingInvoiceID}/Attachments/{FileName} | Creates an attachment from a specific repeating invoices by file name |
| [**CreateRepeatingInvoiceHistory**](AccountingApi.md#createrepeatinginvoicehistory) | **PUT** /RepeatingInvoices/{RepeatingInvoiceID}/History | Creates a  history record for a specific repeating invoice |
| [**CreateRepeatingInvoices**](AccountingApi.md#createrepeatinginvoices) | **PUT** /RepeatingInvoices | Creates one or more repeating invoice templates |
| [**CreateTaxRates**](AccountingApi.md#createtaxrates) | **PUT** /TaxRates | Creates one or more tax rates |
| [**CreateTrackingCategory**](AccountingApi.md#createtrackingcategory) | **PUT** /TrackingCategories | Create tracking categories |
| [**CreateTrackingOptions**](AccountingApi.md#createtrackingoptions) | **PUT** /TrackingCategories/{TrackingCategoryID}/Options | Creates options for a specific tracking category |
| [**DeleteAccount**](AccountingApi.md#deleteaccount) | **DELETE** /Accounts/{AccountID} | Deletes a chart of accounts |
| [**DeleteBatchPayment**](AccountingApi.md#deletebatchpayment) | **POST** /BatchPayments | Updates a specific batch payment for invoices and credit notes |
| [**DeleteBatchPaymentByUrlParam**](AccountingApi.md#deletebatchpaymentbyurlparam) | **POST** /BatchPayments/{BatchPaymentID} | Updates a specific batch payment for invoices and credit notes |
| [**DeleteContactGroupContact**](AccountingApi.md#deletecontactgroupcontact) | **DELETE** /ContactGroups/{ContactGroupID}/Contacts/{ContactID} | Deletes a specific contact from a contact group using a unique contact Id |
| [**DeleteContactGroupContacts**](AccountingApi.md#deletecontactgroupcontacts) | **DELETE** /ContactGroups/{ContactGroupID}/Contacts | Deletes all contacts from a specific contact group |
| [**DeleteCreditNoteAllocations**](AccountingApi.md#deletecreditnoteallocations) | **DELETE** /CreditNotes/{CreditNoteID}/Allocations/{AllocationID} | Deletes an Allocation from a Credit Note |
| [**DeleteItem**](AccountingApi.md#deleteitem) | **DELETE** /Items/{ItemID} | Deletes a specific item |
| [**DeleteLinkedTransaction**](AccountingApi.md#deletelinkedtransaction) | **DELETE** /LinkedTransactions/{LinkedTransactionID} | Deletes a specific linked transactions (billable expenses) |
| [**DeleteOverpaymentAllocations**](AccountingApi.md#deleteoverpaymentallocations) | **DELETE** /Overpayments/{OverpaymentID}/Allocations/{AllocationID} | Deletes an Allocation from an overpayment |
| [**DeletePayment**](AccountingApi.md#deletepayment) | **POST** /Payments/{PaymentID} | Updates a specific payment for invoices and credit notes |
| [**DeletePrepaymentAllocations**](AccountingApi.md#deleteprepaymentallocations) | **DELETE** /Prepayments/{PrepaymentID}/Allocations/{AllocationID} | Deletes an Allocation from a Prepayment |
| [**DeleteTrackingCategory**](AccountingApi.md#deletetrackingcategory) | **DELETE** /TrackingCategories/{TrackingCategoryID} | Deletes a specific tracking category |
| [**DeleteTrackingOptions**](AccountingApi.md#deletetrackingoptions) | **DELETE** /TrackingCategories/{TrackingCategoryID}/Options/{TrackingOptionID} | Deletes a specific option for a specific tracking category |
| [**EmailInvoice**](AccountingApi.md#emailinvoice) | **POST** /Invoices/{InvoiceID}/Email | Sends a copy of a specific invoice to related contact via email |
| [**GetAccount**](AccountingApi.md#getaccount) | **GET** /Accounts/{AccountID} | Retrieves a single chart of accounts by using a unique account Id |
| [**GetAccountAttachmentByFileName**](AccountingApi.md#getaccountattachmentbyfilename) | **GET** /Accounts/{AccountID}/Attachments/{FileName} | Retrieves an attachment for a specific account by filename |
| [**GetAccountAttachmentById**](AccountingApi.md#getaccountattachmentbyid) | **GET** /Accounts/{AccountID}/Attachments/{AttachmentID} | Retrieves a specific attachment from a specific account using a unique attachment Id |
| [**GetAccountAttachments**](AccountingApi.md#getaccountattachments) | **GET** /Accounts/{AccountID}/Attachments | Retrieves attachments for a specific accounts by using a unique account Id |
| [**GetAccounts**](AccountingApi.md#getaccounts) | **GET** /Accounts | Retrieves the full chart of accounts |
| [**GetBankTransaction**](AccountingApi.md#getbanktransaction) | **GET** /BankTransactions/{BankTransactionID} | Retrieves a single spent or received money transaction by using a unique bank transaction Id |
| [**GetBankTransactionAttachmentByFileName**](AccountingApi.md#getbanktransactionattachmentbyfilename) | **GET** /BankTransactions/{BankTransactionID}/Attachments/{FileName} | Retrieves a specific attachment from a specific bank transaction by filename |
| [**GetBankTransactionAttachmentById**](AccountingApi.md#getbanktransactionattachmentbyid) | **GET** /BankTransactions/{BankTransactionID}/Attachments/{AttachmentID} | Retrieves specific attachments from a specific BankTransaction using a unique attachment Id |
| [**GetBankTransactionAttachments**](AccountingApi.md#getbanktransactionattachments) | **GET** /BankTransactions/{BankTransactionID}/Attachments | Retrieves any attachments from a specific bank transactions |
| [**GetBankTransactions**](AccountingApi.md#getbanktransactions) | **GET** /BankTransactions | Retrieves any spent or received money transactions |
| [**GetBankTransactionsHistory**](AccountingApi.md#getbanktransactionshistory) | **GET** /BankTransactions/{BankTransactionID}/History | Retrieves history from a specific bank transaction using a unique bank transaction Id |
| [**GetBankTransfer**](AccountingApi.md#getbanktransfer) | **GET** /BankTransfers/{BankTransferID} | Retrieves specific bank transfers by using a unique bank transfer Id |
| [**GetBankTransferAttachmentByFileName**](AccountingApi.md#getbanktransferattachmentbyfilename) | **GET** /BankTransfers/{BankTransferID}/Attachments/{FileName} | Retrieves a specific attachment on a specific bank transfer by file name |
| [**GetBankTransferAttachmentById**](AccountingApi.md#getbanktransferattachmentbyid) | **GET** /BankTransfers/{BankTransferID}/Attachments/{AttachmentID} | Retrieves a specific attachment from a specific bank transfer using a unique attachment ID |
| [**GetBankTransferAttachments**](AccountingApi.md#getbanktransferattachments) | **GET** /BankTransfers/{BankTransferID}/Attachments | Retrieves attachments from a specific bank transfer |
| [**GetBankTransferHistory**](AccountingApi.md#getbanktransferhistory) | **GET** /BankTransfers/{BankTransferID}/History | Retrieves history from a specific bank transfer using a unique bank transfer Id |
| [**GetBankTransfers**](AccountingApi.md#getbanktransfers) | **GET** /BankTransfers | Retrieves all bank transfers |
| [**GetBatchPayment**](AccountingApi.md#getbatchpayment) | **GET** /BatchPayments/{BatchPaymentID} | Retrieves a specific batch payment using a unique batch payment Id |
| [**GetBatchPaymentHistory**](AccountingApi.md#getbatchpaymenthistory) | **GET** /BatchPayments/{BatchPaymentID}/History | Retrieves history from a specific batch payment |
| [**GetBatchPayments**](AccountingApi.md#getbatchpayments) | **GET** /BatchPayments | Retrieves either one or many batch payments for invoices |
| [**GetBrandingTheme**](AccountingApi.md#getbrandingtheme) | **GET** /BrandingThemes/{BrandingThemeID} | Retrieves a specific branding theme using a unique branding theme Id |
| [**GetBrandingThemePaymentServices**](AccountingApi.md#getbrandingthemepaymentservices) | **GET** /BrandingThemes/{BrandingThemeID}/PaymentServices | Retrieves the payment services for a specific branding theme |
| [**GetBrandingThemes**](AccountingApi.md#getbrandingthemes) | **GET** /BrandingThemes | Retrieves all the branding themes |
| [**GetBudget**](AccountingApi.md#getbudget) | **GET** /Budgets/{BudgetID} | Retrieves a specific budget, which includes budget lines |
| [**GetBudgets**](AccountingApi.md#getbudgets) | **GET** /Budgets | Retrieve a list of budgets |
| [**GetContact**](AccountingApi.md#getcontact) | **GET** /Contacts/{ContactID} | Retrieves a specific contacts in a Xero organisation using a unique contact Id |
| [**GetContactAttachmentByFileName**](AccountingApi.md#getcontactattachmentbyfilename) | **GET** /Contacts/{ContactID}/Attachments/{FileName} | Retrieves a specific attachment from a specific contact by file name |
| [**GetContactAttachmentById**](AccountingApi.md#getcontactattachmentbyid) | **GET** /Contacts/{ContactID}/Attachments/{AttachmentID} | Retrieves a specific attachment from a specific contact using a unique attachment Id |
| [**GetContactAttachments**](AccountingApi.md#getcontactattachments) | **GET** /Contacts/{ContactID}/Attachments | Retrieves attachments for a specific contact in a Xero organisation |
| [**GetContactByContactNumber**](AccountingApi.md#getcontactbycontactnumber) | **GET** /Contacts/{ContactNumber} | Retrieves a specific contact by contact number in a Xero organisation |
| [**GetContactCISSettings**](AccountingApi.md#getcontactcissettings) | **GET** /Contacts/{ContactID}/CISSettings | Retrieves CIS settings for a specific contact in a Xero organisation |
| [**GetContactGroup**](AccountingApi.md#getcontactgroup) | **GET** /ContactGroups/{ContactGroupID} | Retrieves a specific contact group by using a unique contact group Id |
| [**GetContactGroups**](AccountingApi.md#getcontactgroups) | **GET** /ContactGroups | Retrieves the contact Id and name of each contact group |
| [**GetContactHistory**](AccountingApi.md#getcontacthistory) | **GET** /Contacts/{ContactID}/History | Retrieves history records for a specific contact |
| [**GetContacts**](AccountingApi.md#getcontacts) | **GET** /Contacts | Retrieves all contacts in a Xero organisation |
| [**GetCreditNote**](AccountingApi.md#getcreditnote) | **GET** /CreditNotes/{CreditNoteID} | Retrieves a specific credit note using a unique credit note Id |
| [**GetCreditNoteAsPdf**](AccountingApi.md#getcreditnoteaspdf) | **GET** /CreditNotes/{CreditNoteID}/pdf | Retrieves credit notes as PDF files |
| [**GetCreditNoteAttachmentByFileName**](AccountingApi.md#getcreditnoteattachmentbyfilename) | **GET** /CreditNotes/{CreditNoteID}/Attachments/{FileName} | Retrieves a specific attachment on a specific credit note by file name |
| [**GetCreditNoteAttachmentById**](AccountingApi.md#getcreditnoteattachmentbyid) | **GET** /CreditNotes/{CreditNoteID}/Attachments/{AttachmentID} | Retrieves a specific attachment from a specific credit note using a unique attachment Id |
| [**GetCreditNoteAttachments**](AccountingApi.md#getcreditnoteattachments) | **GET** /CreditNotes/{CreditNoteID}/Attachments | Retrieves attachments for a specific credit notes |
| [**GetCreditNoteHistory**](AccountingApi.md#getcreditnotehistory) | **GET** /CreditNotes/{CreditNoteID}/History | Retrieves history records of a specific credit note |
| [**GetCreditNotes**](AccountingApi.md#getcreditnotes) | **GET** /CreditNotes | Retrieves any credit notes |
| [**GetCurrencies**](AccountingApi.md#getcurrencies) | **GET** /Currencies | Retrieves currencies for your Xero organisation |
| [**GetEmployee**](AccountingApi.md#getemployee) | **GET** /Employees/{EmployeeID} | Retrieves a specific employee used in Xero payrun using a unique employee Id |
| [**GetEmployees**](AccountingApi.md#getemployees) | **GET** /Employees | Retrieves employees used in Xero payrun |
| [**GetExpenseClaim**](AccountingApi.md#getexpenseclaim) | **GET** /ExpenseClaims/{ExpenseClaimID} | Retrieves a specific expense claim using a unique expense claim Id |
| [**GetExpenseClaimHistory**](AccountingApi.md#getexpenseclaimhistory) | **GET** /ExpenseClaims/{ExpenseClaimID}/History | Retrieves history records of a specific expense claim |
| [**GetExpenseClaims**](AccountingApi.md#getexpenseclaims) | **GET** /ExpenseClaims | Retrieves expense claims |
| [**GetInvoice**](AccountingApi.md#getinvoice) | **GET** /Invoices/{InvoiceID} | Retrieves a specific sales invoice or purchase bill using a unique invoice Id |
| [**GetInvoiceAsPdf**](AccountingApi.md#getinvoiceaspdf) | **GET** /Invoices/{InvoiceID}/pdf | Retrieves invoices or purchase bills as PDF files |
| [**GetInvoiceAttachmentByFileName**](AccountingApi.md#getinvoiceattachmentbyfilename) | **GET** /Invoices/{InvoiceID}/Attachments/{FileName} | Retrieves an attachment from a specific invoice or purchase bill by filename |
| [**GetInvoiceAttachmentById**](AccountingApi.md#getinvoiceattachmentbyid) | **GET** /Invoices/{InvoiceID}/Attachments/{AttachmentID} | Retrieves a specific attachment from a specific invoices or purchase bills by using a unique attachment Id |
| [**GetInvoiceAttachments**](AccountingApi.md#getinvoiceattachments) | **GET** /Invoices/{InvoiceID}/Attachments | Retrieves attachments for a specific invoice or purchase bill |
| [**GetInvoiceHistory**](AccountingApi.md#getinvoicehistory) | **GET** /Invoices/{InvoiceID}/History | Retrieves history records for a specific invoice |
| [**GetInvoiceReminders**](AccountingApi.md#getinvoicereminders) | **GET** /InvoiceReminders/Settings | Retrieves invoice reminder settings |
| [**GetInvoices**](AccountingApi.md#getinvoices) | **GET** /Invoices | Retrieves sales invoices or purchase bills |
| [**GetItem**](AccountingApi.md#getitem) | **GET** /Items/{ItemID} | Retrieves a specific item using a unique item Id |
| [**GetItemHistory**](AccountingApi.md#getitemhistory) | **GET** /Items/{ItemID}/History | Retrieves history for a specific item |
| [**GetItems**](AccountingApi.md#getitems) | **GET** /Items | Retrieves items |
| [**GetJournal**](AccountingApi.md#getjournal) | **GET** /Journals/{JournalID} | Retrieves a specific journal using a unique journal Id. |
| [**GetJournalByNumber**](AccountingApi.md#getjournalbynumber) | **GET** /Journals/{JournalNumber} | Retrieves a specific journal using a unique journal number. |
| [**GetJournals**](AccountingApi.md#getjournals) | **GET** /Journals | Retrieves journals |
| [**GetLinkedTransaction**](AccountingApi.md#getlinkedtransaction) | **GET** /LinkedTransactions/{LinkedTransactionID} | Retrieves a specific linked transaction (billable expenses) using a unique linked transaction Id |
| [**GetLinkedTransactions**](AccountingApi.md#getlinkedtransactions) | **GET** /LinkedTransactions | Retrieves linked transactions (billable expenses) |
| [**GetManualJournal**](AccountingApi.md#getmanualjournal) | **GET** /ManualJournals/{ManualJournalID} | Retrieves a specific manual journal |
| [**GetManualJournalAttachmentByFileName**](AccountingApi.md#getmanualjournalattachmentbyfilename) | **GET** /ManualJournals/{ManualJournalID}/Attachments/{FileName} | Retrieves a specific attachment from a specific manual journal by file name |
| [**GetManualJournalAttachmentById**](AccountingApi.md#getmanualjournalattachmentbyid) | **GET** /ManualJournals/{ManualJournalID}/Attachments/{AttachmentID} | Allows you to retrieve a specific attachment from a specific manual journal using a unique attachment Id |
| [**GetManualJournalAttachments**](AccountingApi.md#getmanualjournalattachments) | **GET** /ManualJournals/{ManualJournalID}/Attachments | Retrieves attachment for a specific manual journal |
| [**GetManualJournals**](AccountingApi.md#getmanualjournals) | **GET** /ManualJournals | Retrieves manual journals |
| [**GetManualJournalsHistory**](AccountingApi.md#getmanualjournalshistory) | **GET** /ManualJournals/{ManualJournalID}/History | Retrieves history for a specific manual journal |
| [**GetOnlineInvoice**](AccountingApi.md#getonlineinvoice) | **GET** /Invoices/{InvoiceID}/OnlineInvoice | Retrieves a URL to an online invoice |
| [**GetOrganisationActions**](AccountingApi.md#getorganisationactions) | **GET** /Organisation/Actions | Retrieves a list of the key actions your app has permission to perform in the connected Xero organisation. |
| [**GetOrganisationCISSettings**](AccountingApi.md#getorganisationcissettings) | **GET** /Organisation/{OrganisationID}/CISSettings | Retrieves the CIS settings for the Xero organistaion. |
| [**GetOrganisations**](AccountingApi.md#getorganisations) | **GET** /Organisation | Retrieves Xero organisation details |
| [**GetOverpayment**](AccountingApi.md#getoverpayment) | **GET** /Overpayments/{OverpaymentID} | Retrieves a specific overpayment using a unique overpayment Id |
| [**GetOverpaymentHistory**](AccountingApi.md#getoverpaymenthistory) | **GET** /Overpayments/{OverpaymentID}/History | Retrieves history records of a specific overpayment |
| [**GetOverpayments**](AccountingApi.md#getoverpayments) | **GET** /Overpayments | Retrieves overpayments |
| [**GetPayment**](AccountingApi.md#getpayment) | **GET** /Payments/{PaymentID} | Retrieves a specific payment for invoices and credit notes using a unique payment Id |
| [**GetPaymentHistory**](AccountingApi.md#getpaymenthistory) | **GET** /Payments/{PaymentID}/History | Retrieves history records of a specific payment |
| [**GetPaymentServices**](AccountingApi.md#getpaymentservices) | **GET** /PaymentServices | Retrieves payment services |
| [**GetPayments**](AccountingApi.md#getpayments) | **GET** /Payments | Retrieves payments for invoices and credit notes |
| [**GetPrepayment**](AccountingApi.md#getprepayment) | **GET** /Prepayments/{PrepaymentID} | Allows you to retrieve a specified prepayments |
| [**GetPrepaymentHistory**](AccountingApi.md#getprepaymenthistory) | **GET** /Prepayments/{PrepaymentID}/History | Retrieves history record for a specific prepayment |
| [**GetPrepayments**](AccountingApi.md#getprepayments) | **GET** /Prepayments | Retrieves prepayments |
| [**GetPurchaseOrder**](AccountingApi.md#getpurchaseorder) | **GET** /PurchaseOrders/{PurchaseOrderID} | Retrieves a specific purchase order using a unique purchase order Id |
| [**GetPurchaseOrderAsPdf**](AccountingApi.md#getpurchaseorderaspdf) | **GET** /PurchaseOrders/{PurchaseOrderID}/pdf | Retrieves specific purchase order as PDF files using a unique purchase order Id |
| [**GetPurchaseOrderAttachmentByFileName**](AccountingApi.md#getpurchaseorderattachmentbyfilename) | **GET** /PurchaseOrders/{PurchaseOrderID}/Attachments/{FileName} | Retrieves a specific attachment for a specific purchase order by filename |
| [**GetPurchaseOrderAttachmentById**](AccountingApi.md#getpurchaseorderattachmentbyid) | **GET** /PurchaseOrders/{PurchaseOrderID}/Attachments/{AttachmentID} | Retrieves specific attachment for a specific purchase order using a unique attachment Id |
| [**GetPurchaseOrderAttachments**](AccountingApi.md#getpurchaseorderattachments) | **GET** /PurchaseOrders/{PurchaseOrderID}/Attachments | Retrieves attachments for a specific purchase order |
| [**GetPurchaseOrderByNumber**](AccountingApi.md#getpurchaseorderbynumber) | **GET** /PurchaseOrders/{PurchaseOrderNumber} | Retrieves a specific purchase order using purchase order number |
| [**GetPurchaseOrderHistory**](AccountingApi.md#getpurchaseorderhistory) | **GET** /PurchaseOrders/{PurchaseOrderID}/History | Retrieves history for a specific purchase order |
| [**GetPurchaseOrders**](AccountingApi.md#getpurchaseorders) | **GET** /PurchaseOrders | Retrieves purchase orders |
| [**GetQuote**](AccountingApi.md#getquote) | **GET** /Quotes/{QuoteID} | Retrieves a specific quote using a unique quote Id |
| [**GetQuoteAsPdf**](AccountingApi.md#getquoteaspdf) | **GET** /Quotes/{QuoteID}/pdf | Retrieves a specific quote as a PDF file using a unique quote Id |
| [**GetQuoteAttachmentByFileName**](AccountingApi.md#getquoteattachmentbyfilename) | **GET** /Quotes/{QuoteID}/Attachments/{FileName} | Retrieves a specific attachment from a specific quote by filename |
| [**GetQuoteAttachmentById**](AccountingApi.md#getquoteattachmentbyid) | **GET** /Quotes/{QuoteID}/Attachments/{AttachmentID} | Retrieves a specific attachment from a specific quote using a unique attachment Id |
| [**GetQuoteAttachments**](AccountingApi.md#getquoteattachments) | **GET** /Quotes/{QuoteID}/Attachments | Retrieves attachments for a specific quote |
| [**GetQuoteHistory**](AccountingApi.md#getquotehistory) | **GET** /Quotes/{QuoteID}/History | Retrieves history records of a specific quote |
| [**GetQuotes**](AccountingApi.md#getquotes) | **GET** /Quotes | Retrieves sales quotes |
| [**GetReceipt**](AccountingApi.md#getreceipt) | **GET** /Receipts/{ReceiptID} | Retrieves a specific draft expense claim receipt by using a unique receipt Id |
| [**GetReceiptAttachmentByFileName**](AccountingApi.md#getreceiptattachmentbyfilename) | **GET** /Receipts/{ReceiptID}/Attachments/{FileName} | Retrieves a specific attachment from a specific expense claim receipts by file name |
| [**GetReceiptAttachmentById**](AccountingApi.md#getreceiptattachmentbyid) | **GET** /Receipts/{ReceiptID}/Attachments/{AttachmentID} | Retrieves a specific attachments from a specific expense claim receipts by using a unique attachment Id |
| [**GetReceiptAttachments**](AccountingApi.md#getreceiptattachments) | **GET** /Receipts/{ReceiptID}/Attachments | Retrieves attachments for a specific expense claim receipt |
| [**GetReceiptHistory**](AccountingApi.md#getreceipthistory) | **GET** /Receipts/{ReceiptID}/History | Retrieves a history record for a specific receipt |
| [**GetReceipts**](AccountingApi.md#getreceipts) | **GET** /Receipts | Retrieves draft expense claim receipts for any user |
| [**GetRepeatingInvoice**](AccountingApi.md#getrepeatinginvoice) | **GET** /RepeatingInvoices/{RepeatingInvoiceID} | Retrieves a specific repeating invoice by using a unique repeating invoice Id |
| [**GetRepeatingInvoiceAttachmentByFileName**](AccountingApi.md#getrepeatinginvoiceattachmentbyfilename) | **GET** /RepeatingInvoices/{RepeatingInvoiceID}/Attachments/{FileName} | Retrieves a specific attachment from a specific repeating invoices by file name |
| [**GetRepeatingInvoiceAttachmentById**](AccountingApi.md#getrepeatinginvoiceattachmentbyid) | **GET** /RepeatingInvoices/{RepeatingInvoiceID}/Attachments/{AttachmentID} | Retrieves a specific attachment from a specific repeating invoice |
| [**GetRepeatingInvoiceAttachments**](AccountingApi.md#getrepeatinginvoiceattachments) | **GET** /RepeatingInvoices/{RepeatingInvoiceID}/Attachments | Retrieves attachments from a specific repeating invoice |
| [**GetRepeatingInvoiceHistory**](AccountingApi.md#getrepeatinginvoicehistory) | **GET** /RepeatingInvoices/{RepeatingInvoiceID}/History | Retrieves history record for a specific repeating invoice |
| [**GetRepeatingInvoices**](AccountingApi.md#getrepeatinginvoices) | **GET** /RepeatingInvoices | Retrieves repeating invoices |
| [**GetReportAgedPayablesByContact**](AccountingApi.md#getreportagedpayablesbycontact) | **GET** /Reports/AgedPayablesByContact | Retrieves report for aged payables by contact |
| [**GetReportAgedReceivablesByContact**](AccountingApi.md#getreportagedreceivablesbycontact) | **GET** /Reports/AgedReceivablesByContact | Retrieves report for aged receivables by contact |
| [**GetReportBalanceSheet**](AccountingApi.md#getreportbalancesheet) | **GET** /Reports/BalanceSheet | Retrieves report for balancesheet |
| [**GetReportBankSummary**](AccountingApi.md#getreportbanksummary) | **GET** /Reports/BankSummary | Retrieves report for bank summary |
| [**GetReportBudgetSummary**](AccountingApi.md#getreportbudgetsummary) | **GET** /Reports/BudgetSummary | Retrieves report for budget summary |
| [**GetReportExecutiveSummary**](AccountingApi.md#getreportexecutivesummary) | **GET** /Reports/ExecutiveSummary | Retrieves report for executive summary |
| [**GetReportFromId**](AccountingApi.md#getreportfromid) | **GET** /Reports/{ReportID} | Retrieves a specific report using a unique ReportID |
| [**GetReportProfitAndLoss**](AccountingApi.md#getreportprofitandloss) | **GET** /Reports/ProfitAndLoss | Retrieves report for profit and loss |
| [**GetReportTenNinetyNine**](AccountingApi.md#getreporttenninetynine) | **GET** /Reports/TenNinetyNine | Retrieve reports for 1099 |
| [**GetReportTrialBalance**](AccountingApi.md#getreporttrialbalance) | **GET** /Reports/TrialBalance | Retrieves report for trial balance |
| [**GetReportsList**](AccountingApi.md#getreportslist) | **GET** /Reports | Retrieves a list of the organistaions unique reports that require a uuid to fetch |
| [**GetTaxRateByTaxType**](AccountingApi.md#gettaxratebytaxtype) | **GET** /TaxRates/{TaxType} | Retrieves a specific tax rate according to given TaxType code |
| [**GetTaxRates**](AccountingApi.md#gettaxrates) | **GET** /TaxRates | Retrieves tax rates |
| [**GetTrackingCategories**](AccountingApi.md#gettrackingcategories) | **GET** /TrackingCategories | Retrieves tracking categories and options |
| [**GetTrackingCategory**](AccountingApi.md#gettrackingcategory) | **GET** /TrackingCategories/{TrackingCategoryID} | Retrieves specific tracking categories and options using a unique tracking category Id |
| [**GetUser**](AccountingApi.md#getuser) | **GET** /Users/{UserID} | Retrieves a specific user |
| [**GetUsers**](AccountingApi.md#getusers) | **GET** /Users | Retrieves users |
| [**PostSetup**](AccountingApi.md#postsetup) | **POST** /Setup | Sets the chart of accounts, the conversion date and conversion balances |
| [**UpdateAccount**](AccountingApi.md#updateaccount) | **POST** /Accounts/{AccountID} | Updates a chart of accounts |
| [**UpdateAccountAttachmentByFileName**](AccountingApi.md#updateaccountattachmentbyfilename) | **POST** /Accounts/{AccountID}/Attachments/{FileName} | Updates attachment on a specific account by filename |
| [**UpdateBankTransaction**](AccountingApi.md#updatebanktransaction) | **POST** /BankTransactions/{BankTransactionID} | Updates a single spent or received money transaction |
| [**UpdateBankTransactionAttachmentByFileName**](AccountingApi.md#updatebanktransactionattachmentbyfilename) | **POST** /BankTransactions/{BankTransactionID}/Attachments/{FileName} | Updates a specific attachment from a specific bank transaction by filename |
| [**UpdateBankTransferAttachmentByFileName**](AccountingApi.md#updatebanktransferattachmentbyfilename) | **POST** /BankTransfers/{BankTransferID}/Attachments/{FileName} |  |
| [**UpdateContact**](AccountingApi.md#updatecontact) | **POST** /Contacts/{ContactID} | Updates a specific contact in a Xero organisation |
| [**UpdateContactAttachmentByFileName**](AccountingApi.md#updatecontactattachmentbyfilename) | **POST** /Contacts/{ContactID}/Attachments/{FileName} |  |
| [**UpdateContactGroup**](AccountingApi.md#updatecontactgroup) | **POST** /ContactGroups/{ContactGroupID} | Updates a specific contact group |
| [**UpdateCreditNote**](AccountingApi.md#updatecreditnote) | **POST** /CreditNotes/{CreditNoteID} | Updates a specific credit note |
| [**UpdateCreditNoteAttachmentByFileName**](AccountingApi.md#updatecreditnoteattachmentbyfilename) | **POST** /CreditNotes/{CreditNoteID}/Attachments/{FileName} | Updates attachments on a specific credit note by file name |
| [**UpdateExpenseClaim**](AccountingApi.md#updateexpenseclaim) | **POST** /ExpenseClaims/{ExpenseClaimID} | Updates a specific expense claims |
| [**UpdateInvoice**](AccountingApi.md#updateinvoice) | **POST** /Invoices/{InvoiceID} | Updates a specific sales invoices or purchase bills |
| [**UpdateInvoiceAttachmentByFileName**](AccountingApi.md#updateinvoiceattachmentbyfilename) | **POST** /Invoices/{InvoiceID}/Attachments/{FileName} | Updates an attachment from a specific invoices or purchase bill by filename |
| [**UpdateItem**](AccountingApi.md#updateitem) | **POST** /Items/{ItemID} | Updates a specific item |
| [**UpdateLinkedTransaction**](AccountingApi.md#updatelinkedtransaction) | **POST** /LinkedTransactions/{LinkedTransactionID} | Updates a specific linked transactions (billable expenses) |
| [**UpdateManualJournal**](AccountingApi.md#updatemanualjournal) | **POST** /ManualJournals/{ManualJournalID} | Updates a specific manual journal |
| [**UpdateManualJournalAttachmentByFileName**](AccountingApi.md#updatemanualjournalattachmentbyfilename) | **POST** /ManualJournals/{ManualJournalID}/Attachments/{FileName} | Updates a specific attachment from a specific manual journal by file name |
| [**UpdateOrCreateBankTransactions**](AccountingApi.md#updateorcreatebanktransactions) | **POST** /BankTransactions | Updates or creates one or more spent or received money transaction |
| [**UpdateOrCreateContacts**](AccountingApi.md#updateorcreatecontacts) | **POST** /Contacts | Updates or creates one or more contacts in a Xero organisation |
| [**UpdateOrCreateCreditNotes**](AccountingApi.md#updateorcreatecreditnotes) | **POST** /CreditNotes | Updates or creates one or more credit notes |
| [**UpdateOrCreateEmployees**](AccountingApi.md#updateorcreateemployees) | **POST** /Employees | Creates a single new employees used in Xero payrun |
| [**UpdateOrCreateInvoices**](AccountingApi.md#updateorcreateinvoices) | **POST** /Invoices | Updates or creates one or more sales invoices or purchase bills |
| [**UpdateOrCreateItems**](AccountingApi.md#updateorcreateitems) | **POST** /Items | Updates or creates one or more items |
| [**UpdateOrCreateManualJournals**](AccountingApi.md#updateorcreatemanualjournals) | **POST** /ManualJournals | Updates or creates a single manual journal |
| [**UpdateOrCreatePurchaseOrders**](AccountingApi.md#updateorcreatepurchaseorders) | **POST** /PurchaseOrders | Updates or creates one or more purchase orders |
| [**UpdateOrCreateQuotes**](AccountingApi.md#updateorcreatequotes) | **POST** /Quotes | Updates or creates one or more quotes |
| [**UpdateOrCreateRepeatingInvoices**](AccountingApi.md#updateorcreaterepeatinginvoices) | **POST** /RepeatingInvoices | Creates or deletes one or more repeating invoice templates |
| [**UpdatePurchaseOrder**](AccountingApi.md#updatepurchaseorder) | **POST** /PurchaseOrders/{PurchaseOrderID} | Updates a specific purchase order |
| [**UpdatePurchaseOrderAttachmentByFileName**](AccountingApi.md#updatepurchaseorderattachmentbyfilename) | **POST** /PurchaseOrders/{PurchaseOrderID}/Attachments/{FileName} | Updates a specific attachment for a specific purchase order by filename |
| [**UpdateQuote**](AccountingApi.md#updatequote) | **POST** /Quotes/{QuoteID} | Updates a specific quote |
| [**UpdateQuoteAttachmentByFileName**](AccountingApi.md#updatequoteattachmentbyfilename) | **POST** /Quotes/{QuoteID}/Attachments/{FileName} | Updates a specific attachment from a specific quote by filename |
| [**UpdateReceipt**](AccountingApi.md#updatereceipt) | **POST** /Receipts/{ReceiptID} | Updates a specific draft expense claim receipts |
| [**UpdateReceiptAttachmentByFileName**](AccountingApi.md#updatereceiptattachmentbyfilename) | **POST** /Receipts/{ReceiptID}/Attachments/{FileName} | Updates a specific attachment on a specific expense claim receipts by file name |
| [**UpdateRepeatingInvoice**](AccountingApi.md#updaterepeatinginvoice) | **POST** /RepeatingInvoices/{RepeatingInvoiceID} | Deletes a specific repeating invoice template |
| [**UpdateRepeatingInvoiceAttachmentByFileName**](AccountingApi.md#updaterepeatinginvoiceattachmentbyfilename) | **POST** /RepeatingInvoices/{RepeatingInvoiceID}/Attachments/{FileName} | Updates a specific attachment from a specific repeating invoices by file name |
| [**UpdateTaxRate**](AccountingApi.md#updatetaxrate) | **POST** /TaxRates | Updates tax rates |
| [**UpdateTrackingCategory**](AccountingApi.md#updatetrackingcategory) | **POST** /TrackingCategories/{TrackingCategoryID} | Updates a specific tracking category |
| [**UpdateTrackingOptions**](AccountingApi.md#updatetrackingoptions) | **POST** /TrackingCategories/{TrackingCategoryID}/Options/{TrackingOptionID} | Updates a specific option for a specific tracking category |

<a id="createaccount"></a>
# **CreateAccount**
> Accounts CreateAccount (string xeroTenantId, Account account, string? idempotencyKey = null)

Creates a new chart of accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var account = new Account(); // Account | Account object in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a new chart of accounts
                Accounts result = apiInstance.CreateAccount(xeroTenantId, account, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new chart of accounts
    ApiResponse<Accounts> response = apiInstance.CreateAccountWithHttpInfo(xeroTenantId, account, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **account** | [**Account**](Account.md) | Account object in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Accounts**](Accounts.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - created new Account and return response of type Accounts array with new Account |  -  |
| **400** | Validation Error - some data was incorrect returns response of type Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createaccountattachmentbyfilename"></a>
# **CreateAccountAttachmentByFileName**
> Attachments CreateAccountAttachmentByFileName (string xeroTenantId, Guid accountID, string fileName, byte[] body, string? idempotencyKey = null)

Creates an attachment on a specific account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateAccountAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var accountID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Account object
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates an attachment on a specific account
                Attachments result = apiInstance.CreateAccountAttachmentByFileName(xeroTenantId, accountID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateAccountAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAccountAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates an attachment on a specific account
    ApiResponse<Attachments> response = apiInstance.CreateAccountAttachmentByFileNameWithHttpInfo(xeroTenantId, accountID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateAccountAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **accountID** | **Guid** | Unique identifier for Account object |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array of Attachment |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createbanktransactionattachmentbyfilename"></a>
# **CreateBankTransactionAttachmentByFileName**
> Attachments CreateBankTransactionAttachmentByFileName (string xeroTenantId, Guid bankTransactionID, string fileName, byte[] body, string? idempotencyKey = null)

Creates an attachment for a specific bank transaction by filename

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateBankTransactionAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransactionID = 00000000-0000-0000-0000-000000000000;  // Guid | Xero generated unique identifier for a bank transaction
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates an attachment for a specific bank transaction by filename
                Attachments result = apiInstance.CreateBankTransactionAttachmentByFileName(xeroTenantId, bankTransactionID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateBankTransactionAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBankTransactionAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates an attachment for a specific bank transaction by filename
    ApiResponse<Attachments> response = apiInstance.CreateBankTransactionAttachmentByFileNameWithHttpInfo(xeroTenantId, bankTransactionID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateBankTransactionAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransactionID** | **Guid** | Xero generated unique identifier for a bank transaction |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of Attachments array of Attachment |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createbanktransactionhistoryrecord"></a>
# **CreateBankTransactionHistoryRecord**
> HistoryRecords CreateBankTransactionHistoryRecord (string xeroTenantId, Guid bankTransactionID, HistoryRecords historyRecords, string? idempotencyKey = null)

Creates a history record for a specific bank transactions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateBankTransactionHistoryRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransactionID = 00000000-0000-0000-0000-000000000000;  // Guid | Xero generated unique identifier for a bank transaction
            var historyRecords = new HistoryRecords(); // HistoryRecords | HistoryRecords containing an array of HistoryRecord objects in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a history record for a specific bank transactions
                HistoryRecords result = apiInstance.CreateBankTransactionHistoryRecord(xeroTenantId, bankTransactionID, historyRecords, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateBankTransactionHistoryRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBankTransactionHistoryRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a history record for a specific bank transactions
    ApiResponse<HistoryRecords> response = apiInstance.CreateBankTransactionHistoryRecordWithHttpInfo(xeroTenantId, bankTransactionID, historyRecords, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateBankTransactionHistoryRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransactionID** | **Guid** | Xero generated unique identifier for a bank transaction |  |
| **historyRecords** | [**HistoryRecords**](HistoryRecords.md) | HistoryRecords containing an array of HistoryRecord objects in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type HistoryRecords array of HistoryRecord objects |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createbanktransactions"></a>
# **CreateBankTransactions**
> BankTransactions CreateBankTransactions (string xeroTenantId, BankTransactions bankTransactions, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null)

Creates one or more spent or received money transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateBankTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransactions = new BankTransactions(); // BankTransactions | BankTransactions with an array of BankTransaction objects in body of request
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates one or more spent or received money transaction
                BankTransactions result = apiInstance.CreateBankTransactions(xeroTenantId, bankTransactions, summarizeErrors, unitdp, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateBankTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBankTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates one or more spent or received money transaction
    ApiResponse<BankTransactions> response = apiInstance.CreateBankTransactionsWithHttpInfo(xeroTenantId, bankTransactions, summarizeErrors, unitdp, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateBankTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransactions** | [**BankTransactions**](BankTransactions.md) | BankTransactions with an array of BankTransaction objects in body of request |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**BankTransactions**](BankTransactions.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type BankTransactions array with new BankTransaction |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createbanktransfer"></a>
# **CreateBankTransfer**
> BankTransfers CreateBankTransfer (string xeroTenantId, BankTransfers bankTransfers, string? idempotencyKey = null)

Creates a bank transfer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateBankTransferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransfers = new BankTransfers(); // BankTransfers | BankTransfers with array of BankTransfer objects in request body
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a bank transfer
                BankTransfers result = apiInstance.CreateBankTransfer(xeroTenantId, bankTransfers, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateBankTransfer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBankTransferWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a bank transfer
    ApiResponse<BankTransfers> response = apiInstance.CreateBankTransferWithHttpInfo(xeroTenantId, bankTransfers, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateBankTransferWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransfers** | [**BankTransfers**](BankTransfers.md) | BankTransfers with array of BankTransfer objects in request body |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**BankTransfers**](BankTransfers.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of BankTransfers array of one BankTransfer |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createbanktransferattachmentbyfilename"></a>
# **CreateBankTransferAttachmentByFileName**
> Attachments CreateBankTransferAttachmentByFileName (string xeroTenantId, Guid bankTransferID, string fileName, byte[] body, string? idempotencyKey = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateBankTransferAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransferID = 00000000-0000-0000-0000-000000000000;  // Guid | Xero generated unique identifier for a bank transfer
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                Attachments result = apiInstance.CreateBankTransferAttachmentByFileName(xeroTenantId, bankTransferID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateBankTransferAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBankTransferAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Attachments> response = apiInstance.CreateBankTransferAttachmentByFileNameWithHttpInfo(xeroTenantId, bankTransferID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateBankTransferAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransferID** | **Guid** | Xero generated unique identifier for a bank transfer |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of Attachments array of 0 to N Attachment for a Bank Transfer |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createbanktransferhistoryrecord"></a>
# **CreateBankTransferHistoryRecord**
> HistoryRecords CreateBankTransferHistoryRecord (string xeroTenantId, Guid bankTransferID, HistoryRecords historyRecords, string? idempotencyKey = null)

Creates a history record for a specific bank transfer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateBankTransferHistoryRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransferID = 00000000-0000-0000-0000-000000000000;  // Guid | Xero generated unique identifier for a bank transfer
            var historyRecords = new HistoryRecords(); // HistoryRecords | HistoryRecords containing an array of HistoryRecord objects in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a history record for a specific bank transfer
                HistoryRecords result = apiInstance.CreateBankTransferHistoryRecord(xeroTenantId, bankTransferID, historyRecords, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateBankTransferHistoryRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBankTransferHistoryRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a history record for a specific bank transfer
    ApiResponse<HistoryRecords> response = apiInstance.CreateBankTransferHistoryRecordWithHttpInfo(xeroTenantId, bankTransferID, historyRecords, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateBankTransferHistoryRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransferID** | **Guid** | Xero generated unique identifier for a bank transfer |  |
| **historyRecords** | [**HistoryRecords**](HistoryRecords.md) | HistoryRecords containing an array of HistoryRecord objects in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type HistoryRecords array of HistoryRecord objects |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createbatchpayment"></a>
# **CreateBatchPayment**
> BatchPayments CreateBatchPayment (string xeroTenantId, BatchPayments batchPayments, bool? summarizeErrors = null, string? idempotencyKey = null)

Creates one or many batch payments for invoices

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateBatchPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var batchPayments = new BatchPayments(); // BatchPayments | BatchPayments with an array of Payments in body of request
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates one or many batch payments for invoices
                BatchPayments result = apiInstance.CreateBatchPayment(xeroTenantId, batchPayments, summarizeErrors, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateBatchPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBatchPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates one or many batch payments for invoices
    ApiResponse<BatchPayments> response = apiInstance.CreateBatchPaymentWithHttpInfo(xeroTenantId, batchPayments, summarizeErrors, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateBatchPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **batchPayments** | [**BatchPayments**](BatchPayments.md) | BatchPayments with an array of Payments in body of request |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**BatchPayments**](BatchPayments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type BatchPayments array of BatchPayment objects |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createbatchpaymenthistoryrecord"></a>
# **CreateBatchPaymentHistoryRecord**
> HistoryRecords CreateBatchPaymentHistoryRecord (string xeroTenantId, Guid batchPaymentID, HistoryRecords historyRecords, string? idempotencyKey = null)

Creates a history record for a specific batch payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateBatchPaymentHistoryRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var batchPaymentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for BatchPayment
            var historyRecords = new HistoryRecords(); // HistoryRecords | HistoryRecords containing an array of HistoryRecord objects in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a history record for a specific batch payment
                HistoryRecords result = apiInstance.CreateBatchPaymentHistoryRecord(xeroTenantId, batchPaymentID, historyRecords, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateBatchPaymentHistoryRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBatchPaymentHistoryRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a history record for a specific batch payment
    ApiResponse<HistoryRecords> response = apiInstance.CreateBatchPaymentHistoryRecordWithHttpInfo(xeroTenantId, batchPaymentID, historyRecords, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateBatchPaymentHistoryRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **batchPaymentID** | **Guid** | Unique identifier for BatchPayment |  |
| **historyRecords** | [**HistoryRecords**](HistoryRecords.md) | HistoryRecords containing an array of HistoryRecord objects in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type HistoryRecords array of HistoryRecord objects |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createbrandingthemepaymentservices"></a>
# **CreateBrandingThemePaymentServices**
> PaymentServices CreateBrandingThemePaymentServices (string xeroTenantId, Guid brandingThemeID, PaymentServices paymentServices, string? idempotencyKey = null)

Creates a new custom payment service for a specific branding theme

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateBrandingThemePaymentServicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var brandingThemeID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Branding Theme
            var paymentServices = new PaymentServices(); // PaymentServices | PaymentServices array with PaymentService object in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a new custom payment service for a specific branding theme
                PaymentServices result = apiInstance.CreateBrandingThemePaymentServices(xeroTenantId, brandingThemeID, paymentServices, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateBrandingThemePaymentServices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBrandingThemePaymentServicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new custom payment service for a specific branding theme
    ApiResponse<PaymentServices> response = apiInstance.CreateBrandingThemePaymentServicesWithHttpInfo(xeroTenantId, brandingThemeID, paymentServices, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateBrandingThemePaymentServicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **brandingThemeID** | **Guid** | Unique identifier for a Branding Theme |  |
| **paymentServices** | [**PaymentServices**](PaymentServices.md) | PaymentServices array with PaymentService object in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**PaymentServices**](PaymentServices.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type PaymentServices array with newly created PaymentService |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcontactattachmentbyfilename"></a>
# **CreateContactAttachmentByFileName**
> Attachments CreateContactAttachmentByFileName (string xeroTenantId, Guid contactID, string fileName, byte[] body, string? idempotencyKey = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateContactAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Contact
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                Attachments result = apiInstance.CreateContactAttachmentByFileName(xeroTenantId, contactID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateContactAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateContactAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Attachments> response = apiInstance.CreateContactAttachmentByFileNameWithHttpInfo(xeroTenantId, contactID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateContactAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactID** | **Guid** | Unique identifier for a Contact |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array with an newly created Attachment |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcontactgroup"></a>
# **CreateContactGroup**
> ContactGroups CreateContactGroup (string xeroTenantId, ContactGroups contactGroups, string? idempotencyKey = null)

Creates a contact group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateContactGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactGroups = new ContactGroups(); // ContactGroups | ContactGroups with an array of names in request body
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a contact group
                ContactGroups result = apiInstance.CreateContactGroup(xeroTenantId, contactGroups, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateContactGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateContactGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a contact group
    ApiResponse<ContactGroups> response = apiInstance.CreateContactGroupWithHttpInfo(xeroTenantId, contactGroups, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateContactGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactGroups** | [**ContactGroups**](ContactGroups.md) | ContactGroups with an array of names in request body |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**ContactGroups**](ContactGroups.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Contact Groups array of newly created Contact Group |  -  |
| **400** | Validation Error - some data was incorrect returns response of type Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcontactgroupcontacts"></a>
# **CreateContactGroupContacts**
> Contacts CreateContactGroupContacts (string xeroTenantId, Guid contactGroupID, Contacts contacts, string? idempotencyKey = null)

Creates contacts to a specific contact group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateContactGroupContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactGroupID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Contact Group
            var contacts = new Contacts(); // Contacts | Contacts with array of contacts specifying the ContactID to be added to ContactGroup in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates contacts to a specific contact group
                Contacts result = apiInstance.CreateContactGroupContacts(xeroTenantId, contactGroupID, contacts, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateContactGroupContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateContactGroupContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates contacts to a specific contact group
    ApiResponse<Contacts> response = apiInstance.CreateContactGroupContactsWithHttpInfo(xeroTenantId, contactGroupID, contacts, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateContactGroupContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactGroupID** | **Guid** | Unique identifier for a Contact Group |  |
| **contacts** | [**Contacts**](Contacts.md) | Contacts with array of contacts specifying the ContactID to be added to ContactGroup in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Contacts**](Contacts.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Contacts array of added Contacts |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcontacthistory"></a>
# **CreateContactHistory**
> HistoryRecords CreateContactHistory (string xeroTenantId, Guid contactID, HistoryRecords historyRecords, string? idempotencyKey = null)

Creates a new history record for a specific contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateContactHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Contact
            var historyRecords = new HistoryRecords(); // HistoryRecords | HistoryRecords containing an array of HistoryRecord objects in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a new history record for a specific contact
                HistoryRecords result = apiInstance.CreateContactHistory(xeroTenantId, contactID, historyRecords, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateContactHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateContactHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new history record for a specific contact
    ApiResponse<HistoryRecords> response = apiInstance.CreateContactHistoryWithHttpInfo(xeroTenantId, contactID, historyRecords, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateContactHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactID** | **Guid** | Unique identifier for a Contact |  |
| **historyRecords** | [**HistoryRecords**](HistoryRecords.md) | HistoryRecords containing an array of HistoryRecord objects in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type HistoryRecords array of HistoryRecord objects |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcontacts"></a>
# **CreateContacts**
> Contacts CreateContacts (string xeroTenantId, Contacts contacts, bool? summarizeErrors = null, string? idempotencyKey = null)

Creates multiple contacts (bulk) in a Xero organisation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contacts = new Contacts(); // Contacts | Contacts with an array of Contact objects to create in body of request
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates multiple contacts (bulk) in a Xero organisation
                Contacts result = apiInstance.CreateContacts(xeroTenantId, contacts, summarizeErrors, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates multiple contacts (bulk) in a Xero organisation
    ApiResponse<Contacts> response = apiInstance.CreateContactsWithHttpInfo(xeroTenantId, contacts, summarizeErrors, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contacts** | [**Contacts**](Contacts.md) | Contacts with an array of Contact objects to create in body of request |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Contacts**](Contacts.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Contacts array with newly created Contact |  -  |
| **400** | Validation Error - some data was incorrect returns response of type Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcreditnoteallocation"></a>
# **CreateCreditNoteAllocation**
> Allocations CreateCreditNoteAllocation (string xeroTenantId, Guid creditNoteID, Allocations allocations, bool? summarizeErrors = null, string? idempotencyKey = null)

Creates allocation for a specific credit note

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCreditNoteAllocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var creditNoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Credit Note
            var allocations = new Allocations(); // Allocations | Allocations with array of Allocation object in body of request.
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates allocation for a specific credit note
                Allocations result = apiInstance.CreateCreditNoteAllocation(xeroTenantId, creditNoteID, allocations, summarizeErrors, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateCreditNoteAllocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCreditNoteAllocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates allocation for a specific credit note
    ApiResponse<Allocations> response = apiInstance.CreateCreditNoteAllocationWithHttpInfo(xeroTenantId, creditNoteID, allocations, summarizeErrors, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateCreditNoteAllocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **creditNoteID** | **Guid** | Unique identifier for a Credit Note |  |
| **allocations** | [**Allocations**](Allocations.md) | Allocations with array of Allocation object in body of request. |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Allocations**](Allocations.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Allocations array with newly created Allocation for specific Credit Note |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcreditnoteattachmentbyfilename"></a>
# **CreateCreditNoteAttachmentByFileName**
> Attachments CreateCreditNoteAttachmentByFileName (string xeroTenantId, Guid creditNoteID, string fileName, byte[] body, bool? includeOnline = null, string? idempotencyKey = null)

Creates an attachment for a specific credit note

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCreditNoteAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var creditNoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Credit Note
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var includeOnline = true;  // bool? | Allows an attachment to be seen by the end customer within their online invoice (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates an attachment for a specific credit note
                Attachments result = apiInstance.CreateCreditNoteAttachmentByFileName(xeroTenantId, creditNoteID, fileName, body, includeOnline, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateCreditNoteAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCreditNoteAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates an attachment for a specific credit note
    ApiResponse<Attachments> response = apiInstance.CreateCreditNoteAttachmentByFileNameWithHttpInfo(xeroTenantId, creditNoteID, fileName, body, includeOnline, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateCreditNoteAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **creditNoteID** | **Guid** | Unique identifier for a Credit Note |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **includeOnline** | **bool?** | Allows an attachment to be seen by the end customer within their online invoice | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array with newly created Attachment for specific Credit Note |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcreditnotehistory"></a>
# **CreateCreditNoteHistory**
> HistoryRecords CreateCreditNoteHistory (string xeroTenantId, Guid creditNoteID, HistoryRecords historyRecords, string? idempotencyKey = null)

Retrieves history records of a specific credit note

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCreditNoteHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var creditNoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Credit Note
            var historyRecords = new HistoryRecords(); // HistoryRecords | HistoryRecords containing an array of HistoryRecord objects in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Retrieves history records of a specific credit note
                HistoryRecords result = apiInstance.CreateCreditNoteHistory(xeroTenantId, creditNoteID, historyRecords, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateCreditNoteHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCreditNoteHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves history records of a specific credit note
    ApiResponse<HistoryRecords> response = apiInstance.CreateCreditNoteHistoryWithHttpInfo(xeroTenantId, creditNoteID, historyRecords, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateCreditNoteHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **creditNoteID** | **Guid** | Unique identifier for a Credit Note |  |
| **historyRecords** | [**HistoryRecords**](HistoryRecords.md) | HistoryRecords containing an array of HistoryRecord objects in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type HistoryRecords array of HistoryRecord objects |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcreditnotes"></a>
# **CreateCreditNotes**
> CreditNotes CreateCreditNotes (string xeroTenantId, CreditNotes creditNotes, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null)

Creates a new credit note

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCreditNotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var creditNotes = new CreditNotes(); // CreditNotes | Credit Notes with array of CreditNote object in body of request
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a new credit note
                CreditNotes result = apiInstance.CreateCreditNotes(xeroTenantId, creditNotes, summarizeErrors, unitdp, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateCreditNotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCreditNotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new credit note
    ApiResponse<CreditNotes> response = apiInstance.CreateCreditNotesWithHttpInfo(xeroTenantId, creditNotes, summarizeErrors, unitdp, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateCreditNotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **creditNotes** | [**CreditNotes**](CreditNotes.md) | Credit Notes with array of CreditNote object in body of request |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**CreditNotes**](CreditNotes.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Credit Notes array of newly created CreditNote |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcurrency"></a>
# **CreateCurrency**
> Currencies CreateCurrency (string xeroTenantId, Currency currency, string? idempotencyKey = null)

Create a new currency for a Xero organisation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCurrencyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var currency = new Currency(); // Currency | Currency object in the body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Create a new currency for a Xero organisation
                Currencies result = apiInstance.CreateCurrency(xeroTenantId, currency, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateCurrency: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCurrencyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new currency for a Xero organisation
    ApiResponse<Currencies> response = apiInstance.CreateCurrencyWithHttpInfo(xeroTenantId, currency, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateCurrencyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **currency** | [**Currency**](Currency.md) | Currency object in the body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Currencies**](Currencies.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Unsupported - return response incorrect exception, API is not able to create new Currency |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createemployees"></a>
# **CreateEmployees**
> Employees CreateEmployees (string xeroTenantId, Employees employees, bool? summarizeErrors = null, string? idempotencyKey = null)

Creates new employees used in Xero payrun

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateEmployeesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var employees = new Employees(); // Employees | Employees with array of Employee object in body of request
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates new employees used in Xero payrun
                Employees result = apiInstance.CreateEmployees(xeroTenantId, employees, summarizeErrors, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateEmployees: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEmployeesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates new employees used in Xero payrun
    ApiResponse<Employees> response = apiInstance.CreateEmployeesWithHttpInfo(xeroTenantId, employees, summarizeErrors, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateEmployeesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **employees** | [**Employees**](Employees.md) | Employees with array of Employee object in body of request |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Employees**](Employees.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Employees array with new Employee |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createexpenseclaimhistory"></a>
# **CreateExpenseClaimHistory**
> HistoryRecords CreateExpenseClaimHistory (string xeroTenantId, Guid expenseClaimID, HistoryRecords historyRecords, string? idempotencyKey = null)

Creates a history record for a specific expense claim

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateExpenseClaimHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var expenseClaimID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a ExpenseClaim
            var historyRecords = new HistoryRecords(); // HistoryRecords | HistoryRecords containing an array of HistoryRecord objects in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a history record for a specific expense claim
                HistoryRecords result = apiInstance.CreateExpenseClaimHistory(xeroTenantId, expenseClaimID, historyRecords, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateExpenseClaimHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateExpenseClaimHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a history record for a specific expense claim
    ApiResponse<HistoryRecords> response = apiInstance.CreateExpenseClaimHistoryWithHttpInfo(xeroTenantId, expenseClaimID, historyRecords, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateExpenseClaimHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **expenseClaimID** | **Guid** | Unique identifier for a ExpenseClaim |  |
| **historyRecords** | [**HistoryRecords**](HistoryRecords.md) | HistoryRecords containing an array of HistoryRecord objects in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type HistoryRecords array of HistoryRecord objects |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createexpenseclaims"></a>
# **CreateExpenseClaims**
> ExpenseClaims CreateExpenseClaims (string xeroTenantId, ExpenseClaims expenseClaims, string? idempotencyKey = null)

Creates expense claims

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateExpenseClaimsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var expenseClaims = new ExpenseClaims(); // ExpenseClaims | ExpenseClaims with array of ExpenseClaim object in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates expense claims
                ExpenseClaims result = apiInstance.CreateExpenseClaims(xeroTenantId, expenseClaims, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateExpenseClaims: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateExpenseClaimsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates expense claims
    ApiResponse<ExpenseClaims> response = apiInstance.CreateExpenseClaimsWithHttpInfo(xeroTenantId, expenseClaims, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateExpenseClaimsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **expenseClaims** | [**ExpenseClaims**](ExpenseClaims.md) | ExpenseClaims with array of ExpenseClaim object in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**ExpenseClaims**](ExpenseClaims.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type ExpenseClaims array with newly created ExpenseClaim |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createinvoiceattachmentbyfilename"></a>
# **CreateInvoiceAttachmentByFileName**
> Attachments CreateInvoiceAttachmentByFileName (string xeroTenantId, Guid invoiceID, string fileName, byte[] body, bool? includeOnline = null, string? idempotencyKey = null)

Creates an attachment for a specific invoice or purchase bill by filename

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateInvoiceAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var invoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Invoice
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var includeOnline = true;  // bool? | Allows an attachment to be seen by the end customer within their online invoice (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates an attachment for a specific invoice or purchase bill by filename
                Attachments result = apiInstance.CreateInvoiceAttachmentByFileName(xeroTenantId, invoiceID, fileName, body, includeOnline, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateInvoiceAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateInvoiceAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates an attachment for a specific invoice or purchase bill by filename
    ApiResponse<Attachments> response = apiInstance.CreateInvoiceAttachmentByFileNameWithHttpInfo(xeroTenantId, invoiceID, fileName, body, includeOnline, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateInvoiceAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **invoiceID** | **Guid** | Unique identifier for an Invoice |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **includeOnline** | **bool?** | Allows an attachment to be seen by the end customer within their online invoice | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array with newly created Attachment |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createinvoicehistory"></a>
# **CreateInvoiceHistory**
> HistoryRecords CreateInvoiceHistory (string xeroTenantId, Guid invoiceID, HistoryRecords historyRecords, string? idempotencyKey = null)

Creates a history record for a specific invoice

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateInvoiceHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var invoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Invoice
            var historyRecords = new HistoryRecords(); // HistoryRecords | HistoryRecords containing an array of HistoryRecord objects in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a history record for a specific invoice
                HistoryRecords result = apiInstance.CreateInvoiceHistory(xeroTenantId, invoiceID, historyRecords, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateInvoiceHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateInvoiceHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a history record for a specific invoice
    ApiResponse<HistoryRecords> response = apiInstance.CreateInvoiceHistoryWithHttpInfo(xeroTenantId, invoiceID, historyRecords, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateInvoiceHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **invoiceID** | **Guid** | Unique identifier for an Invoice |  |
| **historyRecords** | [**HistoryRecords**](HistoryRecords.md) | HistoryRecords containing an array of HistoryRecord objects in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type HistoryRecords array of HistoryRecord objects |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createinvoices"></a>
# **CreateInvoices**
> Invoices CreateInvoices (string xeroTenantId, Invoices invoices, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null)

Creates one or more sales invoices or purchase bills

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateInvoicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var invoices = new Invoices(); // Invoices | Invoices with an array of invoice objects in body of request
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates one or more sales invoices or purchase bills
                Invoices result = apiInstance.CreateInvoices(xeroTenantId, invoices, summarizeErrors, unitdp, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateInvoices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateInvoicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates one or more sales invoices or purchase bills
    ApiResponse<Invoices> response = apiInstance.CreateInvoicesWithHttpInfo(xeroTenantId, invoices, summarizeErrors, unitdp, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateInvoicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **invoices** | [**Invoices**](Invoices.md) | Invoices with an array of invoice objects in body of request |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Invoices**](Invoices.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Invoices array with newly created Invoice |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createitemhistory"></a>
# **CreateItemHistory**
> HistoryRecords CreateItemHistory (string xeroTenantId, Guid itemID, HistoryRecords historyRecords, string? idempotencyKey = null)

Creates a history record for a specific item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateItemHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var itemID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Item
            var historyRecords = new HistoryRecords(); // HistoryRecords | HistoryRecords containing an array of HistoryRecord objects in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a history record for a specific item
                HistoryRecords result = apiInstance.CreateItemHistory(xeroTenantId, itemID, historyRecords, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateItemHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateItemHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a history record for a specific item
    ApiResponse<HistoryRecords> response = apiInstance.CreateItemHistoryWithHttpInfo(xeroTenantId, itemID, historyRecords, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateItemHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **itemID** | **Guid** | Unique identifier for an Item |  |
| **historyRecords** | [**HistoryRecords**](HistoryRecords.md) | HistoryRecords containing an array of HistoryRecord objects in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type HistoryRecords array of HistoryRecord objects |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createitems"></a>
# **CreateItems**
> Items CreateItems (string xeroTenantId, Items items, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null)

Creates one or more items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var items = new Items(); // Items | Items with an array of Item objects in body of request
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates one or more items
                Items result = apiInstance.CreateItems(xeroTenantId, items, summarizeErrors, unitdp, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates one or more items
    ApiResponse<Items> response = apiInstance.CreateItemsWithHttpInfo(xeroTenantId, items, summarizeErrors, unitdp, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **items** | [**Items**](Items.md) | Items with an array of Item objects in body of request |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Items**](Items.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Items array with newly created Item |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createlinkedtransaction"></a>
# **CreateLinkedTransaction**
> LinkedTransactions CreateLinkedTransaction (string xeroTenantId, LinkedTransaction linkedTransaction, string? idempotencyKey = null)

Creates linked transactions (billable expenses)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateLinkedTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var linkedTransaction = new LinkedTransaction(); // LinkedTransaction | LinkedTransaction object in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates linked transactions (billable expenses)
                LinkedTransactions result = apiInstance.CreateLinkedTransaction(xeroTenantId, linkedTransaction, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateLinkedTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateLinkedTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates linked transactions (billable expenses)
    ApiResponse<LinkedTransactions> response = apiInstance.CreateLinkedTransactionWithHttpInfo(xeroTenantId, linkedTransaction, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateLinkedTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **linkedTransaction** | [**LinkedTransaction**](LinkedTransaction.md) | LinkedTransaction object in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**LinkedTransactions**](LinkedTransactions.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type LinkedTransactions array with newly created LinkedTransaction |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createmanualjournalattachmentbyfilename"></a>
# **CreateManualJournalAttachmentByFileName**
> Attachments CreateManualJournalAttachmentByFileName (string xeroTenantId, Guid manualJournalID, string fileName, byte[] body, string? idempotencyKey = null)

Creates a specific attachment for a specific manual journal by file name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateManualJournalAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var manualJournalID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a ManualJournal
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a specific attachment for a specific manual journal by file name
                Attachments result = apiInstance.CreateManualJournalAttachmentByFileName(xeroTenantId, manualJournalID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateManualJournalAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateManualJournalAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a specific attachment for a specific manual journal by file name
    ApiResponse<Attachments> response = apiInstance.CreateManualJournalAttachmentByFileNameWithHttpInfo(xeroTenantId, manualJournalID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateManualJournalAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **manualJournalID** | **Guid** | Unique identifier for a ManualJournal |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array with a newly created Attachment for a ManualJournals |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createmanualjournalhistoryrecord"></a>
# **CreateManualJournalHistoryRecord**
> HistoryRecords CreateManualJournalHistoryRecord (string xeroTenantId, Guid manualJournalID, HistoryRecords historyRecords, string? idempotencyKey = null)

Creates a history record for a specific manual journal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateManualJournalHistoryRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var manualJournalID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a ManualJournal
            var historyRecords = new HistoryRecords(); // HistoryRecords | HistoryRecords containing an array of HistoryRecord objects in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a history record for a specific manual journal
                HistoryRecords result = apiInstance.CreateManualJournalHistoryRecord(xeroTenantId, manualJournalID, historyRecords, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateManualJournalHistoryRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateManualJournalHistoryRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a history record for a specific manual journal
    ApiResponse<HistoryRecords> response = apiInstance.CreateManualJournalHistoryRecordWithHttpInfo(xeroTenantId, manualJournalID, historyRecords, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateManualJournalHistoryRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **manualJournalID** | **Guid** | Unique identifier for a ManualJournal |  |
| **historyRecords** | [**HistoryRecords**](HistoryRecords.md) | HistoryRecords containing an array of HistoryRecord objects in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type HistoryRecords array of HistoryRecord objects |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createmanualjournals"></a>
# **CreateManualJournals**
> ManualJournals CreateManualJournals (string xeroTenantId, ManualJournals manualJournals, bool? summarizeErrors = null, string? idempotencyKey = null)

Creates one or more manual journals

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateManualJournalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var manualJournals = new ManualJournals(); // ManualJournals | ManualJournals array with ManualJournal object in body of request
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates one or more manual journals
                ManualJournals result = apiInstance.CreateManualJournals(xeroTenantId, manualJournals, summarizeErrors, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateManualJournals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateManualJournalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates one or more manual journals
    ApiResponse<ManualJournals> response = apiInstance.CreateManualJournalsWithHttpInfo(xeroTenantId, manualJournals, summarizeErrors, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateManualJournalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **manualJournals** | [**ManualJournals**](ManualJournals.md) | ManualJournals array with ManualJournal object in body of request |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**ManualJournals**](ManualJournals.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type ManualJournals array with newly created ManualJournal |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createoverpaymentallocations"></a>
# **CreateOverpaymentAllocations**
> Allocations CreateOverpaymentAllocations (string xeroTenantId, Guid overpaymentID, Allocations allocations, bool? summarizeErrors = null, string? idempotencyKey = null)

Creates a single allocation for a specific overpayment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateOverpaymentAllocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var overpaymentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Overpayment
            var allocations = new Allocations(); // Allocations | Allocations array with Allocation object in body of request
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a single allocation for a specific overpayment
                Allocations result = apiInstance.CreateOverpaymentAllocations(xeroTenantId, overpaymentID, allocations, summarizeErrors, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateOverpaymentAllocations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOverpaymentAllocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a single allocation for a specific overpayment
    ApiResponse<Allocations> response = apiInstance.CreateOverpaymentAllocationsWithHttpInfo(xeroTenantId, overpaymentID, allocations, summarizeErrors, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateOverpaymentAllocationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **overpaymentID** | **Guid** | Unique identifier for a Overpayment |  |
| **allocations** | [**Allocations**](Allocations.md) | Allocations array with Allocation object in body of request |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Allocations**](Allocations.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Allocations array with all Allocation for Overpayments |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createoverpaymenthistory"></a>
# **CreateOverpaymentHistory**
> HistoryRecords CreateOverpaymentHistory (string xeroTenantId, Guid overpaymentID, HistoryRecords historyRecords, string? idempotencyKey = null)

Creates a history record for a specific overpayment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateOverpaymentHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var overpaymentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Overpayment
            var historyRecords = new HistoryRecords(); // HistoryRecords | HistoryRecords containing an array of HistoryRecord objects in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a history record for a specific overpayment
                HistoryRecords result = apiInstance.CreateOverpaymentHistory(xeroTenantId, overpaymentID, historyRecords, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateOverpaymentHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOverpaymentHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a history record for a specific overpayment
    ApiResponse<HistoryRecords> response = apiInstance.CreateOverpaymentHistoryWithHttpInfo(xeroTenantId, overpaymentID, historyRecords, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateOverpaymentHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **overpaymentID** | **Guid** | Unique identifier for a Overpayment |  |
| **historyRecords** | [**HistoryRecords**](HistoryRecords.md) | HistoryRecords containing an array of HistoryRecord objects in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type HistoryRecords array of HistoryRecord objects |  -  |
| **400** | A failed request due to validation error - API is not able to create HistoryRecord for Overpayments |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpayment"></a>
# **CreatePayment**
> Payments CreatePayment (string xeroTenantId, Payment payment, string? idempotencyKey = null)

Creates a single payment for invoice or credit notes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreatePaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var payment = new Payment(); // Payment | Request body with a single Payment object
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a single payment for invoice or credit notes
                Payments result = apiInstance.CreatePayment(xeroTenantId, payment, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreatePayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a single payment for invoice or credit notes
    ApiResponse<Payments> response = apiInstance.CreatePaymentWithHttpInfo(xeroTenantId, payment, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreatePaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **payment** | [**Payment**](Payment.md) | Request body with a single Payment object |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Payments**](Payments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Payments array for newly created Payment |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpaymenthistory"></a>
# **CreatePaymentHistory**
> HistoryRecords CreatePaymentHistory (string xeroTenantId, Guid paymentID, HistoryRecords historyRecords, string? idempotencyKey = null)

Creates a history record for a specific payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreatePaymentHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var paymentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Payment
            var historyRecords = new HistoryRecords(); // HistoryRecords | HistoryRecords containing an array of HistoryRecord objects in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a history record for a specific payment
                HistoryRecords result = apiInstance.CreatePaymentHistory(xeroTenantId, paymentID, historyRecords, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreatePaymentHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePaymentHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a history record for a specific payment
    ApiResponse<HistoryRecords> response = apiInstance.CreatePaymentHistoryWithHttpInfo(xeroTenantId, paymentID, historyRecords, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreatePaymentHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **paymentID** | **Guid** | Unique identifier for a Payment |  |
| **historyRecords** | [**HistoryRecords**](HistoryRecords.md) | HistoryRecords containing an array of HistoryRecord objects in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type HistoryRecords array of HistoryRecord objects |  -  |
| **400** | A failed request due to validation error - API is not able to create HistoryRecord for Payments |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpaymentservice"></a>
# **CreatePaymentService**
> PaymentServices CreatePaymentService (string xeroTenantId, PaymentServices paymentServices, string? idempotencyKey = null)

Creates a payment service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreatePaymentServiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var paymentServices = new PaymentServices(); // PaymentServices | PaymentServices array with PaymentService object in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a payment service
                PaymentServices result = apiInstance.CreatePaymentService(xeroTenantId, paymentServices, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreatePaymentService: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePaymentServiceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a payment service
    ApiResponse<PaymentServices> response = apiInstance.CreatePaymentServiceWithHttpInfo(xeroTenantId, paymentServices, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreatePaymentServiceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **paymentServices** | [**PaymentServices**](PaymentServices.md) | PaymentServices array with PaymentService object in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**PaymentServices**](PaymentServices.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type PaymentServices array for newly created PaymentService |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpayments"></a>
# **CreatePayments**
> Payments CreatePayments (string xeroTenantId, Payments payments, bool? summarizeErrors = null, string? idempotencyKey = null)

Creates multiple payments for invoices or credit notes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreatePaymentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var payments = new Payments(); // Payments | Payments array with Payment object in body of request
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates multiple payments for invoices or credit notes
                Payments result = apiInstance.CreatePayments(xeroTenantId, payments, summarizeErrors, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreatePayments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePaymentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates multiple payments for invoices or credit notes
    ApiResponse<Payments> response = apiInstance.CreatePaymentsWithHttpInfo(xeroTenantId, payments, summarizeErrors, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreatePaymentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **payments** | [**Payments**](Payments.md) | Payments array with Payment object in body of request |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Payments**](Payments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Payments array for newly created Payment |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createprepaymentallocations"></a>
# **CreatePrepaymentAllocations**
> Allocations CreatePrepaymentAllocations (string xeroTenantId, Guid prepaymentID, Allocations allocations, bool? summarizeErrors = null, string? idempotencyKey = null)

Allows you to create an Allocation for prepayments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreatePrepaymentAllocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var prepaymentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a PrePayment
            var allocations = new Allocations(); // Allocations | Allocations with an array of Allocation object in body of request
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Allows you to create an Allocation for prepayments
                Allocations result = apiInstance.CreatePrepaymentAllocations(xeroTenantId, prepaymentID, allocations, summarizeErrors, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreatePrepaymentAllocations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePrepaymentAllocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Allows you to create an Allocation for prepayments
    ApiResponse<Allocations> response = apiInstance.CreatePrepaymentAllocationsWithHttpInfo(xeroTenantId, prepaymentID, allocations, summarizeErrors, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreatePrepaymentAllocationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **prepaymentID** | **Guid** | Unique identifier for a PrePayment |  |
| **allocations** | [**Allocations**](Allocations.md) | Allocations with an array of Allocation object in body of request |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Allocations**](Allocations.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Allocations array of Allocation for all Prepayment |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createprepaymenthistory"></a>
# **CreatePrepaymentHistory**
> HistoryRecords CreatePrepaymentHistory (string xeroTenantId, Guid prepaymentID, HistoryRecords historyRecords, string? idempotencyKey = null)

Creates a history record for a specific prepayment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreatePrepaymentHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var prepaymentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a PrePayment
            var historyRecords = new HistoryRecords(); // HistoryRecords | HistoryRecords containing an array of HistoryRecord objects in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a history record for a specific prepayment
                HistoryRecords result = apiInstance.CreatePrepaymentHistory(xeroTenantId, prepaymentID, historyRecords, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreatePrepaymentHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePrepaymentHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a history record for a specific prepayment
    ApiResponse<HistoryRecords> response = apiInstance.CreatePrepaymentHistoryWithHttpInfo(xeroTenantId, prepaymentID, historyRecords, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreatePrepaymentHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **prepaymentID** | **Guid** | Unique identifier for a PrePayment |  |
| **historyRecords** | [**HistoryRecords**](HistoryRecords.md) | HistoryRecords containing an array of HistoryRecord objects in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type HistoryRecords array of HistoryRecord objects |  -  |
| **400** | Unsupported - return response incorrect exception, API is not able to create HistoryRecord for Expense Claims |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpurchaseorderattachmentbyfilename"></a>
# **CreatePurchaseOrderAttachmentByFileName**
> Attachments CreatePurchaseOrderAttachmentByFileName (string xeroTenantId, Guid purchaseOrderID, string fileName, byte[] body, string? idempotencyKey = null)

Creates attachment for a specific purchase order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreatePurchaseOrderAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var purchaseOrderID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Purchase Order
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates attachment for a specific purchase order
                Attachments result = apiInstance.CreatePurchaseOrderAttachmentByFileName(xeroTenantId, purchaseOrderID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreatePurchaseOrderAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePurchaseOrderAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates attachment for a specific purchase order
    ApiResponse<Attachments> response = apiInstance.CreatePurchaseOrderAttachmentByFileNameWithHttpInfo(xeroTenantId, purchaseOrderID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreatePurchaseOrderAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **purchaseOrderID** | **Guid** | Unique identifier for an Purchase Order |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array of Attachment |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpurchaseorderhistory"></a>
# **CreatePurchaseOrderHistory**
> HistoryRecords CreatePurchaseOrderHistory (string xeroTenantId, Guid purchaseOrderID, HistoryRecords historyRecords, string? idempotencyKey = null)

Creates a history record for a specific purchase orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreatePurchaseOrderHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var purchaseOrderID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Purchase Order
            var historyRecords = new HistoryRecords(); // HistoryRecords | HistoryRecords containing an array of HistoryRecord objects in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a history record for a specific purchase orders
                HistoryRecords result = apiInstance.CreatePurchaseOrderHistory(xeroTenantId, purchaseOrderID, historyRecords, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreatePurchaseOrderHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePurchaseOrderHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a history record for a specific purchase orders
    ApiResponse<HistoryRecords> response = apiInstance.CreatePurchaseOrderHistoryWithHttpInfo(xeroTenantId, purchaseOrderID, historyRecords, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreatePurchaseOrderHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **purchaseOrderID** | **Guid** | Unique identifier for an Purchase Order |  |
| **historyRecords** | [**HistoryRecords**](HistoryRecords.md) | HistoryRecords containing an array of HistoryRecord objects in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type HistoryRecords array of HistoryRecord objects |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpurchaseorders"></a>
# **CreatePurchaseOrders**
> PurchaseOrders CreatePurchaseOrders (string xeroTenantId, PurchaseOrders purchaseOrders, bool? summarizeErrors = null, string? idempotencyKey = null)

Creates one or more purchase orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreatePurchaseOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var purchaseOrders = new PurchaseOrders(); // PurchaseOrders | PurchaseOrders with an array of PurchaseOrder object in body of request
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates one or more purchase orders
                PurchaseOrders result = apiInstance.CreatePurchaseOrders(xeroTenantId, purchaseOrders, summarizeErrors, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreatePurchaseOrders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePurchaseOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates one or more purchase orders
    ApiResponse<PurchaseOrders> response = apiInstance.CreatePurchaseOrdersWithHttpInfo(xeroTenantId, purchaseOrders, summarizeErrors, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreatePurchaseOrdersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **purchaseOrders** | [**PurchaseOrders**](PurchaseOrders.md) | PurchaseOrders with an array of PurchaseOrder object in body of request |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**PurchaseOrders**](PurchaseOrders.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type PurchaseOrder array for specified PurchaseOrder |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createquoteattachmentbyfilename"></a>
# **CreateQuoteAttachmentByFileName**
> Attachments CreateQuoteAttachmentByFileName (string xeroTenantId, Guid quoteID, string fileName, byte[] body, string? idempotencyKey = null)

Creates attachment for a specific quote

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateQuoteAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var quoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Quote
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates attachment for a specific quote
                Attachments result = apiInstance.CreateQuoteAttachmentByFileName(xeroTenantId, quoteID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateQuoteAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateQuoteAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates attachment for a specific quote
    ApiResponse<Attachments> response = apiInstance.CreateQuoteAttachmentByFileNameWithHttpInfo(xeroTenantId, quoteID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateQuoteAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **quoteID** | **Guid** | Unique identifier for an Quote |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array of Attachment |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createquotehistory"></a>
# **CreateQuoteHistory**
> HistoryRecords CreateQuoteHistory (string xeroTenantId, Guid quoteID, HistoryRecords historyRecords, string? idempotencyKey = null)

Creates a history record for a specific quote

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateQuoteHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var quoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Quote
            var historyRecords = new HistoryRecords(); // HistoryRecords | HistoryRecords containing an array of HistoryRecord objects in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a history record for a specific quote
                HistoryRecords result = apiInstance.CreateQuoteHistory(xeroTenantId, quoteID, historyRecords, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateQuoteHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateQuoteHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a history record for a specific quote
    ApiResponse<HistoryRecords> response = apiInstance.CreateQuoteHistoryWithHttpInfo(xeroTenantId, quoteID, historyRecords, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateQuoteHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **quoteID** | **Guid** | Unique identifier for an Quote |  |
| **historyRecords** | [**HistoryRecords**](HistoryRecords.md) | HistoryRecords containing an array of HistoryRecord objects in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type HistoryRecords array of HistoryRecord objects |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createquotes"></a>
# **CreateQuotes**
> Quotes CreateQuotes (string xeroTenantId, Quotes quotes, bool? summarizeErrors = null, string? idempotencyKey = null)

Create one or more quotes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateQuotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var quotes = new Quotes(); // Quotes | Quotes with an array of Quote object in body of request
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Create one or more quotes
                Quotes result = apiInstance.CreateQuotes(xeroTenantId, quotes, summarizeErrors, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateQuotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateQuotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create one or more quotes
    ApiResponse<Quotes> response = apiInstance.CreateQuotesWithHttpInfo(xeroTenantId, quotes, summarizeErrors, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateQuotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **quotes** | [**Quotes**](Quotes.md) | Quotes with an array of Quote object in body of request |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Quotes**](Quotes.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Quotes with array with newly created Quote |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createreceipt"></a>
# **CreateReceipt**
> Receipts CreateReceipt (string xeroTenantId, Receipts receipts, int? unitdp = null, string? idempotencyKey = null)

Creates draft expense claim receipts for any user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateReceiptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var receipts = new Receipts(); // Receipts | Receipts with an array of Receipt object in body of request
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates draft expense claim receipts for any user
                Receipts result = apiInstance.CreateReceipt(xeroTenantId, receipts, unitdp, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateReceipt: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateReceiptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates draft expense claim receipts for any user
    ApiResponse<Receipts> response = apiInstance.CreateReceiptWithHttpInfo(xeroTenantId, receipts, unitdp, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateReceiptWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **receipts** | [**Receipts**](Receipts.md) | Receipts with an array of Receipt object in body of request |  |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Receipts**](Receipts.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Receipts array for newly created Receipt |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createreceiptattachmentbyfilename"></a>
# **CreateReceiptAttachmentByFileName**
> Attachments CreateReceiptAttachmentByFileName (string xeroTenantId, Guid receiptID, string fileName, byte[] body, string? idempotencyKey = null)

Creates an attachment on a specific expense claim receipts by file name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateReceiptAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var receiptID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Receipt
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates an attachment on a specific expense claim receipts by file name
                Attachments result = apiInstance.CreateReceiptAttachmentByFileName(xeroTenantId, receiptID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateReceiptAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateReceiptAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates an attachment on a specific expense claim receipts by file name
    ApiResponse<Attachments> response = apiInstance.CreateReceiptAttachmentByFileNameWithHttpInfo(xeroTenantId, receiptID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateReceiptAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **receiptID** | **Guid** | Unique identifier for a Receipt |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array with newly created Attachment for a specified Receipt |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createreceipthistory"></a>
# **CreateReceiptHistory**
> HistoryRecords CreateReceiptHistory (string xeroTenantId, Guid receiptID, HistoryRecords historyRecords, string? idempotencyKey = null)

Creates a history record for a specific receipt

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateReceiptHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var receiptID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Receipt
            var historyRecords = new HistoryRecords(); // HistoryRecords | HistoryRecords containing an array of HistoryRecord objects in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a history record for a specific receipt
                HistoryRecords result = apiInstance.CreateReceiptHistory(xeroTenantId, receiptID, historyRecords, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateReceiptHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateReceiptHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a history record for a specific receipt
    ApiResponse<HistoryRecords> response = apiInstance.CreateReceiptHistoryWithHttpInfo(xeroTenantId, receiptID, historyRecords, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateReceiptHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **receiptID** | **Guid** | Unique identifier for a Receipt |  |
| **historyRecords** | [**HistoryRecords**](HistoryRecords.md) | HistoryRecords containing an array of HistoryRecord objects in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type HistoryRecords array of HistoryRecord objects |  -  |
| **400** | Unsupported - return response incorrect exception, API is not able to create HistoryRecord for Receipts |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createrepeatinginvoiceattachmentbyfilename"></a>
# **CreateRepeatingInvoiceAttachmentByFileName**
> Attachments CreateRepeatingInvoiceAttachmentByFileName (string xeroTenantId, Guid repeatingInvoiceID, string fileName, byte[] body, string? idempotencyKey = null)

Creates an attachment from a specific repeating invoices by file name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateRepeatingInvoiceAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var repeatingInvoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Repeating Invoice
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates an attachment from a specific repeating invoices by file name
                Attachments result = apiInstance.CreateRepeatingInvoiceAttachmentByFileName(xeroTenantId, repeatingInvoiceID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateRepeatingInvoiceAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRepeatingInvoiceAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates an attachment from a specific repeating invoices by file name
    ApiResponse<Attachments> response = apiInstance.CreateRepeatingInvoiceAttachmentByFileNameWithHttpInfo(xeroTenantId, repeatingInvoiceID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateRepeatingInvoiceAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **repeatingInvoiceID** | **Guid** | Unique identifier for a Repeating Invoice |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array with updated Attachment for a specified Repeating Invoice |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createrepeatinginvoicehistory"></a>
# **CreateRepeatingInvoiceHistory**
> HistoryRecords CreateRepeatingInvoiceHistory (string xeroTenantId, Guid repeatingInvoiceID, HistoryRecords historyRecords, string? idempotencyKey = null)

Creates a  history record for a specific repeating invoice

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateRepeatingInvoiceHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var repeatingInvoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Repeating Invoice
            var historyRecords = new HistoryRecords(); // HistoryRecords | HistoryRecords containing an array of HistoryRecord objects in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a  history record for a specific repeating invoice
                HistoryRecords result = apiInstance.CreateRepeatingInvoiceHistory(xeroTenantId, repeatingInvoiceID, historyRecords, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateRepeatingInvoiceHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRepeatingInvoiceHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a  history record for a specific repeating invoice
    ApiResponse<HistoryRecords> response = apiInstance.CreateRepeatingInvoiceHistoryWithHttpInfo(xeroTenantId, repeatingInvoiceID, historyRecords, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateRepeatingInvoiceHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **repeatingInvoiceID** | **Guid** | Unique identifier for a Repeating Invoice |  |
| **historyRecords** | [**HistoryRecords**](HistoryRecords.md) | HistoryRecords containing an array of HistoryRecord objects in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type HistoryRecords array of HistoryRecord objects |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createrepeatinginvoices"></a>
# **CreateRepeatingInvoices**
> RepeatingInvoices CreateRepeatingInvoices (string xeroTenantId, RepeatingInvoices repeatingInvoices, bool? summarizeErrors = null, string? idempotencyKey = null)

Creates one or more repeating invoice templates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateRepeatingInvoicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var repeatingInvoices = new RepeatingInvoices(); // RepeatingInvoices | RepeatingInvoices with an array of repeating invoice objects in body of request
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates one or more repeating invoice templates
                RepeatingInvoices result = apiInstance.CreateRepeatingInvoices(xeroTenantId, repeatingInvoices, summarizeErrors, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateRepeatingInvoices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRepeatingInvoicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates one or more repeating invoice templates
    ApiResponse<RepeatingInvoices> response = apiInstance.CreateRepeatingInvoicesWithHttpInfo(xeroTenantId, repeatingInvoices, summarizeErrors, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateRepeatingInvoicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **repeatingInvoices** | [**RepeatingInvoices**](RepeatingInvoices.md) | RepeatingInvoices with an array of repeating invoice objects in body of request |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**RepeatingInvoices**](RepeatingInvoices.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type RepeatingInvoices array with newly created RepeatingInvoice |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtaxrates"></a>
# **CreateTaxRates**
> TaxRates CreateTaxRates (string xeroTenantId, TaxRates taxRates, string? idempotencyKey = null)

Creates one or more tax rates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateTaxRatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var taxRates = new TaxRates(); // TaxRates | TaxRates array with TaxRate object in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates one or more tax rates
                TaxRates result = apiInstance.CreateTaxRates(xeroTenantId, taxRates, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateTaxRates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTaxRatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates one or more tax rates
    ApiResponse<TaxRates> response = apiInstance.CreateTaxRatesWithHttpInfo(xeroTenantId, taxRates, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateTaxRatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **taxRates** | [**TaxRates**](TaxRates.md) | TaxRates array with TaxRate object in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**TaxRates**](TaxRates.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type TaxRates array newly created TaxRate |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtrackingcategory"></a>
# **CreateTrackingCategory**
> TrackingCategories CreateTrackingCategory (string xeroTenantId, TrackingCategory trackingCategory, string? idempotencyKey = null)

Create tracking categories

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateTrackingCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var trackingCategory = new TrackingCategory(); // TrackingCategory | TrackingCategory object in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Create tracking categories
                TrackingCategories result = apiInstance.CreateTrackingCategory(xeroTenantId, trackingCategory, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateTrackingCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTrackingCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create tracking categories
    ApiResponse<TrackingCategories> response = apiInstance.CreateTrackingCategoryWithHttpInfo(xeroTenantId, trackingCategory, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateTrackingCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **trackingCategory** | [**TrackingCategory**](TrackingCategory.md) | TrackingCategory object in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**TrackingCategories**](TrackingCategories.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type TrackingCategories array of newly created TrackingCategory |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtrackingoptions"></a>
# **CreateTrackingOptions**
> TrackingOptions CreateTrackingOptions (string xeroTenantId, Guid trackingCategoryID, TrackingOption trackingOption, string? idempotencyKey = null)

Creates options for a specific tracking category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateTrackingOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var trackingCategoryID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a TrackingCategory
            var trackingOption = new TrackingOption(); // TrackingOption | TrackingOption object in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates options for a specific tracking category
                TrackingOptions result = apiInstance.CreateTrackingOptions(xeroTenantId, trackingCategoryID, trackingOption, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.CreateTrackingOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTrackingOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates options for a specific tracking category
    ApiResponse<TrackingOptions> response = apiInstance.CreateTrackingOptionsWithHttpInfo(xeroTenantId, trackingCategoryID, trackingOption, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.CreateTrackingOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **trackingCategoryID** | **Guid** | Unique identifier for a TrackingCategory |  |
| **trackingOption** | [**TrackingOption**](TrackingOption.md) | TrackingOption object in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**TrackingOptions**](TrackingOptions.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type TrackingOptions array of options for a specified category |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteaccount"></a>
# **DeleteAccount**
> Accounts DeleteAccount (string xeroTenantId, Guid accountID)

Deletes a chart of accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var accountID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Account object

            try
            {
                // Deletes a chart of accounts
                Accounts result = apiInstance.DeleteAccount(xeroTenantId, accountID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.DeleteAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a chart of accounts
    ApiResponse<Accounts> response = apiInstance.DeleteAccountWithHttpInfo(xeroTenantId, accountID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.DeleteAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **accountID** | **Guid** | Unique identifier for Account object |  |

### Return type

[**Accounts**](Accounts.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - delete existing Account and return response of type Accounts array with deleted Account |  -  |
| **400** | Validation Error - some data was incorrect returns response of type Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletebatchpayment"></a>
# **DeleteBatchPayment**
> BatchPayments DeleteBatchPayment (string xeroTenantId, BatchPaymentDelete batchPaymentDelete, string? idempotencyKey = null)

Updates a specific batch payment for invoices and credit notes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteBatchPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var batchPaymentDelete = new BatchPaymentDelete(); // BatchPaymentDelete | 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific batch payment for invoices and credit notes
                BatchPayments result = apiInstance.DeleteBatchPayment(xeroTenantId, batchPaymentDelete, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.DeleteBatchPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteBatchPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific batch payment for invoices and credit notes
    ApiResponse<BatchPayments> response = apiInstance.DeleteBatchPaymentWithHttpInfo(xeroTenantId, batchPaymentDelete, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.DeleteBatchPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **batchPaymentDelete** | [**BatchPaymentDelete**](BatchPaymentDelete.md) |  |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**BatchPayments**](BatchPayments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type BatchPayments array for updated BatchPayment |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletebatchpaymentbyurlparam"></a>
# **DeleteBatchPaymentByUrlParam**
> BatchPayments DeleteBatchPaymentByUrlParam (string xeroTenantId, Guid batchPaymentID, BatchPaymentDeleteByUrlParam batchPaymentDeleteByUrlParam, string? idempotencyKey = null)

Updates a specific batch payment for invoices and credit notes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteBatchPaymentByUrlParamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var batchPaymentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for BatchPayment
            var batchPaymentDeleteByUrlParam = new BatchPaymentDeleteByUrlParam(); // BatchPaymentDeleteByUrlParam | 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific batch payment for invoices and credit notes
                BatchPayments result = apiInstance.DeleteBatchPaymentByUrlParam(xeroTenantId, batchPaymentID, batchPaymentDeleteByUrlParam, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.DeleteBatchPaymentByUrlParam: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteBatchPaymentByUrlParamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific batch payment for invoices and credit notes
    ApiResponse<BatchPayments> response = apiInstance.DeleteBatchPaymentByUrlParamWithHttpInfo(xeroTenantId, batchPaymentID, batchPaymentDeleteByUrlParam, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.DeleteBatchPaymentByUrlParamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **batchPaymentID** | **Guid** | Unique identifier for BatchPayment |  |
| **batchPaymentDeleteByUrlParam** | [**BatchPaymentDeleteByUrlParam**](BatchPaymentDeleteByUrlParam.md) |  |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**BatchPayments**](BatchPayments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type BatchPayments array for updated BatchPayment |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecontactgroupcontact"></a>
# **DeleteContactGroupContact**
> void DeleteContactGroupContact (string xeroTenantId, Guid contactGroupID, Guid contactID)

Deletes a specific contact from a contact group using a unique contact Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteContactGroupContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactGroupID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Contact Group
            var contactID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Contact

            try
            {
                // Deletes a specific contact from a contact group using a unique contact Id
                apiInstance.DeleteContactGroupContact(xeroTenantId, contactGroupID, contactID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.DeleteContactGroupContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteContactGroupContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a specific contact from a contact group using a unique contact Id
    apiInstance.DeleteContactGroupContactWithHttpInfo(xeroTenantId, contactGroupID, contactID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.DeleteContactGroupContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactGroupID** | **Guid** | Unique identifier for a Contact Group |  |
| **contactID** | **Guid** | Unique identifier for a Contact |  |

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success - return response 204 no content |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecontactgroupcontacts"></a>
# **DeleteContactGroupContacts**
> void DeleteContactGroupContacts (string xeroTenantId, Guid contactGroupID)

Deletes all contacts from a specific contact group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteContactGroupContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactGroupID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Contact Group

            try
            {
                // Deletes all contacts from a specific contact group
                apiInstance.DeleteContactGroupContacts(xeroTenantId, contactGroupID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.DeleteContactGroupContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteContactGroupContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes all contacts from a specific contact group
    apiInstance.DeleteContactGroupContactsWithHttpInfo(xeroTenantId, contactGroupID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.DeleteContactGroupContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactGroupID** | **Guid** | Unique identifier for a Contact Group |  |

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success - return response 204 no content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecreditnoteallocations"></a>
# **DeleteCreditNoteAllocations**
> Allocation DeleteCreditNoteAllocations (string xeroTenantId, Guid creditNoteID, Guid allocationID)

Deletes an Allocation from a Credit Note

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteCreditNoteAllocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var creditNoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Credit Note
            var allocationID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Allocation object

            try
            {
                // Deletes an Allocation from a Credit Note
                Allocation result = apiInstance.DeleteCreditNoteAllocations(xeroTenantId, creditNoteID, allocationID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.DeleteCreditNoteAllocations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCreditNoteAllocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an Allocation from a Credit Note
    ApiResponse<Allocation> response = apiInstance.DeleteCreditNoteAllocationsWithHttpInfo(xeroTenantId, creditNoteID, allocationID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.DeleteCreditNoteAllocationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **creditNoteID** | **Guid** | Unique identifier for a Credit Note |  |
| **allocationID** | **Guid** | Unique identifier for Allocation object |  |

### Return type

[**Allocation**](Allocation.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Allocation with the isDeleted flag as true |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteitem"></a>
# **DeleteItem**
> void DeleteItem (string xeroTenantId, Guid itemID)

Deletes a specific item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var itemID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Item

            try
            {
                // Deletes a specific item
                apiInstance.DeleteItem(xeroTenantId, itemID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.DeleteItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a specific item
    apiInstance.DeleteItemWithHttpInfo(xeroTenantId, itemID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.DeleteItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **itemID** | **Guid** | Unique identifier for an Item |  |

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success - return response 204 no content |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletelinkedtransaction"></a>
# **DeleteLinkedTransaction**
> void DeleteLinkedTransaction (string xeroTenantId, Guid linkedTransactionID)

Deletes a specific linked transactions (billable expenses)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteLinkedTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var linkedTransactionID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a LinkedTransaction

            try
            {
                // Deletes a specific linked transactions (billable expenses)
                apiInstance.DeleteLinkedTransaction(xeroTenantId, linkedTransactionID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.DeleteLinkedTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteLinkedTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a specific linked transactions (billable expenses)
    apiInstance.DeleteLinkedTransactionWithHttpInfo(xeroTenantId, linkedTransactionID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.DeleteLinkedTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **linkedTransactionID** | **Guid** | Unique identifier for a LinkedTransaction |  |

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success - return response 204 no content |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteoverpaymentallocations"></a>
# **DeleteOverpaymentAllocations**
> Allocation DeleteOverpaymentAllocations (string xeroTenantId, Guid overpaymentID, Guid allocationID)

Deletes an Allocation from an overpayment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteOverpaymentAllocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var overpaymentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Overpayment
            var allocationID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Allocation object

            try
            {
                // Deletes an Allocation from an overpayment
                Allocation result = apiInstance.DeleteOverpaymentAllocations(xeroTenantId, overpaymentID, allocationID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.DeleteOverpaymentAllocations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteOverpaymentAllocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an Allocation from an overpayment
    ApiResponse<Allocation> response = apiInstance.DeleteOverpaymentAllocationsWithHttpInfo(xeroTenantId, overpaymentID, allocationID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.DeleteOverpaymentAllocationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **overpaymentID** | **Guid** | Unique identifier for a Overpayment |  |
| **allocationID** | **Guid** | Unique identifier for Allocation object |  |

### Return type

[**Allocation**](Allocation.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Allocation with the isDeleted flag as true |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletepayment"></a>
# **DeletePayment**
> Payments DeletePayment (string xeroTenantId, Guid paymentID, PaymentDelete paymentDelete, string? idempotencyKey = null)

Updates a specific payment for invoices and credit notes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeletePaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var paymentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Payment
            var paymentDelete = new PaymentDelete(); // PaymentDelete | 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific payment for invoices and credit notes
                Payments result = apiInstance.DeletePayment(xeroTenantId, paymentID, paymentDelete, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.DeletePayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific payment for invoices and credit notes
    ApiResponse<Payments> response = apiInstance.DeletePaymentWithHttpInfo(xeroTenantId, paymentID, paymentDelete, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.DeletePaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **paymentID** | **Guid** | Unique identifier for a Payment |  |
| **paymentDelete** | [**PaymentDelete**](PaymentDelete.md) |  |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Payments**](Payments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Payments array for updated Payment |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteprepaymentallocations"></a>
# **DeletePrepaymentAllocations**
> Allocation DeletePrepaymentAllocations (string xeroTenantId, Guid prepaymentID, Guid allocationID)

Deletes an Allocation from a Prepayment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeletePrepaymentAllocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var prepaymentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a PrePayment
            var allocationID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Allocation object

            try
            {
                // Deletes an Allocation from a Prepayment
                Allocation result = apiInstance.DeletePrepaymentAllocations(xeroTenantId, prepaymentID, allocationID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.DeletePrepaymentAllocations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePrepaymentAllocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an Allocation from a Prepayment
    ApiResponse<Allocation> response = apiInstance.DeletePrepaymentAllocationsWithHttpInfo(xeroTenantId, prepaymentID, allocationID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.DeletePrepaymentAllocationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **prepaymentID** | **Guid** | Unique identifier for a PrePayment |  |
| **allocationID** | **Guid** | Unique identifier for Allocation object |  |

### Return type

[**Allocation**](Allocation.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Allocation with the isDeleted flag as true |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetrackingcategory"></a>
# **DeleteTrackingCategory**
> TrackingCategories DeleteTrackingCategory (string xeroTenantId, Guid trackingCategoryID)

Deletes a specific tracking category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteTrackingCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var trackingCategoryID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a TrackingCategory

            try
            {
                // Deletes a specific tracking category
                TrackingCategories result = apiInstance.DeleteTrackingCategory(xeroTenantId, trackingCategoryID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.DeleteTrackingCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTrackingCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a specific tracking category
    ApiResponse<TrackingCategories> response = apiInstance.DeleteTrackingCategoryWithHttpInfo(xeroTenantId, trackingCategoryID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.DeleteTrackingCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **trackingCategoryID** | **Guid** | Unique identifier for a TrackingCategory |  |

### Return type

[**TrackingCategories**](TrackingCategories.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type TrackingCategories array of deleted TrackingCategory |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetrackingoptions"></a>
# **DeleteTrackingOptions**
> TrackingOptions DeleteTrackingOptions (string xeroTenantId, Guid trackingCategoryID, Guid trackingOptionID)

Deletes a specific option for a specific tracking category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteTrackingOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var trackingCategoryID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a TrackingCategory
            var trackingOptionID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Tracking Option

            try
            {
                // Deletes a specific option for a specific tracking category
                TrackingOptions result = apiInstance.DeleteTrackingOptions(xeroTenantId, trackingCategoryID, trackingOptionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.DeleteTrackingOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTrackingOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a specific option for a specific tracking category
    ApiResponse<TrackingOptions> response = apiInstance.DeleteTrackingOptionsWithHttpInfo(xeroTenantId, trackingCategoryID, trackingOptionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.DeleteTrackingOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **trackingCategoryID** | **Guid** | Unique identifier for a TrackingCategory |  |
| **trackingOptionID** | **Guid** | Unique identifier for a Tracking Option |  |

### Return type

[**TrackingOptions**](TrackingOptions.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type TrackingOptions array of remaining options for a specified category |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="emailinvoice"></a>
# **EmailInvoice**
> void EmailInvoice (string xeroTenantId, Guid invoiceID, RequestEmpty requestEmpty, string? idempotencyKey = null)

Sends a copy of a specific invoice to related contact via email

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EmailInvoiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var invoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Invoice
            var requestEmpty = new RequestEmpty(); // RequestEmpty | 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Sends a copy of a specific invoice to related contact via email
                apiInstance.EmailInvoice(xeroTenantId, invoiceID, requestEmpty, idempotencyKey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.EmailInvoice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmailInvoiceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sends a copy of a specific invoice to related contact via email
    apiInstance.EmailInvoiceWithHttpInfo(xeroTenantId, invoiceID, requestEmpty, idempotencyKey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.EmailInvoiceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **invoiceID** | **Guid** | Unique identifier for an Invoice |  |
| **requestEmpty** | [**RequestEmpty**](RequestEmpty.md) |  |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success - return response 204 no content |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaccount"></a>
# **GetAccount**
> Accounts GetAccount (string xeroTenantId, Guid accountID)

Retrieves a single chart of accounts by using a unique account Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var accountID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Account object

            try
            {
                // Retrieves a single chart of accounts by using a unique account Id
                Accounts result = apiInstance.GetAccount(xeroTenantId, accountID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a single chart of accounts by using a unique account Id
    ApiResponse<Accounts> response = apiInstance.GetAccountWithHttpInfo(xeroTenantId, accountID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **accountID** | **Guid** | Unique identifier for Account object |  |

### Return type

[**Accounts**](Accounts.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Accounts array with one Account |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaccountattachmentbyfilename"></a>
# **GetAccountAttachmentByFileName**
> System.IO.Stream GetAccountAttachmentByFileName (string xeroTenantId, Guid accountID, string fileName, string contentType)

Retrieves an attachment for a specific account by filename

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAccountAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var accountID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Account object
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves an attachment for a specific account by filename
                System.IO.Stream result = apiInstance.GetAccountAttachmentByFileName(xeroTenantId, accountID, fileName, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetAccountAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves an attachment for a specific account by filename
    ApiResponse<System.IO.Stream> response = apiInstance.GetAccountAttachmentByFileNameWithHttpInfo(xeroTenantId, accountID, fileName, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetAccountAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **accountID** | **Guid** | Unique identifier for Account object |  |
| **fileName** | **string** | Name of the attachment |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for Account as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaccountattachmentbyid"></a>
# **GetAccountAttachmentById**
> System.IO.Stream GetAccountAttachmentById (string xeroTenantId, Guid accountID, Guid attachmentID, string contentType)

Retrieves a specific attachment from a specific account using a unique attachment Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAccountAttachmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var accountID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Account object
            var attachmentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Attachment object
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves a specific attachment from a specific account using a unique attachment Id
                System.IO.Stream result = apiInstance.GetAccountAttachmentById(xeroTenantId, accountID, attachmentID, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetAccountAttachmentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountAttachmentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific attachment from a specific account using a unique attachment Id
    ApiResponse<System.IO.Stream> response = apiInstance.GetAccountAttachmentByIdWithHttpInfo(xeroTenantId, accountID, attachmentID, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetAccountAttachmentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **accountID** | **Guid** | Unique identifier for Account object |  |
| **attachmentID** | **Guid** | Unique identifier for Attachment object |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for Account as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaccountattachments"></a>
# **GetAccountAttachments**
> Attachments GetAccountAttachments (string xeroTenantId, Guid accountID)

Retrieves attachments for a specific accounts by using a unique account Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAccountAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var accountID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Account object

            try
            {
                // Retrieves attachments for a specific accounts by using a unique account Id
                Attachments result = apiInstance.GetAccountAttachments(xeroTenantId, accountID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetAccountAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves attachments for a specific accounts by using a unique account Id
    ApiResponse<Attachments> response = apiInstance.GetAccountAttachmentsWithHttpInfo(xeroTenantId, accountID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetAccountAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **accountID** | **Guid** | Unique identifier for Account object |  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array of Attachment |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaccounts"></a>
# **GetAccounts**
> Accounts GetAccounts (string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null)

Retrieves the full chart of accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var where = Status==&quot;ACTIVE&quot; AND Type==&quot;BANK&quot;;  // string? | Filter by an any element (optional) 
            var order = Name ASC;  // string? | Order by an any element (optional) 

            try
            {
                // Retrieves the full chart of accounts
                Accounts result = apiInstance.GetAccounts(xeroTenantId, ifModifiedSince, where, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the full chart of accounts
    ApiResponse<Accounts> response = apiInstance.GetAccountsWithHttpInfo(xeroTenantId, ifModifiedSince, where, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |

### Return type

[**Accounts**](Accounts.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Accounts array with 0 to n Account |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbanktransaction"></a>
# **GetBankTransaction**
> BankTransactions GetBankTransaction (string xeroTenantId, Guid bankTransactionID, int? unitdp = null)

Retrieves a single spent or received money transaction by using a unique bank transaction Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBankTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransactionID = 00000000-0000-0000-0000-000000000000;  // Guid | Xero generated unique identifier for a bank transaction
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 

            try
            {
                // Retrieves a single spent or received money transaction by using a unique bank transaction Id
                BankTransactions result = apiInstance.GetBankTransaction(xeroTenantId, bankTransactionID, unitdp);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBankTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBankTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a single spent or received money transaction by using a unique bank transaction Id
    ApiResponse<BankTransactions> response = apiInstance.GetBankTransactionWithHttpInfo(xeroTenantId, bankTransactionID, unitdp);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBankTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransactionID** | **Guid** | Xero generated unique identifier for a bank transaction |  |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |

### Return type

[**BankTransactions**](BankTransactions.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type BankTransactions array with a specific BankTransaction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbanktransactionattachmentbyfilename"></a>
# **GetBankTransactionAttachmentByFileName**
> System.IO.Stream GetBankTransactionAttachmentByFileName (string xeroTenantId, Guid bankTransactionID, string fileName, string contentType)

Retrieves a specific attachment from a specific bank transaction by filename

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBankTransactionAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransactionID = 00000000-0000-0000-0000-000000000000;  // Guid | Xero generated unique identifier for a bank transaction
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves a specific attachment from a specific bank transaction by filename
                System.IO.Stream result = apiInstance.GetBankTransactionAttachmentByFileName(xeroTenantId, bankTransactionID, fileName, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBankTransactionAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBankTransactionAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific attachment from a specific bank transaction by filename
    ApiResponse<System.IO.Stream> response = apiInstance.GetBankTransactionAttachmentByFileNameWithHttpInfo(xeroTenantId, bankTransactionID, fileName, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBankTransactionAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransactionID** | **Guid** | Xero generated unique identifier for a bank transaction |  |
| **fileName** | **string** | Name of the attachment |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for BankTransaction as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbanktransactionattachmentbyid"></a>
# **GetBankTransactionAttachmentById**
> System.IO.Stream GetBankTransactionAttachmentById (string xeroTenantId, Guid bankTransactionID, Guid attachmentID, string contentType)

Retrieves specific attachments from a specific BankTransaction using a unique attachment Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBankTransactionAttachmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransactionID = 00000000-0000-0000-0000-000000000000;  // Guid | Xero generated unique identifier for a bank transaction
            var attachmentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Attachment object
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves specific attachments from a specific BankTransaction using a unique attachment Id
                System.IO.Stream result = apiInstance.GetBankTransactionAttachmentById(xeroTenantId, bankTransactionID, attachmentID, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBankTransactionAttachmentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBankTransactionAttachmentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific attachments from a specific BankTransaction using a unique attachment Id
    ApiResponse<System.IO.Stream> response = apiInstance.GetBankTransactionAttachmentByIdWithHttpInfo(xeroTenantId, bankTransactionID, attachmentID, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBankTransactionAttachmentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransactionID** | **Guid** | Xero generated unique identifier for a bank transaction |  |
| **attachmentID** | **Guid** | Unique identifier for Attachment object |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for BankTransaction as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbanktransactionattachments"></a>
# **GetBankTransactionAttachments**
> Attachments GetBankTransactionAttachments (string xeroTenantId, Guid bankTransactionID)

Retrieves any attachments from a specific bank transactions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBankTransactionAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransactionID = 00000000-0000-0000-0000-000000000000;  // Guid | Xero generated unique identifier for a bank transaction

            try
            {
                // Retrieves any attachments from a specific bank transactions
                Attachments result = apiInstance.GetBankTransactionAttachments(xeroTenantId, bankTransactionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBankTransactionAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBankTransactionAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves any attachments from a specific bank transactions
    ApiResponse<Attachments> response = apiInstance.GetBankTransactionAttachmentsWithHttpInfo(xeroTenantId, bankTransactionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBankTransactionAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransactionID** | **Guid** | Xero generated unique identifier for a bank transaction |  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array with 0 to n Attachment |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbanktransactions"></a>
# **GetBankTransactions**
> BankTransactions GetBankTransactions (string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? unitdp = null, int? pageSize = null)

Retrieves any spent or received money transactions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBankTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var where = Status=="AUTHORISED";  // string? | Filter by an any element (optional) 
            var order = Type ASC;  // string? | Order by an any element (optional) 
            var page = 1;  // int? | Up to 100 bank transactions will be returned in a single API call with line items details (optional) 
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var pageSize = 100;  // int? | Number of records to retrieve per page (optional) 

            try
            {
                // Retrieves any spent or received money transactions
                BankTransactions result = apiInstance.GetBankTransactions(xeroTenantId, ifModifiedSince, where, order, page, unitdp, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBankTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBankTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves any spent or received money transactions
    ApiResponse<BankTransactions> response = apiInstance.GetBankTransactionsWithHttpInfo(xeroTenantId, ifModifiedSince, where, order, page, unitdp, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBankTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |
| **page** | **int?** | Up to 100 bank transactions will be returned in a single API call with line items details | [optional]  |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **pageSize** | **int?** | Number of records to retrieve per page | [optional]  |

### Return type

[**BankTransactions**](BankTransactions.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type BankTransactions array with 0 to n BankTransaction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbanktransactionshistory"></a>
# **GetBankTransactionsHistory**
> HistoryRecords GetBankTransactionsHistory (string xeroTenantId, Guid bankTransactionID)

Retrieves history from a specific bank transaction using a unique bank transaction Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBankTransactionsHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransactionID = 00000000-0000-0000-0000-000000000000;  // Guid | Xero generated unique identifier for a bank transaction

            try
            {
                // Retrieves history from a specific bank transaction using a unique bank transaction Id
                HistoryRecords result = apiInstance.GetBankTransactionsHistory(xeroTenantId, bankTransactionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBankTransactionsHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBankTransactionsHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves history from a specific bank transaction using a unique bank transaction Id
    ApiResponse<HistoryRecords> response = apiInstance.GetBankTransactionsHistoryWithHttpInfo(xeroTenantId, bankTransactionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBankTransactionsHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransactionID** | **Guid** | Xero generated unique identifier for a bank transaction |  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of HistoryRecords array of 0 to N HistoryRecord |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbanktransfer"></a>
# **GetBankTransfer**
> BankTransfers GetBankTransfer (string xeroTenantId, Guid bankTransferID)

Retrieves specific bank transfers by using a unique bank transfer Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBankTransferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransferID = 00000000-0000-0000-0000-000000000000;  // Guid | Xero generated unique identifier for a bank transfer

            try
            {
                // Retrieves specific bank transfers by using a unique bank transfer Id
                BankTransfers result = apiInstance.GetBankTransfer(xeroTenantId, bankTransferID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBankTransfer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBankTransferWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific bank transfers by using a unique bank transfer Id
    ApiResponse<BankTransfers> response = apiInstance.GetBankTransferWithHttpInfo(xeroTenantId, bankTransferID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBankTransferWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransferID** | **Guid** | Xero generated unique identifier for a bank transfer |  |

### Return type

[**BankTransfers**](BankTransfers.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of BankTransfers array with one BankTransfer |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbanktransferattachmentbyfilename"></a>
# **GetBankTransferAttachmentByFileName**
> System.IO.Stream GetBankTransferAttachmentByFileName (string xeroTenantId, Guid bankTransferID, string fileName, string contentType)

Retrieves a specific attachment on a specific bank transfer by file name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBankTransferAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransferID = 00000000-0000-0000-0000-000000000000;  // Guid | Xero generated unique identifier for a bank transfer
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves a specific attachment on a specific bank transfer by file name
                System.IO.Stream result = apiInstance.GetBankTransferAttachmentByFileName(xeroTenantId, bankTransferID, fileName, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBankTransferAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBankTransferAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific attachment on a specific bank transfer by file name
    ApiResponse<System.IO.Stream> response = apiInstance.GetBankTransferAttachmentByFileNameWithHttpInfo(xeroTenantId, bankTransferID, fileName, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBankTransferAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransferID** | **Guid** | Xero generated unique identifier for a bank transfer |  |
| **fileName** | **string** | Name of the attachment |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of binary data from the Attachment to a Bank Transfer |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbanktransferattachmentbyid"></a>
# **GetBankTransferAttachmentById**
> System.IO.Stream GetBankTransferAttachmentById (string xeroTenantId, Guid bankTransferID, Guid attachmentID, string contentType)

Retrieves a specific attachment from a specific bank transfer using a unique attachment ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBankTransferAttachmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransferID = 00000000-0000-0000-0000-000000000000;  // Guid | Xero generated unique identifier for a bank transfer
            var attachmentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Attachment object
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves a specific attachment from a specific bank transfer using a unique attachment ID
                System.IO.Stream result = apiInstance.GetBankTransferAttachmentById(xeroTenantId, bankTransferID, attachmentID, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBankTransferAttachmentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBankTransferAttachmentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific attachment from a specific bank transfer using a unique attachment ID
    ApiResponse<System.IO.Stream> response = apiInstance.GetBankTransferAttachmentByIdWithHttpInfo(xeroTenantId, bankTransferID, attachmentID, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBankTransferAttachmentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransferID** | **Guid** | Xero generated unique identifier for a bank transfer |  |
| **attachmentID** | **Guid** | Unique identifier for Attachment object |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of binary data from the Attachment to a Bank Transfer |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbanktransferattachments"></a>
# **GetBankTransferAttachments**
> Attachments GetBankTransferAttachments (string xeroTenantId, Guid bankTransferID)

Retrieves attachments from a specific bank transfer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBankTransferAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransferID = 00000000-0000-0000-0000-000000000000;  // Guid | Xero generated unique identifier for a bank transfer

            try
            {
                // Retrieves attachments from a specific bank transfer
                Attachments result = apiInstance.GetBankTransferAttachments(xeroTenantId, bankTransferID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBankTransferAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBankTransferAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves attachments from a specific bank transfer
    ApiResponse<Attachments> response = apiInstance.GetBankTransferAttachmentsWithHttpInfo(xeroTenantId, bankTransferID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBankTransferAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransferID** | **Guid** | Xero generated unique identifier for a bank transfer |  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of Attachments array of 0 to N Attachment for a Bank Transfer |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbanktransferhistory"></a>
# **GetBankTransferHistory**
> HistoryRecords GetBankTransferHistory (string xeroTenantId, Guid bankTransferID)

Retrieves history from a specific bank transfer using a unique bank transfer Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBankTransferHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransferID = 00000000-0000-0000-0000-000000000000;  // Guid | Xero generated unique identifier for a bank transfer

            try
            {
                // Retrieves history from a specific bank transfer using a unique bank transfer Id
                HistoryRecords result = apiInstance.GetBankTransferHistory(xeroTenantId, bankTransferID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBankTransferHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBankTransferHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves history from a specific bank transfer using a unique bank transfer Id
    ApiResponse<HistoryRecords> response = apiInstance.GetBankTransferHistoryWithHttpInfo(xeroTenantId, bankTransferID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBankTransferHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransferID** | **Guid** | Xero generated unique identifier for a bank transfer |  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of HistoryRecords array of 0 to N HistoryRecord |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbanktransfers"></a>
# **GetBankTransfers**
> BankTransfers GetBankTransfers (string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null)

Retrieves all bank transfers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBankTransfersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var where = HasAttachments==true;  // string? | Filter by an any element (optional) 
            var order = Amount ASC;  // string? | Order by an any element (optional) 

            try
            {
                // Retrieves all bank transfers
                BankTransfers result = apiInstance.GetBankTransfers(xeroTenantId, ifModifiedSince, where, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBankTransfers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBankTransfersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all bank transfers
    ApiResponse<BankTransfers> response = apiInstance.GetBankTransfersWithHttpInfo(xeroTenantId, ifModifiedSince, where, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBankTransfersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |

### Return type

[**BankTransfers**](BankTransfers.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of BankTransfers array of 0 to N BankTransfer |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbatchpayment"></a>
# **GetBatchPayment**
> BatchPayments GetBatchPayment (string xeroTenantId, Guid batchPaymentID)

Retrieves a specific batch payment using a unique batch payment Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBatchPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var batchPaymentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for BatchPayment

            try
            {
                // Retrieves a specific batch payment using a unique batch payment Id
                BatchPayments result = apiInstance.GetBatchPayment(xeroTenantId, batchPaymentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBatchPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBatchPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific batch payment using a unique batch payment Id
    ApiResponse<BatchPayments> response = apiInstance.GetBatchPaymentWithHttpInfo(xeroTenantId, batchPaymentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBatchPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **batchPaymentID** | **Guid** | Unique identifier for BatchPayment |  |

### Return type

[**BatchPayments**](BatchPayments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type BatchPayments array with matching batch payment Id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbatchpaymenthistory"></a>
# **GetBatchPaymentHistory**
> HistoryRecords GetBatchPaymentHistory (string xeroTenantId, Guid batchPaymentID)

Retrieves history from a specific batch payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBatchPaymentHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var batchPaymentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for BatchPayment

            try
            {
                // Retrieves history from a specific batch payment
                HistoryRecords result = apiInstance.GetBatchPaymentHistory(xeroTenantId, batchPaymentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBatchPaymentHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBatchPaymentHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves history from a specific batch payment
    ApiResponse<HistoryRecords> response = apiInstance.GetBatchPaymentHistoryWithHttpInfo(xeroTenantId, batchPaymentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBatchPaymentHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **batchPaymentID** | **Guid** | Unique identifier for BatchPayment |  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of HistoryRecords array of 0 to N HistoryRecord |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbatchpayments"></a>
# **GetBatchPayments**
> BatchPayments GetBatchPayments (string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null)

Retrieves either one or many batch payments for invoices

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBatchPaymentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var where = Status=="AUTHORISED";  // string? | Filter by an any element (optional) 
            var order = Date ASC;  // string? | Order by an any element (optional) 

            try
            {
                // Retrieves either one or many batch payments for invoices
                BatchPayments result = apiInstance.GetBatchPayments(xeroTenantId, ifModifiedSince, where, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBatchPayments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBatchPaymentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves either one or many batch payments for invoices
    ApiResponse<BatchPayments> response = apiInstance.GetBatchPaymentsWithHttpInfo(xeroTenantId, ifModifiedSince, where, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBatchPaymentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |

### Return type

[**BatchPayments**](BatchPayments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type BatchPayments array of BatchPayment objects |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbrandingtheme"></a>
# **GetBrandingTheme**
> BrandingThemes GetBrandingTheme (string xeroTenantId, Guid brandingThemeID)

Retrieves a specific branding theme using a unique branding theme Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBrandingThemeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var brandingThemeID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Branding Theme

            try
            {
                // Retrieves a specific branding theme using a unique branding theme Id
                BrandingThemes result = apiInstance.GetBrandingTheme(xeroTenantId, brandingThemeID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBrandingTheme: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBrandingThemeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific branding theme using a unique branding theme Id
    ApiResponse<BrandingThemes> response = apiInstance.GetBrandingThemeWithHttpInfo(xeroTenantId, brandingThemeID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBrandingThemeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **brandingThemeID** | **Guid** | Unique identifier for a Branding Theme |  |

### Return type

[**BrandingThemes**](BrandingThemes.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type BrandingThemes with one BrandingTheme |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbrandingthemepaymentservices"></a>
# **GetBrandingThemePaymentServices**
> PaymentServices GetBrandingThemePaymentServices (string xeroTenantId, Guid brandingThemeID)

Retrieves the payment services for a specific branding theme

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBrandingThemePaymentServicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var brandingThemeID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Branding Theme

            try
            {
                // Retrieves the payment services for a specific branding theme
                PaymentServices result = apiInstance.GetBrandingThemePaymentServices(xeroTenantId, brandingThemeID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBrandingThemePaymentServices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBrandingThemePaymentServicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the payment services for a specific branding theme
    ApiResponse<PaymentServices> response = apiInstance.GetBrandingThemePaymentServicesWithHttpInfo(xeroTenantId, brandingThemeID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBrandingThemePaymentServicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **brandingThemeID** | **Guid** | Unique identifier for a Branding Theme |  |

### Return type

[**PaymentServices**](PaymentServices.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type PaymentServices array with 0 to N PaymentService |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbrandingthemes"></a>
# **GetBrandingThemes**
> BrandingThemes GetBrandingThemes (string xeroTenantId)

Retrieves all the branding themes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBrandingThemesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant

            try
            {
                // Retrieves all the branding themes
                BrandingThemes result = apiInstance.GetBrandingThemes(xeroTenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBrandingThemes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBrandingThemesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all the branding themes
    ApiResponse<BrandingThemes> response = apiInstance.GetBrandingThemesWithHttpInfo(xeroTenantId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBrandingThemesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |

### Return type

[**BrandingThemes**](BrandingThemes.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type BrandingThemes |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbudget"></a>
# **GetBudget**
> Budgets GetBudget (string xeroTenantId, Guid budgetID, DateOnly? dateTo = null, DateOnly? dateFrom = null)

Retrieves a specific budget, which includes budget lines

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBudgetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var budgetID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Budgets
            var dateTo = 2019-10-31;  // DateOnly? | Filter by start date (optional) 
            var dateFrom = 2019-10-31;  // DateOnly? | Filter by end date (optional) 

            try
            {
                // Retrieves a specific budget, which includes budget lines
                Budgets result = apiInstance.GetBudget(xeroTenantId, budgetID, dateTo, dateFrom);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBudget: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBudgetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific budget, which includes budget lines
    ApiResponse<Budgets> response = apiInstance.GetBudgetWithHttpInfo(xeroTenantId, budgetID, dateTo, dateFrom);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBudgetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **budgetID** | **Guid** | Unique identifier for Budgets |  |
| **dateTo** | **DateOnly?** | Filter by start date | [optional]  |
| **dateFrom** | **DateOnly?** | Filter by end date | [optional]  |

### Return type

[**Budgets**](Budgets.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Invoices array with specified Invoices |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbudgets"></a>
# **GetBudgets**
> Budgets GetBudgets (string xeroTenantId, List<Guid>? iDs = null, DateOnly? dateTo = null, DateOnly? dateFrom = null)

Retrieve a list of budgets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBudgetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var iDs = new List<Guid>?(); // List<Guid>? | Filter by BudgetID. Allows you to retrieve a specific individual budget. (optional) 
            var dateTo = 2019-10-31;  // DateOnly? | Filter by start date (optional) 
            var dateFrom = 2019-10-31;  // DateOnly? | Filter by end date (optional) 

            try
            {
                // Retrieve a list of budgets
                Budgets result = apiInstance.GetBudgets(xeroTenantId, iDs, dateTo, dateFrom);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetBudgets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBudgetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a list of budgets
    ApiResponse<Budgets> response = apiInstance.GetBudgetsWithHttpInfo(xeroTenantId, iDs, dateTo, dateFrom);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetBudgetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **iDs** | [**List&lt;Guid&gt;?**](Guid.md) | Filter by BudgetID. Allows you to retrieve a specific individual budget. | [optional]  |
| **dateTo** | **DateOnly?** | Filter by start date | [optional]  |
| **dateFrom** | **DateOnly?** | Filter by end date | [optional]  |

### Return type

[**Budgets**](Budgets.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Budgets array with 0 to N Budgets |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontact"></a>
# **GetContact**
> Contacts GetContact (string xeroTenantId, Guid contactID)

Retrieves a specific contacts in a Xero organisation using a unique contact Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Contact

            try
            {
                // Retrieves a specific contacts in a Xero organisation using a unique contact Id
                Contacts result = apiInstance.GetContact(xeroTenantId, contactID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific contacts in a Xero organisation using a unique contact Id
    ApiResponse<Contacts> response = apiInstance.GetContactWithHttpInfo(xeroTenantId, contactID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactID** | **Guid** | Unique identifier for a Contact |  |

### Return type

[**Contacts**](Contacts.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Contacts array with a unique Contact |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontactattachmentbyfilename"></a>
# **GetContactAttachmentByFileName**
> System.IO.Stream GetContactAttachmentByFileName (string xeroTenantId, Guid contactID, string fileName, string contentType)

Retrieves a specific attachment from a specific contact by file name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetContactAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Contact
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves a specific attachment from a specific contact by file name
                System.IO.Stream result = apiInstance.GetContactAttachmentByFileName(xeroTenantId, contactID, fileName, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetContactAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific attachment from a specific contact by file name
    ApiResponse<System.IO.Stream> response = apiInstance.GetContactAttachmentByFileNameWithHttpInfo(xeroTenantId, contactID, fileName, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetContactAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactID** | **Guid** | Unique identifier for a Contact |  |
| **fileName** | **string** | Name of the attachment |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for Contact as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontactattachmentbyid"></a>
# **GetContactAttachmentById**
> System.IO.Stream GetContactAttachmentById (string xeroTenantId, Guid contactID, Guid attachmentID, string contentType)

Retrieves a specific attachment from a specific contact using a unique attachment Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetContactAttachmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Contact
            var attachmentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Attachment object
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves a specific attachment from a specific contact using a unique attachment Id
                System.IO.Stream result = apiInstance.GetContactAttachmentById(xeroTenantId, contactID, attachmentID, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetContactAttachmentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactAttachmentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific attachment from a specific contact using a unique attachment Id
    ApiResponse<System.IO.Stream> response = apiInstance.GetContactAttachmentByIdWithHttpInfo(xeroTenantId, contactID, attachmentID, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetContactAttachmentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactID** | **Guid** | Unique identifier for a Contact |  |
| **attachmentID** | **Guid** | Unique identifier for Attachment object |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for Contact as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontactattachments"></a>
# **GetContactAttachments**
> Attachments GetContactAttachments (string xeroTenantId, Guid contactID)

Retrieves attachments for a specific contact in a Xero organisation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetContactAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Contact

            try
            {
                // Retrieves attachments for a specific contact in a Xero organisation
                Attachments result = apiInstance.GetContactAttachments(xeroTenantId, contactID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetContactAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves attachments for a specific contact in a Xero organisation
    ApiResponse<Attachments> response = apiInstance.GetContactAttachmentsWithHttpInfo(xeroTenantId, contactID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetContactAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactID** | **Guid** | Unique identifier for a Contact |  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array with 0 to N Attachment |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontactbycontactnumber"></a>
# **GetContactByContactNumber**
> Contacts GetContactByContactNumber (string xeroTenantId, string contactNumber)

Retrieves a specific contact by contact number in a Xero organisation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetContactByContactNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactNumber = SB2;  // string | This field is read only on the Xero contact screen, used to identify contacts in external systems (max length = 50).

            try
            {
                // Retrieves a specific contact by contact number in a Xero organisation
                Contacts result = apiInstance.GetContactByContactNumber(xeroTenantId, contactNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetContactByContactNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactByContactNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific contact by contact number in a Xero organisation
    ApiResponse<Contacts> response = apiInstance.GetContactByContactNumberWithHttpInfo(xeroTenantId, contactNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetContactByContactNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactNumber** | **string** | This field is read only on the Xero contact screen, used to identify contacts in external systems (max length &#x3D; 50). |  |

### Return type

[**Contacts**](Contacts.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Contacts array with a unique Contact |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontactcissettings"></a>
# **GetContactCISSettings**
> CISSettings GetContactCISSettings (string xeroTenantId, Guid contactID)

Retrieves CIS settings for a specific contact in a Xero organisation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetContactCISSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Contact

            try
            {
                // Retrieves CIS settings for a specific contact in a Xero organisation
                CISSettings result = apiInstance.GetContactCISSettings(xeroTenantId, contactID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetContactCISSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactCISSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves CIS settings for a specific contact in a Xero organisation
    ApiResponse<CISSettings> response = apiInstance.GetContactCISSettingsWithHttpInfo(xeroTenantId, contactID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetContactCISSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactID** | **Guid** | Unique identifier for a Contact |  |

### Return type

[**CISSettings**](CISSettings.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type CISSettings for a specific Contact |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontactgroup"></a>
# **GetContactGroup**
> ContactGroups GetContactGroup (string xeroTenantId, Guid contactGroupID)

Retrieves a specific contact group by using a unique contact group Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetContactGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactGroupID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Contact Group

            try
            {
                // Retrieves a specific contact group by using a unique contact group Id
                ContactGroups result = apiInstance.GetContactGroup(xeroTenantId, contactGroupID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetContactGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific contact group by using a unique contact group Id
    ApiResponse<ContactGroups> response = apiInstance.GetContactGroupWithHttpInfo(xeroTenantId, contactGroupID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetContactGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactGroupID** | **Guid** | Unique identifier for a Contact Group |  |

### Return type

[**ContactGroups**](ContactGroups.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Contact Groups array with a specific Contact Group |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontactgroups"></a>
# **GetContactGroups**
> ContactGroups GetContactGroups (string xeroTenantId, string? where = null, string? order = null)

Retrieves the contact Id and name of each contact group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetContactGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var where = Status=="ACTIVE";  // string? | Filter by an any element (optional) 
            var order = Name ASC;  // string? | Order by an any element (optional) 

            try
            {
                // Retrieves the contact Id and name of each contact group
                ContactGroups result = apiInstance.GetContactGroups(xeroTenantId, where, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetContactGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the contact Id and name of each contact group
    ApiResponse<ContactGroups> response = apiInstance.GetContactGroupsWithHttpInfo(xeroTenantId, where, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetContactGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |

### Return type

[**ContactGroups**](ContactGroups.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Contact Groups array of Contact Group |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontacthistory"></a>
# **GetContactHistory**
> HistoryRecords GetContactHistory (string xeroTenantId, Guid contactID)

Retrieves history records for a specific contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetContactHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Contact

            try
            {
                // Retrieves history records for a specific contact
                HistoryRecords result = apiInstance.GetContactHistory(xeroTenantId, contactID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetContactHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves history records for a specific contact
    ApiResponse<HistoryRecords> response = apiInstance.GetContactHistoryWithHttpInfo(xeroTenantId, contactID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetContactHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactID** | **Guid** | Unique identifier for a Contact |  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of HistoryRecords array of 0 to N HistoryRecord |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontacts"></a>
# **GetContacts**
> Contacts GetContacts (string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, List<Guid>? iDs = null, int? page = null, bool? includeArchived = null, bool? summaryOnly = null, string? searchTerm = null, int? pageSize = null)

Retrieves all contacts in a Xero organisation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var where = ContactStatus==&quot;ACTIVE&quot;;  // string? | Filter by an any element (optional) 
            var order = Name ASC;  // string? | Order by an any element (optional) 
            var iDs = new List<Guid>?(); // List<Guid>? | Filter by a comma separated list of ContactIDs. Allows you to retrieve a specific set of contacts in a single call. (optional) 
            var page = 1;  // int? | e.g. page=1 - Up to 100 contacts will be returned in a single API call. (optional) 
            var includeArchived = true;  // bool? | e.g. includeArchived=true - Contacts with a status of ARCHIVED will be included in the response (optional) 
            var summaryOnly = true;  // bool? | Use summaryOnly=true in GET Contacts and Invoices endpoint to retrieve a smaller version of the response object. This returns only lightweight fields, excluding computation-heavy fields from the response, making the API calls quick and efficient. (optional)  (default to false)
            var searchTerm = Joe Bloggs;  // string? | Search parameter that performs a case-insensitive text search across the Name, FirstName, LastName, ContactNumber and EmailAddress fields. (optional) 
            var pageSize = 100;  // int? | Number of records to retrieve per page (optional) 

            try
            {
                // Retrieves all contacts in a Xero organisation
                Contacts result = apiInstance.GetContacts(xeroTenantId, ifModifiedSince, where, order, iDs, page, includeArchived, summaryOnly, searchTerm, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all contacts in a Xero organisation
    ApiResponse<Contacts> response = apiInstance.GetContactsWithHttpInfo(xeroTenantId, ifModifiedSince, where, order, iDs, page, includeArchived, summaryOnly, searchTerm, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |
| **iDs** | [**List&lt;Guid&gt;?**](Guid.md) | Filter by a comma separated list of ContactIDs. Allows you to retrieve a specific set of contacts in a single call. | [optional]  |
| **page** | **int?** | e.g. page&#x3D;1 - Up to 100 contacts will be returned in a single API call. | [optional]  |
| **includeArchived** | **bool?** | e.g. includeArchived&#x3D;true - Contacts with a status of ARCHIVED will be included in the response | [optional]  |
| **summaryOnly** | **bool?** | Use summaryOnly&#x3D;true in GET Contacts and Invoices endpoint to retrieve a smaller version of the response object. This returns only lightweight fields, excluding computation-heavy fields from the response, making the API calls quick and efficient. | [optional] [default to false] |
| **searchTerm** | **string?** | Search parameter that performs a case-insensitive text search across the Name, FirstName, LastName, ContactNumber and EmailAddress fields. | [optional]  |
| **pageSize** | **int?** | Number of records to retrieve per page | [optional]  |

### Return type

[**Contacts**](Contacts.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Contacts array with 0 to N Contact |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcreditnote"></a>
# **GetCreditNote**
> CreditNotes GetCreditNote (string xeroTenantId, Guid creditNoteID, int? unitdp = null)

Retrieves a specific credit note using a unique credit note Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCreditNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var creditNoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Credit Note
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 

            try
            {
                // Retrieves a specific credit note using a unique credit note Id
                CreditNotes result = apiInstance.GetCreditNote(xeroTenantId, creditNoteID, unitdp);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetCreditNote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCreditNoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific credit note using a unique credit note Id
    ApiResponse<CreditNotes> response = apiInstance.GetCreditNoteWithHttpInfo(xeroTenantId, creditNoteID, unitdp);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetCreditNoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **creditNoteID** | **Guid** | Unique identifier for a Credit Note |  |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |

### Return type

[**CreditNotes**](CreditNotes.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Credit Notes array with a unique CreditNote |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcreditnoteaspdf"></a>
# **GetCreditNoteAsPdf**
> System.IO.Stream GetCreditNoteAsPdf (string xeroTenantId, Guid creditNoteID)

Retrieves credit notes as PDF files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCreditNoteAsPdfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var creditNoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Credit Note

            try
            {
                // Retrieves credit notes as PDF files
                System.IO.Stream result = apiInstance.GetCreditNoteAsPdf(xeroTenantId, creditNoteID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetCreditNoteAsPdf: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCreditNoteAsPdfWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves credit notes as PDF files
    ApiResponse<System.IO.Stream> response = apiInstance.GetCreditNoteAsPdfWithHttpInfo(xeroTenantId, creditNoteID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetCreditNoteAsPdfWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **creditNoteID** | **Guid** | Unique identifier for a Credit Note |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of binary data from the Attachment to a Credit Note |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcreditnoteattachmentbyfilename"></a>
# **GetCreditNoteAttachmentByFileName**
> System.IO.Stream GetCreditNoteAttachmentByFileName (string xeroTenantId, Guid creditNoteID, string fileName, string contentType)

Retrieves a specific attachment on a specific credit note by file name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCreditNoteAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var creditNoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Credit Note
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves a specific attachment on a specific credit note by file name
                System.IO.Stream result = apiInstance.GetCreditNoteAttachmentByFileName(xeroTenantId, creditNoteID, fileName, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetCreditNoteAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCreditNoteAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific attachment on a specific credit note by file name
    ApiResponse<System.IO.Stream> response = apiInstance.GetCreditNoteAttachmentByFileNameWithHttpInfo(xeroTenantId, creditNoteID, fileName, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetCreditNoteAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **creditNoteID** | **Guid** | Unique identifier for a Credit Note |  |
| **fileName** | **string** | Name of the attachment |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for Credit Note as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcreditnoteattachmentbyid"></a>
# **GetCreditNoteAttachmentById**
> System.IO.Stream GetCreditNoteAttachmentById (string xeroTenantId, Guid creditNoteID, Guid attachmentID, string contentType)

Retrieves a specific attachment from a specific credit note using a unique attachment Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCreditNoteAttachmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var creditNoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Credit Note
            var attachmentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Attachment object
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves a specific attachment from a specific credit note using a unique attachment Id
                System.IO.Stream result = apiInstance.GetCreditNoteAttachmentById(xeroTenantId, creditNoteID, attachmentID, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetCreditNoteAttachmentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCreditNoteAttachmentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific attachment from a specific credit note using a unique attachment Id
    ApiResponse<System.IO.Stream> response = apiInstance.GetCreditNoteAttachmentByIdWithHttpInfo(xeroTenantId, creditNoteID, attachmentID, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetCreditNoteAttachmentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **creditNoteID** | **Guid** | Unique identifier for a Credit Note |  |
| **attachmentID** | **Guid** | Unique identifier for Attachment object |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for Credit Note as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcreditnoteattachments"></a>
# **GetCreditNoteAttachments**
> Attachments GetCreditNoteAttachments (string xeroTenantId, Guid creditNoteID)

Retrieves attachments for a specific credit notes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCreditNoteAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var creditNoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Credit Note

            try
            {
                // Retrieves attachments for a specific credit notes
                Attachments result = apiInstance.GetCreditNoteAttachments(xeroTenantId, creditNoteID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetCreditNoteAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCreditNoteAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves attachments for a specific credit notes
    ApiResponse<Attachments> response = apiInstance.GetCreditNoteAttachmentsWithHttpInfo(xeroTenantId, creditNoteID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetCreditNoteAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **creditNoteID** | **Guid** | Unique identifier for a Credit Note |  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array with all Attachment for specific Credit Note |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcreditnotehistory"></a>
# **GetCreditNoteHistory**
> HistoryRecords GetCreditNoteHistory (string xeroTenantId, Guid creditNoteID)

Retrieves history records of a specific credit note

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCreditNoteHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var creditNoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Credit Note

            try
            {
                // Retrieves history records of a specific credit note
                HistoryRecords result = apiInstance.GetCreditNoteHistory(xeroTenantId, creditNoteID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetCreditNoteHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCreditNoteHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves history records of a specific credit note
    ApiResponse<HistoryRecords> response = apiInstance.GetCreditNoteHistoryWithHttpInfo(xeroTenantId, creditNoteID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetCreditNoteHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **creditNoteID** | **Guid** | Unique identifier for a Credit Note |  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of HistoryRecords array of 0 to N HistoryRecord |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcreditnotes"></a>
# **GetCreditNotes**
> CreditNotes GetCreditNotes (string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? unitdp = null, int? pageSize = null)

Retrieves any credit notes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCreditNotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var where = Status=="DRAFT";  // string? | Filter by an any element (optional) 
            var order = CreditNoteNumber ASC;  // string? | Order by an any element (optional) 
            var page = 1;  // int? | e.g. page=1 – Up to 100 credit notes will be returned in a single API call with line items shown for each credit note (optional) 
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var pageSize = 100;  // int? | Number of records to retrieve per page (optional) 

            try
            {
                // Retrieves any credit notes
                CreditNotes result = apiInstance.GetCreditNotes(xeroTenantId, ifModifiedSince, where, order, page, unitdp, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetCreditNotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCreditNotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves any credit notes
    ApiResponse<CreditNotes> response = apiInstance.GetCreditNotesWithHttpInfo(xeroTenantId, ifModifiedSince, where, order, page, unitdp, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetCreditNotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |
| **page** | **int?** | e.g. page&#x3D;1 – Up to 100 credit notes will be returned in a single API call with line items shown for each credit note | [optional]  |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **pageSize** | **int?** | Number of records to retrieve per page | [optional]  |

### Return type

[**CreditNotes**](CreditNotes.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Credit Notes array of CreditNote |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcurrencies"></a>
# **GetCurrencies**
> Currencies GetCurrencies (string xeroTenantId, string? where = null, string? order = null)

Retrieves currencies for your Xero organisation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCurrenciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var where = Code=="USD";  // string? | Filter by an any element (optional) 
            var order = Code ASC;  // string? | Order by an any element (optional) 

            try
            {
                // Retrieves currencies for your Xero organisation
                Currencies result = apiInstance.GetCurrencies(xeroTenantId, where, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetCurrencies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCurrenciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves currencies for your Xero organisation
    ApiResponse<Currencies> response = apiInstance.GetCurrenciesWithHttpInfo(xeroTenantId, where, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetCurrenciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |

### Return type

[**Currencies**](Currencies.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Currencies array with all Currencies |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getemployee"></a>
# **GetEmployee**
> Employees GetEmployee (string xeroTenantId, Guid employeeID)

Retrieves a specific employee used in Xero payrun using a unique employee Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetEmployeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var employeeID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Employee

            try
            {
                // Retrieves a specific employee used in Xero payrun using a unique employee Id
                Employees result = apiInstance.GetEmployee(xeroTenantId, employeeID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetEmployee: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmployeeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific employee used in Xero payrun using a unique employee Id
    ApiResponse<Employees> response = apiInstance.GetEmployeeWithHttpInfo(xeroTenantId, employeeID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetEmployeeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **employeeID** | **Guid** | Unique identifier for a Employee |  |

### Return type

[**Employees**](Employees.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Employees array with specified Employee |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getemployees"></a>
# **GetEmployees**
> Employees GetEmployees (string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null)

Retrieves employees used in Xero payrun

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetEmployeesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var where = Status=="ACTIVE";  // string? | Filter by an any element (optional) 
            var order = LastName ASC;  // string? | Order by an any element (optional) 

            try
            {
                // Retrieves employees used in Xero payrun
                Employees result = apiInstance.GetEmployees(xeroTenantId, ifModifiedSince, where, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetEmployees: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmployeesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves employees used in Xero payrun
    ApiResponse<Employees> response = apiInstance.GetEmployeesWithHttpInfo(xeroTenantId, ifModifiedSince, where, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetEmployeesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |

### Return type

[**Employees**](Employees.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Employees array with all Employee |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getexpenseclaim"></a>
# **GetExpenseClaim**
> ExpenseClaims GetExpenseClaim (string xeroTenantId, Guid expenseClaimID)

Retrieves a specific expense claim using a unique expense claim Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetExpenseClaimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var expenseClaimID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a ExpenseClaim

            try
            {
                // Retrieves a specific expense claim using a unique expense claim Id
                ExpenseClaims result = apiInstance.GetExpenseClaim(xeroTenantId, expenseClaimID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetExpenseClaim: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExpenseClaimWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific expense claim using a unique expense claim Id
    ApiResponse<ExpenseClaims> response = apiInstance.GetExpenseClaimWithHttpInfo(xeroTenantId, expenseClaimID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetExpenseClaimWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **expenseClaimID** | **Guid** | Unique identifier for a ExpenseClaim |  |

### Return type

[**ExpenseClaims**](ExpenseClaims.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type ExpenseClaims array with specified ExpenseClaim |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getexpenseclaimhistory"></a>
# **GetExpenseClaimHistory**
> HistoryRecords GetExpenseClaimHistory (string xeroTenantId, Guid expenseClaimID)

Retrieves history records of a specific expense claim

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetExpenseClaimHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var expenseClaimID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a ExpenseClaim

            try
            {
                // Retrieves history records of a specific expense claim
                HistoryRecords result = apiInstance.GetExpenseClaimHistory(xeroTenantId, expenseClaimID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetExpenseClaimHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExpenseClaimHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves history records of a specific expense claim
    ApiResponse<HistoryRecords> response = apiInstance.GetExpenseClaimHistoryWithHttpInfo(xeroTenantId, expenseClaimID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetExpenseClaimHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **expenseClaimID** | **Guid** | Unique identifier for a ExpenseClaim |  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of HistoryRecords array of 0 to N HistoryRecord |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getexpenseclaims"></a>
# **GetExpenseClaims**
> ExpenseClaims GetExpenseClaims (string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null)

Retrieves expense claims

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetExpenseClaimsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var where = Status=="SUBMITTED";  // string? | Filter by an any element (optional) 
            var order = Status ASC;  // string? | Order by an any element (optional) 

            try
            {
                // Retrieves expense claims
                ExpenseClaims result = apiInstance.GetExpenseClaims(xeroTenantId, ifModifiedSince, where, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetExpenseClaims: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExpenseClaimsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves expense claims
    ApiResponse<ExpenseClaims> response = apiInstance.GetExpenseClaimsWithHttpInfo(xeroTenantId, ifModifiedSince, where, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetExpenseClaimsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |

### Return type

[**ExpenseClaims**](ExpenseClaims.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type ExpenseClaims array with all ExpenseClaims |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinvoice"></a>
# **GetInvoice**
> Invoices GetInvoice (string xeroTenantId, Guid invoiceID, int? unitdp = null)

Retrieves a specific sales invoice or purchase bill using a unique invoice Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetInvoiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var invoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Invoice
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 

            try
            {
                // Retrieves a specific sales invoice or purchase bill using a unique invoice Id
                Invoices result = apiInstance.GetInvoice(xeroTenantId, invoiceID, unitdp);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetInvoice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvoiceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific sales invoice or purchase bill using a unique invoice Id
    ApiResponse<Invoices> response = apiInstance.GetInvoiceWithHttpInfo(xeroTenantId, invoiceID, unitdp);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetInvoiceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **invoiceID** | **Guid** | Unique identifier for an Invoice |  |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |

### Return type

[**Invoices**](Invoices.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Invoices array with specified Invoices |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinvoiceaspdf"></a>
# **GetInvoiceAsPdf**
> System.IO.Stream GetInvoiceAsPdf (string xeroTenantId, Guid invoiceID)

Retrieves invoices or purchase bills as PDF files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetInvoiceAsPdfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var invoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Invoice

            try
            {
                // Retrieves invoices or purchase bills as PDF files
                System.IO.Stream result = apiInstance.GetInvoiceAsPdf(xeroTenantId, invoiceID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetInvoiceAsPdf: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvoiceAsPdfWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves invoices or purchase bills as PDF files
    ApiResponse<System.IO.Stream> response = apiInstance.GetInvoiceAsPdfWithHttpInfo(xeroTenantId, invoiceID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetInvoiceAsPdfWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **invoiceID** | **Guid** | Unique identifier for an Invoice |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of byte array pdf version of specified Invoices |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinvoiceattachmentbyfilename"></a>
# **GetInvoiceAttachmentByFileName**
> System.IO.Stream GetInvoiceAttachmentByFileName (string xeroTenantId, Guid invoiceID, string fileName, string contentType)

Retrieves an attachment from a specific invoice or purchase bill by filename

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetInvoiceAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var invoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Invoice
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves an attachment from a specific invoice or purchase bill by filename
                System.IO.Stream result = apiInstance.GetInvoiceAttachmentByFileName(xeroTenantId, invoiceID, fileName, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetInvoiceAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvoiceAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves an attachment from a specific invoice or purchase bill by filename
    ApiResponse<System.IO.Stream> response = apiInstance.GetInvoiceAttachmentByFileNameWithHttpInfo(xeroTenantId, invoiceID, fileName, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetInvoiceAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **invoiceID** | **Guid** | Unique identifier for an Invoice |  |
| **fileName** | **string** | Name of the attachment |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for Invoice as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinvoiceattachmentbyid"></a>
# **GetInvoiceAttachmentById**
> System.IO.Stream GetInvoiceAttachmentById (string xeroTenantId, Guid invoiceID, Guid attachmentID, string contentType)

Retrieves a specific attachment from a specific invoices or purchase bills by using a unique attachment Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetInvoiceAttachmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var invoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Invoice
            var attachmentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Attachment object
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves a specific attachment from a specific invoices or purchase bills by using a unique attachment Id
                System.IO.Stream result = apiInstance.GetInvoiceAttachmentById(xeroTenantId, invoiceID, attachmentID, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetInvoiceAttachmentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvoiceAttachmentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific attachment from a specific invoices or purchase bills by using a unique attachment Id
    ApiResponse<System.IO.Stream> response = apiInstance.GetInvoiceAttachmentByIdWithHttpInfo(xeroTenantId, invoiceID, attachmentID, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetInvoiceAttachmentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **invoiceID** | **Guid** | Unique identifier for an Invoice |  |
| **attachmentID** | **Guid** | Unique identifier for Attachment object |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for Invoice as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinvoiceattachments"></a>
# **GetInvoiceAttachments**
> Attachments GetInvoiceAttachments (string xeroTenantId, Guid invoiceID)

Retrieves attachments for a specific invoice or purchase bill

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetInvoiceAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var invoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Invoice

            try
            {
                // Retrieves attachments for a specific invoice or purchase bill
                Attachments result = apiInstance.GetInvoiceAttachments(xeroTenantId, invoiceID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetInvoiceAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvoiceAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves attachments for a specific invoice or purchase bill
    ApiResponse<Attachments> response = apiInstance.GetInvoiceAttachmentsWithHttpInfo(xeroTenantId, invoiceID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetInvoiceAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **invoiceID** | **Guid** | Unique identifier for an Invoice |  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array of Attachments for specified Invoices |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinvoicehistory"></a>
# **GetInvoiceHistory**
> HistoryRecords GetInvoiceHistory (string xeroTenantId, Guid invoiceID)

Retrieves history records for a specific invoice

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetInvoiceHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var invoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Invoice

            try
            {
                // Retrieves history records for a specific invoice
                HistoryRecords result = apiInstance.GetInvoiceHistory(xeroTenantId, invoiceID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetInvoiceHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvoiceHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves history records for a specific invoice
    ApiResponse<HistoryRecords> response = apiInstance.GetInvoiceHistoryWithHttpInfo(xeroTenantId, invoiceID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetInvoiceHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **invoiceID** | **Guid** | Unique identifier for an Invoice |  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of HistoryRecords array of 0 to N HistoryRecord |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinvoicereminders"></a>
# **GetInvoiceReminders**
> InvoiceReminders GetInvoiceReminders (string xeroTenantId)

Retrieves invoice reminder settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetInvoiceRemindersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant

            try
            {
                // Retrieves invoice reminder settings
                InvoiceReminders result = apiInstance.GetInvoiceReminders(xeroTenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetInvoiceReminders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvoiceRemindersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves invoice reminder settings
    ApiResponse<InvoiceReminders> response = apiInstance.GetInvoiceRemindersWithHttpInfo(xeroTenantId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetInvoiceRemindersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |

### Return type

[**InvoiceReminders**](InvoiceReminders.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of Invoice Reminders |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinvoices"></a>
# **GetInvoices**
> Invoices GetInvoices (string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, List<Guid>? iDs = null, List<string>? invoiceNumbers = null, List<Guid>? contactIDs = null, List<string>? statuses = null, int? page = null, bool? includeArchived = null, bool? createdByMyApp = null, int? unitdp = null, bool? summaryOnly = null, int? pageSize = null, string? searchTerm = null)

Retrieves sales invoices or purchase bills

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetInvoicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var where = Status=="DRAFT";  // string? | Filter by an any element (optional) 
            var order = InvoiceNumber ASC;  // string? | Order by an any element (optional) 
            var iDs = new List<Guid>?(); // List<Guid>? | Filter by a comma-separated list of InvoicesIDs. (optional) 
            var invoiceNumbers = new List<string>?(); // List<string>? | Filter by a comma-separated list of InvoiceNumbers. (optional) 
            var contactIDs = new List<Guid>?(); // List<Guid>? | Filter by a comma-separated list of ContactIDs. (optional) 
            var statuses = new List<string>?(); // List<string>? | Filter by a comma-separated list Statuses. For faster response times we recommend using these explicit parameters instead of passing OR conditions into the Where filter. (optional) 
            var page = 1;  // int? | e.g. page=1 – Up to 100 invoices will be returned in a single API call with line items shown for each invoice (optional) 
            var includeArchived = true;  // bool? | e.g. includeArchived=true - Invoices with a status of ARCHIVED will be included in the response (optional) 
            var createdByMyApp = false;  // bool? | When set to true you'll only retrieve Invoices created by your app (optional) 
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var summaryOnly = true;  // bool? | Use summaryOnly=true in GET Contacts and Invoices endpoint to retrieve a smaller version of the response object. This returns only lightweight fields, excluding computation-heavy fields from the response, making the API calls quick and efficient. (optional)  (default to false)
            var pageSize = 100;  // int? | Number of records to retrieve per page (optional) 
            var searchTerm = SearchTerm=REF12;  // string? | Search parameter that performs a case-insensitive text search across the fields e.g. InvoiceNumber, Reference. (optional) 

            try
            {
                // Retrieves sales invoices or purchase bills
                Invoices result = apiInstance.GetInvoices(xeroTenantId, ifModifiedSince, where, order, iDs, invoiceNumbers, contactIDs, statuses, page, includeArchived, createdByMyApp, unitdp, summaryOnly, pageSize, searchTerm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetInvoices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvoicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves sales invoices or purchase bills
    ApiResponse<Invoices> response = apiInstance.GetInvoicesWithHttpInfo(xeroTenantId, ifModifiedSince, where, order, iDs, invoiceNumbers, contactIDs, statuses, page, includeArchived, createdByMyApp, unitdp, summaryOnly, pageSize, searchTerm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetInvoicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |
| **iDs** | [**List&lt;Guid&gt;?**](Guid.md) | Filter by a comma-separated list of InvoicesIDs. | [optional]  |
| **invoiceNumbers** | [**List&lt;string&gt;?**](string.md) | Filter by a comma-separated list of InvoiceNumbers. | [optional]  |
| **contactIDs** | [**List&lt;Guid&gt;?**](Guid.md) | Filter by a comma-separated list of ContactIDs. | [optional]  |
| **statuses** | [**List&lt;string&gt;?**](string.md) | Filter by a comma-separated list Statuses. For faster response times we recommend using these explicit parameters instead of passing OR conditions into the Where filter. | [optional]  |
| **page** | **int?** | e.g. page&#x3D;1 – Up to 100 invoices will be returned in a single API call with line items shown for each invoice | [optional]  |
| **includeArchived** | **bool?** | e.g. includeArchived&#x3D;true - Invoices with a status of ARCHIVED will be included in the response | [optional]  |
| **createdByMyApp** | **bool?** | When set to true you&#39;ll only retrieve Invoices created by your app | [optional]  |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **summaryOnly** | **bool?** | Use summaryOnly&#x3D;true in GET Contacts and Invoices endpoint to retrieve a smaller version of the response object. This returns only lightweight fields, excluding computation-heavy fields from the response, making the API calls quick and efficient. | [optional] [default to false] |
| **pageSize** | **int?** | Number of records to retrieve per page | [optional]  |
| **searchTerm** | **string?** | Search parameter that performs a case-insensitive text search across the fields e.g. InvoiceNumber, Reference. | [optional]  |

### Return type

[**Invoices**](Invoices.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Invoices array with all Invoices |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getitem"></a>
# **GetItem**
> Items GetItem (string xeroTenantId, Guid itemID, int? unitdp = null)

Retrieves a specific item using a unique item Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var itemID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Item
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 

            try
            {
                // Retrieves a specific item using a unique item Id
                Items result = apiInstance.GetItem(xeroTenantId, itemID, unitdp);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific item using a unique item Id
    ApiResponse<Items> response = apiInstance.GetItemWithHttpInfo(xeroTenantId, itemID, unitdp);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **itemID** | **Guid** | Unique identifier for an Item |  |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |

### Return type

[**Items**](Items.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Items array with specified Item |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getitemhistory"></a>
# **GetItemHistory**
> HistoryRecords GetItemHistory (string xeroTenantId, Guid itemID)

Retrieves history for a specific item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetItemHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var itemID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Item

            try
            {
                // Retrieves history for a specific item
                HistoryRecords result = apiInstance.GetItemHistory(xeroTenantId, itemID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetItemHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetItemHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves history for a specific item
    ApiResponse<HistoryRecords> response = apiInstance.GetItemHistoryWithHttpInfo(xeroTenantId, itemID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetItemHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **itemID** | **Guid** | Unique identifier for an Item |  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of HistoryRecords array of 0 to N HistoryRecord |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getitems"></a>
# **GetItems**
> Items GetItems (string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? unitdp = null)

Retrieves items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var where = IsSold==true;  // string? | Filter by an any element (optional) 
            var order = Code ASC;  // string? | Order by an any element (optional) 
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 

            try
            {
                // Retrieves items
                Items result = apiInstance.GetItems(xeroTenantId, ifModifiedSince, where, order, unitdp);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves items
    ApiResponse<Items> response = apiInstance.GetItemsWithHttpInfo(xeroTenantId, ifModifiedSince, where, order, unitdp);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |

### Return type

[**Items**](Items.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Items array with all Item |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getjournal"></a>
# **GetJournal**
> Journals GetJournal (string xeroTenantId, Guid journalID)

Retrieves a specific journal using a unique journal Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetJournalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var journalID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Journal

            try
            {
                // Retrieves a specific journal using a unique journal Id.
                Journals result = apiInstance.GetJournal(xeroTenantId, journalID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetJournal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJournalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific journal using a unique journal Id.
    ApiResponse<Journals> response = apiInstance.GetJournalWithHttpInfo(xeroTenantId, journalID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetJournalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **journalID** | **Guid** | Unique identifier for a Journal |  |

### Return type

[**Journals**](Journals.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Journals array with specified Journal |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getjournalbynumber"></a>
# **GetJournalByNumber**
> Journals GetJournalByNumber (string xeroTenantId, int journalNumber)

Retrieves a specific journal using a unique journal number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetJournalByNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var journalNumber = 1000;  // int | Number of a Journal

            try
            {
                // Retrieves a specific journal using a unique journal number.
                Journals result = apiInstance.GetJournalByNumber(xeroTenantId, journalNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetJournalByNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJournalByNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific journal using a unique journal number.
    ApiResponse<Journals> response = apiInstance.GetJournalByNumberWithHttpInfo(xeroTenantId, journalNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetJournalByNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **journalNumber** | **int** | Number of a Journal |  |

### Return type

[**Journals**](Journals.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Journals array with specified Journal |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getjournals"></a>
# **GetJournals**
> Journals GetJournals (string xeroTenantId, DateTime? ifModifiedSince = null, int? offset = null, bool? paymentsOnly = null)

Retrieves journals

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetJournalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var offset = 10;  // int? | Offset by a specified journal number. e.g. journals with a JournalNumber greater than the offset will be returned (optional) 
            var paymentsOnly = true;  // bool? | Filter to retrieve journals on a cash basis. Journals are returned on an accrual basis by default. (optional) 

            try
            {
                // Retrieves journals
                Journals result = apiInstance.GetJournals(xeroTenantId, ifModifiedSince, offset, paymentsOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetJournals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJournalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves journals
    ApiResponse<Journals> response = apiInstance.GetJournalsWithHttpInfo(xeroTenantId, ifModifiedSince, offset, paymentsOnly);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetJournalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **offset** | **int?** | Offset by a specified journal number. e.g. journals with a JournalNumber greater than the offset will be returned | [optional]  |
| **paymentsOnly** | **bool?** | Filter to retrieve journals on a cash basis. Journals are returned on an accrual basis by default. | [optional]  |

### Return type

[**Journals**](Journals.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Journals array with all Journals |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlinkedtransaction"></a>
# **GetLinkedTransaction**
> LinkedTransactions GetLinkedTransaction (string xeroTenantId, Guid linkedTransactionID)

Retrieves a specific linked transaction (billable expenses) using a unique linked transaction Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetLinkedTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var linkedTransactionID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a LinkedTransaction

            try
            {
                // Retrieves a specific linked transaction (billable expenses) using a unique linked transaction Id
                LinkedTransactions result = apiInstance.GetLinkedTransaction(xeroTenantId, linkedTransactionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetLinkedTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLinkedTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific linked transaction (billable expenses) using a unique linked transaction Id
    ApiResponse<LinkedTransactions> response = apiInstance.GetLinkedTransactionWithHttpInfo(xeroTenantId, linkedTransactionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetLinkedTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **linkedTransactionID** | **Guid** | Unique identifier for a LinkedTransaction |  |

### Return type

[**LinkedTransactions**](LinkedTransactions.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type LinkedTransactions array with a specified LinkedTransaction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlinkedtransactions"></a>
# **GetLinkedTransactions**
> LinkedTransactions GetLinkedTransactions (string xeroTenantId, int? page = null, Guid? linkedTransactionID = null, Guid? sourceTransactionID = null, Guid? contactID = null, string? status = null, Guid? targetTransactionID = null)

Retrieves linked transactions (billable expenses)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetLinkedTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var page = 1;  // int? | Up to 100 linked transactions will be returned in a single API call. Use the page parameter to specify the page to be returned e.g. page=1. (optional) 
            var linkedTransactionID = 00000000-0000-0000-0000-000000000000;  // Guid? | The Xero identifier for an Linked Transaction (optional) 
            var sourceTransactionID = 00000000-0000-0000-0000-000000000000;  // Guid? | Filter by the SourceTransactionID. Get the linked transactions created from a particular ACCPAY invoice (optional) 
            var contactID = 00000000-0000-0000-0000-000000000000;  // Guid? | Filter by the ContactID. Get all the linked transactions that have been assigned to a particular customer. (optional) 
            var status = APPROVED;  // string? | Filter by the combination of ContactID and Status. Get  the linked transactions associated to a  customer and with a status (optional) 
            var targetTransactionID = 00000000-0000-0000-0000-000000000000;  // Guid? | Filter by the TargetTransactionID. Get all the linked transactions allocated to a particular ACCREC invoice (optional) 

            try
            {
                // Retrieves linked transactions (billable expenses)
                LinkedTransactions result = apiInstance.GetLinkedTransactions(xeroTenantId, page, linkedTransactionID, sourceTransactionID, contactID, status, targetTransactionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetLinkedTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLinkedTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves linked transactions (billable expenses)
    ApiResponse<LinkedTransactions> response = apiInstance.GetLinkedTransactionsWithHttpInfo(xeroTenantId, page, linkedTransactionID, sourceTransactionID, contactID, status, targetTransactionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetLinkedTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **page** | **int?** | Up to 100 linked transactions will be returned in a single API call. Use the page parameter to specify the page to be returned e.g. page&#x3D;1. | [optional]  |
| **linkedTransactionID** | **Guid?** | The Xero identifier for an Linked Transaction | [optional]  |
| **sourceTransactionID** | **Guid?** | Filter by the SourceTransactionID. Get the linked transactions created from a particular ACCPAY invoice | [optional]  |
| **contactID** | **Guid?** | Filter by the ContactID. Get all the linked transactions that have been assigned to a particular customer. | [optional]  |
| **status** | **string?** | Filter by the combination of ContactID and Status. Get  the linked transactions associated to a  customer and with a status | [optional]  |
| **targetTransactionID** | **Guid?** | Filter by the TargetTransactionID. Get all the linked transactions allocated to a particular ACCREC invoice | [optional]  |

### Return type

[**LinkedTransactions**](LinkedTransactions.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type LinkedTransactions array with all LinkedTransaction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmanualjournal"></a>
# **GetManualJournal**
> ManualJournals GetManualJournal (string xeroTenantId, Guid manualJournalID)

Retrieves a specific manual journal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetManualJournalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var manualJournalID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a ManualJournal

            try
            {
                // Retrieves a specific manual journal
                ManualJournals result = apiInstance.GetManualJournal(xeroTenantId, manualJournalID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetManualJournal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetManualJournalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific manual journal
    ApiResponse<ManualJournals> response = apiInstance.GetManualJournalWithHttpInfo(xeroTenantId, manualJournalID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetManualJournalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **manualJournalID** | **Guid** | Unique identifier for a ManualJournal |  |

### Return type

[**ManualJournals**](ManualJournals.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type ManualJournals array with a specified ManualJournals |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmanualjournalattachmentbyfilename"></a>
# **GetManualJournalAttachmentByFileName**
> System.IO.Stream GetManualJournalAttachmentByFileName (string xeroTenantId, Guid manualJournalID, string fileName, string contentType)

Retrieves a specific attachment from a specific manual journal by file name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetManualJournalAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var manualJournalID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a ManualJournal
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves a specific attachment from a specific manual journal by file name
                System.IO.Stream result = apiInstance.GetManualJournalAttachmentByFileName(xeroTenantId, manualJournalID, fileName, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetManualJournalAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetManualJournalAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific attachment from a specific manual journal by file name
    ApiResponse<System.IO.Stream> response = apiInstance.GetManualJournalAttachmentByFileNameWithHttpInfo(xeroTenantId, manualJournalID, fileName, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetManualJournalAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **manualJournalID** | **Guid** | Unique identifier for a ManualJournal |  |
| **fileName** | **string** | Name of the attachment |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for Manual Journal as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmanualjournalattachmentbyid"></a>
# **GetManualJournalAttachmentById**
> System.IO.Stream GetManualJournalAttachmentById (string xeroTenantId, Guid manualJournalID, Guid attachmentID, string contentType)

Allows you to retrieve a specific attachment from a specific manual journal using a unique attachment Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetManualJournalAttachmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var manualJournalID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a ManualJournal
            var attachmentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Attachment object
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Allows you to retrieve a specific attachment from a specific manual journal using a unique attachment Id
                System.IO.Stream result = apiInstance.GetManualJournalAttachmentById(xeroTenantId, manualJournalID, attachmentID, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetManualJournalAttachmentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetManualJournalAttachmentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Allows you to retrieve a specific attachment from a specific manual journal using a unique attachment Id
    ApiResponse<System.IO.Stream> response = apiInstance.GetManualJournalAttachmentByIdWithHttpInfo(xeroTenantId, manualJournalID, attachmentID, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetManualJournalAttachmentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **manualJournalID** | **Guid** | Unique identifier for a ManualJournal |  |
| **attachmentID** | **Guid** | Unique identifier for Attachment object |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for Manual Journal as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmanualjournalattachments"></a>
# **GetManualJournalAttachments**
> Attachments GetManualJournalAttachments (string xeroTenantId, Guid manualJournalID)

Retrieves attachment for a specific manual journal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetManualJournalAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var manualJournalID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a ManualJournal

            try
            {
                // Retrieves attachment for a specific manual journal
                Attachments result = apiInstance.GetManualJournalAttachments(xeroTenantId, manualJournalID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetManualJournalAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetManualJournalAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves attachment for a specific manual journal
    ApiResponse<Attachments> response = apiInstance.GetManualJournalAttachmentsWithHttpInfo(xeroTenantId, manualJournalID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetManualJournalAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **manualJournalID** | **Guid** | Unique identifier for a ManualJournal |  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array with all Attachments for a ManualJournals |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmanualjournals"></a>
# **GetManualJournals**
> ManualJournals GetManualJournals (string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? pageSize = null)

Retrieves manual journals

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetManualJournalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var where = Status=="DRAFT";  // string? | Filter by an any element (optional) 
            var order = Date ASC;  // string? | Order by an any element (optional) 
            var page = 1;  // int? | e.g. page=1 – Up to 100 manual journals will be returned in a single API call with line items shown for each overpayment (optional) 
            var pageSize = 100;  // int? | Number of records to retrieve per page (optional) 

            try
            {
                // Retrieves manual journals
                ManualJournals result = apiInstance.GetManualJournals(xeroTenantId, ifModifiedSince, where, order, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetManualJournals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetManualJournalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves manual journals
    ApiResponse<ManualJournals> response = apiInstance.GetManualJournalsWithHttpInfo(xeroTenantId, ifModifiedSince, where, order, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetManualJournalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |
| **page** | **int?** | e.g. page&#x3D;1 – Up to 100 manual journals will be returned in a single API call with line items shown for each overpayment | [optional]  |
| **pageSize** | **int?** | Number of records to retrieve per page | [optional]  |

### Return type

[**ManualJournals**](ManualJournals.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type ManualJournals array with a all ManualJournals |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmanualjournalshistory"></a>
# **GetManualJournalsHistory**
> HistoryRecords GetManualJournalsHistory (string xeroTenantId, Guid manualJournalID)

Retrieves history for a specific manual journal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetManualJournalsHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var manualJournalID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a ManualJournal

            try
            {
                // Retrieves history for a specific manual journal
                HistoryRecords result = apiInstance.GetManualJournalsHistory(xeroTenantId, manualJournalID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetManualJournalsHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetManualJournalsHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves history for a specific manual journal
    ApiResponse<HistoryRecords> response = apiInstance.GetManualJournalsHistoryWithHttpInfo(xeroTenantId, manualJournalID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetManualJournalsHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **manualJournalID** | **Guid** | Unique identifier for a ManualJournal |  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of HistoryRecords array of 0 to N HistoryRecord |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getonlineinvoice"></a>
# **GetOnlineInvoice**
> OnlineInvoices GetOnlineInvoice (string xeroTenantId, Guid invoiceID)

Retrieves a URL to an online invoice

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetOnlineInvoiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var invoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Invoice

            try
            {
                // Retrieves a URL to an online invoice
                OnlineInvoices result = apiInstance.GetOnlineInvoice(xeroTenantId, invoiceID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetOnlineInvoice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOnlineInvoiceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a URL to an online invoice
    ApiResponse<OnlineInvoices> response = apiInstance.GetOnlineInvoiceWithHttpInfo(xeroTenantId, invoiceID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetOnlineInvoiceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **invoiceID** | **Guid** | Unique identifier for an Invoice |  |

### Return type

[**OnlineInvoices**](OnlineInvoices.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type OnlineInvoice array with one OnlineInvoice |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getorganisationactions"></a>
# **GetOrganisationActions**
> Actions GetOrganisationActions (string xeroTenantId)

Retrieves a list of the key actions your app has permission to perform in the connected Xero organisation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetOrganisationActionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant

            try
            {
                // Retrieves a list of the key actions your app has permission to perform in the connected Xero organisation.
                Actions result = apiInstance.GetOrganisationActions(xeroTenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetOrganisationActions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrganisationActionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of the key actions your app has permission to perform in the connected Xero organisation.
    ApiResponse<Actions> response = apiInstance.GetOrganisationActionsWithHttpInfo(xeroTenantId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetOrganisationActionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |

### Return type

[**Actions**](Actions.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Actions array with all key actions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getorganisationcissettings"></a>
# **GetOrganisationCISSettings**
> CISOrgSettings GetOrganisationCISSettings (string xeroTenantId, Guid organisationID)

Retrieves the CIS settings for the Xero organistaion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetOrganisationCISSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var organisationID = 00000000-0000-0000-0000-000000000000;  // Guid | The unique Xero identifier for an organisation

            try
            {
                // Retrieves the CIS settings for the Xero organistaion.
                CISOrgSettings result = apiInstance.GetOrganisationCISSettings(xeroTenantId, organisationID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetOrganisationCISSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrganisationCISSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the CIS settings for the Xero organistaion.
    ApiResponse<CISOrgSettings> response = apiInstance.GetOrganisationCISSettingsWithHttpInfo(xeroTenantId, organisationID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetOrganisationCISSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **organisationID** | **Guid** | The unique Xero identifier for an organisation |  |

### Return type

[**CISOrgSettings**](CISOrgSettings.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Organisation array with specified Organisation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getorganisations"></a>
# **GetOrganisations**
> Organisations GetOrganisations (string xeroTenantId)

Retrieves Xero organisation details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetOrganisationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant

            try
            {
                // Retrieves Xero organisation details
                Organisations result = apiInstance.GetOrganisations(xeroTenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetOrganisations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrganisationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves Xero organisation details
    ApiResponse<Organisations> response = apiInstance.GetOrganisationsWithHttpInfo(xeroTenantId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetOrganisationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |

### Return type

[**Organisations**](Organisations.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Organisation array with all Organisation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getoverpayment"></a>
# **GetOverpayment**
> Overpayments GetOverpayment (string xeroTenantId, Guid overpaymentID)

Retrieves a specific overpayment using a unique overpayment Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetOverpaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var overpaymentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Overpayment

            try
            {
                // Retrieves a specific overpayment using a unique overpayment Id
                Overpayments result = apiInstance.GetOverpayment(xeroTenantId, overpaymentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetOverpayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOverpaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific overpayment using a unique overpayment Id
    ApiResponse<Overpayments> response = apiInstance.GetOverpaymentWithHttpInfo(xeroTenantId, overpaymentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetOverpaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **overpaymentID** | **Guid** | Unique identifier for a Overpayment |  |

### Return type

[**Overpayments**](Overpayments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Overpayments array with specified Overpayments |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getoverpaymenthistory"></a>
# **GetOverpaymentHistory**
> HistoryRecords GetOverpaymentHistory (string xeroTenantId, Guid overpaymentID)

Retrieves history records of a specific overpayment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetOverpaymentHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var overpaymentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Overpayment

            try
            {
                // Retrieves history records of a specific overpayment
                HistoryRecords result = apiInstance.GetOverpaymentHistory(xeroTenantId, overpaymentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetOverpaymentHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOverpaymentHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves history records of a specific overpayment
    ApiResponse<HistoryRecords> response = apiInstance.GetOverpaymentHistoryWithHttpInfo(xeroTenantId, overpaymentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetOverpaymentHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **overpaymentID** | **Guid** | Unique identifier for a Overpayment |  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of HistoryRecords array of 0 to N HistoryRecord |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getoverpayments"></a>
# **GetOverpayments**
> Overpayments GetOverpayments (string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? unitdp = null, int? pageSize = null)

Retrieves overpayments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetOverpaymentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var where = Status=="AUTHORISED";  // string? | Filter by an any element (optional) 
            var order = Status ASC;  // string? | Order by an any element (optional) 
            var page = 1;  // int? | e.g. page=1 – Up to 100 overpayments will be returned in a single API call with line items shown for each overpayment (optional) 
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var pageSize = 100;  // int? | Number of records to retrieve per page (optional) 

            try
            {
                // Retrieves overpayments
                Overpayments result = apiInstance.GetOverpayments(xeroTenantId, ifModifiedSince, where, order, page, unitdp, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetOverpayments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOverpaymentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves overpayments
    ApiResponse<Overpayments> response = apiInstance.GetOverpaymentsWithHttpInfo(xeroTenantId, ifModifiedSince, where, order, page, unitdp, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetOverpaymentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |
| **page** | **int?** | e.g. page&#x3D;1 – Up to 100 overpayments will be returned in a single API call with line items shown for each overpayment | [optional]  |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **pageSize** | **int?** | Number of records to retrieve per page | [optional]  |

### Return type

[**Overpayments**](Overpayments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Overpayments array with all Overpayments |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpayment"></a>
# **GetPayment**
> Payments GetPayment (string xeroTenantId, Guid paymentID)

Retrieves a specific payment for invoices and credit notes using a unique payment Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var paymentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Payment

            try
            {
                // Retrieves a specific payment for invoices and credit notes using a unique payment Id
                Payments result = apiInstance.GetPayment(xeroTenantId, paymentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific payment for invoices and credit notes using a unique payment Id
    ApiResponse<Payments> response = apiInstance.GetPaymentWithHttpInfo(xeroTenantId, paymentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **paymentID** | **Guid** | Unique identifier for a Payment |  |

### Return type

[**Payments**](Payments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Payments array for specified Payment |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpaymenthistory"></a>
# **GetPaymentHistory**
> HistoryRecords GetPaymentHistory (string xeroTenantId, Guid paymentID)

Retrieves history records of a specific payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPaymentHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var paymentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Payment

            try
            {
                // Retrieves history records of a specific payment
                HistoryRecords result = apiInstance.GetPaymentHistory(xeroTenantId, paymentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetPaymentHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPaymentHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves history records of a specific payment
    ApiResponse<HistoryRecords> response = apiInstance.GetPaymentHistoryWithHttpInfo(xeroTenantId, paymentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetPaymentHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **paymentID** | **Guid** | Unique identifier for a Payment |  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of HistoryRecords array of 0 to N HistoryRecord |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpaymentservices"></a>
# **GetPaymentServices**
> PaymentServices GetPaymentServices (string xeroTenantId)

Retrieves payment services

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPaymentServicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant

            try
            {
                // Retrieves payment services
                PaymentServices result = apiInstance.GetPaymentServices(xeroTenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetPaymentServices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPaymentServicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves payment services
    ApiResponse<PaymentServices> response = apiInstance.GetPaymentServicesWithHttpInfo(xeroTenantId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetPaymentServicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |

### Return type

[**PaymentServices**](PaymentServices.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type PaymentServices array for all PaymentService |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpayments"></a>
# **GetPayments**
> Payments GetPayments (string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? pageSize = null)

Retrieves payments for invoices and credit notes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPaymentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var where = Status=="AUTHORISED";  // string? | Filter by an any element (optional) 
            var order = Amount ASC;  // string? | Order by an any element (optional) 
            var page = 1;  // int? | Up to 100 payments will be returned in a single API call (optional) 
            var pageSize = 100;  // int? | Number of records to retrieve per page (optional) 

            try
            {
                // Retrieves payments for invoices and credit notes
                Payments result = apiInstance.GetPayments(xeroTenantId, ifModifiedSince, where, order, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetPayments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPaymentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves payments for invoices and credit notes
    ApiResponse<Payments> response = apiInstance.GetPaymentsWithHttpInfo(xeroTenantId, ifModifiedSince, where, order, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetPaymentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |
| **page** | **int?** | Up to 100 payments will be returned in a single API call | [optional]  |
| **pageSize** | **int?** | Number of records to retrieve per page | [optional]  |

### Return type

[**Payments**](Payments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Payments array for all Payments |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprepayment"></a>
# **GetPrepayment**
> Prepayments GetPrepayment (string xeroTenantId, Guid prepaymentID)

Allows you to retrieve a specified prepayments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPrepaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var prepaymentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a PrePayment

            try
            {
                // Allows you to retrieve a specified prepayments
                Prepayments result = apiInstance.GetPrepayment(xeroTenantId, prepaymentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetPrepayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPrepaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Allows you to retrieve a specified prepayments
    ApiResponse<Prepayments> response = apiInstance.GetPrepaymentWithHttpInfo(xeroTenantId, prepaymentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetPrepaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **prepaymentID** | **Guid** | Unique identifier for a PrePayment |  |

### Return type

[**Prepayments**](Prepayments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Prepayments array for a specified Prepayment |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprepaymenthistory"></a>
# **GetPrepaymentHistory**
> HistoryRecords GetPrepaymentHistory (string xeroTenantId, Guid prepaymentID)

Retrieves history record for a specific prepayment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPrepaymentHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var prepaymentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a PrePayment

            try
            {
                // Retrieves history record for a specific prepayment
                HistoryRecords result = apiInstance.GetPrepaymentHistory(xeroTenantId, prepaymentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetPrepaymentHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPrepaymentHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves history record for a specific prepayment
    ApiResponse<HistoryRecords> response = apiInstance.GetPrepaymentHistoryWithHttpInfo(xeroTenantId, prepaymentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetPrepaymentHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **prepaymentID** | **Guid** | Unique identifier for a PrePayment |  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of HistoryRecords array of 0 to N HistoryRecord |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprepayments"></a>
# **GetPrepayments**
> Prepayments GetPrepayments (string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? unitdp = null, int? pageSize = null)

Retrieves prepayments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPrepaymentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var where = Status=="AUTHORISED";  // string? | Filter by an any element (optional) 
            var order = Reference ASC;  // string? | Order by an any element (optional) 
            var page = 1;  // int? | e.g. page=1 – Up to 100 prepayments will be returned in a single API call with line items shown for each overpayment (optional) 
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var pageSize = 100;  // int? | Number of records to retrieve per page (optional) 

            try
            {
                // Retrieves prepayments
                Prepayments result = apiInstance.GetPrepayments(xeroTenantId, ifModifiedSince, where, order, page, unitdp, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetPrepayments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPrepaymentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves prepayments
    ApiResponse<Prepayments> response = apiInstance.GetPrepaymentsWithHttpInfo(xeroTenantId, ifModifiedSince, where, order, page, unitdp, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetPrepaymentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |
| **page** | **int?** | e.g. page&#x3D;1 – Up to 100 prepayments will be returned in a single API call with line items shown for each overpayment | [optional]  |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **pageSize** | **int?** | Number of records to retrieve per page | [optional]  |

### Return type

[**Prepayments**](Prepayments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Prepayments array for all Prepayment |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpurchaseorder"></a>
# **GetPurchaseOrder**
> PurchaseOrders GetPurchaseOrder (string xeroTenantId, Guid purchaseOrderID)

Retrieves a specific purchase order using a unique purchase order Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPurchaseOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var purchaseOrderID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Purchase Order

            try
            {
                // Retrieves a specific purchase order using a unique purchase order Id
                PurchaseOrders result = apiInstance.GetPurchaseOrder(xeroTenantId, purchaseOrderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetPurchaseOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPurchaseOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific purchase order using a unique purchase order Id
    ApiResponse<PurchaseOrders> response = apiInstance.GetPurchaseOrderWithHttpInfo(xeroTenantId, purchaseOrderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetPurchaseOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **purchaseOrderID** | **Guid** | Unique identifier for an Purchase Order |  |

### Return type

[**PurchaseOrders**](PurchaseOrders.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type PurchaseOrder array for specified PurchaseOrder |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpurchaseorderaspdf"></a>
# **GetPurchaseOrderAsPdf**
> System.IO.Stream GetPurchaseOrderAsPdf (string xeroTenantId, Guid purchaseOrderID)

Retrieves specific purchase order as PDF files using a unique purchase order Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPurchaseOrderAsPdfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var purchaseOrderID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Purchase Order

            try
            {
                // Retrieves specific purchase order as PDF files using a unique purchase order Id
                System.IO.Stream result = apiInstance.GetPurchaseOrderAsPdf(xeroTenantId, purchaseOrderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetPurchaseOrderAsPdf: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPurchaseOrderAsPdfWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific purchase order as PDF files using a unique purchase order Id
    ApiResponse<System.IO.Stream> response = apiInstance.GetPurchaseOrderAsPdfWithHttpInfo(xeroTenantId, purchaseOrderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetPurchaseOrderAsPdfWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **purchaseOrderID** | **Guid** | Unique identifier for an Purchase Order |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of byte array pdf version of specified Purchase Orders |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpurchaseorderattachmentbyfilename"></a>
# **GetPurchaseOrderAttachmentByFileName**
> System.IO.Stream GetPurchaseOrderAttachmentByFileName (string xeroTenantId, Guid purchaseOrderID, string fileName, string contentType)

Retrieves a specific attachment for a specific purchase order by filename

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPurchaseOrderAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var purchaseOrderID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Purchase Order
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves a specific attachment for a specific purchase order by filename
                System.IO.Stream result = apiInstance.GetPurchaseOrderAttachmentByFileName(xeroTenantId, purchaseOrderID, fileName, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetPurchaseOrderAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPurchaseOrderAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific attachment for a specific purchase order by filename
    ApiResponse<System.IO.Stream> response = apiInstance.GetPurchaseOrderAttachmentByFileNameWithHttpInfo(xeroTenantId, purchaseOrderID, fileName, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetPurchaseOrderAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **purchaseOrderID** | **Guid** | Unique identifier for an Purchase Order |  |
| **fileName** | **string** | Name of the attachment |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for Purchase Order as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpurchaseorderattachmentbyid"></a>
# **GetPurchaseOrderAttachmentById**
> System.IO.Stream GetPurchaseOrderAttachmentById (string xeroTenantId, Guid purchaseOrderID, Guid attachmentID, string contentType)

Retrieves specific attachment for a specific purchase order using a unique attachment Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPurchaseOrderAttachmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var purchaseOrderID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Purchase Order
            var attachmentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Attachment object
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves specific attachment for a specific purchase order using a unique attachment Id
                System.IO.Stream result = apiInstance.GetPurchaseOrderAttachmentById(xeroTenantId, purchaseOrderID, attachmentID, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetPurchaseOrderAttachmentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPurchaseOrderAttachmentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific attachment for a specific purchase order using a unique attachment Id
    ApiResponse<System.IO.Stream> response = apiInstance.GetPurchaseOrderAttachmentByIdWithHttpInfo(xeroTenantId, purchaseOrderID, attachmentID, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetPurchaseOrderAttachmentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **purchaseOrderID** | **Guid** | Unique identifier for an Purchase Order |  |
| **attachmentID** | **Guid** | Unique identifier for Attachment object |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for Account as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpurchaseorderattachments"></a>
# **GetPurchaseOrderAttachments**
> Attachments GetPurchaseOrderAttachments (string xeroTenantId, Guid purchaseOrderID)

Retrieves attachments for a specific purchase order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPurchaseOrderAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var purchaseOrderID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Purchase Order

            try
            {
                // Retrieves attachments for a specific purchase order
                Attachments result = apiInstance.GetPurchaseOrderAttachments(xeroTenantId, purchaseOrderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetPurchaseOrderAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPurchaseOrderAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves attachments for a specific purchase order
    ApiResponse<Attachments> response = apiInstance.GetPurchaseOrderAttachmentsWithHttpInfo(xeroTenantId, purchaseOrderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetPurchaseOrderAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **purchaseOrderID** | **Guid** | Unique identifier for an Purchase Order |  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array of Purchase Orders |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpurchaseorderbynumber"></a>
# **GetPurchaseOrderByNumber**
> PurchaseOrders GetPurchaseOrderByNumber (string xeroTenantId, string purchaseOrderNumber)

Retrieves a specific purchase order using purchase order number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPurchaseOrderByNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var purchaseOrderNumber = PO1234;  // string | Unique identifier for a PurchaseOrder

            try
            {
                // Retrieves a specific purchase order using purchase order number
                PurchaseOrders result = apiInstance.GetPurchaseOrderByNumber(xeroTenantId, purchaseOrderNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetPurchaseOrderByNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPurchaseOrderByNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific purchase order using purchase order number
    ApiResponse<PurchaseOrders> response = apiInstance.GetPurchaseOrderByNumberWithHttpInfo(xeroTenantId, purchaseOrderNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetPurchaseOrderByNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **purchaseOrderNumber** | **string** | Unique identifier for a PurchaseOrder |  |

### Return type

[**PurchaseOrders**](PurchaseOrders.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type PurchaseOrder array for specified PurchaseOrder |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpurchaseorderhistory"></a>
# **GetPurchaseOrderHistory**
> HistoryRecords GetPurchaseOrderHistory (string xeroTenantId, Guid purchaseOrderID)

Retrieves history for a specific purchase order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPurchaseOrderHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var purchaseOrderID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Purchase Order

            try
            {
                // Retrieves history for a specific purchase order
                HistoryRecords result = apiInstance.GetPurchaseOrderHistory(xeroTenantId, purchaseOrderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetPurchaseOrderHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPurchaseOrderHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves history for a specific purchase order
    ApiResponse<HistoryRecords> response = apiInstance.GetPurchaseOrderHistoryWithHttpInfo(xeroTenantId, purchaseOrderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetPurchaseOrderHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **purchaseOrderID** | **Guid** | Unique identifier for an Purchase Order |  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of HistoryRecords array of 0 to N HistoryRecord |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpurchaseorders"></a>
# **GetPurchaseOrders**
> PurchaseOrders GetPurchaseOrders (string xeroTenantId, DateTime? ifModifiedSince = null, string? status = null, string? dateFrom = null, string? dateTo = null, string? order = null, int? page = null, int? pageSize = null)

Retrieves purchase orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPurchaseOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var status = SUBMITTED;  // string? | Filter by purchase order status (optional) 
            var dateFrom = 2019-12-01;  // string? | Filter by purchase order date (e.g. GET https://.../PurchaseOrders?DateFrom=2015-12-01&DateTo=2015-12-31 (optional) 
            var dateTo = 2019-12-31;  // string? | Filter by purchase order date (e.g. GET https://.../PurchaseOrders?DateFrom=2015-12-01&DateTo=2015-12-31 (optional) 
            var order = PurchaseOrderNumber ASC;  // string? | Order by an any element (optional) 
            var page = 1;  // int? | To specify a page, append the page parameter to the URL e.g. ?page=1. If there are 100 records in the response you will need to check if there is any more data by fetching the next page e.g ?page=2 and continuing this process until no more results are returned. (optional) 
            var pageSize = 100;  // int? | Number of records to retrieve per page (optional) 

            try
            {
                // Retrieves purchase orders
                PurchaseOrders result = apiInstance.GetPurchaseOrders(xeroTenantId, ifModifiedSince, status, dateFrom, dateTo, order, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetPurchaseOrders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPurchaseOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves purchase orders
    ApiResponse<PurchaseOrders> response = apiInstance.GetPurchaseOrdersWithHttpInfo(xeroTenantId, ifModifiedSince, status, dateFrom, dateTo, order, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetPurchaseOrdersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **status** | **string?** | Filter by purchase order status | [optional]  |
| **dateFrom** | **string?** | Filter by purchase order date (e.g. GET https://.../PurchaseOrders?DateFrom&#x3D;2015-12-01&amp;DateTo&#x3D;2015-12-31 | [optional]  |
| **dateTo** | **string?** | Filter by purchase order date (e.g. GET https://.../PurchaseOrders?DateFrom&#x3D;2015-12-01&amp;DateTo&#x3D;2015-12-31 | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |
| **page** | **int?** | To specify a page, append the page parameter to the URL e.g. ?page&#x3D;1. If there are 100 records in the response you will need to check if there is any more data by fetching the next page e.g ?page&#x3D;2 and continuing this process until no more results are returned. | [optional]  |
| **pageSize** | **int?** | Number of records to retrieve per page | [optional]  |

### Return type

[**PurchaseOrders**](PurchaseOrders.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type PurchaseOrder array of all PurchaseOrder |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getquote"></a>
# **GetQuote**
> Quotes GetQuote (string xeroTenantId, Guid quoteID)

Retrieves a specific quote using a unique quote Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var quoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Quote

            try
            {
                // Retrieves a specific quote using a unique quote Id
                Quotes result = apiInstance.GetQuote(xeroTenantId, quoteID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetQuote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetQuoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific quote using a unique quote Id
    ApiResponse<Quotes> response = apiInstance.GetQuoteWithHttpInfo(xeroTenantId, quoteID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetQuoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **quoteID** | **Guid** | Unique identifier for an Quote |  |

### Return type

[**Quotes**](Quotes.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Quotes array with specified Quote |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getquoteaspdf"></a>
# **GetQuoteAsPdf**
> System.IO.Stream GetQuoteAsPdf (string xeroTenantId, Guid quoteID)

Retrieves a specific quote as a PDF file using a unique quote Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetQuoteAsPdfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var quoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Quote

            try
            {
                // Retrieves a specific quote as a PDF file using a unique quote Id
                System.IO.Stream result = apiInstance.GetQuoteAsPdf(xeroTenantId, quoteID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetQuoteAsPdf: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetQuoteAsPdfWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific quote as a PDF file using a unique quote Id
    ApiResponse<System.IO.Stream> response = apiInstance.GetQuoteAsPdfWithHttpInfo(xeroTenantId, quoteID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetQuoteAsPdfWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **quoteID** | **Guid** | Unique identifier for an Quote |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of byte array pdf version of specified Quotes |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getquoteattachmentbyfilename"></a>
# **GetQuoteAttachmentByFileName**
> System.IO.Stream GetQuoteAttachmentByFileName (string xeroTenantId, Guid quoteID, string fileName, string contentType)

Retrieves a specific attachment from a specific quote by filename

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetQuoteAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var quoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Quote
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves a specific attachment from a specific quote by filename
                System.IO.Stream result = apiInstance.GetQuoteAttachmentByFileName(xeroTenantId, quoteID, fileName, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetQuoteAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetQuoteAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific attachment from a specific quote by filename
    ApiResponse<System.IO.Stream> response = apiInstance.GetQuoteAttachmentByFileNameWithHttpInfo(xeroTenantId, quoteID, fileName, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetQuoteAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **quoteID** | **Guid** | Unique identifier for an Quote |  |
| **fileName** | **string** | Name of the attachment |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for Quote as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getquoteattachmentbyid"></a>
# **GetQuoteAttachmentById**
> System.IO.Stream GetQuoteAttachmentById (string xeroTenantId, Guid quoteID, Guid attachmentID, string contentType)

Retrieves a specific attachment from a specific quote using a unique attachment Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetQuoteAttachmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var quoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Quote
            var attachmentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Attachment object
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves a specific attachment from a specific quote using a unique attachment Id
                System.IO.Stream result = apiInstance.GetQuoteAttachmentById(xeroTenantId, quoteID, attachmentID, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetQuoteAttachmentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetQuoteAttachmentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific attachment from a specific quote using a unique attachment Id
    ApiResponse<System.IO.Stream> response = apiInstance.GetQuoteAttachmentByIdWithHttpInfo(xeroTenantId, quoteID, attachmentID, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetQuoteAttachmentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **quoteID** | **Guid** | Unique identifier for an Quote |  |
| **attachmentID** | **Guid** | Unique identifier for Attachment object |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for Quote as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getquoteattachments"></a>
# **GetQuoteAttachments**
> Attachments GetQuoteAttachments (string xeroTenantId, Guid quoteID)

Retrieves attachments for a specific quote

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetQuoteAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var quoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Quote

            try
            {
                // Retrieves attachments for a specific quote
                Attachments result = apiInstance.GetQuoteAttachments(xeroTenantId, quoteID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetQuoteAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetQuoteAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves attachments for a specific quote
    ApiResponse<Attachments> response = apiInstance.GetQuoteAttachmentsWithHttpInfo(xeroTenantId, quoteID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetQuoteAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **quoteID** | **Guid** | Unique identifier for an Quote |  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array of Attachment |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getquotehistory"></a>
# **GetQuoteHistory**
> HistoryRecords GetQuoteHistory (string xeroTenantId, Guid quoteID)

Retrieves history records of a specific quote

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetQuoteHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var quoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Quote

            try
            {
                // Retrieves history records of a specific quote
                HistoryRecords result = apiInstance.GetQuoteHistory(xeroTenantId, quoteID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetQuoteHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetQuoteHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves history records of a specific quote
    ApiResponse<HistoryRecords> response = apiInstance.GetQuoteHistoryWithHttpInfo(xeroTenantId, quoteID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetQuoteHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **quoteID** | **Guid** | Unique identifier for an Quote |  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of HistoryRecords array of 0 to N HistoryRecord |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getquotes"></a>
# **GetQuotes**
> Quotes GetQuotes (string xeroTenantId, DateTime? ifModifiedSince = null, DateOnly? dateFrom = null, DateOnly? dateTo = null, DateOnly? expiryDateFrom = null, DateOnly? expiryDateTo = null, Guid? contactID = null, string? status = null, int? page = null, string? order = null, string? quoteNumber = null)

Retrieves sales quotes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetQuotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var dateFrom = 2019-10-31;  // DateOnly? | Filter for quotes after a particular date (optional) 
            var dateTo = 2019-10-31;  // DateOnly? | Filter for quotes before a particular date (optional) 
            var expiryDateFrom = 2019-10-31;  // DateOnly? | Filter for quotes expiring after a particular date (optional) 
            var expiryDateTo = 2019-10-31;  // DateOnly? | Filter for quotes before a particular date (optional) 
            var contactID = 00000000-0000-0000-0000-000000000000;  // Guid? | Filter for quotes belonging to a particular contact (optional) 
            var status = DRAFT;  // string? | Filter for quotes of a particular Status (optional) 
            var page = 1;  // int? | e.g. page=1 – Up to 100 Quotes will be returned in a single API call with line items shown for each quote (optional) 
            var order = Status ASC;  // string? | Order by an any element (optional) 
            var quoteNumber = QU-0001;  // string? | Filter by quote number (e.g. GET https://.../Quotes?QuoteNumber=QU-0001) (optional) 

            try
            {
                // Retrieves sales quotes
                Quotes result = apiInstance.GetQuotes(xeroTenantId, ifModifiedSince, dateFrom, dateTo, expiryDateFrom, expiryDateTo, contactID, status, page, order, quoteNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetQuotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetQuotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves sales quotes
    ApiResponse<Quotes> response = apiInstance.GetQuotesWithHttpInfo(xeroTenantId, ifModifiedSince, dateFrom, dateTo, expiryDateFrom, expiryDateTo, contactID, status, page, order, quoteNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetQuotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **dateFrom** | **DateOnly?** | Filter for quotes after a particular date | [optional]  |
| **dateTo** | **DateOnly?** | Filter for quotes before a particular date | [optional]  |
| **expiryDateFrom** | **DateOnly?** | Filter for quotes expiring after a particular date | [optional]  |
| **expiryDateTo** | **DateOnly?** | Filter for quotes before a particular date | [optional]  |
| **contactID** | **Guid?** | Filter for quotes belonging to a particular contact | [optional]  |
| **status** | **string?** | Filter for quotes of a particular Status | [optional]  |
| **page** | **int?** | e.g. page&#x3D;1 – Up to 100 Quotes will be returned in a single API call with line items shown for each quote | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |
| **quoteNumber** | **string?** | Filter by quote number (e.g. GET https://.../Quotes?QuoteNumber&#x3D;QU-0001) | [optional]  |

### Return type

[**Quotes**](Quotes.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type quotes array with all quotes |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreceipt"></a>
# **GetReceipt**
> Receipts GetReceipt (string xeroTenantId, Guid receiptID, int? unitdp = null)

Retrieves a specific draft expense claim receipt by using a unique receipt Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetReceiptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var receiptID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Receipt
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 

            try
            {
                // Retrieves a specific draft expense claim receipt by using a unique receipt Id
                Receipts result = apiInstance.GetReceipt(xeroTenantId, receiptID, unitdp);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetReceipt: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReceiptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific draft expense claim receipt by using a unique receipt Id
    ApiResponse<Receipts> response = apiInstance.GetReceiptWithHttpInfo(xeroTenantId, receiptID, unitdp);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetReceiptWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **receiptID** | **Guid** | Unique identifier for a Receipt |  |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |

### Return type

[**Receipts**](Receipts.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Receipts array for a specified Receipt |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreceiptattachmentbyfilename"></a>
# **GetReceiptAttachmentByFileName**
> System.IO.Stream GetReceiptAttachmentByFileName (string xeroTenantId, Guid receiptID, string fileName, string contentType)

Retrieves a specific attachment from a specific expense claim receipts by file name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetReceiptAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var receiptID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Receipt
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves a specific attachment from a specific expense claim receipts by file name
                System.IO.Stream result = apiInstance.GetReceiptAttachmentByFileName(xeroTenantId, receiptID, fileName, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetReceiptAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReceiptAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific attachment from a specific expense claim receipts by file name
    ApiResponse<System.IO.Stream> response = apiInstance.GetReceiptAttachmentByFileNameWithHttpInfo(xeroTenantId, receiptID, fileName, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetReceiptAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **receiptID** | **Guid** | Unique identifier for a Receipt |  |
| **fileName** | **string** | Name of the attachment |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for Receipt as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreceiptattachmentbyid"></a>
# **GetReceiptAttachmentById**
> System.IO.Stream GetReceiptAttachmentById (string xeroTenantId, Guid receiptID, Guid attachmentID, string contentType)

Retrieves a specific attachments from a specific expense claim receipts by using a unique attachment Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetReceiptAttachmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var receiptID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Receipt
            var attachmentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Attachment object
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves a specific attachments from a specific expense claim receipts by using a unique attachment Id
                System.IO.Stream result = apiInstance.GetReceiptAttachmentById(xeroTenantId, receiptID, attachmentID, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetReceiptAttachmentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReceiptAttachmentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific attachments from a specific expense claim receipts by using a unique attachment Id
    ApiResponse<System.IO.Stream> response = apiInstance.GetReceiptAttachmentByIdWithHttpInfo(xeroTenantId, receiptID, attachmentID, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetReceiptAttachmentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **receiptID** | **Guid** | Unique identifier for a Receipt |  |
| **attachmentID** | **Guid** | Unique identifier for Attachment object |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for Receipt as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreceiptattachments"></a>
# **GetReceiptAttachments**
> Attachments GetReceiptAttachments (string xeroTenantId, Guid receiptID)

Retrieves attachments for a specific expense claim receipt

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetReceiptAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var receiptID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Receipt

            try
            {
                // Retrieves attachments for a specific expense claim receipt
                Attachments result = apiInstance.GetReceiptAttachments(xeroTenantId, receiptID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetReceiptAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReceiptAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves attachments for a specific expense claim receipt
    ApiResponse<Attachments> response = apiInstance.GetReceiptAttachmentsWithHttpInfo(xeroTenantId, receiptID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetReceiptAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **receiptID** | **Guid** | Unique identifier for a Receipt |  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array of Attachments for a specified Receipt |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreceipthistory"></a>
# **GetReceiptHistory**
> HistoryRecords GetReceiptHistory (string xeroTenantId, Guid receiptID)

Retrieves a history record for a specific receipt

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetReceiptHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var receiptID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Receipt

            try
            {
                // Retrieves a history record for a specific receipt
                HistoryRecords result = apiInstance.GetReceiptHistory(xeroTenantId, receiptID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetReceiptHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReceiptHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a history record for a specific receipt
    ApiResponse<HistoryRecords> response = apiInstance.GetReceiptHistoryWithHttpInfo(xeroTenantId, receiptID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetReceiptHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **receiptID** | **Guid** | Unique identifier for a Receipt |  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of HistoryRecords array of 0 to N HistoryRecord |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreceipts"></a>
# **GetReceipts**
> Receipts GetReceipts (string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? unitdp = null)

Retrieves draft expense claim receipts for any user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetReceiptsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var where = Status=="DRAFT";  // string? | Filter by an any element (optional) 
            var order = ReceiptNumber ASC;  // string? | Order by an any element (optional) 
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 

            try
            {
                // Retrieves draft expense claim receipts for any user
                Receipts result = apiInstance.GetReceipts(xeroTenantId, ifModifiedSince, where, order, unitdp);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetReceipts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReceiptsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves draft expense claim receipts for any user
    ApiResponse<Receipts> response = apiInstance.GetReceiptsWithHttpInfo(xeroTenantId, ifModifiedSince, where, order, unitdp);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetReceiptsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |

### Return type

[**Receipts**](Receipts.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Receipts array for all Receipt |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrepeatinginvoice"></a>
# **GetRepeatingInvoice**
> RepeatingInvoices GetRepeatingInvoice (string xeroTenantId, Guid repeatingInvoiceID)

Retrieves a specific repeating invoice by using a unique repeating invoice Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetRepeatingInvoiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var repeatingInvoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Repeating Invoice

            try
            {
                // Retrieves a specific repeating invoice by using a unique repeating invoice Id
                RepeatingInvoices result = apiInstance.GetRepeatingInvoice(xeroTenantId, repeatingInvoiceID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetRepeatingInvoice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRepeatingInvoiceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific repeating invoice by using a unique repeating invoice Id
    ApiResponse<RepeatingInvoices> response = apiInstance.GetRepeatingInvoiceWithHttpInfo(xeroTenantId, repeatingInvoiceID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetRepeatingInvoiceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **repeatingInvoiceID** | **Guid** | Unique identifier for a Repeating Invoice |  |

### Return type

[**RepeatingInvoices**](RepeatingInvoices.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Repeating Invoices array with a specified Repeating Invoice |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrepeatinginvoiceattachmentbyfilename"></a>
# **GetRepeatingInvoiceAttachmentByFileName**
> System.IO.Stream GetRepeatingInvoiceAttachmentByFileName (string xeroTenantId, Guid repeatingInvoiceID, string fileName, string contentType)

Retrieves a specific attachment from a specific repeating invoices by file name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetRepeatingInvoiceAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var repeatingInvoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Repeating Invoice
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves a specific attachment from a specific repeating invoices by file name
                System.IO.Stream result = apiInstance.GetRepeatingInvoiceAttachmentByFileName(xeroTenantId, repeatingInvoiceID, fileName, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetRepeatingInvoiceAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRepeatingInvoiceAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific attachment from a specific repeating invoices by file name
    ApiResponse<System.IO.Stream> response = apiInstance.GetRepeatingInvoiceAttachmentByFileNameWithHttpInfo(xeroTenantId, repeatingInvoiceID, fileName, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetRepeatingInvoiceAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **repeatingInvoiceID** | **Guid** | Unique identifier for a Repeating Invoice |  |
| **fileName** | **string** | Name of the attachment |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for Repeating Invoice as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrepeatinginvoiceattachmentbyid"></a>
# **GetRepeatingInvoiceAttachmentById**
> System.IO.Stream GetRepeatingInvoiceAttachmentById (string xeroTenantId, Guid repeatingInvoiceID, Guid attachmentID, string contentType)

Retrieves a specific attachment from a specific repeating invoice

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetRepeatingInvoiceAttachmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var repeatingInvoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Repeating Invoice
            var attachmentID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Attachment object
            var contentType = image/jpg;  // string | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf

            try
            {
                // Retrieves a specific attachment from a specific repeating invoice
                System.IO.Stream result = apiInstance.GetRepeatingInvoiceAttachmentById(xeroTenantId, repeatingInvoiceID, attachmentID, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetRepeatingInvoiceAttachmentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRepeatingInvoiceAttachmentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific attachment from a specific repeating invoice
    ApiResponse<System.IO.Stream> response = apiInstance.GetRepeatingInvoiceAttachmentByIdWithHttpInfo(xeroTenantId, repeatingInvoiceID, attachmentID, contentType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetRepeatingInvoiceAttachmentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **repeatingInvoiceID** | **Guid** | Unique identifier for a Repeating Invoice |  |
| **attachmentID** | **Guid** | Unique identifier for Attachment object |  |
| **contentType** | **string** | The mime type of the attachment file you are retrieving i.e image/jpg, application/pdf |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of attachment for Repeating Invoice as binary data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrepeatinginvoiceattachments"></a>
# **GetRepeatingInvoiceAttachments**
> Attachments GetRepeatingInvoiceAttachments (string xeroTenantId, Guid repeatingInvoiceID)

Retrieves attachments from a specific repeating invoice

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetRepeatingInvoiceAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var repeatingInvoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Repeating Invoice

            try
            {
                // Retrieves attachments from a specific repeating invoice
                Attachments result = apiInstance.GetRepeatingInvoiceAttachments(xeroTenantId, repeatingInvoiceID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetRepeatingInvoiceAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRepeatingInvoiceAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves attachments from a specific repeating invoice
    ApiResponse<Attachments> response = apiInstance.GetRepeatingInvoiceAttachmentsWithHttpInfo(xeroTenantId, repeatingInvoiceID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetRepeatingInvoiceAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **repeatingInvoiceID** | **Guid** | Unique identifier for a Repeating Invoice |  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array with all Attachments for a specified Repeating Invoice |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrepeatinginvoicehistory"></a>
# **GetRepeatingInvoiceHistory**
> HistoryRecords GetRepeatingInvoiceHistory (string xeroTenantId, Guid repeatingInvoiceID)

Retrieves history record for a specific repeating invoice

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetRepeatingInvoiceHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var repeatingInvoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Repeating Invoice

            try
            {
                // Retrieves history record for a specific repeating invoice
                HistoryRecords result = apiInstance.GetRepeatingInvoiceHistory(xeroTenantId, repeatingInvoiceID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetRepeatingInvoiceHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRepeatingInvoiceHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves history record for a specific repeating invoice
    ApiResponse<HistoryRecords> response = apiInstance.GetRepeatingInvoiceHistoryWithHttpInfo(xeroTenantId, repeatingInvoiceID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetRepeatingInvoiceHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **repeatingInvoiceID** | **Guid** | Unique identifier for a Repeating Invoice |  |

### Return type

[**HistoryRecords**](HistoryRecords.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of HistoryRecords array of 0 to N HistoryRecord |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrepeatinginvoices"></a>
# **GetRepeatingInvoices**
> RepeatingInvoices GetRepeatingInvoices (string xeroTenantId, string? where = null, string? order = null)

Retrieves repeating invoices

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetRepeatingInvoicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var where = Status=="DRAFT";  // string? | Filter by an any element (optional) 
            var order = Total ASC;  // string? | Order by an any element (optional) 

            try
            {
                // Retrieves repeating invoices
                RepeatingInvoices result = apiInstance.GetRepeatingInvoices(xeroTenantId, where, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetRepeatingInvoices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRepeatingInvoicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves repeating invoices
    ApiResponse<RepeatingInvoices> response = apiInstance.GetRepeatingInvoicesWithHttpInfo(xeroTenantId, where, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetRepeatingInvoicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |

### Return type

[**RepeatingInvoices**](RepeatingInvoices.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Repeating Invoices array for all Repeating Invoice |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreportagedpayablesbycontact"></a>
# **GetReportAgedPayablesByContact**
> ReportWithRows GetReportAgedPayablesByContact (string xeroTenantId, Guid contactId, DateOnly? date = null, DateOnly? fromDate = null, DateOnly? toDate = null)

Retrieves report for aged payables by contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetReportAgedPayablesByContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactId = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Contact
            var date = 2019-10-31;  // DateOnly? | The date of the Aged Payables By Contact report (optional) 
            var fromDate = 2019-10-31;  // DateOnly? | filter by the from date of the report e.g. 2021-02-01 (optional) 
            var toDate = 2019-10-31;  // DateOnly? | filter by the to date of the report e.g. 2021-02-28 (optional) 

            try
            {
                // Retrieves report for aged payables by contact
                ReportWithRows result = apiInstance.GetReportAgedPayablesByContact(xeroTenantId, contactId, date, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetReportAgedPayablesByContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReportAgedPayablesByContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves report for aged payables by contact
    ApiResponse<ReportWithRows> response = apiInstance.GetReportAgedPayablesByContactWithHttpInfo(xeroTenantId, contactId, date, fromDate, toDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetReportAgedPayablesByContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactId** | **Guid** | Unique identifier for a Contact |  |
| **date** | **DateOnly?** | The date of the Aged Payables By Contact report | [optional]  |
| **fromDate** | **DateOnly?** | filter by the from date of the report e.g. 2021-02-01 | [optional]  |
| **toDate** | **DateOnly?** | filter by the to date of the report e.g. 2021-02-28 | [optional]  |

### Return type

[**ReportWithRows**](ReportWithRows.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type ReportWithRows |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreportagedreceivablesbycontact"></a>
# **GetReportAgedReceivablesByContact**
> ReportWithRows GetReportAgedReceivablesByContact (string xeroTenantId, Guid contactId, DateOnly? date = null, DateOnly? fromDate = null, DateOnly? toDate = null)

Retrieves report for aged receivables by contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetReportAgedReceivablesByContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactId = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Contact
            var date = 2019-10-31;  // DateOnly? | The date of the Aged Receivables By Contact report (optional) 
            var fromDate = 2019-10-31;  // DateOnly? | filter by the from date of the report e.g. 2021-02-01 (optional) 
            var toDate = 2019-10-31;  // DateOnly? | filter by the to date of the report e.g. 2021-02-28 (optional) 

            try
            {
                // Retrieves report for aged receivables by contact
                ReportWithRows result = apiInstance.GetReportAgedReceivablesByContact(xeroTenantId, contactId, date, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetReportAgedReceivablesByContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReportAgedReceivablesByContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves report for aged receivables by contact
    ApiResponse<ReportWithRows> response = apiInstance.GetReportAgedReceivablesByContactWithHttpInfo(xeroTenantId, contactId, date, fromDate, toDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetReportAgedReceivablesByContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactId** | **Guid** | Unique identifier for a Contact |  |
| **date** | **DateOnly?** | The date of the Aged Receivables By Contact report | [optional]  |
| **fromDate** | **DateOnly?** | filter by the from date of the report e.g. 2021-02-01 | [optional]  |
| **toDate** | **DateOnly?** | filter by the to date of the report e.g. 2021-02-28 | [optional]  |

### Return type

[**ReportWithRows**](ReportWithRows.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type ReportWithRows |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreportbalancesheet"></a>
# **GetReportBalanceSheet**
> ReportWithRows GetReportBalanceSheet (string xeroTenantId, DateOnly? date = null, int? periods = null, string? timeframe = null, string? trackingOptionID1 = null, string? trackingOptionID2 = null, bool? standardLayout = null, bool? paymentsOnly = null)

Retrieves report for balancesheet

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetReportBalanceSheetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var date = 2019-11-01;  // DateOnly? | The date of the Balance Sheet report (optional) 
            var periods = 3;  // int? | The number of periods for the Balance Sheet report (optional) 
            var timeframe = MONTH;  // string? | The period size to compare to (MONTH, QUARTER, YEAR) (optional) 
            var trackingOptionID1 = 00000000-0000-0000-0000-000000000000;  // string? | The tracking option 1 for the Balance Sheet report (optional) 
            var trackingOptionID2 = 00000000-0000-0000-0000-000000000000;  // string? | The tracking option 2 for the Balance Sheet report (optional) 
            var standardLayout = true;  // bool? | The standard layout boolean for the Balance Sheet report (optional) 
            var paymentsOnly = false;  // bool? | return a cash basis for the Balance Sheet report (optional) 

            try
            {
                // Retrieves report for balancesheet
                ReportWithRows result = apiInstance.GetReportBalanceSheet(xeroTenantId, date, periods, timeframe, trackingOptionID1, trackingOptionID2, standardLayout, paymentsOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetReportBalanceSheet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReportBalanceSheetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves report for balancesheet
    ApiResponse<ReportWithRows> response = apiInstance.GetReportBalanceSheetWithHttpInfo(xeroTenantId, date, periods, timeframe, trackingOptionID1, trackingOptionID2, standardLayout, paymentsOnly);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetReportBalanceSheetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **date** | **DateOnly?** | The date of the Balance Sheet report | [optional]  |
| **periods** | **int?** | The number of periods for the Balance Sheet report | [optional]  |
| **timeframe** | **string?** | The period size to compare to (MONTH, QUARTER, YEAR) | [optional]  |
| **trackingOptionID1** | **string?** | The tracking option 1 for the Balance Sheet report | [optional]  |
| **trackingOptionID2** | **string?** | The tracking option 2 for the Balance Sheet report | [optional]  |
| **standardLayout** | **bool?** | The standard layout boolean for the Balance Sheet report | [optional]  |
| **paymentsOnly** | **bool?** | return a cash basis for the Balance Sheet report | [optional]  |

### Return type

[**ReportWithRows**](ReportWithRows.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type ReportWithRows |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreportbanksummary"></a>
# **GetReportBankSummary**
> ReportWithRows GetReportBankSummary (string xeroTenantId, DateOnly? fromDate = null, DateOnly? toDate = null)

Retrieves report for bank summary

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetReportBankSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var fromDate = 2019-10-31;  // DateOnly? | filter by the from date of the report e.g. 2021-02-01 (optional) 
            var toDate = 2019-10-31;  // DateOnly? | filter by the to date of the report e.g. 2021-02-28 (optional) 

            try
            {
                // Retrieves report for bank summary
                ReportWithRows result = apiInstance.GetReportBankSummary(xeroTenantId, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetReportBankSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReportBankSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves report for bank summary
    ApiResponse<ReportWithRows> response = apiInstance.GetReportBankSummaryWithHttpInfo(xeroTenantId, fromDate, toDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetReportBankSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **fromDate** | **DateOnly?** | filter by the from date of the report e.g. 2021-02-01 | [optional]  |
| **toDate** | **DateOnly?** | filter by the to date of the report e.g. 2021-02-28 | [optional]  |

### Return type

[**ReportWithRows**](ReportWithRows.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type ReportWithRows |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreportbudgetsummary"></a>
# **GetReportBudgetSummary**
> ReportWithRows GetReportBudgetSummary (string xeroTenantId, DateOnly? date = null, int? periods = null, int? timeframe = null)

Retrieves report for budget summary

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetReportBudgetSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var date = 2019-03-31;  // DateOnly? | The date for the Bank Summary report e.g. 2018-03-31 (optional) 
            var periods = 2;  // int? | The number of periods to compare (integer between 1 and 12) (optional) 
            var timeframe = 3;  // int? | The period size to compare to (1=month, 3=quarter, 12=year) (optional) 

            try
            {
                // Retrieves report for budget summary
                ReportWithRows result = apiInstance.GetReportBudgetSummary(xeroTenantId, date, periods, timeframe);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetReportBudgetSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReportBudgetSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves report for budget summary
    ApiResponse<ReportWithRows> response = apiInstance.GetReportBudgetSummaryWithHttpInfo(xeroTenantId, date, periods, timeframe);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetReportBudgetSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **date** | **DateOnly?** | The date for the Bank Summary report e.g. 2018-03-31 | [optional]  |
| **periods** | **int?** | The number of periods to compare (integer between 1 and 12) | [optional]  |
| **timeframe** | **int?** | The period size to compare to (1&#x3D;month, 3&#x3D;quarter, 12&#x3D;year) | [optional]  |

### Return type

[**ReportWithRows**](ReportWithRows.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | success- return a Report with Rows object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreportexecutivesummary"></a>
# **GetReportExecutiveSummary**
> ReportWithRows GetReportExecutiveSummary (string xeroTenantId, DateOnly? date = null)

Retrieves report for executive summary

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetReportExecutiveSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var date = 2019-03-31;  // DateOnly? | The date for the Bank Summary report e.g. 2018-03-31 (optional) 

            try
            {
                // Retrieves report for executive summary
                ReportWithRows result = apiInstance.GetReportExecutiveSummary(xeroTenantId, date);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetReportExecutiveSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReportExecutiveSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves report for executive summary
    ApiResponse<ReportWithRows> response = apiInstance.GetReportExecutiveSummaryWithHttpInfo(xeroTenantId, date);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetReportExecutiveSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **date** | **DateOnly?** | The date for the Bank Summary report e.g. 2018-03-31 | [optional]  |

### Return type

[**ReportWithRows**](ReportWithRows.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type ReportWithRows |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreportfromid"></a>
# **GetReportFromId**
> ReportWithRows GetReportFromId (string xeroTenantId, string reportID)

Retrieves a specific report using a unique ReportID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetReportFromIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var reportID = 00000000-0000-0000-0000-000000000000;  // string | Unique identifier for a Report

            try
            {
                // Retrieves a specific report using a unique ReportID
                ReportWithRows result = apiInstance.GetReportFromId(xeroTenantId, reportID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetReportFromId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReportFromIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific report using a unique ReportID
    ApiResponse<ReportWithRows> response = apiInstance.GetReportFromIdWithHttpInfo(xeroTenantId, reportID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetReportFromIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **reportID** | **string** | Unique identifier for a Report |  |

### Return type

[**ReportWithRows**](ReportWithRows.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type ReportWithRows |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreportprofitandloss"></a>
# **GetReportProfitAndLoss**
> ReportWithRows GetReportProfitAndLoss (string xeroTenantId, DateOnly? fromDate = null, DateOnly? toDate = null, int? periods = null, string? timeframe = null, string? trackingCategoryID = null, string? trackingCategoryID2 = null, string? trackingOptionID = null, string? trackingOptionID2 = null, bool? standardLayout = null, bool? paymentsOnly = null)

Retrieves report for profit and loss

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetReportProfitAndLossExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var fromDate = 2019-10-31;  // DateOnly? | filter by the from date of the report e.g. 2021-02-01 (optional) 
            var toDate = 2019-10-31;  // DateOnly? | filter by the to date of the report e.g. 2021-02-28 (optional) 
            var periods = 3;  // int? | The number of periods to compare (integer between 1 and 12) (optional) 
            var timeframe = MONTH;  // string? | The period size to compare to (MONTH, QUARTER, YEAR) (optional) 
            var trackingCategoryID = 00000000-0000-0000-0000-000000000000;  // string? | The trackingCategory 1 for the ProfitAndLoss report (optional) 
            var trackingCategoryID2 = 00000000-0000-0000-0000-000000000000;  // string? | The trackingCategory 2 for the ProfitAndLoss report (optional) 
            var trackingOptionID = 00000000-0000-0000-0000-000000000000;  // string? | The tracking option 1 for the ProfitAndLoss report (optional) 
            var trackingOptionID2 = 00000000-0000-0000-0000-000000000000;  // string? | The tracking option 2 for the ProfitAndLoss report (optional) 
            var standardLayout = true;  // bool? | Return the standard layout for the ProfitAndLoss report (optional) 
            var paymentsOnly = false;  // bool? | Return cash only basis for the ProfitAndLoss report (optional) 

            try
            {
                // Retrieves report for profit and loss
                ReportWithRows result = apiInstance.GetReportProfitAndLoss(xeroTenantId, fromDate, toDate, periods, timeframe, trackingCategoryID, trackingCategoryID2, trackingOptionID, trackingOptionID2, standardLayout, paymentsOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetReportProfitAndLoss: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReportProfitAndLossWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves report for profit and loss
    ApiResponse<ReportWithRows> response = apiInstance.GetReportProfitAndLossWithHttpInfo(xeroTenantId, fromDate, toDate, periods, timeframe, trackingCategoryID, trackingCategoryID2, trackingOptionID, trackingOptionID2, standardLayout, paymentsOnly);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetReportProfitAndLossWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **fromDate** | **DateOnly?** | filter by the from date of the report e.g. 2021-02-01 | [optional]  |
| **toDate** | **DateOnly?** | filter by the to date of the report e.g. 2021-02-28 | [optional]  |
| **periods** | **int?** | The number of periods to compare (integer between 1 and 12) | [optional]  |
| **timeframe** | **string?** | The period size to compare to (MONTH, QUARTER, YEAR) | [optional]  |
| **trackingCategoryID** | **string?** | The trackingCategory 1 for the ProfitAndLoss report | [optional]  |
| **trackingCategoryID2** | **string?** | The trackingCategory 2 for the ProfitAndLoss report | [optional]  |
| **trackingOptionID** | **string?** | The tracking option 1 for the ProfitAndLoss report | [optional]  |
| **trackingOptionID2** | **string?** | The tracking option 2 for the ProfitAndLoss report | [optional]  |
| **standardLayout** | **bool?** | Return the standard layout for the ProfitAndLoss report | [optional]  |
| **paymentsOnly** | **bool?** | Return cash only basis for the ProfitAndLoss report | [optional]  |

### Return type

[**ReportWithRows**](ReportWithRows.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type ReportWithRows |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreporttenninetynine"></a>
# **GetReportTenNinetyNine**
> Reports GetReportTenNinetyNine (string xeroTenantId, string? reportYear = null)

Retrieve reports for 1099

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetReportTenNinetyNineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var reportYear = 2019;  // string? | The year of the 1099 report (optional) 

            try
            {
                // Retrieve reports for 1099
                Reports result = apiInstance.GetReportTenNinetyNine(xeroTenantId, reportYear);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetReportTenNinetyNine: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReportTenNinetyNineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve reports for 1099
    ApiResponse<Reports> response = apiInstance.GetReportTenNinetyNineWithHttpInfo(xeroTenantId, reportYear);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetReportTenNinetyNineWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **reportYear** | **string?** | The year of the 1099 report | [optional]  |

### Return type

[**Reports**](Reports.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Reports |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreporttrialbalance"></a>
# **GetReportTrialBalance**
> ReportWithRows GetReportTrialBalance (string xeroTenantId, DateOnly? date = null, bool? paymentsOnly = null)

Retrieves report for trial balance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetReportTrialBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var date = 2019-10-31;  // DateOnly? | The date for the Trial Balance report e.g. 2018-03-31 (optional) 
            var paymentsOnly = true;  // bool? | Return cash only basis for the Trial Balance report (optional) 

            try
            {
                // Retrieves report for trial balance
                ReportWithRows result = apiInstance.GetReportTrialBalance(xeroTenantId, date, paymentsOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetReportTrialBalance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReportTrialBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves report for trial balance
    ApiResponse<ReportWithRows> response = apiInstance.GetReportTrialBalanceWithHttpInfo(xeroTenantId, date, paymentsOnly);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetReportTrialBalanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **date** | **DateOnly?** | The date for the Trial Balance report e.g. 2018-03-31 | [optional]  |
| **paymentsOnly** | **bool?** | Return cash only basis for the Trial Balance report | [optional]  |

### Return type

[**ReportWithRows**](ReportWithRows.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type ReportWithRows |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreportslist"></a>
# **GetReportsList**
> ReportWithRows GetReportsList (string xeroTenantId)

Retrieves a list of the organistaions unique reports that require a uuid to fetch

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetReportsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant

            try
            {
                // Retrieves a list of the organistaions unique reports that require a uuid to fetch
                ReportWithRows result = apiInstance.GetReportsList(xeroTenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetReportsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReportsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of the organistaions unique reports that require a uuid to fetch
    ApiResponse<ReportWithRows> response = apiInstance.GetReportsListWithHttpInfo(xeroTenantId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetReportsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |

### Return type

[**ReportWithRows**](ReportWithRows.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type ReportWithRows |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettaxratebytaxtype"></a>
# **GetTaxRateByTaxType**
> TaxRates GetTaxRateByTaxType (string xeroTenantId, string taxType)

Retrieves a specific tax rate according to given TaxType code

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetTaxRateByTaxTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var taxType = INPUT2;  // string | A valid TaxType code

            try
            {
                // Retrieves a specific tax rate according to given TaxType code
                TaxRates result = apiInstance.GetTaxRateByTaxType(xeroTenantId, taxType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetTaxRateByTaxType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTaxRateByTaxTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific tax rate according to given TaxType code
    ApiResponse<TaxRates> response = apiInstance.GetTaxRateByTaxTypeWithHttpInfo(xeroTenantId, taxType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetTaxRateByTaxTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **taxType** | **string** | A valid TaxType code |  |

### Return type

[**TaxRates**](TaxRates.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type TaxRates array with one TaxRate |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettaxrates"></a>
# **GetTaxRates**
> TaxRates GetTaxRates (string xeroTenantId, string? where = null, string? order = null)

Retrieves tax rates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetTaxRatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var where = Status=="ACTIVE";  // string? | Filter by an any element (optional) 
            var order = Name ASC;  // string? | Order by an any element (optional) 

            try
            {
                // Retrieves tax rates
                TaxRates result = apiInstance.GetTaxRates(xeroTenantId, where, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetTaxRates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTaxRatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves tax rates
    ApiResponse<TaxRates> response = apiInstance.GetTaxRatesWithHttpInfo(xeroTenantId, where, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetTaxRatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |

### Return type

[**TaxRates**](TaxRates.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type TaxRates array with TaxRates |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettrackingcategories"></a>
# **GetTrackingCategories**
> TrackingCategories GetTrackingCategories (string xeroTenantId, string? where = null, string? order = null, bool? includeArchived = null)

Retrieves tracking categories and options

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetTrackingCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var where = Status=="ACTIVE";  // string? | Filter by an any element (optional) 
            var order = Name ASC;  // string? | Order by an any element (optional) 
            var includeArchived = true;  // bool? | e.g. includeArchived=true - Categories and options with a status of ARCHIVED will be included in the response (optional) 

            try
            {
                // Retrieves tracking categories and options
                TrackingCategories result = apiInstance.GetTrackingCategories(xeroTenantId, where, order, includeArchived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetTrackingCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTrackingCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves tracking categories and options
    ApiResponse<TrackingCategories> response = apiInstance.GetTrackingCategoriesWithHttpInfo(xeroTenantId, where, order, includeArchived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetTrackingCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |
| **includeArchived** | **bool?** | e.g. includeArchived&#x3D;true - Categories and options with a status of ARCHIVED will be included in the response | [optional]  |

### Return type

[**TrackingCategories**](TrackingCategories.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type TrackingCategories array of TrackingCategory |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettrackingcategory"></a>
# **GetTrackingCategory**
> TrackingCategories GetTrackingCategory (string xeroTenantId, Guid trackingCategoryID)

Retrieves specific tracking categories and options using a unique tracking category Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetTrackingCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var trackingCategoryID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a TrackingCategory

            try
            {
                // Retrieves specific tracking categories and options using a unique tracking category Id
                TrackingCategories result = apiInstance.GetTrackingCategory(xeroTenantId, trackingCategoryID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetTrackingCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTrackingCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific tracking categories and options using a unique tracking category Id
    ApiResponse<TrackingCategories> response = apiInstance.GetTrackingCategoryWithHttpInfo(xeroTenantId, trackingCategoryID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetTrackingCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **trackingCategoryID** | **Guid** | Unique identifier for a TrackingCategory |  |

### Return type

[**TrackingCategories**](TrackingCategories.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type TrackingCategories array of specified TrackingCategory |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuser"></a>
# **GetUser**
> Users GetUser (string xeroTenantId, Guid userID)

Retrieves a specific user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var userID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a User

            try
            {
                // Retrieves a specific user
                Users result = apiInstance.GetUser(xeroTenantId, userID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific user
    ApiResponse<Users> response = apiInstance.GetUserWithHttpInfo(xeroTenantId, userID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **userID** | **Guid** | Unique identifier for a User |  |

### Return type

[**Users**](Users.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Users array of specified User |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getusers"></a>
# **GetUsers**
> Users GetUsers (string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null)

Retrieves users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var ifModifiedSince = 2020-02-06T12:17:43.202-08:00;  // DateTime? | Only records created or modified since this timestamp will be returned (optional) 
            var where = IsSubscriber==true;  // string? | Filter by an any element (optional) 
            var order = LastName ASC;  // string? | Order by an any element (optional) 

            try
            {
                // Retrieves users
                Users result = apiInstance.GetUsers(xeroTenantId, ifModifiedSince, where, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.GetUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves users
    ApiResponse<Users> response = apiInstance.GetUsersWithHttpInfo(xeroTenantId, ifModifiedSince, where, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.GetUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **ifModifiedSince** | **DateTime?** | Only records created or modified since this timestamp will be returned | [optional]  |
| **where** | **string?** | Filter by an any element | [optional]  |
| **order** | **string?** | Order by an any element | [optional]  |

### Return type

[**Users**](Users.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Users array of all User |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postsetup"></a>
# **PostSetup**
> ImportSummaryObject PostSetup (string xeroTenantId, Setup setup, string? idempotencyKey = null)

Sets the chart of accounts, the conversion date and conversion balances

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostSetupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var setup = new Setup(); // Setup | Object including an accounts array, a conversion balances array and a conversion date object in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Sets the chart of accounts, the conversion date and conversion balances
                ImportSummaryObject result = apiInstance.PostSetup(xeroTenantId, setup, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.PostSetup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostSetupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets the chart of accounts, the conversion date and conversion balances
    ApiResponse<ImportSummaryObject> response = apiInstance.PostSetupWithHttpInfo(xeroTenantId, setup, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.PostSetupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **setup** | [**Setup**](Setup.md) | Object including an accounts array, a conversion balances array and a conversion date object in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**ImportSummaryObject**](ImportSummaryObject.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - returns a summary of the chart of accounts updates |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateaccount"></a>
# **UpdateAccount**
> Accounts UpdateAccount (string xeroTenantId, Guid accountID, Accounts accounts, string? idempotencyKey = null)

Updates a chart of accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var accountID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Account object
            var accounts = new Accounts(); // Accounts | Request of type Accounts array with one Account
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a chart of accounts
                Accounts result = apiInstance.UpdateAccount(xeroTenantId, accountID, accounts, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a chart of accounts
    ApiResponse<Accounts> response = apiInstance.UpdateAccountWithHttpInfo(xeroTenantId, accountID, accounts, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **accountID** | **Guid** | Unique identifier for Account object |  |
| **accounts** | [**Accounts**](Accounts.md) | Request of type Accounts array with one Account |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Accounts**](Accounts.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - update existing Account and return response of type Accounts array with updated Account |  -  |
| **400** | Validation Error - some data was incorrect returns response of type Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateaccountattachmentbyfilename"></a>
# **UpdateAccountAttachmentByFileName**
> Attachments UpdateAccountAttachmentByFileName (string xeroTenantId, Guid accountID, string fileName, byte[] body, string? idempotencyKey = null)

Updates attachment on a specific account by filename

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateAccountAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var accountID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for Account object
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates attachment on a specific account by filename
                Attachments result = apiInstance.UpdateAccountAttachmentByFileName(xeroTenantId, accountID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateAccountAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAccountAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates attachment on a specific account by filename
    ApiResponse<Attachments> response = apiInstance.UpdateAccountAttachmentByFileNameWithHttpInfo(xeroTenantId, accountID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateAccountAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **accountID** | **Guid** | Unique identifier for Account object |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array of Attachment |  -  |
| **400** | Validation Error - some data was incorrect returns response of type Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatebanktransaction"></a>
# **UpdateBankTransaction**
> BankTransactions UpdateBankTransaction (string xeroTenantId, Guid bankTransactionID, BankTransactions bankTransactions, int? unitdp = null, string? idempotencyKey = null)

Updates a single spent or received money transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateBankTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransactionID = 00000000-0000-0000-0000-000000000000;  // Guid | Xero generated unique identifier for a bank transaction
            var bankTransactions = new BankTransactions(); // BankTransactions | 
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a single spent or received money transaction
                BankTransactions result = apiInstance.UpdateBankTransaction(xeroTenantId, bankTransactionID, bankTransactions, unitdp, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateBankTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateBankTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a single spent or received money transaction
    ApiResponse<BankTransactions> response = apiInstance.UpdateBankTransactionWithHttpInfo(xeroTenantId, bankTransactionID, bankTransactions, unitdp, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateBankTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransactionID** | **Guid** | Xero generated unique identifier for a bank transaction |  |
| **bankTransactions** | [**BankTransactions**](BankTransactions.md) |  |  |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**BankTransactions**](BankTransactions.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type BankTransactions array with updated BankTransaction |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatebanktransactionattachmentbyfilename"></a>
# **UpdateBankTransactionAttachmentByFileName**
> Attachments UpdateBankTransactionAttachmentByFileName (string xeroTenantId, Guid bankTransactionID, string fileName, byte[] body, string? idempotencyKey = null)

Updates a specific attachment from a specific bank transaction by filename

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateBankTransactionAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransactionID = 00000000-0000-0000-0000-000000000000;  // Guid | Xero generated unique identifier for a bank transaction
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific attachment from a specific bank transaction by filename
                Attachments result = apiInstance.UpdateBankTransactionAttachmentByFileName(xeroTenantId, bankTransactionID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateBankTransactionAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateBankTransactionAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific attachment from a specific bank transaction by filename
    ApiResponse<Attachments> response = apiInstance.UpdateBankTransactionAttachmentByFileNameWithHttpInfo(xeroTenantId, bankTransactionID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateBankTransactionAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransactionID** | **Guid** | Xero generated unique identifier for a bank transaction |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of Attachments array of Attachment |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatebanktransferattachmentbyfilename"></a>
# **UpdateBankTransferAttachmentByFileName**
> Attachments UpdateBankTransferAttachmentByFileName (string xeroTenantId, Guid bankTransferID, string fileName, byte[] body, string? idempotencyKey = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateBankTransferAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransferID = 00000000-0000-0000-0000-000000000000;  // Guid | Xero generated unique identifier for a bank transfer
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                Attachments result = apiInstance.UpdateBankTransferAttachmentByFileName(xeroTenantId, bankTransferID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateBankTransferAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateBankTransferAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Attachments> response = apiInstance.UpdateBankTransferAttachmentByFileNameWithHttpInfo(xeroTenantId, bankTransferID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateBankTransferAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransferID** | **Guid** | Xero generated unique identifier for a bank transfer |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of Attachments array of 0 to N Attachment for a Bank Transfer |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecontact"></a>
# **UpdateContact**
> Contacts UpdateContact (string xeroTenantId, Guid contactID, Contacts contacts, string? idempotencyKey = null)

Updates a specific contact in a Xero organisation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Contact
            var contacts = new Contacts(); // Contacts | an array of Contacts containing single Contact object with properties to update
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific contact in a Xero organisation
                Contacts result = apiInstance.UpdateContact(xeroTenantId, contactID, contacts, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific contact in a Xero organisation
    ApiResponse<Contacts> response = apiInstance.UpdateContactWithHttpInfo(xeroTenantId, contactID, contacts, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactID** | **Guid** | Unique identifier for a Contact |  |
| **contacts** | [**Contacts**](Contacts.md) | an array of Contacts containing single Contact object with properties to update |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Contacts**](Contacts.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Contacts array with an updated Contact |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecontactattachmentbyfilename"></a>
# **UpdateContactAttachmentByFileName**
> Attachments UpdateContactAttachmentByFileName (string xeroTenantId, Guid contactID, string fileName, byte[] body, string? idempotencyKey = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateContactAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Contact
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                Attachments result = apiInstance.UpdateContactAttachmentByFileName(xeroTenantId, contactID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateContactAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateContactAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Attachments> response = apiInstance.UpdateContactAttachmentByFileNameWithHttpInfo(xeroTenantId, contactID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateContactAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactID** | **Guid** | Unique identifier for a Contact |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array with an updated Attachment |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecontactgroup"></a>
# **UpdateContactGroup**
> ContactGroups UpdateContactGroup (string xeroTenantId, Guid contactGroupID, ContactGroups contactGroups, string? idempotencyKey = null)

Updates a specific contact group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateContactGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contactGroupID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Contact Group
            var contactGroups = new ContactGroups(); // ContactGroups | an array of Contact groups with Name of specific group to update
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific contact group
                ContactGroups result = apiInstance.UpdateContactGroup(xeroTenantId, contactGroupID, contactGroups, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateContactGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateContactGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific contact group
    ApiResponse<ContactGroups> response = apiInstance.UpdateContactGroupWithHttpInfo(xeroTenantId, contactGroupID, contactGroups, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateContactGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contactGroupID** | **Guid** | Unique identifier for a Contact Group |  |
| **contactGroups** | [**ContactGroups**](ContactGroups.md) | an array of Contact groups with Name of specific group to update |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**ContactGroups**](ContactGroups.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Contact Groups array of updated Contact Group |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecreditnote"></a>
# **UpdateCreditNote**
> CreditNotes UpdateCreditNote (string xeroTenantId, Guid creditNoteID, CreditNotes creditNotes, int? unitdp = null, string? idempotencyKey = null)

Updates a specific credit note

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateCreditNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var creditNoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Credit Note
            var creditNotes = new CreditNotes(); // CreditNotes | an array of Credit Notes containing credit note details to update
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific credit note
                CreditNotes result = apiInstance.UpdateCreditNote(xeroTenantId, creditNoteID, creditNotes, unitdp, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateCreditNote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCreditNoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific credit note
    ApiResponse<CreditNotes> response = apiInstance.UpdateCreditNoteWithHttpInfo(xeroTenantId, creditNoteID, creditNotes, unitdp, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateCreditNoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **creditNoteID** | **Guid** | Unique identifier for a Credit Note |  |
| **creditNotes** | [**CreditNotes**](CreditNotes.md) | an array of Credit Notes containing credit note details to update |  |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**CreditNotes**](CreditNotes.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Credit Notes array with updated CreditNote |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecreditnoteattachmentbyfilename"></a>
# **UpdateCreditNoteAttachmentByFileName**
> Attachments UpdateCreditNoteAttachmentByFileName (string xeroTenantId, Guid creditNoteID, string fileName, byte[] body, string? idempotencyKey = null)

Updates attachments on a specific credit note by file name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateCreditNoteAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var creditNoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Credit Note
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates attachments on a specific credit note by file name
                Attachments result = apiInstance.UpdateCreditNoteAttachmentByFileName(xeroTenantId, creditNoteID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateCreditNoteAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCreditNoteAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates attachments on a specific credit note by file name
    ApiResponse<Attachments> response = apiInstance.UpdateCreditNoteAttachmentByFileNameWithHttpInfo(xeroTenantId, creditNoteID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateCreditNoteAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **creditNoteID** | **Guid** | Unique identifier for a Credit Note |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array with updated Attachment for specific Credit Note |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateexpenseclaim"></a>
# **UpdateExpenseClaim**
> ExpenseClaims UpdateExpenseClaim (string xeroTenantId, Guid expenseClaimID, ExpenseClaims expenseClaims, string? idempotencyKey = null)

Updates a specific expense claims

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateExpenseClaimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var expenseClaimID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a ExpenseClaim
            var expenseClaims = new ExpenseClaims(); // ExpenseClaims | 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific expense claims
                ExpenseClaims result = apiInstance.UpdateExpenseClaim(xeroTenantId, expenseClaimID, expenseClaims, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateExpenseClaim: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateExpenseClaimWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific expense claims
    ApiResponse<ExpenseClaims> response = apiInstance.UpdateExpenseClaimWithHttpInfo(xeroTenantId, expenseClaimID, expenseClaims, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateExpenseClaimWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **expenseClaimID** | **Guid** | Unique identifier for a ExpenseClaim |  |
| **expenseClaims** | [**ExpenseClaims**](ExpenseClaims.md) |  |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**ExpenseClaims**](ExpenseClaims.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type ExpenseClaims array with updated ExpenseClaim |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateinvoice"></a>
# **UpdateInvoice**
> Invoices UpdateInvoice (string xeroTenantId, Guid invoiceID, Invoices invoices, int? unitdp = null, string? idempotencyKey = null)

Updates a specific sales invoices or purchase bills

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateInvoiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var invoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Invoice
            var invoices = new Invoices(); // Invoices | 
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific sales invoices or purchase bills
                Invoices result = apiInstance.UpdateInvoice(xeroTenantId, invoiceID, invoices, unitdp, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateInvoice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateInvoiceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific sales invoices or purchase bills
    ApiResponse<Invoices> response = apiInstance.UpdateInvoiceWithHttpInfo(xeroTenantId, invoiceID, invoices, unitdp, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateInvoiceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **invoiceID** | **Guid** | Unique identifier for an Invoice |  |
| **invoices** | [**Invoices**](Invoices.md) |  |  |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Invoices**](Invoices.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Invoices array with updated Invoice |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateinvoiceattachmentbyfilename"></a>
# **UpdateInvoiceAttachmentByFileName**
> Attachments UpdateInvoiceAttachmentByFileName (string xeroTenantId, Guid invoiceID, string fileName, byte[] body, string? idempotencyKey = null)

Updates an attachment from a specific invoices or purchase bill by filename

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateInvoiceAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var invoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Invoice
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates an attachment from a specific invoices or purchase bill by filename
                Attachments result = apiInstance.UpdateInvoiceAttachmentByFileName(xeroTenantId, invoiceID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateInvoiceAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateInvoiceAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an attachment from a specific invoices or purchase bill by filename
    ApiResponse<Attachments> response = apiInstance.UpdateInvoiceAttachmentByFileNameWithHttpInfo(xeroTenantId, invoiceID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateInvoiceAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **invoiceID** | **Guid** | Unique identifier for an Invoice |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array with updated Attachment |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateitem"></a>
# **UpdateItem**
> Items UpdateItem (string xeroTenantId, Guid itemID, Items items, int? unitdp = null, string? idempotencyKey = null)

Updates a specific item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var itemID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Item
            var items = new Items(); // Items | 
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific item
                Items result = apiInstance.UpdateItem(xeroTenantId, itemID, items, unitdp, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific item
    ApiResponse<Items> response = apiInstance.UpdateItemWithHttpInfo(xeroTenantId, itemID, items, unitdp, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **itemID** | **Guid** | Unique identifier for an Item |  |
| **items** | [**Items**](Items.md) |  |  |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Items**](Items.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Items array with updated Item |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatelinkedtransaction"></a>
# **UpdateLinkedTransaction**
> LinkedTransactions UpdateLinkedTransaction (string xeroTenantId, Guid linkedTransactionID, LinkedTransactions linkedTransactions, string? idempotencyKey = null)

Updates a specific linked transactions (billable expenses)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateLinkedTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var linkedTransactionID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a LinkedTransaction
            var linkedTransactions = new LinkedTransactions(); // LinkedTransactions | 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific linked transactions (billable expenses)
                LinkedTransactions result = apiInstance.UpdateLinkedTransaction(xeroTenantId, linkedTransactionID, linkedTransactions, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateLinkedTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateLinkedTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific linked transactions (billable expenses)
    ApiResponse<LinkedTransactions> response = apiInstance.UpdateLinkedTransactionWithHttpInfo(xeroTenantId, linkedTransactionID, linkedTransactions, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateLinkedTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **linkedTransactionID** | **Guid** | Unique identifier for a LinkedTransaction |  |
| **linkedTransactions** | [**LinkedTransactions**](LinkedTransactions.md) |  |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**LinkedTransactions**](LinkedTransactions.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type LinkedTransactions array with updated LinkedTransaction |  -  |
| **400** | Success - return response of type LinkedTransactions array with updated LinkedTransaction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatemanualjournal"></a>
# **UpdateManualJournal**
> ManualJournals UpdateManualJournal (string xeroTenantId, Guid manualJournalID, ManualJournals manualJournals, string? idempotencyKey = null)

Updates a specific manual journal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateManualJournalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var manualJournalID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a ManualJournal
            var manualJournals = new ManualJournals(); // ManualJournals | 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific manual journal
                ManualJournals result = apiInstance.UpdateManualJournal(xeroTenantId, manualJournalID, manualJournals, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateManualJournal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateManualJournalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific manual journal
    ApiResponse<ManualJournals> response = apiInstance.UpdateManualJournalWithHttpInfo(xeroTenantId, manualJournalID, manualJournals, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateManualJournalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **manualJournalID** | **Guid** | Unique identifier for a ManualJournal |  |
| **manualJournals** | [**ManualJournals**](ManualJournals.md) |  |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**ManualJournals**](ManualJournals.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type ManualJournals array with an updated ManualJournal |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatemanualjournalattachmentbyfilename"></a>
# **UpdateManualJournalAttachmentByFileName**
> Attachments UpdateManualJournalAttachmentByFileName (string xeroTenantId, Guid manualJournalID, string fileName, byte[] body, string? idempotencyKey = null)

Updates a specific attachment from a specific manual journal by file name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateManualJournalAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var manualJournalID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a ManualJournal
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific attachment from a specific manual journal by file name
                Attachments result = apiInstance.UpdateManualJournalAttachmentByFileName(xeroTenantId, manualJournalID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateManualJournalAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateManualJournalAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific attachment from a specific manual journal by file name
    ApiResponse<Attachments> response = apiInstance.UpdateManualJournalAttachmentByFileNameWithHttpInfo(xeroTenantId, manualJournalID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateManualJournalAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **manualJournalID** | **Guid** | Unique identifier for a ManualJournal |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array with an update Attachment for a ManualJournals |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateorcreatebanktransactions"></a>
# **UpdateOrCreateBankTransactions**
> BankTransactions UpdateOrCreateBankTransactions (string xeroTenantId, BankTransactions bankTransactions, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null)

Updates or creates one or more spent or received money transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateOrCreateBankTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var bankTransactions = new BankTransactions(); // BankTransactions | 
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates or creates one or more spent or received money transaction
                BankTransactions result = apiInstance.UpdateOrCreateBankTransactions(xeroTenantId, bankTransactions, summarizeErrors, unitdp, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateOrCreateBankTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrCreateBankTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates or creates one or more spent or received money transaction
    ApiResponse<BankTransactions> response = apiInstance.UpdateOrCreateBankTransactionsWithHttpInfo(xeroTenantId, bankTransactions, summarizeErrors, unitdp, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateOrCreateBankTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **bankTransactions** | [**BankTransactions**](BankTransactions.md) |  |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**BankTransactions**](BankTransactions.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type BankTransactions array with new BankTransaction |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateorcreatecontacts"></a>
# **UpdateOrCreateContacts**
> Contacts UpdateOrCreateContacts (string xeroTenantId, Contacts contacts, bool? summarizeErrors = null, string? idempotencyKey = null)

Updates or creates one or more contacts in a Xero organisation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateOrCreateContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var contacts = new Contacts(); // Contacts | 
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates or creates one or more contacts in a Xero organisation
                Contacts result = apiInstance.UpdateOrCreateContacts(xeroTenantId, contacts, summarizeErrors, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateOrCreateContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrCreateContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates or creates one or more contacts in a Xero organisation
    ApiResponse<Contacts> response = apiInstance.UpdateOrCreateContactsWithHttpInfo(xeroTenantId, contacts, summarizeErrors, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateOrCreateContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **contacts** | [**Contacts**](Contacts.md) |  |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Contacts**](Contacts.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Contacts array with newly created Contact |  -  |
| **400** | Validation Error - some data was incorrect returns response of type Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateorcreatecreditnotes"></a>
# **UpdateOrCreateCreditNotes**
> CreditNotes UpdateOrCreateCreditNotes (string xeroTenantId, CreditNotes creditNotes, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null)

Updates or creates one or more credit notes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateOrCreateCreditNotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var creditNotes = new CreditNotes(); // CreditNotes | an array of Credit Notes with a single CreditNote object.
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates or creates one or more credit notes
                CreditNotes result = apiInstance.UpdateOrCreateCreditNotes(xeroTenantId, creditNotes, summarizeErrors, unitdp, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateOrCreateCreditNotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrCreateCreditNotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates or creates one or more credit notes
    ApiResponse<CreditNotes> response = apiInstance.UpdateOrCreateCreditNotesWithHttpInfo(xeroTenantId, creditNotes, summarizeErrors, unitdp, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateOrCreateCreditNotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **creditNotes** | [**CreditNotes**](CreditNotes.md) | an array of Credit Notes with a single CreditNote object. |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**CreditNotes**](CreditNotes.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Credit Notes array of newly created CreditNote |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateorcreateemployees"></a>
# **UpdateOrCreateEmployees**
> Employees UpdateOrCreateEmployees (string xeroTenantId, Employees employees, bool? summarizeErrors = null, string? idempotencyKey = null)

Creates a single new employees used in Xero payrun

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateOrCreateEmployeesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var employees = new Employees(); // Employees | Employees with array of Employee object in body of request
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates a single new employees used in Xero payrun
                Employees result = apiInstance.UpdateOrCreateEmployees(xeroTenantId, employees, summarizeErrors, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateOrCreateEmployees: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrCreateEmployeesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a single new employees used in Xero payrun
    ApiResponse<Employees> response = apiInstance.UpdateOrCreateEmployeesWithHttpInfo(xeroTenantId, employees, summarizeErrors, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateOrCreateEmployeesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **employees** | [**Employees**](Employees.md) | Employees with array of Employee object in body of request |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Employees**](Employees.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Employees array with new Employee |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateorcreateinvoices"></a>
# **UpdateOrCreateInvoices**
> Invoices UpdateOrCreateInvoices (string xeroTenantId, Invoices invoices, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null)

Updates or creates one or more sales invoices or purchase bills

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateOrCreateInvoicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var invoices = new Invoices(); // Invoices | 
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates or creates one or more sales invoices or purchase bills
                Invoices result = apiInstance.UpdateOrCreateInvoices(xeroTenantId, invoices, summarizeErrors, unitdp, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateOrCreateInvoices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrCreateInvoicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates or creates one or more sales invoices or purchase bills
    ApiResponse<Invoices> response = apiInstance.UpdateOrCreateInvoicesWithHttpInfo(xeroTenantId, invoices, summarizeErrors, unitdp, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateOrCreateInvoicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **invoices** | [**Invoices**](Invoices.md) |  |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Invoices**](Invoices.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Invoices array with newly created Invoice |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateorcreateitems"></a>
# **UpdateOrCreateItems**
> Items UpdateOrCreateItems (string xeroTenantId, Items items, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null)

Updates or creates one or more items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateOrCreateItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var items = new Items(); // Items | 
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates or creates one or more items
                Items result = apiInstance.UpdateOrCreateItems(xeroTenantId, items, summarizeErrors, unitdp, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateOrCreateItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrCreateItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates or creates one or more items
    ApiResponse<Items> response = apiInstance.UpdateOrCreateItemsWithHttpInfo(xeroTenantId, items, summarizeErrors, unitdp, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateOrCreateItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **items** | [**Items**](Items.md) |  |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Items**](Items.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Items array with newly created Item |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateorcreatemanualjournals"></a>
# **UpdateOrCreateManualJournals**
> ManualJournals UpdateOrCreateManualJournals (string xeroTenantId, ManualJournals manualJournals, bool? summarizeErrors = null, string? idempotencyKey = null)

Updates or creates a single manual journal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateOrCreateManualJournalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var manualJournals = new ManualJournals(); // ManualJournals | ManualJournals array with ManualJournal object in body of request
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates or creates a single manual journal
                ManualJournals result = apiInstance.UpdateOrCreateManualJournals(xeroTenantId, manualJournals, summarizeErrors, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateOrCreateManualJournals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrCreateManualJournalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates or creates a single manual journal
    ApiResponse<ManualJournals> response = apiInstance.UpdateOrCreateManualJournalsWithHttpInfo(xeroTenantId, manualJournals, summarizeErrors, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateOrCreateManualJournalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **manualJournals** | [**ManualJournals**](ManualJournals.md) | ManualJournals array with ManualJournal object in body of request |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**ManualJournals**](ManualJournals.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type ManualJournals array with newly created ManualJournal |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateorcreatepurchaseorders"></a>
# **UpdateOrCreatePurchaseOrders**
> PurchaseOrders UpdateOrCreatePurchaseOrders (string xeroTenantId, PurchaseOrders purchaseOrders, bool? summarizeErrors = null, string? idempotencyKey = null)

Updates or creates one or more purchase orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateOrCreatePurchaseOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var purchaseOrders = new PurchaseOrders(); // PurchaseOrders | 
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates or creates one or more purchase orders
                PurchaseOrders result = apiInstance.UpdateOrCreatePurchaseOrders(xeroTenantId, purchaseOrders, summarizeErrors, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateOrCreatePurchaseOrders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrCreatePurchaseOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates or creates one or more purchase orders
    ApiResponse<PurchaseOrders> response = apiInstance.UpdateOrCreatePurchaseOrdersWithHttpInfo(xeroTenantId, purchaseOrders, summarizeErrors, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateOrCreatePurchaseOrdersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **purchaseOrders** | [**PurchaseOrders**](PurchaseOrders.md) |  |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**PurchaseOrders**](PurchaseOrders.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type PurchaseOrder array for specified PurchaseOrder |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateorcreatequotes"></a>
# **UpdateOrCreateQuotes**
> Quotes UpdateOrCreateQuotes (string xeroTenantId, Quotes quotes, bool? summarizeErrors = null, string? idempotencyKey = null)

Updates or creates one or more quotes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateOrCreateQuotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var quotes = new Quotes(); // Quotes | 
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates or creates one or more quotes
                Quotes result = apiInstance.UpdateOrCreateQuotes(xeroTenantId, quotes, summarizeErrors, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateOrCreateQuotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrCreateQuotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates or creates one or more quotes
    ApiResponse<Quotes> response = apiInstance.UpdateOrCreateQuotesWithHttpInfo(xeroTenantId, quotes, summarizeErrors, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateOrCreateQuotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **quotes** | [**Quotes**](Quotes.md) |  |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Quotes**](Quotes.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Quotes array with updated or created Quote |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateorcreaterepeatinginvoices"></a>
# **UpdateOrCreateRepeatingInvoices**
> RepeatingInvoices UpdateOrCreateRepeatingInvoices (string xeroTenantId, RepeatingInvoices repeatingInvoices, bool? summarizeErrors = null, string? idempotencyKey = null)

Creates or deletes one or more repeating invoice templates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateOrCreateRepeatingInvoicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var repeatingInvoices = new RepeatingInvoices(); // RepeatingInvoices | RepeatingInvoices with an array of repeating invoice objects in body of request
            var summarizeErrors = true;  // bool? | If false return 200 OK and mix of successfully created objects and any with validation errors (optional)  (default to false)
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Creates or deletes one or more repeating invoice templates
                RepeatingInvoices result = apiInstance.UpdateOrCreateRepeatingInvoices(xeroTenantId, repeatingInvoices, summarizeErrors, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateOrCreateRepeatingInvoices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrCreateRepeatingInvoicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or deletes one or more repeating invoice templates
    ApiResponse<RepeatingInvoices> response = apiInstance.UpdateOrCreateRepeatingInvoicesWithHttpInfo(xeroTenantId, repeatingInvoices, summarizeErrors, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateOrCreateRepeatingInvoicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **repeatingInvoices** | [**RepeatingInvoices**](RepeatingInvoices.md) | RepeatingInvoices with an array of repeating invoice objects in body of request |  |
| **summarizeErrors** | **bool?** | If false return 200 OK and mix of successfully created objects and any with validation errors | [optional] [default to false] |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**RepeatingInvoices**](RepeatingInvoices.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type RepeatingInvoices array with newly created RepeatingInvoice |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatepurchaseorder"></a>
# **UpdatePurchaseOrder**
> PurchaseOrders UpdatePurchaseOrder (string xeroTenantId, Guid purchaseOrderID, PurchaseOrders purchaseOrders, string? idempotencyKey = null)

Updates a specific purchase order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdatePurchaseOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var purchaseOrderID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Purchase Order
            var purchaseOrders = new PurchaseOrders(); // PurchaseOrders | 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific purchase order
                PurchaseOrders result = apiInstance.UpdatePurchaseOrder(xeroTenantId, purchaseOrderID, purchaseOrders, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdatePurchaseOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePurchaseOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific purchase order
    ApiResponse<PurchaseOrders> response = apiInstance.UpdatePurchaseOrderWithHttpInfo(xeroTenantId, purchaseOrderID, purchaseOrders, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdatePurchaseOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **purchaseOrderID** | **Guid** | Unique identifier for an Purchase Order |  |
| **purchaseOrders** | [**PurchaseOrders**](PurchaseOrders.md) |  |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**PurchaseOrders**](PurchaseOrders.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type PurchaseOrder array for updated PurchaseOrder |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatepurchaseorderattachmentbyfilename"></a>
# **UpdatePurchaseOrderAttachmentByFileName**
> Attachments UpdatePurchaseOrderAttachmentByFileName (string xeroTenantId, Guid purchaseOrderID, string fileName, byte[] body, string? idempotencyKey = null)

Updates a specific attachment for a specific purchase order by filename

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdatePurchaseOrderAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var purchaseOrderID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Purchase Order
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific attachment for a specific purchase order by filename
                Attachments result = apiInstance.UpdatePurchaseOrderAttachmentByFileName(xeroTenantId, purchaseOrderID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdatePurchaseOrderAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePurchaseOrderAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific attachment for a specific purchase order by filename
    ApiResponse<Attachments> response = apiInstance.UpdatePurchaseOrderAttachmentByFileNameWithHttpInfo(xeroTenantId, purchaseOrderID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdatePurchaseOrderAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **purchaseOrderID** | **Guid** | Unique identifier for an Purchase Order |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array of Attachment |  -  |
| **400** | Validation Error - some data was incorrect returns response of type Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatequote"></a>
# **UpdateQuote**
> Quotes UpdateQuote (string xeroTenantId, Guid quoteID, Quotes quotes, string? idempotencyKey = null)

Updates a specific quote

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var quoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Quote
            var quotes = new Quotes(); // Quotes | 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific quote
                Quotes result = apiInstance.UpdateQuote(xeroTenantId, quoteID, quotes, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateQuote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateQuoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific quote
    ApiResponse<Quotes> response = apiInstance.UpdateQuoteWithHttpInfo(xeroTenantId, quoteID, quotes, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateQuoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **quoteID** | **Guid** | Unique identifier for an Quote |  |
| **quotes** | [**Quotes**](Quotes.md) |  |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Quotes**](Quotes.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Quotes array with updated Quote |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatequoteattachmentbyfilename"></a>
# **UpdateQuoteAttachmentByFileName**
> Attachments UpdateQuoteAttachmentByFileName (string xeroTenantId, Guid quoteID, string fileName, byte[] body, string? idempotencyKey = null)

Updates a specific attachment from a specific quote by filename

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateQuoteAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var quoteID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for an Quote
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific attachment from a specific quote by filename
                Attachments result = apiInstance.UpdateQuoteAttachmentByFileName(xeroTenantId, quoteID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateQuoteAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateQuoteAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific attachment from a specific quote by filename
    ApiResponse<Attachments> response = apiInstance.UpdateQuoteAttachmentByFileNameWithHttpInfo(xeroTenantId, quoteID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateQuoteAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **quoteID** | **Guid** | Unique identifier for an Quote |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array of Attachment |  -  |
| **400** | Validation Error - some data was incorrect returns response of type Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatereceipt"></a>
# **UpdateReceipt**
> Receipts UpdateReceipt (string xeroTenantId, Guid receiptID, Receipts receipts, int? unitdp = null, string? idempotencyKey = null)

Updates a specific draft expense claim receipts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateReceiptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var receiptID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Receipt
            var receipts = new Receipts(); // Receipts | 
            var unitdp = 4;  // int? | e.g. unitdp=4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts (optional) 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific draft expense claim receipts
                Receipts result = apiInstance.UpdateReceipt(xeroTenantId, receiptID, receipts, unitdp, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateReceipt: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateReceiptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific draft expense claim receipts
    ApiResponse<Receipts> response = apiInstance.UpdateReceiptWithHttpInfo(xeroTenantId, receiptID, receipts, unitdp, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateReceiptWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **receiptID** | **Guid** | Unique identifier for a Receipt |  |
| **receipts** | [**Receipts**](Receipts.md) |  |  |
| **unitdp** | **int?** | e.g. unitdp&#x3D;4 – (Unit Decimal Places) You can opt in to use four decimal places for unit amounts | [optional]  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Receipts**](Receipts.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Receipts array for updated Receipt |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatereceiptattachmentbyfilename"></a>
# **UpdateReceiptAttachmentByFileName**
> Attachments UpdateReceiptAttachmentByFileName (string xeroTenantId, Guid receiptID, string fileName, byte[] body, string? idempotencyKey = null)

Updates a specific attachment on a specific expense claim receipts by file name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateReceiptAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var receiptID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Receipt
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific attachment on a specific expense claim receipts by file name
                Attachments result = apiInstance.UpdateReceiptAttachmentByFileName(xeroTenantId, receiptID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateReceiptAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateReceiptAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific attachment on a specific expense claim receipts by file name
    ApiResponse<Attachments> response = apiInstance.UpdateReceiptAttachmentByFileNameWithHttpInfo(xeroTenantId, receiptID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateReceiptAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **receiptID** | **Guid** | Unique identifier for a Receipt |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array with updated Attachment for a specified Receipt |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updaterepeatinginvoice"></a>
# **UpdateRepeatingInvoice**
> RepeatingInvoices UpdateRepeatingInvoice (string xeroTenantId, Guid repeatingInvoiceID, RepeatingInvoices repeatingInvoices, string? idempotencyKey = null)

Deletes a specific repeating invoice template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateRepeatingInvoiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var repeatingInvoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Repeating Invoice
            var repeatingInvoices = new RepeatingInvoices(); // RepeatingInvoices | 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Deletes a specific repeating invoice template
                RepeatingInvoices result = apiInstance.UpdateRepeatingInvoice(xeroTenantId, repeatingInvoiceID, repeatingInvoices, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateRepeatingInvoice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRepeatingInvoiceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a specific repeating invoice template
    ApiResponse<RepeatingInvoices> response = apiInstance.UpdateRepeatingInvoiceWithHttpInfo(xeroTenantId, repeatingInvoiceID, repeatingInvoices, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateRepeatingInvoiceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **repeatingInvoiceID** | **Guid** | Unique identifier for a Repeating Invoice |  |
| **repeatingInvoices** | [**RepeatingInvoices**](RepeatingInvoices.md) |  |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**RepeatingInvoices**](RepeatingInvoices.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type RepeatingInvoices array with deleted Invoice |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updaterepeatinginvoiceattachmentbyfilename"></a>
# **UpdateRepeatingInvoiceAttachmentByFileName**
> Attachments UpdateRepeatingInvoiceAttachmentByFileName (string xeroTenantId, Guid repeatingInvoiceID, string fileName, byte[] body, string? idempotencyKey = null)

Updates a specific attachment from a specific repeating invoices by file name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateRepeatingInvoiceAttachmentByFileNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var repeatingInvoiceID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Repeating Invoice
            var fileName = xero-dev.jpg;  // string | Name of the attachment
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | Byte array of file in body of request
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific attachment from a specific repeating invoices by file name
                Attachments result = apiInstance.UpdateRepeatingInvoiceAttachmentByFileName(xeroTenantId, repeatingInvoiceID, fileName, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateRepeatingInvoiceAttachmentByFileName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRepeatingInvoiceAttachmentByFileNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific attachment from a specific repeating invoices by file name
    ApiResponse<Attachments> response = apiInstance.UpdateRepeatingInvoiceAttachmentByFileNameWithHttpInfo(xeroTenantId, repeatingInvoiceID, fileName, body, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateRepeatingInvoiceAttachmentByFileNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **repeatingInvoiceID** | **Guid** | Unique identifier for a Repeating Invoice |  |
| **fileName** | **string** | Name of the attachment |  |
| **body** | **byte[]** | Byte array of file in body of request |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**Attachments**](Attachments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type Attachments array with specified Attachment for a specified Repeating Invoice |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetaxrate"></a>
# **UpdateTaxRate**
> TaxRates UpdateTaxRate (string xeroTenantId, TaxRates taxRates, string? idempotencyKey = null)

Updates tax rates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateTaxRateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var taxRates = new TaxRates(); // TaxRates | 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates tax rates
                TaxRates result = apiInstance.UpdateTaxRate(xeroTenantId, taxRates, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateTaxRate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTaxRateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates tax rates
    ApiResponse<TaxRates> response = apiInstance.UpdateTaxRateWithHttpInfo(xeroTenantId, taxRates, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateTaxRateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **taxRates** | [**TaxRates**](TaxRates.md) |  |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**TaxRates**](TaxRates.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type TaxRates array updated TaxRate |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetrackingcategory"></a>
# **UpdateTrackingCategory**
> TrackingCategories UpdateTrackingCategory (string xeroTenantId, Guid trackingCategoryID, TrackingCategory trackingCategory, string? idempotencyKey = null)

Updates a specific tracking category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateTrackingCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var trackingCategoryID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a TrackingCategory
            var trackingCategory = new TrackingCategory(); // TrackingCategory | 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific tracking category
                TrackingCategories result = apiInstance.UpdateTrackingCategory(xeroTenantId, trackingCategoryID, trackingCategory, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateTrackingCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTrackingCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific tracking category
    ApiResponse<TrackingCategories> response = apiInstance.UpdateTrackingCategoryWithHttpInfo(xeroTenantId, trackingCategoryID, trackingCategory, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateTrackingCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **trackingCategoryID** | **Guid** | Unique identifier for a TrackingCategory |  |
| **trackingCategory** | [**TrackingCategory**](TrackingCategory.md) |  |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**TrackingCategories**](TrackingCategories.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type TrackingCategories array of updated TrackingCategory |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetrackingoptions"></a>
# **UpdateTrackingOptions**
> TrackingOptions UpdateTrackingOptions (string xeroTenantId, Guid trackingCategoryID, Guid trackingOptionID, TrackingOption trackingOption, string? idempotencyKey = null)

Updates a specific option for a specific tracking category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateTrackingOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.xero.com/api.xro/2.0";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountingApi(config);
            var xeroTenantId = YOUR_XERO_TENANT_ID;  // string | Xero identifier for Tenant
            var trackingCategoryID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a TrackingCategory
            var trackingOptionID = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier for a Tracking Option
            var trackingOption = new TrackingOption(); // TrackingOption | 
            var idempotencyKey = KEY_VALUE;  // string? | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional) 

            try
            {
                // Updates a specific option for a specific tracking category
                TrackingOptions result = apiInstance.UpdateTrackingOptions(xeroTenantId, trackingCategoryID, trackingOptionID, trackingOption, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountingApi.UpdateTrackingOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTrackingOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific option for a specific tracking category
    ApiResponse<TrackingOptions> response = apiInstance.UpdateTrackingOptionsWithHttpInfo(xeroTenantId, trackingCategoryID, trackingOptionID, trackingOption, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountingApi.UpdateTrackingOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xeroTenantId** | **string** | Xero identifier for Tenant |  |
| **trackingCategoryID** | **Guid** | Unique identifier for a TrackingCategory |  |
| **trackingOptionID** | **Guid** | Unique identifier for a Tracking Option |  |
| **trackingOption** | [**TrackingOption**](TrackingOption.md) |  |  |
| **idempotencyKey** | **string?** | This allows you to safely retry requests without the risk of duplicate processing. 128 character max. | [optional]  |

### Return type

[**TrackingOptions**](TrackingOptions.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - return response of type TrackingOptions array of options for a specified category |  -  |
| **400** | A failed request due to validation error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

