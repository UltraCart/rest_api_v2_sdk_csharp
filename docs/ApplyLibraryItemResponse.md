# com.ultracart.admin.v2.Model.ApplyLibraryItemResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attributes** | [**List&lt;LibraryItemAttribute&gt;**](LibraryItemAttribute.md) | Attributes from the library item | [optional] 
**Cjson** | **string** | Cjson from library item, only populated if this library item was a cjson snippet or marketing email (not transactional) | [optional] 
**ContentType** | **string** | flow, campaign, cjson, upsell, postcard, transactional_email or email | [optional] 
**EmailTemplateVmPath** | **string** | If a marketing email was applied, this is the path to the template encapsulating the cjson.  This is needed for the UltraCart UI. | [optional] 
**Error** | [**Error**](Error.md) |  | [optional] 
**Metadata** | [**ResponseMetadata**](ResponseMetadata.md) |  | [optional] 
**StorefrontOid** | **int?** | StoreFront oid where content originates necessary for tracking down relative assets | [optional] 
**Success** | **bool?** | Indicates if API call was successful | [optional] 
**Title** | **string** | title of library item, usually the name of the flow or campaign, or description of cjson | [optional] 
**Uuid** | **string** | UUID of marketing email or communication flow/campaign if this library item was an email, campaign or flow | [optional] 
**Warning** | [**Warning**](Warning.md) |  | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

