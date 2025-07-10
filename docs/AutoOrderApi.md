# com.ultracart.admin.v2.Api.AutoOrderApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConsolidateAutoOrders**](AutoOrderApi.md#consolidateautoorders) | **PUT** /auto_order/auto_orders/{auto_order_oid}/consolidate | Consolidates multiple auto orders
[**EstablishAutoOrderByReferenceOrderId**](AutoOrderApi.md#establishautoorderbyreferenceorderid) | **POST** /auto_order/auto_orders/reference_order_id/{reference_order_id} | Establish an auto order by referencing a regular order id
[**GetAutoOrder**](AutoOrderApi.md#getautoorder) | **GET** /auto_order/auto_orders/{auto_order_oid} | Retrieve an auto order by oid
[**GetAutoOrderByCode**](AutoOrderApi.md#getautoorderbycode) | **GET** /auto_order/auto_orders/code/{auto_order_code} | Retrieve an auto order by code
[**GetAutoOrderByReferenceOrderId**](AutoOrderApi.md#getautoorderbyreferenceorderid) | **GET** /auto_order/auto_orders/reference_order_id/{reference_order_id} | Retrieve an auto order by order id
[**GetAutoOrders**](AutoOrderApi.md#getautoorders) | **GET** /auto_order/auto_orders | Retrieve auto orders
[**GetAutoOrdersBatch**](AutoOrderApi.md#getautoordersbatch) | **POST** /auto_order/auto_orders/batch | Retrieve auto order batch
[**GetAutoOrdersByQuery**](AutoOrderApi.md#getautoordersbyquery) | **POST** /auto_order/auto_orders/query | Retrieve auto orders by query
[**PauseAutoOrder**](AutoOrderApi.md#pauseautoorder) | **PUT** /auto_order/auto_orders/{auto_order_oid}/pause | Pause auto order
[**UpdateAutoOrder**](AutoOrderApi.md#updateautoorder) | **PUT** /auto_order/auto_orders/{auto_order_oid} | Update an auto order
[**UpdateAutoOrdersBatch**](AutoOrderApi.md#updateautoordersbatch) | **PUT** /auto_order/auto_orders/batch | Update multiple auto orders



## ConsolidateAutoOrders

> AutoOrderResponse ConsolidateAutoOrders (int autoOrderOid, AutoOrderConsolidate autoOrderConsolidate, string expand = null)

Consolidates multiple auto orders

Consolidates mutliple auto orders on the UltraCart account. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.auto_order
{
    public class ConsolidateAutoOrders
    {
        /*
         *
         * consolidateAutoOrders
         * an auto order with no items, the original_order is used for shipping, billing, and payment information.
         * Once you have your empty auto order, add items to it and call updateAutoOrder.
         *
         */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create auto order API instance using API key
                AutoOrderApi autoOrderApi = new AutoOrderApi(Constants.ApiKey);
                
                string expand = "items,items.future_schedules,original_order,rebill_orders"; // see https://www.ultracart.com/api/#resource_auto_order.html for list
                
                int targetAutoOrderOid = 123456789; // set getAutoOrdersByQuery for retrieving auto orders where you can get their auto_order_oid.
                AutoOrderConsolidate consolidateRequest = new AutoOrderConsolidate();
                consolidateRequest.SourceAutoOrderOids = new List<int> { 23456789, 3456789 }; // these are the autoorder_oids you wish to consolidate into the target.
                
                var apiResponse = autoOrderApi.ConsolidateAutoOrders(targetAutoOrderOid, consolidateRequest, expand);
                
                var consolidatedAutoOrder = apiResponse.AutoOrder;
                
                // TODO: make sure the consolidated order has all the items and history of all orders.
                Console.WriteLine(consolidatedAutoOrder);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoOrderOid** | **int**| The auto order oid to consolidate into. | 
 **autoOrderConsolidate** | [**AutoOrderConsolidate**](AutoOrderConsolidate.md)| Auto orders to consolidate | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**AutoOrderResponse**](AutoOrderResponse.md)

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


## EstablishAutoOrderByReferenceOrderId

> AutoOrderResponse EstablishAutoOrderByReferenceOrderId (string referenceOrderId, string expand = null)

Establish an auto order by referencing a regular order id

Establish an auto order by referencing a regular order id.  The result will be an auto order without any items.  You should add the items and perform an update call.  Orders must be less than 60 days old and use a credit card payment. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.auto_order
{
    public class EstablishAutoOrderByReferenceOrderId
    {
        /*
         *
         * This method takes a normal order id and creates an empty auto order from it.  While this might seem useless having
         * an auto order with no items, the original_order is used for shipping, billing, and payment information.
         * Once you have your empty auto order, add items to it and call updateAutoOrder.
         *
         */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create auto order API instance using API key
                AutoOrderApi autoOrderApi = new AutoOrderApi(Constants.ApiKey);
                
                string expand = "items,items.future_schedules,original_order,rebill_orders"; // see https://www.ultracart.com/api/#resource_auto_order.html for list
                
                string originalOrderId = "DEMO-123457";
                var apiResponse = autoOrderApi.EstablishAutoOrderByReferenceOrderId(originalOrderId, expand);
                
                AutoOrder emptyAutoOrder = apiResponse.AutoOrder;
                int autoOrderOid = emptyAutoOrder.AutoOrderOid;
                
                List<AutoOrderItem> items = new List<AutoOrderItem>();
                AutoOrderItem item = new AutoOrderItem();
                item.OriginalItemId = "ITEM_ABC"; // This item should be configured with auto order features.
                item.OriginalQuantity = 1;
                item.ArbitraryUnitCost = 59.99m;
                // Valid Frequencies
                // "Weekly", "Biweekly", "Every...", "Every 10 Days", "Every 4 Weeks", "Every 6 Weeks", "Every 8 Weeks", "Every 24 Days", "Every 28 Days", "Monthly",
                // "Every 45 Days", "Every 2 Months", "Every 3 Months", "Every 4 Months", "Every 5 Months", "Every 6 Months", "Yearly"
                item.Frequency = AutoOrderItem.FrequencyEnum.Monthly;
                items.Add(item);
                emptyAutoOrder.Items = items;
                
                string validateOriginalOrder = "No";
                var updateResponse = autoOrderApi.UpdateAutoOrder(autoOrderOid, emptyAutoOrder, validateOriginalOrder, expand);
                AutoOrder updatedAutoOrder = updateResponse.AutoOrder;
                Console.WriteLine(updatedAutoOrder);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **referenceOrderId** | **string**| The order id to attach this auto order to | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**AutoOrderResponse**](AutoOrderResponse.md)

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


## GetAutoOrder

> AutoOrderResponse GetAutoOrder (int autoOrderOid, string expand = null)

Retrieve an auto order by oid

Retrieves a single auto order using the specified auto order oid. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.auto_order
{
    public class GetAutoOrder
    {
        /*
         * retrieves an auto_order given the auto_order_oid;
         */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create auto order API instance using API key
                AutoOrderApi autoOrderApi = new AutoOrderApi(Constants.ApiKey);
                
                string expand = "items,items.future_schedules,original_order,rebill_orders"; // see https://www.ultracart.com/api/#resource_auto_order.html for list
                int autoOrderOid = 123456789; // If you don't know the oid, use getAutoOrdersByQuery for retrieving auto orders
                
                var apiResponse = autoOrderApi.GetAutoOrder(autoOrderOid, expand);
                AutoOrder autoOrder = apiResponse.AutoOrder;
                
                Console.WriteLine(autoOrder);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoOrderOid** | **int**| The auto order oid to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**AutoOrderResponse**](AutoOrderResponse.md)

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


## GetAutoOrderByCode

> AutoOrderResponse GetAutoOrderByCode (string autoOrderCode, string expand = null)

Retrieve an auto order by code

Retrieves a single auto order using the specified reference (original) order id. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.auto_order
{
    public class GetAutoOrderByCode
    {
        /*
         * This example illustrates how to query an auto order when you know the 'code'.  Each AutoOrder has a unique
         * identifier used by UltraCart called an OID (Object Identifier).  AutoOrders also have a unique code which
         * is (arguably) an easy way for customers to discuss a specific auto order with a merchant.
         * The codes look like this: "RT2A9CBSX9"
         *
         * It is doubtful that an UltraCart merchant will ever make use of this method.
         *
         * These are the possible expansion values for auto orders.  This list is taken from www.ultracart.com/api/
         * and may become stale. Please review the master website when in doubt.
         * items
         * items.future_schedules
         * items.sample_schedule
         * original_order
         * original_order.affiliate
         * original_order.affiliate.ledger
         * original_order.auto_order
         * original_order.billing
         * original_order.buysafe
         * original_order.channel_partner
         * original_order.checkout
         * original_order.coupon
         * original_order.customer_profile
         * original_order.digital_order
         * original_order.edi
         * original_order.fraud_score
         * original_order.gift
         * original_order.gift_certificate
         * original_order.internal
         * original_order.item
         * original_order.linked_shipment
         * original_order.marketing
         * original_order.payment
         * original_order.payment.transaction
         * original_order.quote
         * original_order.salesforce
         * original_order.shipping
         * original_order.summary
         * original_order.taxes
         * rebill_orders
         * rebill_orders.affiliate
         * rebill_orders.affiliate.ledger
         * rebill_orders.auto_order
         * rebill_orders.billing
         * rebill_orders.buysafe
         * rebill_orders.channel_partner
         * rebill_orders.checkout
         * rebill_orders.coupon
         * rebill_orders.customer_profile
         * rebill_orders.digital_order
         * rebill_orders.edi
         * rebill_orders.fraud_score
         * rebill_orders.gift
         * rebill_orders.gift_certificate
         * rebill_orders.internal
         * rebill_orders.item
         * rebill_orders.linked_shipment
         * rebill_orders.marketing
         * rebill_orders.payment
         * rebill_orders.payment.transaction
         * rebill_orders.quote
         * rebill_orders.salesforce
         * rebill_orders.shipping
         * rebill_orders.summary
         * rebill_orders.taxes
         */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create auto order API instance using API key
                AutoOrderApi autoOrderApi = new AutoOrderApi(Constants.ApiKey);
                
                string expand = "items,items.future_schedules,original_order,rebill_orders"; // contact us if you're unsure what you need
                string code = "RT2A9CBSX9";
                var apiResponse = autoOrderApi.GetAutoOrderByCode(code, expand);
                AutoOrder autoOrder = apiResponse.AutoOrder;
                
                // this will be verbose...
                Console.WriteLine(autoOrder);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoOrderCode** | **string**| The auto order oid to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**AutoOrderResponse**](AutoOrderResponse.md)

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


## GetAutoOrderByReferenceOrderId

> AutoOrderResponse GetAutoOrderByReferenceOrderId (string referenceOrderId, string expand = null)

Retrieve an auto order by order id

Retrieves a single auto order using the specified reference (original) order id. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.auto_order
{
    public class GetAutoOrderByReferenceOrderId
    {
        /*
         * This example illustrates how to query an auto order when you know the original order id.
         * These are the possible expansion values for auto orders.  This list is taken from www.ultracart.com/api/
         * and may become stale. Please review the master website when in doubt.
         * items
         * items.future_schedules
         * items.sample_schedule
         * original_order
         * original_order.affiliate
         * original_order.affiliate.ledger
         * original_order.auto_order
         * original_order.billing
         * original_order.buysafe
         * original_order.channel_partner
         * original_order.checkout
         * original_order.coupon
         * original_order.customer_profile
         * original_order.digital_order
         * original_order.edi
         * original_order.fraud_score
         * original_order.gift
         * original_order.gift_certificate
         * original_order.internal
         * original_order.item
         * original_order.linked_shipment
         * original_order.marketing
         * original_order.payment
         * original_order.payment.transaction
         * original_order.quote
         * original_order.salesforce
         * original_order.shipping
         * original_order.summary
         * original_order.taxes
         * rebill_orders
         * rebill_orders.affiliate
         * rebill_orders.affiliate.ledger
         * rebill_orders.auto_order
         * rebill_orders.billing
         * rebill_orders.buysafe
         * rebill_orders.channel_partner
         * rebill_orders.checkout
         * rebill_orders.coupon
         * rebill_orders.customer_profile
         * rebill_orders.digital_order
         * rebill_orders.edi
         * rebill_orders.fraud_score
         * rebill_orders.gift
         * rebill_orders.gift_certificate
         * rebill_orders.internal
         * rebill_orders.item
         * rebill_orders.linked_shipment
         * rebill_orders.marketing
         * rebill_orders.payment
         * rebill_orders.payment.transaction
         * rebill_orders.quote
         * rebill_orders.salesforce
         * rebill_orders.shipping
         * rebill_orders.summary
         * rebill_orders.taxes
         */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");

            try
            {
                // Create auto order API instance using API key
                AutoOrderApi autoOrderApi = new AutoOrderApi(Constants.ApiKey);

                string expand =
                    "items,items.future_schedules,original_order,rebill_orders"; // contact us if you're unsure what you need
                string originalOrderId = "DEMO-12345678";
                var apiResponse = autoOrderApi.GetAutoOrderByReferenceOrderId(originalOrderId, expand);
                AutoOrder autoOrder = apiResponse.AutoOrder;

                // this will be verbose...
                Console.WriteLine(autoOrder);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **referenceOrderId** | **string**| The auto order oid to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**AutoOrderResponse**](AutoOrderResponse.md)

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


## GetAutoOrders

> AutoOrdersResponse GetAutoOrders (string autoOrderCode = null, string originalOrderId = null, string firstName = null, string lastName = null, string company = null, string city = null, string state = null, string postalCode = null, string countryCode = null, string phone = null, string email = null, string originalOrderDateBegin = null, string originalOrderDateEnd = null, string nextShipmentDateBegin = null, string nextShipmentDateEnd = null, string cardType = null, string itemId = null, string status = null, int? limit = null, int? offset = null, string since = null, string sort = null, string expand = null)

Retrieve auto orders

Retrieves auto orders from the account.  If no parameters are specified, all auto orders will be returned.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.auto_order
{
    public class GetAutoOrders
    {
        /*
        getAutoOrders provides a query service on AutoOrders (aka subscriptions or recurring orders) within the UltraCart
        system. It was the first query provided and the most cumbersome to use.  Please use getAutoOrdersByQuery for an
        easier query method.  If you have multiple auto_order_oids and need the corresponding objects, consider
        getAutoOrdersBatch() to reduce call count.
        */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                List<AutoOrder> autoOrders = new List<AutoOrder>();
                
                int iteration = 1;
                int offset = 0;
                int limit = 200;
                bool moreRecordsToFetch = true;
                
                // Create auto order API instance using API key
                AutoOrderApi autoOrderApi = new AutoOrderApi(Constants.ApiKey);
                
                while (moreRecordsToFetch)
                {
                    Console.WriteLine($"executing iteration {iteration}");
                    List<AutoOrder> chunkOfAutoOrders = GetAutoOrderChunk(autoOrderApi, offset, limit);
                    autoOrders.AddRange(chunkOfAutoOrders);
                    offset = offset + limit;
                    moreRecordsToFetch = chunkOfAutoOrders.Count == limit;
                    iteration++;
                }
                
                // Display the auto orders
                foreach (var autoOrder in autoOrders)
                {
                    Console.WriteLine(autoOrder);
                }
                
                Console.WriteLine($"Total auto orders retrieved: {autoOrders.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
        
        /// <summary>
        /// Returns a chunk of auto orders based on query parameters
        /// </summary>
        /// <param name="autoOrderApi">The auto order API instance</param>
        /// <param name="offset">Pagination offset</param>
        /// <param name="limit">Maximum number of records to return</param>
        /// <returns>List of matching auto orders</returns>
        public static List<AutoOrder> GetAutoOrderChunk(AutoOrderApi autoOrderApi, int offset, int limit)
        {
            string expand = "items,original_order,rebill_orders";
            // see www.ultracart.com/api/ for all the expansion fields available (this list below may become stale)
            /*
            Possible Order Expansions:

            add_ons                             items.sample_schedule	        original_order.buysafe	        original_order.payment.transaction
            items	                            original_order	                original_order.channel_partner	original_order.quote
            items.future_schedules	            original_order.affiliate	    original_order.checkout	        original_order.salesforce
            original_order.affiliate.ledger	    original_order.coupon	        original_order.shipping
            original_order.auto_order	        original_order.customer_profile	original_order.summary
            original_order.billing	            original_order.digital_order	original_order.taxes
            rebill_orders	                    original_order.edi	            rebill_orders.affiliate
            rebill_orders.affiliate.ledger	    original_order.fraud_score	    rebill_orders.auto_order
            rebill_orders.billing	            original_order.gift	            rebill_orders.buysafe
            rebill_orders.channel_partner	    original_order.gift_certificate	rebill_orders.checkout
            rebill_orders.coupon	            original_order.internal	        rebill_orders.customer_profile
            rebill_orders.digital_order	        original_order.item	            rebill_orders.edi
            rebill_orders.fraud_score	        original_order.linked_shipment	rebill_orders.gift
            rebill_orders.gift_certificate      original_order.marketing	    rebill_orders.internal
            rebill_orders.item	                original_order.payment	        rebill_orders.linked_shipment
            rebill_orders.marketing	            rebill_orders.payment	        rebill_orders.quote
            rebill_orders.payment.transaction	rebill_orders.salesforce	    rebill_orders.shipping
            rebill_orders.summary	            rebill_orders.taxes
            */
            
            string autoOrderCode = null;
            string originalOrderId = null;
            string firstName = null;
            string lastName = null;
            string company = null;
            string city = null;
            string state = null;
            string postalCode = null;
            string countryCode = null;
            string phone = null;
            string email = "test@ultracart.com"; // <-- for this example, we are only filtering on email address.
            string originalOrderDateBegin = null;
            string originalOrderDateEnd = null;
            string nextShipmentDateBegin = null;
            string nextShipmentDateEnd = null;
            string cardType = null;
            string itemId = null;
            string status = null;
            string since = null;
            string sort = null;
            
            // see all these parameters?  that is why you should use getAutoOrdersByQuery() instead of getAutoOrders()
            var apiResponse = autoOrderApi.GetAutoOrders(autoOrderCode, originalOrderId, firstName, lastName,
                company, city, state, postalCode, countryCode, phone, email, originalOrderDateBegin,
                originalOrderDateEnd, nextShipmentDateBegin, nextShipmentDateEnd, cardType, itemId, status,
                limit, offset, since, sort, expand);
                
            if (apiResponse.AutoOrders != null)
            {
                return apiResponse.AutoOrders;
            }
            return new List<AutoOrder>();
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoOrderCode** | **string**| Auto order code | [optional] 
 **originalOrderId** | **string**| Original order id | [optional] 
 **firstName** | **string**| First name | [optional] 
 **lastName** | **string**| Last name | [optional] 
 **company** | **string**| Company | [optional] 
 **city** | **string**| City | [optional] 
 **state** | **string**| State | [optional] 
 **postalCode** | **string**| Postal code | [optional] 
 **countryCode** | **string**| Country code (ISO-3166 two letter) | [optional] 
 **phone** | **string**| Phone | [optional] 
 **email** | **string**| Email | [optional] 
 **originalOrderDateBegin** | **string**| Original order date begin | [optional] 
 **originalOrderDateEnd** | **string**| Original order date end | [optional] 
 **nextShipmentDateBegin** | **string**| Next shipment date begin | [optional] 
 **nextShipmentDateEnd** | **string**| Next shipment date end | [optional] 
 **cardType** | **string**| Card type | [optional] 
 **itemId** | **string**| Item ID | [optional] 
 **status** | **string**| Status | [optional] 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Max 200) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **since** | **string**| Fetch auto orders that have been created/modified since this date/time. | [optional] 
 **sort** | **string**| The sort order of the auto orders.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**AutoOrdersResponse**](AutoOrdersResponse.md)

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


## GetAutoOrdersBatch

> AutoOrdersResponse GetAutoOrdersBatch (AutoOrderQueryBatch autoOrderBatch, string expand = null)

Retrieve auto order batch

Retrieves a group of auto orders from the account based on an array of auto order oids.  If more than 200 auto order ids are specified, the API call will fail with a bad request error. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.auto_order
{
    public class GetAutoOrdersBatch
    {
        /*
         * This example illustrates how to retrieve auto orders when you have a list of auto_order_oid.
         * These are the possible expansion values for auto orders.  This list is taken from www.ultracart.com/api/
         * and may become stale. Please review the master website when in doubt.
         * items
         * items.future_schedules
         * items.sample_schedule
         * original_order
         * original_order.affiliate
         * original_order.affiliate.ledger
         * original_order.auto_order
         * original_order.billing
         * original_order.buysafe
         * original_order.channel_partner
         * original_order.checkout
         * original_order.coupon
         * original_order.customer_profile
         * original_order.digital_order
         * original_order.edi
         * original_order.fraud_score
         * original_order.gift
         * original_order.gift_certificate
         * original_order.internal
         * original_order.item
         * original_order.linked_shipment
         * original_order.marketing
         * original_order.payment
         * original_order.payment.transaction
         * original_order.quote
         * original_order.salesforce
         * original_order.shipping
         * original_order.summary
         * original_order.taxes
         * rebill_orders
         * rebill_orders.affiliate
         * rebill_orders.affiliate.ledger
         * rebill_orders.auto_order
         * rebill_orders.billing
         * rebill_orders.buysafe
         * rebill_orders.channel_partner
         * rebill_orders.checkout
         * rebill_orders.coupon
         * rebill_orders.customer_profile
         * rebill_orders.digital_order
         * rebill_orders.edi
         * rebill_orders.fraud_score
         * rebill_orders.gift
         * rebill_orders.gift_certificate
         * rebill_orders.internal
         * rebill_orders.item
         * rebill_orders.linked_shipment
         * rebill_orders.marketing
         * rebill_orders.payment
         * rebill_orders.payment.transaction
         * rebill_orders.quote
         * rebill_orders.salesforce
         * rebill_orders.shipping
         * rebill_orders.summary
         * rebill_orders.taxes*
         */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");

            try
            {
                // Create auto order API instance using API key
                AutoOrderApi autoOrderApi = new AutoOrderApi(Constants.ApiKey);

                string expand =
                    "items,items.future_schedules,original_order,rebill_orders"; // contact us if you're unsure what you need
                List<int> autoOrderOids = new List<int> { 123456, 234567, 345678, 456789 };

                AutoOrderQueryBatch batchRequest = new AutoOrderQueryBatch();
                batchRequest.AutoOrderOids = autoOrderOids;

                var apiResponse = autoOrderApi.GetAutoOrdersBatch(batchRequest, expand);
                List<AutoOrder> autoOrders = apiResponse.AutoOrders;

                // Display auto orders
                foreach (var autoOrder in autoOrders)
                {
                    Console.WriteLine(autoOrder);
                }

                Console.WriteLine($"Retrieved {autoOrders.Count} auto orders");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoOrderBatch** | [**AutoOrderQueryBatch**](AutoOrderQueryBatch.md)| Auto order batch | 
 **expand** | **string**| The object expansion to perform on the result. | [optional] 

### Return type

[**AutoOrdersResponse**](AutoOrdersResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
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


## GetAutoOrdersByQuery

> AutoOrdersResponse GetAutoOrdersByQuery (AutoOrderQuery autoOrderQuery, int? limit = null, int? offset = null, string sort = null, string expand = null)

Retrieve auto orders by query

Retrieves a group of auto orders from the account based on a query object.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.auto_order
{
    public class GetAutoOrdersByQuery
    {
        /*
         * This example illustrates how to retrieve auto orders and handle pagination.
         *
             * These are the possible expansion values for auto orders.  This list is taken from www.ultracart.com/api/
             * and may become stale. Please review the master website when in doubt.
            items
            items.future_schedules
            items.sample_schedule
            original_order
            original_order.affiliate
            original_order.affiliate.ledger
            original_order.auto_order
            original_order.billing
            original_order.buysafe
            original_order.channel_partner
            original_order.checkout
            original_order.coupon
            original_order.customer_profile
            original_order.digital_order
            original_order.edi
            original_order.fraud_score
            original_order.gift
            original_order.gift_certificate
            original_order.internal
            original_order.item
            original_order.linked_shipment
            original_order.marketing
            original_order.payment
            original_order.payment.transaction
            original_order.quote
            original_order.salesforce
            original_order.shipping
            original_order.summary
            original_order.taxes
            rebill_orders
            rebill_orders.affiliate
            rebill_orders.affiliate.ledger
            rebill_orders.auto_order
            rebill_orders.billing
            rebill_orders.buysafe
            rebill_orders.channel_partner
            rebill_orders.checkout
            rebill_orders.coupon
            rebill_orders.customer_profile
            rebill_orders.digital_order
            rebill_orders.edi
            rebill_orders.fraud_score
            rebill_orders.gift
            rebill_orders.gift_certificate
            rebill_orders.internal
            rebill_orders.item
            rebill_orders.linked_shipment
            rebill_orders.marketing
            rebill_orders.payment
            rebill_orders.payment.transaction
            rebill_orders.quote
            rebill_orders.salesforce
            rebill_orders.shipping
            rebill_orders.summary
            rebill_orders.taxes
         */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");

            try
            {
                List<AutoOrder> autoOrders = new List<AutoOrder>();

                int iteration = 1;
                int offset = 0;
                int limit = 200;
                bool moreRecordsToFetch = true;

                // Create auto order API instance using API key
                AutoOrderApi autoOrderApi = new AutoOrderApi(Constants.ApiKey);

                while (moreRecordsToFetch)
                {
                    Console.WriteLine($"executing iteration {iteration}");

                    List<AutoOrder> chunkOfOrders = GetAutoOrderChunk(autoOrderApi, offset, limit);
                    autoOrders.AddRange(chunkOfOrders);
                    offset = offset + limit;
                    moreRecordsToFetch = chunkOfOrders.Count == limit;
                    iteration++;
                }

                // Display auto orders
                foreach (var autoOrder in autoOrders)
                {
                    Console.WriteLine(autoOrder);
                }

                Console.WriteLine($"Retrieved {autoOrders.Count} auto orders");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ApiException occurred on iteration");
                Console.WriteLine(ex);
                Environment.Exit(1);
            }
        }

        /// <summary>
        /// Returns a chunk of auto orders based on query parameters
        /// </summary>
        /// <param name="autoOrderApi">The auto order API instance</param>
        /// <param name="offset">Pagination offset</param>
        /// <param name="limit">Maximum number of records to return</param>
        /// <returns>List of matching auto orders</returns>
        public static List<AutoOrder> GetAutoOrderChunk(AutoOrderApi autoOrderApi, int offset, int limit)
        {
            string expand =
                "items,items.future_schedules,original_order,rebill_orders"; // contact us if you're unsure what you need

            /*
             * These are the supported sorting fields:
            auto_order_code
            order_id
            shipping.company
            shipping.first_name
            shipping.last_name
            shipping.city
            shipping.state_region
            shipping.postal_code
            shipping.country_code
            billing.phone
            billing.email
            billing.cc_email
            billing.company
            billing.first_name
            billing.last_name
            billing.city
            billing.state
            billing.postal_code
            billing.country_code
            creation_dts
            payment.payment_dts
            checkout.screen_branding_theme_code
            next_shipment_dts
             */
            
            string sort = "next_shipment_dts";
            AutoOrderQuery query = new AutoOrderQuery();
            query.Email = "support@ultracart.com";
            var apiResponse = autoOrderApi.GetAutoOrdersByQuery(query, limit, offset, sort, expand);

            if (apiResponse.AutoOrders != null)
            {
                return apiResponse.AutoOrders;
            }

            return new List<AutoOrder>();
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoOrderQuery** | [**AutoOrderQuery**](AutoOrderQuery.md)| Auto order query | 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Maximum 200) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **sort** | **string**| The sort order of the auto orders.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 
 **expand** | **string**| The object expansion to perform on the result. | [optional] 

### Return type

[**AutoOrdersResponse**](AutoOrdersResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
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


## PauseAutoOrder

> AutoOrderResponse PauseAutoOrder (int autoOrderOid, AutoOrder autoOrder, string expand = null)

Pause auto order

Completely pause an auto order 


### Example

```csharp
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.channel_partner
{
    public class PauseAutoOrder
    {
        /*
         * This is a convenience method created for an UltraCart merchant to pause a large number of auto orders
         * due to an inventory shortage. This is not new functionality and can be accomplished with the normal updateAutoOrder
         * call. It does the following logic to an auto order:
         * for each item in the auto order:
         *    if the item is not paused, pause it, setPause(true)
         * save the changes by calling updateAutoOrder()
         *
         * Some warnings if you choose to use this method.
         * There are no convenience methods to unpause auto orders.
         * There are no convenience methods to query which auto orders are paused.
         * We do not recommend pausing auto orders and the merchant is on their own to manage auto order state if they
         * choose to begin pausing orders. Keep good track of what you're doing.
         *
         */
        public static void Execute()
        {
            AutoOrderApi autoOrderApi = new AutoOrderApi(Constants.ApiKey);

            string expand = "items"; // see https://www.ultracart.com/api/#resource_auto_order.html for list
            int autoOrderOid = 123456789; // get an auto order and update it. There are many ways to retrieve an auto order.
            AutoOrderResponse getResponse = autoOrderApi.GetAutoOrder(autoOrderOid);
            AutoOrder autoOrder = getResponse.AutoOrder;

            AutoOrderResponse pauseResponse = autoOrderApi.PauseAutoOrder(autoOrderOid, autoOrder);
            AutoOrder pausedAutoOrder = pauseResponse.AutoOrder;
            System.Console.WriteLine(pausedAutoOrder);
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoOrderOid** | **int**| The auto order oid to pause. | 
 **autoOrder** | [**AutoOrder**](AutoOrder.md)| Auto order to pause | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**AutoOrderResponse**](AutoOrderResponse.md)

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


## UpdateAutoOrder

> AutoOrderResponse UpdateAutoOrder (int autoOrderOid, AutoOrder autoOrder, string validateOriginalOrder = null, string expand = null)

Update an auto order

Update an auto order on the UltraCart account. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.auto_order
{
    public class UpdateAutoOrder
    {
        /*
         *
         * This method allows for updating an auto order.
         * Warning: Take great care editing auto orders.  They are complex.
         * Sometimes you must change the original_order to affect the auto_order.  If you have questions about what fields
         * to update to achieve your desired change, contact UltraCart support.  Better to ask and get it right than to
         * make a bad assumption and corrupt a thousand auto orders.  UltraCart support is ready to assist.
         *
         */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create auto order API instance using API key
                AutoOrderApi autoOrderApi = new AutoOrderApi(Constants.ApiKey);
                
                string expand = "items,items.future_schedules,original_order,rebill_orders"; // see https://www.ultracart.com/api/#resource_auto_order.html for list
                int autoOrderOid = 123456789; // get an auto order and update it. There are many ways to retrieve an auto order.
                var apiResponse = autoOrderApi.GetAutoOrder(autoOrderOid);
                AutoOrder autoOrder = apiResponse.AutoOrder;
                string validateOriginalOrder = "No";
                
                // for this example, the customer supplied the wrong postal code when ordering. So to change the postal code for
                // all subsequent auto orders, we change the original order.
                autoOrder.OriginalOrder.Billing.PostalCode = "44233";
                
                var updateResponse = autoOrderApi.UpdateAutoOrder(autoOrderOid, autoOrder, validateOriginalOrder, expand);
                AutoOrder updatedAutoOrder = updateResponse.AutoOrder;
                Console.WriteLine(updatedAutoOrder);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoOrderOid** | **int**| The auto order oid to update. | 
 **autoOrder** | [**AutoOrder**](AutoOrder.md)| Auto order to update | 
 **validateOriginalOrder** | **string**| Validate original order before updating | [optional] 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**AutoOrderResponse**](AutoOrderResponse.md)

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


## UpdateAutoOrdersBatch

> AutoOrdersResponse UpdateAutoOrdersBatch (AutoOrdersRequest autoOrdersRequest, string expand = null, bool? placeholders = null, bool? async = null)

Update multiple auto orders

Update multiple auto orders on the UltraCart account. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.auto_order
{
    public class UpdateAutoOrdersBatch
    {
        /*
         *
         * This method allows for updating multiple auto orders.
         * Warning: Take great care editing auto orders.  They are complex.
         * Sometimes you must change the original_order to affect the auto_order.  If you have questions about what fields
         * to update to achieve your desired change, contact UltraCart support.  Better to ask and get it right than to
         * make a bad assumption and corrupt a thousand auto orders.  UltraCart support is ready to assist.
         *
         */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create auto order API instance using API key
                AutoOrderApi autoOrderApi = new AutoOrderApi(Constants.ApiKey);
                
                // The _async parameter is what it seems.  True if async.
                // The max records allowed depends on the async flag.  Synch max is 20, Asynch max is 100.
                
                bool async = true; // if true, success returns back a 204 No Content. False returns back the updated orders.
                string expand = null; // since we're async, nothing is returned, so we don't care about expansions.
                // If you are doing a synchronous operation, then set your expand appropriately. set getAutoOrders()
                // sample for expansion samples.
                bool placeholders = false; // mostly used for UI, not needed for a pure scripting operation.
                
                List<AutoOrder> autoOrders = new List<AutoOrder>(); // TODO: This should be a list of auto orders that have been updated. See any getAutoOrders method for retrieval.
                AutoOrdersRequest autoOrdersRequest = new AutoOrdersRequest();
                autoOrdersRequest.AutoOrders = autoOrders;
                
                var apiResponse = autoOrderApi.UpdateAutoOrdersBatch(autoOrdersRequest, expand, placeholders, async);
                if (apiResponse != null)
                {
                    // something went wrong if we have a response.
                    Console.WriteLine(apiResponse);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoOrdersRequest** | [**AutoOrdersRequest**](AutoOrdersRequest.md)| Auto orders to update (synchronous maximum 20 / asynchronous maximum 100) | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 
 **placeholders** | **bool?**| Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. | [optional] 
 **async** | **bool?**| True if the operation should be run async.  No result returned | [optional] 

### Return type

[**AutoOrdersResponse**](AutoOrdersResponse.md)

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

