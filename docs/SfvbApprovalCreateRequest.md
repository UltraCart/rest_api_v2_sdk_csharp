
# com.ultracart.admin.v2.Model.SfvbApprovalCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | The gated action to approve. | [optional] 
**AffiliateNetwork** | [**SfvbAffiliateNetworkRequest**](SfvbAffiliateNetworkRequest.md) |  | [optional] 
**CommsListImport** | [**SfvbCommsProviderImportRequest**](SfvbCommsProviderImportRequest.md) |  | [optional] 
**CommsSettings** | [**SfvbCommsSettingsUpdateRequest**](SfvbCommsSettingsUpdateRequest.md) |  | [optional] 
**Content** | **string** | For a file.put_script write, the exact script to be written, at most 256 KB, and for a file.put_template write the exact template.  For tracking_html.put, the exact HTML the write will send, at most 256 KB.  UltraCart reviews it and keeps only its hash, so send the same bytes again on the write.  Leave it out for a revert, which names params.version. | [optional] 
**DelegateEmail** | **string** | Optional.  The email of a colleague on this account who should decide the request instead of the person who signed in.  They must hold an admin permission that covers the action; they get an email with a link and decide with their own authenticator code.  Any colleague who can&#39;t be used is refused with sfvb.delegate_not_allowed, for every reason alike.  The approval stays yours to poll and use. | [optional] 
**ExperimentStart** | [**SfvbExperimentStartRequest**](SfvbExperimentStartRequest.md) |  | [optional] 
**FlowBackfill** | [**SfvbFlowBackfillRequest**](SfvbFlowBackfillRequest.md) |  | [optional] 
**ItemAttributeRows** | [**List&lt;SfvbItemAttributeBatchRow&gt;**](SfvbItemAttributeBatchRow.md) | For item.attribute_batch, exactly the rows the batch will send - the dry run&#39;s change rows, each with merchant_item_oid and current_sha256.  UltraCart keeps only their hash. | [optional] 
**ItemDefaultPageRows** | [**List&lt;SfvbItemDefaultPageRow&gt;**](SfvbItemDefaultPageRow.md) | For item.default_page, exactly the rows the apply will send - the dry run&#39;s ready rows, each with merchant_item_oid, page_oid and current_sha256.  UltraCart keeps only their hash. | [optional] 
**ItemPreorder** | [**SfvbItemPreorderRequest**](SfvbItemPreorderRequest.md) |  | [optional] 
**ItemPreorderChildren** | [**SfvbItemPreorderChildrenRequest**](SfvbItemPreorderChildrenRequest.md) |  | [optional] 
**ItemPricing** | [**SfvbItemPricingRequest**](SfvbItemPricingRequest.md) |  | [optional] 
**ItemVariations** | [**SfvbItemVariationsRequest**](SfvbItemVariationsRequest.md) |  | [optional] 
**Params** | [**SfvbApprovalParams**](SfvbApprovalParams.md) |  | [optional] 
**PostcardTestMail** | [**SfvbCommsTestPostcardRequest**](SfvbCommsTestPostcardRequest.md) |  | [optional] 
**Reason** | **string** | Why the agent wants to do this, in a sentence.  Shown to the person as unverified text, capped at 500 characters. | [optional] 
**RedirectRows** | [**List&lt;SfvbRedirectDeleteRow&gt;**](SfvbRedirectDeleteRow.md) | For redirect.delete_batch, exactly the rows the batch delete will send, up to 5,000, each with its hash_sha256.  UltraCart keeps only their hash. | [optional] 
**SegmentUpdate** | [**SfvbCommsSegmentWriteRequest**](SfvbCommsSegmentWriteRequest.md) |  | [optional] 
**SiteSeo** | [**SfvbSiteSeoRequest**](SfvbSiteSeoRequest.md) |  | [optional] 
**SmartAttribution** | [**SfvbSmartAttributionRequest**](SfvbSmartAttributionRequest.md) |  | [optional] 
**TrackingProvider** | [**SfvbTrackingProviderRequest**](SfvbTrackingProviderRequest.md) |  | [optional] 
**TransactionalEmail** | [**SfvbTransactionalEmailUpdateRequest**](SfvbTransactionalEmailUpdateRequest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

