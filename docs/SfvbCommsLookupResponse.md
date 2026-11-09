
# com.ultracart.admin.v2.Model.SfvbCommsLookupResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Archived** | **bool** | True when the uuid is an archived campaign or flow.  It is still on its storefront and can be read; it sends nothing. | [optional] 
**CommunicationSequenceUuid** | **string** | The sequence it belongs to, when there is one. | [optional] 
**Kind** | **string** | campaign, flow, sequence, step, email, postcard, list or segment. | [optional] 
**Name** | **string** | The campaign, flow, list or segment name, or the email subject. | [optional] 
**Next** | **string** | The CLI command that reads it. | [optional] 
**Notes** | **List&lt;string&gt;** | What the answer means, in sentences. | [optional] 
**Owner** | [**SfvbCommsLookupOwner**](SfvbCommsLookupOwner.md) |  | [optional] 
**StepUuid** | **string** | The step that sends it, for an email or postcard a step names, or the step itself. | [optional] 
**StorefrontOid** | **int** | The storefront it lives on, for the - -storefront option. | [optional] 
**Uuid** | **string** | The uuid looked up. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

