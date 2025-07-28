# com.ultracart.admin.v2.Model.CartUpsellAfter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FinalizeAfterDts** | **string** | The date/time after which the cart will finalize into an order. | [optional] 
**FinalizeAfterMinutes** | **int?** | The amount of inactivity in minutes after which the cart should be finalized into an order.  This will calculate the finalize_after_dts field. | [optional] 
**UpsellPathCode** | **string** | Upsell path code (this is for legacy upsells only) | [optional] 
**UpsellPathName** | **string** | Upsell path name to start on (StoreFront Upsells).  Will only be respected on a handoff API call. | [optional] 
**UpsellPathVariation** | **string** | Upsell path variation to start on (StoreFront Upsells).   Will only be respected on a handoff API call. | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

