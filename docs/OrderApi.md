# com.ultracart.admin.v2.Api.OrderApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrderOrdersGet**](OrderApi.md#orderordersget) | **GET** /order/orders | Retrieve orders
[**OrderOrdersOrderIdCancelPost**](OrderApi.md#orderordersorderidcancelpost) | **POST** /order/orders/{order_id}/cancel | Cancel an order
[**OrderOrdersOrderIdDelete**](OrderApi.md#orderordersorderiddelete) | **DELETE** /order/orders/{order_id} | Delete an order
[**OrderOrdersOrderIdGet**](OrderApi.md#orderordersorderidget) | **GET** /order/orders/{order_id} | Retrieve an order
[**OrderOrdersOrderIdPut**](OrderApi.md#orderordersorderidput) | **PUT** /order/orders/{order_id} | Update an order
[**OrderOrdersOrderIdResendReceiptPost**](OrderApi.md#orderordersorderidresendreceiptpost) | **POST** /order/orders/{order_id}/resend_receipt | Resend receipt
[**OrderOrdersOrderIdResendShipmentConfirmationPost**](OrderApi.md#orderordersorderidresendshipmentconfirmationpost) | **POST** /order/orders/{order_id}/resend_shipment_confirmation | Resend shipment confirmation


<a name="orderordersget"></a>
# **OrderOrdersGet**
> OrdersResponse OrderOrdersGet (string orderId = null, string paymentMethod = null, string company = null, string firstName = null, string lastName = null, string city = null, string stateRegion = null, string postalCode = null, string countryCode = null, string phone = null, string email = null, string ccEmail = null, decimal? total = null, string screenBrandingThemeCode = null, string storefrontHostName = null, string creationDateBegin = null, string creationDateEnd = null, string paymentDateBegin = null, string paymentDateEnd = null, string shipmentDateBegin = null, string shipmentDateEnd = null, string rma = null, string purchaseOrderNumber = null, string itemId = null, string currentStage = null, string channelPartnerCode = null, string channelPartnerOrderId = null, int? limit = null, int? offset = null, string sort = null, string expand = null)

Retrieve orders

Retrieves a group of orders from the account.  If no parameters are specified, the API call will fail with a bad request error.  Always specify some parameters to limit the scope of the orders returned to ones you are truly interested in.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class OrderOrdersGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new OrderApi();
            var orderId = orderId_example;  // string | Order Id (optional) 
            var paymentMethod = paymentMethod_example;  // string | Payment Method (optional) 
            var company = company_example;  // string | Company (optional) 
            var firstName = firstName_example;  // string | First Name (optional) 
            var lastName = lastName_example;  // string | Last Name (optional) 
            var city = city_example;  // string | City (optional) 
            var stateRegion = stateRegion_example;  // string | State/Region (optional) 
            var postalCode = postalCode_example;  // string | Postal Code (optional) 
            var countryCode = countryCode_example;  // string | Country Code (ISO-3166 two letter) (optional) 
            var phone = phone_example;  // string | Phone (optional) 
            var email = email_example;  // string | Email (optional) 
            var ccEmail = ccEmail_example;  // string | CC Email (optional) 
            var total = 3.4;  // decimal? | Total (optional) 
            var screenBrandingThemeCode = screenBrandingThemeCode_example;  // string | Screen Branding Theme Code (optional) 
            var storefrontHostName = storefrontHostName_example;  // string | StoreFront Host Name (optional) 
            var creationDateBegin = creationDateBegin_example;  // string | Creation Date Begin (optional) 
            var creationDateEnd = creationDateEnd_example;  // string | Creation Date End (optional) 
            var paymentDateBegin = paymentDateBegin_example;  // string | Payment Date Begin (optional) 
            var paymentDateEnd = paymentDateEnd_example;  // string | Payment Date End (optional) 
            var shipmentDateBegin = shipmentDateBegin_example;  // string | Shipment Date Begin (optional) 
            var shipmentDateEnd = shipmentDateEnd_example;  // string | Shipment Date End (optional) 
            var rma = rma_example;  // string | RMA (optional) 
            var purchaseOrderNumber = purchaseOrderNumber_example;  // string | Purchase Order Number (optional) 
            var itemId = itemId_example;  // string | Item Id (optional) 
            var currentStage = currentStage_example;  // string | Current Stage (optional) 
            var channelPartnerCode = channelPartnerCode_example;  // string | Channel Partner Code (optional) 
            var channelPartnerOrderId = channelPartnerOrderId_example;  // string | Channel Partner Order ID (optional) 
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Maximum 200) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var sort = sort_example;  // string | The sort order of the orders.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 
            var expand = expand_example;  // string | The object expansion to perform on the result. (optional) 

            try
            {
                // Retrieve orders
                OrdersResponse result = apiInstance.OrderOrdersGet(orderId, paymentMethod, company, firstName, lastName, city, stateRegion, postalCode, countryCode, phone, email, ccEmail, total, screenBrandingThemeCode, storefrontHostName, creationDateBegin, creationDateEnd, paymentDateBegin, paymentDateEnd, shipmentDateBegin, shipmentDateEnd, rma, purchaseOrderNumber, itemId, currentStage, channelPartnerCode, channelPartnerOrderId, limit, offset, sort, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderOrdersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| Order Id | [optional] 
 **paymentMethod** | **string**| Payment Method | [optional] 
 **company** | **string**| Company | [optional] 
 **firstName** | **string**| First Name | [optional] 
 **lastName** | **string**| Last Name | [optional] 
 **city** | **string**| City | [optional] 
 **stateRegion** | **string**| State/Region | [optional] 
 **postalCode** | **string**| Postal Code | [optional] 
 **countryCode** | **string**| Country Code (ISO-3166 two letter) | [optional] 
 **phone** | **string**| Phone | [optional] 
 **email** | **string**| Email | [optional] 
 **ccEmail** | **string**| CC Email | [optional] 
 **total** | **decimal?**| Total | [optional] 
 **screenBrandingThemeCode** | **string**| Screen Branding Theme Code | [optional] 
 **storefrontHostName** | **string**| StoreFront Host Name | [optional] 
 **creationDateBegin** | **string**| Creation Date Begin | [optional] 
 **creationDateEnd** | **string**| Creation Date End | [optional] 
 **paymentDateBegin** | **string**| Payment Date Begin | [optional] 
 **paymentDateEnd** | **string**| Payment Date End | [optional] 
 **shipmentDateBegin** | **string**| Shipment Date Begin | [optional] 
 **shipmentDateEnd** | **string**| Shipment Date End | [optional] 
 **rma** | **string**| RMA | [optional] 
 **purchaseOrderNumber** | **string**| Purchase Order Number | [optional] 
 **itemId** | **string**| Item Id | [optional] 
 **currentStage** | **string**| Current Stage | [optional] 
 **channelPartnerCode** | **string**| Channel Partner Code | [optional] 
 **channelPartnerOrderId** | **string**| Channel Partner Order ID | [optional] 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Maximum 200) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **sort** | **string**| The sort order of the orders.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 
 **expand** | **string**| The object expansion to perform on the result. | [optional] 

### Return type

[**OrdersResponse**](OrdersResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderordersorderidcancelpost"></a>
# **OrderOrdersOrderIdCancelPost**
> BaseResponse OrderOrdersOrderIdCancelPost (string orderId)

Cancel an order

Cancel an order on the UltraCart account.  If the success flag is false, then consult the error message for why it failed. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class OrderOrdersOrderIdCancelPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new OrderApi();
            var orderId = orderId_example;  // string | The order id to cancel.

            try
            {
                // Cancel an order
                BaseResponse result = apiInstance.OrderOrdersOrderIdCancelPost(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderOrdersOrderIdCancelPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to cancel. | 

### Return type

[**BaseResponse**](BaseResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderordersorderiddelete"></a>
# **OrderOrdersOrderIdDelete**
> void OrderOrdersOrderIdDelete (string orderId)

Delete an order

Delete an order on the UltraCart account. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class OrderOrdersOrderIdDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new OrderApi();
            var orderId = orderId_example;  // string | The order id to delete.

            try
            {
                // Delete an order
                apiInstance.OrderOrdersOrderIdDelete(orderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderOrdersOrderIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to delete. | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderordersorderidget"></a>
# **OrderOrdersOrderIdGet**
> OrderResponse OrderOrdersOrderIdGet (string orderId, string expand = null)

Retrieve an order

Retrieves a single order using the specified order id. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class OrderOrdersOrderIdGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new OrderApi();
            var orderId = orderId_example;  // string | The order id to retrieve.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve an order
                OrderResponse result = apiInstance.OrderOrdersOrderIdGet(orderId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderOrdersOrderIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**OrderResponse**](OrderResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderordersorderidput"></a>
# **OrderOrdersOrderIdPut**
> OrderResponse OrderOrdersOrderIdPut (Order order, string orderId, string expand = null)

Update an order

Update a new order on the UltraCart account. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class OrderOrdersOrderIdPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new OrderApi();
            var order = new Order(); // Order | Order to update
            var orderId = orderId_example;  // string | The order id to update.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Update an order
                OrderResponse result = apiInstance.OrderOrdersOrderIdPut(order, orderId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderOrdersOrderIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **order** | [**Order**](Order.md)| Order to update | 
 **orderId** | **string**| The order id to update. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**OrderResponse**](OrderResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderordersorderidresendreceiptpost"></a>
# **OrderOrdersOrderIdResendReceiptPost**
> BaseResponse OrderOrdersOrderIdResendReceiptPost (string orderId)

Resend receipt

Resend the receipt for an order on the UltraCart account. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class OrderOrdersOrderIdResendReceiptPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new OrderApi();
            var orderId = orderId_example;  // string | The order id to resend the receipt for.

            try
            {
                // Resend receipt
                BaseResponse result = apiInstance.OrderOrdersOrderIdResendReceiptPost(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderOrdersOrderIdResendReceiptPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to resend the receipt for. | 

### Return type

[**BaseResponse**](BaseResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderordersorderidresendshipmentconfirmationpost"></a>
# **OrderOrdersOrderIdResendShipmentConfirmationPost**
> BaseResponse OrderOrdersOrderIdResendShipmentConfirmationPost (string orderId)

Resend shipment confirmation

Resend shipment confirmation for an order on the UltraCart account. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class OrderOrdersOrderIdResendShipmentConfirmationPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new OrderApi();
            var orderId = orderId_example;  // string | The order id to resend the shipment notification for.

            try
            {
                // Resend shipment confirmation
                BaseResponse result = apiInstance.OrderOrdersOrderIdResendShipmentConfirmationPost(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderOrdersOrderIdResendShipmentConfirmationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to resend the shipment notification for. | 

### Return type

[**BaseResponse**](BaseResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

