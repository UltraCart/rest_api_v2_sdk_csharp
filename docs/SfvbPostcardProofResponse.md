
# com.ultracart.admin.v2.Model.SfvbPostcardProofResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BackHtml** | **string** | The back as the send renders it, after the name tokens are filled. | [optional] 
**BackImageUrl** | **string** | The back as the PNG image the print vendor prints from.  A public url. | [optional] 
**BackThumbnailUrl** | **string** | The print vendor thumbnail of the back. | [optional] 
**FrontHtml** | **string** | The front as the send renders it, after the name tokens are filled. | [optional] 
**FrontImageUrl** | **string** | The front as the PNG image the print vendor prints from.  A public url. | [optional] 
**FrontThumbnailUrl** | **string** | The print vendor thumbnail of the front. | [optional] 
**OrderSource** | **string** | Where the order came from.  test for the order_id given, dummy for a made up one, none for no order. | [optional] 
**PostcardUuid** | **string** | The postcard the step mails. | [optional] 
**RenderedPdfUrl** | **string** | The print vendor proof PDF of both sides. | [optional] 
**VendorRendered** | **bool** | True when the print vendor rendered the card, so the image and PDF urls are set. | [optional] 
**Warnings** | [**List&lt;SfvbErrorDetail&gt;**](SfvbErrorDetail.md) | Where the proof differs from a send, such as a placeholder coupon code or a sample address, and anything that would make a send skip the card. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

