
# com.ultracart.admin.v2.Model.SfvbLibraryInstallRecord

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstalledDts** | **string** | When it was installed, ISO 8601. | [optional] 
**InstalledRevisionNumber** | **int** | The revision installed most recently on this storefront. | [optional] 
**LatestRevisionNumber** | **int** | The latest published revision, or null when it can no longer be read. | [optional] 
**LibraryOid** | **int** | The entry. | [optional] 
**Name** | **string** | The entry name, when the entry is still visible to this account. | [optional] 
**Retired** | **bool** | True when the owner retired the entry.  The installed copy keeps working. | [optional] 
**StorefrontOid** | **int** | The storefront it was installed on. | [optional] 
**UpdateAvailable** | **bool** | True when a newer revision has been published.  Nothing updates automatically. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

