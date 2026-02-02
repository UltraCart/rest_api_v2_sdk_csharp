
# com.ultracart.admin.v2.Model.ConversationPbxCallTranscript

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FullTranscriptS3Key** | **string** | S3 key for the full transcript text file | [optional] 
**JobName** | **string** | AWS Transcribe job name | [optional] 
**LanguageCode** | **string** | Language code for transcription | [optional] 
**Provider** | **string** | Transcription service provider | [optional] 
**Segments** | [**List&lt;ConversationPbxCallTranscriptSegment&gt;**](ConversationPbxCallTranscriptSegment.md) | Transcript segments with speaker labels and timestamps | [optional] 
**Status** | **string** | Status of the transcription | [optional] 
**TranscriptJsonS3Key** | **string** | S3 key for the detailed transcript JSON with speaker diarization | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

