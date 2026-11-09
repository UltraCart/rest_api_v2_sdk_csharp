
# com.ultracart.admin.v2.Model.SfvbTrackingProvider

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminPath** | **string** | Where the provider is in the admin. | [optional] 
**ApprovalNeeded** | **bool** | On a dry run, whether the real write needs an approved tracking_provider.change request. | [optional] 
**Changes** | [**List&lt;SfvbTrackingChange&gt;**](SfvbTrackingChange.md) | On a write, each setting it changed, or would change on a dry run.  Secrets read only set or cleared. | [optional] 
**Configured** | **bool** | True when the provider is on, which means one of its identifying fields is set. | [optional] 
**Consent** | [**SfvbTrackingProviderConsent**](SfvbTrackingProviderConsent.md) |  | [optional] 
**ConsentSupported** | **bool** | True when the provider can be held back until the shopper consents. | [optional] 
**Cost** | **string** | For google_tag_manager, what turning on Google Tag Gateway costs. | [optional] 
**DryRun** | **bool** | On a write, true when nothing was saved. | [optional] 
**Events** | [**List&lt;SfvbTrackingProviderEvent&gt;**](SfvbTrackingProviderEvent.md) | For a provider with standard events, each one and whether it is sent. | [optional] 
**Fields** | [**List&lt;SfvbTrackingProviderField&gt;**](SfvbTrackingProviderField.md) | Every field, in the order the admin shows them. | [optional] 
**Group** | **string** | google or other, the admin tab it is on. | [optional] 
**HashSha256** | **string** | The hash of the stored settings.  A secret counts by its mask and length only.  Send it as If-Match when changing or clearing the provider. | [optional] 
**Key** | **string** | The provider key, such as facebook or google_analytics. | [optional] 
**Name** | **string** | The name the admin shows. | [optional] 
**Notes** | **List&lt;string&gt;** | Anything for a person to know or do, such as a field the provider needs before it sends anything, or an OAuth connection to disconnect in the admin after a write. | [optional] 
**Oauth** | [**SfvbTrackingProviderOauth**](SfvbTrackingProviderOauth.md) |  | [optional] 
**ServerSide** | **string** | What the provider also sends from UltraCart&#39;s servers.  A consent gate holds back only the browser pixel, not these.  Absent when it sends nothing server side. | [optional] 
**WholesaleTiers** | [**List&lt;SfvbTrackingWholesaleTier&gt;**](SfvbTrackingWholesaleTier.md) | For google_analytics, the account number per wholesale pricing tier. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

