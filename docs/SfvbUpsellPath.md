
# com.ultracart.admin.v2.Model.SfvbUpsellPath

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** | Whether the path runs.  Setting it true, or changing a path that is active, needs the sfvb_publish scope. | [optional] 
**Archived** | **bool** | Read only here.  Filed out of the default list.  Change it with the archive and unarchive calls. | [optional] 
**CustomerType** | **string** | Which customers the path runs for.  all (the default), new or existing. | [optional] 
**HashSha256** | **string** | Read only.  Hash of the path&#39;s writable fields.  Send it in If-Match on an update. | [optional] 
**ItemLogicSuppression** | [**SfvbUpsellItemLogic**](SfvbUpsellItemLogic.md) |  | [optional] 
**ItemLogicTrigger** | [**SfvbUpsellItemLogic**](SfvbUpsellItemLogic.md) |  | [optional] 
**Location** | **string** | Where in checkout the path runs.  pre checkout or post checkout (the default). | [optional] 
**MaximumOffers** | **int** | Most offers one shopper is shown on this path.  Omitted or null for no limit. | [optional] 
**Name** | **string** | Path name, at most 100 characters. | [optional] 
**PathOrder** | **int** | Read only here.  Position among this storefront&#39;s paths, first to last.  Change it with the move call. | [optional] 
**PathType** | **string** | cascading (the default) or single. | [optional] 
**TowerdataTrigger** | [**SfvbUpsellTowerData**](SfvbUpsellTowerData.md) |  | [optional] 
**TriggerItemIds** | **List&lt;string&gt;** | Read only.  The legacy flat trigger list, derived from item_logic_trigger when its logic is contains_any and empty otherwise. | [optional] 
**TriggerTags** | **List&lt;string&gt;** | Customer tags that trigger the path. | [optional] 
**UpsellPathOid** | **int** | Read only.  Upsell path oid. | [optional] 
**Variations** | [**List&lt;SfvbUpsellVariation&gt;**](SfvbUpsellVariation.md) | The variations shoppers are split between.  At least one. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

