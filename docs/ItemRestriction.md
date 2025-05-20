# com.ultracart.admin.v2.Model.ItemRestriction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExcludeCoupon** | **bool?** | Exclude coupons | [optional] 
**ExcludeFromFreePromotion** | **bool?** | Exclude from free promotion | [optional] 
**ExcludeFromLoyalty** | **bool?** | Exclude from loyalty.  Must be set to true or false to save.  Null is ignored for backwards SDK compatibility | [optional] 
**Items** | [**List&lt;ItemRestrictionItem&gt;**](ItemRestrictionItem.md) | Items | [optional] 
**MaximumQuantity** | **int?** | Maximum quantity | [optional] 
**MinimumQuantity** | **int?** | Minimum quantity (defaults to 1) | [optional] 
**MultipleQuantity** | **int?** | Multiple of quantity | [optional] 
**OnePerCustomer** | **bool?** | One per customer | [optional] 
**PurchaseSeparately** | **bool?** | Purchase separately | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

