# com.ultracart.admin.v2.Api.ConversationApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteConversationCannedMessage**](ConversationApi.md#deleteconversationcannedmessage) | **DELETE** /conversation/canned_messages/{conversation_canned_message_oid} | Delete a conversation canned message
[**DeleteDepartment**](ConversationApi.md#deletedepartment) | **DELETE** /conversation/departments/{conversation_department_oid} | Delete a conversation department
[**DeleteEngagement**](ConversationApi.md#deleteengagement) | **DELETE** /conversation/engagements/{conversation_engagement_oid} | Delete a conversation engagement
[**DeletePbxAgentVoicemail**](ConversationApi.md#deletepbxagentvoicemail) | **DELETE** /conversation/pbx/agent/voicemails/{recording_sid} | Delete Agent Voicemail
[**DeletePbxAudio**](ConversationApi.md#deletepbxaudio) | **DELETE** /conversation/pbx/audio/{conversationPbxAudioUuid} | Delete pbx audio
[**DeletePbxMenu**](ConversationApi.md#deletepbxmenu) | **DELETE** /conversation/pbx/menu/{conversationPbxMenuUuid} | Delete pbx menu
[**DeletePbxQueue**](ConversationApi.md#deletepbxqueue) | **DELETE** /conversation/pbx/queue/{conversationPbxQueueUuid} | Delete pbx queue
[**DeletePbxQueueVoicemail**](ConversationApi.md#deletepbxqueuevoicemail) | **DELETE** /conversation/pbx/queues/{queue_uuid}/voicemails/{recording_sid} | Delete Queue Voicemail
[**DeletePbxTimeBased**](ConversationApi.md#deletepbxtimebased) | **DELETE** /conversation/pbx/time_based/{conversationPbxTimeBasedUuid} | Delete pbx timeBased
[**DeletePbxTimeRange**](ConversationApi.md#deletepbxtimerange) | **DELETE** /conversation/pbx/time_range/{conversationPbxTimeRangeUuid} | Delete pbx timeRange
[**DeletePbxVoicemailMailbox**](ConversationApi.md#deletepbxvoicemailmailbox) | **DELETE** /conversation/pbx/voicemail_mailbox/{conversationPbxVoicemailMailboxUuid} | Delete pbx voicemailMailbox
[**GetAgentKeepAlive**](ConversationApi.md#getagentkeepalive) | **GET** /conversation/agent/keepalive | Agent keep alive
[**GetAgentProfile**](ConversationApi.md#getagentprofile) | **GET** /conversation/agent/profile | Get agent profile
[**GetAgentWebsocketAuthorization**](ConversationApi.md#getagentwebsocketauthorization) | **PUT** /conversation/agent/auth | Get agent websocket authorization
[**GetConversation**](ConversationApi.md#getconversation) | **GET** /conversation/conversations/{conversation_uuid} | Retrieve a conversation
[**GetConversationCannedMessages**](ConversationApi.md#getconversationcannedmessages) | **GET** /conversation/canned_messages | Retrieve a list of canned messages ordered by short_code
[**GetConversationContext**](ConversationApi.md#getconversationcontext) | **PUT** /conversation/conversations/{conversation_uuid}/context | Get a webchat conversation context
[**GetConversationDepartmentMemberList**](ConversationApi.md#getconversationdepartmentmemberlist) | **GET** /conversation/department_members | Retrieve a list of possible department members
[**GetConversationDepartments**](ConversationApi.md#getconversationdepartments) | **GET** /conversation/departments | Retrieve a list of departments ordered by name
[**GetConversationEngagement**](ConversationApi.md#getconversationengagement) | **GET** /conversation/engagements/{conversation_engagement_oid} | Retrieve an engagement
[**GetConversationEngagements**](ConversationApi.md#getconversationengagements) | **GET** /conversation/engagements | Retrieve a list of engagements ordered by name
[**GetConversationMessages**](ConversationApi.md#getconversationmessages) | **GET** /conversation/conversations/{conversation_uuid}/messages/{since} | Retrieve conversation messages
[**GetConversationMultimediaUploadUrl**](ConversationApi.md#getconversationmultimediauploadurl) | **GET** /conversation/upload_url/{extension} | Get a presigned conversation multimedia upload URL
[**GetConversationPbxAudioUploadUrl**](ConversationApi.md#getconversationpbxaudiouploadurl) | **GET** /conversation/pbx/audio/upload_url/{extension} | Get a pre-signed conversation multimedia upload URL
[**GetConversationPbxCustomerSnapshot**](ConversationApi.md#getconversationpbxcustomersnapshot) | **POST** /conversation/pbx/customer_snapshot | Get orders and customer information for a phone number
[**GetConversationPermissions**](ConversationApi.md#getconversationpermissions) | **GET** /conversation/permissions | Retrieve conversation permissions
[**GetConversationWebchatQueueStatuses**](ConversationApi.md#getconversationwebchatqueuestatuses) | **GET** /conversation/conversations/queues/statuses | Retrieve a conversation webchat queue statuses
[**GetConversations**](ConversationApi.md#getconversations) | **GET** /conversation/conversations | Retrieve a list of conversation summaries newest to oldest
[**GetConversationsAutocomplete**](ConversationApi.md#getconversationsautocomplete) | **POST** /conversation/conversations/autocomplete | Retrieve a list of matching terms for a search field
[**GetConversationsSearch**](ConversationApi.md#getconversationssearch) | **POST** /conversation/conversations/search | Search conversations
[**GetLocationsForEngagement**](ConversationApi.md#getlocationsforengagement) | **POST** /conversation/locations | Get location data for engagement configuration
[**GetPbxAgent**](ConversationApi.md#getpbxagent) | **GET** /conversation/pbx/agent/{conversationPbxAgentUuid} | Get pbx agent
[**GetPbxAgentVoicemail**](ConversationApi.md#getpbxagentvoicemail) | **GET** /conversation/pbx/agent/voicemails/{recording_sid} | Get Agent Voicemail
[**GetPbxAgentVoicemails**](ConversationApi.md#getpbxagentvoicemails) | **GET** /conversation/pbx/agent/voicemails | Get Agent Voicemails
[**GetPbxAgents**](ConversationApi.md#getpbxagents) | **GET** /conversation/pbx/agent | Get pbx agents
[**GetPbxAudio**](ConversationApi.md#getpbxaudio) | **GET** /conversation/pbx/audio/{conversationPbxAudioUuid} | Get pbx audio
[**GetPbxAudioUsage**](ConversationApi.md#getpbxaudiousage) | **GET** /conversation/pbx/audio/{conversationPbxAudioUuid}/usage | Get pbx audio usage
[**GetPbxAudios**](ConversationApi.md#getpbxaudios) | **GET** /conversation/pbx/audio | Get pbx audios
[**GetPbxMenu**](ConversationApi.md#getpbxmenu) | **GET** /conversation/pbx/menu/{conversationPbxMenuUuid} | Get pbx menu
[**GetPbxMenus**](ConversationApi.md#getpbxmenus) | **GET** /conversation/pbx/menu | Get pbx menus
[**GetPbxPhoneNumber**](ConversationApi.md#getpbxphonenumber) | **GET** /conversation/pbx/phone_number/{conversationPbxPhoneNumberUuid} | Get pbx phoneNumber
[**GetPbxPhoneNumbers**](ConversationApi.md#getpbxphonenumbers) | **GET** /conversation/pbx/phone_number | Get pbx phoneNumbers
[**GetPbxQueue**](ConversationApi.md#getpbxqueue) | **GET** /conversation/pbx/queue/{conversationPbxQueueUuid} | Get pbx queue
[**GetPbxQueueVoicemail**](ConversationApi.md#getpbxqueuevoicemail) | **GET** /conversation/pbx/queues/{queue_uuid}/voicemails/{recording_sid} | Get Queue Voicemail
[**GetPbxQueueVoicemails**](ConversationApi.md#getpbxqueuevoicemails) | **GET** /conversation/pbx/queues/{queue_uuid}/voicemails | Get Queue Voicemails
[**GetPbxQueues**](ConversationApi.md#getpbxqueues) | **GET** /conversation/pbx/queue | Get pbx queues
[**GetPbxTimeBased**](ConversationApi.md#getpbxtimebased) | **GET** /conversation/pbx/time_based/{conversationPbxTimeBasedUuid} | Get pbx timeBased
[**GetPbxTimeBaseds**](ConversationApi.md#getpbxtimebaseds) | **GET** /conversation/pbx/time_based | Get pbx timeBaseds
[**GetPbxTimeRange**](ConversationApi.md#getpbxtimerange) | **GET** /conversation/pbx/time_range/{conversationPbxTimeRangeUuid} | Get pbx timeRange
[**GetPbxTimeRanges**](ConversationApi.md#getpbxtimeranges) | **GET** /conversation/pbx/time_range | Get pbx timeRanges
[**GetPbxVoicemailMailbox**](ConversationApi.md#getpbxvoicemailmailbox) | **GET** /conversation/pbx/voicemail_mailbox/{conversationPbxVoicemailMailboxUuid} | Get pbx voicemailMailbox
[**GetPbxVoicemailMailboxes**](ConversationApi.md#getpbxvoicemailmailboxes) | **GET** /conversation/pbx/voicemail_mailbox | Get pbx voicemailMailboxes
[**InsertConversationCannedMessage**](ConversationApi.md#insertconversationcannedmessage) | **POST** /conversation/canned_messages | Insert a canned message
[**InsertConversationDepartment**](ConversationApi.md#insertconversationdepartment) | **POST** /conversation/departments | Insert a department
[**InsertConversationEngagement**](ConversationApi.md#insertconversationengagement) | **POST** /conversation/engagements | Insert a engagement
[**InsertPbxAudio**](ConversationApi.md#insertpbxaudio) | **POST** /conversation/pbx/audio | Insert pbx audio
[**InsertPbxMenu**](ConversationApi.md#insertpbxmenu) | **POST** /conversation/pbx/menu | Insert pbx menu
[**InsertPbxQueue**](ConversationApi.md#insertpbxqueue) | **POST** /conversation/pbx/queue | Insert pbx queue
[**InsertPbxTimeBased**](ConversationApi.md#insertpbxtimebased) | **POST** /conversation/pbx/time_based | Insert pbx timeBased
[**InsertPbxTimeRange**](ConversationApi.md#insertpbxtimerange) | **POST** /conversation/pbx/time_range | Insert pbx timeRange
[**InsertPbxVoicemailMailbox**](ConversationApi.md#insertpbxvoicemailmailbox) | **POST** /conversation/pbx/voicemail_mailbox | Insert pbx voicemailMailbox
[**JoinConversation**](ConversationApi.md#joinconversation) | **PUT** /conversation/conversations/{conversation_uuid}/join | Join a conversation
[**LeaveConversation**](ConversationApi.md#leaveconversation) | **DELETE** /conversation/conversations/{conversation_uuid}/leave | Leave a conversation
[**ListenedPbxAgentVoicemail**](ConversationApi.md#listenedpbxagentvoicemail) | **GET** /conversation/pbx/agent/voicemails/{recording_sid}/listened | Listened Agent Voicemail
[**ListenedPbxQueueVoicemail**](ConversationApi.md#listenedpbxqueuevoicemail) | **GET** /conversation/pbx/queues/{queue_uuid}/voicemails/{recording_sid}/listened | Listened Queue Voicemail
[**MarkReadConversation**](ConversationApi.md#markreadconversation) | **PUT** /conversation/conversations/{conversation_uuid}/markread | Mark a conversation as read
[**ResetConversationPbxQueueStatistics**](ConversationApi.md#resetconversationpbxqueuestatistics) | **POST** /conversation/pbx/queues/{queue_uuid}/reset_statistics | reset statistics within the queue
[**SearchConversationCannedMessages**](ConversationApi.md#searchconversationcannedmessages) | **POST** /conversation/canned_messages/search | Search for canned messages by short_code
[**SmsUnsubscribeConversation**](ConversationApi.md#smsunsubscribeconversation) | **PUT** /conversation/conversations/{conversation_uuid}/sms_unsubscribe | Unsubscribe any SMS participants in this conversation
[**StartConversation**](ConversationApi.md#startconversation) | **PUT** /conversation/conversations | Start a conversation
[**UpdateAgentProfile**](ConversationApi.md#updateagentprofile) | **PUT** /conversation/agent/profile | Update agent profile
[**UpdateConversationCannedMessage**](ConversationApi.md#updateconversationcannedmessage) | **PUT** /conversation/canned_messages/{conversation_canned_message_oid} | Update a canned message
[**UpdateConversationDepartment**](ConversationApi.md#updateconversationdepartment) | **PUT** /conversation/departments/{conversation_department_oid} | Update a department
[**UpdateConversationEngagement**](ConversationApi.md#updateconversationengagement) | **PUT** /conversation/engagements/{conversation_engagement_oid} | Update a engagement
[**UpdateConversationWebchatQueueStatus**](ConversationApi.md#updateconversationwebchatqueuestatus) | **PUT** /conversation/conversations/queues/{queue_name}/status | Update status within the queue
[**UpdatePbxAgent**](ConversationApi.md#updatepbxagent) | **PUT** /conversation/pbx/agent/{conversationPbxAgentUuid} | Update pbx agent
[**UpdatePbxAudio**](ConversationApi.md#updatepbxaudio) | **PUT** /conversation/pbx/audio/{conversationPbxAudioUuid} | Update pbx audio
[**UpdatePbxMenu**](ConversationApi.md#updatepbxmenu) | **PUT** /conversation/pbx/menu/{conversationPbxMenuUuid} | Update pbx menu
[**UpdatePbxPhoneNumber**](ConversationApi.md#updatepbxphonenumber) | **PUT** /conversation/pbx/phone_number/{conversationPbxPhoneNumberUuid} | Update pbx phoneNumber
[**UpdatePbxQueue**](ConversationApi.md#updatepbxqueue) | **PUT** /conversation/pbx/queue/{conversationPbxQueueUuid} | Update pbx queue
[**UpdatePbxTimeBased**](ConversationApi.md#updatepbxtimebased) | **PUT** /conversation/pbx/time_based/{conversationPbxTimeBasedUuid} | Update pbx timeBased
[**UpdatePbxTimeRange**](ConversationApi.md#updatepbxtimerange) | **PUT** /conversation/pbx/time_range/{conversationPbxTimeRangeUuid} | Update pbx timeRange
[**UpdatePbxVoicemailMailbox**](ConversationApi.md#updatepbxvoicemailmailbox) | **PUT** /conversation/pbx/voicemail_mailbox/{conversationPbxVoicemailMailboxUuid} | Update pbx voicemailMailbox



## DeleteConversationCannedMessage

> void DeleteConversationCannedMessage (int conversationCannedMessageOid)

Delete a conversation canned message

Delete a conversation canned message 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteConversationCannedMessageExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationCannedMessageOid = 56;  // int | 

            try
            {
                // Delete a conversation canned message
                apiInstance.DeleteConversationCannedMessage(conversationCannedMessageOid);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.DeleteConversationCannedMessage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationCannedMessageOid** | **int**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteDepartment

> void DeleteDepartment (int conversationDepartmentOid)

Delete a conversation department

Delete a conversation department 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteDepartmentExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationDepartmentOid = 56;  // int | 

            try
            {
                // Delete a conversation department
                apiInstance.DeleteDepartment(conversationDepartmentOid);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.DeleteDepartment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationDepartmentOid** | **int**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteEngagement

> void DeleteEngagement (int conversationEngagementOid)

Delete a conversation engagement

Delete a conversation engagement 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteEngagementExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationEngagementOid = 56;  // int | 

            try
            {
                // Delete a conversation engagement
                apiInstance.DeleteEngagement(conversationEngagementOid);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.DeleteEngagement: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationEngagementOid** | **int**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeletePbxAgentVoicemail

> void DeletePbxAgentVoicemail (string recordingSid)

Delete Agent Voicemail

Delete pbx agent Voicemail 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeletePbxAgentVoicemailExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var recordingSid = "recordingSid_example";  // string | 

            try
            {
                // Delete Agent Voicemail
                apiInstance.DeletePbxAgentVoicemail(recordingSid);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.DeletePbxAgentVoicemail: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recordingSid** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeletePbxAudio

> ConversationPbxAudioResponse DeletePbxAudio (string conversationPbxAudioUuid)

Delete pbx audio

Delete a pbx audio 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeletePbxAudioExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxAudioUuid = "conversationPbxAudioUuid_example";  // string | 

            try
            {
                // Delete pbx audio
                ConversationPbxAudioResponse result = apiInstance.DeletePbxAudio(conversationPbxAudioUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.DeletePbxAudio: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxAudioUuid** | **string**|  | 

### Return type

[**ConversationPbxAudioResponse**](ConversationPbxAudioResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeletePbxMenu

> ConversationPbxMenuResponse DeletePbxMenu (string conversationPbxMenuUuid)

Delete pbx menu

Delete a pbx menu 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeletePbxMenuExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxMenuUuid = "conversationPbxMenuUuid_example";  // string | 

            try
            {
                // Delete pbx menu
                ConversationPbxMenuResponse result = apiInstance.DeletePbxMenu(conversationPbxMenuUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.DeletePbxMenu: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxMenuUuid** | **string**|  | 

### Return type

[**ConversationPbxMenuResponse**](ConversationPbxMenuResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeletePbxQueue

> ConversationPbxQueueResponse DeletePbxQueue (string conversationPbxQueueUuid)

Delete pbx queue

Delete a pbx queue 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeletePbxQueueExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxQueueUuid = "conversationPbxQueueUuid_example";  // string | 

            try
            {
                // Delete pbx queue
                ConversationPbxQueueResponse result = apiInstance.DeletePbxQueue(conversationPbxQueueUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.DeletePbxQueue: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxQueueUuid** | **string**|  | 

### Return type

[**ConversationPbxQueueResponse**](ConversationPbxQueueResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeletePbxQueueVoicemail

> void DeletePbxQueueVoicemail (string queueUuid, string recordingSid)

Delete Queue Voicemail

Delete pbx queue Voicemail 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeletePbxQueueVoicemailExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var queueUuid = "queueUuid_example";  // string | 
            var recordingSid = "recordingSid_example";  // string | 

            try
            {
                // Delete Queue Voicemail
                apiInstance.DeletePbxQueueVoicemail(queueUuid, recordingSid);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.DeletePbxQueueVoicemail: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueUuid** | **string**|  | 
 **recordingSid** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeletePbxTimeBased

> ConversationPbxTimeBasedResponse DeletePbxTimeBased (string conversationPbxTimeBasedUuid)

Delete pbx timeBased

Delete a pbx timeBased 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeletePbxTimeBasedExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxTimeBasedUuid = "conversationPbxTimeBasedUuid_example";  // string | 

            try
            {
                // Delete pbx timeBased
                ConversationPbxTimeBasedResponse result = apiInstance.DeletePbxTimeBased(conversationPbxTimeBasedUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.DeletePbxTimeBased: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxTimeBasedUuid** | **string**|  | 

### Return type

[**ConversationPbxTimeBasedResponse**](ConversationPbxTimeBasedResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeletePbxTimeRange

> ConversationPbxTimeRangeResponse DeletePbxTimeRange (string conversationPbxTimeRangeUuid)

Delete pbx timeRange

Delete a pbx timeRange 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeletePbxTimeRangeExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxTimeRangeUuid = "conversationPbxTimeRangeUuid_example";  // string | 

            try
            {
                // Delete pbx timeRange
                ConversationPbxTimeRangeResponse result = apiInstance.DeletePbxTimeRange(conversationPbxTimeRangeUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.DeletePbxTimeRange: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxTimeRangeUuid** | **string**|  | 

### Return type

[**ConversationPbxTimeRangeResponse**](ConversationPbxTimeRangeResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeletePbxVoicemailMailbox

> ConversationPbxVoicemailMailboxResponse DeletePbxVoicemailMailbox (string conversationPbxVoicemailMailboxUuid)

Delete pbx voicemailMailbox

Delete a pbx voicemailMailbox 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeletePbxVoicemailMailboxExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxVoicemailMailboxUuid = "conversationPbxVoicemailMailboxUuid_example";  // string | 

            try
            {
                // Delete pbx voicemailMailbox
                ConversationPbxVoicemailMailboxResponse result = apiInstance.DeletePbxVoicemailMailbox(conversationPbxVoicemailMailboxUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.DeletePbxVoicemailMailbox: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxVoicemailMailboxUuid** | **string**|  | 

### Return type

[**ConversationPbxVoicemailMailboxResponse**](ConversationPbxVoicemailMailboxResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAgentKeepAlive

> void GetAgentKeepAlive ()

Agent keep alive

Called periodically by the conversation API to keep the session alive. 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetAgentKeepAliveExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Agent keep alive
                apiInstance.GetAgentKeepAlive();
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetAgentKeepAlive: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAgentProfile

> ConversationAgentProfileResponse GetAgentProfile ()

Get agent profile

Retrieve the agents profile 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetAgentProfileExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Get agent profile
                ConversationAgentProfileResponse result = apiInstance.GetAgentProfile();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetAgentProfile: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationAgentProfileResponse**](ConversationAgentProfileResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAgentWebsocketAuthorization

> ConversationAgentAuthResponse GetAgentWebsocketAuthorization ()

Get agent websocket authorization

Retrieve a JWT to authorize an agent to make a websocket connection. 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetAgentWebsocketAuthorizationExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Get agent websocket authorization
                ConversationAgentAuthResponse result = apiInstance.GetAgentWebsocketAuthorization();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetAgentWebsocketAuthorization: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationAgentAuthResponse**](ConversationAgentAuthResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConversation

> ConversationResponse GetConversation (string conversationUuid, int? limit = null)

Retrieve a conversation

Retrieve a conversation including the participants and messages 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationUuid = "conversationUuid_example";  // string | 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Retrieve a conversation
                ConversationResponse result = apiInstance.GetConversation(conversationUuid, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationUuid** | **string**|  | 
 **limit** | **int?**|  | [optional] 

### Return type

[**ConversationResponse**](ConversationResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConversationCannedMessages

> ConversationCannedMessagesResponse GetConversationCannedMessages ()

Retrieve a list of canned messages ordered by short_code

Retrieve a list of canned messages ordered by short_code 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationCannedMessagesExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Retrieve a list of canned messages ordered by short_code
                ConversationCannedMessagesResponse result = apiInstance.GetConversationCannedMessages();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationCannedMessages: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationCannedMessagesResponse**](ConversationCannedMessagesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConversationContext

> ConversationWebchatContext GetConversationContext (string conversationUuid)

Get a webchat conversation context

Get a webchat conversation context 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationContextExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationUuid = "conversationUuid_example";  // string | 

            try
            {
                // Get a webchat conversation context
                ConversationWebchatContext result = apiInstance.GetConversationContext(conversationUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationContext: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationUuid** | **string**|  | 

### Return type

[**ConversationWebchatContext**](ConversationWebchatContext.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConversationDepartmentMemberList

> ConversationDepartmentMembersResponse GetConversationDepartmentMemberList ()

Retrieve a list of possible department members

Retrieve a list of possible department members 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationDepartmentMemberListExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Retrieve a list of possible department members
                ConversationDepartmentMembersResponse result = apiInstance.GetConversationDepartmentMemberList();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationDepartmentMemberList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationDepartmentMembersResponse**](ConversationDepartmentMembersResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConversationDepartments

> ConversationDepartmentsResponse GetConversationDepartments ()

Retrieve a list of departments ordered by name

Retrieve a list of departments ordered by name 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationDepartmentsExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Retrieve a list of departments ordered by name
                ConversationDepartmentsResponse result = apiInstance.GetConversationDepartments();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationDepartments: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationDepartmentsResponse**](ConversationDepartmentsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConversationEngagement

> ConversationEngagementResponse GetConversationEngagement (int conversationEngagementOid)

Retrieve an engagement

Retrieve an engagement 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationEngagementExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationEngagementOid = 56;  // int | 

            try
            {
                // Retrieve an engagement
                ConversationEngagementResponse result = apiInstance.GetConversationEngagement(conversationEngagementOid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationEngagement: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationEngagementOid** | **int**|  | 

### Return type

[**ConversationEngagementResponse**](ConversationEngagementResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConversationEngagements

> ConversationEngagementsResponse GetConversationEngagements ()

Retrieve a list of engagements ordered by name

Retrieve a list of engagements ordered by name 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationEngagementsExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Retrieve a list of engagements ordered by name
                ConversationEngagementsResponse result = apiInstance.GetConversationEngagements();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationEngagements: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationEngagementsResponse**](ConversationEngagementsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConversationMessages

> ConversationMessagesResponse GetConversationMessages (string conversationUuid, long since, int? limit = null)

Retrieve conversation messages

Retrieve conversation messages since a particular time 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationMessagesExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationUuid = "conversationUuid_example";  // string | 
            var since = 789L;  // long | 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Retrieve conversation messages
                ConversationMessagesResponse result = apiInstance.GetConversationMessages(conversationUuid, since, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationMessages: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationUuid** | **string**|  | 
 **since** | **long**|  | 
 **limit** | **int?**|  | [optional] 

### Return type

[**ConversationMessagesResponse**](ConversationMessagesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConversationMultimediaUploadUrl

> ConversationMultimediaUploadUrlResponse GetConversationMultimediaUploadUrl (string extension)

Get a presigned conversation multimedia upload URL

Get a presigned conversation multimedia upload URL 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationMultimediaUploadUrlExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var extension = "extension_example";  // string | 

            try
            {
                // Get a presigned conversation multimedia upload URL
                ConversationMultimediaUploadUrlResponse result = apiInstance.GetConversationMultimediaUploadUrl(extension);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationMultimediaUploadUrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **extension** | **string**|  | 

### Return type

[**ConversationMultimediaUploadUrlResponse**](ConversationMultimediaUploadUrlResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConversationPbxAudioUploadUrl

> ConversationPbxAudioUploadUrlResponse GetConversationPbxAudioUploadUrl (string extension)

Get a pre-signed conversation multimedia upload URL

Get a pre-signed conversation multimedia upload URL 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationPbxAudioUploadUrlExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var extension = "extension_example";  // string | 

            try
            {
                // Get a pre-signed conversation multimedia upload URL
                ConversationPbxAudioUploadUrlResponse result = apiInstance.GetConversationPbxAudioUploadUrl(extension);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationPbxAudioUploadUrl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **extension** | **string**|  | 

### Return type

[**ConversationPbxAudioUploadUrlResponse**](ConversationPbxAudioUploadUrlResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConversationPbxCustomerSnapshot

> ConversationPbxCustomerSnapshotResponse GetConversationPbxCustomerSnapshot (ConversationPbxCustomerSnapshotRequest pbxCustomerSnapshotRequest)

Get orders and customer information for a phone number

Retrieves all the orders, auto orders, and customer profile for a given phone number 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationPbxCustomerSnapshotExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var pbxCustomerSnapshotRequest = new ConversationPbxCustomerSnapshotRequest(); // ConversationPbxCustomerSnapshotRequest | Conversation pbx customer snapshot request

            try
            {
                // Get orders and customer information for a phone number
                ConversationPbxCustomerSnapshotResponse result = apiInstance.GetConversationPbxCustomerSnapshot(pbxCustomerSnapshotRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationPbxCustomerSnapshot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pbxCustomerSnapshotRequest** | [**ConversationPbxCustomerSnapshotRequest**](ConversationPbxCustomerSnapshotRequest.md)| Conversation pbx customer snapshot request | 

### Return type

[**ConversationPbxCustomerSnapshotResponse**](ConversationPbxCustomerSnapshotResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConversationPermissions

> ConversationPermissionsResponse GetConversationPermissions ()

Retrieve conversation permissions

Retrieve conversation permissions 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationPermissionsExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Retrieve conversation permissions
                ConversationPermissionsResponse result = apiInstance.GetConversationPermissions();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationPermissions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationPermissionsResponse**](ConversationPermissionsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConversationWebchatQueueStatuses

> ConversationWebchatQueueStatusesResponse GetConversationWebchatQueueStatuses ()

Retrieve a conversation webchat queue statuses

Retrieve a conversation webchat queue statuses including agent status and queue entries 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationWebchatQueueStatusesExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Retrieve a conversation webchat queue statuses
                ConversationWebchatQueueStatusesResponse result = apiInstance.GetConversationWebchatQueueStatuses();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationWebchatQueueStatuses: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationWebchatQueueStatusesResponse**](ConversationWebchatQueueStatusesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConversations

> ConversationsResponse GetConversations (string medium = null, string before = null, int? limit = null, int? offset = null)

Retrieve a list of conversation summaries newest to oldest

Retrieve a list of conversation summaries that are ordered newest to oldest, include the most recent message and whether its been read. 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationsExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var medium = "medium_example";  // string |  (optional) 
            var before = "before_example";  // string |  (optional) 
            var limit = 100;  // int? | The maximum number of records to return on this one API call. (Max 200) (optional)  (default to 100)
            var offset = 0;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)

            try
            {
                // Retrieve a list of conversation summaries newest to oldest
                ConversationsResponse result = apiInstance.GetConversations(medium, before, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversations: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **medium** | **string**|  | [optional] 
 **before** | **string**|  | [optional] 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Max 200) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]

### Return type

[**ConversationsResponse**](ConversationsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConversationsAutocomplete

> ConversationAutocompleteResponse GetConversationsAutocomplete (ConversationAutocompleteRequest autocompleteRequest)

Retrieve a list of matching terms for a search field

Retrieve a list of matching terms for a search field 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationsAutocompleteExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var autocompleteRequest = new ConversationAutocompleteRequest(); // ConversationAutocompleteRequest | Autocomplete Request

            try
            {
                // Retrieve a list of matching terms for a search field
                ConversationAutocompleteResponse result = apiInstance.GetConversationsAutocomplete(autocompleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationsAutocomplete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autocompleteRequest** | [**ConversationAutocompleteRequest**](ConversationAutocompleteRequest.md)| Autocomplete Request | 

### Return type

[**ConversationAutocompleteResponse**](ConversationAutocompleteResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConversationsSearch

> ConversationSearchResponse GetConversationsSearch (ConversationSearchRequest searchRequest)

Search conversations

Search conversations 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationsSearchExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var searchRequest = new ConversationSearchRequest(); // ConversationSearchRequest | Search Request

            try
            {
                // Search conversations
                ConversationSearchResponse result = apiInstance.GetConversationsSearch(searchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationsSearch: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchRequest** | [**ConversationSearchRequest**](ConversationSearchRequest.md)| Search Request | 

### Return type

[**ConversationSearchResponse**](ConversationSearchResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetLocationsForEngagement

> ConversationLocationsResponse GetLocationsForEngagement ()

Get location data for engagement configuration

Get location data for engagement configuration 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetLocationsForEngagementExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Get location data for engagement configuration
                ConversationLocationsResponse result = apiInstance.GetLocationsForEngagement();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetLocationsForEngagement: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationLocationsResponse**](ConversationLocationsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxAgent

> ConversationPbxAgentResponse GetPbxAgent (string conversationPbxAgentUuid)

Get pbx agent

Retrieve a pbx agent 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxAgentExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxAgentUuid = "conversationPbxAgentUuid_example";  // string | 

            try
            {
                // Get pbx agent
                ConversationPbxAgentResponse result = apiInstance.GetPbxAgent(conversationPbxAgentUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxAgent: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxAgentUuid** | **string**|  | 

### Return type

[**ConversationPbxAgentResponse**](ConversationPbxAgentResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxAgentVoicemail

> ConversationPbxVoicemailMessageResponse GetPbxAgentVoicemail (string recordingSid)

Get Agent Voicemail

Retrieve pbx agent Voicemail 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxAgentVoicemailExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var recordingSid = "recordingSid_example";  // string | 

            try
            {
                // Get Agent Voicemail
                ConversationPbxVoicemailMessageResponse result = apiInstance.GetPbxAgentVoicemail(recordingSid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxAgentVoicemail: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recordingSid** | **string**|  | 

### Return type

[**ConversationPbxVoicemailMessageResponse**](ConversationPbxVoicemailMessageResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxAgentVoicemails

> ConversationPbxVoicemailMessageSummariesResponse GetPbxAgentVoicemails ()

Get Agent Voicemails

Retrieve pbx agent Voicemails 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxAgentVoicemailsExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Get Agent Voicemails
                ConversationPbxVoicemailMessageSummariesResponse result = apiInstance.GetPbxAgentVoicemails();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxAgentVoicemails: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationPbxVoicemailMessageSummariesResponse**](ConversationPbxVoicemailMessageSummariesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxAgents

> ConversationPbxAgentsResponse GetPbxAgents ()

Get pbx agents

Retrieve pbx agents 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxAgentsExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Get pbx agents
                ConversationPbxAgentsResponse result = apiInstance.GetPbxAgents();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxAgents: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationPbxAgentsResponse**](ConversationPbxAgentsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxAudio

> ConversationPbxAudioResponse GetPbxAudio (string conversationPbxAudioUuid)

Get pbx audio

Retrieve a pbx audio 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxAudioExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxAudioUuid = "conversationPbxAudioUuid_example";  // string | 

            try
            {
                // Get pbx audio
                ConversationPbxAudioResponse result = apiInstance.GetPbxAudio(conversationPbxAudioUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxAudio: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxAudioUuid** | **string**|  | 

### Return type

[**ConversationPbxAudioResponse**](ConversationPbxAudioResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxAudioUsage

> ConversationPbxAudioUsageResponse GetPbxAudioUsage (string conversationPbxAudioUuid)

Get pbx audio usage

Retrieve a pbx audio usage 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxAudioUsageExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxAudioUuid = "conversationPbxAudioUuid_example";  // string | 

            try
            {
                // Get pbx audio usage
                ConversationPbxAudioUsageResponse result = apiInstance.GetPbxAudioUsage(conversationPbxAudioUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxAudioUsage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxAudioUuid** | **string**|  | 

### Return type

[**ConversationPbxAudioUsageResponse**](ConversationPbxAudioUsageResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxAudios

> ConversationPbxAudiosResponse GetPbxAudios ()

Get pbx audios

Retrieve pbx audios 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxAudiosExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Get pbx audios
                ConversationPbxAudiosResponse result = apiInstance.GetPbxAudios();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxAudios: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationPbxAudiosResponse**](ConversationPbxAudiosResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxMenu

> ConversationPbxMenuResponse GetPbxMenu (string conversationPbxMenuUuid)

Get pbx menu

Retrieve a pbx menu 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxMenuExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxMenuUuid = "conversationPbxMenuUuid_example";  // string | 

            try
            {
                // Get pbx menu
                ConversationPbxMenuResponse result = apiInstance.GetPbxMenu(conversationPbxMenuUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxMenu: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxMenuUuid** | **string**|  | 

### Return type

[**ConversationPbxMenuResponse**](ConversationPbxMenuResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxMenus

> ConversationPbxMenusResponse GetPbxMenus ()

Get pbx menus

Retrieve pbx menus 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxMenusExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Get pbx menus
                ConversationPbxMenusResponse result = apiInstance.GetPbxMenus();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxMenus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationPbxMenusResponse**](ConversationPbxMenusResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxPhoneNumber

> ConversationPbxPhoneNumberResponse GetPbxPhoneNumber (string conversationPbxPhoneNumberUuid)

Get pbx phoneNumber

Retrieve a pbx phoneNumber 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxPhoneNumberExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxPhoneNumberUuid = "conversationPbxPhoneNumberUuid_example";  // string | 

            try
            {
                // Get pbx phoneNumber
                ConversationPbxPhoneNumberResponse result = apiInstance.GetPbxPhoneNumber(conversationPbxPhoneNumberUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxPhoneNumber: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxPhoneNumberUuid** | **string**|  | 

### Return type

[**ConversationPbxPhoneNumberResponse**](ConversationPbxPhoneNumberResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxPhoneNumbers

> ConversationPbxPhoneNumbersResponse GetPbxPhoneNumbers ()

Get pbx phoneNumbers

Retrieve pbx phoneNumbers 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxPhoneNumbersExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Get pbx phoneNumbers
                ConversationPbxPhoneNumbersResponse result = apiInstance.GetPbxPhoneNumbers();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxPhoneNumbers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationPbxPhoneNumbersResponse**](ConversationPbxPhoneNumbersResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxQueue

> ConversationPbxQueueResponse GetPbxQueue (string conversationPbxQueueUuid)

Get pbx queue

Retrieve a pbx queue 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxQueueExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxQueueUuid = "conversationPbxQueueUuid_example";  // string | 

            try
            {
                // Get pbx queue
                ConversationPbxQueueResponse result = apiInstance.GetPbxQueue(conversationPbxQueueUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxQueue: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxQueueUuid** | **string**|  | 

### Return type

[**ConversationPbxQueueResponse**](ConversationPbxQueueResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxQueueVoicemail

> ConversationPbxVoicemailMessageResponse GetPbxQueueVoicemail (string queueUuid, string recordingSid)

Get Queue Voicemail

Retrieve pbx queue Voicemail 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxQueueVoicemailExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var queueUuid = "queueUuid_example";  // string | 
            var recordingSid = "recordingSid_example";  // string | 

            try
            {
                // Get Queue Voicemail
                ConversationPbxVoicemailMessageResponse result = apiInstance.GetPbxQueueVoicemail(queueUuid, recordingSid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxQueueVoicemail: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueUuid** | **string**|  | 
 **recordingSid** | **string**|  | 

### Return type

[**ConversationPbxVoicemailMessageResponse**](ConversationPbxVoicemailMessageResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxQueueVoicemails

> ConversationPbxVoicemailMessageSummariesResponse GetPbxQueueVoicemails (string queueUuid)

Get Queue Voicemails

Retrieve pbx queue voicemails 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxQueueVoicemailsExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var queueUuid = "queueUuid_example";  // string | 

            try
            {
                // Get Queue Voicemails
                ConversationPbxVoicemailMessageSummariesResponse result = apiInstance.GetPbxQueueVoicemails(queueUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxQueueVoicemails: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueUuid** | **string**|  | 

### Return type

[**ConversationPbxVoicemailMessageSummariesResponse**](ConversationPbxVoicemailMessageSummariesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxQueues

> ConversationPbxQueuesResponse GetPbxQueues ()

Get pbx queues

Retrieve pbx queues 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxQueuesExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Get pbx queues
                ConversationPbxQueuesResponse result = apiInstance.GetPbxQueues();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxQueues: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationPbxQueuesResponse**](ConversationPbxQueuesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxTimeBased

> ConversationPbxTimeBasedResponse GetPbxTimeBased (string conversationPbxTimeBasedUuid)

Get pbx timeBased

Retrieve a pbx timeBased 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxTimeBasedExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxTimeBasedUuid = "conversationPbxTimeBasedUuid_example";  // string | 

            try
            {
                // Get pbx timeBased
                ConversationPbxTimeBasedResponse result = apiInstance.GetPbxTimeBased(conversationPbxTimeBasedUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxTimeBased: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxTimeBasedUuid** | **string**|  | 

### Return type

[**ConversationPbxTimeBasedResponse**](ConversationPbxTimeBasedResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxTimeBaseds

> ConversationPbxTimeBasedsResponse GetPbxTimeBaseds ()

Get pbx timeBaseds

Retrieve pbx timeBaseds 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxTimeBasedsExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Get pbx timeBaseds
                ConversationPbxTimeBasedsResponse result = apiInstance.GetPbxTimeBaseds();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxTimeBaseds: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationPbxTimeBasedsResponse**](ConversationPbxTimeBasedsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxTimeRange

> ConversationPbxTimeRangeResponse GetPbxTimeRange (string conversationPbxTimeRangeUuid)

Get pbx timeRange

Retrieve a pbx timeRange 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxTimeRangeExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxTimeRangeUuid = "conversationPbxTimeRangeUuid_example";  // string | 

            try
            {
                // Get pbx timeRange
                ConversationPbxTimeRangeResponse result = apiInstance.GetPbxTimeRange(conversationPbxTimeRangeUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxTimeRange: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxTimeRangeUuid** | **string**|  | 

### Return type

[**ConversationPbxTimeRangeResponse**](ConversationPbxTimeRangeResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxTimeRanges

> ConversationPbxTimeRangesResponse GetPbxTimeRanges ()

Get pbx timeRanges

Retrieve pbx timeRanges 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxTimeRangesExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Get pbx timeRanges
                ConversationPbxTimeRangesResponse result = apiInstance.GetPbxTimeRanges();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxTimeRanges: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationPbxTimeRangesResponse**](ConversationPbxTimeRangesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxVoicemailMailbox

> ConversationPbxVoicemailMailboxResponse GetPbxVoicemailMailbox (string conversationPbxVoicemailMailboxUuid)

Get pbx voicemailMailbox

Retrieve a pbx voicemailMailbox 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxVoicemailMailboxExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxVoicemailMailboxUuid = "conversationPbxVoicemailMailboxUuid_example";  // string | 

            try
            {
                // Get pbx voicemailMailbox
                ConversationPbxVoicemailMailboxResponse result = apiInstance.GetPbxVoicemailMailbox(conversationPbxVoicemailMailboxUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxVoicemailMailbox: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxVoicemailMailboxUuid** | **string**|  | 

### Return type

[**ConversationPbxVoicemailMailboxResponse**](ConversationPbxVoicemailMailboxResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPbxVoicemailMailboxes

> ConversationPbxVoicemailMailboxesResponse GetPbxVoicemailMailboxes ()

Get pbx voicemailMailboxes

Retrieve pbx voicemailMailboxes 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxVoicemailMailboxesExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project


            try
            {
                // Get pbx voicemailMailboxes
                ConversationPbxVoicemailMailboxesResponse result = apiInstance.GetPbxVoicemailMailboxes();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxVoicemailMailboxes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ConversationPbxVoicemailMailboxesResponse**](ConversationPbxVoicemailMailboxesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InsertConversationCannedMessage

> ConversationCannedMessageResponse InsertConversationCannedMessage (ConversationCannedMessage cannedMessage)

Insert a canned message

Insert a canned message 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertConversationCannedMessageExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var cannedMessage = new ConversationCannedMessage(); // ConversationCannedMessage | Canned message

            try
            {
                // Insert a canned message
                ConversationCannedMessageResponse result = apiInstance.InsertConversationCannedMessage(cannedMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.InsertConversationCannedMessage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cannedMessage** | [**ConversationCannedMessage**](ConversationCannedMessage.md)| Canned message | 

### Return type

[**ConversationCannedMessageResponse**](ConversationCannedMessageResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InsertConversationDepartment

> ConversationDepartmentResponse InsertConversationDepartment (ConversationDepartment department)

Insert a department

Insert a department 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertConversationDepartmentExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var department = new ConversationDepartment(); // ConversationDepartment | Department

            try
            {
                // Insert a department
                ConversationDepartmentResponse result = apiInstance.InsertConversationDepartment(department);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.InsertConversationDepartment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **department** | [**ConversationDepartment**](ConversationDepartment.md)| Department | 

### Return type

[**ConversationDepartmentResponse**](ConversationDepartmentResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InsertConversationEngagement

> ConversationEngagementResponse InsertConversationEngagement (ConversationEngagement engagement)

Insert a engagement

Insert a engagement 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertConversationEngagementExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var engagement = new ConversationEngagement(); // ConversationEngagement | Engagement

            try
            {
                // Insert a engagement
                ConversationEngagementResponse result = apiInstance.InsertConversationEngagement(engagement);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.InsertConversationEngagement: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **engagement** | [**ConversationEngagement**](ConversationEngagement.md)| Engagement | 

### Return type

[**ConversationEngagementResponse**](ConversationEngagementResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InsertPbxAudio

> ConversationPbxAudioResponse InsertPbxAudio (ConversationPbxAudio pbxAudio)

Insert pbx audio

Insert a pbx audio 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertPbxAudioExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var pbxAudio = new ConversationPbxAudio(); // ConversationPbxAudio | Pbx Audio

            try
            {
                // Insert pbx audio
                ConversationPbxAudioResponse result = apiInstance.InsertPbxAudio(pbxAudio);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.InsertPbxAudio: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pbxAudio** | [**ConversationPbxAudio**](ConversationPbxAudio.md)| Pbx Audio | 

### Return type

[**ConversationPbxAudioResponse**](ConversationPbxAudioResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InsertPbxMenu

> ConversationPbxMenuResponse InsertPbxMenu (ConversationPbxMenu pbxMenu)

Insert pbx menu

Insert a pbx menu 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertPbxMenuExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var pbxMenu = new ConversationPbxMenu(); // ConversationPbxMenu | Pbx Menu

            try
            {
                // Insert pbx menu
                ConversationPbxMenuResponse result = apiInstance.InsertPbxMenu(pbxMenu);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.InsertPbxMenu: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pbxMenu** | [**ConversationPbxMenu**](ConversationPbxMenu.md)| Pbx Menu | 

### Return type

[**ConversationPbxMenuResponse**](ConversationPbxMenuResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InsertPbxQueue

> ConversationPbxQueueResponse InsertPbxQueue (ConversationPbxQueue pbxQueue)

Insert pbx queue

Insert a pbx queue 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertPbxQueueExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var pbxQueue = new ConversationPbxQueue(); // ConversationPbxQueue | Pbx Queue

            try
            {
                // Insert pbx queue
                ConversationPbxQueueResponse result = apiInstance.InsertPbxQueue(pbxQueue);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.InsertPbxQueue: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pbxQueue** | [**ConversationPbxQueue**](ConversationPbxQueue.md)| Pbx Queue | 

### Return type

[**ConversationPbxQueueResponse**](ConversationPbxQueueResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InsertPbxTimeBased

> ConversationPbxTimeBasedResponse InsertPbxTimeBased (ConversationPbxTimeBased pbxTimeBased)

Insert pbx timeBased

Insert a pbx timeBased 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertPbxTimeBasedExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var pbxTimeBased = new ConversationPbxTimeBased(); // ConversationPbxTimeBased | Pbx TimeBased

            try
            {
                // Insert pbx timeBased
                ConversationPbxTimeBasedResponse result = apiInstance.InsertPbxTimeBased(pbxTimeBased);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.InsertPbxTimeBased: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pbxTimeBased** | [**ConversationPbxTimeBased**](ConversationPbxTimeBased.md)| Pbx TimeBased | 

### Return type

[**ConversationPbxTimeBasedResponse**](ConversationPbxTimeBasedResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InsertPbxTimeRange

> ConversationPbxTimeRangeResponse InsertPbxTimeRange (ConversationPbxTimeRange pbxTimeRange)

Insert pbx timeRange

Insert a pbx timeRange 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertPbxTimeRangeExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var pbxTimeRange = new ConversationPbxTimeRange(); // ConversationPbxTimeRange | Pbx TimeRange

            try
            {
                // Insert pbx timeRange
                ConversationPbxTimeRangeResponse result = apiInstance.InsertPbxTimeRange(pbxTimeRange);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.InsertPbxTimeRange: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pbxTimeRange** | [**ConversationPbxTimeRange**](ConversationPbxTimeRange.md)| Pbx TimeRange | 

### Return type

[**ConversationPbxTimeRangeResponse**](ConversationPbxTimeRangeResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InsertPbxVoicemailMailbox

> ConversationPbxVoicemailMailboxResponse InsertPbxVoicemailMailbox (ConversationPbxVoicemailMailbox pbxVoicemailMailbox)

Insert pbx voicemailMailbox

Insert a pbx voicemailMailbox 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertPbxVoicemailMailboxExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var pbxVoicemailMailbox = new ConversationPbxVoicemailMailbox(); // ConversationPbxVoicemailMailbox | Pbx VoicemailMailbox

            try
            {
                // Insert pbx voicemailMailbox
                ConversationPbxVoicemailMailboxResponse result = apiInstance.InsertPbxVoicemailMailbox(pbxVoicemailMailbox);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.InsertPbxVoicemailMailbox: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pbxVoicemailMailbox** | [**ConversationPbxVoicemailMailbox**](ConversationPbxVoicemailMailbox.md)| Pbx VoicemailMailbox | 

### Return type

[**ConversationPbxVoicemailMailboxResponse**](ConversationPbxVoicemailMailboxResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## JoinConversation

> void JoinConversation (string conversationUuid, ConversationJoinRequest joinRequest = null)

Join a conversation

Join a conversation 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class JoinConversationExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationUuid = "conversationUuid_example";  // string | 
            var joinRequest = new ConversationJoinRequest(); // ConversationJoinRequest | Join request (optional) 

            try
            {
                // Join a conversation
                apiInstance.JoinConversation(conversationUuid, joinRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.JoinConversation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationUuid** | **string**|  | 
 **joinRequest** | [**ConversationJoinRequest**](ConversationJoinRequest.md)| Join request | [optional] 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## LeaveConversation

> void LeaveConversation (string conversationUuid)

Leave a conversation

Leave a conversation 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class LeaveConversationExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationUuid = "conversationUuid_example";  // string | 

            try
            {
                // Leave a conversation
                apiInstance.LeaveConversation(conversationUuid);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.LeaveConversation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationUuid** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListenedPbxAgentVoicemail

> void ListenedPbxAgentVoicemail (string recordingSid)

Listened Agent Voicemail

Listened pbx agent Voicemail 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ListenedPbxAgentVoicemailExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var recordingSid = "recordingSid_example";  // string | 

            try
            {
                // Listened Agent Voicemail
                apiInstance.ListenedPbxAgentVoicemail(recordingSid);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.ListenedPbxAgentVoicemail: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recordingSid** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListenedPbxQueueVoicemail

> void ListenedPbxQueueVoicemail (string queueUuid, string recordingSid)

Listened Queue Voicemail

Listened pbx queue Voicemail 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ListenedPbxQueueVoicemailExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var queueUuid = "queueUuid_example";  // string | 
            var recordingSid = "recordingSid_example";  // string | 

            try
            {
                // Listened Queue Voicemail
                apiInstance.ListenedPbxQueueVoicemail(queueUuid, recordingSid);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.ListenedPbxQueueVoicemail: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueUuid** | **string**|  | 
 **recordingSid** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## MarkReadConversation

> void MarkReadConversation (string conversationUuid)

Mark a conversation as read

Mark a conversation as read 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class MarkReadConversationExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationUuid = "conversationUuid_example";  // string | 

            try
            {
                // Mark a conversation as read
                apiInstance.MarkReadConversation(conversationUuid);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.MarkReadConversation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationUuid** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ResetConversationPbxQueueStatistics

> void ResetConversationPbxQueueStatistics (string queueUuid)

reset statistics within the queue

reset statistics within the queue 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ResetConversationPbxQueueStatisticsExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var queueUuid = "queueUuid_example";  // string | 

            try
            {
                // reset statistics within the queue
                apiInstance.ResetConversationPbxQueueStatistics(queueUuid);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.ResetConversationPbxQueueStatistics: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueUuid** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SearchConversationCannedMessages

> ConversationCannedMessagesResponse SearchConversationCannedMessages (ConversationCannedMessagesSearch searchRequest)

Search for canned messages by short_code

Search for canned messages by short_code 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SearchConversationCannedMessagesExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var searchRequest = new ConversationCannedMessagesSearch(); // ConversationCannedMessagesSearch | Search request

            try
            {
                // Search for canned messages by short_code
                ConversationCannedMessagesResponse result = apiInstance.SearchConversationCannedMessages(searchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.SearchConversationCannedMessages: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchRequest** | [**ConversationCannedMessagesSearch**](ConversationCannedMessagesSearch.md)| Search request | 

### Return type

[**ConversationCannedMessagesResponse**](ConversationCannedMessagesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SmsUnsubscribeConversation

> void SmsUnsubscribeConversation (string conversationUuid)

Unsubscribe any SMS participants in this conversation

Unsubscribe any SMS participants in this conversation 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SmsUnsubscribeConversationExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationUuid = "conversationUuid_example";  // string | 

            try
            {
                // Unsubscribe any SMS participants in this conversation
                apiInstance.SmsUnsubscribeConversation(conversationUuid);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.SmsUnsubscribeConversation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationUuid** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## StartConversation

> ConversationStartResponse StartConversation (ConversationStartRequest startRequest)

Start a conversation

Start a new conversation 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class StartConversationExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var startRequest = new ConversationStartRequest(); // ConversationStartRequest | Start request

            try
            {
                // Start a conversation
                ConversationStartResponse result = apiInstance.StartConversation(startRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.StartConversation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startRequest** | [**ConversationStartRequest**](ConversationStartRequest.md)| Start request | 

### Return type

[**ConversationStartResponse**](ConversationStartResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateAgentProfile

> ConversationAgentProfileResponse UpdateAgentProfile (ConversationAgentProfile profileRequest)

Update agent profile

Update agent profile 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateAgentProfileExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var profileRequest = new ConversationAgentProfile(); // ConversationAgentProfile | Profile request

            try
            {
                // Update agent profile
                ConversationAgentProfileResponse result = apiInstance.UpdateAgentProfile(profileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdateAgentProfile: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profileRequest** | [**ConversationAgentProfile**](ConversationAgentProfile.md)| Profile request | 

### Return type

[**ConversationAgentProfileResponse**](ConversationAgentProfileResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateConversationCannedMessage

> ConversationCannedMessageResponse UpdateConversationCannedMessage (int conversationCannedMessageOid, ConversationCannedMessage cannedMessage)

Update a canned message

Update a canned message 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateConversationCannedMessageExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationCannedMessageOid = 56;  // int | 
            var cannedMessage = new ConversationCannedMessage(); // ConversationCannedMessage | Canned message

            try
            {
                // Update a canned message
                ConversationCannedMessageResponse result = apiInstance.UpdateConversationCannedMessage(conversationCannedMessageOid, cannedMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdateConversationCannedMessage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationCannedMessageOid** | **int**|  | 
 **cannedMessage** | [**ConversationCannedMessage**](ConversationCannedMessage.md)| Canned message | 

### Return type

[**ConversationCannedMessageResponse**](ConversationCannedMessageResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateConversationDepartment

> ConversationDepartmentResponse UpdateConversationDepartment (int conversationDepartmentOid, ConversationDepartment department)

Update a department

Update a department 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateConversationDepartmentExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationDepartmentOid = 56;  // int | 
            var department = new ConversationDepartment(); // ConversationDepartment | Department

            try
            {
                // Update a department
                ConversationDepartmentResponse result = apiInstance.UpdateConversationDepartment(conversationDepartmentOid, department);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdateConversationDepartment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationDepartmentOid** | **int**|  | 
 **department** | [**ConversationDepartment**](ConversationDepartment.md)| Department | 

### Return type

[**ConversationDepartmentResponse**](ConversationDepartmentResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateConversationEngagement

> ConversationEngagementResponse UpdateConversationEngagement (int conversationEngagementOid, ConversationEngagement engagement)

Update a engagement

Update a engagement 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateConversationEngagementExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationEngagementOid = 56;  // int | 
            var engagement = new ConversationEngagement(); // ConversationEngagement | Engagement

            try
            {
                // Update a engagement
                ConversationEngagementResponse result = apiInstance.UpdateConversationEngagement(conversationEngagementOid, engagement);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdateConversationEngagement: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationEngagementOid** | **int**|  | 
 **engagement** | [**ConversationEngagement**](ConversationEngagement.md)| Engagement | 

### Return type

[**ConversationEngagementResponse**](ConversationEngagementResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateConversationWebchatQueueStatus

> void UpdateConversationWebchatQueueStatus (string queueName, ConversationWebchatQueueStatusUpdateRequest statusRequest)

Update status within the queue

Update status within the queue 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateConversationWebchatQueueStatusExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var queueName = "queueName_example";  // string | 
            var statusRequest = new ConversationWebchatQueueStatusUpdateRequest(); // ConversationWebchatQueueStatusUpdateRequest | Status request

            try
            {
                // Update status within the queue
                apiInstance.UpdateConversationWebchatQueueStatus(queueName, statusRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdateConversationWebchatQueueStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueName** | **string**|  | 
 **statusRequest** | [**ConversationWebchatQueueStatusUpdateRequest**](ConversationWebchatQueueStatusUpdateRequest.md)| Status request | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePbxAgent

> ConversationPbxAgentResponse UpdatePbxAgent (string conversationPbxAgentUuid, ConversationPbxAgent pbxAgent)

Update pbx agent

Update a pbx agent 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdatePbxAgentExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxAgentUuid = "conversationPbxAgentUuid_example";  // string | 
            var pbxAgent = new ConversationPbxAgent(); // ConversationPbxAgent | Pbx Agent

            try
            {
                // Update pbx agent
                ConversationPbxAgentResponse result = apiInstance.UpdatePbxAgent(conversationPbxAgentUuid, pbxAgent);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdatePbxAgent: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxAgentUuid** | **string**|  | 
 **pbxAgent** | [**ConversationPbxAgent**](ConversationPbxAgent.md)| Pbx Agent | 

### Return type

[**ConversationPbxAgentResponse**](ConversationPbxAgentResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePbxAudio

> ConversationPbxAudioResponse UpdatePbxAudio (string conversationPbxAudioUuid, ConversationPbxAudio pbxAudio)

Update pbx audio

Update a pbx audio 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdatePbxAudioExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxAudioUuid = "conversationPbxAudioUuid_example";  // string | 
            var pbxAudio = new ConversationPbxAudio(); // ConversationPbxAudio | Pbx Audio

            try
            {
                // Update pbx audio
                ConversationPbxAudioResponse result = apiInstance.UpdatePbxAudio(conversationPbxAudioUuid, pbxAudio);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdatePbxAudio: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxAudioUuid** | **string**|  | 
 **pbxAudio** | [**ConversationPbxAudio**](ConversationPbxAudio.md)| Pbx Audio | 

### Return type

[**ConversationPbxAudioResponse**](ConversationPbxAudioResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePbxMenu

> ConversationPbxMenuResponse UpdatePbxMenu (string conversationPbxMenuUuid, ConversationPbxMenu pbxMenu)

Update pbx menu

Update a pbx menu 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdatePbxMenuExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxMenuUuid = "conversationPbxMenuUuid_example";  // string | 
            var pbxMenu = new ConversationPbxMenu(); // ConversationPbxMenu | Pbx Menu

            try
            {
                // Update pbx menu
                ConversationPbxMenuResponse result = apiInstance.UpdatePbxMenu(conversationPbxMenuUuid, pbxMenu);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdatePbxMenu: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxMenuUuid** | **string**|  | 
 **pbxMenu** | [**ConversationPbxMenu**](ConversationPbxMenu.md)| Pbx Menu | 

### Return type

[**ConversationPbxMenuResponse**](ConversationPbxMenuResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePbxPhoneNumber

> ConversationPbxPhoneNumberResponse UpdatePbxPhoneNumber (string conversationPbxPhoneNumberUuid, ConversationPbxPhoneNumber pbxPhoneNumber)

Update pbx phoneNumber

Update a pbx phoneNumber 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdatePbxPhoneNumberExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxPhoneNumberUuid = "conversationPbxPhoneNumberUuid_example";  // string | 
            var pbxPhoneNumber = new ConversationPbxPhoneNumber(); // ConversationPbxPhoneNumber | Pbx PhoneNumber

            try
            {
                // Update pbx phoneNumber
                ConversationPbxPhoneNumberResponse result = apiInstance.UpdatePbxPhoneNumber(conversationPbxPhoneNumberUuid, pbxPhoneNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdatePbxPhoneNumber: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxPhoneNumberUuid** | **string**|  | 
 **pbxPhoneNumber** | [**ConversationPbxPhoneNumber**](ConversationPbxPhoneNumber.md)| Pbx PhoneNumber | 

### Return type

[**ConversationPbxPhoneNumberResponse**](ConversationPbxPhoneNumberResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePbxQueue

> ConversationPbxQueueResponse UpdatePbxQueue (string conversationPbxQueueUuid, ConversationPbxQueue pbxQueue)

Update pbx queue

Update a pbx queue 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdatePbxQueueExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxQueueUuid = "conversationPbxQueueUuid_example";  // string | 
            var pbxQueue = new ConversationPbxQueue(); // ConversationPbxQueue | Pbx Queue

            try
            {
                // Update pbx queue
                ConversationPbxQueueResponse result = apiInstance.UpdatePbxQueue(conversationPbxQueueUuid, pbxQueue);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdatePbxQueue: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxQueueUuid** | **string**|  | 
 **pbxQueue** | [**ConversationPbxQueue**](ConversationPbxQueue.md)| Pbx Queue | 

### Return type

[**ConversationPbxQueueResponse**](ConversationPbxQueueResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePbxTimeBased

> ConversationPbxTimeBasedResponse UpdatePbxTimeBased (string conversationPbxTimeBasedUuid, ConversationPbxTimeBased pbxTimeBased)

Update pbx timeBased

Update a pbx timeBased 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdatePbxTimeBasedExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxTimeBasedUuid = "conversationPbxTimeBasedUuid_example";  // string | 
            var pbxTimeBased = new ConversationPbxTimeBased(); // ConversationPbxTimeBased | Pbx TimeBased

            try
            {
                // Update pbx timeBased
                ConversationPbxTimeBasedResponse result = apiInstance.UpdatePbxTimeBased(conversationPbxTimeBasedUuid, pbxTimeBased);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdatePbxTimeBased: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxTimeBasedUuid** | **string**|  | 
 **pbxTimeBased** | [**ConversationPbxTimeBased**](ConversationPbxTimeBased.md)| Pbx TimeBased | 

### Return type

[**ConversationPbxTimeBasedResponse**](ConversationPbxTimeBasedResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePbxTimeRange

> ConversationPbxTimeRangeResponse UpdatePbxTimeRange (string conversationPbxTimeRangeUuid, ConversationPbxTimeRange pbxTimeRange)

Update pbx timeRange

Update a pbx timeRange 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdatePbxTimeRangeExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxTimeRangeUuid = "conversationPbxTimeRangeUuid_example";  // string | 
            var pbxTimeRange = new ConversationPbxTimeRange(); // ConversationPbxTimeRange | Pbx TimeRange

            try
            {
                // Update pbx timeRange
                ConversationPbxTimeRangeResponse result = apiInstance.UpdatePbxTimeRange(conversationPbxTimeRangeUuid, pbxTimeRange);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdatePbxTimeRange: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxTimeRangeUuid** | **string**|  | 
 **pbxTimeRange** | [**ConversationPbxTimeRange**](ConversationPbxTimeRange.md)| Pbx TimeRange | 

### Return type

[**ConversationPbxTimeRangeResponse**](ConversationPbxTimeRangeResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePbxVoicemailMailbox

> ConversationPbxVoicemailMailboxResponse UpdatePbxVoicemailMailbox (string conversationPbxVoicemailMailboxUuid, ConversationPbxVoicemailMailbox pbxVoicemailMailbox)

Update pbx voicemailMailbox

Update a pbx voicemailMailbox 

### Example

```csharp

// This example is based on our samples_sdk project, but still contains auto-generated content from our sdk generators.
// As such, this might not be the best way to use this object.
// Please see https://github.com/UltraCart/sdk_samples for working examples.

using System.Collections.Generic;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdatePbxVoicemailMailboxExample
    {
        public static void Main()
        {
            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            var api = new GiftCertificateApi(Constants.API_KEY); // Constants is a class from the sdk_samples project

            var conversationPbxVoicemailMailboxUuid = "conversationPbxVoicemailMailboxUuid_example";  // string | 
            var pbxVoicemailMailbox = new ConversationPbxVoicemailMailbox(); // ConversationPbxVoicemailMailbox | Pbx VoicemailMailbox

            try
            {
                // Update pbx voicemailMailbox
                ConversationPbxVoicemailMailboxResponse result = apiInstance.UpdatePbxVoicemailMailbox(conversationPbxVoicemailMailboxUuid, pbxVoicemailMailbox);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdatePbxVoicemailMailbox: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationPbxVoicemailMailboxUuid** | **string**|  | 
 **pbxVoicemailMailbox** | [**ConversationPbxVoicemailMailbox**](ConversationPbxVoicemailMailbox.md)| Pbx VoicemailMailbox | 

### Return type

[**ConversationPbxVoicemailMailboxResponse**](ConversationPbxVoicemailMailboxResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

