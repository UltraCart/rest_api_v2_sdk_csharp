
# com.ultracart.admin.v2.Model.Item

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accounting** | [**ItemAccounting**](ItemAccounting.md) |  | [optional] 
**Amember** | [**ItemAmember**](ItemAmember.md) |  | [optional] 
**AutoOrder** | [**ItemAutoOrder**](ItemAutoOrder.md) |  | [optional] 
**Ccbill** | [**ItemCCBill**](ItemCCBill.md) |  | [optional] 
**ChannelPartnerItemMappings** | [**List&lt;ItemChannelPartnerMapping&gt;**](ItemChannelPartnerMapping.md) | Channel Partner Item Mapping | [optional] 
**Chargeback** | [**ItemChargeback**](ItemChargeback.md) |  | [optional] 
**Checkout** | [**ItemCheckout**](ItemCheckout.md) |  | [optional] 
**Content** | [**ItemContent**](ItemContent.md) |  | [optional] 
**CreationDts** | **string** | Date/time of creation | [optional] 
**Description** | **string** | Description of the item up to 500 characters. | [optional] 
**DescriptionTranslatedTextInstanceOid** | **int** | Description translated text instance id | [optional] 
**DigitalDelivery** | [**ItemDigitalDelivery**](ItemDigitalDelivery.md) |  | [optional] 
**Ebay** | [**ItemEbay**](ItemEbay.md) |  | [optional] 
**EmailNotifications** | [**ItemEmailNotifications**](ItemEmailNotifications.md) |  | [optional] 
**Enrollment123** | [**ItemEnrollment123**](ItemEnrollment123.md) |  | [optional] 
**FulfillmentAddons** | [**List&lt;ItemFulfillmentAddon&gt;**](ItemFulfillmentAddon.md) | Fulfillment Add-ons | [optional] 
**GiftCertificate** | [**ItemGiftCertificate**](ItemGiftCertificate.md) |  | [optional] 
**GoogleProductSearch** | [**ItemGoogleProductSearch**](ItemGoogleProductSearch.md) |  | [optional] 
**Identifiers** | [**ItemIdentifiers**](ItemIdentifiers.md) |  | [optional] 
**Inactive** | **bool** | True if this item is inactive and can not be purchased | [optional] 
**InstantPaymentNotifications** | [**ItemInstantPaymentNotifications**](ItemInstantPaymentNotifications.md) |  | [optional] 
**Internal** | [**ItemInternal**](ItemInternal.md) |  | [optional] 
**Kit** | **bool** | True if this item is a kit | [optional] 
**KitComponentOnly** | **bool** | True if this item can only be usd as a kit component | [optional] 
**KitDefinition** | [**ItemKitDefinition**](ItemKitDefinition.md) |  | [optional] 
**LastModifiedDts** | **string** | Date/time of last modification | [optional] 
**MerchantId** | **string** | UltraCart merchant ID owning item | [optional] 
**MerchantItemId** | **string** | Unique item id assigned to this item | [optional] 
**MerchantItemOid** | **int** | Unique object identifier for this item | [optional] 
**Options** | [**List&lt;ItemOption&gt;**](ItemOption.md) | Options | [optional] 
**ParentCategoryId** | **int** | Parent category of the item.  Zero indicates the root folder. | [optional] 
**ParentCategoryPath** | **string** | Parent category path.  / indicates the root folder.  This is the folder structure within item management. | [optional] 
**PaymentProcessing** | [**ItemPaymentProcessing**](ItemPaymentProcessing.md) |  | [optional] 
**Physical** | [**ItemPhysical**](ItemPhysical.md) |  | [optional] 
**Pricing** | [**ItemPricing**](ItemPricing.md) |  | [optional] 
**Properties** | [**List&lt;ItemProperty&gt;**](ItemProperty.md) | Properties | [optional] 
**RealtimePricing** | [**ItemRealtimePricing**](ItemRealtimePricing.md) |  | [optional] 
**RecommendReplenishmentDays** | **int** | Number of days to recommend replenishment after.  Null is not configured.  Set to zero to disable. | [optional] 
**Related** | [**ItemRelated**](ItemRelated.md) |  | [optional] 
**Reporting** | [**ItemReporting**](ItemReporting.md) |  | [optional] 
**Restriction** | [**ItemRestriction**](ItemRestriction.md) |  | [optional] 
**Revguard** | [**ItemRevguard**](ItemRevguard.md) |  | [optional] 
**Reviews** | [**ItemReviews**](ItemReviews.md) |  | [optional] 
**Salesforce** | [**ItemSalesforce**](ItemSalesforce.md) |  | [optional] 
**Shipping** | [**ItemShipping**](ItemShipping.md) |  | [optional] 
**Tags** | [**ItemTags**](ItemTags.md) |  | [optional] 
**Tax** | [**ItemTax**](ItemTax.md) |  | [optional] 
**ThirdPartyEmailMarketing** | [**List&lt;ItemThirdPartyEmailMarketing&gt;**](ItemThirdPartyEmailMarketing.md) | 3rd Party Email Marketing | [optional] 
**VariantItems** | [**List&lt;ItemVariantItem&gt;**](ItemVariantItem.md) | Variant Items | [optional] 
**Variations** | [**List&lt;ItemVariation&gt;**](ItemVariation.md) | Variations | [optional] 
**WishlistMember** | [**ItemWishlistMember**](ItemWishlistMember.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

