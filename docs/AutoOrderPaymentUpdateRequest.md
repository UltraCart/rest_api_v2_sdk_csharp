
# com.ultracart.admin.v2.Model.AutoOrderPaymentUpdateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttemptRebill** | **bool** | Attempt to rebill the auto order immediately after the payment information is updated.  Defaults to false. | [optional] 
**CardExpirationMonth** | **int** | Card expiration month (1-12) | [optional] 
**CardExpirationYear** | **int** | Card expiration year (four digit) | [optional] 
**CardNumberToken** | **string** | Hosted field token for the credit card number.  Tokens are valid for two hours. | [optional] 
**CardType** | **string** | Credit card type.  Optional.  When the hosted field token carries the card type, the token wins. | [optional] 
**CardVerificationNumberToken** | **string** | Hosted field token for the card verification number (CVV).  Required when the order has a vaulted card that must be re-vaulted. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

