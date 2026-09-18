
# com.ultracart.admin.v2.Model.SfvbPageSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChildCount** | **int** | Number of pages directly under this one. | [optional] 
**ExcludeFromSitemap** | **bool** | True when the page is left out of the sitemap and marked noindex. | [optional] 
**GroupTemplate** | **string** | Template file that renders the page itself, a bare .vm name found anywhere in the active theme. | [optional] 
**ItemCount** | **int** | Number of items assigned to the page.  The catalog stops counting at its per-page item ceiling. | [optional] 
**ItemTemplate** | **string** | Template file that renders the item pages under this page. | [optional] 
**PageType** | **string** | S for a static page, D for a dynamic one. | [optional] 
**ParentPath** | **string** | Path of the page this one sits under.  Empty for the root page. | [optional] 
**Path** | **string** | The page path, beginning and ending with a slash.  The root page is /. | [optional] 
**Root** | **bool** | True for the storefront&#39;s home page. | [optional] 
**SortOrder** | **int** | Position among its siblings when the parent sorts child pages by a custom order. | [optional] 
**Title** | **string** | The page title. | [optional] 
**UsesSelectors** | **bool** | True when the page&#39;s items or blog posts are chosen by selectors rather than assigned by hand. | [optional] 
**Visible** | **bool** | False when the page is hidden.  A hidden page answers 404 to shoppers. | [optional] 
**VisibleDts** | **string** | When set, the page stays hidden until this time (ISO 8601, UTC). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

