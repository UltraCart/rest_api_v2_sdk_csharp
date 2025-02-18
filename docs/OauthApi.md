# com.ultracart.admin.v2.Api.OauthApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OauthAccessToken**](OauthApi.md#oauthaccesstoken) | **POST** /oauth/token | Exchange authorization code for access token.
[**OauthRevoke**](OauthApi.md#oauthrevoke) | **POST** /oauth/revoke | Revoke this OAuth application.



## OauthAccessToken

> OauthTokenResponse OauthAccessToken (string clientId, string grantType, string code = null, string redirectUri = null, string refreshToken = null)

Exchange authorization code for access token.

The final leg in the OAuth process which exchanges the specified access token for the access code needed to make API calls. 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class OauthAccessTokenExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var clientId = "clientId_example";  // string | The OAuth application client_id.
            var grantType = "grantType_example";  // string | Type of grant
            var code = "code_example";  // string | Authorization code received back from the browser redirect (optional) 
            var redirectUri = "redirectUri_example";  // string | The URI that you redirect the browser to start the authorization process (optional) 
            var refreshToken = "refreshToken_example";  // string | The refresh token received during the original grant_type=authorization_code that can be used to return a new access token (optional) 

            try
            {
                // Exchange authorization code for access token.
                OauthTokenResponse result = apiInstance.OauthAccessToken(clientId, grantType, code, redirectUri, refreshToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OauthApi.OauthAccessToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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
 **redirectUri** | **string**| The URI that you redirect the browser to start the authorization process | [optional] 
 **refreshToken** | **string**| The refresh token received during the original grant_type&#x3D;authorization_code that can be used to return a new access token | [optional] 

### Return type

[**OauthTokenResponse**](OauthTokenResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/x-www-form-urlencoded
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OauthRevoke

> OauthRevokeSuccessResponse OauthRevoke (string clientId, string token)

Revoke this OAuth application.

Revokes the OAuth application associated with the specified client_id and token. 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class OauthRevokeExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var clientId = "clientId_example";  // string | The OAuth application client_id.
            var token = "token_example";  // string | The OAuth access token that is to be revoked..

            try
            {
                // Revoke this OAuth application.
                OauthRevokeSuccessResponse result = apiInstance.OauthRevoke(clientId, token);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OauthApi.OauthRevoke: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

