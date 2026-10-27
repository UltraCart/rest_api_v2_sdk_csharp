
# com.ultracart.admin.v2.Model.SfvbSequence

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CommunicationSequenceUuid** | **string** | The sequence uuid. | [optional] 
**Live** | **bool** | True when its emails and postcards reach customers now. | [optional] 
**Notes** | **List&lt;string&gt;** | Anything the read could not do, such as waiting counts that were unavailable. | [optional] 
**OwnerName** | **string** | The campaign or flow name. | [optional] 
**OwnerStatus** | **string** | The campaign or flow status. | [optional] 
**OwnerType** | **string** | campaign or flow. | [optional] 
**OwnerUuid** | **string** | The campaign or flow uuid. | [optional] 
**Steps** | [**List&lt;SfvbSequenceStep&gt;**](SfvbSequenceStep.md) | The steps from the start, in order.  A branching step holds its sides in branches. | [optional] 
**WaitingIncluded** | **bool** | True when number_waiting was filled in. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

