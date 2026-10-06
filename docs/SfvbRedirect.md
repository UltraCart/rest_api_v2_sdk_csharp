
# com.ultracart.admin.v2.Model.SfvbRedirect

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedDts** | **string** | When SFVB created the rule, ISO 8601.  Empty for rules created in the admin. | [optional] 
**ExcludeFromSitemap** | **bool** | Whether the source is left out of the generated sitemap. | [optional] 
**HashSha256** | **string** | Send back as If-Match to update or delete the rule. | [optional] 
**ModifiedDts** | **string** | When SFVB last changed the rule, ISO 8601. | [optional] 
**Note** | **string** | Why the rule exists. | [optional] 
**PinnedPagePath** | **string** | When the rule is pinned to a page, that page&#39;s current path.  The target follows the page. | [optional] 
**RedirectId** | **int** | The rule&#39;s id. | [optional] 
**Source** | **string** | The path the rule catches, as stored.  A trailing /_* catches everything below it. | [optional] 
**Status** | **string** | 301, 302 (to another site, admin rules only) or rewrite (an admin rule serving the target at the source with a 200).  Rules written through SFVB are always 301. | [optional] 
**Target** | **string** | Where the rule sends the shopper. | [optional] 
**TargetInvalid** | **bool** | True when the target is a page or item that does not exist. | [optional] 
**TargetInvalidMessage** | **string** | Why the target is invalid. | [optional] 
**Type** | **string** | exact or pattern. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

