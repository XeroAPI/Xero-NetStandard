# Org.OpenAPITools.Model.LinkedTransaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceTransactionID** | **Guid** | Filter by the SourceTransactionID. Get all the linked transactions created from a particular ACCPAY invoice | [optional] 
**SourceLineItemID** | **Guid** | The line item identifier from the source transaction. | [optional] 
**ContactID** | **Guid** | Filter by the combination of ContactID and Status. Get all the linked transactions that have been assigned to a particular customer and have a particular status e.g. GET /LinkedTransactions?ContactID&#x3D;4bb34b03-3378-4bb2-a0ed-6345abf3224e&amp;Status&#x3D;APPROVED. | [optional] 
**TargetTransactionID** | **Guid** | Filter by the TargetTransactionID. Get all the linked transactions  allocated to a particular ACCREC invoice | [optional] 
**TargetLineItemID** | **Guid** | The line item identifier from the target transaction. It is possible  to link multiple billable expenses to the same TargetLineItemID. | [optional] 
**LinkedTransactionID** | **Guid** | The Xero identifier for an Linked Transaction e.g./LinkedTransactions/297c2dc5-cc47-4afd-8ec8-74990b8761e9 | [optional] 
**Status** | **string** | Filter by the combination of ContactID and Status. Get all the linked transactions that have been assigned to a particular customer and have a particular status e.g. GET /LinkedTransactions?ContactID&#x3D;4bb34b03-3378-4bb2-a0ed-6345abf3224e&amp;Status&#x3D;APPROVED. | [optional] 
**Type** | **string** | This will always be BILLABLEEXPENSE. More types may be added in future. | [optional] 
**UpdatedDateUTC** | **string** | The last modified date in UTC format | [optional] [readonly] 
**SourceTransactionTypeCode** | **string** | The Type of the source tranasction. This will be ACCPAY if the linked transaction was created from an invoice and SPEND if it was created from a bank transaction. | [optional] 
**ValidationErrors** | [**List&lt;ValidationError&gt;**](ValidationError.md) | Displays array of validation error messages from the API | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

