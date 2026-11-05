
# com.ultracart.admin.v2.Model.SfvbCommsProviderImportResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DryRun** | **bool** | True when nothing was imported. | [optional] 
**Lists** | [**List&lt;SfvbCommsProviderList&gt;**](SfvbCommsProviderList.md) | The lists imported, each into a new list of the same name. | [optional] 
**Notes** | **List&lt;string&gt;** | What the import does. | [optional] 
**Provider** | **string** | The provider. | [optional] 
**Queued** | **bool** | True when the import was started.  It runs in the background and emails the signed-in user when done. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

