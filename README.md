# com.ultracart.admin.v2 - the C# library for the UltraCart Rest API V2

This is the next generation UltraCart REST API...

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2.0.0
- SDK version: 1.0.0
- Build date: 2017-05-08T08:15:57.416-04:00
- Build package: class io.swagger.codegen.languages.CSharpClientCodegen
    For more information, please visit [http://www.ultracart.com](http://www.ultracart.com)

## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using Model;
```

## Getting Started

```csharp
using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: ultraCartOauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ultraCartSimpleApiKey
            Configuration.Default.ApiKey.Add("x-ultracart-simple-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-ultracart-simple-key", "Bearer");

            var apiInstance = new AutoorderApi();
            var autoOrderOid = 56;  // int? | The auto order oid to retrieve.
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve an auto order
                AutoOrderResponse result = apiInstance.AutoOrderAutoOrdersAutoOrderOidGet(autoOrderOid, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoorderApi.AutoOrderAutoOrdersAutoOrderOidGet: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AutoorderApi* | [**AutoOrderAutoOrdersAutoOrderOidGet**](docs/AutoorderApi.md#autoorderautoordersautoorderoidget) | **GET** /auto_order/auto_orders/{auto_order_oid} | Retrieve an auto order
*AutoorderApi* | [**AutoOrderAutoOrdersAutoOrderOidPut**](docs/AutoorderApi.md#autoorderautoordersautoorderoidput) | **PUT** /auto_order/auto_orders/{auto_order_oid} | Update an auto order
*AutoorderApi* | [**AutoOrderAutoOrdersGet**](docs/AutoorderApi.md#autoorderautoordersget) | **GET** /auto_order/auto_orders | Retrieve auto orders
*ChargebackApi* | [**ChargebackChargebacksChargebackDisputeOidDelete**](docs/ChargebackApi.md#chargebackchargebackschargebackdisputeoiddelete) | **DELETE** /chargeback/chargebacks/{chargeback_dispute_oid} | Delete a chargeback
*ChargebackApi* | [**ChargebackChargebacksChargebackDisputeOidGet**](docs/ChargebackApi.md#chargebackchargebackschargebackdisputeoidget) | **GET** /chargeback/chargebacks/{chargeback_dispute_oid} | Retrieve a chargeback
*ChargebackApi* | [**ChargebackChargebacksChargebackDisputeOidPut**](docs/ChargebackApi.md#chargebackchargebackschargebackdisputeoidput) | **PUT** /chargeback/chargebacks/{chargeback_dispute_oid} | Update a chargeback
*ChargebackApi* | [**ChargebackChargebacksGet**](docs/ChargebackApi.md#chargebackchargebacksget) | **GET** /chargeback/chargebacks | Retrieve chargebacks
*ChargebackApi* | [**ChargebackChargebacksPost**](docs/ChargebackApi.md#chargebackchargebackspost) | **POST** /chargeback/chargebacks | Insert a chargeback
*CheckoutApi* | [**CheckoutBrowserKeyPut**](docs/CheckoutApi.md#checkoutbrowserkeyput) | **PUT** /checkout/browser_key | Setup Browser Application
*CheckoutApi* | [**CheckoutCartCartIdGet**](docs/CheckoutApi.md#checkoutcartcartidget) | **GET** /checkout/cart/{cart_id} | Get cart (by cart id)
*CheckoutApi* | [**CheckoutCartFinalizeOrderPost**](docs/CheckoutApi.md#checkoutcartfinalizeorderpost) | **POST** /checkout/cart/finalizeOrder | Finalize Order
*CheckoutApi* | [**CheckoutCartGet**](docs/CheckoutApi.md#checkoutcartget) | **GET** /checkout/cart | Get cart
*CheckoutApi* | [**CheckoutCartHandoffPost**](docs/CheckoutApi.md#checkoutcarthandoffpost) | **POST** /checkout/cart/handoff | Handoff cart
*CheckoutApi* | [**CheckoutCartProfileLoginPost**](docs/CheckoutApi.md#checkoutcartprofileloginpost) | **POST** /checkout/cart/profile/login | Profile login
*CheckoutApi* | [**CheckoutCartProfileLogoutPost**](docs/CheckoutApi.md#checkoutcartprofilelogoutpost) | **POST** /checkout/cart/profile/logout | Profile logout
*CheckoutApi* | [**CheckoutCartProfileRegisterPost**](docs/CheckoutApi.md#checkoutcartprofileregisterpost) | **POST** /checkout/cart/profile/register | Profile registration
*CheckoutApi* | [**CheckoutCartPut**](docs/CheckoutApi.md#checkoutcartput) | **PUT** /checkout/cart | Update cart
*CheckoutApi* | [**CheckoutCartValidatePost**](docs/CheckoutApi.md#checkoutcartvalidatepost) | **POST** /checkout/cart/validate | Validate
*CheckoutApi* | [**CheckoutCityStatePost**](docs/CheckoutApi.md#checkoutcitystatepost) | **POST** /checkout/city_state | City/State for Zip
*CheckoutApi* | [**CheckoutRelatedItemsItemIdPost**](docs/CheckoutApi.md#checkoutrelateditemsitemidpost) | **POST** /checkout/relatedItems/{item_id} | Related items (specific item)
*CheckoutApi* | [**CheckoutRelatedItemsPost**](docs/CheckoutApi.md#checkoutrelateditemspost) | **POST** /checkout/related_items | Related items
*CheckoutApi* | [**CheckoutReturnReturnCodeGet**](docs/CheckoutApi.md#checkoutreturnreturncodeget) | **GET** /checkout/return/{return_code} | Get cart (by return code)
*CustomerApi* | [**CustomerCustomersCustomerProfileOidDelete**](docs/CustomerApi.md#customercustomerscustomerprofileoiddelete) | **DELETE** /customer/customers/{customer_profile_oid} | Delete a customer
*CustomerApi* | [**CustomerCustomersCustomerProfileOidGet**](docs/CustomerApi.md#customercustomerscustomerprofileoidget) | **GET** /customer/customers/{customer_profile_oid} | Retrieve a customer
*CustomerApi* | [**CustomerCustomersCustomerProfileOidPut**](docs/CustomerApi.md#customercustomerscustomerprofileoidput) | **PUT** /customer/customers/{customer_profile_oid} | Update a customer
*CustomerApi* | [**CustomerCustomersGet**](docs/CustomerApi.md#customercustomersget) | **GET** /customer/customers | Retrieve customers
*CustomerApi* | [**CustomerCustomersPost**](docs/CustomerApi.md#customercustomerspost) | **POST** /customer/customers | Insert a customer
*FulfillmentApi* | [**FulfillmentDistributionCentersDistributionCenterCodeAcknowledgementsPut**](docs/FulfillmentApi.md#fulfillmentdistributioncentersdistributioncentercodeacknowledgementsput) | **PUT** /fulfillment/distribution_centers/{distribution_center_code}/acknowledgements | Acknowledge receipt of orders.
*FulfillmentApi* | [**FulfillmentDistributionCentersDistributionCenterCodeInventoryPost**](docs/FulfillmentApi.md#fulfillmentdistributioncentersdistributioncentercodeinventorypost) | **POST** /fulfillment/distribution_centers/{distribution_center_code}/inventory | Update inventory
*FulfillmentApi* | [**FulfillmentDistributionCentersDistributionCenterCodeOrdersGet**](docs/FulfillmentApi.md#fulfillmentdistributioncentersdistributioncentercodeordersget) | **GET** /fulfillment/distribution_centers/{distribution_center_code}/orders | Retrieve orders queued up for this distribution center.
*FulfillmentApi* | [**FulfillmentDistributionCentersDistributionCenterCodeShipmentsPost**](docs/FulfillmentApi.md#fulfillmentdistributioncentersdistributioncentercodeshipmentspost) | **POST** /fulfillment/distribution_centers/{distribution_center_code}/shipments | Mark orders as shipped
*FulfillmentApi* | [**FulfillmentDistributionCentersGet**](docs/FulfillmentApi.md#fulfillmentdistributioncentersget) | **GET** /fulfillment/distribution_centers | Retrieve distribution centers
*ItemApi* | [**ItemItemsGet**](docs/ItemApi.md#itemitemsget) | **GET** /item/items | Retrieve items
*ItemApi* | [**ItemItemsMerchantItemOidDelete**](docs/ItemApi.md#itemitemsmerchantitemoiddelete) | **DELETE** /item/items/{merchant_item_oid} | Delete an item
*ItemApi* | [**ItemItemsMerchantItemOidGet**](docs/ItemApi.md#itemitemsmerchantitemoidget) | **GET** /item/items/{merchant_item_oid} | Retrieve an item
*ItemApi* | [**ItemItemsMerchantItemOidPut**](docs/ItemApi.md#itemitemsmerchantitemoidput) | **PUT** /item/items/{merchant_item_oid} | Update an item
*ItemApi* | [**ItemItemsPost**](docs/ItemApi.md#itemitemspost) | **POST** /item/items | Create an item
*ItemApi* | [**ItemTempMultimediaPost**](docs/ItemApi.md#itemtempmultimediapost) | **POST** /item/temp_multimedia | Upload an image to the temporary multimedia.
*OauthApi* | [**OauthRevokePost**](docs/OauthApi.md#oauthrevokepost) | **POST** /oauth/revoke | Revoke this OAuth application.
*OauthApi* | [**OauthTokenPost**](docs/OauthApi.md#oauthtokenpost) | **POST** /oauth/token | Exchange authorization code for access token.
*OrderApi* | [**OrderOrdersGet**](docs/OrderApi.md#orderordersget) | **GET** /order/orders | Retrieve orders
*OrderApi* | [**OrderOrdersOrderIdCancelPost**](docs/OrderApi.md#orderordersorderidcancelpost) | **POST** /order/orders/{order_id}/cancel | Cancel an order
*OrderApi* | [**OrderOrdersOrderIdDelete**](docs/OrderApi.md#orderordersorderiddelete) | **DELETE** /order/orders/{order_id} | Delete an order
*OrderApi* | [**OrderOrdersOrderIdGet**](docs/OrderApi.md#orderordersorderidget) | **GET** /order/orders/{order_id} | Retrieve an order
*OrderApi* | [**OrderOrdersOrderIdPut**](docs/OrderApi.md#orderordersorderidput) | **PUT** /order/orders/{order_id} | Update an order
*OrderApi* | [**OrderOrdersOrderIdResendReceiptPost**](docs/OrderApi.md#orderordersorderidresendreceiptpost) | **POST** /order/orders/{order_id}/resend_receipt | Resend receipt
*OrderApi* | [**OrderOrdersOrderIdResendShipmentConfirmationPost**](docs/OrderApi.md#orderordersorderidresendshipmentconfirmationpost) | **POST** /order/orders/{order_id}/resend_shipment_confirmation | Resend shipment confirmation
*WebhookApi* | [**WebhookWebhooksGet**](docs/WebhookApi.md#webhookwebhooksget) | **GET** /webhook/webhooks | Retrieve webhooks
*WebhookApi* | [**WebhookWebhooksPost**](docs/WebhookApi.md#webhookwebhookspost) | **POST** /webhook/webhooks | Add a webhook
*WebhookApi* | [**WebhookWebhooksWebhookOidDelete**](docs/WebhookApi.md#webhookwebhookswebhookoiddelete) | **DELETE** /webhook/webhooks/{webhookOid} | Delete a webhook
*WebhookApi* | [**WebhookWebhooksWebhookOidLogsGet**](docs/WebhookApi.md#webhookwebhookswebhookoidlogsget) | **GET** /webhook/webhooks/{webhookOid}/logs | Retrieve the log summaries
*WebhookApi* | [**WebhookWebhooksWebhookOidLogsRequestIdGet**](docs/WebhookApi.md#webhookwebhookswebhookoidlogsrequestidget) | **GET** /webhook/webhooks/{webhookOid}/logs/{requestId} | Retrieve an individual log
*WebhookApi* | [**WebhookWebhooksWebhookOidPut**](docs/WebhookApi.md#webhookwebhookswebhookoidput) | **PUT** /webhook/webhooks/{webhookOid} | Update a webhook
*WebhookApi* | [**WebhookWebhooksWebhookOidReflowEventNamePost**](docs/WebhookApi.md#webhookwebhookswebhookoidrefloweventnamepost) | **POST** /webhook/webhooks/{webhookOid}/reflow/{eventName} | Resend events to the webhook endpoint.


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
 - [Model.Currency](docs/Currency.md)
 - [Model.Customer](docs/Customer.md)
 - [Model.CustomerBilling](docs/CustomerBilling.md)
 - [Model.CustomerCard](docs/CustomerCard.md)
 - [Model.CustomerPricingTier](docs/CustomerPricingTier.md)
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


## Documentation for Authorization

### ultraCartBrowserApiKey

- **Type**: API key
- **API key parameter name**: x-ultracart-browser-key
- **Location**: HTTP header

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

### ultraCartSimpleApiKey

- **Type**: API key
- **API key parameter name**: x-ultracart-simple-key
- **Location**: HTTP header

