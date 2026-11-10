
# com.ultracart.admin.v2.Model.SfvbItemPreorder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Changed** | [**SfvbItemPreorderChange**](SfvbItemPreorderChange.md) |  | [optional] 
**Eta** | **string** | The expected date, YYYY-MM-DD, or null when none is set. | [optional] 
**HashSha256** | **string** | The hash of preorder and eta.  Send it as If-Match, or as the row&#39;s hash_sha256, to change them. | [optional] 
**MerchantItemId** | **string** | The item&#39;s merchant item id. | [optional] 
**MerchantItemOid** | **int** | The item. | [optional] 
**Preorder** | **bool** | True when the item is on pre-order.  Shoppers can order it while out of stock, and its orders go to the Pre-ordered stage. | [optional] 
**ShoppersSee** | **string** | What itempreorder shows.  preorder_with_eta when on pre-order with an ETA of today or later, preorder_no_eta when on pre-order with no ETA or a past one, nothing when not on pre-order. | [optional] 
**ShoppersSeeText** | **string** | shoppers_see in words, such as on pre-order, ETA 2026-11-20. | [optional] 
**VariationValues** | [**List&lt;SfvbItemPreorderOption&gt;**](SfvbItemPreorderOption.md) | For a variation listed under its parent, the option values that pick it, such as Size 2T. | [optional] 
**Warnings** | **List&lt;string&gt;** | After a change, things worth knowing about the new values, such as an ETA in the past.  Never a refusal. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

