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
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

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
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

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
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCustomersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new CustomerApi();
            var email = email_example;  // string | Email (optional) 
            var qbClass = qbClass_example;  // string | Quickbooks class (optional) 
            var quickbooksCode = quickbooksCode_example;  // string | Quickbooks code (optional) 
            var lastModifiedDtsStart = lastModifiedDtsStart_example;  // string | Last modified date start (optional) 
            var lastModifiedDtsEnd = lastModifiedDtsEnd_example;  // string | Last modified date end (optional) 
            var signupDtsStart = signupDtsStart_example;  // string | Signup date start (optional) 
            var signupDtsEnd = signupDtsEnd_example;  // string | Signup date end (optional) 
            var billingFirstName = billingFirstName_example;  // string | Billing first name (optional) 
            var billingLastName = billingLastName_example;  // string | Billing last name (optional) 
            var billingCompany = billingCompany_example;  // string | Billing company (optional) 
            var billingCity = billingCity_example;  // string | Billing city (optional) 
            var billingState = billingState_example;  // string | Billing state (optional) 
            var billingPostalCode = billingPostalCode_example;  // string | Billing postal code (optional) 
            var billingCountryCode = billingCountryCode_example;  // string | Billing country code (optional) 
            var billingDayPhone = billingDayPhone_example;  // string | Billing day phone (optional) 
            var billingEveningPhone = billingEveningPhone_example;  // string | Billing evening phone (optional) 
            var shippingFirstName = shippingFirstName_example;  // string | Shipping first name (optional) 
            var shippingLastName = shippingLastName_example;  // string | Shipping last name (optional) 
            var shippingCompany = shippingCompany_example;  // string | Shipping company (optional) 
            var shippingCity = shippingCity_example;  // string | Shipping city (optional) 
            var shippingState = shippingState_example;  // string | Shipping state (optional) 
            var shippingPostalCode = shippingPostalCode_example;  // string | Shipping postal code (optional) 
            var shippingCountryCode = shippingCountryCode_example;  // string | Shipping country code (optional) 
            var shippingDayPhone = shippingDayPhone_example;  // string | Shipping day phone (optional) 
            var shippingEveningPhone = shippingEveningPhone_example;  // string | Shipping evening phone (optional) 
            var pricingTierOid = 56;  // int? | Pricing tier oid (optional) 
            var pricingTierName = pricingTierName_example;  // string | Pricing tier name (optional) 
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Max 200) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var since = since_example;  // string | Fetch customers that have been created/modified since this date/time. (optional) 
            var sort = sort_example;  // string | The sort order of the customers.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve customers
                CustomersResponse result = apiInstance.GetCustomers(email, qbClass, quickbooksCode, lastModifiedDtsStart, lastModifiedDtsEnd, signupDtsStart, signupDtsEnd, billingFirstName, billingLastName, billingCompany, billingCity, billingState, billingPostalCode, billingCountryCode, billingDayPhone, billingEveningPhone, shippingFirstName, shippingLastName, shippingCompany, shippingCity, shippingState, shippingPostalCode, shippingCountryCode, shippingDayPhone, shippingEveningPhone, pricingTierOid, pricingTierName, limit, offset, since, sort, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetCustomers: " + e.Message );
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
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

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
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

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

