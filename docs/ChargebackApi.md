# com.ultracart.admin.v2.Api.ChargebackApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteChargeback**](ChargebackApi.md#deletechargeback) | **DELETE** /chargeback/chargebacks/{chargeback_dispute_oid} | Delete a chargeback
[**GetChargebackDispute**](ChargebackApi.md#getchargebackdispute) | **GET** /chargeback/chargebacks/{chargeback_dispute_oid} | Retrieve a chargeback
[**GetChargebackDisputes**](ChargebackApi.md#getchargebackdisputes) | **GET** /chargeback/chargebacks | Retrieve chargebacks
[**InsertChargeback**](ChargebackApi.md#insertchargeback) | **POST** /chargeback/chargebacks | Insert a chargeback
[**UpdateChargeback**](ChargebackApi.md#updatechargeback) | **PUT** /chargeback/chargebacks/{chargeback_dispute_oid} | Update a chargeback



## DeleteChargeback

> ChargebackDisputeResponse DeleteChargeback (int chargebackDisputeOid)

Delete a chargeback

Delete a chargeback on the UltraCart account. 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteChargebackExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var chargebackDisputeOid = 56;  // int | The chargeback_dispute_oid to delete.

            try
            {
                // Delete a chargeback
                ChargebackDisputeResponse result = apiInstance.DeleteChargeback(chargebackDisputeOid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChargebackApi.DeleteChargeback: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chargebackDisputeOid** | **int**| The chargeback_dispute_oid to delete. | 

### Return type

[**ChargebackDisputeResponse**](ChargebackDisputeResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

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


## GetChargebackDispute

> ChargebackDisputeResponse GetChargebackDispute (int chargebackDisputeOid, string expand = null)

Retrieve a chargeback

Retrieves a single chargeback using the specified chargeback dispute oid. 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetChargebackDisputeExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var chargebackDisputeOid = 56;  // int | The chargeback dispute oid to retrieve.
            var expand = "expand_example";  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve a chargeback
                ChargebackDisputeResponse result = apiInstance.GetChargebackDispute(chargebackDisputeOid, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChargebackApi.GetChargebackDispute: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chargebackDisputeOid** | **int**| The chargeback dispute oid to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**ChargebackDisputeResponse**](ChargebackDisputeResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

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


## GetChargebackDisputes

> ChargebackDisputesResponse GetChargebackDisputes (string orderId = null, string caseNumber = null, string status = null, string expirationDtsStart = null, string expirationDtsEnd = null, string chargebackDtsStart = null, string chargebackDtsEnd = null, int? limit = null, int? offset = null, string since = null, string sort = null, string expand = null)

Retrieve chargebacks

Retrieves chargebacks from the account.  If no parameters are specified, all chargebacks will be returned.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetChargebackDisputesExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var orderId = "orderId_example";  // string | Order Id (optional) 
            var caseNumber = "caseNumber_example";  // string | Case number (optional) 
            var status = "status_example";  // string | Status (optional) 
            var expirationDtsStart = "expirationDtsStart_example";  // string | Expiration dts start (optional) 
            var expirationDtsEnd = "expirationDtsEnd_example";  // string | Expiration dts end (optional) 
            var chargebackDtsStart = "chargebackDtsStart_example";  // string | Chargeback dts start (optional) 
            var chargebackDtsEnd = "chargebackDtsEnd_example";  // string | Chargeback dts end (optional) 
            var limit = 100;  // int? | The maximum number of records to return on this one API call. (Max 200) (optional)  (default to 100)
            var offset = 0;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var since = "since_example";  // string | Fetch chargebacks that have been created/modified since this date/time. (optional) 
            var sort = "sort_example";  // string | The sort order of the chargebacks.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 
            var expand = "expand_example";  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve chargebacks
                ChargebackDisputesResponse result = apiInstance.GetChargebackDisputes(orderId, caseNumber, status, expirationDtsStart, expirationDtsEnd, chargebackDtsStart, chargebackDtsEnd, limit, offset, since, sort, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChargebackApi.GetChargebackDisputes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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


## InsertChargeback

> ChargebackDisputeResponse InsertChargeback (ChargebackDispute chargeback, string expand = null)

Insert a chargeback

Insert a chargeback on the UltraCart account. 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertChargebackExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var chargeback = new ChargebackDispute(); // ChargebackDispute | Chargeback to insert
            var expand = "expand_example";  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Insert a chargeback
                ChargebackDisputeResponse result = apiInstance.InsertChargeback(chargeback, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChargebackApi.InsertChargeback: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chargeback** | [**ChargebackDispute**](ChargebackDispute.md)| Chargeback to insert | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**ChargebackDisputeResponse**](ChargebackDisputeResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
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


## UpdateChargeback

> ChargebackDisputeResponse UpdateChargeback (int chargebackDisputeOid, ChargebackDispute chargeback, string expand = null)

Update a chargeback

Update a chargeback on the UltraCart account. 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateChargebackExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var chargebackDisputeOid = 56;  // int | The chargeback_dispute_oid to update.
            var chargeback = new ChargebackDispute(); // ChargebackDispute | Chargeback to update
            var expand = "expand_example";  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Update a chargeback
                ChargebackDisputeResponse result = apiInstance.UpdateChargeback(chargebackDisputeOid, chargeback, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChargebackApi.UpdateChargeback: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chargebackDisputeOid** | **int**| The chargeback_dispute_oid to update. | 
 **chargeback** | [**ChargebackDispute**](ChargebackDispute.md)| Chargeback to update | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**ChargebackDisputeResponse**](ChargebackDisputeResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
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

