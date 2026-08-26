
# com.ultracart.admin.v2.Model.SfvbCompileResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContainerId** | **string** | Container id the document compiled under. | [optional] 
**Directives** | **List&lt;string&gt;** | Velocity directives the compiled output declares. | [optional] 
**Success** | **bool** | True when compilation produced output. | [optional] 
**UsedElements** | **List&lt;string&gt;** | Element types used, sorted. | [optional] 
**Validation** | [**SfvbValidationResponse**](SfvbValidationResponse.md) |  | [optional] 
**Velocity** | **string** | The compiled Velocity.  This is the body only; the cache wrapper a stored .cjson gets is not included. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

