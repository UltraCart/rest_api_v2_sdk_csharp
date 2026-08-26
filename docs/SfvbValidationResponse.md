
# com.ultracart.admin.v2.Model.SfvbValidationResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;SfvbErrorDetail&gt;**](SfvbErrorDetail.md) | Problems that will prevent a write. | [optional] 
**UsedElements** | **List&lt;string&gt;** | Element types found in the document, sorted. | [optional] 
**Valid** | **bool** | True when there are no errors.  Warnings do not affect this flag. | [optional] 
**Warnings** | [**List&lt;SfvbErrorDetail&gt;**](SfvbErrorDetail.md) | Quality problems that will not prevent a write but should be addressed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

