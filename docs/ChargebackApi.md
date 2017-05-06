# com.ultracart.admin.v2.Api.ChargebackApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChargebackChargebacksChargebackDisputeOidDelete**](ChargebackApi.md#chargebackchargebackschargebackdisputeoiddelete) | **DELETE** /chargeback/chargebacks/{chargeback_dispute_oid} | Delete a chargeback
[**ChargebackChargebacksChargebackDisputeOidGet**](ChargebackApi.md#chargebackchargebackschargebackdisputeoidget) | **GET** /chargeback/chargebacks/{chargeback_dispute_oid} | Retrieve a chargeback
[**ChargebackChargebacksChargebackDisputeOidPut**](ChargebackApi.md#chargebackchargebackschargebackdisputeoidput) | **PUT** /chargeback/chargebacks/{chargeback_dispute_oid} | Update a chargeback
[**ChargebackChargebacksGet**](ChargebackApi.md#chargebackchargebacksget) | **GET** /chargeback/chargebacks | Retrieve chargebacks
[**ChargebackChargebacksPost**](ChargebackApi.md#chargebackchargebackspost) | **POST** /chargeback/chargebacks | Insert a chargeback


<a name="chargebackchargebackschargebackdisputeoiddelete"></a>
# **ChargebackChargebacksChargebackDisputeOidDelete**
> ChargebackDisputeResponse ChargebackChargebacksChargebackDisputeOidDelete (int? chargebackDisputeOid)

Delete a chargeback

Delete a chargeback on the UltraCart account. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ChargebackChargebacksChargebackDisputeOidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new ChargebackApi();
            var chargebackDisputeOid = 56;  // int? | The chargeback_dispute_oid to delete.

            try
            {
                // Delete a chargeback
                ChargebackDisputeResponse result = apiInstance.ChargebackChargebacksChargebackDisputeOidDelete(chargebackDisputeOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargebackApi.ChargebackChargebacksChargebackDisputeOidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chargebackDisputeOid** | **int?**| The chargeback_dispute_oid to delete. | 

### Return type

[**ChargebackDisputeResponse**](ChargebackDisputeResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chargebackchargebackschargebackdisputeoidget"></a>
# **ChargebackChargebacksChargebackDisputeOidGet**
> ChargebackDisputeResponse ChargebackChargebacksChargebackDisputeOidGet (int? chargebackDisputeOid, string expand = null)

Retrieve a chargeback

Retrieves a single chargeback using the specified chargeback dispute oid. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ChargebackChargebacksChargebackDisputeOidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new ChargebackApi();
            var chargebackDisputeOid = 56;  // int? | The chargeback dispute oid to retrieve.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve a chargeback
                ChargebackDisputeResponse result = apiInstance.ChargebackChargebacksChargebackDisputeOidGet(chargebackDisputeOid, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargebackApi.ChargebackChargebacksChargebackDisputeOidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chargebackDisputeOid** | **int?**| The chargeback dispute oid to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**ChargebackDisputeResponse**](ChargebackDisputeResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chargebackchargebackschargebackdisputeoidput"></a>
# **ChargebackChargebacksChargebackDisputeOidPut**
> ChargebackDisputeResponse ChargebackChargebacksChargebackDisputeOidPut (ChargebackDispute chargeback, int? chargebackDisputeOid)

Update a chargeback

Update a chargeback on the UltraCart account. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ChargebackChargebacksChargebackDisputeOidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new ChargebackApi();
            var chargeback = new ChargebackDispute(); // ChargebackDispute | Chargeback to update
            var chargebackDisputeOid = 56;  // int? | The chargeback_dispute_oid to update.

            try
            {
                // Update a chargeback
                ChargebackDisputeResponse result = apiInstance.ChargebackChargebacksChargebackDisputeOidPut(chargeback, chargebackDisputeOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargebackApi.ChargebackChargebacksChargebackDisputeOidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chargeback** | [**ChargebackDispute**](ChargebackDispute.md)| Chargeback to update | 
 **chargebackDisputeOid** | **int?**| The chargeback_dispute_oid to update. | 

### Return type

[**ChargebackDisputeResponse**](ChargebackDisputeResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chargebackchargebacksget"></a>
# **ChargebackChargebacksGet**
> ChargebackDisputesResponse ChargebackChargebacksGet (string orderId = null, string caseNumber = null, string status = null, string expirationDtsStart = null, string expirationDtsEnd = null, string chargebackDtsStart = null, string chargebackDtsEnd = null, int? limit = null, int? offset = null, string since = null, string sort = null, string expand = null)

Retrieve chargebacks

Retrieves chargebacks from the account.  If no parameters are specified, all chargebacks will be returned.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ChargebackChargebacksGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new ChargebackApi();
            var orderId = orderId_example;  // string | Order Id (optional) 
            var caseNumber = caseNumber_example;  // string | Case number (optional) 
            var status = status_example;  // string | Status (optional) 
            var expirationDtsStart = expirationDtsStart_example;  // string | Expiration dts start (optional) 
            var expirationDtsEnd = expirationDtsEnd_example;  // string | Expiration dts end (optional) 
            var chargebackDtsStart = chargebackDtsStart_example;  // string | Chargeback dts start (optional) 
            var chargebackDtsEnd = chargebackDtsEnd_example;  // string | Chargeback dts end (optional) 
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Max 200) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var since = since_example;  // string | Fetch chargebacks that have been created/modified since this date/time. (optional) 
            var sort = sort_example;  // string | The sort order of the chargebacks.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve chargebacks
                ChargebackDisputesResponse result = apiInstance.ChargebackChargebacksGet(orderId, caseNumber, status, expirationDtsStart, expirationDtsEnd, chargebackDtsStart, chargebackDtsEnd, limit, offset, since, sort, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargebackApi.ChargebackChargebacksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| Order Id | [optional] 
 **caseNumber** | **string**| Case number | [optional] 
 **status** | **string**| Status | [optional] 
 **expirationDtsStart** | **string**| Expiration dts start | [optional] 
 **expirationDtsEnd** | **string**| Expiration dts end | [optional] 
 **chargebackDtsStart** | **string**| Chargeback dts start | [optional] 
 **chargebackDtsEnd** | **string**| Chargeback dts end | [optional] 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Max 200) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **since** | **string**| Fetch chargebacks that have been created/modified since this date/time. | [optional] 
 **sort** | **string**| The sort order of the chargebacks.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**ChargebackDisputesResponse**](ChargebackDisputesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chargebackchargebackspost"></a>
# **ChargebackChargebacksPost**
> ChargebackDisputeResponse ChargebackChargebacksPost (ChargebackDispute chargeback)

Insert a chargeback

Insert a chargeback on the UltraCart account. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ChargebackChargebacksPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new ChargebackApi();
            var chargeback = new ChargebackDispute(); // ChargebackDispute | Chargeback to insert

            try
            {
                // Insert a chargeback
                ChargebackDisputeResponse result = apiInstance.ChargebackChargebacksPost(chargeback);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargebackApi.ChargebackChargebacksPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chargeback** | [**ChargebackDispute**](ChargebackDispute.md)| Chargeback to insert | 

### Return type

[**ChargebackDisputeResponse**](ChargebackDisputeResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

