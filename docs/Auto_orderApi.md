# com.ultracart.admin.v2.Api.Auto_orderApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAutoOrder**](Auto_orderApi.md#getautoorder) | **GET** /auto_order/auto_orders/{auto_order_oid} | Retrieve an auto order
[**GetAutoOrders**](Auto_orderApi.md#getautoorders) | **GET** /auto_order/auto_orders | Retrieve auto orders
[**UpdateAutoOrder**](Auto_orderApi.md#updateautoorder) | **PUT** /auto_order/auto_orders/{auto_order_oid} | Update an auto order


<a name="getautoorder"></a>
# **GetAutoOrder**
> AutoOrderResponse GetAutoOrder (int? autoOrderOid, string expand = null)

Retrieve an auto order

Retrieves a single auto order using the specified auto order oid. 
### Example
```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;
using NUnit.Framework;

namespace SDKSample {
  [TestFixture]
  public class AutoOrderUpdateTest {


    [Test]
    public void UpdateAutoOrder() {


      // See https://secure.ultracart.com/merchant/configuration/apiManagementApp.do
      const string simpleKey = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
      Configuration.Default.ApiKey.Add("x-ultracart-simple-key", simpleKey);
      Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

      var api = new AutoorderApi();

      const int autoOrderOid = 3268342;
      const string expansion = "items";
      var autoOrderResponse = api.GetAutoOrder(autoOrderOid, expansion);
      var autoOrder = autoOrderResponse.AutoOrder;

      var items = autoOrder.Items;

      // for the new item, set the next shipment date equal to the shipment date of the current items.
      // in case there are no items on this auto order (should *never* happen), start with a default of one month out.
      var nextShipmentDate =
        DateTime.UtcNow.AddMonths(1).ToString("s", System.Globalization.CultureInfo.InvariantCulture);

      if (items.Count > 0) {
        nextShipmentDate = items[0].NextShipmentDts;
      }


      var autoOrderItem = new AutoOrderItem {
        OriginalItemId = "PDF",
        OriginalQuantity = 2,
        RebillValue = decimal.Parse("34.23"),
        NextShipmentDts = nextShipmentDate
      };
      items.Add(autoOrderItem);

      autoOrderResponse = api.UpdateAutoOrder(autoOrder, autoOrderOid, expansion);
      autoOrder = autoOrderResponse.AutoOrder;

      Console.WriteLine(autoOrder);


    }


    [Test]
    public void DeleteAutoOrderItem() {


      // See https://secure.ultracart.com/merchant/configuration/apiManagementApp.do
      const string simpleKey = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
      Configuration.Default.ApiKey.Add("x-ultracart-simple-key", simpleKey);
      Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

      var api = new AutoorderApi();

      const int autoOrderOid = 3268342;
      const string expansion = "items";
      var autoOrderResponse = api.GetAutoOrder(autoOrderOid, expansion);
      var autoOrder = autoOrderResponse.AutoOrder;

      var items = autoOrder.Items;


      if (items.Count > 0) {
        items.Remove(items[items.Count - 1]);
      }


      autoOrderResponse = api.UpdateAutoOrder(autoOrder, autoOrderOid, expansion);
      autoOrder = autoOrderResponse.AutoOrder;

      Console.WriteLine(autoOrder);

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
// You must create your own Simple API key for this example to work.
// See the comments below.

using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;
using NUnit.Framework;

namespace SDKSample {

  [TestFixture]
  public class QueryAutoOrdersByEmail {

    /// <summary>
    /// Helper method to loop through a (possibly, be extremely doubtful) large auto order set and return back a chunk of it.
    /// See the Main method for its usage.
    /// See https://www.ultracart.com/api/#resource_auto_order.html
    /// </summary>
    /// <param name="api">AutoorderApi reference</param>
    /// <param name="email">email to filter by</param>
    /// <param name="offset">The record offset.  First execution this will be zero, and then increment
    /// by the number of records returned each iteration.</param>
    /// <param name="limit">Default and maximum is 200 records.  The example below uses 100.</param>
    /// <returns>
    /// A list of UltraCart AutoOrders.
    /// </returns>
    private static List<AutoOrder> GetAutOrdersChunk(AutoorderApi api, string email, int offset = 0, int limit = 200) {

      const string expand = "items,rebill_orders,original_order";

      var autoOrderResponse = api.GetAutoOrders(email: email, offset: offset, limit: limit, expand: expand);
      // TODO if the response is not success, handle errors here.
      return autoOrderResponse.Success == true ? autoOrderResponse.AutoOrders : new List<AutoOrder>();

    }


    [Test]
    public void GetAutoOrders() {

      // API Simple Keys Documentation
      // https://ultracart.atlassian.net/wiki/display/ucdoc/API+Simple+Key
      //
      // This is the backend screen where API keys are created.
      // See https://secure.ultracart.com/merchant/configuration/apiManagementApp.do
      const string simpleKey = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
      Configuration.Default.ApiKey.Add("x-ultracart-simple-key", simpleKey);

      // This is required.  Search for 'Versioning' on this page:
      // https://www.ultracart.com/api/versioning.html
      Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

      var api = new AutoorderApi();
      var offset = 0;
      const int limit = 100; // why 100?  Just to show more looping.  200 is the max and a better choice.
      var stillMoreRecords = true;
      var autoOrders = new List<AutoOrder>();
      const string email = "test@test.com";

      while (stillMoreRecords) {
        var chunkOfAutoOrders = GetAutOrdersChunk(api, email, offset, limit);
        Console.WriteLine($"{chunkOfAutoOrders.Count} auto orders retrieved.");
        autoOrders.AddRange(chunkOfAutoOrders);
        offset += limit;
        stillMoreRecords = chunkOfAutoOrders.Count == limit;

      }

      Console.WriteLine($"{autoOrders.Count} total auto orders retrieved.");

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
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;
using NUnit.Framework;

namespace SDKSample {
  [TestFixture]
  public class AutoOrderUpdateTest {


    [Test]
    public void UpdateAutoOrder() {


      // See https://secure.ultracart.com/merchant/configuration/apiManagementApp.do
      const string simpleKey = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
      Configuration.Default.ApiKey.Add("x-ultracart-simple-key", simpleKey);
      Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

      var api = new AutoorderApi();

      const int autoOrderOid = 3268342;
      const string expansion = "items";
      var autoOrderResponse = api.GetAutoOrder(autoOrderOid, expansion);
      var autoOrder = autoOrderResponse.AutoOrder;

      var items = autoOrder.Items;

      // for the new item, set the next shipment date equal to the shipment date of the current items.
      // in case there are no items on this auto order (should *never* happen), start with a default of one month out.
      var nextShipmentDate =
        DateTime.UtcNow.AddMonths(1).ToString("s", System.Globalization.CultureInfo.InvariantCulture);

      if (items.Count > 0) {
        nextShipmentDate = items[0].NextShipmentDts;
      }


      var autoOrderItem = new AutoOrderItem {
        OriginalItemId = "PDF",
        OriginalQuantity = 2,
        RebillValue = decimal.Parse("34.23"),
        NextShipmentDts = nextShipmentDate
      };
      items.Add(autoOrderItem);

      autoOrderResponse = api.UpdateAutoOrder(autoOrder, autoOrderOid, expansion);
      autoOrder = autoOrderResponse.AutoOrder;

      Console.WriteLine(autoOrder);


    }


    [Test]
    public void DeleteAutoOrderItem() {


      // See https://secure.ultracart.com/merchant/configuration/apiManagementApp.do
      const string simpleKey = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
      Configuration.Default.ApiKey.Add("x-ultracart-simple-key", simpleKey);
      Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

      var api = new AutoorderApi();

      const int autoOrderOid = 3268342;
      const string expansion = "items";
      var autoOrderResponse = api.GetAutoOrder(autoOrderOid, expansion);
      var autoOrder = autoOrderResponse.AutoOrder;

      var items = autoOrder.Items;


      if (items.Count > 0) {
        items.Remove(items[items.Count - 1]);
      }


      autoOrderResponse = api.UpdateAutoOrder(autoOrder, autoOrderOid, expansion);
      autoOrder = autoOrderResponse.AutoOrder;

      Console.WriteLine(autoOrder);

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

