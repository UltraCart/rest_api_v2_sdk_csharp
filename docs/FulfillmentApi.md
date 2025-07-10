# com.ultracart.admin.v2.Api.FulfillmentApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AcknowledgeOrders**](FulfillmentApi.md#acknowledgeorders) | **PUT** /fulfillment/distribution_centers/{distribution_center_code}/acknowledgements | Acknowledge receipt of orders.
[**GeneratePackingSlip**](FulfillmentApi.md#generatepackingslip) | **GET** /fulfillment/distribution_centers/{distribution_center_code}/orders/{order_id} | Generate a packing slip for this order for the given distribution center.
[**GetDistributionCenterOrders**](FulfillmentApi.md#getdistributioncenterorders) | **GET** /fulfillment/distribution_centers/{distribution_center_code}/orders | Retrieve orders queued up for this distribution center.
[**GetDistributionCenters**](FulfillmentApi.md#getdistributioncenters) | **GET** /fulfillment/distribution_centers | Retrieve distribution centers
[**ShipOrders**](FulfillmentApi.md#shiporders) | **POST** /fulfillment/distribution_centers/{distribution_center_code}/shipments | Mark orders as shipped
[**UpdateInventory**](FulfillmentApi.md#updateinventory) | **POST** /fulfillment/distribution_centers/{distribution_center_code}/inventory | Update inventory



## AcknowledgeOrders

> void AcknowledgeOrders (string distributionCenterCode, List<string> orderIds)

Acknowledge receipt of orders.

Acknowledge receipt of orders so that they are removed from the fulfillment queue.  This method must be called after receiving and order (via webhook) or retrieving (via retrieve orders method). 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using com.ultracart.admin.v2.Client;

namespace SdkSample.fulfillment
{
    public class AcknowledgeOrders
    {
        /// <summary>
        /// acknowledgeOrders informs UltraCart that you (the fulfillment center) have received an order and have queued it for
        /// shipping.  This method is NOT used to notify an order has shipped, only that it is going to be shipped at some
        /// point in the future.
        /// 
        /// This method should be called by a fulfillment center after receiving an order either by 1) getDistributionCenterOrders
        /// or 2) webhook.  Webhooks are the most efficient means for receiving orders, but if your fulfillment center lacks
        /// the ability to consume webhooks, polling by getDistributionCenterOrders is an alternate means.
        /// 
        /// This method is important for notifying UltraCart that a fulfillment center has the action on an order.  Until this
        /// call is made, UltraCart will continue to notify a fulfillment center of an order either by 1) subsequent webhooks or
        /// 2) continue to include an order in subsequent getDistributionCenterOrders.
        /// 
        /// You will need the distribution center (DC) code.  UltraCart allows for multiple DC and the code is a
        /// unique short string you assign to a DC as an easy mnemonic.
        /// 
        /// For more information about UltraCart distribution centers, please see:
        /// https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1377114/Distribution+Center
        /// 
        /// If you do not know your DC code, query a list of all DC and print them out.
        /// $result = $fulfillment_api->getDistributionCenters();
        /// print_r($result);
        /// 
        /// A successful call will receive back a status code 204 (No Content).
        /// 
        /// Possible Errors:
        /// More than 100 order ids provided -> "order_ids can not contain more than 100 records at a time"
        /// </summary>
        public static void Execute()
        {
            string distributionCenterCode = "RAMI";
            FulfillmentApi fulfillmentApi = new FulfillmentApi(Constants.ApiKey);

            List<string> ordersIds = new List<string> { "DEMO-12345", "DEMO-12346", "DEMO-12347", "DEMO-12348", "DEMO-12349" };

            try
            {
                // limit is 100 acknowledgements at a time.
                fulfillmentApi.AcknowledgeOrders(distributionCenterCode, ordersIds);
                Console.WriteLine("done");
            }
            catch (ApiException e)
            {
                // update inventory failed. examine the reason.
                Console.WriteLine("Exception when calling FulfillmentApi->AcknowledgeOrders: " + e.Message);
                Environment.Exit(1);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **distributionCenterCode** | **string**| Distribution center code | 
 **orderIds** | [**List&lt;string&gt;**](string.md)| Orders to acknowledge receipt of (limit 100) | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
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


## GeneratePackingSlip

> OrderPackingSlipResponse GeneratePackingSlip (string distributionCenterCode, string orderId)

Generate a packing slip for this order for the given distribution center.

The packing slip PDF that is returned is base 64 encoded 


### Example

```csharp
using System;
using System.IO;
using System.Text;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace SdkSample.fulfillment
{
    public class GeneratePackingSlip
    {
        /// <summary>
        /// generatePackingSlip accepts a distribution center code and order_id and returns back a base64 encoded byte array pdf.
        /// Both the dc code and order_id are needed because an order may have multiple items shipping via different DCs.
        /// 
        /// You will need the distribution center (DC) code. UltraCart allows for multiple DC and the code is a
        /// unique short string you assign to a DC as an easy mnemonic.
        /// 
        /// For more information about UltraCart distribution centers, please see:
        /// https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1377114/Distribution+Center
        /// 
        /// If you do not know your DC code, query a list of all DC and print them out.
        /// $result = $fulfillment_api->getDistributionCenters();
        /// print_r($result);
        /// </summary>
        public static void Execute()
        {
            FulfillmentApi fulfillmentApi = Samples.GetFulfillmentApi();

            string distributionCenterCode = "RAMI";
            string orderId = "DEMO-12345";

            try
            {
                // limit is 500 inventory updates at a time. batch them if you're going large.
                OrderPackingSlipResponse apiResponse = fulfillmentApi.GeneratePackingSlip(distributionCenterCode, orderId);
                string base64Pdf = apiResponse.PdfBase64;
                byte[] decodedPdf = Convert.FromBase64String(base64Pdf);
                File.WriteAllBytes("packing_slip.pdf", decodedPdf);

                Console.WriteLine("done");
            }
            catch (ApiException e)
            {
                // update inventory failed. examine the reason.
                Console.WriteLine("Exception when calling FulfillmentApi->GeneratePackingSlip: " + e.Message);
                Environment.Exit(1);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **distributionCenterCode** | **string**| Distribution center code | 
 **orderId** | **string**| Order ID | 

### Return type

[**OrderPackingSlipResponse**](OrderPackingSlipResponse.md)

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


## GetDistributionCenterOrders

> OrdersResponse GetDistributionCenterOrders (string distributionCenterCode)

Retrieve orders queued up for this distribution center.

Retrieves up to 100 orders that are queued up in this distribution center.  You must acknowledge them before additional new orders will be returned.  There is NO record chunking.  You'll get the same 100 records again and again until you acknowledge orders.  The orders that are returned contain only items for this distribution center and are by default completely expanded with billing, channel_partner, checkout, coupons, customer_profile, edi, gift, gift_certificate, internal, items, payment, shipping, summary, taxes. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.fulfillment
{
    public class GetDistributionCenterOrders
    {
        /*
            getDistributionCenterOrders accepts a distribution center code and returns back up to 100 orders that need shipping.
            There is NO pagination with this method call. Once you receive the orders, you should insert them into your
            system, and acknowledge them via the acknowledgeOrders call. After you acknowledge the orders, subsequent calls
            to getDistributionCenterOrders will return another batch of 100 orders.

            The orders that are returned contain only items for THIS distribution center and are by default completely expanded
            with billing, channel_partner, checkout, coupons, customer_profile, edi, gift, gift_certificate, internal,
            items, payment, shipping, summary, taxes

            You will need the distribution center (DC) code. UltraCart allows for multiple DC and the code is a
            unique short string you assign to a DC as an easy mnemonic.

            For more information about UltraCart distribution centers, please see:
            https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1377114/Distribution+Center

            If you do not know your DC code, query a list of all DC and print them out.
            DistributionCentersResponse result = fulfillmentApi.GetDistributionCenters();
            Console.WriteLine(result);
        */

        public static void Execute()
        {
            FulfillmentApi fulfillmentApi = Samples.GetFulfillmentApi();

            try
            {
                List<string> acknowledgedOrders = new List<string>();
                string distributionCenterCode = "RAMI";
                OrdersResponse result = fulfillmentApi.GetDistributionCenterOrders(distributionCenterCode);
                List<Order> orders = result.Orders;
                foreach (Order order in orders)
                {
                    Console.WriteLine(order);
                    // TODO: do something useful with this order, like adding it to your shipping queue.
                    acknowledgedOrders.Add(order.OrderId);
                }

                // TODO: once you've securely and completely received it into your system, acknowledge the order.
                fulfillmentApi.AcknowledgeOrders(distributionCenterCode, acknowledgedOrders);

                // After acknowledging orders, you should call getDistributionCenterOrders again until you receive zero orders to ship.

                Console.WriteLine("done");
            }
            catch (Exception e)
            {
                // update inventory failed. examine the reason.
                Console.WriteLine("Exception when calling FulfillmentApi.GetDistributionCenterOrders: " + e.Message);
                Environment.Exit(1);
            }
        }


    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **distributionCenterCode** | **string**| Distribution center code | 

### Return type

[**OrdersResponse**](OrdersResponse.md)

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


## GetDistributionCenters

> DistributionCentersResponse GetDistributionCenters ()

Retrieve distribution centers

Retrieves the distribution centers that this user has access to. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.fulfillment
{
    public class GetDistributionCenters
    {
        /*
            This method returns back a list of all distribution centers configured for a merchant.

            You will need the distribution center (DC) code for most operations.
            UltraCart allows for multiple DC and the code is a unique short string you assign to a DC as an easy mnemonic.
            This method call is an easy way to determine what a DC code is for a particular distribution center.

            For more information about UltraCart distribution centers, please see:
            https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1377114/Distribution+Center
        */

        public static void Execute()
        {
            FulfillmentApi fulfillmentApi = Samples.GetFulfillmentApi();

            try
            {
                DistributionCentersResponse result = fulfillmentApi.GetDistributionCenters();
                foreach(DistributionCenter dc in result.DistributionCenters)
                Console.WriteLine(dc.ToString());

                Console.WriteLine("done");
            }
            catch (Exception e)
            {
                // update inventory failed.  examine the reason.
                Console.WriteLine("Exception when calling FulfillmentApi.GetDistributionCenters: " + e.Message);
                Environment.Exit(1);
            }
        }
    }
}
```


### Parameters

This endpoint does not need any parameter.

### Return type

[**DistributionCentersResponse**](DistributionCentersResponse.md)

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


## ShipOrders

> void ShipOrders (string distributionCenterCode, List<FulfillmentShipment> shipments)

Mark orders as shipped

Store the tracking information and mark the order shipped for this distribution center. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.fulfillment
{
    public class ShipOrders
    {
        /*
            shipOrders informs UltraCart that you (the fulfillment center) have shipped an order and allows you to provide
            UltraCart with tracking information.

            You will need the distribution center (DC) code.  UltraCart allows for multiple DC and the code is a
            unique short string you assign to a DC as an easy mnemonic.

            For more information about UltraCart distribution centers, please see:
            https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1377114/Distribution+Center

            If you do not know your DC code, query a list of all DC and print them out.
            DistributionCentersResponse result = fulfillmentApi.GetDistributionCenters();
            Console.WriteLine(result);

            A successful call will receive back a status code 204 (No Content).

            Possible Errors:
            More than 100 order ids provided -> "shipments can not contain more than 100 records at a time"
        */

        public static void Execute()
        {
            string distributionCenterCode = "RAMI";
            FulfillmentApi fulfillmentApi = Samples.GetFulfillmentApi();

            FulfillmentShipment shipment = new FulfillmentShipment();
            shipment.OrderId = "DEMO-12345";
            shipment.TrackingNumbers = new List<string> { "UPS-1234567890", "USPS-BLAH-BLAH-BLAH" }; // this order had two boxes.
            shipment.ShippingCost = 16.99m; // the actual cost to ship this order
            shipment.FulfillmentFee = 8.99m; // this fulfillment center is kinda pricey.
            shipment.PackageCost = 11.99m; // 11.99?  we use only the finest packaging.

            List<FulfillmentShipment> shipments = new List<FulfillmentShipment> { shipment }; // up to 100 shipments per call

            try
            {
                // limit is 100 shipments updates at a time.
                fulfillmentApi.ShipOrders(distributionCenterCode, shipments);
                Console.WriteLine("done");
            }
            catch (Exception e)
            {
                // update inventory failed.  examine the reason.
                Console.WriteLine("Exception when calling FulfillmentApi.ShipOrders: " + e.Message);
                Environment.Exit(1);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **distributionCenterCode** | **string**| Distribution center code | 
 **shipments** | [**List&lt;FulfillmentShipment&gt;**](FulfillmentShipment.md)| Orders to mark shipped | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
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


## UpdateInventory

> void UpdateInventory (string distributionCenterCode, List<FulfillmentInventory> inventories)

Update inventory

Update the inventory for items associated with this distribution center 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.fulfillment
{
    public class UpdateInventory
    {
        /*
            updateInventory is a simple means of updating UltraCart inventory for one or more items (500 max per call)
            You will need the distribution center (DC) code.  UltraCart allows for multiple DC and the code is a
            unique short string you assign to a DC as an easy mnemonic.

            For more information about UltraCart distribution centers, please see:
            https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1377114/Distribution+Center

            If you do not know your DC code, query a list of all DC and print them out.
            DistributionCentersResponse result = fulfillmentApi.GetDistributionCenters();
            Console.WriteLine(result);

            Possible Errors:
            More than 500 items provided -> "inventories can not contain more than 500 records at a time"
        */

        public static void Execute()
        {
            string distributionCenterCode = "RAMI";
            FulfillmentApi fulfillmentApi = Samples.GetFulfillmentApi();

            string sku = "9780982021361";
            int quantity = 9;
            FulfillmentInventory firstInventory = new FulfillmentInventory();
            firstInventory.ItemId = sku;
            firstInventory.Quantity = quantity;
            List<FulfillmentInventory> inventoryUpdates = new List<FulfillmentInventory> { firstInventory }; // for this example, we're only updating one item.

            Console.WriteLine(inventoryUpdates);

            try
            {
                // limit is 500 inventory updates at a time.  batch them if you're going large.
                fulfillmentApi.UpdateInventory(distributionCenterCode, inventoryUpdates);
                Console.WriteLine("done");
            }
            catch (Exception e)
            {
                // update inventory failed.  examine the reason.
                Console.WriteLine("Exception when calling FulfillmentApi.UpdateInventory: " + e.Message);
                Environment.Exit(1);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **distributionCenterCode** | **string**| Distribution center code | 
 **inventories** | [**List&lt;FulfillmentInventory&gt;**](FulfillmentInventory.md)| Inventory updates (limit 500) | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
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

