# com.ultracart.admin.v2.Model.TaxCity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountingCode** | **string** | Accounting code for programs such as QuickBooks | [optional] 
**City** | **string** | City | [optional] 
**CityOid** | **int?** | Tax record object identifier used internally by database | [optional] 
**CountyOid** | **int?** | Tax record object identifier used internally by database | [optional] 
**DontCollectCity** | **bool?** | Flag instructing engine to not collect city tax for this city | [optional] 
**DontCollectPostalCode** | **bool?** | Flag instructing engine to not collect postal code tax for this city | [optional] 
**PostalCodes** | [**List&lt;TaxPostalCode&gt;**](TaxPostalCode.md) | Postal Codes within this city | [optional] 
**TaxRate** | **decimal?** | Tax Rate | [optional] 
**TaxRateFormatted** | **string** | Tax rate formatted | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

