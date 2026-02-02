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


<a name="addgiftcertificateledgerentry"></a>
# **AddGiftCertificateLedgerEntry**
> GiftCertificateResponse AddGiftCertificateLedgerEntry (int? giftCertificateOid, GiftCertificateLedgerEntry giftCertificateLedgerEntry)

Add a gift certificate ledger entry

Adds a ledger entry for this gift certificate. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class AddGiftCertificateLedgerEntryExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new GiftCertificateApi(simpleKey);

            var giftCertificateOid = 56;  // int? | 
            var giftCertificateLedgerEntry = new GiftCertificateLedgerEntry(); // GiftCertificateLedgerEntry | Gift certificate ledger entry

            try
            {
                // Add a gift certificate ledger entry
                GiftCertificateResponse result = apiInstance.AddGiftCertificateLedgerEntry(giftCertificateOid, giftCertificateLedgerEntry);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GiftCertificateApi.AddGiftCertificateLedgerEntry: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **giftCertificateOid** | **int?**|  | 
 **giftCertificateLedgerEntry** | [**GiftCertificateLedgerEntry**](GiftCertificateLedgerEntry.md)| Gift certificate ledger entry | 

### Return type

[**GiftCertificateResponse**](GiftCertificateResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creategiftcertificate"></a>
# **CreateGiftCertificate**
> GiftCertificateResponse CreateGiftCertificate (GiftCertificateCreateRequest giftCertificateCreateRequest)

Create a gift certificate

Creates a gift certificate for this merchant account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class CreateGiftCertificateExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new GiftCertificateApi(simpleKey);

            var giftCertificateCreateRequest = new GiftCertificateCreateRequest(); // GiftCertificateCreateRequest | Gift certificate create request

            try
            {
                // Create a gift certificate
                GiftCertificateResponse result = apiInstance.CreateGiftCertificate(giftCertificateCreateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GiftCertificateApi.CreateGiftCertificate: " + e.Message );
            }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegiftcertificate"></a>
# **DeleteGiftCertificate**
> void DeleteGiftCertificate (int? giftCertificateOid)

Delete a gift certificate

Deletes a gift certificate for this merchant account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteGiftCertificateExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new GiftCertificateApi(simpleKey);

            var giftCertificateOid = 56;  // int? | 

            try
            {
                // Delete a gift certificate
                apiInstance.DeleteGiftCertificate(giftCertificateOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GiftCertificateApi.DeleteGiftCertificate: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **giftCertificateOid** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgiftcertificatebycode"></a>
# **GetGiftCertificateByCode**
> GiftCertificateResponse GetGiftCertificateByCode (string code)

Retrieve gift certificate by code

Retrieves a gift certificate from the account based on the code (the value the customer enters at checkout time). 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetGiftCertificateByCodeExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new GiftCertificateApi(simpleKey);

            var code = code_example;  // string | 

            try
            {
                // Retrieve gift certificate by code
                GiftCertificateResponse result = apiInstance.GetGiftCertificateByCode(code);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GiftCertificateApi.GetGiftCertificateByCode: " + e.Message );
            }
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgiftcertificatebyoid"></a>
# **GetGiftCertificateByOid**
> GiftCertificateResponse GetGiftCertificateByOid (int? giftCertificateOid)

Retrieve gift certificate by oid

Retrieves a gift certificate from the account based on the internal primary key. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetGiftCertificateByOidExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new GiftCertificateApi(simpleKey);

            var giftCertificateOid = 56;  // int? | 

            try
            {
                // Retrieve gift certificate by oid
                GiftCertificateResponse result = apiInstance.GetGiftCertificateByOid(giftCertificateOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GiftCertificateApi.GetGiftCertificateByOid: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **giftCertificateOid** | **int?**|  | 

### Return type

[**GiftCertificateResponse**](GiftCertificateResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgiftcertificatesbyemail"></a>
# **GetGiftCertificatesByEmail**
> GiftCertificatesResponse GetGiftCertificatesByEmail (string email)

Retrieve gift certificate by email

Retrieves all gift certificates from the account based on customer email. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetGiftCertificatesByEmailExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new GiftCertificateApi(simpleKey);

            var email = email_example;  // string | 

            try
            {
                // Retrieve gift certificate by email
                GiftCertificatesResponse result = apiInstance.GetGiftCertificatesByEmail(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GiftCertificateApi.GetGiftCertificatesByEmail: " + e.Message );
            }
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgiftcertificatesbyquery"></a>
# **GetGiftCertificatesByQuery**
> GiftCertificatesResponse GetGiftCertificatesByQuery (GiftCertificateQuery giftCertificateQuery, int? limit = null, int? offset = null, string since = null, string sort = null, string expand = null)

Retrieve gift certificates by query

Retrieves gift certificates from the account.  If no parameters are specified, all gift certificates will be returned.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetGiftCertificatesByQueryExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new GiftCertificateApi(simpleKey);

            var giftCertificateQuery = new GiftCertificateQuery(); // GiftCertificateQuery | Gift certificates query
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Max 200) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var since = since_example;  // string | Fetch customers that have been created/modified since this date/time. (optional) 
            var sort = sort_example;  // string | The sort order of the customers.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve gift certificates by query
                GiftCertificatesResponse result = apiInstance.GetGiftCertificatesByQuery(giftCertificateQuery, limit, offset, since, sort, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GiftCertificateApi.GetGiftCertificatesByQuery: " + e.Message );
            }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategiftcertificate"></a>
# **UpdateGiftCertificate**
> GiftCertificateResponse UpdateGiftCertificate (int? giftCertificateOid, GiftCertificate giftCertificate)

Update a gift certificate

Update a gift certificate for this merchant account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateGiftCertificateExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new GiftCertificateApi(simpleKey);

            var giftCertificateOid = 56;  // int? | 
            var giftCertificate = new GiftCertificate(); // GiftCertificate | Gift certificate

            try
            {
                // Update a gift certificate
                GiftCertificateResponse result = apiInstance.UpdateGiftCertificate(giftCertificateOid, giftCertificate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GiftCertificateApi.UpdateGiftCertificate: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **giftCertificateOid** | **int?**|  | 
 **giftCertificate** | [**GiftCertificate**](GiftCertificate.md)| Gift certificate | 

### Return type

[**GiftCertificateResponse**](GiftCertificateResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

