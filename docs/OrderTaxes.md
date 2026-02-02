# com.ultracart.admin.v2.Model.OrderTaxes
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArbitraryTax** | **decimal?** | Arbitrary Tax, this is meaningless for updating an order.  For inserting a new order, this will override any internal tax calculations and should only be used for orders completed outside the system. | [optional] 
**ArbitraryTaxRate** | **decimal?** | Arbitrary tax rate, this is meaningless for updating an order.  For inserting a new order, this will override any internal tax calculations and should only be used for orders completed outside the system. | [optional] 
**ArbitraryTaxableSubtotal** | **decimal?** | Arbitrary taxable subtotal, this is meaningless for updating an order.  For inserting a new order, this will override any internal tax calculations and should only be used for orders completed outside the system. | [optional] 
**TaxCityAccountingCode** | **string** | QuickBooks tax city code | [optional] 
**TaxCountryAccountingCode** | **string** | QuickBooks tax country code | [optional] 
**TaxCounty** | **string** | County used for tax calculation purposes (only in the United States) | [optional] 
**TaxCountyAccountingCode** | **string** | QuickBooks tax county code | [optional] 
**TaxGiftCharge** | **bool?** | True if gift charge is taxed | [optional] 
**TaxPostalCodeAccountingCode** | **string** | QuickBooks tax postal code code | [optional] 
**TaxRate** | **decimal?** | Tax rate, this is meaningless for updating an order.  For inserting a new order, if you need to override internal tax calculations, use the arbitrary fields. | [optional] 
**TaxRateCity** | **decimal?** | Tax rate at the city level | [optional] 
**TaxRateCountry** | **decimal?** | Tax rate at the country level | [optional] 
**TaxRateCounty** | **decimal?** | Tax rate at the county level | [optional] 
**TaxRatePostalCode** | **decimal?** | Tax rate at the postal code level | [optional] 
**TaxRateState** | **decimal?** | Tax rate at the state level | [optional] 
**TaxShipping** | **bool?** | True if shipping is taxed | [optional] 
**TaxStateAccountingCode** | **string** | QuickBooks tax state code | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

