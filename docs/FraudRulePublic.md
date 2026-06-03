
# com.ultracart.admin.v2.Model.FraudRulePublic

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AffiliateOid** | **int** | Affiliate oid for the &#39;affiliate matches&#39; rule type. | [optional] 
**AmountThreshold** | **decimal** | Monetary or score threshold for amount/score/percentage rule types. | [optional] 
**AutoNote** | **string** | Note automatically appended to the order&#39;s merchant note when this rule fires. | [optional] 
**AvsMatchType** | **string** |  | [optional] 
**AvsResponseCodes** | **string** | AVS response codes for the &#39;address street and zip avs&#39; rule type. | [optional] 
**CardNumber** | **string** | Masked credit card number for rules tied to a specific card | [optional] 
**CountThreshold** | **int** | Integer count threshold for count/quantity/hours rule types. | [optional] 
**CountryCode** | **string** | ISO country code for the &#39;address not in country&#39; rule type. | [optional] 
**CreatedBy** | **string** |  | [optional] 
**CreatedDts** | **string** | Created date | [optional] 
**CreditCardBins** | **List&lt;string&gt;** | Credit card BINs blocked by the &#39;credit card block bin&#39; rule type. | [optional] 
**DeclineMessage** | **string** | Message shown in the A/R review screen when this rule fires. | [optional] 
**Description** | **string** | Human-readable description of the rule | [optional] 
**DescriptionHtml** | **string** | HTML version of the rule description | [optional] 
**Email** | **string** | Email address for the &#39;address email&#39; rule type. | [optional] 
**FailureAction** | **string** | Action taken when this rule fires. | [optional] 
**FraudRuleOid** | **int** | UltraCart unique identifier for this fraud rule | [optional] 
**GatewayResponseCodes** | **string** | Gateway response code key for the &#39;gateway response&#39; rule type. | [optional] 
**GatewayResponseValue** | **string** | Gateway response code value for the &#39;gateway response&#39; rule type. | [optional] 
**IpAddress** | **string** | IP address or subnet for &#39;exempt ip&#39; and &#39;ip matches&#39; rule types. | [optional] 
**IpRangeType** | **string** |  | [optional] 
**ItemFilters** | [**List&lt;FraudRuleItemFilter&gt;**](FraudRuleItemFilter.md) | Item filters restricting this rule to orders containing one or more of these items. | [optional] 
**MerchantItemId** | **string** | Merchant item id for the &#39;item matches&#39; rule type. | [optional] 
**ModifyCustomField1** | **string** | Value the rule sets on order custom field 1 (only meaningful for &#39;Process Payment and Modify&#39;). | [optional] 
**ModifyCustomField2** | **string** | Value the rule sets on order custom field 2 (only meaningful for &#39;Process Payment and Modify&#39;). | [optional] 
**ModifyCustomField3** | **string** | Value the rule sets on order custom field 3 (only meaningful for &#39;Process Payment and Modify&#39;). | [optional] 
**ModifyCustomField4** | **string** | Value the rule sets on order custom field 4 (only meaningful for &#39;Process Payment and Modify&#39;). | [optional] 
**ModifyCustomField5** | **string** | Value the rule sets on order custom field 5 (only meaningful for &#39;Process Payment and Modify&#39;). | [optional] 
**ModifyCustomField6** | **string** | Value the rule sets on order custom field 6 (only meaningful for &#39;Process Payment and Modify&#39;). | [optional] 
**ModifyCustomField7** | **string** | Value the rule sets on order custom field 7 (only meaningful for &#39;Process Payment and Modify&#39;). | [optional] 
**ModifySkipAffiliate** | **bool** | When true, the rule strips the affiliate from the order (only meaningful for &#39;Process Payment and Modify&#39;). | [optional] 
**ModifySkipAffiliateNetworkPixel** | **bool** | When true, the rule suppresses the affiliate network pixel (only meaningful for &#39;Process Payment and Modify&#39;). | [optional] 
**RotatingTransactionGatewayFilters** | [**List&lt;FraudRuleRotatingTransactionGatewayFilter&gt;**](FraudRuleRotatingTransactionGatewayFilter.md) | Gateway filters restricting this rule to orders processed by one of these rotating transaction gateways. | [optional] 
**RuleGroup** | **string** | Group containing this rule type (eg &#39;creditCardRules&#39;). Deliberately not constrained by allowableValues on the response so SDK consumers do not hard-fail on an unexpected value if a future rule_type slips through the server-side mapping. Search REQUESTS still restrict rule_group to the known set. | [optional] 
**RuleType** | **string** | Rule type. | [optional] 
**StorefrontFilters** | [**List&lt;FraudRuleStorefrontFilter&gt;**](FraudRuleStorefrontFilter.md) | Storefront filters restricting this rule to orders placed on one of these storefronts. | [optional] 
**UserAction** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

