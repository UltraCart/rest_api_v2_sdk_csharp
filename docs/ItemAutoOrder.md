# com.ultracart.admin.v2.Model.ItemAutoOrder
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthFutureAmount** | **decimal?** | Amount to try and authorize for the future rebill | [optional] 
**AuthTestAmount** | **decimal?** | Amount to try and test authorize | [optional] 
**AutoOrderCancelItemId** | **string** | Item id to attempt charging the customer for if they cancel | [optional] 
**AutoOrderCancelItemOid** | **int?** | Item object identifier to attempt charging the customer for if they cancel | [optional] 
**AutoOrderDowngradeItems** | **List&lt;string&gt;** | List of downgrade items presented to customer service representatives | [optional] 
**AutoOrderPaused** | **bool?** | True if the rebill processing of this item is paused | [optional] 
**AutoOrderSchedules** | **List&lt;string&gt;** | The user selectable schedules that are available | [optional] 
**AutoOrderUpgradeItems** | **List&lt;string&gt;** | List of upgrade items presented to customer service representatives | [optional] 
**AutoOrderUpsell** | **bool?** | True if this item uses a fixed upsell step schedule | [optional] 
**AutoOrderUpsellNoEasyCancel** | **bool?** | Do not send the easy cancel email to the customer | [optional] 
**AutoOrderUpsellOnePerCustomer** | **bool?** | Limit the purchase of this item to one per customer | [optional] 
**AutoOrderable** | **bool?** | True if this item can be automatically ordered by the customer | [optional] 
**CancelOtherAutoOrders** | **bool?** | True if other auto orders for this customer should be canceled when this item is ordered | [optional] 
**FreeShippingAutoOrder** | **bool?** | True if the customer should be given free shipping | [optional] 
**RefundOtherAutoOrders** | **bool?** | True if other auto orders for this customer should refunded if this item is refunded. | [optional] 
**Steps** | [**List&lt;ItemAutoOrderStep&gt;**](ItemAutoOrderStep.md) | The rebill steps if this auto order is an upsell | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

