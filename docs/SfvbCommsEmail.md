
# com.ultracart.admin.v2.Model.SfvbCommsEmail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContainerLastModifiedDts** | **string** | When the email container was last changed (ISO 8601, UTC). | [optional] 
**Deleted** | **bool** | True when the email was deleted. | [optional] 
**EmailUuid** | **string** | The email uuid.  Use it with the email container (owner type email) and with the email render endpoint. | [optional] 
**PendingReview** | **bool** | True while a change waits for review. | [optional] 
**PreviewText** | **string** | The preview text an inbox shows after the subject. | [optional] 
**Rejected** | **bool** | True when review rejected the email.  Don&#39;t edit it without the merchant. | [optional] 
**RequiresReview** | **bool** | True when a change to this email must be reviewed before it sends. | [optional] 
**StepUuid** | **string** | The step that sends this email. | [optional] 
**Subject** | **string** | The subject line. | [optional] 
**Transactional** | **bool** | True for a transactional email, which skips the marketing footer rules. | [optional] 
**VariantName** | **string** | For an email in an experiment step, the variant name.  Absent otherwise. | [optional] 
**VariantPercentage** | **decimal** | For an email in an experiment step, the share of customers it is sent to. | [optional] 
**VariantWinner** | **bool** | For an email in an experiment step, true when the experiment chose it as the winner. | [optional] 
**_Version** | **int** | The email version. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

