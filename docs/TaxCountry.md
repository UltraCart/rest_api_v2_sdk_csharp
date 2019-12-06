# com.ultracart.admin.v2.Model.TaxCountry
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountingCode** | **string** | Accounting code for programs such as QuickBooks | [optional] 
**CountryCode** | **string** | Country code (2 characters | [optional] 
**CountryOid** | **int?** | Tax record object identifier used internally by database | [optional] 
**States** | [**List&lt;TaxState&gt;**](TaxState.md) | States (or regions or territories) within this country | [optional] 
**TaxGiftCharge** | **bool?** | True if taxation within this jurisdiction should charge tax on gift charge | [optional] 
**TaxGiftWrap** | **bool?** | True if taxation within this jurisdiction should charge tax on gift wrap | [optional] 
**TaxRate** | **decimal?** | Tax Rate | [optional] 
**TaxRateFormatted** | **string** | Tax rate formatted | [optional] 
**TaxShipping** | **bool?** | True if taxation within this jurisdiction should charge tax on shipping | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

