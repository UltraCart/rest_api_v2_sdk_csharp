
# com.ultracart.admin.v2.Model.SfvbCampaign

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CampaignUuid** | **string** | The campaign uuid. | [optional] 
**CommunicationSequenceUuid** | **string** | The communication sequence the steps belong to. | [optional] 
**CreatedDts** | **string** | When the campaign was created (ISO 8601, UTC). | [optional] 
**Deleted** | **bool** | True when the campaign was deleted. | [optional] 
**Emails** | [**List&lt;SfvbCommsEmail&gt;**](SfvbCommsEmail.md) | Its emails, in step order. | [optional] 
**EndOnceCustomerPurchases** | **bool** | True when a customer leaves the campaign once they buy from one of its emails. | [optional] 
**EndOnceCustomerPurchasesAnywhere** | **bool** | True when a customer leaves the campaign once they buy from any source. | [optional] 
**HashSha256** | **string** | Send this as If-Match when changing or archiving the campaign. | [optional] 
**Live** | **bool** | True when the emails and postcards reach customers now, so a change to one shows at once.  False only in a status that sends nothing. | [optional] 
**Memberships** | [**List&lt;SfvbCampaignMembership&gt;**](SfvbCampaignMembership.md) | The lists and segments it sends to or leaves out. | [optional] 
**Name** | **string** | The campaign name. | [optional] 
**Notes** | **List&lt;string&gt;** | What a write did beyond the fields it was asked to change, such as putting emails back to needing review or setting a scheduled campaign back to draft.  Only on a write. | [optional] 
**Postcards** | [**List&lt;SfvbCommsPostcard&gt;**](SfvbCommsPostcard.md) | Its postcards, in step order. | [optional] 
**ScheduledDts** | **string** | When the campaign is scheduled to send (ISO 8601, UTC), when it is. | [optional] 
**SendingDomainUuid** | **string** | The sending domain uuid.  Defaults to the storefront&#39;s marketing sending domain. | [optional] 
**SendingName** | **string** | The from name.  Defaults to the storefront&#39;s marketing setting. | [optional] 
**SendingUser** | **string** | The part of the from address before the at sign.  Defaults to the storefront&#39;s marketing setting. | [optional] 
**Status** | **string** | The status, such as draft, scheduled, sending, sent or archived. | [optional] 
**StatusDts** | **string** | When the status last changed (ISO 8601, UTC). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

