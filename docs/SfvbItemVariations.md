
# com.ultracart.admin.v2.Model.SfvbItemVariations

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Axes** | [**List&lt;SfvbItemVariationAxis&gt;**](SfvbItemVariationAxis.md) | The axes in order.  Empty when the item has no variations. | [optional] 
**Combinations** | [**List&lt;SfvbItemVariationCombination&gt;**](SfvbItemVariationCombination.md) | Every filled combination.  A combination not listed has no child, and shoppers see it as unavailable. | [optional] 
**Description** | **string** | The parent item&#39;s description. | [optional] 
**HashSha256** | **string** | Hash of the variations.  Send it as If-Match on the update. | [optional] 
**MerchantItemId** | **string** | The parent item&#39;s id. | [optional] 
**MerchantItemOid** | **int** | The parent item&#39;s oid. | [optional] 
**UnfilledCombinations** | **int** | How many combinations of the options have no child. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

