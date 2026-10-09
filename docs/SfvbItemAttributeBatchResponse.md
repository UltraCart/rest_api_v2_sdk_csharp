
# com.ultracart.admin.v2.Model.SfvbItemAttributeBatchResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Applied** | **bool** | True after an apply. | [optional] 
**Change** | **int** | Rows that would change, from a dry run. | [optional] 
**Error** | **int** | Rows on an item that could not be saved, after an apply. | [optional] 
**Invalid** | **int** | Rows refused by the attribute checks. | [optional] 
**ItemCount** | **int** | Distinct items with at least one row that would change, or did. | [optional] 
**NotFound** | **int** | Rows naming an item that does not exist. | [optional] 
**PlanHash** | **string** | The hash of the rows answered as change, with their current_sha256.  Apply exactly those rows with this hash. | [optional] 
**Rows** | [**List&lt;SfvbItemAttributeBatchRowResult&gt;**](SfvbItemAttributeBatchRowResult.md) | One result per row, in request order. | [optional] 
**Stale** | **int** | Rows skipped because the value is not the one expected. | [optional] 
**Total** | **int** | Rows checked. | [optional] 
**Unchanged** | **int** | Rows whose value is already the new one. | [optional] 
**Updated** | **int** | Rows written, after an apply. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

