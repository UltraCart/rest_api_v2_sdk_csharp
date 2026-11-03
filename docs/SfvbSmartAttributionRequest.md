
# com.ultracart.admin.v2.Model.SfvbSmartAttributionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssistPercent** | **decimal** | 0 to 1, at most 4 decimals. | [optional] 
**AttributionModel** | **string** | position_based, linear, time_decay or custom. | [optional] 
**CloserPercent** | **decimal** | 0 to 1, at most 4 decimals. | [optional] 
**LookbackDays** | **int** | 7 to 365. | [optional] 
**Mode** | **string** | disabled, report_only or active.  Making it active, or any change while it is active, needs an approval. | [optional] 
**OriginatorPercent** | **decimal** | 0 to 1, at most 4 decimals.  The three global percentages must total exactly 1, so send all three to change the split. | [optional] 
**Platforms** | [**List&lt;SfvbSmartAttributionPlatform&gt;**](SfvbSmartAttributionPlatform.md) | When sent, replaces the whole platform list.  Up to 100, each name and id once.  Left out, the list is unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

