# com.ultracart.admin.v2.Model.ItemDigitalItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClickWrapAgreement** | **string** | Click wrap agreement is presented to the customer before they can purchase your product. | [optional] 
**CreationDts** | **string** | File creation date | [optional] 
**Description** | **string** | Description of the digital item | [optional] 
**DigitalItemOid** | **int?** | The Digital item oid is a primary key used internally by UltraCart.  You should not set or change this value.  Doing so will have no effect. | [optional] 
**ExternalId** | **string** | External Id useful for syncing with a remote filesystem, this may be an MD5 hash or whatever suits your needs. | [optional] 
**FileSize** | **long?** | File size | [optional] 
**ImportFromUrl** | **string** | This url is sourced to create or update a digital file in your digital library.  It is only considered during an insert or update operation. | [optional] 
**MimeType** | **string** | Mime type associated with the file | [optional] 
**OriginalFilename** | **string** | Original filename | [optional] 
**PdfMeta** | [**ItemDigitalItemPdfMeta**](ItemDigitalItemPdfMeta.md) |  | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

