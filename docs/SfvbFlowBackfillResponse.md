
# com.ultracart.admin.v2.Model.SfvbFlowBackfillResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capped** | **bool** | True when the plan&#39;s customer limit stopped the count. | [optional] 
**Customers** | **int** | How many different customers those are. | [optional] 
**DryRun** | **bool** | True when nothing was enrolled. | [optional] 
**Enrollments** | **int** | How many enrollments the backfill makes (a purchased product trigger makes one per item). | [optional] 
**FlowUuid** | **string** | The flow. | [optional] 
**Notes** | **List&lt;string&gt;** | What happens next, in sentences. | [optional] 
**OrderDaysOld** | **int** | The days of orders, for an order trigger. | [optional] 
**RelativeToEvent** | **bool** | Whether the first wait is shortened by each order&#39;s age. | [optional] 
**SegmentRebuildRequired** | **bool** | True when the segment needs a rebuild, so the count is from its last one. | [optional] 
**Started** | **bool** | True when the backfill started in the background.  The signed-in user is emailed when it ends. | [optional] 
**TriggerType** | **string** | The flow&#39;s trigger. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

