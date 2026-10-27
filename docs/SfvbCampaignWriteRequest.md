
# com.ultracart.admin.v2.Model.SfvbCampaignWriteRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndOnceCustomerPurchases** | **bool** | True to end the campaign for a customer once they buy from one of its emails. | [optional] 
**EndOnceCustomerPurchasesAnywhere** | **bool** | True to end the campaign for a customer once they buy from any source. | [optional] 
**Memberships** | [**List&lt;SfvbCampaignMembership&gt;**](SfvbCampaignMembership.md) | The lists and segments it sends to or leaves out.  Replaces the whole set.  An empty array clears it. | [optional] 
**Name** | **string** | The campaign name, 1 to 250 characters.  Required to create. | [optional] 
**ScheduledDts** | **string** | When to send once started (ISO 8601).  An empty string clears the schedule. | [optional] 
**SendingDomainUuid** | **string** | The sending domain uuid.  Defaults to the storefront&#39;s marketing sending domain. | [optional] 
**SendingName** | **string** | The from name.  Defaults to the storefront&#39;s marketing setting. | [optional] 
**SendingUser** | **string** | The part of the from address before the at sign.  Defaults to the storefront&#39;s marketing setting. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

