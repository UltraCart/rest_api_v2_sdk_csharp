
# com.ultracart.admin.v2.Model.SfvbFlowWriteRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowMultipleConcurrentEnrollments** | **bool** | True when a customer may be in this flow more than once at a time. | [optional] 
**EndOnceCustomerPurchases** | **bool** | True to end the flow for a customer once they buy from one of its emails. | [optional] 
**EndOnceCustomerPurchasesAnywhere** | **bool** | True to end the flow for a customer once they buy from any source. | [optional] 
**Name** | **string** | The flow name, 1 to 250 characters.  Required to create. | [optional] 
**ReentryDelayDays** | **int** | Days before a customer may enter again, 1 to 1095.  Only with after_days. | [optional] 
**ReentryPolicy** | **string** | Whether a customer may enter again, anytime, after_days or never. | [optional] 
**SendingDomainUuid** | **string** | The sending domain uuid.  Defaults to the storefront&#39;s marketing sending domain. | [optional] 
**SendingName** | **string** | The from name.  Defaults to the storefront&#39;s marketing setting. | [optional] 
**SendingUser** | **string** | The part of the from address before the at sign.  Defaults to the storefront&#39;s marketing setting. | [optional] 
**TriggerParameter** | **string** | The list or segment uuid for a list or segment trigger.  Create only. | [optional] 
**TriggerType** | **string** | What enrolls a customer, such as cart abandoned.  Create only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

