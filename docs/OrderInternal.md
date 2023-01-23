# com.ultracart.admin.v2.Model.OrderInternal
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExportedToAccounting** | **bool?** | True if the order has been exported to QuickBooks. If QuickBooks is not configured, then this will already be true | [optional] 
**MerchantNotes** | **string** | Merchant notes.  Full notes in non-transactional mode.  Just used to write a new merchant note when transaction merchant notes enabled. | [optional] 
**PlacedByUser** | **string** | If placed via the BEOE, this is the user that placed the order | [optional] 
**RefundByUser** | **string** | User that issued the refund | [optional] 
**SalesRepCode** | **string** | Sales rep code associated with the order | [optional] 
**TransactionalMerchantNotes** | [**List&lt;OrderTransactionalMerchantNote&gt;**](OrderTransactionalMerchantNote.md) | Transactional merchant notes | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

