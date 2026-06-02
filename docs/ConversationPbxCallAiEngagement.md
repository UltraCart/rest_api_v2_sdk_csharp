
# com.ultracart.admin.v2.Model.ConversationPbxCallAiEngagement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgentName** | **string** | Display name of the AI agent | [optional] 
**AgentUuid** | **string** | UUID of the AI agent configuration used | [optional] 
**Cost** | [**ConversationPbxCallAiCost**](ConversationPbxCallAiCost.md) |  | [optional] 
**EndedAtDts** | **string** | Timestamp when the AI engagement ended | [optional] 
**EngagementType** | **string** | Type of AI engagement | [optional] 
**SessionUuid** | **string** | Unique identifier for this AI engagement session | [optional] 
**StartedAtDts** | **string** | Timestamp when the AI engagement started | [optional] 
**Status** | **string** | Status of the AI engagement | [optional] 
**ToolCalls** | [**List&lt;ConversationPbxCallAiToolCall&gt;**](ConversationPbxCallAiToolCall.md) | List of tool calls made by the AI agent during this engagement | [optional] 
**Whispers** | [**List&lt;ConversationPbxCallAiWhisper&gt;**](ConversationPbxCallAiWhisper.md) | List of coaching whispers sent during this engagement | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

