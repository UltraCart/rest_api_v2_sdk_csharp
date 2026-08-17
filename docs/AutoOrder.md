
# com.ultracart.admin.v2.Model.AutoOrder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddOns** | [**List&lt;AutoOrderAddonItem&gt;**](AutoOrderAddonItem.md) | Array of addon objects instructing which items to add to auto order and how many times they should be added. | [optional] 
**AutoOrderCode** | **string** | Unique code assigned to this auto order | [optional] 
**AutoOrderOid** | **int** | Auto order object identifier | [optional] 
**CancelAfterNextXOrders** | **int** | Cancel this auto order after X additional rebills | [optional] 
**CancelDowngrade** | **bool** | True if the auto order was canceled because the customer purchased a downgrade item | [optional] 
**CancelReason** | **string** | The reason this auto order was canceled by either merchant or customer. Supplying this when setting enabled to false records the change as a cancellation rather than a disable. | [optional] 
**CancelUpgrade** | **bool** | True if the auto order was canceled because the customer purchased an upgrade item | [optional] 
**CanceledByUser** | **string** | The user that canceled the auto order. Supplying this when setting enabled to false records the change as a cancellation rather than a disable. | [optional] 
**CanceledDts** | **string** | The date/time that the auto order was canceled. Supply this to record an explicit cancellation time, otherwise it is stamped automatically when enabled is set to false along with cancel_reason or canceled_by_user. | [optional] 
**Completed** | **bool** | True if the auto order ran successfully to completion | [optional] 
**CreditCardAttempt** | **int** | The number of credit card attempts that have taken place | [optional] 
**DisabledDts** | **string** | The date/time the auto order was disabled, either by a failed rebill or by setting enabled to false without a cancellation | [optional] 
**Emails** | [**List&lt;AutoOrderEmail&gt;**](AutoOrderEmail.md) | Email delivery records associated with this auto order. | [optional] 
**Enabled** | **bool** | True if this auto order is enabled. Setting this to false along with cancel_reason or canceled_by_user records the change as a cancellation and fires the auto order cancel notifications. Setting it to false without either field records a disable instead. | [optional] 
**FailureReason** | **string** | The reason this auto order failed during the last rebill attempt | [optional] 
**Items** | [**List&lt;AutoOrderItem&gt;**](AutoOrderItem.md) | The items that are setup to rebill | [optional] 
**Logs** | [**List&lt;AutoOrderLog&gt;**](AutoOrderLog.md) | Logs associated with this auto order | [optional] 
**Management** | [**AutoOrderManagement**](AutoOrderManagement.md) |  | [optional] 
**MerchantId** | **string** | UltraCart merchant ID owning this order | [optional] 
**MergedDts** | **string** | The date/time the auto order was merged into another auto order | [optional] 
**MergedIntoAutoOrderOid** | **int** | The auto order that this auto order was merged into | [optional] 
**NextAttempt** | **string** | The next time that the auto order will be attempted for processing | [optional] 
**OriginalOrder** | [**Order**](Order.md) |  | [optional] 
**OriginalOrderId** | **string** | The original order id that this auto order is associated with. | [optional] 
**OverrideAffiliateId** | **int** | Override the affiliate id given credit for rebills of this auto order | [optional] 
**Properties** | [**List&lt;AutoOrderProperty&gt;**](AutoOrderProperty.md) | Array of property objects | [optional] 
**RebillOrders** | [**List&lt;Order&gt;**](Order.md) | Rebill orders that have taken place on this auto order | [optional] 
**RotatingTransactionGatewayCode** | **string** | The RTG code associated with this order for future rebills | [optional] 
**Status** | **string** | The status of the auto order | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

