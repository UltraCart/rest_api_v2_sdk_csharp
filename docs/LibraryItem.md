# com.ultracart.admin.v2.Model.LibraryItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Assets** | [**List&lt;LibraryItemAsset&gt;**](LibraryItemAsset.md) |  | [optional] 
**Categories** | **List&lt;string&gt;** |  | [optional] 
**Content** | **string** |  | [optional] 
**ContentType** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Industries** | **List&lt;string&gt;** |  | [optional] 
**LibraryItemOid** | **int?** |  | [optional] 
**MerchantId** | **string** |  | [optional] 
**Price** | **decimal?** | The price of the published item.  Null for any private library items. | [optional] 
**PriceFormatted** | **string** | The formatted price of the published item.  Null for any private library items. | [optional] 
**Published** | **bool?** | True if this library item is a published item (not source) | [optional] 
**PublishedFromLibraryItemOid** | **int?** | The source item used to publish this item.  This allows for comparisons between source and published | [optional] 
**PublishedVersion** | **int?** | The source version when this item was published.  This allows for out-of-date alerts to be shown when there is a difference between source and published | [optional] 
**Purchased** | **bool?** | True if this library item has been purchased | [optional] 
**PurchasedFromLibraryItemOid** | **int?** | The published item that was purchased to make this item.  This allows for comparisons between published and purchased | [optional] 
**PurchasedVersion** | **int?** | The published version when this item was purchased.  This allows for out-of-date alerts to be shown when there is a difference between published and purchased | [optional] 
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


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

