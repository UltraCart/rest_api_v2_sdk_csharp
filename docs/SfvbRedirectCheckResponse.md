
# com.ultracart.admin.v2.Model.SfvbRedirectCheckResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;SfvbErrorDetail&gt;**](SfvbErrorDetail.md) | Findings that block the rule. | [optional] 
**Source** | **string** | The source as it matches, lower case without a trailing index.html. | [optional] 
**Type** | **string** | exact or pattern. | [optional] 
**Valid** | **bool** | True when nothing blocks the rule. | [optional] 
**Warnings** | [**List&lt;SfvbErrorDetail&gt;**](SfvbErrorDetail.md) | Findings that do not block it.  A chain carries the final target as its suggestion. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

