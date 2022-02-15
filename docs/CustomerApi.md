# com.ultracart.admin.v2.Api.CustomerApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCustomer**](CustomerApi.md#deletecustomer) | **DELETE** /customer/customers/{customer_profile_oid} | Delete a customer
[**GetCustomer**](CustomerApi.md#getcustomer) | **GET** /customer/customers/{customer_profile_oid} | Retrieve a customer
[**GetCustomerByEmail**](CustomerApi.md#getcustomerbyemail) | **GET** /customer/customers/by_email/{email} | Retrieve a customer by Email
[**GetCustomerEditorValues**](CustomerApi.md#getcustomereditorvalues) | **GET** /customer/editor_values | Retrieve values needed for a customer profile editor
[**GetCustomerEmailLists**](CustomerApi.md#getcustomeremaillists) | **GET** /customer/email_lists | Retrieve all email lists across all storefronts
[**GetCustomers**](CustomerApi.md#getcustomers) | **GET** /customer/customers | Retrieve customers
[**GetCustomersByQuery**](CustomerApi.md#getcustomersbyquery) | **POST** /customer/customers/query | Retrieve customers by query
[**GetCustomersForDataTables**](CustomerApi.md#getcustomersfordatatables) | **POST** /customer/customers/dataTables | Retrieve customers for DataTables plugin
[**GetEmailVerificationToken**](CustomerApi.md#getemailverificationtoken) | **POST** /customer/customers/email_verify/get_token | Create a token that can be used to verify a customer email address
[**InsertCustomer**](CustomerApi.md#insertcustomer) | **POST** /customer/customers | Insert a customer
[**UpdateCustomer**](CustomerApi.md#updatecustomer) | **PUT** /customer/customers/{customer_profile_oid} | Update a customer
[**UpdateCustomerEmailLists**](CustomerApi.md#updatecustomeremaillists) | **POST** /customer/customers/{customer_profile_oid}/email_lists | Update email list subscriptions for a customer
[**ValidateEmailVerificationToken**](CustomerApi.md#validateemailverificationtoken) | **POST** /customer/customers/email_verify/validate_token | Validate a token that can be used to verify a customer email address


<a name="deletecustomer"></a>
# **DeleteCustomer**
> void DeleteCustomer (int? customerProfileOid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CustomerApi(simpleKey);

            var customerProfileOid = 56;  // int? | The customer_profile_oid to delete.

            try
            {
                // Delete a customer
                apiInstance.DeleteCustomer(customerProfileOid);
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

void (empty response body)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CustomerApi(simpleKey);

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

<a name="getcustomerbyemail"></a>
# **GetCustomerByEmail**
> CustomerResponse GetCustomerByEmail (string email, string expand = null)

Retrieve a customer by Email

Retrieves a single customer using the specified customer email address. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCustomerByEmailExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CustomerApi(simpleKey);

            var email = email_example;  // string | The email address of the customer to retrieve.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve a customer by Email
                CustomerResponse result = apiInstance.GetCustomerByEmail(email, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetCustomerByEmail: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomereditorvalues"></a>
# **GetCustomerEditorValues**
> CustomerEditorValues GetCustomerEditorValues ()

Retrieve values needed for a customer profile editor

Retrieve values needed for a customer profile editor. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCustomerEditorValuesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CustomerApi(simpleKey);


            try
            {
                // Retrieve values needed for a customer profile editor
                CustomerEditorValues result = apiInstance.GetCustomerEditorValues();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetCustomerEditorValues: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CustomerEditorValues**](CustomerEditorValues.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomeremaillists"></a>
# **GetCustomerEmailLists**
> EmailListsResponse GetCustomerEmailLists ()

Retrieve all email lists across all storefronts

Retrieve all email lists across all storefronts 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCustomerEmailListsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CustomerApi(simpleKey);


            try
            {
                // Retrieve all email lists across all storefronts
                EmailListsResponse result = apiInstance.GetCustomerEmailLists();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetCustomerEmailLists: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**EmailListsResponse**](EmailListsResponse.md)

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

<a name="getcustomersbyquery"></a>
# **GetCustomersByQuery**
> CustomersResponse GetCustomersByQuery (CustomerQuery customerQuery, int? limit = null, int? offset = null, string since = null, string sort = null, string expand = null)

Retrieve customers by query

Retrieves customers from the account.  If no parameters are specified, all customers will be returned.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCustomersByQueryExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CustomerApi(simpleKey);

            var customerQuery = new CustomerQuery(); // CustomerQuery | Customer query
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Max 200) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var since = since_example;  // string | Fetch customers that have been created/modified since this date/time. (optional) 
            var sort = sort_example;  // string | The sort order of the customers.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve customers by query
                CustomersResponse result = apiInstance.GetCustomersByQuery(customerQuery, limit, offset, since, sort, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetCustomersByQuery: " + e.Message );
            }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomersfordatatables"></a>
# **GetCustomersForDataTables**
> DataTablesServerSideResponse GetCustomersForDataTables (string expand = null)

Retrieve customers for DataTables plugin

Retrieves customers from the account.  If no searches are specified, all customers will be returned. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCustomersForDataTablesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CustomerApi(simpleKey);

            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve customers for DataTables plugin
                DataTablesServerSideResponse result = apiInstance.GetCustomersForDataTables(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetCustomersForDataTables: " + e.Message );
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

[**DataTablesServerSideResponse**](DataTablesServerSideResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailverificationtoken"></a>
# **GetEmailVerificationToken**
> EmailVerifyTokenResponse GetEmailVerificationToken (EmailVerifyTokenRequest tokenRequest)

Create a token that can be used to verify a customer email address

Create a token that can be used to verify a customer email address.  The implementation of how a customer interacts with this token is left to the merchant. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailVerificationTokenExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CustomerApi(simpleKey);

            var tokenRequest = new EmailVerifyTokenRequest(); // EmailVerifyTokenRequest | Token request

            try
            {
                // Create a token that can be used to verify a customer email address
                EmailVerifyTokenResponse result = apiInstance.GetEmailVerificationToken(tokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetEmailVerificationToken: " + e.Message );
            }
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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CustomerApi(simpleKey);

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CustomerApi(simpleKey);

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

<a name="updatecustomeremaillists"></a>
# **UpdateCustomerEmailLists**
> CustomerEmailListChanges UpdateCustomerEmailLists (int? customerProfileOid, CustomerEmailListChanges listChanges)

Update email list subscriptions for a customer

Update email list subscriptions for a customer 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateCustomerEmailListsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CustomerApi(simpleKey);

            var customerProfileOid = 56;  // int? | The customer profile oid
            var listChanges = new CustomerEmailListChanges(); // CustomerEmailListChanges | List changes

            try
            {
                // Update email list subscriptions for a customer
                CustomerEmailListChanges result = apiInstance.UpdateCustomerEmailLists(customerProfileOid, listChanges);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.UpdateCustomerEmailLists: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerProfileOid** | **int?**| The customer profile oid | 
 **listChanges** | [**CustomerEmailListChanges**](CustomerEmailListChanges.md)| List changes | 

### Return type

[**CustomerEmailListChanges**](CustomerEmailListChanges.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validateemailverificationtoken"></a>
# **ValidateEmailVerificationToken**
> EmailVerifyTokenValidateResponse ValidateEmailVerificationToken (EmailVerifyTokenValidateRequest validationRequest)

Validate a token that can be used to verify a customer email address

Validate a token that can be used to verify a customer email address.  The implementation of how a customer interacts with this token is left to the merchant. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ValidateEmailVerificationTokenExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new CustomerApi(simpleKey);

            var validationRequest = new EmailVerifyTokenValidateRequest(); // EmailVerifyTokenValidateRequest | Token validation request

            try
            {
                // Validate a token that can be used to verify a customer email address
                EmailVerifyTokenValidateResponse result = apiInstance.ValidateEmailVerificationToken(validationRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.ValidateEmailVerificationToken: " + e.Message );
            }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

