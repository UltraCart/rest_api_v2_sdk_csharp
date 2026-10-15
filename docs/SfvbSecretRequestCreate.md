
# com.ultracart.admin.v2.Model.SfvbSecretRequestCreate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Keys** | **List&lt;string&gt;** | Bulk.  One handle per key and sink, and each key is that handle&#39;s target, such as one sending domain per key.  At most 500 handles in all. | [optional] 
**Label** | **string** | A short name the person sees, marked as unverified.  At most 120 characters. | [optional] 
**Reason** | **string** | Why the agent needs it.  Shown to the person, marked as unverified.  At most 500 characters. | [optional] 
**Sinks** | **List&lt;string&gt;** | The secret fields to collect, by sink id.  GET secrets/kinds lists them.  All must take the same kind of target. | [optional] 
**TargetId** | **string** | The object the values are for.  A Twilio account by its account SID (AC followed by 32 hex digits), and a sending domain by the domain name, which may be one not added yet.  Required for sinks that need an authenticator code, unless keys names the targets.  Leave it out when keys is sent. | [optional] 
**TtlSeconds** | **int** | How long each handle stays usable once the values are entered.  60 to 86400, default 3600. | [optional] 
**Uses** | **int** | How many writes each handle may make.  1 to 100, default 1. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

