# Org.OpenAPITools.Model.BatchPaymentDetails
Bank details for use on a batch payment stored with each contact

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BankAccountNumber** | **string** | Bank account number for use with Batch Payments | [optional] 
**BankAccountName** | **string** | Name of bank for use with Batch Payments | [optional] 
**Details** | **string** | (Non-NZ Only) These details are sent to the org’s bank as a reference for the batch payment transaction. They will also show with the batch payment transaction in the bank reconciliation Find &amp; Match screen. Depending on your individual bank, the detail may also show on the bank statement imported into Xero. Maximum field length &#x3D; 18 | [optional] 
**Code** | **string** | (NZ Only) Optional references for the batch payment transaction. It will also show with the batch payment transaction in the bank reconciliation Find &amp; Match screen. Depending on your individual bank, the detail may also show on the bank statement you import into Xero. | [optional] 
**Reference** | **string** | (NZ Only) Optional references for the batch payment transaction. It will also show with the batch payment transaction in the bank reconciliation Find &amp; Match screen. Depending on your individual bank, the detail may also show on the bank statement you import into Xero. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

