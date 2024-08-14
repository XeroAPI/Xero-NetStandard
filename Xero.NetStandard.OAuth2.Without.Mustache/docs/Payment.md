# Org.OpenAPITools.Model.Payment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Invoice** | [**Invoice**](Invoice.md) |  | [optional] 
**CreditNote** | [**CreditNote**](CreditNote.md) |  | [optional] 
**Prepayment** | [**Prepayment**](Prepayment.md) |  | [optional] 
**Overpayment** | [**Overpayment**](Overpayment.md) |  | [optional] 
**InvoiceNumber** | **string** | Number of invoice or credit note you are applying payment to e.g.INV-4003 | [optional] 
**CreditNoteNumber** | **string** | Number of invoice or credit note you are applying payment to e.g. INV-4003 | [optional] 
**BatchPayment** | [**BatchPayment**](BatchPayment.md) |  | [optional] 
**Account** | [**Account**](Account.md) |  | [optional] 
**Code** | **string** | Code of account you are using to make the payment e.g. 001 (note- not all accounts have a code value) | [optional] 
**Date** | **string** | Date the payment is being made (YYYY-MM-DD) e.g. 2009-09-06 | [optional] 
**CurrencyRate** | **double** | Exchange rate when payment is received. Only used for non base currency invoices and credit notes e.g. 0.7500 | [optional] 
**Amount** | **double** | The amount of the payment. Must be less than or equal to the outstanding amount owing on the invoice e.g. 200.00 | [optional] 
**BankAmount** | **double** | The amount of the payment in the currency of the bank account. | [optional] 
**Reference** | **string** | An optional description for the payment e.g. Direct Debit | [optional] 
**IsReconciled** | **bool** | An optional parameter for the payment. A boolean indicating whether you would like the payment to be created as reconciled when using PUT, or whether a payment has been reconciled when using GET | [optional] 
**Status** | **string** | The status of the payment. | [optional] 
**PaymentType** | **string** | See Payment Types. | [optional] [readonly] 
**UpdatedDateUTC** | **string** | UTC timestamp of last update to the payment | [optional] [readonly] 
**PaymentID** | **Guid** | The Xero identifier for an Payment e.g. 297c2dc5-cc47-4afd-8ec8-74990b8761e9 | [optional] 
**BatchPaymentID** | **Guid** | Present if the payment was created as part of a batch. | [optional] 
**BankAccountNumber** | **string** | The suppliers bank account number the payment is being made to | [optional] 
**Particulars** | **string** | The suppliers bank account number the payment is being made to | [optional] 
**Details** | **string** | The information to appear on the supplier&#39;s bank account | [optional] 
**HasAccount** | **bool** | A boolean to indicate if a contact has an validation errors | [optional] [default to false]
**HasValidationErrors** | **bool** | A boolean to indicate if a contact has an validation errors | [optional] [default to false]
**StatusAttributeString** | **string** | A string to indicate if a invoice status | [optional] 
**ValidationErrors** | [**List&lt;ValidationError&gt;**](ValidationError.md) | Displays array of validation error messages from the API | [optional] 
**Warnings** | [**List&lt;ValidationError&gt;**](ValidationError.md) | Displays array of warning messages from the API | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

