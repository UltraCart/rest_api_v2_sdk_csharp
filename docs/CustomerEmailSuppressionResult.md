
# com.ultracart.admin.v2.Model.CustomerEmailSuppressionResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BounceCleared** | **bool** | True only if this call actually removed bounce suppression.  Bounce has no per-customer flag, so there is no corresponding state field. | [optional] 
**CustomerProfileOid** | **int** | The customer profile oid that was operated on | [optional] 
**Email** | **string** | The email address that was operated on | [optional] 
**EspSuppressionRemoved** | **bool** | True only if every requested suppression surface was successfully cleared.  When false, see esp_warning - - the profile was still modified. | [optional] 
**EspWarning** | **string** | Human readable explanation when esp_suppression_removed is false.  Suitable for display to a support agent. | [optional] 
**GlobalUnsubscribeCleared** | **bool** | True only if this call actually changed the global unsubscribe flag.  False if it was already clear. | [optional] 
**GlobalUnsubscribed** | **bool** | Global unsubscribe state AFTER this call | [optional] 
**GlobalUnsubscribedDts** | **string** | Global unsubscribe timestamp after this call.  Nulled when cleared; the prior value is retained on the audit record. | [optional] 
**SpamComplaint** | **bool** | Spam complaint state AFTER this call | [optional] 
**SpamComplaintCleared** | **bool** | True only if this call actually changed the spam complaint flag.  False if it was already clear. | [optional] 
**SpamComplaintDts** | **string** | Spam complaint timestamp after this call.  Nulled when cleared; the prior value is retained on the audit record. | [optional] 
**SuppressionSurfaces** | [**EmailSuppressionSurfaces**](EmailSuppressionSurfaces.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

