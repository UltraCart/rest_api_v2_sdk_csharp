
# com.ultracart.admin.v2.Model.SfvbRedirectDeleteResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Applied** | **bool** | True when this call deleted rules. | [optional] 
**Deletable** | **int** | Rows that can be, or on an apply could be, deleted. | [optional] 
**Deleted** | **int** | Rules deleted.  Zero on a dry run. | [optional] 
**Limit** | **int** | The most rules a storefront can have for add and import to work. | [optional] 
**NotFound** | **int** | Rows naming no rule on this storefront.  Skipped. | [optional] 
**PlanHash** | **string** | Send this to apply exactly these rows.  Also what an approval for them is bound to. | [optional] 
**Rows** | [**List&lt;SfvbRedirectDeleteRowResult&gt;**](SfvbRedirectDeleteRowResult.md) | One result per row, in request order. | [optional] 
**RuleCount** | **int** | The storefront&#39;s redirect rules now.  After an apply, after the delete. | [optional] 
**Stale** | **int** | Rows whose rule changed since its hash was read.  Skipped. | [optional] 
**Total** | **int** | Rows in the request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

