
# com.ultracart.admin.v2.Model.EmailPerformance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveCustomers** | **int** | Active customers.  The value will be -1 if calculation is pending. | [optional] 
**ActualCustomers** | **int** | Actual customers that they have regardless of active state.  The value will be -1 if calculation is pending. | [optional] 
**BounceCount** | **int** | Bounce count | [optional] 
**BouncePercentage** | **decimal** | bounce percentage rate based upon our look back window.  This should be under five percent or the account will be paused for sending. | [optional] 
**BouncePercentageFormatted** | **string** | bounce percentage rate (formatted) based upon our look back window.  This should be under five percent or the account will be paused for sending. | [optional] 
**CustomerHistogram** | [**EmailPerformanceCustomerHistogram**](EmailPerformanceCustomerHistogram.md) |  | [optional] 
**DailyStats** | [**List&lt;EmailPerformanceDaily&gt;**](EmailPerformanceDaily.md) | Daily statistics used for charting | [optional] 
**DeliveredCount** | **int** | Delivered count | [optional] 
**LoyaltyProgramType** | **string** | Loyalty Program Type | [optional] 
**MaxActiveCustomers** | **int** | Maximum active customers allowed under their billing plan | [optional] 
**MaxEmailsPerDay** | **int** | Max emails per day | [optional] 
**MaxEmailsPerHour** | **int** | Max emails per hour | [optional] 
**MaxEmailsPerMonth** | **int** | Max emails per month | [optional] 
**PausedForSpam** | **bool** | True if campaign/flow emails are paused due to spam complaints. | [optional] 
**Revenue** | **decimal** | Revenue | [optional] 
**SentEmailsPerDay** | **int** | Sent emails last 24 hours | [optional] 
**SentEmailsPerHour** | **int** | Sent emails last hour | [optional] 
**SentEmailsPerMonth** | **int** | Sent emails last 31 days | [optional] 
**SequenceSendCount** | **int** | Total sequence (campaign/flow) emails sent | [optional] 
**SpamCount** | **int** | Spam complaints | [optional] 
**SpamPercentage** | **decimal** | Spam percentage rate based upon our look back window.  This should be under one half a percent or the account will be paused for sending. | [optional] 
**SpamPercentageFormatted** | **string** | Spam percentage rate (formatted) based upon our look back window.  This should be under one half a percent or the account will be paused for sending. | [optional] 
**TransactionalSendCount** | **int** | Total transactions emails sent | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

