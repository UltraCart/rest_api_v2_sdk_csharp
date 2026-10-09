
# com.ultracart.admin.v2.Model.SfvbItemRelated

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HashSha256** | **string** | The hash of the above.  Send it as If-Match to change them. | [optional] 
**MerchantItemId** | **string** | The item&#39;s merchant item id. | [optional] 
**MerchantItemOid** | **int** | The item. | [optional] 
**NoSystemCalculatedRelatedItems** | **bool** | True when UltraCart does not calculate related items for this item. | [optional] 
**NotRelatable** | **bool** | True when this item is never shown as related to another. | [optional] 
**RelatedItems** | [**List&lt;SfvbItemRelatedItem&gt;**](SfvbItemRelatedItem.md) | In stored order - the merchant&#39;s own (user, addon, complementary) and UltraCart&#39;s calculated ones (system). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

