
# com.ultracart.admin.v2.Model.SfvbItemMultimedia

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The image code, which is what an itemimage element&#39;s itemImageCode refers to.  Empty for the default image. | [optional] 
**Declared** | **bool** | True when a template declares this code.  A slot that is attached but not declared is an image nothing on the page is asking for. | [optional] 
**Default** | **bool** | True for the image an itemimage element with no code renders.  Default is per media type, so an item may have one default image and one default PDF at the same time. | [optional] 
**Description** | **string** | Stored with the image and rendered as its alt text.  When it is empty the render falls back to the item&#39;s own description, so an empty value here is not an empty alt attribute. | [optional] 
**Dimensions** | **string** | Width x height in pixels, when the storage measured the file. | [optional] 
**ExcludeFromGallery** | **bool** | True when the storage marks this image as kept out of the item gallery. | [optional] 
**Filename** | **string** | The stored file&#39;s name.  Empty when the slot is declared and nothing is attached. | [optional] 
**Type** | **string** | The media type the storage recorded. | [optional] 
**ViewUrl** | **string** | Where the stored image is served.  Absent when nothing is attached to the slot. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

