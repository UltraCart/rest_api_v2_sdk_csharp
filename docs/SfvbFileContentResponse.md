
# com.ultracart.admin.v2.Model.SfvbFileContentResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoCompiled** | **bool** | True when this file is compiler output and must not be edited directly. | [optional] 
**Content** | **string** | UTF-8 content.  Only text/_* files can be read this way. | [optional] 
**FsFileOid** | **int** | StoreFront file system file oid. | [optional] 
**HashSha256** | **string** | SHA-256 of the content.  Also returned as the ETag header; send it back as If-Match when writing. | [optional] 
**MimeType** | **string** | Mime type. | [optional] 
**Path** | **string** | Full path of the file. | [optional] 
**Size** | **int** | Size in bytes. | [optional] 
**Truncated** | **bool** | True when the content was cut short.  Never truncated silently. | [optional] 
**Valid** | **bool** | False when the file failed Velocity validation on its last write. | [optional] 
**VelocityErrors** | **string** | Velocity errors recorded on the last write.  Null when valid. | [optional] 
**_Version** | **int** | Version number of the content returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

