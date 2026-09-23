
# com.ultracart.admin.v2.Model.SfvbUpsellItemLogic

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Items** | [**List&lt;SfvbUpsellItemLogicItem&gt;**](SfvbUpsellItemLogicItem.md) | The items this logic looks at.  Every item id must exist on the merchant account. | [optional] 
**Logic** | **string** | How items is read.  contains_any, contains_all, all, any or total.  Omitted or null means no item logic. | [optional] 
**TotalQuantityComparison** | **int** | For total only.  The quantity the summed quantity is compared with. | [optional] 
**TotalQuantityOperator** | **string** | For total only.  The comparison applied to the summed quantity.  One of &lt;, &lt;&#x3D;, &#x3D;, &gt;&#x3D;, &gt;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

