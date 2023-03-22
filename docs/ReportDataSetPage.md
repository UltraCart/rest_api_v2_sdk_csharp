# com.ultracart.admin.v2.Model.ReportDataSetPage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataSetUuid** | **string** | A unique identifier assigned to the data set that is returned. | [optional] 
**MerchantId** | **string** | Merchant that owns this data set | [optional] 
**NextPageToken** | **string** |  | [optional] 
**NextStartIndex** | **int?** |  | [optional] 
**PageNumber** | **int?** |  | [optional] 
**RowCount** | **int?** |  | [optional] 
**Rows** | [**List&lt;ReportDataSetRow&gt;**](ReportDataSetRow.md) | Rows returned for the data set | [optional] 
**RowsS3Url** | **string** | Signed S3 URL where the page rows can be downloaded from | [optional] 
**StartIndex** | **int?** | Zero based index of the starting row | [optional] 
**TableId** | **string** | The BigQuery destination table id that contains the result. | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

