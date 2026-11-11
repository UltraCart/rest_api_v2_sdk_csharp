
# com.ultracart.admin.v2.Model.OauthTokenResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessToken** | **string** | Access token to use in OAuth authenticated API call | [optional] 
**Error** | **string** |  | [optional] 
**ErrorCode** | **string** | With error access_denied, a machine readable reason.  sfvb.beta_access_required means the account isn&#39;t enabled for the StoreFront CLI beta, not that a person clicked Deny. | [optional] 
**ErrorDescription** | **string** |  | [optional] 
**ErrorUri** | **string** |  | [optional] 
**ExpiresIn** | **string** | The number of seconds since issuance when the access token will expire and need to be refreshed using the refresh token | [optional] 
**MerchantId** | **string** | The UltraCart merchant account that authorized this token.  Use it to map the token to the merchant within your own system.  Also returned by GET /oauth/me along with the account name. | [optional] 
**ObjectId** | **string** | With error_code sfvb.beta_access_required, the merchant id that was refused. | [optional] 
**RefreshToken** | **string** | The refresh token that should be used to fetch a new access token when the expiration occurs | [optional] 
**RefreshTokenExpiresIn** | **string** | Seconds until the refresh token expires.  Returned only by applications that rotate refresh tokens, which return a new refresh token on every refresh. | [optional] 
**Scope** | **string** | The scope of permissions associated with teh access token | [optional] 
**TokenType** | **string** | Type of token | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

