
# com.ultracart.admin.v2.Model.SfvbContainerResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cjson** | **string** | The container JSON.  Runtime state is stripped on the way out. | [optional] 
**ContainerName** | **string** | Container name. | [optional] 
**HashSha256** | **string** | SHA-256 of the cjson.  Send back as If-Match when writing. | [optional] 
**LastModified** | **string** | When the container was last modified, in the store&#39;s own record of it.  Every owner type reports this.  It is absent only when the container has never been written since the store began recording it, so treat an absent value as unknown rather than as never modified.  Two behaviours worth knowing.  A postcard keeps one timestamp for both of its sides, so writing the front moves the value the back reports.  An upsell container that is rewritten with byte identical content keeps its original date rather than moving to now, because the timestamp tracks changes to the container and not writes to the offer. | [optional] 
**OwnerObjectId** | **string** | Identifier of the owning object within its store. | [optional] 
**OwnerType** | **string** | Where this container lives. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

