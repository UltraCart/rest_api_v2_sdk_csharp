
# com.ultracart.admin.v2.Model.SfvbErrorDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | Stable machine readable code.  Namespaced sfvb.*  Safe to match on; these are never reworded. | [optional] 
**Column** | **int** | 1-indexed column number.  Populated for Velocity problems. | [optional] 
**DidYouMean** | **List&lt;string&gt;** | Close matches for an unrecognized value, best match first.  Populated for unknown element types and unknown configuration keys. | [optional] 
**Expected** | **string** | Description of what was expected instead. | [optional] 
**Found** | **string** | The value that was actually found, when the problem is about a value. | [optional] 
**Line** | **int** | 1-indexed line number.  Populated for Velocity problems; null for CJSON problems, which carry a pointer instead. | [optional] 
**Message** | **string** | Human readable description of the problem. | [optional] 
**Pointer** | **string** | JSON Pointer (RFC 6901) to the offending node within the submitted CJSON.  Null for whole-document problems. | [optional] 
**Severity** | **string** | error or warning.  Warnings never fail a request. | [optional] 
**Suggestion** | **string** | Optional pointer at a known good example, typically a storefront library fragment that solves the same problem properly. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

