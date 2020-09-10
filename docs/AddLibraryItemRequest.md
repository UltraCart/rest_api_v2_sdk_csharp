# com.ultracart.admin.v2.Model.AddLibraryItemRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cjson** | **string** | Cjson to be added to library | [optional] 
**ContentType** | **string** | flow, campaign, cjson, email, transactional_email or upsell | [optional] 
**Description** | **string** | description of library item | [optional] 
**EmailName** | **string** | Required if content_type is transactional_email. This is the name of the email template (html, not text).  This name should have a .vm file extension.  An example is auto_order_cancel_html.vm | [optional] 
**EmailPath** | **string** | Required if content_type is transactional_email. This is the full path to the email template stored in the file system.  This defines which StoreFront contains the desired email template.  An example is /themes/Elements/core/emails/auto_order_cancel_html.vm | [optional] 
**Screenshots** | [**List&lt;LibraryItemScreenshot&gt;**](LibraryItemScreenshot.md) | Screenshot urls for display | [optional] 
**StorefrontOid** | **int?** | StoreFront oid where content originates necessary for tracking down relative assets | [optional] 
**Title** | **string** | title of library item, usually the name of the flow or campaign, or description of cjson | [optional] 
**UpsellOfferOid** | **int?** | Required if content_type is upsell. This is object identifier of a StoreFront Upsell Offer. | [optional] 
**Uuid** | **string** | UUID of communication flow or campaign, null if this item is neither | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

