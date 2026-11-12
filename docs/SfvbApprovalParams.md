
# com.ultracart.admin.v2.Model.SfvbApprovalParams

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AffiliateNetworkOid** | **int** | The affiliate network, for affiliate_network.change and affiliate_network.delete.  0 or left out for affiliate_network.change of a network the create call will add. | [optional] 
**AfterStepUuid** | **string** | For sequence_step.move, the step it moves after.  Or branch_step_uuid with side. | [optional] 
**AttributeNames** | **List&lt;string&gt;** | For item.attribute_batch, the attributes the batch would change.  Set by the server. | [optional] 
**BlogPostOid** | **int** | The blog post, for blog_post.delete. | [optional] 
**BranchStepUuid** | **string** | For sequence_step.move, the condition, split or inboxgeek step it moves to the start of a side of. | [optional] 
**ContentSha256** | **string** | For file.put_script, file.put_template and tracking_html.put, the SHA-256 of the exact bytes approved, and for affiliate_network.change the SHA-256 of the conversion pixel.  Set by the server, never by the caller.  The write must send bytes with this hash. | [optional] 
**Domain** | **string** | For sending_domain.delete, the sending domain. | [optional] 
**EspTwilioUuid** | **string** | For twilio_account.delete, the Twilio account&#39;s esp_twilio_uuid, as GET comms/twilio_account returns it. | [optional] 
**ExperimentOid** | **int** | For experiment.end, the experiment to end. | [optional] 
**ItemCount** | **int** | For item.attribute_batch, how many items the batch would change when it was requested.  Set by the server. | [optional] 
**MerchantItemOid** | **int** | For item.pricing, the item whose pricing changes. | [optional] 
**Path** | **string** | The file path, for file.delete, file.put_script and file.put_template, or the page path for experiment.start of a page experiment.  Exactly as the gated call will send it. | [optional] 
**RequestSha256** | **string** | For experiment.start of a url experiment, the hash of the checked experiment approved, for item.pricing, tracking_provider.change and affiliate_network.change the hash of the change, and for smart_attribution.change the hash of the configuration the change would store.  Set by the server.  The gated call must send the same. | [optional] 
**RowsSha256** | **string** | For redirect.delete_batch and item.attribute_batch, the plan_hash of the exact rows approved.  Set by the server.  The batch must send rows with this hash. | [optional] 
**RuleCount** | **int** | For redirect.delete_batch, how many rules the batch would delete when it was requested.  Set by the server. | [optional] 
**SegmentUuid** | **string** | The segment whose rule changes, for segment.update. | [optional] 
**SequenceUuid** | **string** | The communication sequence, for sequence_step.delete, sequence_step.move and sequence_step.enable_postcard. | [optional] 
**Side** | **string** | For sequence_step.move with branch_step_uuid, the side&#39;s label from the sequence read. | [optional] 
**Slot** | **string** | For experiment.start of a page experiment, the page body name, which defaults to body.  For tracking_html.put, tracking or conversion. | [optional] 
**StepUuid** | **string** | The step to remove, for sequence_step.delete, to move, for sequence_step.move, or to turn on, for sequence_step.enable_postcard. | [optional] 
**TrackingProvider** | **string** | The tracking provider key, for tracking_provider.change and tracking_provider.clear. | [optional] 
**UpsellKind** | **string** | For upsell.enable, what to switch on. | [optional] 
**UpsellOid** | **int** | For upsell.enable, the oid of the offer or path to switch on. | [optional] 
**_Version** | **int** | For file.put_script and file.put_template, the history version a revert restores.  Leave it out, and send content instead, for a write. | [optional] 
**WidgetId** | **string** | For experiment.start of a page experiment, the id of the experiment element. | [optional] 
**WinnerVariationNumber** | **int** | For experiment.end, the winning variation.  Leave it out to end without a winner, and leave it out of the end call too. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

