
# com.ultracart.admin.v2.Model.SfvbRecordingPageView

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Domain** | **string** | The host name of the address. | [optional] 
**Events** | [**List&lt;SfvbRecordingEvent&gt;**](SfvbRecordingEvent.md) | Named events on this page view in time order, such as rage clicks and script errors. | [optional] 
**FirstEventTimestamp** | **string** | When recording of this page view began, ISO-8601 in UTC. | [optional] 
**LastEventTimestamp** | **string** | When recording of this page view ended, ISO-8601 in UTC. | [optional] 
**MissingEvents** | **bool** | True when no replay events were stored for this page view. | [optional] 
**Params** | [**List&lt;SfvbRecordingParameter&gt;**](SfvbRecordingParameter.md) | The query string parameters on the address. | [optional] 
**Referrer** | **string** | The referring address, when there was one. | [optional] 
**ScreenRecordingPageViewUuid** | **string** | Identifies this page view when fetching its replay events. | [optional] 
**TimeOnPage** | **int** | Seconds the visitor spent on the page. | [optional] 
**TimingDomContentLoaded** | **int** | Milliseconds until DOMContentLoaded fired. | [optional] 
**TimingLoaded** | **int** | Milliseconds until the load event fired. | [optional] 
**TruncatedEvents** | **bool** | True when the recorder stopped storing events part way through this page view. | [optional] 
**Url** | **string** | The address the visitor viewed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

