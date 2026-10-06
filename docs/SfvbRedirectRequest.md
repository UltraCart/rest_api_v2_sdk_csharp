
# com.ultracart.admin.v2.Model.SfvbRedirectRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Note** | **string** | Why the rule exists, up to 500 characters. | [optional] 
**OverLivePage** | **bool** | Allow a source that is a live, visible page or item, which the rule then hides. | [optional] 
**Source** | **string** | The path to catch, starting with /.  End it with /_* to catch everything below. | [optional] 
**Status** | **string** | Updates only.  301 turns an admin rule into a permanent redirect.  Leave empty to keep the rule&#39;s status.  New rules are always 301. | [optional] 
**Target** | **string** | A path on the storefront, or a URL on one of its own hosts. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

