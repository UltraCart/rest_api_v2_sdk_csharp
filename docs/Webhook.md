
# com.ultracart.admin.v2.Model.Webhook

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiUserOid** | **int** | Populated if webhook associated with an API user | [optional] 
**ApiVersion** | **string** | Version of the API objects that are sent in notifications | [optional] 
**ApplicationProfile** | [**ApiUserApplicationProfile**](ApiUserApplicationProfile.md) |  | [optional] 
**AuthenticationType** | **string** | The type of authentication this webhook will use when communicating with your server | [optional] 
**BasicPassword** | **string** | Basic authentication password | [optional] 
**BasicUsername** | **string** | Basic authentication user name | [optional] 
**CompressEvents** | **bool** | Compress events with GZIP then base 64 encode them as a string | [optional] 
**ConsecutiveFailures** | **int** | The number of consecutive failures that have occurred trying to deliver notifications to the target server | [optional] 
**Disabled** | **bool** | True if the webhook has been disabled | [optional] 
**EventCategories** | [**List&lt;WebhookEventCategory&gt;**](WebhookEventCategory.md) | The categories of events.  Individual events and subscriptions are handled in the child objects.  _placeholders parameter effects the population of this on a retrieval. | [optional] 
**IamAccessKey** | **string** | IAM Access Key for AWS SQS Delivery | [optional] 
**IamSecretKey** | **string** | IAM Secret Key for AWS SQS Delivery | [optional] 
**MaximumEvents** | **int** | The maximum number of events in the payload that UltraCart will deliver | [optional] 
**MaximumSize** | **int** | The maximum size of the payload that UltraCart will deliver | [optional] 
**MerchantId** | **string** | The UltraCart merchant ID that owns this webhook | [optional] 
**NextRetryAfter** | **string** | The next time UltraCart will attempt delivery if failures have been occurring | [optional] 
**Pending** | **int** | The number of pending events for this webhook | [optional] 
**WebhookOid** | **int** | The object identifier for this webhook | [optional] 
**WebhookUrl** | **string** | The URL to deliver events to.  Must be HTTPS for customer related information. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

