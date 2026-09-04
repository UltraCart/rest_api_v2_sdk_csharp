
# com.ultracart.admin.v2.Model.SfvbThemeJobResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Complete** | **bool** | True once the job has stopped, whether it succeeded or failed. | [optional] 
**Description** | **string** | Human readable description of the job. | [optional] 
**ErrorMessage** | **string** | Failure detail.  Populated only when status is error. | [optional] 
**FinishedDts** | **string** | When the job stopped.  Null until it does. | [optional] 
**JobId** | **int** | Job handle.  Poll getSfvbThemeJob with this. | [optional] 
**Progress** | **int** | Percent complete, 0-100. | [optional] 
**ProgressDescription** | **string** | What the job is doing right now, for example &#39;Duplicating locale text&#39;. | [optional] 
**StartedDts** | **string** | When the job started running.  Null until it does. | [optional] 
**Status** | **string** | Raw job status. | [optional] 
**SubmittedDts** | **string** | When the job was queued. | [optional] 
**Success** | **bool** | True only when the job finished successfully.  Check complete first. | [optional] 
**TargetPath** | **string** | Path the new theme is being created at.  Returned when the job is started and on every poll, so you do not have to keep the response that started it.  The theme oid itself is NOT returned, so once the job completes you list themes and match on this path.  It is also what success is checked against - a finished job whose theme is not here reports success false rather than pretending. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

