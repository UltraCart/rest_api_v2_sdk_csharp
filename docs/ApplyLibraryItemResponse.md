# com.ultracart.admin.v2.Model.ApplyLibraryItemResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cjson** | **string** | Cjson from library item, only populated if this library item was a cjson snippet | [optional] 
**ContentType** | **string** | flow, campaign, cjson, or upsell | [optional] 
**Error** | [**Error**](Error.md) |  | [optional] 
**Metadata** | [**ResponseMetadata**](ResponseMetadata.md) |  | [optional] 
**StorefrontOid** | **int?** | StoreFront oid where content originates necessary for tracking down relative assets | [optional] 
**Success** | **bool?** | Indicates if API call was successful | [optional] 
**Title** | **string** | title of library item, usually the name of the flow or campaign, or description of cjson | [optional] 
**Uuid** | **string** | UUID of communication flow or campaign if this library item was a campaign or flow | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

