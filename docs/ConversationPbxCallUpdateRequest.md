
# com.ultracart.admin.v2.Model.ConversationPbxCallUpdateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Finalize** | **bool** | True when the agent has finished after-call work (Save &amp; finish). Stamps notes_finalized_dts, which together with transcript availability gates Zoho Desk ticket creation. | [optional] 
**Notes** | **string** | Agent-authored notes for the call. Card-like values are scrubbed server-side for PCI compliance. | [optional] 
**ZohoDeskTicketId** | **string** | Existing zoho desk ticket id to associate this call with. | [optional] 
**ZohoDeskTicketUrl** | **string** | Existing zoho desk ticket URL | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

