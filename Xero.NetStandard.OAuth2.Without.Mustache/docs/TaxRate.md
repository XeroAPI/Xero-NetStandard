# Org.OpenAPITools.Model.TaxRate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of tax rate | [optional] 
**TaxType** | **string** | The tax type | [optional] 
**TaxComponents** | [**List&lt;TaxComponent&gt;**](TaxComponent.md) | See TaxComponents | [optional] 
**Status** | **string** | See Status Codes | [optional] 
**ReportTaxType** | **string** | See ReportTaxTypes | [optional] 
**CanApplyToAssets** | **bool** | Boolean to describe if tax rate can be used for asset accounts i.e.  true,false | [optional] [readonly] 
**CanApplyToEquity** | **bool** | Boolean to describe if tax rate can be used for equity accounts i.e true,false | [optional] [readonly] 
**CanApplyToExpenses** | **bool** | Boolean to describe if tax rate can be used for expense accounts  i.e. true,false | [optional] [readonly] 
**CanApplyToLiabilities** | **bool** | Boolean to describe if tax rate can be used for liability accounts  i.e. true,false | [optional] [readonly] 
**CanApplyToRevenue** | **bool** | Boolean to describe if tax rate can be used for revenue accounts i.e. true,false | [optional] [readonly] 
**DisplayTaxRate** | **double** | Tax Rate (decimal to 4dp) e.g 12.5000 | [optional] [readonly] 
**EffectiveRate** | **double** | Effective Tax Rate (decimal to 4dp) e.g 12.5000 | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

