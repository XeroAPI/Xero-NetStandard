# Org.OpenAPITools.Model.Account

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | Customer defined alpha numeric account code e.g 200 or SALES (max length &#x3D; 10) | [optional] 
**Name** | **string** | Name of account (max length &#x3D; 150) | [optional] 
**AccountID** | **Guid** | The Xero identifier for an account – specified as a string following  the endpoint name   e.g. /297c2dc5-cc47-4afd-8ec8-74990b8761e9 | [optional] 
**Type** | **AccountType** |  | [optional] 
**BankAccountNumber** | **string** | For bank accounts only (Account Type BANK) | [optional] 
**Status** | **string** | Accounts with a status of ACTIVE can be updated to ARCHIVED. See Account Status Codes | [optional] 
**Description** | **string** | Description of the Account. Valid for all types of accounts except bank accounts (max length &#x3D; 4000) | [optional] 
**BankAccountType** | **string** | For bank accounts only. See Bank Account types | [optional] 
**CurrencyCode** | **CurrencyCode** |  | [optional] 
**TaxType** | **string** | The tax type from taxRates | [optional] 
**EnablePaymentsToAccount** | **bool** | Boolean – describes whether account can have payments applied to it | [optional] 
**ShowInExpenseClaims** | **bool** | Boolean – describes whether account code is available for use with expense claims | [optional] 
**Class** | **string** | See Account Class Types | [optional] [readonly] 
**SystemAccount** | **string** | If this is a system account then this element is returned. See System Account types. Note that non-system accounts may have this element set as either “” or null. | [optional] [readonly] 
**ReportingCode** | **string** | Shown if set | [optional] 
**ReportingCodeName** | **string** | Shown if set | [optional] [readonly] 
**HasAttachments** | **bool** | boolean to indicate if an account has an attachment (read only) | [optional] [readonly] [default to false]
**UpdatedDateUTC** | **string** | Last modified date UTC format | [optional] [readonly] 
**AddToWatchlist** | **bool** | Boolean – describes whether the account is shown in the watchlist widget on the dashboard | [optional] 
**ValidationErrors** | [**List&lt;ValidationError&gt;**](ValidationError.md) | Displays array of validation error messages from the API | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

