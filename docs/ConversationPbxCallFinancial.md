
# com.ultracart.admin.v2.Model.ConversationPbxCallFinancial

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AiAgentBilledMinutes** | **decimal** | Total AI agent billed minutes for this call | [optional] 
**AiAgentCost** | **decimal** | Total AI agent cost for this call | [optional] 
**AiAgentCostCurrency** | **string** | Currency for AI agent cost | [optional] 
**CallCurrency** | **string** | Currency for call price (default USD) | [optional] 
**CallPrice** | **decimal** | Twilio call cost | [optional] 
**CallPriceEstimated** | **bool** | True if call price is a fallback-rate estimate, false if Twilio-confirmed | [optional] 
**TranscriptionCost** | **decimal** | AWS Transcribe transcription cost | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

