
# com.ultracart.admin.v2.Model.SfvbEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventDts** | **string** | When it happened, ISO 8601. | [optional] 
**EventId** | **string** | Time-ordered id.  Pass the last one seen as after to replay what came since. | [optional] 
**ObjectId** | **string** | The id of what changed, such as the approval_id. | [optional] 
**ObjectType** | **string** | What changed, such as approval. | [optional] 
**StorefrontOid** | **int** | The storefront it concerns.  Empty for merchant-level objects. | [optional] 
**Type** | **string** | approval.decided (approved, denied, cancelled or refused by the script review) or approval.ready (the review finished and the person can decide). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

