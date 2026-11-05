
# com.ultracart.admin.v2.Model.SfvbCommsSequenceStatsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CommunicationSequenceUuid** | **string** | The sequence. | [optional] 
**Days** | **int** | The window, in days, for the step counts. | [optional] 
**Notes** | **List&lt;string&gt;** | What the windows are and what a missing count means. | [optional] 
**Overall** | [**SfvbCommsStat**](SfvbCommsStat.md) |  | [optional] 
**Steps** | [**List&lt;SfvbCommsStepStat&gt;**](SfvbCommsStepStat.md) | Each email, SMS, postcard and branch step, in the stored order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

