# com.ultracart.admin.v2.Api.CouponsApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCoupon**](CouponsApi.md#deletecoupon) | **DELETE** /coupon/coupons/{coupon_oid} | Delete a coupon
[**GetCoupon**](CouponsApi.md#getcoupon) | **GET** /coupon/coupons/{coupon_oid} | Retrieve a coupon
[**GetCoupons**](CouponsApi.md#getcoupons) | **GET** /coupon/coupons | Retrieve coupons
[**GetCouponsByQuery**](CouponsApi.md#getcouponsbyquery) | **GET** /coupon/coupons/query | Retrieve coupons by query
[**InsertCoupon**](CouponsApi.md#insertcoupon) | **POST** /coupon/coupons | Insert a coupon
[**UpdateCoupon**](CouponsApi.md#updatecoupon) | **PUT** /coupon/coupons/{coupon_oid} | Update a coupon


<a name="deletecoupon"></a>
# **DeleteCoupon**
> CouponResponse DeleteCoupon (int? couponOid)

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

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CouponsApi();
            var couponOid = 56;  // int? | The coupon_oid to delete.

            try
            {
                // Delete a coupon
                CouponResponse result = apiInstance.DeleteCoupon(couponOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponsApi.DeleteCoupon: " + e.Message );
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

[**CouponResponse**](CouponResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
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

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CouponsApi();
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
                Debug.Print("Exception when calling CouponsApi.GetCoupon: " + e.Message );
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

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CouponsApi();
            var merchantCode = merchantCode_example;  // string | Merchant code (optional) 
            var description = description_example;  // string | Description (optional) 
            var couponType = couponType_example;  // string | Coupon type (optional) 
            var startDateBegin = startDateBegin_example;  // string | Start date begin (optional) 
            var startDateEnd = startDateEnd_example;  // string | Start date end (optional) 
            var expirationDateBegin = expirationDateBegin_example;  // string | Expiration date begin (optional) 
            var expirationDateEnd = expirationDateEnd_example;  // string | Expiration date end (optional) 
            var affiliateOid = 56;  // int? | Affiliate oid (optional) 
            var excludeExpired = true;  // bool? | Exclude expired (optional)  (default to true)
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
                Debug.Print("Exception when calling CouponsApi.GetCoupons: " + e.Message );
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
 **excludeExpired** | **bool?**| Exclude expired | [optional] [default to true]
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

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CouponsApi();
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
                Debug.Print("Exception when calling CouponsApi.GetCouponsByQuery: " + e.Message );
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

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CouponsApi();
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
                Debug.Print("Exception when calling CouponsApi.InsertCoupon: " + e.Message );
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

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new CouponsApi();
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
                Debug.Print("Exception when calling CouponsApi.UpdateCoupon: " + e.Message );
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

