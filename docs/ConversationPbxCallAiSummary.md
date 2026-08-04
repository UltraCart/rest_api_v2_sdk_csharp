
# com.ultracart.admin.v2.Model.ConversationPbxCallAiSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActionItems** | **List&lt;string&gt;** | Action items identified during the call | [optional] 
**CallCategory** | **string** | Category of the call (e.g. support, sales, billing) | [optional] 
**CompletionTokens** | **int** | Number of output tokens used to generate the summary | [optional] 
**Cost** | **decimal** | Cost of generating the summary in the specified currency | [optional] 
**CostCurrency** | **string** | Currency code for the summary cost (always USD) | [optional] 
**GeneratedAtDts** | **string** | Timestamp when the summary was generated | [optional] 
**KeyTopics** | **List&lt;string&gt;** | Key topics discussed during the call | [optional] 
**Model** | **string** | AI model used to generate the summary (e.g. grok-4.1-fast) | [optional] 
**PromptTokens** | **int** | Number of input tokens used to generate the summary | [optional] 
**Sentiment** | **string** | Overall sentiment of the call | [optional] 
**Summary** | **string** | 2-3 sentence synopsis of the call | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

