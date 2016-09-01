# com.ultracart.admin.v2 - the C# library for the UltraCart Rest API V2

This is the next generation UltraCart REST API...

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2.0.0
- SDK version: 1.0.0
- Build date: 2016-09-01T10:25:34.214-04:00
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

            var apiInstance = new ItemApi();
            var parentCategoryId = 56;  // int? | The parent category to retrieve items for.  Unspecified means all items on the account.  0 = root (optional) 
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (optional) 
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional) 
            var since = since_example;  // string | Fetch items that have been created/modified since this date/time. (optional) 
            var sort = sort_example;  // string | The sort order of the items.  See documentation for examples (optional) 
            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 
            var placeholders = true;  // bool? | Whether or not placeholder values should be returned in the result.  Useful for UIs that consume this REST API. (optional) 

            try
            {
                // Retrieve items
                ItemsResponse result = apiInstance.ItemItemsGet(parentCategoryId, limit, offset, since, sort, expand, placeholders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.ItemItemsGet: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://secure.ultracart.com/rest/admin/v2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ItemApi* | [**ItemItemsGet**](docs/ItemApi.md#itemitemsget) | **GET** /item/items | Retrieve items
*ItemApi* | [**ItemItemsMerchantItemOidDelete**](docs/ItemApi.md#itemitemsmerchantitemoiddelete) | **DELETE** /item/items/{merchant_item_oid} | Delete an item
*ItemApi* | [**ItemItemsMerchantItemOidGet**](docs/ItemApi.md#itemitemsmerchantitemoidget) | **GET** /item/items/{merchant_item_oid} | Retrieve an item
*ItemApi* | [**ItemItemsMerchantItemOidPut**](docs/ItemApi.md#itemitemsmerchantitemoidput) | **PUT** /item/items/{merchant_item_oid} | Update an item
*ItemApi* | [**ItemItemsPost**](docs/ItemApi.md#itemitemspost) | **POST** /item/items | Create an item
*ItemApi* | [**ItemTempMultimediaPost**](docs/ItemApi.md#itemtempmultimediapost) | **POST** /item/temp_multimedia | Upload an image to the temporary multimedia.
*WebhookApi* | [**WebhookWebhooksGet**](docs/WebhookApi.md#webhookwebhooksget) | **GET** /webhook/webhooks | Retrieve webhooks
*WebhookApi* | [**WebhookWebhooksPost**](docs/WebhookApi.md#webhookwebhookspost) | **POST** /webhook/webhooks | Add a webhook
*WebhookApi* | [**WebhookWebhooksWebhookOidDelete**](docs/WebhookApi.md#webhookwebhookswebhookoiddelete) | **DELETE** /webhook/webhooks/{webhookOid} | Delete a webhook
*WebhookApi* | [**WebhookWebhooksWebhookOidLogsGet**](docs/WebhookApi.md#webhookwebhookswebhookoidlogsget) | **GET** /webhook/webhooks/{webhookOid}/logs | Retrieve the log summaries
*WebhookApi* | [**WebhookWebhooksWebhookOidLogsRequestIdGet**](docs/WebhookApi.md#webhookwebhookswebhookoidlogsrequestidget) | **GET** /webhook/webhooks/{webhookOid}/logs/{requestId} | Retrieve an individual log
*WebhookApi* | [**WebhookWebhooksWebhookOidPut**](docs/WebhookApi.md#webhookwebhookswebhookoidput) | **PUT** /webhook/webhooks/{webhookOid} | Update a webhook
*WebhookApi* | [**WebhookWebhooksWebhookOidReflowEventNamePost**](docs/WebhookApi.md#webhookwebhookswebhookoidrefloweventnamepost) | **POST** /webhook/webhooks/{webhookOid}/reflow/{eventName} | Resend events to the webhook endpoint.
*WebhookApi* | [**WebhookWebhooksWebhookOidSamplesGet**](docs/WebhookApi.md#webhookwebhookswebhookoidsamplesget) | **GET** /webhook/webhooks/{webhookOid}/samples | Retrieve a sample notification.
*WebhookApi* | [**WebhookWebhooksWebhookOidValidatePost**](docs/WebhookApi.md#webhookwebhookswebhookoidvalidatepost) | **POST** /webhook/webhooks/{webhookOid}/validate | Send test message to an endpoint.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ApiUserApplicationProfile](docs/ApiUserApplicationProfile.md)
 - [Model.Distance](docs/Distance.md)
 - [Model.Error](docs/Error.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
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
 - [Model.WebhookSampleRequest](docs/WebhookSampleRequest.md)
 - [Model.WebhookSampleRequestResponse](docs/WebhookSampleRequestResponse.md)
 - [Model.WebhooksResponse](docs/WebhooksResponse.md)
 - [Model.Weight](docs/Weight.md)


## Documentation for Authorization

### ultraCartOauth

- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: https://secure.ultracart.com/rest/oauth/authorize
- **Scopes**: 
  - item_read: Allows you to read item information.
  - item_write: Allows you to write item information.

### ultraCartSimpleApiKey

- **Type**: API key
- **API key parameter name**: x-ultracart-simple-key
- **Location**: HTTP header

