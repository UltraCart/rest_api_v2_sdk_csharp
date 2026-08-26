
# com.ultracart.admin.v2.Model.SfvbPreviewSessionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BytesStored** | **int** | Bytes stored in this session by the request that returned this response. | [optional] 
**ExpiresInSeconds** | **int** | Seconds until this session expires. | [optional] 
**MaxBytes** | **int** | Maximum bytes one preview session may hold. | [optional] 
**OwnerLogin** | **string** | Login this session belongs to.  Sessions are keyed by user, not by token. | [optional] 
**PreviewSessionId** | **string** | The preview session id. | [optional] 
**Skipped** | [**List&lt;SfvbErrorDetail&gt;**](SfvbErrorDetail.md) | Containers that were sent but could not be stored, with the reason. | [optional] 
**StoredKeys** | **List&lt;string&gt;** | Preview map keys that were stored.  A container whose owner type could not be resolved is silently dropped by the underlying store, so compare this against what you sent. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

