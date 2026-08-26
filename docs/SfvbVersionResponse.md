
# com.ultracart.admin.v2.Model.SfvbVersionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContainerManagerVersion** | **string** | Container manager version used to compile for this merchant. | [optional] 
**ContainerVersionsRetained** | **int** | Versions kept per non-file container before the oldest are pruned.  Beyond this, history is gone - not merely paginated. | [optional] 
**ElementCount** | **int** | Number of element types this version recognizes. | [optional] 
**MaxCjsonBytes** | **int** | Largest CJSON document that will be parsed, in bytes. | [optional] 
**MaxPreviewSessionBytes** | **int** | Largest payload one preview session may hold, in bytes. | [optional] 
**MaxSearchResults** | **int** | Hard ceiling on file search results per page. | [optional] 
**MaxTemplateBytes** | **int** | Largest template file that can be written, in bytes. | [optional] 
**MaxWidgetIdsPerRequest** | **int** | Most widget ids that can be reserved in one call. | [optional] 
**PreviewSessionTtlSeconds** | **int** | Seconds a preview session survives before expiring. | [optional] 
**Release** | **string** | Release channel selected for this merchant. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

