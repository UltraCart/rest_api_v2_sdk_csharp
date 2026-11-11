
# com.ultracart.admin.v2.Model.SfvbThemeJobResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Complete** | **bool** | True once the job has stopped, whether it succeeded or failed. | [optional] 
**Description** | **string** | Human readable description of the job. | [optional] 
**ErrorMessage** | **string** | What to do next when the job did not produce a theme.  The internal cause is not returned; it is recorded against the job id in the server log. | [optional] 
**FinishedDts** | **string** | When the job stopped, ISO 8601 UTC.  Null until it does. | [optional] 
**JobId** | **int** | Job handle.  Poll getSfvbThemeJob with this. | [optional] 
**MergeConflicts** | **List&lt;string&gt;** | Paths of the copy&#39;s files that still have unresolved merge conflicts, read fresh on every poll, so the list shrinks as you resolve them.  Each needs its conflict marker lines resolved and the file saved before the theme can be activated.  Empty when there are none. | [optional] 
**Progress** | **int** | Percent complete, 0-100. | [optional] 
**ProgressDescription** | **string** | What the job is doing right now, for example &#39;Duplicating locale text&#39;. | [optional] 
**StartedDts** | **string** | When the job started running, ISO 8601 UTC.  Null until it does. | [optional] 
**Status** | **string** | Raw job status. | [optional] 
**SubmittedDts** | **string** | When the job was queued, ISO 8601 UTC. | [optional] 
**Success** | **bool** | True only when the job finished successfully.  Check complete first. | [optional] 
**TargetPath** | **string** | Path the new theme is being created at.  Returned when the job is started and on every poll, so you do not have to keep the response that started it.  Once the job completes, the theme found at this path is reported as theme_oid.  It is also what success is checked against - a finished job whose theme is not here reports success false rather than pretending. | [optional] 
**ThemeOid** | **int** | Oid of the theme the job created, once it is complete and the theme exists.  Null until then. | [optional] 
**UpgradeToVersion** | **string** | The version the copy was asked to be upgraded to, when the duplicate asked for an upgrade.  Null for a plain copy.  A complete job reports success only when the copy is at this version. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

