
# com.ultracart.admin.v2.Model.FraudRuleInsertRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AffiliateEmail** | **string** | Affiliate email. Used by the &#39;affiliate matches&#39; rule type when affiliate_oid is not supplied. | [optional] 
**AffiliateOid** | **int** | Affiliate OID. Used by the &#39;affiliate matches&#39; rule type. If omitted, affiliate_email is required. | [optional] 
**AmountThreshold** | **decimal** | Monetary or score threshold. Used by *transaction amount exceeds*, *fraud score exceeds*, and *decline percentage exceeds* rules. | [optional] 
**AutoNote** | **string** | Note automatically appended to the order&#39;s merchant note when this rule fires. | [optional] 
**AvsMatchType** | **string** | AVS match type for the zip portion. Used by the &#39;address street and zip avs&#39; rule type. | [optional] 
**AvsResponseCodes** | **string** | AVS response codes (street). Used by the &#39;address street and zip avs&#39; rule type. | [optional] 
**CountThreshold** | **int** | Integer count threshold. Used by *count exceeds*, *change number*, *quantity exceeds*, and *purchased within last hours* rules. | [optional] 
**CountryCode** | **string** | ISO country code. Used by the &#39;address not in country&#39; rule type. | [optional] 
**CreditCardBins** | **List&lt;string&gt;** | Credit card BINs to block (max 20). Used by the &#39;credit card block bin&#39; rule type. | [optional] 
**Email** | **string** | Email address. Used by the &#39;address email&#39; rule type. | [optional] 
**FailureAction** | **string** | Action to take when this rule fires. | [optional] 
**GatewayResponseCodes** | **string** | Gateway response code key. Used by the &#39;gateway response&#39; rule type. | [optional] 
**GatewayResponseValue** | **string** | Gateway response code value. Used by the &#39;gateway response&#39; rule type. | [optional] 
**IpAddress** | **string** | IP address or subnet (eg &#39;192.168.1.1&#39; or &#39;10.0.0.0/8&#39;). Used by &#39;exempt ip&#39; and &#39;ip matches&#39; rules. | [optional] 
**IpRangeType** | **string** | Specifies whether an IP rule applies to a single address or a subnet. | [optional] 
**ItemFilters** | **List&lt;string&gt;** | Optional list of merchant item ids restricting this rule to orders containing one or more of these items. | [optional] 
**MerchantItemId** | **string** | Merchant item id. Used by the &#39;item matches&#39; rule type. | [optional] 
**ModifyCustomField1** | **string** | When failure_action is &#39;Process Payment and Modify&#39;, set order custom field 1 to this value. | [optional] 
**ModifyCustomField2** | **string** | When failure_action is &#39;Process Payment and Modify&#39;, set order custom field 2 to this value. | [optional] 
**ModifyCustomField3** | **string** | When failure_action is &#39;Process Payment and Modify&#39;, set order custom field 3 to this value. | [optional] 
**ModifyCustomField4** | **string** | When failure_action is &#39;Process Payment and Modify&#39;, set order custom field 4 to this value. | [optional] 
**ModifyCustomField5** | **string** | When failure_action is &#39;Process Payment and Modify&#39;, set order custom field 5 to this value. | [optional] 
**ModifyCustomField6** | **string** | When failure_action is &#39;Process Payment and Modify&#39;, set order custom field 6 to this value. | [optional] 
**ModifyCustomField7** | **string** | When failure_action is &#39;Process Payment and Modify&#39;, set order custom field 7 to this value. | [optional] 
**ModifySkipAffiliate** | **bool** | When failure_action is &#39;Process Payment and Modify&#39;, strip the affiliate from the order. | [optional] 
**ModifySkipAffiliateNetworkPixel** | **bool** | When failure_action is &#39;Process Payment and Modify&#39;, skip firing the affiliate network pixel. | [optional] 
**RotatingTransactionGatewayFilters** | **List&lt;int&gt;** | Optional list of rotating transaction gateway oids restricting this rule to orders processed by one of these gateways. | [optional] 
**RuleType** | **string** | Rule type. Also returned by GET /v2/fraud/lookup_values. | [optional] 
**ScreenBrandingThemeFilters** | **List&lt;int&gt;** | Optional list of screen branding theme oids restricting this rule to orders associated with one or more storefronts. | [optional] 
**UserAction** | **string** | Only used by rule types that distinguish between attempted and approved transactions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

