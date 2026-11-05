
# com.ultracart.admin.v2.Model.SfvbCommsMembersResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerData** | **string** | masked, or shown when show_customer_data was sent. | [optional] 
**ListUuid** | **string** | The list, for a list&#39;s members. | [optional] 
**Members** | [**List&lt;SfvbCommsMember&gt;**](SfvbCommsMember.md) | This page of members. | [optional] 
**Notes** | **List&lt;string&gt;** | What to keep in mind, such as how to handle customer data that is shown. | [optional] 
**Page** | **int** | The page number, from 1. | [optional] 
**PageSize** | **int** | Members per page. | [optional] 
**RebuildRequired** | **bool** | For a segment, true while it is being rebuilt, so the members are from the last rebuild. | [optional] 
**SegmentUuid** | **string** | The segment, for a segment&#39;s members. | [optional] 
**TotalMembers** | **int** | How many members there are. | [optional] 
**TotalPages** | **int** | How many pages there are. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

