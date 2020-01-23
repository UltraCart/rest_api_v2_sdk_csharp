# com.ultracart.admin.v2.Api.AffiliateApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetClicksByQuery**](AffiliateApi.md#getclicksbyquery) | **POST** /affiliate/clicks/query | Retrieve clicks
[**GetLedgersByQuery**](AffiliateApi.md#getledgersbyquery) | **POST** /affiliate/ledgers/query | Retrieve ledger entries


<a name="getclicksbyquery"></a>
# **GetClicksByQuery**
> AffiliateClicksResponse GetClicksByQuery (AffiliateClickQuery clickQuery, int? limit = null, int? offset = null, string expand = null)

Retrieve clicks

Retrieves a group of clicks from the account based on a query object.  If no parameters are specified, the API call will fail with a bad request error.  Always specify some parameters to limit the scope of the clicks returned to ones you are truly interested in.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetClicksByQueryExample
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
              

            var apiInstance = new AffiliateApi();
            var clickQuery = new AffiliateClickQuery(); // AffiliateClickQuery | Click query
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Maximum 10000) (optional)  (default to 10000)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var expand = expand_example;  // string | The object expansion to perform on the result.  Only option is link. (optional) 

            try
            {
                // Retrieve clicks
                AffiliateClicksResponse result = apiInstance.GetClicksByQuery(clickQuery, limit, offset, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AffiliateApi.GetClicksByQuery: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clickQuery** | [**AffiliateClickQuery**](AffiliateClickQuery.md)| Click query | 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Maximum 10000) | [optional] [default to 10000]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **expand** | **string**| The object expansion to perform on the result.  Only option is link. | [optional] 

### Return type

[**AffiliateClicksResponse**](AffiliateClicksResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getledgersbyquery"></a>
# **GetLedgersByQuery**
> AffiliateLedgersResponse GetLedgersByQuery (AffiliateLedgerQuery ledgerQuery, int? limit = null, int? offset = null, string expand = null)

Retrieve ledger entries

Retrieves a group of ledger entries from the account based on a query object.  If no parameters are specified, the API call will fail with a bad request error.  Always specify some parameters to limit the scope of the ledgers returned to ones you are truly interested in.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetLedgersByQueryExample
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
              

            var apiInstance = new AffiliateApi();
            var ledgerQuery = new AffiliateLedgerQuery(); // AffiliateLedgerQuery | Ledger query
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Maximum 200) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var expand = expand_example;  // string | The object expansion to perform on the result.  Only option is link. (optional) 

            try
            {
                // Retrieve ledger entries
                AffiliateLedgersResponse result = apiInstance.GetLedgersByQuery(ledgerQuery, limit, offset, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AffiliateApi.GetLedgersByQuery: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ledgerQuery** | [**AffiliateLedgerQuery**](AffiliateLedgerQuery.md)| Ledger query | 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Maximum 200) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **expand** | **string**| The object expansion to perform on the result.  Only option is link. | [optional] 

### Return type

[**AffiliateLedgersResponse**](AffiliateLedgersResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

