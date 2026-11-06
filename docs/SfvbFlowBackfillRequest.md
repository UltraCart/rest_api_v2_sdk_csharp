
# com.ultracart.admin.v2.Model.SfvbFlowBackfillRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DryRun** | **bool** | Count who would be enrolled and enroll nobody. | [optional] 
**FlowUuid** | **string** | The flow.  Used by a flow.backfill approval request.  The backfill call takes it from the path. | [optional] 
**OrderDaysOld** | **int** | For an order trigger, how many days of orders to enroll, 1 to 90 (default 5). | [optional] 
**RelativeToEvent** | **bool** | For an order trigger, shorten the flow&#39;s first wait by each order&#39;s age. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

