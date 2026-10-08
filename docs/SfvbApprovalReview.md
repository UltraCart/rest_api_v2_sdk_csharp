
# com.ultracart.admin.v2.Model.SfvbApprovalReview

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Apis** | **List&lt;string&gt;** | Browser features the script uses that matter for safety, such as network calls, cookies, storage and dynamic code. | [optional] 
**Domains** | **List&lt;string&gt;** | Every host the script names, found by UltraCart&#39;s scanner rather than the AI. | [optional] 
**Findings** | [**List&lt;SfvbApprovalReviewFinding&gt;**](SfvbApprovalReviewFinding.md) | What the reviewers flagged, each with the line and the quoted code. | [optional] 
**NewDomains** | **List&lt;string&gt;** | Hosts the current version of the file does not name. | [optional] 
**PromptVersion** | **string** | Version of the review policy that produced this. | [optional] 
**ReviewedAt** | **string** | When the review ran, ISO 8601 UTC. | [optional] 
**Signals** | **List&lt;string&gt;** | Obfuscation, card field and credential signals the scanner found.  Credentials are named by kind, never by value. | [optional] 
**SizeBytes** | **int** | Size of the reviewed script in bytes. | [optional] 
**Summary** | **string** | What the script does, in plain words, as the reviewers read it. | [optional] 
**Verdict** | **string** | approve when both reviewers found nothing, human when the person should look closely.  On a refused request, block when both reviewers found a clear violation, error when the review could not finish. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

