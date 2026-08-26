
# com.ultracart.admin.v2.Model.BulkJob

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompletedAt** | **string** | When the job reached a terminal status | [optional] 
**DuplicateCount** | **int** | Records short-circuited as duplicates | [optional] 
**ErrorCode** | **string** | Job-level failure code when status is failed | [optional] 
**FailCount** | **int** | Records that failed | [optional] 
**JobId** | **string** | Public-facing job id (uc-bulk-&lt;ulid&gt;) | [optional] 
**Object** | **string** | Object type this job processes | [optional] 
**Operation** | **string** | Mutation mode this job runs (the bulk surface is write-only) | [optional] 
**ProcessedRecords** | **int** | Records processed so far | [optional] 
**QueuePosition** | **int** | Position behind the merchant&#39;s active job (queued jobs only) | [optional] 
**ResultsSummaryUrl** | **string** | Presigned S3 URL to the full per-record results NDJSON (set when finished) | [optional] 
**StartedAt** | **string** | When the worker started the job | [optional] 
**Status** | **string** | Job status | [optional] 
**SubmittedAt** | **string** | When the job was submitted | [optional] 
**SuccessCount** | **int** | Records that landed | [optional] 
**TotalRecords** | **int** | Total records counted on the first pass (null until counted) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

