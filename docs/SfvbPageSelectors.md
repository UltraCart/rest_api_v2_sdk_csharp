
# com.ultracart.admin.v2.Model.SfvbPageSelectors

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlogPostSelectors** | [**List&lt;SfvbPageBlogPostSelector&gt;**](SfvbPageBlogPostSelector.md) | The conditions that choose the page&#39;s blog posts. | [optional] 
**ItemSelectors** | [**List&lt;SfvbPageItemSelector&gt;**](SfvbPageItemSelector.md) | The conditions that choose the page&#39;s items.  While there are any, the page&#39;s items are recalculated from them and cannot be assigned by hand. | [optional] 
**MatchAllBlogPostSelectors** | **bool** | True when a blog post must meet every blog post selector, false when any one is enough. | [optional] 
**MatchAllItemSelectors** | **bool** | True when an item must meet every item selector, false when meeting any one is enough. | [optional] 
**Path** | **string** | The page path.  Read only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

