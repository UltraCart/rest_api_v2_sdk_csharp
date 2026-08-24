
# com.ultracart.admin.v2.Model.AdjustLoyaltyPointsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Description of this adjustment, 200 characters max | [optional] 
**LoyaltyPoints** | **int** | The number of loyalty points to add to the ledger.  Use a negative number to debit points.  Required and may not be zero. | [optional] 
**OrderId** | **string** | Optional order id if this adjustment is related to a particular order | [optional] 
**VestingDays** | **int** | Optional days required for this adjustment to vest.  Leave null to use the merchant configured default.  Use zero for immediate vesting. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

