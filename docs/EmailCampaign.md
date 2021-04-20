# com.ultracart.admin.v2.Model.EmailCampaign
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClickRateFormatted** | **string** | Click rate of emails | [optional] 
**CreatedDts** | **string** | Created date | [optional] 
**Deleted** | **bool?** | True if this campaign was deleted | [optional] 
**EmailCampaignUuid** | **string** | Email campaign UUID | [optional] 
**EmailCommunicationSequenceUuid** | **string** | Email communication sequence UUID | [optional] 
**EndOnceCustomerPurchases** | **bool?** | True if the customer should end the flow once they purchase from this campaign | [optional] 
**EndOnceCustomerPurchasesAnywhere** | **bool?** | True if the customer should end the flow once they purchase from anywhere | [optional] 
**EspCampaignFolderUuid** | **string** | Campaign folder UUID.  Null for uncategorized | [optional] 
**EspDomainUser** | **string** | User of the sending address | [optional] 
**EspDomainUuid** | **string** | UUID of the sending domain | [optional] 
**EspFriendlyName** | **string** | Friendly name of the sending email | [optional] 
**LibraryItemOid** | **int?** | If this item was ever added to the Code Library, this is the oid for that library item, or 0 if never added before.  This value is used to determine if a library item should be inserted or updated. | [optional] 
**Memberships** | [**List&lt;EmailListSegmentMembership&gt;**](EmailListSegmentMembership.md) | List and segment memberships | [optional] 
**MerchantId** | **string** | Merchant ID | [optional] 
**Name** | **string** | Name of email campaign | [optional] 
**OpenRateFormatted** | **string** | Open rate of emails | [optional] 
**PreventSendingDueToSpam** | **bool?** | True if this campaign is prevented from sending at this time due to spam complaints. | [optional] 
**RevenueFormatted** | **string** | Revenue associated with campaign | [optional] 
**RevenuePerCustomerFormatted** | **string** | Revenue per customer associated with campaign | [optional] 
**ScheduledDts** | **string** | Scheduled date | [optional] 
**ScreenshotLargeFullUrl** | **string** | URL to a large full length screenshot | [optional] 
**Status** | **string** | Status of the campaign of draft, archived, and sent | [optional] 
**StatusDts** | **string** | Timestamp when the last status change happened | [optional] 
**StorefrontOid** | **int?** | Storefront oid | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

