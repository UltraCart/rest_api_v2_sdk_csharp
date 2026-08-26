
# com.ultracart.admin.v2.Model.SfvbValidateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cjson** | **string** | The container JSON to validate. | [optional] 
**ContainerName** | **string** | Container name it will be stored under, for example upsell-offer or email-footer.  Some rules key off the name. | [optional] 
**IncludeWarnings** | **bool** | Include quality warnings as well as errors.  Defaults to true. | [optional] 
**MarketingEmail** | **bool** | For email containers, whether this is a marketing email.  Marketing emails carry CAN-SPAM footer requirements that transactional emails do not. | [optional] 
**OwnerType** | **string** | Where this container is destined to live.  Determines which contextual rules apply. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

