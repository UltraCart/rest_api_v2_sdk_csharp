
# com.ultracart.admin.v2.Model.OauthMeResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationName** | **string** | The name of your application as the merchant approved it. | [optional] 
**ClientId** | **string** | Your application&#39;s client_id.  Null when authenticating with a simple key, which is not tied to an application. | [optional] 
**MerchantId** | **string** | The UltraCart merchant account that authorized your application.  Stable, and the value to key your own records on. | [optional] 
**MerchantName** | **string** | The account&#39;s company name, suitable for displaying to your user.  The merchant can change this, so display it rather than storing it as an identifier. | [optional] 
**Scopes** | **List&lt;string&gt;** | The permissions the merchant granted.  May be narrower than the permissions your application currently requests. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

