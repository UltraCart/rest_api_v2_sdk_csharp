# com.ultracart.admin.v2.Api.OrderApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdjustOrderTotal**](OrderApi.md#adjustordertotal) | **POST** /order/orders/{order_id}/adjust_order_total/{desired_total} | Adjusts an order total
[**AssignToAffiliate**](OrderApi.md#assigntoaffiliate) | **POST** /order/orders/{order_id}/assignToAffiliate | Assigns an order to an affiliate
[**BlockRefundOnOrder**](OrderApi.md#blockrefundonorder) | **GET** /order/orders/{order_id}/refund_block | Set a refund block on an order
[**CancelOrder**](OrderApi.md#cancelorder) | **POST** /order/orders/{order_id}/cancel | Cancel an order
[**DeleteOrder**](OrderApi.md#deleteorder) | **DELETE** /order/orders/{order_id} | Delete an order
[**DuplicateOrder**](OrderApi.md#duplicateorder) | **POST** /order/orders/{order_id}/duplicate | Duplicate an order
[**Format**](OrderApi.md#format) | **POST** /order/orders/{order_id}/format | Format order
[**GenerateInvoice**](OrderApi.md#generateinvoice) | **GET** /order/orders/{order_id}/invoice | Generate an invoice for this order.
[**GenerateOrderToken**](OrderApi.md#generateordertoken) | **GET** /order/orders/token/{order_id} | Generate an order token for a given order id
[**GeneratePackingSlipAllDC**](OrderApi.md#generatepackingslipalldc) | **GET** /order/orders/{order_id}/packing_slip | Generate a packing slip for this order across all distribution centers.
[**GeneratePackingSlipSpecificDC**](OrderApi.md#generatepackingslipspecificdc) | **GET** /order/orders/{order_id}/packing_slip/{distribution_center_code} | Generate a packing slip for this order for the given distribution center.
[**GetAccountsReceivableRetryConfig**](OrderApi.md#getaccountsreceivableretryconfig) | **GET** /order/accountsReceivableRetryConfig | Retrieve A/R Retry Configuration
[**GetAccountsReceivableRetryStats**](OrderApi.md#getaccountsreceivableretrystats) | **GET** /order/accountsReceivableRetryConfig/stats | Retrieve A/R Retry Statistics
[**GetOrder**](OrderApi.md#getorder) | **GET** /order/orders/{order_id} | Retrieve an order
[**GetOrderByToken**](OrderApi.md#getorderbytoken) | **POST** /order/orders/token | Retrieve an order using a token
[**GetOrderEdiDocuments**](OrderApi.md#getorderedidocuments) | **GET** /order/orders/{order_id}/edi | Retrieve EDI documents associated with this order.
[**GetOrders**](OrderApi.md#getorders) | **GET** /order/orders | Retrieve orders
[**GetOrdersBatch**](OrderApi.md#getordersbatch) | **POST** /order/orders/batch | Retrieve order batch
[**GetOrdersByQuery**](OrderApi.md#getordersbyquery) | **POST** /order/orders/query | Retrieve orders by query
[**InsertOrder**](OrderApi.md#insertorder) | **POST** /order/orders | Insert an order
[**IsRefundableOrder**](OrderApi.md#isrefundableorder) | **GET** /order/orders/{order_id}/refundable | Determine if an order can be refunded
[**ProcessPayment**](OrderApi.md#processpayment) | **POST** /order/orders/{order_id}/process_payment | Process payment
[**RefundOrder**](OrderApi.md#refundorder) | **PUT** /order/orders/{order_id}/refund | Refund an order
[**ReplaceOrderItemMerchantItemId**](OrderApi.md#replaceorderitemmerchantitemid) | **PUT** /order/orders/{order_id}/replace_item_id | Replaces an order item id
[**Replacement**](OrderApi.md#replacement) | **POST** /order/orders/{order_id}/replacement | Replacement order
[**ResendReceipt**](OrderApi.md#resendreceipt) | **POST** /order/orders/{order_id}/resend_receipt | Resend receipt
[**ResendShipmentConfirmation**](OrderApi.md#resendshipmentconfirmation) | **POST** /order/orders/{order_id}/resend_shipment_confirmation | Resend shipment confirmation
[**UnblockRefundOnOrder**](OrderApi.md#unblockrefundonorder) | **GET** /order/orders/{order_id}/refund_unblock | Remove a refund block on an order
[**UpdateAccountsReceivableRetryConfig**](OrderApi.md#updateaccountsreceivableretryconfig) | **POST** /order/accountsReceivableRetryConfig | Update A/R Retry Configuration
[**UpdateOrder**](OrderApi.md#updateorder) | **PUT** /order/orders/{order_id} | Update an order
[**ValidateOrder**](OrderApi.md#validateorder) | **POST** /order/validate | Validate



## AdjustOrderTotal

> BaseResponse AdjustOrderTotal (string orderId, string desiredTotal)

Adjusts an order total

Adjusts an order total.  Adjusts individual items appropriately and considers taxes.  Desired total should be provided in the same currency as the order and must be less than the current total and greater than zero.  This call will change the order total.  It returns true if the desired total is achieved.  If the goal seeking algorithm falls short (usually by pennies), this method returns back false.  View the merchant notes for the order for further details. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.order
{
    public class AdjustOrderTotal
    {
        /**
         * OrderApi.adjustOrderTotal() takes a desired order total and performs goal-seeking to adjust all items and taxes
         * appropriately.  This method was created for merchants dealing with Medicare and Medicaid.  When selling their
         * medical devices, they would often run into limits approved by Medicare.  As such, they needed to adjust the
         * order total to match the approved amount.  This is a convenience method to adjust individual items and their
         * taxes to match the desired total.
         */
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            string orderId = "DEMO-0009104390";
            string desiredTotal = "21.99";
            BaseResponse apiResponse = orderApi.AdjustOrderTotal(orderId, desiredTotal);

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                Console.WriteLine("Order could not be adjusted. See error log.");
                return;
            }

            if (apiResponse.Success)
            {
                Console.WriteLine("Order was adjusted successfully. Use GetOrder() to retrieve the order if needed.");
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to cancel. | 
 **desiredTotal** | **string**| The desired total with no formatting. example 123.45 | 

### Return type

[**BaseResponse**](BaseResponse.md)

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


## AssignToAffiliate

> OrderResponse AssignToAffiliate (string orderId, OrderAssignToAffiliateRequest assignToAffiliateRequest, string expand = null)

Assigns an order to an affiliate

Assigns an order to an affiliate. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to assign to the affiliate. | 
 **assignToAffiliateRequest** | [**OrderAssignToAffiliateRequest**](OrderAssignToAffiliateRequest.md)| Assign to affiliate request | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**OrderResponse**](OrderResponse.md)

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


## BlockRefundOnOrder

> void BlockRefundOnOrder (string orderId, string blockReason = null)

Set a refund block on an order

Sets a refund block on an order to prevent a user from performing a refund.  Commonly used when a chargeback has been received. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;

namespace SdkSample.order
{
    public class BlockRefundOnOrder
    {
        /**
         * blockRefundOnOrder sets an order property that is considered when a refund request is made.
         * If the property is present, the refund is denied.  Being an order property allows for querying
         * upon it within BigQuery for audit purposes.
         */
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            string orderId = "DEMO-0009105222";
            orderApi.BlockRefundOnOrder(orderId, "Chargeback");
            Console.WriteLine("Method executed successfully.  Returns back 204 No Content.");

        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to block a refund on. | 
 **blockReason** | **string**| Block reason code (optional) | [optional] 

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


## CancelOrder

> BaseResponse CancelOrder (string orderId, bool? lockSelfShipOrders = null, bool? skipRefundAndHold = null)

Cancel an order

Cancel an order on the UltraCart account.  If the success flag is false, then consult the error message for why it failed. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.order
{
    public class CancelOrder
    {
        /**
         * OrderApi.CancelOrder() will do just that.  It will cancel an order by rejecting it.
         * However, the following restrictions apply:
         * 1) If the order is already completed, this call will fail.
         * 2) If the order has already been rejected, this call will fail.
         * 3) If the order has already been transmitted to a fulfillment center, this call will fail.
         * 4) If the order is queued for transmission to a distribution center, this call will fail.
         */
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            string orderId = "DEMO-0009104390";
            BaseResponse apiResponse = orderApi.CancelOrder(orderId);

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                Console.WriteLine("Order could not be canceled. See error log.");
                return;
            }

            if (apiResponse.Success)
            {
                Console.WriteLine("Order was canceled successfully.");
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to cancel. | 
 **lockSelfShipOrders** | **bool?**| Flag to prevent a order shipping during a refund process | [optional] 
 **skipRefundAndHold** | **bool?**| Skip refund and move order to Held Orders department | [optional] 

### Return type

[**BaseResponse**](BaseResponse.md)

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


## DeleteOrder

> void DeleteOrder (string orderId)

Delete an order

Delete an order on the UltraCart account. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.order
{
    public class DeleteOrder
    {
        /**
         * OrderApi.DeleteOrder() will do just that.  It will delete an order.
         * You might find it more useful to reject an order rather than delete it in order to leave an audit trail.
         * However, deleting test orders will be useful to keep your order history tidy.  Still, any order
         * may be deleted.
         */
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            string orderId = "DEMO-0008104390";
            orderApi.DeleteOrder(orderId);
            Console.WriteLine("Order was deleted successfully.");
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to delete. | 

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


## DuplicateOrder

> OrderResponse DuplicateOrder (string orderId, string expand = null)

Duplicate an order

Perform a duplicate of the specified order_id and return a new order located in Accounts Receivable. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.order
{
    public class DuplicateOrder
    {
        /// <summary>
        /// OrderApi.DuplicateOrder() does not accomplish much on its own. The use-case for this method is to
        /// duplicate a customer's order and then charge them for it. DuplicateOrder() does not charge the customer again.
        ///
        /// These are the steps for cloning an existing order and charging the customer for it.
        /// 1. DuplicateOrder
        /// 2. UpdateOrder (if you wish to change any part of it)
        /// 3. ProcessPayment to charge the customer.
        ///
        /// As a reminder, if you wish to create a new order from scratch, use the CheckoutApi or ChannelPartnerApi.
        /// The OrderApi is for managing existing orders.
        /// </summary>
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            // For this example, we're going to change the items after we duplicate the order, so
            // the only expansion properties we need are the items.
            // See: https://www.ultracart.com/api/ for a list of all expansions.
            string expansion = "items";

            // Step 1. Duplicate the order
            string orderIdToDuplicate = "DEMO-0009104436";
            OrderResponse apiResponse = orderApi.DuplicateOrder(orderIdToDuplicate, expansion);
            Order newOrder = apiResponse.Order;

            // Step 2. Update the items. I will create a new items array and assign it to the order to remove the old ones completely.
            OrderItem[] items = new OrderItem[1];
            OrderItem item = new OrderItem();
            item.MerchantItemId = "simple_teapot";
            item.Quantity = 1;
            item.Description = "A lovely teapot";
            item.DistributionCenterCode = "DFLT"; // where is this item shipping out of?

            Currency cost = new Currency();
            cost.CurrencyCode = "USD";
            cost.Value = 9.99m;
            item.Cost = cost;

            Weight weight = new Weight();
            weight.Uom = Weight.UomEnum.OZ;
            weight.Value = 6;
            item.Weight = weight;
            
            newOrder.Items = new List<OrderItem>{item};
            OrderResponse updateResponse = orderApi.UpdateOrder(newOrder.OrderId, newOrder, expansion);

            Order updatedOrder = updateResponse.Order;

            // Step 3. process the payment.
            // the request object below takes two optional arguments.
            // The first is an amount if you wish to bill for an amount different from the order.
            // We do not bill differently in this example.
            // The second is card_verification_number_token, which is a token you can create by using our hosted fields to
            // upload a CVV value. This will create a token you may use here. However, most merchants using the duplicate
            // order method will be setting up an auto order for a customer. Those will not make use of the CVV, so we're
            // not including it here. That is why the request object below is does not have any values set.
            // For more info on hosted fields:
            // See: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1377775/UltraCart+Hosted+Credit+Card+Fields
            // See: https://github.com/UltraCart/sdk_samples/blob/master/hosted_fields/hosted_fields.html

            OrderProcessPaymentRequest processPaymentRequest = new OrderProcessPaymentRequest();
            OrderProcessPaymentResponse paymentResponse = orderApi.ProcessPayment(newOrder.OrderId, processPaymentRequest);
            OrderPaymentTransaction transactionDetails = paymentResponse.PaymentTransaction; // do whatever you wish with this.

            Console.WriteLine("New Order (after updated items):");
            Console.WriteLine(updatedOrder);
            Console.WriteLine("Payment Response:");
            Console.WriteLine(paymentResponse);
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to duplicate. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

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


## Format

> OrderFormatResponse Format (string orderId, OrderFormat formatOptions)

Format order

Format the order for display at text or html 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.order
{
    public class Format
    {
        public static void Execute()
        {
            /*
             * format() returns back a text-formatted or html block for displaying an order. It is similar to what you would
             * see on a receipt page.
             */

            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            OrderFormat formatOptions = new OrderFormat();
            formatOptions.Context = "receipt"; // unknown,receipt,shipment,refund,quote-request,quote
            formatOptions.Format = OrderFormat.FormatEnum.Table; // text,div,table,email
            formatOptions.ShowContactInfo = false;
            formatOptions.ShowPaymentInfo = false; // might not want to show this to just anyone.
            formatOptions.ShowMerchantNotes = false; // be careful showing these
            formatOptions.EmailAsLink = true; // makes the email addresses web links
            // if you only wish to show the items for a particular distribution center,
            // this might be useful if you have Context='shipment' and you're displaying this order to a fulfillment center, etc
            // formatOptions.FilterDistributionCenterOid = 1234321;
            formatOptions.LinkFileAttachments = true;
            formatOptions.ShowInternalInformation = true; // consider this carefully.
            formatOptions.ShowNonSensitivePaymentInfo = true; // what the customer usually sees
            formatOptions.ShowInMerchantCurrency = true;
            formatOptions.HideBillToAddress = false;
            // formatOptions.FilterToItemsInContainerOid = 123454321; // you probably won't need this.
            // when an order displays on the secure.ultracart.com site, we link the email to our order search so you can quickly
            // search for all orders for that email. I doubt you would have use for that. But maybe.
            formatOptions.DontLinkEmailToSearch = true;
            formatOptions.Translate = false; // if true, shows in customer's native language

            string orderId = "DEMO-0009104390";

            OrderFormatResponse apiResponse = orderApi.Format(orderId, formatOptions);
            
            string formattedResult = apiResponse.FormattedResult;
            Console.WriteLine("<html lang=\"en\">");
            Console.WriteLine("<head>");
            // you won't have css links for format=table
            foreach (string link in apiResponse.CssLinks)
            {
                Console.WriteLine("<style type=\"text/css\">" + link + "</style>");
            }
            Console.WriteLine("</head><body>");
            Console.WriteLine(formattedResult);
            Console.WriteLine("</body></html>");
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to format | 
 **formatOptions** | [**OrderFormat**](OrderFormat.md)| Format options | 

### Return type

[**OrderFormatResponse**](OrderFormatResponse.md)

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


## GenerateInvoice

> OrderInvoiceResponse GenerateInvoice (string orderId)

Generate an invoice for this order.

The invoice PDF that is returned is base 64 encoded 


### Example

```csharp
using System;
using System.IO;
using System.Net;
using System.Text;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.order
{
    public class GenerateInvoice
    {
        public static void Execute()
        {
            /*
                generateInvoice returns back a base64 encoded byte array of the given order's Invoice in PDF format.
            */

            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            string orderId = "DEMO-0009104976";
            OrderInvoiceResponse apiResponse = orderApi.GenerateInvoice(orderId);

            // the invoice will return as a base64 encoded
            // unpack, save off, email, whatever.
            string base64Pdf = apiResponse.PdfBase64;

            byte[] decodedPdf = Convert.FromBase64String(base64Pdf);
            File.WriteAllBytes("invoice.pdf", decodedPdf);

            // If this is running as a web application, you could return the PDF to the browser
            // using something like this (this is ASP.NET-specific code):
            /*
            HttpContext.Current.Response.ContentType = "application/pdf";
            HttpContext.Current.Response.AddHeader("Content-Disposition", "inline; filename=\"invoice.pdf\"");
            HttpContext.Current.Response.AddHeader("Cache-Control", "public, must-revalidate, max-age=0");
            HttpContext.Current.Response.AddHeader("Pragma", "public");
            HttpContext.Current.Response.AddHeader("Content-Length", decodedPdf.Length.ToString());
            HttpContext.Current.Response.BinaryWrite(decodedPdf);
            HttpContext.Current.Response.End();
            */

            Console.WriteLine("Invoice PDF saved to invoice.pdf");
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| Order ID | 

### Return type

[**OrderInvoiceResponse**](OrderInvoiceResponse.md)

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


## GenerateOrderToken

> OrderTokenResponse GenerateOrderToken (string orderId)

Generate an order token for a given order id

Retrieves a single order token for a given order id.  The token can be used with the getOrderByToken API. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.order
{
    public class GenerateOrderToken
    {
        public static void Execute()
        {
            /*
             * This method generates a unique encrypted key for an Order.  This is useful if you wish to provide links for
             * customer orders without allowing someone to easily cycle through orders.  By requiring order tokens, you
             * control which orders are viewable with a public hyperlink.
             *
             * This method works in tandem with OrderApi.getOrderByToken()
             */

            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            string orderId = "DEMO-0009104436";
            OrderTokenResponse orderTokenResponse = orderApi.GenerateOrderToken(orderId);
            string orderToken = orderTokenResponse.OrderToken;

            Console.WriteLine($"Order Token is: {orderToken}");

            /*
             * The token format will look something like this:
             * DEMO:UJZOGiIRLqgE3a10yp5wmEozLPNsGrDHNPiHfxsi0iAEcxgo9H74J/l6SR3X8g==
             */
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to generate a token for. | 

### Return type

[**OrderTokenResponse**](OrderTokenResponse.md)

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


## GeneratePackingSlipAllDC

> OrderPackingSlipResponse GeneratePackingSlipAllDC (string orderId)

Generate a packing slip for this order across all distribution centers.

The packing slip PDF that is returned is base 64 encoded 


### Example

```csharp
using System;
using System.IO;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.order
{
    public class GeneratePackingSlipAllDC
    {
        public static void Execute()
        {
            /*
             * OrderApi.generatePackingSlipAllDC() is a method that might be used by a fulfillment center or distribution
             * center to generate a packing slip to include with a shipment.  This method will return a packing slip for
             * an order for all distribution centers involved.
             *
             */

            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            string orderId = "DEMO-0009104390";

            OrderPackingSlipResponse apiResponse = orderApi.GeneratePackingSlipAllDC(orderId);

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                Environment.Exit(1);
            }

            // the packing slip will return as a base64 encoded
            // unpack, save off, email, whatever.
            string base64PackingSlip = apiResponse.PdfBase64;

            Console.WriteLine(base64PackingSlip);
            
            // Decode Base64 string into a byte array
            byte[] pdfBytes = Convert.FromBase64String(base64PackingSlip);

            // Save the byte array to a PDF file
            File.WriteAllBytes("packing_slip.pdf", pdfBytes);

            Console.WriteLine("PDF file saved successfully as 'packing_slip.pdf'");
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| Order ID | 

### Return type

[**OrderPackingSlipResponse**](OrderPackingSlipResponse.md)

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


## GeneratePackingSlipSpecificDC

> OrderPackingSlipResponse GeneratePackingSlipSpecificDC (string distributionCenterCode, string orderId)

Generate a packing slip for this order for the given distribution center.

The packing slip PDF that is returned is base 64 encoded 


### Example

```csharp
using System;
using System.IO;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.order
{
    public class GeneratePackingSlipSpecificDC
    {
        public static void Execute()
        {
            /*
             * OrderApi.generatePackingSlipSpecificDC() is a method that might be used by a fulfillment center or distribution
             * center to generate a packing slip to include with a shipment.  As such, this method allows for a packing slip
             * for a specific distribution center (DC) in the case that an order has multiple shipments from multiple DC.
             *
             * You must know the DC, which should not be a problem for any custom shipping application.
             * See: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1377114/Distribution+Center
             */

            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            string orderId = "DEMO-0009104390";
            string dc = "DFLT";

            OrderPackingSlipResponse apiResponse = orderApi.GeneratePackingSlipSpecificDC(dc, orderId);

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                Environment.Exit(1);
            }

            // the packing slip will return as a base64 encoded
            // unpack, save off, email, whatever.
            string base64PackingSlip = apiResponse.PdfBase64;


            Console.WriteLine(base64PackingSlip);
            
            // Decode Base64 string into a byte array
            byte[] pdfBytes = Convert.FromBase64String(base64PackingSlip);

            // Save the byte array to a PDF file
            File.WriteAllBytes("packing_slip.pdf", pdfBytes);

            Console.WriteLine("PDF file saved successfully as 'packing_slip.pdf'");
            

        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **distributionCenterCode** | **string**| Distribution center code | 
 **orderId** | **string**| Order ID | 

### Return type

[**OrderPackingSlipResponse**](OrderPackingSlipResponse.md)

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


## GetAccountsReceivableRetryConfig

> AccountsReceivableRetryConfigResponse GetAccountsReceivableRetryConfig ()

Retrieve A/R Retry Configuration

Retrieve A/R Retry Configuration. This is primarily an internal API call.  It is doubtful you would ever need to use it. 


### Example

```csharp
// This is primarily an internal API call.  It is doubtful you would ever need to use it.
// We do not provide an example for this call.
```


### Parameters

This endpoint does not need any parameter.

### Return type

[**AccountsReceivableRetryConfigResponse**](AccountsReceivableRetryConfigResponse.md)

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


## GetAccountsReceivableRetryStats

> AccountsReceivableRetryStatsResponse GetAccountsReceivableRetryStats (string from = null, string to = null)

Retrieve A/R Retry Statistics

Retrieve A/R Retry Statistics. This is primarily an internal API call.  It is doubtful you would ever need to use it. 


### Example

```csharp
// This is primarily an internal API call.  It is doubtful you would ever need to use it.
// We do not provide an example for this call.
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **string**|  | [optional] 
 **to** | **string**|  | [optional] 

### Return type

[**AccountsReceivableRetryStatsResponse**](AccountsReceivableRetryStatsResponse.md)

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


## GetOrder

> OrderResponse GetOrder (string orderId, string expand = null)

Retrieve an order

Retrieves a single order using the specified order id. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using Newtonsoft.Json;

namespace SdkSample.order
{
    public class GetOrder
    {
        /*
         * OrderApi.getOrder() retrieves a single order for a given order_id.
         */
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

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
            string expansion = "item,summary,billing,shipping,shipping.tracking_number_details";

            string orderId = "DEMO-0009104390";
            OrderResponse apiResponse = orderApi.GetOrder(orderId, expansion);

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                Environment.Exit(1);
            }

            Order order = apiResponse.Order;
            Console.WriteLine(JsonConvert.SerializeObject(order, new JsonSerializerSettings { Formatting = Formatting.Indented}));
            
        }

    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to retrieve. | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

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


## GetOrderByToken

> OrderResponse GetOrderByToken (OrderByTokenQuery orderByTokenQuery, string expand = null)

Retrieve an order using a token

Retrieves a single order using the specified order token. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using Newtonsoft.Json;

namespace SdkSample.order
{
    public class GetOrderByToken
    {
        /*
         * OrderApi.getOrderByToken() was created for use within a custom thank-you page.  The built-in StoreFront
         * thank you page displays the customer receipt and allows for unlimited customization.  However, many
         * merchants wish to process the receipt page on their own servers to do custom processing.
         *
         * See: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1377199/Custom+Thank+You+Page+URL
         *
         * When setting up a custom thank-you url in the StoreFronts, you will provide a query parameter that will hold
         * this order token.  You many extract that from the Request.QueryString object, then turn around and call getOrderByToken
         * to get the order object.
         */
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

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

            string expansion = "billing,checkout,coupon,customer_profile,item,payment,shipping,summary,taxes";

            // the token will be in a Request.QueryString parameter defined by you within your storefront.
            // StoreFront -> Privacy and Tracking -> Advanced -> CustomThankYouUrl
            // Example would be: www.mysite.com/receipt.aspx?OrderToken=[OrderToken]

            // Assuming this is an ASP.NET application and we're using Request.QueryString
            // string orderToken = Request.QueryString["OrderToken"];
            string orderToken = "DEMO:UZBOGywSKKwD2a5wx5JwmkwyIPNsGrDHNPiHfxsi0iAEcxgo9H74J/l6SR3X8g=="; // this won't work for you...
            // to generate an order token manually for testing, set generateOrderToken.cs
            // TODO (for you, the merchant): handle missing order token (perhaps this page somehow called by a search engine, etc).

            OrderByTokenQuery orderTokenQuery = new OrderByTokenQuery();
            orderTokenQuery.OrderToken = orderToken;
            OrderResponse apiResponse = orderApi.GetOrderByToken(orderTokenQuery, expansion);
            Order order = apiResponse.Order;

            Console.WriteLine(JsonConvert.SerializeObject(order, new JsonSerializerSettings { Formatting = Formatting.Indented}));
            
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderByTokenQuery** | [**OrderByTokenQuery**](OrderByTokenQuery.md)| Order by token query | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**OrderResponse**](OrderResponse.md)

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


## GetOrderEdiDocuments

> OrderEdiDocumentsResponse GetOrderEdiDocuments (string orderId)

Retrieve EDI documents associated with this order.

Retrieve EDI documents associated with this order. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using Newtonsoft.Json;

namespace SdkSample.order
{
    public class GetOrderEdiDocuments
    {
        /*
            getOrderEdiDocuments returns back all EDI documents associated with an order.

            Possible Errors:
            Order.channelPartnerOid is null -> "Order is not associated with an EDI channel partner."
         */
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            string orderId = "DEMO-0009104976";
            OrderEdiDocumentsResponse response = orderApi.GetOrderEdiDocuments(orderId);
            List<OrderEdiDocument> documents = response.EdiDocuments;

            foreach (OrderEdiDocument doc in documents)
            {
                Console.WriteLine(JsonConvert.SerializeObject(doc,
                    new JsonSerializerSettings { Formatting = Formatting.Indented }));
            }
            
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to retrieve EDI documents for. | 

### Return type

[**OrderEdiDocumentsResponse**](OrderEdiDocumentsResponse.md)

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


## GetOrders

> OrdersResponse GetOrders (string orderId = null, string paymentMethod = null, string company = null, string firstName = null, string lastName = null, string city = null, string stateRegion = null, string postalCode = null, string countryCode = null, string phone = null, string email = null, string ccEmail = null, decimal? total = null, string screenBrandingThemeCode = null, string storefrontHostName = null, string creationDateBegin = null, string creationDateEnd = null, string paymentDateBegin = null, string paymentDateEnd = null, string shipmentDateBegin = null, string shipmentDateEnd = null, string rma = null, string purchaseOrderNumber = null, string itemId = null, string currentStage = null, string channelPartnerCode = null, string channelPartnerOrderId = null, int? limit = null, int? offset = null, string sort = null, string expand = null)

Retrieve orders

Retrieves a group of orders from the account.  If no parameters are specified, the API call will fail with a bad request error.  Always specify some parameters to limit the scope of the orders returned to ones you are truly interested in.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using Newtonsoft.Json;

namespace SdkSample.order
{
    public class GetOrders
    {
        /*
         * getOrders was the first order query provided by UltraCart. It still functions well, but it is extremely verbose
         * because the query call takes a variable for every possible filter. You are advised to get getOrdersByQuery().
         * It is easier to use and will result in less code. Still, we provide an example here to be thorough.
         *
         * For this email, we will query all orders for a particular email address. The getOrdersByQuery() example
         * illustrates using a date range to filter and select orders.
         */
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            List<Order> orders = new List<Order>();

            int iteration = 1;
            int offset = 0;
            int limit = 200;
            bool moreRecordsToFetch = true;

            while (moreRecordsToFetch)
            {
                Console.WriteLine($"executing iteration {iteration}<br>");
                List<Order> chunkOfOrders = GetOrderChunk(orderApi, offset, limit);
                orders.AddRange(chunkOfOrders);
                offset = offset + limit;
                moreRecordsToFetch = chunkOfOrders.Count == limit;
                iteration++;
            }

            // this could get verbose...
            foreach (Order order in orders)
            {
                Console.WriteLine(JsonConvert.SerializeObject(order, new JsonSerializerSettings { Formatting = Formatting.Indented}));                
            }
            
            Console.WriteLine("<html lang=\"en\"><body><pre>");
            Console.WriteLine(orders);
            Console.WriteLine("</pre></body></html>");
        }

        private static List<Order> GetOrderChunk(OrderApi orderApi, int offset, int limit)
        {
            string expansion = "item,summary,billing,shipping,shipping.tracking_number_details";
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

            string orderId = null;
            string paymentMethod = null;
            string company = null;
            string firstName = null;
            string lastName = null;
            string city = null;
            string stateRegion = null;
            string postalCode = null;
            string countryCode = null;
            string phone = null;
            string email = "support@ultracart.com"; // <-- this is the only filter we're using.
            string ccEmail = null;
            decimal? total = null;
            string screenBrandingThemeCode = null;
            string storefrontHostName = null;
            string creationDateBegin = null;
            string creationDateEnd = null;
            string paymentDateBegin = null;
            string paymentDateEnd = null;
            string shipmentDateBegin = null;
            string shipmentDateEnd = null;
            string rma = null;
            string purchaseOrderNumber = null;
            string itemId = null;
            string currentStage = null;
            string channelPartnerCode = null;
            string channelPartnerOrderId = null;
            string sort = null;

            // see all these parameters? that is why you should use getOrdersByQuery() instead of getOrders()
            OrdersResponse apiResponse = orderApi.GetOrders(orderId, paymentMethod, company, firstName, lastName, city,
                stateRegion, postalCode, countryCode, phone, email, ccEmail, total, screenBrandingThemeCode,
                storefrontHostName, creationDateBegin, creationDateEnd, paymentDateBegin, paymentDateEnd,
                shipmentDateBegin, shipmentDateEnd, rma, purchaseOrderNumber, itemId, currentStage,
                channelPartnerCode, channelPartnerOrderId, limit, offset, sort, expansion);

            if (apiResponse.Orders != null)
            {
                return apiResponse.Orders.ToList();
            }
            return new List<Order>();
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| Order Id | [optional] 
 **paymentMethod** | **string**| Payment Method | [optional] 
 **company** | **string**| Company | [optional] 
 **firstName** | **string**| First Name | [optional] 
 **lastName** | **string**| Last Name | [optional] 
 **city** | **string**| City | [optional] 
 **stateRegion** | **string**| State/Region | [optional] 
 **postalCode** | **string**| Postal Code | [optional] 
 **countryCode** | **string**| Country Code (ISO-3166 two letter) | [optional] 
 **phone** | **string**| Phone | [optional] 
 **email** | **string**| Email | [optional] 
 **ccEmail** | **string**| CC Email | [optional] 
 **total** | **decimal?**| Total | [optional] 
 **screenBrandingThemeCode** | **string**| Screen Branding Theme Code | [optional] 
 **storefrontHostName** | **string**| StoreFront Host Name | [optional] 
 **creationDateBegin** | **string**| Creation Date Begin | [optional] 
 **creationDateEnd** | **string**| Creation Date End | [optional] 
 **paymentDateBegin** | **string**| Payment Date Begin | [optional] 
 **paymentDateEnd** | **string**| Payment Date End | [optional] 
 **shipmentDateBegin** | **string**| Shipment Date Begin | [optional] 
 **shipmentDateEnd** | **string**| Shipment Date End | [optional] 
 **rma** | **string**| RMA | [optional] 
 **purchaseOrderNumber** | **string**| Purchase Order Number | [optional] 
 **itemId** | **string**| Item Id | [optional] 
 **currentStage** | **string**| Current Stage | [optional] 
 **channelPartnerCode** | **string**| Channel Partner Code | [optional] 
 **channelPartnerOrderId** | **string**| Channel Partner Order ID | [optional] 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Maximum 200) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **sort** | **string**| The sort order of the orders.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 
 **expand** | **string**| The object expansion to perform on the result. | [optional] 

### Return type

[**OrdersResponse**](OrdersResponse.md)

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


## GetOrdersBatch

> OrdersResponse GetOrdersBatch (OrderQueryBatch orderBatch, string expand = null)

Retrieve order batch

Retrieves a group of orders from the account based on an array of order ids.  If more than 500 order ids are specified, the API call will fail with a bad request error. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using Newtonsoft.Json;

namespace SdkSample.order
{
    public class GetOrdersBatch
    {
        /*
         * This method is useful when you need to query a defined set of orders and would like to avoid querying them
         * one at a time.
         */
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            string expansion = "item,summary,billing,shipping,shipping.tracking_number_details";
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

            OrderQueryBatch orderBatch = new OrderQueryBatch();
            List<string> orderIds = new List<string> { "DEMO-0009104390", "DEMO-0009104391", "DEMO-0009104392" };
            orderBatch.OrderIds = orderIds;

            OrdersResponse apiResponse = orderApi.GetOrdersBatch(orderBatch, expansion);

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                Environment.Exit(1);
            }

            List<Order> orders = apiResponse.Orders;
            if (orders.Count == 0)
            {
                Console.Error.WriteLine("There were no orders returned by this query.");
            }

            // do something with the orders. for this example, we're just accessing many properties as illustration.
            foreach (Order order in orders)
            {
                OrderSummary summary = order.Summary;
                decimal actualShippingCost = summary.ActualShipping?.Localized ?? 0m;

                Order.CurrentStageEnum? currentStage = order.CurrentStage;
                OrderShipping sAddr = order.Shipping;
                List<string> trackingNumbers = sAddr.TrackingNumbers;
                foreach (string trackingNumber in trackingNumbers)
                {
                    // do something with tracking number here.
                }

                // Here's how to access the shipping information.  Do something with the variables.
                string sfname = order.Shipping.FirstName;
                string slname = order.Shipping.LastName;
                string saddress1 = order.Shipping.Address1;
                string saddress2 = order.Shipping.Address2;
                string scity = order.Shipping.City;
                string sregion = order.Shipping.StateRegion;
                string sccode = order.Shipping.CountryCode;
                string spcode = order.Shipping.PostalCode;
                string sdayphone = order.Shipping.DayPhone;
                string shippingMethod = order.Shipping.ShippingMethod;

                // Here's how to access the billing information.  Do something with the variables.
                string billingAddress1 = order.Billing.Address1;
                string billingAddress2 = order.Billing.Address2;
                string billingCity = order.Billing.City;
                string billingStateRegion = order.Billing.StateRegion;
                string billingCountryCode = order.Billing.CountryCode;
                string billingPostalCode = order.Billing.PostalCode;
                string email = order.Billing.Email; // email is located on the billing object.

                // here is how to access the items
                List<OrderItem> items = order.Items;
                foreach (OrderItem item in items)
                {
                    decimal qty = item.Quantity;
                    string itemId = item.MerchantItemId;
                    string description = item.Description;
                    decimal cost = item.Cost.Localized;
                    string costFormatted = item.Cost.LocalizedFormatted; // cost with symbols.
                }
            }

            // this could get verbose depending on the size of your batch ...
            foreach (Order order in orders)
            {
                Console.WriteLine(JsonConvert.SerializeObject(order, new JsonSerializerSettings { Formatting = Formatting.Indented}));                
            }
            
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderBatch** | [**OrderQueryBatch**](OrderQueryBatch.md)| Order batch | 
 **expand** | **string**| The object expansion to perform on the result. | [optional] 

### Return type

[**OrdersResponse**](OrdersResponse.md)

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


## GetOrdersByQuery

> OrdersResponse GetOrdersByQuery (OrderQuery orderQuery, int? limit = null, int? offset = null, string sort = null, string expand = null)

Retrieve orders by query

Retrieves a group of orders from the account based on a query object.  If no parameters are specified, the API call will fail with a bad request error.  Always specify some parameters to limit the scope of the orders returned to ones you are truly interested in.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 


### Example

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using Newtonsoft.Json;

namespace SdkSample.order
{
    public class GetOrdersByQuery
    {
        /*
         * This example illustrates how to query the OrderQuery object to select a range of records. It uses a subroutine
         * to aggregate the records that span multiple API calls. This example illustrates a work-around to selecting
         * all rejected orders. Because the UltraCart SDK does not have a way to query orders based on whether they
         * were rejected, we can instead query based on the rejected_dts, which is null if the order is not rejected.
         * So we will simply use a large time frame to ensure we query all rejections.
         */
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            List<Order> orders = new List<Order>();

            int iteration = 1;
            int offset = 0;
            int limit = 200;
            bool moreRecordsToFetch = true;

            while (moreRecordsToFetch)
            {
                Console.WriteLine($"executing iteration {iteration}<br>");
                List<Order> chunkOfOrders = GetOrderChunk(orderApi, offset, limit);
                orders.AddRange(chunkOfOrders);
                offset = offset + limit;
                moreRecordsToFetch = chunkOfOrders.Count == limit;
                iteration++;
            }

            foreach (Order order in orders)
            {
                Console.WriteLine(JsonConvert.SerializeObject(order, new JsonSerializerSettings { Formatting = Formatting.Indented}));                
            }            
        }

        private static List<Order> GetOrderChunk(OrderApi orderApi, int offset, int limit)
        {
            string expansion = "item,summary,billing,shipping,shipping.tracking_number_details";
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

            OrderQuery query = new OrderQuery();
            // Uncomment the next two lines to retrieve a single order. But there are simpler methods to do that.
            // string orderId = "DEMO-0009104390";
            // orderQuery.OrderId = orderId;

            string beginDts = DateTime.Now.AddDays(-2000).ToString("yyyy-MM-dd") + "T00:00:00+00:00"; // yes, that 2,000 days.
            string endDts = DateTime.Now.ToString("yyyy-MM-dd") + "T00:00:00+00:00";
            Console.Error.WriteLine(beginDts);
            Console.Error.WriteLine(endDts);

            query.RefundDateBegin = beginDts;
            query.RefundDateEnd = endDts;

            OrdersResponse apiResponse = orderApi.GetOrdersByQuery(query, limit, offset, null, expansion);
            if (apiResponse.Orders != null)
            {
                return apiResponse.Orders.ToList();
            }
            return new List<Order>();
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderQuery** | [**OrderQuery**](OrderQuery.md)| Order query | 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Maximum 200) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **sort** | **string**| The sort order of the orders.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 
 **expand** | **string**| The object expansion to perform on the result. | [optional] 

### Return type

[**OrdersResponse**](OrdersResponse.md)

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


## InsertOrder

> OrderResponse InsertOrder (Order order, string expand = null)

Insert an order

Inserts a new order on the UltraCart account.  This is probably NOT the method you want.  This is for channel orders.  For regular orders the customer is entering, use the CheckoutApi.  It has many, many more features, checks, and validations. 


### Example

```csharp
/*
 * Please do not use OrderApi.insertOrder()
 * This method was provided in the first release of our REST API.
 * It was replaced with our ChannelPartnerApi.importChannelPartnerOrder()
 *
 * Here are your options:
 * If you need to add regular orders that still require payment processing, use the CheckoutApi.
 *    The CheckoutApi has fantastic support for payment processing.
 *
 * If you need to add channel partner orders (eBay, Amazon, your call center, etc), use the ChannelPartnerApi.
 *    The ChannelPartnerApi has appropriate support for processing such orders.
 *
 * We support our entire API forever, so this method remains active.  But, we do not provide any samples for it.
 * You may use it, but we believe it will require extra time and effort and possibly much frustration.
 *
 * Reminder: The ONLY way to provide credit card numbers and cvv numbers to the UltraCart system is through
 * hosted fields.
 * See: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1377775/UltraCart+Hosted+Credit+Card+Fields
 * See: https://github.com/UltraCart/sdk_samples/blob/master/hosted_fields/hosted_fields.html
 */
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **order** | [**Order**](Order.md)| Order to insert | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

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


## IsRefundableOrder

> OrderRefundableResponse IsRefundableOrder (string orderId)

Determine if an order can be refunded

Determine if an order can be refunded based upon payment method and age 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using Newtonsoft.Json;

namespace SdkSample.order
{
    public class IsRefundableOrder
    {
        /*
            isRefundable queries the UltraCart system whether an order is refundable or not.
            In addition to a simple boolean response, UltraCart also returns back any reasons why
            an order is not refundable.
            Finally, the response also contains any refund or return reasons configured on the account in the event
            that this merchant account is configured to require a reason for a return or refund.
         */
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            string orderId = "DEMO-0009104976";
            OrderRefundableResponse refundableResponse = orderApi.IsRefundableOrder(orderId);
            Console.WriteLine($"Is Refundable: {refundableResponse.Refundable}");

            // the response contains dropdown values and additional information.  It's much more than a true/false flag.
            Console.WriteLine("API Response:");
            Console.WriteLine(JsonConvert.SerializeObject(refundableResponse, new JsonSerializerSettings { Formatting = Formatting.Indented}));            
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to check for refundable order. | 

### Return type

[**OrderRefundableResponse**](OrderRefundableResponse.md)

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


## ProcessPayment

> OrderProcessPaymentResponse ProcessPayment (string orderId, OrderProcessPaymentRequest processPaymentRequest)

Process payment

Process payment on order 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using Newtonsoft.Json;

namespace SdkSample.order
{
    public class ProcessPayment
    {
        /*
         * OrderApi.processPayment() was designed to charge a customer for an order. It was created to work in tandem with
         * duplicateOrder(), which does not accomplish payment on its own. The use-case for this method is to
         * duplicate a customer's order and then charge them for it. duplicateOrder() does not charge the customer again,
         * which is why processPayment() exists.
         *
         * These are the steps for cloning an existing order and charging the customer for it.
         * 1. duplicateOrder
         * 2. updateOrder (if you wish to change any part of it)
         * 3. processPayment to charge the customer.
         *
         * As a reminder, if you wish to create a new order from scratch, use the CheckoutApi or ChannelPartnerApi.
         * The OrderApi is for managing existing orders.
         */
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            string expansion = "items";   // for this example, we're going to change the items after we duplicate the order, so
                                          // the only expansion properties we need are the items.
                                          // See: https://www.ultracart.com/api/  for a list of all expansions.

            // Step 1. Duplicate the order
            string orderIdToDuplicate = "DEMO-0009104436";
            OrderResponse apiResponse = orderApi.DuplicateOrder(orderIdToDuplicate, expansion);
            Order newOrder = apiResponse.Order;

            // Step 2. Update the items. I will create a new items list and assign it to the order to remove the old ones completely.
            List<OrderItem> items = new List<OrderItem>();
            OrderItem item = new OrderItem();
            item.MerchantItemId = "simple_teapot";
            item.Quantity = 1;
            item.Description = "A lovely teapot";
            item.DistributionCenterCode = "DFLT"; // where is this item shipping out of?

            Currency cost = new Currency();
            cost.CurrencyCode = "USD";
            cost.Value = 9.99m;
            item.Cost = cost;

            Weight weight = new Weight();
            weight.Uom = Weight.UomEnum.OZ;
            weight.Value = 6;
            item.Weight = weight;

            items.Add(item);
            newOrder.Items = items;
            OrderResponse updateResponse = orderApi.UpdateOrder(newOrder.OrderId, newOrder, expansion);

            Order updatedOrder = updateResponse.Order;

            // Step 3. process the payment.
            // the request object below takes two optional arguments.
            // The first is an amount if you wish to bill for an amount different from the order.
            // We do not bill differently in this example.
            // The second is card_verification_number_token, which is a token you can create by using our hosted fields to
            // upload a CVV value. This will create a token you may use here. However, most merchants using the duplicate
            // order method will be setting up an auto order for a customer. Those will not make use of the CVV, so we're
            // not including it here. That is why the request object below is does not have any values set.
            // For more info on hosted fields:
            // See: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/1377775/UltraCart+Hosted+Credit+Card+Fields
            // See: https://github.com/UltraCart/sdk_samples/blob/master/hosted_fields/hosted_fields.html

            OrderProcessPaymentRequest processPaymentRequest = new OrderProcessPaymentRequest();
            OrderProcessPaymentResponse paymentResponse = orderApi.ProcessPayment(newOrder.OrderId, processPaymentRequest);
            OrderPaymentTransaction transactionDetails = paymentResponse.PaymentTransaction; // do whatever you wish with this.

            Console.WriteLine("New Order (after updated items):");
            DisplayOrderInfo(updatedOrder);
            Console.WriteLine("\nPayment Response:");
            DisplayPaymentResponse(paymentResponse);
        }

        private static void DisplayOrderInfo(Order order)
        {
            Console.WriteLine($"Order ID: {order.OrderId}");
            Console.WriteLine($"Total: {order.Summary?.Total?.Value} {order.Summary?.Total?.CurrencyCode}");
            Console.WriteLine("Items:");
            foreach (OrderItem item in order.Items)
            {
                Console.WriteLine($"  - {item.Quantity}x {item.Description} ({item.MerchantItemId})");
                Console.WriteLine($"    Cost: {item.Cost.Value} {item.Cost.CurrencyCode}");
            }
        }

        private static void DisplayPaymentResponse(OrderProcessPaymentResponse response)
        {
            Console.WriteLine($"Successfully Processed: {response.Success}");
            if (response.PaymentTransaction != null)
            {
                Console.WriteLine($"Transaction ID: {response.PaymentTransaction.TransactionId}");
                Console.WriteLine($"Transaction Timestamp: {response.PaymentTransaction.TransactionTimestamp}");
            }
            
            // here's the entire object:
            Console.WriteLine(JsonConvert.SerializeObject(response, new JsonSerializerSettings { Formatting = Formatting.Indented}));
            
            if (response.Error != null)
            {
                Console.WriteLine($"Error: {response.Error.UserMessage}");
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to process payment on | 
 **processPaymentRequest** | [**OrderProcessPaymentRequest**](OrderProcessPaymentRequest.md)| Process payment parameters | 

### Return type

[**OrderProcessPaymentResponse**](OrderProcessPaymentResponse.md)

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


## RefundOrder

> OrderResponse RefundOrder (string orderId, Order order, bool? rejectAfterRefund = null, bool? skipCustomerNotification = null, bool? autoOrderCancel = null, bool? manualRefund = null, bool? reverseAffiliateTransactions = null, bool? issueStoreCredit = null, string autoOrderCancelReason = null, string expand = null)

Refund an order

Perform a refund operation on an order and then update the order if successful.  All of the object properties ending in _refunded should be the TOTAL amount that should end up being refunded.  UltraCart will calculate the actual amount to refund based upon the prior refunds. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using Newtonsoft.Json;

namespace SdkSample.order
{
    public class RefundOrder
    {
        /*
         * refundOrder() allows for both partial and complete refunds. Both are accomplished with the same steps.
         * 1) retrieve an order object using the SDK.
         * 2) input the refunded quantities for any or all items
         * 3) call refundOrder, passing in the modified object.
         * 4) To do a full refund, set all item refund quantities to their purchased quantities.
         *
         * This example will perform a full refund.
         */
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            // for the refund, I only need the items expanded to adjust their quantities.
            // See: https://www.ultracart.com/api/ for a list of all expansions.
            string expand = "items";

            // Step 1. Retrieve the order
            string orderId = "DEMO-0009104436";
            Order order = orderApi.GetOrder(orderId, expand).Order;

            foreach (OrderItem item in order.Items)
            {
                item.QuantityRefunded = item.Quantity;
            }

            bool rejectAfterRefund = false;
            bool skipCustomerNotification = true;
            bool cancelAssociatedAutoOrders = true; // does not matter for this sample. the order is not a recurring order.
            bool considerManualRefundDoneExternally = false; // no, I want an actual refund done through my gateway
            bool reverseAffiliateTransactions = true; // can't let my affiliates get money on a refunded order. bad business.
            bool issueStoreCredit = false;
            string autoCancelReason = null;

            OrderResponse apiResponse = orderApi.RefundOrder(
                orderId,
                order, 
                rejectAfterRefund, 
                skipCustomerNotification,
                cancelAssociatedAutoOrders, 
                considerManualRefundDoneExternally, 
                reverseAffiliateTransactions,
                issueStoreCredit,
                autoCancelReason,
                expand
            );

            Order refundedOrder = apiResponse.Order;

            // examine the subtotals and ensure everything was refunded correctly.
            Console.WriteLine(JsonConvert.SerializeObject(refundedOrder, new JsonSerializerSettings { Formatting = Formatting.Indented}));
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
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

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


## ReplaceOrderItemMerchantItemId

> OrderResponse ReplaceOrderItemMerchantItemId (string orderId, ReplaceOrderItemIdRequest replaceOrderItemIdRequest, string expand = null)

Replaces an order item id

Replaces a single order item id with another merchant_item_id, leaving all other attributes and properties unchanged.  A custom method requested by a merchant to allow for item id updates due to shipping errors.  It is doubtful you will ever need this method.  The expansion variable affects the returned order object. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to update. | 
 **replaceOrderItemIdRequest** | [**ReplaceOrderItemIdRequest**](ReplaceOrderItemIdRequest.md)| Replacement Request | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

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


## Replacement

> OrderReplacementResponse Replacement (string orderId, OrderReplacement replacement)

Replacement order

Create a replacement order based upon a previous order 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.order
{
    public class Replacement
    {
        /*
         * The use-case for replacement() is to create another order for a customer to replace the items of the existing
         * order. For example, a merchant is selling perishable goods and the goods arrive late, spoiled. replacement()
         * helps to create another order to send more goods to the customer.
         *
         * You MUST supply the items you desire in the replacement order. This is done with the OrderReplacement.items field.
         * All options are displayed below including whether to charge the customer for this replacement order or not.
         */
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            // Step 1. Replace the order
            string orderIdToReplace = "DEMO-0009104436";
            OrderReplacement replacementOptions = new OrderReplacement();
            replacementOptions.OriginalOrderId = orderIdToReplace;

            List<OrderReplacementItem> items = new List<OrderReplacementItem>();

            OrderReplacementItem item1 = new OrderReplacementItem();
            item1.MerchantItemId = "TSHIRT";
            item1.Quantity = 1;
            // item1.ArbitraryUnitCost = 9.99m;
            items.Add(item1);

            OrderReplacementItem item2 = new OrderReplacementItem();
            item2.MerchantItemId = "BONE";
            item2.Quantity = 2;
            items.Add(item2);

            replacementOptions.Items = items;

            // replacementOptions.ShippingMethod = "FedEx: Ground";
            replacementOptions.ImmediateCharge = true;
            replacementOptions.SkipPayment = true;
            replacementOptions.Free = true;
            replacementOptions.CustomField1 = "Whatever";
            replacementOptions.CustomField4 = "More Whatever";
            replacementOptions.AdditionalMerchantNotesNewOrder = "Replacement order for spoiled ice cream";
            replacementOptions.AdditionalMerchantNotesOriginalOrder = "This order was replaced.";

            OrderReplacementResponse apiResponse = orderApi.Replacement(orderIdToReplace, replacementOptions);

            Console.WriteLine($"Replacement Order: {apiResponse.OrderId}");
            Console.WriteLine($"Success flag: {apiResponse.Successful}");
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to generate a replacement for. | 
 **replacement** | [**OrderReplacement**](OrderReplacement.md)| Replacement order details | 

### Return type

[**OrderReplacementResponse**](OrderReplacementResponse.md)

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


## ResendReceipt

> BaseResponse ResendReceipt (string orderId)

Resend receipt

Resend the receipt for an order on the UltraCart account. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.order
{
    public class ResendReceipt
    {
        /*
         * OrderApi.resendReceipt() will resend (email) a receipt to a customer.
         */
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            string orderId = "DEMO-0009104436";

            BaseResponse apiResponse = orderApi.ResendReceipt(orderId);

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                Console.WriteLine("Order receipt could not be resent. See error log.");
                return;
            }

            if (apiResponse.Success)
            {
                Console.WriteLine("Receipt was resent.");
            }
            else
            {
                Console.WriteLine("Failed to resend receipt.");
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to resend the receipt for. | 

### Return type

[**BaseResponse**](BaseResponse.md)

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


## ResendShipmentConfirmation

> BaseResponse ResendShipmentConfirmation (string orderId)

Resend shipment confirmation

Resend shipment confirmation for an order on the UltraCart account. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace SdkSample.order
{
    public class ResendShipmentConfirmation
    {
        /*
         * OrderApi.resendShipmentConfirmation() will resend (email) a shipment confirmation to a customer.
         */
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            string orderId = "DEMO-0009104436";

            BaseResponse apiResponse = orderApi.ResendShipmentConfirmation(orderId);

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                Console.WriteLine("Order could not be adjusted. See error log.");
                return;
            }

            if (apiResponse.Success)
            {
                Console.WriteLine("Shipment confirmation was resent.");
            }
            else
            {
                Console.WriteLine("Failed to resend shipment confirmation.");
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to resend the shipment notification for. | 

### Return type

[**BaseResponse**](BaseResponse.md)

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


## UnblockRefundOnOrder

> void UnblockRefundOnOrder (string orderId)

Remove a refund block on an order

Removes a refund block on an order to prevent a user from performing a refund. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;

namespace SdkSample.order
{
    public class UnblockRefundOnOrder
    {
        /**
         * unblockRefundOnOrder removes an order property that is considered when a refund request is made.
         * If the property is present, the refund is denied.  Being an order property allows for querying
         * upon it within BigQuery for audit purposes.
         */
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            string orderId = "DEMO-0009105222";
            orderApi.UnblockRefundOnOrder(orderId);
            Console.WriteLine("Method executed successfully.  Returns back 204 No Content.");
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to unblock a refund on. | 

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


## UpdateAccountsReceivableRetryConfig

> BaseResponse UpdateAccountsReceivableRetryConfig (AccountsReceivableRetryConfig retryConfig)

Update A/R Retry Configuration

Update A/R Retry Configuration.  This is primarily an internal API call.  It is doubtful you would ever need to use it. 


### Example

```csharp
// This is primarily an internal API call.  It is doubtful you would ever need to use it.
// We do not provide an example for this call.
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **retryConfig** | [**AccountsReceivableRetryConfig**](AccountsReceivableRetryConfig.md)| AccountsReceivableRetryConfig object | 

### Return type

[**BaseResponse**](BaseResponse.md)

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


## UpdateOrder

> OrderResponse UpdateOrder (string orderId, Order order, string expand = null)

Update an order

Update a new order on the UltraCart account.  This is probably NOT the method you want.  It is rare to update a completed order.  This will not trigger charges, emails, or any other automation. 


### Example

```csharp
using System;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using Newtonsoft.Json;

namespace SdkSample.order
{
    public class UpdateOrder
    {
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            string expansion = "checkout"; // see the getOrder sample for expansion discussion

            string orderId = "DEMO-0009104976";
            Order order = orderApi.GetOrder(orderId, expansion).Order;

            Console.WriteLine("Original Order follows:");
            Console.WriteLine(JsonConvert.SerializeObject(order, new JsonSerializerSettings { Formatting = Formatting.Indented}));
            

            // TODO: do some updates to the order.
            // For example:
            // order.BillingAddress.FirstName = "John";
            // order.BillingAddress.LastName = "Smith";

            OrderResponse apiResponse = orderApi.UpdateOrder(orderId, order,expansion);

            if (apiResponse.Error != null)
            {
                Console.Error.WriteLine(apiResponse.Error.DeveloperMessage);
                Console.Error.WriteLine(apiResponse.Error.UserMessage);
                return;
            }

            Order updatedOrder = apiResponse.Order;

            Console.WriteLine("Updated Order follows:");
            Console.WriteLine(JsonConvert.SerializeObject(updatedOrder, new JsonSerializerSettings { Formatting = Formatting.Indented}));
            
        }
        
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order id to update. | 
 **order** | [**Order**](Order.md)| Order to update | 
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

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


## ValidateOrder

> OrderValidationResponse ValidateOrder (OrderValidationRequest validationRequest)

Validate

Validate the order for errors.  Specific checks can be passed to fine tune what is validated. Read and write permissions are required because the validate method may fix obvious address issues automatically which require update permission.This rest call makes use of the built-in translation of rest objects to UltraCart internal objects which also contains a multitude of validation checks that cannot be trapped.  Therefore any time this call is made, you should also trap api exceptions and examine their content because it may contain validation issues.  So check the response object and trap any exceptions. 


### Example

```csharp
using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using Newtonsoft.Json;

namespace SdkSample.order
{
    public class ValidateOrder
    {
        /*
            validateOrder may be used to check for any and all validation errors that may result from an insertOrder
            or updateOrder call. Because those method are built on our existing infrastructure, some validation
            errors may not bubble up to the rest api call and instead be returned as generic "something went wrong" errors.
            This call will return detail validation issues needing correction.

            Within the ValidationRequest, you may leave the 'checks' array null to check for everything, or pass
            an array of the specific checks you desire. Here is a list of the checks:

            "Billing Address Provided"
            "Billing Destination Restriction"
            "Billing Phone Numbers Provided"
            "Billing State Abbreviation Valid"
            "Billing Validate City State Zip"
            "Email provided if required"
            "Gift Message Length"
            "Item Quantity Valid"
            "Items Present"
            "Merchant Specific Item Relationships"
            "One per customer violations"
            "Referral Code Provided"
            "Shipping Address Provided"
            "Shipping Destination Restriction"
            "Shipping Method Ignore Invalid"
            "Shipping Method Provided"
            "Shipping State Abbreviation Valid"
            "Shipping Validate City State Zip"
            "Special Instructions Length"
         */
        public static void Execute()
        {
            OrderApi orderApi = new OrderApi(Constants.ApiKey);

            string expansion = "checkout"; // see the getOrder sample for expansion discussion

            string orderId = "DEMO-0009104976";
            Order order = orderApi.GetOrder(orderId, expansion).Order;

            Console.WriteLine(JsonConvert.SerializeObject(order, new JsonSerializerSettings { Formatting = Formatting.Indented}));

            // TODO: do some updates to the order.
            OrderValidationRequest validationRequest = new OrderValidationRequest();
            validationRequest.Order = order;
            validationRequest.Checks = null; // leaving this null to perform all validations.

            OrderValidationResponse apiResponse = orderApi.ValidateOrder(validationRequest);

            Console.WriteLine("Validation errors:");
            if (apiResponse.Errors != null)
            {
                foreach (string error in apiResponse.Errors)
                {
                    Console.WriteLine($"- {error}");
                }
            }
            else
            {
                Console.WriteLine("No validation errors found.");
            }

            Console.WriteLine("\nValidation messages:");
            if (apiResponse.Messages != null)
            {
                foreach (string message in apiResponse.Messages)
                {
                    Console.WriteLine($"- {message}");
                }
            }
            else
            {
                Console.WriteLine("No validation messages found.");
            }
        }
    }
}
```


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **validationRequest** | [**OrderValidationRequest**](OrderValidationRequest.md)| Validation request | 

### Return type

[**OrderValidationResponse**](OrderValidationResponse.md)

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

