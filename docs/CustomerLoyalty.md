# com.ultracart.admin.v2.Model.CustomerLoyalty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentPoints** | **int?** | Current points | [optional] 
**InternalGiftCertificate** | [**GiftCertificate**](GiftCertificate.md) |  | [optional] 
**InternalGiftCertificateBalance** | **string** | Loyalty Cashback / Store credit balance (internal gift certificate balance) | [optional] 
**InternalGiftCertificateOid** | **int?** | Internal gift certificate oid used to tracking loyalty cashback / store credit. | [optional] 
**LedgerEntries** | [**List&lt;CustomerLoyaltyLedger&gt;**](CustomerLoyaltyLedger.md) | Ledger entries | [optional] 
**LoyaltyTierExpirationDts** | **string** | Loyalty tier expiration date (read only because of SDK addition) | [optional] 
**LoyaltyTierName** | **string** | Loyalty tier name | [optional] 
**LoyaltyTierOid** | **int?** | Loyalty tier oid (set to zero to remove the tier) | [optional] 
**PendingPoints** | **int?** | Pending Points | [optional] 
**Redemptions** | [**List&lt;CustomerLoyaltyRedemption&gt;**](CustomerLoyaltyRedemption.md) | Redemptions | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

