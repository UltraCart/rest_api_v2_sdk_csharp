
# com.ultracart.admin.v2.Model.SfvbStepDispatchLogsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Counts** | [**SfvbStepCounts**](SfvbStepCounts.md) |  | [optional] 
**Entries** | [**List&lt;SfvbStepDispatchLog&gt;**](SfvbStepDispatchLog.md) | The entries in the window, newest first. | [optional] 
**NextOffset** | **int** | Send this as offset for the next page.  Absent on the last page. | [optional] 
**Notes** | **List&lt;string&gt;** | What a person should know about reading these entries. | [optional] 
**SequenceUuid** | **string** | The communication sequence the step is in. | [optional] 
**Since** | **string** | The start of the window read, as ISO 8601. | [optional] 
**StepType** | **string** | The step&#39;s type, such as email, sms or wait. | [optional] 
**StepUuid** | **string** | The step. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

