
# com.ultracart.admin.v2.Model.SfvbPostcardProofRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address1** | **string** | The recipient street address.  Without address1, city, state and postal_code, a sample address is used. | [optional] 
**Address2** | **string** | The recipient second address line. | [optional] 
**CartItemIds** | **List&lt;string&gt;** | Item ids for the cart a cart flow card renders with.  The cart is made for the proof and deleted after it. | [optional] 
**City** | **string** | The recipient city. | [optional] 
**CustomerName** | **string** | The recipient name the card greets and is addressed to.  Defaults to the signed in user. | [optional] 
**HtmlOnly** | **bool** | True to return only the rendered HTML of both sides, with no print vendor render.  The default, false, also returns the images that would print and the vendor proof PDF. | [optional] 
**OrderId** | **string** | A test order for an order flow card.  Real orders are refused.  Without one, an order flow card renders with a made up order. | [optional] 
**PostalCode** | **string** | The recipient postal code. | [optional] 
**State** | **string** | The recipient state. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

