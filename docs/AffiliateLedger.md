# com.ultracart.admin.v2.Model.AffiliateLedger
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AffiliateClickOid** | **int?** | Unique object identifier for the click associated with this ledger entry | [optional] 
**AffiliateLedgerOid** | **int?** | Affiliate ledger object ID associated with this ledger | [optional] 
**AffiliateLinkOid** | **int?** | Unique object identifier for the link that this click is associated with | [optional] 
**AffiliateOid** | **int?** | Affiliate object ID associated with this transaction | [optional] 
**AssignedByUser** | **string** | User that assigned the transaction if it was done manually | [optional] 
**Click** | [**AffiliateClick**](AffiliateClick.md) |  | [optional] 
**ItemId** | **string** | Item ID associated with this transaction | [optional] 
**Link** | [**AffiliateLink**](AffiliateLink.md) |  | [optional] 
**Order** | [**Order**](Order.md) |  | [optional] 
**OrderId** | **string** | Order ID associated with this transaction | [optional] 
**OriginalTransactionDts** | **string** | Date/time of the original transaction for reversals | [optional] 
**SubId** | **string** | Sub ID associated with transaction (from the click) | [optional] 
**TierNumber** | **int?** | Tier number that this transaction earned | [optional] 
**TransactionAmount** | **decimal?** | Transaction amount | [optional] 
**TransactionAmountPaid** | **decimal?** | Amount of the transaction that has been paid out. | [optional] 
**TransactionDts** | **string** | Date/time that the transaction was made | [optional] 
**TransactionMemo** | **string** | Memo explaining the transaction | [optional] 
**TransactionPercentage** | **decimal?** | Percentage associated with this transaction | [optional] 
**TransactionState** | **string** | Transaction state | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

