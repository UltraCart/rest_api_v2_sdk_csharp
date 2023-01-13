# com.ultracart.admin.v2.Api.ChannelPartnerApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelOrderByChannelPartnerOrderId**](ChannelPartnerApi.md#cancelorderbychannelpartnerorderid) | **DELETE** /channel_partner/cancel/by_channel_partner_order_id/{order_id} | Cancel channel partner order by channel partner order id
[**CancelOrderByUltraCartOrderId**](ChannelPartnerApi.md#cancelorderbyultracartorderid) | **DELETE** /channel_partner/cancel/by_ultracart_order_id/{order_id} | Cancel channel partner order by UltraCart order id
[**DeleteChannelPartnerShipToPreference**](ChannelPartnerApi.md#deletechannelpartnershiptopreference) | **DELETE** /channel_partner/channel_partners/{channel_partner_oid}/ship_to_preferences/{channel_partner_ship_to_preference_oid} | Delete a ship to preference record for the channel partner.
[**EstimateShippingForChannelPartnerOrder**](ChannelPartnerApi.md#estimateshippingforchannelpartnerorder) | **POST** /channel_partner/estimate_shipping | Estimate shipping for channel partner order
[**EstimateTaxForChannelPartnerOrder**](ChannelPartnerApi.md#estimatetaxforchannelpartnerorder) | **POST** /channel_partner/estimate_tax | Estimate tax for channel partner order
[**GetChannelPartnerShipToPreference**](ChannelPartnerApi.md#getchannelpartnershiptopreference) | **GET** /channel_partner/channel_partners/{channel_partner_oid}/ship_to_preferences/{channel_partner_ship_to_preference_oid} | Retrieve the ship to preference associated with the channel partner and the specific id.
[**GetChannelPartnerShipToPreferences**](ChannelPartnerApi.md#getchannelpartnershiptopreferences) | **GET** /channel_partner/channel_partners/{channel_partner_oid}/ship_to_preferences | Retrieve the ship to preferences associated with the channel partner.
[**GetChannelPartners**](ChannelPartnerApi.md#getchannelpartners) | **GET** /channel_partner/channel_partners | Retrieve the channel partners configured on the account.
[**ImportChannelPartnerOrder**](ChannelPartnerApi.md#importchannelpartnerorder) | **POST** /channel_partner/import | Insert channel partner order
[**InsertChannelPartnerShipToPreference**](ChannelPartnerApi.md#insertchannelpartnershiptopreference) | **POST** /channel_partner/channel_partners/{channel_partner_oid}/ship_to_preferences | Insert a ship to preference record for the channel partner.
[**UpdateChannelPartnerShipToPreference**](ChannelPartnerApi.md#updatechannelpartnershiptopreference) | **PUT** /channel_partner/channel_partners/{channel_partner_oid}/ship_to_preferences/{channel_partner_ship_to_preference_oid} | Update a ship to preference record for the channel partner.


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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelorderbyultracartorderid"></a>
# **CancelOrderByUltraCartOrderId**
> ChannelPartnerCancelResponse CancelOrderByUltraCartOrderId (string orderId)

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
    public class CancelOrderByUltraCartOrderIdExample
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
                ChannelPartnerCancelResponse result = apiInstance.CancelOrderByUltraCartOrderId(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelPartnerApi.CancelOrderByUltraCartOrderId: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechannelpartnershiptopreference"></a>
# **DeleteChannelPartnerShipToPreference**
> void DeleteChannelPartnerShipToPreference (int? channelPartnerOid, int? channelPartnerShipToPreferenceOid)

Delete a ship to preference record for the channel partner.

Delete a ship to preference record for the channel partner. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteChannelPartnerShipToPreferenceExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ChannelPartnerApi(simpleKey);

            var channelPartnerOid = 56;  // int? | 
            var channelPartnerShipToPreferenceOid = 56;  // int? | 

            try
            {
                // Delete a ship to preference record for the channel partner.
                apiInstance.DeleteChannelPartnerShipToPreference(channelPartnerOid, channelPartnerShipToPreferenceOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelPartnerApi.DeleteChannelPartnerShipToPreference: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelPartnerOid** | **int?**|  | 
 **channelPartnerShipToPreferenceOid** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
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

<a name="estimatetaxforchannelpartnerorder"></a>
# **EstimateTaxForChannelPartnerOrder**
> ChannelPartnerEstimateTaxResponse EstimateTaxForChannelPartnerOrder (ChannelPartnerOrder channelPartnerOrder)

Estimate tax for channel partner order

Estimate tax for order from a channel partner. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class EstimateTaxForChannelPartnerOrderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ChannelPartnerApi(simpleKey);

            var channelPartnerOrder = new ChannelPartnerOrder(); // ChannelPartnerOrder | Order needing tax estimate

            try
            {
                // Estimate tax for channel partner order
                ChannelPartnerEstimateTaxResponse result = apiInstance.EstimateTaxForChannelPartnerOrder(channelPartnerOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelPartnerApi.EstimateTaxForChannelPartnerOrder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelPartnerOrder** | [**ChannelPartnerOrder**](ChannelPartnerOrder.md)| Order needing tax estimate | 

### Return type

[**ChannelPartnerEstimateTaxResponse**](ChannelPartnerEstimateTaxResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelpartnershiptopreference"></a>
# **GetChannelPartnerShipToPreference**
> ChannelPartnerShipToPreferenceResponse GetChannelPartnerShipToPreference (int? channelPartnerOid, int? channelPartnerShipToPreferenceOid)

Retrieve the ship to preference associated with the channel partner and the specific id.

Retrieve the ship to preference associated with the channel partner and the specific id. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetChannelPartnerShipToPreferenceExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ChannelPartnerApi(simpleKey);

            var channelPartnerOid = 56;  // int? | 
            var channelPartnerShipToPreferenceOid = 56;  // int? | 

            try
            {
                // Retrieve the ship to preference associated with the channel partner and the specific id.
                ChannelPartnerShipToPreferenceResponse result = apiInstance.GetChannelPartnerShipToPreference(channelPartnerOid, channelPartnerShipToPreferenceOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelPartnerApi.GetChannelPartnerShipToPreference: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelPartnerOid** | **int?**|  | 
 **channelPartnerShipToPreferenceOid** | **int?**|  | 

### Return type

[**ChannelPartnerShipToPreferenceResponse**](ChannelPartnerShipToPreferenceResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelpartnershiptopreferences"></a>
# **GetChannelPartnerShipToPreferences**
> ChannelPartnerShipToPreferencesResponse GetChannelPartnerShipToPreferences (int? channelPartnerOid)

Retrieve the ship to preferences associated with the channel partner.

Retrieve the ship to preferences associated with the channel partner. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetChannelPartnerShipToPreferencesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ChannelPartnerApi(simpleKey);

            var channelPartnerOid = 56;  // int? | 

            try
            {
                // Retrieve the ship to preferences associated with the channel partner.
                ChannelPartnerShipToPreferencesResponse result = apiInstance.GetChannelPartnerShipToPreferences(channelPartnerOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelPartnerApi.GetChannelPartnerShipToPreferences: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelPartnerOid** | **int?**|  | 

### Return type

[**ChannelPartnerShipToPreferencesResponse**](ChannelPartnerShipToPreferencesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelpartners"></a>
# **GetChannelPartners**
> ChannelPartnersResponse GetChannelPartners ()

Retrieve the channel partners configured on the account.

Retrieve the channel partners configured on the account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetChannelPartnersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ChannelPartnerApi(simpleKey);


            try
            {
                // Retrieve the channel partners configured on the account.
                ChannelPartnersResponse result = apiInstance.GetChannelPartners();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelPartnerApi.GetChannelPartners: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ChannelPartnersResponse**](ChannelPartnersResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
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

<a name="insertchannelpartnershiptopreference"></a>
# **InsertChannelPartnerShipToPreference**
> ChannelPartnerShipToPreferenceResponse InsertChannelPartnerShipToPreference (int? channelPartnerOid, ChannelPartnerShipToPreference shipToPreference)

Insert a ship to preference record for the channel partner.

Insert a ship to preference record for the channel partner. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertChannelPartnerShipToPreferenceExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ChannelPartnerApi(simpleKey);

            var channelPartnerOid = 56;  // int? | 
            var shipToPreference = new ChannelPartnerShipToPreference(); // ChannelPartnerShipToPreference | Ship to preference to create

            try
            {
                // Insert a ship to preference record for the channel partner.
                ChannelPartnerShipToPreferenceResponse result = apiInstance.InsertChannelPartnerShipToPreference(channelPartnerOid, shipToPreference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelPartnerApi.InsertChannelPartnerShipToPreference: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelPartnerOid** | **int?**|  | 
 **shipToPreference** | [**ChannelPartnerShipToPreference**](ChannelPartnerShipToPreference.md)| Ship to preference to create | 

### Return type

[**ChannelPartnerShipToPreferenceResponse**](ChannelPartnerShipToPreferenceResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatechannelpartnershiptopreference"></a>
# **UpdateChannelPartnerShipToPreference**
> ChannelPartnerShipToPreferenceResponse UpdateChannelPartnerShipToPreference (int? channelPartnerOid, int? channelPartnerShipToPreferenceOid, ChannelPartnerShipToPreference shipToPreference)

Update a ship to preference record for the channel partner.

Update a ship to preference record for the channel partner. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateChannelPartnerShipToPreferenceExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ChannelPartnerApi(simpleKey);

            var channelPartnerOid = 56;  // int? | 
            var channelPartnerShipToPreferenceOid = 56;  // int? | 
            var shipToPreference = new ChannelPartnerShipToPreference(); // ChannelPartnerShipToPreference | Ship to preference to create

            try
            {
                // Update a ship to preference record for the channel partner.
                ChannelPartnerShipToPreferenceResponse result = apiInstance.UpdateChannelPartnerShipToPreference(channelPartnerOid, channelPartnerShipToPreferenceOid, shipToPreference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelPartnerApi.UpdateChannelPartnerShipToPreference: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelPartnerOid** | **int?**|  | 
 **channelPartnerShipToPreferenceOid** | **int?**|  | 
 **shipToPreference** | [**ChannelPartnerShipToPreference**](ChannelPartnerShipToPreference.md)| Ship to preference to create | 

### Return type

[**ChannelPartnerShipToPreferenceResponse**](ChannelPartnerShipToPreferenceResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

