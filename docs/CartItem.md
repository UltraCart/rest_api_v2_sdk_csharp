# com.ultracart.admin.v2.Model.CartItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArbitraryUnitCost** | [**Currency**](Currency.md) |  | [optional] 
**Attributes** | [**List&lt;CartItemAttribute&gt;**](CartItemAttribute.md) | Attributes | [optional] 
**AutoOrderSchedule** | **string** | Auto order schedule the customer selected | [optional] 
**DefaultImageUrl** | **string** | URL to the default multimedia image | [optional] 
**DefaultThumbnailUrl** | **string** | URL to the default multimedia thumbnail | [optional] 
**Description** | **string** | Description of the item | [optional] 
**Discount** | [**Currency**](Currency.md) |  | [optional] 
**ExtendedDescription** | **string** | Extended description of the item | [optional] 
**ItemId** | **string** | Item ID | [optional] 
**ItemOid** | **int?** | Item object identifier | [optional] 
**Kit** | **bool?** | True if this item is a kit | [optional] 
**KitComponentOptions** | [**List&lt;CartKitComponentOption&gt;**](CartKitComponentOption.md) | Options associated with the kit components | [optional] 
**ManufacturerSuggestedRetailPrice** | [**Currency**](Currency.md) |  | [optional] 
**MaximumQuantity** | **decimal?** | Maximum quantity the customer can purchase | [optional] 
**MinimumQuantity** | **decimal?** | Minimum quantity the customer can purchase | [optional] 
**Multimedia** | [**List&lt;CartItemMultimedia&gt;**](CartItemMultimedia.md) | Multimedia | [optional] 
**Options** | [**List&lt;CartItemOption&gt;**](CartItemOption.md) | Options | [optional] 
**Phsyical** | [**CartItemPhysical**](CartItemPhysical.md) |  | [optional] 
**Position** | **int?** | Position of the item in the cart | [optional] 
**Preorder** | **bool?** | True if this item is on pre-order | [optional] 
**Quantity** | **decimal?** | quantity | [optional] 
**Schedules** | **List&lt;string&gt;** | Customer selectable auto order schedules | [optional] 
**TotalCost** | [**Currency**](Currency.md) |  | [optional] 
**TotalCostWithDiscount** | [**Currency**](Currency.md) |  | [optional] 
**UnitCost** | [**Currency**](Currency.md) |  | [optional] 
**UnitCostWithDiscount** | [**Currency**](Currency.md) |  | [optional] 
**Upsell** | **bool?** | True if this item was added to the cart as part of an upsell | [optional] 
**Variations** | [**List&lt;CartItemVariationSelection&gt;**](CartItemVariationSelection.md) | Variations | [optional] 
**ViewUrl** | **string** | URL to view the product on the site | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

