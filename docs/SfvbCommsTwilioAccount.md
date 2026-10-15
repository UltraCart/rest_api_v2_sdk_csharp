
# com.ultracart.admin.v2.Model.SfvbCommsTwilioAccount

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountSid** | **string** | The Twilio account SID, AC followed by 32 hex digits.  It names the account, so it is also the target_id of a secret request for its auth token.  Required to create. | [optional] 
**AiTwimlAppSid** | **string** | The SID of the TwiML app UltraCart made for the AI agent.  Set by the server. | [optional] 
**ApiKeyId** | **string** | The SID of the Twilio API key UltraCart made for this account.  Set by the server.  Its secret is never returned. | [optional] 
**ApiKeyName** | **string** | The name of the Twilio API key UltraCart made for this account.  Set by the server. | [optional] 
**AuthToken** | **string** | The Twilio auth token.  A secret field.  Reads return a mask.  To set it, send a secret handle (sec_...) made for this account SID by POST secrets with sink twilio.account.auth_token.  Send the mask back, or leave it out, to keep it.  Required to create. | [optional] 
**EspTwilioUuid** | **string** | UltraCart&#39;s id for the Twilio account.  Set by the server. | [optional] 
**InboundTwimlAppSid** | **string** | The SID of the TwiML app UltraCart made for inbound calls and SMS.  Set by the server. | [optional] 
**OutboundTwimlAppSid** | **string** | The SID of the TwiML app UltraCart made for outbound calls.  Set by the server. | [optional] 
**PhoneNumbers** | **List&lt;string&gt;** | The account&#39;s phone numbers UltraCart uses, in E.164 format.  Leave it out of an update to keep them; an update that sends it replaces them all. | [optional] 
**PublicKeySid** | **string** | The SID of the voice encryption public key UltraCart registered with Twilio.  Set by the server.  The keys themselves are never returned. | [optional] 
**TwilioWorkspaceSid** | **string** | The SID of the TaskRouter workspace the phone system uses, when it has one.  Set by the server. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

