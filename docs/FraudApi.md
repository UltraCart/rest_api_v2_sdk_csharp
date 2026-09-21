# com.ultracart.admin.v2.Api.FraudApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeclineEmail**](FraudApi.md#declineemail) | **POST** /fraud/decline_email | Decline email during checkout fraud review
[**DeleteFraudRule**](FraudApi.md#deletefraudrule) | **DELETE** /fraud/rules/{fraud_rule_oid} | Delete a fraud rule
[**EstablishFraudRulesFromOrder**](FraudApi.md#establishfraudrulesfromorder) | **POST** /fraud/rules/from_order | Establish fraud rules from an order
[**GetFraudLookupValues**](FraudApi.md#getfraudlookupvalues) | **GET** /fraud/lookup_values | Retrieve fraud rule lookup values
[**InsertFraudRule**](FraudApi.md#insertfraudrule) | **POST** /fraud/rules | Insert a fraud rule
[**SearchFraudRules**](FraudApi.md#searchfraudrules) | **POST** /fraud/rules/search | Search fraud rules



## DeclineEmail

> void DeclineEmail (FraudDeclineEmailRequest fraudDeclineEmailsRequest)

Decline email during checkout fraud review

Adds one email address to the fraud decline list for this merchant account. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.fraud
{
    public class DeclineEmail
    {
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            try
            {
                // declineEmail is a shortcut for telling UltraCart to decline orders from a specific
                // email address. It is the quick alternative to building a full "address email" fraud
                // rule by hand.
                FraudApi fraudApi = new FraudApi(Constants.ApiKey);

                FraudDeclineEmailRequest declineRequest = new FraudDeclineEmailRequest();
                declineRequest.Email = "chargeback-charlie@example.com";

                fraudApi.DeclineEmail(declineRequest);

                Console.WriteLine("Declined email: " + declineRequest.Email);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fraudDeclineEmailsRequest** | [**FraudDeclineEmailRequest**](FraudDeclineEmailRequest.md)| Fraud decline emails request | 

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
| **204** | No Content |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteFraudRule

> void DeleteFraudRule (int fraudRuleOid)

Delete a fraud rule

Deletes a fraud rule for this merchant account. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.fraud
{
    public class DeleteFraudRule
    {
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            try
            {
                // deleteFraudRule removes a fraud rule by its oid.
                //
                // To keep this sample self-contained it first inserts a throwaway rule, then deletes it
                // using the oid returned from the insert. In your own code you would already have the oid
                // of the rule you want to remove (for example from SearchFraudRules).
                FraudApi fraudApi = new FraudApi(Constants.ApiKey);

                // Insert a rule so we have something to delete.
                FraudRuleInsertRequest rule = new FraudRuleInsertRequest();
                rule.RuleType = FraudRuleInsertRequest.RuleTypeEnum.Creditcardsingletransactionexceeds;
                rule.AmountThreshold = 2500.00m;
                rule.FailureAction = FraudRuleInsertRequest.FailureActionEnum.FlagForReview;
                rule.AutoNote = "Temporary rule created by the DeleteFraudRule sample";

                FraudRuleResponse insertResponse = fraudApi.InsertFraudRule(rule);
                int fraudRuleOid = insertResponse.FraudRule.FraudRuleOid;
                Console.WriteLine("Inserted temporary rule, oid = " + fraudRuleOid);

                // Now delete it.
                fraudApi.DeleteFraudRule(fraudRuleOid);
                Console.WriteLine("Deleted fraud rule oid = " + fraudRuleOid);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fraudRuleOid** | **int**|  | 

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
| **204** | No Content |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EstablishFraudRulesFromOrder

> FraudRulesResponse EstablishFraudRulesFromOrder (FraudRuleFromOrderRequest fraudRuleFromOrderRequest)

Establish fraud rules from an order

Creates one or more fraud rules for this merchant account derived from an existing order, mirroring the 'establish fraud filter' action in the order processing screen. Select which filters to establish; all values are taken from the order. The IP rule is created against the order's /24 subnet (last octet masked). The credit card filter duplicates the order's stored card vault token, so no card number is sent through the API. Filters whose order data is missing (no stored card, no email, no usable IP, or no numeric street) are skipped and reported in the warning slot rather than failing the request. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.fraud
{
    public class EstablishFraudRulesFromOrder
    {
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            try
            {
                // establishFraudRulesFromOrder is a shortcut that derives fraud rules from an existing
                // order. Point it at an order you have identified as fraudulent and tell it which
                // attributes of that order to turn into rules: the email, the credit card, the ip
                // address, and/or the address. It creates the matching rules and returns them. This is
                // the fast way to "block everything associated with this bad order" instead of building
                // each rule by hand.
                //
                // Not every filter produces a rule; the order must actually have that attribute. For
                // example an order with no stored card data will not produce a credit card rule.
                FraudApi fraudApi = new FraudApi(Constants.ApiKey);

                FraudRuleFromOrderRequest request = new FraudRuleFromOrderRequest();
                request.OrderId = "DEMO-0009104434";
                request.EstablishEmailFilter = true;
                request.EstablishCardFilter = true;
                request.EstablishIpFilter = true;
                request.EstablishAddressFilter = true;
                request.FailureAction = FraudRuleFromOrderRequest.FailureActionEnum.FlagForReview;
                request.AutoNote = "Established from fraudulent order DEMO-0009104434";

                FraudRulesResponse apiResponse = fraudApi.EstablishFraudRulesFromOrder(request);

                Console.WriteLine("Established " + apiResponse.FraudRules.Count + " rule(s) from the order:");
                foreach (FraudRulePublic fraudRule in apiResponse.FraudRules)
                {
                    Console.WriteLine("  oid " + fraudRule.FraudRuleOid + " - " + fraudRule.RuleType + " - " + fraudRule.AutoNote);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fraudRuleFromOrderRequest** | [**FraudRuleFromOrderRequest**](FraudRuleFromOrderRequest.md)| Fraud rule from order request | 

### Return type

[**FraudRulesResponse**](FraudRulesResponse.md)

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


## GetFraudLookupValues

> FraudLookupValuesResponse GetFraudLookupValues ()

Retrieve fraud rule lookup values

Returns the dropdown values required to build valid fraud rule insert and search requests. Includes rule types, failure actions, user actions, IP range types, AVS match types, the merchant's rotating transaction gateways, screen branding themes, countries, and affiliates. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.fraud
{
    public class GetFraudLookupValues
    {
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            try
            {
                // getFraudLookupValues returns the lookup values used when building fraud rules:
                // the allowed countries, affiliates, ip range types, rule groups, and rule types.
                // Call this first when constructing a rule so you supply valid values.
                FraudApi fraudApi = new FraudApi(Constants.ApiKey);

                FraudLookupValuesResponse apiResponse = fraudApi.GetFraudLookupValues();
                FraudLookupValues lookupValues = apiResponse.FraudLookupValues;

                Console.WriteLine("Rule types: " + lookupValues.RuleTypes);
                Console.WriteLine("Rule groups: " + lookupValues.RuleGroups);
                Console.WriteLine("IP range types: " + lookupValues.IpRangeTypes);
                Console.WriteLine("Countries: " + lookupValues.Countries);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
```


### Parameters

This endpoint does not need any parameter.

### Return type

[**FraudLookupValuesResponse**](FraudLookupValuesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InsertFraudRule

> FraudRuleResponse InsertFraudRule (FraudRuleInsertRequest fraudRuleInsertRequest)

Insert a fraud rule

Creates a fraud rule for this merchant account. Field names in the request body are semantic (eg amount_threshold, email, ip_address). Call GET /v2/fraud/lookup_values for the list of valid rule_type, failure_action, and related dropdown values. The 'credit card matches' rule type is not supported via REST. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.fraud
{
    public class InsertFraudRule
    {
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            try
            {
                // insertFraudRule creates a single fraud rule. Each rule has a rule_type (what it
                // inspects), a failure_action (what happens when it matches), and type-specific fields
                // such as an amount threshold, country code, ip address, or email.
                //
                // This sample has some fun and inserts several rules of different types in one run.
                // Call GetFraudLookupValues.cs to see every valid rule_type and the other lookup values.
                FraudApi fraudApi = new FraudApi(Constants.ApiKey);

                List<FraudRuleInsertRequest> rules = new List<FraudRuleInsertRequest>();

                // 1. Decline any order placed with a known-bad email address.
                FraudRuleInsertRequest emailRule = new FraudRuleInsertRequest();
                emailRule.RuleType = FraudRuleInsertRequest.RuleTypeEnum.Addressemail;
                emailRule.Email = "chargeback-charlie@example.com";
                emailRule.FailureAction = FraudRuleInsertRequest.FailureActionEnum.DeclineTransaction;
                emailRule.AutoNote = "Known chargeback email - decline on sight";
                rules.Add(emailRule);

                // 2. Flag large single credit card transactions over $1,000 for manual review.
                FraudRuleInsertRequest largeTxnRule = new FraudRuleInsertRequest();
                largeTxnRule.RuleType = FraudRuleInsertRequest.RuleTypeEnum.Creditcardsingletransactionexceeds;
                largeTxnRule.AmountThreshold = 1000.00m;
                largeTxnRule.FailureAction = FraudRuleInsertRequest.FailureActionEnum.FlagForReview;
                largeTxnRule.AutoNote = "Large single transaction - review before shipping";
                rules.Add(largeTxnRule);

                // 3. Decline orders that ship outside the United States.
                FraudRuleInsertRequest countryRule = new FraudRuleInsertRequest();
                countryRule.RuleType = FraudRuleInsertRequest.RuleTypeEnum.Addressnotincountry;
                countryRule.CountryCode = "US";
                countryRule.FailureAction = FraudRuleInsertRequest.FailureActionEnum.DeclineTransaction;
                countryRule.AutoNote = "Domestic shipping only";
                rules.Add(countryRule);

                // 4. Decline transactions originating from a specific bad IP address.
                FraudRuleInsertRequest ipRule = new FraudRuleInsertRequest();
                ipRule.RuleType = FraudRuleInsertRequest.RuleTypeEnum.Ipmatches;
                ipRule.IpAddress = "203.0.113.66";
                ipRule.IpRangeType = FraudRuleInsertRequest.IpRangeTypeEnum.Address;
                ipRule.FailureAction = FraudRuleInsertRequest.FailureActionEnum.DeclineTransaction;
                ipRule.AutoNote = "Blocked IP address";
                rules.Add(ipRule);

                // 5. Flag prepaid credit cards for review.
                FraudRuleInsertRequest prepaidRule = new FraudRuleInsertRequest();
                prepaidRule.RuleType = FraudRuleInsertRequest.RuleTypeEnum.Creditcardblockprepaid;
                prepaidRule.FailureAction = FraudRuleInsertRequest.FailureActionEnum.FlagForReview;
                prepaidRule.AutoNote = "Prepaid card - take a closer look";
                rules.Add(prepaidRule);

                // 6. Flag a customer IP making more than 10 transactions in a single day.
                FraudRuleInsertRequest velocityRule = new FraudRuleInsertRequest();
                velocityRule.RuleType = FraudRuleInsertRequest.RuleTypeEnum.Ipdailytransactioncountexceeds;
                velocityRule.CountThreshold = 10;
                velocityRule.IpRangeType = FraudRuleInsertRequest.IpRangeTypeEnum.Address;
                velocityRule.UserAction = FraudRuleInsertRequest.UserActionEnum.Attempted;
                velocityRule.FailureAction = FraudRuleInsertRequest.FailureActionEnum.FlagForReview;
                velocityRule.AutoNote = "IP velocity - more than 10 orders in a day";
                rules.Add(velocityRule);

                foreach (FraudRuleInsertRequest rule in rules)
                {
                    FraudRuleResponse apiResponse = fraudApi.InsertFraudRule(rule);
                    FraudRulePublic created = apiResponse.FraudRule;
                    Console.WriteLine("Inserted '" + rule.RuleType + "' rule, oid = " + created.FraudRuleOid);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fraudRuleInsertRequest** | [**FraudRuleInsertRequest**](FraudRuleInsertRequest.md)| Fraud rule insert request | 

### Return type

[**FraudRuleResponse**](FraudRuleResponse.md)

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


## SearchFraudRules

> FraudRulesResponse SearchFraudRules (FraudRuleSearchRequest fraudRuleSearchRequest, int? limit = null, int? offset = null, string sort = null)

Search fraud rules

Searches fraud rules for this merchant account using semantic filter fields. Pagination and sort are passed as query parameters (_limit, _offset, _sort). You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. Results are capped at 10,000 records by ElasticSearch and the warning slot indicates when that cap was hit. Use more selective filters in that case. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.fraud
{
    public class SearchFraudRules
    {
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            try
            {
                // searchFraudRules returns the fraud rules that match the supplied criteria. Every field
                // on the FraudRuleSearchRequest is optional; supply only the ones you want to filter on.
                // Pagination and sort are passed as the limit, offset, and sort parameters.
                //
                // This sample searches for every rule whose action is "Decline Transaction".
                FraudApi fraudApi = new FraudApi(Constants.ApiKey);

                FraudRuleSearchRequest searchRequest = new FraudRuleSearchRequest();
                searchRequest.FailureAction = FraudRuleSearchRequest.FailureActionEnum.DeclineTransaction;

                FraudRulesResponse apiResponse = fraudApi.SearchFraudRules(searchRequest, 200, 0, null);

                Console.WriteLine("Found " + apiResponse.FraudRules.Count + " rule(s) with action 'Decline Transaction'");
                foreach (FraudRulePublic fraudRule in apiResponse.FraudRules)
                {
                    Console.WriteLine("  oid " + fraudRule.FraudRuleOid + " - " + fraudRule.RuleType + " - " + fraudRule.AutoNote);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fraudRuleSearchRequest** | [**FraudRuleSearchRequest**](FraudRuleSearchRequest.md)| Fraud rule search request | 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Maximum 200) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **sort** | **string**| The sort order of the fraud rules.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 

### Return type

[**FraudRulesResponse**](FraudRulesResponse.md)

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

