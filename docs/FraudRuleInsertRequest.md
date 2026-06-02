
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
**CreditCardBins** | **Object** | Credit card BINs to block (max 20). Used by the &#39;credit card block bin&#39; rule type. | [optional] 
**Email** | **string** | Email address. Used by the &#39;address email&#39; rule type. | [optional] 
**FailureAction** | **string** | Action to take when this rule fires. | [optional] 
**GatewayResponseCodes** | **string** | Gateway response code key. Used by the &#39;gateway response&#39; rule type. | [optional] 
**GatewayResponseValue** | **string** | Gateway response code value. Used by the &#39;gateway response&#39; rule type. | [optional] 
**IpAddress** | **string** | IP address or subnet (eg &#39;192.168.1.1&#39; or &#39;10.0.0.0/8&#39;). Used by &#39;exempt ip&#39; and &#39;ip matches&#39; rules. | [optional] 
**IpRangeType** | **string** | Specifies whether an IP rule applies to a single address or a subnet. | [optional] 
**ItemFilters** | **Object** | Optional list of merchant item ids restricting this rule to orders containing one or more of these items. | [optional] 
**MerchantItemId** | **string** | Merchant item id. Used by the &#39;item matches&#39; rule type. | [optional] 
**ModifyCustomField1** | **string** |  | [optional] 
**ModifyCustomField2** | **string** |  | [optional] 
**ModifyCustomField3** | **string** |  | [optional] 
**ModifyCustomField4** | **string** |  | [optional] 
**ModifyCustomField5** | **string** |  | [optional] 
**ModifyCustomField6** | **string** |  | [optional] 
**ModifyCustomField7** | **string** |  | [optional] 
**ModifySkipAffiliate** | **bool** |  | [optional] 
**ModifySkipAffiliateNetworkPixel** | **bool** |  | [optional] 
**RotatingTransactionGatewayFilters** | **Object** | Optional list of rotating transaction gateway oids restricting this rule to orders processed by one of these gateways. | [optional] 
**RuleType** | **string** | Rule type. Also returned by GET /v2/fraud/lookup_values. | [optional] 
**ScreenBrandingThemeFilters** | **Object** | Optional list of screen branding theme oids restricting this rule to orders associated with one or more storefronts. | [optional] 
**UserAction** | **string** | Only used by rule types that distinguish between attempted and approved transactions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

