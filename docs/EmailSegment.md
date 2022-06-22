
# com.ultracart.admin.v2.Model.EmailSegment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowCsvDownload** | **bool** | True if the current user has the rights to download this segment. | [optional] 
**AllowFacebookAudiences** | **bool** | True if this StoreFront has the Facebook Analytics app connected and supports them | [optional] 
**CreatedDts** | **string** | Created date | [optional] 
**Deleted** | **bool** | True if this campaign was deleted | [optional] 
**EmailSegmentUuid** | **string** | Email segment UUID | [optional] 
**EspListSegmentFolderUuid** | **string** | List/Segment folder UUID | [optional] 
**FacebookCustomAudience** | **bool** | True if you want to sync to a facebook custom audience | [optional] 
**FilterProfileEquationJson** | **string** | File profile equation json | [optional] 
**MemberCount** | **int** | Count of members in this segment | [optional] 
**MerchantId** | **string** | Merchant ID | [optional] 
**Name** | **string** | Name of email segment | [optional] 
**RankJson** | **string** | Rank settings json | [optional] 
**RebuildRequired** | **bool** | True if a rebuild is required because some part of the segment has changed | [optional] 
**StorefrontOid** | **int** | Storefront oid | [optional] 
**ThirdpartyJoinAddTags** | **List&lt;string&gt;** | Third party provider tags to add when a customer joins the segment. | [optional] 
**ThirdpartyJoinRemoveTags** | **List&lt;string&gt;** | Third party provider tags to remove when a customer joins the segment. | [optional] 
**ThirdpartyLeaveAddTags** | **List&lt;string&gt;** | Third party provider tags to add when a customer leaves the segment. | [optional] 
**ThirdpartyLeaveRemoveTags** | **List&lt;string&gt;** | Third party provider tags to remove when a customer leaves the segment. | [optional] 
**ThirdpartyListId** | **string** | List id of third party provider to sync with. | [optional] 
**ThirdpartyProviderName** | **string** | Name of third party provider to sync segment to a list with. | [optional] 
**UsedBy** | [**List&lt;EmailListSegmentUsedBy&gt;**](EmailListSegmentUsedBy.md) | Details on the flows or campaigns that use this list. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

