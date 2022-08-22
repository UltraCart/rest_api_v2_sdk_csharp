
# com.ultracart.admin.v2.Model.ItemReviews

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HasApprovedReview** | **bool** | True if the item has an approved review | [optional] 
**HasReview** | **bool** | True if the item has a review | [optional] 
**IndividualReviews** | [**List&lt;ItemReview&gt;**](ItemReview.md) |  | [optional] 
**ReviewCount** | **int** | Number of approved reviews | [optional] 
**ReviewOverall** | **decimal** | Overall score of reviews | [optional] 
**ReviewTemplateName** | **string** | Review template name | [optional] 
**ReviewTemplateOid** | **int** | Review template object identifier | [optional] 
**Reviewable** | **bool** | True if the item is reviewable | [optional] 
**ShareReviewsWithMerchantItemId** | **string** | Share reviews with item id.  To set, use the share_reviews_with_merchant_item_oid field. | [optional] 
**ShareReviewsWithMerchantItemOid** | **int** | Share reviews with item oid.  To null out this field, set teh value to zero. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

