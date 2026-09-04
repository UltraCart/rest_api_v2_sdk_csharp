
# com.ultracart.admin.v2.Model.ConversationAgentTestSessionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CartId** | **string** | Cart established for this session, soft logged in as the chosen customer profile.  Real, and anything the agent adds to it persists. | [optional] 
**ConversationWebchatQueueUuid** | **string** | Queue entry created for this session | [optional] 
**CustomerAuth** | [**ConversationCustomerAuth**](ConversationCustomerAuth.md) |  | [optional] 
**Error** | [**Error**](Error.md) |  | [optional] 
**Metadata** | [**ResponseMetadata**](ResponseMetadata.md) |  | [optional] 
**StorefrontHostName** | **string** | Storefront the session is running against | [optional] 
**Success** | **bool** |  | [optional] 
**Warning** | [**Warning**](Warning.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

