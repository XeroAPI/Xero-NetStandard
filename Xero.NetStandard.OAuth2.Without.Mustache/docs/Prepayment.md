# Org.OpenAPITools.Model.Prepayment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | See Prepayment Types | [optional] 
**Contact** | [**Contact**](Contact.md) |  | [optional] 
**Date** | **string** | The date the prepayment is created YYYY-MM-DD | [optional] 
**Status** | **string** | See Prepayment Status Codes | [optional] 
**LineAmountTypes** | **LineAmountTypes** |  | [optional] 
**LineItems** | [**List&lt;LineItem&gt;**](LineItem.md) | See Prepayment Line Items | [optional] 
**SubTotal** | **double** | The subtotal of the prepayment excluding taxes | [optional] 
**TotalTax** | **double** | The total tax on the prepayment | [optional] 
**Total** | **double** | The total of the prepayment(subtotal + total tax) | [optional] 
**Reference** | **string** | Returns Invoice number field. Reference field isn&#39;t available. | [optional] [readonly] 
**UpdatedDateUTC** | **string** | UTC timestamp of last update to the prepayment | [optional] [readonly] 
**CurrencyCode** | **CurrencyCode** |  | [optional] 
**PrepaymentID** | **Guid** | Xero generated unique identifier | [optional] 
**CurrencyRate** | **double** | The currency rate for a multicurrency prepayment. If no rate is specified, the XE.com day rate is used | [optional] 
**RemainingCredit** | **double** | The remaining credit balance on the prepayment | [optional] 
**Allocations** | [**List&lt;Allocation&gt;**](Allocation.md) | See Allocations | [optional] 
**Payments** | [**List&lt;Payment&gt;**](Payment.md) | See Payments | [optional] 
**AppliedAmount** | **double** | The amount of applied to an invoice | [optional] 
**HasAttachments** | **bool** | boolean to indicate if a prepayment has an attachment | [optional] [readonly] [default to false]
**Attachments** | [**List&lt;Attachment&gt;**](Attachment.md) | See Attachments | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

