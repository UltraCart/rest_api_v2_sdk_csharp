# com.ultracart.admin.v2.Api.ChannelPartnerApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelOrderByChannelPartnerOrderId**](ChannelPartnerApi.md#cancelorderbychannelpartnerorderid) | **DELETE** /channel_partner/cancel/by_channel_partner_order_id/{order_id} | Cancel channel partner order by channel partner order id
[**CancelOrderByUltraCartOrderId**](ChannelPartnerApi.md#cancelorderbyultracartorderid) | **DELETE** /channel_partner/cancel/by_ultracart_order_id/{order_id} | Cancel channel partner order by UltraCart order id
[**DeleteChannelPartnerShipToPreference**](ChannelPartnerApi.md#deletechannelpartnershiptopreference) | **DELETE** /channel_partner/channel_partners/{channel_partner_oid}/ship_to_preferences/{channel_partner_ship_to_preference_oid} | Delete a ship to preference record for the channel partner.
[**EstimateShippingForChannelPartnerOrder**](ChannelPartnerApi.md#estimateshippingforchannelpartnerorder) | **POST** /channel_partner/estimate_shipping | Estimate shipping for channel partner order
[**EstimateTaxForChannelPartnerOrder**](ChannelPartnerApi.md#estimatetaxforchannelpartnerorder) | **POST** /channel_partner/estimate_tax | Estimate tax for channel partner order
[**GetChannelPartnerOrder**](ChannelPartnerApi.md#getchannelpartnerorder) | **GET** /channel_partner/orders/{order_id} | Retrieve a channel partner order
[**GetChannelPartnerOrderByChannelPartnerOrderId**](ChannelPartnerApi.md#getchannelpartnerorderbychannelpartnerorderid) | **GET** /channel_partner/orders/by_channel_partner_order_id/{order_id} | Retrieve a channel partner order by the channel partner order id
[**GetChannelPartnerReasonCodes**](ChannelPartnerApi.md#getchannelpartnerreasoncodes) | **GET** /channel_partner/channel_partners/{channel_partner_oid}/reason_codes | Retrieve reject and refund reason codes.
[**GetChannelPartnerShipToPreference**](ChannelPartnerApi.md#getchannelpartnershiptopreference) | **GET** /channel_partner/channel_partners/{channel_partner_oid}/ship_to_preferences/{channel_partner_ship_to_preference_oid} | Retrieve the ship to preference associated with the channel partner and the specific id.
[**GetChannelPartnerShipToPreferences**](ChannelPartnerApi.md#getchannelpartnershiptopreferences) | **GET** /channel_partner/channel_partners/{channel_partner_oid}/ship_to_preferences | Retrieve the ship to preferences associated with the channel partner.
[**GetChannelPartners**](ChannelPartnerApi.md#getchannelpartners) | **GET** /channel_partner/channel_partners | Retrieve the channel partners configured on the account.
[**ImportChannelPartnerOrder**](ChannelPartnerApi.md#importchannelpartnerorder) | **POST** /channel_partner/import | Insert channel partner order
[**InsertChannelPartnerShipToPreference**](ChannelPartnerApi.md#insertchannelpartnershiptopreference) | **POST** /channel_partner/channel_partners/{channel_partner_oid}/ship_to_preferences | Insert a ship to preference record for the channel partner.
[**RefundChannelPartnerOrder**](ChannelPartnerApi.md#refundchannelpartnerorder) | **PUT** /channel_partner/orders/{order_id}/refund | Refund a channel partner order
[**UpdateChannelPartnerShipToPreference**](ChannelPartnerApi.md#updatechannelpartnershiptopreference) | **PUT** /channel_partner/channel_partners/{channel_partner_oid}/ship_to_preferences/{channel_partner_ship_to_preference_oid} | Update a ship to preference record for the channel partner.



## CancelOrderByChannelPartnerOrderId

> ChannelPartnerCancelResponse CancelOrderByChannelPartnerOrderId (string orderId)

Cancel channel partner order by channel partner order id

Cancel channel partner order by channel partner order id 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.channel_partner
{
    public class CancelOrderByChannelPartnerOrderId
    {
        /*
        cancelOrderByChannelPartnerOrderId takes a channel partner order id, which is the external order id, and attempts
        to 'cancel' the order.  UltraCart doesn't have a cancel order state, so this needs some explanation of what happens.

        Here is the logic of the cancel process:
        If the Order stage is [this] then do [that]:
            'Completed Order'       -> Error: "Order has already been completed."
            'Rejected'              -> Error: "Order has already been rejected."
            'Accounts Receivable'   -> Success: order is rejected.
            'Preordered'            -> Success: order is rejected.
            'Quote Sent'            -> Success: order is rejected.
            'Quote Requested'       -> Success: order is rejected.

        The remaining stages are Fraud Review and Shipping Department.  Orders in these stages have already completed payment.
        From this point, complex logic determines if the order has already shipped, or is queued to ship in a way that cannot be canceled.
        Here is the logic for those stages, but the gist of it all is this:  If you receive any of the errors below, the order has progressed past a point where it can be canceled.
        SHIPPING LOGIC:
        Iterate through each item and consider it's shipping status:
            Item has already been transmitted to fulfillment center (contains a transmitted dts) -> Error: "The order has already had an item that has been transmitted to the distribution center."
            Does item DC (distribution center) have a transmission mechanism configured?
                YES -> Does the transmission have schedules? If NO -> Error: "The distribution center does not have any schedules so it would be an immediate transmission."
                NO -> Error: "Cant tell if we can cancel because the DC doesnt have a transport configured."

        If the above logic completes without errors, the following conditions must be met:
        Order has DC activity records.  If NO -> Error: "There is no activity in the DC queue when there should be."
        There must be at least 5 minutes before the next DC transmission. If NO -> Error: "Activity record is not at least 5 minutes away so we need to bail."

        At this point, the order will be canceled with the following activity:
        1) Distribution Center activity is cleared
        2) The order is refunded.  If the order is less than 24 hours old, a void is attempted instead.


        Other Possible Errors:
        System errors -> "Internal error.  Please contact UltraCart Support."
        Order does not exist -> "Invalid order ID specified."
        During refunding, original transaction could not be found -> "Unable to find original transaction on the order."
        During refunding, original transaction was found, but transaction id could not be found -> "Unable to locate original transaction reference number."
        During refunding, PayPal was used by no longer configured -> "PayPal is no longer configured on your account to refund against."
        Gateway does not support refunds -> [GatewayName] does not support refunds at this time.
        */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create channel partner API instance using API key
                ChannelPartnerApi channelPartnerApi = new ChannelPartnerApi(Constants.ChannelPartnerApiKey);
                
                string channelPartnerOrderId = "BLAH-BLAH-123";
                var cancelResult = channelPartnerApi.CancelOrderByChannelPartnerOrderId(channelPartnerOrderId);
                
                if (!cancelResult.Success)
                {
                    foreach (string error in cancelResult.CancelErrors)
                    {
                        Console.WriteLine(error);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex); // Dumps all exception information
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The channel partner order id to delete. | 

### Return type

[**ChannelPartnerCancelResponse**](ChannelPartnerCancelResponse.md)

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


## CancelOrderByUltraCartOrderId

> ChannelPartnerCancelResponse CancelOrderByUltraCartOrderId (string orderId)

Cancel channel partner order by UltraCart order id

Cancel channel partner order by UltraCart order id 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.channel_partner
{
    public class CancelOrderByUltraCartOrderId
    {
        /*
        cancelOrderByUltraCartOrderId takes an UltraCart order id and attempts to 'cancel' the order.
        UltraCart doesn't have a cancel order state, so this needs some explanation of what happens.

        Here is the logic of the cancel process:
        If the Order stage is [this] then do [that]:
            'Completed Order'       -> Error: "Order has already been completed."
            'Rejected'              -> Error: "Order has already been rejected."
            'Accounts Receivable'   -> Success: order is rejected.
            'Preordered'            -> Success: order is rejected.
            'Quote Sent'            -> Success: order is rejected.
            'Quote Requested'       -> Success: order is rejected.

        The remaining stages are Fraud Review and Shipping Department.  Orders in these stages have already completed payment.
        From this point, complex logic determines if the order has already shipped, or is queued to ship in a way that cannot be canceled.
        Here is the logic for those stages, but the gist of it all is this:  If you receive any of the errors below, the order has progressed past a point where it can be canceled.
        SHIPPING LOGIC:
        Iterate through each item and consider it's shipping status:
            Item has already been transmitted to fulfillment center (contains a transmitted dts) -> Error: "The order has already had an item that has been transmitted to the distribution center."
            Does item DC (distribution center) have a transmission mechanism configured?
                YES -> Does the transmission have schedules? If NO -> Error: "The distribution center does not have any schedules so it would be an immediate transmission."
                NO -> Error: "Cant tell if we can cancel because the DC doesnt have a transport configured."

        If the above logic completes without errors, the following conditions must be met:
        Order has DC activity records.  If NO -> Error: "There is no activity in the DC queue when there should be."
        There must be at least 5 minutes before the next DC transmission. If NO -> Error: "Activity record is not at least 5 minutes away so we need to bail."

        At this point, the order will be canceled with the following activity:
        1) Distribution Center activity is cleared
        2) The order is refunded.  If the order is less than 24 hours old, a void is attempted instead.


        Other Possible Errors:
        System errors -> "Internal error.  Please contact UltraCart Support."
        Order does not exist -> "Invalid order ID specified."
        During refunding, original transaction could not be found -> "Unable to find original transaction on the order."
        During refunding, original transaction was found, but transaction id could not be found -> "Unable to locate original transaction reference number."
        During refunding, PayPal was used by no longer configured -> "PayPal is no longer configured on your account to refund against."
        Gateway does not support refunds -> [GatewayName] does not support refunds at this time.
        */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create channel partner API instance using API key
                ChannelPartnerApi channelPartnerApi = new ChannelPartnerApi(Constants.ChannelPartnerApiKey);
                
                string ultracartOrderId = "DEMO-12345678980";
                var cancelResult = channelPartnerApi.CancelOrderByUltraCartOrderId(ultracartOrderId);
                
                if (!cancelResult.Success)
                {
                    foreach (string error in cancelResult.CancelErrors)
                    {
                        Console.WriteLine(error);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);  // Dumps all exception information
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The UltraCart order id to delete. | 

### Return type

[**ChannelPartnerCancelResponse**](ChannelPartnerCancelResponse.md)

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


## DeleteChannelPartnerShipToPreference

> void DeleteChannelPartnerShipToPreference (int channelPartnerOid, int channelPartnerShipToPreferenceOid)

Delete a ship to preference record for the channel partner.

Delete a ship to preference record for the channel partner. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.channel_partner
{
    public class DeleteChannelPartnerShipToPreference
    {
        /*
         Deletes a ChannelPartnerShiptoPreference.  These preferences are used by EDI channel partners to automatically
         apply return policies and add additional free items to EDI orders based on the EDI code that is present.

         Success will return a status code 204 (No content)

         Possible Errors:
         Attempting to interact with a channel partner other than the one tied to your API Key:
            "Invalid channel_partner_oid specified.  Your REST API key may only interact with channel_partner_oid: 12345"
         Supply a bad preference oid: "Invalid channel_partner_ship_to_preference_oid specified."
        */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create channel partner API instance using API key
                ChannelPartnerApi channelPartnerApi = new ChannelPartnerApi(Constants.ChannelPartnerApiKey);
                
                int channelPartnerShiptoPreferenceOid = 67890; // you will usually get this by calling getChannelPartnerShipToPreferences()
                int channelPartnerOid = 12345;
                
                channelPartnerApi.DeleteChannelPartnerShipToPreference(channelPartnerOid, channelPartnerShiptoPreferenceOid);
                Console.WriteLine("Channel partner ship to preference deleted successfully");
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
 **channelPartnerOid** | **int**|  | 
 **channelPartnerShipToPreferenceOid** | **int**|  | 

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


## EstimateShippingForChannelPartnerOrder

> ChannelPartnerEstimateShippingResponse EstimateShippingForChannelPartnerOrder (ChannelPartnerOrder channelPartnerOrder)

Estimate shipping for channel partner order

Estimate shipping for order from a channel partner. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.channel_partner
{
    public class EstimateShippingForChannelPartnerOrder
    {
        /*
         This is a helper function for call centers to calculate the shipping cost on an order.  In a typical flow, the call center
         will collect all the shipping information and items being purchased into a ChannelPartnerOrder object.
         They will then call this method, passing in the order object.  The response will contain the shipping estimates
         that the call center can present to the customer.  Once the customer selects a particulate estimate,
         they can then plug that cost into their call center application and complete the order.

         Possible Errors:
         Using an API key that is not tied to a channel partner: "This API Key does not have permission to interact with channel partner orders.  Please review your Channel Partner configuration."
         Order has invalid channel partner code: "Invalid channel partner code"
         Order has no items: "null order.items passed." or "order.items array contains a null entry."
         Order has no channel partner order id: "order.channelPartnerOrderId must be specified."
         Order channel partner order id is a duplicate:  "order.channelPartnerOrderId [XYZ] already used."
         Channel Partner is inactive: "partner is inactive."
        */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create channel partner API instance using API key
                ChannelPartnerApi channelPartnerApi = new ChannelPartnerApi(Constants.ChannelPartnerApiKey);
                
                ChannelPartnerOrder order = new ChannelPartnerOrder()
                {
                    ChannelPartnerOrderId = "widget-1245-abc-1",
                    Coupons = new List<string>() { "10OFF" },
                    // DeliveryDate will impact shipping estimates if there is a delivery deadline.  
                    // DeliveryDate =
                    //    DateTime.Now.AddDays(14).ToString("s", System.Globalization.CultureInfo.InvariantCulture),
                    Items = new List<ChannelPartnerOrderItem>()
                    {
                        new ChannelPartnerOrderItem()
                        {
                            // ArbitraryUnitCost = 9.99m,
                            // AutoOrderLastRebillDts = DateTime.Now.AddDays(-30).ToString("s", System.Globalization.CultureInfo.InvariantCulture),
                            // AutoOrderSchedule = "Weekly",
                            MerchantItemId = "shirt",
                            Options = new List<ChannelPartnerOrderItemOption>()
                            {
                                new ChannelPartnerOrderItemOption()
                                {
                                    Name = "Size",
                                    Value = "Small"
                                },
                                new ChannelPartnerOrderItemOption()
                                {
                                    Name = "Color",
                                    Value = "Orange"
                                }
                            },
                            Quantity = 1,
                            Upsell = false,
                        }
                    },
                    // ShipOnDate = DateTime.Now.AddDays(7).ToString("s", System.Globalization.CultureInfo.InvariantCulture),
                    ShipToResidential = true,
                    ShiptoAddress1 = "55 Main Street",
                    ShiptoAddress2 = "Suite 202",
                    ShiptoCity = "Duluth",
                    ShiptoCompany = "Widgets Inc",
                    ShiptoCountryCode = "US",
                    ShiptoDayPhone = "6785552323",
                    ShiptoEveningPhone = "7703334444",
                    ShiptoFirstName = "Sally",
                    ShiptoLastName = "McGonkyDee",
                    ShiptoPostalCode = "30097",
                    ShiptoStateRegion = "GA",
                    ShiptoTitle = "Director"
                };
                
                var apiResponse = channelPartnerApi.EstimateShippingForChannelPartnerOrder(order);
                var estimates = apiResponse.Estimates;
                
                // TODO: Apply one estimate shipping method (name) and cost to your channel partner order.
                
                // Display shipping estimates
                foreach (var estimate in estimates)
                {
                    Console.WriteLine(estimate);
                }
                
                Console.WriteLine($"Retrieved {estimates.Count} shipping estimates");
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
 **channelPartnerOrder** | [**ChannelPartnerOrder**](ChannelPartnerOrder.md)| Order needing shipping estimate | 

### Return type

[**ChannelPartnerEstimateShippingResponse**](ChannelPartnerEstimateShippingResponse.md)

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


## EstimateTaxForChannelPartnerOrder

> ChannelPartnerEstimateTaxResponse EstimateTaxForChannelPartnerOrder (ChannelPartnerOrder channelPartnerOrder)

Estimate tax for channel partner order

Estimate tax for order from a channel partner. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.channel_partner
{
    public class EstimateTaxForChannelPartnerOrder
    {
        /*
         This is a helper function for call centers to calculate the tax on an order.  In a typical flow, the call center
         will collect all the shipping information and items being purchased into a ChannelPartnerOrder object.
         They will then call this method, passing in the order object.  The response will contain the tax that should be
         collected.  They can then plug that tax into their call center application and complete the order.

         Possible Errors:
         Using an API key that is not tied to a channel partner: "This API Key does not have permission to interact with channel partner orders.  Please review your Channel Partner configuration."
         Order has invalid channel partner code: "Invalid channel partner code"
         Order has no items: "null order.items passed." or "order.items array contains a null entry."
         Order has no channel partner order id: "order.channelPartnerOrderId must be specified."
         Order channel partner order id is a duplicate:  "order.channelPartnerOrderId [XYZ] already used."
         Channel Partner is inactive: "partner is inactive."
        */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create channel partner API instance using API key
                ChannelPartnerApi channelPartnerApi = new ChannelPartnerApi(Constants.ChannelPartnerApiKey);
                
                ChannelPartnerOrder order = new ChannelPartnerOrder()
                {
                    ChannelPartnerOrderId = "widget-1245-abc-1",
                    Coupons = new List<string>() { "10OFF" },
                    // DeliveryDate will impact shipping estimates if there is a delivery deadline.  
                    // DeliveryDate =
                    //    DateTime.Now.AddDays(14).ToString("s", System.Globalization.CultureInfo.InvariantCulture),
                    Items = new List<ChannelPartnerOrderItem>()
                    {
                        new ChannelPartnerOrderItem()
                        {
                            // ArbitraryUnitCost = 9.99m,
                            // AutoOrderLastRebillDts = DateTime.Now.AddDays(-30).ToString("s", System.Globalization.CultureInfo.InvariantCulture),
                            // AutoOrderSchedule = "Weekly",
                            MerchantItemId = "shirt",
                            Options = new List<ChannelPartnerOrderItemOption>()
                            {
                                new ChannelPartnerOrderItemOption()
                                {
                                    Name = "Size",
                                    Value = "Small"
                                },
                                new ChannelPartnerOrderItemOption()
                                {
                                    Name = "Color",
                                    Value = "Orange"
                                }
                            },
                            Quantity = 1,
                            Upsell = false,
                        }
                    },
                    // ShipOnDate = DateTime.Now.AddDays(7).ToString("s", System.Globalization.CultureInfo.InvariantCulture),
                    ShipToResidential = true,
                    ShiptoAddress1 = "55 Main Street",
                    ShiptoAddress2 = "Suite 202",
                    ShiptoCity = "Duluth",
                    ShiptoCompany = "Widgets Inc",
                    ShiptoCountryCode = "US",
                    ShiptoDayPhone = "6785552323",
                    ShiptoEveningPhone = "7703334444",
                    ShiptoFirstName = "Sally",
                    ShiptoLastName = "McGonkyDee",
                    ShiptoPostalCode = "30097",
                    ShiptoStateRegion = "GA",
                    ShiptoTitle = "Director"
                };
                
                var apiResponse = channelPartnerApi.EstimateTaxForChannelPartnerOrder(order);
                var arbitraryTax = apiResponse.ArbitraryTax;
                // TODO: Apply this tax to your channel partner order.
                
                Console.WriteLine($"Estimated tax: {arbitraryTax}");
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
 **channelPartnerOrder** | [**ChannelPartnerOrder**](ChannelPartnerOrder.md)| Order needing tax estimate | 

### Return type

[**ChannelPartnerEstimateTaxResponse**](ChannelPartnerEstimateTaxResponse.md)

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


## GetChannelPartnerOrder

> OrderResponse GetChannelPartnerOrder (string orderId, string expand = null)

Retrieve a channel partner order

Retrieves a single order using the specified order id.  Only orders belonging to this channel partner may be retrieved. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.channel_partner
{
    public class GetChannelPartnerOrder
    {
        /*
         * ChannelPartnerApi.getChannelPartnerOrder() retrieves a single order for a given order_id.  It is identical to the
         * OrderApi.getOrder() call, but allows for a restricted permission set.  The channel partner api assumes
         * a tie to a Channel Partner and only allows retrieval of orders created by that Channel Partner.
         */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create channel partner API instance using API key
                ChannelPartnerApi channelPartnerApi = new ChannelPartnerApi(Constants.ChannelPartnerApiKey);
                
                // The expansion variable instructs UltraCart how much information to return.  The order object is large and
                // while it's easily manageable for a single order, when querying thousands of orders, is useful to reduce
                // payload size.
                // see www.ultracart.com/api/ for all the expansion fields available (this list below may become stale)
                /*
                Possible Order Expansions:
                affiliate           affiliate.ledger                    auto_order
                billing             channel_partner                     checkout
                coupon              customer_profile                    digital_order
                edi                 fraud_score                         gift
                gift_certificate    internal                            item
                linked_shipment     marketing                           payment
                payment.transaction quote                               salesforce
                shipping            shipping.tracking_number_details    summary
                taxes
                */
                
                // A channel partner will almost always query an order for the purpose of turning around and submitting it to a refund call.
                // As such, the expansion most likely needed is listed below.
                string expansion = "item,summary,shipping";
                
                // This order MUST be an order associated with this channel partner or you will receive a 400 Bad Request.
                string orderId = "DEMO-0009110366";
                var apiResponse = channelPartnerApi.GetChannelPartnerOrder(orderId, expansion);
                
                if (apiResponse.Error != null)
                {
                    Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                    Console.Error.WriteLine(apiResponse.Error.UserMessage);
                    Environment.Exit(1);
                }
                
                Order order = apiResponse.Order;
                Console.WriteLine(order);
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
 **orderId** | **string**| The order id to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See OrderApi.getOrder documentation for examples | [optional] 

### Return type

[**OrderResponse**](OrderResponse.md)

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


## GetChannelPartnerOrderByChannelPartnerOrderId

> OrderResponse GetChannelPartnerOrderByChannelPartnerOrderId (string orderId, string expand = null)

Retrieve a channel partner order by the channel partner order id

Retrieves a single order using the channel partner order id, not the ultracart order id.  Only orders belonging to this channel partner may be retrieved. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.channel_partner
{
    public class GetChannelPartnerOrderByChannelPartnerOrderId
    {
        /*
         * ChannelPartnerApi.getChannelPartnerOrderByChannelPartnerOrderId() retrieves a single order for a given
         * channel partner order_id.  This might be useful for call centers which only have their order ids and not UltraCart's.
         * It is identical to the OrderApi.getOrder() call in functionality and result,
         * but allows for a restricted permission set.  The channel partner api assumes a tie to a Channel Partner and
         * only allows retrieval of orders created by that Channel Partner.
         */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create channel partner API instance using API key
                ChannelPartnerApi channelPartnerApi = new ChannelPartnerApi(Constants.ChannelPartnerApiKey);
                
                // The expansion variable instructs UltraCart how much information to return.  The order object is large and
                // while it's easily manageable for a single order, when querying thousands of orders, is useful to reduce
                // payload size.
                // see www.ultracart.com/api/ for all the expansion fields available (this list below may become stale)
                /*
                Possible Order Expansions:
                affiliate           affiliate.ledger                    auto_order
                billing             channel_partner                     checkout
                coupon              customer_profile                    digital_order
                edi                 fraud_score                         gift
                gift_certificate    internal                            item
                linked_shipment     marketing                           payment
                payment.transaction quote                               salesforce
                shipping            shipping.tracking_number_details    summary
                taxes
                */
                
                // A channel partner will almost always query an order for the purpose of turning around and submitting it to a refund call.
                // As such, the expansion most likely needed is listed below.
                string expansion = "item,summary,shipping";
                
                // This order MUST be an order associated with this channel partner or you will receive a 400 Bad Request.
                string channelPartnerOrderId = "MY-CALL-CENTER-BLAH-BLAH";
                var apiResponse = channelPartnerApi.GetChannelPartnerOrderByChannelPartnerOrderId(channelPartnerOrderId, expansion);
                
                if (apiResponse.Error != null)
                {
                    Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                    Console.Error.WriteLine(apiResponse.Error.UserMessage);
                    Environment.Exit(1);
                }
                
                Order order = apiResponse.Order;
                Console.WriteLine(order);
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
 **orderId** | **string**| The channel partner order id to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See OrderApi.getOrder documentation for examples | [optional] 

### Return type

[**OrderResponse**](OrderResponse.md)

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


## GetChannelPartnerReasonCodes

> ChanelPartnerReasonCodesResponse GetChannelPartnerReasonCodes (int channelPartnerOid)

Retrieve reject and refund reason codes.

Retrieve reject and refund reason codes. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.channel_partner
{
    public class GetChannelPartnerReasonCodes
    {
        /*
         * Retrieve a list of all refund and reject reason codes configured by the merchant.  These might be required when doing a refund.
         */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create channel partner API instance using API key
                ChannelPartnerApi channelPartnerApi = new ChannelPartnerApi(Constants.ChannelPartnerApiKey);
                var apiResponse = channelPartnerApi.GetChannelPartnerReasonCodes(18413);
                
                if (apiResponse.Error != null)
                {
                    Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                    Console.Error.WriteLine(apiResponse.Error.UserMessage);
                    Environment.Exit(1);
                }
                
                var rejectReasons = apiResponse.OrderLevelRejectReasons;
                var refundReasons = apiResponse.OrderLevelRefundReasons;
                
                foreach (var reason in refundReasons)
                {
                    Console.WriteLine(reason);
                }
                
                Console.WriteLine($"Retrieved {refundReasons.Count} refund reasons");
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
 **channelPartnerOid** | **int**|  | 

### Return type

[**ChanelPartnerReasonCodesResponse**](ChanelPartnerReasonCodesResponse.md)

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


## GetChannelPartnerShipToPreference

> ChannelPartnerShipToPreferenceResponse GetChannelPartnerShipToPreference (int channelPartnerOid, int channelPartnerShipToPreferenceOid)

Retrieve the ship to preference associated with the channel partner and the specific id.

Retrieve the ship to preference associated with the channel partner and the specific id. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.channel_partner
{
    public class GetChannelPartnerShipToPreference
    {
        /*
         Retrieves a shipto preference for a channel partner.
         These preferences are used by EDI channel partners to automatically
         apply return policies and add additional free items to EDI orders based on the EDI code that is present.

         Possible Errors:
         Attempting to interact with a channel partner other than the one tied to your API Key:
            "Invalid channel_partner_oid specified.  Your REST API key may only interact with channel_partner_oid: 12345"
         Supplying a bad channel partner oid: "Invalid channel_partner_oid specified."
         Supplying a bad channel partner shipto preference oid: "Invalid channel_partner_ship_to_preference_oid specified."
        */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create channel partner API instance using API key
                ChannelPartnerApi channelPartnerApi = new ChannelPartnerApi(Constants.ChannelPartnerApiKey);
                
                int channelPartnerOid = 12345;
                int channelPartnerShiptoPreferenceOid = 67890;
                
                var apiResponse = channelPartnerApi.GetChannelPartnerShipToPreference(channelPartnerOid, channelPartnerShiptoPreferenceOid);
                
                if (apiResponse.Error != null)
                {
                    Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                    Console.Error.WriteLine(apiResponse.Error.UserMessage);
                    Environment.Exit(1);
                }
                
                var preference = apiResponse.ShipToPreference;
                Console.WriteLine(preference);
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
 **channelPartnerOid** | **int**|  | 
 **channelPartnerShipToPreferenceOid** | **int**|  | 

### Return type

[**ChannelPartnerShipToPreferenceResponse**](ChannelPartnerShipToPreferenceResponse.md)

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


## GetChannelPartnerShipToPreferences

> ChannelPartnerShipToPreferencesResponse GetChannelPartnerShipToPreferences (int channelPartnerOid)

Retrieve the ship to preferences associated with the channel partner.

Retrieve the ship to preferences associated with the channel partner. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.channel_partner
{
    public class GetChannelPartnerShipToPreferences
    {
        /*
         Retrieves all shipto preferences for a channel partner.
         These preferences are used by EDI channel partners to automatically
         apply return policies and add additional free items to EDI orders based on the EDI code that is present.

         Possible Errors:
         Attempting to interact with a channel partner other than the one tied to your API Key:
            "Invalid channel_partner_oid specified.  Your REST API key may only interact with channel_partner_oid: 12345"
         Supplying a bad channel partner oid: "Invalid channel_partner_oid specified."
        */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create channel partner API instance using API key
                ChannelPartnerApi channelPartnerApi = new ChannelPartnerApi(Constants.ChannelPartnerApiKey);
                
                int channelPartnerOid = 12345;
                var apiResponse = channelPartnerApi.GetChannelPartnerShipToPreferences(channelPartnerOid);
                
                if (apiResponse.Error != null)
                {
                    Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                    Console.Error.WriteLine(apiResponse.Error.UserMessage);
                    Environment.Exit(1);
                }
                
                var preferences = apiResponse.ShipToPreferences;
                
                foreach (var preference in preferences)
                {
                    Console.WriteLine(preference);
                }
                
                Console.WriteLine($"Retrieved {preferences.Count} ship to preferences");
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
 **channelPartnerOid** | **int**|  | 

### Return type

[**ChannelPartnerShipToPreferencesResponse**](ChannelPartnerShipToPreferencesResponse.md)

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


## GetChannelPartners

> ChannelPartnersResponse GetChannelPartners ()

Retrieve the channel partners configured on the account.

Retrieve the channel partners configured on the account. 


### Example

```csharp
using System;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.channel_partner
{
    public class GetChannelPartners
    {
        /*
            Retrieves a list of all channel partners configured for this merchant.  If the API KEY used is tied to a specific
            Channel Partner, then the results will contain only that Channel Partner.
         */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create channel partner API instance using API key
                ChannelPartnerApi channelPartnerApi = new ChannelPartnerApi(Constants.ChannelPartnerApiKey);
                var apiResponse = channelPartnerApi.GetChannelPartners();
                
                if (apiResponse.Error != null)
                {
                    Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                    Console.Error.WriteLine(apiResponse.Error.UserMessage);
                    Environment.Exit(1);
                }
                
                var channelPartners = apiResponse.ChannelPartners;
                
                foreach (var channelPartner in channelPartners)
                {
                    Console.WriteLine(channelPartner);
                }
                
                Console.WriteLine($"Retrieved {channelPartners.Count} channel partners");
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

[**ChannelPartnersResponse**](ChannelPartnersResponse.md)

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


## ImportChannelPartnerOrder

> ChannelPartnerImportResponse ImportChannelPartnerOrder (ChannelPartnerOrder channelPartnerOrder)

Insert channel partner order

Insert order from a channel partner. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.channel_partner
{
    public class ImportChannelPartnerOrder
    {
        /*
            To run channel partner examples, you will need:
            1) An API Key: https://secure.ultracart.com/merchant/configuration/apiManagementApp.do
            2) That API Key must be assigned to a channel partner: https://secure.ultracart.com/merchant/configuration/customChannelPartnerListLoad.do

            The spreadsheet import docs will serve you well here.  They describe many fields
            https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1377246/Channel+Partner+API+-+Spreadsheet+Import
        */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            var doFirstExample = false;
            try
            {
                // Create channel partner API instance using API key
                ChannelPartnerApi channelPartnerApi = new ChannelPartnerApi(Constants.ChannelPartnerApiKey);
                
                // NOTICE:
                // The real difficulty with using this API is the hosted fields requirement for credit card information.
                // You will need to incorporate UltraCart hosted fields in your Customer Service UI and capture credit card
                // information through the hosted fields and then provide the tokens here.  You CANNOT provide raw credit
                // card information via this interface.
                // The two fields in this API are hostedFieldsCardToken and hostedFieldsCvvToken
                // Within this sdk_samples github project, review the /hosted_fields/hosted_fields.html file for an example
                
                // There are TWO examples.  The first is an order that still needs the credit card charged.  This example uses
                // the hosted fields to collect payment information and pass it to UltraCart for processing.  The second example
                // already has payment processed and just passes in the authorization information.
                
                // ---------------------------------------------
                // ---------------------------------------------
                // Example 1 - Order needs payment processing
                // ---------------------------------------------
                // ---------------------------------------------
                
                ChannelPartnerOrder order = new ChannelPartnerOrder();

                if (doFirstExample)
                {

                    // order.AdvertisingSource = "Friend"; // https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1377001/Advertising+Sources
                    // order.AffiliateId = 856234; // https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1377727/Affiliates
                    // order.AffiliateSubId = 1234; // https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1376754/Allowing+Affiliates+to+use+Sub-IDs
                    // order.ArbitraryShippingHandlingTotal = 9.99;
                    // order.ArbitraryTax = 2.50;
                    // order.ArbitraryTaxRate = 7.0;
                    // order.ArbitraryTaxableSubtotal = 69.99;

                    order.AssociateWithCustomerProfileIfPresent = true;
                    order.AutoApprovePurchaseOrder = true;
                    order.BilltoAddress1 = "11460 Johns Creek Parkway";
                    order.BilltoAddress2 = "Suite 101";
                    order.BilltoCity = "Duluth";
                    order.BilltoCompany = "Widgets Inc";
                    order.BilltoCountryCode = "US";
                    order.BilltoDayPhone = "6784153823";
                    order.BilltoEveningPhone = "6784154019";
                    order.BilltoFirstName = "John";
                    order.BilltoLastName = "Smith";
                    order.BilltoPostalCode = "30097";
                    order.BilltoStateRegion = "GA";
                    order.BilltoTitle = "Sir";
                    order.CcEmail = "orders@widgets.com";
                    order.ChannelPartnerOrderId = "widget-1245-abc";
                    order.ConsiderRecurring = false;
                    order.Coupons = new List<string> { "10OFF", "BUY1GET1" };

                    // order.CreditCardAuthorizationAmount = 69.99;
                    // order.CreditCardAuthorizationDts = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssK"); // this will usually not be 'now'. it will be the actual auth date
                    // order.CreditCardAuthorizationNumber = "1234";

                    order.CreditCardExpirationMonth = 5;
                    order.CreditCardExpirationYear = 2032;
                    order.CreditCardType = "VISA"; // see the hosted fields below for the card number and cvv tokens
                    order.CustomField1 = "Whatever";
                    order.CustomField2 = "You";
                    order.CustomField3 = "Want";
                    order.CustomField4 = "Can";
                    order.CustomField5 = "Go";
                    order.CustomField6 = "In";
                    order.CustomField7 = "CustomFields";
                    order.DeliveryDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssK");
                    order.Email = "ceo@widgets.com";
                    order.Gift = false;

                    order.GiftEmail = "sally@aol.com";
                    order.GiftMessage = "Congratulations on your promotion!";

                    order.HostedFieldsCardToken = "7C97B0AAA26AB10180B4B29F00380101";
                    order.HostedFieldsCvvToken = "C684AB4336787F0180B4B51971380101";

                    // order.InsuranceApplicationId = insuranceApplicationId; // these are used by only a handful of specialized merchants
                    // order.InsuranceClaimId = insuranceClaimId; // these are used by only a handful of specialized merchants

                    order.IpAddress = "34.125.95.217";

                    // -- Items start ---
                    ChannelPartnerOrderItem item = new ChannelPartnerOrderItem();
                    // item.ArbitraryUnitCost = 9.99;
                    // item.AutoOrderLastRebillDts = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssK");
                    // item.AutoOrderSchedule = "Weekly";

                    item.MerchantItemId = "shirt";
                    item.Quantity = 1;
                    item.Upsell = false;

                    ChannelPartnerOrderItemOption itemOption1 = new ChannelPartnerOrderItemOption();
                    itemOption1.Name = "Size";
                    itemOption1.Value = "Small";

                    ChannelPartnerOrderItemOption itemOption2 = new ChannelPartnerOrderItemOption();
                    itemOption2.Name = "Color";
                    itemOption2.Value = "Orange";

                    item.Options = new List<ChannelPartnerOrderItemOption> { itemOption1, itemOption2 };

                    order.Items = new List<ChannelPartnerOrderItem> { item };
                    // -- Items End ---


                    order.LeastCostRoute = true; // Give me the lowest cost shipping
                    order.LeastCostRouteShippingMethods = new List<string>
                        { "FedEx: Ground", "UPS: Ground", "USPS: Priority" };
                    order.MailingListOptIn =
                        true; // Yes, I confirmed with the customer personally they wish to be on my mailing lists.
                    order.NoRealtimePaymentProcessing = false;
                    order.PaymentMethod = ChannelPartnerOrder.PaymentMethodEnum.CreditCard;
                    // order.PurchaseOrderNumber = "PO-12345";
                    order.RotatingTransactionGatewayCode =
                        "MyStripe"; // We wish this to be charged against our Stripe gateway
                    order.ScreenBrandingThemeCode =
                        "SF1986"; // Theme codes predated StoreFronts. Each StoreFront still has a theme code under the hood. We need that here. See this screen to find your code: https://secure.ultracart.com/merchant/configuration/customerServiceLoad.do
                    order.ShipOnDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssK");
                    order.ShipToResidential = true;
                    // order.ShippingMethod = "FedEx: Ground"; // We're using LeastCostRoute, so we do not supply this value
                    order.ShiptoAddress1 = "55 Main Street";
                    order.ShiptoAddress2 = "Suite 202";
                    order.ShiptoCity = "Duluth";
                    order.ShiptoCompany = "Widgets Inc";
                    order.ShiptoCountryCode = "US";
                    order.ShiptoDayPhone = "6785552323";
                    order.ShiptoEveningPhone = "7703334444";
                    order.ShiptoFirstName = "Sally";
                    order.ShiptoLastName = "McGonkyDee";
                    order.ShiptoPostalCode = "30097";
                    order.ShiptoStateRegion = "GA";
                    order.ShiptoTitle = "Director";
                    order.SkipPaymentProcessing = false;
                    order.SpecialInstructions =
                        "Please wrap this in bubble wrap because my FedEx delivery guy is abusive to packages";
                    order.StoreCompleted =
                        false; // this will bypass everything, including shipping. useful only for importing old orders long completed
                    order.StorefrontHostName = "store.mysite.com";
                    order.StoreIfPaymentDeclines =
                        false; // if payment fails, this can send it to Accounts Receivable. Do not want that. Fail if payment fails.
                    order.TaxCounty = "Gwinnett";
                    order.TaxExempt = false;

                    ChannelPartnerOrderTransaction orderTransaction = new ChannelPartnerOrderTransaction();
                    orderTransaction.Successful = false; // we haven't charged the card yet, so this is false.
                    orderTransaction.Details =
                        new List<ChannelPartnerOrderTransactionDetail>(); // we haven't charged the card yet, so this is empty.
                    order.Transaction = orderTransaction;
                    order.TreatWarningsAsErrors = true;

                    var apiResponse = channelPartnerApi.ImportChannelPartnerOrder(order);
                }

                // ---------------------------------------------
                // ---------------------------------------------
                // Example 2 - Order already processed
                // ---------------------------------------------
                // ---------------------------------------------
                
                ChannelPartnerOrder processedOrder = new ChannelPartnerOrder();
                
                // processedOrder.AdvertisingSource = "Friend"; // https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1377001/Advertising+Sources
                // processedOrder.AffiliateId = 856234; // https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1377727/Affiliates
                // processedOrder.AffiliateSubId = 1234; // https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1376754/Allowing+Affiliates+to+use+Sub-IDs
                // processedOrder.ArbitraryShippingHandlingTotal = 9.99;
                // processedOrder.ArbitraryTax = 2.50;
                // processedOrder.ArbitraryTaxRate = 7.0;
                // processedOrder.ArbitraryTaxableSubtotal = 69.99;
                
                processedOrder.AssociateWithCustomerProfileIfPresent = true;
                processedOrder.AutoApprovePurchaseOrder = true;
                processedOrder.BilltoAddress1 = "11460 Johns Creek Parkway";
                processedOrder.BilltoAddress2 = "Suite 101";
                processedOrder.BilltoCity = "Duluth";
                processedOrder.BilltoCompany = "Widgets Inc";
                processedOrder.BilltoCountryCode = "US";
                processedOrder.BilltoDayPhone = "6784153823";
                processedOrder.BilltoEveningPhone = "6784154019";
                processedOrder.BilltoFirstName = "John";
                processedOrder.BilltoLastName = "Smith";
                processedOrder.BilltoPostalCode = "30097";
                processedOrder.BilltoStateRegion = "GA";
                processedOrder.BilltoTitle = "Sir";
                processedOrder.CcEmail = "orders@widgets.com";
                processedOrder.ChannelPartnerOrderId = "widget-1245-abc";
                processedOrder.ConsiderRecurring = false;
                processedOrder.Coupons = new List<string> { "10OFF", "BUY1GET1" };
                
                // processedOrder.CreditCardAuthorizationAmount = 69.99;
                // processedOrder.CreditCardAuthorizationDts = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssK"); // this will usually not be 'now'. it will be the actual auth date
                // processedOrder.CreditCardAuthorizationNumber = "1234";
                
                processedOrder.CreditCardExpirationMonth = 5;
                processedOrder.CreditCardExpirationYear = 2032;
                processedOrder.CreditCardType = "VISA"; // see the hosted fields below for the card number and cvv tokens
                processedOrder.CustomField1 = "Whatever";
                processedOrder.CustomField2 = "You";
                processedOrder.CustomField3 = "Want";
                processedOrder.CustomField4 = "Can";
                processedOrder.CustomField5 = "Go";
                processedOrder.CustomField6 = "In";
                processedOrder.CustomField7 = "CustomFields";
                processedOrder.DeliveryDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssK");
                processedOrder.Email = "ceo@widgets.com";
                processedOrder.Gift = false;
                
                processedOrder.GiftEmail = "sally@aol.com";
                processedOrder.GiftMessage = "Congratulations on your promotion!";
                
                // processedOrder.InsuranceApplicationId = insuranceApplicationId; // these are used by only a handful of specialized merchants
                // processedOrder.InsuranceClaimId = insuranceClaimId; // these are used by only a handful of specialized merchants
                
                processedOrder.IpAddress = "34.125.95.217";
                
                // -- Items start ---
                ChannelPartnerOrderItem processedItem = new ChannelPartnerOrderItem();
                // processedItem.ArbitraryUnitCost = 9.99;
                // processedItem.AutoOrderLastRebillDts = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssK");
                // processedItem.AutoOrderSchedule = "Weekly";
                
                processedItem.MerchantItemId = "shirt";
                processedItem.Quantity = 1;
                processedItem.Upsell = false;
                
                ChannelPartnerOrderItemOption processedItemOption1 = new ChannelPartnerOrderItemOption();
                processedItemOption1.Name = "Size";
                processedItemOption1.Value = "Small";
                
                ChannelPartnerOrderItemOption processedItemOption2 = new ChannelPartnerOrderItemOption();
                processedItemOption2.Name = "Color";
                processedItemOption2.Value = "Orange";
                
                processedItem.Options = new List<ChannelPartnerOrderItemOption> { processedItemOption1, processedItemOption2 };
                
                processedOrder.Items = new List<ChannelPartnerOrderItem> { processedItem };
                // -- Items End ---
                
                // We don't use least cost routing here. We've already completed the order and should know what shipping method
                // the customer was charged for. So that is set in the processedOrder.ShippingMethod property.
                // processedOrder.LeastCostRoute = true; // Give me the lowest cost shipping
                // processedOrder.LeastCostRouteShippingMethods = new List<string> { "FedEx: Ground", "UPS: Ground", "USPS: Priority" };
                processedOrder.MailingListOptIn = true; // Yes, I confirmed with the customer personally they wish to be on my mailing lists.
                processedOrder.NoRealtimePaymentProcessing = true; // nothing to charge, payment was already collected
                processedOrder.PaymentMethod = ChannelPartnerOrder.PaymentMethodEnum.CreditCard;
                // processedOrder.PurchaseOrderNumber = "PO-12345";
                processedOrder.RotatingTransactionGatewayCode = "MyStripe"; // We wish this to be charged against our Stripe gateway
                processedOrder.ScreenBrandingThemeCode = "SF1986"; // Theme codes predated StoreFronts. Each StoreFront still has a theme code under the hood. We need that here. See this screen to find your code: https://secure.ultracart.com/merchant/configuration/customerServiceLoad.do
                processedOrder.ShipOnDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssK");
                processedOrder.ShipToResidential = true;
                processedOrder.ShippingMethod = "FedEx: Ground";
                processedOrder.ShiptoAddress1 = "55 Main Street";
                processedOrder.ShiptoAddress2 = "Suite 202";
                processedOrder.ShiptoCity = "Duluth";
                processedOrder.ShiptoCompany = "Widgets Inc";
                processedOrder.ShiptoCountryCode = "US";
                processedOrder.ShiptoDayPhone = "6785552323";
                processedOrder.ShiptoEveningPhone = "7703334444";
                processedOrder.ShiptoFirstName = "Sally";
                processedOrder.ShiptoLastName = "McGonkyDee";
                processedOrder.ShiptoPostalCode = "30097";
                processedOrder.ShiptoStateRegion = "GA";
                processedOrder.ShiptoTitle = "Director";
                processedOrder.SkipPaymentProcessing = true; // bypass payment
                processedOrder.SpecialInstructions = "Please wrap this in bubble wrap because my FedEx delivery guy is abusive to packages";
                processedOrder.StoreCompleted = true; // this is an old order or an order handled completely outside UltraCart, so do not do anything to it. Just store it.
                processedOrder.StorefrontHostName = "store.mysite.com";
                processedOrder.StoreIfPaymentDeclines = false; // if payment fails, this can send it to Accounts Receivable. Do not want that. Fail if payment fails.
                processedOrder.TaxCounty = "Gwinnett";
                processedOrder.TaxExempt = false;
                
                ChannelPartnerOrderTransaction processedOrderTransaction = new ChannelPartnerOrderTransaction();
                processedOrderTransaction.Successful = true; // transaction was successful
                
                ChannelPartnerOrderTransactionDetail td1 = new ChannelPartnerOrderTransactionDetail(); // 'td' is short for transaction detail
                td1.Name = "AVS Code";
                td1.Value = "X";
                
                ChannelPartnerOrderTransactionDetail td2 = new ChannelPartnerOrderTransactionDetail();
                td2.Name = "Authorization Code";
                td2.Value = "123456";
                
                ChannelPartnerOrderTransactionDetail td3 = new ChannelPartnerOrderTransactionDetail();
                td3.Name = "CVV Code";
                td3.Value = "M";
                
                ChannelPartnerOrderTransactionDetail td4 = new ChannelPartnerOrderTransactionDetail();
                td4.Name = "Response Code";
                td4.Value = "Authorized";
                
                ChannelPartnerOrderTransactionDetail td5 = new ChannelPartnerOrderTransactionDetail();
                td5.Name = "Reason Code";
                td5.Value = "1";
                
                ChannelPartnerOrderTransactionDetail td6 = new ChannelPartnerOrderTransactionDetail();
                td6.Name = "Response Subcode";
                td6.Value = "1";
                
                ChannelPartnerOrderTransactionDetail td7 = new ChannelPartnerOrderTransactionDetail();
                td7.Name = "Transaction ID";
                td7.Value = "1234567890";
                
                processedOrderTransaction.Details = new List<ChannelPartnerOrderTransactionDetail> { td1, td2, td3, td4, td5, td6, td7 };
                processedOrder.Transaction = processedOrderTransaction;
                processedOrder.TreatWarningsAsErrors = true;
                
                var processedApiResponse = channelPartnerApi.ImportChannelPartnerOrder(processedOrder);
                
                Console.WriteLine("Orders imported successfully");
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
 **channelPartnerOrder** | [**ChannelPartnerOrder**](ChannelPartnerOrder.md)| Order to insert | 

### Return type

[**ChannelPartnerImportResponse**](ChannelPartnerImportResponse.md)

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


## InsertChannelPartnerShipToPreference

> ChannelPartnerShipToPreferenceResponse InsertChannelPartnerShipToPreference (int channelPartnerOid, ChannelPartnerShipToPreference shipToPreference)

Insert a ship to preference record for the channel partner.

Insert a ship to preference record for the channel partner. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Reflection;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.channel_partner
{
    public class InsertChannelPartnerShipToPreference
    {
        /*
         Inserts a channel partner shipto preference for a channel partner.
         These preferences are used by EDI channel partners to automatically
         apply return policies and add additional free items to EDI orders based on the EDI code that is present.

         Possible Errors:
         Attempting to interact with a channel partner other than the one tied to your API Key:
            "Invalid channel_partner_oid specified.  Your REST API key may only interact with channel_partner_oid: 12345"
         Supplying a bad channel partner oid: "Invalid channel_partner_oid specified."
        */
        public static void Execute()
        {
            Console.WriteLine("--- " + MethodBase.GetCurrentMethod()?.DeclaringType?.Name + " ---");
            
            try
            {
                // Create channel partner API instance using API key
                ChannelPartnerApi channelPartnerApi = new ChannelPartnerApi(Constants.ChannelPartnerApiKey);
                
                int channelPartnerOid = 12345;
                
                ChannelPartnerShipToPreference preference = new ChannelPartnerShipToPreference();
                preference.ChannelPartnerOid = channelPartnerOid;
                preference.ShipToEdiCode = "EDI_CODE_HERE";
                preference.ReturnPolicy = "This is some return policy text that will be printed on the packing slip.";
                preference.AdditionalKitComponentItemIds = new List<string> { "ITEM_ID1", "ITEM_ID2", "ITEM_ID3" };
                preference.Description = "This is a merchant friendly description to help me remember what the above setting are.";
                
                var apiResponse = channelPartnerApi.InsertChannelPartnerShipToPreference(channelPartnerOid, preference);
                
                if (apiResponse.Error != null)
                {
                    Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                    Console.Error.WriteLine(apiResponse.Error.UserMessage);
                    Environment.Exit(1);
                }
                
                var insertedPreference = apiResponse.ShipToPreference;
                
                // This should equal what you submitted.
                Console.WriteLine(insertedPreference);
                Console.WriteLine("Ship to preference inserted successfully");
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
 **channelPartnerOid** | **int**|  | 
 **shipToPreference** | [**ChannelPartnerShipToPreference**](ChannelPartnerShipToPreference.md)| Ship to preference to create | 

### Return type

[**ChannelPartnerShipToPreferenceResponse**](ChannelPartnerShipToPreferenceResponse.md)

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


## RefundChannelPartnerOrder

> OrderResponse RefundChannelPartnerOrder (string orderId, Order order, bool? rejectAfterRefund = null, bool? skipCustomerNotification = null, bool? autoOrderCancel = null, bool? manualRefund = null, bool? reverseAffiliateTransactions = null, bool? issueStoreCredit = null, string autoOrderCancelReason = null, string expand = null)

Refund a channel partner order

Perform a refund operation on a channel partner order and then update the order if successful.  All of the object properties ending in _refunded should be the TOTAL amount that should end up being refunded.  UltraCart will calculate the actual amount to refund based upon the prior refunds. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using Newtonsoft.Json;

namespace SdkSample.channel_partner
{
    public class RefundChannelPartnerOrder
    {
        /// <summary>
        /// IMPORTANT: Do NOT construct the refunded order. This method does a refund but also update the entire object, so start with an order query.
        /// ALWAYS start with an order retrieved from the system.
        /// 1. Call getChannelPartnerOrder or getChannelPartnerOrderByChannelPartnerOrderId to retrieve the order being refunded
        /// 2. For a full refund, reverse the following:
        ///    A. Set the refunded qty and refunded amount for each item.
        ///    B. Set the refunded tax (if any)
        ///    C. Set the refunded shipping
        /// NOTE: refund amounts are positive numbers. If any item total cost is $20.00, a full refunded amount would also be positive $20.00
        /// See the ChannelPartnerApi.getChannelPartnerOrder() sample for details on that method.
        /// </summary>
        public static void Execute()
        {
            // Create channel partner API instance
            ChannelPartnerApi channelPartnerApi = new ChannelPartnerApi(Constants.ChannelPartnerApiKey);
            
            // For a comment on this expansion, see getChannelPartnerOrder sample.
            string expansion = "item,summary,shipping";
            
            // This order MUST be an order associated with this channel partner, or you will receive a 400 Bad Request.
            string orderId = "DEMO-0009106820";
            OrderResponse apiResponse = channelPartnerApi.GetChannelPartnerOrder(orderId, expansion);

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                Environment.Exit(1);
            }

            Order order = apiResponse.Order;

            // RefundReason may be required, but is optional by default.
            // RefundReason may be a set list, or may be freeform. This is configured on the backend (secure.ultracart.com)
            // by Navigating to Home -> Configuration -> Order Management -> Refund/Reject Reasons
            // Warning: If this is a 2nd refund after an initial partial refund, be sure you account for the units and amount already refunded.
            order.RefundReason = "Damage Product";
            order.Summary.TaxRefunded = order.Summary.Tax;
            order.Summary.ShippingHandlingRefunded = order.Summary.ShippingHandlingTotal;
            
            foreach (OrderItem item in order.Items)
            {
                // Item level refund reasons are optional, but may be required. See the above breadcrumb trail for refund reason config.
                item.RefundReason = "DifferentItem";
                item.QuantityRefunded = item.Quantity;
                item.TotalRefunded = item.TotalCostWithDiscount;
            }

            bool rejectAfterRefund = false;
            bool skipCustomerNotifications = true;
            bool autoOrderCancel = false; // If this was an auto order, and they wanted to cancel it, set this flag to true.
            // Set manualRefund to true if the actual refund happened outside the system, and you just want a record of it.
            // If UltraCart did not process this refund, manualRefund should be true.
            bool manualRefund = false;
            bool reverseAffiliateTransactions = true; // For a full refund, the affiliate should not get credit, or should they?
            bool issueStoreCredit = false; // If true, the customer would receive store credit instead of a return on their credit card.
            string autoOrderCancelReason = null;

            apiResponse = channelPartnerApi.RefundChannelPartnerOrder(
                orderId, 
                order, 
                rejectAfterRefund,
                skipCustomerNotifications, 
                autoOrderCancel, 
                manualRefund, 
                reverseAffiliateTransactions,
                issueStoreCredit, 
                autoOrderCancelReason, 
                expansion);

            Error error = apiResponse.Error;
            Order updatedOrder = apiResponse.Order;
            // Verify the updated order contains all the desired refunds. Verify that refunded total is equal to total.

            // Note: The error 'Request to refund an invalid amount.' means you requested a total refund amount less than or equal to zero.
            Console.WriteLine("Error:");
            Console.WriteLine(error != null ? JsonConvert.SerializeObject(error, Formatting.Indented) : "null");
            Console.WriteLine("\n\n--------------------\n\n");
            Console.WriteLine("Updated Order:");
            Console.WriteLine(updatedOrder != null ? JsonConvert.SerializeObject(updatedOrder, Formatting.Indented) : "null");
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to refund. | 
 **order** | [**Order**](Order.md)| Order to refund | 
 **rejectAfterRefund** | **bool?**| Reject order after refund | [optional] [default to false]
 **skipCustomerNotification** | **bool?**| Skip customer email notification | [optional] [default to false]
 **autoOrderCancel** | **bool?**| Cancel associated auto orders | [optional] [default to false]
 **manualRefund** | **bool?**| Consider a manual refund done externally | [optional] [default to false]
 **reverseAffiliateTransactions** | **bool?**| Reverse affiliate transactions | [optional] [default to true]
 **issueStoreCredit** | **bool?**| Issue a store credit instead of refunding the original payment method, loyalty must be configured on merchant account | [optional] [default to false]
 **autoOrderCancelReason** | **string**| Reason for auto orders cancellation | [optional] 
 **expand** | **string**| The object expansion to perform on the result.  See OrderApi.refundOrder documentation for examples | [optional] 

### Return type

[**OrderResponse**](OrderResponse.md)

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


## UpdateChannelPartnerShipToPreference

> ChannelPartnerShipToPreferenceResponse UpdateChannelPartnerShipToPreference (int channelPartnerOid, int channelPartnerShipToPreferenceOid, ChannelPartnerShipToPreference shipToPreference)

Update a ship to preference record for the channel partner.

Update a ship to preference record for the channel partner. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using Newtonsoft.Json;

namespace SdkSample.channel_partner
{
    public class UpdateChannelPartnerShipToPreference
    {
        /// <summary>
        /// Updates a channel partner shipto preference for a channel partner.
        /// These preferences are used by EDI channel partners to automatically
        /// apply return policies and add additional free items to EDI orders based on the EDI code that is present.
        /// 
        /// Possible Errors:
        /// Attempting to interact with a channel partner other than the one tied to your API Key:
        ///    "Invalid channel_partner_oid specified.  Your REST API key may only interact with channel_partner_oid: 12345"
        /// Supplying a bad channel partner oid: "Invalid channel_partner_oid specified."
        /// </summary>
        public static void Execute()
        {
            ChannelPartnerApi channelPartnerApi = new ChannelPartnerApi(Constants.ChannelPartnerApiKey);
            int channelPartnerOid = 12345;
            int channelPartnerShipToPreferenceOid = 67890;

            ChannelPartnerShipToPreferenceResponse apiResponse = channelPartnerApi.GetChannelPartnerShipToPreference(
                channelPartnerOid, 
                channelPartnerShipToPreferenceOid);

            ChannelPartnerShipToPreference preference = apiResponse.ShipToPreference;
            
            // Update some fields.
            preference.ShipToEdiCode = "EDI_CODE_HERE";
            preference.ReturnPolicy = "This is some return policy text that will be printed on the packing slip.";
            preference.AdditionalKitComponentItemIds = new List<string> { "ITEM_ID1", "ITEM_ID2", "ITEM_ID3" };
            preference.Description = "This is a merchant friendly description to help me remember what the above setting are.";

            apiResponse = channelPartnerApi.UpdateChannelPartnerShipToPreference(
                channelPartnerOid, 
                channelPartnerShipToPreferenceOid, 
                preference);

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                Environment.Exit(1);
            }

            ChannelPartnerShipToPreference updatedPreference = apiResponse.ShipToPreference;

            // This should equal what you submitted.
            Console.WriteLine(JsonConvert.SerializeObject(updatedPreference, Formatting.Indented));
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelPartnerOid** | **int**|  | 
 **channelPartnerShipToPreferenceOid** | **int**|  | 
 **shipToPreference** | [**ChannelPartnerShipToPreference**](ChannelPartnerShipToPreference.md)| Ship to preference to create | 

### Return type

[**ChannelPartnerShipToPreferenceResponse**](ChannelPartnerShipToPreferenceResponse.md)

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

