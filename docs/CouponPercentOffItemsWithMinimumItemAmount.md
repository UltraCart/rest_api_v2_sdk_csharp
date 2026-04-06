
# com.ultracart.admin.v2.Model.CouponPercentOffItemsWithMinimumItemAmount

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrencyCode** | **string** | The ISO-4217 three letter currency code the customer is viewing prices in | [optional] 
**DiscountPercent** | **decimal** | The percentage of subtotal discount | [optional] 
**ExcludedItemTags** | **List&lt;string&gt;** | A list of item tags which cannot be discounted. | [optional] 
**ExcludedItems** | **List&lt;string&gt;** | A list of items which cannot be discounted. | [optional] 
**ItemTags** | **List&lt;string&gt;** | An optional list of item tags which will receive a discount.  If blank, discount applies to all items except excluded items. | [optional] 
**Items** | **List&lt;string&gt;** | An optional list of items which will receive a discount.  If blank, discount applies to all items except excluded items. | [optional] 
**Limit** | **int** | The (optional) maximum quantity of discounted items. | [optional] 
**MinimumItemAmount** | **decimal** | The minimum item amount (dollars) required for the discount to apply | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

