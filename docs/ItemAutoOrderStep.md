
# com.ultracart.admin.v2.Model.ItemAutoOrderStep

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArbitraryScheduleDays** | **int** | If the schedule is arbitrary, then this is the number of days | [optional] 
**ArbitraryUnitCost** | **decimal** | Arbitrary unit cost used to override the regular item cost | [optional] 
**ArbitraryUnitCostSchedules** | [**List&lt;ItemAutoOrderStepArbitraryUnitCostSchedule&gt;**](ItemAutoOrderStepArbitraryUnitCostSchedule.md) | Arbitrary unit costs schedules for more advanced discounting by rebill attempt | [optional] 
**GrandfatherPricing** | [**List&lt;ItemAutoOrderStepGrandfatherPricing&gt;**](ItemAutoOrderStepGrandfatherPricing.md) | Grand-father pricing configuration if the rebill schedule has changed over time | [optional] 
**ManagedBy** | **string** | Managed by (defaults to UltraCart) | [optional] 
**PauseDays** | **int** | Number of days to pause | [optional] 
**PauseUntilDate** | **string** | Wait for this step to happen until the specified date | [optional] 
**PauseUntilDayOfMonth** | **int** | Pause until a specific day of the month | [optional] 
**PauseUntilMinimumDelayDays** | **int** | Pause at least this many days between the last order and the calculated next day of month | [optional] 
**PreshipmentNoticeDays** | **int** | If set, a pre-shipment notice is sent to the customer this many days in advance | [optional] 
**RecurringMerchantItemId** | **string** | Item id to rebill | [optional] 
**RecurringMerchantItemOid** | **int** | Item object identifier to rebill | [optional] 
**RepeatCount** | **int** | Number of times to rebill.  Last step can be null for infinite | [optional] 
**Schedule** | **string** | Frequency of the rebill | [optional] 
**SubscribeEmailListName** | **string** | Email list name to subscribe the customer to when the rebill occurs | [optional] 
**SubscribeEmailListOid** | **int** | Email list identifier to subscribe the customer to when this rebill occurs | [optional] 
**Type** | **string** | Type of step (item, kit only, loop or pause) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

