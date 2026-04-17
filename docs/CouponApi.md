# com.ultracart.admin.v2.Api.CouponApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCoupon**](CouponApi.md#deletecoupon) | **DELETE** /coupon/coupons/{coupon_oid} | Delete a coupon
[**DeleteCouponsByCode**](CouponApi.md#deletecouponsbycode) | **DELETE** /coupon/coupons/by_code | Deletes multiple coupons
[**DeleteCouponsByOid**](CouponApi.md#deletecouponsbyoid) | **DELETE** /coupon/coupons/by_oid | Deletes multiple coupons
[**DoesCouponCodeExist**](CouponApi.md#doescouponcodeexist) | **GET** /coupon/coupons/merchant_code/{merchant_code}/exists | Determines if a coupon merchant code already exists
[**GenerateCouponCodes**](CouponApi.md#generatecouponcodes) | **POST** /coupon/coupons/{coupon_oid}/generate_codes | Generates one time codes for a coupon
[**GenerateOneTimeCodesByMerchantCode**](CouponApi.md#generateonetimecodesbymerchantcode) | **POST** /coupon/coupons/merchant_code/{merchant_code}/generate_codes | Generates one time codes by merchant code
[**GetAutoApply**](CouponApi.md#getautoapply) | **GET** /coupon/auto_apply | Retrieve auto apply rules and conditions
[**GetCoupon**](CouponApi.md#getcoupon) | **GET** /coupon/coupons/{coupon_oid} | Retrieve a coupon
[**GetCouponByMerchantCode**](CouponApi.md#getcouponbymerchantcode) | **GET** /coupon/coupons/merchant_code/{merchant_code} | Retrieve a coupon by merchant code
[**GetCoupons**](CouponApi.md#getcoupons) | **GET** /coupon/coupons | Retrieve coupons
[**GetCouponsByQuery**](CouponApi.md#getcouponsbyquery) | **POST** /coupon/coupons/query | Retrieve coupons by query
[**GetEditorValues**](CouponApi.md#geteditorvalues) | **GET** /coupon/editor_values | Retrieve values needed for a coupon editor
[**InsertCoupon**](CouponApi.md#insertcoupon) | **POST** /coupon/coupons | Insert a coupon
[**InsertCoupons**](CouponApi.md#insertcoupons) | **POST** /coupon/coupons/batch | Insert multiple coupons
[**SearchItems**](CouponApi.md#searchitems) | **GET** /coupon/searchItems | Searches for items to display within a coupon editor and assign to coupons
[**UpdateAutoApply**](CouponApi.md#updateautoapply) | **POST** /coupon/auto_apply | Update auto apply rules and conditions
[**UpdateCoupon**](CouponApi.md#updatecoupon) | **PUT** /coupon/coupons/{coupon_oid} | Update a coupon
[**UpdateCoupons**](CouponApi.md#updatecoupons) | **PUT** /coupon/coupons/batch | Update multiple coupons
[**UploadCouponCodes**](CouponApi.md#uploadcouponcodes) | **POST** /coupon/coupons/{coupon_oid}/upload_codes | Upload one-time codes for a coupon



## DeleteCoupon

> void DeleteCoupon (int couponOid)

Delete a coupon

Delete a coupon on the UltraCart account. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.coupon
{
    public class DeleteCoupon
    {
        
        /// <summary>
        /// Deletes a specific coupon using the UltraCart API
        /// </summary>
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            CouponApi couponApi = new CouponApi(Constants.ApiKey);
            string expand = null; // coupons do not have expansions.
            
            Coupon coupon = new Coupon();
            coupon.MerchantCode = Guid.NewGuid().ToString("N").Substring(0, 8);
            coupon.Description = "Test coupon for sdk_sample.coupon.DeleteCoupon";
            coupon.AmountOffSubtotal = new CouponAmountOffSubtotal("USD", 0.01m); // one penny discount.

            CouponResponse couponResponse = couponApi.InsertCoupon(coupon, expand);
            coupon = couponResponse.Coupon;

            Console.WriteLine("Created the following temporary coupon:");
            Console.WriteLine($"Coupon OID: {coupon.CouponOid}");
            Console.WriteLine($"Coupon Type: {coupon.CouponType}");
            Console.WriteLine($"Coupon Description: {coupon.Description}");
            
            int couponOid = coupon.CouponOid;
            
            // Delete the coupon
            couponApi.DeleteCoupon(couponOid);

            Console.WriteLine($"Successfully deleted coupon with ID: {couponOid}");
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponOid** | **int**| The coupon_oid to delete. | 

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


## DeleteCouponsByCode

> void DeleteCouponsByCode (CouponDeletesRequest couponDeleteRequest)

Deletes multiple coupons

Delete coupons on the UltraCart account. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.coupon
{
    public class DeleteCouponsByCode
    {
        
        /// <summary>
        /// Deletes a specific coupon using the UltraCart API
        /// </summary>
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");

            CouponApi couponApi = new CouponApi(Constants.ApiKey);
            string expand = null; // coupons do not have expansions.

            String merchantCode = Guid.NewGuid().ToString("N").Substring(0, 8);
            
            Coupon coupon = new Coupon();
            coupon.MerchantCode = merchantCode; 
            coupon.Description = "Test coupon for DeleteCouponsByCode";
            coupon.AmountOffSubtotal = new CouponAmountOffSubtotal("USD", 0.01m); // one penny discount.

            CouponResponse couponResponse = couponApi.InsertCoupon(coupon, expand);
            coupon = couponResponse.Coupon;

            Console.WriteLine("Created the following temporary coupon:");
            Console.WriteLine($"Coupon OID: {coupon.MerchantCode}");
            Console.WriteLine($"Coupon Type: {coupon.CouponType}");
            Console.WriteLine($"Coupon Description: {coupon.Description}");
            
            // Delete the coupon
            CouponDeletesRequest deleteRequest = new CouponDeletesRequest();
            deleteRequest.CouponCodes = new List<string> { merchantCode };             
            couponApi.DeleteCouponsByCode(deleteRequest);

            Console.WriteLine($"Successfully deleted coupon with merchantCode: {merchantCode}");
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponDeleteRequest** | [**CouponDeletesRequest**](CouponDeletesRequest.md)| Coupon oids to delete | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
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


## DeleteCouponsByOid

> void DeleteCouponsByOid (CouponDeletesRequest couponDeleteRequest)

Deletes multiple coupons

Delete coupons on the UltraCart account. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.coupon
{
    public class DeleteCouponsByOid
    {
        
        /// <summary>
        /// Deletes a specific coupon using the UltraCart API
        /// </summary>
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");

            CouponApi couponApi = new CouponApi(Constants.ApiKey);
            string expand = null; // coupons do not have expansions.

            String merchantCode = Guid.NewGuid().ToString("N").Substring(0, 8);
            
            Coupon coupon = new Coupon();
            coupon.MerchantCode = merchantCode; 
            coupon.Description = "Test coupon for DeleteCouponsByCode";
            coupon.AmountOffSubtotal = new CouponAmountOffSubtotal("USD", 0.01m); // one penny discount.

            CouponResponse couponResponse = couponApi.InsertCoupon(coupon, expand);
            coupon = couponResponse.Coupon;

            Console.WriteLine("Created the following temporary coupon:");
            Console.WriteLine($"Coupon OID: {coupon.MerchantCode}");
            Console.WriteLine($"Coupon Type: {coupon.CouponType}");
            Console.WriteLine($"Coupon Description: {coupon.Description}");
            
            // Delete the coupon
            CouponDeletesRequest deleteRequest = new CouponDeletesRequest();
            deleteRequest.CouponOids = new List<int> { coupon.CouponOid };             
            couponApi.DeleteCouponsByCode(deleteRequest);

            Console.WriteLine($"Successfully deleted coupon with merchantCode: {merchantCode}");
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponDeleteRequest** | [**CouponDeletesRequest**](CouponDeletesRequest.md)| Coupon oids to delete | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
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


## DoesCouponCodeExist

> CouponExistsResponse DoesCouponCodeExist (string merchantCode)

Determines if a coupon merchant code already exists

Determines if a coupon merchant code already exists. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.coupon
{
    public class DoesCouponCodeExist
    {
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");

            try
            {
                CouponApi couponApi = new CouponApi(Constants.ApiKey);

                String merchantCode = Guid.NewGuid().ToString("N").Substring(0, 8);

                CouponExistsResponse couponExistsResponse = couponApi.DoesCouponCodeExist(merchantCode);
                // The response should be false.
                if (couponExistsResponse.Exists)
                {
                    throw new Exception("CouponApi.DoesCouponCodeExist should have returned false.");
                }

                // Now create the coupon and ensure it exists.
                Coupon coupon = new Coupon();
                coupon.MerchantCode = merchantCode;
                coupon.Description = "Test coupon for DoesCouponCodeExist";
                coupon.AmountOffSubtotal = new CouponAmountOffSubtotal("USD", 0.01m); // one penny discount.

                CouponResponse couponResponse = couponApi.InsertCoupon(coupon);
                coupon = couponResponse.Coupon;

                Console.WriteLine("Created the following temporary coupon:");
                Console.WriteLine($"Coupon OID: {coupon.MerchantCode}");
                Console.WriteLine($"Coupon Type: {coupon.CouponType}");
                Console.WriteLine($"Coupon Description: {coupon.Description}");

                couponExistsResponse = couponApi.DoesCouponCodeExist(merchantCode);
                if (!couponExistsResponse.Exists)
                {
                    throw new Exception(
                        "CouponApi.DoesCouponCodeExist should have returned true after creating the coupon.");
                }

                // Delete the coupon
                couponApi.DeleteCoupon(coupon.CouponOid);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantCode** | **string**| The coupon merchant code to examine. | 

### Return type

[**CouponExistsResponse**](CouponExistsResponse.md)

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


## GenerateCouponCodes

> CouponCodesResponse GenerateCouponCodes (int couponOid, CouponCodesRequest couponCodesRequest)

Generates one time codes for a coupon

Generate one time codes for a coupon 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.coupon
{
    public class GenerateCouponCodes
    {
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create coupon API instance using API key
                CouponApi couponApi = new CouponApi(Constants.ApiKey);

                String merchantCode = Guid.NewGuid().ToString("N").Substring(0, 8);
                
                // Now create the coupon and ensure it exists.
                Coupon coupon = new Coupon();
                coupon.MerchantCode = merchantCode;
                coupon.Description = "Test coupon for GetCoupon";
                coupon.AmountOffSubtotal = new CouponAmountOffSubtotal("USD", 0.01m); // one penny discount.

                CouponResponse couponResponse = couponApi.InsertCoupon(coupon);
                coupon = couponResponse.Coupon;
                
                
                CouponCodesRequest codesRequest = new CouponCodesRequest();
                codesRequest.Quantity = 5; // give me 5 codes.
                codesRequest.ExpirationDts = DateTime.UtcNow.AddDays(90).ToString("yyyy-MM-ddTHH:mm:ssK"); // do you want the codes to expire?
                // codesRequest.ExpirationSeconds = null; // also an option for short-lived coupons
                
                var apiResponse = couponApi.GenerateCouponCodes(coupon.CouponOid, codesRequest);
                var couponCodes = apiResponse.CouponCodes;
                
                // Display generated coupon codes
                Console.WriteLine($"Generated {couponCodes.Count} coupon codes:");
                foreach (var code in couponCodes)
                {
                    Console.WriteLine(code);
                }
                
                // Delete the coupon
                couponApi.DeleteCoupon(coupon.CouponOid);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponOid** | **int**| The coupon oid to generate codes. | 
 **couponCodesRequest** | [**CouponCodesRequest**](CouponCodesRequest.md)| Coupon code generation parameters | 

### Return type

[**CouponCodesResponse**](CouponCodesResponse.md)

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


## GenerateOneTimeCodesByMerchantCode

> CouponCodesResponse GenerateOneTimeCodesByMerchantCode (string merchantCode, CouponCodesRequest couponCodesRequest)

Generates one time codes by merchant code

Generate one time codes by merchant code 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.coupon
{
    public class GenerateOneTimeCodesByMerchantCode
    {
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create coupon API instance using API key
                CouponApi couponApi = new CouponApi(Constants.ApiKey);

                String merchantCode = Guid.NewGuid().ToString("N").Substring(0, 8);
                
                // Now create the coupon and ensure it exists.
                Coupon coupon = new Coupon();
                coupon.MerchantCode = merchantCode;
                coupon.Description = "Test coupon for GetCoupon";
                coupon.AmountOffSubtotal = new CouponAmountOffSubtotal("USD", 0.01m); // one penny discount.

                CouponResponse couponResponse = couponApi.InsertCoupon(coupon);
                coupon = couponResponse.Coupon;

                Console.WriteLine("Created the following temporary coupon:");
                Console.WriteLine($"Coupon OID: {coupon.MerchantCode}");
                Console.WriteLine($"Coupon Type: {coupon.CouponType}");
                Console.WriteLine($"Coupon Description: {coupon.Description}");
                
                
                CouponCodesRequest codesRequest = new CouponCodesRequest();
                codesRequest.Quantity = 5; // give me 5 codes.
                codesRequest.ExpirationDts = DateTime.UtcNow.AddDays(90).ToString("yyyy-MM-ddTHH:mm:ssK"); // do you want the codes to expire?
                // codesRequest.ExpirationSeconds = null; // also an option for short-lived coupons
                
                var apiResponse = couponApi.GenerateOneTimeCodesByMerchantCode(merchantCode, codesRequest);
                var couponCodes = apiResponse.CouponCodes;
                
                // Display generated coupon codes
                Console.WriteLine($"Generated {couponCodes.Count} one-time coupon codes for merchant code '{merchantCode}':");
                foreach (var code in couponCodes)
                {
                    Console.WriteLine(code);
                }
                
                // Delete the coupon
                couponApi.DeleteCoupon(coupon.CouponOid);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantCode** | **string**| The merchant code to generate one time codes. | 
 **couponCodesRequest** | [**CouponCodesRequest**](CouponCodesRequest.md)| Coupon code generation parameters | 

### Return type

[**CouponCodesResponse**](CouponCodesResponse.md)

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


## GetAutoApply

> CouponAutoApplyConditions GetAutoApply ()

Retrieve auto apply rules and conditions

Retrieve auto apply rules and conditions 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.coupon
{
    public class GetAutoApply
    {
        /*
          getAutoApply returns back the items and subtotals that trigger "auto coupons", i.e. coupons that are automatically
          added to a shopping cart.  The manual configuration of auto coupons is at the bottom of the main coupons screen.
          See: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1376525/Coupons#Coupons-Navigation
        */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create coupon API instance using API key
                CouponApi couponApi = new CouponApi(Constants.ApiKey);
                
                // Get auto apply coupons information
                var apiResponse = couponApi.GetAutoApply();
                
                // Display subtotal levels
                Console.WriteLine("These are the subtotal levels:");
                foreach (var subtotalLevel in apiResponse.SubtotalLevels)
                {
                    Console.WriteLine(subtotalLevel);
                }
                
                // Display item triggers
                Console.WriteLine("These are the item triggers:");
                foreach (var requiredItem in apiResponse.RequiredItems)
                {
                    Console.WriteLine(requiredItem);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters

This endpoint does not need any parameter.

### Return type

[**CouponAutoApplyConditions**](CouponAutoApplyConditions.md)

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


## GetCoupon

> CouponResponse GetCoupon (int couponOid, string expand = null)

Retrieve a coupon

Retrieves a single coupon using the specified coupon profile oid. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.coupon
{
    public class GetCoupon
    {
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");

            try
            {
                CouponApi couponApi = new CouponApi(Constants.ApiKey);

                String merchantCode = Guid.NewGuid().ToString("N").Substring(0, 8);
                
                // Now create the coupon and ensure it exists.
                Coupon coupon = new Coupon();
                coupon.MerchantCode = merchantCode;
                coupon.Description = "Test coupon for GetCoupon";
                coupon.AmountOffSubtotal = new CouponAmountOffSubtotal("USD", 0.01m); // one penny discount.

                CouponResponse couponResponse = couponApi.InsertCoupon(coupon);
                coupon = couponResponse.Coupon;

                Console.WriteLine("Created the following temporary coupon:");
                Console.WriteLine($"Coupon OID: {coupon.MerchantCode}");
                Console.WriteLine($"Coupon Type: {coupon.CouponType}");
                Console.WriteLine($"Coupon Description: {coupon.Description}");

                couponResponse = couponApi.GetCoupon(coupon.CouponOid);
                Coupon copyOfCoupon = couponResponse.Coupon;
                Console.WriteLine("GetCoupon returned the following coupon:");
                Console.WriteLine($"Coupon OID: {copyOfCoupon.MerchantCode}");
                Console.WriteLine($"Coupon Type: {copyOfCoupon.CouponType}");
                Console.WriteLine($"Coupon Description: {copyOfCoupon.Description}");
                
                // Delete the coupon
                couponApi.DeleteCoupon(coupon.CouponOid);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponOid** | **int**| The coupon oid to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CouponResponse**](CouponResponse.md)

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


## GetCouponByMerchantCode

> CouponResponse GetCouponByMerchantCode (string merchantCode, string expand = null)

Retrieve a coupon by merchant code

Retrieves a single coupon using the specified merchant code. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.coupon
{
    public class GetCouponByMerchantCode
    {
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");

            try
            {
                CouponApi couponApi = new CouponApi(Constants.ApiKey);

                String merchantCode = Guid.NewGuid().ToString("N").Substring(0, 8);
                
                // Now create the coupon and ensure it exists.
                Coupon coupon = new Coupon();
                coupon.MerchantCode = merchantCode;
                coupon.Description = "Test coupon for GetCoupon";
                coupon.AmountOffSubtotal = new CouponAmountOffSubtotal("USD", 0.01m); // one penny discount.

                CouponResponse couponResponse = couponApi.InsertCoupon(coupon);
                coupon = couponResponse.Coupon;

                Console.WriteLine("Created the following temporary coupon:");
                Console.WriteLine($"Coupon OID: {coupon.MerchantCode}");
                Console.WriteLine($"Coupon Type: {coupon.CouponType}");
                Console.WriteLine($"Coupon Description: {coupon.Description}");

                couponResponse = couponApi.GetCouponByMerchantCode(merchantCode);
                Coupon copyOfCoupon = couponResponse.Coupon;
                Console.WriteLine("GetCoupon returned the following coupon:");
                Console.WriteLine($"Coupon OID: {copyOfCoupon.MerchantCode}");
                Console.WriteLine($"Coupon Type: {copyOfCoupon.CouponType}");
                Console.WriteLine($"Coupon Description: {copyOfCoupon.Description}");
                
                // Delete the coupon
                couponApi.DeleteCoupon(coupon.CouponOid);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantCode** | **string**| The coupon merchant code to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CouponResponse**](CouponResponse.md)

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


## GetCoupons

> CouponsResponse GetCoupons (string merchantCode = null, string description = null, string couponType = null, string startDateBegin = null, string startDateEnd = null, string expirationDateBegin = null, string expirationDateEnd = null, int? affiliateOid = null, bool? excludeExpired = null, int? limit = null, int? offset = null, string sort = null, string expand = null)

Retrieve coupons

Retrieves coupons for this account.  If no parameters are specified, all coupons will be returned.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.coupon
{
    public class GetCoupons
    {
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                List<Coupon> coupons = new List<Coupon>();
                
                int iteration = 1;
                int offset = 0;
                int limit = 200;
                bool needMoreRecords = true;
                
                while (needMoreRecords)
                {
                    Console.WriteLine($"executing iteration #{iteration++}");
                    List<Coupon> blockOfCoupons = GetCouponsChunk(offset, limit);
                    foreach (Coupon coupon in blockOfCoupons)
                    {
                        coupons.Add(coupon);
                    }
                    
                    offset += limit;
                    needMoreRecords = blockOfCoupons.Count == limit;
                    // Thread.Sleep(1000);  // I'm testing rate limiter headers. this should probably be uncommented. maybe.
                }
                
                // Display the coupons
                foreach (var coupon in coupons)
                {
                    Console.WriteLine(coupon);
                }
                
                Console.WriteLine($"Total coupons retrieved: {coupons.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
        
        /// <summary>
        /// Returns a block of coupons
        /// </summary>
        /// <param name="offset">pagination variable</param>
        /// <param name="limit">pagination variable. max server will allow is 200</param>
        /// <returns>List of Coupon objects</returns>
        public static List<Coupon> GetCouponsChunk(int offset = 0, int limit = 200)
        {
            // Create coupon API instance using API key
            CouponApi couponApi = new CouponApi(Constants.ApiKey);
            
            // TODO: consider using GetCouponsByQuery() as it does not require all search parameters
            string merchantCode = null;
            string description = null;
            string couponType = null;
            string startDateBegin = null;
            string startDateEnd = null;
            string expirationDateBegin = null;
            string expirationDateEnd = null;
            int? affiliateOid = null;
            bool? excludeExpired = null;
            
            string sort = null;
            string expand = null; // getCoupons doesn't have any expansions. full record is always returned.
            
            var getResponse = couponApi.GetCoupons(merchantCode, description, couponType, 
                startDateBegin, startDateEnd, expirationDateBegin, expirationDateEnd, 
                affiliateOid, excludeExpired, limit, offset, sort, expand);
                
            if (getResponse.Success && getResponse.Success)
            {
                return getResponse.Coupons;
            }
            
            return new List<Coupon>();
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantCode** | **string**| Merchant code | [optional] 
 **description** | **string**| Description | [optional] 
 **couponType** | **string**| Coupon type | [optional] 
 **startDateBegin** | **string**| Start date begin | [optional] 
 **startDateEnd** | **string**| Start date end | [optional] 
 **expirationDateBegin** | **string**| Expiration date begin | [optional] 
 **expirationDateEnd** | **string**| Expiration date end | [optional] 
 **affiliateOid** | **int?**| Affiliate oid | [optional] 
 **excludeExpired** | **bool?**| Exclude expired | [optional] 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Max 200) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **sort** | **string**| The sort order of the coupons.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CouponsResponse**](CouponsResponse.md)

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


## GetCouponsByQuery

> CouponsResponse GetCouponsByQuery (CouponQuery couponQuery, int? limit = null, int? offset = null, string sort = null, string expand = null)

Retrieve coupons by query

Retrieves coupons from the account.  If no parameters are specified, all coupons will be returned.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.coupon
{
    public class GetCouponsByQuery
    {
        /*
        retrieves coupons by query.  Can filter on specific coupons or return back all coupons.  Support pagination.
        A note about the coupon type below.  Those are string literals representing coupons.  This method is used UltraCart's
        backend, and it uses a dropdown box for that value showing friendly descriptions of them.

        It's not anticipated a merchant would need to query by coupon type, but in the event you do, here's the list of constants:
        "BOGO limit L"
        "Free shipping method Y"
        "Free shipping method Y with purchase of items Z"
        "Free shipping method Y with subtotal Z"
        "Free shipping on item Z"
        "Free X with purchase of Y dollars limit L"
        "Free X with purchase of Y dollars limit L and shipping Z"
        "Free X with purchase of Y limit L"
        "Free X with purchase of Y limit L and free shipping"
        "I Free X with every J purchase of Y limit L"
        "I Free X with every J purchase of Y mix and match group limit L"
        "Item X for Y with purchase of Z limit L"
        "multiple X $ off item Z limit L"
        "No discount"
        "Tiered Dollar Off Subtotal"
        "Tiered % off items Z limit L"
        "Tiered $ off item Z limit L"
        "Tiered Percent off shipping methods Y with subtotal Z"
        "Tiered Percent Off Subtotal"
        "X dollars off shipping method Y with purchase of items Z"
        "X dollars off subtotal with purchase Y items"
        "X $ for item Z limit L"
        "X more loyalty cashback"
        "X more loyalty points"
        "X % off item Z and free shipping"
        "X $ off item Z limit L"
        "X % off item Z limit L"
        "X % off msrp item Z limit L"
        "X % off retail item Z limit L"
        "X $ off shipping method Y"
        "X % off shipping method Y"
        "X $ off subtotal"
        "X % off subtotal"
        "X $ off subtotal and shipping"
        "X % off subtotal free shipping method Y"
        "X % off subtotal limit L"
        "X off subtotal with purchase block of L item Y"
        "X % off subtotal with purchase of item Y"
        "X % off subtotal with purchase of Y"
        "X $ off subtotal with Y $ purchase"
        "X $ off subtotal with Y $ purchase and free shipping"
        "X % off Y with purchase Z limit L"
        "X % off Y with T purchase Z limit L"
        "X percent more loyalty points"
        "X $ shipping method Y with subtotal Z"
        "X ? subtotal"
        */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                List<Coupon> coupons = new List<Coupon>();
                
                int iteration = 1;
                int offset = 0;
                int limit = 200;
                bool moreRecordsToFetch = true;
                
                while (moreRecordsToFetch)
                {
                    Console.WriteLine($"executing iteration {iteration}");
                    List<Coupon> chunkOfCoupons = GetCouponChunk(offset, limit);
                    coupons.AddRange(chunkOfCoupons);
                    offset += limit;
                    moreRecordsToFetch = chunkOfCoupons.Count == limit;
                    iteration++;
                }
                
                // Display the coupons
                foreach (var coupon in coupons)
                {
                    Console.WriteLine(coupon);
                }
                
                Console.WriteLine($"Total coupons retrieved: {coupons.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
        
        /// <summary>
        /// Returns a chunk of coupons based on query parameters
        /// </summary>
        /// <param name="offset">Pagination offset</param>
        /// <param name="limit">Maximum number of records to return</param>
        /// <returns>List of matching coupons</returns>
        public static List<Coupon> GetCouponChunk(int offset, int limit)
        {
            // Create coupon API instance using API key
            CouponApi couponApi = new CouponApi(Constants.ApiKey);
            
            CouponQuery query = new CouponQuery();
            query.MerchantCode = "10OFF"; // supports partial matching
            query.Description = "Saturday"; // supports partial matching
            // query.CouponType = null; // see the note at the top of this sample.
            // query.StartDtsBegin = DateTime.UtcNow.AddDays(-2000).ToString("yyyy-MM-ddTHH:mm:ssK"); // yes, that 2,000 days.
            // query.StartDtsEnd = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssK");
            // query.ExpirationDtsBegin = null;
            // query.ExpirationDtsEnd = null;
            // query.AffiliateOid = 0; // this requires an affiliate_oid. If you need help finding an affiliate's oid, contact support.
            query.ExcludeExpired = true;
            
            string expand = null; // coupons do not have expansions
            string sort = "merchant_code"; // Possible sorts: "coupon_type", "merchant_code", "description", "start_dts", "expiration_dts", "quickbooks_code"
            
            var apiResponse = couponApi.GetCouponsByQuery(query, limit, offset, sort, expand);
            if (apiResponse.Coupons != null)
            {
                return apiResponse.Coupons;
            }
            return new List<Coupon>();
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponQuery** | [**CouponQuery**](CouponQuery.md)| Coupon query | 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Max 200) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **sort** | **string**| The sort order of the coupons.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CouponsResponse**](CouponsResponse.md)

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


## GetEditorValues

> CouponEditorValues GetEditorValues ()

Retrieve values needed for a coupon editor

Retrieve values needed for a coupon editor 


### Example

```csharp
namespace SdkSample.coupon
{
    public class GetEditorValues
    {
        public static void Execute()
        {
            // This is an internal method used by our Coupon management screen.  It returns back all the static data needed
            // for our dropdown lists, such as coupon constants.  You can call it if you like, but the data won't be
            // of much use.
        }
    }
}
```


### Parameters

This endpoint does not need any parameter.

### Return type

[**CouponEditorValues**](CouponEditorValues.md)

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


## InsertCoupon

> CouponResponse InsertCoupon (Coupon coupon, string expand = null)

Insert a coupon

Insert a coupon on the UltraCart account. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.coupon
{
    public class InsertCoupon
    {
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            try
            {
                // Create coupon API instance using API key
                CouponApi couponApi = new CouponApi(Constants.ApiKey);

                // Create a new coupon
                Coupon coupon = new Coupon();
                coupon.MerchantCode = "InsertCouponSample";
                coupon.Description ="One penny off subtotal";

                // Each coupon must have a 'type' defined by creating a child object directly beneath the main Coupon object.
                // This is complex and there are a LOT of coupon types. See the backend (secure.ultracart.com) coupon screens
                // to get an idea of what functionality each coupon possesses. If you're not sure, contact UltraCart support.
                coupon.AmountOffSubtotal = new CouponAmountOffSubtotal();
                coupon.AmountOffSubtotal.DiscountAmount = 0.01m;

                // Here are the different coupon types, but beware that new coupons are added frequently.
                //CouponAmountOffItems
                //CouponAmountOffShipping
                //CouponAmountOffShippingWithItemsPurchase
                //CouponAmountOffSubtotal
                //CouponAmountOffSubtotalAndShipping
                //CouponAmountOffSubtotalFreeShippingWithPurchase
                //CouponAmountOffSubtotalWithBlockPurchase
                //CouponAmountOffSubtotalWithItemsPurchase
                //CouponAmountOffSubtotalWithPurchase
                //CouponAmountShippingWithSubtotal
                //CouponDiscountItems
                //CouponDiscountItemWithItemPurchase
                //CouponFreeItemAndShippingWithSubtotal
                //CouponFreeItemsWithItemPurchase
                //CouponFreeItemsWithMixMatchPurchase
                //CouponFreeItemWithItemPurchase
                //CouponFreeItemWithItemPurchaseAndFreeShipping
                //CouponFreeItemWithSubtotal
                //CouponFreeShipping
                //CouponFreeShippingSpecificItems
                //CouponFreeShippingWithItemsPurchase
                //CouponFreeShippingWithSubtotal
                //CouponMoreLoyaltyCashback
                //CouponMoreLoyaltyPoints
                //CouponMultipleAmountsOffItems
                //CouponNoDiscount
                //CouponPercentMoreLoyaltyCashback
                //CouponPercentMoreLoyaltyPoints
                //CouponPercentOffItems
                //CouponPercentOffItemsAndFreeShipping
                //CouponPercentOffItemsWithItemsPurchase
                //CouponPercentOffItemWithItemsQuantityPurchase
                //CouponPercentOffMsrpItems
                //CouponPercentOffRetailPriceItems
                //CouponPercentOffShipping
                //CouponPercentOffSubtotal
                //CouponPercentOffSubtotalAndFreeShipping
                //CouponPercentOffSubtotalLimit
                //CouponPercentOffSubtotalWithItemsPurchase
                //CouponPercentOffSubtotalWithSubtotal
                //CouponTieredAmountOffItems
                //CouponTieredAmountOffSubtotal
                //CouponTieredPercentOffItems
                //CouponTieredPercentOffShipping
                //CouponTieredPercentOffSubtotal
                //CouponTieredPercentOffSubtotalBasedOnMSRP
                //CouponTierItemDiscount
                //CouponTierPercent
                //CouponTierQuantityAmount
                //CouponTierQuantityPercent

                string expand = null; // coupons do not have expansions
                var apiResponse = couponApi.InsertCoupon(coupon, expand);
                
                coupon = apiResponse.Coupon;
                Console.WriteLine("Created the following temporary coupon:");
                Console.WriteLine($"Coupon OID: {coupon.CouponOid}");
                Console.WriteLine($"Coupon Type: {coupon.CouponType}");
                Console.WriteLine($"Coupon Description: {coupon.Description}");
                
                Console.WriteLine("Deleting newly created coupon to clean up.");
                couponApi.DeleteCoupon(coupon.CouponOid);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **coupon** | [**Coupon**](Coupon.md)| Coupon to insert | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CouponResponse**](CouponResponse.md)

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


## InsertCoupons

> CouponsResponse InsertCoupons (CouponsRequest couponsRequest, string expand = null, bool? placeholders = null)

Insert multiple coupons

Insert multiple coupon on the UltraCart account. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.coupon
{
    public class InsertCoupons
    {
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            try
            {
                // Create coupon API instance using API key
                CouponApi couponApi = new CouponApi(Constants.ApiKey);
                
                Coupon coupon1 = new Coupon();
                coupon1.MerchantCode = "PennyOff";
                coupon1.Description ="Test Coupon for InsertCoupons sample";
                coupon1.AmountOffSubtotal = new CouponAmountOffSubtotal(); // see InsertCoupon for examples of types
                coupon1.AmountOffSubtotal.DiscountAmount = 0.01m;

                Coupon coupon2 = new Coupon();
                coupon2.MerchantCode = "TwoPenniesOff";
                coupon2.Description ="Test Coupon for InsertCoupons sample";
                coupon2.AmountOffSubtotal = new CouponAmountOffSubtotal(); // see InsertCoupon for examples of types
                coupon2.AmountOffSubtotal.DiscountAmount = 0.02m;
                
                CouponsRequest couponsRequest = new CouponsRequest();
                couponsRequest.Coupons = new List<Coupon> { coupon1, coupon2 };
                var apiResponse = couponApi.InsertCoupons(couponsRequest);
                
                Console.WriteLine(apiResponse);

                foreach (Coupon coupon in apiResponse.Coupons)
                {
                    Console.WriteLine($"Deleting newly created coupon (Coupon OID {coupon.CouponOid}) to clean up.");
                    couponApi.DeleteCoupon(coupon.CouponOid);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponsRequest** | [**CouponsRequest**](CouponsRequest.md)| Coupons to insert (maximum 50) | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 
 **placeholders** | **bool?**| Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. | [optional] 

### Return type

[**CouponsResponse**](CouponsResponse.md)

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


## SearchItems

> CouponItemSearchResultsResponse SearchItems (string s = null, int? m = null)

Searches for items to display within a coupon editor and assign to coupons

Searches for items to display within a coupon editor and assign to coupons 


### Example

```csharp
using System;

namespace SdkSample.coupon
{
    public class SearchItems
    {
        public static void Execute()
        {
            // This is an internal method used by our Coupon management screen.  It searches merchant items to display in
            // some of the coupon editor dropdowns.  See ItemApi.getItemsByQuery if you need to search items.  This method
            // is inflexible and geared toward our UI.
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **s** | **string**|  | [optional] 
 **m** | **int?**|  | [optional] 

### Return type

[**CouponItemSearchResultsResponse**](CouponItemSearchResultsResponse.md)

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


## UpdateAutoApply

> void UpdateAutoApply (CouponAutoApplyConditions conditions)

Update auto apply rules and conditions

Update auto apply rules and conditions 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.coupon
{
    public class UpdateAutoApply
    {
        /*
          updateAutoApply updates the items and subtotals conditions that trigger "auto coupons", i.e. coupons that are automatically
          added to a shopping cart.  The manual configuration of auto coupons is at the bottom of the main coupons screen.
          See: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1376525/Coupons#Coupons-Navigation

          // Success is 200 (There is no content.  Yes, this should return a 204, but it returns a 200 with no content)
        */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create coupon API instance using API key
                CouponApi couponApi = new CouponApi(Constants.ApiKey);
                
                // Create auto apply conditions
                CouponAutoApplyConditions autoApply = new CouponAutoApplyConditions();
                
                // Create item condition
                CouponAutoApplyCondition itemCondition = new CouponAutoApplyCondition();
                itemCondition.RequiredItemId = "ITEM_ABC";
                itemCondition.CouponCode = "10OFF";
                List<CouponAutoApplyCondition> itemConditions = new List<CouponAutoApplyCondition> { itemCondition };
                
                // Create subtotal condition
                CouponAutoApplyCondition subtotalCondition = new CouponAutoApplyCondition();
                subtotalCondition.MinimumSubtotal = 50; // must spend fifty dollars
                subtotalCondition.CouponCode = "5OFF"; // Corrected from item condition in original code
                List<CouponAutoApplyCondition> subtotalConditions = new List<CouponAutoApplyCondition> { subtotalCondition };
                
                // Set conditions to auto apply object
                autoApply.RequiredItems = itemConditions;
                autoApply.SubtotalLevels = subtotalConditions;
                
                // Update auto apply conditions
                couponApi.UpdateAutoApply(autoApply);
                
                Console.WriteLine("Auto apply conditions updated successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conditions** | [**CouponAutoApplyConditions**](CouponAutoApplyConditions.md)| Conditions | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
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


## UpdateCoupon

> CouponResponse UpdateCoupon (int couponOid, Coupon coupon, string expand = null)

Update a coupon

Update a coupon on the UltraCart account. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.coupon
{
    public class UpdateCoupon
    {
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create coupon API instance using API key
                CouponApi couponApi = new CouponApi(Constants.ApiKey);

                String merchantCode = Guid.NewGuid().ToString("N").Substring(0, 8);
                
                // Now create the coupon and ensure it exists.
                Coupon coupon = new Coupon();
                coupon.MerchantCode = merchantCode;
                coupon.Description = "Test coupon for GetCoupon";
                coupon.AmountOffSubtotal = new CouponAmountOffSubtotal("USD", 0.01m); // one penny discount.

                CouponResponse couponResponse = couponApi.InsertCoupon(coupon);
                coupon = couponResponse.Coupon;
                
                // update the coupon. this can be difficult given the complexity of coupons. see insertCoupon sample for details.
                coupon.ExpirationDts = DateTime.UtcNow.AddDays(90).ToString("yyyy-MM-ddTHH:mm:ssK");

                var updatedResponse = couponApi.UpdateCoupon(coupon.CouponOid, coupon);
                Coupon updatedCoupon = updatedResponse.Coupon;

                // Display the updated coupon
                Console.WriteLine(updatedCoupon);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponOid** | **int**| The coupon_oid to update. | 
 **coupon** | [**Coupon**](Coupon.md)| Coupon to update | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CouponResponse**](CouponResponse.md)

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


## UpdateCoupons

> CouponsResponse UpdateCoupons (CouponsRequest couponsRequest, string expand = null, bool? placeholders = null, bool? async = null)

Update multiple coupons

Update multiple coupon on the UltraCart account. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.coupon
{
    public class UpdateCoupons
    {
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create coupon API instance using API key
                CouponApi couponApi = new CouponApi(Constants.ApiKey);

                String merchantCode = Guid.NewGuid().ToString("N").Substring(0, 8);
                
                // Now create the coupon and ensure it exists.
                Coupon coupon = new Coupon();
                coupon.MerchantCode = merchantCode;
                coupon.Description = "Test coupon for GetCoupon";
                coupon.AmountOffSubtotal = new CouponAmountOffSubtotal("USD", 0.01m); // one penny discount.

                CouponResponse couponResponse = couponApi.InsertCoupon(coupon);
                coupon = couponResponse.Coupon;
                
                // update the coupon. this can be difficult given the complexity of coupons. see insertCoupon sample for details.
                coupon.ExpirationDts = DateTime.UtcNow.AddDays(90).ToString("yyyy-MM-ddTHH:mm:ssK");

                // This example only has one coupon. But it's a trivial matter to add more coupons
                CouponsRequest couponsRequest = new CouponsRequest();
                couponsRequest.Coupons = new List<Coupon> { coupon };

                var updatedResponse = couponApi.UpdateCoupons(couponsRequest);
                List<Coupon> updatedCoupons = updatedResponse.Coupons;

                // Display the updated coupons
                foreach (var updatedCoupon in updatedCoupons)
                {
                    Console.WriteLine(updatedCoupon);
                }
                
                // Delete the coupon
                couponApi.DeleteCoupon(coupon.CouponOid);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponsRequest** | [**CouponsRequest**](CouponsRequest.md)| Coupons to update (synchronous maximum 50 / asynchronous maximum 100) | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 
 **placeholders** | **bool?**| Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. | [optional] 
 **async** | **bool?**| True if the operation should be run async.  No result returned | [optional] 

### Return type

[**CouponsResponse**](CouponsResponse.md)

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


## UploadCouponCodes

> UploadCouponCodesResponse UploadCouponCodes (int couponOid, UploadCouponCodesRequest uploadCouponCodesRequest)

Upload one-time codes for a coupon

Upload one-time codes for a coupon 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.coupon
{
    public class UploadCouponCodes
    {
        /*
          uploadCouponCodes allows a merchant to upload one-time use codes and associate them with a merchant code (i.e. a coupon).
          UltraCart has methods for generating one-time codes, and they work well, but this method exists when the merchant generates
          them themselves. This frequently occurs when a merchant sends out a mailer with unique coupon codes on the mailer. The
          merchant can then upload those codes with this method.
        */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create coupon API instance using API key
                CouponApi couponApi = new CouponApi(Constants.ApiKey);

                String merchantCode = Guid.NewGuid().ToString("N").Substring(0, 8);
                
                // Now create the coupon and ensure it exists.
                Coupon coupon = new Coupon();
                coupon.MerchantCode = merchantCode;
                coupon.Description = "Test coupon for GetCoupon";
                coupon.AmountOffSubtotal = new CouponAmountOffSubtotal("USD", 0.01m); // one penny discount.

                CouponResponse couponResponse = couponApi.InsertCoupon(coupon);
                coupon = couponResponse.Coupon;
                
                // Create request for uploading coupon codes
                UploadCouponCodesRequest codesRequest = new UploadCouponCodesRequest();
                codesRequest.CouponCodes = new List<string> { "code1", "code2", "code3" };
                
                // Upload the coupon codes
                var apiResponse = couponApi.UploadCouponCodes(coupon.CouponOid, codesRequest);
                
                // Display results
                Console.WriteLine("Uploaded codes:");
                foreach (var code in apiResponse.UploadedCodes)
                {
                    Console.WriteLine(code);
                }
                
                Console.WriteLine("Duplicated codes:");
                foreach (var code in apiResponse.DuplicateCodes)
                {
                    Console.WriteLine(code);
                }
                
                Console.WriteLine("Rejected codes:");
                foreach (var code in apiResponse.RejectedCodes)
                {
                    Console.WriteLine(code);
                }
                
                
                // Delete the coupon
                couponApi.DeleteCoupon(coupon.CouponOid);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponOid** | **int**| The coupon oid to associate with the provided one-time codes. | 
 **uploadCouponCodesRequest** | [**UploadCouponCodesRequest**](UploadCouponCodesRequest.md)| One-time coupon codes | 

### Return type

[**UploadCouponCodesResponse**](UploadCouponCodesResponse.md)

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

