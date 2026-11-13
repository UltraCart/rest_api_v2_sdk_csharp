
# com.ultracart.admin.v2.Model.SfvbSearchFacetsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangedFacets** | **List&lt;string&gt;** | After a change, the facets it changed. | [optional] 
**CostPricePoints** | **List&lt;int&gt;** | The Cost facet price breaks, smallest first. | [optional] 
**DryRun** | **bool** | True when nothing was saved. | [optional] 
**Facets** | [**List&lt;SfvbSearchFacet&gt;**](SfvbSearchFacet.md) | Every facet the storefront can offer, in the fixed order shoppers see them. | [optional] 
**HashSha256** | **string** | Hash of the facets and price points.  Send it as If-Match on a change. | [optional] 
**PricePointsChanged** | **bool** | After a change, true when the price points changed. | [optional] 
**Rebuild** | **string** | After a change, the search index rebuild it started.  none, quick (minutes, small catalogs), slow (the regular rebuild cycle) or failed (the change is saved but the rebuild could not be started; save again or contact support). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

