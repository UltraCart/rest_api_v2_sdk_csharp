
# com.ultracart.admin.v2.Model.SfvbFlow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowMultipleConcurrentEnrollments** | **bool** | True when a customer may be in this flow more than once at a time. | [optional] 
**CommunicationSequenceUuid** | **string** | The communication sequence the steps belong to. | [optional] 
**CreatedDts** | **string** | When the flow was created (ISO 8601, UTC). | [optional] 
**Deleted** | **bool** | True when the flow was deleted. | [optional] 
**Emails** | [**List&lt;SfvbCommsEmail&gt;**](SfvbCommsEmail.md) | Its emails, in step order. | [optional] 
**EndOnceCustomerPurchases** | **bool** | True when a customer leaves the flow once they buy from one of its emails. | [optional] 
**EndOnceCustomerPurchasesAnywhere** | **bool** | True when a customer leaves the flow once they buy from any source. | [optional] 
**FlowUuid** | **string** | The flow uuid. | [optional] 
**HashSha256** | **string** | Send this as If-Match when changing, archiving or turning the flow on or off. | [optional] 
**Live** | **bool** | True when the emails and postcards reach customers now, so a change to one shows at once.  False only in a status that sends nothing. | [optional] 
**Name** | **string** | The flow name. | [optional] 
**Notes** | **List&lt;string&gt;** | What a write did beyond the fields it was asked to change, such as putting emails back to needing review or setting a scheduled campaign back to draft.  Only on a write. | [optional] 
**Postcards** | [**List&lt;SfvbCommsPostcard&gt;**](SfvbCommsPostcard.md) | Its postcards, in step order. | [optional] 
**ReentryDelayDays** | **int** | Days before a customer may enter again, with after_days. | [optional] 
**ReentryPolicy** | **string** | Whether a customer may enter again, anytime, after_days or never. | [optional] 
**SendingDomainUuid** | **string** | The sending domain uuid.  Defaults to the storefront&#39;s marketing sending domain. | [optional] 
**SendingName** | **string** | The from name.  Defaults to the storefront&#39;s marketing setting. | [optional] 
**SendingUser** | **string** | The part of the from address before the at sign.  Defaults to the storefront&#39;s marketing setting. | [optional] 
**Status** | **string** | The status, such as draft, active, paused, draining or inactive. | [optional] 
**StatusDts** | **string** | When the status last changed (ISO 8601, UTC). | [optional] 
**TriggerParameter** | **string** | The list or segment uuid, or other value, the trigger is limited to. | [optional] 
**TriggerParameterName** | **string** | The name of the trigger parameter, when the trigger takes one. | [optional] 
**TriggerType** | **string** | What starts the flow, such as cart abandon or an order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

