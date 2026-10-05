
# com.ultracart.admin.v2.Model.SfvbLibraryInstallReceipt

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cjson** | **string** | The fragment, with its file paths rewritten to where they were installed.  Ready to place. | [optional] 
**Conflicts** | [**List&lt;SfvbLibraryInstallConflict&gt;**](SfvbLibraryInstallConflict.md) | Paths that already held a different file.  With on_conflict fail these refuse the install. | [optional] 
**ContentManifest** | [**SfvbLibraryContentManifest**](SfvbLibraryContentManifest.md) |  | [optional] 
**FilesSkipped** | **List&lt;string&gt;** | Paths not written, because an identical or chosen existing file was kept, or the file could not be fetched. | [optional] 
**FilesWritten** | **List&lt;string&gt;** | Storefront paths this install wrote. | [optional] 
**LibraryOid** | **int** | The entry. | [optional] 
**RevisionNumber** | **int** | The revision installed. | [optional] 
**UnresolvedParameters** | **List&lt;string&gt;** | Required parameters with no default.  Replace them in the cjson before placing it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

