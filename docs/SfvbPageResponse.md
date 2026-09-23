
# com.ultracart.admin.v2.Model.SfvbPageResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attributes** | [**List&lt;SfvbPageAttribute&gt;**](SfvbPageAttribute.md) | Every attribute this page has, including ones a template declares but nothing has set yet.  These are what the pageattribute element renders.  Sorted by name. | [optional] 
**Description** | **string** | The page description, the text a page template renders as the page&#39;s description.  Omitted when empty. | [optional] 
**ExcludeFromSitemap** | **bool** | True when the page is left out of the sitemap and marked noindex. | [optional] 
**GroupTemplate** | **string** | Template file that renders the page itself, a bare .vm name found anywhere in the active theme. | [optional] 
**ItemTemplate** | **string** | Template file that renders the item pages under this page. | [optional] 
**Multimedia** | [**List&lt;SfvbPageMultimedia&gt;**](SfvbPageMultimedia.md) | The page&#39;s images, including codes a template declares but nothing has attached yet.  These are what the pageimage element renders - the default image when pageImageCode is empty, otherwise the image with that code.  The default image comes first. | [optional] 
**Path** | **string** | The page path, normalized to begin and end with a slash. | [optional] 
**Title** | **string** | The page title. | [optional] 
**Visible** | **bool** | False when the page is hidden.  A hidden page answers 404 to shoppers. | [optional] 
**VisibleDts** | **string** | When set, the page stays hidden until this time (ISO 8601, UTC). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

