
# com.ultracart.admin.v2.Model.SfvbEventsAuthResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpiresDts** | **string** | When the token stops working, ISO 8601.  Ask for a new one to reconnect. | [optional] 
**Jwt** | **string** | The connect token on its own. | [optional] 
**WebsocketUrl** | **string** | The websocket URL to open, with the token on it.  Open it before expires_dts; each token opens one connection. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

