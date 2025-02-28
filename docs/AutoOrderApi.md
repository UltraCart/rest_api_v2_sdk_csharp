# com.ultracart.admin.v2.Api.AutoOrderApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConsolidateAutoOrders**](AutoOrderApi.md#consolidateautoorders) | **PUT** /auto_order/auto_orders/{auto_order_oid}/consolidate | Consolidates multiple auto orders
[**EstablishAutoOrderByReferenceOrderId**](AutoOrderApi.md#establishautoorderbyreferenceorderid) | **POST** /auto_order/auto_orders/reference_order_id/{reference_order_id} | Establish an auto order by referencing a regular order id
[**GetAutoOrder**](AutoOrderApi.md#getautoorder) | **GET** /auto_order/auto_orders/{auto_order_oid} | Retrieve an auto order by oid
[**GetAutoOrderByCode**](AutoOrderApi.md#getautoorderbycode) | **GET** /auto_order/auto_orders/code/{auto_order_code} | Retrieve an auto order by code
[**GetAutoOrderByReferenceOrderId**](AutoOrderApi.md#getautoorderbyreferenceorderid) | **GET** /auto_order/auto_orders/reference_order_id/{reference_order_id} | Retrieve an auto order by order id
[**GetAutoOrders**](AutoOrderApi.md#getautoorders) | **GET** /auto_order/auto_orders | Retrieve auto orders
[**GetAutoOrdersBatch**](AutoOrderApi.md#getautoordersbatch) | **POST** /auto_order/auto_orders/batch | Retrieve auto order batch
[**GetAutoOrdersByQuery**](AutoOrderApi.md#getautoordersbyquery) | **POST** /auto_order/auto_orders/query | Retrieve auto orders by query
[**PauseAutoOrder**](AutoOrderApi.md#pauseautoorder) | **PUT** /auto_order/auto_orders/{auto_order_oid}/pause | Pause auto order
[**UpdateAutoOrder**](AutoOrderApi.md#updateautoorder) | **PUT** /auto_order/auto_orders/{auto_order_oid} | Update an auto order
[**UpdateAutoOrdersBatch**](AutoOrderApi.md#updateautoordersbatch) | **PUT** /auto_order/auto_orders/batch | Update multiple auto orders


<a name="consolidateautoorders"></a>
# **ConsolidateAutoOrders**
> AutoOrderResponse ConsolidateAutoOrders (AutoOrderConsolidate autoOrderConsolidate, int? autoOrderOid, string expand = null)

Consolidates multiple auto orders

Consolidates mutliple auto orders on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ConsolidateAutoOrdersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new AutoOrderApi(simpleKey);

            var autoOrderConsolidate = new AutoOrderConsolidate(); // AutoOrderConsolidate | Auto orders to consolidate
            var autoOrderOid = 56;  // int? | The auto order oid to consolidate into.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Consolidates multiple auto orders
                AutoOrderResponse result = apiInstance.ConsolidateAutoOrders(autoOrderConsolidate, autoOrderOid, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoOrderApi.ConsolidateAutoOrders: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoOrderConsolidate** | [**AutoOrderConsolidate**](AutoOrderConsolidate.md)| Auto orders to consolidate | 
 **autoOrderOid** | **int?**| The auto order oid to consolidate into. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**AutoOrderResponse**](AutoOrderResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="establishautoorderbyreferenceorderid"></a>
# **EstablishAutoOrderByReferenceOrderId**
> AutoOrderResponse EstablishAutoOrderByReferenceOrderId (string referenceOrderId, string expand = null)

Establish an auto order by referencing a regular order id

Establish an auto order by referencing a regular order id.  The result will be an auto order without any items.  You should add the items and perform an update call.  Orders must be less than 60 days old and use a credit card payment. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class EstablishAutoOrderByReferenceOrderIdExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new AutoOrderApi(simpleKey);

            var referenceOrderId = referenceOrderId_example;  // string | The order id to attach this auto order to
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Establish an auto order by referencing a regular order id
                AutoOrderResponse result = apiInstance.EstablishAutoOrderByReferenceOrderId(referenceOrderId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoOrderApi.EstablishAutoOrderByReferenceOrderId: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **referenceOrderId** | **string**| The order id to attach this auto order to | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**AutoOrderResponse**](AutoOrderResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getautoorder"></a>
# **GetAutoOrder**
> AutoOrderResponse GetAutoOrder (int? autoOrderOid, string expand = null)

Retrieve an auto order by oid

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new AutoOrderApi(simpleKey);

            var autoOrderOid = 56;  // int? | The auto order oid to retrieve.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve an auto order by oid
                AutoOrderResponse result = apiInstance.GetAutoOrder(autoOrderOid, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoOrderApi.GetAutoOrder: " + e.Message );
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

<a name="getautoorderbycode"></a>
# **GetAutoOrderByCode**
> AutoOrderResponse GetAutoOrderByCode (string autoOrderCode, string expand = null)

Retrieve an auto order by code

Retrieves a single auto order using the specified reference (original) order id. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetAutoOrderByCodeExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new AutoOrderApi(simpleKey);

            var autoOrderCode = autoOrderCode_example;  // string | The auto order oid to retrieve.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve an auto order by code
                AutoOrderResponse result = apiInstance.GetAutoOrderByCode(autoOrderCode, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoOrderApi.GetAutoOrderByCode: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoOrderCode** | **string**| The auto order oid to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**AutoOrderResponse**](AutoOrderResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getautoorderbyreferenceorderid"></a>
# **GetAutoOrderByReferenceOrderId**
> AutoOrderResponse GetAutoOrderByReferenceOrderId (string referenceOrderId, string expand = null)

Retrieve an auto order by order id

Retrieves a single auto order using the specified reference (original) order id. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetAutoOrderByReferenceOrderIdExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new AutoOrderApi(simpleKey);

            var referenceOrderId = referenceOrderId_example;  // string | The auto order oid to retrieve.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve an auto order by order id
                AutoOrderResponse result = apiInstance.GetAutoOrderByReferenceOrderId(referenceOrderId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoOrderApi.GetAutoOrderByReferenceOrderId: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **referenceOrderId** | **string**| The auto order oid to retrieve. | 
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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new AutoOrderApi(simpleKey);

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
            var sort = sort_example;  // string | The sort order of the auto orders.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve auto orders
                AutoOrdersResponse result = apiInstance.GetAutoOrders(autoOrderCode, originalOrderId, firstName, lastName, company, city, state, postalCode, countryCode, phone, email, originalOrderDateBegin, originalOrderDateEnd, nextShipmentDateBegin, nextShipmentDateEnd, cardType, itemId, status, limit, offset, since, sort, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoOrderApi.GetAutoOrders: " + e.Message );
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
 **sort** | **string**| The sort order of the auto orders.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**AutoOrdersResponse**](AutoOrdersResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getautoordersbatch"></a>
# **GetAutoOrdersBatch**
> AutoOrdersResponse GetAutoOrdersBatch (AutoOrderQueryBatch autoOrderBatch, string expand = null)

Retrieve auto order batch

Retrieves a group of auto orders from the account based on an array of auto order oids.  If more than 200 auto order ids are specified, the API call will fail with a bad request error. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetAutoOrdersBatchExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new AutoOrderApi(simpleKey);

            var autoOrderBatch = new AutoOrderQueryBatch(); // AutoOrderQueryBatch | Auto order batch
            var expand = expand_example;  // string | The object expansion to perform on the result. (optional) 

            try
            {
                // Retrieve auto order batch
                AutoOrdersResponse result = apiInstance.GetAutoOrdersBatch(autoOrderBatch, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoOrderApi.GetAutoOrdersBatch: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoOrderBatch** | [**AutoOrderQueryBatch**](AutoOrderQueryBatch.md)| Auto order batch | 
 **expand** | **string**| The object expansion to perform on the result. | [optional] 

### Return type

[**AutoOrdersResponse**](AutoOrdersResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getautoordersbyquery"></a>
# **GetAutoOrdersByQuery**
> AutoOrdersResponse GetAutoOrdersByQuery (AutoOrderQuery autoOrderQuery, int? limit = null, int? offset = null, string sort = null, string expand = null)

Retrieve auto orders by query

Retrieves a group of auto orders from the account based on a query object.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetAutoOrdersByQueryExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new AutoOrderApi(simpleKey);

            var autoOrderQuery = new AutoOrderQuery(); // AutoOrderQuery | Auto order query
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Maximum 200) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var sort = sort_example;  // string | The sort order of the auto orders.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 
            var expand = expand_example;  // string | The object expansion to perform on the result. (optional) 

            try
            {
                // Retrieve auto orders by query
                AutoOrdersResponse result = apiInstance.GetAutoOrdersByQuery(autoOrderQuery, limit, offset, sort, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoOrderApi.GetAutoOrdersByQuery: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoOrderQuery** | [**AutoOrderQuery**](AutoOrderQuery.md)| Auto order query | 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Maximum 200) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **sort** | **string**| The sort order of the auto orders.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 
 **expand** | **string**| The object expansion to perform on the result. | [optional] 

### Return type

[**AutoOrdersResponse**](AutoOrdersResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pauseautoorder"></a>
# **PauseAutoOrder**
> AutoOrderResponse PauseAutoOrder (AutoOrder autoOrder, int? autoOrderOid, string expand = null)

Pause auto order

Completely pause an auto order 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class PauseAutoOrderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new AutoOrderApi(simpleKey);

            var autoOrder = new AutoOrder(); // AutoOrder | Auto orders to pause
            var autoOrderOid = 56;  // int? | The auto order oid to pause.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Pause auto order
                AutoOrderResponse result = apiInstance.PauseAutoOrder(autoOrder, autoOrderOid, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoOrderApi.PauseAutoOrder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoOrder** | [**AutoOrder**](AutoOrder.md)| Auto orders to pause | 
 **autoOrderOid** | **int?**| The auto order oid to pause. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**AutoOrderResponse**](AutoOrderResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateautoorder"></a>
# **UpdateAutoOrder**
> AutoOrderResponse UpdateAutoOrder (AutoOrder autoOrder, int? autoOrderOid, string validateOriginalOrder = null, string expand = null)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new AutoOrderApi(simpleKey);

            var autoOrder = new AutoOrder(); // AutoOrder | Auto order to update
            var autoOrderOid = 56;  // int? | The auto order oid to update.
            var validateOriginalOrder = validateOriginalOrder_example;  // string | Validate original order before updating (optional) 
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Update an auto order
                AutoOrderResponse result = apiInstance.UpdateAutoOrder(autoOrder, autoOrderOid, validateOriginalOrder, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoOrderApi.UpdateAutoOrder: " + e.Message );
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
 **validateOriginalOrder** | **string**| Validate original order before updating | [optional] 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**AutoOrderResponse**](AutoOrderResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateautoordersbatch"></a>
# **UpdateAutoOrdersBatch**
> AutoOrdersResponse UpdateAutoOrdersBatch (AutoOrdersRequest autoOrdersRequest, string expand = null, bool? placeholders = null, bool? async = null)

Update multiple auto orders

Update multiple auto orders on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateAutoOrdersBatchExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new AutoOrderApi(simpleKey);

            var autoOrdersRequest = new AutoOrdersRequest(); // AutoOrdersRequest | Auto orders to update (synchronous maximum 20 / asynchronous maximum 100)
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 
            var async = true;  // bool? | True if the operation should be run async.  No result returned (optional) 

            try
            {
                // Update multiple auto orders
                AutoOrdersResponse result = apiInstance.UpdateAutoOrdersBatch(autoOrdersRequest, expand, placeholders, async);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoOrderApi.UpdateAutoOrdersBatch: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autoOrdersRequest** | [**AutoOrdersRequest**](AutoOrdersRequest.md)| Auto orders to update (synchronous maximum 20 / asynchronous maximum 100) | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 
 **placeholders** | **bool?**| Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. | [optional] 
 **async** | **bool?**| True if the operation should be run async.  No result returned | [optional] 

### Return type

[**AutoOrdersResponse**](AutoOrdersResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

