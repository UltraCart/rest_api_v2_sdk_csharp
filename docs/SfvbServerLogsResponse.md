
# com.ultracart.admin.v2.Model.SfvbServerLogsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Limit** | **int** | The most logs returned. | [optional] 
**Logs** | [**List&lt;SfvbServerLog&gt;**](SfvbServerLog.md) | Matching logs, newest first, without their text. | [optional] 
**MoreAvailable** | **bool** | True when older logs in the window were not read.  Narrow since, or page by moving since back. | [optional] 
**Searched** | **int** | How many of the newest logs in the window were read to find these. | [optional] 
**Since** | **string** | The start of the window searched, ISO-8601 in UTC.  Logs are kept for seven days. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

