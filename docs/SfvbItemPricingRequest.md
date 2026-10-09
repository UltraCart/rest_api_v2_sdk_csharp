
# com.ultracart.admin.v2.Model.SfvbItemPricingRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClearMsrp** | **bool** | True to remove the MSRP.  Not with msrp. | [optional] 
**ClearSale** | **bool** | True to remove the sale.  Not with sale_cost. | [optional] 
**Cost** | **decimal** | The new price, 0 or more. | [optional] 
**Msrp** | **decimal** | The manufacturer suggested retail price, more than 0 (or 0 when the price is 0). | [optional] 
**SaleCost** | **decimal** | The sale price, 0 or more.  Sent with sale_start and sale_end, all three or none. | [optional] 
**SaleEnd** | **string** | When the sale ends, ISO 8601 with an offset, after sale_start.  Required with sale_cost. | [optional] 
**SaleStart** | **string** | When the sale starts, ISO 8601 with an offset.  Required with sale_cost. | [optional] 
**VolumeDiscounts** | [**List&lt;SfvbItemVolumeDiscount&gt;**](SfvbItemVolumeDiscount.md) | Replaces the retail quantity breaks.  An empty list removes them all.  Up to 20, each quantity 2 or more and named once. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

