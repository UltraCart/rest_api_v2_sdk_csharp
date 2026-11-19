
# com.ultracart.admin.v2.Model.SfvbCodeLibraryEmailDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContainerCjson** | **string** | The item&#39;s body as stored.  Starting a new email from it gives its elements new ids. | [optional] 
**Description** | **string** | The item&#39;s description. | [optional] 
**Files** | [**List&lt;SfvbCodeLibraryFile&gt;**](SfvbCodeLibraryFile.md) | The image files the item carries, without their contents. | [optional] 
**LibraryItemOid** | **int** | The item, to send as library_item_oid on the step insert. | [optional] 
**PreviewText** | **string** | The preview text a new email takes from the item, or null when it has none. | [optional] 
**Source** | **string** | owned (this account&#39;s own), shared (shared with this account) or public (published and approved by UltraCart). | [optional] 
**Subject** | **string** | The subject a new email takes from the item, or null when it has none. | [optional] 
**Title** | **string** | The item&#39;s title. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

