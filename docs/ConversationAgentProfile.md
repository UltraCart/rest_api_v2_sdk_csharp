
# com.ultracart.admin.v2.Model.ConversationAgentProfile

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ai** | **bool** | AI powered chat bot | [optional] 
**AiCapabilities** | [**ConversationVirtualAgentCapabilities**](ConversationVirtualAgentCapabilities.md) |  | [optional] 
**AiChatInstructions** | **string** | Additional instructions for this AI when handle web chats | [optional] 
**AiPersona** | **string** | Persona of this AI agent | [optional] 
**AiSmsInstructions** | **string** | Additional instructions for this AI when handle SMS messages | [optional] 
**AiTicketInstructions** | **string** | Additional instructions for this AI when handling ticket draft replies | [optional] 
**ChatLimit** | **int** | The number of engagement chats that can be pushed on them at any given time. | [optional] 
**DefaultLanguageIsoCode** | **string** | The default language the agent is chatting in | [optional] 
**DefaultStatus** | **string** | Default status when the agent loads conversations app. | [optional] 
**DisplayName** | **string** | An alternate name that the agent wants to use in chat. | [optional] 
**Name** | **string** | Their actual user name for profile settings display as placeholder test | [optional] 
**ProfileImageUploadKey** | **string** | An upload key used to update the profile image. | [optional] 
**ProfileImageUrl** | **string** | Their current profile image URL | [optional] 
**UserId** | **int** | User ID associated with the agent.  Populated by getAgentProfiles call only. | [optional] 
**ZohodeskClassifications** | **List&lt;string&gt;** | Restrict this agent to drafting replies only to tickets with these classifications | [optional] 
**ZohodeskDepartments** | **List&lt;string&gt;** | Restrict this agent to drafting replies only to these department ids | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

