
# com.ultracart.admin.v2.Model.SfvbPageCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | The page description, for templates that show one. | [optional] 
**ExcludeFromSitemap** | **bool** | Leave the page out of the sitemap and mark it noindex.  Usual for ad landing pages. | [optional] 
**GroupTemplate** | **string** | Template that renders the page, a name from the template list.  When omitted the page inherits its parent&#39;s templates, or catalog_group.vm directly under the root. | [optional] 
**ItemTemplate** | **string** | Template that renders the item pages under this page.  Inherited or defaulted like group_template. | [optional] 
**PageType** | **string** | S for a static page, D for a dynamic one.  Defaults to D, as in the admin. | [optional] 
**Path** | **string** | Path of the new page, for example /lp/spring-sale/.  The parent page must already exist, and the last part may only contain letters, digits, hyphens and underscores. | [optional] 
**Title** | **string** | The page title. | [optional] 
**Visible** | **bool** | False creates the page hidden, so it answers 404 to shoppers until it is shown. | [optional] 
**VisibleDts** | **string** | Keep the page hidden until this time (ISO 8601). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

