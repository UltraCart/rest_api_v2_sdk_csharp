# com.ultracart.admin.v2.Model.TaxCounty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountingCode** | **string** | Accounting code for programs such as QuickBooks | [optional] 
**Cities** | [**List&lt;TaxCity&gt;**](TaxCity.md) | Cities within this city | [optional] 
**County** | **string** | County | [optional] 
**CountyOid** | **int?** | Tax record object identifier used internally by database | [optional] 
**DontCollectCity** | **bool?** | Flag instructing engine to not collect city tax for this county | [optional] 
**DontCollectCounty** | **bool?** | Flag instructing engine to not collect county tax for this county | [optional] 
**DontCollectPostalCode** | **bool?** | Flag instructing engine to not collect postal code tax for this county | [optional] 
**StateOid** | **int?** | Tax record object identifier used internally by database | [optional] 
**TaxRate** | **decimal?** | Tax Rate | [optional] 
**TaxRateFormatted** | **string** | Tax rate formatted | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

