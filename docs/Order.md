# com.ultracart.admin.v2.Model.Order
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Affiliates** | [**List&lt;OrderAffiliate&gt;**](OrderAffiliate.md) | Affiliates if any were associated with the order.  The first one in the array sent the order and each subsequent affiliate is the recruiter that earns a downline commission. | [optional] 
**AutoOrder** | [**OrderAutoOrder**](OrderAutoOrder.md) |  | [optional] 
**Billing** | [**OrderBilling**](OrderBilling.md) |  | [optional] 
**Buysafe** | [**OrderBuysafe**](OrderBuysafe.md) |  | [optional] 
**ChannelPartner** | [**OrderChannelPartner**](OrderChannelPartner.md) |  | [optional] 
**Checkout** | [**OrderCheckout**](OrderCheckout.md) |  | [optional] 
**Coupons** | [**List&lt;OrderCoupon&gt;**](OrderCoupon.md) | Coupons | [optional] 
**CreationDts** | **string** | Date/time that the order was created | [optional] 
**CurrencyCode** | **string** | Currency code that the customer used if different than the merchant&#39;s base currency code | [optional] 
**CurrentStage** | **string** | Current stage that the order is in. | [optional] 
**CustomerProfile** | [**Customer**](Customer.md) |  | [optional] 
**DigitalOrder** | [**OrderDigitalOrder**](OrderDigitalOrder.md) |  | [optional] 
**Edi** | [**OrderEdi**](OrderEdi.md) |  | [optional] 
**ExchangeRate** | **decimal?** | Exchange rate at the time the order was placed if currency code is different than the base currency | [optional] 
**FraudScore** | [**OrderFraudScore**](OrderFraudScore.md) |  | [optional] 
**Gift** | [**OrderGift**](OrderGift.md) |  | [optional] 
**GiftCertificate** | [**OrderGiftCertificate**](OrderGiftCertificate.md) |  | [optional] 
**_Internal** | [**OrderInternal**](OrderInternal.md) |  | [optional] 
**Items** | [**List&lt;OrderItem&gt;**](OrderItem.md) | Items | [optional] 
**LanguageIsoCode** | **string** | Three letter ISO-639 language code used by the customer during the checkout if different than the default language | [optional] 
**LinkedShipment** | [**OrderLinkedShipment**](OrderLinkedShipment.md) |  | [optional] 
**Marketing** | [**OrderMarketing**](OrderMarketing.md) |  | [optional] 
**MerchantId** | **string** | UltraCart merchant ID owning this order | [optional] 
**OrderId** | **string** | Order ID | [optional] 
**Payment** | [**OrderPayment**](OrderPayment.md) |  | [optional] 
**Quote** | [**OrderQuote**](OrderQuote.md) |  | [optional] 
**RefundDts** | **string** | If the order was refunded, the date/time that the last refund occurred | [optional] 
**RejectDts** | **string** | If the order was rejected, the date/time that the rejection occurred | [optional] 
**Salesforce** | [**OrderSalesforce**](OrderSalesforce.md) |  | [optional] 
**Shipping** | [**OrderShipping**](OrderShipping.md) |  | [optional] 
**Summary** | [**OrderSummary**](OrderSummary.md) |  | [optional] 
**Taxes** | [**OrderTaxes**](OrderTaxes.md) |  | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
