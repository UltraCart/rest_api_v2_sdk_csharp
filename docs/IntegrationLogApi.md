# com.ultracart.admin.v2.Api.IntegrationLogApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetIntegrationLog**](IntegrationLogApi.md#getintegrationlog) | **GET** /integration_log/query/{pk}/{sk} | Retrieve an integration log
[**GetIntegrationLogFile**](IntegrationLogApi.md#getintegrationlogfile) | **GET** /integration_log/query/{pk}/{sk}/{uuid} | Retrieve an integration log file
[**GetIntegrationLogFilePdf**](IntegrationLogApi.md#getintegrationlogfilepdf) | **GET** /integration_log/query/{pk}/{sk}/{uuid}/pdf | Retrieve an integration log file converted to PDF
[**GetIntegrationLogSummariesQuery**](IntegrationLogApi.md#getintegrationlogsummariesquery) | **POST** /integration_log/summary/query | Retrieve integration log summaries
[**GetIntegrationLogsQuery**](IntegrationLogApi.md#getintegrationlogsquery) | **POST** /integration_log/query | Retrieve integration logs



## GetIntegrationLog

> IntegrationLogResponse GetIntegrationLog (string pk, string sk)

Retrieve an integration log

Retrieve an integration logs from the account based identifiers 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetIntegrationLogExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://secure.ultracart.com/rest/v2";
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-ultracart-simple-key", "Bearer");

            var apiInstance = new IntegrationLogApi(Configuration.Default);
            var pk = "pk_example";  // string | 
            var sk = "sk_example";  // string | 

            try
            {
                // Retrieve an integration log
                IntegrationLogResponse result = apiInstance.GetIntegrationLog(pk, sk);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IntegrationLogApi.GetIntegrationLog: " + e.Message );
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
 **pk** | **string**|  | 
 **sk** | **string**|  | 

### Return type

[**IntegrationLogResponse**](IntegrationLogResponse.md)

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


## GetIntegrationLogFile

> System.IO.Stream GetIntegrationLogFile (string pk, string sk, string uuid)

Retrieve an integration log file

Retrieve an integration log file from the account based identifiers 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetIntegrationLogFileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://secure.ultracart.com/rest/v2";
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-ultracart-simple-key", "Bearer");

            var apiInstance = new IntegrationLogApi(Configuration.Default);
            var pk = "pk_example";  // string | 
            var sk = "sk_example";  // string | 
            var uuid = "uuid_example";  // string | 

            try
            {
                // Retrieve an integration log file
                System.IO.Stream result = apiInstance.GetIntegrationLogFile(pk, sk, uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IntegrationLogApi.GetIntegrationLogFile: " + e.Message );
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
 **pk** | **string**|  | 
 **sk** | **string**|  | 
 **uuid** | **string**|  | 

### Return type

**System.IO.Stream**

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/octet-stream


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


## GetIntegrationLogFilePdf

> System.IO.Stream GetIntegrationLogFilePdf (string pk, string sk, string uuid)

Retrieve an integration log file converted to PDF

Retrieve an integration log file from the account based identifiers 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetIntegrationLogFilePdfExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://secure.ultracart.com/rest/v2";
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-ultracart-simple-key", "Bearer");

            var apiInstance = new IntegrationLogApi(Configuration.Default);
            var pk = "pk_example";  // string | 
            var sk = "sk_example";  // string | 
            var uuid = "uuid_example";  // string | 

            try
            {
                // Retrieve an integration log file converted to PDF
                System.IO.Stream result = apiInstance.GetIntegrationLogFilePdf(pk, sk, uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IntegrationLogApi.GetIntegrationLogFilePdf: " + e.Message );
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
 **pk** | **string**|  | 
 **sk** | **string**|  | 
 **uuid** | **string**|  | 

### Return type

**System.IO.Stream**

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/octet-stream


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


## GetIntegrationLogSummariesQuery

> IntegrationLogSummaryQueryResponse GetIntegrationLogSummariesQuery (IntegrationLogSummaryQueryRequest integrationLogSummariesQuery)

Retrieve integration log summaries

Retrieves a set of integration log summaries from the account based on a query object. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetIntegrationLogSummariesQueryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://secure.ultracart.com/rest/v2";
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-ultracart-simple-key", "Bearer");

            var apiInstance = new IntegrationLogApi(Configuration.Default);
            var integrationLogSummariesQuery = new IntegrationLogSummaryQueryRequest(); // IntegrationLogSummaryQueryRequest | Integration log summaries query

            try
            {
                // Retrieve integration log summaries
                IntegrationLogSummaryQueryResponse result = apiInstance.GetIntegrationLogSummariesQuery(integrationLogSummariesQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IntegrationLogApi.GetIntegrationLogSummariesQuery: " + e.Message );
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
 **integrationLogSummariesQuery** | [**IntegrationLogSummaryQueryRequest**](IntegrationLogSummaryQueryRequest.md)| Integration log summaries query | 

### Return type

[**IntegrationLogSummaryQueryResponse**](IntegrationLogSummaryQueryResponse.md)

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


## GetIntegrationLogsQuery

> IntegrationLogQueryResponse GetIntegrationLogsQuery (IntegrationLogQueryRequest integrationLogQuery, int? limit = null, int? offset = null, string sort = null)

Retrieve integration logs

Retrieves a set of integration logs from the account based on a query object. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetIntegrationLogsQueryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://secure.ultracart.com/rest/v2";
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-ultracart-simple-key", "Bearer");

            var apiInstance = new IntegrationLogApi(Configuration.Default);
            var integrationLogQuery = new IntegrationLogQueryRequest(); // IntegrationLogQueryRequest | Integration log query
            var limit = 100;  // int? | The maximum number of records to return on this one API call. (Default 100, Max 500) (optional)  (default to 100)
            var offset = 0;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var sort = "sort_example";  // string | The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 

            try
            {
                // Retrieve integration logs
                IntegrationLogQueryResponse result = apiInstance.GetIntegrationLogsQuery(integrationLogQuery, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IntegrationLogApi.GetIntegrationLogsQuery: " + e.Message );
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
 **integrationLogQuery** | [**IntegrationLogQueryRequest**](IntegrationLogQueryRequest.md)| Integration log query | 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Default 100, Max 500) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **sort** | **string**| The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 

### Return type

[**IntegrationLogQueryResponse**](IntegrationLogQueryResponse.md)

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

