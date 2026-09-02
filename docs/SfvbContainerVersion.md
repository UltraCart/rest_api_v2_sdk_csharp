
# com.ultracart.admin.v2.Model.SfvbContainerVersion

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cjson** | **string** | The CJSON this version held.  Populated only when reading a single version, and null when the operation is create.  Listings omit it because container CJSON is large. | [optional] 
**Comment** | **string** | Comment recorded with the write that replaced this version. | [optional] 
**ContainerHistoryOid** | **int** | History record oid.  Pass to the revert operation on the owning container.  Absent on the entry marked current, which holds the value stored right now, has no history row of its own, and so cannot be fetched or reverted to. | [optional] 
**ContainerName** | **string** | Container name, where the owner has more than one container. | [optional] 
**CreatedDts** | **string** | When this snapshot was taken. | [optional] 
**Current** | **bool** | True for the value currently stored. | [optional] 
**EditedBy** | **string** | Login of whoever caused this snapshot. | [optional] 
**HashSha256** | **string** | SHA-256 of this version&#39;s CJSON. | [optional] 
**Operation** | **string** | What the container was before the write this entry precedes.  create means it did not exist, so reverting to this entry removes it again; update means it held the cjson recorded here. | [optional] 
**OwnerObjectId** | **string** | Owner object identifier. | [optional] 
**OwnerType** | **string** | Owner type. | [optional] 
**Size** | **int** | Size of this version&#39;s CJSON in bytes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

