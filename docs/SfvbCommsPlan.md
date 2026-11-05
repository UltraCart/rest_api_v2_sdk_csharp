
# com.ultracart.admin.v2.Model.SfvbCommsPlan

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveCustomers** | **int** | Customers being mailed now. | [optional] 
**AllowListImport** | **bool** | True when the account may import lists from another email provider. | [optional] 
**AllowTrackingEmails** | **bool** | True when shipment tracking emails are allowed. | [optional] 
**BounceCount** | **int** | Emails bounced. | [optional] 
**BouncePercentage** | **decimal** | The bounce percentage. | [optional] 
**DeliveredCount** | **int** | Emails delivered. | [optional] 
**InitialSendingLimits** | **int** | The starting sending limit for a new account. | [optional] 
**MaxActiveCustomers** | **int** | The most customers the plan mails. | [optional] 
**MaxEmailsPerDay** | **int** | The daily sending cap. | [optional] 
**MaxEmailsPerHour** | **int** | The hourly sending cap. | [optional] 
**MaxEmailsPerMonth** | **int** | The monthly sending cap. | [optional] 
**PausedForSpam** | **bool** | True when sending is paused for spam complaints. | [optional] 
**PlanCustomers** | **int** | Customers the plan covers. | [optional] 
**PlanEmails** | **int** | Emails a month the plan covers. | [optional] 
**PlanName** | **string** | The plan, such as small. | [optional] 
**PlanNameFormatted** | **string** | The plan&#39;s display name. | [optional] 
**RequireOrderWithinLastDays** | **int** | When set, only customers who ordered within this many days are mailed. | [optional] 
**SentEmailsPerDay** | **int** | Emails sent in the last day. | [optional] 
**SentEmailsPerHour** | **int** | Emails sent in the last hour. | [optional] 
**SentEmailsPerMonth** | **int** | Emails sent in the last month. | [optional] 
**SpamCount** | **int** | Spam complaints. | [optional] 
**SpamPercentLimit** | **int** | The spam complaint percentage at which sending pauses. | [optional] 
**SpamPercentage** | **decimal** | The spam complaint percentage. | [optional] 
**TotalCustomers** | **int** | Customers allowed in all. | [optional] 
**TotalEmails** | **int** | Emails a month allowed in all. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

