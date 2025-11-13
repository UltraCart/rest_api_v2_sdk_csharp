
# com.ultracart.admin.v2.Model.ConversationVirtualAgentCapabilities

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessStorefrontAndItem** | **bool** | Permission flag to allow this Agent access to the storefront and item information. | [optional] 
**CancelSubscription** | **bool** |  | [optional] 
**DelaySubscription** | **bool** |  | [optional] 
**GenerateCoupon** | **bool** | Permission flag to allow this Agent to generate coupons based upon the agent prompt instructions | [optional] 
**LookupOrderInformation** | **bool** |  | [optional] 
**LookupSubscriptionInformation** | **bool** |  | [optional] 
**OpenSupportTicket** | **bool** |  | [optional] 
**OpenSupportTicketChannel** | **string** | Channel to use to open the support ticket | [optional] 
**OpenSupportTicketChannelEmail** | **string** | Email to send support ticket to | [optional] 
**OpenSupportTicketZohoDeskDepartmentId** | **string** | Department ID to open a Zoho Desk ticket for | [optional] 
**PauseSubscription** | **bool** |  | [optional] 
**ResumeSubscription** | **bool** |  | [optional] 
**TransferChatToLiveAgent** | **bool** |  | [optional] 
**UpdateSubscriptionCreditCard** | **bool** |  | [optional] 
**ZohoDeskAvailable** | **bool** | True if Zoho Desk is connected to UltraCart | [optional] 
**ZohoDeskDepartments** | [**List&lt;ConversationVirtualAgentCapabilityZohoDeskDepartment&gt;**](ConversationVirtualAgentCapabilityZohoDeskDepartment.md) | Array of Zoho Desk Department if zoho desk is connected to UltraCart | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

