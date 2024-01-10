
# com.ultracart.admin.v2.Model.WorkflowTasksRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssignedToGroupId** | **int** | Assigned to group ID | [optional] 
**AssignedToMe** | **bool** | Tasks are assigned to me either by direct user id or a group that the user is a member of | [optional] 
**AssignedToUserId** | **int** | Assigned to user ID | [optional] 
**CreatedBy** | [**WorkflowUser**](WorkflowUser.md) |  | [optional] 
**CreatedDtsBegin** | **string** | Date/time that the workflow task was created | [optional] 
**CreatedDtsEnd** | **string** | Date/time that the workflow task was created | [optional] 
**DelayUntilDtsBegin** | **string** | Date/time that the workflow task should delay until | [optional] 
**DelayUntilDtsEnd** | **string** | Date/time that the workflow task should delay until | [optional] 
**DueDtsBegin** | **string** | Date/time that the workflow task is due | [optional] 
**DueDtsEnd** | **string** | Date/time that the workflow task is due | [optional] 
**LastUpdateDtsBegin** | **string** | Date/time that the workflow task was last updated | [optional] 
**LastUpdateDtsEnd** | **string** | Date/time that the workflow task was last updated | [optional] 
**ObjectEmail** | **string** | Object is associated with customer email | [optional] 
**ObjectType** | **string** | Object Type | [optional] 
**Priority** | **string** | Priority | [optional] 
**Status** | **string** | Status of the workflow task | [optional] 
**Tags** | **List&lt;string&gt;** | Tasks that are tagged with the specified tags | [optional] 
**Unassigned** | **bool** | Tasks that are unassigned to a user or group | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

