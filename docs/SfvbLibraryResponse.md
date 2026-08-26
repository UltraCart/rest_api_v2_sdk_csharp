
# com.ultracart.admin.v2.Model.SfvbLibraryResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Facets** | [**List&lt;SfvbLibraryFacet&gt;**](SfvbLibraryFacet.md) | Available narrowing dimensions.  Send a chosen option back as facet_{name}&#x3D;{option}. | [optional] 
**FirstResultNumber** | **int** | 1-indexed position of the first result on this page. | [optional] 
**LastResultNumber** | **int** | 1-indexed position of the last result on this page. | [optional] 
**Results** | [**List&lt;SfvbLibraryEntry&gt;**](SfvbLibraryEntry.md) | Matching library entries, without their CJSON.  Fetch a single entry to get the fragment itself. | [optional] 
**TotalPages** | **int** | Total pages available. | [optional] 
**TotalResults** | **int** | Total matches across all pages. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

