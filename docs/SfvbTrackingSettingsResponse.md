
# com.ultracart.admin.v2.Model.SfvbTrackingSettingsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Advanced** | [**SfvbTrackingAdvanced**](SfvbTrackingAdvanced.md) |  | [optional] 
**Changes** | [**List&lt;SfvbTrackingChange&gt;**](SfvbTrackingChange.md) | On a write, each setting it changed, or would change on a dry run.  Empty when nothing changed.  Absent on a read. | [optional] 
**Currencies** | **List&lt;string&gt;** | The currency codes default_currency accepts. | [optional] 
**DryRun** | **bool** | On a write, true when nothing was saved.  Absent on a read. | [optional] 
**Privacy** | [**SfvbTrackingPrivacy**](SfvbTrackingPrivacy.md) |  | [optional] 
**StorefrontOid** | **int** | The storefront these settings belong to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

