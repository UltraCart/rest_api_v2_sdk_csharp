
# com.ultracart.admin.v2.Model.SfvbRecording

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdPlatform** | [**ScreenRecordingAdPlatform**](ScreenRecordingAdPlatform.md) |  | [optional] 
**Browser** | **string** | Browser name from the user agent. | [optional] 
**BrowserVersion** | **string** | Browser version from the user agent. | [optional] 
**Converted** | **bool** | True when the session ended in an order. | [optional] 
**Device** | **string** | Device name from the user agent. | [optional] 
**EndTimestamp** | **string** | When the session ended, ISO-8601 in UTC. | [optional] 
**GeolocationCountry** | **string** | Country the visitor was in. | [optional] 
**GeolocationState** | **string** | State or region the visitor was in. | [optional] 
**LanguageIsoCode** | **string** | The browser language. | [optional] 
**OrderId** | **string** | The order placed during the session, when there was one. | [optional] 
**Os** | **string** | Operating system from the user agent. | [optional] 
**PageViewCount** | **int** | How many pages the visitor viewed. | [optional] 
**PageViews** | [**List&lt;SfvbRecordingPageView&gt;**](SfvbRecordingPageView.md) | The pages viewed, in order. | [optional] 
**ReferrerDomain** | **string** | The domain that referred the visitor. | [optional] 
**RrwebVersion** | **string** | The rrweb version that recorded the session.  Replay with the same version. | [optional] 
**ScreenRecordingUuid** | **string** | Identifies the recording. | [optional] 
**StartTimestamp** | **string** | When the session started, ISO-8601 in UTC. | [optional] 
**TimeOnSite** | **int** | Seconds the visitor spent on the site. | [optional] 
**UtmCampaign** | **string** | utm_campaign on arrival. | [optional] 
**UtmSource** | **string** | utm_source on arrival. | [optional] 
**WindowHeight** | **int** | Browser window height in pixels. | [optional] 
**WindowWidth** | **int** | Browser window width in pixels. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

