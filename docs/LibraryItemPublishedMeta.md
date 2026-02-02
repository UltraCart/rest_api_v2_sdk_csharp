# com.ultracart.admin.v2.Model.LibraryItemPublishedMeta
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CountOfVersions** | **int?** | The number of published versions a source item has, or zero if this item is not a source or is private | [optional] 
**LibraryItemPublishedOid** | **int?** | The oid pointing to the most recent published version, or zero if this is not a published source item. | [optional] 
**LibraryItemReviewOid** | **int?** | The oid pointing to the review data if this is a source library item and currently under review | [optional] 
**Rejected** | **bool?** | True if this is a source item and is under review and was rejected. | [optional] 
**RejectedReason** | **string** | The reason for rejection if this item is a source item, is under review, and was rejected.  For all other cases, this value will be null or missing. | [optional] 
**ReleaseVersion** | **int?** | If this library item is a source item and it is published, this is the most recent release version number | [optional] 
**ReviewVersion** | **int?** | If this library item is a source item and has a published item currently under review, this is that version number | [optional] 
**UnderReview** | **bool?** | True if this library item is a source item and is currently under review | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

