
# com.ultracart.admin.v2.Model.SfvbSmartAttribution

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssistPercent** | **decimal** | The global assist credit, 0 to 1. | [optional] 
**AttributionModel** | **string** | position_based, linear, time_decay or custom. | [optional] 
**AvailablePlatforms** | [**List&lt;SfvbSmartAttributionPlatform&gt;**](SfvbSmartAttributionPlatform.md) | Platforms detected from the storefront&#39;s tracking integrations that are not configured yet, with suggested settings. | [optional] 
**CloserPercent** | **decimal** | The global closer credit, 0 to 1. | [optional] 
**Configured** | **bool** | True when the storefront has a saved configuration.  When false, the other fields are the defaults an enable would save. | [optional] 
**HashSha256** | **string** | The hash of the configuration.  Send it as If-Match when changing or deleting it. | [optional] 
**LookbackDays** | **int** | How many days of a shopper&#39;s visits count toward an order, 7 to 365. | [optional] 
**Mode** | **string** | disabled, report_only (decisions are recorded but every platform reports as before) or active (Smart Attribution decides whether each platform&#39;s conversion fires and what value it reports). | [optional] 
**OriginatorPercent** | **decimal** | The global originator credit, 0 to 1.  The three global percentages total exactly 1. | [optional] 
**Platforms** | [**List&lt;SfvbSmartAttributionPlatform&gt;**](SfvbSmartAttributionPlatform.md) | The configured platforms. | [optional] 
**StorefrontOid** | **int** | The storefront this configuration belongs to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

