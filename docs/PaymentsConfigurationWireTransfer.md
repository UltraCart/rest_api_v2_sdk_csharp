# com.ultracart.admin.v2.Model.PaymentsConfigurationWireTransfer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcceptWireTransfer** | **bool?** | Master flag indicating this merchant accepts wire transfers | [optional] 
**AccountNumber** | **string** | account_number | [optional] 
**AccountingCode** | **string** | Optional Quickbooks accounting code | [optional] 
**BankAddress** | **string** | Bank address | [optional] 
**DepositToAccount** | **string** | Optional Quickbooks deposit to account | [optional] 
**IntermediateRoutingNumber** | **string** | Intermediate routing number | [optional] 
**Restrictions** | [**PaymentsConfigurationRestrictions**](PaymentsConfigurationRestrictions.md) |  | [optional] 
**RoutingNumber** | **string** | Routing number | [optional] 
**SurchargeAccountingCode** | **string** | If a surcharge is present and this merchant is integrated with Quickbooks, this is the accounting code for the surcharge amount | [optional] 
**SurchargeFee** | **string** | surcharge_fee | [optional] 
**SurchargePercentage** | **string** | surcharge_percentage | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

