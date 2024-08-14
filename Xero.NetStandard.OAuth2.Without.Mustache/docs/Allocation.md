# Org.OpenAPITools.Model.Allocation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllocationID** | **Guid** | Xero generated unique identifier | [optional] 
**Invoice** | [**Invoice**](Invoice.md) |  | 
**Overpayment** | [**Overpayment**](Overpayment.md) |  | [optional] 
**Prepayment** | [**Prepayment**](Prepayment.md) |  | [optional] 
**CreditNote** | [**CreditNote**](CreditNote.md) |  | [optional] 
**Amount** | **double** | the amount being applied to the invoice | 
**Date** | **string** | the date the allocation is applied YYYY-MM-DD. | 
**IsDeleted** | **bool** | A flag that returns true when the allocation is succesfully deleted | [optional] [readonly] 
**StatusAttributeString** | **string** | A string to indicate if a invoice status | [optional] 
**ValidationErrors** | [**List&lt;ValidationError&gt;**](ValidationError.md) | Displays array of validation error messages from the API | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

