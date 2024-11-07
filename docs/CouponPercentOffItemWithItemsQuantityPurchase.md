
# com.ultracart.admin.v2.Model.CouponPercentOffItemWithItemsQuantityPurchase

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiscountPercent** | **decimal** | The percentage of subtotal discount | [optional] 
**ItemTags** | **List&lt;string&gt;** | An optional list of item tags which will receive a discount if one of the required purchased items is purchased. | [optional] 
**Items** | **List&lt;string&gt;** | A list of items which will receive a discount if one of the required purchase items is purchased. | [optional] 
**Limit** | **int** | The (optional) maximum quantity of discounted items. | [optional] 
**RequiredPurchaseItems** | **List&lt;string&gt;** | Required items (at least one from the list) that must be purchased for coupon to be valid | [optional] 
**RequiredPurchaseItemsTags** | **List&lt;string&gt;** | Required item tags (at least one from the list) that must be purchase for coupon to be valid. | [optional] 
**RequiredPurchaseQuantity** | **int** | The quantity of items that must be purchased for the discount to be applied. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

