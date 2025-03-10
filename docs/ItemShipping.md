
# com.ultracart.admin.v2.Model.ItemShipping

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowBackOrder** | **bool** | Allow back order | [optional] 
**AmazonFba** | **bool** | Fulfillment by Amazon.com | [optional] 
**CaseInnerPacks** | **int** | Case inner packs | [optional] 
**CaseUnits** | **int** | Case units | [optional] 
**Cases** | [**List&lt;ItemShippingCase&gt;**](ItemShippingCase.md) | Cases | [optional] 
**CollectSerialNumbers** | **bool** | This item is on pre-order | [optional] 
**CountryCodeOfOrigin** | **string** | Country code of origin for customs forms.  (ISO-3166 two letter code) | [optional] 
**CustomsDescription** | **string** | Customs description | [optional] 
**CustomsValue** | **decimal** | Customs value | [optional] 
**DeliveryOnFriday** | **bool** | Delivery on Friday | [optional] 
**DeliveryOnMonday** | **bool** | Delivery on Monday | [optional] 
**DeliveryOnSaturday** | **bool** | Delivery on Saturday | [optional] 
**DeliveryOnSunday** | **bool** | Delivery on Sunday | [optional] 
**DeliveryOnThursday** | **bool** | Delivery on Thursday | [optional] 
**DeliveryOnTuesday** | **bool** | Delivery on Tuesday | [optional] 
**DeliveryOnWednesday** | **bool** | Delivery on Wednesday | [optional] 
**DestinationMarkups** | [**List&lt;ItemShippingDestinationMarkup&gt;**](ItemShippingDestinationMarkup.md) | Destination markups | [optional] 
**DestinationRestrictions** | [**List&lt;ItemShippingDestinationRestriction&gt;**](ItemShippingDestinationRestriction.md) | Destination restrictions | [optional] 
**DistributionCenters** | [**List&lt;ItemShippingDistributionCenter&gt;**](ItemShippingDistributionCenter.md) | Distribution centers | [optional] 
**Eta** | **string** | Estimated time of arrival | [optional] 
**FreeShipping** | **bool** | Qualifies for free shipping | [optional] 
**FreightClass** | **string** | Freight class | [optional] 
**Hazmat** | **bool** | Hazardous material | [optional] 
**HoldForTransmission** | **bool** | Hold for transmission | [optional] 
**MadeToOrder** | **bool** | True if this item is made to order | [optional] 
**MadeToOrderLeadTime** | **int** | Number of days lead time it takes to make the item before ite can ship | [optional] 
**MaxDaysTimeInTransit** | **int** | Maximum days allowed in transit | [optional] 
**Methods** | [**List&lt;ItemShippingMethod&gt;**](ItemShippingMethod.md) | Methods | [optional] 
**NoShippingDiscount** | **bool** | No shipping discounts | [optional] 
**PackageRequirements** | [**List&lt;ItemShippingPackageRequirement&gt;**](ItemShippingPackageRequirement.md) | Package requirements | [optional] 
**PerishableClassName** | **string** | Perishable class name | [optional] 
**PerishableClassOid** | **int** | Perishable class object identifier | [optional] 
**Preorder** | **bool** | This item is on pre-order | [optional] 
**RequireDeliveryDate** | **bool** | True to require customer to select a delivery date | [optional] 
**RestrictShipmentOnFriday** | **bool** | Restrict shipment on Friday | [optional] 
**RestrictShipmentOnMonday** | **bool** | Restrict shipment on Monday | [optional] 
**RestrictShipmentOnSaturday** | **bool** | Restrict shipment on Saturday | [optional] 
**RestrictShipmentOnSunday** | **bool** | Restrict shipment on Sunday | [optional] 
**RestrictShipmentOnThursday** | **bool** | Restrict shipment on Thursday | [optional] 
**RestrictShipmentOnTuesday** | **bool** | Restrict shipment on Tuesday | [optional] 
**RestrictShipmentOnWednesday** | **bool** | Restrict shipment on Wednesday | [optional] 
**ShipSeparately** | **bool** | Ship this item in a separate box | [optional] 
**ShipSeparatelyAdditionalWeight** | [**Weight**](Weight.md) |  | [optional] 
**ShipSeparatelyHeight** | [**Distance**](Distance.md) |  | [optional] 
**ShipSeparatelyLength** | [**Distance**](Distance.md) |  | [optional] 
**ShipSeparatelyPackageSpecialType** | **string** | Ship separately package special type | [optional] 
**ShipSeparatelyWidth** | [**Distance**](Distance.md) |  | [optional] 
**SpecialProductType** | **string** | Special product type (USPS Media Mail) | [optional] 
**TrackInventory** | **bool** | Track inventory | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

