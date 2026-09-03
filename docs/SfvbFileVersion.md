
# com.ultracart.admin.v2.Model.SfvbFileVersion

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Comment** | **string** | Comment recorded with the write. | [optional] 
**Current** | **bool** | True for the version currently on disk. | [optional] 
**EditedBy** | **string** | Login of whoever wrote this version. | [optional] 
**FsFileHistoryOid** | **int** | History record oid, for correlating an entry with the file manager.  Absent on the entry marked current, which is the content on disk right now and has no history row of its own.  Unlike container_history_oid on a container version, this is NOT addressable through this API - nothing accepts it.  Fetch and revert a file version by path plus version instead. | [optional] 
**HashSha256** | **string** | SHA-256 of this version&#39;s content. | [optional] 
**LastModified** | **string** | When this version was written. | [optional] 
**Revertable** | **bool** | True when this version can be reverted to, which is every entry except the one marked current.  Note that it is absent rather than false on that entry - false booleans are omitted across this API, so a generated client sees undefined rather than false.  Test whether the key is present, or simpler still, use current. | [optional] 
**Size** | **int** | Size in bytes. | [optional] 
**_Version** | **int** | Version number.  Pass to files/content or files/revert. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

