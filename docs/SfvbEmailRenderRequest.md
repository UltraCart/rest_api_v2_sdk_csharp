
# com.ultracart.admin.v2.Model.SfvbEmailRenderRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CartItemIds** | **List&lt;string&gt;** | Item ids for the cart the email renders with.  For a cart flow email, or the transactional email this cart and email this item templates. | [optional] 
**Cjson** | **string** | An unsaved draft to render in place of the saved content.  For a flow or campaign email, the email container.  For a transactional email, the body container (the theme file core/emails/&lt;name&gt;_body.cjson). | [optional] 
**CustomerName** | **string** | The customer name a flow or campaign email greets.  Defaults to the signed in user. | [optional] 
**OrderId** | **string** | A test order to render the email with.  Real orders are refused.  Without one, an order email renders with a made up order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

