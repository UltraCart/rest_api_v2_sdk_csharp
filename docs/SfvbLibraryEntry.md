
# com.ultracart.admin.v2.Model.SfvbLibraryEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bookmarked** | **bool** | True when the calling user has bookmarked this entry. | [optional] 
**Cjson** | **string** | The fragment&#39;s CJSON.  Omitted from search results to keep them terse; fetch a single entry to get it. | [optional] 
**Description** | **string** | What this fragment is for. | [optional] 
**LibraryOid** | **int** | Library entry oid. | [optional] 
**Name** | **string** | Entry name. | [optional] 
**Owned** | **bool** | True when the calling user owns this entry. | [optional] 
**ReferencedFiles** | **List&lt;string&gt;** | Storefront file paths this fragment references.  Installing the fragment copies them into the storefront; reading it does not. | [optional] 
**ScreenshotKey** | **string** | S3 listing key for the large screenshot, when one has been generated. | [optional] 
**ShareWithAccount** | **bool** | True when the entry is shared across the merchant account. | [optional] 
**ThumbnailKey** | **string** | S3 listing key for the medium thumbnail, when one has been generated.  Thumbnails are produced asynchronously and can lag a save by a minute or two. | [optional] 
**WidgetType** | **string** | Element type at the root of the fragment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

