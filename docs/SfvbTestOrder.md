
# com.ultracart.admin.v2.Model.SfvbTestOrder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoOrder** | **bool** | True when the order started an auto order, for working on the subscription pages. | [optional] 
**Created** | **string** | When the order was placed, ISO-8601 in UTC. | [optional] 
**CurrencyCode** | **string** | The currency of the total. | [optional] 
**DigitalItems** | **bool** | True when the order has digital downloads, for working on the digital download page. | [optional] 
**ItemCount** | **int** | How many item lines the order has. | [optional] 
**OrderId** | **string** | The order id.  Pass it as a render&#39;s context_order_id. | [optional] 
**PaymentMethod** | **string** | How the order was paid, such as Credit Card or PayPal. | [optional] 
**Stage** | **string** | The order&#39;s current stage code, such as CO (completed), SD (shipping department) or AR (accounts receivable). | [optional] 
**Total** | **string** | The order total as a decimal string. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

