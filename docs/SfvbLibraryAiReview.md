
# com.ultracart.admin.v2.Model.SfvbLibraryAiReview

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Findings** | **Object** | What the reviewers found.  detail is the category followed by the quoted evidence. | [optional] 
**PromptVersion** | **string** | Version of the review policy that produced this verdict. | [optional] 
**ReviewedDts** | **string** | When the review ran, ISO 8601. | [optional] 
**ScreenshotSha256** | **string** | The screenshot the review looked at, or absent when there was none. | [optional] 
**Summary** | **string** | One or two sentences explaining the verdict. | [optional] 
**Verdict** | **string** | approve, block, human or error.  block refuses any publish.  human or error refuses a public publish and is recorded on a shared one. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

