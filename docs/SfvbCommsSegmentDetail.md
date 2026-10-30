
# com.ultracart.admin.v2.Model.SfvbCommsSegmentDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedDts** | **string** | When it was created (ISO 8601, UTC). | [optional] 
**FilterProfileEquationJson** | **string** | The rule, as JSON text in the admin editor&#39;s shape.  Every entry in groups must hold, and inside a group one function is enough. | [optional] 
**FolderUuid** | **string** | The list and segment folder it is filed in, or absent. | [optional] 
**HashSha256** | **string** | Send as If-Match on an update.  Covers the name, the rule and the folder. | [optional] 
**MemberCount** | **int** | How many customers it held at its last rebuild.  Out of date while rebuild_required is true. | [optional] 
**Name** | **string** | The segment name. | [optional] 
**RebuildNightly** | **bool** | True when the rule has a date range, so the segment is also rebuilt every night. | [optional] 
**RebuildPercentage** | **decimal** | How far the current rebuild has got, when one is running. | [optional] 
**RebuildRequired** | **bool** | True when the rule changed and the segment has not finished rebuilding. | [optional] 
**SegmentUuid** | **string** | The segment uuid. | [optional] 
**UsedBy** | [**List&lt;SfvbCommsSegmentUsedBy&gt;**](SfvbCommsSegmentUsedBy.md) | The campaigns that send to it and the flows it starts. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

