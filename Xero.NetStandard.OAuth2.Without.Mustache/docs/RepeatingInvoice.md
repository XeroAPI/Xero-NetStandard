# Org.OpenAPITools.Model.RepeatingInvoice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | See Invoice Types | [optional] 
**Contact** | [**Contact**](Contact.md) |  | [optional] 
**Schedule** | [**Schedule**](Schedule.md) |  | [optional] 
**LineItems** | [**List&lt;LineItem&gt;**](LineItem.md) | See LineItems | [optional] 
**LineAmountTypes** | **LineAmountTypes** |  | [optional] 
**Reference** | **string** | ACCREC only – additional reference number | [optional] 
**BrandingThemeID** | **Guid** | See BrandingThemes | [optional] 
**CurrencyCode** | **CurrencyCode** |  | [optional] 
**Status** | **string** | One of the following - DRAFT or AUTHORISED – See Invoice Status Codes | [optional] 
**SubTotal** | **double** | Total of invoice excluding taxes | [optional] 
**TotalTax** | **double** | Total tax on invoice | [optional] 
**Total** | **double** | Total of Invoice tax inclusive (i.e. SubTotal + TotalTax) | [optional] 
**RepeatingInvoiceID** | **Guid** | Xero generated unique identifier for repeating invoice template | [optional] 
**ID** | **Guid** | Xero generated unique identifier for repeating invoice template | [optional] 
**HasAttachments** | **bool** | Boolean to indicate if an invoice has an attachment | [optional] [readonly] [default to false]
**Attachments** | [**List&lt;Attachment&gt;**](Attachment.md) | Displays array of attachments from the API | [optional] 
**ApprovedForSending** | **bool** | Boolean to indicate whether the invoice has been approved for sending | [optional] [default to false]
**SendCopy** | **bool** | Boolean to indicate whether a copy is sent to sender&#39;s email | [optional] [default to false]
**MarkAsSent** | **bool** | Boolean to indicate whether the invoice in the Xero app displays as \&quot;sent\&quot; | [optional] [default to false]
**IncludePDF** | **bool** | Boolean to indicate whether to include PDF attachment | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

