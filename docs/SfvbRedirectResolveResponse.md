
# com.ultracart.admin.v2.Model.SfvbRedirectResolveResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FinalPath** | **string** | Where the shopper ends up.  The storefront sends them straight there in one redirect. | [optional] 
**FinalStatus** | **string** | The status the shopper gets, 301, 302, rewrite, or none when no rule matches. | [optional] 
**LandsOn** | **string** | live_page, hidden_page, item, not_found or other (a file or system path). | [optional] 
**Path** | **string** | The path asked about. | [optional] 
**Steps** | [**List&lt;SfvbRedirectResolveStep&gt;**](SfvbRedirectResolveStep.md) | Each redirect followed, in order.  Empty when no rule matches. | [optional] 
**TooLong** | **bool** | True when the chain is longer than the storefront follows. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

