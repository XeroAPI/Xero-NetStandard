# Org.OpenAPITools.Model.Item

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | User defined item code (max length &#x3D; 30) | 
**InventoryAssetAccountCode** | **string** | The inventory asset account for the item. The account must be of type INVENTORY. The  COGSAccountCode in PurchaseDetails is also required to create a tracked item | [optional] 
**Name** | **string** | The name of the item (max length &#x3D; 50) | [optional] 
**IsSold** | **bool** | Boolean value, defaults to true. When IsSold is true the item will be available on sales transactions in the Xero UI. If IsSold is updated to false then Description and SalesDetails values will be nulled. | [optional] 
**IsPurchased** | **bool** | Boolean value, defaults to true. When IsPurchased is true the item is available for purchase transactions in the Xero UI. If IsPurchased is updated to false then PurchaseDescription and PurchaseDetails values will be nulled. | [optional] 
**Description** | **string** | The sales description of the item (max length &#x3D; 4000) | [optional] 
**PurchaseDescription** | **string** | The purchase description of the item (max length &#x3D; 4000) | [optional] 
**PurchaseDetails** | [**Purchase**](Purchase.md) |  | [optional] 
**SalesDetails** | [**Purchase**](Purchase.md) |  | [optional] 
**IsTrackedAsInventory** | **bool** | True for items that are tracked as inventory. An item will be tracked as inventory if the InventoryAssetAccountCode and COGSAccountCode are set. | [optional] 
**TotalCostPool** | **double** | The value of the item on hand. Calculated using average cost accounting. | [optional] 
**QuantityOnHand** | **double** | The quantity of the item on hand | [optional] 
**UpdatedDateUTC** | **string** | Last modified date in UTC format | [optional] [readonly] 
**ItemID** | **Guid** | The Xero identifier for an Item | [optional] 
**StatusAttributeString** | **string** | Status of object | [optional] 
**ValidationErrors** | [**List&lt;ValidationError&gt;**](ValidationError.md) | Displays array of validation error messages from the API | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

