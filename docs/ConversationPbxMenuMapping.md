
# com.ultracart.admin.v2.Model.ConversationPbxMenuMapping

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | Action | [optional] 
**ActionTarget** | **string** | Action target.  This is the UUID associated with the configuration object of that particular type. | [optional] 
**Digits** | **int** | Digits | [optional] 
**SmsFromNumber** | **string** | Optional phone number to send the text message from.  Must be a phone number configured on this merchant account and SMS enabled.  Defaults to the number the caller dialed.  Only used when the action is &#39;send text&#39;. | [optional] 
**Speech** | **string** | Speech | [optional] 
**TextMessage** | **string** | Text message body sent to the caller when the action is &#39;send text&#39;.  Ignored for all other actions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

