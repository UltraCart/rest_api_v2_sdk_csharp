# com.ultracart.admin.v2.Model.ConversationPbxCall
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountSid** | **string** | Twilio account SID | [optional] 
**Agents** | [**List&lt;ConversationPbxCallAgent&gt;**](ConversationPbxCallAgent.md) | List of agents who participated in this call | [optional] 
**AiAgentEngagements** | [**List&lt;ConversationPbxCallAiEngagement&gt;**](ConversationPbxCallAiEngagement.md) | List of AI agent engagements during the call | [optional] 
**CallSid** | **string** | Twilio call SID for the primary (customer) call leg | [optional] 
**CallUuid** | **string** | Unique identifier for this call record | [optional] 
**Caller** | [**ConversationPbxCallCaller**](ConversationPbxCallCaller.md) |  | [optional] 
**ConferenceSid** | **string** | Twilio conference SID if this call used conferencing | [optional] 
**CreatedAtDts** | **string** | Timestamp when the call record was created | [optional] 
**CustomerName** | **string** | Customer name associated with this call | [optional] 
**CustomerProfileOid** | **string** | UltraCart customer profile OID if the caller was matched to a customer | [optional] 
**Disposition** | **string** | Call disposition describing how the call ended | [optional] 
**Email** | **string** | Email address of the caller if known | [optional] 
**Financial** | [**ConversationPbxCallFinancial**](ConversationPbxCallFinancial.md) |  | [optional] 
**Holds** | [**List&lt;ConversationPbxCallHold&gt;**](ConversationPbxCallHold.md) | List of hold events during the call | [optional] 
**MerchantId** | **string** | Merchant identifier | [optional] 
**RecordingSids** | **List&lt;string&gt;** | List of all Twilio recording SIDs associated with this call | [optional] 
**Recordings** | [**List&lt;ConversationPbxCallRecording&gt;**](ConversationPbxCallRecording.md) | List of recordings made during the call | [optional] 
**Routing** | [**ConversationPbxCallRouting**](ConversationPbxCallRouting.md) |  | [optional] 
**Status** | **string** | Final status of the call | [optional] 
**Timeline** | [**ConversationPbxCallTimeline**](ConversationPbxCallTimeline.md) |  | [optional] 
**Transfers** | [**List&lt;ConversationPbxCallTransfer&gt;**](ConversationPbxCallTransfer.md) | List of transfer events during the call | [optional] 
**UpdatedAtDts** | **string** | Timestamp when the call record was last updated | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

