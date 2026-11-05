
# com.ultracart.admin.v2.Model.SfvbPostcardTrackingResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cards** | [**List&lt;SfvbPostcardCard&gt;**](SfvbPostcardCard.md) | This page of cards. | [optional] 
**CustomerData** | **string** | masked, or shown when show_customer_data was sent. | [optional] 
**Notes** | **List&lt;string&gt;** | What to keep in mind, such as how to handle customer data that is shown. | [optional] 
**Page** | **int** | The page number, from 1. | [optional] 
**PageCost** | **decimal** | The total cost of the cards on this page. | [optional] 
**PageSize** | **int** | Cards per page. | [optional] 
**PostcardUuid** | **string** | The postcard. | [optional] 
**TotalCards** | **int** | How many cards have been mailed for this postcard. | [optional] 
**TotalPages** | **int** | How many pages there are. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

