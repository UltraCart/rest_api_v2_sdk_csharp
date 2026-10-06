
# com.ultracart.admin.v2.Model.SfvbNotFoundEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BotHits** | **int** | Bot hits since bot counting began on this entry.  Empty when not yet counted. | [optional] 
**BotShare** | **Object** | bot_hits divided by counted_hits, 0 to 1.  Empty when not yet counted. | [optional] 
**CountedHits** | **int** | Hits since bot counting began, the base for bot_share. | [optional] 
**FirstSeenDts** | **string** | First hit, ISO 8601. | [optional] 
**Hits** | **int** | Every recorded hit, bots included. | [optional] 
**Ignored** | **bool** | True when the entry is ignored and no longer counts. | [optional] 
**LastSeenDts** | **string** | Latest hit, ISO 8601. | [optional] 
**NotFoundId** | **string** | The entry&#39;s id. | [optional] 
**Path** | **string** | The path, without its query string.  Token-like segments show as {token} unless asked for. | [optional] 
**RedirectedTo** | **string** | Where a redirect rule now sends this path, when one does. | [optional] 
**ReferrerHosts** | **List&lt;string&gt;** | Hosts of the pages that linked to it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

