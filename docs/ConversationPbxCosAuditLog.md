
# com.ultracart.admin.v2.Model.ConversationPbxCosAuditLog

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | Action taken | [optional] 
**AgentLogin** | **string** | Login of the agent who attempted the call | [optional] 
**AuditLogUuid** | **string** | Audit log entry unique identifier | [optional] 
**ClassOfServiceName** | **string** | Name of the class of service (denormalized for display) | [optional] 
**ClassOfServiceUuid** | **string** | UUID of the class of service that was evaluated | [optional] 
**Destination** | **string** | Phone number the agent tried to dial | [optional] 
**MerchantId** | **string** | Merchant Id | [optional] 
**RuleTriggered** | **string** | Rule that triggered the action | [optional] 
**SupervisorLogin** | **string** | Login of supervisor who approved/denied (null for timeouts and direct blocks) | [optional] 
**Timestamp** | **string** | ISO 8601 timestamp of the event | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

