# com.ultracart.admin.v2.Model.EmailStat
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClickCount** | **int?** | Count of clicked emails | [optional] 
**ClickCountFormatted** | **string** | Count of clicked emails, formatted | [optional] 
**ConversionCount** | **int?** | Count of conversions | [optional] 
**ConversionCountFormatted** | **string** | Count of conversions, formatted | [optional] 
**Deleted** | **bool?** | True if campaign/flow has been archived | [optional] 
**DeliveredCount** | **int?** | Count of delivered emails | [optional] 
**DeliveredCountFormatted** | **string** | Count of delivered emails, formatted | [optional] 
**KickboxCount** | **int?** | Count of emails kicked | [optional] 
**KickboxCountFormatted** | **string** | Count of emails kicked, formatted | [optional] 
**MerchantId** | **string** | Merchant ID | [optional] 
**Name** | **string** | List or segment name | [optional] 
**OpenCount** | **int?** | Count of opened emails | [optional] 
**OpenCountFormatted** | **string** | Count of opened emails, formatted | [optional] 
**OrderCount** | **int?** | Count of orders | [optional] 
**OrderCountFormatted** | **string** | Count of orders, formatted | [optional] 
**PermanentBounceCount** | **int?** | Count of emails permanently bounced | [optional] 
**PermanentBounceCountFormatted** | **string** | Count of emails permanently bounced, formatted | [optional] 
**Profit** | **decimal?** | Profit | [optional] 
**ProfitFormatted** | **string** | Profit, formatted | [optional] 
**Revenue** | **decimal?** | Revenue | [optional] 
**RevenueFormatted** | **string** | Revenue, formatted | [optional] 
**SendCount** | **int?** | Count of emails sent | [optional] 
**SendCountFormatted** | **string** | Count of emails sent, formatted | [optional] 
**SkippedCount** | **int?** | Count of skipped emails | [optional] 
**SkippedCountFormatted** | **string** | Count of skipped emails, formatted | [optional] 
**SpamCount** | **int?** | Count of emails classified as spam | [optional] 
**SpamCountFormatted** | **string** | Count of emails classified as spam, formatted | [optional] 
**StatType** | **string** | Campaign, Flow or None (for anything else) | [optional] 
**Status** | **string** | Status of campaign or flow | [optional] 
**StatusDts** | **string** | Status dts of campaign or flow | [optional] 
**StepUuid** | **string** | Step UUID if the statistics are at the step/email level | [optional] 
**Steps** | [**List&lt;EmailStat&gt;**](EmailStat.md) |  | [optional] 
**StorefrontOid** | **int?** | Storefront oid | [optional] 
**UnsubscribeCount** | **int?** | Count of emails classified as unsubscribe | [optional] 
**UnsubscribeCountFormatted** | **string** | Count of emails classified as unsubscribe, formatted | [optional] 
**Uuid** | **string** | List/Segment uuid, or Flow/Campaign uuid depending on level of stat aggregation. | [optional] 
**ViewCount** | **int?** | Count of views | [optional] 
**ViewCountFormatted** | **string** | Count of views, formatted | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

