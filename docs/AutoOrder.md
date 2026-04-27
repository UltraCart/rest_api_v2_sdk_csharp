
# com.ultracart.admin.v2.Model.AutoOrder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddOns** | [**List&lt;AutoOrderAddonItem&gt;**](AutoOrderAddonItem.md) | Array of addon objects instructing which items to add to auto order and how many times they should be added. | [optional] 
**AutoOrderCode** | **string** | Unique code assigned to this auto order | [optional] 
**AutoOrderOid** | **int** | Auto order object identifier | [optional] 
**CancelAfterNextXOrders** | **int** | Cancel this auto order after X additional rebills | [optional] 
**CancelDowngrade** | **bool** | True if the auto order was canceled because the customer purchased a downgrade item | [optional] 
**CancelReason** | **string** | The reason this auto order was canceled by either merchant or customer | [optional] 
**CancelUpgrade** | **bool** | True if the auto order was canceled because the customer purchased an upgrade item | [optional] 
**CanceledByUser** | **string** | The user that canceled the auto order | [optional] 
**CanceledDts** | **string** | The date/time that the auto order was canceled | [optional] 
**Completed** | **bool** | True if the auto order ran successfully to completion | [optional] 
**CreditCardAttempt** | **int** | The number of credit card attempts that have taken place | [optional] 
**DisabledDts** | **string** | The date/time the auto order was disabled due to failed rebills | [optional] 
**Enabled** | **bool** | True if this auto order is enabled | [optional] 
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

