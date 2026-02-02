# com.ultracart.admin.v2.Api.WebhookApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteWebhook**](WebhookApi.md#deletewebhook) | **DELETE** /webhook/webhooks/{webhookOid} | Delete a webhook
[**DeleteWebhookByUrl**](WebhookApi.md#deletewebhookbyurl) | **DELETE** /webhook/webhooks | Delete a webhook by URL
[**GetWebhookLog**](WebhookApi.md#getwebhooklog) | **GET** /webhook/webhooks/{webhookOid}/logs/{requestId} | Retrieve an individual log
[**GetWebhookLogSummaries**](WebhookApi.md#getwebhooklogsummaries) | **GET** /webhook/webhooks/{webhookOid}/logs | Retrieve the log summaries
[**GetWebhooks**](WebhookApi.md#getwebhooks) | **GET** /webhook/webhooks | Retrieve webhooks
[**InsertWebhook**](WebhookApi.md#insertwebhook) | **POST** /webhook/webhooks | Add a webhook
[**ResendEvent**](WebhookApi.md#resendevent) | **POST** /webhook/webhooks/{webhookOid}/reflow/{eventName} | Resend events to the webhook endpoint.
[**UpdateWebhook**](WebhookApi.md#updatewebhook) | **PUT** /webhook/webhooks/{webhookOid} | Update a webhook



## DeleteWebhook

> void DeleteWebhook (int webhookOid)

Delete a webhook

Delete a webhook on the UltraCart account. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.webhook
{
    public class DeleteWebhook
    {
        public static void Execute()
        {
            /*
             * Deletes a webhook
             *
             * You will need the webhook_oid to call this method. Call getWebhooks() if you don't know your oid.
             * Returns status code 204 (No Content) on success
             */

            WebhookApi webhookApi = new WebhookApi(Constants.ApiKey);
            int webhookOid = 123456789; // call getWebhooks if you don't know this.
            webhookApi.DeleteWebhook(webhookOid);
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookOid** | **int**| The webhook oid to delete. | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteWebhookByUrl

> WebhookResponse DeleteWebhookByUrl (Webhook webhook)

Delete a webhook by URL

Delete a webhook based upon the URL on the webhook_url matching an existing webhook. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.webhook
{
    public class DeleteWebhookByUrl
    {
        public static void Execute()
        {
            /*
             * This method can be confusing due to its payload. The method does indeed delete a webhook by url, but you need to
             * pass a webhook object in as the payload. However, only the url is used. UltraCart does this to avoid any confusion
             * with the rest url versus the webhook url.
             *
             * To use:
             * Get your webhook url.
             * Create a Webhook object.
             * Set the Webhook url property.
             * Pass the webhook to deleteWebhookByUrl()
             *
             * Returns status code 204 (No Content) on success
             */

            WebhookApi webhookApi = new WebhookApi(Constants.ApiKey);

            string webhookUrl = "https://www.mywebiste.com/page/to/call/when/this/webhook/fires.php";
            Webhook webhook = new Webhook();
            webhook.WebhookUrl = webhookUrl;

            webhookApi.DeleteWebhookByUrl(webhook);
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhook** | [**Webhook**](Webhook.md)| Webhook to delete | 

### Return type

[**WebhookResponse**](WebhookResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetWebhookLog

> WebhookLogResponse GetWebhookLog (int webhookOid, string requestId)

Retrieve an individual log

Retrieves an individual log for a webhook given the webhook oid the request id. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.webhook
{
    public class GetWebhookLog
    {
        public static void Execute()
        {
            /*
             * getWebhookLog() provides a detail log of a webhook event. It is used in tandem with getWebhookLogSummaries to audit
             * webhook events. This method call will require the webhook_oid and the request_id. The webhook_oid can be discerned
             * from the results of getWebhooks() and the request_id can be found from getWebhookLogSummaries(). see those examples
             * if needed.
             */

            WebhookApi webhookApi = new WebhookApi(Constants.ApiKey);

            int webhookOid = 123456789; // call getWebhooks if you don't know this.
            string requestId = "987654321";  // call getWebhookLogSummaries if you don't know this.

            WebhookLogResponse apiResponse = webhookApi.GetWebhookLog(webhookOid, requestId);
            WebhookLog webhookLog = apiResponse.WebhookLog;

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                Environment.Exit(1);
            }

            Console.WriteLine("<html lang=\"en\"><body><pre>");
            Console.WriteLine(webhookLog.ToString());
            Console.WriteLine("</pre></body></html>");
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookOid** | **int**| The webhook oid that owns the log. | 
 **requestId** | **string**| The request id associated with the log to view. | 

### Return type

[**WebhookLogResponse**](WebhookLogResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetWebhookLogSummaries

> WebhookLogSummariesResponse GetWebhookLogSummaries (int webhookOid, int? limit = null, int? offset = null, string since = null)

Retrieve the log summaries

Retrieves the log summary information for a given webhook.  This is useful for displaying all the various logs that can be viewed. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace SdkSample.webhook
{
    public class GetWebhookLogSummaries
    {
        /*
         * This example illustrates how to retrieve webhook log summaries.
         */

        /// <summary>
        /// Gets a chunk of webhook log summaries
        /// </summary>
        /// <param name="webhookApi">The webhook API instance</param>
        /// <param name="offset">Offset for pagination</param>
        /// <param name="limit">Maximum number of records to return</param>
        /// <returns>Array of webhook log summaries</returns>
        /// <exception cref="ApiException">Thrown when API call fails</exception>
        private static List<WebhookLogSummary> GetSummaryChunk(WebhookApi webhookApi, int offset, int limit)
        {
            int webhookOid = 123456789; // if you don't know this, use getWebhooks to find your webhook, then get its oid.
            string since = DateTime.Now.AddDays(-10).ToString("yyyy-MM-dd") + "T00:00:00+00:00"; // get the last 10 days
            // Pay attention to whether limit or offset comes first in the method signature. UltraCart is not consistent with their ordering.
            WebhookLogSummariesResponse apiResponse = webhookApi.GetWebhookLogSummaries(webhookOid, limit, offset, since);

            if (apiResponse.WebhookLogSummaries != null)
            {
                return apiResponse.WebhookLogSummaries;
            }
            return new List<WebhookLogSummary>();
        }

        public static void Execute()
        {
            WebhookApi webhookApi = new WebhookApi(Constants.ApiKey);
            
            List<WebhookLogSummary> summaries = new List<WebhookLogSummary>();

            int iteration = 1;
            int offset = 0;
            int limit = 200;
            bool moreRecordsToFetch = true;

            try
            {
                while (moreRecordsToFetch)
                {
                    Console.WriteLine("executing iteration " + iteration);

                    List<WebhookLogSummary> chunkOfSummaries = GetSummaryChunk(webhookApi, offset, limit);
                    summaries.AddRange(chunkOfSummaries);
                    offset = offset + limit;
                    moreRecordsToFetch = chunkOfSummaries.Count == limit;
                    iteration++;
                }
            }
            catch (ApiException e)
            {
                Console.WriteLine("ApiException occurred on iteration " + iteration);
                Console.WriteLine(e.ToString());
                Environment.Exit(1);
            }

            // this will be verbose...
            foreach (WebhookLogSummary summary in summaries)
            {
                Console.WriteLine(summary.ToString());
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookOid** | **int**| The webhook oid to retrieve log summaries for. | 
 **limit** | **int?**| The maximum number of records to return on this one API call. | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **since** | **string**| Fetch log summaries that have been delivered since this date/time. | [optional] 

### Return type

[**WebhookLogSummariesResponse**](WebhookLogSummariesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetWebhooks

> WebhooksResponse GetWebhooks (int? limit = null, int? offset = null, string sort = null, bool? placeholders = null)

Retrieve webhooks

Retrieves the webhooks associated with this application. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace SdkSample.webhook
{
    public class GetWebhooks
    {
        /*
         * This example illustrates how to retrieve all webhooks.
         */

        /// <summary>
        /// Gets a chunk of webhooks
        /// </summary>
        /// <param name="webhookApi">The webhook API instance</param>
        /// <param name="offset">Offset for pagination</param>
        /// <param name="limit">Maximum number of records to return</param>
        /// <returns>List of webhooks</returns>
        /// <exception cref="ApiException">Thrown when API call fails</exception>
        private static List<Webhook> GetWebhookChunk(WebhookApi webhookApi, int offset, int limit)
        {
            string sort = null; // default sorting is webhook_url, disabled, and those are also the two choices for sorting.
            bool? placeholders = null;  // useful for UI displays, but not needed here.
            // Pay attention to whether limit or offset comes first in the method signature. UltraCart is not consistent with their ordering.
            WebhooksResponse apiResponse = webhookApi.GetWebhooks(limit, offset, sort, placeholders);

            if (apiResponse.Webhooks != null)
            {
                return apiResponse.Webhooks;
            }
            return new List<Webhook>();
        }

        public static void Execute()
        {
            WebhookApi webhookApi = new WebhookApi(Constants.ApiKey);
            
            List<Webhook> webhooks = new List<Webhook>();

            int iteration = 1;
            int offset = 0;
            int limit = 200;
            bool moreRecordsToFetch = true;

            try
            {
                while (moreRecordsToFetch)
                {
                    Console.WriteLine("executing iteration " + iteration);

                    List<Webhook> chunkOfWebhooks = GetWebhookChunk(webhookApi, offset, limit);
                    webhooks.AddRange(chunkOfWebhooks);
                    offset = offset + limit;
                    moreRecordsToFetch = chunkOfWebhooks.Count == limit;
                    iteration++;
                }
            }
            catch (ApiException e)
            {
                Console.WriteLine("ApiException occurred on iteration " + iteration);
                Console.WriteLine(e.ToString());
                Environment.Exit(1);
            }

            // this will be verbose...
            foreach (Webhook webhook in webhooks)
            {
                Console.WriteLine(webhook.ToString());
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

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InsertWebhook

> WebhookResponse InsertWebhook (Webhook webhook, bool? placeholders = null)

Add a webhook

Adds a new webhook on the account.  If you add a new webhook with the authentication_type set to basic, but do not specify the basic_username and basic_password, UltraCart will automatically generate random ones and return them.  This allows your application to have simpler logic on the setup of a secure webhook. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.webhook
{
    public class InsertWebhook
    {
        public static void Execute()
        {
            /*
             * Adds a new webhook on the account.  If you add a new webhook with the authentication_type set to basic, but
             * do not specify the basic_username and basic_password, UltraCart will automatically generate random ones and
             * return them.  This allows your application to have simpler logic on the setup of a secure webhook.
             * 
             * Event Category      Event Name                      Description
             * auto_order	        auto_order_cancel	            Fired when an auto order is canceled
             * auto_order	        auto_order_create	            Fired when an auto order is created
             * auto_order	        auto_order_decline	            Fired when an auto order is declined
             * auto_order	        auto_order_disable	            Fired when an auto order is disabled
             * auto_order	        auto_order_preshipment          Fired when an auto order generates a new pre-shipment notice
             * auto_order	        auto_order_rebill	            Fired when an auto order is rebilled
             * auto_order	        auto_order_update	            Fired when an auto order is updated
             * chargeback	        chargeback_create	            Fired when a chargeback is created
             * chargeback	        chargeback_delete	            Fired when a chargeback is deleted
             * chargeback	        chargeback_update	            Fired when a chargeback is updated
             * checkout	            checkout_cart_abandon	        Fired when a cart is abandoned
             * checkout	            checkout_cart_send_return_email Fired when a return email should be sent to a customer
             * customer	            customer_create                 Fired when a customer profile is created.
             * customer	            customer_delete                 Fired when a customer profile is deleted.
             * customer	            customer_update                 Fired when a customer profile is updated.
             * fulfillment	        fulfillment_hold                Fired when an order is held for review
             * fulfillment	        fulfillment_transmit            Fired to transmit an order to the fulfillment house
             * item	                item_create                     Fired when a new item is created.
             * item	                item_delete                     Fired when an item is deleted.
             * item	                item_update                     Fired when an item is updated.
             * order	            order_abandon_recovery          Fired when a previously abandoned cart turns into an order
             * order	            order_create                    Fired when an order is placed
             * order	            order_delete                    Fired when an order is deleted
             * order	            order_payment_failed            Fired when a payment fails
             * order	            order_payment_process           Fired when a payment is processed
             * order	            order_refund                    Fired when an order is refunded
             * order	            order_reject                    Fired when an order is rejected
             * order	            order_s3_invoice                Fired when an invoice PDF is stored in S3 bucket
             * order	            order_s3_packing_slip           Fired when a packing slip PDF is stored in an S3 bucket
             * order	            order_ship                      Fired when an order is shipped
             * order	            order_ship_delivered            Fired when an order has a shipment delivered
             * order	            order_ship_expected             Fired when an order has an expected delivery date
             * order	            order_ship_out_for_delivery     Fired when an order has a shipment out for delivery
             * order	            order_stage_change              Fired when an order stage changes
             * order	            order_update                    Fired when an order is edited
             * storefront	        screen_recording                Fired when a screen recording is created
             * user	                user_create                     Fired when a user is created
             * user	                user_delete                     Fired when a user is deleted
             * user	                user_login                      Fired when a user logs in
             * user	                user_update                     Fired when a user is updated
             * workflow_task	    workflow_task_create            Fired when a workflow task is created
             * workflow_task	    workflow_task_delete            Fired when a workflow task is deleted
             * workflow_task	    workflow_task_update            Fired when a workflow task is updated
             * 
             * Note: Each event uses the same expansions as the event category.  To see a list of possible expansion values,
             * visit www.ultracart.com/api/. Order Expansions (https://www.ultracart.com/api/#resource_order.html) are listed
             * below because most webhooks are for order events.
             * Order Expansion:
             * affiliate	        auto_order          billing             checkout
             * affiliate.ledger	    channel_partner	    coupon	            customer_profile
             * digital_order	    edi	                fraud_score	        gift
             * gift_certificate	    internal	        item	            linked_shipment
             * marketing	        payment	            payment.transaction point_of_sale
             * quote	            salesforce	        shipping	        shipping.tracking_number_details
             * summary	            taxes	            utms
             * 
             * Note: The WebhookEventSubscription.event_ruler field is processed with the AWS Event Ruler library to filter down
             * events to just what you want.  If you wish to employ a ruler filter, see https://github.com/aws/event-ruler
             * for syntax examples.  You'll need to apply the aws syntax against the UltraCart object models.  Contact UltraCart
             * support if you need assistance creating the proper ruler expression.
             * 
             * 
             * Possible Errors:
             */

            WebhookApi webhookApi = new WebhookApi(Constants.ApiKey);

            Webhook webhook = new Webhook();
            webhook.WebhookUrl = "https://www.mywebiste.com/page/to/call/when/this/webhook/fires.php";  // Must be HTTPS if customer related information is being delivered.
            webhook.AuthenticationType = Webhook.AuthenticationTypeEnum.Basic;  // "basic","none","api user","aws iam"
            webhook.BasicUsername = "george";
            webhook.BasicPassword = "LlamaLlamaRedPajama";
            webhook.MaximumEvents = 10;
            webhook.MaximumSize = 5242880; // 5 MB is pretty chunky.
            webhook.ApiVersion = Webhook.ApiVersionEnum._20170301; // this is our only API version so far.
            webhook.CompressEvents = true; // compress events with gzip, then base64 encode them as a string.

            WebhookEventSubscription eventSub1 = new WebhookEventSubscription();
            eventSub1.EventName = "order_create";
            eventSub1.EventDescription = "when an order is placed";
            eventSub1.Expansion = "shipping,billing,item,coupon,summary"; // whatever you need.
            eventSub1.EventRuler = null; // no filtering.  we want all objects.
            eventSub1.Comments = "Merchant specific comment, for example: Bobby needs this webhook for the Accounting department.";

            WebhookEventSubscription eventSub2 = new WebhookEventSubscription();
            eventSub2.EventName = "order_update";
            eventSub2.EventDescription = "when an order is modified";
            eventSub2.Expansion = "shipping,billing,item,coupon,summary"; // whatever you need.
            eventSub2.EventRuler = null; // no filtering.  we want all objects.
            eventSub2.Comments = "Merchant specific comment, for example: Bobby needs this webhook for the Accounting department.";

            WebhookEventSubscription eventSub3 = new WebhookEventSubscription();
            eventSub3.EventName = "order_delete";
            eventSub3.EventDescription = "when an order is modified";
            eventSub3.Expansion = ""; // don't need any expansion on delete.  only need to know the order_id
            eventSub3.EventRuler = null; // no filtering.  we want all objects.
            eventSub3.Comments = "Merchant specific comment, for example: Bobby needs this webhook for the Accounting department.";

            WebhookEventCategory eventCategory1 = new WebhookEventCategory();
            eventCategory1.EventCategory = "order";
            eventCategory1.Events = new List<WebhookEventSubscription> { eventSub1, eventSub2, eventSub3 };

            // apiResponse.Webhook will return the newly created webhook.
            WebhookResponse apiResponse = webhookApi.InsertWebhook(webhook, false);

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                Environment.Exit(1);
            }

            Webhook createdWebhook = apiResponse.Webhook;
            // TODO - store the webhook oid in case you ever need to make changes.

            // This should equal what you submitted, plus contain much new information
            Console.WriteLine(createdWebhook.ToString());
 
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


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ResendEvent

> WebhookReflowResponse ResendEvent (int webhookOid, string eventName)

Resend events to the webhook endpoint.

This method will resend events to the webhook endpoint.  This method can be used for example to send all the existing items on an account to a webhook. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.webhook
{
    public class ResendEvent
    {
        public static void Execute()
        {
            /*
             * resentEvent is used to reflow an event.  It will resend ALL events in history.  So it is essentially a way to
             * get all objects from an event.  Currently, there are only two events available for reflow: "item_update", and "order_create".
             * These two events provide the means to have a webhook receive all items or orders.  This method is usually called
             * at the beginning of a webhook's life to prepopulate a merchant's database with all items or orders.
             *
             * You will need the webhook_oid to call this method.  Call getWebhooks() if you don't know your oid.
             */

            WebhookApi webhookApi = new WebhookApi(Constants.ApiKey);

            int webhookOid = 123456789; // call getWebhooks if you don't know this.
            string eventName = "item_update"; // or "order_create", but for this sample, we want all items.

            WebhookReflowResponse apiResponse = webhookApi.ResendEvent(webhookOid, eventName);
            WebhookReflow reflow = apiResponse.Reflow;
            bool success = reflow.Queued;

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                Environment.Exit(1);
            }

            Console.WriteLine(apiResponse.ToString());
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookOid** | **int**| The webhook oid that is receiving the reflowed events. | 
 **eventName** | **string**| The event to reflow. | 

### Return type

[**WebhookReflowResponse**](WebhookReflowResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateWebhook

> WebhookResponse UpdateWebhook (int webhookOid, Webhook webhook, bool? placeholders = null)

Update a webhook

Update a webhook on the account 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.webhook
{
    public class UpdateWebhook
    {
        public static void Execute()
        {
            /*
             * Updates a webhook on the account.  See insertWebhook.php for a complete example with field usage.
             * For this example, we are just updating the basic password.
             */

            WebhookApi webhookApi = new WebhookApi(Constants.ApiKey);

            // you should have stored this when you created the webhook.  If you don't know it, call getWebhooks and iterate through
            // them to find you target webhook (add useful comments to each webhook really helps in this endeavor) and get the
            // webhook oid from that.  You'll want to call getWebhooks any way to get the object for updating. It is HIGHLY
            // recommended to get the object from UltraCart for updating rather than constructing it yourself to avoid accidentally
            // deleting a part of the object during the update.
            int webhookOid = 123456789;

            Webhook webhookToUpdate = null;
            List<Webhook> webhooks = webhookApi.GetWebhooks(100, 0, null, null).Webhooks;
            foreach (Webhook webhook in webhooks)
            {
                if (webhook.WebhookOid == webhookOid)
                {
                    webhookToUpdate = webhook;
                    break;
                }
            }

            webhookToUpdate.BasicPassword = "new password here";
            WebhookResponse apiResponse = webhookApi.UpdateWebhook(webhookOid, webhookToUpdate);
            Webhook updatedWebhook = apiResponse.Webhook;

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                Environment.Exit(1);
            }

 
            Console.WriteLine(updatedWebhook.ToString());
 
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookOid** | **int**| The webhook oid to update. | 
 **webhook** | [**Webhook**](Webhook.md)| Webhook to update | 
 **placeholders** | **bool?**| Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. | [optional] 

### Return type

[**WebhookResponse**](WebhookResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

