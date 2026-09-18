
# com.ultracart.admin.v2.Model.SfvbPageItemSelector

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttributeName** | **string** | attribute - the item attribute name.  Required with attribute_value. | [optional] 
**AttributeValue** | **string** | attribute - the value to match. | [optional] 
**ItemFolderOid** | **int** | item folder and item folder tree - the item folder, which must exist. | [optional] 
**ManufacturerName** | **string** | manufacturer name - required. | [optional] 
**RetailCostHigh** | **decimal** | retail cost - the highest price. | [optional] 
**RetailCostLow** | **decimal** | retail cost - the lowest price.  At least one of low and high is required. | [optional] 
**SaleItem** | **bool** | sale item - match items on sale. | [optional] 
**Tag** | **string** | tag - the item tag to match.  Required. | [optional] 
**TopSellerCount** | **int** | top seller - how many items, 1 to 250.  Required with top_seller_days. | [optional] 
**TopSellerDays** | **int** | top seller - over how many days, 1 to 180. | [optional] 
**Type** | **string** | One of retail cost, attribute, variation, not variation, manufacturer name, exploded diagram, sale item, item folder, item folder tree, top seller, new, pre-order, tag. | [optional] 
**VariationName** | **string** | variation - the variation name.  Required with variation_value. | [optional] 
**VariationValue** | **string** | variation - the variation value to match. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

