# com.ultracart.admin.v2.Model.AccountsReceivableRetryConfig
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool?** | True if the retry should run daily.  False puts the retry service into an inactive state for this merchant. | [optional] 
**AllowProcessLinkedAccounts** | **bool?** | True if this account has linked accounts that it can process. | [optional] 
**CancelAutoOrder** | **bool?** | If true also cancel the auto order if the order is rejected at the end | [optional] 
**CurrentServicePlan** | **string** | The current service plan that the account is on. | [optional] 
**DailyActivityList** | [**List&lt;AccountsReceivableRetryDayActivity&gt;**](AccountsReceivableRetryDayActivity.md) | A list of days and what actions should take place on those days after an order reaches accounts receivable | [optional] 
**ManagedByLinkedAccountMerchantId** | **bool?** | If not null, this account is managed by the specified parent merchant id. | [optional] 
**MerchantId** | **string** | UltraCart merchant ID | [optional] 
**NotifyEmails** | **List&lt;string&gt;** | A list of email addresses to receive summary notifications from the retry service. | [optional] 
**NotifyRejections** | **bool?** | If true, email addresses are notified of rejections. | [optional] 
**NotifySuccesses** | **bool?** | If true, email addresses are notified of successful charges. | [optional] 
**ProcessLinkedAccounts** | **bool?** | If true, all linked accounts are also processed using the same rules. | [optional] 
**ProcessingPercentage** | **string** | The percentage rate charged for the service. | [optional] 
**RejectAtEnd** | **bool?** | If true, the order is rejected the day after the last configured activity day | [optional] 
**TrialMode** | **bool?** | True if the account is currently in trial mode.  Set to false to exit trial mode. | [optional] 
**TrialModeExpirationDts** | **string** | The date when trial mode expires.  If this date is reached without exiting trial mode, the service will de-activate. | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

