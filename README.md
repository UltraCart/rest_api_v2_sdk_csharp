# UltraCart C# SDK - the C# library for the UltraCart Rest API V2

This is the next generation UltraCart REST API...

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2.0.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

For more information, please visit [http://www.ultracart.com](http://www.ultracart.com)


<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out com.ultracart.admin.v2.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
// You must create your own Simple API key for this example to work.
// See the comments below.

using System;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace SDKSample {
  public class GettingStarted {

    /// <summary>
    /// Helper method to loop through a large customer record set and return back a chunk of it.
    /// See the Main method for its usage.
    /// See https://www.ultracart.com/api/#resource_customer.html
    /// See https://www.ultracart.com/api/#Operation1 for the /customer/customers REST call.
    /// </summary>
    /// <param name="api">CustomerApi reference</param>
    /// <param name="offset">The record offset.  First execution this will be zero, and then increment
    /// by the number of records returned each iteration.</param>
    /// <param name="limit">Default and maximum is 200 records.  The example below uses 100.</param>
    /// <returns>
    /// A list of UltraCart customer profiles.  These are NOT records.  They are customer profiles.
    /// If a customer places an order and does not create a customer profile, they will not appear in this list.
    /// </returns>
    private static List<Customer> GetCustomerChunk(CustomerApi api, int offset = 0, int limit = 200) {

      // string expand = null; // no expansion.  bare bones.  you will rarely want this.
      const string expand = "shipping,billing"; // shipping and billing addresses
      // string expand = "shipping,billing,cards,pricing_tiers"; // everything.

      var customerResponse = api.GetCustomers(offset: offset, limit: limit, expand: expand);
      // TODO if the response is not success, handle errors here.
      return customerResponse.Success == true ? customerResponse.Customers : new List<Customer>();

    }



    private static int Main() {

      // API Simple Keys Documentation
      // https://ultracart.atlassian.net/wiki/display/ucdoc/API+Simple+Key
      //
      // This is the backend screen where API keys are created.
      // See https://secure.ultracart.com/merchant/configuration/apiManagementApp.do
      const string simpleKey = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
      Configuration.Default.ApiKey.Add("x-ultracart-simple-key", simpleKey);

      // This is required.  Search for 'Versioning' on this page:
      // https://www.ultracart.com/api/#topics.html
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

      return 0;
    }

  }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AutoOrderApi* | [**GetAutoOrder**](docs/AutoOrderApi.md#getautoorder) | **GET** /auto_order/auto_orders/{auto_order_oid} | Retrieve an auto order
*AutoOrderApi* | [**GetAutoOrders**](docs/AutoOrderApi.md#getautoorders) | **GET** /auto_order/auto_orders | Retrieve auto orders
*AutoOrderApi* | [**UpdateAutoOrder**](docs/AutoOrderApi.md#updateautoorder) | **PUT** /auto_order/auto_orders/{auto_order_oid} | Update an auto order
*ChargebackApi* | [**DeleteChargeback**](docs/ChargebackApi.md#deletechargeback) | **DELETE** /chargeback/chargebacks/{chargeback_dispute_oid} | Delete a chargeback
*ChargebackApi* | [**GetChargebackDispute**](docs/ChargebackApi.md#getchargebackdispute) | **GET** /chargeback/chargebacks/{chargeback_dispute_oid} | Retrieve a chargeback
*ChargebackApi* | [**GetChargebackDisputes**](docs/ChargebackApi.md#getchargebackdisputes) | **GET** /chargeback/chargebacks | Retrieve chargebacks
*ChargebackApi* | [**InsertChargeback**](docs/ChargebackApi.md#insertchargeback) | **POST** /chargeback/chargebacks | Insert a chargeback
*ChargebackApi* | [**UpdateChargeback**](docs/ChargebackApi.md#updatechargeback) | **PUT** /chargeback/chargebacks/{chargeback_dispute_oid} | Update a chargeback
*CheckoutApi* | [**CityState**](docs/CheckoutApi.md#citystate) | **POST** /checkout/city_state | City/State for Zip
*CheckoutApi* | [**FinalizeOrder**](docs/CheckoutApi.md#finalizeorder) | **POST** /checkout/cart/finalizeOrder | Finalize Order
*CheckoutApi* | [**GetCart**](docs/CheckoutApi.md#getcart) | **GET** /checkout/cart | Get cart
*CheckoutApi* | [**GetCartByCartId**](docs/CheckoutApi.md#getcartbycartid) | **GET** /checkout/cart/{cart_id} | Get cart (by cart id)
*CheckoutApi* | [**GetCartByReturnCode**](docs/CheckoutApi.md#getcartbyreturncode) | **GET** /checkout/return/{return_code} | Get cart (by return code)
*CheckoutApi* | [**HandoffCart**](docs/CheckoutApi.md#handoffcart) | **POST** /checkout/cart/handoff | Handoff cart
*CheckoutApi* | [**Login**](docs/CheckoutApi.md#login) | **POST** /checkout/cart/profile/login | Profile login
*CheckoutApi* | [**Logout**](docs/CheckoutApi.md#logout) | **POST** /checkout/cart/profile/logout | Profile logout
*CheckoutApi* | [**Register**](docs/CheckoutApi.md#register) | **POST** /checkout/cart/profile/register | Profile registration
*CheckoutApi* | [**RelatedItemsForCart**](docs/CheckoutApi.md#relateditemsforcart) | **POST** /checkout/related_items | Related items
*CheckoutApi* | [**RelatedItemsForItem**](docs/CheckoutApi.md#relateditemsforitem) | **POST** /checkout/relatedItems/{item_id} | Related items (specific item)
*CheckoutApi* | [**SetupBrowserKey**](docs/CheckoutApi.md#setupbrowserkey) | **PUT** /checkout/browser_key | Setup Browser Application
*CheckoutApi* | [**UpdateCart**](docs/CheckoutApi.md#updatecart) | **PUT** /checkout/cart | Update cart
*CheckoutApi* | [**ValidateCart**](docs/CheckoutApi.md#validatecart) | **POST** /checkout/cart/validate | Validate
*CustomerApi* | [**DeleteCustomer**](docs/CustomerApi.md#deletecustomer) | **DELETE** /customer/customers/{customer_profile_oid} | Delete a customer
*CustomerApi* | [**GetCustomer**](docs/CustomerApi.md#getcustomer) | **GET** /customer/customers/{customer_profile_oid} | Retrieve a customer
*CustomerApi* | [**GetCustomers**](docs/CustomerApi.md#getcustomers) | **GET** /customer/customers | Retrieve customers
*CustomerApi* | [**GetCustomersByQuery**](docs/CustomerApi.md#getcustomersbyquery) | **GET** /customer/customers/query | Retrieve customers by query
*CustomerApi* | [**InsertCustomer**](docs/CustomerApi.md#insertcustomer) | **POST** /customer/customers | Insert a customer
*CustomerApi* | [**UpdateCustomer**](docs/CustomerApi.md#updatecustomer) | **PUT** /customer/customers/{customer_profile_oid} | Update a customer
*FulfillmentApi* | [**AcknowledgeOrders**](docs/FulfillmentApi.md#acknowledgeorders) | **PUT** /fulfillment/distribution_centers/{distribution_center_code}/acknowledgements | Acknowledge receipt of orders.
*FulfillmentApi* | [**GetDistributionCenterOrders**](docs/FulfillmentApi.md#getdistributioncenterorders) | **GET** /fulfillment/distribution_centers/{distribution_center_code}/orders | Retrieve orders queued up for this distribution center.
*FulfillmentApi* | [**GetDistributionCenters**](docs/FulfillmentApi.md#getdistributioncenters) | **GET** /fulfillment/distribution_centers | Retrieve distribution centers
*FulfillmentApi* | [**ShipOrders**](docs/FulfillmentApi.md#shiporders) | **POST** /fulfillment/distribution_centers/{distribution_center_code}/shipments | Mark orders as shipped
*FulfillmentApi* | [**UpdateInventory**](docs/FulfillmentApi.md#updateinventory) | **POST** /fulfillment/distribution_centers/{distribution_center_code}/inventory | Update inventory
*ItemApi* | [**DeleteItem**](docs/ItemApi.md#deleteitem) | **DELETE** /item/items/{merchant_item_oid} | Delete an item
*ItemApi* | [**GetItem**](docs/ItemApi.md#getitem) | **GET** /item/items/{merchant_item_oid} | Retrieve an item
*ItemApi* | [**GetItemByMerchantItemId**](docs/ItemApi.md#getitembymerchantitemid) | **GET** /item/items/merchant_item_id/{merchant_item_id} | Retrieve an item by item id
*ItemApi* | [**GetItems**](docs/ItemApi.md#getitems) | **GET** /item/items | Retrieve items
*ItemApi* | [**InsertItem**](docs/ItemApi.md#insertitem) | **POST** /item/items | Create an item
*ItemApi* | [**UpdateItem**](docs/ItemApi.md#updateitem) | **PUT** /item/items/{merchant_item_oid} | Update an item
*ItemApi* | [**UploadTemporaryMultimedia**](docs/ItemApi.md#uploadtemporarymultimedia) | **POST** /item/temp_multimedia | Upload an image to the temporary multimedia.
*OauthApi* | [**OauthAccessToken**](docs/OauthApi.md#oauthaccesstoken) | **POST** /oauth/token | Exchange authorization code for access token.
*OauthApi* | [**OauthRevoke**](docs/OauthApi.md#oauthrevoke) | **POST** /oauth/revoke | Revoke this OAuth application.
*OrderApi* | [**CancelOrder**](docs/OrderApi.md#cancelorder) | **POST** /order/orders/{order_id}/cancel | Cancel an order
*OrderApi* | [**DeleteOrder**](docs/OrderApi.md#deleteorder) | **DELETE** /order/orders/{order_id} | Delete an order
*OrderApi* | [**GetOrder**](docs/OrderApi.md#getorder) | **GET** /order/orders/{order_id} | Retrieve an order
*OrderApi* | [**GetOrders**](docs/OrderApi.md#getorders) | **GET** /order/orders | Retrieve orders
*OrderApi* | [**GetOrdersByQuery**](docs/OrderApi.md#getordersbyquery) | **POST** /order/orders/query | Retrieve orders
*OrderApi* | [**RefundOrder**](docs/OrderApi.md#refundorder) | **PUT** /order/orders/{order_id}/refund | Refund an order
*OrderApi* | [**ResendReceipt**](docs/OrderApi.md#resendreceipt) | **POST** /order/orders/{order_id}/resend_receipt | Resend receipt
*OrderApi* | [**ResendShipmentConfirmation**](docs/OrderApi.md#resendshipmentconfirmation) | **POST** /order/orders/{order_id}/resend_shipment_confirmation | Resend shipment confirmation
*OrderApi* | [**UpdateOrder**](docs/OrderApi.md#updateorder) | **PUT** /order/orders/{order_id} | Update an order
*WebhookApi* | [**DeleteWebhook**](docs/WebhookApi.md#deletewebhook) | **DELETE** /webhook/webhooks/{webhookOid} | Delete a webhook
*WebhookApi* | [**GetWebhookLog**](docs/WebhookApi.md#getwebhooklog) | **GET** /webhook/webhooks/{webhookOid}/logs/{requestId} | Retrieve an individual log
*WebhookApi* | [**GetWebhookLogSummaries**](docs/WebhookApi.md#getwebhooklogsummaries) | **GET** /webhook/webhooks/{webhookOid}/logs | Retrieve the log summaries
*WebhookApi* | [**GetWebhooks**](docs/WebhookApi.md#getwebhooks) | **GET** /webhook/webhooks | Retrieve webhooks
*WebhookApi* | [**InsertWebhook**](docs/WebhookApi.md#insertwebhook) | **POST** /webhook/webhooks | Add a webhook
*WebhookApi* | [**ResendEvent**](docs/WebhookApi.md#resendevent) | **POST** /webhook/webhooks/{webhookOid}/reflow/{eventName} | Resend events to the webhook endpoint.
*WebhookApi* | [**UpdateWebhook**](docs/WebhookApi.md#updatewebhook) | **PUT** /webhook/webhooks/{webhookOid} | Update a webhook


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ApiUserApplicationProfile](docs/ApiUserApplicationProfile.md)
 - [Model.AutoOrder](docs/AutoOrder.md)
 - [Model.AutoOrderItem](docs/AutoOrderItem.md)
 - [Model.AutoOrderItemOption](docs/AutoOrderItemOption.md)
 - [Model.AutoOrderResponse](docs/AutoOrderResponse.md)
 - [Model.AutoOrdersResponse](docs/AutoOrdersResponse.md)
 - [Model.BaseResponse](docs/BaseResponse.md)
 - [Model.Cart](docs/Cart.md)
 - [Model.CartAffiliate](docs/CartAffiliate.md)
 - [Model.CartBilling](docs/CartBilling.md)
 - [Model.CartBuysafe](docs/CartBuysafe.md)
 - [Model.CartCheckout](docs/CartCheckout.md)
 - [Model.CartCoupon](docs/CartCoupon.md)
 - [Model.CartCustomerProfile](docs/CartCustomerProfile.md)
 - [Model.CartCustomerProfileAddress](docs/CartCustomerProfileAddress.md)
 - [Model.CartCustomerProfileCreditCard](docs/CartCustomerProfileCreditCard.md)
 - [Model.CartFinalizeOrderRequest](docs/CartFinalizeOrderRequest.md)
 - [Model.CartFinalizeOrderRequestOptions](docs/CartFinalizeOrderRequestOptions.md)
 - [Model.CartFinalizeOrderResponse](docs/CartFinalizeOrderResponse.md)
 - [Model.CartGift](docs/CartGift.md)
 - [Model.CartGiftCertificate](docs/CartGiftCertificate.md)
 - [Model.CartItem](docs/CartItem.md)
 - [Model.CartItemAttribute](docs/CartItemAttribute.md)
 - [Model.CartItemMultimedia](docs/CartItemMultimedia.md)
 - [Model.CartItemMultimediaThumbnail](docs/CartItemMultimediaThumbnail.md)
 - [Model.CartItemOption](docs/CartItemOption.md)
 - [Model.CartItemOptionValue](docs/CartItemOptionValue.md)
 - [Model.CartItemPhysical](docs/CartItemPhysical.md)
 - [Model.CartItemVariationSelection](docs/CartItemVariationSelection.md)
 - [Model.CartKitComponentOption](docs/CartKitComponentOption.md)
 - [Model.CartMarketing](docs/CartMarketing.md)
 - [Model.CartPayment](docs/CartPayment.md)
 - [Model.CartPaymentAmazon](docs/CartPaymentAmazon.md)
 - [Model.CartPaymentCheck](docs/CartPaymentCheck.md)
 - [Model.CartPaymentCreditCard](docs/CartPaymentCreditCard.md)
 - [Model.CartPaymentPurchaseOrder](docs/CartPaymentPurchaseOrder.md)
 - [Model.CartProfileLoginRequest](docs/CartProfileLoginRequest.md)
 - [Model.CartProfileLoginResponse](docs/CartProfileLoginResponse.md)
 - [Model.CartProfileRegisterRequest](docs/CartProfileRegisterRequest.md)
 - [Model.CartProfileRegisterResponse](docs/CartProfileRegisterResponse.md)
 - [Model.CartResponse](docs/CartResponse.md)
 - [Model.CartSettings](docs/CartSettings.md)
 - [Model.CartSettingsBilling](docs/CartSettingsBilling.md)
 - [Model.CartSettingsGift](docs/CartSettingsGift.md)
 - [Model.CartSettingsGiftWrap](docs/CartSettingsGiftWrap.md)
 - [Model.CartSettingsPayment](docs/CartSettingsPayment.md)
 - [Model.CartSettingsPaymentAmazon](docs/CartSettingsPaymentAmazon.md)
 - [Model.CartSettingsPaymentCreditCard](docs/CartSettingsPaymentCreditCard.md)
 - [Model.CartSettingsPaymentPayPal](docs/CartSettingsPaymentPayPal.md)
 - [Model.CartSettingsProvince](docs/CartSettingsProvince.md)
 - [Model.CartSettingsShipping](docs/CartSettingsShipping.md)
 - [Model.CartSettingsShippingCalendar](docs/CartSettingsShippingCalendar.md)
 - [Model.CartSettingsShippingEstimate](docs/CartSettingsShippingEstimate.md)
 - [Model.CartSettingsTaxes](docs/CartSettingsTaxes.md)
 - [Model.CartSettingsTerms](docs/CartSettingsTerms.md)
 - [Model.CartShipping](docs/CartShipping.md)
 - [Model.CartSummary](docs/CartSummary.md)
 - [Model.CartTaxes](docs/CartTaxes.md)
 - [Model.CartUpsellAfter](docs/CartUpsellAfter.md)
 - [Model.CartValidationRequest](docs/CartValidationRequest.md)
 - [Model.CartValidationResponse](docs/CartValidationResponse.md)
 - [Model.ChargebackDispute](docs/ChargebackDispute.md)
 - [Model.ChargebackDisputeResponse](docs/ChargebackDisputeResponse.md)
 - [Model.ChargebackDisputesResponse](docs/ChargebackDisputesResponse.md)
 - [Model.CheckoutHandoffRequest](docs/CheckoutHandoffRequest.md)
 - [Model.CheckoutHandoffResponse](docs/CheckoutHandoffResponse.md)
 - [Model.CheckoutSetupBrowserKeyRequest](docs/CheckoutSetupBrowserKeyRequest.md)
 - [Model.CheckoutSetupBrowserKeyResponse](docs/CheckoutSetupBrowserKeyResponse.md)
 - [Model.CityStateZip](docs/CityStateZip.md)
 - [Model.Currency](docs/Currency.md)
 - [Model.Customer](docs/Customer.md)
 - [Model.CustomerBilling](docs/CustomerBilling.md)
 - [Model.CustomerCard](docs/CustomerCard.md)
 - [Model.CustomerPricingTier](docs/CustomerPricingTier.md)
 - [Model.CustomerQuery](docs/CustomerQuery.md)
 - [Model.CustomerResponse](docs/CustomerResponse.md)
 - [Model.CustomerShipping](docs/CustomerShipping.md)
 - [Model.CustomersResponse](docs/CustomersResponse.md)
 - [Model.Distance](docs/Distance.md)
 - [Model.DistributionCenter](docs/DistributionCenter.md)
 - [Model.DistributionCentersResponse](docs/DistributionCentersResponse.md)
 - [Model.Error](docs/Error.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.FulfillmentInventory](docs/FulfillmentInventory.md)
 - [Model.FulfillmentShipment](docs/FulfillmentShipment.md)
 - [Model.HTTPHeader](docs/HTTPHeader.md)
 - [Model.Item](docs/Item.md)
 - [Model.ItemAccounting](docs/ItemAccounting.md)
 - [Model.ItemAmember](docs/ItemAmember.md)
 - [Model.ItemAutoOrder](docs/ItemAutoOrder.md)
 - [Model.ItemAutoOrderStep](docs/ItemAutoOrderStep.md)
 - [Model.ItemAutoOrderStepArbitraryUnitCostSchedule](docs/ItemAutoOrderStepArbitraryUnitCostSchedule.md)
 - [Model.ItemAutoOrderStepGrandfatherPricing](docs/ItemAutoOrderStepGrandfatherPricing.md)
 - [Model.ItemCCBill](docs/ItemCCBill.md)
 - [Model.ItemChannelPartnerMapping](docs/ItemChannelPartnerMapping.md)
 - [Model.ItemChargeback](docs/ItemChargeback.md)
 - [Model.ItemChargebackAddendum](docs/ItemChargebackAddendum.md)
 - [Model.ItemChargebackAdjustmentRequest](docs/ItemChargebackAdjustmentRequest.md)
 - [Model.ItemCheckout](docs/ItemCheckout.md)
 - [Model.ItemContent](docs/ItemContent.md)
 - [Model.ItemContentAssignment](docs/ItemContentAssignment.md)
 - [Model.ItemContentAttribute](docs/ItemContentAttribute.md)
 - [Model.ItemContentMultimedia](docs/ItemContentMultimedia.md)
 - [Model.ItemContentMultimediaThumbnail](docs/ItemContentMultimediaThumbnail.md)
 - [Model.ItemDigitalDelivery](docs/ItemDigitalDelivery.md)
 - [Model.ItemDigitalItem](docs/ItemDigitalItem.md)
 - [Model.ItemEbay](docs/ItemEbay.md)
 - [Model.ItemEbayCategorySpecific](docs/ItemEbayCategorySpecific.md)
 - [Model.ItemEbayMarketListing](docs/ItemEbayMarketListing.md)
 - [Model.ItemEbayMarketPlaceAnalysis](docs/ItemEbayMarketPlaceAnalysis.md)
 - [Model.ItemEmailNotifications](docs/ItemEmailNotifications.md)
 - [Model.ItemEnrollment123](docs/ItemEnrollment123.md)
 - [Model.ItemGiftCertificate](docs/ItemGiftCertificate.md)
 - [Model.ItemGoogleProductSearch](docs/ItemGoogleProductSearch.md)
 - [Model.ItemIdentifiers](docs/ItemIdentifiers.md)
 - [Model.ItemInstantPaymentNotification](docs/ItemInstantPaymentNotification.md)
 - [Model.ItemInstantPaymentNotifications](docs/ItemInstantPaymentNotifications.md)
 - [Model.ItemInternal](docs/ItemInternal.md)
 - [Model.ItemKitComponent](docs/ItemKitComponent.md)
 - [Model.ItemKitDefinition](docs/ItemKitDefinition.md)
 - [Model.ItemOption](docs/ItemOption.md)
 - [Model.ItemOptionValue](docs/ItemOptionValue.md)
 - [Model.ItemOptionValueAdditionalItem](docs/ItemOptionValueAdditionalItem.md)
 - [Model.ItemOptionValueDigitalItem](docs/ItemOptionValueDigitalItem.md)
 - [Model.ItemPaymentProcessing](docs/ItemPaymentProcessing.md)
 - [Model.ItemPhysical](docs/ItemPhysical.md)
 - [Model.ItemPricing](docs/ItemPricing.md)
 - [Model.ItemPricingTier](docs/ItemPricingTier.md)
 - [Model.ItemPricingTierDiscount](docs/ItemPricingTierDiscount.md)
 - [Model.ItemPricingTierLimit](docs/ItemPricingTierLimit.md)
 - [Model.ItemRealtimePricing](docs/ItemRealtimePricing.md)
 - [Model.ItemRelated](docs/ItemRelated.md)
 - [Model.ItemRelatedItem](docs/ItemRelatedItem.md)
 - [Model.ItemReporting](docs/ItemReporting.md)
 - [Model.ItemResponse](docs/ItemResponse.md)
 - [Model.ItemRestriction](docs/ItemRestriction.md)
 - [Model.ItemRestrictionItem](docs/ItemRestrictionItem.md)
 - [Model.ItemRevguard](docs/ItemRevguard.md)
 - [Model.ItemReviews](docs/ItemReviews.md)
 - [Model.ItemSalesforce](docs/ItemSalesforce.md)
 - [Model.ItemShipping](docs/ItemShipping.md)
 - [Model.ItemShippingCase](docs/ItemShippingCase.md)
 - [Model.ItemShippingDestinationMarkup](docs/ItemShippingDestinationMarkup.md)
 - [Model.ItemShippingDestinationRestriction](docs/ItemShippingDestinationRestriction.md)
 - [Model.ItemShippingDistributionCenter](docs/ItemShippingDistributionCenter.md)
 - [Model.ItemShippingMethod](docs/ItemShippingMethod.md)
 - [Model.ItemShippingPackageRequirement](docs/ItemShippingPackageRequirement.md)
 - [Model.ItemTax](docs/ItemTax.md)
 - [Model.ItemTaxExemption](docs/ItemTaxExemption.md)
 - [Model.ItemThirdPartyEmailMarketing](docs/ItemThirdPartyEmailMarketing.md)
 - [Model.ItemVariantItem](docs/ItemVariantItem.md)
 - [Model.ItemVariation](docs/ItemVariation.md)
 - [Model.ItemVariationOption](docs/ItemVariationOption.md)
 - [Model.ItemWishlistMember](docs/ItemWishlistMember.md)
 - [Model.ItemsResponse](docs/ItemsResponse.md)
 - [Model.OauthRevokeSuccessResponse](docs/OauthRevokeSuccessResponse.md)
 - [Model.OauthTokenResponse](docs/OauthTokenResponse.md)
 - [Model.Order](docs/Order.md)
 - [Model.OrderAffiliate](docs/OrderAffiliate.md)
 - [Model.OrderAffiliateLedger](docs/OrderAffiliateLedger.md)
 - [Model.OrderAutoOrder](docs/OrderAutoOrder.md)
 - [Model.OrderBilling](docs/OrderBilling.md)
 - [Model.OrderBuysafe](docs/OrderBuysafe.md)
 - [Model.OrderChannelPartner](docs/OrderChannelPartner.md)
 - [Model.OrderCheckout](docs/OrderCheckout.md)
 - [Model.OrderCoupon](docs/OrderCoupon.md)
 - [Model.OrderDigitalItem](docs/OrderDigitalItem.md)
 - [Model.OrderDigitalOrder](docs/OrderDigitalOrder.md)
 - [Model.OrderEdi](docs/OrderEdi.md)
 - [Model.OrderFraudScore](docs/OrderFraudScore.md)
 - [Model.OrderGift](docs/OrderGift.md)
 - [Model.OrderGiftCertificate](docs/OrderGiftCertificate.md)
 - [Model.OrderInternal](docs/OrderInternal.md)
 - [Model.OrderItem](docs/OrderItem.md)
 - [Model.OrderItemEdi](docs/OrderItemEdi.md)
 - [Model.OrderItemEdiIdentification](docs/OrderItemEdiIdentification.md)
 - [Model.OrderItemEdiLot](docs/OrderItemEdiLot.md)
 - [Model.OrderItemOption](docs/OrderItemOption.md)
 - [Model.OrderItemOptionFileAttachment](docs/OrderItemOptionFileAttachment.md)
 - [Model.OrderLinkedShipment](docs/OrderLinkedShipment.md)
 - [Model.OrderMarketing](docs/OrderMarketing.md)
 - [Model.OrderPayment](docs/OrderPayment.md)
 - [Model.OrderPaymentCheck](docs/OrderPaymentCheck.md)
 - [Model.OrderPaymentCreditCard](docs/OrderPaymentCreditCard.md)
 - [Model.OrderPaymentECheck](docs/OrderPaymentECheck.md)
 - [Model.OrderPaymentPurchaseOrder](docs/OrderPaymentPurchaseOrder.md)
 - [Model.OrderPaymentTransaction](docs/OrderPaymentTransaction.md)
 - [Model.OrderPaymentTransactionDetail](docs/OrderPaymentTransactionDetail.md)
 - [Model.OrderQuery](docs/OrderQuery.md)
 - [Model.OrderQuote](docs/OrderQuote.md)
 - [Model.OrderResponse](docs/OrderResponse.md)
 - [Model.OrderSalesforce](docs/OrderSalesforce.md)
 - [Model.OrderShipping](docs/OrderShipping.md)
 - [Model.OrderSummary](docs/OrderSummary.md)
 - [Model.OrderTaxes](docs/OrderTaxes.md)
 - [Model.OrdersResponse](docs/OrdersResponse.md)
 - [Model.ResponseMetadata](docs/ResponseMetadata.md)
 - [Model.ResultSet](docs/ResultSet.md)
 - [Model.TempMultimedia](docs/TempMultimedia.md)
 - [Model.TempMultimediaResponse](docs/TempMultimediaResponse.md)
 - [Model.Webhook](docs/Webhook.md)
 - [Model.WebhookEventCategory](docs/WebhookEventCategory.md)
 - [Model.WebhookEventSubscription](docs/WebhookEventSubscription.md)
 - [Model.WebhookLog](docs/WebhookLog.md)
 - [Model.WebhookLogResponse](docs/WebhookLogResponse.md)
 - [Model.WebhookLogSummariesResponse](docs/WebhookLogSummariesResponse.md)
 - [Model.WebhookLogSummary](docs/WebhookLogSummary.md)
 - [Model.WebhookResponse](docs/WebhookResponse.md)
 - [Model.WebhookSampleRequest](docs/WebhookSampleRequest.md)
 - [Model.WebhookSampleRequestResponse](docs/WebhookSampleRequestResponse.md)
 - [Model.WebhooksResponse](docs/WebhooksResponse.md)
 - [Model.Weight](docs/Weight.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="ultraCartBrowserApiKey"></a>
### ultraCartBrowserApiKey

- **Type**: API key
- **API key parameter name**: x-ultracart-browser-key
- **Location**: HTTP header

<a name="ultraCartOauth"></a>
### ultraCartOauth

- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: https://secure.ultracart.com/rest/v2/oauth/authorize
- **Scopes**: 
  - auto_order_read: Allows you to read auto order information.
  - auto_order_write: Allows you to write auto order information.
  - chargeback_read: Allows you to read chargeback information.
  - chargeback_write: Allows you to write chargeback information.
  - checkout_read: Allows you to read checkout information.
  - checkout_write: Allows you to write checkout information.
  - customer_read: Allows you to read customer information.
  - customer_write: Allows you to write customer information.
  - fulfillment_read: Allows you to read fulfillment information.
  - fulfillment_write: Allows you to write fulfillment information.
  - order_read: Allows you to read order information.
  - order_write: Allows you to write order information.
  - item_read: Allows you to read item information.
  - item_write: Allows you to write item information.
  - webhook_read: Allows you to read webhook information.
  - webhook_write: Allows you to write webhook information.
  - ultrabooks_read: 1 of 2 required to use UltraBooks
  - ultrabooks_write: 2 of 2 required to use UltraBooks

<a name="ultraCartSimpleApiKey"></a>
### ultraCartSimpleApiKey

- **Type**: API key
- **API key parameter name**: x-ultracart-simple-key
- **Location**: HTTP header

