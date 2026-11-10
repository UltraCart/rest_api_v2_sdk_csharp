
# com.ultracart.admin.v2.Model.SfvbItemPreorderChildrenRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Children** | [**List&lt;SfvbItemPreorderChildRow&gt;**](SfvbItemPreorderChildRow.md) | The variations to change, 1 to 100, each named once. | [optional] 
**ClearEta** | **bool** | True to remove the ETA from every variation named.  Not with eta. | [optional] 
**Eta** | **string** | The expected date for every variation named, YYYY-MM-DD.  Not with clear_eta. | [optional] 
**Preorder** | **bool** | True to put the variations on pre-order, false to take them off.  Needs an approved item.preorder request when it changes any of them. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

