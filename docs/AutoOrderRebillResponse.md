
# com.ultracart.admin.v2.Model.AutoOrderRebillResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoOrder** | [**AutoOrder**](AutoOrder.md) |  | [optional] 
**Error** | [**Error**](Error.md) |  | [optional] 
**FailureReason** | **string** | Why the rebill attempt did not succeed | [optional] 
**Metadata** | [**ResponseMetadata**](ResponseMetadata.md) |  | [optional] 
**RebillAttempted** | **bool** | True if a rebill was attempted during this call | [optional] 
**RebillOrderId** | **string** | The order id created by a successful rebill | [optional] 
**RebillSuccess** | **bool** | True if the rebill attempt produced an order | [optional] 
**Success** | **bool** | Indicates if API call was successful | [optional] 
**Warning** | [**Warning**](Warning.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

