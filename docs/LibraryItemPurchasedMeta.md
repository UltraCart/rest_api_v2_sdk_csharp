
# com.ultracart.admin.v2.Model.LibraryItemPurchasedMeta

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MostRecentVersion** | **int** | The most recent version of the item purchased | [optional] 
**MyPurchasedVersion** | **int** | If this is a public item and the merchant has already purchased it, this is their version.  If not yet purchased, this will be zero.  This value will only be populated during a searchPublicItems() call. | [optional] 
**UpgradeAvailable** | **bool** | True if the most recent version of this purchase it greater than what was purchased | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

