
# com.ultracart.admin.v2.Model.SfvbApprovalParams

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttributeNames** | **List&lt;string&gt;** | For item.attribute_batch, the attributes the batch would change.  Set by the server. | [optional] 
**BlogPostOid** | **int** | The blog post, for blog_post.delete. | [optional] 
**ContentSha256** | **string** | For file.put_script, the SHA-256 of the exact bytes approved.  Set by the server, never by the caller.  The write must send bytes with this hash. | [optional] 
**ExperimentOid** | **int** | For experiment.end, the experiment to end. | [optional] 
**ItemCount** | **int** | For item.attribute_batch, how many items the batch would change when it was requested.  Set by the server. | [optional] 
**MerchantItemOid** | **int** | For item.pricing, the item whose pricing changes. | [optional] 
**Path** | **string** | The file path, for file.delete and file.put_script, or the page path for experiment.start of a page experiment.  Exactly as the gated call will send it. | [optional] 
**RequestSha256** | **string** | For experiment.start of a url experiment, the hash of the checked experiment approved, and for item.pricing the hash of the change.  Set by the server.  The gated call must send the same. | [optional] 
**RowsSha256** | **string** | For redirect.delete_batch and item.attribute_batch, the plan_hash of the exact rows approved.  Set by the server.  The batch must send rows with this hash. | [optional] 
**RuleCount** | **int** | For redirect.delete_batch, how many rules the batch would delete when it was requested.  Set by the server. | [optional] 
**Slot** | **string** | For experiment.start of a page experiment, the page body name.  Defaults to body. | [optional] 
**UpsellKind** | **string** | For upsell.enable, what to switch on. | [optional] 
**UpsellOid** | **int** | For upsell.enable, the oid of the offer or path to switch on. | [optional] 
**_Version** | **int** | For file.put_script, the history version a revert restores.  Leave it out, and send content instead, for a write. | [optional] 
**WidgetId** | **string** | For experiment.start of a page experiment, the id of the experiment element. | [optional] 
**WinnerVariationNumber** | **int** | For experiment.end, the winning variation.  Leave it out to end without a winner, and leave it out of the end call too. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

