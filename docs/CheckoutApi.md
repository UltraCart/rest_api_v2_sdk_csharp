# com.ultracart.admin.v2.Api.CheckoutApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckoutBrowserKeyPut**](CheckoutApi.md#checkoutbrowserkeyput) | **PUT** /checkout/browser_key | Setup Browser Application
[**CheckoutCartCartIdGet**](CheckoutApi.md#checkoutcartcartidget) | **GET** /checkout/cart/{cart_id} | Get cart (by cart id)
[**CheckoutCartFinalizeOrderPost**](CheckoutApi.md#checkoutcartfinalizeorderpost) | **POST** /checkout/cart/finalizeOrder | Finalize Order
[**CheckoutCartGet**](CheckoutApi.md#checkoutcartget) | **GET** /checkout/cart | Get cart
[**CheckoutCartHandoffPost**](CheckoutApi.md#checkoutcarthandoffpost) | **POST** /checkout/cart/handoff | Handoff cart
[**CheckoutCartProfileLoginPost**](CheckoutApi.md#checkoutcartprofileloginpost) | **POST** /checkout/cart/profile/login | Profile login
[**CheckoutCartProfileLogoutPost**](CheckoutApi.md#checkoutcartprofilelogoutpost) | **POST** /checkout/cart/profile/logout | Profile logout
[**CheckoutCartProfileRegisterPost**](CheckoutApi.md#checkoutcartprofileregisterpost) | **POST** /checkout/cart/profile/register | Profile registration
[**CheckoutCartPut**](CheckoutApi.md#checkoutcartput) | **PUT** /checkout/cart | Update cart
[**CheckoutCartValidatePost**](CheckoutApi.md#checkoutcartvalidatepost) | **POST** /checkout/cart/validate | Validate
[**CheckoutCityStatePost**](CheckoutApi.md#checkoutcitystatepost) | **POST** /checkout/city_state | City/State for Zip
[**CheckoutRelatedItemsItemIdPost**](CheckoutApi.md#checkoutrelateditemsitemidpost) | **POST** /checkout/relatedItems/{item_id} | Related items (specific item)
[**CheckoutRelatedItemsPost**](CheckoutApi.md#checkoutrelateditemspost) | **POST** /checkout/related_items | Related items
[**CheckoutReturnReturnCodeGet**](CheckoutApi.md#checkoutreturnreturncodeget) | **GET** /checkout/return/{return_code} | Get cart (by return code)


<a name="checkoutbrowserkeyput"></a>
# **CheckoutBrowserKeyPut**
> CheckoutSetupBrowserKeyResponse CheckoutBrowserKeyPut (CheckoutSetupBrowserKeyRequest browserKeyRequest)

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
    public class CheckoutBrowserKeyPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new CheckoutApi();
            var browserKeyRequest = new CheckoutSetupBrowserKeyRequest(); // CheckoutSetupBrowserKeyRequest | Setup browser key request

            try
            {
                // Setup Browser Application
                CheckoutSetupBrowserKeyResponse result = apiInstance.CheckoutBrowserKeyPut(browserKeyRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.CheckoutBrowserKeyPut: " + e.Message );
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

<a name="checkoutcartcartidget"></a>
# **CheckoutCartCartIdGet**
> CartResponse CheckoutCartCartIdGet (string cartId, string expand = null)

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
    public class CheckoutCartCartIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: ultraCartBrowserApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-browser-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-browser-key", "Bearer");
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new CheckoutApi();
            var cartId = cartId_example;  // string | Cart ID to retrieve
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Get cart (by cart id)
                CartResponse result = apiInstance.CheckoutCartCartIdGet(cartId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.CheckoutCartCartIdGet: " + e.Message );
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

<a name="checkoutcartfinalizeorderpost"></a>
# **CheckoutCartFinalizeOrderPost**
> CartFinalizeOrderResponse CheckoutCartFinalizeOrderPost (CartFinalizeOrderRequest finalizeRequest)

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
    public class CheckoutCartFinalizeOrderPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new CheckoutApi();
            var finalizeRequest = new CartFinalizeOrderRequest(); // CartFinalizeOrderRequest | Finalize request

            try
            {
                // Finalize Order
                CartFinalizeOrderResponse result = apiInstance.CheckoutCartFinalizeOrderPost(finalizeRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.CheckoutCartFinalizeOrderPost: " + e.Message );
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

<a name="checkoutcartget"></a>
# **CheckoutCartGet**
> CartResponse CheckoutCartGet (string expand = null)

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
    public class CheckoutCartGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: ultraCartBrowserApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-browser-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-browser-key", "Bearer");
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new CheckoutApi();
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Get cart
                CartResponse result = apiInstance.CheckoutCartGet(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.CheckoutCartGet: " + e.Message );
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

<a name="checkoutcarthandoffpost"></a>
# **CheckoutCartHandoffPost**
> CheckoutHandoffResponse CheckoutCartHandoffPost (CheckoutHandoffRequest handoffRequest, string expand = null)

Handoff cart

Handoff the browser to UltraCart for view cart on StoreFront, transfer to PayPal or finalization of the order (including upsell processing). 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class CheckoutCartHandoffPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: ultraCartBrowserApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-browser-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-browser-key", "Bearer");
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new CheckoutApi();
            var handoffRequest = new CheckoutHandoffRequest(); // CheckoutHandoffRequest | Handoff request
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Handoff cart
                CheckoutHandoffResponse result = apiInstance.CheckoutCartHandoffPost(handoffRequest, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.CheckoutCartHandoffPost: " + e.Message );
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

<a name="checkoutcartprofileloginpost"></a>
# **CheckoutCartProfileLoginPost**
> CartProfileLoginResponse CheckoutCartProfileLoginPost (CartProfileLoginRequest loginRequest, string expand = null)

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
    public class CheckoutCartProfileLoginPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: ultraCartBrowserApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-browser-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-browser-key", "Bearer");
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new CheckoutApi();
            var loginRequest = new CartProfileLoginRequest(); // CartProfileLoginRequest | Login request
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Profile login
                CartProfileLoginResponse result = apiInstance.CheckoutCartProfileLoginPost(loginRequest, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.CheckoutCartProfileLoginPost: " + e.Message );
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

<a name="checkoutcartprofilelogoutpost"></a>
# **CheckoutCartProfileLogoutPost**
> CartResponse CheckoutCartProfileLogoutPost (Cart cart, string expand = null)

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
    public class CheckoutCartProfileLogoutPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: ultraCartBrowserApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-browser-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-browser-key", "Bearer");
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new CheckoutApi();
            var cart = new Cart(); // Cart | Cart
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Profile logout
                CartResponse result = apiInstance.CheckoutCartProfileLogoutPost(cart, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.CheckoutCartProfileLogoutPost: " + e.Message );
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

<a name="checkoutcartprofileregisterpost"></a>
# **CheckoutCartProfileRegisterPost**
> CartProfileRegisterResponse CheckoutCartProfileRegisterPost (CartProfileRegisterRequest registerRequest, string expand = null)

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
    public class CheckoutCartProfileRegisterPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: ultraCartBrowserApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-browser-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-browser-key", "Bearer");
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new CheckoutApi();
            var registerRequest = new CartProfileRegisterRequest(); // CartProfileRegisterRequest | Register request
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Profile registration
                CartProfileRegisterResponse result = apiInstance.CheckoutCartProfileRegisterPost(registerRequest, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.CheckoutCartProfileRegisterPost: " + e.Message );
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

<a name="checkoutcartput"></a>
# **CheckoutCartPut**
> CartResponse CheckoutCartPut (Cart cart, string expand = null)

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
    public class CheckoutCartPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: ultraCartBrowserApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-browser-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-browser-key", "Bearer");
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new CheckoutApi();
            var cart = new Cart(); // Cart | Cart
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Update cart
                CartResponse result = apiInstance.CheckoutCartPut(cart, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.CheckoutCartPut: " + e.Message );
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

<a name="checkoutcartvalidatepost"></a>
# **CheckoutCartValidatePost**
> CartValidationResponse CheckoutCartValidatePost (CartValidationRequest validationRequest, string expand = null)

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
    public class CheckoutCartValidatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: ultraCartBrowserApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-browser-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-browser-key", "Bearer");
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new CheckoutApi();
            var validationRequest = new CartValidationRequest(); // CartValidationRequest | Validation request
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Validate
                CartValidationResponse result = apiInstance.CheckoutCartValidatePost(validationRequest, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.CheckoutCartValidatePost: " + e.Message );
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

<a name="checkoutcitystatepost"></a>
# **CheckoutCityStatePost**
> ItemsResponse CheckoutCityStatePost (Cart cart)

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
    public class CheckoutCityStatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: ultraCartBrowserApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-browser-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-browser-key", "Bearer");
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new CheckoutApi();
            var cart = new Cart(); // Cart | Cart

            try
            {
                // City/State for Zip
                ItemsResponse result = apiInstance.CheckoutCityStatePost(cart);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.CheckoutCityStatePost: " + e.Message );
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

[**ItemsResponse**](ItemsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutrelateditemsitemidpost"></a>
# **CheckoutRelatedItemsItemIdPost**
> ItemsResponse CheckoutRelatedItemsItemIdPost (string itemId, Cart cart, string expand = null)

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
    public class CheckoutRelatedItemsItemIdPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: ultraCartBrowserApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-browser-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-browser-key", "Bearer");
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new CheckoutApi();
            var itemId = itemId_example;  // string | Item ID to retrieve related items for
            var cart = new Cart(); // Cart | Cart
            var expand = expand_example;  // string | The object expansion to perform on the result.  See item resource documentation for examples (optional) 

            try
            {
                // Related items (specific item)
                ItemsResponse result = apiInstance.CheckoutRelatedItemsItemIdPost(itemId, cart, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.CheckoutRelatedItemsItemIdPost: " + e.Message );
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

<a name="checkoutrelateditemspost"></a>
# **CheckoutRelatedItemsPost**
> ItemsResponse CheckoutRelatedItemsPost (Cart cart, string expand = null)

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
    public class CheckoutRelatedItemsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: ultraCartBrowserApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-browser-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-browser-key", "Bearer");
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new CheckoutApi();
            var cart = new Cart(); // Cart | Cart
            var expand = expand_example;  // string | The object expansion to perform on the result.  See item resource documentation for examples (optional) 

            try
            {
                // Related items
                ItemsResponse result = apiInstance.CheckoutRelatedItemsPost(cart, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.CheckoutRelatedItemsPost: " + e.Message );
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

<a name="checkoutreturnreturncodeget"></a>
# **CheckoutReturnReturnCodeGet**
> CartResponse CheckoutReturnReturnCodeGet (string returnCode, string expand = null)

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
    public class CheckoutReturnReturnCodeGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: ultraCartBrowserApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-browser-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-browser-key", "Bearer");
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new CheckoutApi();
            var returnCode = returnCode_example;  // string | Return code to lookup cart ID by
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Get cart (by return code)
                CartResponse result = apiInstance.CheckoutReturnReturnCodeGet(returnCode, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutApi.CheckoutReturnReturnCodeGet: " + e.Message );
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

