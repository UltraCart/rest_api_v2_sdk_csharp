# com.ultracart.admin.v2.Model.PaymentsConfigurationCreditCard
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcceptCreditCard** | **bool?** | Master flag indicating whether this merchant accepts credit card payments | [optional] 
**BilledBy** | **string** | Description that appears on customer statements | [optional] 
**ChargeDuringCheckout** | **bool?** | If false, order will be accepted and placed into Accounts Receivable without charging card first | [optional] 
**CollectCvv2** | **bool?** | UltraCart will require customer to enter cvv if this is true | [optional] 
**ConfiguredGatewayDetails** | **string** | Human readable description of the credit card gateway currently configured | [optional] 
**FailedAttempts** | **int?** | The number of failed attempts before the order is placed into Accounts Receivable for manual intervention | [optional] 
**HideConnectSingleGateway** | **bool?** | This internal flag aids the UI in determining which buttons to show. | [optional] 
**Restrictions** | [**List&lt;PaymentsConfigurationRestrictions&gt;**](PaymentsConfigurationRestrictions.md) | Restrictions for this payment method | [optional] 
**SendCustomerBillingUpdateOnDecline** | **bool?** | UltraCart will send customers emails to update their credit card if the card is declined | [optional] 
**SupportedCards** | [**List&lt;PaymentsConfigurationCreditCardType&gt;**](PaymentsConfigurationCreditCardType.md) | A list of credit cards the merchant wishes to accept. | [optional] 
**TestMethods** | [**List&lt;PaymentsConfigurationTestMethod&gt;**](PaymentsConfigurationTestMethod.md) | An array of test methods for placing test orders.  The cards defined here may be real or fake, but any order placed with them will be marked as Test orders | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

