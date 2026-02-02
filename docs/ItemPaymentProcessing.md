# com.ultracart.admin.v2.Model.ItemPaymentProcessing
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlockPrepaid** | **bool?** | True if prepaid cards should be blocked from buying this item | [optional] 
**BlockRefunds** | **bool?** | True if this item should block any refund attempts, set to false otherwise, null value will not update the field | [optional] 
**CreditCardTransactionType** | **string** | Credit card transaction type | [optional] 
**NoRealtimeCharge** | **bool?** | True if no real-time charge should be performed on this item. | [optional] 
**PaymentMethodValidity** | **List&lt;string&gt;** | Payment method validity | [optional] 
**RotatingTransactionGatewayCodes** | **List&lt;string&gt;** | Rotating transaction gateway codes | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

