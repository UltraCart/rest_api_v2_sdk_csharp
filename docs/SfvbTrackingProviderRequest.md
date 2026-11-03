
# com.ultracart.admin.v2.Model.SfvbTrackingProviderRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcceptCost** | **bool** | True to accept the cost of turning on Google Tag Gateway.  Required to turn it on. | [optional] 
**Consent** | [**SfvbTrackingProviderConsent**](SfvbTrackingProviderConsent.md) |  | [optional] 
**DryRun** | **bool** | True to check the change and report it without saving. | [optional] 
**Events** | **Object** | Standard events by name, true to send. | [optional] 
**Fields** | **Object** | Plain field values by key.  An empty string clears one.  Booleans are true or false.  Secrets go in secrets instead. | [optional] 
**Secrets** | [**SfvbTrackingProviderSecrets**](SfvbTrackingProviderSecrets.md) |  | [optional] 
**Unset** | **List&lt;string&gt;** | Plain field keys to clear. | [optional] 
**WholesaleTiers** | [**List&lt;SfvbTrackingWholesaleTier&gt;**](SfvbTrackingWholesaleTier.md) | For google_analytics, account numbers by pricing_tier_oid. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

