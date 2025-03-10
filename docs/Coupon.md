
# com.ultracart.admin.v2.Model.Coupon

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AffiliateOid** | **int** | Associates an order with an affiliate when this value is set. | [optional] 
**AllowMultipleOneTimeCodes** | **bool** | True if multiple one time codes for this coupon can be used on a cart at the same time. | [optional] 
**AmountOffItems** | [**CouponAmountOffItems**](CouponAmountOffItems.md) |  | [optional] 
**AmountOffShipping** | [**CouponAmountOffShipping**](CouponAmountOffShipping.md) |  | [optional] 
**AmountOffShippingWithItemsPurchase** | [**CouponAmountOffShippingWithItemsPurchase**](CouponAmountOffShippingWithItemsPurchase.md) |  | [optional] 
**AmountOffSubtotal** | [**CouponAmountOffSubtotal**](CouponAmountOffSubtotal.md) |  | [optional] 
**AmountOffSubtotalAndFreeShipping** | [**CouponAmountOffSubtotalFreeShippingWithPurchase**](CouponAmountOffSubtotalFreeShippingWithPurchase.md) |  | [optional] 
**AmountOffSubtotalAndShipping** | [**CouponAmountOffSubtotalAndShipping**](CouponAmountOffSubtotalAndShipping.md) |  | [optional] 
**AmountOffSubtotalWithBlockPurchase** | [**CouponAmountOffSubtotalWithBlockPurchase**](CouponAmountOffSubtotalWithBlockPurchase.md) |  | [optional] 
**AmountOffSubtotalWithItemsPurchase** | [**CouponAmountOffSubtotalWithItemsPurchase**](CouponAmountOffSubtotalWithItemsPurchase.md) |  | [optional] 
**AmountOffSubtotalWithPurchase** | [**CouponAmountOffSubtotalWithPurchase**](CouponAmountOffSubtotalWithPurchase.md) |  | [optional] 
**AmountShippingWithSubtotal** | [**CouponAmountShippingWithSubtotal**](CouponAmountShippingWithSubtotal.md) |  | [optional] 
**AutomaticallyApplyCouponCodes** | [**CouponAutomaticallyApplyCouponCodes**](CouponAutomaticallyApplyCouponCodes.md) |  | [optional] 
**BuyOneGetOne** | [**CouponBuyOneGetOneLimit**](CouponBuyOneGetOneLimit.md) |  | [optional] 
**CalculatedDescription** | **string** | Calculated description displayed to the customer if no description is specified. | [optional] 
**CanBeUsedWithOtherCoupons** | **bool** | True if this coupon can be used with other coupons in a single order. | [optional] 
**CouponOid** | **int** | Coupon oid. | [optional] 
**CouponType** | **string** | Coupon type. | [optional] 
**Description** | **string** | Description of the coupon up to 50 characters. | [optional] 
**DiscountItemWithItemPurchase** | [**CouponDiscountItemWithItemPurchase**](CouponDiscountItemWithItemPurchase.md) |  | [optional] 
**DiscountItems** | [**CouponDiscountItems**](CouponDiscountItems.md) |  | [optional] 
**ExpirationDts** | **string** | Date/time when coupon expires | [optional] 
**FreeItemAndShippingWithSubtotal** | [**CouponFreeItemAndShippingWithSubtotal**](CouponFreeItemAndShippingWithSubtotal.md) |  | [optional] 
**FreeItemWithItemPurchase** | [**CouponFreeItemWithItemPurchase**](CouponFreeItemWithItemPurchase.md) |  | [optional] 
**FreeItemWithItemPurchaseAndFreeShipping** | [**CouponFreeItemWithItemPurchaseAndFreeShipping**](CouponFreeItemWithItemPurchaseAndFreeShipping.md) |  | [optional] 
**FreeItemWithSubtotal** | [**CouponFreeItemWithSubtotal**](CouponFreeItemWithSubtotal.md) |  | [optional] 
**FreeItemsWithItemPurchase** | [**CouponFreeItemsWithItemPurchase**](CouponFreeItemsWithItemPurchase.md) |  | [optional] 
**FreeItemsWithMixmatchPurchase** | [**CouponFreeItemsWithMixMatchPurchase**](CouponFreeItemsWithMixMatchPurchase.md) |  | [optional] 
**FreeShipping** | [**CouponFreeShipping**](CouponFreeShipping.md) |  | [optional] 
**FreeShippingSpecificItems** | [**CouponFreeShippingSpecificItems**](CouponFreeShippingSpecificItems.md) |  | [optional] 
**FreeShippingWithItemsPurchase** | [**CouponFreeShippingWithItemsPurchase**](CouponFreeShippingWithItemsPurchase.md) |  | [optional] 
**FreeShippingWithSubtotal** | [**CouponFreeShippingWithSubtotal**](CouponFreeShippingWithSubtotal.md) |  | [optional] 
**HideFromCustomer** | **bool** | Hide coupon from customer during checkout.  Often used when coupons are automatic discounting mechanisms. | [optional] 
**MerchantCode** | **string** | Merchant code of coupon up to 20 characters. | [optional] 
**MerchantNotes** | **string** | Internal notes about this coupon.  These are not visible to customer. | [optional] 
**MoreLoyaltyCashback** | [**CouponMoreLoyaltyCashback**](CouponMoreLoyaltyCashback.md) |  | [optional] 
**MoreLoyaltyPoints** | [**CouponMoreLoyaltyPoints**](CouponMoreLoyaltyPoints.md) |  | [optional] 
**MultipleAmountsOffItems** | [**CouponMultipleAmountsOffItems**](CouponMultipleAmountsOffItems.md) |  | [optional] 
**NoDiscount** | [**CouponNoDiscount**](CouponNoDiscount.md) |  | [optional] 
**PercentMoreLoyaltyCashback** | [**CouponPercentMoreLoyaltyCashback**](CouponPercentMoreLoyaltyCashback.md) |  | [optional] 
**PercentMoreLoyaltyPoints** | [**CouponPercentMoreLoyaltyPoints**](CouponPercentMoreLoyaltyPoints.md) |  | [optional] 
**PercentOffItemWithItemsQuantityPurchase** | [**CouponPercentOffItemWithItemsQuantityPurchase**](CouponPercentOffItemWithItemsQuantityPurchase.md) |  | [optional] 
**PercentOffItems** | [**CouponPercentOffItems**](CouponPercentOffItems.md) |  | [optional] 
**PercentOffItemsAndFreeShipping** | [**CouponPercentOffItemsAndFreeShipping**](CouponPercentOffItemsAndFreeShipping.md) |  | [optional] 
**PercentOffItemsWithItemsPurchase** | [**CouponPercentOffItemsWithItemsPurchase**](CouponPercentOffItemsWithItemsPurchase.md) |  | [optional] 
**PercentOffMsrpItems** | [**CouponPercentOffMsrpItems**](CouponPercentOffMsrpItems.md) |  | [optional] 
**PercentOffRetailPriceItems** | [**CouponPercentOffRetailPriceItems**](CouponPercentOffRetailPriceItems.md) |  | [optional] 
**PercentOffShipping** | [**CouponPercentOffShipping**](CouponPercentOffShipping.md) |  | [optional] 
**PercentOffSubtotal** | [**CouponPercentOffSubtotal**](CouponPercentOffSubtotal.md) |  | [optional] 
**PercentOffSubtotalAndFreeShipping** | [**CouponPercentOffSubtotalAndFreeShipping**](CouponPercentOffSubtotalAndFreeShipping.md) |  | [optional] 
**PercentOffSubtotalLimit** | [**CouponPercentOffSubtotalLimit**](CouponPercentOffSubtotalLimit.md) |  | [optional] 
**PercentOffSubtotalWithItemsPurchase** | [**CouponPercentOffSubtotalWithItemsPurchase**](CouponPercentOffSubtotalWithItemsPurchase.md) |  | [optional] 
**PercentOffSubtotalWithSubtotal** | [**CouponPercentOffSubtotalWithSubtotal**](CouponPercentOffSubtotalWithSubtotal.md) |  | [optional] 
**QuickbooksCode** | **string** | Quickbooks accounting code. | [optional] 
**RestrictByPostalCodes** | **List&lt;string&gt;** | Optional list of postal codes which restrict a coupon to within these postal codes. | [optional] 
**RestrictByScreenBrandingThemeCodes** | [**List&lt;CouponRestriction&gt;**](CouponRestriction.md) | Optional list of legacy screen branding theme codes to limit coupon use to only those themes. | [optional] 
**RestrictByStorefronts** | [**List&lt;CouponRestriction&gt;**](CouponRestriction.md) | Optional list of storefronts to limit coupon use to only those storefronts. | [optional] 
**SkipOnRebill** | **bool** | Skip this coupon when it is on a rebill of an auto order. | [optional] 
**StartDts** | **string** | Date/time when coupon is valid | [optional] 
**SuperCoupon** | **bool** | If true, this coupon can be used with ANY other coupon regardless of the other coupons configuration | [optional] 
**TieredAmountOffItems** | [**CouponTieredAmountOffItems**](CouponTieredAmountOffItems.md) |  | [optional] 
**TieredAmountOffSubtotal** | [**CouponTieredAmountOffSubtotal**](CouponTieredAmountOffSubtotal.md) |  | [optional] 
**TieredPercentOffItems** | [**CouponTieredPercentOffItems**](CouponTieredPercentOffItems.md) |  | [optional] 
**TieredPercentOffShipping** | [**CouponTieredPercentOffShipping**](CouponTieredPercentOffShipping.md) |  | [optional] 
**TieredPercentOffSubtotal** | [**CouponTieredPercentOffSubtotal**](CouponTieredPercentOffSubtotal.md) |  | [optional] 
**TieredPercentOffSubtotalBasedOnMsrp** | [**CouponTieredPercentOffSubtotalBasedOnMSRP**](CouponTieredPercentOffSubtotalBasedOnMSRP.md) |  | [optional] 
**UsableBy** | **string** | Who may use this coupon. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

