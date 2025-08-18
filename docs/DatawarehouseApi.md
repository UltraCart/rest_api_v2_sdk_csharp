# com.ultracart.admin.v2.Api.DatawarehouseApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCustomDashboard**](DatawarehouseApi.md#deletecustomdashboard) | **DELETE** /datawarehouse/custom_dashboards/{custom_dashboard_oid} | Delete a custom dashboard
[**DeleteCustomDashboardSchedule**](DatawarehouseApi.md#deletecustomdashboardschedule) | **DELETE** /datawarehouse/custom_dashboards/{custom_dashboard_oid}/schedules/{custom_dashboard_schedule_oid} | Delete a custom dashboard schedule
[**DeleteCustomReport**](DatawarehouseApi.md#deletecustomreport) | **DELETE** /datawarehouse/custom_reports/{custom_report_oid} | Delete a custom report
[**DeleteReport**](DatawarehouseApi.md#deletereport) | **DELETE** /datawarehouse/reports/{report_oid} | Delete a report
[**DryRunReportQueries**](DatawarehouseApi.md#dryrunreportqueries) | **PUT** /datawarehouse/reports/dryrun | Dry run the report queries
[**ExecuteCustomReport**](DatawarehouseApi.md#executecustomreport) | **PUT** /datawarehouse/custom_reports/{custom_report_oid}/execute | Execute a custom report
[**ExecuteCustomReports**](DatawarehouseApi.md#executecustomreports) | **PUT** /datawarehouse/custom_reports/execute | Execute a custom reports
[**ExecuteReportQueries**](DatawarehouseApi.md#executereportqueries) | **PUT** /datawarehouse/reports/execute | Execute the report queries
[**GetCustomDashboard**](DatawarehouseApi.md#getcustomdashboard) | **GET** /datawarehouse/custom_dashboards/{custom_dashboard_oid} | Get a custom dashboard
[**GetCustomDashboardSchedules**](DatawarehouseApi.md#getcustomdashboardschedules) | **GET** /datawarehouse/custom_dashboards/{custom_dashboard_oid}/schedules | Get custom dashboards
[**GetCustomDashboards**](DatawarehouseApi.md#getcustomdashboards) | **GET** /datawarehouse/custom_dashboards | Get custom dashboards
[**GetCustomReport**](DatawarehouseApi.md#getcustomreport) | **GET** /datawarehouse/custom_reports/{custom_report_oid} | Get a custom report
[**GetCustomReportAccountConfig**](DatawarehouseApi.md#getcustomreportaccountconfig) | **GET** /datawarehouse/custom_reports/account_config | Get custom report account configuration
[**GetCustomReports**](DatawarehouseApi.md#getcustomreports) | **GET** /datawarehouse/custom_reports | Get custom reports
[**GetReport**](DatawarehouseApi.md#getreport) | **GET** /datawarehouse/reports/{report_oid} | Get a report
[**GetReportDataSet**](DatawarehouseApi.md#getreportdataset) | **GET** /datawarehouse/reports/dataset/{dataset_uuid} | Get a report data set
[**GetReportDataSetPage**](DatawarehouseApi.md#getreportdatasetpage) | **GET** /datawarehouse/reports/dataset/{dataset_uuid}/pages/{page_number} | Get a report data set page
[**GetReportWebsocketAuthorization**](DatawarehouseApi.md#getreportwebsocketauthorization) | **PUT** /datawarehouse/reports/auth | Get report websocket authorization
[**GetReports**](DatawarehouseApi.md#getreports) | **GET** /datawarehouse/reports | Get list of reports available
[**InsertCustomDashboard**](DatawarehouseApi.md#insertcustomdashboard) | **POST** /datawarehouse/custom_dashboards | Create a custom dashboard
[**InsertCustomDashboardSchedule**](DatawarehouseApi.md#insertcustomdashboardschedule) | **POST** /datawarehouse/custom_dashboards/{custom_dashboard_oid}/schedules | Create a custom dashboard schedule
[**InsertCustomReport**](DatawarehouseApi.md#insertcustomreport) | **POST** /datawarehouse/custom_reports | Create a custom report
[**InsertReport**](DatawarehouseApi.md#insertreport) | **POST** /datawarehouse/reports | Create a report
[**UpdateCustomDashboard**](DatawarehouseApi.md#updatecustomdashboard) | **PUT** /datawarehouse/custom_dashboards/{custom_dashboard_oid} | Update a custom dashboard
[**UpdateCustomDashboardSchedule**](DatawarehouseApi.md#updatecustomdashboardschedule) | **PUT** /datawarehouse/custom_dashboards/{custom_dashboard_oid}/schedules/{custom_dashboard_schedule_oid} | Update a custom dashboard schedule
[**UpdateCustomReport**](DatawarehouseApi.md#updatecustomreport) | **PUT** /datawarehouse/custom_reports/{custom_report_oid} | Update a custom report
[**UpdateCustomReportAccountConfig**](DatawarehouseApi.md#updatecustomreportaccountconfig) | **PUT** /datawarehouse/custom_reports/account_config | Update custom report account config
[**UpdateReport**](DatawarehouseApi.md#updatereport) | **PUT** /datawarehouse/reports/{report_oid} | Update a report


<a name="deletecustomdashboard"></a>
# **DeleteCustomDashboard**
> void DeleteCustomDashboard (int? customDashboardOid)

Delete a custom dashboard

Delete a custom dashboard on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteCustomDashboardExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var customDashboardOid = 56;  // int? | The dashboard oid to delete.

            try
            {
                // Delete a custom dashboard
                apiInstance.DeleteCustomDashboard(customDashboardOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.DeleteCustomDashboard: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customDashboardOid** | **int?**| The dashboard oid to delete. | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomdashboardschedule"></a>
# **DeleteCustomDashboardSchedule**
> void DeleteCustomDashboardSchedule (int? customDashboardScheduleOid, int? customDashboardOid)

Delete a custom dashboard schedule

delete a custom dashboard schedule on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteCustomDashboardScheduleExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var customDashboardScheduleOid = 56;  // int? | The dashboard schedule oid to delete.
            var customDashboardOid = 56;  // int? | The dashboard oid that owns the schedule.

            try
            {
                // Delete a custom dashboard schedule
                apiInstance.DeleteCustomDashboardSchedule(customDashboardScheduleOid, customDashboardOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.DeleteCustomDashboardSchedule: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customDashboardScheduleOid** | **int?**| The dashboard schedule oid to delete. | 
 **customDashboardOid** | **int?**| The dashboard oid that owns the schedule. | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomreport"></a>
# **DeleteCustomReport**
> void DeleteCustomReport (int? customReportOid)

Delete a custom report

Delete a custom report on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteCustomReportExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var customReportOid = 56;  // int? | The report oid to delete.

            try
            {
                // Delete a custom report
                apiInstance.DeleteCustomReport(customReportOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.DeleteCustomReport: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customReportOid** | **int?**| The report oid to delete. | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

<a name="dryrunreportqueries"></a>
# **DryRunReportQueries**
> ReportDryRunQueriesResponse DryRunReportQueries (ReportDryRunQueriesRequest queryRequest)

Dry run the report queries

Dry run the report queries 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DryRunReportQueriesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var queryRequest = new ReportDryRunQueriesRequest(); // ReportDryRunQueriesRequest | Dry run request

            try
            {
                // Dry run the report queries
                ReportDryRunQueriesResponse result = apiInstance.DryRunReportQueries(queryRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.DryRunReportQueries: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queryRequest** | [**ReportDryRunQueriesRequest**](ReportDryRunQueriesRequest.md)| Dry run request | 

### Return type

[**ReportDryRunQueriesResponse**](ReportDryRunQueriesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executecustomreport"></a>
# **ExecuteCustomReport**
> CustomReportExecutionResponse ExecuteCustomReport (CustomReportExecutionRequest executionRequest, int? customReportOid)

Execute a custom report

Execute a custom report on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ExecuteCustomReportExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var executionRequest = new CustomReportExecutionRequest(); // CustomReportExecutionRequest | Request to execute custom report
            var customReportOid = 56;  // int? | The report oid to execute.

            try
            {
                // Execute a custom report
                CustomReportExecutionResponse result = apiInstance.ExecuteCustomReport(executionRequest, customReportOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.ExecuteCustomReport: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **executionRequest** | [**CustomReportExecutionRequest**](CustomReportExecutionRequest.md)| Request to execute custom report | 
 **customReportOid** | **int?**| The report oid to execute. | 

### Return type

[**CustomReportExecutionResponse**](CustomReportExecutionResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executecustomreports"></a>
# **ExecuteCustomReports**
> CustomReportsExecutionResponse ExecuteCustomReports (CustomReportsExecutionRequest executionRequest)

Execute a custom reports

Execute a custom reports on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ExecuteCustomReportsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var executionRequest = new CustomReportsExecutionRequest(); // CustomReportsExecutionRequest | Request to execute custom reports

            try
            {
                // Execute a custom reports
                CustomReportsExecutionResponse result = apiInstance.ExecuteCustomReports(executionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.ExecuteCustomReports: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **executionRequest** | [**CustomReportsExecutionRequest**](CustomReportsExecutionRequest.md)| Request to execute custom reports | 

### Return type

[**CustomReportsExecutionResponse**](CustomReportsExecutionResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
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

<a name="getcustomdashboard"></a>
# **GetCustomDashboard**
> CustomDashboardResponse GetCustomDashboard (int? customDashboardOid)

Get a custom dashboard

Retrieve a custom dashboard 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCustomDashboardExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var customDashboardOid = 56;  // int? | 

            try
            {
                // Get a custom dashboard
                CustomDashboardResponse result = apiInstance.GetCustomDashboard(customDashboardOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.GetCustomDashboard: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customDashboardOid** | **int?**|  | 

### Return type

[**CustomDashboardResponse**](CustomDashboardResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomdashboardschedules"></a>
# **GetCustomDashboardSchedules**
> CustomDashboardSchedulesResponse GetCustomDashboardSchedules (int? customDashboardOid)

Get custom dashboards

Retrieve a custom dashboards 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCustomDashboardSchedulesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var customDashboardOid = 56;  // int? | 

            try
            {
                // Get custom dashboards
                CustomDashboardSchedulesResponse result = apiInstance.GetCustomDashboardSchedules(customDashboardOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.GetCustomDashboardSchedules: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customDashboardOid** | **int?**|  | 

### Return type

[**CustomDashboardSchedulesResponse**](CustomDashboardSchedulesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomdashboards"></a>
# **GetCustomDashboards**
> CustomDashboardsResponse GetCustomDashboards ()

Get custom dashboards

Retrieve a custom dashboards 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCustomDashboardsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);


            try
            {
                // Get custom dashboards
                CustomDashboardsResponse result = apiInstance.GetCustomDashboards();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.GetCustomDashboards: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CustomDashboardsResponse**](CustomDashboardsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomreport"></a>
# **GetCustomReport**
> CustomReportResponse GetCustomReport (int? customReportOid)

Get a custom report

Retrieve a custom report 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCustomReportExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var customReportOid = 56;  // int? | 

            try
            {
                // Get a custom report
                CustomReportResponse result = apiInstance.GetCustomReport(customReportOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.GetCustomReport: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customReportOid** | **int?**|  | 

### Return type

[**CustomReportResponse**](CustomReportResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomreportaccountconfig"></a>
# **GetCustomReportAccountConfig**
> CustomReportAccountConfigResponse GetCustomReportAccountConfig ()

Get custom report account configuration

Retrieve a custom report account configuration 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCustomReportAccountConfigExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);


            try
            {
                // Get custom report account configuration
                CustomReportAccountConfigResponse result = apiInstance.GetCustomReportAccountConfig();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.GetCustomReportAccountConfig: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CustomReportAccountConfigResponse**](CustomReportAccountConfigResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomreports"></a>
# **GetCustomReports**
> CustomReportsResponse GetCustomReports ()

Get custom reports

Retrieve a custom reports 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCustomReportsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);


            try
            {
                // Get custom reports
                CustomReportsResponse result = apiInstance.GetCustomReports();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.GetCustomReports: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CustomReportsResponse**](CustomReportsResponse.md)

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

<a name="insertcustomdashboard"></a>
# **InsertCustomDashboard**
> CustomDashboardResponse InsertCustomDashboard (CustomDashboard dashboard)

Create a custom dashboard

Create a new custom dashboard on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertCustomDashboardExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var dashboard = new CustomDashboard(); // CustomDashboard | Dashboard to create

            try
            {
                // Create a custom dashboard
                CustomDashboardResponse result = apiInstance.InsertCustomDashboard(dashboard);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.InsertCustomDashboard: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dashboard** | [**CustomDashboard**](CustomDashboard.md)| Dashboard to create | 

### Return type

[**CustomDashboardResponse**](CustomDashboardResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertcustomdashboardschedule"></a>
# **InsertCustomDashboardSchedule**
> CustomDashboardScheduleResponse InsertCustomDashboardSchedule (int? customDashboardOid, CustomDashboardSchedule dashboardSchedule)

Create a custom dashboard schedule

Create a new custom dashboard schedule on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertCustomDashboardScheduleExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var customDashboardOid = 56;  // int? | 
            var dashboardSchedule = new CustomDashboardSchedule(); // CustomDashboardSchedule | Dashboard schedule to create

            try
            {
                // Create a custom dashboard schedule
                CustomDashboardScheduleResponse result = apiInstance.InsertCustomDashboardSchedule(customDashboardOid, dashboardSchedule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.InsertCustomDashboardSchedule: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customDashboardOid** | **int?**|  | 
 **dashboardSchedule** | [**CustomDashboardSchedule**](CustomDashboardSchedule.md)| Dashboard schedule to create | 

### Return type

[**CustomDashboardScheduleResponse**](CustomDashboardScheduleResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertcustomreport"></a>
# **InsertCustomReport**
> CustomReportResponse InsertCustomReport (CustomReport report)

Create a custom report

Create a new custom report on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertCustomReportExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var report = new CustomReport(); // CustomReport | Report to create

            try
            {
                // Create a custom report
                CustomReportResponse result = apiInstance.InsertCustomReport(report);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.InsertCustomReport: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **report** | [**CustomReport**](CustomReport.md)| Report to create | 

### Return type

[**CustomReportResponse**](CustomReportResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
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

<a name="updatecustomdashboard"></a>
# **UpdateCustomDashboard**
> CustomDashboardResponse UpdateCustomDashboard (CustomDashboard dashboard, int? customDashboardOid)

Update a custom dashboard

Update a custom dashboard on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateCustomDashboardExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var dashboard = new CustomDashboard(); // CustomDashboard | Dashboard to custom update
            var customDashboardOid = 56;  // int? | The dashboard oid to custom update.

            try
            {
                // Update a custom dashboard
                CustomDashboardResponse result = apiInstance.UpdateCustomDashboard(dashboard, customDashboardOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.UpdateCustomDashboard: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dashboard** | [**CustomDashboard**](CustomDashboard.md)| Dashboard to custom update | 
 **customDashboardOid** | **int?**| The dashboard oid to custom update. | 

### Return type

[**CustomDashboardResponse**](CustomDashboardResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomdashboardschedule"></a>
# **UpdateCustomDashboardSchedule**
> CustomDashboardResponse UpdateCustomDashboardSchedule (CustomDashboardSchedule dashboardSchedule, int? customDashboardScheduleOid, int? customDashboardOid)

Update a custom dashboard schedule

Update a custom dashboard schedule on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateCustomDashboardScheduleExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var dashboardSchedule = new CustomDashboardSchedule(); // CustomDashboardSchedule | Dashboard schedule to update
            var customDashboardScheduleOid = 56;  // int? | The dashboard schedule oid to update.
            var customDashboardOid = 56;  // int? | The dashboard oid to update.

            try
            {
                // Update a custom dashboard schedule
                CustomDashboardResponse result = apiInstance.UpdateCustomDashboardSchedule(dashboardSchedule, customDashboardScheduleOid, customDashboardOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.UpdateCustomDashboardSchedule: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dashboardSchedule** | [**CustomDashboardSchedule**](CustomDashboardSchedule.md)| Dashboard schedule to update | 
 **customDashboardScheduleOid** | **int?**| The dashboard schedule oid to update. | 
 **customDashboardOid** | **int?**| The dashboard oid to update. | 

### Return type

[**CustomDashboardResponse**](CustomDashboardResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomreport"></a>
# **UpdateCustomReport**
> CustomReportResponse UpdateCustomReport (CustomReport report, int? customReportOid)

Update a custom report

Update a custom report on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateCustomReportExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var report = new CustomReport(); // CustomReport | Report to custom update
            var customReportOid = 56;  // int? | The report oid to custom update.

            try
            {
                // Update a custom report
                CustomReportResponse result = apiInstance.UpdateCustomReport(report, customReportOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.UpdateCustomReport: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **report** | [**CustomReport**](CustomReport.md)| Report to custom update | 
 **customReportOid** | **int?**| The report oid to custom update. | 

### Return type

[**CustomReportResponse**](CustomReportResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomreportaccountconfig"></a>
# **UpdateCustomReportAccountConfig**
> CustomReportAccountConfigResponse UpdateCustomReportAccountConfig (CustomReportAccountConfig accountConfig)

Update custom report account config

Update custom report account config. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateCustomReportAccountConfigExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new DatawarehouseApi(simpleKey);

            var accountConfig = new CustomReportAccountConfig(); // CustomReportAccountConfig | Account config to update

            try
            {
                // Update custom report account config
                CustomReportAccountConfigResponse result = apiInstance.UpdateCustomReportAccountConfig(accountConfig);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatawarehouseApi.UpdateCustomReportAccountConfig: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountConfig** | [**CustomReportAccountConfig**](CustomReportAccountConfig.md)| Account config to update | 

### Return type

[**CustomReportAccountConfigResponse**](CustomReportAccountConfigResponse.md)

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

