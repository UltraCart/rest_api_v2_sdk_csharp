
# com.ultracart.admin.v2.Model.ConversationWebchatQueueStatusAgent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgentStatus** | **string** | Status of the agent | [optional] 
**AgentUserId** | **string** | Agent user id (populated by Java so the dispatch-scheduler Lambda can read it directly without parsing conversation_participant_arn) | [optional] 
**ConversationParticipantArn** | **string** |  | [optional] 
**ConversationParticipantName** | **string** |  | [optional] 
**CustomStatusName** | **string** | Active custom status display name for this agent (denormalized) | [optional] 
**CustomStatusUuid** | **string** | Active custom status uuid for this agent (null when on a system status) | [optional] 
**LastChatDts** | **string** | Date/time that this agent took their last chat | [optional] 
**NextRoundRobin** | **bool** |  | [optional] 
**ProfileImageUrl** | **string** | Profile image URL | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

