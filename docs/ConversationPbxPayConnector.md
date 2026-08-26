
# com.ultracart.admin.v2.Model.ConversationPbxPayConnector

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Description of the connector | [optional] 
**Environment** | **string** | Environment the connector points at.  Only live connectors are returned.  Sandbox and unconfigured connectors are ignored. | [optional] 
**FriendlyName** | **string** | Friendly name of the connector as shown in the Twilio console | [optional] 
**MerchantId** | **string** | Merchant Id | [optional] 
**Processor** | **string** | Payment processor behind this connector | [optional] 
**ProcessorAccountId** | **string** | The processor account this connector is bound to (Stripe connected account id or Braintree merchant id).  A payment captured with this connector can only be charged within this account. | [optional] 
**Sid** | **string** | Twilio installed add-on SID for this connector | [optional] 
**UniqueName** | **string** | Unique name of the connector.  This is the value used for the paymentConnector attribute of the Twilio Pay verb. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

