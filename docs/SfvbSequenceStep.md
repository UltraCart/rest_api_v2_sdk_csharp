
# com.ultracart.admin.v2.Model.SfvbSequenceStep

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Branches** | [**List&lt;SfvbSequenceBranch&gt;**](SfvbSequenceBranch.md) | Its two sides, for a condition, split or InboxGeek step.  Absent for every other type. | [optional] 
**ConfigError** | **bool** | True when the step&#39;s settings could not be read. | [optional] 
**ConfigJson** | **string** | The step&#39;s settings as the admin stores them.  A webhook&#39;s header and parameter values are masked. | [optional] 
**ConfigMerchantNotes** | **string** | A note stored inside the step&#39;s settings, when there is one. | [optional] 
**Disabled** | **bool** | True when the step is switched off in its settings. | [optional] 
**EmailUuids** | **List&lt;string&gt;** | The emails it sends.  One for an email step, one per variant for an experiment. | [optional] 
**FilterProfileEquationJson** | **string** | The step&#39;s audience filter as stored, when it has one. | [optional] 
**HashSha256** | **string** | The hash of the step&#39;s type, stored settings and audience filter.  Send it back as If-Match when changing the step. | [optional] 
**ItemIds** | **List&lt;string&gt;** | The items it names, for a cart or rate limiter step. | [optional] 
**Label** | **string** | The type as the admin names it, such as Time Delay.  The type itself for one it doesn&#39;t know. | [optional] 
**ListUuids** | **List&lt;string&gt;** | The lists it subscribes or unsubscribes, for a list step. | [optional] 
**MerchantNotes** | **string** | The note stored on the step. | [optional] 
**Name** | **string** | The step&#39;s own display name from its settings, when it has one. | [optional] 
**NumberWaiting** | **int** | How many customers are waiting on this step now.  Only when waiting counts were asked for. | [optional] 
**PostcardUuid** | **string** | The postcard it sends, for a postcard step. | [optional] 
**StepUuid** | **string** | The step uuid. | [optional] 
**Type** | **string** | The step type, such as email, wait, condition or webhook. | [optional] 
**Unreachable** | **bool** | True for a step no branch leads to.  Listed at the end so nothing is hidden. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

