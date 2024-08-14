# Org.OpenAPITools.Model.ManualJournal

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Narration** | **string** | Description of journal being posted | 
**JournalLines** | [**List&lt;ManualJournalLine&gt;**](ManualJournalLine.md) | See JournalLines | [optional] 
**Date** | **string** | Date journal was posted – YYYY-MM-DD | [optional] 
**LineAmountTypes** | **LineAmountTypes** |  | [optional] 
**Status** | **string** | See Manual Journal Status Codes | [optional] 
**Url** | **string** | Url link to a source document – shown as “Go to [appName]” in the Xero app | [optional] 
**ShowOnCashBasisReports** | **bool** | Boolean – default is true if not specified | [optional] 
**HasAttachments** | **bool** | Boolean to indicate if a manual journal has an attachment | [optional] [readonly] [default to false]
**UpdatedDateUTC** | **string** | Last modified date UTC format | [optional] [readonly] 
**ManualJournalID** | **Guid** | The Xero identifier for a Manual Journal | [optional] 
**StatusAttributeString** | **string** | A string to indicate if a invoice status | [optional] 
**Warnings** | [**List&lt;ValidationError&gt;**](ValidationError.md) | Displays array of warning messages from the API | [optional] 
**ValidationErrors** | [**List&lt;ValidationError&gt;**](ValidationError.md) | Displays array of validation error messages from the API | [optional] 
**Attachments** | [**List&lt;Attachment&gt;**](Attachment.md) | Displays array of attachments from the API | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

