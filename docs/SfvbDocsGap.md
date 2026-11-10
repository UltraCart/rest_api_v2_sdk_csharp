
# com.ultracart.admin.v2.Model.SfvbDocsGap

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Duplicate** | **bool** | On submit, true when this account had already sent the same report.  The earlier report_id is returned and nothing new is kept. | [optional] 
**ReceivedAt** | **string** | When UltraCart received the report. | [optional] 
**ReportId** | **string** | The report&#39;s id.  Quote it to UltraCart, or look the report up with GET docs/gaps/{report_id}. | [optional] 
**Status** | **string** | received until UltraCart staff look at it, then accepted, declined or fixed. | [optional] 
**StatusAt** | **string** | When the status last changed.  Absent while the report is received. | [optional] 
**StorefrontOid** | **int** | The storefront named when the report was sent, if one was. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

