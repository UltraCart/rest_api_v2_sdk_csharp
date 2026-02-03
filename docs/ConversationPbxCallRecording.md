# com.ultracart.admin.v2.Model.ConversationPbxCallRecording
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Channels** | **int?** | Number of audio channels in the recording (1 for mono, 2 for stereo/dual-channel) | [optional] 
**DurationSeconds** | **int?** | Duration of the recording in seconds | [optional] 
**IsPrimary** | **bool?** | Whether this is the primary recording for the call | [optional] 
**RecordingS3Key** | **string** | S3 key for the recording audio file | [optional] 
**RecordingSid** | **string** | Twilio recording SID | [optional] 
**RecordingUrl** | **string** | URL to access the recording | [optional] 
**Status** | **string** | Status of the recording | [optional] 
**Transcript** | [**ConversationPbxCallTranscript**](ConversationPbxCallTranscript.md) |  | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

