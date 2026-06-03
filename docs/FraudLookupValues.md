
# com.ultracart.admin.v2.Model.FraudLookupValues

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Affiliates** | [**List&lt;FraudLookupAffiliate&gt;**](FraudLookupAffiliate.md) | Affiliates with non-empty email, sorted by email. | [optional] 
**AvsMatchTypes** | **List&lt;string&gt;** | Valid values for avs_match_type on the &#39;address street and zip avs&#39; rule type. | [optional] 
**Countries** | **List&lt;string&gt;** | ISO country codes available to this merchant. | [optional] 
**FailureActions** | **List&lt;string&gt;** | Valid values for failure_action on insert and search requests. | [optional] 
**IpRangeTypes** | **List&lt;string&gt;** | Valid values for ip_range_type on IP-based rules. | [optional] 
**LinkedAccounts** | **bool** | True when this merchant has at least one linked merchant account. | [optional] 
**RotatingTransactionGateways** | [**List&lt;FraudLookupGateway&gt;**](FraudLookupGateway.md) | Rotating transaction gateways configured for this merchant. Use the oid as a value in rotating_transaction_gateway_filters on insert. | [optional] 
**RuleGroups** | **List&lt;string&gt;** | Valid values for rule_group on search requests. | [optional] 
**RuleTypes** | **List&lt;string&gt;** | Valid values for rule_type on insert and search requests. | [optional] 
**ScreenBrandingThemes** | [**List&lt;FraudLookupTheme&gt;**](FraudLookupTheme.md) | Screen branding themes configured for this merchant. Use the oid as a value in screen_branding_theme_filters on insert. | [optional] 
**UserActions** | **List&lt;string&gt;** | Valid values for user_action on rule types that distinguish between attempted and approved transactions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

