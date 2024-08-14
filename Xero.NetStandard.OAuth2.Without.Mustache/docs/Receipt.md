# Org.OpenAPITools.Model.Receipt

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **string** | Date of receipt – YYYY-MM-DD | [optional] 
**Contact** | [**Contact**](Contact.md) |  | [optional] 
**LineItems** | [**List&lt;LineItem&gt;**](LineItem.md) |  | [optional] 
**User** | [**User**](User.md) |  | [optional] 
**Reference** | **string** | Additional reference number | [optional] 
**LineAmountTypes** | **LineAmountTypes** |  | [optional] 
**SubTotal** | **double** | Total of receipt excluding taxes | [optional] 
**TotalTax** | **double** | Total tax on receipt | [optional] 
**Total** | **double** | Total of receipt tax inclusive (i.e. SubTotal + TotalTax) | [optional] 
**ReceiptID** | **Guid** | Xero generated unique identifier for receipt | [optional] 
**Status** | **string** | Current status of receipt – see status types | [optional] 
**ReceiptNumber** | **string** | Xero generated sequence number for receipt in current claim for a given user | [optional] [readonly] 
**UpdatedDateUTC** | **string** | Last modified date UTC format | [optional] [readonly] 
**HasAttachments** | **bool** | boolean to indicate if a receipt has an attachment | [optional] [readonly] [default to false]
**Url** | **string** | URL link to a source document – shown as “Go to [appName]” in the Xero app | [optional] [readonly] 
**ValidationErrors** | [**List&lt;ValidationError&gt;**](ValidationError.md) | Displays array of validation error messages from the API | [optional] 
**Warnings** | [**List&lt;ValidationError&gt;**](ValidationError.md) | Displays array of warning messages from the API | [optional] 
**Attachments** | [**List&lt;Attachment&gt;**](Attachment.md) | Displays array of attachments from the API | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

