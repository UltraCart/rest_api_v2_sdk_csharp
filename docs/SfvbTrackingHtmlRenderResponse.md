
# com.ultracart.admin.v2.Model.SfvbTrackingHtmlRenderResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContentSha256** | **string** | The SHA-256 of the HTML rendered, before rendering, as the slot would store it.  For a draft, the hash a tracking_html.put approval binds. | [optional] 
**Html** | **string** | The rendered HTML, with order tokens filled and Velocity run, as the receipt would inject it.  Empty when the slot is empty. | [optional] 
**OrderId** | **string** | The test order rendered against. | [optional] 
**Provides** | **List&lt;string&gt;** | The Velocity references the render provides.  Any other reference the receipt page has is left as written. | [optional] 
**SizeBytes** | **int** | The size of html in UTF-8 bytes. | [optional] 
**Slot** | **string** | The slot rendered.  Always conversion. | [optional] 
**Source** | **string** | stored when the slot&#39;s saved HTML was rendered, draft when the request&#39;s content was. | [optional] 
**Warnings** | [**List&lt;SfvbErrorDetail&gt;**](SfvbErrorDetail.md) | What the render left out or could not do, such as tokens it doesn&#39;t fill. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

