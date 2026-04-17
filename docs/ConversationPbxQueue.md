
# com.ultracart.admin.v2.Model.ConversationPbxQueue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AiPriority** | **string** | AI Agent Priority compared to human agents | [optional] 
**AiSummaryEnabled** | **bool** | If true, AI summaries are generated for answered calls in this queue | [optional] 
**AiSummaryInstructions** | **string** | Custom instructions injected into the AI summary system prompt for this queue | [optional] 
**AiTimeoutSeconds** | **int** | AI timeout seconds | [optional] 
**AnnounceQueuePosition** | **bool** | If true, the customer is told their queue position upon entering the queue | [optional] 
**AutomaticCoachAgentUuid** | **string** | AI Agent UUID to automatically engage to provide coaching | [optional] 
**CallbackAnnounceAudioUuid** | **string** | Custom audio file UUID for the callback offer prompt | [optional] 
**CallbackAnnounceSay** | **string** | Custom TTS text for the callback offer prompt | [optional] 
**CallbackConfirmAudioUuid** | **string** | Custom audio file UUID for the callback confirmation message | [optional] 
**CallbackConfirmSay** | **string** | Custom TTS text for the callback confirmation message | [optional] 
**CallbackEnabled** | **bool** | If true, the callback option is enabled for this queue | [optional] 
**CallbackHoursOnly** | **bool** | When true, only offer callbacks during business hours | [optional] 
**CallbackMaxAttempts** | **int** | Maximum number of times the system will attempt to call the customer back | [optional] 
**CallbackMaxOffers** | **int** | Maximum number of times the callback option is offered to a caller per call | [optional] 
**CallbackMaxPending** | **int** | Maximum number of pending callbacks allowed per queue | [optional] 
**CallbackOfferAfterSeconds** | **int** | Seconds a caller must wait in queue before the callback option is offered | [optional] 
**CallbackOfferIntervalSeconds** | **int** | Seconds between repeat callback offers to the same caller | [optional] 
**CallbackRetryDelaySeconds** | **int** | Delay in seconds between callback retry attempts | [optional] 
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
**ZohoDeskDepartmentId** | **string** | Zoho Desk department ID to create tickets in | [optional] 
**ZohoDeskTicketEnabled** | **bool** | If true, a Zoho Desk ticket is automatically created for answered calls in this queue | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

