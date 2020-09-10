# com.ultracart.admin.v2.Model.OrderShipping
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address1** | **string** | Address line 1 | [optional] 
**Address2** | **string** | Address line 2 | [optional] 
**City** | **string** | City | [optional] 
**Company** | **string** | Company | [optional] 
**CountryCode** | **string** | ISO-3166 two letter country code | [optional] 
**DayPhone** | **string** | Day time phone | [optional] 
**DayPhoneE164** | **string** | Day time phone (E164 format) | [optional] 
**DeliveryDate** | **string** | Date the customer is requesting delivery on.  Typically used for perishable product delivery. | [optional] 
**EveningPhone** | **string** | Evening phone | [optional] 
**FirstName** | **string** | First name | [optional] 
**LastName** | **string** | Last name | [optional] 
**LeastCostRoute** | **bool?** | If true, instructs UltraCart to apply the cheapest shipping method to this order.  Used only for channel partner order inserts. | [optional] 
**LeastCostRouteShippingMethods** | **List&lt;string&gt;** | List of shipping methods to consider if least_code_route is true. Used only for channel parter order inserts. | [optional] 
**LiftGate** | **bool?** | Lift gate requested (LTL shipping methods only) | [optional] 
**PostalCode** | **string** | Postal code | [optional] 
**Rma** | **string** | RMA number | [optional] 
**ShipOnDate** | **string** | Date the customer is requesting that the order ship on.  Typically used for perishable product delivery. | [optional] 
**ShipToResidential** | **bool?** | True if the shipping address is residential.  Effects the methods that are available to the customer as well as the price of the shipping method. | [optional] 
**Shipping3rdPartyAccountNumber** | **string** | Shipping 3rd party account number | [optional] 
**ShippingDate** | **string** | Date/time the order shipped on.  This date is set once the first shipment is sent to the customer. | [optional] 
**ShippingDepartmentStatus** | **string** | Shipping department status | [optional] 
**ShippingMethod** | **string** | Shipping method | [optional] 
**ShippingMethodAccountingCode** | **string** | Shipping method accounting code | [optional] 
**SpecialInstructions** | **string** | Special instructions from the customer regarding shipping | [optional] 
**StateRegion** | **string** | State | [optional] 
**Title** | **string** | Title | [optional] 
**TrackingNumberDetails** | [**List&lt;OrderTrackingNumberDetails&gt;**](OrderTrackingNumberDetails.md) | Tracking number details | [optional] 
**TrackingNumbers** | **List&lt;string&gt;** | Tracking numbers | [optional] 
**Weight** | [**Weight**](Weight.md) |  | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

