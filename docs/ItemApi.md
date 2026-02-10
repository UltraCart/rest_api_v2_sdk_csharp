# com.ultracart.admin.v2.Api.ItemApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteDigitalItem**](ItemApi.md#deletedigitalitem) | **DELETE** /item/digital_library/{digital_item_oid} | Delete a digital item, which is a file within the digital library, not an actual merchant item
[**DeleteItem**](ItemApi.md#deleteitem) | **DELETE** /item/items/{merchant_item_oid} | Delete an item
[**DeleteReview**](ItemApi.md#deletereview) | **DELETE** /item/items/{merchant_item_oid}/reviews/{review_oid} | Delete a review
[**GetDigitalItem**](ItemApi.md#getdigitalitem) | **GET** /item/digital_library/{digital_item_oid} | Retrieve a digital item from the digital library, which are digital files that may be attached to normal items
[**GetDigitalItems**](ItemApi.md#getdigitalitems) | **GET** /item/digital_library | Retrieve digital items from the digital library which are digital files that may be attached to normal items
[**GetDigitalItemsByExternalId**](ItemApi.md#getdigitalitemsbyexternalid) | **GET** /item/digital_library/by_external/{external_id} | Retrieves digital items from the digital library (which are digital files that may be attached to normal items) that having a matching external id
[**GetInventorySnapshot**](ItemApi.md#getinventorysnapshot) | **GET** /item/items/inventory_snapshot | Retrieve a list of item inventories.  This method may be called once every 15 minutes.  More than that will result in a 429 response.
[**GetItem**](ItemApi.md#getitem) | **GET** /item/items/{merchant_item_oid} | Retrieve an item
[**GetItemByMerchantItemId**](ItemApi.md#getitembymerchantitemid) | **GET** /item/items/merchant_item_id/{merchant_item_id} | Retrieve an item by item id
[**GetItems**](ItemApi.md#getitems) | **GET** /item/items | Retrieve items
[**GetPricingTiers**](ItemApi.md#getpricingtiers) | **GET** /item/pricing_tiers | Retrieve pricing tiers
[**GetReview**](ItemApi.md#getreview) | **GET** /item/items/{merchant_item_oid}/reviews/{review_oid} | Get a review
[**GetReviews**](ItemApi.md#getreviews) | **GET** /item/items/{merchant_item_oid}/reviews | Get reviews for an item
[**GetUnassociatedDigitalItems**](ItemApi.md#getunassociateddigitalitems) | **GET** /item/digital_library/unassociated | Retrieve digital items from the digital library (which are digital files that may be attached to normal items) not yet associated with actual items
[**InsertDigitalItem**](ItemApi.md#insertdigitalitem) | **POST** /item/digital_library | Create a file within the digital library
[**InsertItem**](ItemApi.md#insertitem) | **POST** /item/items | Create an item
[**InsertReview**](ItemApi.md#insertreview) | **POST** /item/items/{merchant_item_oid}/reviews | Insert a review
[**InsertUpdateItemContentAttribute**](ItemApi.md#insertupdateitemcontentattribute) | **POST** /item/items/{merchant_item_oid}/content/attributes | Upsert an item content attribute
[**UpdateDigitalItem**](ItemApi.md#updatedigitalitem) | **PUT** /item/digital_library/{digital_item_oid} | Updates a file within the digital library
[**UpdateItem**](ItemApi.md#updateitem) | **PUT** /item/items/{merchant_item_oid} | Update an item
[**UpdateItems**](ItemApi.md#updateitems) | **PUT** /item/items/batch | Update multiple items
[**UpdateReview**](ItemApi.md#updatereview) | **PUT** /item/items/{merchant_item_oid}/reviews/{review_oid} | Update a review
[**UploadTemporaryMultimedia**](ItemApi.md#uploadtemporarymultimedia) | **POST** /item/temp_multimedia | Upload an image to the temporary multimedia.


<a name="deletedigitalitem"></a>
# **DeleteDigitalItem**
> void DeleteDigitalItem (int? digitalItemOid)

Delete a digital item, which is a file within the digital library, not an actual merchant item

Delete a digital item on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteDigitalItemExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var digitalItemOid = 56;  // int? | The digital item oid to delete.

            try
            {
                // Delete a digital item, which is a file within the digital library, not an actual merchant item
                apiInstance.DeleteDigitalItem(digitalItemOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.DeleteDigitalItem: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **digitalItemOid** | **int?**| The digital item oid to delete. | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitem"></a>
# **DeleteItem**
> void DeleteItem (int? merchantItemOid)

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
    public class DeleteItemExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var merchantItemOid = 56;  // int? | The item oid to delete.

            try
            {
                // Delete an item
                apiInstance.DeleteItem(merchantItemOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.DeleteItem: " + e.Message );
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

<a name="deletereview"></a>
# **DeleteReview**
> void DeleteReview (int? reviewOid, int? merchantItemOid)

Delete a review

Delete an item review. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteReviewExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var reviewOid = 56;  // int? | The review oid to delete.
            var merchantItemOid = 56;  // int? | The item oid the review is associated with.

            try
            {
                // Delete a review
                apiInstance.DeleteReview(reviewOid, merchantItemOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.DeleteReview: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reviewOid** | **int?**| The review oid to delete. | 
 **merchantItemOid** | **int?**| The item oid the review is associated with. | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdigitalitem"></a>
# **GetDigitalItem**
> ItemDigitalItemResponse GetDigitalItem (int? digitalItemOid)

Retrieve a digital item from the digital library, which are digital files that may be attached to normal items

Retrieves a digital item (file information) from the account.  Be aware that these are not normal items that can be added to a shopping cart. Rather, they are digital files that may be associated with normal items. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetDigitalItemExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var digitalItemOid = 56;  // int? | The digital item oid to retrieve.

            try
            {
                // Retrieve a digital item from the digital library, which are digital files that may be attached to normal items
                ItemDigitalItemResponse result = apiInstance.GetDigitalItem(digitalItemOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.GetDigitalItem: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **digitalItemOid** | **int?**| The digital item oid to retrieve. | 

### Return type

[**ItemDigitalItemResponse**](ItemDigitalItemResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdigitalitems"></a>
# **GetDigitalItems**
> ItemDigitalItemsResponse GetDigitalItems (int? limit = null, int? offset = null, string since = null, string sort = null, string expand = null, bool? placeholders = null)

Retrieve digital items from the digital library which are digital files that may be attached to normal items

Retrieves a group of digital items (file information) from the account.  If no parameters are specified, all digital items will be returned.  Be aware that these are not normal items that can be added to a shopping cart. Rather, they are digital files that may be associated with normal items.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetDigitalItemsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Default 100, Max 2000) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var since = since_example;  // string | Fetch items that have been created/modified since this date/time. (optional) 
            var sort = sort_example;  // string | The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 

            try
            {
                // Retrieve digital items from the digital library which are digital files that may be attached to normal items
                ItemDigitalItemsResponse result = apiInstance.GetDigitalItems(limit, offset, since, sort, expand, placeholders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.GetDigitalItems: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| The maximum number of records to return on this one API call. (Default 100, Max 2000) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **since** | **string**| Fetch items that have been created/modified since this date/time. | [optional] 
 **sort** | **string**| The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 
 **placeholders** | **bool?**| Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. | [optional] 

### Return type

[**ItemDigitalItemsResponse**](ItemDigitalItemsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdigitalitemsbyexternalid"></a>
# **GetDigitalItemsByExternalId**
> ItemDigitalItemsResponse GetDigitalItemsByExternalId (string externalId)

Retrieves digital items from the digital library (which are digital files that may be attached to normal items) that having a matching external id

Retrieves digital items from the digital library (which are digital files that may be attached to normal items) that having a matching external id.  Be aware that these are not normal items that can be added to a shopping cart. Rather, they are digital files that may be associated with normal items. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetDigitalItemsByExternalIdExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var externalId = externalId_example;  // string | The external id to match against.

            try
            {
                // Retrieves digital items from the digital library (which are digital files that may be attached to normal items) that having a matching external id
                ItemDigitalItemsResponse result = apiInstance.GetDigitalItemsByExternalId(externalId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.GetDigitalItemsByExternalId: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalId** | **string**| The external id to match against. | 

### Return type

[**ItemDigitalItemsResponse**](ItemDigitalItemsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventorysnapshot"></a>
# **GetInventorySnapshot**
> ItemInventorySnapshotResponse GetInventorySnapshot ()

Retrieve a list of item inventories.  This method may be called once every 15 minutes.  More than that will result in a 429 response.

Retrieve a list of item inventories.  This method may be called once every 15 minutes.  More than that will result in a 429 response. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetInventorySnapshotExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);


            try
            {
                // Retrieve a list of item inventories.  This method may be called once every 15 minutes.  More than that will result in a 429 response.
                ItemInventorySnapshotResponse result = apiInstance.GetInventorySnapshot();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.GetInventorySnapshot: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ItemInventorySnapshotResponse**](ItemInventorySnapshotResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitem"></a>
# **GetItem**
> ItemResponse GetItem (int? merchantItemOid, string expand = null, bool? placeholders = null)

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
    public class GetItemExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var merchantItemOid = 56;  // int? | The item oid to retrieve.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 

            try
            {
                // Retrieve an item
                ItemResponse result = apiInstance.GetItem(merchantItemOid, expand, placeholders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.GetItem: " + e.Message );
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

<a name="getitembymerchantitemid"></a>
# **GetItemByMerchantItemId**
> ItemResponse GetItemByMerchantItemId (string merchantItemId, string expand = null, bool? placeholders = null)

Retrieve an item by item id

Retrieves a single item using the specified item id. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetItemByMerchantItemIdExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var merchantItemId = merchantItemId_example;  // string | The item id to retrieve.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 

            try
            {
                // Retrieve an item by item id
                ItemResponse result = apiInstance.GetItemByMerchantItemId(merchantItemId, expand, placeholders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.GetItemByMerchantItemId: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantItemId** | **string**| The item id to retrieve. | 
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

<a name="getitems"></a>
# **GetItems**
> ItemsResponse GetItems (int? parentCategoryId = null, string parentCategoryPath = null, int? limit = null, int? offset = null, string since = null, string sort = null, string expand = null, bool? placeholders = null)

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
    public class GetItemsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

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
                ItemsResponse result = apiInstance.GetItems(parentCategoryId, parentCategoryPath, limit, offset, since, sort, expand, placeholders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.GetItems: " + e.Message );
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

<a name="getpricingtiers"></a>
# **GetPricingTiers**
> PricingTiersResponse GetPricingTiers (string expand = null)

Retrieve pricing tiers

Retrieves the pricing tiers 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPricingTiersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve pricing tiers
                PricingTiersResponse result = apiInstance.GetPricingTiers(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.GetPricingTiers: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**PricingTiersResponse**](PricingTiersResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreview"></a>
# **GetReview**
> ItemReviewResponse GetReview (int? reviewOid, int? merchantItemOid)

Get a review

Retrieve an item review. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetReviewExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var reviewOid = 56;  // int? | The review oid to retrieve.
            var merchantItemOid = 56;  // int? | The item oid the review is associated with.

            try
            {
                // Get a review
                ItemReviewResponse result = apiInstance.GetReview(reviewOid, merchantItemOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.GetReview: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reviewOid** | **int?**| The review oid to retrieve. | 
 **merchantItemOid** | **int?**| The item oid the review is associated with. | 

### Return type

[**ItemReviewResponse**](ItemReviewResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreviews"></a>
# **GetReviews**
> ItemReviewsResponse GetReviews (int? merchantItemOid)

Get reviews for an item

Retrieve item reviews. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetReviewsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var merchantItemOid = 56;  // int? | The item oid the review is associated with.

            try
            {
                // Get reviews for an item
                ItemReviewsResponse result = apiInstance.GetReviews(merchantItemOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.GetReviews: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantItemOid** | **int?**| The item oid the review is associated with. | 

### Return type

[**ItemReviewsResponse**](ItemReviewsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getunassociateddigitalitems"></a>
# **GetUnassociatedDigitalItems**
> ItemDigitalItemsResponse GetUnassociatedDigitalItems (int? limit = null, int? offset = null, string since = null, string sort = null, string expand = null, bool? placeholders = null)

Retrieve digital items from the digital library (which are digital files that may be attached to normal items) not yet associated with actual items

Retrieves a group of digital items (file information) from the account that are not yet associated with any actual items.  If no parameters are specified, all digital items will be returned.  Be aware that these are not normal items that can be added to a shopping cart. Rather, they are digital files that may be associated with normal items.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetUnassociatedDigitalItemsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Default 100, Max 2000) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var since = since_example;  // string | Fetch items that have been created/modified since this date/time. (optional) 
            var sort = sort_example;  // string | The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 

            try
            {
                // Retrieve digital items from the digital library (which are digital files that may be attached to normal items) not yet associated with actual items
                ItemDigitalItemsResponse result = apiInstance.GetUnassociatedDigitalItems(limit, offset, since, sort, expand, placeholders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.GetUnassociatedDigitalItems: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| The maximum number of records to return on this one API call. (Default 100, Max 2000) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **since** | **string**| Fetch items that have been created/modified since this date/time. | [optional] 
 **sort** | **string**| The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 
 **placeholders** | **bool?**| Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. | [optional] 

### Return type

[**ItemDigitalItemsResponse**](ItemDigitalItemsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertdigitalitem"></a>
# **InsertDigitalItem**
> ItemDigitalItemResponse InsertDigitalItem (ItemDigitalItem digitalItem)

Create a file within the digital library

Create a file within the digital library.  This does not create an item, but makes this digital file available and selectable as part (or all) of an item. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertDigitalItemExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var digitalItem = new ItemDigitalItem(); // ItemDigitalItem | Digital item to create

            try
            {
                // Create a file within the digital library
                ItemDigitalItemResponse result = apiInstance.InsertDigitalItem(digitalItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.InsertDigitalItem: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **digitalItem** | [**ItemDigitalItem**](ItemDigitalItem.md)| Digital item to create | 

### Return type

[**ItemDigitalItemResponse**](ItemDigitalItemResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertitem"></a>
# **InsertItem**
> ItemResponse InsertItem (Item item, string expand = null, bool? placeholders = null)

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
    public class InsertItemExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var item = new Item(); // Item | Item to create
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 

            try
            {
                // Create an item
                ItemResponse result = apiInstance.InsertItem(item, expand, placeholders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.InsertItem: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | [**Item**](Item.md)| Item to create | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 
 **placeholders** | **bool?**| Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. | [optional] 

### Return type

[**ItemResponse**](ItemResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertreview"></a>
# **InsertReview**
> ItemReviewResponse InsertReview (ItemReview review, int? merchantItemOid)

Insert a review

Insert a item review. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertReviewExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var review = new ItemReview(); // ItemReview | Review to insert
            var merchantItemOid = 56;  // int? | The item oid the review is associated with.

            try
            {
                // Insert a review
                ItemReviewResponse result = apiInstance.InsertReview(review, merchantItemOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.InsertReview: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **review** | [**ItemReview**](ItemReview.md)| Review to insert | 
 **merchantItemOid** | **int?**| The item oid the review is associated with. | 

### Return type

[**ItemReviewResponse**](ItemReviewResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertupdateitemcontentattribute"></a>
# **InsertUpdateItemContentAttribute**
> void InsertUpdateItemContentAttribute (ItemContentAttribute itemAttribute, int? merchantItemOid)

Upsert an item content attribute

Update an item content attribute, creating it new if it does not yet exist. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertUpdateItemContentAttributeExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var itemAttribute = new ItemContentAttribute(); // ItemContentAttribute | Item content attribute to upsert
            var merchantItemOid = 56;  // int? | The item oid to modify.

            try
            {
                // Upsert an item content attribute
                apiInstance.InsertUpdateItemContentAttribute(itemAttribute, merchantItemOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.InsertUpdateItemContentAttribute: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemAttribute** | [**ItemContentAttribute**](ItemContentAttribute.md)| Item content attribute to upsert | 
 **merchantItemOid** | **int?**| The item oid to modify. | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedigitalitem"></a>
# **UpdateDigitalItem**
> ItemDigitalItemResponse UpdateDigitalItem (int? digitalItemOid, ItemDigitalItem digitalItem)

Updates a file within the digital library

Updates a file within the digital library.  This does not update an item, but updates a digital file available and selectable as part (or all) of an item. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateDigitalItemExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var digitalItemOid = 56;  // int? | The digital item oid to update.
            var digitalItem = new ItemDigitalItem(); // ItemDigitalItem | Digital item to update

            try
            {
                // Updates a file within the digital library
                ItemDigitalItemResponse result = apiInstance.UpdateDigitalItem(digitalItemOid, digitalItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.UpdateDigitalItem: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **digitalItemOid** | **int?**| The digital item oid to update. | 
 **digitalItem** | [**ItemDigitalItem**](ItemDigitalItem.md)| Digital item to update | 

### Return type

[**ItemDigitalItemResponse**](ItemDigitalItemResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitem"></a>
# **UpdateItem**
> ItemResponse UpdateItem (Item item, int? merchantItemOid, string expand = null, bool? placeholders = null)

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
    public class UpdateItemExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var item = new Item(); // Item | Item to update
            var merchantItemOid = 56;  // int? | The item oid to update.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 

            try
            {
                // Update an item
                ItemResponse result = apiInstance.UpdateItem(item, merchantItemOid, expand, placeholders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.UpdateItem: " + e.Message );
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
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 
 **placeholders** | **bool?**| Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. | [optional] 

### Return type

[**ItemResponse**](ItemResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitems"></a>
# **UpdateItems**
> ItemsResponse UpdateItems (ItemsRequest itemsRequest, string expand = null, bool? placeholders = null, bool? async = null)

Update multiple items

Update multiple item on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateItemsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var itemsRequest = new ItemsRequest(); // ItemsRequest | Items to update (synchronous maximum 20 / asynchronous maximum 100)
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 
            var async = true;  // bool? | True if the operation should be run async.  No result returned (optional) 

            try
            {
                // Update multiple items
                ItemsResponse result = apiInstance.UpdateItems(itemsRequest, expand, placeholders, async);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.UpdateItems: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemsRequest** | [**ItemsRequest**](ItemsRequest.md)| Items to update (synchronous maximum 20 / asynchronous maximum 100) | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 
 **placeholders** | **bool?**| Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. | [optional] 
 **async** | **bool?**| True if the operation should be run async.  No result returned | [optional] 

### Return type

[**ItemsResponse**](ItemsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereview"></a>
# **UpdateReview**
> ItemReviewResponse UpdateReview (ItemReview review, int? reviewOid, int? merchantItemOid)

Update a review

Update an item review. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateReviewExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var review = new ItemReview(); // ItemReview | Review to update
            var reviewOid = 56;  // int? | The review oid to update.
            var merchantItemOid = 56;  // int? | The item oid the review is associated with.

            try
            {
                // Update a review
                ItemReviewResponse result = apiInstance.UpdateReview(review, reviewOid, merchantItemOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.UpdateReview: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **review** | [**ItemReview**](ItemReview.md)| Review to update | 
 **reviewOid** | **int?**| The review oid to update. | 
 **merchantItemOid** | **int?**| The item oid the review is associated with. | 

### Return type

[**ItemReviewResponse**](ItemReviewResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadtemporarymultimedia"></a>
# **UploadTemporaryMultimedia**
> TempMultimediaResponse UploadTemporaryMultimedia (System.IO.Stream _file)

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
    public class UploadTemporaryMultimediaExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ItemApi(simpleKey);

            var _file = new System.IO.Stream(); // System.IO.Stream | File to upload

            try
            {
                // Upload an image to the temporary multimedia.
                TempMultimediaResponse result = apiInstance.UploadTemporaryMultimedia(_file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.UploadTemporaryMultimedia: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_file** | **System.IO.Stream**| File to upload | 

### Return type

[**TempMultimediaResponse**](TempMultimediaResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

