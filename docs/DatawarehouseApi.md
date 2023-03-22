# com.ultracart.admin.v2.Api.DatawarehouseApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteReport**](DatawarehouseApi.md#deletereport) | **DELETE** /datawarehouse/reports/{report_oid} | Delete a report
[**ExecuteReportQueries**](DatawarehouseApi.md#executereportqueries) | **PUT** /datawarehouse/reports/execute | Execute the report queries
[**GetReport**](DatawarehouseApi.md#getreport) | **GET** /datawarehouse/reports/{report_oid} | Get a report
[**GetReportDataSet**](DatawarehouseApi.md#getreportdataset) | **GET** /datawarehouse/reports/dataset/{dataset_uuid} | Get a report data set
[**GetReportDataSetPage**](DatawarehouseApi.md#getreportdatasetpage) | **GET** /datawarehouse/reports/dataset/{dataset_uuid}/pages/{page_number} | Get a report data set page
[**GetReportWebsocketAuthorization**](DatawarehouseApi.md#getreportwebsocketauthorization) | **PUT** /datawarehouse/reports/auth | Get report websocket authorization
[**GetReports**](DatawarehouseApi.md#getreports) | **GET** /datawarehouse/reports | Get list of reports available
[**InsertReport**](DatawarehouseApi.md#insertreport) | **POST** /datawarehouse/reports | Create a report
[**UpdateReport**](DatawarehouseApi.md#updatereport) | **PUT** /datawarehouse/reports/{report_oid} | Update a report


<a name="deletereport"></a>
# **DeleteReport**
> void DeleteReport (int? reportOid)

Delete a report

Delete a report on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteReportExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var reportOid = 56;  // int? | The report oid to delete.

            try
            {
                // Delete a report
                apiInstance.DeleteReport(reportOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.DeleteReport: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportOid** | **int?**| The report oid to delete. | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executereportqueries"></a>
# **ExecuteReportQueries**
> void ExecuteReportQueries (ReportExecuteQueriesRequest queryRequest)

Execute the report queries

Execute the report queries 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ExecuteReportQueriesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var queryRequest = new ReportExecuteQueriesRequest(); // ReportExecuteQueriesRequest | Query request

            try
            {
                // Execute the report queries
                apiInstance.ExecuteReportQueries(queryRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.ExecuteReportQueries: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queryRequest** | [**ReportExecuteQueriesRequest**](ReportExecuteQueriesRequest.md)| Query request | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreport"></a>
# **GetReport**
> ReportResponse GetReport (int? reportOid)

Get a report

Retrieve a report 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetReportExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var reportOid = 56;  // int? | 

            try
            {
                // Get a report
                ReportResponse result = apiInstance.GetReport(reportOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.GetReport: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportOid** | **int?**|  | 

### Return type

[**ReportResponse**](ReportResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreportdataset"></a>
# **GetReportDataSet**
> ReportDataSetResponse GetReportDataSet (string datasetUuid)

Get a report data set

Retrieve a report data set 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetReportDataSetExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var datasetUuid = datasetUuid_example;  // string | 

            try
            {
                // Get a report data set
                ReportDataSetResponse result = apiInstance.GetReportDataSet(datasetUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.GetReportDataSet: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasetUuid** | **string**|  | 

### Return type

[**ReportDataSetResponse**](ReportDataSetResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreportdatasetpage"></a>
# **GetReportDataSetPage**
> ReportDataSetPageResponse GetReportDataSetPage (string datasetUuid, int? pageNumber)

Get a report data set page

Retrieve a report data set page 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetReportDataSetPageExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var datasetUuid = datasetUuid_example;  // string | 
            var pageNumber = 56;  // int? | 

            try
            {
                // Get a report data set page
                ReportDataSetPageResponse result = apiInstance.GetReportDataSetPage(datasetUuid, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.GetReportDataSetPage: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasetUuid** | **string**|  | 
 **pageNumber** | **int?**|  | 

### Return type

[**ReportDataSetPageResponse**](ReportDataSetPageResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreportwebsocketauthorization"></a>
# **GetReportWebsocketAuthorization**
> ReportAuthResponse GetReportWebsocketAuthorization ()

Get report websocket authorization

Retrieve a JWT to authorize a report to make a websocket connection. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetReportWebsocketAuthorizationExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);


            try
            {
                // Get report websocket authorization
                ReportAuthResponse result = apiInstance.GetReportWebsocketAuthorization();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.GetReportWebsocketAuthorization: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ReportAuthResponse**](ReportAuthResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreports"></a>
# **GetReports**
> ReportsResponse GetReports ()

Get list of reports available

Retrieve a list of reports available 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetReportsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);


            try
            {
                // Get list of reports available
                ReportsResponse result = apiInstance.GetReports();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.GetReports: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ReportsResponse**](ReportsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertreport"></a>
# **InsertReport**
> ReportResponse InsertReport (Report report)

Create a report

Create a new report on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertReportExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var report = new Report(); // Report | Report to create

            try
            {
                // Create a report
                ReportResponse result = apiInstance.InsertReport(report);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.InsertReport: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **report** | [**Report**](Report.md)| Report to create | 

### Return type

[**ReportResponse**](ReportResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereport"></a>
# **UpdateReport**
> ReportResponse UpdateReport (Report report, int? reportOid)

Update a report

Update a report on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateReportExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var report = new Report(); // Report | Report to update
            var reportOid = 56;  // int? | The report oid to update.

            try
            {
                // Update a report
                ReportResponse result = apiInstance.UpdateReport(report, reportOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.UpdateReport: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **report** | [**Report**](Report.md)| Report to update | 
 **reportOid** | **int?**| The report oid to update. | 

### Return type

[**ReportResponse**](ReportResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

