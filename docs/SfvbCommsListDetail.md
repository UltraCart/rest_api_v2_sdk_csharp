
# com.ultracart.admin.v2.Model.SfvbCommsListDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedDts** | **string** | When the list was created. | [optional] 
**FolderUuid** | **string** | The list and segment folder it is filed in, or none. | [optional] 
**HashSha256** | **string** | The hash of the name, folder and public settings.  Send it as If-Match to change or archive the list. | [optional] 
**ListUuid** | **string** | The list uuid. | [optional] 
**MemberCount** | **int** | How many customers are on the list. | [optional] 
**Name** | **string** | The list name. | [optional] 
**PublicDescription** | **string** | The description subscribers see for a public list. | [optional] 
**PublicList** | **bool** | True when subscribers can choose this list on the storefront&#39;s email preferences page. | [optional] 
**UsedBy** | [**List&lt;SfvbCommsSegmentUsedBy&gt;**](SfvbCommsSegmentUsedBy.md) | The campaigns that send to the list and the flows it starts, each with whether it is live. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

