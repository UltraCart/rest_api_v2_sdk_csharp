
# com.ultracart.admin.v2.Model.SfvbContainerResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveTheme** | **bool** | True when this container lives in the theme currently serving live traffic.  Writing to it requires the sfvb_publish scope. | [optional] 
**Cjson** | **string** | The container JSON.  Runtime state is stripped on the way out. | [optional] 
**ContainerId** | **string** | Container id as the compiler will derive it. | [optional] 
**ContainerName** | **string** | Container name. | [optional] 
**HashSha256** | **string** | SHA-256 of the cjson.  Send back as If-Match when writing. | [optional] 
**LastModified** | **string** | When the container was last modified, where the store records it. | [optional] 
**OwnerObjectId** | **string** | Identifier of the owning object within its store. | [optional] 
**OwnerType** | **string** | Where this container lives. | [optional] 
**Path** | **string** | File path, for theme and page containers only. | [optional] 
**_Version** | **int** | File version, for theme and page containers only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

