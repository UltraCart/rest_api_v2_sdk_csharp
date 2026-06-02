
# com.ultracart.admin.v2.Model.ConversationAgentStatusRollup

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgentName** | **string** | Agent display name | [optional] 
**AgentUserId** | **string** | Agent user id | [optional] 
**AvailabilityPct** | **Object** |  | [optional] 
**AvailableSeconds** | **long** | Seconds spent Available (incl. Busy per OVERVIEW reporting convention) | [optional] 
**CallsTaken** | **int** | Calls handled by the agent on this day (PBX channel only) | [optional] 
**Channel** | **string** | Channel | [optional] 
**ChatsHandled** | **int** | Chats handled by the agent on this day (chat channel only) | [optional] 
**RollupDate** | **string** | Day this rollup covers (YYYY-MM-DD) | [optional] 
**StatusBreakdown** | **Object** | Per-status duration breakdown in seconds (status name -&gt; seconds) | [optional] 
**TotalTrackedSeconds** | **long** | Total seconds tracked across all statuses for the day | [optional] 
**UnavailableSeconds** | **long** | Seconds spent Unavailable | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

