
# com.ultracart.admin.v2.Model.SfvbTemplate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayBlogPosts** | **bool** | True when the template shows the page&#39;s blog posts. | [optional] 
**DisplayItems** | **bool** | True when the template shows the page&#39;s items. | [optional] 
**DisplaySubgroups** | **bool** | True when the template shows the pages under this one. | [optional] 
**MetadataAvailable** | **bool** | False when the template has no metadata, so the capability flags below are unknown. | [optional] 
**Name** | **string** | The bare file name.  This is the value a page&#39;s group_template or item_template holds. | [optional] 
**PageType** | **string** | The page type the template declares, such as group, item or static.  system for the fixed templates the storefront itself uses, such as checkout and my account.  Null when the template has no metadata. | [optional] 
**Pagination** | **bool** | True when the template pages through a long list of items. | [optional] 
**System** | **bool** | True for the fixed templates the storefront itself uses.  Never assign one to a page. | [optional] 
**ThemeRelativePath** | **string** | Where the file sits inside the theme. | [optional] 
**VisualBuilder** | **bool** | True when the template renders visual builder containers. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

