
# com.ultracart.admin.v2.Model.SfvbApproval

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | The gated action. | [optional] 
**ApprovalId** | **string** | Send this as the Approval-Id header on the gated call once status is approved. | [optional] 
**ApprovalUrl** | **string** | The page where the person approves or denies.  Show it to them.  Never open or fill it in yourself. | [optional] 
**CreatedAt** | **string** | When the request was made, ISO 8601 UTC. | [optional] 
**Description** | **string** | The sentence the person reads before approving.  Written by the server, not the agent. | [optional] 
**ExpiresAt** | **string** | When this approval stops being usable, ISO 8601 UTC.  For a pending request, when it lapses undecided.  For an approved one, when it must have been used by. | [optional] 
**ExpiresInSeconds** | **int** | Seconds until expires_at.  Zero once passed. | [optional] 
**FreshCodeRequired** | **bool** | True when the person must enter a new 2FA code for this request even inside an approval session. | [optional] 
**IntervalSeconds** | **int** | Poll no more often than this. | [optional] 
**Outcome** | **string** | Once used, succeeded or failed.  Used with no outcome means the result is unknown.  Check the target and never send the call again with this approval. | [optional] 
**OutcomeCode** | **string** | The error code the gated call failed with. | [optional] 
**OutcomeHttpStatus** | **int** | The HTTP status the gated call answered with. | [optional] 
**Params** | [**SfvbApprovalParams**](SfvbApprovalParams.md) |  | [optional] 
**Reason** | **string** | The reason the agent sent, as stored and shown (cleaned and capped). | [optional] 
**Scope** | **string** | Where the action applies.  The storefront host name, or account for account-wide actions. | [optional] 
**Status** | **string** | pending, approved, denied, cancelled, expired or used.  Only approved may be sent with the gated call. | [optional] 
**StorefrontOid** | **int** | The storefront the action runs on.  Absent for account-wide actions. | [optional] 
**UsedAt** | **string** | When the gated call used this approval, ISO 8601 UTC. | [optional] 
**UserCode** | **string** | Short matching code.  Print it next to approval_url so the person can check the page shows the same code. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

