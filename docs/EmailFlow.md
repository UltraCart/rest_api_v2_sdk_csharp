
# com.ultracart.admin.v2.Model.EmailFlow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowMultipleConcurrentEnrollments** | **bool** | True if a customer may be enrolled in this flow multiple times | [optional] 
**BackPopulating** | **bool** | True if the flow is currently performing a back population. | [optional] 
**ClickRateFormatted** | **string** | Click rate of emails, formatted | [optional] 
**CreatedDts** | **string** | Created date | [optional] 
**Deleted** | **bool** | True if this campaign was deleted | [optional] 
**EmailCommunicationSequenceUuid** | **string** | Email communication sequence UUID | [optional] 
**EmailFlowUuid** | **string** | Email flow UUID | [optional] 
**EndOnceCustomerPurchases** | **bool** | True if the customer should end the flow once they purchase from an email on this flow | [optional] 
**EndOnceCustomerPurchasesAnywhere** | **bool** | True if the customer should end the flow once they purchase from any source | [optional] 
**EnrolledCustomers** | **int** | Number of enrolled customers. | [optional] 
**EspDomainUser** | **string** | Username of sending email | [optional] 
**EspDomainUuid** | **string** | UUID of sending domain | [optional] 
**EspFlowFolderUuid** | **string** | Flow folder UUID.  Null for uncategorized | [optional] 
**EspFriendlyName** | **string** | Friendly name of the sending email | [optional] 
**FilterProfileEquationJson** | **string** | File profile equation json | [optional] 
**LibraryItemOid** | **int** | If this item was ever added to the Code Library, this is the oid for that library item, or 0 if never added before.  This value is used to determine if a library item should be inserted or updated. | [optional] 
**MaximumEnrolled** | **bool** | The number of maximum customers for the plan are currently enrolled in this flow. | [optional] 
**MerchantId** | **string** | Merchant ID | [optional] 
**Name** | **string** | Name of email flow | [optional] 
**OpenRateFormatted** | **string** | Open rate of emails, formatted | [optional] 
**RevenueFormatted** | **string** | Revenue, formatted | [optional] 
**RevenuePerCustomerFormatted** | **string** | Revenue per customer, formatted | [optional] 
**ScreenshotLargeFullUrl** | **string** | URL to a large full length screenshot | [optional] 
**SmsEspTwilioUuid** | **string** | Twilio Account UUID.  Null for none | [optional] 
**SmsPhoneNumber** | **string** | Twilio SMS Phone Number.  Null for none | [optional] 
**Status** | **string** | Status of the campaign of draft, archived, active, and inactive | [optional] 
**StatusDts** | **string** | Timestamp when the last status change happened | [optional] 
**StorefrontOid** | **int** | Storefront oid | [optional] 
**TriggerParameter** | **string** | Trigger parameter | [optional] 
**TriggerParameterName** | **string** | Trigger parameter name | [optional] 
**TriggerType** | **string** | Trigger type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

