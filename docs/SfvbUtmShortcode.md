
# com.ultracart.admin.v2.Model.SfvbUtmShortcode

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The shortcode.  Matched ignoring case. | [optional] 
**CreationDts** | **string** | When the shortcode was created, ISO 8601. | [optional] 
**Description** | **string** | What the shortcode is for.  Null when blank. | [optional] 
**HashSha256** | **string** | The hash of the code, description and values.  Send it as If-Match when changing or deleting the shortcode. | [optional] 
**ItmCampaign** | **string** | ITM campaign the shortcode applies.  Null when blank. | [optional] 
**ItmContent** | **string** | ITM content the shortcode applies.  Null when blank. | [optional] 
**ItmId** | **string** | ITM id the shortcode applies.  Null when blank. | [optional] 
**ItmMedium** | **string** | ITM medium the shortcode applies.  Null when blank. | [optional] 
**ItmSource** | **string** | ITM (internal tracking) source the shortcode applies.  Null when blank. | [optional] 
**ItmTerm** | **string** | ITM term the shortcode applies.  Null when blank. | [optional] 
**LastModifiedDts** | **string** | When the shortcode last changed, ISO 8601. | [optional] 
**PathSegment** | **string** | Append this to a storefront path (as its last segment) to apply the shortcode.  Fires only where that full path is not itself a page. | [optional] 
**QueryParameter** | **string** | Add this query parameter to a link on any page running UC Analytics, including other sites, to apply the shortcode. | [optional] 
**ShortcodeOid** | **int** | The shortcode&#39;s id on this storefront. | [optional] 
**UtmCampaign** | **string** | UTM campaign the shortcode applies.  Null when blank. | [optional] 
**UtmContent** | **string** | UTM content the shortcode applies.  Null when blank. | [optional] 
**UtmId** | **string** | UTM id the shortcode applies.  Null when blank. | [optional] 
**UtmMedium** | **string** | UTM medium the shortcode applies.  Null when blank. | [optional] 
**UtmSource** | **string** | UTM source the shortcode applies.  Null when blank. | [optional] 
**UtmTerm** | **string** | UTM term the shortcode applies.  Null when blank. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

