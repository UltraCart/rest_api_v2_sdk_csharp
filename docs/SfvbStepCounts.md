
# com.ultracart.admin.v2.Model.SfvbStepCounts

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Clicked** | **int** | Messages with a click. | [optional] 
**Customers** | **int** | For a step that isn&#39;t an email, the customers that passed through it. | [optional] 
**Delivered** | **int** | Messages delivered. | [optional] 
**Opened** | **int** | Emails opened. | [optional] 
**Sent** | **int** | Messages sent. | [optional] 
**Skipped** | **int** | Customers who reached the step and were not sent anything.  The dispatch log says why. | [optional] 
**Source** | **string** | email (the step&#39;s email, all time), sequence (the begin step, customers who started the sequence, all time) or step (this step, the last 90 days). | [optional] 
**Spam** | **int** | Spam complaints. | [optional] 
**Unsubscribed** | **int** | Unsubscribes from these messages. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

