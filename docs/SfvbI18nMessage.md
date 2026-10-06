
# com.ultracart.admin.v2.Model.SfvbI18nMessage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Edited** | **bool** | True when the English was changed from the template&#39;s text. | [optional] 
**EnglishText** | **string** | The English text, the source every other language is translated from. | [optional] 
**HashSha256** | **string** | Send back as If-Match when setting or resetting this message. | [optional] 
**Imported** | **bool** | True when the message came from an older theme&#39;s locale file.  It cannot be reset. | [optional] 
**Key** | **string** | The message key. | [optional] 
**ThemeOid** | **int** | The theme the message belongs to.  Messages are kept per storefront and theme. | [optional] 
**Translations** | [**List&lt;SfvbI18nTranslation&gt;**](SfvbI18nTranslation.md) | Each enabled language other than English, with its text and where it comes from. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

