# com.ultracart.admin.v2.Api.ConfigurationApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DelayAutoOrders**](ConfigurationApi.md#delayautoorders) | **POST** /configuration/checkout/payments/rtg/{rtg_oid}/delayAutoOrders | Delay auto order processing for a day for this rotating transaction gateway
[**DeleteRotatingTransactionGateway**](ConfigurationApi.md#deleterotatingtransactiongateway) | **DELETE** /configuration/checkout/payments/rtg/{rtg_oid} | Delete a rotating transaction gateway
[**GetPaymentsConfiguration**](ConfigurationApi.md#getpaymentsconfiguration) | **GET** /configuration/checkout/payments | Retrieve payments configuration
[**GetPaymentsRotatingGateway**](ConfigurationApi.md#getpaymentsrotatinggateway) | **GET** /configuration/checkout/payments/rtg/{rtg_oid} | Retrieve a rotating transaction gateway
[**GetPaymentsRotatingGatewayByCode**](ConfigurationApi.md#getpaymentsrotatinggatewaybycode) | **GET** /configuration/checkout/payments/rtg/byCode/{code} | Retrieve a rotating transaction gateway by code
[**GetPaymentsRotatingTransactionGateways**](ConfigurationApi.md#getpaymentsrotatingtransactiongateways) | **GET** /configuration/checkout/payments/rtg | Retrieve a list of rotating transaction gateways
[**GetPaymentsRtgSummaries**](ConfigurationApi.md#getpaymentsrtgsummaries) | **GET** /configuration/checkout/payments/rtg/summaries | Retrieve a summary of rotating transaction gateways
[**GetPaymentsTransactionGateways**](ConfigurationApi.md#getpaymentstransactiongateways) | **GET** /configuration/checkout/payments/tg | Retrieve a list of transaction gateways
[**InsertRotatingTransactionGateway**](ConfigurationApi.md#insertrotatingtransactiongateway) | **POST** /configuration/checkout/payments/rtg/ | Insert a rotating transaction gateway
[**MigrateToRotatingTransactionGateway**](ConfigurationApi.md#migratetorotatingtransactiongateway) | **POST** /configuration/checkout/payments/tg/migrateToRtgWithCodeOf/{code} | Migrate a normal transaction gateway to a rotating transaction gateway
[**StripeConnect**](ConfigurationApi.md#stripeconnect) | **POST** /configuration/checkout/payments/rtg/{rtg_oid}/stripeConnect | Begin the processing of connecting with Stripe
[**UpdatePaymentsConfiguration**](ConfigurationApi.md#updatepaymentsconfiguration) | **PUT** /configuration/checkout/payments | Updates payments configuration
[**UpdatePaymentsTransactionGateway**](ConfigurationApi.md#updatepaymentstransactiongateway) | **PUT** /configuration/checkout/payments/tg | Updates payments transaction gateway
[**UpdateRotatingTransactionGateway**](ConfigurationApi.md#updaterotatingtransactiongateway) | **PUT** /configuration/checkout/payments/rtg/{rtg_oid} | Update a rotating transaction gateway
[**WepayEnroll**](ConfigurationApi.md#wepayenroll) | **PUT** /configuration/checkout/wepayEnroll | Enroll with WePay


<a name="delayautoorders"></a>
# **DelayAutoOrders**
> DelayAutoOrdersResponse DelayAutoOrders (int? rtgOid)

Delay auto order processing for a day for this rotating transaction gateway

Delay auto order processing for a day for this rotating transaction gateway 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DelayAutoOrdersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConfigurationApi(simpleKey);

            var rtgOid = 56;  // int? | The rtg_oid to delay.

            try
            {
                // Delay auto order processing for a day for this rotating transaction gateway
                DelayAutoOrdersResponse result = apiInstance.DelayAutoOrders(rtgOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.DelayAutoOrders: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rtgOid** | **int?**| The rtg_oid to delay. | 

### Return type

[**DelayAutoOrdersResponse**](DelayAutoOrdersResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterotatingtransactiongateway"></a>
# **DeleteRotatingTransactionGateway**
> BaseResponse DeleteRotatingTransactionGateway (int? rtgOid)

Delete a rotating transaction gateway

Delete a rotating transaction gateway 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteRotatingTransactionGatewayExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConfigurationApi(simpleKey);

            var rtgOid = 56;  // int? | The rtg_oid to delete.

            try
            {
                // Delete a rotating transaction gateway
                BaseResponse result = apiInstance.DeleteRotatingTransactionGateway(rtgOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.DeleteRotatingTransactionGateway: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rtgOid** | **int?**| The rtg_oid to delete. | 

### Return type

[**BaseResponse**](BaseResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentsconfiguration"></a>
# **GetPaymentsConfiguration**
> PaymentsConfigurationResponse GetPaymentsConfiguration ()

Retrieve payments configuration

Retrieves payments configuration for this account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPaymentsConfigurationExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConfigurationApi(simpleKey);


            try
            {
                // Retrieve payments configuration
                PaymentsConfigurationResponse result = apiInstance.GetPaymentsConfiguration();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.GetPaymentsConfiguration: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PaymentsConfigurationResponse**](PaymentsConfigurationResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentsrotatinggateway"></a>
# **GetPaymentsRotatingGateway**
> RotatingTransactionGatewayResponse GetPaymentsRotatingGateway (int? rtgOid)

Retrieve a rotating transaction gateway

Retrieve a rotating transaction gateway 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPaymentsRotatingGatewayExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConfigurationApi(simpleKey);

            var rtgOid = 56;  // int? | The rtg_oid for the desired record.

            try
            {
                // Retrieve a rotating transaction gateway
                RotatingTransactionGatewayResponse result = apiInstance.GetPaymentsRotatingGateway(rtgOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.GetPaymentsRotatingGateway: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rtgOid** | **int?**| The rtg_oid for the desired record. | 

### Return type

[**RotatingTransactionGatewayResponse**](RotatingTransactionGatewayResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentsrotatinggatewaybycode"></a>
# **GetPaymentsRotatingGatewayByCode**
> RotatingTransactionGatewayResponse GetPaymentsRotatingGatewayByCode (string code)

Retrieve a rotating transaction gateway by code

Retrieve a rotating transaction gateway by code 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPaymentsRotatingGatewayByCodeExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConfigurationApi(simpleKey);

            var code = code_example;  // string | The code for the desired rotating transaction gateway.

            try
            {
                // Retrieve a rotating transaction gateway by code
                RotatingTransactionGatewayResponse result = apiInstance.GetPaymentsRotatingGatewayByCode(code);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.GetPaymentsRotatingGatewayByCode: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The code for the desired rotating transaction gateway. | 

### Return type

[**RotatingTransactionGatewayResponse**](RotatingTransactionGatewayResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentsrotatingtransactiongateways"></a>
# **GetPaymentsRotatingTransactionGateways**
> RotatingTransactionGatewaysResponse GetPaymentsRotatingTransactionGateways ()

Retrieve a list of rotating transaction gateways

Retrieve a list of rotating transaction gateways 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPaymentsRotatingTransactionGatewaysExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConfigurationApi(simpleKey);


            try
            {
                // Retrieve a list of rotating transaction gateways
                RotatingTransactionGatewaysResponse result = apiInstance.GetPaymentsRotatingTransactionGateways();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.GetPaymentsRotatingTransactionGateways: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RotatingTransactionGatewaysResponse**](RotatingTransactionGatewaysResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentsrtgsummaries"></a>
# **GetPaymentsRtgSummaries**
> RtgSummaryResponse GetPaymentsRtgSummaries ()

Retrieve a summary of rotating transaction gateways

Retrieve a summary of rotating transaction gateways 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPaymentsRtgSummariesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConfigurationApi(simpleKey);


            try
            {
                // Retrieve a summary of rotating transaction gateways
                RtgSummaryResponse result = apiInstance.GetPaymentsRtgSummaries();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.GetPaymentsRtgSummaries: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RtgSummaryResponse**](RtgSummaryResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentstransactiongateways"></a>
# **GetPaymentsTransactionGateways**
> TransactionGatewaysResponse GetPaymentsTransactionGateways ()

Retrieve a list of transaction gateways

Retrieve a list of transaction gateways 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPaymentsTransactionGatewaysExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConfigurationApi(simpleKey);


            try
            {
                // Retrieve a list of transaction gateways
                TransactionGatewaysResponse result = apiInstance.GetPaymentsTransactionGateways();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.GetPaymentsTransactionGateways: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TransactionGatewaysResponse**](TransactionGatewaysResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertrotatingtransactiongateway"></a>
# **InsertRotatingTransactionGateway**
> RotatingTransactionGatewayResponse InsertRotatingTransactionGateway (RotatingTransactionGateway rotatingTransactionGateway)

Insert a rotating transaction gateway

Insert a rotating transaction gateway 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertRotatingTransactionGatewayExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConfigurationApi(simpleKey);

            var rotatingTransactionGateway = new RotatingTransactionGateway(); // RotatingTransactionGateway | Rotating transaction gateway

            try
            {
                // Insert a rotating transaction gateway
                RotatingTransactionGatewayResponse result = apiInstance.InsertRotatingTransactionGateway(rotatingTransactionGateway);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.InsertRotatingTransactionGateway: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rotatingTransactionGateway** | [**RotatingTransactionGateway**](RotatingTransactionGateway.md)| Rotating transaction gateway | 

### Return type

[**RotatingTransactionGatewayResponse**](RotatingTransactionGatewayResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migratetorotatingtransactiongateway"></a>
# **MigrateToRotatingTransactionGateway**
> RotatingTransactionGatewayResponse MigrateToRotatingTransactionGateway (string code)

Migrate a normal transaction gateway to a rotating transaction gateway

Migrate a normal transaction gateway to a rotating transaction gateway 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class MigrateToRotatingTransactionGatewayExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConfigurationApi(simpleKey);

            var code = code_example;  // string | The short code for the new rotating transaction gateway

            try
            {
                // Migrate a normal transaction gateway to a rotating transaction gateway
                RotatingTransactionGatewayResponse result = apiInstance.MigrateToRotatingTransactionGateway(code);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.MigrateToRotatingTransactionGateway: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The short code for the new rotating transaction gateway | 

### Return type

[**RotatingTransactionGatewayResponse**](RotatingTransactionGatewayResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stripeconnect"></a>
# **StripeConnect**
> StripeConnectResponse StripeConnect (int? rtgOid)

Begin the processing of connecting with Stripe

Begin the processing of connecting with Stripe. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class StripeConnectExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConfigurationApi(simpleKey);

            var rtgOid = 56;  // int? | The rtg_oid to be connected to stripe.

            try
            {
                // Begin the processing of connecting with Stripe
                StripeConnectResponse result = apiInstance.StripeConnect(rtgOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.StripeConnect: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rtgOid** | **int?**| The rtg_oid to be connected to stripe. | 

### Return type

[**StripeConnectResponse**](StripeConnectResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepaymentsconfiguration"></a>
# **UpdatePaymentsConfiguration**
> PaymentsConfigurationResponse UpdatePaymentsConfiguration (PaymentsConfiguration paymentsConfiguration)

Updates payments configuration

Updates payments configuration on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdatePaymentsConfigurationExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConfigurationApi(simpleKey);

            var paymentsConfiguration = new PaymentsConfiguration(); // PaymentsConfiguration | Payments configuration

            try
            {
                // Updates payments configuration
                PaymentsConfigurationResponse result = apiInstance.UpdatePaymentsConfiguration(paymentsConfiguration);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.UpdatePaymentsConfiguration: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentsConfiguration** | [**PaymentsConfiguration**](PaymentsConfiguration.md)| Payments configuration | 

### Return type

[**PaymentsConfigurationResponse**](PaymentsConfigurationResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepaymentstransactiongateway"></a>
# **UpdatePaymentsTransactionGateway**
> TransactionGatewaysResponse UpdatePaymentsTransactionGateway (TransactionGatewaysRequest updateGatewayRequest)

Updates payments transaction gateway

Updates payments transaction gateway on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdatePaymentsTransactionGatewayExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConfigurationApi(simpleKey);

            var updateGatewayRequest = new TransactionGatewaysRequest(); // TransactionGatewaysRequest | Transaction gateways

            try
            {
                // Updates payments transaction gateway
                TransactionGatewaysResponse result = apiInstance.UpdatePaymentsTransactionGateway(updateGatewayRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.UpdatePaymentsTransactionGateway: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateGatewayRequest** | [**TransactionGatewaysRequest**](TransactionGatewaysRequest.md)| Transaction gateways | 

### Return type

[**TransactionGatewaysResponse**](TransactionGatewaysResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterotatingtransactiongateway"></a>
# **UpdateRotatingTransactionGateway**
> RotatingTransactionGateway UpdateRotatingTransactionGateway (int? rtgOid, RotatingTransactionGateway rotatingTransactionGateway)

Update a rotating transaction gateway

Update a rotating transaction gateway 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateRotatingTransactionGatewayExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConfigurationApi(simpleKey);

            var rtgOid = 56;  // int? | The rtg_oid to update.
            var rotatingTransactionGateway = new RotatingTransactionGateway(); // RotatingTransactionGateway | Rotating transaction gateway

            try
            {
                // Update a rotating transaction gateway
                RotatingTransactionGateway result = apiInstance.UpdateRotatingTransactionGateway(rtgOid, rotatingTransactionGateway);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.UpdateRotatingTransactionGateway: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rtgOid** | **int?**| The rtg_oid to update. | 
 **rotatingTransactionGateway** | [**RotatingTransactionGateway**](RotatingTransactionGateway.md)| Rotating transaction gateway | 

### Return type

[**RotatingTransactionGateway**](RotatingTransactionGateway.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wepayenroll"></a>
# **WepayEnroll**
> PaymentsConfigurationResponse WepayEnroll (PaymentsWepayEnroll wepayEnroll)

Enroll with WePay

Enroll with WePay on the UltraCart account. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class WepayEnrollExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConfigurationApi(simpleKey);

            var wepayEnroll = new PaymentsWepayEnroll(); // PaymentsWepayEnroll | Wepay enrollment information

            try
            {
                // Enroll with WePay
                PaymentsConfigurationResponse result = apiInstance.WepayEnroll(wepayEnroll);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.WepayEnroll: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **wepayEnroll** | [**PaymentsWepayEnroll**](PaymentsWepayEnroll.md)| Wepay enrollment information | 

### Return type

[**PaymentsConfigurationResponse**](PaymentsConfigurationResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

