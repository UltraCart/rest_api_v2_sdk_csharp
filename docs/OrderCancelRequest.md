
# com.ultracart.admin.v2.Model.OrderCancelRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LockSelfShipOrders** | **bool** | Flag to prevent a order shipping during a refund process | [optional] 
**RejectReason** | **string** | Reason stored on the order when it is rejected without a refund (Accounts Receivable, Pre-order, Quote or Hold), the same as the reject reason in the UI. | [optional] 
**SkipRefundAndHold** | **bool** | Skip refund and move order to Held Orders department | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

