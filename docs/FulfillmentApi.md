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


<a name="acknowledgeorders"></a>
# **AcknowledgeOrders**
> void AcknowledgeOrders (string distributionCenterCode, List<string> orderIds)

Acknowledge receipt of orders.

Acknowledge receipt of orders so that they are removed from the fulfillment queue.  This method must be called after receiving and order (via webhook) or retrieving (via retrieve orders method). 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class AcknowledgeOrdersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new FulfillmentApi(simpleKey);

            var distributionCenterCode = distributionCenterCode_example;  // string | Distribution center code
            var orderIds = ;  // List<string> | Orders to acknowledge receipt of (limit 100)

            try
            {
                // Acknowledge receipt of orders.
                apiInstance.AcknowledgeOrders(distributionCenterCode, orderIds);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentApi.AcknowledgeOrders: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **distributionCenterCode** | **string**| Distribution center code | 
 **orderIds** | **List&lt;string&gt;**| Orders to acknowledge receipt of (limit 100) | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatepackingslip"></a>
# **GeneratePackingSlip**
> OrderPackingSlipResponse GeneratePackingSlip (string distributionCenterCode, string orderId)

Generate a packing slip for this order for the given distribution center.

The packing slip PDF that is returned is base 64 encoded 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GeneratePackingSlipExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new FulfillmentApi(simpleKey);

            var distributionCenterCode = distributionCenterCode_example;  // string | Distribution center code
            var orderId = orderId_example;  // string | Order ID

            try
            {
                // Generate a packing slip for this order for the given distribution center.
                OrderPackingSlipResponse result = apiInstance.GeneratePackingSlip(distributionCenterCode, orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentApi.GeneratePackingSlip: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistributioncenterorders"></a>
# **GetDistributionCenterOrders**
> OrdersResponse GetDistributionCenterOrders (string distributionCenterCode)

Retrieve orders queued up for this distribution center.

Retrieves up to 100 orders that are queued up in this distribution center.  You must acknowledge them before additional new orders will be returned.  There is NO record chunking.  You'll get the same 100 records again and again until you acknowledge orders.  The orders that are returned contain only items for this distribution center and are by default completely expanded with billing, channel_partner, checkout, coupons, customer_profile, edi, gift, gift_certificate, internal, items, payment, shipping, summary, taxes. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetDistributionCenterOrdersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new FulfillmentApi(simpleKey);

            var distributionCenterCode = distributionCenterCode_example;  // string | Distribution center code

            try
            {
                // Retrieve orders queued up for this distribution center.
                OrdersResponse result = apiInstance.GetDistributionCenterOrders(distributionCenterCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentApi.GetDistributionCenterOrders: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistributioncenters"></a>
# **GetDistributionCenters**
> DistributionCentersResponse GetDistributionCenters ()

Retrieve distribution centers

Retrieves the distribution centers that this user has access to. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetDistributionCentersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new FulfillmentApi(simpleKey);


            try
            {
                // Retrieve distribution centers
                DistributionCentersResponse result = apiInstance.GetDistributionCenters();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentApi.GetDistributionCenters: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shiporders"></a>
# **ShipOrders**
> void ShipOrders (string distributionCenterCode, List<FulfillmentShipment> shipments)

Mark orders as shipped

Store the tracking information and mark the order shipped for this distribution center. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ShipOrdersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new FulfillmentApi(simpleKey);

            var distributionCenterCode = distributionCenterCode_example;  // string | Distribution center code
            var shipments = new List<FulfillmentShipment>(); // List<FulfillmentShipment> | Orders to mark shipped

            try
            {
                // Mark orders as shipped
                apiInstance.ShipOrders(distributionCenterCode, shipments);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentApi.ShipOrders: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinventory"></a>
# **UpdateInventory**
> void UpdateInventory (string distributionCenterCode, List<FulfillmentInventory> inventories)

Update inventory

Update the inventory for items associated with this distribution center 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateInventoryExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new FulfillmentApi(simpleKey);

            var distributionCenterCode = distributionCenterCode_example;  // string | Distribution center code
            var inventories = new List<FulfillmentInventory>(); // List<FulfillmentInventory> | Inventory updates (limit 500)

            try
            {
                // Update inventory
                apiInstance.UpdateInventory(distributionCenterCode, inventories);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentApi.UpdateInventory: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

