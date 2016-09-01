# com.ultracart.admin.v2.Api.WebhookApi

All URIs are relative to *https://secure.ultracart.com/rest/admin/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WebhookWebhooksGet**](WebhookApi.md#webhookwebhooksget) | **GET** /webhook/webhooks | Retrieve webhooks
[**WebhookWebhooksPost**](WebhookApi.md#webhookwebhookspost) | **POST** /webhook/webhooks | Add a webhook
[**WebhookWebhooksWebhookOidDelete**](WebhookApi.md#webhookwebhookswebhookoiddelete) | **DELETE** /webhook/webhooks/{webhookOid} | Delete a webhook
[**WebhookWebhooksWebhookOidLogsGet**](WebhookApi.md#webhookwebhookswebhookoidlogsget) | **GET** /webhook/webhooks/{webhookOid}/logs | Retrieve the log summaries
[**WebhookWebhooksWebhookOidLogsRequestIdGet**](WebhookApi.md#webhookwebhookswebhookoidlogsrequestidget) | **GET** /webhook/webhooks/{webhookOid}/logs/{requestId} | Retrieve an individual log
[**WebhookWebhooksWebhookOidPut**](WebhookApi.md#webhookwebhookswebhookoidput) | **PUT** /webhook/webhooks/{webhookOid} | Update a webhook
[**WebhookWebhooksWebhookOidReflowEventNamePost**](WebhookApi.md#webhookwebhookswebhookoidrefloweventnamepost) | **POST** /webhook/webhooks/{webhookOid}/reflow/{eventName} | Resend events to the webhook endpoint.
[**WebhookWebhooksWebhookOidSamplesGet**](WebhookApi.md#webhookwebhookswebhookoidsamplesget) | **GET** /webhook/webhooks/{webhookOid}/samples | Retrieve a sample notification.
[**WebhookWebhooksWebhookOidValidatePost**](WebhookApi.md#webhookwebhookswebhookoidvalidatepost) | **POST** /webhook/webhooks/{webhookOid}/validate | Send test message to an endpoint.


<a name="webhookwebhooksget"></a>
# **WebhookWebhooksGet**
> WebhooksResponse WebhookWebhooksGet ()

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

            try
            {
                // Retrieve webhooks
                WebhooksResponse result = apiInstance.WebhookWebhooksGet();
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
This endpoint does not need any parameter.

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
> WebhooksResponse WebhookWebhooksPost (Webhook webhook)

Add a webhook

Adds a new webhook on the account 

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

            try
            {
                // Add a webhook
                WebhooksResponse result = apiInstance.WebhookWebhooksPost(webhook);
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

### Return type

[**WebhooksResponse**](WebhooksResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
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
> WebhookLogSummariesResponse WebhookWebhooksWebhookOidLogsGet (int? webhookOid)

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

            try
            {
                // Retrieve the log summaries
                WebhookLogSummariesResponse result = apiInstance.WebhookWebhooksWebhookOidLogsGet(webhookOid);
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
> WebhooksResponse WebhookWebhooksWebhookOidPut (Webhook webhook, int? webhookOid)

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

            try
            {
                // Update a webhook
                WebhooksResponse result = apiInstance.WebhookWebhooksWebhookOidPut(webhook, webhookOid);
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

### Return type

[**WebhooksResponse**](WebhooksResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhookwebhookswebhookoidsamplesget"></a>
# **WebhookWebhooksWebhookOidSamplesGet**
> WebhookSampleRequestResponse WebhookWebhooksWebhookOidSamplesGet (int? webhookOid)

Retrieve a sample notification.

Retrieves a sample notification for the webhook.  This provides as example of what the notifications that can be delivered will look like. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class WebhookWebhooksWebhookOidSamplesGetExample
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
            var webhookOid = 56;  // int? | The webhook oid to retrieve samples for.

            try
            {
                // Retrieve a sample notification.
                WebhookSampleRequestResponse result = apiInstance.WebhookWebhooksWebhookOidSamplesGet(webhookOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookWebhooksWebhookOidSamplesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookOid** | **int?**| The webhook oid to retrieve samples for. | 

### Return type

[**WebhookSampleRequestResponse**](WebhookSampleRequestResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhookwebhookswebhookoidvalidatepost"></a>
# **WebhookWebhooksWebhookOidValidatePost**
> WebhookLogResponse WebhookWebhooksWebhookOidValidatePost (WebhookSampleRequest samples, int? webhookOid)

Send test message to an endpoint.

Performs a test of the webhook endpoint given the specified sample request and returns the log associated with the response. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class WebhookWebhooksWebhookOidValidatePostExample
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
            var samples = new WebhookSampleRequest(); // WebhookSampleRequest | Samples to send in the test
            var webhookOid = 56;  // int? | The webhook oid that is being tested.

            try
            {
                // Send test message to an endpoint.
                WebhookLogResponse result = apiInstance.WebhookWebhooksWebhookOidValidatePost(samples, webhookOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookWebhooksWebhookOidValidatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **samples** | [**WebhookSampleRequest**](WebhookSampleRequest.md)| Samples to send in the test | 
 **webhookOid** | **int?**| The webhook oid that is being tested. | 

### Return type

[**WebhookLogResponse**](WebhookLogResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

