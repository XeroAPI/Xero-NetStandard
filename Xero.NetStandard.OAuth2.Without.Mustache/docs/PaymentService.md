# Org.OpenAPITools.Model.PaymentService

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentServiceID** | **Guid** | Xero identifier | [optional] 
**PaymentServiceName** | **string** | Name of payment service | [optional] 
**PaymentServiceUrl** | **string** | The custom payment URL | [optional] 
**PayNowText** | **string** | The text displayed on the Pay Now button in Xero Online Invoicing. If this is not set it will default to Pay by credit card | [optional] 
**PaymentServiceType** | **string** | This will always be CUSTOM for payment services created via the API. | [optional] 
**ValidationErrors** | [**List&lt;ValidationError&gt;**](ValidationError.md) | Displays array of validation error messages from the API | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

