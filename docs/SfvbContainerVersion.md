
# com.ultracart.admin.v2.Model.SfvbContainerVersion

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cjson** | **string** | The CJSON this version held.  Populated only when reading a single version, and null when the operation is create.  Listings omit it because container CJSON is large. | [optional] 
**Comment** | **string** | Comment recorded with the write that replaced this version. | [optional] 
**ContainerHistoryOid** | **int** | History record oid.  Pass to the revert operation on the owning container.  Absent on the entry marked current, which holds the value stored right now, has no history row of its own, and so cannot be fetched or reverted to. | [optional] 
**ContainerName** | **string** | Container name, where the owner has more than one container. | [optional] 
**ContentCreatedDts** | **string** | When this version&#39;s content was written, ISO 8601 UTC.  Same source and limits as content_edited_by. | [optional] 
**ContentEditedBy** | **string** | Login of whoever wrote this version&#39;s content, taken from the write recorded on the next older entry.  Absent on a create entry and on the oldest entry kept, such as a template body that was in place before any history.  Saves made outside this API, in the admin visual builder, are not recorded, so after one this names the previous API write. | [optional] 
**CreatedDts** | **string** | When the write that replaced this version happened, ISO 8601 UTC.  On the current entry, when it was written. | [optional] 
**Current** | **bool** | True for the value currently stored. | [optional] 
**EditedBy** | **string** | Login of whoever made the write that replaced this version.  On the current entry, whoever wrote it.  See content_edited_by for who wrote a history entry&#39;s content. | [optional] 
**HashSha256** | **string** | SHA-256 of this version&#39;s CJSON. | [optional] 
**Operation** | **string** | What the container was before the write this entry precedes.  create means it did not exist, so reverting to this entry removes it again; update means it held the cjson recorded here; delete means it held the cjson recorded here and the write after it removed the container, so reverting to this entry puts that cjson back. | [optional] 
**OwnerObjectId** | **string** | Owner object identifier. | [optional] 
**OwnerType** | **string** | Owner type. | [optional] 
**Size** | **int** | Size of this version&#39;s CJSON in bytes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

