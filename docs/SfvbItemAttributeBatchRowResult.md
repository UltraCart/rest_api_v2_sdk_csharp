
# com.ultracart.admin.v2.Model.SfvbItemAttributeBatchRowResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentPresent** | **bool** | Whether the item had the attribute before this batch. | [optional] 
**CurrentSha256** | **string** | The hash of the value before this batch.  Send it back with the row to apply. | [optional] 
**CurrentValue** | **string** | The value before this batch, for a backup.  Empty when the item has no such attribute. | [optional] 
**MerchantItemId** | **string** | The item&#39;s merchant item id.  Absent when not_found. | [optional] 
**MerchantItemOid** | **int** | The item.  Absent when not_found. | [optional] 
**Message** | **string** | Why a row is invalid, stale or error. | [optional] 
**Name** | **string** | The attribute name as sent. | [optional] 
**Result** | **string** | change or unchanged from a dry run, updated after an apply, stale (the value differs from expected_value or changed since the dry run), not_found, invalid, or error when the item could not be saved. | [optional] 
**Row** | **int** | The row&#39;s position in the request, from 1. | [optional] 
**Type** | **string** | The type the value is checked and stored as - the declaring template&#39;s, else the one sent. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

