
# com.ultracart.admin.v2.Model.AutoOrderItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArbitraryItemId** | **string** | Arbitrary item id that should be rebilled instead of the normal schedule | [optional] 
**ArbitraryPercentageDiscount** | **decimal** | An arbitrary percentage discount to provide on future rebills | [optional] 
**ArbitraryQuantity** | **decimal** | Arbitrary quantity to rebill | [optional] 
**ArbitraryScheduleDays** | **int** | The number of days to rebill if the frequency is set to an arbitrary number of days | [optional] 
**ArbitraryUnitCost** | **decimal** | Arbitrary unit cost that rebills of this item should occur at | [optional] 
**ArbitraryUnitCostRemainingOrders** | **int** | The number of rebills to give the arbitrary unit cost on before reverting to normal pricing. | [optional] 
**AutoOrderItemOid** | **int** | Primary key of AutoOrderItem | [optional] 
**Frequency** | **string** | Frequency of the rebill if not a fixed schedule | [optional] 
**FutureSchedules** | [**List&lt;AutoOrderItemFutureSchedule&gt;**](AutoOrderItemFutureSchedule.md) | The future rebill schedule for this item up to the next ten rebills | [optional] 
**LastOrderDts** | **string** | Date/time of the last order of this item | [optional] 
**LifeTimeValue** | **decimal** | The life time value of this item including the original purchase | [optional] 
**NextPreshipmentNoticeDts** | **string** | The date/time of when the next pre-shipment notice should be sent | [optional] 
**NextShipmentDts** | **string** | Date/time that this item is scheduled to rebill | [optional] 
**NoOrderAfterDts** | **string** | Date/time after which no additional rebills of this item should occur | [optional] 
**NumberOfRebills** | **int** | The number of times this item has rebilled | [optional] 
**Options** | [**List&lt;AutoOrderItemOption&gt;**](AutoOrderItemOption.md) | Options associated with this item | [optional] 
**OriginalItemId** | **string** | The original item id purchased.  This item controls scheduling.  If you wish to modify a schedule, for example, from monthly to yearly, change this item from your monthly item to your yearly item, and then change the next_shipment_dts to your desired date. | [optional] 
**OriginalQuantity** | **decimal** | The original quantity purchased | [optional] 
**PaypalPayerId** | **string** | The PayPal Payer ID tied to this item | [optional] 
**PaypalRecurringPaymentProfileId** | **string** | The PayPal Profile ID tied to this item | [optional] 
**PreshipmentNoticeSent** | **bool** | True if the preshipment notice associated with the next rebill has been sent | [optional] 
**RebillValue** | **decimal** | The value of the rebills of this item | [optional] 
**RemainingRepeatCount** | **int** | The number of rebills remaining before this item is complete | [optional] 
**SimpleSchedule** | [**AutoOrderItemSimpleSchedule**](AutoOrderItemSimpleSchedule.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

