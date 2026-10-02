
# com.ultracart.admin.v2.Model.SfvbBlogPostDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowComments** | **bool** | Whether shoppers may comment.  Like every false value here, false is left out of the response. | [optional] 
**Author** | **string** | The post author. | [optional] 
**BlogPostOid** | **int** | The blog post&#39;s oid.  This is what a page&#39;s blog post assignment names. | [optional] 
**Body** | **string** | The post body as HTML, exactly as stored. | [optional] 
**CreatedDts** | **string** | When the post was created (ISO 8601, UTC). | [optional] 
**Excerpt** | **string** | The post excerpt as HTML, exactly as stored. | [optional] 
**Images** | [**List&lt;SfvbBlogPostImage&gt;**](SfvbBlogPostImage.md) | The post&#39;s images, the default image first. | [optional] 
**LastModifiedDts** | **string** | When the post was last changed (ISO 8601, UTC), or null if it never was. | [optional] 
**PublicationDts** | **string** | When the post is published (ISO 8601, UTC), or null for a draft. | [optional] 
**SeoDescription** | **string** | The meta description (storefrontSEODescription).  Absent when not set. | [optional] 
**SeoKeywords** | **string** | The meta keywords (storefrontSEOKeywords).  Absent when not set. | [optional] 
**SeoTitle** | **string** | The page head title (storefrontSEOTitle).  Absent when not set, and the head then uses the post title. | [optional] 
**Tags** | **List&lt;string&gt;** | The post&#39;s tags, in alphabetical order.  The order they were sent in is not kept. | [optional] 
**Title** | **string** | The post title. | [optional] 
**Unassigned** | **bool** | True when no page shows this post yet. | [optional] 
**UrlPart** | **string** | The post&#39;s name in its URL. | [optional] 
**ViewUrl** | **string** | The post&#39;s address on the storefront, or null until a page shows it. | [optional] 
**Visibility** | **string** | P public, L logged in customers only, D draft. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

