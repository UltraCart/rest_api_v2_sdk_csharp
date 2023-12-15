# com.ultracart.admin.v2.Model.OrderPaymentHealthBenefitCard
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HealthBenefitCardExpirationMonth** | **int?** | Health benefit card expiration month (1-12) | [optional] 
**HealthBenefitCardExpirationYear** | **int?** | Health benefit card expiration year (Four digit year) | [optional] 
**HealthBenefitCardNumber** | **string** | Health benefit card number (masked to last 4) | [optional] 
**HealthBenefitCardNumberToken** | **string** | Health benefit card number token from hosted fields used to update the health benefit card number | [optional] 
**HealthBenefitCardNumberTruncated** | **bool?** | True if the health benefit card has been truncated | [optional] 
**HealthBenefitCardVerificationNumberToken** | **string** | Health benefit card verification number token from hosted fields, only for import/insert of new orders, completely ignored for updates, and always null/empty for queries | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

