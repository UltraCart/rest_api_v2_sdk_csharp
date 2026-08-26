
# com.ultracart.admin.v2.Model.SfvbRenderRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AncestorsCjson** | **string** | The chain of ancestor nodes above this one, as CJSON.  Elements that inherit layout or styling from a parent render differently without it, so supply it when rendering a node from inside a container rather than a standalone fragment. | [optional] 
**ChildContainersJson** | **string** | Child containers this node references, as a JSON object keyed by container id.  Compiled into the render context so nested containers resolve. | [optional] 
**Cjson** | **string** | The CJSON node to render. | [optional] 
**ContextAffiliateOid** | **int** | Affiliate oid for the rendering context. | [optional] 
**ContextBlogPostOid** | **int** | Blog post oid for the rendering context. | [optional] 
**ContextGroupPath** | **string** | Catalog group path for the rendering context. | [optional] 
**ContextItemId** | **string** | Item id for the rendering context.  Required for item bound elements. | [optional] 
**ContextOrderId** | **string** | Order id for the rendering context. | [optional] 
**ContextPageNumber** | **string** | Page number for paginated elements.  Defaults to 1. | [optional] 
**ContextUpsellOfferOid** | **int** | Upsell offer oid for the rendering context. | [optional] 
**LanguageIsoCode** | **string** | Language ISO code.  Defaults to ENG. | [optional] 
**Uri** | **string** | Storefront URI the node would appear on.  Affects rendering of anything page relative. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

