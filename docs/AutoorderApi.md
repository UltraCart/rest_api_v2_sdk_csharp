# com.ultracart.admin.v2.Api.AutoorderApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAutoOrder**](AutoorderApi.md#getautoorder) | **GET** /auto_order/auto_orders/{auto_order_oid} | Retrieve an auto order
[**GetAutoOrders**](AutoorderApi.md#getautoorders) | **GET** /auto_order/auto_orders | Retrieve auto orders
[**UpdateAutoOrder**](AutoorderApi.md#updateautoorder) | **PUT** /auto_order/auto_orders/{auto_order_oid} | Update an auto order


<a name="getautoorder"></a>
# **GetAutoOrder**
> AutoOrderResponse GetAutoOrder (int? autoOrderOid, string expand = null)

Retrieve an auto order

Retrieves a single auto order using the specified auto order oid. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetAutoOrderExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new AutoorderApi();
            var autoOrderOid = 56;  // int? | The auto order oid to retrieve.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve an auto order
                AutoOrderResponse result = apiInstance.GetAutoOrder(autoOrderOid, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoorderApi.GetAutoOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoOrderOid** | **int?**| The auto order oid to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**AutoOrderResponse**](AutoOrderResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getautoorders"></a>
# **GetAutoOrders**
> AutoOrdersResponse GetAutoOrders (string autoOrderCode = null, string originalOrderId = null, string firstName = null, string lastName = null, string company = null, string city = null, string state = null, string postalCode = null, string countryCode = null, string phone = null, string email = null, string originalOrderDateBegin = null, string originalOrderDateEnd = null, string nextShipmentDateBegin = null, string nextShipmentDateEnd = null, string cardType = null, string itemId = null, string status = null, int? limit = null, int? offset = null, string since = null, string sort = null, string expand = null)

Retrieve auto orders

Retrieves auto orders from the account.  If no parameters are specified, all auto orders will be returned.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetAutoOrdersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new AutoorderApi();
            var autoOrderCode = autoOrderCode_example;  // string | Auto order code (optional) 
            var originalOrderId = originalOrderId_example;  // string | Original order id (optional) 
            var firstName = firstName_example;  // string | First name (optional) 
            var lastName = lastName_example;  // string | Last name (optional) 
            var company = company_example;  // string | Company (optional) 
            var city = city_example;  // string | City (optional) 
            var state = state_example;  // string | State (optional) 
            var postalCode = postalCode_example;  // string | Postal code (optional) 
            var countryCode = countryCode_example;  // string | Country code (ISO-3166 two letter) (optional) 
            var phone = phone_example;  // string | Phone (optional) 
            var email = email_example;  // string | Email (optional) 
            var originalOrderDateBegin = originalOrderDateBegin_example;  // string | Original order date begin (optional) 
            var originalOrderDateEnd = originalOrderDateEnd_example;  // string | Original order date end (optional) 
            var nextShipmentDateBegin = nextShipmentDateBegin_example;  // string | Next shipment date begin (optional) 
            var nextShipmentDateEnd = nextShipmentDateEnd_example;  // string | Next shipment date end (optional) 
            var cardType = cardType_example;  // string | Card type (optional) 
            var itemId = itemId_example;  // string | Item ID (optional) 
            var status = status_example;  // string | Status (optional) 
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Max 200) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var since = since_example;  // string | Fetch auto orders that have been created/modified since this date/time. (optional) 
            var sort = sort_example;  // string | The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve auto orders
                AutoOrdersResponse result = apiInstance.GetAutoOrders(autoOrderCode, originalOrderId, firstName, lastName, company, city, state, postalCode, countryCode, phone, email, originalOrderDateBegin, originalOrderDateEnd, nextShipmentDateBegin, nextShipmentDateEnd, cardType, itemId, status, limit, offset, since, sort, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoorderApi.GetAutoOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoOrderCode** | **string**| Auto order code | [optional] 
 **originalOrderId** | **string**| Original order id | [optional] 
 **firstName** | **string**| First name | [optional] 
 **lastName** | **string**| Last name | [optional] 
 **company** | **string**| Company | [optional] 
 **city** | **string**| City | [optional] 
 **state** | **string**| State | [optional] 
 **postalCode** | **string**| Postal code | [optional] 
 **countryCode** | **string**| Country code (ISO-3166 two letter) | [optional] 
 **phone** | **string**| Phone | [optional] 
 **email** | **string**| Email | [optional] 
 **originalOrderDateBegin** | **string**| Original order date begin | [optional] 
 **originalOrderDateEnd** | **string**| Original order date end | [optional] 
 **nextShipmentDateBegin** | **string**| Next shipment date begin | [optional] 
 **nextShipmentDateEnd** | **string**| Next shipment date end | [optional] 
 **cardType** | **string**| Card type | [optional] 
 **itemId** | **string**| Item ID | [optional] 
 **status** | **string**| Status | [optional] 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Max 200) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **since** | **string**| Fetch auto orders that have been created/modified since this date/time. | [optional] 
 **sort** | **string**| The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**AutoOrdersResponse**](AutoOrdersResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateautoorder"></a>
# **UpdateAutoOrder**
> AutoOrderResponse UpdateAutoOrder (AutoOrder autoOrder, int? autoOrderOid, string expand = null)

Update an auto order

Update an auto order on the UltraCart account. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateAutoOrderExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new AutoorderApi();
            var autoOrder = new AutoOrder(); // AutoOrder | Auto order to update
            var autoOrderOid = 56;  // int? | The auto order oid to update.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Update an auto order
                AutoOrderResponse result = apiInstance.UpdateAutoOrder(autoOrder, autoOrderOid, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoorderApi.UpdateAutoOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoOrder** | [**AutoOrder**](AutoOrder.md)| Auto order to update | 
 **autoOrderOid** | **int?**| The auto order oid to update. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**AutoOrderResponse**](AutoOrderResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

