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
using System.Web;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.oauth
{
    public class OauthAccessToken
    {
        /*
         * The first step in implementing an OAuth authorization to your UltraCart Developer Application is
         * creating a Client ID and Secret. See the following doc for instructions on doing so:
         * https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/3488907265/Developer+Applications+-+Creating+a+Client+ID+and+Secret+for+an+OAuth+Application
         * 
         * The second step is to construct an authorize url for your customers to follow and authorize your application.
         * See the oauthAuthorize.php for an example on constructing that url.
         * 
         * This method, OAuth.oauthAccessToken() will be called from within your redirect script, i.e. that web page the
         * customer is redirected to by UltraCart after successfully authorizing your application.
         * 
         * This example illustrates how to retrieve the code parameter and exchange it for an access_token and refresh_token.
         * 
         * Once you have your Client ID and Secret created, our OAuth security follows the industry standards.
         * 1. Construct an authorize url for your customers.
         * 2. Your customers will follow the link and authorize your application.
         * 3. Store their oauth credentials as best fits your application.
         * 
         * Parameters this script should expect:
         * code -> used to exchange for an access token
         * state -> whatever you passed in your authorize url
         * error -> if you have a problem with your application configure. Possible values are:
         *     invalid_request -> your authorize url has expired
         *     access_denied -> user said 'no' and did not grant access.
         * 
         * Parameters you will use to retrieve a token:
         * code -> the value provided as a query parameter from UltraCart, required if grant_type is 'authorization_code'
         * client_id -> your client id (see doc link at top of this file)
         * grant_type -> 'authorization_code' or 'refresh_token'
         * redirect_url -> The URI that you redirect the browser to start the authorization process
         * refresh_token -> if grant_type = 'refresh_token', you have to provide the refresh token. makes sense, yes?
         * 
         * See OauthTokenResponse for fields that are returned from this call.
         * All SDKs have the same field names with slight differences in capitalization and underscores.
         * https://github.com/UltraCart/rest_api_v2_sdk_csharp/blob/master/src/com.ultracart.admin.v2/Model/OauthTokenResponse.cs
         */
        public static void Execute()
        {
            string clientId = "5e31ce86e17f02015a35257c47151544";  // this is given to you when you create your application (see the doc link above)
            string grantType = "authorization_code";
            string redirectUrl = "https://www.mywebsite.com/oauth/redirect_here.php";
            string state = "denmark";  // this is whatever you used when you created your authorize url (see oauthAuthorize.php)

            // Note: You'll need to implement your own method to get the code from query parameters
            string code = HttpContext.Current.Request.QueryString["code"];
            string refreshToken = null;

            OauthApi oauthApi = new OauthApi(Constants.ApiKey);
            OauthTokenResponse apiResponse = oauthApi.OauthAccessToken(clientId, grantType, code, redirectUrl, refreshToken);

            // apiResponse is an OauthTokenResponse object
            string newRefreshToken = apiResponse.RefreshToken;
            string expiresIn = apiResponse.ExpiresIn;
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
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.oauth
{
    public class OauthRevoke 
    {
        /*
         * This is a last feature of the UltraCart OAuth Security Implementation.
         * oauthRevoke is used to kill an access token.
         * Call this method when a customer desires to terminate using your Developer Application.
         *
         * The first step in implementing an OAuth authorization to your UltraCart Developer Application is
         * creating a Client ID and Secret. See the following doc for instructions on doing so:
         * https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/3488907265/Developer+Applications+-+Creating+a+Client+ID+and+Secret+for+an+OAuth+Application
         */
        public static void Execute()
        {
            string clientId = "5e31ce86e17f02015a35257c47151544";  // this is given to you when you create your application (see the doc link above)
            string accessToken = "123456789012345678901234567890"; // this is stored by your application somewhere somehow.

            OauthApi oauthApi = new OauthApi(Constants.ApiKey);
            OauthRevokeSuccessResponse apiResponse = oauthApi.OauthRevoke(clientId, accessToken);

            // apiResponse is an OauthRevokeSuccessResponse object
            bool successful = apiResponse.Successful;
            string message = apiResponse.Message;
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

