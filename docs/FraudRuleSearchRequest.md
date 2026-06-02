
# com.ultracart.admin.v2.Model.FraudRuleSearchRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AffiliateOidOrEmail** | **string** | Affiliate oid (integer) or affiliate email. Email is resolved to oid before searching. | [optional] 
**AmountThresholdBegin** | **decimal** | Lower bound on amount/score/percentage thresholds (rules backed by the same numeric column). | [optional] 
**AmountThresholdEnd** | **decimal** |  | [optional] 
**AutoNote** | **string** | Wildcard search on the rule&#39;s auto_note. Use &#39;*&#39; for wildcards. | [optional] 
**CountThresholdBegin** | **int** | Lower bound on count thresholds (rules backed by the same integer count column). | [optional] 
**CountThresholdEnd** | **int** |  | [optional] 
**CreatedBy** | **string** |  | [optional] 
**CreatedDateBegin** | **string** | Rule creation date begin (MM/dd/yyyy) | [optional] 
**CreatedDateEnd** | **string** | Rule creation date end (MM/dd/yyyy) | [optional] 
**CreditCardPartial** | **string** | Partial credit card number for matching &#39;credit card matches&#39; rules. Use &#39;*&#39; wildcards. | [optional] 
**DeclineMessage** | **string** | Wildcard search on the rule&#39;s decline_message. Use &#39;*&#39; for wildcards. | [optional] 
**FailureAction** | **string** |  | [optional] 
**GatewayCode** | **string** |  | [optional] 
**MerchantItemId** | **string** |  | [optional] 
**ModifierValue** | **string** | Wildcard search on the rule&#39;s secondary modifier (eg &#39;address&#39;/&#39;subnet&#39;, gateway codes, avs match types). | [optional] 
**ModifyCustomField1** | **string** |  | [optional] 
**ModifyCustomField2** | **string** |  | [optional] 
**ModifyCustomField3** | **string** |  | [optional] 
**ModifyCustomField4** | **string** |  | [optional] 
**ModifyCustomField5** | **string** |  | [optional] 
**ModifyCustomField6** | **string** |  | [optional] 
**ModifyCustomField7** | **string** |  | [optional] 
**ModifySkipAffiliate** | **bool** |  | [optional] 
**ModifySkipAffiliateNetworkPixel** | **bool** |  | [optional] 
**RuleGroup** | **string** | Rule group to filter by. | [optional] 
**RuleType** | **string** | Rule type to filter by. | [optional] 
**SearchLinkedAccounts** | **bool** | Include rules from accounts linked to this merchant. Defaults to false. | [optional] 
**StorefrontHostname** | **string** |  | [optional] 
**TextValue** | **string** | Wildcard search on the rule&#39;s text parameter (email / ip / bin / country / item id / avs codes - the backend disambiguates by rule_type). | [optional] 
**ThemeCode** | **string** |  | [optional] 
**UserAction** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

