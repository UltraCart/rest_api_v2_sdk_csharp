
# com.ultracart.admin.v2.Model.SfvbContainerResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cjson** | **string** | The container JSON.  Runtime state is stripped on the way out. | [optional] 
**ContainerName** | **string** | Container name. | [optional] 
**HashSha256** | **string** | SHA-256 of the cjson.  Send back as If-Match when writing. | [optional] 
**LastModified** | **string** | When the container was last modified, in the store&#39;s own record of it.  Present for email, postcardfront and postcardback.  Absent for upsell and item, because those tables carry no modification timestamp at all - for those two, read created_dts on the current entry of container_versions, which records when this API last wrote the container.  Note that a postcard keeps one timestamp for both of its sides, so writing the front moves the value the back reports. | [optional] 
**OwnerObjectId** | **string** | Identifier of the owning object within its store. | [optional] 
**OwnerType** | **string** | Where this container lives. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

