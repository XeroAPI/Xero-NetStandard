# Org.OpenAPITools.Model.Employee

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmployeeID** | **Guid** | The Xero identifier for an employee e.g. 297c2dc5-cc47-4afd-8ec8-74990b8761e9 | [optional] 
**Status** | **string** | Current status of an employee – see contact status types | [optional] 
**FirstName** | **string** | First name of an employee (max length &#x3D; 255) | [optional] 
**LastName** | **string** | Last name of an employee (max length &#x3D; 255) | [optional] 
**ExternalLink** | [**ExternalLink**](ExternalLink.md) |  | [optional] 
**UpdatedDateUTC** | **string** |  | [optional] [readonly] 
**StatusAttributeString** | **string** | A string to indicate if a invoice status | [optional] 
**ValidationErrors** | [**List&lt;ValidationError&gt;**](ValidationError.md) | Displays array of validation error messages from the API | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

