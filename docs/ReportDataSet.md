# com.ultracart.admin.v2.Model.ReportDataSet
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataSetQueryUuid** | **string** | A unique identifier assigned to the data set query that is returned. | [optional] 
**DataSetUuid** | **string** | A unique identifier assigned to the data set that is returned. | [optional] 
**DestinationTableId** | **string** | The BigQuery destination table id that contains the result. | [optional] 
**ErrorMessage** | **string** | Error message if the query failed. | [optional] 
**ExecutedSql** | **string** |  | [optional] 
**ForObjectId** | **string** | An identifier that can be used to help match up the returned data set | [optional] 
**ForObjectType** | **string** | The type of object this data set is for | [optional] 
**InitialPages** | [**List&lt;ReportDataSetPage&gt;**](ReportDataSetPage.md) | Initial pages returned in the dataset | [optional] 
**MaxResults** | **long?** | The total number of results | [optional] 
**MerchantId** | **string** | Merchant that owns this data set | [optional] 
**PageCount** | **int?** | The total number of pages in the result set | [optional] 
**PageSize** | **int?** | The size of the pages | [optional] 
**RequestDts** | **string** | Date/Time of the client submitted the request.  Can be used to resolve out of order query completion results | [optional] 
**Schema** | [**List&lt;ReportDataSetSchema&gt;**](ReportDataSetSchema.md) | The schema associated with the data set. | [optional] 
**SecurityLevel** | **string** | Security level this dataset was read from. | [optional] 
**Timezone** | **string** |  | [optional] 
**UserData** | **string** | Any other data that needs to be returned with the response to help the UI | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

