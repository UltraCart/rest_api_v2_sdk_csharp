# com.ultracart.admin.v2.Api.SsoApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSsoSessionUser**](SsoApi.md#getssosessionuser) | **GET** /sso/session/user | Get single sign on session user
[**SsoAuthorize**](SsoApi.md#ssoauthorize) | **PUT** /sso/authorize | Authorize a single sign on session
[**SsoSessionRevoke**](SsoApi.md#ssosessionrevoke) | **DELETE** /sso/session/revoke | Revoke single sign on session
[**SsoToken**](SsoApi.md#ssotoken) | **PUT** /sso/token | Exchange a single sign on code for a simple key token


<a name="getssosessionuser"></a>
# **GetSsoSessionUser**
> User GetSsoSessionUser ()

Get single sign on session user

This is the equivalent of logging out of the single sign on session 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetSsoSessionUserExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new SsoApi(simpleKey);


            try
            {
                // Get single sign on session user
                User result = apiInstance.GetSsoSessionUser();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsoApi.GetSsoSessionUser: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**User**](User.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ssoauthorize"></a>
# **SsoAuthorize**
> ItemsResponse SsoAuthorize (SingleSignOnAuthorizeRequest authorizationRequest)

Authorize a single sign on session

Starts the process of authorizing a single sign on session. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SsoAuthorizeExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new SsoApi(simpleKey);

            var authorizationRequest = new SingleSignOnAuthorizeRequest(); // SingleSignOnAuthorizeRequest | Authorization request

            try
            {
                // Authorize a single sign on session
                ItemsResponse result = apiInstance.SsoAuthorize(authorizationRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsoApi.SsoAuthorize: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorizationRequest** | [**SingleSignOnAuthorizeRequest**](SingleSignOnAuthorizeRequest.md)| Authorization request | 

### Return type

[**ItemsResponse**](ItemsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ssosessionrevoke"></a>
# **SsoSessionRevoke**
> void SsoSessionRevoke ()

Revoke single sign on session

This is the equivalent of logging out of the single sign on session 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SsoSessionRevokeExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new SsoApi(simpleKey);


            try
            {
                // Revoke single sign on session
                apiInstance.SsoSessionRevoke();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsoApi.SsoSessionRevoke: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ssotoken"></a>
# **SsoToken**
> ItemsResponse SsoToken (SingleSignOnTokenRequest tokenRequest)

Exchange a single sign on code for a simple key token

Called by your application after receiving the code back on the redirect URI to obtain a simple key token to make API calls with 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SsoTokenExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new SsoApi(simpleKey);

            var tokenRequest = new SingleSignOnTokenRequest(); // SingleSignOnTokenRequest | Token request

            try
            {
                // Exchange a single sign on code for a simple key token
                ItemsResponse result = apiInstance.SsoToken(tokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsoApi.SsoToken: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenRequest** | [**SingleSignOnTokenRequest**](SingleSignOnTokenRequest.md)| Token request | 

### Return type

[**ItemsResponse**](ItemsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

