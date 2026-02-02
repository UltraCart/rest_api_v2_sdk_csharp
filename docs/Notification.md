# com.ultracart.admin.v2.Model.Notification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CanFilterByDistributionCenters** | **bool?** | True if this notification can be filtered to only send for one or more distribution centers. | [optional] 
**CanIncludeAffiliate** | **bool?** | True if this notification can include an affiliate information. | [optional] 
**CanIncludeOrder** | **bool?** | True if this notification can include an order attachment. | [optional] 
**CanIncludeOrderPlainText** | **bool?** | True if this notification can include a plain text rendering of an order directly within an email.  Some desire this over an attachment | [optional] 
**DistributionCenterFilters** | **List&lt;string&gt;** | If this notification supports it, this list of distribution center CODES will filter the notification to just those distribution centers. | [optional] 
**IncludeAffiliate** | **bool?** | If true, and this notification supports it, affiliate information will be attached to all notifications of this type | [optional] 
**IncludeOrder** | **bool?** | If true, and this notification supports it, the order will be attached to all notifications of this type | [optional] 
**IncludeOrderPlainText** | **bool?** | If true, and this notification supports it, a plain text order will be directly inserted into all notifications of this type | [optional] 
**Name** | **string** | The name of this notification. | [optional] 
**NotificationGroup** | **string** | A group for this notification.  This name is only used for visual grouping within interfaces. | [optional] 
**Selected** | **bool?** | True if this user wishes to receive this email notification. | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

