# com.ultracart.admin.v2.Api.SfvbApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompileSfvbCjson**](SfvbApi.md#compilesfvbcjson) | **POST** /sfvb/cjson/compile | Compile CJSON to Velocity
[**CreateSfvbPreviewSession**](SfvbApi.md#createsfvbpreviewsession) | **POST** /sfvb/storefronts/{storefront_oid}/preview_sessions | Create a preview session
[**DeleteSfvbFile**](SfvbApi.md#deletesfvbfile) | **DELETE** /sfvb/storefronts/{storefront_oid}/files | Delete a storefront file
[**DeleteSfvbPreviewSession**](SfvbApi.md#deletesfvbpreviewsession) | **DELETE** /sfvb/storefronts/{storefront_oid}/preview_sessions/{preview_session_id} | Delete a preview session
[**DownloadSfvbFile**](SfvbApi.md#downloadsfvbfile) | **GET** /sfvb/storefronts/{storefront_oid}/files/download | Read a storefront file&#39;s raw bytes
[**DuplicateSfvbTheme**](SfvbApi.md#duplicatesfvbtheme) | **POST** /sfvb/storefronts/{storefront_oid}/themes/{theme_oid}/duplicate | Duplicate a theme
[**GetSfvbCjsonUsedElements**](SfvbApi.md#getsfvbcjsonusedelements) | **POST** /sfvb/cjson/elements | Element types used by a container
[**GetSfvbContainer**](SfvbApi.md#getsfvbcontainer) | **GET** /sfvb/storefronts/{storefront_oid}/containers/{owner_type}/{owner_object_id} | Read a container stored outside the file system
[**GetSfvbContainerVersion**](SfvbApi.md#getsfvbcontainerversion) | **GET** /sfvb/storefronts/{storefront_oid}/container_versions/{container_history_oid} | Read the CJSON stored in one container history entry
[**GetSfvbElement**](SfvbApi.md#getsfvbelement) | **GET** /sfvb/elements/{element_type} | Configuration schema for one element type
[**GetSfvbFileContent**](SfvbApi.md#getsfvbfilecontent) | **GET** /sfvb/storefronts/{storefront_oid}/files/content | Read a storefront file
[**GetSfvbFileUploadUrl**](SfvbApi.md#getsfvbfileuploadurl) | **GET** /sfvb/storefronts/{storefront_oid}/files/upload_url/{extension} | Get a URL to upload a binary asset to
[**GetSfvbLibraryEntry**](SfvbApi.md#getsfvblibraryentry) | **GET** /sfvb/storefronts/{storefront_oid}/library/{library_oid} | Read one library entry including its CJSON
[**GetSfvbPreviewUrl**](SfvbApi.md#getsfvbpreviewurl) | **GET** /sfvb/storefronts/{storefront_oid}/preview_sessions/{preview_session_id}/url | URL that renders a preview session
[**GetSfvbTheme**](SfvbApi.md#getsfvbtheme) | **GET** /sfvb/storefronts/{storefront_oid}/themes/{theme_oid} | Get a theme
[**GetSfvbThemeJob**](SfvbApi.md#getsfvbthemejob) | **GET** /sfvb/storefronts/{storefront_oid}/theme_jobs/{job_id} | Status of an asynchronous theme job
[**GetSfvbVersion**](SfvbApi.md#getsfvbversion) | **GET** /sfvb/version | Compiler version for this merchant
[**GetSfvbWhoami**](SfvbApi.md#getsfvbwhoami) | **GET** /sfvb/whoami | Who this token is
[**InstallSfvbLibraryEntry**](SfvbApi.md#installsfvblibraryentry) | **POST** /sfvb/storefronts/{storefront_oid}/library/{library_oid}/install | Install a library entry into a storefront
[**ListSfvbContainerVersions**](SfvbApi.md#listsfvbcontainerversions) | **GET** /sfvb/storefronts/{storefront_oid}/container_versions | Version history for a container stored outside the file system
[**ListSfvbElements**](SfvbApi.md#listsfvbelements) | **GET** /sfvb/elements | List every SFVB element type
[**ListSfvbFileVersions**](SfvbApi.md#listsfvbfileversions) | **GET** /sfvb/storefronts/{storefront_oid}/files/versions | Version history for a storefront file
[**ListSfvbFiles**](SfvbApi.md#listsfvbfiles) | **GET** /sfvb/storefronts/{storefront_oid}/files | List a storefront directory
[**ListSfvbStorefronts**](SfvbApi.md#listsfvbstorefronts) | **GET** /sfvb/storefronts | List storefronts
[**ListSfvbThemes**](SfvbApi.md#listsfvbthemes) | **GET** /sfvb/storefronts/{storefront_oid}/themes | List themes for a storefront
[**ListSfvbUpsellOffers**](SfvbApi.md#listsfvbupselloffers) | **GET** /sfvb/storefronts/{storefront_oid}/upsell_offers | List upsell offers
[**PutSfvbContainer**](SfvbApi.md#putsfvbcontainer) | **PUT** /sfvb/storefronts/{storefront_oid}/containers/{owner_type}/{owner_object_id} | Write a container stored outside the file system
[**PutSfvbFileContent**](SfvbApi.md#putsfvbfilecontent) | **PUT** /sfvb/storefronts/{storefront_oid}/files/content | Write a storefront file
[**PutSfvbPreviewSession**](SfvbApi.md#putsfvbpreviewsession) | **PUT** /sfvb/storefronts/{storefront_oid}/preview_sessions/{preview_session_id} | Push containers into a preview session
[**RenderSfvbWidgets**](SfvbApi.md#rendersfvbwidgets) | **POST** /sfvb/storefronts/{storefront_oid}/themes/{theme_oid}/render | Render a CJSON node to HTML
[**ReserveSfvbWidgetIds**](SfvbApi.md#reservesfvbwidgetids) | **POST** /sfvb/storefronts/{storefront_oid}/widget_ids | Reserve a block of widget ids
[**RevertSfvbContainer**](SfvbApi.md#revertsfvbcontainer) | **POST** /sfvb/storefronts/{storefront_oid}/containers/{owner_type}/{owner_object_id}/revert | Revert a container stored outside the file system
[**RevertSfvbFile**](SfvbApi.md#revertsfvbfile) | **POST** /sfvb/storefronts/{storefront_oid}/files/revert | Revert a storefront file to an earlier version
[**SearchSfvbFiles**](SfvbApi.md#searchsfvbfiles) | **POST** /sfvb/storefronts/{storefront_oid}/files/search | Search storefront files
[**SearchSfvbLibrary**](SfvbApi.md#searchsfvblibrary) | **GET** /sfvb/storefronts/{storefront_oid}/library | Search the element library
[**UploadSfvbFile**](SfvbApi.md#uploadsfvbfile) | **POST** /sfvb/storefronts/{storefront_oid}/files/upload | Store a binary asset that was already uploaded
[**ValidateSfvbCjson**](SfvbApi.md#validatesfvbcjson) | **POST** /sfvb/cjson/validate | Validate CJSON
[**ValidateSfvbVelocity**](SfvbApi.md#validatesfvbvelocity) | **POST** /sfvb/storefronts/{storefront_oid}/themes/{theme_oid}/velocity/validate | Validate a Velocity template against a theme



## CompileSfvbCjson

> SfvbCompileResponse CompileSfvbCjson (SfvbCompileRequest compileRequest)

Compile CJSON to Velocity

Compiles a container document to Velocity without storing anything.  Supply theme_oid to compile with the theme's inherit groups applied; omit it to compile standalone. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **compileRequest** | [**SfvbCompileRequest**](SfvbCompileRequest.md)| CJSON to compile | 

### Return type

[**SfvbCompileResponse**](SfvbCompileResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **413** |  |  -  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateSfvbPreviewSession

> SfvbPreviewSessionResponse CreateSfvbPreviewSession (int storefrontOid)

Create a preview session

Returns a server generated session id to push containers into.  The id is not caller supplied, because concurrent agents choosing their own would be free to collide, and the browser editor's habit of minting one with Math.random is not a property worth carrying into an API.  Expires after eight hours and can be deleted sooner.  Requires a token that resolves to a user, so use the device authorization flow. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 

### Return type

[**SfvbPreviewSessionResponse**](SfvbPreviewSessionResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteSfvbFile

> void DeleteSfvbFile (int storefrontOid, string ifMatch, string path = null)

Delete a storefront file

Recoverable from the recycle bin. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **ifMatch** | **string**| Content hash of the file being deleted.  Required; 428 when absent, 412 when stale. | 
 **path** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteSfvbPreviewSession

> void DeleteSfvbPreviewSession (int storefrontOid, string previewSessionId)

Delete a preview session

Releases the session before its eight hour expiry.  Without this the only way to free one is to wait, which is a poor answer for a tool that may open a dozen in an afternoon. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **previewSessionId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DownloadSfvbFile

> void DownloadSfvbFile (int storefrontOid, string path = null)

Read a storefront file's raw bytes

Returns the file itself rather than a JSON envelope, for any type including binaries that files/content refuses.  Use this to verify what you uploaded, and note it is the only way to read a file inside a theme that is not active - such a file is served to nobody until the theme is promoted, so it has no public URL to fetch instead.  On success the body is the file; on failure it is the usual JSON error object, so do not assume the content type without checking the status. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DuplicateSfvbTheme

> SfvbThemeJobResponse DuplicateSfvbTheme (int storefrontOid, int themeOid, SfvbThemeDuplicateRequest duplicateRequest)

Duplicate a theme

Copies a theme into a new one and returns a job handle to poll.  Asynchronous, because copying a theme copies every file in it.  Needs sfvb_write rather than sfvb_publish, because the job explicitly does not activate what it creates, so the worst outcome of a mistaken call is a spare theme.  This is how you get somewhere safe to work - duplicate, edit the copy with an ordinary write scope, and let a human promote it. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **themeOid** | **int**|  | 
 **duplicateRequest** | [**SfvbThemeDuplicateRequest**](SfvbThemeDuplicateRequest.md)| Theme duplication details | 

### Return type

[**SfvbThemeJobResponse**](SfvbThemeJobResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbCjsonUsedElements

> SfvbElementsResponse GetSfvbCjsonUsedElements (SfvbCompileRequest compileRequest)

Element types used by a container


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **compileRequest** | [**SfvbCompileRequest**](SfvbCompileRequest.md)| CJSON to inspect | 

### Return type

[**SfvbElementsResponse**](SfvbElementsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbContainer

> SfvbContainerResponse GetSfvbContainer (int storefrontOid, string ownerType, string ownerObjectId, string containerName = null)

Read a container stored outside the file system

owner_type is one of upsell, email, postcardfront, postcardback or item.  Item containers also require container_name.  Theme and page containers are files; read those through files/content. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **ownerType** | **string**|  | 
 **ownerObjectId** | **string**|  | 
 **containerName** | **string**|  | [optional] 

### Return type

[**SfvbContainerResponse**](SfvbContainerResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbContainerVersion

> SfvbContainerVersion GetSfvbContainerVersion (int storefrontOid, int containerHistoryOid, string ownerType = null, string ownerObjectId = null, string containerName = null)

Read the CJSON stored in one container history entry

Inspect or diff an earlier version without reverting to it.  The version is addressed through the container that owns it, so a history oid belonging to some other resource cannot be read through this route. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **containerHistoryOid** | **int**|  | 
 **ownerType** | **string**|  | [optional] 
 **ownerObjectId** | **string**|  | [optional] 
 **containerName** | **string**|  | [optional] 

### Return type

[**SfvbContainerVersion**](SfvbContainerVersion.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbElement

> SfvbElementSchemaResponse GetSfvbElement (string elementType)

Configuration schema for one element type


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **elementType** | **string**|  | 

### Return type

[**SfvbElementSchemaResponse**](SfvbElementSchemaResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbFileContent

> SfvbFileContentResponse GetSfvbFileContent (int storefrontOid, string path = null, int? version = null)

Read a storefront file

Returns the current content, or an earlier version when version is supplied.  Send the body's hash_sha256 back as If-Match when writing.  The ETag header carries the same hash, but a compressing proxy may append a suffix such as -gzip to it, so prefer the body value. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**|  | [optional] 
 **version** | **int?**|  | [optional] 

### Return type

[**SfvbFileContentResponse**](SfvbFileContentResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **413** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbFileUploadUrl

> SfvbFileUploadUrlResponse GetSfvbFileUploadUrl (int storefrontOid, string extension)

Get a URL to upload a binary asset to

Binary content does not travel through this API as JSON, so uploading an image, font, video or PDF is two steps.  Ask here for a URL, PUT the raw bytes straight to it, then call uploadSfvbFile quoting the key you were given.  The bytes never pass through the API server.  The extension is checked against the accepted type list before a URL is issued, so an unsupported type fails here rather than after you have sent the file.  The URL is short lived and the key is bound to your account. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **extension** | **string**|  | 

### Return type

[**SfvbFileUploadUrlResponse**](SfvbFileUploadUrlResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbLibraryEntry

> SfvbLibraryEntry GetSfvbLibraryEntry (int storefrontOid, int libraryOid)

Read one library entry including its CJSON

Returns the fragment as authored.  If it references images or other storefront files those paths will not resolve on this storefront until the entry is installed, so use install rather than this when the intent is to place the fragment. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **libraryOid** | **int**|  | 

### Return type

[**SfvbLibraryEntry**](SfvbLibraryEntry.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbPreviewUrl

> SfvbPreviewUrlResponse GetSfvbPreviewUrl (int storefrontOid, string previewSessionId, string path = null)

URL that renders a preview session

Refuses a session that does not exist, so a URL you receive is for a session that was really there.  expires_in_seconds is the time actually remaining, not the configured lifetime.  Needs a token that resolves to a user, because a preview session belongs to the person who created it. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **previewSessionId** | **string**|  | 
 **path** | **string**|  | [optional] 

### Return type

[**SfvbPreviewUrlResponse**](SfvbPreviewUrlResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbTheme

> SfvbTheme GetSfvbTheme (int storefrontOid, int themeOid)

Get a theme


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **themeOid** | **int**|  | 

### Return type

[**SfvbTheme**](SfvbTheme.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbThemeJob

> SfvbThemeJobResponse GetSfvbThemeJob (int storefrontOid, int jobId)

Status of an asynchronous theme job

Poll until complete is true, then check success.  Note that the new theme's oid is not returned.  The job's product is a plain text report rather than a structured result, so once it completes, list themes and match on the target_path the start call gave you. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **jobId** | **int**|  | 

### Return type

[**SfvbThemeJobResponse**](SfvbThemeJobResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbVersion

> SfvbVersionResponse GetSfvbVersion ()

Compiler version for this merchant

The visual builder release channel is per merchant, so a CLI holding cached schema or element data should compare against this to know when it has gone stale. 


### Example


(No example for this operation).


### Parameters

This endpoint does not need any parameter.

### Return type

[**SfvbVersionResponse**](SfvbVersionResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbWhoami

> SfvbWhoamiResponse GetSfvbWhoami ()

Who this token is

Returns the merchant, user, granted scopes and reachable storefronts for the calling token.  Declared for any scope so an application can always discover which account it is connected to. 


### Example


(No example for this operation).


### Parameters

This endpoint does not need any parameter.

### Return type

[**SfvbWhoamiResponse**](SfvbWhoamiResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InstallSfvbLibraryEntry

> SfvbLibraryEntry InstallSfvbLibraryEntry (int storefrontOid, int libraryOid)

Install a library entry into a storefront

Copies the fragment's referenced assets into the storefront file system and returns the CJSON with its paths resolved, ready to place.  This writes, which is why it is a POST rather than the GET the internal admin endpoint uses.  It also requires sfvb_publish, because the assets land in the shared storefront file system, which is served to shoppers regardless of which theme is active, so no amount of working inside a duplicate theme isolates them. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **libraryOid** | **int**|  | 

### Return type

[**SfvbLibraryEntry**](SfvbLibraryEntry.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbContainerVersions

> SfvbContainerVersionsResponse ListSfvbContainerVersions (int storefrontOid, string ownerType = null, string ownerObjectId = null, string containerName = null)

Version history for a container stored outside the file system


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **ownerType** | **string**|  | [optional] 
 **ownerObjectId** | **string**|  | [optional] 
 **containerName** | **string**|  | [optional] 

### Return type

[**SfvbContainerVersionsResponse**](SfvbContainerVersionsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbElements

> SfvbElementsResponse ListSfvbElements ()

List every SFVB element type

The authoritative vocabulary, taken from the same lookup the compiler uses.  A type absent from this list compiles to a literal placeholder line in the page rather than failing, which is why validation treats an unknown type as an error. 


### Example


(No example for this operation).


### Parameters

This endpoint does not need any parameter.

### Return type

[**SfvbElementsResponse**](SfvbElementsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbFileVersions

> SfvbFileVersionsResponse ListSfvbFileVersions (int storefrontOid, string path = null)

Version history for a storefront file

Version history is the undo for anything in the storefront file system, which is what makes an agent's writes recoverable. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**|  | [optional] 

### Return type

[**SfvbFileVersionsResponse**](SfvbFileVersionsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbFiles

> SfvbFilesResponse ListSfvbFiles (int storefrontOid, string path = null, int? storefrontFsDirectoryOid = null, int? themeOid = null, int? maxEntries = null)

List a storefront directory

Directories first, then files, each sorted by name.  Address by path or by directory oid; supplying theme_oid also retries a path that does not resolve at the storefront root relative to that theme, so /theme/css/ works without knowing the theme's directory name.  Each file carries its content hash, so a listing is enough to start an If-Match write without a separate read. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**|  | [optional] 
 **storefrontFsDirectoryOid** | **int?**|  | [optional] 
 **themeOid** | **int?**|  | [optional] 
 **maxEntries** | **int?**|  | [optional] 

### Return type

[**SfvbFilesResponse**](SfvbFilesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbStorefronts

> SfvbStorefrontsResponse ListSfvbStorefronts ()

List storefronts


### Example


(No example for this operation).


### Parameters

This endpoint does not need any parameter.

### Return type

[**SfvbStorefrontsResponse**](SfvbStorefrontsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbThemes

> SfvbThemesResponse ListSfvbThemes (int storefrontOid)

List themes for a storefront

Exactly one theme is flagged active.  Writing to the active theme is writing live and requires the sfvb_publish scope. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 

### Return type

[**SfvbThemesResponse**](SfvbThemesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbUpsellOffers

> SfvbUpsellOffersResponse ListSfvbUpsellOffers (int storefrontOid)

List upsell offers

Without container JSON, so the funnel can be surveyed cheaply.  A large container size alongside a small element count is the signature of markup pasted into a single html element. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 

### Return type

[**SfvbUpsellOffersResponse**](SfvbUpsellOffersResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbContainer

> SfvbContainerResponse PutSfvbContainer (int storefrontOid, string ownerType, string ownerObjectId, string ifMatch, SfvbContainerWriteRequest containerWriteRequest, string containerName = null)

Write a container stored outside the file system

Validation is mandatory and runs here regardless of whether the caller validated first.  The previous value is snapshotted before the write, so the change can be reverted.  Side effects the visual builder performs on save, such as upsell screenshot regeneration and email content review flagging, are applied too. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **ownerType** | **string**|  | 
 **ownerObjectId** | **string**|  | 
 **ifMatch** | **string**| CJSON hash from the last read.  Required; 428 when absent, 412 when stale. | 
 **containerWriteRequest** | [**SfvbContainerWriteRequest**](SfvbContainerWriteRequest.md)| Container CJSON to write | 
 **containerName** | **string**|  | [optional] 

### Return type

[**SfvbContainerResponse**](SfvbContainerResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbFileContent

> SfvbFileWriteResponse PutSfvbFileContent (int storefrontOid, string ifMatch, SfvbFileWriteRequest fileWriteRequest, string path = null)

Write a storefront file

Runs the template sandbox, Velocity validation and the internationalization check, records a version, and compiles the sibling .vm when the file is a .cjson under a theme.  Send If-Match with the hash from the last read to avoid clobbering a concurrent change.  Writing into the active theme requires sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **ifMatch** | **string**| Content hash from the last read.  Required; 428 when absent, 412 when stale. | 
 **fileWriteRequest** | [**SfvbFileWriteRequest**](SfvbFileWriteRequest.md)| File content to write | 
 **path** | **string**|  | [optional] 

### Return type

[**SfvbFileWriteResponse**](SfvbFileWriteResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **413** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbPreviewSession

> SfvbPreviewSessionResponse PutSfvbPreviewSession (int storefrontOid, string previewSessionId, SfvbPreviewSessionRequest previewSession, int? themeOid = null)

Push containers into a preview session

Stores compiled containers against a session created by createSfvbPreviewSession.  Replaces whatever the session held.  Nothing durable is written.  Requires a token that resolves to a user, so use the device authorization flow. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **previewSessionId** | **string**|  | 
 **previewSession** | [**SfvbPreviewSessionRequest**](SfvbPreviewSessionRequest.md)| Containers to stage in the preview session | 
 **themeOid** | **int?**|  | [optional] 

### Return type

[**SfvbPreviewSessionResponse**](SfvbPreviewSessionResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RenderSfvbWidgets

> SfvbRenderResponse RenderSfvbWidgets (int storefrontOid, int themeOid, SfvbRenderRequest renderRequest)

Render a CJSON node to HTML

Renders one node in the context of a theme and a page.  Unlike compile this is stateful.  Rendering resolves merchant data, so an element bound to an item renders wrongly, and silently, without a context item id.  One node per call, so a node that fails to render fails on its own rather than taking a batch with it, and a failure says why. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **themeOid** | **int**|  | 
 **renderRequest** | [**SfvbRenderRequest**](SfvbRenderRequest.md)| Widgets to render | 

### Return type

[**SfvbRenderResponse**](SfvbRenderResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReserveSfvbWidgetIds

> SfvbWidgetIdsResponse ReserveSfvbWidgetIds (int storefrontOid, int? count = null)

Reserve a block of widget ids

Widget ids are allocated by the server, not invented by the caller.  Reserve a block, then form ids as elementType-number.  This is the single most likely thing to get wrong on a first write.  A POST rather than a GET because it consumes a sequence.  A GET that mutates will eventually be prefetched, retried or cached by something that assumed it was safe. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **count** | **int?**|  | [optional] 

### Return type

[**SfvbWidgetIdsResponse**](SfvbWidgetIdsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RevertSfvbContainer

> SfvbContainerResponse RevertSfvbContainer (int storefrontOid, string ownerType, string ownerObjectId, string ifMatch, SfvbContainerRevertRequest containerRevertRequest, string containerName = null)

Revert a container stored outside the file system

The restore is itself snapshotted, so a revert can be undone in turn.  Reverting to an entry recorded before the container existed removes it again.  Addressed through the owning container and guarded by If-Match, because a revert overwrites live content just as much as an ordinary write does. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **ownerType** | **string**|  | 
 **ownerObjectId** | **string**|  | 
 **ifMatch** | **string**| CJSON hash of the container being reverted.  Required; 428 when absent, 412 when stale. | 
 **containerRevertRequest** | [**SfvbContainerRevertRequest**](SfvbContainerRevertRequest.md)| Version to revert the container to | 
 **containerName** | **string**|  | [optional] 

### Return type

[**SfvbContainerResponse**](SfvbContainerResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **428** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RevertSfvbFile

> SfvbFileWriteResponse RevertSfvbFile (int storefrontOid, string ifMatch, SfvbFileRevertRequest fileRevertRequest)

Revert a storefront file to an earlier version

The revert lands as a new version, so it is itself undoable. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **ifMatch** | **string**| Content hash of the file being reverted.  Required; 428 when absent, 412 when stale. | 
 **fileRevertRequest** | [**SfvbFileRevertRequest**](SfvbFileRevertRequest.md)| Version to revert the file to | 

### Return type

[**SfvbFileWriteResponse**](SfvbFileWriteResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SearchSfvbFiles

> SfvbFileSearchResponse SearchSfvbFiles (int storefrontOid, SfvbFileSearchRequest searchRequest)

Search storefront files

Searches names and, when text is supplied, file contents.  For a CLI with no local copy this is the only way to answer where something is defined without walking the whole tree.  Results are capped and truncation is always reported. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **searchRequest** | [**SfvbFileSearchRequest**](SfvbFileSearchRequest.md)| File search | 

### Return type

[**SfvbFileSearchResponse**](SfvbFileSearchResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SearchSfvbLibrary

> SfvbLibraryResponse SearchSfvbLibrary (int storefrontOid, string segment = null, string search = null, int? pageNumber = null, int? resultsPerPage = null)

Search the element library

Known-good CJSON fragments a human already built out of real elements.  This is what a lint warning about a monolithic html element should point at - a warning that names a fragment solving the same problem is an instruction, where a warning on its own is only criticism.  Results are terse; fetch a single entry for its CJSON.  Narrow with facet_{name}={option} query parameters. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **segment** | **string**|  | [optional] 
 **search** | **string**|  | [optional] 
 **pageNumber** | **int?**|  | [optional] 
 **resultsPerPage** | **int?**|  | [optional] 

### Return type

[**SfvbLibraryResponse**](SfvbLibraryResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UploadSfvbFile

> SfvbFileWriteResponse UploadSfvbFile (int storefrontOid, SfvbFileUploadRequest fileUploadRequest, string ifMatch = null)

Store a binary asset that was already uploaded

The second half of the two step upload.  The bytes are fetched from the key, checked against the extension they claim to be, and written exactly as a text write is - so the same If-Match precondition, the same read only refusal and the same publish gate apply.  An SVG is sanitized before it is stored.  Writing outside /themes/ requires sfvb_publish, because anything served off the storefront root is live by definition. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **fileUploadRequest** | [**SfvbFileUploadRequest**](SfvbFileUploadRequest.md)| Where to store the uploaded bytes | 
 **ifMatch** | **string**| Content hash from the last read.  Required when the file already exists; 428 when absent, 412 when stale. | [optional] 

### Return type

[**SfvbFileWriteResponse**](SfvbFileWriteResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **413** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ValidateSfvbCjson

> SfvbValidationResponse ValidateSfvbCjson (SfvbValidateRequest validateRequest)

Validate CJSON

Runs the structural schema, the contextual business rules for the destination owner type, and the quality lint.  A document that fails returns HTTP 200 with valid false rather than a transport error - the request was well formed, the document was not. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **validateRequest** | [**SfvbValidateRequest**](SfvbValidateRequest.md)| CJSON to validate | 

### Return type

[**SfvbValidationResponse**](SfvbValidationResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ValidateSfvbVelocity

> SfvbValidationResponse ValidateSfvbVelocity (int storefrontOid, int themeOid, SfvbVelocityValidateRequest velocityValidateRequest)

Validate a Velocity template against a theme

Theme scoped rather than stateless.  Validation builds a theme template context and evaluates against it.  Also applies the template sandbox, so an agent learns the rule before a write fails. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **themeOid** | **int**|  | 
 **velocityValidateRequest** | [**SfvbVelocityValidateRequest**](SfvbVelocityValidateRequest.md)| Velocity template to validate | 

### Return type

[**SfvbValidationResponse**](SfvbValidationResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

