# Org.OpenAPITools.Model.LineItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LineItemID** | **Guid** | LineItem unique ID | [optional] 
**Description** | **string** | Description needs to be at least 1 char long. A line item with just a description (i.e no unit amount or quantity) can be created by specifying just a &lt;Description&gt; element that contains at least 1 character | [optional] 
**Quantity** | **double** | LineItem Quantity | [optional] 
**UnitAmount** | **double** | LineItem Unit Amount | [optional] 
**ItemCode** | **string** | See Items | [optional] 
**AccountCode** | **string** | See Accounts | [optional] 
**AccountID** | **Guid** | The associated account ID related to this line item | [optional] 
**TaxType** | **string** | The tax type from TaxRates | [optional] 
**TaxAmount** | **double** | The tax amount is auto calculated as a percentage of the line amount (see below) based on the tax rate. This value can be overriden if the calculated &lt;TaxAmount&gt; is not correct. | [optional] 
**Item** | [**LineItemItem**](LineItemItem.md) |  | [optional] 
**LineAmount** | **double** | If you wish to omit either the Quantity or UnitAmount you can provide a LineAmount and Xero will calculate the missing amount for you. The line amount reflects the discounted price if either a DiscountRate or DiscountAmount has been used i.e. LineAmount &#x3D; Quantity * Unit Amount * ((100 - DiscountRate)/100) or LineAmount &#x3D; (Quantity * UnitAmount) - DiscountAmount | [optional] 
**Tracking** | [**List&lt;LineItemTracking&gt;**](LineItemTracking.md) | Optional Tracking Category – see Tracking.  Any LineItem can have a  maximum of 2 &lt;TrackingCategory&gt; elements. | [optional] 
**DiscountRate** | **double** | Percentage discount being applied to a line item (only supported on  ACCREC invoices – ACC PAY invoices and credit notes in Xero do not support discounts | [optional] 
**DiscountAmount** | **double** | Discount amount being applied to a line item. Only supported on ACCREC invoices and quotes. ACCPAY invoices and credit notes in Xero do not support discounts. | [optional] 
**RepeatingInvoiceID** | **Guid** | The Xero identifier for a Repeating Invoice | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

