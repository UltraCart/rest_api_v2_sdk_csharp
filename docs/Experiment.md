# com.ultracart.admin.v2.Model.Experiment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContainerId** | **string** | Contained ID where the experiment element was located | [optional] 
**DurationDays** | **int?** | Duration in days | [optional] 
**EndDts** | **string** | End date/time | [optional] 
**EqualWeighting** | **bool?** | Whether or not traffic is equally weighted or shifts over time during the experiment | [optional] 
**ExperimentType** | **string** | The type of experiment | [optional] 
**Id** | **string** | Experiment id | [optional] 
**Name** | **string** | Experiment name | [optional] 
**Notes** | **string** | Notes about the experiment | [optional] 
**Objective** | **string** | Objective that is being optimized | [optional] 
**ObjectiveParameter** | **string** | Objective parameter (such as event name) that is being optimized | [optional] 
**OpenaiCurrentIteration** | **int?** | The current iteration of the OpenAI related experiment | [optional] 
**OpenaiElementType** | **string** | The type of OpenAI element being experimented on | [optional] 
**OpenaiModel** | **string** | The type of OpenAI model used | [optional] 
**OpenaiTotalIterations** | **int?** | The total number of iterations to perform on the experiment | [optional] 
**OptimizationType** | **string** | Type of optimization | [optional] 
**PValue** | **decimal?** | Statistics p-value for the experiment | [optional] 
**SessionCount** | **int?** | Total number of sessions in the experiment | [optional] 
**StartDts** | **string** | Start date/time | [optional] 
**Status** | **string** | Status of the experiment | [optional] 
**StorefrontExperimentOid** | **int?** | Storefront Experiment Oid | [optional] 
**StorefrontOid** | **int?** | Storefront oid | [optional] 
**Uri** | **string** | URI the experiment was started on | [optional] 
**Variations** | [**List&lt;ExperimentVariation&gt;**](ExperimentVariation.md) | Variations being tested in the experiment | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

