# Org.OpenAPITools.Model.PurchaseOrder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Contact** | [**Contact**](Contact.md) |  | [optional] 
**LineItems** | [**List&lt;LineItem&gt;**](LineItem.md) | See LineItems | [optional] 
**Date** | **string** | Date purchase order was issued – YYYY-MM-DD. If the Date element is not specified then it will default to the current date based on the timezone setting of the organisation | [optional] 
**DeliveryDate** | **string** | Date the goods are to be delivered – YYYY-MM-DD | [optional] 
**LineAmountTypes** | **LineAmountTypes** |  | [optional] 
**PurchaseOrderNumber** | **string** | Unique alpha numeric code identifying purchase order (when missing will auto-generate from your Organisation Invoice Settings) | [optional] 
**Reference** | **string** | Additional reference number | [optional] 
**BrandingThemeID** | **Guid** | See BrandingThemes | [optional] 
**CurrencyCode** | **CurrencyCode** |  | [optional] 
**Status** | **string** | See Purchase Order Status Codes | [optional] 
**SentToContact** | **bool** | Boolean to set whether the purchase order should be marked as “sent”. This can be set only on purchase orders that have been approved or billed | [optional] 
**DeliveryAddress** | **string** | The address the goods are to be delivered to | [optional] 
**AttentionTo** | **string** | The person that the delivery is going to | [optional] 
**Telephone** | **string** | The phone number for the person accepting the delivery | [optional] 
**DeliveryInstructions** | **string** | A free text feild for instructions (500 characters max) | [optional] 
**ExpectedArrivalDate** | **string** | The date the goods are expected to arrive. | [optional] 
**PurchaseOrderID** | **Guid** | Xero generated unique identifier for purchase order | [optional] 
**CurrencyRate** | **double** | The currency rate for a multicurrency purchase order. If no rate is specified, the XE.com day rate is used. | [optional] 
**SubTotal** | **double** | Total of purchase order excluding taxes | [optional] [readonly] 
**TotalTax** | **double** | Total tax on purchase order | [optional] [readonly] 
**Total** | **double** | Total of Purchase Order tax inclusive (i.e. SubTotal + TotalTax) | [optional] [readonly] 
**TotalDiscount** | **double** | Total of discounts applied on the purchase order line items | [optional] [readonly] 
**HasAttachments** | **bool** | boolean to indicate if a purchase order has an attachment | [optional] [readonly] [default to false]
**UpdatedDateUTC** | **string** | Last modified date UTC format | [optional] [readonly] 
**StatusAttributeString** | **string** | A string to indicate if a invoice status | [optional] 
**ValidationErrors** | [**List&lt;ValidationError&gt;**](ValidationError.md) | Displays array of validation error messages from the API | [optional] 
**Warnings** | [**List&lt;ValidationError&gt;**](ValidationError.md) | Displays array of warning messages from the API | [optional] 
**Attachments** | [**List&lt;Attachment&gt;**](Attachment.md) | Displays array of attachments from the API | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

