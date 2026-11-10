
# com.ultracart.admin.v2.Model.SfvbItemDefaultPageResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AlreadyDefault** | **int** | Rows whose page is already the default. | [optional] 
**DryRun** | **bool** | True when nothing was saved. | [optional] 
**Failed** | **int** | Rows whose change didn&#39;t save (apply). | [optional] 
**ItemCount** | **int** | Distinct items in the request. | [optional] 
**Ready** | **int** | Rows that would change (dry run). | [optional] 
**Refused** | **int** | Rows refused - not found, not assigned, hidden, another storefront or invalid. | [optional] 
**Rows** | [**List&lt;SfvbItemDefaultPageResult&gt;**](SfvbItemDefaultPageResult.md) | Every row, in request order. | [optional] 
**RowsSha256** | **string** | Hash of the ready rows.  Request item.default_page with exactly those rows, then apply them with this. | [optional] 
**Stale** | **int** | Rows that changed since they were read. | [optional] 
**Updated** | **int** | Rows changed (apply). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

