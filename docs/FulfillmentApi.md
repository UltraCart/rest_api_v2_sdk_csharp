# com.ultracart.admin.v2.Api.FulfillmentApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FulfillmentDistributionCentersDistributionCenterCodeAcknowledgementsPut**](FulfillmentApi.md#fulfillmentdistributioncentersdistributioncentercodeacknowledgementsput) | **PUT** /fulfillment/distribution_centers/{distribution_center_code}/acknowledgements | Acknowledge receipt of orders.
[**FulfillmentDistributionCentersDistributionCenterCodeInventoryPost**](FulfillmentApi.md#fulfillmentdistributioncentersdistributioncentercodeinventorypost) | **POST** /fulfillment/distribution_centers/{distribution_center_code}/inventory | Update inventory
[**FulfillmentDistributionCentersDistributionCenterCodeOrdersGet**](FulfillmentApi.md#fulfillmentdistributioncentersdistributioncentercodeordersget) | **GET** /fulfillment/distribution_centers/{distribution_center_code}/orders | Retrieve orders queued up for this distribution center.
[**FulfillmentDistributionCentersDistributionCenterCodeShipmentsPost**](FulfillmentApi.md#fulfillmentdistributioncentersdistributioncentercodeshipmentspost) | **POST** /fulfillment/distribution_centers/{distribution_center_code}/shipments | Mark orders as shipped
[**FulfillmentDistributionCentersGet**](FulfillmentApi.md#fulfillmentdistributioncentersget) | **GET** /fulfillment/distribution_centers | Retrieve distribution centers


<a name="fulfillmentdistributioncentersdistributioncentercodeacknowledgementsput"></a>
# **FulfillmentDistributionCentersDistributionCenterCodeAcknowledgementsPut**
> void FulfillmentDistributionCentersDistributionCenterCodeAcknowledgementsPut (string distributionCenterCode, List<string> orderIds)

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
    public class FulfillmentDistributionCentersDistributionCenterCodeAcknowledgementsPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new FulfillmentApi();
            var distributionCenterCode = distributionCenterCode_example;  // string | Distribution center code
            var orderIds = ;  // List<string> | Orders to acknowledge receipt of (limit 100)

            try
            {
                // Acknowledge receipt of orders.
                apiInstance.FulfillmentDistributionCentersDistributionCenterCodeAcknowledgementsPut(distributionCenterCode, orderIds);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentApi.FulfillmentDistributionCentersDistributionCenterCodeAcknowledgementsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **distributionCenterCode** | **string**| Distribution center code | 
 **orderIds** | **List<string>**| Orders to acknowledge receipt of (limit 100) | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fulfillmentdistributioncentersdistributioncentercodeinventorypost"></a>
# **FulfillmentDistributionCentersDistributionCenterCodeInventoryPost**
> void FulfillmentDistributionCentersDistributionCenterCodeInventoryPost (string distributionCenterCode, List<FulfillmentInventory> inventories)

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
    public class FulfillmentDistributionCentersDistributionCenterCodeInventoryPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new FulfillmentApi();
            var distributionCenterCode = distributionCenterCode_example;  // string | Distribution center code
            var inventories = new List<FulfillmentInventory>(); // List<FulfillmentInventory> | Inventory updates (limit 500)

            try
            {
                // Update inventory
                apiInstance.FulfillmentDistributionCentersDistributionCenterCodeInventoryPost(distributionCenterCode, inventories);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentApi.FulfillmentDistributionCentersDistributionCenterCodeInventoryPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **distributionCenterCode** | **string**| Distribution center code | 
 **inventories** | [**List<FulfillmentInventory>**](FulfillmentInventory.md)| Inventory updates (limit 500) | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fulfillmentdistributioncentersdistributioncentercodeordersget"></a>
# **FulfillmentDistributionCentersDistributionCenterCodeOrdersGet**
> OrdersResponse FulfillmentDistributionCentersDistributionCenterCodeOrdersGet (string distributionCenterCode)

Retrieve orders queued up for this distribution center.

Retrieves up to 100 orders that are queued up in this distribution center.  You must acknowledge them before additional new orders will be returned.  The orders that are returned contain only items for this distribution center and are expanded with billing, buysafe, channel_partner, checkout, coupons, customer_profile, edi, gift, gift_certificate, internal, items, payment, shipping, summary, taxes. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class FulfillmentDistributionCentersDistributionCenterCodeOrdersGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new FulfillmentApi();
            var distributionCenterCode = distributionCenterCode_example;  // string | Distribution center code

            try
            {
                // Retrieve orders queued up for this distribution center.
                OrdersResponse result = apiInstance.FulfillmentDistributionCentersDistributionCenterCodeOrdersGet(distributionCenterCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentApi.FulfillmentDistributionCentersDistributionCenterCodeOrdersGet: " + e.Message );
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

<a name="fulfillmentdistributioncentersdistributioncentercodeshipmentspost"></a>
# **FulfillmentDistributionCentersDistributionCenterCodeShipmentsPost**
> void FulfillmentDistributionCentersDistributionCenterCodeShipmentsPost (string distributionCenterCode, List<FulfillmentShipment> shipments)

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
    public class FulfillmentDistributionCentersDistributionCenterCodeShipmentsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new FulfillmentApi();
            var distributionCenterCode = distributionCenterCode_example;  // string | Distribution center code
            var shipments = new List<FulfillmentShipment>(); // List<FulfillmentShipment> | Orders to mark shipped

            try
            {
                // Mark orders as shipped
                apiInstance.FulfillmentDistributionCentersDistributionCenterCodeShipmentsPost(distributionCenterCode, shipments);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentApi.FulfillmentDistributionCentersDistributionCenterCodeShipmentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **distributionCenterCode** | **string**| Distribution center code | 
 **shipments** | [**List<FulfillmentShipment>**](FulfillmentShipment.md)| Orders to mark shipped | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fulfillmentdistributioncentersget"></a>
# **FulfillmentDistributionCentersGet**
> DistributionCentersResponse FulfillmentDistributionCentersGet ()

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
    public class FulfillmentDistributionCentersGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new FulfillmentApi();

            try
            {
                // Retrieve distribution centers
                DistributionCentersResponse result = apiInstance.FulfillmentDistributionCentersGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentApi.FulfillmentDistributionCentersGet: " + e.Message );
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

