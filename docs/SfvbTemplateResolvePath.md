
# com.ultracart.admin.v2.Model.SfvbTemplateResolvePath

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Candidates** | [**List&lt;SfvbTemplateResolveCandidate&gt;**](SfvbTemplateResolveCandidate.md) | Every file of that name below this path, in the order the storefront searches. | [optional] 
**DirectoryFound** | **bool** | False when the theme has no such directory, so the storefront skips this path. | [optional] 
**Match** | **string** | The candidate this path supplies, relative to the theme root, or null.  It is the first candidate that is not skipped. | [optional] 
**ResourcePath** | **string** | The resource path, relative to the theme root.  / is the theme root itself. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

