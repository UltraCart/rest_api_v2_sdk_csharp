
# com.ultracart.admin.v2.Model.SfvbRedirectDeleteRowResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HashSha256** | **string** | The rule&#39;s current hash.  Absent when not_found. | [optional] 
**Note** | **string** | The rule&#39;s note. | [optional] 
**RedirectId** | **int** | The rule. | [optional] 
**Result** | **string** | deletable, stale (the rule changed since its hash was read), not_found, or deleted after an apply. | [optional] 
**Source** | **string** | The rule&#39;s source, for a backup. | [optional] 
**Status** | **string** | The rule&#39;s status (301, 302 or rewrite). | [optional] 
**Target** | **string** | The rule&#39;s target, for a backup. | [optional] 
**Type** | **string** | exact or pattern. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

