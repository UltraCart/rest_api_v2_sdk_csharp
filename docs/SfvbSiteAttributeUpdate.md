
# com.ultracart.admin.v2.Model.SfvbSiteAttributeUpdate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Attribute name.  Matched without regard to case against what the storefront already has, so you do not have to reproduce the exact casing.  A name nothing matches creates a new attribute. | [optional] 
**Type** | **string** | Only consulted when creating an attribute no template declares.  For a declared attribute the template&#39;s type always wins, because the templates decide it and not the caller. | [optional] 
**Value** | **string** | The value to store.  An empty string clears it.  For html the markup is stored as given and rendered as given.  For boolean send the text true or false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

