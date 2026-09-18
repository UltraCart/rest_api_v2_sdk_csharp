
# com.ultracart.admin.v2.Model.SfvbExperimentStartRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DurationDays** | **int** | url - 3 to 90.  A url experiment always ends by itself after this many days. | [optional] 
**EqualWeighting** | **bool** | url - true keeps the split fixed.  false shifts traffic toward the leader as the experiment runs.  Defaults to true. | [optional] 
**Name** | **string** | url - experiment name. | [optional] 
**Notes** | **string** | url - notes, such as the hypothesis being tested. | [optional] 
**Objective** | **string** | url - one of the objectives from the objective list. | [optional] 
**ObjectiveParameter** | **string** | url - the event name, when the objective is Events. | [optional] 
**OptimizationType** | **string** | url - MAXIMUM or MINIMUM. | [optional] 
**Path** | **string** | page - path of the page whose body holds the experiment element. | [optional] 
**Slot** | **string** | page - the body file&#39;s name without .cjson.  Defaults to body. | [optional] 
**Type** | **string** | page or url. | [optional] 
**Variations** | [**List&lt;SfvbExperimentStartVariation&gt;**](SfvbExperimentStartVariation.md) | url - 2 to 5 pages.  The first is the control. | [optional] 
**WidgetId** | **string** | page - id of the experiment element in that body. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

