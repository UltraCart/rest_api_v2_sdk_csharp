
# com.ultracart.admin.v2.Model.SfvbSequenceStepCreateResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BackContainerUuid** | **string** | A post_card step&#39;s back, the container with owner type postcardback and this owner id. | [optional] 
**EmailUuid** | **string** | The new email&#39;s uuid.  Its body is the email container with this owner id. | [optional] 
**FrontContainerUuid** | **string** | A post_card step&#39;s front, the container with owner type postcardfront and this owner id. | [optional] 
**LibraryFilesKept** | **List&lt;string&gt;** | The library item&#39;s files whose path already held a file, which was kept, not replaced. | [optional] 
**LibraryFilesSkipped** | **List&lt;string&gt;** | The library item&#39;s files that weren&#39;t written because they aren&#39;t a PNG, JPEG or GIF image whose bytes match its name.  Only those images are copied from a library item. | [optional] 
**LibraryFilesWritten** | **List&lt;string&gt;** | Storefront file paths the library item&#39;s files were written to.  A file already at its path is kept as it is and listed in library_files_kept instead. | [optional] 
**LibraryItemOid** | **int** | The code library email item the new email started from (#1589), when one was given. | [optional] 
**Notes** | **List&lt;string&gt;** | What to do next, such as writing the body, and customers already waiting on the step before it. | [optional] 
**PostcardUuid** | **string** | A post_card step&#39;s new postcard (#1644). | [optional] 
**RequiresReview** | **bool** | True when the new email must pass content review before it sends. | [optional] 
**Step** | [**SfvbSequenceStep**](SfvbSequenceStep.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

