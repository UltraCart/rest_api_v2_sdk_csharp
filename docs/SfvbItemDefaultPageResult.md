
# com.ultracart.admin.v2.Model.SfvbItemDefaultPageResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentDefaultOid** | **int** | The default page&#39;s oid now, or null. | [optional] 
**CurrentDefaultPath** | **string** | The default page now, or null. | [optional] 
**CurrentSha256** | **string** | Hash of the item&#39;s pages and default on this storefront.  Send it back on the apply. | [optional] 
**Index** | **int** | The row&#39;s position in the request, from 0. | [optional] 
**MerchantItemId** | **string** | The item&#39;s id, when found. | [optional] 
**MerchantItemOid** | **int** | The item&#39;s oid, when found. | [optional] 
**Message** | **string** | Why the row is refused, stale or failed. | [optional] 
**PreviousDefaultOid** | **int** | Apply only - the previous default page&#39;s oid. | [optional] 
**PreviousDefaultPath** | **string** | Apply only - the default page before the change, to undo it. | [optional] 
**Status** | **string** | ready, already_default, target_not_found, target_not_on_host, target_not_assigned, target_hidden, item_not_found, invalid, stale, updated or failed. | [optional] 
**TargetOid** | **int** | The page&#39;s oid. | [optional] 
**TargetPath** | **string** | The page the row makes the default. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

