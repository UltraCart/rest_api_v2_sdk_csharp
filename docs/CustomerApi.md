# com.ultracart.admin.v2.Api.CustomerApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCustomerStoreCredit**](CustomerApi.md#addcustomerstorecredit) | **POST** /customer/customers/{customer_profile_oid}/store_credit | Adds store credit to a customer
[**AdjustInternalCertificate**](CustomerApi.md#adjustinternalcertificate) | **POST** /customer/customers/{customer_profile_oid}/adjust_cashback_balance | Updates the cashback balance for a customer by updating the internal gift certificate used, creating the gift certificate if needed.
[**DeleteCustomer**](CustomerApi.md#deletecustomer) | **DELETE** /customer/customers/{customer_profile_oid} | Delete a customer
[**DeleteWishListItem**](CustomerApi.md#deletewishlistitem) | **DELETE** /customer/customers/{customer_profile_oid}/wishlist/{customer_wishlist_item_oid} | Delete a customer wishlist item
[**GetCustomer**](CustomerApi.md#getcustomer) | **GET** /customer/customers/{customer_profile_oid} | Retrieve a customer
[**GetCustomerByEmail**](CustomerApi.md#getcustomerbyemail) | **GET** /customer/customers/by_email/{email} | Retrieve a customer by Email
[**GetCustomerEditorValues**](CustomerApi.md#getcustomereditorvalues) | **GET** /customer/editor_values | Retrieve values needed for a customer profile editor
[**GetCustomerEmailLists**](CustomerApi.md#getcustomeremaillists) | **GET** /customer/email_lists | Retrieve all email lists across all storefronts
[**GetCustomerStoreCredit**](CustomerApi.md#getcustomerstorecredit) | **GET** /customer/customers/{customer_profile_oid}/store_credit | Retrieve the customer store credit accumulated through loyalty programs
[**GetCustomerWishList**](CustomerApi.md#getcustomerwishlist) | **GET** /customer/customers/{customer_profile_oid}/wishlist | Retrieve wishlist items for customer
[**GetCustomerWishListItem**](CustomerApi.md#getcustomerwishlistitem) | **GET** /customer/customers/{customer_profile_oid}/wishlist/{customer_wishlist_item_oid} | Retrieve wishlist item for customer
[**GetCustomers**](CustomerApi.md#getcustomers) | **GET** /customer/customers | Retrieve customers
[**GetCustomersByQuery**](CustomerApi.md#getcustomersbyquery) | **POST** /customer/customers/query | Retrieve customers by query
[**GetCustomersForDataTables**](CustomerApi.md#getcustomersfordatatables) | **POST** /customer/customers/dataTables | Retrieve customers for DataTables plugin
[**GetEmailVerificationToken**](CustomerApi.md#getemailverificationtoken) | **POST** /customer/customers/email_verify/get_token | Create a token that can be used to verify a customer email address
[**GetMagicLink**](CustomerApi.md#getmagiclink) | **PUT** /customer/customers/{customer_profile_oid}/magic_link/{storefront_host_name} | getMagicLink
[**InsertCustomer**](CustomerApi.md#insertcustomer) | **POST** /customer/customers | Insert a customer
[**InsertWishListItem**](CustomerApi.md#insertwishlistitem) | **POST** /customer/customers/{customer_profile_oid}/wishlist | Insert a customer wishlist item
[**MergeCustomer**](CustomerApi.md#mergecustomer) | **PUT** /customer/customers/{customer_profile_oid}/merge | Merge customer into this customer
[**SearchCustomerProfileValues**](CustomerApi.md#searchcustomerprofilevalues) | **POST** /customer/search | Searches for all matching values (using POST)
[**UpdateCustomer**](CustomerApi.md#updatecustomer) | **PUT** /customer/customers/{customer_profile_oid} | Update a customer
[**UpdateCustomerEmailLists**](CustomerApi.md#updatecustomeremaillists) | **POST** /customer/customers/{customer_profile_oid}/email_lists | Update email list subscriptions for a customer
[**UpdateWishListItem**](CustomerApi.md#updatewishlistitem) | **PUT** /customer/customers/{customer_profile_oid}/wishlist/{customer_wishlist_item_oid} | Update a customer wishlist item
[**ValidateEmailVerificationToken**](CustomerApi.md#validateemailverificationtoken) | **POST** /customer/customers/email_verify/validate_token | Validate a token that can be used to verify a customer email address



## AddCustomerStoreCredit

> BaseResponse AddCustomerStoreCredit (int customerProfileOid, CustomerStoreCreditAddRequest storeCreditRequest)

Adds store credit to a customer

Adds store credit to a customer 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.customer
{
    public class AddCustomerStoreCredit
    {
        /**
         * Adds store credit to a customer's account.
         *
         * This method requires a customer profile oid. This is a unique number used by UltraCart to identify a customer.
         * If you do not know a customer's oid, call getCustomerByEmail() to retrieve the customer and their oid.
         *
         * Possible Errors:
         * Missing store credit -> "store_credit_request.amount is missing and is required."
         * Zero or negative store credit -> "store_credit_request.amount must be a positive amount."
         */
        public static void Execute()
        {
            CustomerApi customerApi = new CustomerApi(Constants.ApiKey);

            string email = "test@ultracart.com";
            Customer customer = customerApi.GetCustomerByEmail(email).Customer;
            int customerOid = customer.CustomerProfileOid;

            CustomerStoreCreditAddRequest storeCreditRequest = new CustomerStoreCreditAddRequest();
            storeCreditRequest.Amount = 20.00m;
            storeCreditRequest.Description = "Customer is super cool and I wanted to give them store credit.";
            storeCreditRequest.ExpirationDays = 365; // or leave null for no expiration
            storeCreditRequest.VestingDays = 45; // customer has to wait 45 days to use it.

            BaseResponse apiResponse = customerApi.AddCustomerStoreCredit(customerOid, storeCreditRequest);

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                Environment.Exit(1);
            }

            Console.WriteLine(apiResponse.Success);
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerProfileOid** | **int**| The customer oid to credit. | 
 **storeCreditRequest** | [**CustomerStoreCreditAddRequest**](CustomerStoreCreditAddRequest.md)| Store credit to add | 

### Return type

[**BaseResponse**](BaseResponse.md)

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


## AdjustInternalCertificate

> AdjustInternalCertificateResponse AdjustInternalCertificate (int customerProfileOid, AdjustInternalCertificateRequest adjustInternalCertificateRequest)

Updates the cashback balance for a customer by updating the internal gift certificate used, creating the gift certificate if needed.

Updates the cashback balance for a customer by updating the internal gift certificate used, creating the gift certificate if needed. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.customer
{
    public class AdjustInternalCertificate
    {
        /**
         * Adjusts the cashback balance of a customer. This method's name is adjustInternalCertificate, which
         * is a poor choice of naming, but results from an underlying implementation of using an internal gift certificate
         * to track cashback balance. Sorry for the confusion.
         *
         * This method requires a customer profile oid. This is a unique number used by UltraCart to identify a customer.
         * If you do not know a customer's oid, call getCustomerByEmail() to retrieve the customer and their oid.
         *
         * Possible Errors:
         * Missing adjustment amount -> "adjust_internal_certificate_request.adjustment_amount is required and was missing"
         */
        public static void Execute()
        {
            CustomerApi customerApi = new CustomerApi(Constants.ApiKey);

            string email = "test@ultracart.com";
            Customer customer = customerApi.GetCustomerByEmail(email).Customer;
            int customerOid = customer.CustomerProfileOid;

            AdjustInternalCertificateRequest adjustRequest = new AdjustInternalCertificateRequest();
            adjustRequest.Description = "Adjusting customer cashback balance because they called and complained about product.";
            adjustRequest.ExpirationDays = 365; // expires in 365 days
            adjustRequest.VestingDays = 45; // customer has to wait 45 days to use it.
            adjustRequest.AdjustmentAmount = 59; // add 59 to their balance.
            adjustRequest.OrderId = "DEMO-12345"; // or leave null. this ties the adjustment to a particular order.
            adjustRequest.EntryDts = null; // use current time.

            AdjustInternalCertificateResponse apiResponse = customerApi.AdjustInternalCertificate(customerOid, adjustRequest);

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                Environment.Exit(1);
            }

            Console.WriteLine($"Success: {apiResponse.Success}");
            Console.WriteLine($"Adjustment Amount: {apiResponse.AdjustmentAmount}");
            Console.WriteLine($"Balance Amount: {apiResponse.BalanceAmount}");
            
            Console.WriteLine(apiResponse);
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerProfileOid** | **int**| The customer profile oid | 
 **adjustInternalCertificateRequest** | [**AdjustInternalCertificateRequest**](AdjustInternalCertificateRequest.md)| adjustInternalCertificateRequest | 

### Return type

[**AdjustInternalCertificateResponse**](AdjustInternalCertificateResponse.md)

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


## DeleteCustomer

> void DeleteCustomer (int customerProfileOid)

Delete a customer

Delete a customer on the UltraCart account. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;

namespace SdkSample.customer
{
    public class DeleteCustomer
    {
        public static void Execute()
        {
            try
            {
                int customerOid = CustomerFunctions.InsertSampleCustomer();
                CustomerFunctions.DeleteSampleCustomer(customerOid);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("An Exception occurred. Please review the following error:");
                Console.Error.WriteLine(ex); // <-- change_me: handle gracefully
                Environment.Exit(1);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerProfileOid** | **int**| The customer_profile_oid to delete. | 

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


## DeleteWishListItem

> void DeleteWishListItem (int customerProfileOid, int customerWishlistItemOid)

Delete a customer wishlist item

Delete a customer wishlist item 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using SdkSample.item;

namespace SdkSample.customer
{
    public class DeleteWishListItem
    {
        /**
         * The wishlist methods allow management of a customer's wishlist.
         * This includes:
         *     DeleteWishListItem
         *     GetCustomerWishList
         *     GetCustomerWishListItem
         *     InsertWishListItem
         *     UpdateWishListItem
         * These methods provide a standard CRUD interface. The example below uses all of them.
         *
         * You'll need merchant_item_oids to insert wishlist items. If you don't know the oids,
         * call ItemApi.GetItemByMerchantItemId() to retrieve the item, then get item.MerchantItemOid
         *
         * Note: Priority of wishlist item, 3 being low priority and 5 is high priority.
         */
        public static void Execute()
        {
            try
            {
                CustomerApi customerApi = new CustomerApi(Constants.ApiKey);

                // create a few items first.
                int firstItemOid = ItemFunctions.InsertSampleItemAndGetOid();
                int secondItemOid = ItemFunctions.InsertSampleItemAndGetOid();

                // create a customer
                int customerOid = CustomerFunctions.InsertSampleCustomer();

                // TODO: If you don't know the customer oid, use GetCustomerByEmail() to retrieve the customer.

                // add some wish list items.
                CustomerWishListItem addWishItem = new CustomerWishListItem();
                addWishItem.CustomerProfileOid = customerOid;
                addWishItem.MerchantItemOid = firstItemOid;
                addWishItem.Comments = "I really want this for my birthday";
                addWishItem.Priority = 3; // Priority of wishlist item, 3 being low priority and 5 is high priority.
                CustomerWishListItem firstCreatedWishItem = customerApi.InsertWishListItem(customerOid, addWishItem);

                addWishItem = new CustomerWishListItem();
                addWishItem.CustomerProfileOid = customerOid;
                addWishItem.MerchantItemOid = secondItemOid;
                addWishItem.Comments = "Christmas Idea!";
                addWishItem.Priority = 5; // Priority of wishlist item, 3 being low priority and 5 is high priority.
                CustomerWishListItem secondCreatedWishItem = customerApi.InsertWishListItem(customerOid, addWishItem);

                // retrieve one wishlist item again
                CustomerWishListItem firstCreatedWishItemCopy = customerApi.GetCustomerWishListItem(customerOid, firstCreatedWishItem.CustomerWishlistItemOid).WishlistItem;
                // retrieve all wishlist items
                CustomerWishListItemsResponse allWishListItems = customerApi.GetCustomerWishList(customerOid);

                // update an item.
                secondCreatedWishItem.Priority = 4;
                CustomerWishListItem updatedSecondWishItem = customerApi.UpdateWishListItem(customerOid, secondCreatedWishItem.CustomerWishlistItemOid, secondCreatedWishItem);

                // delete a wish list item
                customerApi.DeleteWishListItem(customerOid, firstCreatedWishItem.CustomerWishlistItemOid);

                // Clean up
                CustomerFunctions.DeleteSampleCustomer(customerOid);
                ItemFunctions.DeleteSampleItemByOid(firstItemOid);
                ItemFunctions.DeleteSampleItemByOid(secondItemOid);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("An Exception occurred. Please review the following error:");
                Console.Error.WriteLine(ex); // <-- change_me: handle gracefully
                Environment.Exit(1);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerProfileOid** | **int**| The customer oid for this wishlist. | 
 **customerWishlistItemOid** | **int**| The wishlist oid for this wishlist item to delete. | 

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


## GetCustomer

> CustomerResponse GetCustomer (int customerProfileOid, string expand = null)

Retrieve a customer

Retrieves a single customer using the specified customer profile oid. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.customer
{
    public class GetCustomer
    {
        /**
         * Of the two GetCustomer methods, you'll probably always use GetCustomerByEmail instead of this one.
         * Most customer logic revolves around the email, not the customer oid. The latter is only meaningful as a primary
         * key in the UltraCart databases. But here is an example of using GetCustomer().
         */
        public static void Execute()
        {
            try
            {
                string email = CustomerFunctions.CreateRandomEmail();
                int customerOid = CustomerFunctions.InsertSampleCustomer(email);
                CustomerApi customerApi = new CustomerApi(Constants.ApiKey);

                // the _expand variable is set to return just the address fields.
                // see CustomerFunctions for a list of expansions, or consult the source: https://www.ultracart.com/api/
                CustomerResponse apiResponse = customerApi.GetCustomer(customerOid, "billing,shipping");
                Customer customer = apiResponse.Customer; // assuming this succeeded

                Console.WriteLine(customer);

                CustomerFunctions.DeleteSampleCustomer(customerOid);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("An Exception occurred. Please review the following error:");
                Console.Error.WriteLine(ex); // <-- change_me: handle gracefully
                Environment.Exit(1);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerProfileOid** | **int**| The customer oid to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CustomerResponse**](CustomerResponse.md)

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


## GetCustomerByEmail

> CustomerResponse GetCustomerByEmail (string email, string expand = null)

Retrieve a customer by Email

Retrieves a single customer using the specified customer email address. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.customer
{
    public class GetCustomerByEmail
    {
        /**
         * Of the two GetCustomer methods, you'll probably always use this one over GetCustomer.
         * Most customer logic revolves around the email, not the customer oid. The latter is only meaningful as a primary
         * key in the UltraCart databases. But our sample functions return back the oid, so we'll ignore that and just
         * use the email that we create.
         */
        public static void Execute()
        {
            try
            {
                string email = CustomerFunctions.CreateRandomEmail();
                int customerOid = CustomerFunctions.InsertSampleCustomer(email);
                CustomerApi customerApi = Samples.GetCustomerApi();

                // the _expand variable is set to return just the address fields.
                // see CustomerFunctions for a list of expansions, or consult the source: https://www.ultracart.com/api/
                CustomerResponse apiResponse = customerApi.GetCustomerByEmail(email, "billing,shipping");
                Customer customer = apiResponse.Customer; // assuming this succeeded

                Console.WriteLine(customer);

                CustomerFunctions.DeleteSampleCustomer(customerOid);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("An Exception occurred. Please review the following error:");
                Console.Error.WriteLine(ex); // <-- change_me: handle gracefully
                Environment.Exit(1);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| The email address of the customer to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CustomerResponse**](CustomerResponse.md)

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


## GetCustomerEditorValues

> CustomerEditorValues GetCustomerEditorValues ()

Retrieve values needed for a customer profile editor

Retrieve values needed for a customer profile editor. 


### Example

```csharp
// This is an internal method used by our Customer management screen.  It returns back all the static data needed
// for our dropdown lists, such as lists of state and countries.  You can call it if you like, but the data won't be
// of much use.
```


### Parameters

This endpoint does not need any parameter.

### Return type

[**CustomerEditorValues**](CustomerEditorValues.md)

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


## GetCustomerEmailLists

> EmailListsResponse GetCustomerEmailLists ()

Retrieve all email lists across all storefronts

Retrieve all email lists across all storefronts 


### Example

```csharp
// This is an internal method used by our Email workflow engines.  It returns back all the email lists a customer
// is currently subscribed to.  It's geared towards our UI needs, so the data returned may appear cryptic.
//  We're not including a sample for it because we don't envision it being valuable to a merchant.
```


### Parameters

This endpoint does not need any parameter.

### Return type

[**EmailListsResponse**](EmailListsResponse.md)

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


## GetCustomerStoreCredit

> CustomerStoreCreditResponse GetCustomerStoreCredit (int customerProfileOid)

Retrieve the customer store credit accumulated through loyalty programs

Retrieve the customer store credit accumulated through loyalty programs 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.customer
{
    public class GetCustomerStoreCredit
    {
        /*
            getCustomerStoreCredit returns back the store credit for a customer, which includes:
            total - lifetime credit
            available - currently available store credit
            vesting - amount of store credit vesting
            expiring - amount of store credit expiring within 30 days
            pastLedgers - transaction history
            futureLedgers - future transactions including expiring entries
         */
        public static void Execute()
        {
            try
            {
                CustomerApi customerApi = new CustomerApi(Constants.ApiKey);

                // create a customer
                int customerOid = CustomerFunctions.InsertSampleCustomer();

                // add some store credit.
                CustomerStoreCreditAddRequest addRequest = new CustomerStoreCreditAddRequest();
                addRequest.Description = "First credit add";
                addRequest.VestingDays = 10;
                addRequest.ExpirationDays = 20; // that's not a lot of time!
                addRequest.Amount = 20;
                customerApi.AddCustomerStoreCredit(customerOid, addRequest);

                // add more store credit.
                addRequest = new CustomerStoreCreditAddRequest();
                addRequest.Description = "Second credit add";
                addRequest.VestingDays = 0; // immediately available.
                addRequest.ExpirationDays = 90;
                addRequest.Amount = 40;
                customerApi.AddCustomerStoreCredit(customerOid, addRequest);

                CustomerStoreCreditResponse apiResponse = customerApi.GetCustomerStoreCredit(customerOid);
                CustomerStoreCredit storeCredit = apiResponse.CustomerStoreCredit;

                Console.WriteLine(storeCredit); // <-- There's a lot of information inside this object.

                // clean up this sample.
                CustomerFunctions.DeleteSampleCustomer(customerOid);
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
 **customerProfileOid** | **int**| The customer oid to retrieve. | 

### Return type

[**CustomerStoreCreditResponse**](CustomerStoreCreditResponse.md)

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


## GetCustomerWishList

> CustomerWishListItemsResponse GetCustomerWishList (int customerProfileOid)

Retrieve wishlist items for customer

Retrieve wishlist items for customer. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using SdkSample.item;

namespace SdkSample.customer
{
    public class GetCustomerWishList
    {
        /*
            The wishlist methods allow management of a customer's wishlist.
            This includes:
                DeleteWishListItem
                GetCustomerWishList
                GetCustomerWishListItem
                InsertWishListItem
                UpdateWishListItem
            These methods provide a standard CRUD interface. The example below uses all of them.

            You'll need merchant_item_oids to insert wishlist items. If you don't know the oids,
            call ItemApi.GetItemByMerchantItemId() to retrieve the item, then get item.MerchantItemOid

            Note: Priority of wishlist item, 3 being low priority and 5 is high priority.
        */
        public static void Execute()
        {
            try
            {
                CustomerApi customerApi = new CustomerApi(Constants.ApiKey);

                // create a few items first.
                int firstItemOid = ItemFunctions.InsertSampleItemAndGetOid();
                int secondItemOid = ItemFunctions.InsertSampleItemAndGetOid();

                // create a customer
                int customerOid = CustomerFunctions.InsertSampleCustomer();

                // TODO: If you don't know the customer oid, use GetCustomerByEmail() to retrieve the customer.

                // add some wish list items.
                CustomerWishListItem addWishItem = new CustomerWishListItem();
                addWishItem.CustomerProfileOid = customerOid;
                addWishItem.MerchantItemOid = firstItemOid;
                addWishItem.Comments = "I really want this for my birthday";
                addWishItem.Priority = 3; // Priority of wishlist item, 3 being low priority and 5 is high priority.
                CustomerWishListItem firstCreatedWishItem = customerApi.InsertWishListItem(customerOid, addWishItem);

                addWishItem = new CustomerWishListItem();
                addWishItem.CustomerProfileOid = customerOid;
                addWishItem.MerchantItemOid = secondItemOid;
                addWishItem.Comments = "Christmas Idea!";
                addWishItem.Priority = 5; // Priority of wishlist item, 3 being low priority and 5 is high priority.
                CustomerWishListItem secondCreatedWishItem = customerApi.InsertWishListItem(customerOid, addWishItem);

                // retrieve one wishlist item again
                CustomerWishListItem firstCreatedWishItemCopy = customerApi.GetCustomerWishListItem(customerOid, firstCreatedWishItem.CustomerWishlistItemOid).WishlistItem;
                // retrieve all wishlist items
                List<CustomerWishListItem> allWishListItems = customerApi.GetCustomerWishList(customerOid).WishlistItems;

                // update an item.
                secondCreatedWishItem.Priority = 4;
                CustomerWishListItem updatedSecondWishItem = customerApi.UpdateWishListItem(customerOid, secondCreatedWishItem.CustomerWishlistItemOid, secondCreatedWishItem);

                // delete a wish list item
                customerApi.DeleteWishListItem(customerOid, firstCreatedWishItem.CustomerWishlistItemOid);

                // Clean up
                CustomerFunctions.DeleteSampleCustomer(customerOid);
                ItemFunctions.DeleteSampleItemByOid(firstItemOid);
                ItemFunctions.DeleteSampleItemByOid(secondItemOid);
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
 **customerProfileOid** | **int**| The customer oid for this wishlist. | 

### Return type

[**CustomerWishListItemsResponse**](CustomerWishListItemsResponse.md)

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


## GetCustomerWishListItem

> CustomerWishListItemResponse GetCustomerWishListItem (int customerProfileOid, int customerWishlistItemOid)

Retrieve wishlist item for customer

Retrieve wishlist item for customer. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using SdkSample.item;

namespace SdkSample.customer
{
    public class GetCustomerWishListItem
    {
        /*
            The wishlist methods allow management of a customer's wishlist.
            This includes:
                DeleteWishListItem
                GetCustomerWishList
                GetCustomerWishListItem
                InsertWishListItem
                UpdateWishListItem
            These methods provide a standard CRUD interface. The example below uses all of them.

            You'll need merchant_item_oids to insert wishlist items. If you don't know the oids,
            call ItemApi.GetItemByMerchantItemId() to retrieve the item, then get item.MerchantItemOid

            Note: Priority of wishlist item, 3 being low priority and 5 is high priority.
        */
        public static void Execute()
        {
            try
            {
                CustomerApi customerApi = new CustomerApi(Constants.ApiKey);

                // create a few items first.
                int firstItemOid = ItemFunctions.InsertSampleItemAndGetOid();
                int secondItemOid = ItemFunctions.InsertSampleItemAndGetOid();

                // create a customer
                int customerOid = CustomerFunctions.InsertSampleCustomer();

                // TODO: If you don't know the customer oid, use GetCustomerByEmail() to retrieve the customer.

                // add some wish list items.
                CustomerWishListItem addWishItem = new CustomerWishListItem();
                addWishItem.CustomerProfileOid = customerOid;
                addWishItem.MerchantItemOid = firstItemOid;
                addWishItem.Comments = "I really want this for my birthday";
                addWishItem.Priority = 3; // Priority of wishlist item, 3 being low priority and 5 is high priority.
                CustomerWishListItem firstCreatedWishItem = customerApi.InsertWishListItem(customerOid, addWishItem);

                addWishItem = new CustomerWishListItem();
                addWishItem.CustomerProfileOid = customerOid;
                addWishItem.MerchantItemOid = secondItemOid;
                addWishItem.Comments = "Christmas Idea!";
                addWishItem.Priority = 5; // Priority of wishlist item, 3 being low priority and 5 is high priority.
                CustomerWishListItem secondCreatedWishItem = customerApi.InsertWishListItem(customerOid, addWishItem);

                // retrieve one wishlist item again
                CustomerWishListItem firstCreatedWishItemCopy = customerApi.GetCustomerWishListItem(customerOid, firstCreatedWishItem.CustomerWishlistItemOid).WishlistItem;
                // retrieve all wishlist items
                List<CustomerWishListItem> allWishListItems = customerApi.GetCustomerWishList(customerOid).WishlistItems;

                // update an item.
                secondCreatedWishItem.Priority = 4;
                CustomerWishListItem updatedSecondWishItem = customerApi.UpdateWishListItem(customerOid, secondCreatedWishItem.CustomerWishlistItemOid, secondCreatedWishItem);

                // delete a wish list item
                customerApi.DeleteWishListItem(customerOid, firstCreatedWishItem.CustomerWishlistItemOid);

                // Clean up
                CustomerFunctions.DeleteSampleCustomer(customerOid);
                ItemFunctions.DeleteSampleItemByOid(firstItemOid);
                ItemFunctions.DeleteSampleItemByOid(secondItemOid);
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
 **customerProfileOid** | **int**| The customer oid for this wishlist. | 
 **customerWishlistItemOid** | **int**| The wishlist oid for this wishlist item. | 

### Return type

[**CustomerWishListItemResponse**](CustomerWishListItemResponse.md)

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


## GetCustomers

> CustomersResponse GetCustomers (string email = null, string qbClass = null, string quickbooksCode = null, string lastModifiedDtsStart = null, string lastModifiedDtsEnd = null, string signupDtsStart = null, string signupDtsEnd = null, string billingFirstName = null, string billingLastName = null, string billingCompany = null, string billingCity = null, string billingState = null, string billingPostalCode = null, string billingCountryCode = null, string billingDayPhone = null, string billingEveningPhone = null, string shippingFirstName = null, string shippingLastName = null, string shippingCompany = null, string shippingCity = null, string shippingState = null, string shippingPostalCode = null, string shippingCountryCode = null, string shippingDayPhone = null, string shippingEveningPhone = null, int? pricingTierOid = null, string pricingTierName = null, int? limit = null, int? offset = null, string since = null, string sort = null, string expand = null)

Retrieve customers

Retrieves customers from the account.  If no parameters are specified, all customers will be returned.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.customer
{
    public class GetCustomers
    {
        /**
         * This example illustrates how to retrieve customers. It uses the pagination logic necessary to query all customers.
         * This method was the first GetCustomers and has parameters for all the search terms. It's an ogre. Using
         * GetCustomersByQuery is much easier to use.
         */
        public static List<Customer> GetCustomerChunk(CustomerApi customerApi, int offset, int limit)
        {
            // The real devil in the GetCustomers calls is the expansion, making sure you return everything you need without
            // returning everything since these objects are extremely large. The customer object can be truly large with
            // all the order history. These are the possible expansion values.
            /*
                attachments     billing     cards           cc_emails       loyalty     orders_summary          pricing_tiers
                privacy         properties  quotes_summary  reviewer        shipping    software_entitlements   tags
                tax_codes     
             */
            string expand = "shipping,billing"; // just the address fields. contact us if you're unsure
            
            // TODO: Seriously, use GetCustomersByQuery -- it's so much better than this old method.
            string email = null;
            string qbClass = null;
            string quickbooksCode = null;
            string lastModifiedDtsStart = null;
            string lastModifiedDtsEnd = null;
            string signupDtsStart = null;
            string signupDtsEnd = null;
            string billingFirstName = null;
            string billingLastName = null;
            string billingCompany = null;
            string billingCity = null;
            string billingState = null;
            string billingPostalCode = null;
            string billingCountryCode = null;
            string billingDayPhone = null;
            string billingEveningPhone = null;
            string shippingFirstName = null;
            string shippingLastName = null;
            string shippingCompany = null;
            string shippingCity = null;
            string shippingState = null;
            string shippingPostalCode = null;
            string shippingCountryCode = null;
            string shippingDayPhone = null;
            string shippingEveningPhone = null;
            int? pricingTierOid = null;
            string pricingTierName = null;
            string since = null;
            string sort = null;
            
            CustomersResponse apiResponse = customerApi.GetCustomers(
                email, qbClass, quickbooksCode, lastModifiedDtsStart, lastModifiedDtsEnd, signupDtsStart, signupDtsEnd,
                billingFirstName, billingLastName, billingCompany, billingCity, billingState, billingPostalCode,
                billingCountryCode, billingDayPhone, billingEveningPhone, shippingFirstName, shippingLastName,
                shippingCompany, shippingCity, shippingState, shippingPostalCode, shippingCountryCode,
                shippingDayPhone, shippingEveningPhone, pricingTierOid, pricingTierName, limit, offset, since, sort, expand);

            if (apiResponse.Customers != null)
            {
                return apiResponse.Customers.ToList();
            }
            return new List<Customer>();
        }

        public static void Execute()
        {
            try
            {
                CustomerApi customerApi = Samples.GetCustomerApi();
                List<Customer> customers = new List<Customer>();

                int iteration = 1;
                int offset = 0;
                int limit = 200;
                bool moreRecordsToFetch = true;

                while (moreRecordsToFetch)
                {
                    Console.WriteLine($"Executing iteration {iteration}");

                    List<Customer> chunkOfCustomers = GetCustomerChunk(customerApi, offset, limit);
                    customers.AddRange(chunkOfCustomers);
                    offset = offset + limit;
                    moreRecordsToFetch = chunkOfCustomers.Count == limit;
                    iteration++;
                }

                // This will be verbose...
                Console.WriteLine(customers);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Exception occurred: {ex.Message}");
                Console.Error.WriteLine(ex);
                Environment.Exit(1);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Email | [optional] 
 **qbClass** | **string**| Quickbooks class | [optional] 
 **quickbooksCode** | **string**| Quickbooks code | [optional] 
 **lastModifiedDtsStart** | **string**| Last modified date start | [optional] 
 **lastModifiedDtsEnd** | **string**| Last modified date end | [optional] 
 **signupDtsStart** | **string**| Signup date start | [optional] 
 **signupDtsEnd** | **string**| Signup date end | [optional] 
 **billingFirstName** | **string**| Billing first name | [optional] 
 **billingLastName** | **string**| Billing last name | [optional] 
 **billingCompany** | **string**| Billing company | [optional] 
 **billingCity** | **string**| Billing city | [optional] 
 **billingState** | **string**| Billing state | [optional] 
 **billingPostalCode** | **string**| Billing postal code | [optional] 
 **billingCountryCode** | **string**| Billing country code | [optional] 
 **billingDayPhone** | **string**| Billing day phone | [optional] 
 **billingEveningPhone** | **string**| Billing evening phone | [optional] 
 **shippingFirstName** | **string**| Shipping first name | [optional] 
 **shippingLastName** | **string**| Shipping last name | [optional] 
 **shippingCompany** | **string**| Shipping company | [optional] 
 **shippingCity** | **string**| Shipping city | [optional] 
 **shippingState** | **string**| Shipping state | [optional] 
 **shippingPostalCode** | **string**| Shipping postal code | [optional] 
 **shippingCountryCode** | **string**| Shipping country code | [optional] 
 **shippingDayPhone** | **string**| Shipping day phone | [optional] 
 **shippingEveningPhone** | **string**| Shipping evening phone | [optional] 
 **pricingTierOid** | **int?**| Pricing tier oid | [optional] 
 **pricingTierName** | **string**| Pricing tier name | [optional] 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Max 200) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **since** | **string**| Fetch customers that have been created/modified since this date/time. | [optional] 
 **sort** | **string**| The sort order of the customers.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CustomersResponse**](CustomersResponse.md)

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


## GetCustomersByQuery

> CustomersResponse GetCustomersByQuery (CustomerQuery customerQuery, int? limit = null, int? offset = null, string since = null, string sort = null, string expand = null)

Retrieve customers by query

Retrieves customers from the account.  If no parameters are specified, all customers will be returned.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.customer
{
    public class GetCustomersByQuery
    {
        /*
         * This example illustrates how to retrieve customers. It uses the pagination logic necessary to query all customers.
         */
        public static void Execute()
        {
            // pulling all records could take a long time.
            CustomerApi customerApi = Samples.GetCustomerApi();

            List<Customer> customers = new List<Customer>();

            int iteration = 1;
            int offset = 0;
            int limit = 200;
            bool moreRecordsToFetch = true;

            try
            {
                while (moreRecordsToFetch)
                {
                    Console.WriteLine("executing iteration " + iteration);

                    List<Customer> chunkOfCustomers = GetCustomerChunk(customerApi, offset, limit);
                    customers = customers.Concat(chunkOfCustomers).ToList();
                    offset = offset + limit;
                    moreRecordsToFetch = chunkOfCustomers.Count == limit;
                    iteration++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurred on iteration " + iteration);
                Console.WriteLine(e);
                Environment.Exit(1);
            }

            // this will be verbose...
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        /// <summary>
        /// Retrieves a chunk of customers based on specified parameters
        /// </summary>
        /// <param name="customerApi">The customer API client</param>
        /// <param name="offset">Starting position for retrieval</param>
        /// <param name="limit">Maximum number of records to retrieve</param>
        /// <returns>List of customers</returns>
        private static List<Customer> GetCustomerChunk(CustomerApi customerApi, int offset, int limit)
        {
            // The real devil in the getCustomers calls is the expansion, making sure you return everything you need without
            // returning everything since these objects are extremely large. The customer object can be truly large with
            // all the order history. These are the possible expansion values.
            /*
                attachments     billing     cards           cc_emails       loyalty     orders_summary          pricing_tiers
                privacy         properties  quotes_summary  reviewer        shipping    software_entitlements   tags
                tax_codes
            */
            string expand = "shipping,billing"; // just the address fields. contact us if you're unsure

            // TODO: This is just showing all the possibilities. In reality, you'll just assign the filters you need.
            CustomerQuery query = new CustomerQuery();
            //query.Email = null;
            //query.QbClass = null;
            //query.QuickbooksCode = null;
            //query.LastModifiedDtsStart = null;
            //query.LastModifiedDtsEnd = null;
            //query.SignupDtsStart = null;
            //query.SignupDtsEnd = null;
            //query.BillingFirstName = null;
            //query.BillingLastName = null;
            //query.BillingCompany = null;
            //query.BillingCity = null;
            //query.BillingState = null;
            //query.BillingPostalCode = null;
            //query.BillingCountryCode = null;
            //query.BillingDayPhone = null;
            //query.BillingEveningPhone = null;
            //query.ShippingFirstName = null;
            //query.ShippingLastName = null;
            //query.ShippingCompany = null;
            //query.ShippingCity = null;
            //query.ShippingState = null;
            //query.ShippingPostalCode = null;
            //query.ShippingCountryCode = null;
            //query.ShippingDayPhone = null;
            //query.ShippingEveningPhone = null;
            //query.PricingTierOid = null;
            //query.PricingTierName = null;

            string since = null;
            string sort = "email";

            CustomersResponse apiResponse = customerApi.GetCustomersByQuery(query, offset, limit, since, sort, expand);

            if (apiResponse.Customers != null)
            {
                return apiResponse.Customers;
            }
            return new List<Customer>();
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerQuery** | [**CustomerQuery**](CustomerQuery.md)| Customer query | 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Max 200) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **since** | **string**| Fetch customers that have been created/modified since this date/time. | [optional] 
 **sort** | **string**| The sort order of the customers.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CustomersResponse**](CustomersResponse.md)

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
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCustomersForDataTables

> DataTablesServerSideResponse GetCustomersForDataTables (string expand = null)

Retrieve customers for DataTables plugin

Retrieves customers from the account.  If no searches are specified, all customers will be returned. 


### Example

```csharp
// This is an internal method used by our Customer management screen.  It won't be of much use to you, so we're
// not including a sample.  getCustomer, getCustomerByEmail, getCustomers and getCustomersByQuery are more useful
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**DataTablesServerSideResponse**](DataTablesServerSideResponse.md)

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


## GetEmailVerificationToken

> EmailVerifyTokenResponse GetEmailVerificationToken (EmailVerifyTokenRequest tokenRequest)

Create a token that can be used to verify a customer email address

Create a token that can be used to verify a customer email address.  The implementation of how a customer interacts with this token is left to the merchant. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.customer
{
    public class GetEmailVerificationToken
    {
        /*
            GetEmailVerificationToken and ValidateEmailVerificationToken are tandem functions that allow a merchant to verify
            a customer's email address. GetEmailVerificationToken returns back a token that the merchant can use however
            they wish to present to a customer. Usually this will be emailed to the customer within instructions to enter
            it back into a website. Once the customer enters the token back into a site (along with their email),
            ValidateEmailVerificationToken will validate the token.

            Notice that GetEmailVerificationToken requires both the email and password.
         */
        public static void Execute()
        {
            CustomerApi customerApi = new CustomerApi(Constants.ApiKey);

            string email = "test@ultracart.com";
            string password = "squirrel";

            EmailVerifyTokenRequest tokenRequest = new EmailVerifyTokenRequest();
            tokenRequest.Email = email;
            tokenRequest.Password = password;

            EmailVerifyTokenResponse tokenResponse = customerApi.GetEmailVerificationToken(tokenRequest);
            string token = tokenResponse.Token;

            // TODO - email the token to the customer, have them enter it back into another page...
            // TODO - verify the token with the following call

            EmailVerifyTokenValidateRequest verifyRequest = new EmailVerifyTokenValidateRequest();
            verifyRequest.Token = token;
            EmailVerifyTokenValidateResponse verifyResponse = customerApi.ValidateEmailVerificationToken(verifyRequest);

            Console.WriteLine("Was the correct token provided? " + verifyResponse.Success);
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenRequest** | [**EmailVerifyTokenRequest**](EmailVerifyTokenRequest.md)| Token request | 

### Return type

[**EmailVerifyTokenResponse**](EmailVerifyTokenResponse.md)

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
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetMagicLink

> CustomerMagicLinkResponse GetMagicLink (int customerProfileOid, string storefrontHostName)

getMagicLink

Retrieves a magic link to allow a merchant to login as a customer.  This method is a PUT call intentionally. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using System.Web;
using com.ultracart.admin.v2.Client;

namespace SdkSample.customer
{
    public class GetMagicLink
    {
        public static void Execute()
        {
            /*
                getMagicLink returns back a url whereby a merchant can log into their website as the customer.
                This may be useful to "see what the customer is seeing" and is the only method to do so since
                the customer's passwords are encrypted.  Note: A merchant may also do this using the UltraCart
                backend site within the Customer Management section.
             */

            try
            {
                CustomerApi customerApi = new CustomerApi(Constants.ApiKey);

                // create a customer
                int customerOid = CustomerFunctions.InsertSampleCustomer();
                string storefront = "www.website.com";  // required.  many merchants have dozens of storefronts. which one?

                CustomerMagicLinkResponse apiResponse = customerApi.GetMagicLink(customerOid, storefront);
                string url = apiResponse.Url;

                Console.WriteLine("<html><body><script>window.location.href = " + HttpUtility.UrlEncode(url) + ";</script></body></html>");

                // clean up this sample. - don't do this or the above magic link won't work.  But you'll want to clean up this
                // sample customer manually using the backend.
                // CustomerFunctions.DeleteSampleCustomer(customerOid);

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
 **customerProfileOid** | **int**| The customer_profile_oid of the customer. | 
 **storefrontHostName** | **string**| The storefront to log into. | 

### Return type

[**CustomerMagicLinkResponse**](CustomerMagicLinkResponse.md)

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


## InsertCustomer

> CustomerResponse InsertCustomer (Customer customer, string expand = null)

Insert a customer

Insert a customer on the UltraCart account. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace SdkSample.customer
{
    public class InsertCustomer
    {
        public static void Execute()
        {
            try
            {
                int customerOid = CustomerFunctions.InsertSampleCustomer();
                CustomerFunctions.DeleteSampleCustomer(customerOid);
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
 **customer** | [**Customer**](Customer.md)| Customer to insert | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CustomerResponse**](CustomerResponse.md)

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


## InsertWishListItem

> CustomerWishListItem InsertWishListItem (int customerProfileOid, CustomerWishListItem wishlistItem)

Insert a customer wishlist item

Insert a customer wishlist item 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;
using SdkSample.item;

namespace SdkSample.customer
{
    public class InsertWishListItem
    {
        public static void Execute()
        {
            /*
                The wishlist methods allow management of a customer's wishlist.
                This includes:
                    DeleteWishListItem
                    GetCustomerWishList
                    GetCustomerWishListItem
                    InsertWishListItem
                    UpdateWishListItem
                These methods provide a standard CRUD interface.  The example below uses all of them.

                You'll need merchant_item_oids to insert wishlist items.  If you don't know the oids,
                call ItemApi.GetItemByMerchantItemId() to retrieve the item, then get item.MerchantItemOid

                Note: Priority of wishlist item, 3 being low priority and 5 is high priority.
             */

            try
            {
                CustomerApi customerApi = new CustomerApi(Constants.ApiKey);

                // create a few items first.
                int firstItemOid = ItemFunctions.InsertSampleItemAndGetOid();
                int secondItemOid = ItemFunctions.InsertSampleItemAndGetOid();

                // create a customer
                int customerOid = CustomerFunctions.InsertSampleCustomer();

                // TODO: If you don't know the customer oid, use GetCustomerByEmail() to retrieve the customer.

                // add some wish list items.
                CustomerWishListItem addWishItem = new CustomerWishListItem();
                addWishItem.CustomerProfileOid = customerOid;
                addWishItem.MerchantItemOid = firstItemOid;
                addWishItem.Comments = "I really want this for my birthday";
                addWishItem.Priority = 3; // Priority of wishlist item, 3 being low priority and 5 is high priority.
                CustomerWishListItem firstCreatedWishItem = customerApi.InsertWishListItem(customerOid, addWishItem);

                addWishItem = new CustomerWishListItem();
                addWishItem.CustomerProfileOid = customerOid;
                addWishItem.MerchantItemOid = secondItemOid;
                addWishItem.Comments = "Christmas Idea!";
                addWishItem.Priority = 5; // Priority of wishlist item, 3 being low priority and 5 is high priority.
                CustomerWishListItem secondCreatedWishItem = customerApi.InsertWishListItem(customerOid, addWishItem);

                // retrieve one wishlist item again
                CustomerWishListItem firstCreatedWishItemCopy = customerApi.GetCustomerWishListItem(customerOid, firstCreatedWishItem.CustomerWishlistItemOid).WishlistItem;
                // retrieve all wishlist items
                List<CustomerWishListItem> allWishListItems = customerApi.GetCustomerWishList(customerOid).WishlistItems;

                // update an item.
                secondCreatedWishItem.Priority = 4;
                CustomerWishListItem updatedSecondWishItem = customerApi.UpdateWishListItem(customerOid, secondCreatedWishItem.CustomerWishlistItemOid, secondCreatedWishItem);

                // delete a wish list item
                customerApi.DeleteWishListItem(customerOid, firstCreatedWishItem.CustomerWishlistItemOid);

                // Clean up
                CustomerFunctions.DeleteSampleCustomer(customerOid);
                ItemFunctions.DeleteSampleItemByOid(firstItemOid);
                ItemFunctions.DeleteSampleItemByOid(secondItemOid);
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
 **customerProfileOid** | **int**| The customer oid for this wishlist. | 
 **wishlistItem** | [**CustomerWishListItem**](CustomerWishListItem.md)| Wishlist item to insert | 

### Return type

[**CustomerWishListItem**](CustomerWishListItem.md)

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


## MergeCustomer

> void MergeCustomer (int customerProfileOid, CustomerMergeRequest customer, string expand = null)

Merge customer into this customer

Merge customer into this customer. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace SdkSample.customer
{
    public class MergeCustomer
    {
        public static void Execute()
        {
            /*
                The merge function was requested by UltraCart merchants that sell software and manage activation keys.  Frequently,
                customers would purchase their software using one email address, and then accidentally re-subscribe using a
                different email address (for example, they purchased subsequent years using PayPal which was tied to their spouse's
                email).  However it happened, the customer now how software licenses spread across multiple emails and therefore
                multiple customer profiles.

                merge combine the customer profiles, merging order history and software entitlements.  Still, it may be used to
                combine any two customer profiles for any reason.

                Success returns back a status code 204 (No Content)
             */

            try
            {
                // first customer
                int firstCustomerOid = CustomerFunctions.InsertSampleCustomer();

                string secondEmail = CustomerFunctions.CreateRandomEmail();
                int secondCustomerOid = CustomerFunctions.InsertSampleCustomer(secondEmail);

                CustomerMergeRequest mergeRequest = new CustomerMergeRequest();
                // Supply either the email or the customer oid.  Only need one.
                mergeRequest.Email = secondEmail;
                // mergeRequest.CustomerProfileOid = customerOid;

                CustomerApi customerApi = new CustomerApi(Constants.ApiKey);
                customerApi.MergeCustomer(firstCustomerOid, mergeRequest);

                // clean up this sample.
                CustomerFunctions.DeleteSampleCustomer(firstCustomerOid);
                // Notice: No need to delete the second sample.  The merge call deletes it.
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
 **customerProfileOid** | **int**| The customer_profile_oid to update. | 
 **customer** | [**CustomerMergeRequest**](CustomerMergeRequest.md)| Customer to merge into this profile. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

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


## SearchCustomerProfileValues

> LookupResponse SearchCustomerProfileValues (LookupRequest lookupRequest)

Searches for all matching values (using POST)


### Example

```csharp
// This is an internal method used by our Customer management screen.  It only searches customer tags and is geared
// towards our UI needs, so it's inflexible.  We're not including a sample for it because we don't envision it
// being valuable to a merchant.
// getCustomersByQuery is the merchant's search method.  It is completely full-featured and easy to use.
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lookupRequest** | [**LookupRequest**](LookupRequest.md)| LookupRequest | 

### Return type

[**LookupResponse**](LookupResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
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


## UpdateCustomer

> CustomerResponse UpdateCustomer (int customerProfileOid, Customer customer, string expand = null)

Update a customer

Update a customer on the UltraCart account. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace SdkSample.customer
{
    public class UpdateCustomer
    {
        public static void Execute()
        {
            try
            {
                int customerOid = CustomerFunctions.InsertSampleCustomer();

                CustomerApi customerApi = new CustomerApi(Constants.ApiKey);
                // just want address fields.  see https://www.ultracart.com/api/#resource_customer.html for all expansion values
                string expand = "billing,shipping";
                Customer customer = customerApi.GetCustomer(customerOid, expand).Customer;
                // TODO: do some edits to the customer.  Here we will change some billing fields.
                customer.Billing[0].Address2 = "Apartment 101";

                // notice expand is passed to update as well since it returns back an updated customer object.
                // we use the same expansion, so we get back the same fields and can do comparisons.
                CustomerResponse apiResponse = customerApi.UpdateCustomer(customerOid, customer, expand);

                // verify the update
                Console.WriteLine(apiResponse.Customer);

                CustomerFunctions.DeleteSampleCustomer(customerOid);
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
 **customerProfileOid** | **int**| The customer_profile_oid to update. | 
 **customer** | [**Customer**](Customer.md)| Customer to update | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CustomerResponse**](CustomerResponse.md)

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


## UpdateCustomerEmailLists

> CustomerEmailListChanges UpdateCustomerEmailLists (int customerProfileOid, CustomerEmailListChanges listChanges)

Update email list subscriptions for a customer

Update email list subscriptions for a customer 


### Example

```csharp
// This is an internal method used by our Email workflow engines.  It allows for updating the email lists a customer
// is currently subscribed to.  It's geared towards our UI needs, so its usage may appear cryptic.
//  We're not including a sample for it because we don't envision it being valuable to a merchant.
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerProfileOid** | **int**| The customer profile oid | 
 **listChanges** | [**CustomerEmailListChanges**](CustomerEmailListChanges.md)| List changes | 

### Return type

[**CustomerEmailListChanges**](CustomerEmailListChanges.md)

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


## UpdateWishListItem

> CustomerWishListItem UpdateWishListItem (int customerProfileOid, int customerWishlistItemOid, CustomerWishListItem wishlistItem)

Update a customer wishlist item

Update a customer wishlist item 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;
using SdkSample.item;

namespace SdkSample.customer
{
    public class UpdateWishListItem
    {
        public static void Execute()
        {
            /*
                The wishlist methods allow management of a customer's wishlist.
                This includes:
                    DeleteWishListItem
                    GetCustomerWishList
                    GetCustomerWishListItem
                    InsertWishListItem
                    UpdateWishListItem
                These methods provide a standard CRUD interface.  The example below uses all of them.

                You'll need merchant_item_oids to insert wishlist items.  If you don't know the oids,
                call ItemApi.GetItemByMerchantItemId() to retrieve the item, then get item.MerchantItemOid

                Note: Priority of wishlist item, 3 being low priority and 5 is high priority.
             */

            try
            {
                CustomerApi customerApi = new CustomerApi(Constants.ApiKey);

                // create a few items first.
                int firstItemOid = ItemFunctions.InsertSampleItemAndGetOid();
                int secondItemOid = ItemFunctions.InsertSampleItemAndGetOid();

                // create a customer
                int customerOid = CustomerFunctions.InsertSampleCustomer();

                // TODO: If you don't know the customer oid, use GetCustomerByEmail() to retrieve the customer.

                // add some wish list items.
                CustomerWishListItem addWishItem = new CustomerWishListItem();
                addWishItem.CustomerProfileOid = customerOid;
                addWishItem.MerchantItemOid = firstItemOid;
                addWishItem.Comments = "I really want this for my birthday";
                addWishItem.Priority = 3; // Priority of wishlist item, 3 being low priority and 5 is high priority.
                CustomerWishListItem firstCreatedWishItem = customerApi.InsertWishListItem(customerOid, addWishItem);

                addWishItem = new CustomerWishListItem();
                addWishItem.CustomerProfileOid = customerOid;
                addWishItem.MerchantItemOid = secondItemOid;
                addWishItem.Comments = "Christmas Idea!";
                addWishItem.Priority = 5; // Priority of wishlist item, 3 being low priority and 5 is high priority.
                CustomerWishListItem secondCreatedWishItem = customerApi.InsertWishListItem(customerOid, addWishItem);

                // retrieve one wishlist item again
                CustomerWishListItem firstCreatedWishItemCopy = customerApi.GetCustomerWishListItem(customerOid, firstCreatedWishItem.CustomerWishlistItemOid).WishlistItem;
                // retrieve all wishlist items
                List<CustomerWishListItem> allWishListItems = customerApi.GetCustomerWishList(customerOid).WishlistItems;

                // update an item.
                secondCreatedWishItem.Priority = 4;
                CustomerWishListItem updatedSecondWishItem = customerApi.UpdateWishListItem(customerOid, secondCreatedWishItem.CustomerWishlistItemOid, secondCreatedWishItem);

                // delete a wish list item
                customerApi.DeleteWishListItem(customerOid, firstCreatedWishItem.CustomerWishlistItemOid);

                // Clean up
                CustomerFunctions.DeleteSampleCustomer(customerOid);
                ItemFunctions.DeleteSampleItemByOid(firstItemOid);
                ItemFunctions.DeleteSampleItemByOid(secondItemOid);
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
 **customerProfileOid** | **int**| The customer oid for this wishlist. | 
 **customerWishlistItemOid** | **int**| The wishlist oid for this wishlist item. | 
 **wishlistItem** | [**CustomerWishListItem**](CustomerWishListItem.md)| Wishlist item to update | 

### Return type

[**CustomerWishListItem**](CustomerWishListItem.md)

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


## ValidateEmailVerificationToken

> EmailVerifyTokenValidateResponse ValidateEmailVerificationToken (EmailVerifyTokenValidateRequest validationRequest)

Validate a token that can be used to verify a customer email address

Validate a token that can be used to verify a customer email address.  The implementation of how a customer interacts with this token is left to the merchant. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.customer
{
    public class ValidateEmailVerificationToken
    {
        public static void Execute()
        {
            /*
                GetEmailVerificationToken and ValidateEmailVerificationToken are tandem functions that allow a merchant to verify
                a customer's email address. GetEmailVerificationToken returns back a token that the merchant can use however
                they wish to present to a customer. Usually this will be emailed to the customer within instructions to enter
                it back into a website.  Once the customer enters the token back into a site (along with their email),
                ValidateEmailVerificationToken will validate the token.

                Notice that GetEmailVerificationToken requires both the email and password.
             */

            CustomerApi customerApi = new CustomerApi(Constants.ApiKey);

            string email = "test@ultracart.com";
            string password = "squirrel";

            EmailVerifyTokenRequest tokenRequest = new EmailVerifyTokenRequest();
            tokenRequest.Email = email;
            tokenRequest.Password = password;

            EmailVerifyTokenResponse tokenResponse = customerApi.GetEmailVerificationToken(tokenRequest);
            string token = tokenResponse.Token;

            // TODO - email the token to the customer, have them enter it back into another page...
            // TODO - verify the token with the following call

            EmailVerifyTokenValidateRequest verifyRequest = new EmailVerifyTokenValidateRequest();
            verifyRequest.Token = token;
            EmailVerifyTokenValidateResponse verifyResponse = customerApi.ValidateEmailVerificationToken(verifyRequest);

            Console.WriteLine("Was the correct token provided? " + verifyResponse.Success);
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **validationRequest** | [**EmailVerifyTokenValidateRequest**](EmailVerifyTokenValidateRequest.md)| Token validation request | 

### Return type

[**EmailVerifyTokenValidateResponse**](EmailVerifyTokenValidateResponse.md)

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
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

