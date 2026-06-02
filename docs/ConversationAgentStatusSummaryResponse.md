
# com.ultracart.admin.v2.Model.ConversationAgentStatusSummaryResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Agents** | [**List&lt;AgentSummary&gt;**](AgentSummary.md) | Per-agent enriched summary (status totals + activity metrics) | [optional] 
**AvgAvailablePct** | **Object** |  | [optional] 
**Error** | [**Error**](Error.md) |  | [optional] 
**Metadata** | [**ResponseMetadata**](ResponseMetadata.md) |  | [optional] 
**StatusBreakdown** | **Object** | Total seconds-in-status across all agents, keyed by status name | [optional] 
**Success** | **bool** | Indicates if API call was successful | [optional] 
**TotalAgents** | **int** | Distinct agents with at least one transition in the range | [optional] 
**Warning** | [**Warning**](Warning.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

