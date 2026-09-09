
# com.ultracart.admin.v2.Model.SfvbThemeAttributesResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** | True when this theme is the one serving live traffic.  Changing an active theme&#39;s colours changes what shoppers see immediately, so the write requires the sfvb_publish scope.  Duplicate the theme and restyle the copy to work with an ordinary write scope. | [optional] 
**Attributes** | [**List&lt;SfvbThemeAttribute&gt;**](SfvbThemeAttribute.md) | Every slot this theme has, including ones declared by a template but never set.  Sorted by name. | [optional] 
**ThemeName** | **string** | Theme name, so a caller can confirm it is working on the theme it meant. | [optional] 
**ThemeOid** | **int** | StoreFront theme oid these belong to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

