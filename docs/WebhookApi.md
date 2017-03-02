# com.ultracart.admin.v2.Api.WebhookApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WebhookWebhooksGet**](WebhookApi.md#webhookwebhooksget) | **GET** /webhook/webhooks | Retrieve webhooks
[**WebhookWebhooksPost**](WebhookApi.md#webhookwebhookspost) | **POST** /webhook/webhooks | Add a webhook
[**WebhookWebhooksWebhookOidDelete**](WebhookApi.md#webhookwebhookswebhookoiddelete) | **DELETE** /webhook/webhooks/{webhookOid} | Delete a webhook
[**WebhookWebhooksWebhookOidLogsGet**](WebhookApi.md#webhookwebhookswebhookoidlogsget) | **GET** /webhook/webhooks/{webhookOid}/logs | Retrieve the log summaries
[**WebhookWebhooksWebhookOidLogsRequestIdGet**](WebhookApi.md#webhookwebhookswebhookoidlogsrequestidget) | **GET** /webhook/webhooks/{webhookOid}/logs/{requestId} | Retrieve an individual log
[**WebhookWebhooksWebhookOidPut**](WebhookApi.md#webhookwebhookswebhookoidput) | **PUT** /webhook/webhooks/{webhookOid} | Update a webhook
[**WebhookWebhooksWebhookOidReflowEventNamePost**](WebhookApi.md#webhookwebhookswebhookoidrefloweventnamepost) | **POST** /webhook/webhooks/{webhookOid}/reflow/{eventName} | Resend events to the webhook endpoint.


<a name="webhookwebhooksget"></a>
# **WebhookWebhooksGet**
> WebhooksResponse WebhookWebhooksGet (int? limit = null, int? offset = null, string sort = null, bool? placeholders = null)

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
    public class WebhookWebhooksGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new WebhookApi();
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var sort = sort_example;  // string | The sort order of the webhooks.  See documentation for examples (optional) 
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 

            try
            {
                // Retrieve webhooks
                WebhooksResponse result = apiInstance.WebhookWebhooksGet(limit, offset, sort, placeholders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookWebhooksGet: " + e.Message );
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

<a name="webhookwebhookspost"></a>
# **WebhookWebhooksPost**
> WebhookResponse WebhookWebhooksPost (Webhook webhook, bool? placeholders = null)

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
    public class WebhookWebhooksPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new WebhookApi();
            var webhook = new Webhook(); // Webhook | Webhook to create
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 

            try
            {
                // Add a webhook
                WebhookResponse result = apiInstance.WebhookWebhooksPost(webhook, placeholders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookWebhooksPost: " + e.Message );
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

<a name="webhookwebhookswebhookoiddelete"></a>
# **WebhookWebhooksWebhookOidDelete**
> void WebhookWebhooksWebhookOidDelete (int? webhookOid)

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
    public class WebhookWebhooksWebhookOidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new WebhookApi();
            var webhookOid = 56;  // int? | The webhook oid to delete.

            try
            {
                // Delete a webhook
                apiInstance.WebhookWebhooksWebhookOidDelete(webhookOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookWebhooksWebhookOidDelete: " + e.Message );
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

<a name="webhookwebhookswebhookoidlogsget"></a>
# **WebhookWebhooksWebhookOidLogsGet**
> WebhookLogSummariesResponse WebhookWebhooksWebhookOidLogsGet (int? webhookOid, int? limit = null, int? offset = null, string since = null)

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
    public class WebhookWebhooksWebhookOidLogsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new WebhookApi();
            var webhookOid = 56;  // int? | The webhook oid to retrieve log summaries for.
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var since = since_example;  // string | Fetch log summaries that have been delivered since this date/time. (optional) 

            try
            {
                // Retrieve the log summaries
                WebhookLogSummariesResponse result = apiInstance.WebhookWebhooksWebhookOidLogsGet(webhookOid, limit, offset, since);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookWebhooksWebhookOidLogsGet: " + e.Message );
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

<a name="webhookwebhookswebhookoidlogsrequestidget"></a>
# **WebhookWebhooksWebhookOidLogsRequestIdGet**
> WebhookLogResponse WebhookWebhooksWebhookOidLogsRequestIdGet (int? webhookOid, string requestId)

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
    public class WebhookWebhooksWebhookOidLogsRequestIdGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new WebhookApi();
            var webhookOid = 56;  // int? | The webhook oid that owns the log.
            var requestId = requestId_example;  // string | The request id associated with the log to view.

            try
            {
                // Retrieve an individual log
                WebhookLogResponse result = apiInstance.WebhookWebhooksWebhookOidLogsRequestIdGet(webhookOid, requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookWebhooksWebhookOidLogsRequestIdGet: " + e.Message );
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

<a name="webhookwebhookswebhookoidput"></a>
# **WebhookWebhooksWebhookOidPut**
> WebhookResponse WebhookWebhooksWebhookOidPut (Webhook webhook, int? webhookOid, bool? placeholders = null)

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
    public class WebhookWebhooksWebhookOidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new WebhookApi();
            var webhook = new Webhook(); // Webhook | Webhook to update
            var webhookOid = 56;  // int? | The webhook oid to update.
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 

            try
            {
                // Update a webhook
                WebhookResponse result = apiInstance.WebhookWebhooksWebhookOidPut(webhook, webhookOid, placeholders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookWebhooksWebhookOidPut: " + e.Message );
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

<a name="webhookwebhookswebhookoidrefloweventnamepost"></a>
# **WebhookWebhooksWebhookOidReflowEventNamePost**
> WebhookSampleRequestResponse WebhookWebhooksWebhookOidReflowEventNamePost (int? webhookOid, string eventName)

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
    public class WebhookWebhooksWebhookOidReflowEventNamePostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new WebhookApi();
            var webhookOid = 56;  // int? | The webhook oid that is receiving the reflowed events.
            var eventName = eventName_example;  // string | The event to reflow.

            try
            {
                // Resend events to the webhook endpoint.
                WebhookSampleRequestResponse result = apiInstance.WebhookWebhooksWebhookOidReflowEventNamePost(webhookOid, eventName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookWebhooksWebhookOidReflowEventNamePost: " + e.Message );
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

