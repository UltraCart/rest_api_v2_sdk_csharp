
# com.ultracart.admin.v2.Model.TaxJarConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** | True if TaxJar is active for this merchant | [optional] 
**ApiKey** | **string** | TaxJar API key | [optional] 
**EstimateOnly** | **bool** | True if this TaxJar configuration is to estimate taxes only and not report placed orders to TaxJar | [optional] 
**SendOutsideNexus** | **bool** | Send orders outside your nexus TaxJar.  The default is to not transmit outside orders to TaxJar to reduce API calls.  However, this will prevent TaxJar from dynamically creating new Nexus when thresholds are exceeded for a state. | [optional] 
**SendTestOrders** | **bool** | Send test orders through to TaxJar.  The default is to not transmit test orders to TaxJar. | [optional] 
**SkipCalculationOutsideNexus** | **bool** | Only calculate tax for states within your nexus.  Requires send_outside_nexus to be true.  When true, orders outside your nexus are still transmitted to TaxJar for nexus tracking, but no tax calculation is requested for them, reducing API calls. | [optional] 
**SkipChannelOrders** | **bool** | Do not send channel partner orders to TaxJar.  Set this to true if your channel partner reports tax on their own. | [optional] 
**UseDistributionCenterFrom** | **bool** | Use distribution center from address | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

