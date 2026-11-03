
# com.ultracart.admin.v2.Model.SfvbTrackingAdvancedRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CatalogUrl** | **string** | A path starting with / or an absolute http or https URL, up to 250 characters. | [optional] 
**ContinueShoppingUrl** | **string** | A path starting with / or an absolute http or https URL, up to 250 characters. | [optional] 
**ConversionPixelOnlyIfPaid** | **bool** | True to run the receipt&#39;s conversion HTML only for orders whose payment succeeded. | [optional] 
**DefaultCurrency** | **string** | A currency code from the read&#39;s currencies. | [optional] 
**DryRun** | **bool** | True to check the change and report it without saving. | [optional] 
**OmitOrderData** | **bool** | True to leave the order data off the custom thank you URL. | [optional] 
**PaymentPendingUrl** | **string** | A path starting with / or an absolute http or https URL, up to 500 characters. | [optional] 
**ThankYouUrl** | **string** | A path starting with / or an absolute http or https URL, up to 500 characters. | [optional] 
**Unset** | **List&lt;string&gt;** | Text settings to clear, by key.  continue_shopping_url, catalog_url, thank_you_url, payment_pending_url or default_currency.  Not with a value for the same key. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

