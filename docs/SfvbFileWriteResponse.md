
# com.ultracart.admin.v2.Model.SfvbFileWriteResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompiledPath** | **string** | Path of the compiled output, when writing a .cjson under a theme triggered a compile. | [optional] 
**File** | [**SfvbFileEntry**](SfvbFileEntry.md) |  | [optional] 
**HashSha256** | **string** | New SHA-256.  Use as the next If-Match value. | [optional] 
**PublicUrl** | **string** | Where a shopper&#39;s browser will fetch this file, for use in an img src or a background image.  Present only for a path outside /themes/, which is served straight off the storefront root.  A file inside a theme is absent here because its public URL depends on which theme is active, and guessing it would be worse than omitting it. | [optional] 
**Validation** | [**SfvbValidationResponse**](SfvbValidationResponse.md) |  | [optional] 
**VelocityErrors** | **string** | Velocity errors recorded by the store.  Present means the file was written but is not valid. | [optional] 
**_Version** | **int** | New version number. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

