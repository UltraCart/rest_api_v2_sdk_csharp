
# com.ultracart.admin.v2.Model.SfvbThemesResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveThemeOid** | **int** | Oid of the active theme, repeated here so a caller does not have to scan the list. | [optional] 
**ThemeCount** | **int** | How many themes the storefront holds now.  When it equals theme_limit, delete an inactive theme in the admin before duplicating. | [optional] 
**ThemeLimit** | **int** | Most themes a storefront can hold, active and inactive together.  A duplicate or install at the limit is refused with sfvb.theme_limit_reached. | [optional] 
**Themes** | [**List&lt;SfvbTheme&gt;**](SfvbTheme.md) | Themes belonging to the storefront.  Exactly one is flagged active. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

