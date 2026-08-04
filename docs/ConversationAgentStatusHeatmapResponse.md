
# com.ultracart.admin.v2.Model.ConversationAgentStatusHeatmapResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Agents** | **List&lt;string&gt;** | Y-axis labels (one per agent) | [optional] 
**Data** | **List&lt;Object&gt;** | Sparse cells. Each row is [agent_index, hour, value]; empty cells are omitted. | [optional] 
**Error** | [**Error**](Error.md) |  | [optional] 
**Hours** | **List&lt;int&gt;** | X-axis values (hours of day, 0-23) | [optional] 
**Metadata** | [**ResponseMetadata**](ResponseMetadata.md) |  | [optional] 
**Success** | **bool** | Indicates if API call was successful | [optional] 
**Warning** | [**Warning**](Warning.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

