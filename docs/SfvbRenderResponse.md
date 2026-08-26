
# com.ultracart.admin.v2.Model.SfvbRenderResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;SfvbErrorDetail&gt;**](SfvbErrorDetail.md) | Why the render failed.  Always populated when success is false. | [optional] 
**Html** | **string** | Rendered HTML. | [optional] 
**PendingTranslationCount** | **int** | Number of strings still awaiting translation in the requested language. | [optional] 
**Success** | **bool** | True when HTML was produced. | [optional] 
**Truncated** | **bool** | True when the HTML was cut short. | [optional] 
**Warnings** | [**List&lt;SfvbErrorDetail&gt;**](SfvbErrorDetail.md) | Quality warnings about the rendered node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

