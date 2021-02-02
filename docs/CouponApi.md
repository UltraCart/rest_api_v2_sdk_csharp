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
[**GetCouponsByQuery**](CouponApi.md#getcouponsbyquery) | **GET** /coupon/coupons/query | Retrieve coupons by query
[**GetEditorValues**](CouponApi.md#geteditorvalues) | **GET** /coupon/editor_values | Retrieve values needed for a coupon editor
[**InsertCoupon**](CouponApi.md#insertcoupon) | **POST** /coupon/coupons | Insert a coupon
[**InsertCoupons**](CouponApi.md#insertcoupons) | **POST** /coupon/coupons/batch | Insert multiple coupons
[**SearchItems**](CouponApi.md#searchitems) | **GET** /coupon/searchItems | Searches for items to display within a coupon editor and assign to coupons
[**UpdateAutoApply**](CouponApi.md#updateautoapply) | **POST** /coupon/auto_apply | Update auto apply rules and conditions
[**UpdateCoupon**](CouponApi.md#updatecoupon) | **PUT** /coupon/coupons/{coupon_oid} | Update a coupon
[**UpdateCoupons**](CouponApi.md#updatecoupons) | **PUT** /coupon/coupons/batch | Update multiple coupons
[**UploadCouponCodes**](CouponApi.md#uploadcouponcodes) | **POST** /coupon/coupons/{coupon_oid}/upload_codes | Upload one-time codes for a coupon


<a name="deletecoupon"></a>
# **DeleteCoupon**
> void DeleteCoupon (int? couponOid)

Delete a coupon

Delete a coupon on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteCouponExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);

            var couponOid = 56;  // int? | The coupon_oid to delete.

            try
            {
                // Delete a coupon
                apiInstance.DeleteCoupon(couponOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.DeleteCoupon: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponOid** | **int?**| The coupon_oid to delete. | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecouponsbycode"></a>
# **DeleteCouponsByCode**
> void DeleteCouponsByCode (CouponDeletesRequest couponDeleteRequest)

Deletes multiple coupons

Delete coupons on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteCouponsByCodeExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);

            var couponDeleteRequest = new CouponDeletesRequest(); // CouponDeletesRequest | Coupon oids to delete

            try
            {
                // Deletes multiple coupons
                apiInstance.DeleteCouponsByCode(couponDeleteRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.DeleteCouponsByCode: " + e.Message );
            }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecouponsbyoid"></a>
# **DeleteCouponsByOid**
> void DeleteCouponsByOid (CouponDeletesRequest couponDeleteRequest)

Deletes multiple coupons

Delete coupons on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteCouponsByOidExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);

            var couponDeleteRequest = new CouponDeletesRequest(); // CouponDeletesRequest | Coupon oids to delete

            try
            {
                // Deletes multiple coupons
                apiInstance.DeleteCouponsByOid(couponDeleteRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.DeleteCouponsByOid: " + e.Message );
            }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="doescouponcodeexist"></a>
# **DoesCouponCodeExist**
> CouponExistsResponse DoesCouponCodeExist (string merchantCode)

Determines if a coupon merchant code already exists

Determines if a coupon merchant code already exists. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DoesCouponCodeExistExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);

            var merchantCode = merchantCode_example;  // string | The coupon merchant code to examine.

            try
            {
                // Determines if a coupon merchant code already exists
                CouponExistsResponse result = apiInstance.DoesCouponCodeExist(merchantCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.DoesCouponCodeExist: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatecouponcodes"></a>
# **GenerateCouponCodes**
> CouponCodesResponse GenerateCouponCodes (int? couponOid, CouponCodesRequest couponCodesRequest)

Generates one time codes for a coupon

Generate one time codes for a coupon 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GenerateCouponCodesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);

            var couponOid = 56;  // int? | The coupon oid to generate codes.
            var couponCodesRequest = new CouponCodesRequest(); // CouponCodesRequest | Coupon code generation parameters

            try
            {
                // Generates one time codes for a coupon
                CouponCodesResponse result = apiInstance.GenerateCouponCodes(couponOid, couponCodesRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.GenerateCouponCodes: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponOid** | **int?**| The coupon oid to generate codes. | 
 **couponCodesRequest** | [**CouponCodesRequest**](CouponCodesRequest.md)| Coupon code generation parameters | 

### Return type

[**CouponCodesResponse**](CouponCodesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateonetimecodesbymerchantcode"></a>
# **GenerateOneTimeCodesByMerchantCode**
> CouponCodesResponse GenerateOneTimeCodesByMerchantCode (string merchantCode, CouponCodesRequest couponCodesRequest)

Generates one time codes by merchant code

Generate one time codes by merchant code 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GenerateOneTimeCodesByMerchantCodeExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);

            var merchantCode = merchantCode_example;  // string | The merchant code to generate one time codes.
            var couponCodesRequest = new CouponCodesRequest(); // CouponCodesRequest | Coupon code generation parameters

            try
            {
                // Generates one time codes by merchant code
                CouponCodesResponse result = apiInstance.GenerateOneTimeCodesByMerchantCode(merchantCode, couponCodesRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.GenerateOneTimeCodesByMerchantCode: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getautoapply"></a>
# **GetAutoApply**
> CouponAutoApplyConditions GetAutoApply ()

Retrieve auto apply rules and conditions

Retrieve auto apply rules and conditions 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetAutoApplyExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);


            try
            {
                // Retrieve auto apply rules and conditions
                CouponAutoApplyConditions result = apiInstance.GetAutoApply();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.GetAutoApply: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcoupon"></a>
# **GetCoupon**
> CouponResponse GetCoupon (int? couponOid, string expand = null)

Retrieve a coupon

Retrieves a single coupon using the specified coupon profile oid. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCouponExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);

            var couponOid = 56;  // int? | The coupon oid to retrieve.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve a coupon
                CouponResponse result = apiInstance.GetCoupon(couponOid, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.GetCoupon: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponOid** | **int?**| The coupon oid to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CouponResponse**](CouponResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcouponbymerchantcode"></a>
# **GetCouponByMerchantCode**
> CouponResponse GetCouponByMerchantCode (string merchantCode, string expand = null)

Retrieve a coupon by merchant code

Retrieves a single coupon using the specified merchant code. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCouponByMerchantCodeExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);

            var merchantCode = merchantCode_example;  // string | The coupon merchant code to retrieve.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve a coupon by merchant code
                CouponResponse result = apiInstance.GetCouponByMerchantCode(merchantCode, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.GetCouponByMerchantCode: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcoupons"></a>
# **GetCoupons**
> CouponsResponse GetCoupons (string merchantCode = null, string description = null, string couponType = null, string startDateBegin = null, string startDateEnd = null, string expirationDateBegin = null, string expirationDateEnd = null, int? affiliateOid = null, bool? excludeExpired = null, int? limit = null, int? offset = null, string sort = null, string expand = null)

Retrieve coupons

Retrieves coupons for this account.  If no parameters are specified, all coupons will be returned.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCouponsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);

            var merchantCode = merchantCode_example;  // string | Merchant code (optional) 
            var description = description_example;  // string | Description (optional) 
            var couponType = couponType_example;  // string | Coupon type (optional) 
            var startDateBegin = startDateBegin_example;  // string | Start date begin (optional) 
            var startDateEnd = startDateEnd_example;  // string | Start date end (optional) 
            var expirationDateBegin = expirationDateBegin_example;  // string | Expiration date begin (optional) 
            var expirationDateEnd = expirationDateEnd_example;  // string | Expiration date end (optional) 
            var affiliateOid = 56;  // int? | Affiliate oid (optional) 
            var excludeExpired = true;  // bool? | Exclude expired (optional) 
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Max 200) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var sort = sort_example;  // string | The sort order of the coupons.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve coupons
                CouponsResponse result = apiInstance.GetCoupons(merchantCode, description, couponType, startDateBegin, startDateEnd, expirationDateBegin, expirationDateEnd, affiliateOid, excludeExpired, limit, offset, sort, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.GetCoupons: " + e.Message );
            }
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcouponsbyquery"></a>
# **GetCouponsByQuery**
> CouponsResponse GetCouponsByQuery (CouponQuery couponQuery, int? limit = null, int? offset = null, string sort = null, string expand = null)

Retrieve coupons by query

Retrieves coupons from the account.  If no parameters are specified, all coupons will be returned.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCouponsByQueryExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);

            var couponQuery = new CouponQuery(); // CouponQuery | Coupon query
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Max 200) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var sort = sort_example;  // string | The sort order of the coupons.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve coupons by query
                CouponsResponse result = apiInstance.GetCouponsByQuery(couponQuery, limit, offset, sort, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.GetCouponsByQuery: " + e.Message );
            }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteditorvalues"></a>
# **GetEditorValues**
> CouponEditorValues GetEditorValues ()

Retrieve values needed for a coupon editor

Retrieve values needed for a coupon editor 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEditorValuesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);


            try
            {
                // Retrieve values needed for a coupon editor
                CouponEditorValues result = apiInstance.GetEditorValues();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.GetEditorValues: " + e.Message );
            }
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertcoupon"></a>
# **InsertCoupon**
> CouponResponse InsertCoupon (Coupon coupon, string expand = null)

Insert a coupon

Insert a coupon on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertCouponExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);

            var coupon = new Coupon(); // Coupon | Coupon to insert
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Insert a coupon
                CouponResponse result = apiInstance.InsertCoupon(coupon, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.InsertCoupon: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertcoupons"></a>
# **InsertCoupons**
> CouponsResponse InsertCoupons (CouponsRequest couponsRequest, string expand = null, bool? placeholders = null)

Insert multiple coupons

Insert multiple coupon on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertCouponsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);

            var couponsRequest = new CouponsRequest(); // CouponsRequest | Coupons to insert (maximum 20)
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 

            try
            {
                // Insert multiple coupons
                CouponsResponse result = apiInstance.InsertCoupons(couponsRequest, expand, placeholders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.InsertCoupons: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponsRequest** | [**CouponsRequest**](CouponsRequest.md)| Coupons to insert (maximum 20) | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 
 **placeholders** | **bool?**| Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. | [optional] 

### Return type

[**CouponsResponse**](CouponsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchitems"></a>
# **SearchItems**
> CouponItemSearchResultsResponse SearchItems (string s = null, int? m = null)

Searches for items to display within a coupon editor and assign to coupons

Searches for items to display within a coupon editor and assign to coupons 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SearchItemsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);

            var s = s_example;  // string |  (optional) 
            var m = 56;  // int? |  (optional) 

            try
            {
                // Searches for items to display within a coupon editor and assign to coupons
                CouponItemSearchResultsResponse result = apiInstance.SearchItems(s, m);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.SearchItems: " + e.Message );
            }
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateautoapply"></a>
# **UpdateAutoApply**
> void UpdateAutoApply (CouponAutoApplyConditions conditions)

Update auto apply rules and conditions

Update auto apply rules and conditions 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateAutoApplyExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);

            var conditions = new CouponAutoApplyConditions(); // CouponAutoApplyConditions | Conditions

            try
            {
                // Update auto apply rules and conditions
                apiInstance.UpdateAutoApply(conditions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.UpdateAutoApply: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecoupon"></a>
# **UpdateCoupon**
> CouponResponse UpdateCoupon (Coupon coupon, int? couponOid, string expand = null)

Update a coupon

Update a coupon on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateCouponExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);

            var coupon = new Coupon(); // Coupon | Coupon to update
            var couponOid = 56;  // int? | The coupon_oid to update.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Update a coupon
                CouponResponse result = apiInstance.UpdateCoupon(coupon, couponOid, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.UpdateCoupon: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **coupon** | [**Coupon**](Coupon.md)| Coupon to update | 
 **couponOid** | **int?**| The coupon_oid to update. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CouponResponse**](CouponResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecoupons"></a>
# **UpdateCoupons**
> CouponsResponse UpdateCoupons (CouponsRequest couponsRequest, string expand = null, bool? placeholders = null, bool? async = null)

Update multiple coupons

Update multiple coupon on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateCouponsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);

            var couponsRequest = new CouponsRequest(); // CouponsRequest | Coupons to update (synchronous maximum 20 / asynchronous maximum 100)
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 
            var async = true;  // bool? | True if the operation should be run async.  No result returned (optional) 

            try
            {
                // Update multiple coupons
                CouponsResponse result = apiInstance.UpdateCoupons(couponsRequest, expand, placeholders, async);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.UpdateCoupons: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponsRequest** | [**CouponsRequest**](CouponsRequest.md)| Coupons to update (synchronous maximum 20 / asynchronous maximum 100) | 
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadcouponcodes"></a>
# **UploadCouponCodes**
> UploadCouponCodesResponse UploadCouponCodes (int? couponOid, UploadCouponCodesRequest uploadCouponCodesRequest)

Upload one-time codes for a coupon

Upload one-time codes for a coupon 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UploadCouponCodesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CouponApi(simpleKey);

            var couponOid = 56;  // int? | The coupon oid to associate with the provided one-time codes.
            var uploadCouponCodesRequest = new UploadCouponCodesRequest(); // UploadCouponCodesRequest | One-time coupon codes

            try
            {
                // Upload one-time codes for a coupon
                UploadCouponCodesResponse result = apiInstance.UploadCouponCodes(couponOid, uploadCouponCodesRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.UploadCouponCodes: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponOid** | **int?**| The coupon oid to associate with the provided one-time codes. | 
 **uploadCouponCodesRequest** | [**UploadCouponCodesRequest**](UploadCouponCodesRequest.md)| One-time coupon codes | 

### Return type

[**UploadCouponCodesResponse**](UploadCouponCodesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

