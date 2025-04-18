
# com.ultracart.admin.v2.Model.CouponDiscountItemWithItemPurchase

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrencyCode** | **string** | The ISO-4217 three letter currency code the customer is viewing prices in | [optional] 
**DiscountItem** | **string** | The item that will be sold at the discount_price when required_purchase_item is purchased. | [optional] 
**DiscountItemTags** | **List&lt;string&gt;** | An optional list of item tags which will receive a discount of one of the required purchased items is purchased. | [optional] 
**DiscountPrice** | **decimal** | The price (unit cost) of the discounted item | [optional] 
**Limit** | **int** | The (optional) maximum quantity of discounted items. | [optional] 
**RequiredPurchaseItem** | **string** | The item that must be purchased for the discount to be applied to the discount item. | [optional] 
**RequiredPurchaseItemsTags** | **List&lt;string&gt;** | An optional list of item tags which are required to be purchased. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

