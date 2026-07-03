
# com.ultracart.admin.v2.Model.BulkUploadUrlResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Error** | [**Error**](Error.md) |  | [optional] 
**ExpiresAt** | **string** | When the presigned URL expires | [optional] 
**MaxRecords** | **int** | Per-job record cap | [optional] 
**Metadata** | [**ResponseMetadata**](ResponseMetadata.md) |  | [optional] 
**S3Key** | **string** | Opaque reference to pass back on POST /rest/v2/bulk/{object} | [optional] 
**Success** | **bool** | Indicates if API call was successful | [optional] 
**UploadUrl** | **string** | Presigned S3 PUT URL (short-lived) | [optional] 
**Warning** | [**Warning**](Warning.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

