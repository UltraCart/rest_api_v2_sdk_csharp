
# com.ultracart.admin.v2.Model.ConversationAgentStatusConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** | Whether the status is active and selectable. DELETE soft-deactivates by setting this to false. | [optional] 
**Channel** | **string** | Channel this status applies to | [optional] 
**Color** | **string** | Hex color for UI (e.g. &#39;#FF5733&#39;) | [optional] 
**ConversationStatusUuid** | **string** | Conversation agent status unique identifier | [optional] 
**CreatedAt** | **string** | Created at | [optional] 
**Icon** | **string** | Icon name | [optional] 
**MerchantId** | **string** | Merchant Id | [optional] 
**Name** | **string** | Display name shown to agents | [optional] 
**ParentStatus** | **string** | Channel-native parent status | [optional] 
**RoutingEffect** | **string** | Canonical routing semantic. Derived server-side from (channel, parent_status). | [optional] 
**SortOrder** | **int** | Sort order in lists; lower &#x3D; first | [optional] 
**TwilioActivitySid** | **string** | Twilio TaskRouter Activity SID (PBX-only; null for chat-only statuses) | [optional] 
**UpdatedAt** | **string** | Updated at | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

