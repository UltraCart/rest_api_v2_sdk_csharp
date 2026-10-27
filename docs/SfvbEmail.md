
# com.ultracart.admin.v2.Model.SfvbEmail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContainerLastModifiedDts** | **string** | When the email container was last changed (ISO 8601, UTC). | [optional] 
**EmailUuid** | **string** | The email uuid.  The same uuid the email container (owner type email) and the email render take. | [optional] 
**HashSha256** | **string** | Hash of the subject and preview text.  Send it as If-Match when updating.  A change to the email body does not change it. | [optional] 
**Live** | **bool** | True when the email is in a flow or campaign that is sending, so a change reaches customers and needs sfvb_publish.  An email in neither is reported live. | [optional] 
**Notes** | **List&lt;string&gt;** | What a write did beyond the fields asked for, such as a step label it could not refresh.  Only on a write. | [optional] 
**PendingReview** | **bool** | True while a change waits for review.  An edit puts it back to needing review. | [optional] 
**PreviewText** | **string** | The preview text an inbox shows after the subject. | [optional] 
**Rejected** | **bool** | True when review rejected the email.  An edit puts it back to needing review. | [optional] 
**RequiresReview** | **bool** | True when a change to this email must be reviewed before it sends. | [optional] 
**Subject** | **string** | The subject line.  Merge tokens such as firstName are filled in at send. | [optional] 
**SuspendedForSpam** | **bool** | True when UltraCart suspended the email for spam.  Edits are refused until the merchant resolves it with UltraCart support. | [optional] 
**Transactional** | **bool** | True for a transactional email, which skips the marketing footer rules. | [optional] 
**_Version** | **int** | The email version.  Every save adds one. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

