# com.ultracart.admin.v2.Model.OrderFraudScore
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnonymousProxy** | **bool?** | True if the IP address is a known anonymous proxy server | [optional] 
**BinMatch** | **string** | Whether the BIN (first six digits) matched the country | [optional] 
**CarderEmail** | **bool?** | True if the email address belongs to a known credit card fraudster | [optional] 
**CountryCode** | **string** | Country code | [optional] 
**CountryMatch** | **bool?** | Country code matches BIN country | [optional] 
**CustomerPhoneInBillingLocation** | **string** | Whether the customer&#39;s phone number is located in the area of the billing address | [optional] 
**DistanceKm** | **int?** | Distance in kilometers between the IP address and the BIN | [optional] 
**FreeEmail** | **bool?** | True if the email address is for a free service like gmail.com | [optional] 
**HighRiskCountry** | **bool?** | True if the customer is in a high risk country known for internet fraud | [optional] 
**IpCity** | **string** | City associated with the IP address | [optional] 
**IpIsp** | **string** | ISP that owns the IP address | [optional] 
**IpLatitude** | **string** | Approximate latitude associated with the IP address | [optional] 
**IpLongitude** | **string** | Approximate longitude associated with the IP address | [optional] 
**IpOrg** | **string** | Organization that owns the IP address | [optional] 
**IpRegion** | **string** | State/region associated with the IP address | [optional] 
**ProxyScore** | **decimal?** | Likelihood of the IP address being a proxy server | [optional] 
**Score** | **decimal?** | Overall score.  This is the score that is compared to see if the order is rejected or held for review by the fraud filter rules. | [optional] 
**ShipForwarder** | **bool?** | True if the address is a known ship forwarding company | [optional] 
**SpamScore** | **decimal?** | Likelihood of the email address being associated with a spammer | [optional] 
**TransparentProxy** | **bool?** | True if the IP address that placed the order is a transparent proxy server | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

