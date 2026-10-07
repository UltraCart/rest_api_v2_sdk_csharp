
# com.ultracart.admin.v2.Model.SfvbTestOrdersResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hint** | **string** | Present when nothing matched.  Says how to place a test order. | [optional] 
**SearchedDays** | **int** | How many days back were searched, 7, 30 or 90, widening until enough test orders were found. | [optional] 
**TestOrders** | [**List&lt;SfvbTestOrder&gt;**](SfvbTestOrder.md) | Test orders, newest first.  Only orders marked as test orders are ever listed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

