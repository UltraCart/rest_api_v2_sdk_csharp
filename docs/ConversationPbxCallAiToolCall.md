# com.ultracart.admin.v2.Model.ConversationPbxCallAiToolCall
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CalledAtDts** | **string** | Timestamp when the tool was called | [optional] 
**CompletedAtDts** | **string** | Timestamp when the tool call completed | [optional] 
**DurationMs** | **int?** | Duration of the tool call in milliseconds | [optional] 
**ErrorMessage** | **string** | Error message if the tool call failed | [optional] 
**Parameters** | **Object** | Parameters passed to the tool (structure varies by tool) | [optional] 
**Result** | **Object** | Result returned by the tool (structure varies by tool) | [optional] 
**Success** | **bool?** | Whether the tool call succeeded | [optional] 
**ToolCallUuid** | **string** | Unique identifier for this tool call | [optional] 
**ToolName** | **string** | Name of the tool that was called | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

