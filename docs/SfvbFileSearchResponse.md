
# com.ultracart.admin.v2.Model.SfvbFileSearchResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Files** | [**List&lt;SfvbFileEntry&gt;**](SfvbFileEntry.md) | Matching files. | [optional] 
**MaxResults** | **int** | The cap that was applied. | [optional] 
**NextOffset** | **int** | Offset to send for the next page.  Zero when truncated is false.  Never truncates without giving a way to continue. | [optional] 
**Offset** | **int** | Results skipped to produce this page. | [optional] 
**ResultCount** | **int** | Number of results returned. | [optional] 
**TotalCount** | **int** | Total matches found.  Available because the underlying query is unbounded and returns everything anyway; it is not evidence that fetching them all is cheap. | [optional] 
**Truncated** | **bool** | True when matches exist beyond this page.  next_offset is populated when it is. | [optional] 
**TruncationAdvice** | **string** | Advice for the caller when truncated is true. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

