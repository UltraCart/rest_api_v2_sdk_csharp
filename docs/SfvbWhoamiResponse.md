
# com.ultracart.admin.v2.Model.SfvbWhoamiResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActingAsUser** | **bool** | True when this token resolves to a merchant user.  Preview sessions and file writes need one, because they are recorded against the person who approved the token.  Only device flow tokens resolve a user, so a plain API key will see this false. | [optional] 
**ApplicationName** | **string** | Description of the application this credential belongs to. | [optional] 
**AuthenticationType** | **string** | How this token authenticated - Oauth2, Simple Key, Public/Private Key or Browser Key. | [optional] 
**CanPublish** | **bool** | True when this token may write a target that is currently live - an active upsell offer, an email on a delivering flow, the active theme, the storefront root.  Never infer this; it is the difference between a draft edit and a shopper visible change. | [optional] 
**CanRead** | **bool** | True when this token may read.  Do not infer this from the requested scope name. | [optional] 
**CanWrite** | **bool** | True when this token may write.  Writing a target that is not currently live needs only this. | [optional] 
**DeviceScope** | **string** | Device scope name, when this is a device flow token. | [optional] 
**Login** | **string** | Login of the user who approved this token.  Populated for device flow tokens; null for plain API key credentials. | [optional] 
**MerchantId** | **string** | Merchant id this token acts against. | [optional] 
**Scopes** | **List&lt;string&gt;** | Scopes granted to this token. | [optional] 
**Storefronts** | [**List&lt;SfvbStorefront&gt;**](SfvbStorefront.md) | Storefronts reachable with this token.  Empty unless the token holds sfvb_read, because storefront inventory is resource data rather than identity. | [optional] 
**StorefrontsWithheld** | **bool** | True when storefronts was emptied because the token lacks sfvb_read, rather than because the account has none.  Without this the two look identical. | [optional] 
**UserName** | **string** | Display name of the approving user, when known. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

