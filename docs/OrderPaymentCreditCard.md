
# com.ultracart.admin.v2.Model.OrderPaymentCreditCard

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardAuthTicket** | **string** | Card authorization ticket | [optional] 
**CardAuthorizationAmount** | **decimal** | Card authorization amount | [optional] 
**CardAuthorizationDts** | **string** | Card authorization date/time | [optional] 
**CardAuthorizationReferenceNumber** | **string** | Card authorization reference number | [optional] 
**CardExpirationMonth** | **int** | Card expiration month (1-12) | [optional] 
**CardExpirationYear** | **int** | Card expiration year (Four digit year) | [optional] 
**CardNumber** | **string** | Card number (masked to last 4) | [optional] 
**CardNumberToken** | **string** | Card number token from hosted fields used to update the card number | [optional] 
**CardNumberTruncated** | **bool** | True if the card has been truncated | [optional] 
**CardType** | **string** | Card type | [optional] 
**CardVerificationNumberToken** | **string** | Card verification number token from hosted fields, only for import/insert of new orders, completely ignored for updates, and always null/empty for queries | [optional] 
**DualVaulted** | [**OrderPaymentCreditCardDualVaulted**](OrderPaymentCreditCardDualVaulted.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

