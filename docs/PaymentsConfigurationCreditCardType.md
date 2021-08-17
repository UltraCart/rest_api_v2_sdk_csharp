# com.ultracart.admin.v2.Model.PaymentsConfigurationCreditCardType
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountingCode** | **string** | Optional field used for Quickbooks integrations to match this credit card with the corresponding payment type in Quickbooks | [optional] 
**CardTypeIcon** | **string** | Internally used icon information for this card type | [optional] 
**CreditCard** | **string** | Credit card type | [optional] 
**DepositToAccount** | **string** | The name of the account to deposit funds | [optional] 
**Enabled** | **bool?** | If true, this card type will be accepted during checkout | [optional] 
**ProcessingFee** | **decimal?** | Optional additional fee applied to order for this card | [optional] 
**ProcessingPercentage** | **decimal?** | Optional additional fee applied to order for this card | [optional] 
**Restrictions** | [**PaymentsConfigurationRestrictions**](PaymentsConfigurationRestrictions.md) |  | [optional] 
**SurchargeAccountingCode** | **string** | Optional field. If integrated with Quickbooks, this code will be used when informing Quickbooks about any surcharges applied to orders | [optional] 
**TransactionFee** | **decimal?** | An optional additional fee to charge the customer for using this card. | [optional] 
**TransactionPercentage** | **decimal?** | An optional transaction percentage to charge the customer for using this card | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

