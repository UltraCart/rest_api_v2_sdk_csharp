
# com.ultracart.admin.v2.Model.SfvbTrackingHtmlResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxBytes** | **int** | The largest HTML the API writes to a slot, in UTF-8 bytes.  The admin allows larger, but UltraCart&#39;s review must read the whole of it. | [optional] 
**Slots** | [**List&lt;SfvbTrackingHtml&gt;**](SfvbTrackingHtml.md) | tracking and conversion, each with its size and hash_sha256.  Read one slot for its content. | [optional] 
**StorefrontOid** | **int** | The storefront. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

