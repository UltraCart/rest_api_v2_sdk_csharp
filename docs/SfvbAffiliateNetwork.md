
# com.ultracart.admin.v2.Model.SfvbAffiliateNetwork

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AffiliateNetworkOid** | **int** | The network&#39;s oid.  Smart Attribution names it as a platform&#39;s integration_id. | [optional] 
**ApprovalNeeded** | **bool** | On a dry run, whether the real write needs an approved affiliate_network.change request. | [optional] 
**AssignToAffiliateOid** | **int** | The account&#39;s own affiliate that orders from this network are assigned to.  Null when none. | [optional] 
**Changes** | [**List&lt;SfvbTrackingChange&gt;**](SfvbTrackingChange.md) | On a write, what changed, or what would change on a dry run.  conversion_pixel shows its size and hash, not its content. | [optional] 
**Commission** | **decimal** | A fixed commission amount, in the account&#39;s currency.  Null when not set. | [optional] 
**ConversionPixel** | **string** | HTML for custom, or the postback URL for server_to_server, with the admin&#39;s order tokens.  Only on a read of one network and on a write.  Empty when not set. | [optional] 
**ConversionPixelSha256** | **string** | The SHA-256 of conversion_pixel as UTF-8. | [optional] 
**ConversionPixelSizeBytes** | **int** | The size of conversion_pixel in UTF-8 bytes. | [optional] 
**ConversionType** | **string** | custom prints conversion_pixel into the receipt page.  commission_junction fires the account&#39;s Commission Junction setup instead and does not use conversion_pixel.  server_to_server has UltraCart&#39;s server request conversion_pixel as an https URL after the order.  A value stored by the admin that is none of these is shown as stored. | [optional] 
**CookieLifetimeDays** | **int** | How long the visit is remembered, in days, 1 to 3650. | [optional] 
**DryRun** | **bool** | On a write, true when nothing was saved. | [optional] 
**FirePercentage** | **decimal** | The share of this network&#39;s orders whose pixel fires, from 0 to 100. | [optional] 
**HashSha256** | **string** | The hash of the network as stored.  Send it as If-Match on an update or delete. | [optional] 
**IfNotFired** | **string** | What UltraCart&#39;s own affiliate system does with an order whose pixel did not fire.  process handles it as usual, skip leaves it out, assign credits if_not_fired_affiliate_oid. | [optional] 
**IfNotFiredAffiliateOid** | **int** | For if_not_fired assign, the account&#39;s own affiliate to credit. | [optional] 
**NetworkName** | **string** | The network&#39;s name, up to 50 characters. | [optional] 
**ParameterName** | **string** | The URL parameter that marks a visit from this network, up to 50 characters.  Compared without case. | [optional] 
**ParameterValue** | **string** | The parameter&#39;s value for this network, up to 100 characters.  Compared without case. | [optional] 
**RecordFireInCustomField** | **int** | The order custom field, 1 to 10, that records whether the pixel fired. | [optional] 
**RecordNameInCustomField** | **int** | The order custom field, 1 to 10, that records the network&#39;s name. | [optional] 
**RemoveEmptyPixelParameters** | **bool** | For server_to_server only, true to drop query parameters that are empty after the tokens are filled in. | [optional] 
**StompPreviousCookie** | **bool** | True to replace another network&#39;s cookie.  False keeps the first network&#39;s. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

