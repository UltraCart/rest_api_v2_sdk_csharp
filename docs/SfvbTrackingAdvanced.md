
# com.ultracart.admin.v2.Model.SfvbTrackingAdvanced

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CatalogUrl** | **string** | The override for the storefront&#39;s catalog URL (the admin&#39;s Override Catalog URL).  A path starting with / or an absolute http or https URL, up to 250 characters.  Null when not overridden. | [optional] 
**ContinueShoppingUrl** | **string** | Where the continue shopping button goes instead of the default.  A path starting with / or an absolute http or https URL, up to 250 characters.  Null when not overridden. | [optional] 
**ConversionPixelOnlyIfPaid** | **bool** | True when the receipt&#39;s conversion HTML runs only for orders whose payment succeeded. | [optional] 
**DefaultCurrency** | **string** | The storefront&#39;s default currency code, one of the response&#39;s currencies.  Null when not set. | [optional] 
**HashSha256** | **string** | The hash of the seven writable settings.  Send it as If-Match when changing them. | [optional] 
**OmitOrderData** | **bool** | True when the order data is left off the custom thank you URL. | [optional] 
**OrderHashSecretKeySet** | **bool** | True when the account has an order hash secret key.  The key is shared by every storefront on the account, is never returned, and is changed only in the admin.  Null when it could not be checked. | [optional] 
**PaymentPendingUrl** | **string** | Where the shopper goes when the order&#39;s payment is still pending.  A path starting with / or an absolute http or https URL, up to 500 characters.  Null when not set. | [optional] 
**ThankYouUrl** | **string** | Where the shopper goes after placing an order, instead of the built-in receipt.  A path starting with / or an absolute http or https URL, up to 500 characters.  Null for the built-in receipt. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

