
# com.ultracart.admin.v2.Model.SfvbNotFoundSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Last24Hours** | **List&lt;int&gt;** | 404 hits per hour for the last 24 hours, oldest first. | [optional] 
**Last30Days** | **List&lt;int&gt;** | 404 hits per day, oldest first, ending today in the server&#39;s time zone.  Bots and shoppers together. | [optional] 
**Last7Days** | **List&lt;int&gt;** | 404 hits per day for the last 7 days, oldest first. | [optional] 
**NewPaths** | [**List&lt;SfvbNotFoundEntry&gt;**](SfvbNotFoundEntry.md) | Up to 10 open paths first seen in the last 30 days, most hits first, leaving out paths only bots have hit. | [optional] 
**Notes** | **List&lt;string&gt;** | What a person should know about reading these counts. | [optional] 
**Total30Days** | **int** | The sum of last_30_days. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

