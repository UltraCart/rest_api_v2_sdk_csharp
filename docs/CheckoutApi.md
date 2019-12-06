# com.ultracart.admin.v2.Api.CheckoutApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CityState**](CheckoutApi.md#citystate) | **POST** /checkout/city_state | City/State for Zip
[**FinalizeOrder**](CheckoutApi.md#finalizeorder) | **POST** /checkout/cart/finalizeOrder | Finalize Order
[**GetAffirmCheckout**](CheckoutApi.md#getaffirmcheckout) | **GET** /checkout/cart/{cart_id}/affirmCheckout | Get affirm checkout (by cart id)
[**GetAllowedCountries**](CheckoutApi.md#getallowedcountries) | **POST** /checkout/allowedCountries | Allowed countries
[**GetCart**](CheckoutApi.md#getcart) | **GET** /checkout/cart | Get cart
[**GetCartByCartId**](CheckoutApi.md#getcartbycartid) | **GET** /checkout/cart/{cart_id} | Get cart (by cart id)
[**GetCartByReturnCode**](CheckoutApi.md#getcartbyreturncode) | **GET** /checkout/return/{return_code} | Get cart (by return code)
[**GetStateProvincesForCountry**](CheckoutApi.md#getstateprovincesforcountry) | **POST** /checkout/stateProvincesForCountry/{country_code} | Get state/province list for a country code
[**HandoffCart**](CheckoutApi.md#handoffcart) | **POST** /checkout/cart/handoff | Handoff cart
[**Login**](CheckoutApi.md#login) | **POST** /checkout/cart/profile/login | Profile login
[**Logout**](CheckoutApi.md#logout) | **POST** /checkout/cart/profile/logout | Profile logout
[**Register**](CheckoutApi.md#register) | **POST** /checkout/cart/profile/register | Profile registration
[**RelatedItemsForCart**](CheckoutApi.md#relateditemsforcart) | **POST** /checkout/related_items | Related items
[**RelatedItemsForItem**](CheckoutApi.md#relateditemsforitem) | **POST** /checkout/relatedItems/{item_id} | Related items (specific item)
[**SetupBrowserKey**](CheckoutApi.md#setupbrowserkey) | **PUT** /checkout/browser_key | Setup Browser Application
[**UpdateCart**](CheckoutApi.md#updatecart) | **PUT** /checkout/cart | Update cart
[**ValidateCart**](CheckoutApi.md#validatecart) | **POST** /checkout/cart/validate | Validate


<a name="citystate"></a>
# **CityState**
> CityStateZip CityState (Cart cart)

City/State for Zip

Look up the city and state for the shipping zip code.  Useful for building an auto complete for parts of the shipping address 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class CityStateExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CheckoutApi();
            var cart = new Cart(); // Cart | Cart

            try
            {
                // City/State for Zip
                CityStateZip result = apiInstance.CityState(cart);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.CityState: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cart** | [**Cart**](Cart.md)| Cart | 

### Return type

[**CityStateZip**](CityStateZip.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="finalizeorder"></a>
# **FinalizeOrder**
> CartFinalizeOrderResponse FinalizeOrder (CartFinalizeOrderRequest finalizeRequest)

Finalize Order

Finalize the cart into an order.  This method can not be called with browser key authentication.  It is ONLY meant for server side code to call. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class FinalizeOrderExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CheckoutApi();
            var finalizeRequest = new CartFinalizeOrderRequest(); // CartFinalizeOrderRequest | Finalize request

            try
            {
                // Finalize Order
                CartFinalizeOrderResponse result = apiInstance.FinalizeOrder(finalizeRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.FinalizeOrder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **finalizeRequest** | [**CartFinalizeOrderRequest**](CartFinalizeOrderRequest.md)| Finalize request | 

### Return type

[**CartFinalizeOrderResponse**](CartFinalizeOrderResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaffirmcheckout"></a>
# **GetAffirmCheckout**
> CartAffirmCheckoutResponse GetAffirmCheckout (string cartId)

Get affirm checkout (by cart id)

Get a Affirm checkout object for the specified cart_id parameter. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetAffirmCheckoutExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CheckoutApi();
            var cartId = cartId_example;  // string | Cart ID to retrieve

            try
            {
                // Get affirm checkout (by cart id)
                CartAffirmCheckoutResponse result = apiInstance.GetAffirmCheckout(cartId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.GetAffirmCheckout: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartId** | **string**| Cart ID to retrieve | 

### Return type

[**CartAffirmCheckoutResponse**](CartAffirmCheckoutResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallowedcountries"></a>
# **GetAllowedCountries**
> CheckoutAllowedCountriesResponse GetAllowedCountries ()

Allowed countries

Lookup the allowed countries for this merchant id 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetAllowedCountriesExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CheckoutApi();

            try
            {
                // Allowed countries
                CheckoutAllowedCountriesResponse result = apiInstance.GetAllowedCountries();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.GetAllowedCountries: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CheckoutAllowedCountriesResponse**](CheckoutAllowedCountriesResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcart"></a>
# **GetCart**
> CartResponse GetCart (string expand = null)

Get cart

If the cookie is set on the browser making the request then it will return their active cart.  Otherwise it will create a new cart. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCartExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CheckoutApi();
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Get cart
                CartResponse result = apiInstance.GetCart(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.GetCart: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CartResponse**](CartResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartbycartid"></a>
# **GetCartByCartId**
> CartResponse GetCartByCartId (string cartId, string expand = null)

Get cart (by cart id)

Get a cart specified by the cart_id parameter. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCartByCartIdExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CheckoutApi();
            var cartId = cartId_example;  // string | Cart ID to retrieve
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Get cart (by cart id)
                CartResponse result = apiInstance.GetCartByCartId(cartId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.GetCartByCartId: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartId** | **string**| Cart ID to retrieve | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CartResponse**](CartResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartbyreturncode"></a>
# **GetCartByReturnCode**
> CartResponse GetCartByReturnCode (string returnCode, string expand = null)

Get cart (by return code)

Get a cart specified by the return code parameter. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCartByReturnCodeExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CheckoutApi();
            var returnCode = returnCode_example;  // string | Return code to lookup cart ID by
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Get cart (by return code)
                CartResponse result = apiInstance.GetCartByReturnCode(returnCode, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.GetCartByReturnCode: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnCode** | **string**| Return code to lookup cart ID by | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CartResponse**](CartResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstateprovincesforcountry"></a>
# **GetStateProvincesForCountry**
> CheckoutStateProvinceResponse GetStateProvincesForCountry (string countryCode)

Get state/province list for a country code

Lookup a state/province list for a given country code 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetStateProvincesForCountryExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CheckoutApi();
            var countryCode = countryCode_example;  // string | Two letter ISO country code

            try
            {
                // Get state/province list for a country code
                CheckoutStateProvinceResponse result = apiInstance.GetStateProvincesForCountry(countryCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.GetStateProvincesForCountry: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCode** | **string**| Two letter ISO country code | 

### Return type

[**CheckoutStateProvinceResponse**](CheckoutStateProvinceResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handoffcart"></a>
# **HandoffCart**
> CheckoutHandoffResponse HandoffCart (CheckoutHandoffRequest handoffRequest, string expand = null)

Handoff cart

Handoff the browser to UltraCart for view cart on StoreFront, transfer to PayPal, transfer to Affirm or finalization of the order (including upsell processing). 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class HandoffCartExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CheckoutApi();
            var handoffRequest = new CheckoutHandoffRequest(); // CheckoutHandoffRequest | Handoff request
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Handoff cart
                CheckoutHandoffResponse result = apiInstance.HandoffCart(handoffRequest, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.HandoffCart: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handoffRequest** | [**CheckoutHandoffRequest**](CheckoutHandoffRequest.md)| Handoff request | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CheckoutHandoffResponse**](CheckoutHandoffResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="login"></a>
# **Login**
> CartProfileLoginResponse Login (CartProfileLoginRequest loginRequest, string expand = null)

Profile login

Login in to the customer profile specified by cart.billing.email and password 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class LoginExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CheckoutApi();
            var loginRequest = new CartProfileLoginRequest(); // CartProfileLoginRequest | Login request
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Profile login
                CartProfileLoginResponse result = apiInstance.Login(loginRequest, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.Login: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loginRequest** | [**CartProfileLoginRequest**](CartProfileLoginRequest.md)| Login request | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CartProfileLoginResponse**](CartProfileLoginResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logout"></a>
# **Logout**
> CartResponse Logout (Cart cart, string expand = null)

Profile logout

Log the cart out of the current profile.  No error will occur if they are not logged in. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class LogoutExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CheckoutApi();
            var cart = new Cart(); // Cart | Cart
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Profile logout
                CartResponse result = apiInstance.Logout(cart, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.Logout: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cart** | [**Cart**](Cart.md)| Cart | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CartResponse**](CartResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="register"></a>
# **Register**
> CartProfileRegisterResponse Register (CartProfileRegisterRequest registerRequest, string expand = null)

Profile registration

Register a new customer profile.  Requires the cart.billing object to be populated along with the password. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class RegisterExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CheckoutApi();
            var registerRequest = new CartProfileRegisterRequest(); // CartProfileRegisterRequest | Register request
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Profile registration
                CartProfileRegisterResponse result = apiInstance.Register(registerRequest, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.Register: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registerRequest** | [**CartProfileRegisterRequest**](CartProfileRegisterRequest.md)| Register request | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CartProfileRegisterResponse**](CartProfileRegisterResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="relateditemsforcart"></a>
# **RelatedItemsForCart**
> ItemsResponse RelatedItemsForCart (Cart cart, string expand = null)

Related items

Retrieve all the related items for the cart contents.  Expansion is limited to content, content.assignments, content.attributes, content.multimedia, content.multimedia.thumbnails, options, pricing, and pricing.tiers. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class RelatedItemsForCartExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CheckoutApi();
            var cart = new Cart(); // Cart | Cart
            var expand = expand_example;  // string | The object expansion to perform on the result.  See item resource documentation for examples (optional) 

            try
            {
                // Related items
                ItemsResponse result = apiInstance.RelatedItemsForCart(cart, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.RelatedItemsForCart: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cart** | [**Cart**](Cart.md)| Cart | 
 **expand** | **string**| The object expansion to perform on the result.  See item resource documentation for examples | [optional] 

### Return type

[**ItemsResponse**](ItemsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="relateditemsforitem"></a>
# **RelatedItemsForItem**
> ItemsResponse RelatedItemsForItem (string itemId, Cart cart, string expand = null)

Related items (specific item)

Retrieve all the related items for the cart contents.  Expansion is limited to content, content.assignments, content.attributes, content.multimedia, content.multimedia.thumbnails, options, pricing, and pricing.tiers. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class RelatedItemsForItemExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CheckoutApi();
            var itemId = itemId_example;  // string | Item ID to retrieve related items for
            var cart = new Cart(); // Cart | Cart
            var expand = expand_example;  // string | The object expansion to perform on the result.  See item resource documentation for examples (optional) 

            try
            {
                // Related items (specific item)
                ItemsResponse result = apiInstance.RelatedItemsForItem(itemId, cart, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.RelatedItemsForItem: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemId** | **string**| Item ID to retrieve related items for | 
 **cart** | [**Cart**](Cart.md)| Cart | 
 **expand** | **string**| The object expansion to perform on the result.  See item resource documentation for examples | [optional] 

### Return type

[**ItemsResponse**](ItemsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setupbrowserkey"></a>
# **SetupBrowserKey**
> CheckoutSetupBrowserKeyResponse SetupBrowserKey (CheckoutSetupBrowserKeyRequest browserKeyRequest)

Setup Browser Application

Setup a browser key authenticated application with checkout permissions.  This REST call must be made with an authentication scheme that is not browser key.  The new application will be linked to the application that makes this call.  If this application is disabled / deleted, then so will the application setup by this call.  The purpose of this call is to allow an OAuth applicaiton, such as the Wordpress plugin, to setup the proper browser based authentication for the REST checkout API to use. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SetupBrowserKeyExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CheckoutApi();
            var browserKeyRequest = new CheckoutSetupBrowserKeyRequest(); // CheckoutSetupBrowserKeyRequest | Setup browser key request

            try
            {
                // Setup Browser Application
                CheckoutSetupBrowserKeyResponse result = apiInstance.SetupBrowserKey(browserKeyRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.SetupBrowserKey: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **browserKeyRequest** | [**CheckoutSetupBrowserKeyRequest**](CheckoutSetupBrowserKeyRequest.md)| Setup browser key request | 

### Return type

[**CheckoutSetupBrowserKeyResponse**](CheckoutSetupBrowserKeyResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecart"></a>
# **UpdateCart**
> CartResponse UpdateCart (Cart cart, string expand = null)

Update cart

Update the cart. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateCartExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CheckoutApi();
            var cart = new Cart(); // Cart | Cart
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Update cart
                CartResponse result = apiInstance.UpdateCart(cart, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.UpdateCart: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cart** | [**Cart**](Cart.md)| Cart | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CartResponse**](CartResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatecart"></a>
# **ValidateCart**
> CartValidationResponse ValidateCart (CartValidationRequest validationRequest, string expand = null)

Validate

Validate the cart for errors.  Specific checks can be passed and multiple validations can occur throughout your checkout flow. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ValidateCartExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CheckoutApi();
            var validationRequest = new CartValidationRequest(); // CartValidationRequest | Validation request
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Validate
                CartValidationResponse result = apiInstance.ValidateCart(validationRequest, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.ValidateCart: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **validationRequest** | [**CartValidationRequest**](CartValidationRequest.md)| Validation request | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CartValidationResponse**](CartValidationResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

