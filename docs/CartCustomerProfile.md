# com.ultracart.admin.v2.Model.CartCustomerProfile
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Allow3rdPartyBilling** | **bool?** | True if profile is allowed to bill to their 3rd party shipping account | [optional] 
**AllowCod** | **bool?** | True if this profile is allowed to use a COD | [optional] 
**AllowPurchaseOrder** | **bool?** | True if this profile is allowed to use a purchase order | [optional] 
**BillingAddresses** | [**List&lt;CartCustomerProfileAddress&gt;**](CartCustomerProfileAddress.md) | Billing addresses on file for this profile | [optional] 
**CreditCards** | [**List&lt;CartCustomerProfileCreditCard&gt;**](CartCustomerProfileCreditCard.md) | Credit cards on file for this profile (masked) | [optional] 
**CustomerProfileOid** | **int?** | Unique identifier | [optional] 
**DhlAccountNumber** | **string** | DHL account number on file | [optional] 
**DhlDutyAccountNumber** | **string** | DHL duty account number on file | [optional] 
**Email** | **string** | Email | [optional] 
**FedexAccountNumber** | **string** | FedEx account number on file | [optional] 
**FreeShipping** | **bool?** | True if this profile always qualifies for free shipping | [optional] 
**FreeShippingMinimum** | **decimal?** | The minimum aount that this profile has to purchase to qualify for free shipping | [optional] 
**MaximumItemCount** | **int?** | Maximum item count this profile can purchase | [optional] 
**MinimumItemCount** | **int?** | Minimum item count this profile must purchase | [optional] 
**MinimumSubtotal** | **decimal?** | Minimum subtotal this profile must purchase | [optional] 
**NoCoupons** | **bool?** | True if this profile is prevented from using coupons | [optional] 
**NoFreeShipping** | **bool?** | True if this profile is never given free shipping | [optional] 
**NoRealtimeCharge** | **bool?** | True if this customers orders are not charged in real-time | [optional] 
**PricingTiers** | **List&lt;string&gt;** | Pricing tier names this profile qualifies for | [optional] 
**ShippingAddresses** | [**List&lt;CartCustomerProfileAddress&gt;**](CartCustomerProfileAddress.md) | Shipping addresses on file for this profile | [optional] 
**TaxExempt** | **bool?** | True if this profile is exempt from sales tax | [optional] 
**UpsAccountNumber** | **string** | UPS account number on file | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

