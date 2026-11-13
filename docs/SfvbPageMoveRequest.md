
# com.ultracart.admin.v2.Model.SfvbPageMoveRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DryRun** | **bool** | True to run every check and report what would move, without moving anything or needing an approval. | [optional] 
**NewPath** | **string** | Where the page goes, for example /lp/summer-sale/ or /sale/spring/.  Its parent page must exist, and nothing may be at this path yet. | [optional] 
**Path** | **string** | The page to move, for example /lp/spring-sale/. | [optional] 
**RedirectNote** | **string** | The note on that redirect rule.  Up to 500 characters.  A note naming the move is used when left out. | [optional] 
**RedirectOldUrl** | **string** | 301 to add one pattern redirect from the old path, sub-pages and items included, to the new one in the same call.  Leave it out to add none, and the old addresses answer 404. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

