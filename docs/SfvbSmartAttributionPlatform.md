
# com.ultracart.admin.v2.Model.SfvbSmartAttributionPlatform

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssistPercent** | **decimal** | This platform&#39;s assist credit, 0 to 1.  Used only when platform_type_override is true. | [optional] 
**CloserPercent** | **decimal** | This platform&#39;s closer credit, 0 to 1.  Used only when platform_type_override is true. | [optional] 
**FireOnRebill** | **bool** | True when the platform also reports auto order rebills.  On a write, when left out, true for paid and owned and false for the affiliate types. | [optional] 
**IntegrationId** | **int** | The integration&#39;s id, such as an affiliate network pixel&#39;s oid.  Null for a platform matched by name.  On a write it must be an id from platforms or available_platforms. | [optional] 
**IntegrationName** | **string** | The platform, as Smart Attribution names it, up to 50 characters. | [optional] 
**NonParticipantPercent** | **decimal** | The credit this platform reports for an order it took no part in, 0 to 1.  0 when left out. | [optional] 
**OriginatorPercent** | **decimal** | This platform&#39;s originator credit, 0 to 1.  Used only when platform_type_override is true. | [optional] 
**PlatformType** | **string** | paid, owned, external affiliate, affiliate network pixel, or excluded. | [optional] 
**PlatformTypeOverride** | **bool** | True when this platform uses its own originator, assist and closer split instead of the global one.  On a write, when left out, true if all three of its percentages are sent. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

