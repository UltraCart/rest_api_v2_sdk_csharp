# com.ultracart.admin.v2.Model.PaymentsConfigurationPayPal
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcceptPaypal** | **bool?** | Master flag that determine if PayPal is an active payment for this account | [optional] 
**AccountingCode** | **string** | Optional accounting code that is set to Quickbooks when an order uses this payment method. | [optional] 
**ApiPassword** | **string** | PayPal API password | [optional] 
**ApiUsername** | **string** | PayPal API username | [optional] 
**CertificateOnFile** | **bool?** | (Legacy) true if there is a PayPal certificate already on file. Used to manage the internal UI | [optional] 
**DepositToAccount** | **string** | The account to deposit funds | [optional] 
**Email** | **string** | The main PayPal email address | [optional] 
**Environment** | **string** | PayPal configuration, live or sandbox | [optional] 
**HeaderImageUrl** | **string** | The URL for the PayPal header | [optional] 
**HideBillMeLater** | **bool?** | True if the Bill Me Later button should be hidden during checkout | [optional] 
**HideExpressCheckoutOnViewCart** | **bool?** | True if the PayPal express checkout button should be hidden on the view cart page.  This will force the customer to enter address information before being able to checkout with PayPal | [optional] 
**HideForUnshippedOrders** | **bool?** | True if PayPal should be hidden for orders with no shippable product, such as digital orders | [optional] 
**HoldInAr** | **bool?** | If true, PayPal orders are held in Accounts Receivable for review | [optional] 
**LandingPage** | **string** | PayPal landing page | [optional] 
**Mode** | **string** | The PayPal mode | [optional] 
**PrivateKeyPassword** | **string** | PayPal API private key password | [optional] 
**ProcessingFee** | **decimal?** | Optional additional fee to charge if PayPal is used.  It is rare for this to be used. | [optional] 
**ProcessingPercentage** | **decimal?** | The processing percentage charged by PayPal | [optional] 
**PushPaypal** | **bool?** | True if the internal UI should recommend opening a PayPal account | [optional] 
**Restrictions** | [**PaymentsConfigurationRestrictions**](PaymentsConfigurationRestrictions.md) |  | [optional] 
**SendRecurring** | **bool?** | True if UltraCart should send recurring orders to PayPal.  There are restrictions to what PayPal will accept for recurring orders.  Be careful. | [optional] 
**ShortPaypalMarketingText** | **bool?** | Short marketing text | [optional] 
**ShowCardLogosNotDirectlySupported** | **bool?** | internal ui flag | [optional] 
**ShowSignature** | **bool?** | Internal flag used to manage UI | [optional] 
**Signature** | **string** | PayPal signature | [optional] 
**SolutionType** | **string** | PayPal solution type | [optional] 
**SummaryEmail** | **string** | The email where PayPal summaries should be sent | [optional] 
**SummaryMode** | **string** | Description of what mode PayPal is operating | [optional] 
**ZeroDollarPenny** | **bool?** | Send free items to PayPal as one cent items and subtract this penny from shipping.  PayPal does not allow the sale of free items. | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

