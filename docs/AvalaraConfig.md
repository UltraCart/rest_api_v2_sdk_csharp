# com.ultracart.admin.v2.Model.AvalaraConfig
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | Avalara account ID | [optional] 
**Active** | **bool?** | True if Avalara is active for this merchant | [optional] 
**AvalaraOid** | **int?** | Unique identifier for this avalara config object | [optional] 
**CompanyId** | **string** | Avalara company ID | [optional] 
**EnableUpc** | **bool?** | True if this Avalara configuration is set to enable tax valuation by UPC | [optional] 
**EstimateOnly** | **bool?** | True if this Avalara configuration is to estimate taxes only and not report placed orders to Avalara | [optional] 
**GuestCustomerCode** | **string** | Optional customer code for customers without profiles, defaults to GuestCustomer | [optional] 
**LastTestDts** | **string** | Date/time of the connection test to Avalara | [optional] 
**LicenseKey** | **string** | Avalara license key | [optional] 
**Sandbox** | **bool?** | True if this Avalara instance is pointed at the Avalara Sandbox | [optional] 
**SendTestOrders** | **bool?** | Send test orders through to Avalara.  The default is to not transmit test orders to Avalara. | [optional] 
**ServiceUrl** | **string** | Avalara service URL | [optional] 
**TestResults** | **string** | Test results of the last connection test to Avalara | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

