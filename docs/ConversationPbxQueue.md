
# com.ultracart.admin.v2.Model.ConversationPbxQueue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnnounceQueuePosition** | **bool** | If true, the customer is told their queue position upon entering the queue | [optional] 
**ConversationPbxQueueUuid** | **string** | Conversation Pbx Queue unique identifier | [optional] 
**ConversationVoicemailMailboxUuid** | **string** | The voicemail mailbox associated with this queue | [optional] 
**HoldConversationPbxAudioUuid** | **string** | The audio to play while holding in a queue | [optional] 
**MaxHoldSeconds** | **int** | The maximum number of seconds for a customer to hold in a queue | [optional] 
**Members** | [**ConversationPbxQueueMembers**](ConversationPbxQueueMembers.md) |  | [optional] 
**MerchantId** | **string** | Merchant Id | [optional] 
**Name** | **string** | Name of queue | [optional] 
**NoAgentAvailablePlayAudioUuid** | **string** | When no agent is available after the max_hold_seconds, say this | [optional] 
**NoAgentAvailableSay** | **string** | When no agent is available after the max_hold_seconds, say this | [optional] 
**NoAgentAvailableSayVoice** | **string** | The type of voice used to say text when no agent is available | [optional] 
**PlayAudioUuid** | **string** | Audio played when customer enters a queue | [optional] 
**RecordCall** | **bool** | If true, any calls in this queue are recorded | [optional] 
**Say** | **string** | Say text when a customer enters queue | [optional] 
**SayVoice** | **string** | The type of voice to use when say text is spoken | [optional] 
**TwilioTaskrouterWorkflowSid** | **string** | Twilio taskrouter workflow sid | [optional] 
**TwilioWorkspaceQueueSid** | **string** | Twilio workspace queue sid | [optional] 
**Voicemail** | **bool** | If true, this queue has a voicemail associated with it | [optional] 
**WaitCriticalSeconds** | **int** | Wait time in seconds before critical | [optional] 
**WaitWarningSeconds** | **int** | Wait time in seconds before warning | [optional] 
**WrapUpSeconds** | **int** | Wrap up time in seconds | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

