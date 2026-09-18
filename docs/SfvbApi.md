# com.ultracart.admin.v2.Api.SfvbApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddSfvbPageBlogPosts**](SfvbApi.md#addsfvbpageblogposts) | **POST** /sfvb/storefronts/{storefront_oid}/pages/blog_posts/add | Assign blog posts to a page
[**AddSfvbPageItems**](SfvbApi.md#addsfvbpageitems) | **POST** /sfvb/storefronts/{storefront_oid}/pages/items/add | Assign items to a page
[**CompileSfvbCjson**](SfvbApi.md#compilesfvbcjson) | **POST** /sfvb/cjson/compile | Compile CJSON to Velocity
[**CreateSfvbPreviewAccess**](SfvbApi.md#createsfvbpreviewaccess) | **POST** /sfvb/storefronts/{storefront_oid}/preview_access | One time link that opens a preview in a browser with no UltraCart login
[**CreateSfvbPreviewSession**](SfvbApi.md#createsfvbpreviewsession) | **POST** /sfvb/storefronts/{storefront_oid}/preview_sessions | Create a preview session
[**DeleteSfvbFile**](SfvbApi.md#deletesfvbfile) | **DELETE** /sfvb/storefronts/{storefront_oid}/files | Delete a storefront file
[**DeleteSfvbPageMultimedia**](SfvbApi.md#deletesfvbpagemultimedia) | **DELETE** /sfvb/storefronts/{storefront_oid}/pages/multimedia | Detach an image from a page
[**DeleteSfvbPreviewSession**](SfvbApi.md#deletesfvbpreviewsession) | **DELETE** /sfvb/storefronts/{storefront_oid}/preview_sessions/{preview_session_id} | Delete a preview session
[**DownloadSfvbFile**](SfvbApi.md#downloadsfvbfile) | **GET** /sfvb/storefronts/{storefront_oid}/files/download | Read a storefront file&#39;s raw bytes
[**DuplicateSfvbPage**](SfvbApi.md#duplicatesfvbpage) | **POST** /sfvb/storefronts/{storefront_oid}/pages/duplicate | Copy a page to a new path
[**DuplicateSfvbTheme**](SfvbApi.md#duplicatesfvbtheme) | **POST** /sfvb/storefronts/{storefront_oid}/themes/{theme_oid}/duplicate | Duplicate a theme
[**EndSfvbExperiment**](SfvbApi.md#endsfvbexperiment) | **POST** /sfvb/storefronts/{storefront_oid}/experiments/{experiment_oid}/end | End an experiment
[**GetSfvbCjsonUsedElements**](SfvbApi.md#getsfvbcjsonusedelements) | **POST** /sfvb/cjson/elements | Element types used by a container
[**GetSfvbContainer**](SfvbApi.md#getsfvbcontainer) | **GET** /sfvb/storefronts/{storefront_oid}/containers/{owner_type}/{owner_object_id} | Read a container stored outside the file system
[**GetSfvbContainerVersion**](SfvbApi.md#getsfvbcontainerversion) | **GET** /sfvb/storefronts/{storefront_oid}/container_versions/{container_history_oid} | Read the CJSON stored in one container history entry
[**GetSfvbElement**](SfvbApi.md#getsfvbelement) | **GET** /sfvb/elements/{element_type} | Configuration schema and field card for one element type
[**GetSfvbExperiment**](SfvbApi.md#getsfvbexperiment) | **GET** /sfvb/storefronts/{storefront_oid}/experiments/{experiment_oid} | Read one experiment and its statistics
[**GetSfvbExperimentObjectives**](SfvbApi.md#getsfvbexperimentobjectives) | **GET** /sfvb/storefronts/{storefront_oid}/experiments/objectives | List the objectives an experiment can optimize
[**GetSfvbFileContent**](SfvbApi.md#getsfvbfilecontent) | **GET** /sfvb/storefronts/{storefront_oid}/files/content | Read a storefront file
[**GetSfvbFileUploadUrl**](SfvbApi.md#getsfvbfileuploadurl) | **GET** /sfvb/storefronts/{storefront_oid}/files/upload_url/{extension} | Get a URL to upload a binary asset to
[**GetSfvbLibraryEntry**](SfvbApi.md#getsfvblibraryentry) | **GET** /sfvb/storefronts/{storefront_oid}/library/{library_oid} | Read one library entry including its CJSON
[**GetSfvbMenu**](SfvbApi.md#getsfvbmenu) | **GET** /sfvb/storefronts/{storefront_oid}/menus/{code} | Read one store menu and its entries
[**GetSfvbMenus**](SfvbApi.md#getsfvbmenus) | **GET** /sfvb/storefronts/{storefront_oid}/menus | List a storefront&#39;s store menus
[**GetSfvbPage**](SfvbApi.md#getsfvbpage) | **GET** /sfvb/storefronts/{storefront_oid}/pages | Read a page&#39;s attributes and images
[**GetSfvbPageBlogPosts**](SfvbApi.md#getsfvbpageblogposts) | **GET** /sfvb/storefronts/{storefront_oid}/pages/blog_posts | Read the blog posts assigned to a page
[**GetSfvbPageItems**](SfvbApi.md#getsfvbpageitems) | **GET** /sfvb/storefronts/{storefront_oid}/pages/items | Read the items assigned to a page
[**GetSfvbPageSelectors**](SfvbApi.md#getsfvbpageselectors) | **GET** /sfvb/storefronts/{storefront_oid}/pages/selectors | Read a page&#39;s selectors
[**GetSfvbPreviewUrl**](SfvbApi.md#getsfvbpreviewurl) | **GET** /sfvb/storefronts/{storefront_oid}/preview_sessions/{preview_session_id}/url | URL that renders a preview session
[**GetSfvbSiteAttributes**](SfvbApi.md#getsfvbsiteattributes) | **GET** /sfvb/storefronts/{storefront_oid}/attributes | Read a storefront&#39;s site attributes
[**GetSfvbTheme**](SfvbApi.md#getsfvbtheme) | **GET** /sfvb/storefronts/{storefront_oid}/themes/{theme_oid} | Get a theme
[**GetSfvbThemeAttributes**](SfvbApi.md#getsfvbthemeattributes) | **GET** /sfvb/storefronts/{storefront_oid}/themes/{theme_oid}/attributes | Read a theme&#39;s colors, fonts and settings
[**GetSfvbThemeJob**](SfvbApi.md#getsfvbthemejob) | **GET** /sfvb/storefronts/{storefront_oid}/theme_jobs/{job_id} | Status of an asynchronous theme job
[**GetSfvbVersion**](SfvbApi.md#getsfvbversion) | **GET** /sfvb/version | Compiler version for this merchant
[**GetSfvbWhoami**](SfvbApi.md#getsfvbwhoami) | **GET** /sfvb/whoami | Who this token is
[**InsertSfvbPage**](SfvbApi.md#insertsfvbpage) | **POST** /sfvb/storefronts/{storefront_oid}/pages | Create a page
[**InstallSfvbLibraryEntry**](SfvbApi.md#installsfvblibraryentry) | **POST** /sfvb/storefronts/{storefront_oid}/library/{library_oid}/install | Install a library entry into a storefront
[**ListSfvbBlogPosts**](SfvbApi.md#listsfvbblogposts) | **GET** /sfvb/storefronts/{storefront_oid}/blog_posts | List the storefront&#39;s blog posts
[**ListSfvbContainerVersions**](SfvbApi.md#listsfvbcontainerversions) | **GET** /sfvb/storefronts/{storefront_oid}/container_versions | Version history for a container stored outside the file system
[**ListSfvbElements**](SfvbApi.md#listsfvbelements) | **GET** /sfvb/elements | List every SFVB element type
[**ListSfvbExperiments**](SfvbApi.md#listsfvbexperiments) | **GET** /sfvb/storefronts/{storefront_oid}/experiments | List the storefront&#39;s experiments
[**ListSfvbFileVersions**](SfvbApi.md#listsfvbfileversions) | **GET** /sfvb/storefronts/{storefront_oid}/files/versions | Version history for a storefront file
[**ListSfvbFiles**](SfvbApi.md#listsfvbfiles) | **GET** /sfvb/storefronts/{storefront_oid}/files | List a storefront directory
[**ListSfvbPages**](SfvbApi.md#listsfvbpages) | **GET** /sfvb/storefronts/{storefront_oid}/pages/list | List the storefront&#39;s pages
[**ListSfvbStorefronts**](SfvbApi.md#listsfvbstorefronts) | **GET** /sfvb/storefronts | List storefronts
[**ListSfvbTemplates**](SfvbApi.md#listsfvbtemplates) | **GET** /sfvb/storefronts/{storefront_oid}/templates | List the active theme&#39;s templates
[**ListSfvbThemes**](SfvbApi.md#listsfvbthemes) | **GET** /sfvb/storefronts/{storefront_oid}/themes | List themes for a storefront
[**ListSfvbUpsellOffers**](SfvbApi.md#listsfvbupselloffers) | **GET** /sfvb/storefronts/{storefront_oid}/upsell_offers | List upsell offers
[**PutSfvbContainer**](SfvbApi.md#putsfvbcontainer) | **PUT** /sfvb/storefronts/{storefront_oid}/containers/{owner_type}/{owner_object_id} | Write a container stored outside the file system
[**PutSfvbExperimentVariation**](SfvbApi.md#putsfvbexperimentvariation) | **PUT** /sfvb/storefronts/{storefront_oid}/experiments/{experiment_oid}/variations/{variation_number} | Pause or resume a variation
[**PutSfvbFileContent**](SfvbApi.md#putsfvbfilecontent) | **PUT** /sfvb/storefronts/{storefront_oid}/files/content | Write a storefront file
[**PutSfvbMenu**](SfvbApi.md#putsfvbmenu) | **PUT** /sfvb/storefronts/{storefront_oid}/menus/{code} | Replace a store menu&#39;s entries
[**PutSfvbPageAttributes**](SfvbApi.md#putsfvbpageattributes) | **PUT** /sfvb/storefronts/{storefront_oid}/pages/attributes | Change a page&#39;s attributes
[**PutSfvbPageMultimedia**](SfvbApi.md#putsfvbpagemultimedia) | **PUT** /sfvb/storefronts/{storefront_oid}/pages/multimedia | Attach an image to a page
[**PutSfvbPageSelectors**](SfvbApi.md#putsfvbpageselectors) | **PUT** /sfvb/storefronts/{storefront_oid}/pages/selectors | Replace a page&#39;s selectors
[**PutSfvbPageSettings**](SfvbApi.md#putsfvbpagesettings) | **PUT** /sfvb/storefronts/{storefront_oid}/pages/settings | Change a page&#39;s settings
[**PutSfvbPreviewSession**](SfvbApi.md#putsfvbpreviewsession) | **PUT** /sfvb/storefronts/{storefront_oid}/preview_sessions/{preview_session_id} | Push containers into a preview session
[**PutSfvbSiteAttributes**](SfvbApi.md#putsfvbsiteattributes) | **PUT** /sfvb/storefronts/{storefront_oid}/attributes | Change a storefront&#39;s site attributes
[**PutSfvbThemeAttributes**](SfvbApi.md#putsfvbthemeattributes) | **PUT** /sfvb/storefronts/{storefront_oid}/themes/{theme_oid}/attributes | Change a theme&#39;s colors, fonts and settings
[**RemoveSfvbPageBlogPosts**](SfvbApi.md#removesfvbpageblogposts) | **POST** /sfvb/storefronts/{storefront_oid}/pages/blog_posts/remove | Take blog posts off a page
[**RemoveSfvbPageItems**](SfvbApi.md#removesfvbpageitems) | **POST** /sfvb/storefronts/{storefront_oid}/pages/items/remove | Take items off a page
[**RenderSfvbWidgets**](SfvbApi.md#rendersfvbwidgets) | **POST** /sfvb/storefronts/{storefront_oid}/themes/{theme_oid}/render | Render a CJSON node to HTML
[**ReserveSfvbWidgetIds**](SfvbApi.md#reservesfvbwidgetids) | **POST** /sfvb/storefronts/{storefront_oid}/widget_ids | Reserve a block of widget ids
[**RevertSfvbContainer**](SfvbApi.md#revertsfvbcontainer) | **POST** /sfvb/storefronts/{storefront_oid}/containers/{owner_type}/{owner_object_id}/revert | Revert a container stored outside the file system
[**RevertSfvbFile**](SfvbApi.md#revertsfvbfile) | **POST** /sfvb/storefronts/{storefront_oid}/files/revert | Revert a storefront file to an earlier version
[**SearchSfvbFiles**](SfvbApi.md#searchsfvbfiles) | **POST** /sfvb/storefronts/{storefront_oid}/files/search | Search storefront files
[**SearchSfvbLibrary**](SfvbApi.md#searchsfvblibrary) | **GET** /sfvb/storefronts/{storefront_oid}/library | Search the element library
[**StartSfvbExperiment**](SfvbApi.md#startsfvbexperiment) | **POST** /sfvb/storefronts/{storefront_oid}/experiments | Start an experiment
[**UploadSfvbFile**](SfvbApi.md#uploadsfvbfile) | **POST** /sfvb/storefronts/{storefront_oid}/files/upload | Store a binary asset that was already uploaded
[**ValidateSfvbCjson**](SfvbApi.md#validatesfvbcjson) | **POST** /sfvb/cjson/validate | Validate CJSON
[**ValidateSfvbVelocity**](SfvbApi.md#validatesfvbvelocity) | **POST** /sfvb/storefronts/{storefront_oid}/themes/{theme_oid}/velocity/validate | Validate a Velocity template against a theme



## AddSfvbPageBlogPosts

> SfvbPageBlogPostsResponse AddSfvbPageBlogPosts (int storefrontOid, string path, SfvbPageBlogPostsRequest pageBlogPostsRequest)

Assign blog posts to a page

Adds posts by blog_post_oid, at most 500 at a time.  Every oid must be a post on this storefront, and one that is not changes nothing.  Refused on a page whose selectors choose its blog posts.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /blog/ | 
 **pageBlogPostsRequest** | [**SfvbPageBlogPostsRequest**](SfvbPageBlogPostsRequest.md)| Blog posts to assign | 

### Return type

[**SfvbPageBlogPostsResponse**](SfvbPageBlogPostsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
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


## AddSfvbPageItems

> SfvbPageItemsResponse AddSfvbPageItems (int storefrontOid, string path, SfvbPageItemsAddRequest pageItemsAddRequest)

Assign items to a page

Adds items by item id, at most 500 at a time, or changes the sort order or url part of items already on the page.  Every id is checked first and one unknown id changes nothing.  Refused on a page whose selectors choose its items.  sort_order is refused unless the page sorts its items by a custom order.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /lp/spring-sale/ | 
 **pageItemsAddRequest** | [**SfvbPageItemsAddRequest**](SfvbPageItemsAddRequest.md)| Items to assign | 

### Return type

[**SfvbPageItemsResponse**](SfvbPageItemsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
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


## CreateSfvbPreviewAccess

> SfvbPreviewAccessResponse CreateSfvbPreviewAccess (int storefrontOid, SfvbPreviewAccessRequest previewAccess = null)

One time link that opens a preview in a browser with no UltraCart login

The preview URL only works in a browser already signed in to UltraCart on the storefront's own host, and an agent's built in browser never is.  This returns a single use access_url on the storefront host instead.  Opening it gets past the storefront lock, shows the requested theme and applies the requested preview session for the rest of that browser session, then redirects to path.  It expires two minutes after issue or on first use.  Pages opened afterwards carry an X-UltraCart-Preview header of applied or not-applied.  Requires a token that resolves to a user, so use the device authorization flow. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **previewAccess** | [**SfvbPreviewAccessRequest**](SfvbPreviewAccessRequest.md)| What the browser should see | [optional] 

### Return type

[**SfvbPreviewAccessResponse**](SfvbPreviewAccessResponse.md)

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


## CreateSfvbPreviewSession

> SfvbPreviewSessionResponse CreateSfvbPreviewSession (int storefrontOid)

Create a preview session

Returns a server generated session id to push containers into, and opens the session so that id exists rather than merely being random.  The id is not caller supplied, because concurrent agents choosing their own would be free to collide, and the browser editor's habit of minting one with Math.random is not a property worth carrying into an API.  Expires after eight hours and can be deleted sooner.  Requires a token that resolves to a user, so use the device authorization flow. 


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
| **412** |  |  -  |
| **428** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteSfvbPageMultimedia

> SfvbPageResponse DeleteSfvbPageMultimedia (int storefrontOid, string path, string code = null, bool? _default = null)

Detach an image from a page

Name exactly one of code or default.  Removes the page's copy of the image; the source file in the page folder is left alone.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /catalog/dispensers/ | 
 **code** | **string**| Image code to detach | [optional] 
 **_default** | **bool?**| True to detach the default image | [optional] 

### Return type

[**SfvbPageResponse**](SfvbPageResponse.md)

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


## DuplicateSfvbPage

> SfvbPageResponse DuplicateSfvbPage (int storefrontOid, SfvbPageDuplicateRequest pageDuplicateRequest)

Copy a page to a new path

Copies what the store admin's duplicate copies - settings, items, blog posts, permissions, attributes, selectors, images and the page folder with its body.  The copy goes to the path you choose, under any existing page, with the same path rules as creating a page, and a 409 with the code sfvb.page_exists when that path is taken.  The root page and pages with pages under them cannot be copied.  A page whose folder holds a started experiment is refused, because the copy would share the experiment - end it first.  Translated title and description text is not copied.  Always needs sfvb_publish, because the copy is live as soon as it exists. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **pageDuplicateRequest** | [**SfvbPageDuplicateRequest**](SfvbPageDuplicateRequest.md)| The page to copy and where | 

### Return type

[**SfvbPageResponse**](SfvbPageResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **201** |  |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
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


## EndSfvbExperiment

> SfvbExperiment EndSfvbExperiment (int storefrontOid, int experimentOid, SfvbExperimentEndRequest experimentEndRequest = null)

End an experiment

Ends a running experiment.  With winner_variation_number the winner gets all new visitors, and a page experiment's winning content is promoted into the page by the completion job on its next run, which also emails the merchant.  Without a winner a page experiment's id is cleared from its page body so the page shows variation 0, and a url experiment sends everyone to variation 0.  Visitors already assigned to a url experiment keep their page for up to 30 days.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **experimentOid** | **int**|  | 
 **experimentEndRequest** | [**SfvbExperimentEndRequest**](SfvbExperimentEndRequest.md)| The winner, if any | [optional] 

### Return type

[**SfvbExperiment**](SfvbExperiment.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
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

owner_type is one of upsell, email, postcardfront, postcardback, item or itemid.  It also says how owner_object_id is read - item and upsell take an oid, itemid takes a merchant item id, and the rest take an esp uuid.  itemid reaches the same containers as item and is the way to address one from a storefront, where data-context-item-id carries the merchant item id and the oid appears nowhere.  Item containers also require container_name.  Theme and page containers are files; read those through files/content. 


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

Inspect or diff an earlier version without reverting to it.  The version is addressed through the container that owns it, so a history oid belonging to some other resource cannot be read through this route.  owner_type also says how owner_object_id is read, and itemid addresses an item container by merchant item id. 


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

Configuration schema and field card for one element type

schema is the draft-07 JSON schema for the element config object and doc is the markdown field card, both as strings.  Either is omitted when none has been published for the element, which is still a 200.  The catalog is published by the visual builder release process, and a republish can take up to an hour to appear here. 


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


## GetSfvbExperiment

> SfvbExperiment GetSfvbExperiment (int storefrontOid, int experimentOid, bool? daily = null)

Read one experiment and its statistics

The experiment, its variations and their statistics, and with daily=true each variation's daily rows.  p95_sessions_needed is estimated only after 1000 sessions, and sessions_needed_computed_dts says when.  For a url experiment, router_url is the address visitors must enter through. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **experimentOid** | **int**|  | 
 **daily** | **bool?**| Include each variation&#39;s daily statistics | [optional] 

### Return type

[**SfvbExperiment**](SfvbExperiment.md)

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


## GetSfvbExperimentObjectives

> SfvbExperimentObjectivesResponse GetSfvbExperimentObjectives (int storefrontOid)

List the objectives an experiment can optimize

Each objective with what is measured per session and compared between variations, the usual optimization type, and whether it needs an event name. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 

### Return type

[**SfvbExperimentObjectivesResponse**](SfvbExperimentObjectivesResponse.md)

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


## GetSfvbMenu

> SfvbMenu GetSfvbMenu (int storefrontOid, string code)

Read one store menu and its entries

The whole tree, in render order.  Page entries carry the page_path they resolve to and item entries the merchant_item_id, rather than the oids the storage keeps.  Menu item oids are not returned at all because a write regenerates every one of them.  Keep hash_sha256 - it is the If-Match a write needs. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **code** | **string**| Menu code, matched without regard to case | 

### Return type

[**SfvbMenu**](SfvbMenu.md)

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


## GetSfvbMenus

> SfvbMenusResponse GetSfvbMenus (int storefrontOid)

List a storefront's store menus

The menus a menu element's menuName can name, sorted by code and without their entries.  A code the active theme's templates ask for but nothing has created is included with unconfigured true - that code renders an empty list today, and writing it creates it.  A menu no template names is marked undeclared, which usually means a menuName is misspelled. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 

### Return type

[**SfvbMenusResponse**](SfvbMenusResponse.md)

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


## GetSfvbPage

> SfvbPageResponse GetSfvbPage (int storefrontOid, string path)

Read a page's attributes and images

What the pageattribute and pageimage elements render for this page.  These are not in any file, which is why a page folder can be empty and its elements still render something.  Attributes and image codes a template declares but nothing has set are included, so the response describes what the page can show rather than only what has been saved. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /catalog/dispensers/ | 

### Return type

[**SfvbPageResponse**](SfvbPageResponse.md)

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


## GetSfvbPageBlogPosts

> SfvbPageBlogPostsResponse GetSfvbPageBlogPosts (int storefrontOid, string path)

Read the blog posts assigned to a page

The posts the page shows.  uses_selectors is true when the page's blog post selectors choose them instead. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /blog/ | 

### Return type

[**SfvbPageBlogPostsResponse**](SfvbPageBlogPostsResponse.md)

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


## GetSfvbPageItems

> SfvbPageItemsResponse GetSfvbPageItems (int storefrontOid, string path)

Read the items assigned to a page

The items on the page with their sort order and url part.  uses_selectors is true when the page's selectors choose its items instead. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /lp/spring-sale/ | 

### Return type

[**SfvbPageItemsResponse**](SfvbPageItemsResponse.md)

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


## GetSfvbPageSelectors

> SfvbPageSelectors GetSfvbPageSelectors (int storefrontOid, string path)

Read a page's selectors

The conditions that choose the page's items and blog posts, and whether each set must all match. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /lp/spring-sale/ | 

### Return type

[**SfvbPageSelectors**](SfvbPageSelectors.md)

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


## GetSfvbSiteAttributes

> SfvbSiteAttributesResponse GetSfvbSiteAttributes (int storefrontOid)

Read a storefront's site attributes

The values the siteattribute element and $site.attr render.  These are not in any file or theme.  Attributes a template declares but nothing has set are included with the template's default, so the response describes what the templates can render rather than only what has been saved.  Credentials stored as site attributes are never included. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 

### Return type

[**SfvbSiteAttributesResponse**](SfvbSiteAttributesResponse.md)

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


## GetSfvbThemeAttributes

> SfvbThemeAttributesResponse GetSfvbThemeAttributes (int storefrontOid, int themeOid)

Read a theme's colors, fonts and settings

The values theme.css and the compiled containers resolve at render time.  These do NOT live in any file.  settings.json contains a palette and looks like the answer, but it is the theme's factory template - it supplies defaults for slots that have never been set and is ignored for slots that have, so editing it will not change a color and reading it will not tell you the current one.  Slots a template declares but nothing has ever set are included here, carrying the default they will render with, so the response describes the whole theme rather than the rows that happen to exist. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **themeOid** | **int**|  | 

### Return type

[**SfvbThemeAttributesResponse**](SfvbThemeAttributesResponse.md)

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


## InsertSfvbPage

> SfvbPageResponse InsertSfvbPage (int storefrontOid, SfvbPageCreateRequest pageCreateRequest)

Create a page

Creates the page and its folder, the way the store admin's add page does.  The parent page must already exist, and the last part of the path may only contain letters, digits, hyphens and underscores - it is refused, not cleaned.  A path that already has a page is refused with a 409 and the code sfvb.page_exists.  Without a group_template the page inherits its parent's templates, or catalog_group.vm directly under the root.  Set attributes and images afterwards with the page attribute and image endpoints, and push the body to the page folder.  Always needs sfvb_publish, because the page is live as soon as it exists.  Deleting, moving and renaming pages stay in the store admin. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **pageCreateRequest** | [**SfvbPageCreateRequest**](SfvbPageCreateRequest.md)| The page to create | 

### Return type

[**SfvbPageResponse**](SfvbPageResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **201** |  |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
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


## ListSfvbBlogPosts

> SfvbBlogPostsResponse ListSfvbBlogPosts (int storefrontOid, string search = null, int? page = null, int? pageSize = null)

List the storefront's blog posts

One page of blog posts, newest first, without their bodies.  search matches the title, body, excerpt, url part or author, or a tag exactly.  unassigned marks posts no page shows yet.  Use a post's blog_post_oid to assign it to a page. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **search** | **string**| Text to search for | [optional] 
 **page** | **int?**| Page number, starting at 1 | [optional] 
 **pageSize** | **int?**| Posts per page, 1 to 100, default 50 | [optional] 

### Return type

[**SfvbBlogPostsResponse**](SfvbBlogPostsResponse.md)

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


## ListSfvbContainerVersions

> SfvbContainerVersionsResponse ListSfvbContainerVersions (int storefrontOid, string ownerType = null, string ownerObjectId = null, string containerName = null)

Version history for a container stored outside the file system

Addressed the same way as the container itself, so owner_type also says how owner_object_id is read and itemid lists the history of the item container that merchant item id names. 


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


## ListSfvbExperiments

> SfvbExperimentsResponse ListSfvbExperiments (int storefrontOid, string status = null, string type = null, string path = null)

List the storefront's experiments

Every experiment that is not deleted, with its variations and their statistics - the same numbers the store admin shows.  Filter by status, by type (page, url, theme, openai), or by the page an experiment runs on.  auto_ends_at says when the engine will end an experiment by itself, and p_value is a one-way ANOVA across all variations.  Read one experiment for its daily statistics. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **status** | **string**| Running or Ended | [optional] 
 **type** | **string**| page, url, theme or openai | [optional] 
 **path** | **string**| Only experiments on this page, for example /lp/spring-sale/ | [optional] 

### Return type

[**SfvbExperimentsResponse**](SfvbExperimentsResponse.md)

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


## ListSfvbPages

> SfvbPageListResponse ListSfvbPages (int storefrontOid, string under = null)

List the storefront's pages

Every page with its settings, sorted by path with the root first.  Hidden pages are included.  Pass under to list one page and everything below it.  Read from the same cached catalog the admin page tree uses, so a page created a moment ago can take a moment to appear here - read it directly with the single-page read to confirm a write. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **under** | **string**| Only this page and the pages below it, for example /lp/ | [optional] 

### Return type

[**SfvbPageListResponse**](SfvbPageListResponse.md)

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


## ListSfvbTemplates

> SfvbTemplatesResponse ListSfvbTemplates (int storefrontOid, string pageType = null)

List the active theme's templates

Each template with the page type it declares and what it can render - items, sub-pages, blog posts, pagination, visual builder containers.  A page's group_template names one of these.  The storefront's fixed templates, such as checkout and my account, are flagged system and must never be assigned to a page. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **pageType** | **string**| Only templates declaring this page type, for example group | [optional] 

### Return type

[**SfvbTemplatesResponse**](SfvbTemplatesResponse.md)

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

Validation is mandatory and runs here regardless of whether the caller validated first.  The previous value is snapshotted before the write, so the change can be reverted.  Side effects the visual builder performs on save, such as upsell screenshot regeneration and email content review flagging, are applied too.  owner_type also says how owner_object_id is read; send itemid to address an item container by merchant item id rather than by oid.  Either way the history records the one canonical address, so a container written under one spelling is listed and reverted under the other. 


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
| **428** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbExperimentVariation

> SfvbExperiment PutSfvbExperimentVariation (int storefrontOid, int experimentOid, int variationNumber, SfvbExperimentVariationUpdateRequest experimentVariationUpdateRequest)

Pause or resume a variation

Stops or resumes sending new visitors to one variation of a running experiment.  Visitors already assigned keep seeing it.  Variation 0 cannot be paused, because the split falls back to it, and the last variation still receiving visitors cannot be paused.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **experimentOid** | **int**|  | 
 **variationNumber** | **int**|  | 
 **experimentVariationUpdateRequest** | [**SfvbExperimentVariationUpdateRequest**](SfvbExperimentVariationUpdateRequest.md)| Pause or resume | 

### Return type

[**SfvbExperiment**](SfvbExperiment.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
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
| **428** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbMenu

> SfvbMenu PutSfvbMenu (int storefrontOid, string code, SfvbMenuWriteRequest menuWriteRequest, string ifMatch = null)

Replace a store menu's entries

A whole menu replace, not a merge - what you send is what the menu holds afterwards, so read it, change the tree and send it back.  Omitting items changes only the title; sending an empty array empties the menu.  Writing a code that does not exist creates it.  Every entry is checked before any of it is written, including that a merchant_item_id and a page_path actually resolve, so a tree with one bad entry changes nothing.  Always needs sfvb_publish, because a menu is shared by every theme and there is no dormant copy to change instead. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **code** | **string**| Menu code, matched without regard to case | 
 **menuWriteRequest** | [**SfvbMenuWriteRequest**](SfvbMenuWriteRequest.md)| The menu&#39;s replacement contents | 
 **ifMatch** | **string**| Content hash from the last read.  Required when the menu already exists; 428 when absent, 412 when stale. | [optional] 

### Return type

[**SfvbMenu**](SfvbMenu.md)

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


## PutSfvbPageAttributes

> SfvbPageResponse PutSfvbPageAttributes (int storefrontOid, string path, SfvbPageAttributeUpdateRequest pageAttributeUpdateRequest)

Change a page's attributes

A partial update.  Only the attributes you name are changed.  Every entry is checked before any is written.  List, slider, item set, page collection and video list attributes are refused - edit those in the page editor.  Always needs sfvb_publish, because a page's attributes are shared by every theme and there is no dormant copy to change instead. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /catalog/dispensers/ | 
 **pageAttributeUpdateRequest** | [**SfvbPageAttributeUpdateRequest**](SfvbPageAttributeUpdateRequest.md)| Attributes to change | 

### Return type

[**SfvbPageResponse**](SfvbPageResponse.md)

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


## PutSfvbPageMultimedia

> SfvbPageResponse PutSfvbPageMultimedia (int storefrontOid, string path, SfvbPageMultimediaRequest pageMultimediaRequest)

Attach an image to a page

Upload the image with files/upload to the page path followed by a filename first, then name that filename here as either the default image or an image code.  The default image is what a pageimage element with no pageImageCode renders, and what a subgroup tile shows.  Replaces whatever that slot held.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /catalog/dispensers/ | 
 **pageMultimediaRequest** | [**SfvbPageMultimediaRequest**](SfvbPageMultimediaRequest.md)| Image to attach | 

### Return type

[**SfvbPageResponse**](SfvbPageResponse.md)

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


## PutSfvbPageSelectors

> SfvbPageSelectors PutSfvbPageSelectors (int storefrontOid, string path, SfvbPageSelectors pageSelectorsRequest)

Replace a page's selectors

Each list you send replaces that whole set, and an empty list clears it.  A list you leave out is not touched.  The page's items or blog posts are recalculated from the new selectors straight away.  While a page has item selectors its items cannot be assigned by hand.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /lp/spring-sale/ | 
 **pageSelectorsRequest** | [**SfvbPageSelectors**](SfvbPageSelectors.md)| The selector sets to replace | 

### Return type

[**SfvbPageSelectors**](SfvbPageSelectors.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
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


## PutSfvbPageSettings

> SfvbPageResponse PutSfvbPageSettings (int storefrontOid, string path, SfvbPageSettingsRequest pageSettingsRequest)

Change a page's settings

A partial update.  Only the fields you send change - title, description, templates, visibility, sitemap exclusion, sort orders, items per page and page type.  Unlike the store admin's page save, the page's attributes, images, items, selectors and permissions are left exactly as they are.  Fields that would move or rename the page, and fields this endpoint does not know, are refused.  The root page cannot be hidden.  Always needs sfvb_publish, because page settings are live. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /lp/spring-sale/ | 
 **pageSettingsRequest** | [**SfvbPageSettingsRequest**](SfvbPageSettingsRequest.md)| The settings to change | 

### Return type

[**SfvbPageResponse**](SfvbPageResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
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


## PutSfvbPreviewSession

> SfvbPreviewSessionResponse PutSfvbPreviewSession (int storefrontOid, string previewSessionId, SfvbPreviewSessionRequest previewSession, int? themeOid = null)

Push containers into a preview session

Stores compiled containers against a session created by createSfvbPreviewSession.  Replaces whatever the session held.  The session must exist - this does not create one, so a deleted, expired or never issued id is a 404 rather than a new session.  Nothing durable is written.  Requires a token that resolves to a user, so use the device authorization flow. 


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


## PutSfvbSiteAttributes

> SfvbSiteAttributesResponse PutSfvbSiteAttributes (int storefrontOid, SfvbSiteAttributeUpdateRequest siteAttributeUpdateRequest)

Change a storefront's site attributes

A partial update.  Only the attributes you name are changed.  Every entry is checked before any is written.  List, video list, mailing list and item set attributes are refused, and so are the General screen settings other than the title, the SEO description and keywords and the social account names.  Credentials are refused.  Always needs sfvb_publish, because every theme reads the same attributes and there is no dormant copy to change instead.  The admin General screen saves the whole storefront, so a merchant with it open can still overwrite a change made here. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **siteAttributeUpdateRequest** | [**SfvbSiteAttributeUpdateRequest**](SfvbSiteAttributeUpdateRequest.md)| Attributes to change | 

### Return type

[**SfvbSiteAttributesResponse**](SfvbSiteAttributesResponse.md)

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


## PutSfvbThemeAttributes

> SfvbThemeAttributesResponse PutSfvbThemeAttributes (int storefrontOid, int themeOid, SfvbThemeAttributeUpdateRequest attributeUpdateRequest)

Change a theme's colors, fonts and settings

A partial update.  Only the slots you name are changed and every other slot on the theme keeps its value, so there is no need to send the whole set back to change one color.  Send a whole palette in one call rather than one call per color - they are applied together, so the storefront never renders half of a change.  Needs sfvb_publish when the theme is the one serving live traffic, because a color is referenced by name from every template that uses it and one write repaints the whole storefront at once.  On a dormant theme sfvb_write is enough, which is what makes duplicate-then-restyle work. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **themeOid** | **int**|  | 
 **attributeUpdateRequest** | [**SfvbThemeAttributeUpdateRequest**](SfvbThemeAttributeUpdateRequest.md)| Slots to change | 

### Return type

[**SfvbThemeAttributesResponse**](SfvbThemeAttributesResponse.md)

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


## RemoveSfvbPageBlogPosts

> SfvbPageBlogPostsResponse RemoveSfvbPageBlogPosts (int storefrontOid, string path, SfvbPageBlogPostsRequest pageBlogPostsRequest)

Take blog posts off a page

Removes posts by blog_post_oid, at most 500 at a time.  Every oid must be on the page, and one that is not changes nothing.  The posts themselves are not touched.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /blog/ | 
 **pageBlogPostsRequest** | [**SfvbPageBlogPostsRequest**](SfvbPageBlogPostsRequest.md)| Blog posts to take off the page | 

### Return type

[**SfvbPageBlogPostsResponse**](SfvbPageBlogPostsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
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


## RemoveSfvbPageItems

> SfvbPageItemsResponse RemoveSfvbPageItems (int storefrontOid, string path, SfvbPageItemsRemoveRequest pageItemsRemoveRequest)

Take items off a page

Removes items by item id, at most 500 at a time.  Every id must be on the page, and one that is not changes nothing.  The items themselves are not touched.  Refused on a page whose selectors choose its items.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /lp/spring-sale/ | 
 **pageItemsRemoveRequest** | [**SfvbPageItemsRemoveRequest**](SfvbPageItemsRemoveRequest.md)| Items to take off the page | 

### Return type

[**SfvbPageItemsResponse**](SfvbPageItemsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
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
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RevertSfvbContainer

> SfvbContainerResponse RevertSfvbContainer (int storefrontOid, string ownerType, string ownerObjectId, string ifMatch, SfvbContainerRevertRequest containerRevertRequest, string containerName = null)

Revert a container stored outside the file system

The restore is itself snapshotted, so a revert can be undone in turn.  Reverting to an entry recorded before the container existed removes it again.  Addressed through the owning container and guarded by If-Match, because a revert overwrites live content just as much as an ordinary write does.  owner_type also says how owner_object_id is read, so a version written by oid can be reverted by merchant item id and the other way round. 


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
| **412** |  |  -  |
| **428** |  |  -  |
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


## StartSfvbExperiment

> SfvbExperiment StartSfvbExperiment (int storefrontOid, SfvbExperimentStartRequest experimentStartRequest)

Start an experiment

type page starts an experiment element already saved in a page body - send path, slot and widget_id, and its name, objective, duration and variations are read from the element with the builder's rules (2 to 5 variations numbered 0 up with no gaps, 3 to 90 days, traffic on all or none adding up to 100).  The new id is written into the element and the body is saved, so pull it again before the next edit.  type url splits visitors between existing pages at router_url, and always ends by itself after duration_days.  Always needs sfvb_publish, because visitors are split as soon as it starts. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **experimentStartRequest** | [**SfvbExperimentStartRequest**](SfvbExperimentStartRequest.md)| The experiment to start | 

### Return type

[**SfvbExperiment**](SfvbExperiment.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **201** |  |  -  |
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
| **428** |  |  -  |
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

