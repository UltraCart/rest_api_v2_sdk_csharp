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



## DeleteDigitalItem

> void DeleteDigitalItem (int digitalItemOid)

Delete a digital item, which is a file within the digital library, not an actual merchant item

Delete a digital item on the UltraCart account. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using SdkSample.item;

namespace SdkSample.item
{
    public class DeleteDigitalItem
    {
        public static void Execute()
        {
            try
            {
                int digitalItemOid = ItemFunctions.InsertSampleDigitalItem();
                ItemFunctions.DeleteSampleDigitalItem(digitalItemOid);
            }
            catch (Exception e)
            {
                Console.WriteLine("An Exception occurred. Please review the following error:");
                Console.WriteLine(e); // <-- change_me: handle gracefully
                Environment.Exit(1);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **digitalItemOid** | **int**| The digital item oid to delete. | 

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
| **204** | No Content |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteItem

> void DeleteItem (int merchantItemOid)

Delete an item

Delete an item on the UltraCart account. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using SdkSample.item;

namespace SdkSample.item
{
    public class DeleteItem
    {
        public static void Execute()
        {
            try
            {
                int itemOid = ItemFunctions.InsertSampleItemAndGetOid();
                ItemFunctions.DeleteSampleItemByOid(itemOid);
            }
            catch (Exception e)
            {
                Console.WriteLine("An Exception occurred. Please review the following error:");
                Console.WriteLine(e); // <-- change_me: handle gracefully
                Environment.Exit(1);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantItemOid** | **int**| The item oid to delete. | 

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
| **204** | No Content |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteReview

> void DeleteReview (int reviewOid, int merchantItemOid)

Delete a review

Delete an item review. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using SdkSample.item;

namespace SdkSample.item
{
    public class DeleteReview
    {
        /*
            Deletes a specific user review for an item. This would most likely be used by a merchant who has cached all
            reviews on a separate site and then wishes to remove a particular review.

            The merchant_item_oid is a unique identifier used by UltraCart. If you do not know your item's oid, call
            ItemApi.GetItemByMerchantItemId() to retrieve the item, and then it's oid item.MerchantItemOid

            The review_oid is a unique identifier used by UltraCart. If you do not know a review's oid, call
            ItemApi.GetReviews() to get all reviews where you can then grab the oid from an item.

            Success returns back a status code of 204 (No Content)
         */
        public static void Execute()
        {
            ItemApi itemApi = new ItemApi(Constants.ApiKey);
            int merchantItemOid = 123456;
            int reviewOid = 987654;
            itemApi.DeleteReview(reviewOid, merchantItemOid);
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reviewOid** | **int**| The review oid to delete. | 
 **merchantItemOid** | **int**| The item oid the review is associated with. | 

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
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDigitalItem

> ItemDigitalItemResponse GetDigitalItem (int digitalItemOid)

Retrieve a digital item from the digital library, which are digital files that may be attached to normal items

Retrieves a digital item (file information) from the account.  Be aware that these are not normal items that can be added to a shopping cart. Rather, they are digital files that may be associated with normal items. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using SdkSample.item;

namespace SdkSample.item
{
    public class GetDigitalItem
    {
        public static void Execute()
        {
            try
            {
                /*
                 * Please Note!
                 * Digital Items are not normal items you sell on your site. They are digital files that you may add to
                 * a library and then attach to a normal item as an accessory or the main item itself.
                 * See: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1376485/Digital+Items
                 */

                int digitalItemOid = ItemFunctions.InsertSampleDigitalItem(); // create an item so I can get an item
                ItemApi itemApi = Samples.GetItemApi();
                ItemDigitalItemResponse apiResponse = itemApi.GetDigitalItem(digitalItemOid);
                ItemDigitalItem digitalItem = apiResponse.DigitalItem; // assuming this succeeded

                Console.WriteLine("The following item was retrieved via GetDigitalItem():");
                Console.WriteLine(digitalItem);

                ItemFunctions.DeleteSampleDigitalItem(digitalItemOid);
            }
            catch (Exception e)
            {
                Console.WriteLine("An Exception occurred. Please review the following error:");
                Console.WriteLine(e); // <-- change_me: handle gracefully
                Environment.Exit(1);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **digitalItemOid** | **int**| The digital item oid to retrieve. | 

### Return type

[**ItemDigitalItemResponse**](ItemDigitalItemResponse.md)

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
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDigitalItems

> ItemDigitalItemsResponse GetDigitalItems (int? limit = null, int? offset = null, string since = null, string sort = null, string expand = null, bool? placeholders = null)

Retrieve digital items from the digital library which are digital files that may be attached to normal items

Retrieves a group of digital items (file information) from the account.  If no parameters are specified, all digital items will be returned.  Be aware that these are not normal items that can be added to a shopping cart. Rather, they are digital files that may be associated with normal items.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using SdkSample.item;

namespace SdkSample.item
{
    public class GetDigitalItems
    {
        public static void Execute()
        {
            try
            {
                /*
                 * Please Note!
                 * Digital Items are not normal items you sell on your site. They are digital files that you may add to
                 * a library and then attach to a normal item as an accessory or the main item itself.
                 * See: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1376485/Digital+Items
                 */

                int digitalItemOid = ItemFunctions.InsertSampleDigitalItem(); // create an item so I can get an item
                ItemApi itemApi = Samples.GetItemApi();

                int limit = 100;
                int offset = 0;
                string since = null; // digital items do not use since. leave as null.
                string sort = null; // if null, use default of original_filename
                string expand = null; // digital items have no expansion. leave as null. this value is ignored
                bool? placeholders = null; // digital items have no placeholders. leave as null.

                ItemDigitalItemsResponse apiResponse = itemApi.GetDigitalItems(limit, offset, since, sort, expand, placeholders);
                List<ItemDigitalItem> digitalItems = apiResponse.DigitalItems; // assuming this succeeded

                Console.WriteLine("The following items were retrieved via GetDigitalItems():");
                foreach (ItemDigitalItem digitalItem in digitalItems)
                {
                    Console.WriteLine(digitalItem);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An Exception occurred. Please review the following error:");
                Console.WriteLine(e); // <-- change_me: handle gracefully
                Environment.Exit(1);
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


## GetDigitalItemsByExternalId

> ItemDigitalItemsResponse GetDigitalItemsByExternalId (string externalId)

Retrieves digital items from the digital library (which are digital files that may be attached to normal items) that having a matching external id

Retrieves digital items from the digital library (which are digital files that may be attached to normal items) that having a matching external id.  Be aware that these are not normal items that can be added to a shopping cart. Rather, they are digital files that may be associated with normal items. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using SdkSample.item;

namespace SdkSample.item
{
    public class GetDigitalItemsByExternalId
    {
        public static void Execute()
        {
            try
            {
                /*
                 * Please Note!
                 * Digital Items are not normal items you sell on your site. They are digital files that you may add to
                 * a library and then attach to a normal item as an accessory or the main item itself.
                 * See: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1376485/Digital+Items
                 */

                string externalId = Guid.NewGuid().ToString("N");
                Console.WriteLine("My external id is " + externalId);
                int digitalItemOid = ItemFunctions.InsertSampleDigitalItem(externalId); // create digital item with a specific external id I can later use.
                ItemApi itemApi = Samples.GetItemApi();
                ItemDigitalItemsResponse apiResponse = itemApi.GetDigitalItemsByExternalId(externalId);
                List<ItemDigitalItem> digitalItems = apiResponse.DigitalItems; // assuming this succeeded

                Console.WriteLine("The following item was retrieved via GetDigitalItem():");
                Console.WriteLine(digitalItems);

                ItemFunctions.DeleteSampleDigitalItem(digitalItemOid);
            }
            catch (Exception e)
            {
                Console.WriteLine("An Exception occurred. Please review the following error:");
                Console.WriteLine(e); // <-- change_me: handle gracefully
                Environment.Exit(1);
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


## GetInventorySnapshot

> ItemInventorySnapshotResponse GetInventorySnapshot ()

Retrieve a list of item inventories.  This method may be called once every 15 minutes.  More than that will result in a 429 response.

Retrieve a list of item inventories.  This method may be called once every 15 minutes.  More than that will result in a 429 response. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using Newtonsoft.Json;

namespace SdkSample.item
{
    public class GetInventorySnapshot
    {
        public static void Execute()
        {
            try
            {

                // Retrieve a list of item inventories.
                // This method may be called once every 15 minutes.  More than that will result in a 429 response.
                ItemApi itemApi = Samples.GetItemApi();
                ItemInventorySnapshotResponse snapshotResponse = itemApi.GetInventorySnapshot();
                foreach (ItemInventorySnapshot inventory in snapshotResponse.Inventories)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(inventory, new JsonSerializerSettings { Formatting = Formatting.Indented}));                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An Exception occurred. Please review the following error:");
                Console.WriteLine(e); // <-- change_me: handle gracefully
                Environment.Exit(1);
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


## GetItem

> ItemResponse GetItem (int merchantItemOid, string expand = null, bool? placeholders = null)

Retrieve an item

Retrieves a single item using the specified item oid. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.item
{
    public class GetItem
    {

        /// <summary>
        /// Execute the item retrieval example
        /// </summary>
        public static void Execute()
        {
            // Of the two getItem methods, you'll probably always use getItemByMerchantItemId instead of this one.
            // Most item work is done with the item id, not the item oid. The latter is only meaningful as a primary
            // key in the UltraCart databases. But here is an example of using getItem(). We take the long route here
            // of retrieving the item using getItemByMerchantItemId to obtain the oid rather than hard-coding it. We do this
            // because these samples are used in our quality control system and run repeatedly.

            try
            {
                
                ItemApi itemApi = new ItemApi(Constants.ApiKey);
                int itemOid = ItemFunctions.InsertSampleItemAndGetOid();
                CustomerApi customerApi = new CustomerApi(Constants.ApiKey); // only needed for accessing reviewer information below.

                // Yes, I'm creating an item, getting that item in order to get the item id, then getting the item yet again
                // using a different method. All to illustrate GetItemByMerchantItemId
                string itemId = itemApi.GetItem(itemOid).Item.MerchantItemId;
                
                
                // the expand variable is null in the following call. we just need the base object this time.
                ItemResponse apiResponse = itemApi.GetItemByMerchantItemId(itemId, null, false);
                Item item = apiResponse.Item; // assuming this succeeded

                int merchantItemOid = item.MerchantItemOid;

                // This is the actual call for this script.
                // The real devil in the getItem calls is the expansion, making sure you return everything you need without
                // returning everything since these objects are extremely large.
                // These are the possible expansion values.
                /*
                    accounting
                    amember
                    auto_order
                    auto_order.steps
                    ccbill
                    channel_partner_mappings
                    chargeback
                    checkout
                    content
                    content.assignments
                    content.attributes
                    content.multimedia
                    content.multimedia.thumbnails
                    digital_delivery
                    ebay
                    email_notifications
                    enrollment123
                    gift_certificate
                    google_product_search
                    kit_definition
                    identifiers
                    instant_payment_notifications
                    internal
                    options
                    payment_processing
                    physical
                    pricing
                    pricing.tiers
                    realtime_pricing
                    related
                    reporting
                    restriction
                    reviews
                    reviews.individual_reviews
                    salesforce
                    shipping
                    shipping.cases
                    shipping.destination_markups
                    shipping.destination_restrictions
                    shipping.distribution_centers
                    shipping.methods
                    shipping.package_requirements
                    tax
                    third_party_email_marketing
                    variations
                    wishlist_member
                */
                // string expand = "kit_definition,options,shipping,tax,variations"; // just some random ones. contact us if you're unsure
                string expand = "reviews,reviews.individual_reviews";  // changed the random above to reviews to illustrate accessing product reviews.
                apiResponse = itemApi.GetItem(merchantItemOid, expand, false);
                item = apiResponse.Item;

                ItemReviews itemReviews = item.Reviews;
                List<ItemReview> individualReviews = itemReviews.IndividualReviews;
                
                // do whatever you wish with the reviews. iterate them, print them, etc.
                // if you need the reviewer information
                foreach (ItemReview individualReview in individualReviews)
                {
                    // if you need reviewer profile questions, such as "How often do you use this product?", access the
                    // rating names and scores. these are configurable by merchant, so we do not know what your questions may be.
                    // See Home -> Configuration -> Items -> Reviews -> Settings
                    // Or this URL: https://secure.ultracart.com/merchant/item/review/reviewSettingsLoad.do
                    string ratingName1 = individualReview.RatingName1; // <-- this will not be the full question, but a key string.
                    decimal ratingScore1 = individualReview.RatingScore1;

                    // if you need the review information, access that via their customer object. Be careful. This can result
                    // in a LOT of API calls and exhaust your limit. You may wish to add 'Sleep' calls to your loop and cache
                    // these results daily or weekly.
                    CustomerResponse customerResponse = customerApi.GetCustomer(individualReview.CustomerProfileOid, "reviewer");
                    Customer customer = customerResponse.Customer;
                    CustomerReviewer reviewer = customer.Reviewer;
                }

                Console.WriteLine("The following item was retrieved via getItem():");
                Console.WriteLine(item.ToString());

                ItemFunctions.DeleteSampleItemByOid(itemOid);
            }
            catch (com.ultracart.admin.v2.Client.ApiException e)
            {
                Console.WriteLine("An ApiException occurred. Please review the following error:");
                Console.WriteLine(e.ToString()); // <-- change_me: handle gracefully
                Environment.Exit(1);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantItemOid** | **int**| The item oid to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 
 **placeholders** | **bool?**| Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. | [optional] 

### Return type

[**ItemResponse**](ItemResponse.md)

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
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetItemByMerchantItemId

> ItemResponse GetItemByMerchantItemId (string merchantItemId, string expand = null, bool? placeholders = null)

Retrieve an item by item id

Retrieves a single item using the specified item id. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.item
{
    public class GetItemByMerchantItemId
    {
        /// <summary>
        /// Execute the item retrieval example
        /// </summary>
        public static void Execute()
        {
            // Of the two getItem methods, you'll probably always use getItemByMerchantItemId instead of this one.
            // Most item work is done with the item id, not the item oid. The latter is only meaningful as a primary
            // key in the UltraCart databases. But here is an example of using getItem(). We take the long route here
            // of retrieving the item using getItemByMerchantItemId to obtain the oid rather than hard-coding it. We do this
            // because these samples are used in our quality control system and run repeatedly.

            try
            {
                string itemId = ItemFunctions.InsertSampleItem();

                ItemApi itemApi = new ItemApi(Constants.ApiKey);

                // The real devil in the getItem calls is the expansion, making sure you return everything you need without
                // returning everything since these objects are extremely large.
                // These are the possible expansion values.
                /*
                    accounting
                    amember
                    auto_order
                    auto_order.steps
                    ccbill
                    channel_partner_mappings
                    chargeback
                    checkout
                    content
                    content.assignments
                    content.attributes
                    content.multimedia
                    content.multimedia.thumbnails
                    digital_delivery
                    ebay
                    email_notifications
                    enrollment123
                    gift_certificate
                    google_product_search
                    kit_definition
                    identifiers
                    instant_payment_notifications
                    internal
                    options
                    payment_processing
                    physical
                    pricing
                    pricing.tiers
                    realtime_pricing
                    related
                    reporting
                    restriction
                    reviews
                    salesforce
                    shipping
                    shipping.cases
                    shipping.destination_markups
                    shipping.destination_restrictions
                    shipping.distribution_centers
                    shipping.methods
                    shipping.package_requirements
                    tax
                    third_party_email_marketing
                    variations
                    wishlist_member
                */
                string expand = "kit_definition,options,shipping,tax,variations"; // just some random ones. contact us if you're unsure
                ItemResponse apiResponse = itemApi.GetItemByMerchantItemId(itemId, expand, false);
                Item item = apiResponse.Item;

                Console.WriteLine("The following item was retrieved via getItemByMerchantItemId():");
                Console.WriteLine(item.ToString());

                ItemFunctions.DeleteSampleItem(itemId);
            }
            catch (com.ultracart.admin.v2.Client.ApiException e)
            {
                Console.WriteLine("An ApiException occurred. Please review the following error:");
                Console.WriteLine(e.ToString()); // <-- change_me: handle gracefully
                Environment.Exit(1);
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


## GetItems

> ItemsResponse GetItems (int? parentCategoryId = null, string parentCategoryPath = null, int? limit = null, int? offset = null, string since = null, string sort = null, string expand = null, bool? placeholders = null)

Retrieve items

Retrieves a group of items from the account.  If no parameters are specified, all items will be returned.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.item
{
    public class GetItems
    {
        /// <summary>
        /// Execute the item retrieval example
        /// </summary>
        public static void Execute()
        {
            /*
             * This example illustrates how to retrieve items. When dealing with items, please note that categories are
             * essentially folders to organize and store items. They are only used for that purpose and play no role in
             * the checkout process or in the storefront display of items. So you may organize your items as best serves
             * you. We're often asked why was use the word 'category' instead of 'folder'. We started down the road of
             * item management 27 years ago with the word 'category', and it's too much trouble to change. So items are
             * managed by categories, not folders. But they are folders. :)
             * The call takes two possible parameters:
             * 1) parentCategoryId: This is a number which uniquely identifies a category in our system. Not easy to determine.
             * 2) parentCategoryPath: This is the folder path you wish to retrieve, starting with a forward slash "/"
             * If you provide neither of these values, all items are returned.
             */

            // Increase timeout for long-running operation
            // Note: In C# we don't need to explicitly set execution time limits like in PHP

            ItemApi itemApi = new ItemApi(Constants.ApiKey);
            
            List<Item> items = new List<Item>();
            
            int iteration = 1;
            int offset = 0;
            int limit = 200;
            bool moreRecordsToFetch = true;
            
            try
            {
                while (moreRecordsToFetch)
                {
                    Console.WriteLine($"executing iteration {iteration}");
                    
                    List<Item> chunkOfItems = GetItemChunk(itemApi, offset, limit);
                    items = items.Concat(chunkOfItems).ToList();
                    offset += limit;
                    moreRecordsToFetch = chunkOfItems.Count == limit;
                    iteration++;
                }
            }
            catch (com.ultracart.admin.v2.Client.ApiException e)
            {
                Console.WriteLine($"ApiException occurred on iteration {iteration}");
                Console.WriteLine(e.ToString());
                Environment.Exit(1);
            }
            
            // this will be verbose...
            foreach (Item item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
        
        /// <summary>
        /// Get a chunk of items from the API
        /// </summary>
        /// <param name="itemApi">ItemApi instance</param>
        /// <param name="offset">Starting offset for retrieval</param>
        /// <param name="limit">Maximum number of records to retrieve</param>
        /// <returns>List of retrieved items</returns>
        private static List<Item> GetItemChunk(ItemApi itemApi, int offset, int limit)
        {
            // The real devil in the getItem calls is the expansion, making sure you return everything you need without
            // returning everything since these objects are extremely large.
            // These are the possible expansion values.
            /*
            accounting                      amember                     auto_order                      auto_order.steps
            ccbill                          channel_partner_mappings    chargeback                      checkout
            content                         content.assignments         content.attributes              content.multimedia
            content.multimedia.thumbnails   digital_delivery            ebay                            email_notifications
            enrollment123                   gift_certificate            google_product_search           kit_definition
            identifiers                     instant_payment_notifications   internal                    options
            payment_processing              physical                    pricing                         pricing.tiers
            realtime_pricing                related                     reporting                       restriction
            reviews                         salesforce                  shipping                        shipping.cases
            tax                             third_party_email_marketing variations                      wishlist_member
            shipping.destination_markups
            shipping.destination_restrictions
            shipping.distribution_centers
            shipping.methods
            shipping.package_requirements
            */
            string expand = "kit_definition,options,shipping,tax,variations"; // just some random ones. contact us if you're unsure
            
            int? parentCategoryId = null;
            string parentCategoryPath = null;
            string since = null;
            string sort = null;
            
            ItemsResponse apiResponse = itemApi.GetItems(parentCategoryId, parentCategoryPath, limit, offset, since,
                sort, expand, false);
            
            if (apiResponse.Items != null)
            {
                return apiResponse.Items;
            }
            
            return new List<Item>();
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


## GetPricingTiers

> PricingTiersResponse GetPricingTiers (string expand = null)

Retrieve pricing tiers

Retrieves the pricing tiers 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.item
{
    public class GetPricingTiers
    {
        /// <summary>
        /// Execute method containing all business logic
        /// </summary>
        public static void Execute()
        {
            ItemApi itemApi = new ItemApi(Constants.ApiKey);

            try
            {
                /*
                 * Possible expansion values for PricingTier object:
                 * approval_notification
                 * signup_notification
                 */

                string expand = "approval_notification,signup_notification";
                PricingTiersResponse apiResponse = itemApi.GetPricingTiers(expand);

                // Display pricing tiers
                foreach (PricingTier pricingTier in apiResponse.PricingTiers)
                {
                    Console.WriteLine(pricingTier);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurred.");
                Console.WriteLine(e);
                Environment.Exit(1);
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


## GetReview

> ItemReviewResponse GetReview (int reviewOid, int merchantItemOid)

Get a review

Retrieve an item review. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.item
{
    public class GetReview
    {
        /// <summary>
        /// Execute method containing all business logic
        /// </summary>
        public static void Execute()
        {
            /*
             * Retrieves a specific user review for an item. This would most likely be used by a merchant who has cached all
             * reviews on a separate site and then wishes to update a particular review. It's always best to "get" the object,
             * make changes to it, then call the update instead of trying to recreate the object from scratch.
             *
             * The merchant_item_oid is a unique identifier used by UltraCart. If you do not know your item's oid, call
             * ItemApi.GetItemByMerchantItemId() to retrieve the item, and then it's oid item.MerchantItemOid
             *
             * The review_oid is a unique identifier used by UltraCart. If you do not know a review's oid, call
             * ItemApi.GetReviews() to get all reviews where you can then grab the oid from an item.
             */

            ItemApi itemApi = new ItemApi(Constants.ApiKey);
            int merchantItemOid = 123456;
            int reviewOid = 987654;
            ItemReviewResponse apiResponse = itemApi.GetReview(reviewOid, merchantItemOid);

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                Environment.Exit(1);
            }

            ItemReview review = apiResponse.Review;
            
            Console.WriteLine("<html lang=\"en\"><body><pre>");
            Console.WriteLine(review.ToString());
            Console.WriteLine("</pre></body></html>");
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reviewOid** | **int**| The review oid to retrieve. | 
 **merchantItemOid** | **int**| The item oid the review is associated with. | 

### Return type

[**ItemReviewResponse**](ItemReviewResponse.md)

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
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetReviews

> ItemReviewsResponse GetReviews (int merchantItemOid)

Get reviews for an item

Retrieve item reviews. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using System.Collections.Generic;

namespace SdkSample.item
{
    public class GetReviews
    {
        /// <summary>
        /// Execute method containing all business logic
        /// </summary>
        public static void Execute()
        {
            /*
             * Retrieves all user reviews for an item.
             *
             * The merchant_item_oid is a unique identifier used by UltraCart. If you do not know your item's oid, call
             * ItemApi.GetItemByMerchantItemId() to retrieve the item, and then it's oid item.MerchantItemOid
             */

            ItemApi itemApi = new ItemApi(Constants.ApiKey);
            int merchantItemOid = 123456;
            ItemReviewsResponse apiResponse = itemApi.GetReviews(merchantItemOid);

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                Environment.Exit(1);
            }

            List<ItemReview> reviews = apiResponse.Reviews;
            
            foreach (ItemReview review in reviews)
            {
                Console.WriteLine(review.ToString());
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantItemOid** | **int**| The item oid the review is associated with. | 

### Return type

[**ItemReviewsResponse**](ItemReviewsResponse.md)

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
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetUnassociatedDigitalItems

> ItemDigitalItemsResponse GetUnassociatedDigitalItems (int? limit = null, int? offset = null, string since = null, string sort = null, string expand = null, bool? placeholders = null)

Retrieve digital items from the digital library (which are digital files that may be attached to normal items) not yet associated with actual items

Retrieves a group of digital items (file information) from the account that are not yet associated with any actual items.  If no parameters are specified, all digital items will be returned.  Be aware that these are not normal items that can be added to a shopping cart. Rather, they are digital files that may be associated with normal items.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.item
{
    public class GetUnassociatedDigitalItems
    {
        /// <summary>
        /// Execute method containing all business logic
        /// </summary>
        public static void Execute()
        {
            try
            {
                /*
                 * Please Note!
                 * Digital Items are not normal items you sell on your site. They are digital files that you may add to
                 * a library and then attach to a normal item as an accessory or the main item itself.
                 * See: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1376485/Digital+Items
                 * 
                 * Retrieves a group of digital items (file information) from the account that are not yet associated with any
                 * actual items. If no parameters are specified, all digital items will be returned. Be aware that these are
                 * not normal items that can be added to a shopping cart. Rather, they are digital files that may be associated
                 * with normal items. You will need to make multiple API calls in order to retrieve the entire result set since
                 * this API performs result set pagination.
                 * 
                 * Default sort order: original_filename
                 * Possible sort orders: original_filename, description, file_size
                 */

                int digitalItemOid = ItemFunctions.InsertSampleDigitalItem(); // create an item that will be unassociated.
                ItemApi itemApi = new ItemApi(Constants.ApiKey);

                int limit = 100;
                int offset = 0;
                string since = null; // digital items do not use since. leave as null.
                string sort = null; // if null, use default of original_filename
                string expand = null; // digital items have no expansion. leave as null. this value is ignored
                bool? placeholders = null; // digital items have no placeholders. leave as null.

                ItemDigitalItemsResponse apiResponse = itemApi.GetUnassociatedDigitalItems(limit, offset, since, sort, expand, placeholders);
                List<ItemDigitalItem> digitalItems = apiResponse.DigitalItems; // assuming this succeeded

                Console.WriteLine("The following items were retrieved via GetUnassociatedDigitalItems():");
                foreach (ItemDigitalItem digitalItem in digitalItems)
                {
                    Console.WriteLine(digitalItem.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An Exception occurred. Please review the following error:");
                Console.WriteLine(e.ToString()); // <-- change_me: handle gracefully
                Environment.Exit(1);
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


## InsertDigitalItem

> ItemDigitalItemResponse InsertDigitalItem (ItemDigitalItem digitalItem)

Create a file within the digital library

Create a file within the digital library.  This does not create an item, but makes this digital file available and selectable as part (or all) of an item. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.item
{
    public class InsertDigitalItem
    {
        /// <summary>
        /// Execute method containing all business logic
        /// </summary>
        public static void Execute()
        {
            try
            {
                int digitalItemOid = ItemFunctions.InsertSampleDigitalItem();
                ItemFunctions.DeleteSampleDigitalItem(digitalItemOid);
            }
            catch (Exception e)
            {
                Console.WriteLine("An Exception occurred. Please review the following error:");
                Console.WriteLine(e.ToString()); // <-- change_me: handle gracefully
                Environment.Exit(1);
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


## InsertItem

> ItemResponse InsertItem (Item item, string expand = null, bool? placeholders = null)

Create an item

Create a new item on the UltraCart account. 


### Example

```csharp
using System;


namespace SdkSample.item
{
    public class InsertItem
    {
        public static void Execute()
        {
            try
            {
                string itemId = ItemFunctions.InsertSampleItem();
                ItemFunctions.DeleteSampleItem(itemId);
            }
            catch (Exception e)
            {
                Console.WriteLine("An Exception occurred. Please review the following error:");
                Console.WriteLine(e.ToString()); // handle gracefully
                Environment.Exit(1);
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


## InsertReview

> ItemReviewResponse InsertReview (int merchantItemOid, ItemReview review)

Insert a review

Insert a item review. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.item
{
    /// <summary>
    /// Sample code for inserting a product review
    /// </summary>
    public class InsertReview
    {
        public static void Execute()
        {
            try
            {
                // To insert a review, you'll need an item's OID (Object Identifier) first. So for this example, we create
                // a sample item first, then retrieve it by item id to fetch the item oid.
                
                Console.WriteLine("<pre>");
                string itemId = ItemFunctions.InsertSampleItem();
                Console.WriteLine("</pre>");
                ItemApi itemApi = Samples.GetItemApi(); // convenience function for getting an api handle.

                string expand = "reviews"; // expand string is 'reviews' because we'll need to update the sample item's review template below.
                // list of expansions for item object: https://www.ultracart.com/api/#resource_item.html

                ItemResponse itemResponse = itemApi.GetItemByMerchantItemId(itemId, expand, null);
                Item item = itemResponse.Item;
                int itemOid = item.MerchantItemOid;

                // The target item must have a review template associated before you may attach a review.
                // You may create a review template here:
                // https://secure.ultracart.com/merchant/item/review/reviewTemplateListLoad.do
                // We're using a review template from our development system and it will not work for you.
                // Once you have a review template, update your item either via our gui or the rest api.
                // GUI: secure.ultracart.com -> Home -> Items -> <your item> -> Edit -> Review tab
                // Since we're using a sample item we just created above (line 17), we'll update via the rest api.
                // The rest api requires the review template oid, which is found on the template screen (url on line 25 above)

                int reviewTemplateOid = 402;
                ItemReviews reviews = new ItemReviews();
                reviews.ReviewTemplateOid = reviewTemplateOid;
                item.Reviews = reviews;
                item = itemApi.UpdateItem(itemOid, item, expand, null).Item;

                // You will need to know what your product review looks like.
                ItemReview review = new ItemReview();
                review.Title = "Best Product Ever!";
                review.Review = "I loved this product. I bought it for my wife and she was so happy she cried. blah blah blah";
                review.ReviewedNickname = "Bob420";
                review.Featured = true; // featured? sure. why not? this is a great review.
                review.RatingName1 = "Durability";
                review.RatingName2 = "Price";
                review.RatingName3 = "Performance";
                review.RatingName4 = "Appearance";
                review.RatingScore1 = 4.5m;
                review.RatingScore2 = 3.5m;
                review.RatingScore3 = 2.5m;
                review.RatingScore4 = 1.5m;
                review.Overall = 5.0m; // hooray!
                review.ReviewerLocation = "Southside Chicago";
                review.Status = ItemReview.StatusEnum.Approved;
                // insert the review and update our local variable to see how the review looks now.
                review = itemApi.InsertReview(itemOid, review).Review;

                Console.WriteLine("<br>This is my review object:<br><pre>");
                Console.WriteLine(review.ToString());
                Console.WriteLine("</pre>");

                // This will clean up the sample item, but you may wish to review the item in the backend or on your website first.
                // DeleteSampleItem(itemId);
            }
            catch (Exception e)
            {
                Console.WriteLine("An Exception occurred. Please review the following error:");
                Console.WriteLine(e.ToString()); // handle gracefully
                Environment.Exit(1);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantItemOid** | **int**| The item oid the review is associated with. | 
 **review** | [**ItemReview**](ItemReview.md)| Review to insert | 

### Return type

[**ItemReviewResponse**](ItemReviewResponse.md)

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
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InsertUpdateItemContentAttribute

> void InsertUpdateItemContentAttribute (int merchantItemOid, ItemContentAttribute itemAttribute)

Upsert an item content attribute

Update an item content attribute, creating it new if it does not yet exist. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.item
{
    public class InsertUpdateItemContentAttribute
    {
        public static void Execute()
        {
            /*
                While UltraCart provides a means for updating item content, it is StoreFront specific. This method allows for
                item-wide update of content, such as SEO fields. The content attribute has three fields:
                1) name
                2) value
                3) type: boolean,color,definitionlist,html,integer,mailinglist,multiline,rgba,simplelist,string,videolist

                The SEO content has the following names:
                Item Meta Title = "storefrontSEOTitle"
                Item Meta Description = "storefrontSEODescription"
                Item Meta Keywords = "storefrontSEOKeywords"

                The merchant_item_oid is a unique identifier used by UltraCart. If you do not know your item's oid, call
                ItemApi.GetItemByMerchantItemId() to retrieve the item, and then it's oid item.MerchantItemOid

                Success will return back a status code of 204 (No Content)
            */

            ItemApi itemApi = new ItemApi(Constants.ApiKey);
            int merchantItemOid = 12345;

            ItemContentAttribute attribute = new ItemContentAttribute();
            attribute.Name = "storefrontSEOKeywords";
            attribute.Value = "dog,cat,fish";
            attribute.Type = "string";

            itemApi.InsertUpdateItemContentAttribute(merchantItemOid, attribute);
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantItemOid** | **int**| The item oid to modify. | 
 **itemAttribute** | [**ItemContentAttribute**](ItemContentAttribute.md)| Item content attribute to upsert | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateDigitalItem

> ItemDigitalItemResponse UpdateDigitalItem (int digitalItemOid, ItemDigitalItem digitalItem)

Updates a file within the digital library

Updates a file within the digital library.  This does not update an item, but updates a digital file available and selectable as part (or all) of an item. 


### Example

```csharp
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using System;
using com.ultracart.admin.v2.Client;

namespace SdkSample.item
{
    public class UpdateDigitalItem
    {
        public static void Execute()
        {
            try
            {
                int digitalItemOid = ItemFunctions.InsertSampleDigitalItem();

                ItemApi itemApi = new ItemApi(Constants.ApiKey);
                ItemDigitalItemResponse apiResponse = itemApi.GetDigitalItem(digitalItemOid);
                ItemDigitalItem digitalItem = apiResponse.DigitalItem;

                digitalItem.Description = "I have updated the description to this sentence.";
                digitalItem.ClickWrapAgreement = "You hereby agree that the earth is round.  No debate.";

                itemApi.UpdateDigitalItem(digitalItemOid, digitalItem);

                ItemFunctions.DeleteSampleDigitalItem(digitalItemOid);
            }
            catch (ApiException e)
            {
                Console.WriteLine("An ApiException occurred.  Please review the following error:");
                Console.WriteLine(e); // <-- change_me: handle gracefully
                Environment.Exit(1);
            }
        }


    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **digitalItemOid** | **int**| The digital item oid to update. | 
 **digitalItem** | [**ItemDigitalItem**](ItemDigitalItem.md)| Digital item to update | 

### Return type

[**ItemDigitalItemResponse**](ItemDigitalItemResponse.md)

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
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateItem

> ItemResponse UpdateItem (int merchantItemOid, Item item, string expand = null, bool? placeholders = null)

Update an item

Update a new item on the UltraCart account. 


### Example

```csharp
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using System;
using com.ultracart.admin.v2.Client;

namespace SdkSample.item
{
    public class UpdateItem
    {
        public static void Execute()
        {
            try
            {
                string itemId = ItemFunctions.InsertSampleItem();

                ItemApi itemApi = new ItemApi(Constants.ApiKey);

                // See one of the getItem or getItems samples for possible expansion values
                // See also: https://www.ultracart.com/api/#resource_item.html
                string expand = "pricing";
                ItemResponse apiResponse = itemApi.GetItemByMerchantItemId(itemId, expand, false);
                Item item = apiResponse.Item;
                decimal originalPrice = item.Pricing.Cost;

                // update the price of the item.
                ItemPricing itemPricing = item.Pricing;
                itemPricing.Cost = 12.99m;

                apiResponse = itemApi.UpdateItem(item.MerchantItemOid, item, expand, false);
                Item updatedItem = apiResponse.Item;

                // ensure the price was updated.
                Console.WriteLine("Original Price: " + originalPrice);
                Console.WriteLine("Updated Price: " + updatedItem.Pricing.Cost);

                ItemFunctions.DeleteSampleItem(itemId);
            }
            catch (ApiException e)
            {
                Console.WriteLine("An ApiException occurred.  Please review the following error:");
                Console.WriteLine(e); // <-- change_me: handle gracefully
                Environment.Exit(1);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantItemOid** | **int**| The item oid to update. | 
 **item** | [**Item**](Item.md)| Item to update | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 
 **placeholders** | **bool?**| Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. | [optional] 

### Return type

[**ItemResponse**](ItemResponse.md)

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
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateItems

> ItemsResponse UpdateItems (ItemsRequest itemsRequest, string expand = null, bool? placeholders = null, bool? async = null)

Update multiple items

Update multiple item on the UltraCart account. 


### Example

```csharp
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Client;

namespace SdkSample.item
{
    public class UpdateItems
    {
        public static void Execute()
        {
            try
            {
                string itemId1 = ItemFunctions.InsertSampleItem();
                string itemId2 = ItemFunctions.InsertSampleItem();

                ItemApi itemApi = new ItemApi(Constants.ApiKey);

                // See one of the getItem or getItems samples for possible expansion values
                // See also: https://www.ultracart.com/api/#resource_item.html
                string expand = "pricing";
                ItemResponse apiResponse = itemApi.GetItemByMerchantItemId(itemId1, expand, false);
                Item item1 = apiResponse.Item;
                apiResponse = itemApi.GetItemByMerchantItemId(itemId2, expand, false);
                Item item2 = apiResponse.Item;

                // update the price of the item.
                item1.Pricing.Cost = 12.99m;
                item2.Pricing.Cost = 14.99m;

                ItemsRequest updateItemsRequest = new ItemsRequest();
                updateItemsRequest.Items = new List<Item>{item1, item2};
                ItemsResponse updateItemsResponse = itemApi.UpdateItems(updateItemsRequest, expand, false, false);

                ItemFunctions.DeleteSampleItem(itemId1);
                ItemFunctions.DeleteSampleItem(itemId2);
            }
            catch (ApiException e)
            {
                Console.WriteLine("An ApiException occurred.  Please review the following error:");
                Console.WriteLine(e); // <-- change_me: handle gracefully
                Environment.Exit(1);
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


## UpdateReview

> ItemReviewResponse UpdateReview (int reviewOid, int merchantItemOid, ItemReview review)

Update a review

Update an item review. 


### Example

```csharp
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using System;
using com.ultracart.admin.v2.Client;

namespace SdkSample.item
{
    public class UpdateReview
    {
        public static void Execute()
        {
            try
            {
                // To update a review, you'll need an item's OID (Object Identifier) and the review oid first.

                int merchantItemOid = 99998888; // if you don't know your oid, call GetItemByMerchantItemId() to get your item, then get the oid.
                int reviewOid = 123456; // this is the particular oid you wish to update.

                ItemApi itemApi = new ItemApi(Constants.ApiKey); // convenience function for getting an api handle.
                ItemReview review = itemApi.GetReview(merchantItemOid, reviewOid).Review;

                // You will need to know what your product review looks like.
                review.Title = "Best Product Ever!";
                review.Review = "I loved this product.  I bought it for my wife and she was so happy she cried.  blah blah blah";
                review.ReviewedNickname = "Bob420";
                review.Featured = true; // featured? sure. why not? this is a great review.
                review.RatingName1 = "Durability";
                review.RatingName2 = "Price";
                review.RatingName3 = "Performance";
                review.RatingName4 = "Appearance";
                review.RatingScore1 = 4.5m;
                review.RatingScore2 = 3.5m;
                review.RatingScore3 = 2.5m;
                review.RatingScore4 = 1.5m;
                review.Overall = 5.0m; // hooray!
                review.ReviewerLocation = "Southside Chicago";
                review.Status = ItemReview.StatusEnum.Approved;
                // insert the review and update our local variable to see how the review looks now.
                review = itemApi.UpdateReview(reviewOid, merchantItemOid, review).Review;

                Console.WriteLine("This is my review object:");
                Console.WriteLine(review);

                // This will clean up the sample item, but you may wish to review the item in the backend or on your website first.
                // DeleteSampleItem(itemId);
            }
            catch (ApiException e)
            {
                Console.WriteLine("An ApiException occurred.  Please review the following error:");
                Console.WriteLine(e); // <-- change_me: handle gracefully
                Environment.Exit(1);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reviewOid** | **int**| The review oid to update. | 
 **merchantItemOid** | **int**| The item oid the review is associated with. | 
 **review** | [**ItemReview**](ItemReview.md)| Review to update | 

### Return type

[**ItemReviewResponse**](ItemReviewResponse.md)

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
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UploadTemporaryMultimedia

> TempMultimediaResponse UploadTemporaryMultimedia (System.IO.Stream file)

Upload an image to the temporary multimedia.

Uploads an image and returns back meta information about the image as well as the identifier needed for the item update. 


### Example

```csharp
// This method is used internally by UltraCart.
// We don't envision a scenario where a merchant would ever need to call this.
// As such, we're not providing a sample for it.  If you can think of a use for this
// method, contact us, and we'll help you work through it.
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

