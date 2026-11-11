
# com.ultracart.admin.v2.Model.SfvbCliVersion

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cutoff** | **string** | The date (yyyy-MM-dd) the minimum will be raised to the recommended version.  Omitted when none is announced. | [optional] 
**Minimum** | **string** | The lowest supported version.  Omitted when none is set. | [optional] 
**Recommended** | **string** | The version to upgrade to.  Omitted when none is set. | [optional] 
**Reported** | **string** | The version the CLI sent in X-UltraCart-CLI-Version.  Omitted when it sent none, which is read as 0.0.0. | [optional] 
**Status** | **string** | ok, deprecated (below recommended - keep working, tell the merchant to upgrade) or unsupported (below minimum - every other call is refused with 426 sfvb.cli_upgrade_required). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

