
# com.ultracart.admin.v2.Model.SfvbCompileRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cjson** | **string** | The container JSON to compile. | [optional] 
**ContainerName** | **string** | Optional container name, used to derive the container id the same way a .cjson file name would.  Omit and the id on the document is kept. | [optional] 
**StorefrontOid** | **int** | Optional storefront oid.  Required when theme_oid is supplied. | [optional] 
**ThemeOid** | **int** | Optional theme oid.  Supplies the theme&#39;s inherit groups configuration so compilation matches what the theme would produce.  Omit to compile without inheritance. | [optional] 
**Validate** | **bool** | Run validation before compiling and fail on errors.  Defaults to true. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

