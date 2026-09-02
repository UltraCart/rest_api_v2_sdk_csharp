
# com.ultracart.admin.v2.Model.SfvbFileUploadUrlResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpiresInSeconds** | **int** | Seconds until the upload URL stops working.  Ask for a new one rather than holding this across a long job. | [optional] 
**HttpMethod** | **string** | HTTP method the upload URL expects. | [optional] 
**Key** | **string** | Quote this back to the upload endpoint once the bytes are in place.  It identifies the uploaded object and is bound to your account. | [optional] 
**UploadUrl** | **string** | Send the raw bytes to this URL.  It is short lived and single use, and it is not part of this API - do not send an Authorization header with it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

