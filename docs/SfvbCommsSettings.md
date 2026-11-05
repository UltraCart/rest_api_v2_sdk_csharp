
# com.ultracart.admin.v2.Model.SfvbCommsSettings

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HashSha256** | **string** | The hash of the settings.  Send it as If-Match to change them. | [optional] 
**MachineOpenIgnore** | **bool** | True when opens by mail privacy proxies are ignored.  Account-wide; changed in the admin. | [optional] 
**MarketingSender** | [**SfvbCommsSender**](SfvbCommsSender.md) |  | [optional] 
**PostcardReturnAddress** | [**SfvbPostcardAddress**](SfvbPostcardAddress.md) |  | [optional] 
**PostcardReturnAddressComplete** | **bool** | True when the name, street, city, state and postal code are all set.  Until then postcards fall back as the send code does. | [optional] 
**ReviewsIoConfigured** | **bool** | True when a Reviews.io key is set for the account. | [optional] 
**SmsPhoneNumber** | **string** | The default SMS number the admin offers for a new flow or campaign.  No send reads it.  An SMS step sends from its flow&#39;s or campaign&#39;s own number. | [optional] 
**SmsTwilioUuid** | **string** | The Twilio account that holds sms_phone_number. | [optional] 
**TransactionalSender** | [**SfvbCommsSender**](SfvbCommsSender.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

