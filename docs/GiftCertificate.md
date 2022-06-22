
# com.ultracart.admin.v2.Model.GiftCertificate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Activated** | **bool** | True if this gift certificate is activated and ready to apply to purchases. | [optional] 
**Code** | **string** | The code used by the customer to purchase against this gift certificate. | [optional] 
**CustomerProfileOid** | **int** | This is the customer profile oid associated with this internally managed gift certificate. | [optional] 
**Deleted** | **bool** | True if this gift certificate was deleted. | [optional] 
**Email** | **string** | Email of the customer associated with this gift certificate. | [optional] 
**ExpirationDts** | **string** | Expiration date time. | [optional] 
**GiftCertificateOid** | **int** | Gift certificate oid. | [optional] 
**Internal** | **bool** | This is an internally managed gift certificate associated with the loyalty cash rewards program. | [optional] 
**LedgerEntries** | [**List&lt;GiftCertificateLedgerEntry&gt;**](GiftCertificateLedgerEntry.md) | A list of all ledger activity for this gift certificate. | [optional] 
**MerchantId** | **string** | Merchant Id | [optional] 
**MerchantNote** | **string** | A list of all ledger activity for this gift certificate. | [optional] 
**OriginalBalance** | **decimal** | Original balance of the gift certificate. | [optional] 
**ReferenceOrderId** | **string** | The order used to purchase this gift certificate.  This value is ONLY set during checkout when a certificate is purchased, not when it is used.  Any usage is recorded in the ledger | [optional] 
**RemainingBalance** | **decimal** | The remaining balance on the gift certificate.  This is never set directly, but calculated from the ledger.  To change the remaining balance, add a ledger entry. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

