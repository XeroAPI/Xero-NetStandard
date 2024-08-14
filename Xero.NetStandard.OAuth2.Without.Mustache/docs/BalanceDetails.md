# Org.OpenAPITools.Model.BalanceDetails
An array to specify multiple currency balances of an account

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Balance** | **double** | The opening balances of the account. Debits are positive, credits are negative values | [optional] 
**CurrencyCode** | **string** | The currency of the balance (Not required for base currency) | [optional] 
**CurrencyRate** | **double** | (Optional) Exchange rate to base currency when money is spent or received. If not specified, XE rate for the day is applied | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

