# com.ultracart.admin.v2.Model.LibraryItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Assets** | [**List&lt;LibraryItemAsset&gt;**](LibraryItemAsset.md) |  | [optional] 
**Attributes** | [**List&lt;LibraryItemAttribute&gt;**](LibraryItemAttribute.md) |  | [optional] 
**Categories** | **List&lt;string&gt;** |  | [optional] 
**Content** | **string** |  | [optional] 
**ContentType** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Industries** | **List&lt;string&gt;** |  | [optional] 
**LibraryItemOid** | **int?** |  | [optional] 
**MerchantId** | **string** |  | [optional] 
**MyPurchasedVersion** | **int?** | If this is a public item and the merchant has already purchased it, this is their version.  If not yet purchased, this will be zero.  This value will only be populated during a searchPublicItems() call. | [optional] 
**OriginalObjectId** | **string** | This id points to the original object that was added to the library. For flows and campaigns, this is a uuid string.  For upsells, it is an oid integer.  For transactional_emails, it is an email name. | [optional] 
**Price** | **decimal?** | The price of the published item.  Null for any private library items. | [optional] 
**PriceFormatted** | **string** | The formatted price of the published item.  Null for any private library items. | [optional] 
**Published** | **bool?** | True if this library item is a published item (not source) | [optional] 
**PublishedDts** | **Object** | The timestamp of the last published version | [optional] 
**PublishedFromLibraryItemOid** | **int?** | The source item used to publish this item.  This allows for comparisons between source and published | [optional] 
**PublishedMeta** | [**LibraryItemPublishedMeta**](LibraryItemPublishedMeta.md) |  | [optional] 
**PublishedVersion** | **int?** | The source version when this item was published.  This allows for out-of-date alerts to be shown when there is a difference between source and published | [optional] 
**Purchased** | **bool?** | True if this library item has been purchased | [optional] 
**PurchasedFromLibraryItemOid** | **int?** | The published item that was purchased to make this item.  This allows for comparisons between published and purchased | [optional] 
**PurchasedMeta** | [**LibraryItemPurchasedMeta**](LibraryItemPurchasedMeta.md) |  | [optional] 
**PurchasedVersion** | **int?** | The published version when this item was purchased.  This allows for out-of-date alerts to be shown when there is a difference between published and purchased | [optional] 
**Rejected** | **bool?** | Any published library reviewed by UltraCart staff for malicious or inappropriate content will have this flag set to true.  This is always false for non-published items | [optional] 
**RejectedReason** | **string** | Any rejected published item will have this field populated with the reason. | [optional] 
**ReleaseNotes** | **string** | Release notes specific to each published version and only appearing on public items. | [optional] 
**ReleaseVersion** | **int?** | This counter records how many times a library item has been published.  This is used to show version history. | [optional] 
**Reviewed** | **bool?** | Any published library items must be reviewed by UltraCart staff for malicious content.  This flag shows the status of that review.  This is always false for non-published items | [optional] 
**ReviewedDts** | **Object** | This is the timestamp for a published items formal review by UltraCart staff for malicious content. | [optional] 
**Screenshots** | [**List&lt;LibraryItemScreenshot&gt;**](LibraryItemScreenshot.md) |  | [optional] 
**ShareWithAccounts** | [**List&lt;LibraryItemAccount&gt;**](LibraryItemAccount.md) |  | [optional] 
**ShareWithOtherEmails** | [**List&lt;LibraryItemEmail&gt;**](LibraryItemEmail.md) |  | [optional] 
**Shared** | **bool?** | True if this item is shared from another merchant account | [optional] 
**Source** | **bool?** | True if this library item has been published | [optional] 
**SourceToLibraryItemOid** | **int?** | This oid points to the published library item, if there is one. | [optional] 
**SourceVersion** | **int?** | The version of this item.  Increment every time the item is saved. | [optional] 
**Style** | **string** |  | [optional] 
**TimesPurchased** | **int?** |  | [optional] 
**Title** | **string** |  | [optional] 
**Type** | **string** |  | [optional] 
**UnderReview** | **bool?** | True if this library item was published but is awaiting review from UltraCart staff. | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

