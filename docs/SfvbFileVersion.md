
# com.ultracart.admin.v2.Model.SfvbFileVersion

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Comment** | **string** | Comment recorded with the write. | [optional] 
**Current** | **bool** | True for the version currently on disk. | [optional] 
**EditedBy** | **string** | Login of whoever wrote this version. | [optional] 
**FsFileHistoryOid** | **int** | History record oid. | [optional] 
**HashSha256** | **string** | SHA-256 of this version&#39;s content. | [optional] 
**LastModified** | **string** | When this version was written. | [optional] 
**Revertable** | **bool** | True when this version can be reverted to. | [optional] 
**Size** | **int** | Size in bytes. | [optional] 
**_Version** | **int** | Version number.  Pass to files/content or files/revert. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

