
# com.ultracart.admin.v2.Model.SfvbCampaign

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CampaignUuid** | **string** | The campaign uuid. | [optional] 
**CommunicationSequenceUuid** | **string** | The communication sequence the steps belong to. | [optional] 
**CreatedDts** | **string** | When the campaign was created (ISO 8601, UTC). | [optional] 
**Deleted** | **bool** | True when the campaign was deleted. | [optional] 
**Emails** | [**List&lt;SfvbCommsEmail&gt;**](SfvbCommsEmail.md) | Its emails, in step order. | [optional] 
**Live** | **bool** | True when the emails and postcards reach customers now, so a change to one shows at once.  False only in a status that sends nothing. | [optional] 
**Name** | **string** | The campaign name. | [optional] 
**Postcards** | [**List&lt;SfvbCommsPostcard&gt;**](SfvbCommsPostcard.md) | Its postcards, in step order. | [optional] 
**ScheduledDts** | **string** | When the campaign is scheduled to send (ISO 8601, UTC), when it is. | [optional] 
**Status** | **string** | The status, such as draft, scheduled, sending, sent or archived. | [optional] 
**StatusDts** | **string** | When the status last changed (ISO 8601, UTC). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

