# com.ultracart.admin.v2.Api.IntegrationLogApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetIntegrationLog**](IntegrationLogApi.md#getintegrationlog) | **GET** /integration_log/query/{pk}/{sk} | Retrieve an integration log
[**GetIntegrationLogFile**](IntegrationLogApi.md#getintegrationlogfile) | **GET** /integration_log/query/{pk}/{sk}/{uuid} | Retrieve an integration log file
[**GetIntegrationLogSummariesQuery**](IntegrationLogApi.md#getintegrationlogsummariesquery) | **POST** /integration_log/summary/query | Retrieve integration log summaries
[**GetIntegrationLogsQuery**](IntegrationLogApi.md#getintegrationlogsquery) | **POST** /integration_log/query | Retrieve integration logs


<a name="getintegrationlog"></a>
# **GetIntegrationLog**
> IntegrationLogResponse GetIntegrationLog (string pk, string sk)

Retrieve an integration log

Retrieve an integration logs from the account based identifiers 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetIntegrationLogExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new IntegrationLogApi(simpleKey);

            var pk = pk_example;  // string | 
            var sk = sk_example;  // string | 

            try
            {
                // Retrieve an integration log
                IntegrationLogResponse result = apiInstance.GetIntegrationLog(pk, sk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationLogApi.GetIntegrationLog: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getintegrationlogfile"></a>
# **GetIntegrationLogFile**
> System.IO.Stream GetIntegrationLogFile (string pk, string sk, string uuid)

Retrieve an integration log file

Retrieve an integration log file from the account based identifiers 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetIntegrationLogFileExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new IntegrationLogApi(simpleKey);

            var pk = pk_example;  // string | 
            var sk = sk_example;  // string | 
            var uuid = uuid_example;  // string | 

            try
            {
                // Retrieve an integration log file
                System.IO.Stream result = apiInstance.GetIntegrationLogFile(pk, sk, uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationLogApi.GetIntegrationLogFile: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getintegrationlogsummariesquery"></a>
# **GetIntegrationLogSummariesQuery**
> IntegrationLogSummaryQueryResponse GetIntegrationLogSummariesQuery (IntegrationLogSummaryQueryRequest integrationLogSummariesQuery)

Retrieve integration log summaries

Retrieves a set of integration log summaries from the account based on a query object. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetIntegrationLogSummariesQueryExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new IntegrationLogApi(simpleKey);

            var integrationLogSummariesQuery = new IntegrationLogSummaryQueryRequest(); // IntegrationLogSummaryQueryRequest | Integration log summaries query

            try
            {
                // Retrieve integration log summaries
                IntegrationLogSummaryQueryResponse result = apiInstance.GetIntegrationLogSummariesQuery(integrationLogSummariesQuery);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationLogApi.GetIntegrationLogSummariesQuery: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getintegrationlogsquery"></a>
# **GetIntegrationLogsQuery**
> IntegrationLogQueryResponse GetIntegrationLogsQuery (IntegrationLogQueryRequest integrationLogQuery, int? limit = null, int? offset = null, string sort = null)

Retrieve integration logs

Retrieves a set of integration logs from the account based on a query object. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetIntegrationLogsQueryExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new IntegrationLogApi(simpleKey);

            var integrationLogQuery = new IntegrationLogQueryRequest(); // IntegrationLogQueryRequest | Integration log query
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Default 100, Max 500) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var sort = sort_example;  // string | The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 

            try
            {
                // Retrieve integration logs
                IntegrationLogQueryResponse result = apiInstance.GetIntegrationLogsQuery(integrationLogQuery, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationLogApi.GetIntegrationLogsQuery: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

