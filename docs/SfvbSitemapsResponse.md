
# com.ultracart.admin.v2.Model.SfvbSitemapsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | **string** | The host the sitemaps are built for. | [optional] 
**Notes** | **List&lt;string&gt;** | What a person should know about these sitemaps, such as when they are rebuilt. | [optional] 
**PreventIndexing** | **bool** | True when the storefront&#39;s Prevent Indexing setting is on.  The sitemaps are still served, but every page tells search engines not to index it. | [optional] 
**RobotsTxt** | [**SfvbRobotsTxt**](SfvbRobotsTxt.md) |  | [optional] 
**Sitemaps** | [**List&lt;SfvbSitemap&gt;**](SfvbSitemap.md) | The sitemaps that exist, sitemaps.org first.  Empty until the nightly build has run. | [optional] 
**StorefrontOid** | **int** | The storefront. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

