
# com.ultracart.admin.v2.Model.DistributionCenter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address1** | **string** | Address line 1 of the distribution center | [optional] 
**Address2** | **string** | Address line 2 of the distribution center | [optional] 
**City** | **string** | City of the distribution center | [optional] 
**Code** | **string** | Unique code for this distribution center | [optional] 
**CountryCode** | **string** | Country code of the distribution center | [optional] 
**DefaultCenter** | **bool** | True if this is the default distribution center on the account | [optional] 
**DefaultHandlesAllItems** | **bool** | True if this distribution center handles all new items by default | [optional] 
**DistributionCenterOid** | **int** | Distribution center object identifier | [optional] 
**Duns** | **string** | DUNS number assigned to this distribution center (EDI) | [optional] 
**EstimateFromDistributionCenterOid** | **int** | Estimate shipments for this distribution center as if they came from the other distribution center | [optional] 
**FtpPassword** | **string** | Password associated with the virtual FTP | [optional] 
**HoldBeforeShipmentMinutes** | **int** | The number of minutes to hold a shipment | [optional] 
**HoldBeforeTransmission** | **bool** | True if the shipment should be held before transmission and require a manual release | [optional] 
**HoldAutoOrderBeforeShipmentMinutes** | **int** |  | [optional] 
**Latitude** | **decimal** | Latitude where the distribution center is located | [optional] 
**Longitude** | **decimal** | Longitude where the distribution center is located | [optional] 
**Name** | **string** | Name of this distribution center | [optional] 
**NoCustomerDirectShipments** | **bool** | True if this distribution center does not handle customer direct shipments | [optional] 
**NoSplitShipment** | **bool** | True if this distribution center is not allowed to participate in a split shipment. | [optional] 
**PickupCutoffTimeFriday** | **string** | The time (EST) after which pickups will not be available on Friday | [optional] 
**PickupCutoffTimeMonday** | **string** | The time (EST) after which pickups will not be available on Monday | [optional] 
**PickupCutoffTimeSaturday** | **string** | The time (EST) after which pickups will not be available on Saturday | [optional] 
**PickupCutoffTimeSunday** | **string** | The time (EST) after which pickups will not be available on Sunday | [optional] 
**PickupCutoffTimeThursday** | **string** | The time (EST) after which pickups will not be available on Thursday | [optional] 
**PickupCutoffTimeTuesday** | **string** | The time (EST) after which pickups will not be available on Tuesday | [optional] 
**PickupCutoffTimeWednesday** | **string** | The time (EST) after which pickups will not be available on Wednesday | [optional] 
**PickupStartTimeFriday** | **string** | The time (EST) after which pickups are available on Friday | [optional] 
**PickupStartTimeMonday** | **string** | The time (EST) after which pickups are available on Monday | [optional] 
**PickupStartTimeSaturday** | **string** | The time (EST) after which pickups are available on Saturday | [optional] 
**PickupStartTimeSunday** | **string** | The time (EST) after which pickups are available on Sunday | [optional] 
**PickupStartTimeThursday** | **string** | The time (EST) after which pickups are available on Thursday | [optional] 
**PickupStartTimeTuesday** | **string** | The time (EST) after which pickups are available on Tuesday | [optional] 
**PickupStartTimeWednesday** | **string** | The time (EST) after which pickups are available on Wednesday | [optional] 
**PickupTz** | **string** | The IANA timezone for all pickup times | [optional] 
**PostalCode** | **string** | Postal code of the distribution center | [optional] 
**ProcessDays** | **int** | The number of processing days required before an order ships | [optional] 
**ProcessInventoryStartTime** | **string** | The time (EST) after which inventory updates will be processed | [optional] 
**ProcessInventoryStopTime** | **string** | The time (EST) before which inventory updates will be processed | [optional] 
**RequireAsn** | **bool** | True if ASNs are required for this distribution center (EDI) | [optional] 
**SendKitInsteadOfComponents** | **bool** | True if we should send the kit instead of the components | [optional] 
**ShipmentCutoffTimeFriday** | **string** | The time (EST) after which shipments will not be processed on Friday | [optional] 
**ShipmentCutoffTimeMonday** | **string** | The time (EST) after which shipments will not be processed on Monday | [optional] 
**ShipmentCutoffTimeSaturday** | **string** | The time (EST) after which shipments will not be processed on Saturday | [optional] 
**ShipmentCutoffTimeSunday** | **string** | The time (EST) after which shipments will not be processed on Sunday | [optional] 
**ShipmentCutoffTimeThursday** | **string** | The time (EST) after which shipments will not be processed on Thursday | [optional] 
**ShipmentCutoffTimeTuesday** | **string** | The time (EST) after which shipments will not be processed on Tuesday | [optional] 
**ShipmentCutoffTimeWednesday** | **string** | The time (EST) after which shipments will not be processed on Wednesday | [optional] 
**State** | **string** | State of the distribution center | [optional] 
**TransmitBlankCosts** | **bool** | True if monetary amounts should be zeroed before transmission | [optional] 
**Transport** | **string** | Transport mechanism for this distribution center | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

