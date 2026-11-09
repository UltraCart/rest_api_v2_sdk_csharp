
# com.ultracart.admin.v2.Model.SfvbTrackingCheckPlanProvider

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Events** | [**List&lt;SfvbTrackingCheckPlanEvent&gt;**](SfvbTrackingCheckPlanEvent.md) | The dataLayer, gtag and fbq calls it makes, where the template makes them. | [optional] 
**Expect** | **string** | must_load, must_not_load (held back by a gate this consent state and region have not granted, or never sent for this event), or may_load (depends on something the plan cannot know).  A missing may_load request is a warning, never a fail. | [optional] 
**Gate** | [**SfvbTrackingCheckPlanGate**](SfvbTrackingCheckPlanGate.md) |  | [optional] 
**Name** | **string** | A name to show. | [optional] 
**Note** | **string** | Why the expectation is what it is, when that is not obvious. | [optional] 
**Provider** | **string** | The provider key, as tracking/providers names it.  For custom or affiliate network HTML, the host. | [optional] 
**Requests** | [**List&lt;SfvbTrackingCheckPlanRequest&gt;**](SfvbTrackingCheckPlanRequest.md) | The requests it makes. | [optional] 
**Source** | **string** | provider for a provider in the catalog, custom_html for the storefront Tracking or Conversion HTML, affiliate_network for an affiliate network pixel. | [optional] 
**Template** | **string** | The storefront template that writes it, tracking.vm or conversion.vm.  Left out for custom and affiliate network HTML. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

