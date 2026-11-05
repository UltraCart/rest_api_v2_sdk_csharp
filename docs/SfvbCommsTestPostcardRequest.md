
# com.ultracart.admin.v2.Model.SfvbCommsTestPostcardRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address1** | **string** | The street address. | [optional] 
**Address2** | **string** | The second address line. | [optional] 
**CartItemIds** | **List&lt;string&gt;** | Items for a cart flow&#39;s card. | [optional] 
**City** | **string** | The city. | [optional] 
**DryRun** | **bool** | Check everything, including that postcards are turned on, and show the cost, without mailing or using an approval. | [optional] 
**MailCard** | **bool** | Must be true.  Without it nothing is mailed; use the postcard proof to see the card. | [optional] 
**Name** | **string** | The recipient&#39;s name. | [optional] 
**OrderId** | **string** | A test order to render an order flow&#39;s card with.  A real customer&#39;s order is refused. | [optional] 
**PostalCode** | **string** | The postal code. | [optional] 
**State** | **string** | The state. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

