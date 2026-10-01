
# com.ultracart.admin.v2.Model.SfvbRecordingEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The event name, such as rage click, script error, checkout error or add to cart. | [optional] 
**Params** | [**List&lt;SfvbRecordingParameter&gt;**](SfvbRecordingParameter.md) | The event&#39;s parameters as name and value pairs.  Omitted for input change events, whose values are what the visitor typed. | [optional] 
**SubText** | **string** | A short human readable summary of the event, when the recorder produced one. | [optional] 
**Timestamp** | **string** | When it happened, ISO-8601 in UTC.  Subtract the page view&#39;s first_event_timestamp for the offset into the replay. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

