
# com.ultracart.admin.v2.Model.SfvbTrackingPrivacy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnonymizeIp** | **string** | Which shoppers have their IP address anonymized on the cart and order.  all, eea, non_us, or null for nobody. | [optional] 
**DefaultMailingListOff** | **string** | Which shoppers start checkout with the mailing list sign-up unchecked.  all, eea, non_us, or null for nobody. | [optional] 
**DisableReturnEmail** | **string** | Which shoppers are left out of the return email (the admin&#39;s Disable Return Email rule).  all, eea, non_us, or null for nobody. | [optional] 
**ExcludePurchaseBubbleHistory** | **string** | Which shoppers&#39; purchases are left out of the purchase bubble history.  all, eea, non_us, or null for nobody. | [optional] 
**HashSha256** | **string** | The hash of these five rules.  Send it as If-Match when changing them. | [optional] 
**ShowCookieNotice** | **string** | Which shoppers see the privacy and cookie notice.  all, eea (shoppers in the European Economic Area), non_us, or null for nobody. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

