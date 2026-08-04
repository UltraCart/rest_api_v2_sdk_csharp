
# com.ultracart.admin.v2.Model.CustomerEmailSuppressionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClearBounce** | **bool** | Clear bounce suppression for this address.  Bounce has no per-customer flag; it exists only on the suppression tables. | [optional] 
**ClearGlobalUnsubscribe** | **bool** | Clear the global unsubscribe flag.  No-op if it is already clear. | [optional] 
**ClearSpamComplaint** | **bool** | Clear the spam complaint flag.  Requires a reason.  No-op if it is already clear. | [optional] 
**ConsentSource** | **string** | How the customer communicated consent. | [optional] 
**Reason** | **string** | Justification for the clear.  Required when clearing a spam complaint.  Retained on the audit record. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

