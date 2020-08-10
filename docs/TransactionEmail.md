# com.ultracart.admin.v2.Model.TransactionEmail
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | **string** | Actual template contents | [optional] 
**EspDomainUuid** | **string** | The uuid of the sending domain | [optional] 
**EspFriendlyName** | **string** | Friendly from that will appear in customer email clients. | [optional] 
**EspUser** | **string** | The username of the sending email.  This is not the full email.  Only the username which is everything before the @ sign. | [optional] 
**FileExists** | **bool?** | An internal identifier used to aid in retrieving templates from the filesystem. | [optional] 
**FileName** | **string** | File name | [optional] 
**Group** | **string** | Group | [optional] 
**HandlebarVariables** | **List&lt;string&gt;** | Handlebar Variables available for email template | [optional] 
**Invalid** | **bool?** | Invalid will be true if the template cannot compile | [optional] 
**LastModified** | **string** | Last modified timestamp | [optional] 
**Options** | [**List&lt;TransactionEmailOption&gt;**](TransactionEmailOption.md) | Options that help govern how and when this template is used | [optional] 
**Path** | **string** | directory path where template is stored in file system | [optional] 
**Size** | **string** | Size of file in friendly description | [optional] 
**StoreFrontFsDirectoryOid** | **int?** | Internal identifier used to store and retrieve template from filesystem | [optional] 
**StoreFrontFsFileOid** | **int?** | Internal identifier used to store and retrieve template from filesystem | [optional] 
**Subject** | **string** | Subject | [optional] 
**SyntaxErrors** | **string** | Any syntax errors contained within the tempalate | [optional] 
**TemplatePathRelativePath** | **string** | Internal value used to locate the template in the filesystem | [optional] 
**ThemeRelativePath** | **string** | Theme relative path in the filesystem. | [optional] 


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

