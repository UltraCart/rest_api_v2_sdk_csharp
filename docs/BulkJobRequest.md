
# com.ultracart.admin.v2.Model.BulkJobRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operation** | **string** | Mutation mode - insert (create only) or upsert (create or update). Defaults to insert. This is always a mutation verb â€” the bulk surface writes only and has no read / query mode. upsert is currently supported for customer only. | [optional] 
**S3Key** | **string** | The s3_key returned by the upload-url endpoint | [optional] 
**WebhookSecret** | **string** | Optional shared secret echoed in the completion POST&#39;s Authorization header | [optional] 
**WebhookUrl** | **string** | Optional URL to POST once, on completion | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

