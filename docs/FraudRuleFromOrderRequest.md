
# com.ultracart.admin.v2.Model.FraudRuleFromOrderRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoNote** | **string** | Note automatically appended to the order&#39;s merchant note when these rules fire. | [optional] 
**EstablishAddressFilter** | **bool** | Establish an &#39;address street and zip avs&#39; rule from the order&#39;s ship-to street and zip. | [optional] 
**EstablishCardFilter** | **bool** | Establish a &#39;credit card matches&#39; rule by duplicating the order&#39;s stored card vault token. Skipped if the order has no stored card. | [optional] 
**EstablishEmailFilter** | **bool** | Establish an &#39;address email&#39; rule from the order&#39;s email address. | [optional] 
**EstablishIpFilter** | **bool** | Establish an &#39;ip matches&#39; subnet rule from the order&#39;s customer IP address (last octet masked to a subnet). | [optional] 
**FailureAction** | **string** | Action to take when these rules fire. Defaults to &#39;Flag For Review&#39; when omitted. | [optional] 
**OrderId** | **string** | The order id to establish the fraud rule(s) from. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

