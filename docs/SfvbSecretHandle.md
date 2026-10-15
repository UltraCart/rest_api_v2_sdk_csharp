
# com.ultracart.admin.v2.Model.SfvbSecretHandle

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpiresAt** | **string** | When it stops being usable, ISO 8601 UTC. | [optional] 
**Fingerprint** | **string** | The last few characters of the value, as a mask shows them, so the person can tell values apart.  Empty until entered. | [optional] 
**Handle** | **string** | The handle.  Safe to log and keep in plans.  It works only for the sign-in that requested it. | [optional] 
**Key** | **string** | The bulk key it is for, or empty. | [optional] 
**Sink** | **string** | The secret field it can be written to. | [optional] 
**Status** | **string** | pending (no value yet), ready, in_use (a write holds it), consumed, revoked or expired. | [optional] 
**TargetId** | **string** | The object it can be written to, or empty when the request named none. | [optional] 
**UsesLeft** | **int** | Writes left.  Empty once the handle is gone. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

