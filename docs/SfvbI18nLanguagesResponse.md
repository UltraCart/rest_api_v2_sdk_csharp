
# com.ultracart.admin.v2.Model.SfvbI18nLanguagesResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Changed** | **bool** | On enable or disable, false when the language was already in that state and nothing was saved. | [optional] 
**CharacterEstimate** | **int** | About how many characters of storefront text one language translates. | [optional] 
**DefaultLanguageCode** | **string** | The code of the language shoppers start in.  The source of every string is still English. | [optional] 
**HashSha256** | **string** | Send back as If-Match when enabling or disabling a language. | [optional] 
**Languages** | [**List&lt;SfvbI18nLanguage&gt;**](SfvbI18nLanguage.md) | Every language the storefront can be translated into, enabled or not, English first. | [optional] 
**PerLanguageCost** | **string** | The estimated machine translation cost of enabling one more language, formatted. | [optional] 
**StorefrontOid** | **int** | The storefront. | [optional] 
**SupportsI18n** | **bool** | False when the active theme takes its languages from locale files.  Language and message writes are refused then. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

