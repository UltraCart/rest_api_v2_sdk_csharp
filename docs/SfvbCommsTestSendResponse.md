
# com.ultracart.admin.v2.Model.SfvbCommsTestSendResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Body** | **string** | For an SMS, the message as sent. | [optional] 
**Channel** | **string** | email, sms or postcard. | [optional] 
**Cost** | **decimal** | For a postcard, what this card costs the account. | [optional] 
**DryRun** | **bool** | True when nothing was sent. | [optional] 
**Notes** | **List&lt;string&gt;** | What else happened, such as records created by the test. | [optional] 
**Recipient** | **string** | Who it went to, as a user on this account (their login), or the postcard&#39;s city and state. | [optional] 
**Sent** | **bool** | True when it was sent or mailed.  False on a dry run or when it was skipped. | [optional] 
**SkippedReason** | **string** | Why it wasn&#39;t sent or mailed, when it wasn&#39;t. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

