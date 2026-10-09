
# com.ultracart.admin.v2.Model.SfvbApprovalCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | The gated action to approve. | [optional] 
**Content** | **string** | For a file.put_script write, the exact script to be written, at most 256 KB.  UltraCart reviews it and keeps only its hash, so send the same bytes again on the write.  Leave it out for a revert, which names params.version. | [optional] 
**ExperimentStart** | [**SfvbExperimentStartRequest**](SfvbExperimentStartRequest.md) |  | [optional] 
**ItemAttributeRows** | [**List&lt;SfvbItemAttributeBatchRow&gt;**](SfvbItemAttributeBatchRow.md) | For item.attribute_batch, exactly the rows the batch will send - the dry run&#39;s change rows, each with merchant_item_oid and current_sha256.  UltraCart keeps only their hash. | [optional] 
**ItemPricing** | [**SfvbItemPricingRequest**](SfvbItemPricingRequest.md) |  | [optional] 
**Params** | [**SfvbApprovalParams**](SfvbApprovalParams.md) |  | [optional] 
**Reason** | **string** | Why the agent wants to do this, in a sentence.  Shown to the person as unverified text, capped at 500 characters. | [optional] 
**RedirectRows** | [**List&lt;SfvbRedirectDeleteRow&gt;**](SfvbRedirectDeleteRow.md) | For redirect.delete_batch, exactly the rows the batch delete will send, up to 5,000, each with its hash_sha256.  UltraCart keeps only their hash. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

