
# com.ultracart.admin.v2.Model.SfvbSiteSeo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApprovalNeeded** | **bool** | On a change, true when it needs an approved site_seo.change request. | [optional] 
**Canonical** | **bool** | True when pages output canonical links. | [optional] 
**Changed** | **bool** | On a change, true when anything was saved, or would be on a dry run. | [optional] 
**Changes** | [**List&lt;SfvbSiteSeoChange&gt;**](SfvbSiteSeoChange.md) | On a change, each switch it changed, or would change on a dry run. | [optional] 
**Description** | **string** | The default meta description, the storefrontSEODescription site attribute. | [optional] 
**DryRun** | **bool** | True when nothing was saved because the request was a dry run. | [optional] 
**HashSha256** | **string** | The hash of the three switches.  Send it as If-Match on a change. | [optional] 
**Keywords** | **string** | The default meta keywords, the storefrontSEOKeywords site attribute. | [optional] 
**Notes** | **List&lt;string&gt;** | What a person should know about these settings. | [optional] 
**PreventIndexing** | **bool** | True when every page tells search engines not to index it.  For a development store only. | [optional] 
**SchemaOrg** | **bool** | True when pages output Schema.org structured data. | [optional] 
**StorefrontOid** | **int** | The storefront. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

