
# com.ultracart.admin.v2.Model.SfvbMenu

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The menu&#39;s code, which is the value a menu element&#39;s menuName refers to.  Compare case insensitively. | [optional] 
**HashSha256** | **string** | Content hash of the menu as stored.  Send it back as If-Match when writing. | [optional] 
**ItemCount** | **int** | How many entries the menu holds in total, counting every level of the tree. | [optional] 
**Items** | [**List&lt;SfvbMenuItem&gt;**](SfvbMenuItem.md) | The menu&#39;s entries, in the order they render.  Omitted from the list endpoint, which returns each menu&#39;s identity and counts only. | [optional] 
**Title** | **string** | The menu&#39;s own label, shown in the store admin rather than on the storefront.  Trimmed to 250 characters. | [optional] 
**Unconfigured** | **bool** | True when a template names this code but no menu has been created for it.  Such a code renders an empty list today.  Write it to create it. | [optional] 
**Undeclared** | **bool** | True when no template on the storefront names this code.  The menu is stored and editable, but nothing renders it, which usually means a menu element&#39;s menuName is misspelled. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

