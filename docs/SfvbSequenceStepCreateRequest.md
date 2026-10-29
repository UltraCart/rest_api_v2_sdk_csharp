
# com.ultracart.admin.v2.Model.SfvbSequenceStepCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AfterStepUuid** | **string** | The step the new step follows, in the same list.  Not an end, continue or merge step. | [optional] 
**BranchStepUuid** | **string** | A condition, split or inboxgeek step.  With side, the new step goes first on that side. | [optional] 
**PreviewText** | **string** | The new email&#39;s preview text, 5 to 150 characters. | [optional] 
**Side** | **string** | With branch_step_uuid, the side&#39;s label from the sequence read.  yes or no for a condition, left or right for a split or inboxgeek step. | [optional] 
**Subject** | **string** | The new email&#39;s subject line, 5 to 150 characters. | [optional] 
**Type** | **string** | The kind of step.  Only email for now. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

