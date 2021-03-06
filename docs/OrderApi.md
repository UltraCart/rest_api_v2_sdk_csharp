# com.ultracart.admin.v2.Api.OrderApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdjustOrderTotal**](OrderApi.md#adjustordertotal) | **POST** /order/orders/{order_id}/adjust_order_total/{desired_total} | Adjusts an order total
[**CancelOrder**](OrderApi.md#cancelorder) | **POST** /order/orders/{order_id}/cancel | Cancel an order
[**DeleteOrder**](OrderApi.md#deleteorder) | **DELETE** /order/orders/{order_id} | Delete an order
[**Format**](OrderApi.md#format) | **POST** /order/orders/{order_id}/format | Format order
[**GenerateOrderToken**](OrderApi.md#generateordertoken) | **GET** /order/orders/token/{order_id} | Generate an order token for a given order id
[**GetAccountsReceivableRetryConfig**](OrderApi.md#getaccountsreceivableretryconfig) | **GET** /order/accountsReceivableRetryConfig | Retrieve A/R Retry Configuration
[**GetAccountsReceivableRetryStats**](OrderApi.md#getaccountsreceivableretrystats) | **GET** /order/accountsReceivableRetryConfig/stats | Retrieve A/R Retry Statistics
[**GetOrder**](OrderApi.md#getorder) | **GET** /order/orders/{order_id} | Retrieve an order
[**GetOrderByToken**](OrderApi.md#getorderbytoken) | **POST** /order/orders/token | Retrieve an order using a token
[**GetOrders**](OrderApi.md#getorders) | **GET** /order/orders | Retrieve orders
[**GetOrdersBatch**](OrderApi.md#getordersbatch) | **POST** /order/orders/batch | Retrieve order batch
[**GetOrdersByQuery**](OrderApi.md#getordersbyquery) | **POST** /order/orders/query | Retrieve orders by query
[**InsertOrder**](OrderApi.md#insertorder) | **POST** /order/orders | Insert an order
[**ProcessPayment**](OrderApi.md#processpayment) | **POST** /order/orders/{order_id}/process_payment | Process payment
[**RefundOrder**](OrderApi.md#refundorder) | **PUT** /order/orders/{order_id}/refund | Refund an order
[**Replacement**](OrderApi.md#replacement) | **POST** /order/orders/{order_id}/replacement | Replacement order
[**ResendReceipt**](OrderApi.md#resendreceipt) | **POST** /order/orders/{order_id}/resend_receipt | Resend receipt
[**ResendShipmentConfirmation**](OrderApi.md#resendshipmentconfirmation) | **POST** /order/orders/{order_id}/resend_shipment_confirmation | Resend shipment confirmation
[**UpdateAccountsReceivableRetryConfig**](OrderApi.md#updateaccountsreceivableretryconfig) | **POST** /order/accountsReceivableRetryConfig | Update A/R Retry Configuration
[**UpdateOrder**](OrderApi.md#updateorder) | **PUT** /order/orders/{order_id} | Update an order


<a name="adjustordertotal"></a>
# **AdjustOrderTotal**
> BaseResponse AdjustOrderTotal (string orderId, string desiredTotal)

Adjusts an order total

Adjusts an order total.  Adjusts individual items appropriately and considers taxes.  Desired total should be provided in the same currency as the order.  Returns true if successful. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class AdjustOrderTotalExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

            var orderId = orderId_example;  // string | The order id to cancel.
            var desiredTotal = desiredTotal_example;  // string | The desired total with no formatting. example 123.45

            try
            {
                // Adjusts an order total
                BaseResponse result = apiInstance.AdjustOrderTotal(orderId, desiredTotal);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.AdjustOrderTotal: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to cancel. | 
 **desiredTotal** | **string**| The desired total with no formatting. example 123.45 | 

### Return type

[**BaseResponse**](BaseResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelorder"></a>
# **CancelOrder**
> BaseResponse CancelOrder (string orderId)

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
    public class CancelOrderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

            var orderId = orderId_example;  // string | The order id to cancel.

            try
            {
                // Cancel an order
                BaseResponse result = apiInstance.CancelOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.CancelOrder: " + e.Message );
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

<a name="deleteorder"></a>
# **DeleteOrder**
> void DeleteOrder (string orderId)

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
    public class DeleteOrderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

            var orderId = orderId_example;  // string | The order id to delete.

            try
            {
                // Delete an order
                apiInstance.DeleteOrder(orderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.DeleteOrder: " + e.Message );
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

<a name="format"></a>
# **Format**
> OrderFormatResponse Format (string orderId, OrderFormat formatOptions)

Format order

Format the order for display at text or html 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class FormatExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

            var orderId = orderId_example;  // string | The order id to format
            var formatOptions = new OrderFormat(); // OrderFormat | Format options

            try
            {
                // Format order
                OrderFormatResponse result = apiInstance.Format(orderId, formatOptions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.Format: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to format | 
 **formatOptions** | [**OrderFormat**](OrderFormat.md)| Format options | 

### Return type

[**OrderFormatResponse**](OrderFormatResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateordertoken"></a>
# **GenerateOrderToken**
> OrderTokenResponse GenerateOrderToken (string orderId)

Generate an order token for a given order id

Retrieves a single order token for a given order id.  The token can be used with the getOrderByToken API. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GenerateOrderTokenExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

            var orderId = orderId_example;  // string | The order id to generate a token for.

            try
            {
                // Generate an order token for a given order id
                OrderTokenResponse result = apiInstance.GenerateOrderToken(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GenerateOrderToken: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to generate a token for. | 

### Return type

[**OrderTokenResponse**](OrderTokenResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountsreceivableretryconfig"></a>
# **GetAccountsReceivableRetryConfig**
> AccountsReceivableRetryConfigResponse GetAccountsReceivableRetryConfig ()

Retrieve A/R Retry Configuration

Retrieve A/R Retry Configuration. This is primarily an internal API call.  It is doubtful you would ever need to use it. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetAccountsReceivableRetryConfigExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);


            try
            {
                // Retrieve A/R Retry Configuration
                AccountsReceivableRetryConfigResponse result = apiInstance.GetAccountsReceivableRetryConfig();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GetAccountsReceivableRetryConfig: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AccountsReceivableRetryConfigResponse**](AccountsReceivableRetryConfigResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountsreceivableretrystats"></a>
# **GetAccountsReceivableRetryStats**
> AccountsReceivableRetryStatsResponse GetAccountsReceivableRetryStats (string from = null, string to = null)

Retrieve A/R Retry Statistics

Retrieve A/R Retry Statistics. This is primarily an internal API call.  It is doubtful you would ever need to use it. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetAccountsReceivableRetryStatsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

            var from = from_example;  // string |  (optional) 
            var to = to_example;  // string |  (optional) 

            try
            {
                // Retrieve A/R Retry Statistics
                AccountsReceivableRetryStatsResponse result = apiInstance.GetAccountsReceivableRetryStats(from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GetAccountsReceivableRetryStats: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **string**|  | [optional] 
 **to** | **string**|  | [optional] 

### Return type

[**AccountsReceivableRetryStatsResponse**](AccountsReceivableRetryStatsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorder"></a>
# **GetOrder**
> OrderResponse GetOrder (string orderId, string expand = null)

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
    public class GetOrderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

            var orderId = orderId_example;  // string | The order id to retrieve.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve an order
                OrderResponse result = apiInstance.GetOrder(orderId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrder: " + e.Message );
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

<a name="getorderbytoken"></a>
# **GetOrderByToken**
> OrderResponse GetOrderByToken (OrderByTokenQuery orderByTokenQuery, string expand = null)

Retrieve an order using a token

Retrieves a single order using the specified order token. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetOrderByTokenExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

            var orderByTokenQuery = new OrderByTokenQuery(); // OrderByTokenQuery | Order by token query
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve an order using a token
                OrderResponse result = apiInstance.GetOrderByToken(orderByTokenQuery, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrderByToken: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderByTokenQuery** | [**OrderByTokenQuery**](OrderByTokenQuery.md)| Order by token query | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**OrderResponse**](OrderResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorders"></a>
# **GetOrders**
> OrdersResponse GetOrders (string orderId = null, string paymentMethod = null, string company = null, string firstName = null, string lastName = null, string city = null, string stateRegion = null, string postalCode = null, string countryCode = null, string phone = null, string email = null, string ccEmail = null, decimal? total = null, string screenBrandingThemeCode = null, string storefrontHostName = null, string creationDateBegin = null, string creationDateEnd = null, string paymentDateBegin = null, string paymentDateEnd = null, string shipmentDateBegin = null, string shipmentDateEnd = null, string rma = null, string purchaseOrderNumber = null, string itemId = null, string currentStage = null, string channelPartnerCode = null, string channelPartnerOrderId = null, int? customerProfileOid = null, string refundDateBegin = null, string refundDateEnd = null, string customField1 = null, string customField2 = null, string customField3 = null, string customField4 = null, string customField5 = null, string customField6 = null, string customField7 = null, int? limit = null, int? offset = null, string sort = null, string expand = null)

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
    public class GetOrdersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

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
            var total = 8.14;  // decimal? | Total (optional) 
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
            var customerProfileOid = 56;  // int? |  (optional) 
            var refundDateBegin = refundDateBegin_example;  // string |  (optional) 
            var refundDateEnd = refundDateEnd_example;  // string |  (optional) 
            var customField1 = customField1_example;  // string |  (optional) 
            var customField2 = customField2_example;  // string |  (optional) 
            var customField3 = customField3_example;  // string |  (optional) 
            var customField4 = customField4_example;  // string |  (optional) 
            var customField5 = customField5_example;  // string |  (optional) 
            var customField6 = customField6_example;  // string |  (optional) 
            var customField7 = customField7_example;  // string |  (optional) 
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Maximum 200) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var sort = sort_example;  // string | The sort order of the orders.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 
            var expand = expand_example;  // string | The object expansion to perform on the result. (optional) 

            try
            {
                // Retrieve orders
                OrdersResponse result = apiInstance.GetOrders(orderId, paymentMethod, company, firstName, lastName, city, stateRegion, postalCode, countryCode, phone, email, ccEmail, total, screenBrandingThemeCode, storefrontHostName, creationDateBegin, creationDateEnd, paymentDateBegin, paymentDateEnd, shipmentDateBegin, shipmentDateEnd, rma, purchaseOrderNumber, itemId, currentStage, channelPartnerCode, channelPartnerOrderId, customerProfileOid, refundDateBegin, refundDateEnd, customField1, customField2, customField3, customField4, customField5, customField6, customField7, limit, offset, sort, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrders: " + e.Message );
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
 **customerProfileOid** | **int?**|  | [optional] 
 **refundDateBegin** | **string**|  | [optional] 
 **refundDateEnd** | **string**|  | [optional] 
 **customField1** | **string**|  | [optional] 
 **customField2** | **string**|  | [optional] 
 **customField3** | **string**|  | [optional] 
 **customField4** | **string**|  | [optional] 
 **customField5** | **string**|  | [optional] 
 **customField6** | **string**|  | [optional] 
 **customField7** | **string**|  | [optional] 
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

<a name="getordersbatch"></a>
# **GetOrdersBatch**
> OrdersResponse GetOrdersBatch (OrderQueryBatch orderBatch, string expand = null)

Retrieve order batch

Retrieves a group of orders from the account based on an array of order ids.  If more than 500 order ids are specified, the API call will fail with a bad request error. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetOrdersBatchExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

            var orderBatch = new OrderQueryBatch(); // OrderQueryBatch | Order batch
            var expand = expand_example;  // string | The object expansion to perform on the result. (optional) 

            try
            {
                // Retrieve order batch
                OrdersResponse result = apiInstance.GetOrdersBatch(orderBatch, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrdersBatch: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderBatch** | [**OrderQueryBatch**](OrderQueryBatch.md)| Order batch | 
 **expand** | **string**| The object expansion to perform on the result. | [optional] 

### Return type

[**OrdersResponse**](OrdersResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getordersbyquery"></a>
# **GetOrdersByQuery**
> OrdersResponse GetOrdersByQuery (OrderQuery orderQuery, int? limit = null, int? offset = null, string sort = null, string expand = null)

Retrieve orders by query

Retrieves a group of orders from the account based on a query object.  If no parameters are specified, the API call will fail with a bad request error.  Always specify some parameters to limit the scope of the orders returned to ones you are truly interested in.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetOrdersByQueryExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

            var orderQuery = new OrderQuery(); // OrderQuery | Order query
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Maximum 200) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var sort = sort_example;  // string | The sort order of the orders.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 
            var expand = expand_example;  // string | The object expansion to perform on the result. (optional) 

            try
            {
                // Retrieve orders by query
                OrdersResponse result = apiInstance.GetOrdersByQuery(orderQuery, limit, offset, sort, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrdersByQuery: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderQuery** | [**OrderQuery**](OrderQuery.md)| Order query | 
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

<a name="insertorder"></a>
# **InsertOrder**
> OrderResponse InsertOrder (Order order, string expand = null)

Insert an order

Inserts a new order on the UltraCart account.  This is probably NOT the method you want.  This is for channel orders.  For regular orders the customer is entering, use the CheckoutApi.  It has many, many more features, checks, and validations. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertOrderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

            var order = new Order(); // Order | Order to insert
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Insert an order
                OrderResponse result = apiInstance.InsertOrder(order, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.InsertOrder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **order** | [**Order**](Order.md)| Order to insert | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**OrderResponse**](OrderResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processpayment"></a>
# **ProcessPayment**
> OrderProcessPaymentResponse ProcessPayment (string orderId, OrderProcessPaymentRequest processPaymentRequest)

Process payment

Process payment on order 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ProcessPaymentExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

            var orderId = orderId_example;  // string | The order id to process payment on
            var processPaymentRequest = new OrderProcessPaymentRequest(); // OrderProcessPaymentRequest | Process payment parameters

            try
            {
                // Process payment
                OrderProcessPaymentResponse result = apiInstance.ProcessPayment(orderId, processPaymentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.ProcessPayment: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to process payment on | 
 **processPaymentRequest** | [**OrderProcessPaymentRequest**](OrderProcessPaymentRequest.md)| Process payment parameters | 

### Return type

[**OrderProcessPaymentResponse**](OrderProcessPaymentResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refundorder"></a>
# **RefundOrder**
> OrderResponse RefundOrder (Order order, string orderId, bool? rejectAfterRefund = null, bool? skipCustomerNotification = null, bool? autoOrderCancel = null, bool? manualRefund = null, bool? reverseAffiliateTransactions = null, string expand = null)

Refund an order

Perform a refund operation on an order and then update the order if successful 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class RefundOrderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

            var order = new Order(); // Order | Order to refund
            var orderId = orderId_example;  // string | The order id to refund.
            var rejectAfterRefund = true;  // bool? | Reject order after refund (optional)  (default to false)
            var skipCustomerNotification = true;  // bool? | Skip customer email notification (optional)  (default to false)
            var autoOrderCancel = true;  // bool? | Cancel associated auto orders (optional)  (default to false)
            var manualRefund = true;  // bool? | Consider a manual refund done externally (optional)  (default to false)
            var reverseAffiliateTransactions = true;  // bool? | Reverse affiliate transactions (optional)  (default to true)
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Refund an order
                OrderResponse result = apiInstance.RefundOrder(order, orderId, rejectAfterRefund, skipCustomerNotification, autoOrderCancel, manualRefund, reverseAffiliateTransactions, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.RefundOrder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **order** | [**Order**](Order.md)| Order to refund | 
 **orderId** | **string**| The order id to refund. | 
 **rejectAfterRefund** | **bool?**| Reject order after refund | [optional] [default to false]
 **skipCustomerNotification** | **bool?**| Skip customer email notification | [optional] [default to false]
 **autoOrderCancel** | **bool?**| Cancel associated auto orders | [optional] [default to false]
 **manualRefund** | **bool?**| Consider a manual refund done externally | [optional] [default to false]
 **reverseAffiliateTransactions** | **bool?**| Reverse affiliate transactions | [optional] [default to true]
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**OrderResponse**](OrderResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacement"></a>
# **Replacement**
> OrderReplacementResponse Replacement (string orderId, OrderReplacement replacement)

Replacement order

Create a replacement order based upon a previous order 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ReplacementExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

            var orderId = orderId_example;  // string | The order id to generate a replacement for.
            var replacement = new OrderReplacement(); // OrderReplacement | Replacement order details

            try
            {
                // Replacement order
                OrderReplacementResponse result = apiInstance.Replacement(orderId, replacement);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.Replacement: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to generate a replacement for. | 
 **replacement** | [**OrderReplacement**](OrderReplacement.md)| Replacement order details | 

### Return type

[**OrderReplacementResponse**](OrderReplacementResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resendreceipt"></a>
# **ResendReceipt**
> BaseResponse ResendReceipt (string orderId)

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
    public class ResendReceiptExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

            var orderId = orderId_example;  // string | The order id to resend the receipt for.

            try
            {
                // Resend receipt
                BaseResponse result = apiInstance.ResendReceipt(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.ResendReceipt: " + e.Message );
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

<a name="resendshipmentconfirmation"></a>
# **ResendShipmentConfirmation**
> BaseResponse ResendShipmentConfirmation (string orderId)

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
    public class ResendShipmentConfirmationExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

            var orderId = orderId_example;  // string | The order id to resend the shipment notification for.

            try
            {
                // Resend shipment confirmation
                BaseResponse result = apiInstance.ResendShipmentConfirmation(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.ResendShipmentConfirmation: " + e.Message );
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

<a name="updateaccountsreceivableretryconfig"></a>
# **UpdateAccountsReceivableRetryConfig**
> BaseResponse UpdateAccountsReceivableRetryConfig (AccountsReceivableRetryConfig retryConfig)

Update A/R Retry Configuration

Update A/R Retry Configuration.  This is primarily an internal API call.  It is doubtful you would ever need to use it. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateAccountsReceivableRetryConfigExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

            var retryConfig = new AccountsReceivableRetryConfig(); // AccountsReceivableRetryConfig | AccountsReceivableRetryConfig object

            try
            {
                // Update A/R Retry Configuration
                BaseResponse result = apiInstance.UpdateAccountsReceivableRetryConfig(retryConfig);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.UpdateAccountsReceivableRetryConfig: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **retryConfig** | [**AccountsReceivableRetryConfig**](AccountsReceivableRetryConfig.md)| AccountsReceivableRetryConfig object | 

### Return type

[**BaseResponse**](BaseResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorder"></a>
# **UpdateOrder**
> OrderResponse UpdateOrder (Order order, string orderId, string expand = null)

Update an order

Update a new order on the UltraCart account.  This is probably NOT the method you want.  It is rare to update a completed order.  This will not trigger charges, emails, or any other automation. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateOrderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new OrderApi(simpleKey);

            var order = new Order(); // Order | Order to update
            var orderId = orderId_example;  // string | The order id to update.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Update an order
                OrderResponse result = apiInstance.UpdateOrder(order, orderId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.UpdateOrder: " + e.Message );
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

