
# com.ultracart.admin.v2.Model.FraudRuleSearchRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AffiliateOidOrEmail** | **string** | Affiliate oid (integer) or affiliate email. Email is resolved to oid before searching. | [optional] 
**AmountThresholdBegin** | **decimal** | Lower bound on amount/score/percentage thresholds (rules backed by the same numeric column). | [optional] 
**AmountThresholdEnd** | **decimal** | Upper bound on amount/score/percentage thresholds (rules backed by the same numeric column). | [optional] 
**AutoNote** | **string** | Wildcard search on the rule&#39;s auto_note. Use &#39;*&#39; for wildcards. | [optional] 
**CountThresholdBegin** | **int** | Lower bound on count thresholds (rules backed by the same integer count column). | [optional] 
**CountThresholdEnd** | **int** | Upper bound on count thresholds (rules backed by the same integer count column). | [optional] 
**CreatedBy** | **string** | Filter to rules created by this user login. | [optional] 
**CreatedDateBegin** | **string** | Rule creation date begin (MM/dd/yyyy) | [optional] 
**CreatedDateEnd** | **string** | Rule creation date end (MM/dd/yyyy) | [optional] 
**CreditCardPartial** | **string** | Partial credit card number for matching &#39;credit card matches&#39; rules. Use &#39;*&#39; wildcards. | [optional] 
**DeclineMessage** | **string** | Wildcard search on the rule&#39;s decline_message. Use &#39;*&#39; for wildcards. | [optional] 
**FailureAction** | **string** |  | [optional] 
**GatewayCode** | **string** | Filter to rules with this rotating transaction gateway code in their rotating_transaction_gateway_filters list. | [optional] 
**MerchantItemId** | **string** | Filter to rules with this merchant item id in their item_filters list. | [optional] 
**ModifierValue** | **string** | Wildcard search on the rule&#39;s secondary modifier (eg &#39;address&#39;/&#39;subnet&#39;, gateway codes, avs match types). | [optional] 
**ModifyCustomField1** | **string** | Wildcard search on rules&#39; modify_custom_field1 value. | [optional] 
**ModifyCustomField2** | **string** | Wildcard search on rules&#39; modify_custom_field2 value. | [optional] 
**ModifyCustomField3** | **string** | Wildcard search on rules&#39; modify_custom_field3 value. | [optional] 
**ModifyCustomField4** | **string** | Wildcard search on rules&#39; modify_custom_field4 value. | [optional] 
**ModifyCustomField5** | **string** | Wildcard search on rules&#39; modify_custom_field5 value. | [optional] 
**ModifyCustomField6** | **string** | Wildcard search on rules&#39; modify_custom_field6 value. | [optional] 
**ModifyCustomField7** | **string** | Wildcard search on rules&#39; modify_custom_field7 value. | [optional] 
**ModifySkipAffiliate** | **bool** | Filter to rules whose modify_skip_affiliate flag matches this value. | [optional] 
**ModifySkipAffiliateNetworkPixel** | **bool** | Filter to rules whose modify_skip_affiliate_network_pixel flag matches this value. | [optional] 
**RuleGroup** | **string** | Rule group to filter by. | [optional] 
**RuleType** | **string** | Rule type to filter by. | [optional] 
**SearchLinkedAccounts** | **bool** | Include rules from accounts linked to this merchant. Defaults to false. | [optional] 
**StorefrontHostname** | **string** | Filter to rules with this storefront hostname in their screen_branding_theme_filters list. | [optional] 
**TextValue** | **string** | Wildcard search on the rule&#39;s text parameter (email / ip / bin / country / item id / avs codes - the backend disambiguates by rule_type). | [optional] 
**ThemeCode** | **string** | Filter to rules with this screen branding theme code in their screen_branding_theme_filters list. | [optional] 
**UserAction** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

