
# com.ultracart.admin.v2.Model.SfvbPageMultimedia

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The image code, which is what pageImageCode refers to.  Empty for the default image. | [optional] 
**Declared** | **bool** | True when a template declares this code.  An attached image whose code nothing declares renders nowhere unless a pageimage element names it. | [optional] 
**Default** | **bool** | True for the page&#39;s default image, which a pageimage element with no pageImageCode renders.  This is the thumbnail a subgroup tile shows. | [optional] 
**Description** | **string** | What the slot is for, as the declaring template describes it, otherwise the description stored with the image.  Rendered as the alt text. | [optional] 
**Dimensions** | **string** | Width x height in pixels, when the attached file is an image. | [optional] 
**Filename** | **string** | The attached file&#39;s name within the page&#39;s folder.  Empty when nothing is attached. | [optional] 
**PublicUrl** | **string** | Where the source file is served on the storefront.  Absent when nothing is attached. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

