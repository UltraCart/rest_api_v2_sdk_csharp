
# com.ultracart.admin.v2.Model.OrderProcessPaymentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal** | Specific amount to bill (optional).  If not specified the total of the order is billed. | [optional] 
**CardVerificationNumberToken** | **string** | Card verification number token from hosted fields used during credit card transaction processing (optional) | [optional] 
**RotatingTransactionGatewayCode** | **string** | Rotating transaction gateway code to process the payment through (optional).  Must be an active rotating transaction gateway on the account.  The charge is attempted on that gateway only, without cascading to other gateways, the same as choosing a gateway on the Accounts Receivable Process Payment screen. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

