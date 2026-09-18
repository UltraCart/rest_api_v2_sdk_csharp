
# com.ultracart.admin.v2.Model.SfvbPageSettingsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlogPostTemplate** | **string** | Template that renders the blog posts under this page. | [optional] 
**Description** | **string** | The page description.  Null or empty clears it. | [optional] 
**ExcludeFromSitemap** | **bool** | Leave the page out of the sitemap and mark it noindex. | [optional] 
**GroupTemplate** | **string** | Template that renders the page, a name from the template list. | [optional] 
**ItemTemplate** | **string** | Template that renders the item pages under this page. | [optional] 
**ItemsPerPage** | **int** | Items per page on a template that paginates.  Null returns to the template&#39;s default. | [optional] 
**PageType** | **string** | S for a static page, D for a dynamic one. | [optional] 
**ReviewTemplate** | **string** | Template that renders the item review pages under this page. | [optional] 
**SortOrder** | **int** | Position among its siblings when the parent sorts child pages by a custom order.  Null clears it. | [optional] 
**SortOrderChildGroups** | **string** | How the pages under this one are ordered.  TA or TD by title, DA or DD by description, C custom. | [optional] 
**SortOrderChildItems** | **string** | How the page&#39;s items are ordered.  IA or ID by item id, DA or DD by description, SA or SD by manufacturer SKU, PA or PD by price, RA or RD by review, NA or ND by inventory, C custom. | [optional] 
**Title** | **string** | The page title. | [optional] 
**Visible** | **bool** | False hides the page, so it answers 404 to shoppers.  The root page cannot be hidden. | [optional] 
**VisibleDts** | **string** | Keep the page hidden until this time (ISO 8601).  Null or empty clears it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

