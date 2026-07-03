
# com.ultracart.admin.v2.Model.BulkRecord

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | On an upsert success, whether the record was inserted or updated | [optional] 
**ErrorCode** | **string** | Error code on a failed record | [optional] 
**ErrorMessage** | **string** | Human-readable detail on a failed record | [optional] 
**LineNumber** | **long** | Original NDJSON line number | [optional] 
**MerchantRecordId** | **string** | The merchant-supplied dedupe key for this record | [optional] 
**Status** | **string** | Per-record verdict | [optional] 
**UcId** | **string** | UltraCart-side id created on success or matched on duplicate | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

