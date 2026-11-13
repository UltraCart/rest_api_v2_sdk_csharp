
# com.ultracart.admin.v2.Model.SfvbPageMoveResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DryRun** | **bool** | True when nothing was moved. | [optional] 
**NewPath** | **string** | The page&#39;s path after the move. | [optional] 
**Page** | [**SfvbPageResponse**](SfvbPageResponse.md) |  | [optional] 
**PagesMoved** | **int** | How many pages moved, the page itself included. | [optional] 
**Path** | **string** | The page&#39;s path before the move. | [optional] 
**Redirect** | [**SfvbRedirect**](SfvbRedirect.md) |  | [optional] 
**RedirectSource** | **string** | The pattern the old addresses redirect from, when a redirect was asked for. | [optional] 
**Warnings** | [**List&lt;SfvbErrorDetail&gt;**](SfvbErrorDetail.md) | Findings that did not block the move, such as a redirect chain. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

