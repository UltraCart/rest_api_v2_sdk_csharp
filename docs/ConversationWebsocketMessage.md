
# com.ultracart.admin.v2.Model.ConversationWebsocketMessage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConversationUuid** | **string** | Conversation UUID if the websocket message is tied to a specific conversation | [optional] 
**EventAddCoupon** | [**ConversationEventAddCoupon**](ConversationEventAddCoupon.md) |  | [optional] 
**EventAddItem** | [**ConversationEventAddItem**](ConversationEventAddItem.md) |  | [optional] 
**EventConversationClosed** | [**ConversationSummary**](ConversationSummary.md) |  | [optional] 
**EventNewConversation** | [**ConversationSummary**](ConversationSummary.md) |  | [optional] 
**EventNewMessage** | [**ConversationSummary**](ConversationSummary.md) |  | [optional] 
**EventParticipantJoin** | [**ConversationSummary**](ConversationSummary.md) |  | [optional] 
**EventParticipantJoinParticipant** | [**ConversationParticipant**](ConversationParticipant.md) |  | [optional] 
**EventParticipantLeft** | [**ConversationSummary**](ConversationSummary.md) |  | [optional] 
**EventParticipantLeftParticipant** | [**ConversationParticipant**](ConversationParticipant.md) |  | [optional] 
**EventParticipantUpdate** | [**ConversationSummary**](ConversationSummary.md) |  | [optional] 
**EventQueuePosition** | [**ConversationEventQueuePosition**](ConversationEventQueuePosition.md) |  | [optional] 
**EventQueueStatusUpdate** | [**ConversationWebchatQueueStatus**](ConversationWebchatQueueStatus.md) |  | [optional] 
**EventReadMessage** | [**ConversationEventReadMessage**](ConversationEventReadMessage.md) |  | [optional] 
**EventRrweb** | [**ConversationEventRRWeb**](ConversationEventRRWeb.md) |  | [optional] 
**EventType** | **string** | Type of event | [optional] 
**EventTyping** | [**ConversationEventTyping**](ConversationEventTyping.md) |  | [optional] 
**EventUpdatedMessage** | [**ConversationMessage**](ConversationMessage.md) |  | [optional] 
**EventWebchatContext** | [**ConversationEventWebchatContext**](ConversationEventWebchatContext.md) |  | [optional] 
**Message** | [**ConversationMessage**](ConversationMessage.md) |  | [optional] 
**Type** | **string** | Type of message | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

