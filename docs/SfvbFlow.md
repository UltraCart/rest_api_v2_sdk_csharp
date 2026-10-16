
# com.ultracart.admin.v2.Model.SfvbFlow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CommunicationSequenceUuid** | **string** | The communication sequence the steps belong to. | [optional] 
**CreatedDts** | **string** | When the flow was created (ISO 8601, UTC). | [optional] 
**Deleted** | **bool** | True when the flow was deleted. | [optional] 
**Emails** | [**List&lt;SfvbCommsEmail&gt;**](SfvbCommsEmail.md) | Its emails, in step order. | [optional] 
**FlowUuid** | **string** | The flow uuid. | [optional] 
**Live** | **bool** | True when the emails and postcards reach customers now, so a change to one shows at once.  False only in a status that sends nothing. | [optional] 
**Name** | **string** | The flow name. | [optional] 
**Postcards** | [**List&lt;SfvbCommsPostcard&gt;**](SfvbCommsPostcard.md) | Its postcards, in step order. | [optional] 
**Status** | **string** | The status, such as draft, active, paused, draining or inactive. | [optional] 
**StatusDts** | **string** | When the status last changed (ISO 8601, UTC). | [optional] 
**TriggerParameterName** | **string** | The name of the trigger parameter, when the trigger takes one. | [optional] 
**TriggerType** | **string** | What starts the flow, such as cart abandon or an order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

