# com.ultracart.admin.v2.Api.ChannelPartnerApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelOrderByChannelPartnerOrderId**](ChannelPartnerApi.md#cancelorderbychannelpartnerorderid) | **DELETE** /channel_partner/cancel/by_channel_partner_order_id/{order_id} | Cancel channel partner order by channel partner order id
[**CancelOrderByChannelUltraCartOrderId**](ChannelPartnerApi.md#cancelorderbychannelultracartorderid) | **DELETE** /channel_partner/cancel/by_ultracart_order_id/{order_id} | Cancel channel partner order by UltraCart order id
[**EstimateShippingForChannelPartnerOrder**](ChannelPartnerApi.md#estimateshippingforchannelpartnerorder) | **POST** /channel_partner/estimate_shipping | Estimate shipping for channel partner order
[**ImportChannelPartnerOrder**](ChannelPartnerApi.md#importchannelpartnerorder) | **POST** /channel_partner/import | Insert channel partner order


<a name="cancelorderbychannelpartnerorderid"></a>
# **CancelOrderByChannelPartnerOrderId**
> ChannelPartnerCancelResponse CancelOrderByChannelPartnerOrderId (string orderId)

Cancel channel partner order by channel partner order id

Cancel channel partner order by channel partner order id 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class CancelOrderByChannelPartnerOrderIdExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ChannelPartnerApi(simpleKey);

            var orderId = orderId_example;  // string | The channel partner order id to delete.

            try
            {
                // Cancel channel partner order by channel partner order id
                ChannelPartnerCancelResponse result = apiInstance.CancelOrderByChannelPartnerOrderId(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelPartnerApi.CancelOrderByChannelPartnerOrderId: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The channel partner order id to delete. | 

### Return type

[**ChannelPartnerCancelResponse**](ChannelPartnerCancelResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelorderbychannelultracartorderid"></a>
# **CancelOrderByChannelUltraCartOrderId**
> ChannelPartnerCancelResponse CancelOrderByChannelUltraCartOrderId (string orderId)

Cancel channel partner order by UltraCart order id

Cancel channel partner order by UltraCart order id 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class CancelOrderByChannelUltraCartOrderIdExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ChannelPartnerApi(simpleKey);

            var orderId = orderId_example;  // string | The UltraCart order id to delete.

            try
            {
                // Cancel channel partner order by UltraCart order id
                ChannelPartnerCancelResponse result = apiInstance.CancelOrderByChannelUltraCartOrderId(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelPartnerApi.CancelOrderByChannelUltraCartOrderId: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The UltraCart order id to delete. | 

### Return type

[**ChannelPartnerCancelResponse**](ChannelPartnerCancelResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="estimateshippingforchannelpartnerorder"></a>
# **EstimateShippingForChannelPartnerOrder**
> ChannelPartnerEstimateShippingResponse EstimateShippingForChannelPartnerOrder (ChannelPartnerOrder channelPartnerOrder)

Estimate shipping for channel partner order

Estimate shipping for order from a channel partner. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class EstimateShippingForChannelPartnerOrderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ChannelPartnerApi(simpleKey);

            var channelPartnerOrder = new ChannelPartnerOrder(); // ChannelPartnerOrder | Order needing shipping estimate

            try
            {
                // Estimate shipping for channel partner order
                ChannelPartnerEstimateShippingResponse result = apiInstance.EstimateShippingForChannelPartnerOrder(channelPartnerOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelPartnerApi.EstimateShippingForChannelPartnerOrder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelPartnerOrder** | [**ChannelPartnerOrder**](ChannelPartnerOrder.md)| Order needing shipping estimate | 

### Return type

[**ChannelPartnerEstimateShippingResponse**](ChannelPartnerEstimateShippingResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importchannelpartnerorder"></a>
# **ImportChannelPartnerOrder**
> ChannelPartnerImportResponse ImportChannelPartnerOrder (ChannelPartnerOrder channelPartnerOrder)

Insert channel partner order

Insert order from a channel partner. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ImportChannelPartnerOrderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ChannelPartnerApi(simpleKey);

            var channelPartnerOrder = new ChannelPartnerOrder(); // ChannelPartnerOrder | Order to insert

            try
            {
                // Insert channel partner order
                ChannelPartnerImportResponse result = apiInstance.ImportChannelPartnerOrder(channelPartnerOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelPartnerApi.ImportChannelPartnerOrder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelPartnerOrder** | [**ChannelPartnerOrder**](ChannelPartnerOrder.md)| Order to insert | 

### Return type

[**ChannelPartnerImportResponse**](ChannelPartnerImportResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

