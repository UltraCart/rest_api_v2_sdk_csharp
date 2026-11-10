
# com.ultracart.admin.v2.Model.SfvbItemDefaultPageRow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentSha256** | **string** | The dry run&#39;s current_sha256 for the item.  Required on an apply. | [optional] 
**ExpectedCurrentPath** | **string** | Dry run only - the default page the row expects now.  A different default makes the row stale. | [optional] 
**MerchantItemId** | **string** | The item&#39;s id.  Send this or merchant_item_oid. | [optional] 
**MerchantItemOid** | **int** | The item&#39;s oid.  Required on an apply. | [optional] 
**PageOid** | **int** | The page to make the default, by oid.  Required on an apply. | [optional] 
**PagePath** | **string** | The page to make the default, by path.  Send this or page_oid. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

