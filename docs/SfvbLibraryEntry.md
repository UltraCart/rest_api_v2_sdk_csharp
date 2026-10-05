
# com.ultracart.admin.v2.Model.SfvbLibraryEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bookmarked** | **bool** | True when the calling user has bookmarked this entry. | [optional] 
**Cjson** | **string** | The fragment&#39;s CJSON.  Omitted from search results to keep them terse; fetch a single entry to get it. | [optional] 
**ContentManifest** | [**SfvbLibraryContentManifest**](SfvbLibraryContentManifest.md) |  | [optional] 
**Description** | **string** | What this fragment is for. | [optional] 
**HashSha256** | **string** | Hash of the draft&#39;s writable fields.  Send it back as If-Match to update, delete or publish.  Present only for the owner. | [optional] 
**LastModifiedDts** | **string** | When the draft was last saved, ISO 8601. | [optional] 
**LibraryOid** | **int** | Library entry oid. | [optional] 
**Name** | **string** | Entry name. | [optional] 
**Owned** | **bool** | True when the calling user owns this entry. | [optional] 
**Parameters** | [**List&lt;SfvbLibraryParameter&gt;**](SfvbLibraryParameter.md) | Named values the fragment expects the installer to supply. | [optional] 
**PublishedRevisionNumber** | **int** | The latest published revision, or null when the entry has never been published. | [optional] 
**ReferencedFiles** | **List&lt;string&gt;** | Storefront file paths this fragment references.  Installing the fragment copies them into the storefront; reading it does not. | [optional] 
**Retired** | **bool** | True when the owner deleted an entry that had been published or installed.  It is kept so existing installs still resolve, and it leaves search. | [optional] 
**RevisionNumber** | **int** | The revision returned.  For the owner this is the draft, which every save increments.  For anyone else it is the published revision. | [optional] 
**ScreenshotHeight** | **int** | Screenshot height in pixels. | [optional] 
**ScreenshotKey** | **string** | S3 listing key for the large screenshot, when one has been generated. | [optional] 
**ScreenshotSha256** | **string** | Hash of the uploaded screenshot. | [optional] 
**ScreenshotStale** | **bool** | True on an update that changed the fragment of an entry with a screenshot.  Retake it and set it again with the library screenshot endpoint. | [optional] 
**ScreenshotWidth** | **int** | Screenshot width in pixels. | [optional] 
**ShareWithAccount** | **bool** | True when the entry is shared across the merchant account. | [optional] 
**SharedWith** | [**List&lt;SfvbLibraryShareTarget&gt;**](SfvbLibraryShareTarget.md) | Linked accounts the entry is shared with.  Present only for the owner. | [optional] 
**Taxonomy** | [**SfvbLibraryTaxonomy**](SfvbLibraryTaxonomy.md) |  | [optional] 
**ThumbnailKey** | **string** | S3 listing key for the medium thumbnail, when one has been generated.  Thumbnails are produced asynchronously and can lag a save by a minute or two. | [optional] 
**Visibility** | **string** | private, shared or public. | [optional] 
**WidgetType** | **string** | Element type at the root of the fragment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

