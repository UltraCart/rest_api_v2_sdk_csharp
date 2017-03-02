# com.ultracart.admin.v2.Api.ItemApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ItemItemsGet**](ItemApi.md#itemitemsget) | **GET** /item/items | Retrieve items
[**ItemItemsMerchantItemOidDelete**](ItemApi.md#itemitemsmerchantitemoiddelete) | **DELETE** /item/items/{merchant_item_oid} | Delete an item
[**ItemItemsMerchantItemOidGet**](ItemApi.md#itemitemsmerchantitemoidget) | **GET** /item/items/{merchant_item_oid} | Retrieve an item
[**ItemItemsMerchantItemOidPut**](ItemApi.md#itemitemsmerchantitemoidput) | **PUT** /item/items/{merchant_item_oid} | Update an item
[**ItemItemsPost**](ItemApi.md#itemitemspost) | **POST** /item/items | Create an item
[**ItemTempMultimediaPost**](ItemApi.md#itemtempmultimediapost) | **POST** /item/temp_multimedia | Upload an image to the temporary multimedia.


<a name="itemitemsget"></a>
# **ItemItemsGet**
> ItemsResponse ItemItemsGet (int? parentCategoryId = null, string parentCategoryPath = null, int? limit = null, int? offset = null, string since = null, string sort = null, string expand = null, bool? placeholders = null)

Retrieve items

Retrieves a group of items from the account.  If no parameters are specified, all items will be returned.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ItemItemsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new ItemApi();
            var parentCategoryId = 56;  // int? | The parent category object id to retrieve items for.  Unspecified means all items on the account.  0 = root (optional) 
            var parentCategoryPath = parentCategoryPath_example;  // string | The parent category path to retrieve items for.  Unspecified means all items on the account.  / = root (optional) 
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Default 100, Max 2000) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var since = since_example;  // string | Fetch items that have been created/modified since this date/time. (optional) 
            var sort = sort_example;  // string | The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 

            try
            {
                // Retrieve items
                ItemsResponse result = apiInstance.ItemItemsGet(parentCategoryId, parentCategoryPath, limit, offset, since, sort, expand, placeholders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.ItemItemsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentCategoryId** | **int?**| The parent category object id to retrieve items for.  Unspecified means all items on the account.  0 &#x3D; root | [optional] 
 **parentCategoryPath** | **string**| The parent category path to retrieve items for.  Unspecified means all items on the account.  / &#x3D; root | [optional] 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Default 100, Max 2000) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **since** | **string**| Fetch items that have been created/modified since this date/time. | [optional] 
 **sort** | **string**| The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 
 **placeholders** | **bool?**| Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. | [optional] 

### Return type

[**ItemsResponse**](ItemsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemitemsmerchantitemoiddelete"></a>
# **ItemItemsMerchantItemOidDelete**
> void ItemItemsMerchantItemOidDelete (int? merchantItemOid)

Delete an item

Delete an item on the UltraCart account. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ItemItemsMerchantItemOidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new ItemApi();
            var merchantItemOid = 56;  // int? | The item oid to delete.

            try
            {
                // Delete an item
                apiInstance.ItemItemsMerchantItemOidDelete(merchantItemOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.ItemItemsMerchantItemOidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantItemOid** | **int?**| The item oid to delete. | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemitemsmerchantitemoidget"></a>
# **ItemItemsMerchantItemOidGet**
> ItemResponse ItemItemsMerchantItemOidGet (int? merchantItemOid, string expand = null, bool? placeholders = null)

Retrieve an item

Retrieves a single item using the specified item oid. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ItemItemsMerchantItemOidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new ItemApi();
            var merchantItemOid = 56;  // int? | The item oid to retrieve.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 

            try
            {
                // Retrieve an item
                ItemResponse result = apiInstance.ItemItemsMerchantItemOidGet(merchantItemOid, expand, placeholders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.ItemItemsMerchantItemOidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantItemOid** | **int?**| The item oid to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 
 **placeholders** | **bool?**| Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. | [optional] 

### Return type

[**ItemResponse**](ItemResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemitemsmerchantitemoidput"></a>
# **ItemItemsMerchantItemOidPut**
> ItemResponse ItemItemsMerchantItemOidPut (Item item, int? merchantItemOid)

Update an item

Update a new item on the UltraCart account. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ItemItemsMerchantItemOidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new ItemApi();
            var item = new Item(); // Item | Item to update
            var merchantItemOid = 56;  // int? | The item oid to update.

            try
            {
                // Update an item
                ItemResponse result = apiInstance.ItemItemsMerchantItemOidPut(item, merchantItemOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.ItemItemsMerchantItemOidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | [**Item**](Item.md)| Item to update | 
 **merchantItemOid** | **int?**| The item oid to update. | 

### Return type

[**ItemResponse**](ItemResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemitemspost"></a>
# **ItemItemsPost**
> ItemResponse ItemItemsPost (Item item)

Create an item

Create a new item on the UltraCart account. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ItemItemsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new ItemApi();
            var item = new Item(); // Item | Item to create

            try
            {
                // Create an item
                ItemResponse result = apiInstance.ItemItemsPost(item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.ItemItemsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | [**Item**](Item.md)| Item to create | 

### Return type

[**ItemResponse**](ItemResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemtempmultimediapost"></a>
# **ItemTempMultimediaPost**
> TempMultimediaResponse ItemTempMultimediaPost (System.IO.Stream file)

Upload an image to the temporary multimedia.

Uploads an image and returns back meta information about the image as well as the identifier needed for the item update. 

### Example
```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ItemTempMultimediaPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new ItemApi();
            var file = new System.IO.Stream(); // System.IO.Stream | File to upload

            try
            {
                // Upload an image to the temporary multimedia.
                TempMultimediaResponse result = apiInstance.ItemTempMultimediaPost(file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.ItemTempMultimediaPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to upload | 

### Return type

[**TempMultimediaResponse**](TempMultimediaResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

