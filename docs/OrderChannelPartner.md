
# com.ultracart.admin.v2.Model.OrderChannelPartner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoApprovePurchaseOrder** | **bool** | If true, any purchase order submitted is automatically approved | [optional] 
**ChannelPartnerCode** | **string** | The code of the channel partner | [optional] 
**ChannelPartnerData** | **string** | Additional data provided by the channel partner, read-only | [optional] 
**ChannelPartnerOid** | **int** | Channel partner object identifier, read-only and available on existing channel orders only. | [optional] 
**ChannelPartnerOrderId** | **string** | The order ID assigned by the channel partner for this order. | [optional] 
**IgnoreInvalidShippingMethod** | **bool** | Set to true to ignore invalid shipping method being specified.  Only applicable on inserting orders. | [optional] 
**NoRealtimePaymentProcessing** | **bool** | Indicates this order should be placed in Account Receivable for later payment processing | [optional] 
**SkipPaymentProcessing** | **bool** | Indicates this order was already paid for via a channel purchase and no payment collection should be attempted | [optional] 
**StoreCompleted** | **bool** | Instructs UltraCart to skip shipping department and mark this order as fully complete.  This flag defaults to true.  Set this flag to false to shipped product for this order. | [optional] 
**StoreIfPaymentDeclines** | **bool** | If true, any failed payment will place the order in Accounts Receivable rather than rejecting it. | [optional] 
**TreatWarningsAsErrors** | **bool** | Any warnings are raised as errors and halt the import of the order | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

