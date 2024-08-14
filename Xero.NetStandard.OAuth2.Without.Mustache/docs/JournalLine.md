# Org.OpenAPITools.Model.JournalLine

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JournalLineID** | **Guid** | Xero identifier for Journal | [optional] 
**AccountID** | **Guid** | See Accounts | [optional] 
**AccountCode** | **string** | See Accounts | [optional] 
**AccountType** | **AccountType** |  | [optional] 
**AccountName** | **string** | See AccountCodes | [optional] 
**Description** | **string** | The description from the source transaction line item. Only returned if populated. | [optional] 
**NetAmount** | **double** | Net amount of journal line. This will be a positive value for a debit and negative for a credit | [optional] 
**GrossAmount** | **double** | Gross amount of journal line (NetAmount + TaxAmount). | [optional] 
**TaxAmount** | **double** | Total tax on a journal line | [optional] [readonly] 
**TaxType** | **string** | The tax type from taxRates | [optional] 
**TaxName** | **string** | see TaxRates | [optional] 
**TrackingCategories** | [**List&lt;TrackingCategory&gt;**](TrackingCategory.md) | Optional Tracking Category – see Tracking. Any JournalLine can have a maximum of 2 &lt;TrackingCategory&gt; elements. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

