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
[**GetCartByReturnToken**](CheckoutApi.md#getcartbyreturntoken) | **GET** /checkout/return_token | Get cart (by return token)
[**GetStateProvincesForCountry**](CheckoutApi.md#getstateprovincesforcountry) | **POST** /checkout/stateProvincesForCountry/{country_code} | Get state/province list for a country code
[**HandoffCart**](CheckoutApi.md#handoffcart) | **POST** /checkout/cart/handoff | Handoff cart
[**Login**](CheckoutApi.md#login) | **POST** /checkout/cart/profile/login | Profile login
[**Logout**](CheckoutApi.md#logout) | **POST** /checkout/cart/profile/logout | Profile logout
[**Register**](CheckoutApi.md#register) | **POST** /checkout/cart/profile/register | Profile registration
[**RegisterAffiliateClick**](CheckoutApi.md#registeraffiliateclick) | **POST** /checkout/affiliateClick/register | Register affiliate click
[**RelatedItemsForCart**](CheckoutApi.md#relateditemsforcart) | **POST** /checkout/related_items | Related items
[**RelatedItemsForItem**](CheckoutApi.md#relateditemsforitem) | **POST** /checkout/relatedItems/{item_id} | Related items (specific item)
[**SetupBrowserKey**](CheckoutApi.md#setupbrowserkey) | **PUT** /checkout/browser_key | Setup Browser Application
[**UpdateCart**](CheckoutApi.md#updatecart) | **PUT** /checkout/cart | Update cart
[**ValidateCart**](CheckoutApi.md#validatecart) | **POST** /checkout/cart/validate | Validate



## CityState

> CityStateZip CityState (Cart cart)

City/State for Zip

Look up the city and state for the shipping zip code.  Useful for building an auto complete for parts of the shipping address 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.checkout
{
    public class CityState
    {
        /// <summary>
        /// Takes a postal code and returns back a city and state (US Only)
        /// </summary>
        public static void Execute()
        {
            // Reference Implementation: https://github.com/UltraCart/responsive_checkout
            // Takes a postal code and returns back a city and state (US Only)

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);

            String cartId = "123456789123456789123456789123456789";  // you should have the cart id from session or cookie.
            Cart cart = new Cart();
            cart.CartId = cartId; // required
            cart.Shipping = new CartShipping();
            cart.Shipping.PostalCode = "44233";

            CityStateZip apiResponse = checkoutApi.CityState(cart);
            Console.WriteLine("City: " + apiResponse.City);
            Console.WriteLine("State: " + apiResponse.State);
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


## FinalizeOrder

> CartFinalizeOrderResponse FinalizeOrder (CartFinalizeOrderRequest finalizeRequest)

Finalize Order

Finalize the cart into an order.  This method can not be called with browser key authentication.  It is ONLY meant for server side code to call. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.checkout
{
    public class FinalizeOrder
    {
        /// <summary>
        /// Finalizes an order from a cart
        /// </summary>
        public static void Execute()
        {
            // Reference Implementation: https://github.com/UltraCart/responsive_checkout

            // Note: You probably should NOT be using this method.  Use handoffCart() instead.
            // This method is a server-side only (no browser key allowed) method for turning a cart into an order.
            // It exists for merchants who wish to provide their own upsells, but again, a warning, using this method
            // will exclude the customer checkout from a vast and powerful suite of functionality provided free by UltraCart.
            // Still, some merchants need this functionality, so here it is.  If you're unsure, you don't need it.  Use handoff.

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);

            String expansion = "customer_profile,items,billing,shipping,coupons,checkout,payment,summary,taxes"; //
            // Possible Expansion Variables: (see https://www.ultracart.com/api/#resource_checkout.html
            /*
            affiliate                   checkout                            customer_profile
            billing                     coupons                             gift
            gift_certificate            items.attributes                   items.multimedia
            items                       items.multimedia.thumbnails         items.physical
            marketing                   payment                                settings.gift
            settings.billing.provinces  settings.shipping.deliver_on_date   settings.shipping.estimates
            settings.shipping.provinces settings.shipping.ship_on_date     settings.taxes
            settings.terms              shipping                           taxes
            summary                     upsell_after
             */

            String cartId = "123456789123456789123456789123456789"; // get the cart id from session or cookie.  beyond this sample scope.
            
            CartResponse cartResponse = checkoutApi.GetCartByCartId(cartId, expansion);
            Cart cart = cartResponse.Cart;

            // TODO - add some items, collect billing and shipping, use hosted fields to collect payment, etc.

            CartFinalizeOrderRequest finalizeRequest = new CartFinalizeOrderRequest();
            finalizeRequest.Cart = cart;
            CartFinalizeOrderRequestOptions finalizeOptions = new CartFinalizeOrderRequestOptions(); // Lots of options here.  Contact support if you're unsure what you need.
            finalizeRequest.Options = finalizeOptions;

            CartFinalizeOrderResponse orderResponse = checkoutApi.FinalizeOrder(finalizeRequest);
            // orderResponse.Successful;
            // orderResponse.Errors;
            // orderResponse.OrderId;
            // orderResponse.Order;


            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(orderResponse, Newtonsoft.Json.Formatting.Indented));

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


## GetAffirmCheckout

> CartAffirmCheckoutResponse GetAffirmCheckout (string cartId)

Get affirm checkout (by cart id)

Get a Affirm checkout object for the specified cart_id parameter. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.checkout
{
    public class GetAffirmCheckout
    {
        /// <summary>
        /// For a given cart id (the cart should be fully updated in UltraCart), returns back the json object
        /// needed to proceed with an Affirm checkout.
        /// </summary>
        public static void Execute()
        {
            // Reference Implementation: https://github.com/UltraCart/responsive_checkout
            // For a given cart id (the cart should be fully updated in UltraCart), returns back the json object
            // needed to proceed with an Affirm checkout.  See https://www.affirm.com/ for details about Affirm.
            // This sample does not show the construction of the affirm checkout widgets.  See the affirm api for those examples.

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);
            String cartId = "123456789123456789123456789123456789"; // this should be retrieved from a session or cookie
            CartAffirmCheckoutResponse apiResponse = checkoutApi.GetAffirmCheckout(cartId);
            if (apiResponse.Errors != null && apiResponse.Errors.Count > 0)
            {
                // TODO: display errors to customer about the failure
                foreach (String error in apiResponse.Errors)
                {
                    Console.WriteLine(error);
                }
            }
            else
            {
                Console.WriteLine(apiResponse.CheckoutJson); // this is the object to send to Affirm.
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


## GetAllowedCountries

> CheckoutAllowedCountriesResponse GetAllowedCountries ()

Allowed countries

Lookup the allowed countries for this merchant id 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using Newtonsoft.Json;

namespace SdkSample.checkout
{
    public class GetAllowedCountries
    {
        /// <summary>
        /// A simple method for populating the country list boxes with all the countries this merchant has configured to accept.
        /// </summary>
        public static void Execute()
        {
            // Reference Implementation: https://github.com/UltraCart/responsive_checkout
            // A simple method for populating the country list boxes with all the countries this merchant has configured to accept.

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);

            CheckoutAllowedCountriesResponse apiResponse = checkoutApi.GetAllowedCountries();
            List<Country> allowedCountries = apiResponse.Countries;

            foreach (Country country in allowedCountries)
            {
                Console.WriteLine(JsonConvert.SerializeObject(country, new JsonSerializerSettings { Formatting = Formatting.Indented}));
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


## GetCart

> CartResponse GetCart (string expand = null)

Get cart

If the cookie is set on the browser making the request then it will return their active cart.  Otherwise it will create a new cart. 


### Example

```csharp
using System;
using System.Web;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using RestSharp;

namespace SdkSample.checkout
{
    public class GetCart
    {
        /// <summary>
        /// Retrieves a cart either by creating a new one or getting an existing one by cart ID
        /// </summary>
        public static void Execute()
        {
            // Reference Implementation: https://github.com/UltraCart/responsive_checkout

            // this example is the same for both getCart.php and getCartByCartId.php.  They work as a pair and are called
            // depending on the presence of an existing cart id or not.  For new carts, getCart() is used.  For existing
            // carts, getCartByCartId($cart_id) is used.

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);

            string expansion = "customer_profile,items,billing,shipping,coupons,checkout,payment,summary,taxes"; //
            // Possible Expansion Variables: (see https://www.ultracart.com/api/#resource_checkout.html
            /*
            affiliate                   checkout                            customer_profile
            billing                     coupons                             gift
            gift_certificate            items.attributes                   items.multimedia
            items                       items.multimedia.thumbnails         items.physical
            marketing                   payment                                settings.gift
            settings.billing.provinces  settings.shipping.deliver_on_date   settings.shipping.estimates
            settings.shipping.provinces settings.shipping.ship_on_date     settings.taxes
            settings.terms              shipping                           taxes
            summary                     upsell_after
             */

            string cartId = null; // no cart id yet.  GetCart will return a new cart.
            CartResponse apiResponse = checkoutApi.GetCart(expansion);
            Cart cart  = apiResponse.Cart;

            // TODO: set or re-set the cart cookie if this is part of a multi-page process. two weeks is a generous cart id time.
            HttpCookie cookie = new HttpCookie(Constants.CartIdCookieName);
            cookie.Value = cart.CartId;
            cookie.Expires = DateTime.Now.AddDays(14); // 1209600 seconds = 14 days
            cookie.Path = "/";
            // HttpContext.Current.Response.Cookies.Add(cookie);

            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(cart, Newtonsoft.Json.Formatting.Indented));
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


## GetCartByCartId

> CartResponse GetCartByCartId (string cartId, string expand = null)

Get cart (by cart id)

Get a cart specified by the cart_id parameter. 


### Example

```csharp
using System;
using System.Web;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using RestSharp;

namespace SdkSample.checkout
{
    public class GetCartByCartId
    {
        /// <summary>
        /// Retrieves a cart either by creating a new one or getting an existing one by cart ID
        /// </summary>
        public static void Execute()
        {
            // Reference Implementation: https://github.com/UltraCart/responsive_checkout

            // this example is the same for both getCart.php and getCartByCartId.php.  They work as a pair and are called
            // depending on the presence of an existing cart id or not.  For new carts, getCart() is used.  For existing
            // carts, getCartByCartId($cart_id) is used.

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);

            String expansion = "items"; // for this example, we're just getting a cart to insert some items into it.

            String cartId = "123456780123456780123456780123456780"; // get from session or cookie.
            CartResponse apiResponse = checkoutApi.GetCartByCartId(cartId, expansion);
            Cart cart = apiResponse.Cart;

            // TODO: set or re-set the cart cookie if this is part of a multi-page process. two weeks is a generous cart id time.
            HttpCookie cookie = new HttpCookie(Constants.CartIdCookieName);
            cookie.Value = cart.CartId;
            cookie.Expires = DateTime.Now.AddDays(14); // 1209600 seconds = 14 days
            cookie.Path = "/";
            // HttpContext.Current.Response.Cookies.Add(cookie);

            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(cart, Newtonsoft.Json.Formatting.Indented));
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


## GetCartByReturnCode

> CartResponse GetCartByReturnCode (string returnCode, string expand = null)

Get cart (by return code)

Get a cart specified by the return code parameter. 


### Example

```csharp
using System;
using System.Web;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using RestSharp;

namespace SdkSample.checkout
{
    public class GetCartByReturnCode
    {
        /// <summary>
        /// Retrieves a cart using a return code
        /// </summary>
        public static void Execute()
        {
            // Reference Implementation: https://github.com/UltraCart/responsive_checkout

            // this example returns a shopping cart given a return_code.  The return_code is generated by UltraCart
            // and usually emailed to a customer.  The email will provide a link to this script where you may use the
            // return_code to retrieve the customer's cart.

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);

            String expansion = "items,billing,shipping,coupons,checkout,payment,summary,taxes"; //
            // Possible Expansion Variables: (see https://www.ultracart.com/api/#resource_checkout.html
            /*
            affiliate                   checkout                            customer_profile
            billing                     coupons                             gift
            gift_certificate            items.attributes                   items.multimedia
            items                       items.multimedia.thumbnails         items.physical
            marketing                   payment                                settings.gift
            settings.billing.provinces  settings.shipping.deliver_on_date   settings.shipping.estimates
            settings.shipping.provinces settings.shipping.ship_on_date     settings.taxes
            settings.terms              shipping                           taxes
            summary                     upsell_after
             */

            String returnCode = "1234567890"; // usually retrieved from a query parameter
            CartResponse apiResponse = checkoutApi.GetCartByReturnCode(returnCode, expansion);
            Cart cart = apiResponse.Cart;

            // TODO: set or re-set the cart cookie if this is part of a multi-page process. two weeks is a generous cart id time.
            HttpCookie cookie = new HttpCookie(Constants.CartIdCookieName);
            cookie.Value = cart.CartId;
            cookie.Expires = DateTime.Now.AddDays(14); // 1209600 seconds = 14 days
            cookie.Path = "/";
            // HttpContext.Current.Response.Cookies.Add(cookie);

            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(cart, Newtonsoft.Json.Formatting.Indented));
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


## GetCartByReturnToken

> CartResponse GetCartByReturnToken (string returnToken = null, string expand = null)

Get cart (by return token)

Get a cart specified by the encrypted return token parameter. 


### Example

```csharp
using System;
using System.Web;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using RestSharp;

namespace SdkSample.checkout
{
    public class GetCartByReturnToken
    {
        /// <summary>
        /// Retrieves a cart using a return token
        /// </summary>
        public static void Execute()
        {
            // Reference Implementation: https://github.com/UltraCart/responsive_checkout

            // this example returns a shopping cart given a return_token.  The return token is generated by StoreFront Communications
            // and usually emailed to a customer.  The link within the email will (when you configure your storefront communications)
            // provide a link to this script where you may use the token to retrieve the customer's cart.

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);

            String expansion = "items,billing,shipping,coupons,checkout,payment,summary,taxes"; //
            // Possible Expansion Variables: (see https://www.ultracart.com/api/#resource_checkout.html
            /*
            affiliate                   checkout                            customer_profile
            billing                     coupons                             gift
            gift_certificate            items.attributes                   items.multimedia
            items                       items.multimedia.thumbnails         items.physical
            marketing                   payment                                settings.gift
            settings.billing.provinces  settings.shipping.deliver_on_date   settings.shipping.estimates
            settings.shipping.provinces settings.shipping.ship_on_date     settings.taxes
            settings.terms              shipping                           taxes
            summary                     upsell_after
             */

            String cartToken = "1234567890"; // usually retrieved from a query parameter
            CartResponse apiResponse = checkoutApi.GetCartByReturnToken(cartToken, expansion);
            Cart cart = apiResponse.Cart;

            // TODO: set or re-set the cart cookie if this is part of a multi-page process. two weeks is a generous cart id time.
            HttpCookie cookie = new HttpCookie(Constants.CartIdCookieName);
            cookie.Value = cart.CartId;
            cookie.Expires = DateTime.Now.AddDays(14); // 1209600 seconds = 14 days
            cookie.Path = "/";
            // HttpContext.Current.Response.Cookies.Add(cookie);

            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(cart, Newtonsoft.Json.Formatting.Indented));
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnToken** | **string**| Return token provided by StoreFront Communications | [optional] 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CartResponse**](CartResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

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


## GetStateProvincesForCountry

> CheckoutStateProvinceResponse GetStateProvincesForCountry (string countryCode)

Get state/province list for a country code

Lookup a state/province list for a given country code 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using Newtonsoft.Json;

namespace SdkSample.checkout
{
    public class GetStateProvincesForCountry
    {
        /// <summary>
        /// A simple method for populating the state_region list boxes with all the states/regions allowed for a country code.
        /// </summary>
        public static void Execute()
        {
            // Reference Implementation: https://github.com/UltraCart/responsive_checkout
            // A simple method for populating the state_region list boxes with all the states/regions allowed for a country code.

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);

            String countryCode = "US";

            CheckoutStateProvinceResponse apiResponse = checkoutApi.GetStateProvincesForCountry(countryCode);
            List<StateProvince> provinces = apiResponse.StateProvinces;

            foreach (StateProvince province in provinces)
            {
                Console.WriteLine(JsonConvert.SerializeObject(province,
                    new JsonSerializerSettings { Formatting = Formatting.Indented }));
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


## HandoffCart

> CheckoutHandoffResponse HandoffCart (CheckoutHandoffRequest handoffRequest, string expand = null)

Handoff cart

Handoff the browser to UltraCart for view cart on StoreFront, transfer to PayPal, transfer to Affirm, transfer to Sezzle or finalization of the order (including upsell processing). 


### Example

```csharp
using System;
using System.Web;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.checkout
{
    public class HandoffCart
    {
        /// <summary>
        /// Hands off a cart to the UltraCart engine for further processing
        /// </summary>
        public static void Execute()
        {
            // Reference Implementation: https://github.com/UltraCart/responsive_checkout

            // this example uses the getCart.php code as a starting point, because we must get a cart to handoff a cart.
            // here, we are handing off the cart to the ultracart engine with an operation of 'view', meaning that we
            // simply added some items to the cart and wish for UltraCart to gather the remaining customer information
            // as part of a normal checkout operation.
            // valid operations are: "view", "checkout", "paypal", "paypalcredit", "affirm", "sezzle"
            // Besides "view", the other operations are finalizers.
            // "checkout": finalize the transaction using a customer's personal credit card (traditional checkout)
            // "paypal": finalize the transaction by sending the customer to PayPal

            // getCart.php code start ----------------------------------------------------------------------------

            // this example is the same for both getCart.php and getCartByCartId.php.  They work as a pair and are called
            // depending on the presence of an existing cart id or not.  For new carts, getCart() is used.  For existing
            // carts, getCartByCartId($cart_id) is used.

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);

            String expansion = "items"; // for this example, we're just getting a cart to insert some items into it.

            String cartId = null;
            // get the cartId from session or cookie.
            // if (HttpContext.Current.Request.Cookies[Constants.CART_ID_COOKIE_NAME] != null)
            // {
            //     cartId = HttpContext.Current.Request.Cookies[Constants.CART_ID_COOKIE_NAME].Value;
            // }

            Cart cart = null;
            CartResponse apiResponse;
            if (cartId == null)
            {
                apiResponse = checkoutApi.GetCart(expansion);
            }
            else
            {
                apiResponse = checkoutApi.GetCartByCartId(cartId, expansion);
            }
            cart = apiResponse.Cart;

            // getCart.php code end ----------------------------------------------------------------------------


            // Although the above code checks for a cookie and retrieves or creates a cart based on the cookie presence, typically
            // a php script calling the handoff() method will have an existing cart, so you may wish to check for a cookie and
            // redirect if there isn't one.  However, it is possible that you wish to create a cart, update it, and hand it off
            // to UltraCart all within one script, so we've left the conditional cart creation calls intact.

            CheckoutHandoffRequest handoffRequest = new CheckoutHandoffRequest();
            handoffRequest.Cart = cart;
            handoffRequest.Operation = CheckoutHandoffRequest.OperationEnum.View;
            handoffRequest.ErrorReturnUrl = "/some/page/on/this/php/server/that/can/handle/errors/if/ultracart/encounters/an/issue/with/this/cart.php";
            handoffRequest.ErrorParameterName = "uc_error"; // name this whatever the script supplied in ->setErrorReturnUrl() will check for in the $_GET object.
            handoffRequest.SecureHostName = "mystorefront.com"; // set to desired storefront.  some merchants have multiple storefronts.
            CheckoutHandoffResponse handoffResponse = checkoutApi.HandoffCart(handoffRequest, expansion);


            if (handoffResponse.Errors != null && handoffResponse.Errors.Count > 0)
            {
                // TODO: handle errors that might happen before handoff and manage those
            }
            else
            {
                String redirectUrl = handoffResponse.RedirectToUrl;
                Console.WriteLine(redirectUrl);
                // Issue the redirect to the customer.
                // HttpContext.Current.Response.Redirect(redirectUrl);
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


## Login

> CartProfileLoginResponse Login (CartProfileLoginRequest loginRequest, string expand = null)

Profile login

Login in to the customer profile specified by cart.billing.email and password 


### Example

```csharp
using System;
using System.Linq;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.checkout
{
    public class Login
    {
        public static void Execute()
        {
            // Reference Implementation: https://github.com/UltraCart/responsive_checkout

            // This example logs a user into the UltraCart system.
            // This example assumes you already have a shopping cart object created.
            // For new carts, getCart() is used.  For existing carts, getCartByCartId(cart_id) is used.

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);

            // Note: customer_profile is a required expansion for login to work properly
            string expansion = "customer_profile,items,billing,shipping,coupons,checkout,payment,summary,taxes";
            // Possible Expansion Variables: (see https://www.ultracart.com/api/#resource_checkout.html

            // create a new cart (change this to an existing if you have one)
            Cart cart = checkoutApi.GetCart(expansion).Cart;

            string email = "test@test.com"; // collect this from user.
            string password = "ABC123"; // collect this from user.

            cart.Billing = new CartBilling();
            cart.Billing.Email = email;

            CartProfileLoginRequest loginRequest = new CartProfileLoginRequest();
            loginRequest.Cart = cart; // will look for billing.email
            loginRequest.Password = password;

            CartProfileLoginResponse apiResponse = checkoutApi.Login(loginRequest);
            // Store the updated cart variable.
            cart = apiResponse.Cart;

            if (apiResponse.Errors?.Any() == true)
            {
                // notify customer login failed.
            }
            else
            {
                // proceed with successful login.                
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


## Logout

> CartResponse Logout (Cart cart, string expand = null)

Profile logout

Log the cart out of the current profile.  No error will occur if they are not logged in. 


### Example

```csharp
using System;
using System.Linq;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.checkout
{
    public class Logout
    {
        public static void Execute()
        {
            // Reference Implementation: https://github.com/UltraCart/responsive_checkout

            // This example logs a user OUT of the UltraCart system.
            //  It assumes the shopping cart has already had a successful login.
            // see login sdk_sample for logging in help.
            // For new carts, getCart() is used.  For existing carts, getCartByCartId(cart_id) is used.

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);

            // Note: customer_profile is a required expansion for login to work properly
            string expansion = "customer_profile,items,billing,shipping,coupons,checkout,payment,summary,taxes";
            // Possible Expansion Variables: (see https://www.ultracart.com/api/#resource_checkout.html

            // create a new cart (change this to an existing if you have one)
            Cart cart = checkoutApi.GetCart(expansion).Cart;

            string email = "test@test.com"; // collect this from user.
            string password = "ABC123"; // collect this from user.

            cart.Billing = new CartBilling();
            cart.Billing.Email = email;

            CartProfileLoginRequest loginRequest = new CartProfileLoginRequest();
            loginRequest.Cart = cart; // will look for billing.email
            loginRequest.Password = password;

            CartProfileLoginResponse apiResponse = checkoutApi.Login(loginRequest);
            cart = apiResponse.Cart;

            if (apiResponse.Errors?.Any() == true)
            {
                // notify customer login failed. Until they login, you can't logout.
            }
            else
            {
                checkoutApi.Logout(cart, expansion); // <-- Here is the logout call.                
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


## Register

> CartProfileRegisterResponse Register (CartProfileRegisterRequest registerRequest, string expand = null)

Profile registration

Register a new customer profile.  Requires the cart.billing object to be populated along with the password. 


### Example

```csharp
using System;
using System.Linq;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.checkout
{
    public class Register
    {
        public static void Execute()
        {
            // Reference Implementation: https://github.com/UltraCart/responsive_checkout

            // Registers a user in your merchant system.  This will create a customer profile.
            // For new carts, getCart() is used.  For existing carts, getCartByCartId(cart_id) is used.

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);

            // Note: customer_profile is a required expansion for login to work properly
            string expansion = "customer_profile,items,billing,shipping,coupons,checkout,payment,summary,taxes";
            // Possible Expansion Variables: (see https://www.ultracart.com/api/#resource_checkout.html

            // create a new cart (change this to an existing if you have one)
            Cart cart = checkoutApi.GetCart(expansion).Cart;

            string email = "test@test.com"; // collect this from user.
            string password = "ABC123"; // collect this from user.

            cart.Billing = new CartBilling();
            cart.Billing.Email = email; // this is the username.

            CartProfileRegisterRequest registerRequest = new CartProfileRegisterRequest();
            registerRequest.Cart = cart; // will look for billing.email
            registerRequest.Password = password;

            CartProfileRegisterResponse apiResponse = checkoutApi.Register(registerRequest);
            cart = apiResponse.Cart; // Important!  Get the cart from the response.

            if (apiResponse.Errors?.Any() == true)
            {
                foreach (string error in apiResponse.Errors)
                {
                    Console.WriteLine(error);
                }
            }
            else
            {
                Console.WriteLine("Successfully registered new customer profile!");
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


## RegisterAffiliateClick

> RegisterAffiliateClickResponse RegisterAffiliateClick (RegisterAffiliateClickRequest registerAffiliateClickRequest, string expand = null)

Register affiliate click

Register an affiliate click.  Used by custom checkouts that are completely API based and do not perform checkout handoff. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.checkout
{
    public class RegisterAffiliateClick
    {
        public static void Execute()
        {
            // Reference Implementation: https://github.com/UltraCart/responsive_checkout
            // Records an affiliate click.

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);

            RegisterAffiliateClickRequest clickRequest = new RegisterAffiliateClickRequest();
            
            // Note: In C#, you'll need to get these values from your HttpContext
            // This is a simplified example - implement proper request handling in your application
            string ipAddress = "127.0.0.1"; // Replace with actual implementation to get IP
            string userAgent = ""; // Replace with actual implementation to get user agent
            string refererUrl = ""; // Replace with actual implementation to get referer URL
            
            clickRequest.IpAddress = ipAddress;
            clickRequest.UserAgent = userAgent;
            clickRequest.ReferrerUrl = refererUrl;
            clickRequest.Affid = 123456789; // you should know this from your UltraCart affiliate system.
            clickRequest.Subid = "TODO:SupplyThisValue";
            // clickRequest.LandingPageUrl = null;  // if you have landing page url.

            RegisterAffiliateClickResponse apiResponse = checkoutApi.RegisterAffiliateClick(clickRequest);
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(apiResponse, Newtonsoft.Json.Formatting.Indented));
            
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registerAffiliateClickRequest** | [**RegisterAffiliateClickRequest**](RegisterAffiliateClickRequest.md)| Register affiliate click request | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**RegisterAffiliateClickResponse**](RegisterAffiliateClickResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

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


## RelatedItemsForCart

> ItemsResponse RelatedItemsForCart (Cart cart, string expand = null)

Related items

Retrieve all the related items for the cart contents.  Expansion is limited to content, content.assignments, content.attributes, content.multimedia, content.multimedia.thumbnails, options, pricing, and pricing.tiers. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.checkout
{
    public class RelatedItemsForCart
    {
        public static void Execute()
        {
            // Reference Implementation: https://github.com/UltraCart/responsive_checkout

            // Retrieves items related to the items within the cart.  Item relations are configured in the UltraCart backend.
            // See: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1377171/Related+Items

            // Note: The returned items have a fixed expansion (only so many item properties are returned).  The item expansion is:
            // content, content.assignments, content.attributes, content.multimedia, content.multimedia.thumbnails, options, pricing, and pricing.tiers

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);

            string expansion = "customer_profile,items,billing,shipping,coupons,checkout,payment,summary,taxes"; //
            // Possible Expansion Variables: (see https://www.ultracart.com/api/#resource_checkout.html
            /*
            affiliate                   checkout                            customer_profile
            billing                     coupons                             gift
            gift_certificate            items.attributes                   items.multimedia
            items                       items.multimedia.thumbnails         items.physical
            marketing                   payment                                settings.gift
            settings.billing.provinces  settings.shipping.deliver_on_date   settings.shipping.estimates
            settings.shipping.provinces settings.shipping.ship_on_date     settings.taxes
            settings.terms              shipping                           taxes
            summary                     upsell_after
             */

            // In C# web application, you'd get the cookie from HttpContext
            string cartId = null;
            // Example of how you might get the cookie in ASP.NET
            // if (HttpContext.Current.Request.Cookies[Constants.CART_ID_COOKIE_NAME] != null)
            // {
            //     cartId = HttpContext.Current.Request.Cookies[Constants.CART_ID_COOKIE_NAME].Value;
            // }

            Cart cart = null;
            if (cartId == null)
            {
                CartResponse apiResponse = checkoutApi.GetCart(expansion);
                cart = apiResponse.Cart;
            }
            else
            {
                CartResponse apiResponse = checkoutApi.GetCartByCartId(cartId, expansion);
                cart = apiResponse.Cart;
            }

            // TODO - add some items to the cart and update.

            List<CartItem> items = new List<CartItem>();
            CartItem cartItem = new CartItem();
            cartItem.ItemId = "ITEM_ABC";
            cartItem.Quantity = 1;
            items.Add(cartItem);
            cart.Items = items;

            // update the cart and assign it back to our variable.
            cart = checkoutApi.UpdateCart(cart, expansion).Cart;

            ItemsResponse apiResponse2 = checkoutApi.RelatedItemsForCart(cart);
            List<Item> relatedItems = apiResponse2.Items;

            Console.WriteLine("<html lang=\"en\"><body><pre>");
            foreach (Item item in relatedItems)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("</pre></body></html>");
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


## RelatedItemsForItem

> ItemsResponse RelatedItemsForItem (string itemId, Cart cart, string expand = null)

Related items (specific item)

Retrieve all the related items for the cart contents.  Expansion is limited to content, content.assignments, content.attributes, content.multimedia, content.multimedia.thumbnails, options, pricing, and pricing.tiers. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.checkout
{
    public class RelatedItemsForItem
    {
        public static void Execute()
        {
            // Reference Implementation: https://github.com/UltraCart/responsive_checkout

            // Retrieves items related to the items within the cart, in addition to another item id you supply.
            // Item relations are configured in the UltraCart backend.
            // See: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1377171/Related+Items

            // Note: The returned items have a fixed expansion (only so many item properties are returned).  The item expansion is:
            // content, content.assignments, content.attributes, content.multimedia, content.multimedia.thumbnails, options, pricing, and pricing.tiers

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);

            string expansion = "customer_profile,items,billing,shipping,coupons,checkout,payment,summary,taxes"; //
            // Possible Expansion Variables: (see https://www.ultracart.com/api/#resource_checkout.html
            /*
            affiliate                   checkout                            customer_profile
            billing                     coupons                             gift
            gift_certificate            items.attributes                   items.multimedia
            items                       items.multimedia.thumbnails         items.physical
            marketing                   payment                                settings.gift
            settings.billing.provinces  settings.shipping.deliver_on_date   settings.shipping.estimates
            settings.shipping.provinces settings.shipping.ship_on_date     settings.taxes
            settings.terms              shipping                           taxes
            summary                     upsell_after
             */

            // In C# web application, you'd get the cookie from HttpContext
            string cartId = null;
            // Example of how you might get the cookie in ASP.NET
            // if (HttpContext.Current.Request.Cookies[Constants.CART_ID_COOKIE_NAME] != null)
            // {
            //     cartId = HttpContext.Current.Request.Cookies[Constants.CART_ID_COOKIE_NAME].Value;
            // }

            Cart cart = null;
            if (cartId == null)
            {
                CartResponse apiResponse = checkoutApi.GetCart(expansion);
                cart = apiResponse.Cart;
            }
            else
            {
                CartResponse apiResponse = checkoutApi.GetCartByCartId(cartId, expansion);
                cart = apiResponse.Cart;
            }

            // TODO - add some items to the cart and update.

            List<CartItem> items = new List<CartItem>();
            CartItem cartItem = new CartItem();
            cartItem.ItemId = "ITEM_ABC";
            cartItem.Quantity = 1;
            items.Add(cartItem);
            cart.Items = items;

            // update the cart and assign it back to our variable.
            cart = checkoutApi.UpdateCart(cart, expansion).Cart;

            string anotherItemId = "ITEM_ZZZ";

            ItemsResponse apiResponse2 = checkoutApi.RelatedItemsForItem(anotherItemId, cart, expansion);
            List<Item> relatedItems = apiResponse2.Items;

            Console.WriteLine("<html lang=\"en\"><body><pre>");
            foreach (Item item in relatedItems)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("</pre></body></html>");
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


## SetupBrowserKey

> CheckoutSetupBrowserKeyResponse SetupBrowserKey (CheckoutSetupBrowserKeyRequest browserKeyRequest)

Setup Browser Application

Setup a browser key authenticated application with checkout permissions.  This REST call must be made with an authentication scheme that is not browser key.  The new application will be linked to the application that makes this call.  If this application is disabled / deleted, then so will the application setup by this call.  The purpose of this call is to allow an OAuth application, such as the Wordpress plugin, to setup the proper browser based authentication for the REST checkout API to use. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.checkout
{
    public class SetupBrowserKey
    {
        public static void Execute()
        {
            /*
                This is a checkout api method.  It creates a browser key for use in a client side checkout.  This call must be
                made server side with a Simple API Key or an OAuth access_token.
             */

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);

            CheckoutSetupBrowserKeyRequest keyRequest = new CheckoutSetupBrowserKeyRequest();
            keyRequest.AllowedReferrers = new List<string> { "https://www.mywebsite.com" };
            string browserKey = checkoutApi.SetupBrowserKey(keyRequest).BrowserKey;

            Console.WriteLine("<html lang=\"en\"><body><pre>");
            Console.WriteLine(browserKey);
            Console.WriteLine("</pre></body></html>");
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


## UpdateCart

> CartResponse UpdateCart (Cart cart, string expand = null)

Update cart

Update the cart. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.checkout
{
    public class UpdateCart
    {
        public static void Execute()
        {
            // Reference Implementation: https://github.com/UltraCart/responsive_checkout

            // this example uses the getCart.php code as a starting point, because we must get a cart to update a cart.
            // getCart.php code start ----------------------------------------------------------------------------
            // this example is the same for both getCart.php and getCartByCartId.php.  They work as a pair and are called
            // depending on the presence of an existing cart id or not.  For new carts, getCart() is used.  For existing
            // carts, getCartByCartId(cart_id) is used.

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);

            string expansion = "items"; // for this example, we're just getting a cart to insert some items into it.

            // In C# web applications, you'd retrieve the cookie from the HttpContext
            string cartId = null;
            // Example of how you might retrieve a cookie in ASP.NET:
            // if (HttpContext.Current.Request.Cookies[Constants.CART_ID_COOKIE_NAME] != null)
            // {
            //     cartId = HttpContext.Current.Request.Cookies[Constants.CART_ID_COOKIE_NAME].Value;
            // }

            Cart cart = null;
            if (cartId == null)
            {
                CartResponse apiResponse = checkoutApi.GetCart(expansion);
                cart = apiResponse.Cart;
            }
            else
            {
                CartResponse apiResponse = checkoutApi.GetCartByCartId(cartId, expansion);
                cart = apiResponse.Cart;
            }

            // getCart.php code end ----------------------------------------------------------------------------

            // for this simple example, items will be added to the cart.  so our expansion variable is simply 'items' above.
            // Get the items array on the cart, creating it if it doesn't exist.
            List<CartItem> items = cart.Items;
            // If null, go ahead and initialize it to an empty list
            if (items == null)
            {
                items = new List<CartItem>();
            }

            // Create a new item
            CartItem item = new CartItem();
            item.ItemId = "BASEBALL"; // TODO: Adjust the item id
            item.Quantity = 1; // TODO: Adjust the quantity

            // TODO: If your item has options then you need to create a new CartItemOption object and add it to the list.
            List<CartItemOption> options = new List<CartItemOption>();
            item.Options = options;

            // Add the item to the items list
            items.Add(item);

            // Make sure to update the cart with the new list
            cart.Items = items;

            // Push the cart up to save the item
            CartResponse cartResponse = checkoutApi.UpdateCart(cart, expansion);

            // Extract the updated cart from the response
            cart = cartResponse.Cart;

            // TODO: set or re-set the cart cookie if this is part of a multi-page process. two weeks is a generous cart id time.
            // Example of how you might set a cookie in ASP.NET:
            // HttpCookie cookie = new HttpCookie(Constants.CART_ID_COOKIE_NAME);
            // cookie.Value = cart.CartId;
            // cookie.Expires = DateTime.Now.AddDays(14); // 2 weeks
            // cookie.Path = "/";
            // HttpContext.Current.Response.Cookies.Add(cookie);

            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(cart, Newtonsoft.Json.Formatting.Indented));
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


## ValidateCart

> CartValidationResponse ValidateCart (CartValidationRequest validationRequest, string expand = null)

Validate

Validate the cart for errors.  Specific checks can be passed and multiple validations can occur throughout your checkout flow. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.checkout
{
    public class ValidateCart
    {
        public static void Execute()
        {
            /*
                This is a checkout api method.  It can be used both server side or client side.  This example is a server side
                call using a Simple API Key.  See the JavaScript sdk samples if you wish to see a browser key implementation.

                validateCart passes a shopping cart to UltraCart for validation.
             */

            CheckoutApi checkoutApi = new CheckoutApi(Constants.ApiKey);
            string cartId = "123456789123456789123456789123456789"; // usually this would be retrieved from a session variable or cookie.

            string expansion = "items,billing,shipping,coupons,checkout,payment,summary,taxes"; //
            // Possible Expansion Variables: (see https://www.ultracart.com/api/#resource_checkout.html) also see getCart() example


            Cart cart = checkoutApi.GetCartByCartId(cartId, expansion).Cart;

            CartValidationRequest validationRequest = new CartValidationRequest();
            validationRequest.Cart = cart;
            // validationRequest.Checks = null; // leave this null for all validations
            // Possible Checks
            /*
            All,Advertising Source Provided,Billing Address Provided,
            Billing Destination Restriction,Billing Phone Numbers Provided,Billing State Abbreviation Valid,Billing Validate City State Zip,
            Coupon Zip Code Restriction,Credit Card Shipping Method Conflict,Customer Profile Does Not Exist.,CVV2 Not Required,
            Electronic Check Confirm Account Number,Email confirmed,Email provided if required,Gift Message Length,Item Quantity Valid,
            Item Restrictions,Items Present,Merchant Specific Item Relationships,One per customer violations,Options Provided,
            Payment Information Validate,Payment Method Provided,Payment Method Restriction,Pricing Tier Limits,Quantity requirements met,
            Referral Code Provided,Shipping Address Provided,Shipping Destination Restriction,Shipping Method Provided,
            Shipping Needs Recalculation,Shipping State Abbreviation Valid,Shipping Validate City State Zip,Special Instructions Length,
            Tax County Specified,Valid Delivery Date,Valid Ship On Date,Auth Test Credit Card
             */

            // This method also does an update in the process, so pass in a good expansion and grab the return cart variable.
            CartValidationResponse apiResponse = checkoutApi.ValidateCart(validationRequest, expansion);
            cart = apiResponse.Cart;

            Console.WriteLine("<html lang=\"en\"><body><pre>");
            Console.WriteLine("Validation Errors:");
            if (apiResponse.Errors != null)
            {
                foreach (string error in apiResponse.Errors)
                {
                    Console.WriteLine(error);
                }
            }
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(cart, Newtonsoft.Json.Formatting.Indented));
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

