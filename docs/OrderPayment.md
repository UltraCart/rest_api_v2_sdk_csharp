# com.ultracart.admin.v2.Model.OrderPayment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Check** | [**OrderPaymentCheck**](OrderPaymentCheck.md) |  | [optional] 
**CreditCard** | [**OrderPaymentCreditCard**](OrderPaymentCreditCard.md) |  | [optional] 
**Echeck** | [**OrderPaymentECheck**](OrderPaymentECheck.md) |  | [optional] 
**HoldForFraudReview** | **bool?** | True if order has been held for fraud review | [optional] 
**PaymentDts** | **string** | Date/time that the payment was successfully processed | [optional] 
**PaymentMethod** | **string** | Payment method | [optional] 
**PaymentMethodAccountingCode** | **string** | Payment method QuickBooks code | [optional] 
**PaymentMethodDepositToAccount** | **string** | Payment method QuickBooks deposit account | [optional] 
**PaymentStatus** | **string** | Payment status | [optional] 
**PurchaseOrder** | [**OrderPaymentPurchaseOrder**](OrderPaymentPurchaseOrder.md) |  | [optional] 
**RotatingTransactionGatewayCode** | **string** | Rotating transaction gateway code used to process this order | [optional] 
**Surcharge** | [**Currency**](Currency.md) |  | [optional] 
**SurchargeAccountingCode** | **string** | Surcharge accounting code | [optional] 
**SurchargeTransactionFee** | **decimal?** | Surcharge transaction fee | [optional] 
**SurchargeTransactionPercentage** | **decimal?** | Surcharge transaction percentage | [optional] 
**TestOrder** | **bool?** | True if this is a test order | [optional] 
**Transactions** | [**List&lt;OrderPaymentTransaction&gt;**](OrderPaymentTransaction.md) | Transactions associated with processing this payment | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

