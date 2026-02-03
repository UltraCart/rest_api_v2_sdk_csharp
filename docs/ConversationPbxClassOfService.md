# com.ultracart.admin.v2.Model.ConversationPbxClassOfService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedCountries** | **List&lt;string&gt;** | E.164 country calling codes (e.g. 1 for US/Canada, 44 for UK). Empty means domestic only. | [optional] 
**BlockPremiumNumbers** | **bool?** | Block calls to 900, 976, premium-rate, and shortcode destinations | [optional] 
**ConversationPbxClassOfServiceUuid** | **string** | Class of Service unique identifier | [optional] 
**DefaultFlag** | **bool?** | If true, this CoS applies to all agents without an explicit cos_uuid. Only one per merchant. | [optional] 
**Description** | **string** | Description of the class of service | [optional] 
**MerchantId** | **string** | Merchant Id | [optional] 
**Name** | **string** | Display name for the class of service | [optional] 
**OutboundEnabled** | **bool?** | Whether agents with this CoS can make outbound calls | [optional] 
**TimeRangeUuid** | **string** | UUID of a time range. If set, outbound calls only permitted during those time windows. | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

