# com.ultracart.admin.v2.Api.WebhookApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteWebhook**](WebhookApi.md#deletewebhook) | **DELETE** /webhook/webhooks/{webhookOid} | Delete a webhook
[**GetWebhookLog**](WebhookApi.md#getwebhooklog) | **GET** /webhook/webhooks/{webhookOid}/logs/{requestId} | Retrieve an individual log
[**GetWebhookLogSummaries**](WebhookApi.md#getwebhooklogsummaries) | **GET** /webhook/webhooks/{webhookOid}/logs | Retrieve the log summaries
[**GetWebhooks**](WebhookApi.md#getwebhooks) | **GET** /webhook/webhooks | Retrieve webhooks
[**InsertWebhook**](WebhookApi.md#insertwebhook) | **POST** /webhook/webhooks | Add a webhook
[**ResendEvent**](WebhookApi.md#resendevent) | **POST** /webhook/webhooks/{webhookOid}/reflow/{eventName} | Resend events to the webhook endpoint.
[**UpdateWebhook**](WebhookApi.md#updatewebhook) | **PUT** /webhook/webhooks/{webhookOid} | Update a webhook


<a name="deletewebhook"></a>
# **DeleteWebhook**
> void DeleteWebhook (int? webhookOid)

Delete a webhook

Delete a webhook on the UltraCart account. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteWebhookExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-ultracart-simple-key", "Bearer");

            var apiInstance = new WebhookApi();
            var webhookOid = 56;  // int? | The webhook oid to delete.

            try
            {
                // Delete a webhook
                apiInstance.DeleteWebhook(webhookOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.DeleteWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookOid** | **int?**| The webhook oid to delete. | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooklog"></a>
# **GetWebhookLog**
> WebhookLogResponse GetWebhookLog (int? webhookOid, string requestId)

Retrieve an individual log

Retrieves an individual log for a webhook given the webhook oid the request id. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetWebhookLogExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-ultracart-simple-key", "Bearer");

            var apiInstance = new WebhookApi();
            var webhookOid = 56;  // int? | The webhook oid that owns the log.
            var requestId = requestId_example;  // string | The request id associated with the log to view.

            try
            {
                // Retrieve an individual log
                WebhookLogResponse result = apiInstance.GetWebhookLog(webhookOid, requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.GetWebhookLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookOid** | **int?**| The webhook oid that owns the log. | 
 **requestId** | **string**| The request id associated with the log to view. | 

### Return type

[**WebhookLogResponse**](WebhookLogResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooklogsummaries"></a>
# **GetWebhookLogSummaries**
> WebhookLogSummariesResponse GetWebhookLogSummaries (int? webhookOid, int? limit = null, int? offset = null, string since = null)

Retrieve the log summaries

Retrieves the log summary information for a given webhook.  This is useful for displaying all the various logs that can be viewed. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetWebhookLogSummariesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-ultracart-simple-key", "Bearer");

            var apiInstance = new WebhookApi();
            var webhookOid = 56;  // int? | The webhook oid to retrieve log summaries for.
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var since = since_example;  // string | Fetch log summaries that have been delivered since this date/time. (optional) 

            try
            {
                // Retrieve the log summaries
                WebhookLogSummariesResponse result = apiInstance.GetWebhookLogSummaries(webhookOid, limit, offset, since);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.GetWebhookLogSummaries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookOid** | **int?**| The webhook oid to retrieve log summaries for. | 
 **limit** | **int?**| The maximum number of records to return on this one API call. | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **since** | **string**| Fetch log summaries that have been delivered since this date/time. | [optional] 

### Return type

[**WebhookLogSummariesResponse**](WebhookLogSummariesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooks"></a>
# **GetWebhooks**
> WebhooksResponse GetWebhooks (int? limit = null, int? offset = null, string sort = null, bool? placeholders = null)

Retrieve webhooks

Retrieves the webhooks associated with this application. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetWebhooksExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-ultracart-simple-key", "Bearer");

            var apiInstance = new WebhookApi();
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var sort = sort_example;  // string | The sort order of the webhooks.  See documentation for examples (optional) 
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 

            try
            {
                // Retrieve webhooks
                WebhooksResponse result = apiInstance.GetWebhooks(limit, offset, sort, placeholders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.GetWebhooks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| The maximum number of records to return on this one API call. | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **sort** | **string**| The sort order of the webhooks.  See documentation for examples | [optional] 
 **placeholders** | **bool?**| Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. | [optional] 

### Return type

[**WebhooksResponse**](WebhooksResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertwebhook"></a>
# **InsertWebhook**
> WebhookResponse InsertWebhook (Webhook webhook, bool? placeholders = null)

Add a webhook

Adds a new webhook on the account.  If you add a new webhook with the authentication_type set to basic, but do not specify the basic_username and basic_password, UltraCart will automatically generate random ones and return them.  This allows your application to have simpler logic on the setup of a secure webhook. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertWebhookExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-ultracart-simple-key", "Bearer");

            var apiInstance = new WebhookApi();
            var webhook = new Webhook(); // Webhook | Webhook to create
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 

            try
            {
                // Add a webhook
                WebhookResponse result = apiInstance.InsertWebhook(webhook, placeholders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.InsertWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhook** | [**Webhook**](Webhook.md)| Webhook to create | 
 **placeholders** | **bool?**| Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. | [optional] 

### Return type

[**WebhookResponse**](WebhookResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resendevent"></a>
# **ResendEvent**
> WebhookSampleRequestResponse ResendEvent (int? webhookOid, string eventName)

Resend events to the webhook endpoint.

This method will resend events to the webhook endpoint.  This method can be used for example to send all the existing items on an account to a webhook. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ResendEventExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-ultracart-simple-key", "Bearer");

            var apiInstance = new WebhookApi();
            var webhookOid = 56;  // int? | The webhook oid that is receiving the reflowed events.
            var eventName = eventName_example;  // string | The event to reflow.

            try
            {
                // Resend events to the webhook endpoint.
                WebhookSampleRequestResponse result = apiInstance.ResendEvent(webhookOid, eventName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.ResendEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookOid** | **int?**| The webhook oid that is receiving the reflowed events. | 
 **eventName** | **string**| The event to reflow. | 

### Return type

[**WebhookSampleRequestResponse**](WebhookSampleRequestResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewebhook"></a>
# **UpdateWebhook**
> WebhookResponse UpdateWebhook (Webhook webhook, int? webhookOid, bool? placeholders = null)

Update a webhook

Update a webhook on the account 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateWebhookExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-ultracart-simple-key", "Bearer");

            var apiInstance = new WebhookApi();
            var webhook = new Webhook(); // Webhook | Webhook to update
            var webhookOid = 56;  // int? | The webhook oid to update.
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 

            try
            {
                // Update a webhook
                WebhookResponse result = apiInstance.UpdateWebhook(webhook, webhookOid, placeholders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.UpdateWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhook** | [**Webhook**](Webhook.md)| Webhook to update | 
 **webhookOid** | **int?**| The webhook oid to update. | 
 **placeholders** | **bool?**| Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. | [optional] 

### Return type

[**WebhookResponse**](WebhookResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

