# com.ultracart.admin.v2.Api.OauthApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OauthAccessToken**](OauthApi.md#oauthaccesstoken) | **POST** /oauth/token | Exchange authorization code for access token.
[**OauthRevoke**](OauthApi.md#oauthrevoke) | **POST** /oauth/revoke | Revoke this OAuth application.


<a name="oauthaccesstoken"></a>
# **OauthAccessToken**
> OauthTokenResponse OauthAccessToken (string clientId, string grantType, string code = null, string redirectUri = null, string refreshToken = null)

Exchange authorization code for access token.

The final leg in the OAuth process which exchanges the specified access token for the access code needed to make API calls. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class OauthAccessTokenExample
    {
        public void main()
        {
            
            // Configure API key authorization: ultraCartBrowserApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-browser-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-browser-key", "Bearer");
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new OauthApi();
            var clientId = clientId_example;  // string | The OAuth application client_id.
            var grantType = grantType_example;  // string | Type of grant
            var code = code_example;  // string | Authorization code received back from the browser redirect (optional) 
            var redirectUri = redirectUri_example;  // string | The URI that you redirect the browser to to start the authorization process (optional) 
            var refreshToken = refreshToken_example;  // string | The refresh token received during the original grant_type=authorization_code that can be used to return a new access token (optional) 

            try
            {
                // Exchange authorization code for access token.
                OauthTokenResponse result = apiInstance.OauthAccessToken(clientId, grantType, code, redirectUri, refreshToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OauthApi.OauthAccessToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| The OAuth application client_id. | 
 **grantType** | **string**| Type of grant | 
 **code** | **string**| Authorization code received back from the browser redirect | [optional] 
 **redirectUri** | **string**| The URI that you redirect the browser to to start the authorization process | [optional] 
 **refreshToken** | **string**| The refresh token received during the original grant_type&#x3D;authorization_code that can be used to return a new access token | [optional] 

### Return type

[**OauthTokenResponse**](OauthTokenResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oauthrevoke"></a>
# **OauthRevoke**
> OauthRevokeSuccessResponse OauthRevoke (string clientId, string token)

Revoke this OAuth application.

Revokes the OAuth application associated with the specified client_id and token. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class OauthRevokeExample
    {
        public void main()
        {
            
            // Configure API key authorization: ultraCartBrowserApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-browser-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-browser-key", "Bearer");
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new OauthApi();
            var clientId = clientId_example;  // string | The OAuth application client_id.
            var token = token_example;  // string | The OAuth access token that is to be revoked..

            try
            {
                // Revoke this OAuth application.
                OauthRevokeSuccessResponse result = apiInstance.OauthRevoke(clientId, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OauthApi.OauthRevoke: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| The OAuth application client_id. | 
 **token** | **string**| The OAuth access token that is to be revoked.. | 

### Return type

[**OauthRevokeSuccessResponse**](OauthRevokeSuccessResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

