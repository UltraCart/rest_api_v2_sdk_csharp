
# com.ultracart.admin.v2.Model.SfvbThemeDuplicateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Folder** | **string** | Directory name for the new theme under /themes/.  Letters and numbers; it is cleansed before use.  Must not already exist - a collision is refused rather than resolved, because silently creating a differently named theme leaves you unsure what you made. | [optional] 
**TargetStorefrontOid** | **int** | Storefront to create the copy on.  Defaults to the storefront in the path.  Supply it only when copying a theme between storefronts you own. | [optional] 
**ThemeName** | **string** | Name for the new theme. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

