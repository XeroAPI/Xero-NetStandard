# Org.OpenAPITools.Model.Schedule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Period** | **int** | Integer used with the unit e.g. 1 (every 1 week), 2 (every 2 months) | [optional] 
**Unit** | **string** | One of the following - WEEKLY or MONTHLY | [optional] 
**DueDate** | **int** | Integer used with due date type e.g 20 (of following month), 31 (of current month) | [optional] 
**DueDateType** | **string** | the payment terms | [optional] 
**StartDate** | **string** | Date the first invoice of the current version of the repeating schedule was generated (changes when repeating invoice is edited) | [optional] 
**NextScheduledDate** | **string** | The calendar date of the next invoice in the schedule to be generated | [optional] 
**EndDate** | **string** | Invoice end date – only returned if the template has an end date set | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

