# com.ultracart.admin.v2.Model.WorkflowTask
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssignedToGroup** | **string** | Assigned to group | [optional] 
**AssignedToGroupId** | **int?** | Assigned to group ID | [optional] 
**AssignedToUser** | **string** | Assigned to user | [optional] 
**AssignedToUserId** | **int?** | Assigned to user ID | [optional] 
**Attachments** | [**List&lt;WorkflowAttachment&gt;**](WorkflowAttachment.md) | Attachments to the Workflow Task | [optional] 
**CreatedBy** | [**WorkflowUser**](WorkflowUser.md) |  | [optional] 
**CreatedDts** | **string** | Date/time that the workflow task was created | [optional] 
**DelayUntilDts** | **string** | Date/time that the workflow task should delay until | [optional] 
**DependantWorkflowTaskUuid** | **string** | Dependant Workflow Task UUID (must be completed before this task can be completed) | [optional] 
**DueDts** | **string** | Date/time that the workflow task is due | [optional] 
**ExpirationDts** | **string** | Date/time that the workflow task will expire and be closed.  This is set by system generated tasks. | [optional] 
**Histories** | [**List&lt;WorkflowTaskHistory&gt;**](WorkflowTaskHistory.md) | Array of history records for the task | [optional] 
**LastUpdateDts** | **string** | Date/time that the workflow task was last updated | [optional] 
**MerchantId** | **string** | Merchant ID | [optional] 
**Notes** | [**List&lt;WorkflowNote&gt;**](WorkflowNote.md) | Notes on the Workflow Task | [optional] 
**ObjectEmail** | **string** | Object is associated with customer email | [optional] 
**ObjectId** | **string** | Object ID | [optional] 
**ObjectType** | **string** | Object Type | [optional] 
**ObjectUrl** | **string** | Object URL | [optional] 
**Priority** | **string** | Priority | [optional] 
**Properties** | [**List&lt;Property&gt;**](Property.md) | Properties | [optional] 
**RelatedWorkflowTaskUuid** | **string** | Related Workflow Task UUID | [optional] 
**Status** | **string** | Status of the workflow task | [optional] 
**SystemTaskType** | **string** | Constant for the type of system generated task | [optional] 
**Tags** | **List&lt;string&gt;** | Tags | [optional] 
**TaskContext** | **string** | User friendly string of the task context | [optional] 
**TaskDetails** | **string** | Task Details | [optional] 
**TaskName** | **string** | Task Name | [optional] 
**WorkflowTaskUuid** | **string** | Workflow Task UUID | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

