
# com.ultracart.admin.v2.Model.SfvbItemContainersResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemContainers** | [**List&lt;SfvbItemContainer&gt;**](SfvbItemContainer.md) | The containers on this page, ordered by merchant item id then container name. | [optional] 
**MaxResults** | **int** | The cap that was applied. | [optional] 
**NextOffset** | **int** | Offset to send for the next page.  Zero when truncated is false.  Never truncates without giving a way to continue. | [optional] 
**Offset** | **int** | Containers skipped to produce this page. | [optional] 
**ResultCount** | **int** | Number of containers returned on this page. | [optional] 
**TotalCount** | **int** | Total containers matching the filter.  With container_name supplied this is the answer to how many items carry that slot. | [optional] 
**Truncated** | **bool** | True when containers exist beyond this page.  next_offset is populated when it is. | [optional] 
**TruncationAdvice** | **string** | Advice for the caller when truncated is true. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

