
# com.ultracart.admin.v2.Model.CouponAmountOffItemsAndFreeShipping

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrencyCode** | **string** | The ISO-4217 three letter currency code the customer is viewing prices in | [optional] 
**DiscountAmount** | **decimal** | The amount of discount | [optional] 
**ItemTags** | **List&lt;string&gt;** | An optional list of item tags which will receive a discount. | [optional] 
**Items** | **List&lt;string&gt;** | A list of items which are eligible for the discount amount. | [optional] 
**Limit** | **int** | The limit of items which are eligible for the discount amount. | [optional] 
**ShippingMethods** | **List&lt;string&gt;** | One or more shipping methods that may be used with this coupon.  If not specified or empty, methods that are marked as qualifies for free shipping will be the only free methods | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

