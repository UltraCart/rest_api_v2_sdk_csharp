
# com.ultracart.admin.v2.Model.SfvbPageRefreshResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Message** | **string** | A plain sentence saying what happened. | [optional] 
**Path** | **string** | The page path the refresh used, after normalization. | [optional] 
**Refreshed** | **bool** | True when a cached copy was dropped.  The next request renders the page fresh. | [optional] 
**WasCached** | **bool** | True when the page had a cache entry. | [optional] 
**WasValid** | **bool** | True when that entry was being served from cache. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

