# com.ultracart.admin.v2.Model.OrderRefundableResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Error** | [**Error**](Error.md) |  | [optional] 
**ItemLevelRefundReasonRequired** | **bool?** | True if the item level refund reason is required | [optional] 
**ItemLevelRefundReasons** | [**List&lt;OrderReason&gt;**](OrderReason.md) | Reason codes available at the item level. | [optional] 
**ItemLevelReturnReasons** | [**List&lt;OrderReason&gt;**](OrderReason.md) | Return codes available at the item level. | [optional] 
**ManualBecauseMultipleCharges** | **bool?** | If true, this refund will have to be manually done because of additional charges with the virtual terminal were made | [optional] 
**Metadata** | [**ResponseMetadata**](ResponseMetadata.md) |  | [optional] 
**OrderLevelRefundReasonRequired** | **bool?** | True if the order level refund reason is required | [optional] 
**OrderLevelRefundReasons** | [**List&lt;OrderReason&gt;**](OrderReason.md) | Reason codes available at the order level. | [optional] 
**OrderLevelRejectReasonRequired** | **bool?** | True if the order level reject reason is required | [optional] 
**OrderLevelRejectReasons** | [**List&lt;OrderReason&gt;**](OrderReason.md) | Reject codes available at the order level. | [optional] 
**Refundable** | **bool?** | Whether the order is refundable or not.  Null should be interpreted as false. | [optional] 
**Success** | **bool?** | Indicates if API call was successful | [optional] 
**Warning** | [**Warning**](Warning.md) |  | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

