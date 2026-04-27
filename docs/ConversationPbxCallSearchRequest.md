
# com.ultracart.admin.v2.Model.ConversationPbxCallSearchRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgentIds** | **List&lt;string&gt;** | Filter by agent IDs | [optional] 
**CustomerName** | **string** | Filter by customer name | [optional] 
**Direction** | **string** | Filter by call direction (inbound/outbound) | [optional] 
**Disposition** | **string** | Filter by call disposition | [optional] 
**EndDate** | **string** | Filter calls created on or before this date (ISO 8601) | [optional] 
**HasAiEngagement** | **bool** | Filter to calls with AI agent engagement | [optional] 
**HasRecording** | **bool** | Filter to calls that have a recording | [optional] 
**HasTranscript** | **bool** | Filter to calls that have a transcript | [optional] 
**MaxDurationSeconds** | **int** | Filter by maximum call duration in seconds | [optional] 
**MinDurationSeconds** | **int** | Filter by minimum call duration in seconds | [optional] 
**PhoneNumber** | **string** | Filter by phone number (partial match supported) | [optional] 
**QueueUuids** | **List&lt;string&gt;** | Filter by queue UUIDs | [optional] 
**SearchTerm** | **string** | Free text search term - smart-routed based on content (phone, email, UUID, or general text) | [optional] 
**StartDate** | **string** | Filter calls created on or after this date (ISO 8601) | [optional] 
**Statuses** | **List&lt;string&gt;** | Filter by call statuses | [optional] 
**TranscriptSearch** | **string** | Search within transcript text | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

