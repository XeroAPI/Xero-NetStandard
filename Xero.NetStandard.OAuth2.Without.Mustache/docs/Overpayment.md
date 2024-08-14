# Org.OpenAPITools.Model.Overpayment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | See Overpayment Types | [optional] 
**Contact** | [**Contact**](Contact.md) |  | [optional] 
**Date** | **string** | The date the overpayment is created YYYY-MM-DD | [optional] 
**Status** | **string** | See Overpayment Status Codes | [optional] 
**LineAmountTypes** | **LineAmountTypes** |  | [optional] 
**LineItems** | [**List&lt;LineItem&gt;**](LineItem.md) | See Overpayment Line Items | [optional] 
**SubTotal** | **double** | The subtotal of the overpayment excluding taxes | [optional] 
**TotalTax** | **double** | The total tax on the overpayment | [optional] 
**Total** | **double** | The total of the overpayment (subtotal + total tax) | [optional] 
**UpdatedDateUTC** | **string** | UTC timestamp of last update to the overpayment | [optional] [readonly] 
**CurrencyCode** | **CurrencyCode** |  | [optional] 
**OverpaymentID** | **Guid** | Xero generated unique identifier | [optional] 
**CurrencyRate** | **double** | The currency rate for a multicurrency overpayment. If no rate is specified, the XE.com day rate is used | [optional] 
**RemainingCredit** | **double** | The remaining credit balance on the overpayment | [optional] 
**Allocations** | [**List&lt;Allocation&gt;**](Allocation.md) | See Allocations | [optional] 
**AppliedAmount** | **double** | The amount of applied to an invoice | [optional] 
**Payments** | [**List&lt;Payment&gt;**](Payment.md) | See Payments | [optional] 
**HasAttachments** | **bool** | boolean to indicate if a overpayment has an attachment | [optional] [readonly] [default to false]
**Attachments** | [**List&lt;Attachment&gt;**](Attachment.md) | See Attachments | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

