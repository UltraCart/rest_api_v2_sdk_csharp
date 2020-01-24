# com.ultracart.admin.v2.Model.CartFinalizeOrderRequestOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoApprovePurchaseOrder** | **bool?** | Automatically approve the purchase order | [optional] 
**ChannelPartnerCode** | **string** | Channel partner code to associate this order with | [optional] 
**ChannelPartnerOid** | **int?** | Channel partner oid to associate this order with | [optional] 
**ChannelPartnerOrderId** | **string** | Channel partner order id for reference | [optional] 
**ConsiderRecurring** | **bool?** | Consider this order a recurring order for the purposes of payment gateway recurring flag | [optional] 
**CreditCardAuthorizationAmount** | **decimal?** | If the order was authorized outside of UltraCart, this is the amount of the authorization | [optional] 
**CreditCardAuthorizationDate** | **string** | If the order was authorized outside of UltraCart, this is the date/time of the authorization | [optional] 
**CreditCardAuthorizationReferenceNumber** | **string** | If the order was authorized outside of UltraCart, this is the authorization reference number | [optional] 
**NoRealtimePaymentProcessing** | **bool?** | Prevents normal real-time processing of the payment and sends the order to Accounts Receivable | [optional] 
**SetupNextCart** | **bool?** | True if the system should create another cart automatically if the current cart was logged into a profile | [optional] 
**SkipPaymentProcessing** | **bool?** | Skip payment processing and move the order on to shipping (or completed if no shipping required) | [optional] 
**StoreCompleted** | **bool?** | True the order in the completed stage | [optional] 
**StoreIfPaymentDeclines** | **bool?** | Store the order in accounts receivable if the payment declines | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

