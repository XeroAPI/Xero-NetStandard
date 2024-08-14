# Org.OpenAPITools.Model.BankTransfer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromBankAccount** | [**Account**](Account.md) |  | 
**ToBankAccount** | [**Account**](Account.md) |  | 
**Amount** | **double** | amount of the transaction | 
**Date** | **string** | The date of the Transfer YYYY-MM-DD | [optional] 
**BankTransferID** | **Guid** | The identifier of the Bank Transfer | [optional] [readonly] 
**CurrencyRate** | **double** | The currency rate | [optional] [readonly] 
**FromBankTransactionID** | **Guid** | The Bank Transaction ID for the source account | [optional] [readonly] 
**ToBankTransactionID** | **Guid** | The Bank Transaction ID for the destination account | [optional] [readonly] 
**FromIsReconciled** | **bool** | The Bank Transaction boolean to show if it is reconciled for the source account | [optional] [default to false]
**ToIsReconciled** | **bool** | The Bank Transaction boolean to show if it is reconciled for the destination account | [optional] [default to false]
**Reference** | **string** | Reference for the transactions. | [optional] 
**HasAttachments** | **bool** | Boolean to indicate if a Bank Transfer has an attachment | [optional] [readonly] [default to false]
**CreatedDateUTC** | **string** | UTC timestamp of creation date of bank transfer | [optional] [readonly] 
**ValidationErrors** | [**List&lt;ValidationError&gt;**](ValidationError.md) | Displays array of validation error messages from the API | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

