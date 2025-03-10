
# com.ultracart.admin.v2.Model.ItemEbay

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** | True if the item is active for listing | [optional] 
**CategoryId** | **int** | e-Bay category ID | [optional] 
**CategorySpecifics** | [**List&lt;ItemEbayCategorySpecific&gt;**](ItemEbayCategorySpecific.md) | Answers to category specific questions | [optional] 
**ConditionDescription** | **string** | Description of the condition (e-Bay constant) | [optional] 
**ConditionId** | **int** | Numerical ID of the condition (e-Bay constant) | [optional] 
**ConsecutiveFailures** | **int** | Number of consecutive failures trying to list this item | [optional] 
**CustomCategory1** | **long** | e-Bay Store category 1 | [optional] 
**CustomCategory2** | **long** | e-Bay Store category 2 | [optional] 
**DispatchTimeMax** | **int** | Maximum number of days it will take to ship the item | [optional] 
**Domestic1AdditionalCost** | **decimal** | Domestic 1 method additional item cost | [optional] 
**Domestic1FirstCost** | **decimal** | Domestic 1 method first item cost | [optional] 
**Domestic2AdditionalCost** | **decimal** | Domestic 2 method additional item cost | [optional] 
**Domestic2FirstCost** | **decimal** | Domestic 2 method first item cost | [optional] 
**Domestic3AdditionalCost** | **decimal** | Domestic 3 method additional item cost | [optional] 
**Domestic3FirstCost** | **decimal** | Domestic 3 method first item cost | [optional] 
**Domestic4AdditionalCost** | **decimal** | Domestic 4 method additional item cost | [optional] 
**Domestic4FirstCost** | **decimal** | Domestic 4 method first item cost | [optional] 
**EbayAuctionId** | **string** | If listed, this is the e-Bay auction id | [optional] 
**EbaySpecificInventory** | **int** | e-Bay specific inventory | [optional] 
**EbayTemplateName** | **string** | The template name to use hwen rendering the e-Bay listing | [optional] 
**EbayTemplateOid** | **int** | The template object identifier to use when rendering the e-Bay listing | [optional] 
**EndTime** | **string** | Date/time of the auction end | [optional] 
**FreeShipping** | **bool** | True if item receives free shipping | [optional] 
**FreeShippingMethod** | **string** | The method that is free for free shipping | [optional] 
**International1AdditionalCost** | **decimal** | International 1 method additional item cost | [optional] 
**International1FirstCost** | **decimal** | International 1 method first item cost | [optional] 
**International2AdditionalCost** | **decimal** | International 2 method additional item cost | [optional] 
**International2FirstCost** | **decimal** | International 2 method first item cost | [optional] 
**International3AdditionalCost** | **decimal** | International 3 method additional item cost | [optional] 
**International3FirstCost** | **decimal** | International 3 method first item cost | [optional] 
**International4AdditionalCost** | **decimal** | International 4 method additional item cost | [optional] 
**International4FirstCost** | **decimal** | International 4 method first item cost | [optional] 
**LastStatusDts** | **string** | Date/time of the last status check | [optional] 
**ListedDispatchTimeMax** | **int** | Current listing dispatch time maximum | [optional] 
**ListedEbayTemplateOid** | **int** | The template object identifier used for the listing | [optional] 
**ListingDts** | **string** | Date/time of the listing | [optional] 
**ListingDuration** | **string** | The duration of the listing | [optional] 
**ListingPrice** | **decimal** | Price to list the item at | [optional] 
**ListingPriceOverride** | **decimal** | The price to list the item at if different than the regular UltraCart item price | [optional] 
**ListingType** | **string** | The type of e-Bay listing | [optional] 
**MarketplaceAnalysis** | [**ItemEbayMarketPlaceAnalysis**](ItemEbayMarketPlaceAnalysis.md) |  | [optional] 
**MarketplaceAnalysisPerform** | **bool** | True if marketplace analysis should be performed | [optional] 
**MarketplaceFinalValueFeePercentage** | **decimal** | Marketplace FVF percentage | [optional] 
**MarketplaceLastCheckDts** | **string** | Date/time of the marketplace analysis last check | [optional] 
**MarketplaceLowest** | **bool** | True if we are the lowest offer in the marketplace | [optional] 
**MarketplaceMapViolation** | **bool** | True if another seller is violating MAP | [optional] 
**MarketplaceMultiplier** | **decimal** | Marketplace multiplier | [optional] 
**MarketplaceOtherPrice** | **decimal** | Marketplace other price | [optional] 
**MarketplaceOtherSeller** | **string** | Marketplace other seller | [optional] 
**MarketplaceOtherShipping** | **decimal** | Marketplace other shipping | [optional] 
**MarketplaceOtherTotal** | **decimal** | Marketplace other total | [optional] 
**MarketplaceOurAdditionalProfitPotential** | **decimal** | Marketplace our additional profit potential | [optional] 
**MarketplaceOurPrice** | **decimal** | Marketplace our price | [optional] 
**MarketplaceOurProfit** | **decimal** | Marketplace our profit | [optional] 
**MarketplaceOurShipping** | **decimal** | Marketplace our shipping | [optional] 
**MarketplaceOurTotal** | **decimal** | Marketplace our total | [optional] 
**MarketplaceOverhead** | **decimal** | Marketplace overhead | [optional] 
**MarketplaceProfitable** | **bool** | True if our listing is profitable to sell | [optional] 
**NextAttemptDts** | **string** | Date/time for the next attempt to list | [optional] 
**NextListingDuration** | **string** | The next listing duration to use when the current listing ends. | [optional] 
**NoPromotionalShipping** | **bool** | True if the item should not qualify for promotional shipping | [optional] 
**PackagingHandlingCosts** | **decimal** | Packaging and handling costs | [optional] 
**PreviousEbayAuctionId** | **string** | Previous e-Bay auction id | [optional] 
**Quantity** | **int** | Quantity available of the item | [optional] 
**ReservePrice** | **decimal** | Reserve price | [optional] 
**SendDimensionsAndWeight** | **string** | How to send the item dimensions and weights to e-Bay | [optional] 
**StartTime** | **string** | Date/time of the auction start | [optional] 
**Status** | **string** | Status of the item&#39;s listing | [optional] 
**TargetDispatchTimeMax** | **int** | Typical number of days it will take to ship the item | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

