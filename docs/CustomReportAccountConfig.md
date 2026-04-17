
# com.ultracart.admin.v2.Model.CustomReportAccountConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AiBudget** | **decimal** |  | [optional] 
**AiUsage** | **decimal** | Current AI usage creating reports | [optional] 
**AiUsageBreakdowns** | [**List&lt;CustomReportUsageBreakdown&gt;**](CustomReportUsageBreakdown.md) |  | [optional] 
**MerchantId** | **string** | Current BigQuery SQL usage running reports | [optional] 
**NoviceSqlComments** | **bool** |  | [optional] 
**OptIn** | **bool** | True if they have opted into custom reports | [optional] 
**OptInByUser** | **string** | User that opted into custom reporting | [optional] 
**OptInDate** | **string** | Date/time that custom reporting was opted in to | [optional] 
**ReadOnly** | **bool** |  | [optional] 
**SqlBudget** | **decimal** |  | [optional] 
**SqlUsage** | **decimal** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

