
# com.ultracart.admin.v2.Model.FraudRulePublic

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AffiliateOid** | **int** |  | [optional] 
**AmountThreshold** | **decimal** |  | [optional] 
**AutoNote** | **string** |  | [optional] 
**AvsMatchType** | **string** |  | [optional] 
**AvsResponseCodes** | **string** |  | [optional] 
**CardNumber** | **string** | Masked credit card number for rules tied to a specific card | [optional] 
**CountThreshold** | **int** |  | [optional] 
**CountryCode** | **string** |  | [optional] 
**CreatedBy** | **string** |  | [optional] 
**CreatedDts** | **string** | Created date | [optional] 
**CreditCardBins** | **Object** | Credit card BINs blocked by the &#39;credit card block bin&#39; rule type. | [optional] 
**DeclineMessage** | **string** |  | [optional] 
**Description** | **string** | Human-readable description of the rule | [optional] 
**DescriptionHtml** | **string** | HTML version of the rule description | [optional] 
**Email** | **string** |  | [optional] 
**FailureAction** | **string** | Action taken when this rule fires. | [optional] 
**FraudRuleOid** | **int** | UltraCart unique identifier for this fraud rule | [optional] 
**GatewayResponseCodes** | **string** |  | [optional] 
**GatewayResponseValue** | **string** |  | [optional] 
**IpAddress** | **string** |  | [optional] 
**IpRangeType** | **string** |  | [optional] 
**ItemFilters** | [**List&lt;FraudRuleItemFilter&gt;**](FraudRuleItemFilter.md) |  | [optional] 
**MerchantItemId** | **string** |  | [optional] 
**ModifyCustomField1** | **string** |  | [optional] 
**ModifyCustomField2** | **string** |  | [optional] 
**ModifyCustomField3** | **string** |  | [optional] 
**ModifyCustomField4** | **string** |  | [optional] 
**ModifyCustomField5** | **string** |  | [optional] 
**ModifyCustomField6** | **string** |  | [optional] 
**ModifyCustomField7** | **string** |  | [optional] 
**ModifySkipAffiliate** | **bool** |  | [optional] 
**ModifySkipAffiliateNetworkPixel** | **bool** |  | [optional] 
**RotatingTransactionGatewayFilters** | [**List&lt;FraudRuleRotatingTransactionGatewayFilter&gt;**](FraudRuleRotatingTransactionGatewayFilter.md) |  | [optional] 
**RuleGroup** | **string** | Group containing this rule type (eg &#39;creditCardRules&#39;). Deliberately not constrained by allowableValues on the response so SDK consumers do not hard-fail on an unexpected value if a future rule_type slips through the server-side mapping. Search REQUESTS still restrict rule_group to the known set. | [optional] 
**RuleType** | **string** | Rule type. | [optional] 
**StorefrontFilters** | [**List&lt;FraudRuleStorefrontFilter&gt;**](FraudRuleStorefrontFilter.md) |  | [optional] 
**UserAction** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

