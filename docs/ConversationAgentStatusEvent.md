
# com.ultracart.admin.v2.Model.ConversationAgentStatusEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgentIdentifier** | **string** | Agent identifier â€” voice_identity for PBX (e.g. &#39;client:login&#39;), participant_arn for chat, synthetic &#39;ai:&lt;user_id&gt;&#39; for AI flag events. Stable across an agent&#39;s events; participates in DDB pk and GSI1 sk. | [optional] 
**AgentName** | **string** | Agent display name at the time of the event | [optional] 
**AgentType** | **string** | Agent type | [optional] 
**AgentUserId** | **string** | Agent user id (links across channels) | [optional] 
**Channel** | **string** | Channel | [optional] 
**CustomStatusName** | **string** | Custom status name (when applicable) | [optional] 
**CustomStatusUuid** | **string** | Custom status uuid (when applicable) | [optional] 
**DurationInPreviousSeconds** | **long** | Time spent in the previous status, in seconds | [optional] 
**EventDts** | **string** | Event timestamp (ISO 8601) | [optional] 
**EventUuid** | **string** | Event UUID (natural key for ES + BQ) | [optional] 
**MerchantId** | **string** | Merchant Id | [optional] 
**NewRoutingEffect** | **string** | Canonical new routing semantic | [optional] 
**NewStatus** | **string** | Channel-native new status name | [optional] 
**ParentMerchantId** | **string** | Parent merchant id (denormalized for ES routing parity) | [optional] 
**PreviousRoutingEffect** | **string** | Canonical previous routing semantic | [optional] 
**PreviousStatus** | **string** | Channel-native previous status name | [optional] 
**Trigger** | **string** | What triggered the transition | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

