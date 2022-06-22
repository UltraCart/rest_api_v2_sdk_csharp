
# com.ultracart.admin.v2.Model.OrderReplacement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalMerchantNotesNewOrder** | **string** | Additional merchant notes to append to the new order | [optional] 
**AdditionalMerchantNotesOriginalOrder** | **string** | Additional merchant notes to append to the original order | [optional] 
**CustomField1** | **string** | Custom field 1 | [optional] 
**CustomField2** | **string** | Custom field 2 | [optional] 
**CustomField3** | **string** | Custom field 3 | [optional] 
**CustomField4** | **string** | Custom field 4 | [optional] 
**CustomField5** | **string** | Custom field 5 | [optional] 
**CustomField6** | **string** | Custom field 6 | [optional] 
**CustomField7** | **string** | Custom field 7 | [optional] 
**Free** | **bool** | Set to true if this replacement shipment should be free for the customer. | [optional] 
**ImmediateCharge** | **bool** | Set to true if you want to immediately charge the payment on this order, otherwise it will go to Accounts Receivable. | [optional] 
**Items** | [**List&lt;OrderReplacementItem&gt;**](OrderReplacementItem.md) | Items to include in the replacement order | [optional] 
**OriginalOrderId** | **string** | Original order id | [optional] 
**ShippingMethod** | **string** | Shipping method to use.  If not specified or invalid then least cost shipping will take place. | [optional] 
**SkipPayment** | **bool** | Set to true if you want to skip the payment as if it was successful. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

