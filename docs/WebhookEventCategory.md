# com.ultracart.admin.v2.Model.WebhookEventCategory
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventCategory** | **string** | Name of the event category | [optional] 
**Events** | [**List&lt;WebhookEventSubscription&gt;**](WebhookEventSubscription.md) | The events within the category.  Individual subscription flags contained within the child object. | [optional] 
**Subscribed** | **bool?** | True if all the events within this category are subscribed.  This is a convenience flag to make user interfaces easier. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

