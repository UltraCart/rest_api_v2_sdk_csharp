
# com.ultracart.admin.v2.Model.SfvbCommsStat

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bounced** | **int** | Permanent bounces. | [optional] 
**Channel** | **string** | email, sms, postcard, branch or sequence, or step for a step type that records no counts of its own, with every count named in not_measured. | [optional] 
**Clicked** | **int** | Clicks (for a postcard, scans of its QR code). | [optional] 
**Conversions** | **int** | Conversions. | [optional] 
**Customers** | **int** | Customers who reached it (a branch side), or started (a whole sequence). | [optional] 
**Delivered** | **int** | Deliveries. | [optional] 
**Finished** | **int** | Customers who finished the sequence. | [optional] 
**InProgress** | **int** | Customers in the sequence now. | [optional] 
**Invalid** | **int** | Addresses the email validator refused. | [optional] 
**NotMeasured** | **List&lt;string&gt;** | The counts this channel doesn&#39;t record, left out above. | [optional] 
**Opened** | **int** | Opens. | [optional] 
**Orders** | **int** | Orders attributed. | [optional] 
**Profit** | **decimal** | Profit attributed. | [optional] 
**ReturnedToSender** | **int** | Postcards returned to sender. | [optional] 
**Revenue** | **decimal** | Revenue attributed. | [optional] 
**Sent** | **int** | Sends. | [optional] 
**Skipped** | **int** | Customers skipped. | [optional] 
**Spam** | **int** | Spam complaints. | [optional] 
**Unsubscribed** | **int** | Unsubscribes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

