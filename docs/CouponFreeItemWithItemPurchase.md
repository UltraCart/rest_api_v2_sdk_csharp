# com.ultracart.admin.v2.Model.CouponFreeItemWithItemPurchase
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemTags** | **List&lt;string&gt;** | An optional list of item tags which will receive a discount of one of the required purchased items is purchased. | [optional] 
**Items** | **List&lt;string&gt;** | A list of free items which will receive a discount if one of the required purchase items is purchased. | [optional] 
**Limit** | **int?** | The (optional) maximum quantity of discounted items. | [optional] 
**MatchRequiredPurchaseItemToFreeItem** | **bool?** | If true then the free item is matched 1:1 with the free item in the list. | [optional] 
**RequiredPurchaseItems** | **List&lt;string&gt;** | Required items (at least one from the list) that must be purchased for coupon to be valid | [optional] 
**RequiredPurchaseItemsTags** | **List&lt;string&gt;** | An optional list of item tags which are required to be purchased. | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

