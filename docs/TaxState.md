
# com.ultracart.admin.v2.Model.TaxState

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountingCode** | **string** | Accounting code for programs such as QuickBooks | [optional] 
**Counties** | [**List&lt;TaxCounty&gt;**](TaxCounty.md) | Counties within this state | [optional] 
**CountryOid** | **int** | Tax record object identifier used internally by database | [optional] 
**DontCollectCity** | **bool** | Flag instructing engine to not collect city tax for this state | [optional] 
**DontCollectCounty** | **bool** | Flag instructing engine to not collect county tax for this state | [optional] 
**DontCollectPostalCode** | **bool** | Flag instructing engine to not collect postal code tax for this state | [optional] 
**DontCollectState** | **bool** | Flag instructing engine to not collect state tax for this state | [optional] 
**ExemptDigitalItems** | **bool** | True if digital items are exempt from sales tax in this state. | [optional] 
**ExemptPhysicalItems** | **bool** | True if physical items are exempt from sales tax in this state. | [optional] 
**ExemptServiceItems** | **bool** | True if service items are exempt from sales tax in this state. | [optional] 
**StateCode** | **string** | State code | [optional] 
**StateOid** | **int** | Tax record object identifier used internally by database | [optional] 
**TaxGiftCharge** | **bool** | True if taxation within this jurisdiction should charge tax on gift charge | [optional] 
**TaxGiftWrap** | **bool** | True if taxation within this jurisdiction should charge tax on gift wrap | [optional] 
**TaxRate** | **decimal** | Tax Rate | [optional] 
**TaxRateFormatted** | **string** | Tax rate formatted | [optional] 
**TaxShipping** | **bool** | True if taxation within this jurisdiction should charge tax on shipping | [optional] 
**UseUltracartManagedRates** | **bool** | If true, use UltraCart managed rates for this state | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

