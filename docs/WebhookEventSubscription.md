
# com.ultracart.admin.v2.Model.WebhookEventSubscription

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Comments** | **string** | Comment about the event to provide further clarification to the end user | [optional] 
**DeprecatedFlag** | **bool** | True if the event is deprecated.  See the API change log for details on when it will be discontinued. | [optional] 
**DiscontinuedFlag** | **bool** | True if the event is discontinued.  See the API change log for details on migration details. | [optional] 
**EventDescription** | **string** | Description of the event | [optional] 
**EventName** | **string** | Event name | [optional] 
**EventRuler** | **string** | Optional - Event ruler expression to filter events to.  Only events that match this Ruler expression will be transmitted to the webhook. | [optional] 
**Expansion** | **string** | The expand string for the notification object.  See the individual resource _expand documentation for valid values. | [optional] 
**Subscribed** | **bool** | True if this is event is subscribed to | [optional] 
**SupportsReflow** | **bool** | True if the event can be triggered to reflow existing records | [optional] 
**WebhookEventOid** | **int** | The webhook event object identifier | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

