# com.ultracart.admin.v2.Model.ReportDataSetQuery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComparisonResults** | **bool?** | True if a date range filter is provided with comparison date ranges and two results should be returned for the query. | [optional] 
**DataSetQueryUuid** | **string** | A unique identifier assigned to the data set query that is returned. | [optional] 
**DataSource** | [**ReportDataSource**](ReportDataSource.md) |  | [optional] 
**Dimensions** | [**List&lt;ReportPageVisualizationDimension&gt;**](ReportPageVisualizationDimension.md) |  | [optional] 
**Filter** | [**ReportFilter**](ReportFilter.md) |  | [optional] 
**ForObjectId** | **string** | An identifier that can be used to help match up the returned data set | [optional] 
**ForObjectType** | **string** | The type of object this data set is for | [optional] 
**Metrics** | [**List&lt;ReportPageVisualizationMetric&gt;**](ReportPageVisualizationMetric.md) |  | [optional] 
**OrderByColumns** | [**List&lt;ReportDataSetQueryOrderByColumn&gt;**](ReportDataSetQueryOrderByColumn.md) | The columns to order by in the final result.  If not specified the dimensions will be used | [optional] 
**PageSize** | **int?** | Result set page size.  The default value is 200 records.  Max is 10000. | [optional] 
**SelectedFilters** | [**List&lt;ReportFilter&gt;**](ReportFilter.md) |  | [optional] 
**SkipCache** | **bool?** | True if the 15 minute cache should be skipped. | [optional] 
**UserData** | **string** | Any other data that needs to be returned with the response to help the UI | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

