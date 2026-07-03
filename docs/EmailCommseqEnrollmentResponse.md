
# com.ultracart.admin.v2.Model.EmailCommseqEnrollmentResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AlreadyEnrolled** | **bool** | True if the customer was already enrolled and therefore not enrolled again | [optional] 
**Enrolled** | **bool** | True if the customer was newly enrolled into the sequence | [optional] 
**Error** | [**Error**](Error.md) |  | [optional] 
**EspCustomerUuid** | **string** | The resolved ESP customer UUID for the enrolled email | [optional] 
**Metadata** | [**ResponseMetadata**](ResponseMetadata.md) |  | [optional] 
**Success** | **bool** | Indicates if API call was successful | [optional] 
**Warning** | [**Warning**](Warning.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

