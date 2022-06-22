
# com.ultracart.admin.v2.Model.ApplyLibraryItemRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmailUuid** | **string** | Normal emails are applied to an existing email object, so when requesting a library item to be applied to an email, supply the email uuid.  This is only for normal emails.  Transactional emails do not have a uuid. | [optional] 
**LibraryItemOid** | **int** | Library item oid that you wish to apply to the given StoreFront | [optional] 
**PostcardUuid** | **string** | The postcard uuid you wish to apply to a given StoreFront. | [optional] 
**StorefrontOid** | **int** | StoreFront oid where content originates necessary for tracking down relative assets | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

