
# com.ultracart.admin.v2.Model.ConversationAgentTestSessionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerProfileOid** | **int** | Customer profile to converse as.  The cart is established as a soft login for this customer, so the agent sees their real order history. | [optional] 
**Question** | **string** | Optional opening question, the same way a customer types one before joining the queue. | [optional] 
**QueueName** | **string** | Webchat queue to join.  The agent is selected explicitly, so this does not have to be a queue the agent is assigned to. | [optional] 
**StorefrontHostName** | **string** | Host name of the storefront to test against, with no protocol prefix.  Determines which catalog the agent searches. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

