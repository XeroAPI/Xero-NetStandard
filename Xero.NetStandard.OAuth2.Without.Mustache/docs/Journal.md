# Org.OpenAPITools.Model.Journal

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JournalID** | **Guid** | Xero identifier | [optional] 
**JournalDate** | **string** | Date the journal was posted | [optional] 
**JournalNumber** | **int** | Xero generated journal number | [optional] 
**CreatedDateUTC** | **string** | Created date UTC format | [optional] [readonly] 
**Reference** | **string** | reference field for additional indetifying information | [optional] 
**SourceID** | **Guid** | The identifier for the source transaction (e.g. InvoiceID) | [optional] 
**SourceType** | **string** | The journal source type. The type of transaction that created the journal | [optional] 
**JournalLines** | [**List&lt;JournalLine&gt;**](JournalLine.md) | See JournalLines | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

