
# com.ultracart.admin.v2.Model.SfvbSecretRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **string** | When the request was made, ISO 8601 UTC. | [optional] 
**Delegated** | **bool** | True when the requester handed it to a colleague to fill in. | [optional] 
**Description** | **string** | The sentence the person reads.  Written by the server, not the agent. | [optional] 
**ExpiresAt** | **string** | When a pending request lapses, ISO 8601 UTC. | [optional] 
**ExpiresInSeconds** | **int** | Seconds until expires_at.  Zero once passed. | [optional] 
**FulfilledAt** | **string** | When the values were entered, ISO 8601 UTC. | [optional] 
**HandleCount** | **int** | How many handles the request made. | [optional] 
**Handles** | [**List&lt;SfvbSecretHandle&gt;**](SfvbSecretHandle.md) | Every handle with its status.  Left out of the list endpoint; read one request for them. | [optional] 
**IntervalSeconds** | **int** | Poll no more often than this. | [optional] 
**Keys** | **List&lt;string&gt;** | The bulk keys, or empty. | [optional] 
**Label** | **string** | The label the agent sent, as stored and shown. | [optional] 
**Reason** | **string** | The reason the agent sent, as stored and shown. | [optional] 
**RequestId** | **string** | The request id. | [optional] 
**RequestUrl** | **string** | The page where the person enters the values.  Show it to them.  Never open or fill it in yourself. | [optional] 
**RequiresTotp** | **bool** | True when the person must enter a code from their authenticator app. | [optional] 
**Sinks** | **List&lt;string&gt;** | The secret fields being collected. | [optional] 
**Status** | **string** | pending, fulfilled, cancelled or expired. | [optional] 
**TargetId** | **string** | The object the values are for, or empty for a bulk request or an open one. | [optional] 
**UserCode** | **string** | Short matching code.  Print it next to request_url so the person can check the page shows the same code. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

