# com.ultracart.admin.v2.Model.CouponPercentOffItems
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiscountPercent** | **decimal?** | The percentage of subtotal discount | [optional] 
**ExcludedItemTags** | **List&lt;string&gt;** | A list of item tags which cannot be discounted. | [optional] 
**ExcludedItems** | **List&lt;string&gt;** | A list of items which cannot be discounted. | [optional] 
**ItemTags** | **List&lt;string&gt;** | An optional list of item tags which will receive a discount.  If blank, discount applies to all items except excluded items. | [optional] 
**Items** | **List&lt;string&gt;** | An optional list of items which will receive a discount.  If blank, discount applies to all items except excluded items. | [optional] 
**Limit** | **int?** | The (optional) maximum quantity of discounted items. | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

