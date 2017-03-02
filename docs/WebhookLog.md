# com.ultracart.admin.v2.Model.WebhookLog
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeliveryDts** | **string** | Date/time of delivery | [optional] 
**Duration** | **int?** | Number of milliseconds to process the notification | [optional] 
**Request** | **string** | Request payload (first 100,000 characters) | [optional] 
**RequestHeaders** | [**List&lt;HTTPHeader&gt;**](HTTPHeader.md) | Request headers sent to the server | [optional] 
**RequestId** | **string** | Request id is a unique string that you can look up in the logs | [optional] 
**Response** | **string** | Response payload (first 100,000 characters) | [optional] 
**ResponseHeaders** | [**List&lt;HTTPHeader&gt;**](HTTPHeader.md) | Response headers received from the server | [optional] 
**StatusCode** | **int?** | HTTP status code received from the server | [optional] 
**Success** | **bool?** | True if the delivery was successful | [optional] 
**Uri** | **string** | URI of the webhook delivered to | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

