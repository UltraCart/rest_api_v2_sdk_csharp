# com.ultracart.admin.v2.Model.CustomerStoreCredit
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Available** | **decimal?** | Available store credit which is defined as unused and vested | [optional] 
**Expiring** | **decimal?** | Amount of store credit expiring within 30 days | [optional] 
**FutureLedgers** | [**List&lt;CustomerStoreCreditLedgerEntry&gt;**](CustomerStoreCreditLedgerEntry.md) | Array of future ledger entries including expiring entries | [optional] 
**PastLedgers** | [**List&lt;CustomerStoreCreditLedgerEntry&gt;**](CustomerStoreCreditLedgerEntry.md) | Array of past ledger entries including accrual, usage, and expiring entries | [optional] 
**Total** | **decimal?** | Total lifetime store credit for this customer. | [optional] 
**Vesting** | **decimal?** | Amount of store credit vesting | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

