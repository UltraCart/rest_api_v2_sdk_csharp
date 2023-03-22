
# com.ultracart.admin.v2.Model.ReportExecuteQueriesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientUuid** | **string** | Unique UUID assigned to this client during the auth.  This will be used to locate the websocket connect id. | [optional] 
**ConnectionId** | **string** | The websocket connection id that should receive back notices of query completion. | [optional] 
**DefaultDatasetId** | **string** |  | [optional] 
**DefaultProjectId** | **string** |  | [optional] 
**MerchantId** | **string** |  | [optional] 
**Queries** | [**List&lt;ReportDataSetQuery&gt;**](ReportDataSetQuery.md) | An array of queries that we want the lambda function to execute. | [optional] 
**SecurityLevel** | **string** | Security level to execute report under | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

