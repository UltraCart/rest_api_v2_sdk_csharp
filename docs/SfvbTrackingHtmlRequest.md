
# com.ultracart.admin.v2.Model.SfvbTrackingHtmlRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | **string** | The whole HTML the slot will hold, at most 256 KB as UTF-8.  An empty string empties the slot, which needs no approval.  Anything else needs an approved tracking_html.put request for exactly these bytes. | [optional] 
**DryRun** | **bool** | True to check the write and say whether it needs an approval, without saving. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

