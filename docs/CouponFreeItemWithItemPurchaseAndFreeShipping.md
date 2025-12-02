# com.ultracart.admin.v2.Model.CouponFreeItemWithItemPurchaseAndFreeShipping
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Items** | **List&lt;string&gt;** | A list of free items which will receive a discount if one of the required purchase items is purchased. | [optional] 
**Limit** | **int?** | The (optional) maximum quantity of discounted items.  Free shipping will apply to all units of the free item ids though. | [optional] 
**MatchRequiredPurchaseItemToFreeItem** | **bool?** | If true then the free item is matched 1:1 with the free item in the list. | [optional] 
**RequiredPurchaseItems** | **List&lt;string&gt;** | Required items (at least one from the list) that must be purchased for coupon to be valid | [optional] 
**ShippingMethods** | **List&lt;string&gt;** | One or more shipping methods that may be used with this coupon.  If not specified or empty, methods that are marked as qualifies for free shipping will be the only free methods | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

