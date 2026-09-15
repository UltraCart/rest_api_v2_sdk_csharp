
# com.ultracart.admin.v2.Model.SfvbPreviewAccessRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | Storefront path to land on, beginning with a slash.  Defaults to / | [optional] 
**PreviewSessionId** | **string** | Staged preview session to show.  It must be one this user created and it must not have expired.  Leave it out to show the saved containers with nothing staged. | [optional] 
**ThemeOid** | **int** | Theme to show, which may be inactive.  Must belong to this storefront.  Defaults to the active theme. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

