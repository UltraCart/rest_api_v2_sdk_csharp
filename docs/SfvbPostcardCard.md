
# com.ultracart.admin.v2.Model.SfvbPostcardCard

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConversionDts** | **string** | When the customer ordered after it. | [optional] 
**Cost** | **decimal** | What the account is billed for this card. | [optional] 
**CustomerUuid** | **string** | The customer it was mailed to. | [optional] 
**DeliveredDts** | **string** | When it was delivered. | [optional] 
**From** | [**SfvbPostcardAddress**](SfvbPostcardAddress.md) |  | [optional] 
**MailedDts** | **string** | When it was mailed. | [optional] 
**OrderId** | **string** | The order it converted to. | [optional] 
**PrintRecordUuid** | **string** | The print vendor&#39;s record for this card. | [optional] 
**Status** | **string** | The vendor&#39;s latest status. | [optional] 
**SubmitDts** | **string** | When it was sent to the printer. | [optional] 
**To** | [**SfvbPostcardAddress**](SfvbPostcardAddress.md) |  | [optional] 
**TrackingDescription** | **string** | The vendor&#39;s own words for the latest status.  Only when customer data was asked for, since it can name where the card went. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

