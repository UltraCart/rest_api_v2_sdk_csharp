
# com.ultracart.admin.v2.Model.ConversationAgentStatusTimelineResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallEvents** | [**List&lt;ConversationAgentCallEvent&gt;**](ConversationAgentCallEvent.md) | PBX call records for the agent on the requested day | [optional] 
**ChatEvents** | [**List&lt;ConversationAgentChatEvent&gt;**](ConversationAgentChatEvent.md) | Chat conversations for the agent on the requested day | [optional] 
**Error** | [**Error**](Error.md) |  | [optional] 
**Metadata** | [**ResponseMetadata**](ResponseMetadata.md) |  | [optional] 
**StatusEvents** | [**List&lt;ConversationAgentStatusEvent&gt;**](ConversationAgentStatusEvent.md) | Status transitions for the agent on the requested day | [optional] 
**Success** | **bool** | Indicates if API call was successful | [optional] 
**Summary** | [**TimelineSummary**](TimelineSummary.md) |  | [optional] 
**Warning** | [**Warning**](Warning.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

