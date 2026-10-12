
# com.ultracart.admin.v2.Model.SfvbEventsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Events** | [**List&lt;SfvbEvent&gt;**](SfvbEvent.md) | Oldest first. | [optional] 
**More** | **bool** | True when more events follow.  Ask again with after set to the last event_id. | [optional] 
**ResyncRequired** | **bool** | True when the cursor is older than the 72 hours of events kept.  Re-list what you were waiting on instead of replaying. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

