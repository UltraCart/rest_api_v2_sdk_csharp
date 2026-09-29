
# com.ultracart.admin.v2.Model.TaxCloudConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiKey** | **string** | TaxCloud API key | [optional] 
**ConnectionId** | **string** | TaxCloud Connection ID (a UUID) identifying the TaxCloud connection to use; a test connection and a production connection have different IDs | [optional] 
**DefaultTic** | **string** | Default TaxCloud TIC (Taxability Information Code), used for items that do not have their own TIC; blank lets TaxCloud apply its default (0, general goods) | [optional] 
**EstimateOnly** | **bool** | True if this TaxCloud configuration is to estimate taxes only and not report placed orders to TaxCloud | [optional] 
**LastTestDts** | **string** | Date/time of the connection test to TaxCloud | [optional] 
**ShippingTic** | **string** | TaxCloud TIC used to classify shipping/handling charges (11000 &#x3D; shipping and handling); blank means shipping is not taxed | [optional] 
**TestResults** | **string** | Test results of the last connection test to TaxCloud | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

