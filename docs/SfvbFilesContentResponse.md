
# com.ultracart.admin.v2.Model.SfvbFilesContentResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Files** | [**List&lt;SfvbFileContentResult&gt;**](SfvbFileContentResult.md) | One entry per path read, in the order asked. | [optional] 
**RemainingPaths** | **List&lt;string&gt;** | Paths not read because the response reached its size limit, in the order asked.  Send them again to read them.  Omitted when every path was read. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

