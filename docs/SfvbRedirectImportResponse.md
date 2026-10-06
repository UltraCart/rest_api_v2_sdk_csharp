
# com.ultracart.admin.v2.Model.SfvbRedirectImportResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Applied** | **bool** | True when the rows were written. | [optional] 
**Blocked** | **int** | How many rows have a blocking finding.  Any blocked row means nothing is applied. | [optional] 
**Flagged** | **int** | How many rows have only warnings. | [optional] 
**Limit** | **int** | The most rules a storefront may have through SFVB. | [optional] 
**PlanHash** | **string** | Send back with the same rows to apply exactly this plan. | [optional] 
**Rows** | [**List&lt;SfvbRedirectImportRowResult&gt;**](SfvbRedirectImportRowResult.md) | The rows with findings. | [optional] 
**RuleCount** | **int** | How many rules the storefront has, or would have after applying. | [optional] 
**Total** | **int** | How many rows were sent. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

