
# com.ultracart.admin.v2.Model.CouponTieredPercentOffItems

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemTags** | **List&lt;string&gt;** | An optional list of item tags which will receive a discount.  If blank, discount applies to all items except excluded items. | [optional] 
**Items** | **List&lt;string&gt;** | A list of items of which at least one must be purchased for coupon to be valid. | [optional] 
**Limit** | **decimal** | The (optional) maximum quantity of discounted items. | [optional] 
**Tiers** | [**List&lt;CouponTierQuantityPercent&gt;**](CouponTierQuantityPercent.md) | A list of discount tiers. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

