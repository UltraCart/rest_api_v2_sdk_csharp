
# com.ultracart.admin.v2.Model.SfvbTrackingProviderField

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Allowed** | **List&lt;string&gt;** | For a select, the values accepted. | [optional] 
**Key** | **string** | The field key a write names. | [optional] 
**Label** | **string** | The label the admin shows. | [optional] 
**Mask** | **string** | For a stored secret, its mask.  Send it back, or leave the secret out, to keep it. | [optional] 
**Max** | **int** | The longest value accepted, or for an id_list the longest line. | [optional] 
**MaxValue** | **int** | For a number, the largest value accepted. | [optional] 
**MinValue** | **int** | For a number, the smallest value accepted. | [optional] 
**Secret** | **bool** | True for a secret.  Its value is never returned; set and mask say whether one is stored. | [optional] 
**Set** | **bool** | For a secret, true when one is stored. | [optional] 
**Sink** | **string** | For a writable secret, the sink a secret request names, with this storefront_oid as its target. | [optional] 
**Type** | **string** | id, id_list, token, url, server_url, host, host_list, bool, select, number, numeric_id or secret.  It decides what a write accepts. | [optional] 
**UnavailableReason** | **string** | Present only when this storefront can&#39;t turn the field on, and why.  Turning it off still works. | [optional] 
**Value** | **string** | The stored value.  Booleans are true or false.  Null when blank.  Never present for a secret. | [optional] 
**Writable** | **bool** | False for a field the API reports but does not change. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

