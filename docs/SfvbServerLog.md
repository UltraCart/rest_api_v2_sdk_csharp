
# com.ultracart.admin.v2.Model.SfvbServerLog

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppError** | **bool** | True when the render itself failed and the page could not be produced. | [optional] 
**DurationMs** | **int** | How long the render took in milliseconds. | [optional] 
**ErrorCount** | **int** | Error lines in the log, including Velocity problems such as a null | [optional] 
**LineCount** | **int** | Lines in the full log text. | [optional] 
**LogId** | **string** | Opaque id of this log.  Pass it to the get endpoint.  Preview pages send the same id in the X-UltraCart-Storefront-Log-Id response header. | [optional] 
**RequestTemplate** | **string** | The template the page rendered with, when known. | [optional] 
**RequestUrl** | **string** | The address that was rendered, as the server recorded it. | [optional] 
**StartDate** | **string** | When the render started, ISO-8601 in UTC. | [optional] 
**Status** | **string** | ERROR when the render logged any error line or failed, otherwise SUCCESS. | [optional] 
**StopDate** | **string** | When the render finished, ISO-8601 in UTC. | [optional] 
**WarningCount** | **int** | Warning lines in the log. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

