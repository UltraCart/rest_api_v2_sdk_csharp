
# com.ultracart.admin.v2.Model.SfvbTransactionalEmailDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeliveryOptions** | [**List&lt;SfvbTransactionalDeliveryOption&gt;**](SfvbTransactionalDeliveryOption.md) | Its delivery options.  Empty for an email that has none. | [optional] 
**FileName** | **string** | The HTML template file, such as receipt_html.vm. | [optional] 
**HashSha256** | **string** | The hash of the subject, the options and the sender.  Send it as If-Match to change them. | [optional] 
**Name** | **string** | The display name, such as Order - Receipt. | [optional] 
**Sender** | [**SfvbTransactionalSender**](SfvbTransactionalSender.md) |  | [optional] 
**SenderSharedWith** | **List&lt;string&gt;** | Every storefront on this account that shares the sender, this one included. | [optional] 
**Subject** | **string** | The subject line. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

