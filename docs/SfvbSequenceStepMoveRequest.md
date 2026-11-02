
# com.ultracart.admin.v2.Model.SfvbSequenceStepMoveRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AfterStepUuid** | **string** | The step it moves after, in that step&#39;s list.  The begin step puts it first in the sequence.  Not an end, continue or merge step. | [optional] 
**AnchorHashSha256** | **string** | The hash_sha256 of after_step_uuid, or of branch_step_uuid, from the last read.  Required; 412 when stale. | [optional] 
**BranchStepUuid** | **string** | A condition, split or inboxgeek step.  With side, the step moves to the start of that side. | [optional] 
**Side** | **string** | With branch_step_uuid, the side&#39;s label from the sequence read.  yes or no for a condition, left or right for a split or inboxgeek step. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

