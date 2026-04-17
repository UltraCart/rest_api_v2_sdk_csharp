# com.ultracart.admin.v2.Api.ConversationEmbedApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EmbedOauthDeviceAuthorize**](ConversationEmbedApi.md#embedoauthdeviceauthorize) | **POST** /conversation_embed/oauth/device/authorize | Initiate a device authorization flow for an embed widget.
[**EmbedOauthRevoke**](ConversationEmbedApi.md#embedoauthrevoke) | **POST** /conversation_embed/oauth/device/revoke | Revoke an embed widget access or refresh token.
[**EmbedOauthToken**](ConversationEmbedApi.md#embedoauthtoken) | **POST** /conversation_embed/oauth/device/token | Exchange a device_code or refresh_token for an access token (embed widget).
[**GetEmbedPbxAuth**](ConversationEmbedApi.md#getembedpbxauth) | **PUT** /conversation_embed/pbx-auth | Get PBX authorization for the embedded softphone widget.



## EmbedOauthDeviceAuthorize

> void EmbedOauthDeviceAuthorize (string clientId, string scope)

Initiate a device authorization flow for an embed widget.

RFC 8628 device authorization. Only the embed widget's client_id and the crm_embed scope are accepted. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| The embed widget OAuth client_id. | 
 **scope** | **string**| The application-level scope (must be &#39;crm_embed&#39;). | 

### Return type

void (empty response body)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/x-www-form-urlencoded
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EmbedOauthRevoke

> void EmbedOauthRevoke (string clientId, string token)

Revoke an embed widget access or refresh token.

RFC 7009 style â€” the token itself is proof of possession. Accepts either an access token or a refresh token in the 'token' parameter. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| The embed widget OAuth client_id. | 
 **token** | **string**| The token to revoke (access token or refresh token). | 

### Return type

void (empty response body)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/x-www-form-urlencoded
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EmbedOauthToken

> void EmbedOauthToken (string clientId, string grantType, string deviceCode = null, string refreshToken = null)

Exchange a device_code or refresh_token for an access token (embed widget).

Accepts grant_type=urn:ietf:params:oauth:grant-type:device_code or grant_type=refresh_token. Other grant types are rejected. Access tokens issued here expire in 60 minutes. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| The embed widget OAuth client_id. | 
 **grantType** | **string**| Grant type. | 
 **deviceCode** | **string**| The device code received from /oauth/device/authorize (required for device_code grant). | [optional] 
 **refreshToken** | **string**| The refresh token (required for refresh_token grant). | [optional] 

### Return type

void (empty response body)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/x-www-form-urlencoded
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEmbedPbxAuth

> ConversationEmbedPbxAuthResponse GetEmbedPbxAuth ()

Get PBX authorization for the embedded softphone widget.

Returns a narrow subset of agent auth fields â€” only what the softphone widget needs to connect to the PBX relay. Twilio tokens, conversation JWTs, and chat/customer permissions are intentionally excluded. 


### Example


(No example for this operation).


### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationEmbedPbxAuthResponse**](ConversationEmbedPbxAuthResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

