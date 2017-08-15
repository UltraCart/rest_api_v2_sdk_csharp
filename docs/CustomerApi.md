# com.ultracart.admin.v2.Api.CustomerApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCustomer**](CustomerApi.md#deletecustomer) | **DELETE** /customer/customers/{customer_profile_oid} | Delete a customer
[**GetCustomer**](CustomerApi.md#getcustomer) | **GET** /customer/customers/{customer_profile_oid} | Retrieve a customer
[**GetCustomers**](CustomerApi.md#getcustomers) | **GET** /customer/customers | Retrieve customers
[**InsertCustomer**](CustomerApi.md#insertcustomer) | **POST** /customer/customers | Insert a customer
[**UpdateCustomer**](CustomerApi.md#updatecustomer) | **PUT** /customer/customers/{customer_profile_oid} | Update a customer


<a name="deletecustomer"></a>
# **DeleteCustomer**
> CustomerResponse DeleteCustomer (int? customerProfileOid)

Delete a customer

Delete a customer on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteCustomerExample
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
              

            var apiInstance = new CustomerApi();
            var customerProfileOid = 56;  // int? | The customer_profile_oid to delete.

            try
            {
                // Delete a customer
                CustomerResponse result = apiInstance.DeleteCustomer(customerProfileOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.DeleteCustomer: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerProfileOid** | **int?**| The customer_profile_oid to delete. | 

### Return type

[**CustomerResponse**](CustomerResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomer"></a>
# **GetCustomer**
> CustomerResponse GetCustomer (int? customerProfileOid, string expand = null)

Retrieve a customer

Retrieves a single customer using the specified customer profile oid. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCustomerExample
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
              

            var apiInstance = new CustomerApi();
            var customerProfileOid = 56;  // int? | The customer oid to retrieve.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve a customer
                CustomerResponse result = apiInstance.GetCustomer(customerProfileOid, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetCustomer: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerProfileOid** | **int?**| The customer oid to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CustomerResponse**](CustomerResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomers"></a>
# **GetCustomers**
> CustomersResponse GetCustomers (string email = null, string qbClass = null, string quickbooksCode = null, string lastModifiedDtsStart = null, string lastModifiedDtsEnd = null, string signupDtsStart = null, string signupDtsEnd = null, string billingFirstName = null, string billingLastName = null, string billingCompany = null, string billingCity = null, string billingState = null, string billingPostalCode = null, string billingCountryCode = null, string billingDayPhone = null, string billingEveningPhone = null, string shippingFirstName = null, string shippingLastName = null, string shippingCompany = null, string shippingCity = null, string shippingState = null, string shippingPostalCode = null, string shippingCountryCode = null, string shippingDayPhone = null, string shippingEveningPhone = null, int? pricingTierOid = null, string pricingTierName = null, int? limit = null, int? offset = null, string since = null, string sort = null, string expand = null)

Retrieve customers

Retrieves customers from the account.  If no parameters are specified, all customers will be returned.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 
### Example
```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;
using NUnit.Framework;

namespace SDKSample {
  [TestFixture]
  public class CustomerApiTest {

    private static List<Customer> GetCustomerChunk(ICustomerApi api, int offset = 0, int limit = 200) {

      // string expand = null; // no expansion.  bare bones.
      const string expand = "shipping,billing"; // shipping and billing addresses
      // string expand = "shipping,billing,cards,pricing_tiers"; // everything.

      var customerResponse = api.GetCustomers(offset: offset, limit: limit, expand: expand);
      // TODO if the response is not success, handle errors here.
      return customerResponse.Success == true ? customerResponse.Customers : new List<Customer>();

    }


    [Test]
    public void GetCustomersTest() {


      // See https://secure.ultracart.com/merchant/configuration/apiManagementApp.do
      const string simpleKey = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
      Configuration.Default.ApiKey.Add("x-ultracart-simple-key", simpleKey);
      Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

      var api = new CustomerApi();
      var offset = 0;
      const int limit = 100; // why 100?  Just to show more looping.  200 is the max and a better choice.
      var stillMoreRecords = true;
      var customers = new List<Customer>();

      while (stillMoreRecords) {
        var chunkOfCustomers = GetCustomerChunk(api, offset, limit);
        Console.WriteLine($"{chunkOfCustomers.Count} customers retrieved.");
        customers.AddRange(chunkOfCustomers);
        offset += limit;
        stillMoreRecords = chunkOfCustomers.Count == limit;

      }

      Console.WriteLine($"{customers.Count} total customers retrieved.");

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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertcustomer"></a>
# **InsertCustomer**
> CustomerResponse InsertCustomer (Customer customer, string expand = null)

Insert a customer

Insert a customer on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertCustomerExample
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
              

            var apiInstance = new CustomerApi();
            var customer = new Customer(); // Customer | Customer to insert
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Insert a customer
                CustomerResponse result = apiInstance.InsertCustomer(customer, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.InsertCustomer: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomer"></a>
# **UpdateCustomer**
> CustomerResponse UpdateCustomer (Customer customer, int? customerProfileOid, string expand = null)

Update a customer

Update a customer on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateCustomerExample
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
              

            var apiInstance = new CustomerApi();
            var customer = new Customer(); // Customer | Customer to update
            var customerProfileOid = 56;  // int? | The customer_profile_oid to update.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Update a customer
                CustomerResponse result = apiInstance.UpdateCustomer(customer, customerProfileOid, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.UpdateCustomer: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customer** | [**Customer**](Customer.md)| Customer to update | 
 **customerProfileOid** | **int?**| The customer_profile_oid to update. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**CustomerResponse**](CustomerResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

