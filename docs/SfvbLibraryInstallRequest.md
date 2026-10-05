
# com.ultracart.admin.v2.Model.SfvbLibraryInstallRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcknowledgeExecutable** | **bool** | Must be true to install an entry whose content_manifest lists executable content.  Read the manifest first. | [optional] 
**OnConflict** | **string** | What to do when a file the entry installs already exists with different content.  fail refuses and writes nothing, skip keeps the existing file, overwrite replaces it. | [optional] 
**RevisionNumber** | **int** | A published revision to install.  Defaults to the latest one, or the draft for the owner. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

