
# com.ultracart.admin.v2.Model.SfvbEmailRenderResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Draft** | **bool** | True when an unsaved draft was rendered. | [optional] 
**Html** | **string** | The HTML body. | [optional] 
**OrderId** | **string** | The order the email rendered with, when it used one. | [optional] 
**OrderSource** | **string** | Where that order came from.  test (the order given), dummy (made up) or none. | [optional] 
**PreviewText** | **string** | The preview text an inbox shows after the subject, when the email has one. | [optional] 
**Subject** | **string** | The subject line. | [optional] 
**Text** | **string** | The plain text body. | [optional] 
**Validation** | [**SfvbValidationResponse**](SfvbValidationResponse.md) |  | [optional] 
**Warnings** | [**List&lt;SfvbErrorDetail&gt;**](SfvbErrorDetail.md) | Problems a real send would hit, such as a missing required footer token, and placeholders used in place of values a send creates. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

