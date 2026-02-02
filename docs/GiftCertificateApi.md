# com.ultracart.admin.v2.Api.GiftCertificateApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddGiftCertificateLedgerEntry**](GiftCertificateApi.md#addgiftcertificateledgerentry) | **POST** /gift_certificate/gift_certificates/{gift_certificate_oid}/ledger_entry | Add a gift certificate ledger entry
[**CreateGiftCertificate**](GiftCertificateApi.md#creategiftcertificate) | **POST** /gift_certificate/gift_certificates | Create a gift certificate
[**DeleteGiftCertificate**](GiftCertificateApi.md#deletegiftcertificate) | **DELETE** /gift_certificate/gift_certificates/{gift_certificate_oid} | Delete a gift certificate
[**GetGiftCertificateByCode**](GiftCertificateApi.md#getgiftcertificatebycode) | **POST** /gift_certificate/gift_certificates/by_code/{code} | Retrieve gift certificate by code
[**GetGiftCertificateByOid**](GiftCertificateApi.md#getgiftcertificatebyoid) | **POST** /gift_certificate/gift_certificates/{gift_certificate_oid} | Retrieve gift certificate by oid
[**GetGiftCertificatesByEmail**](GiftCertificateApi.md#getgiftcertificatesbyemail) | **POST** /gift_certificate/gift_certificates/by_email/{email} | Retrieve gift certificate by email
[**GetGiftCertificatesByQuery**](GiftCertificateApi.md#getgiftcertificatesbyquery) | **POST** /gift_certificate/gift_certificates/query | Retrieve gift certificates by query
[**UpdateGiftCertificate**](GiftCertificateApi.md#updategiftcertificate) | **PUT** /gift_certificate/gift_certificates/{gift_certificate_oid} | Update a gift certificate



## AddGiftCertificateLedgerEntry

> GiftCertificateResponse AddGiftCertificateLedgerEntry (int giftCertificateOid, GiftCertificateLedgerEntry giftCertificateLedgerEntry)

Add a gift certificate ledger entry

Adds a ledger entry for this gift certificate. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.gift_certificate
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class AddGiftCertificateLedgerEntry
    {
        public static void Execute()
        {
            var giftCertificate = AddGiftCertificateLedgerEntryCall();
            Utility.DumpObject(giftCertificate, "Gift Certificate");
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public static GiftCertificate AddGiftCertificateLedgerEntryCall()
        {
            var api = new GiftCertificateApi(Constants.ApiKey);
            
            const int giftCertificateOid = 676713;
            
            GiftCertificateLedgerEntry ledgerEntry = new GiftCertificateLedgerEntry()
            {
                Amount = new Decimal(-15.35),  // this is the change amount in the gift certificate.  this is not a balance.  it will be subtracted from it.
                Description = "Customer bought something over the counter using this gift certificate.",
                EntryDts = DateTime.UtcNow.ToString("s", System.Globalization.CultureInfo.InvariantCulture),
                GiftCertificateLedgerOid = 0,  // the system will assign an oid.  do not assign one here.
                GiftCertificateOid = giftCertificateOid,  // this is an existing gift certificate oid.  I created it using createGiftCertificate.ts
                ReferenceOrderId = "BLAH-12345" // if this ledger entry is related to an order, add it here, else use null.                
            };

            // add ledger entry does not take an expansion variable.  it will return the entire object by default.
            var gcResponse = api.AddGiftCertificateLedgerEntry(giftCertificateOid, ledgerEntry);
            return gcResponse.GiftCertificate;
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **giftCertificateOid** | **int**|  | 
 **giftCertificateLedgerEntry** | [**GiftCertificateLedgerEntry**](GiftCertificateLedgerEntry.md)| Gift certificate ledger entry | 

### Return type

[**GiftCertificateResponse**](GiftCertificateResponse.md)

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


## CreateGiftCertificate

> GiftCertificateResponse CreateGiftCertificate (GiftCertificateCreateRequest giftCertificateCreateRequest)

Create a gift certificate

Creates a gift certificate for this merchant account. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.gift_certificate
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class CreateGiftCertificate
    {

        public static void Execute()
        {
            var giftCertificate = CreateGiftCertificateCall();
            Utility.DumpObject(giftCertificate, "Gift Certificate");
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public static GiftCertificate CreateGiftCertificateCall()
        {
            var api = new GiftCertificateApi(Constants.ApiKey);
            
            GiftCertificateCreateRequest createRequest = new GiftCertificateCreateRequest()
            {
                Amount = new Decimal(200.00),
                InitialLedgerDescription = "Created via C# SDK",
                MerchantNote = "Internal comment here",
                Email = "support@ultracart.com",
                ExpirationDts = DateTime.UtcNow.AddMonths(3).ToString("s", System.Globalization.CultureInfo.InvariantCulture)
            };

            // create does not take an expansion variable.  it will return the entire object by default.
            var gcResponse = api.CreateGiftCertificate(createRequest);
            return gcResponse.GiftCertificate;
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **giftCertificateCreateRequest** | [**GiftCertificateCreateRequest**](GiftCertificateCreateRequest.md)| Gift certificate create request | 

### Return type

[**GiftCertificateResponse**](GiftCertificateResponse.md)

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


## DeleteGiftCertificate

> void DeleteGiftCertificate (int giftCertificateOid)

Delete a gift certificate

Deletes a gift certificate for this merchant account. 


### Example

```csharp
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.gift_certificate
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class DeleteGiftCertificate
    {
        public static void Execute()
        {
            var giftCertificate = DeleteGiftCertificateCall();
            Utility.DumpObject(giftCertificate, "Gift Certificate");
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public static GiftCertificate DeleteGiftCertificateCall()
        {
            var api = new GiftCertificateApi(Constants.ApiKey);
            
            const int giftCertificateOid = 676713;
            api.DeleteGiftCertificate(giftCertificateOid);

            // if I re-query the gift certificate after deleting, I will still get an object back, but the
            // deleted flag on the object will be true.
            // by_oid does not take an expansion variable.  it will return the entire object by default.
            var gcResponse = api.GetGiftCertificateByOid(giftCertificateOid);
            return gcResponse.GiftCertificate;
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **giftCertificateOid** | **int**|  | 

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


## GetGiftCertificateByCode

> GiftCertificateResponse GetGiftCertificateByCode (string code)

Retrieve gift certificate by code

Retrieves a gift certificate from the account based on the code (the value the customer enters at checkout time). 


### Example

```csharp
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.gift_certificate
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class GetGiftCertificateByCode
    {
        public static void Execute()
        {
            var giftCertificate = GetGiftCertificateByCodeCall();
            Utility.DumpObject(giftCertificate, "Gift Certificate");
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public static GiftCertificate GetGiftCertificateByCodeCall()
        {
            var api = new GiftCertificateApi(Constants.ApiKey);
            
            const string code = "X8PV761V2Z";

            // by_code does not take an expansion variable.  it will return the entire object by default.
            var gcResponse = api.GetGiftCertificateByCode(code);
            return gcResponse.GiftCertificate;
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**|  | 

### Return type

[**GiftCertificateResponse**](GiftCertificateResponse.md)

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


## GetGiftCertificateByOid

> GiftCertificateResponse GetGiftCertificateByOid (int giftCertificateOid)

Retrieve gift certificate by oid

Retrieves a gift certificate from the account based on the internal primary key. 


### Example

```csharp
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.gift_certificate
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class GetGiftCertificateByOid
    {
        
        public static void Execute()
        {
            var giftCertificate = GetGiftCertificateByOidCall();
            Utility.DumpObject(giftCertificate, "Gift Certificate");
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public static GiftCertificate GetGiftCertificateByOidCall()
        {
            var api = new GiftCertificateApi(Constants.ApiKey);
            
            const int giftCertificateOid = 676713;

            // by_oid does not take an expansion variable.  it will return the entire object by default.
            var gcResponse = api.GetGiftCertificateByOid(giftCertificateOid);
            return gcResponse.GiftCertificate;
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **giftCertificateOid** | **int**|  | 

### Return type

[**GiftCertificateResponse**](GiftCertificateResponse.md)

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


## GetGiftCertificatesByEmail

> GiftCertificatesResponse GetGiftCertificatesByEmail (string email)

Retrieve gift certificate by email

Retrieves all gift certificates from the account based on customer email. 


### Example

```csharp
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.gift_certificate
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class GetGiftCertificatesByEmail
    {
        public static void Execute()
        {
            var giftCertificates = GetGiftCertificatesByEmailCall();
            Utility.DumpObject(giftCertificates, "Gift Certificates");
            foreach (var gc in giftCertificates)
            {
                Utility.DumpObject(gc, "Gift Certificate");
            }
            
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public static List<GiftCertificate> GetGiftCertificatesByEmailCall()
        {
            var api = new GiftCertificateApi(Constants.ApiKey);
            
            const string email = "support@ultracart.com";

            // by_email does not take an expansion variable.  it will return the entire object by default.
            var gcResponse = api.GetGiftCertificatesByEmail(email);
            return gcResponse.GiftCertificates;
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**|  | 

### Return type

[**GiftCertificatesResponse**](GiftCertificatesResponse.md)

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


## GetGiftCertificatesByQuery

> GiftCertificatesResponse GetGiftCertificatesByQuery (GiftCertificateQuery giftCertificateQuery, int? limit = null, int? offset = null, string since = null, string sort = null, string expand = null)

Retrieve gift certificates by query

Retrieves gift certificates from the account.  If no parameters are specified, all gift certificates will be returned.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 


### Example

```csharp
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.gift_certificate
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class GetGiftCertificatesByQuery
    {

        public static void Execute()
        {
            var giftCertificates = GetGiftCertificateByQueryCall();
            foreach (var giftCertificate in giftCertificates)
            {
                Utility.DumpObject(giftCertificate, "Gift Certificate");    
            }
        }


        private static List<GiftCertificate> GetGiftCertificateChunk(GiftCertificateApi api, int offset, int limit)
        {
            const string expansion = "ledger";

            // leaving query empty, so no filtering, and I should get all records returned.
            GiftCertificateQuery query = new GiftCertificateQuery();
            
            var gcResponse = api.GetGiftCertificatesByQuery(query, limit, offset, null, null, expansion);
                if(gcResponse.Success == true && gcResponse.GiftCertificates != null){
                    return gcResponse.GiftCertificates;
                }

                return new List<GiftCertificate>();
        }
        
        
        
        // ReSharper disable once MemberCanBePrivate.Global
        public static List<GiftCertificate> GetGiftCertificateByQueryCall()
        {
            var api = new GiftCertificateApi(Constants.ApiKey);

            List<GiftCertificate> giftCertificates = new List<GiftCertificate>();

            var iteration = 1;
            var offset = 0;
            var limit = 200;
            var moreRecordsToFetch = true;

            while( moreRecordsToFetch ){

                System.Console.WriteLine("executing iteration " + iteration);
                var chuckOfCertificates = GetGiftCertificateChunk(api, offset, limit);
                giftCertificates.AddRange(chuckOfCertificates);
                offset += limit;
                moreRecordsToFetch = chuckOfCertificates.Count == limit;
                iteration++;
                
            }
            

            return giftCertificates;
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **giftCertificateQuery** | [**GiftCertificateQuery**](GiftCertificateQuery.md)| Gift certificates query | 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Max 200) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **since** | **string**| Fetch customers that have been created/modified since this date/time. | [optional] 
 **sort** | **string**| The sort order of the customers.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**GiftCertificatesResponse**](GiftCertificatesResponse.md)

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


## UpdateGiftCertificate

> GiftCertificateResponse UpdateGiftCertificate (int giftCertificateOid, GiftCertificate giftCertificate)

Update a gift certificate

Update a gift certificate for this merchant account. 


### Example

```csharp
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.gift_certificate
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class UpdateGiftCertificate
    {
        public static void Execute()
        {
            var giftCertificate = UpdateGiftCertificateCall();
            Utility.DumpObject(giftCertificate, "Gift Certificate");
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public static GiftCertificate UpdateGiftCertificateCall()
        {
            var api = new GiftCertificateApi(Constants.ApiKey);
            
            const int giftCertificateOid = 676713;
            
            var gcResponse = api.GetGiftCertificateByOid(giftCertificateOid);
            var giftCertificate = gcResponse.GiftCertificate;
            giftCertificate.Email = "perry@ultracart.com";
            

            // update does not take an expansion variable.  it will return the entire object by default.
            gcResponse = api.UpdateGiftCertificate(giftCertificateOid, giftCertificate);
            return gcResponse.GiftCertificate;
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **giftCertificateOid** | **int**|  | 
 **giftCertificate** | [**GiftCertificate**](GiftCertificate.md)| Gift certificate | 

### Return type

[**GiftCertificateResponse**](GiftCertificateResponse.md)

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

