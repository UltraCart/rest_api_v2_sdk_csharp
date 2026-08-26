
# com.ultracart.admin.v2.Model.SfvbFilesResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Files** | [**List&lt;SfvbFileEntry&gt;**](SfvbFileEntry.md) | Directories first, then files, each sorted by name. | [optional] 
**FsDirectoryOid** | **int** | Oid of the directory that was listed. | [optional] 
**OmittedCount** | **int** | Number of entries omitted when truncated is true. | [optional] 
**ParentFsDirectoryOid** | **int** | Oid of the parent directory, or zero at the root. | [optional] 
**Path** | **string** | Path that was listed. | [optional] 
**Truncated** | **bool** | True when the listing was capped.  Never truncated silently. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

