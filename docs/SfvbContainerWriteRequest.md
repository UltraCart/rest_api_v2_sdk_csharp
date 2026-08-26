
# com.ultracart.admin.v2.Model.SfvbContainerWriteRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowWarnings** | **bool** | Store the container even if quality warnings were raised.  Warnings never block by default; this field exists so a caller can opt into treating them as blocking by setting it false. | [optional] 
**Cjson** | **string** | The container JSON to store. | [optional] 
**Comment** | **string** | Optional comment recorded against the version this write creates. | [optional] 
**MarketingEmail** | **bool** | For email containers, whether this is a marketing email.  Selects whether CAN-SPAM footer rules apply. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

