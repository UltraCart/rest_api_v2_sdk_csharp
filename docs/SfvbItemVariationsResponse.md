
# com.ultracart.admin.v2.Model.SfvbItemVariationsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApprovalNeeded** | **bool** | True when the change needs an approved item.variations request. | [optional] 
**Axes** | [**List&lt;SfvbItemVariationAxis&gt;**](SfvbItemVariationAxis.md) | The axes in order. | [optional] 
**Changes** | [**List&lt;SfvbItemVariationChangeResult&gt;**](SfvbItemVariationChangeResult.md) | What each change did, or would do on a dry run. | [optional] 
**Combinations** | [**List&lt;SfvbItemVariationCombination&gt;**](SfvbItemVariationCombination.md) | Every filled combination. | [optional] 
**Description** | **string** | The parent item&#39;s description. | [optional] 
**DryRun** | **bool** | True when nothing was saved. | [optional] 
**HashSha256** | **string** | Hash of the variations as returned. | [optional] 
**MerchantItemId** | **string** | The parent item&#39;s id. | [optional] 
**MerchantItemOid** | **int** | The parent item&#39;s oid. | [optional] 
**UnfilledCombinations** | **int** | How many combinations of the options have no child. | [optional] 
**Warnings** | **List&lt;string&gt;** | Things worth knowing, such as combinations left unfilled. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

