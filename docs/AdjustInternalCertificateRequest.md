# com.ultracart.admin.v2.Model.AdjustInternalCertificateRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdjustmentAmount** | **decimal?** | The adjustment amount | [optional] 
**Description** | **string** | Description of this adjustment, 50 characters max | [optional] 
**EntryDts** | **string** | Optional timestamp for the adjustment, defaults to current time | [optional] 
**ExpirationDays** | **int?** | Optional expiration days from the entry_dts when these adjustment becomes worthless | [optional] 
**OrderId** | **string** | Optional order id if this adjustment is related to a particular order | [optional] 
**VestingDays** | **int?** | Optional days required for this adjustment to vest | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

