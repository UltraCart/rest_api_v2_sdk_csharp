
# com.ultracart.admin.v2.Model.SfvbCodeLibraryEmailResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Created** | **bool** | On a save, true when this request made the item and false when an earlier save with the same uuid had, in which case nothing changed.  Absent on a read. | [optional] 
**Email** | [**SfvbCodeLibraryEmailDetail**](SfvbCodeLibraryEmailDetail.md) |  | [optional] 
**FilesSkipped** | [**List&lt;SfvbCodeLibraryFileSkipped&gt;**](SfvbCodeLibraryFileSkipped.md) | On a save, the files the body names that the item does not carry, each with the reason.  Absent on a read. | [optional] 
**Notes** | **List&lt;string&gt;** | Plain sentences about the save, for example executable elements or absolute file URLs in the body. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

