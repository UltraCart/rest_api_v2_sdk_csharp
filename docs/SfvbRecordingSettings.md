
# com.ultracart.admin.v2.Model.SfvbRecordingSettings

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CostPerThousand** | **decimal** | What 1,000 recorded sessions cost after the trial, in US dollars. | [optional] 
**Enabled** | **bool** | True when real shoppers&#39; sessions on this storefront are being recorded. | [optional] 
**RetentionInterval** | **string** | How long recordings are kept, such as 1 year. | [optional] 
**SessionsCurrentBillingPeriod** | **int** | Sessions recorded so far in the current billing period. | [optional] 
**SessionsLastBillingPeriod** | **int** | Sessions recorded in the previous billing period. | [optional] 
**SessionsTrialBillingPeriod** | **int** | Sessions recorded during the free trial. | [optional] 
**TrialExpiration** | **string** | When the free trial ends, as an ISO-8601 time.  Absent until the trial has started. | [optional] 
**TrialExpired** | **bool** | True when the free trial is over and recorded sessions are billed. | [optional] 
**TrialStarted** | **bool** | True once recording has been turned on at least once, which starts a 14 day free trial. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

