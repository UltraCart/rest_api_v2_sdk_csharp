
# com.ultracart.admin.v2.Model.SfvbRedirectResolveBatchResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NotFound** | **int** | How many paths end on a 404 (lands_on not_found), the ones to redirect or create. | [optional] 
**Redirected** | **int** | How many paths at least one rule redirects. | [optional] 
**Results** | [**List&lt;SfvbRedirectResolveResponse&gt;**](SfvbRedirectResolveResponse.md) | One result per path, in the order sent, the same as the single resolve&#39;s answer. | [optional] 
**Total** | **int** | How many paths were resolved. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

