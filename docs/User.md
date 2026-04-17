
# com.ultracart.admin.v2.Model.User

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiIpAddressMasks** | **List&lt;string&gt;** | A list of IP addresses whitelisted for any user with API Access permission.  Without this list, each ip address must be authenticated by a user, which can be a pain for some servers. | [optional] 
**ChangeFtpPasswordTo** | **string** | Supply a new FTP password using this field.  Password are stored using one-way encryption, so they are never available anywhere in the system.  The FTP password cannot be the same as the normal password. | [optional] 
**ChangePasswordTo** | **string** | Supply a new password using this field.  Password are stored using one-way encryption, so they are never available anywhere in the system. | [optional] 
**Email** | **string** | Email address of user | [optional] 
**FullName** | **string** | Full name of user.  This is used solely for human assistance and so the UltraCart staff knows who they are calling when there is a problem. | [optional] 
**Groups** | [**List&lt;UserGroupMembership&gt;**](UserGroupMembership.md) | A list of groups for this merchant and whether or not this user is a member of those groups. | [optional] 
**LinkedAccounts** | [**List&lt;LinkedAccount&gt;**](LinkedAccount.md) | A list of linked accounts and whether or not this user is mirrored to any of those accounts. | [optional] 
**Login** | **string** | User name of user.  Must be unique across a merchant account. | [optional] 
**LoginHistories** | [**List&lt;UserLogin&gt;**](UserLogin.md) | A list of user logins over the past 90 days | [optional] 
**Notifications** | [**List&lt;Notification&gt;**](Notification.md) | A list of notifications the user receives. | [optional] 
**OtpSerialNumber** | **string** | OTP Serial Number such as Google Authenticator or Crypto Card. | [optional] 
**Permissions** | [**List&lt;Permission&gt;**](Permission.md) | A list of permissions the user enjoys for accessing the backend of UltraCart. | [optional] 
**Phone** | **string** | Phone number of user.  Please supply a valid phone number.  When something breaks on your account, we need to be able to reach you. | [optional] 
**UserId** | **int** | User id is a unique identifier for this user | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

