
# com.ultracart.admin.v2.Model.SfvbAffiliateNetworkRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssignToAffiliateOid** | **int** | One of the account&#39;s own affiliates.  Name it in unset to clear it. | [optional] 
**Commission** | **decimal** | A fixed commission amount, 0 or more, with at most 6 decimals.  Name it in unset to clear it. | [optional] 
**ConversionPixel** | **string** | HTML for custom, at most 10,000 characters, or one https URL for server_to_server.  An empty string empties it.  A pixel that a custom or server_to_server network will use needs an approved affiliate_network.change request for exactly this change. | [optional] 
**ConversionType** | **string** | custom, commission_junction or server_to_server. | [optional] 
**CookieLifetimeDays** | **int** | 1 to 3650. | [optional] 
**DryRun** | **bool** | True to check the change and say whether it needs an approval, without saving. | [optional] 
**FirePercentage** | **decimal** | 0 to 100, with at most 2 decimals. | [optional] 
**IfNotFired** | **string** | process, skip or assign.  assign needs if_not_fired_affiliate_oid. | [optional] 
**IfNotFiredAffiliateOid** | **int** | For if_not_fired assign, one of the account&#39;s own affiliates. | [optional] 
**NetworkName** | **string** | Up to 50 characters.  Required on a create. | [optional] 
**ParameterName** | **string** | Up to 50 characters.  Required on a create. | [optional] 
**ParameterValue** | **string** | Up to 100 characters.  Required on a create. | [optional] 
**RecordFireInCustomField** | **int** | 1 to 10. | [optional] 
**RecordNameInCustomField** | **int** | 1 to 10. | [optional] 
**RemoveEmptyPixelParameters** | **bool** | server_to_server only. | [optional] 
**StompPreviousCookie** | **bool** | True to replace another network&#39;s cookie. | [optional] 
**Unset** | **List&lt;string&gt;** | Fields to clear.  commission and assign_to_affiliate_oid only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

