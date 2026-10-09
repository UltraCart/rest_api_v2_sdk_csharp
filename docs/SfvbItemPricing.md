
# com.ultracart.admin.v2.Model.SfvbItemPricing

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cost** | **decimal** | The price. | [optional] 
**CurrencyCode** | **string** | The currency every amount is in.  Read only here. | [optional] 
**HashSha256** | **string** | The hash of the pricing above.  Send it as If-Match to change it. | [optional] 
**MerchantItemId** | **string** | The item&#39;s merchant item id. | [optional] 
**MerchantItemOid** | **int** | The item. | [optional] 
**Msrp** | **decimal** | The manufacturer suggested retail price, when set. | [optional] 
**SaleActive** | **bool** | Whether the sale price applies right now. | [optional] 
**SaleCost** | **decimal** | The sale price, when a sale is set. | [optional] 
**SaleEnd** | **string** | When the sale ends, ISO 8601. | [optional] 
**SaleStart** | **string** | When the sale starts, ISO 8601. | [optional] 
**VolumeDiscounts** | [**List&lt;SfvbItemVolumeDiscount&gt;**](SfvbItemVolumeDiscount.md) | Retail quantity breaks, lowest quantity first.  Wholesale pricing tiers are not shown or changed here. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

