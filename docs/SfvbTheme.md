
# com.ultracart.admin.v2.Model.SfvbTheme

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** | True when this theme is the one serving live traffic.  Writing to an active theme requires the sfvb_publish scope. | [optional] 
**Description** | **string** | What the theme is, where the author supplied a description. | [optional] 
**FsDirectoryOid** | **int** | Oid of the theme root directory in the storefront file system. | [optional] 
**Path** | **string** | Root path of the theme in the storefront file system, for example /themes/mytheme/ | [optional] 
**StorefrontOid** | **int** | StoreFront oid this theme belongs to. | [optional] 
**ThemeName** | **string** | Theme name. | [optional] 
**ThemeOid** | **int** | StoreFront theme oid. | [optional] 
**UpgradeAvailable** | **bool** | True when a newer version of this theme exists.  Relevant because an upgrade is what produces the merge conflicts that block activation. | [optional] 
**Valid** | **bool** | False when the theme contains templates that failed validation.  Worth checking before choosing a theme to work in. | [optional] 
**_Version** | **string** | Theme version. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

