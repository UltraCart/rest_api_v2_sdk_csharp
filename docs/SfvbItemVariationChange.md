
# com.ultracart.admin.v2.Model.SfvbItemVariationChange

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Axis** | **string** | The axis the change is about. | [optional] 
**Before** | **string** | add_option puts the new option before this one.  Otherwise it goes last. | [optional] 
**Child** | **string** | set_combination - the child item id, or null to clear the combination. | [optional] 
**DefaultOption** | **bool** | add_option and add_axis make the option the default. | [optional] 
**DefaultText** | **string** | The prompt, for add_axis and set_default_text.  Null clears it. | [optional] 
**MultimediaOid** | **int** | An image of the parent item.  For set_option_multimedia null clears it; for set_combination null keeps the current one. | [optional] 
**Op** | **string** | add_axis, remove_axis, rename_axis, add_option, remove_option, rename_option, reorder_options, set_default, set_default_text, set_option_multimedia or set_combination. | [optional] 
**Quantity** | **int** | set_combination - how many of the child the combination adds.  Defaults to 1. | [optional] 
**To** | **string** | The new name, for rename_axis and rename_option. | [optional] 
**Value** | **string** | The option the change is about. | [optional] 
**Values** | **List&lt;string&gt;** | add_axis options in order, or every option in its new order for reorder_options. | [optional] 
**VariationValues** | [**List&lt;SfvbItemVariationValue&gt;**](SfvbItemVariationValue.md) | set_combination - one axis and option per axis. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

