
# com.ultracart.admin.v2.Model.SfvbApprovalParams

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlogPostOid** | **int** | The blog post, for blog_post.delete. | [optional] 
**ContentSha256** | **string** | For file.put_script, the SHA-256 of the exact bytes approved.  Set by the server, never by the caller.  The write must send bytes with this hash. | [optional] 
**Path** | **string** | The file path, for file.delete and file.put_script.  Exactly as the gated call will send it. | [optional] 
**RowsSha256** | **string** | For redirect.delete_batch, the plan_hash of the exact rows approved.  Set by the server.  The batch delete must send rows with this hash. | [optional] 
**RuleCount** | **int** | For redirect.delete_batch, how many rules the batch would delete when it was requested.  Set by the server. | [optional] 
**_Version** | **int** | For file.put_script, the history version a revert restores.  Leave it out, and send content instead, for a write. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

