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
[**GetAgentProfiles**](ConversationApi.md#getagentprofiles) | **GET** /conversation/agent/profiles | Get agent profiles
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
[**GetVirtualAgentBudget**](ConversationApi.md#getvirtualagentbudget) | **GET** /conversation/virtualagent/budget | Get virtual agent budget
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
[**UpdateVirtualAgentBudget**](ConversationApi.md#updatevirtualagentbudget) | **PUT** /conversation/virtualagent/budget | Update virtual agent budget


<a name="deleteconversationcannedmessage"></a>
# **DeleteConversationCannedMessage**
> void DeleteConversationCannedMessage (int? conversationCannedMessageOid)

Delete a conversation canned message

Delete a conversation canned message 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteConversationCannedMessageExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationCannedMessageOid = 56;  // int? | 

            try
            {
                // Delete a conversation canned message
                apiInstance.DeleteConversationCannedMessage(conversationCannedMessageOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.DeleteConversationCannedMessage: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationCannedMessageOid** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedepartment"></a>
# **DeleteDepartment**
> void DeleteDepartment (int? conversationDepartmentOid)

Delete a conversation department

Delete a conversation department 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteDepartmentExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationDepartmentOid = 56;  // int? | 

            try
            {
                // Delete a conversation department
                apiInstance.DeleteDepartment(conversationDepartmentOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.DeleteDepartment: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationDepartmentOid** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteengagement"></a>
# **DeleteEngagement**
> void DeleteEngagement (int? conversationEngagementOid)

Delete a conversation engagement

Delete a conversation engagement 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteEngagementExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationEngagementOid = 56;  // int? | 

            try
            {
                // Delete a conversation engagement
                apiInstance.DeleteEngagement(conversationEngagementOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.DeleteEngagement: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationEngagementOid** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepbxagentvoicemail"></a>
# **DeletePbxAgentVoicemail**
> void DeletePbxAgentVoicemail (string recordingSid)

Delete Agent Voicemail

Delete pbx agent Voicemail 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeletePbxAgentVoicemailExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var recordingSid = recordingSid_example;  // string | 

            try
            {
                // Delete Agent Voicemail
                apiInstance.DeletePbxAgentVoicemail(recordingSid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.DeletePbxAgentVoicemail: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepbxaudio"></a>
# **DeletePbxAudio**
> ConversationPbxAudioResponse DeletePbxAudio (string conversationPbxAudioUuid)

Delete pbx audio

Delete a pbx audio 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeletePbxAudioExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxAudioUuid = conversationPbxAudioUuid_example;  // string | 

            try
            {
                // Delete pbx audio
                ConversationPbxAudioResponse result = apiInstance.DeletePbxAudio(conversationPbxAudioUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.DeletePbxAudio: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepbxmenu"></a>
# **DeletePbxMenu**
> ConversationPbxMenuResponse DeletePbxMenu (string conversationPbxMenuUuid)

Delete pbx menu

Delete a pbx menu 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeletePbxMenuExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxMenuUuid = conversationPbxMenuUuid_example;  // string | 

            try
            {
                // Delete pbx menu
                ConversationPbxMenuResponse result = apiInstance.DeletePbxMenu(conversationPbxMenuUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.DeletePbxMenu: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepbxqueue"></a>
# **DeletePbxQueue**
> ConversationPbxQueueResponse DeletePbxQueue (string conversationPbxQueueUuid)

Delete pbx queue

Delete a pbx queue 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeletePbxQueueExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxQueueUuid = conversationPbxQueueUuid_example;  // string | 

            try
            {
                // Delete pbx queue
                ConversationPbxQueueResponse result = apiInstance.DeletePbxQueue(conversationPbxQueueUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.DeletePbxQueue: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepbxqueuevoicemail"></a>
# **DeletePbxQueueVoicemail**
> void DeletePbxQueueVoicemail (string queueUuid, string recordingSid)

Delete Queue Voicemail

Delete pbx queue Voicemail 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeletePbxQueueVoicemailExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var queueUuid = queueUuid_example;  // string | 
            var recordingSid = recordingSid_example;  // string | 

            try
            {
                // Delete Queue Voicemail
                apiInstance.DeletePbxQueueVoicemail(queueUuid, recordingSid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.DeletePbxQueueVoicemail: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepbxtimebased"></a>
# **DeletePbxTimeBased**
> ConversationPbxTimeBasedResponse DeletePbxTimeBased (string conversationPbxTimeBasedUuid)

Delete pbx timeBased

Delete a pbx timeBased 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeletePbxTimeBasedExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxTimeBasedUuid = conversationPbxTimeBasedUuid_example;  // string | 

            try
            {
                // Delete pbx timeBased
                ConversationPbxTimeBasedResponse result = apiInstance.DeletePbxTimeBased(conversationPbxTimeBasedUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.DeletePbxTimeBased: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepbxtimerange"></a>
# **DeletePbxTimeRange**
> ConversationPbxTimeRangeResponse DeletePbxTimeRange (string conversationPbxTimeRangeUuid)

Delete pbx timeRange

Delete a pbx timeRange 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeletePbxTimeRangeExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxTimeRangeUuid = conversationPbxTimeRangeUuid_example;  // string | 

            try
            {
                // Delete pbx timeRange
                ConversationPbxTimeRangeResponse result = apiInstance.DeletePbxTimeRange(conversationPbxTimeRangeUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.DeletePbxTimeRange: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepbxvoicemailmailbox"></a>
# **DeletePbxVoicemailMailbox**
> ConversationPbxVoicemailMailboxResponse DeletePbxVoicemailMailbox (string conversationPbxVoicemailMailboxUuid)

Delete pbx voicemailMailbox

Delete a pbx voicemailMailbox 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeletePbxVoicemailMailboxExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxVoicemailMailboxUuid = conversationPbxVoicemailMailboxUuid_example;  // string | 

            try
            {
                // Delete pbx voicemailMailbox
                ConversationPbxVoicemailMailboxResponse result = apiInstance.DeletePbxVoicemailMailbox(conversationPbxVoicemailMailboxUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.DeletePbxVoicemailMailbox: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagentkeepalive"></a>
# **GetAgentKeepAlive**
> void GetAgentKeepAlive ()

Agent keep alive

Called periodically by the conversation API to keep the session alive. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetAgentKeepAliveExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Agent keep alive
                apiInstance.GetAgentKeepAlive();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetAgentKeepAlive: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagentprofile"></a>
# **GetAgentProfile**
> ConversationAgentProfileResponse GetAgentProfile ()

Get agent profile

Retrieve the agents profile 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetAgentProfileExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Get agent profile
                ConversationAgentProfileResponse result = apiInstance.GetAgentProfile();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetAgentProfile: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagentprofiles"></a>
# **GetAgentProfiles**
> ConversationAgentProfilesResponse GetAgentProfiles ()

Get agent profiles

Retrieve the agents profile 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetAgentProfilesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Get agent profiles
                ConversationAgentProfilesResponse result = apiInstance.GetAgentProfiles();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetAgentProfiles: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ConversationAgentProfilesResponse**](ConversationAgentProfilesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagentwebsocketauthorization"></a>
# **GetAgentWebsocketAuthorization**
> ConversationAgentAuthResponse GetAgentWebsocketAuthorization ()

Get agent websocket authorization

Retrieve a JWT to authorize an agent to make a websocket connection. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetAgentWebsocketAuthorizationExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Get agent websocket authorization
                ConversationAgentAuthResponse result = apiInstance.GetAgentWebsocketAuthorization();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetAgentWebsocketAuthorization: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversation"></a>
# **GetConversation**
> ConversationResponse GetConversation (string conversationUuid, int? limit = null)

Retrieve a conversation

Retrieve a conversation including the participants and messages 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationUuid = conversationUuid_example;  // string | 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Retrieve a conversation
                ConversationResponse result = apiInstance.GetConversation(conversationUuid, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversation: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversationcannedmessages"></a>
# **GetConversationCannedMessages**
> ConversationCannedMessagesResponse GetConversationCannedMessages ()

Retrieve a list of canned messages ordered by short_code

Retrieve a list of canned messages ordered by short_code 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationCannedMessagesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Retrieve a list of canned messages ordered by short_code
                ConversationCannedMessagesResponse result = apiInstance.GetConversationCannedMessages();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationCannedMessages: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversationcontext"></a>
# **GetConversationContext**
> ConversationWebchatContext GetConversationContext (string conversationUuid)

Get a webchat conversation context

Get a webchat conversation context 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationContextExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationUuid = conversationUuid_example;  // string | 

            try
            {
                // Get a webchat conversation context
                ConversationWebchatContext result = apiInstance.GetConversationContext(conversationUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationContext: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversationdepartmentmemberlist"></a>
# **GetConversationDepartmentMemberList**
> ConversationDepartmentMembersResponse GetConversationDepartmentMemberList ()

Retrieve a list of possible department members

Retrieve a list of possible department members 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationDepartmentMemberListExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Retrieve a list of possible department members
                ConversationDepartmentMembersResponse result = apiInstance.GetConversationDepartmentMemberList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationDepartmentMemberList: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversationdepartments"></a>
# **GetConversationDepartments**
> ConversationDepartmentsResponse GetConversationDepartments ()

Retrieve a list of departments ordered by name

Retrieve a list of departments ordered by name 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationDepartmentsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Retrieve a list of departments ordered by name
                ConversationDepartmentsResponse result = apiInstance.GetConversationDepartments();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationDepartments: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversationengagement"></a>
# **GetConversationEngagement**
> ConversationEngagementResponse GetConversationEngagement (int? conversationEngagementOid)

Retrieve an engagement

Retrieve an engagement 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationEngagementExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationEngagementOid = 56;  // int? | 

            try
            {
                // Retrieve an engagement
                ConversationEngagementResponse result = apiInstance.GetConversationEngagement(conversationEngagementOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationEngagement: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationEngagementOid** | **int?**|  | 

### Return type

[**ConversationEngagementResponse**](ConversationEngagementResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversationengagements"></a>
# **GetConversationEngagements**
> ConversationEngagementsResponse GetConversationEngagements ()

Retrieve a list of engagements ordered by name

Retrieve a list of engagements ordered by name 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationEngagementsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Retrieve a list of engagements ordered by name
                ConversationEngagementsResponse result = apiInstance.GetConversationEngagements();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationEngagements: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversationmessages"></a>
# **GetConversationMessages**
> ConversationMessagesResponse GetConversationMessages (string conversationUuid, long? since, int? limit = null)

Retrieve conversation messages

Retrieve conversation messages since a particular time 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationMessagesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationUuid = conversationUuid_example;  // string | 
            var since = 789;  // long? | 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Retrieve conversation messages
                ConversationMessagesResponse result = apiInstance.GetConversationMessages(conversationUuid, since, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationMessages: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationUuid** | **string**|  | 
 **since** | **long?**|  | 
 **limit** | **int?**|  | [optional] 

### Return type

[**ConversationMessagesResponse**](ConversationMessagesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversationmultimediauploadurl"></a>
# **GetConversationMultimediaUploadUrl**
> ConversationMultimediaUploadUrlResponse GetConversationMultimediaUploadUrl (string extension)

Get a presigned conversation multimedia upload URL

Get a presigned conversation multimedia upload URL 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationMultimediaUploadUrlExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var extension = extension_example;  // string | 

            try
            {
                // Get a presigned conversation multimedia upload URL
                ConversationMultimediaUploadUrlResponse result = apiInstance.GetConversationMultimediaUploadUrl(extension);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationMultimediaUploadUrl: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversationpbxaudiouploadurl"></a>
# **GetConversationPbxAudioUploadUrl**
> ConversationPbxAudioUploadUrlResponse GetConversationPbxAudioUploadUrl (string extension)

Get a pre-signed conversation multimedia upload URL

Get a pre-signed conversation multimedia upload URL 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationPbxAudioUploadUrlExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var extension = extension_example;  // string | 

            try
            {
                // Get a pre-signed conversation multimedia upload URL
                ConversationPbxAudioUploadUrlResponse result = apiInstance.GetConversationPbxAudioUploadUrl(extension);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationPbxAudioUploadUrl: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversationpbxcustomersnapshot"></a>
# **GetConversationPbxCustomerSnapshot**
> ConversationPbxCustomerSnapshotResponse GetConversationPbxCustomerSnapshot (ConversationPbxCustomerSnapshotRequest pbxCustomerSnapshotRequest)

Get orders and customer information for a phone number

Retrieves all the orders, auto orders, and customer profile for a given phone number 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationPbxCustomerSnapshotExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var pbxCustomerSnapshotRequest = new ConversationPbxCustomerSnapshotRequest(); // ConversationPbxCustomerSnapshotRequest | Conversation pbx customer snapshot request

            try
            {
                // Get orders and customer information for a phone number
                ConversationPbxCustomerSnapshotResponse result = apiInstance.GetConversationPbxCustomerSnapshot(pbxCustomerSnapshotRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationPbxCustomerSnapshot: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversationpermissions"></a>
# **GetConversationPermissions**
> ConversationPermissionsResponse GetConversationPermissions ()

Retrieve conversation permissions

Retrieve conversation permissions 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationPermissionsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Retrieve conversation permissions
                ConversationPermissionsResponse result = apiInstance.GetConversationPermissions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationPermissions: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversationwebchatqueuestatuses"></a>
# **GetConversationWebchatQueueStatuses**
> ConversationWebchatQueueStatusesResponse GetConversationWebchatQueueStatuses ()

Retrieve a conversation webchat queue statuses

Retrieve a conversation webchat queue statuses including agent status and queue entries 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationWebchatQueueStatusesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Retrieve a conversation webchat queue statuses
                ConversationWebchatQueueStatusesResponse result = apiInstance.GetConversationWebchatQueueStatuses();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationWebchatQueueStatuses: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversations"></a>
# **GetConversations**
> ConversationsResponse GetConversations (string medium = null, string before = null, int? limit = null, int? offset = null)

Retrieve a list of conversation summaries newest to oldest

Retrieve a list of conversation summaries that are ordered newest to oldest, include the most recent message and whether its been read. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var medium = medium_example;  // string |  (optional) 
            var before = before_example;  // string |  (optional) 
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Max 200) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)

            try
            {
                // Retrieve a list of conversation summaries newest to oldest
                ConversationsResponse result = apiInstance.GetConversations(medium, before, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversations: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversationsautocomplete"></a>
# **GetConversationsAutocomplete**
> ConversationAutocompleteResponse GetConversationsAutocomplete (ConversationAutocompleteRequest autocompleteRequest)

Retrieve a list of matching terms for a search field

Retrieve a list of matching terms for a search field 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationsAutocompleteExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var autocompleteRequest = new ConversationAutocompleteRequest(); // ConversationAutocompleteRequest | Autocomplete Request

            try
            {
                // Retrieve a list of matching terms for a search field
                ConversationAutocompleteResponse result = apiInstance.GetConversationsAutocomplete(autocompleteRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationsAutocomplete: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversationssearch"></a>
# **GetConversationsSearch**
> ConversationSearchResponse GetConversationsSearch (ConversationSearchRequest searchRequest)

Search conversations

Search conversations 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetConversationsSearchExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var searchRequest = new ConversationSearchRequest(); // ConversationSearchRequest | Search Request

            try
            {
                // Search conversations
                ConversationSearchResponse result = apiInstance.GetConversationsSearch(searchRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetConversationsSearch: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocationsforengagement"></a>
# **GetLocationsForEngagement**
> ConversationLocationsResponse GetLocationsForEngagement ()

Get location data for engagement configuration

Get location data for engagement configuration 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetLocationsForEngagementExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Get location data for engagement configuration
                ConversationLocationsResponse result = apiInstance.GetLocationsForEngagement();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetLocationsForEngagement: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxagent"></a>
# **GetPbxAgent**
> ConversationPbxAgentResponse GetPbxAgent (string conversationPbxAgentUuid)

Get pbx agent

Retrieve a pbx agent 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxAgentExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxAgentUuid = conversationPbxAgentUuid_example;  // string | 

            try
            {
                // Get pbx agent
                ConversationPbxAgentResponse result = apiInstance.GetPbxAgent(conversationPbxAgentUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxAgent: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxagentvoicemail"></a>
# **GetPbxAgentVoicemail**
> ConversationPbxVoicemailMessageResponse GetPbxAgentVoicemail (string recordingSid)

Get Agent Voicemail

Retrieve pbx agent Voicemail 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxAgentVoicemailExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var recordingSid = recordingSid_example;  // string | 

            try
            {
                // Get Agent Voicemail
                ConversationPbxVoicemailMessageResponse result = apiInstance.GetPbxAgentVoicemail(recordingSid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxAgentVoicemail: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxagentvoicemails"></a>
# **GetPbxAgentVoicemails**
> ConversationPbxVoicemailMessageSummariesResponse GetPbxAgentVoicemails ()

Get Agent Voicemails

Retrieve pbx agent Voicemails 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxAgentVoicemailsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Get Agent Voicemails
                ConversationPbxVoicemailMessageSummariesResponse result = apiInstance.GetPbxAgentVoicemails();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxAgentVoicemails: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxagents"></a>
# **GetPbxAgents**
> ConversationPbxAgentsResponse GetPbxAgents ()

Get pbx agents

Retrieve pbx agents 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxAgentsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Get pbx agents
                ConversationPbxAgentsResponse result = apiInstance.GetPbxAgents();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxAgents: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxaudio"></a>
# **GetPbxAudio**
> ConversationPbxAudioResponse GetPbxAudio (string conversationPbxAudioUuid)

Get pbx audio

Retrieve a pbx audio 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxAudioExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxAudioUuid = conversationPbxAudioUuid_example;  // string | 

            try
            {
                // Get pbx audio
                ConversationPbxAudioResponse result = apiInstance.GetPbxAudio(conversationPbxAudioUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxAudio: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxaudiousage"></a>
# **GetPbxAudioUsage**
> ConversationPbxAudioUsageResponse GetPbxAudioUsage (string conversationPbxAudioUuid)

Get pbx audio usage

Retrieve a pbx audio usage 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxAudioUsageExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxAudioUuid = conversationPbxAudioUuid_example;  // string | 

            try
            {
                // Get pbx audio usage
                ConversationPbxAudioUsageResponse result = apiInstance.GetPbxAudioUsage(conversationPbxAudioUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxAudioUsage: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxaudios"></a>
# **GetPbxAudios**
> ConversationPbxAudiosResponse GetPbxAudios ()

Get pbx audios

Retrieve pbx audios 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxAudiosExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Get pbx audios
                ConversationPbxAudiosResponse result = apiInstance.GetPbxAudios();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxAudios: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxmenu"></a>
# **GetPbxMenu**
> ConversationPbxMenuResponse GetPbxMenu (string conversationPbxMenuUuid)

Get pbx menu

Retrieve a pbx menu 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxMenuExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxMenuUuid = conversationPbxMenuUuid_example;  // string | 

            try
            {
                // Get pbx menu
                ConversationPbxMenuResponse result = apiInstance.GetPbxMenu(conversationPbxMenuUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxMenu: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxmenus"></a>
# **GetPbxMenus**
> ConversationPbxMenusResponse GetPbxMenus ()

Get pbx menus

Retrieve pbx menus 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxMenusExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Get pbx menus
                ConversationPbxMenusResponse result = apiInstance.GetPbxMenus();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxMenus: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxphonenumber"></a>
# **GetPbxPhoneNumber**
> ConversationPbxPhoneNumberResponse GetPbxPhoneNumber (string conversationPbxPhoneNumberUuid)

Get pbx phoneNumber

Retrieve a pbx phoneNumber 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxPhoneNumberExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxPhoneNumberUuid = conversationPbxPhoneNumberUuid_example;  // string | 

            try
            {
                // Get pbx phoneNumber
                ConversationPbxPhoneNumberResponse result = apiInstance.GetPbxPhoneNumber(conversationPbxPhoneNumberUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxPhoneNumber: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxphonenumbers"></a>
# **GetPbxPhoneNumbers**
> ConversationPbxPhoneNumbersResponse GetPbxPhoneNumbers ()

Get pbx phoneNumbers

Retrieve pbx phoneNumbers 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxPhoneNumbersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Get pbx phoneNumbers
                ConversationPbxPhoneNumbersResponse result = apiInstance.GetPbxPhoneNumbers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxPhoneNumbers: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxqueue"></a>
# **GetPbxQueue**
> ConversationPbxQueueResponse GetPbxQueue (string conversationPbxQueueUuid)

Get pbx queue

Retrieve a pbx queue 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxQueueExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxQueueUuid = conversationPbxQueueUuid_example;  // string | 

            try
            {
                // Get pbx queue
                ConversationPbxQueueResponse result = apiInstance.GetPbxQueue(conversationPbxQueueUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxQueue: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxqueuevoicemail"></a>
# **GetPbxQueueVoicemail**
> ConversationPbxVoicemailMessageResponse GetPbxQueueVoicemail (string queueUuid, string recordingSid)

Get Queue Voicemail

Retrieve pbx queue Voicemail 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxQueueVoicemailExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var queueUuid = queueUuid_example;  // string | 
            var recordingSid = recordingSid_example;  // string | 

            try
            {
                // Get Queue Voicemail
                ConversationPbxVoicemailMessageResponse result = apiInstance.GetPbxQueueVoicemail(queueUuid, recordingSid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxQueueVoicemail: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxqueuevoicemails"></a>
# **GetPbxQueueVoicemails**
> ConversationPbxVoicemailMessageSummariesResponse GetPbxQueueVoicemails (string queueUuid)

Get Queue Voicemails

Retrieve pbx queue voicemails 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxQueueVoicemailsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var queueUuid = queueUuid_example;  // string | 

            try
            {
                // Get Queue Voicemails
                ConversationPbxVoicemailMessageSummariesResponse result = apiInstance.GetPbxQueueVoicemails(queueUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxQueueVoicemails: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxqueues"></a>
# **GetPbxQueues**
> ConversationPbxQueuesResponse GetPbxQueues ()

Get pbx queues

Retrieve pbx queues 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxQueuesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Get pbx queues
                ConversationPbxQueuesResponse result = apiInstance.GetPbxQueues();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxQueues: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxtimebased"></a>
# **GetPbxTimeBased**
> ConversationPbxTimeBasedResponse GetPbxTimeBased (string conversationPbxTimeBasedUuid)

Get pbx timeBased

Retrieve a pbx timeBased 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxTimeBasedExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxTimeBasedUuid = conversationPbxTimeBasedUuid_example;  // string | 

            try
            {
                // Get pbx timeBased
                ConversationPbxTimeBasedResponse result = apiInstance.GetPbxTimeBased(conversationPbxTimeBasedUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxTimeBased: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxtimebaseds"></a>
# **GetPbxTimeBaseds**
> ConversationPbxTimeBasedsResponse GetPbxTimeBaseds ()

Get pbx timeBaseds

Retrieve pbx timeBaseds 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxTimeBasedsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Get pbx timeBaseds
                ConversationPbxTimeBasedsResponse result = apiInstance.GetPbxTimeBaseds();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxTimeBaseds: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxtimerange"></a>
# **GetPbxTimeRange**
> ConversationPbxTimeRangeResponse GetPbxTimeRange (string conversationPbxTimeRangeUuid)

Get pbx timeRange

Retrieve a pbx timeRange 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxTimeRangeExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxTimeRangeUuid = conversationPbxTimeRangeUuid_example;  // string | 

            try
            {
                // Get pbx timeRange
                ConversationPbxTimeRangeResponse result = apiInstance.GetPbxTimeRange(conversationPbxTimeRangeUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxTimeRange: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxtimeranges"></a>
# **GetPbxTimeRanges**
> ConversationPbxTimeRangesResponse GetPbxTimeRanges ()

Get pbx timeRanges

Retrieve pbx timeRanges 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxTimeRangesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Get pbx timeRanges
                ConversationPbxTimeRangesResponse result = apiInstance.GetPbxTimeRanges();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxTimeRanges: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxvoicemailmailbox"></a>
# **GetPbxVoicemailMailbox**
> ConversationPbxVoicemailMailboxResponse GetPbxVoicemailMailbox (string conversationPbxVoicemailMailboxUuid)

Get pbx voicemailMailbox

Retrieve a pbx voicemailMailbox 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxVoicemailMailboxExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxVoicemailMailboxUuid = conversationPbxVoicemailMailboxUuid_example;  // string | 

            try
            {
                // Get pbx voicemailMailbox
                ConversationPbxVoicemailMailboxResponse result = apiInstance.GetPbxVoicemailMailbox(conversationPbxVoicemailMailboxUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxVoicemailMailbox: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbxvoicemailmailboxes"></a>
# **GetPbxVoicemailMailboxes**
> ConversationPbxVoicemailMailboxesResponse GetPbxVoicemailMailboxes ()

Get pbx voicemailMailboxes

Retrieve pbx voicemailMailboxes 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetPbxVoicemailMailboxesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Get pbx voicemailMailboxes
                ConversationPbxVoicemailMailboxesResponse result = apiInstance.GetPbxVoicemailMailboxes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetPbxVoicemailMailboxes: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvirtualagentbudget"></a>
# **GetVirtualAgentBudget**
> ConversationVirtualAgentBudgetResponse GetVirtualAgentBudget ()

Get virtual agent budget

Retrieve virtual agent budget 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetVirtualAgentBudgetExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);


            try
            {
                // Get virtual agent budget
                ConversationVirtualAgentBudgetResponse result = apiInstance.GetVirtualAgentBudget();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.GetVirtualAgentBudget: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ConversationVirtualAgentBudgetResponse**](ConversationVirtualAgentBudgetResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertconversationcannedmessage"></a>
# **InsertConversationCannedMessage**
> ConversationCannedMessageResponse InsertConversationCannedMessage (ConversationCannedMessage cannedMessage)

Insert a canned message

Insert a canned message 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertConversationCannedMessageExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var cannedMessage = new ConversationCannedMessage(); // ConversationCannedMessage | Canned message

            try
            {
                // Insert a canned message
                ConversationCannedMessageResponse result = apiInstance.InsertConversationCannedMessage(cannedMessage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.InsertConversationCannedMessage: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertconversationdepartment"></a>
# **InsertConversationDepartment**
> ConversationDepartmentResponse InsertConversationDepartment (ConversationDepartment department)

Insert a department

Insert a department 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertConversationDepartmentExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var department = new ConversationDepartment(); // ConversationDepartment | Department

            try
            {
                // Insert a department
                ConversationDepartmentResponse result = apiInstance.InsertConversationDepartment(department);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.InsertConversationDepartment: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertconversationengagement"></a>
# **InsertConversationEngagement**
> ConversationEngagementResponse InsertConversationEngagement (ConversationEngagement engagement)

Insert a engagement

Insert a engagement 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertConversationEngagementExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var engagement = new ConversationEngagement(); // ConversationEngagement | Engagement

            try
            {
                // Insert a engagement
                ConversationEngagementResponse result = apiInstance.InsertConversationEngagement(engagement);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.InsertConversationEngagement: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertpbxaudio"></a>
# **InsertPbxAudio**
> ConversationPbxAudioResponse InsertPbxAudio (ConversationPbxAudio pbxAudio)

Insert pbx audio

Insert a pbx audio 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertPbxAudioExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var pbxAudio = new ConversationPbxAudio(); // ConversationPbxAudio | Pbx Audio

            try
            {
                // Insert pbx audio
                ConversationPbxAudioResponse result = apiInstance.InsertPbxAudio(pbxAudio);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.InsertPbxAudio: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertpbxmenu"></a>
# **InsertPbxMenu**
> ConversationPbxMenuResponse InsertPbxMenu (ConversationPbxMenu pbxMenu)

Insert pbx menu

Insert a pbx menu 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertPbxMenuExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var pbxMenu = new ConversationPbxMenu(); // ConversationPbxMenu | Pbx Menu

            try
            {
                // Insert pbx menu
                ConversationPbxMenuResponse result = apiInstance.InsertPbxMenu(pbxMenu);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.InsertPbxMenu: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertpbxqueue"></a>
# **InsertPbxQueue**
> ConversationPbxQueueResponse InsertPbxQueue (ConversationPbxQueue pbxQueue)

Insert pbx queue

Insert a pbx queue 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertPbxQueueExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var pbxQueue = new ConversationPbxQueue(); // ConversationPbxQueue | Pbx Queue

            try
            {
                // Insert pbx queue
                ConversationPbxQueueResponse result = apiInstance.InsertPbxQueue(pbxQueue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.InsertPbxQueue: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertpbxtimebased"></a>
# **InsertPbxTimeBased**
> ConversationPbxTimeBasedResponse InsertPbxTimeBased (ConversationPbxTimeBased pbxTimeBased)

Insert pbx timeBased

Insert a pbx timeBased 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertPbxTimeBasedExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var pbxTimeBased = new ConversationPbxTimeBased(); // ConversationPbxTimeBased | Pbx TimeBased

            try
            {
                // Insert pbx timeBased
                ConversationPbxTimeBasedResponse result = apiInstance.InsertPbxTimeBased(pbxTimeBased);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.InsertPbxTimeBased: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertpbxtimerange"></a>
# **InsertPbxTimeRange**
> ConversationPbxTimeRangeResponse InsertPbxTimeRange (ConversationPbxTimeRange pbxTimeRange)

Insert pbx timeRange

Insert a pbx timeRange 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertPbxTimeRangeExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var pbxTimeRange = new ConversationPbxTimeRange(); // ConversationPbxTimeRange | Pbx TimeRange

            try
            {
                // Insert pbx timeRange
                ConversationPbxTimeRangeResponse result = apiInstance.InsertPbxTimeRange(pbxTimeRange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.InsertPbxTimeRange: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertpbxvoicemailmailbox"></a>
# **InsertPbxVoicemailMailbox**
> ConversationPbxVoicemailMailboxResponse InsertPbxVoicemailMailbox (ConversationPbxVoicemailMailbox pbxVoicemailMailbox)

Insert pbx voicemailMailbox

Insert a pbx voicemailMailbox 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertPbxVoicemailMailboxExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var pbxVoicemailMailbox = new ConversationPbxVoicemailMailbox(); // ConversationPbxVoicemailMailbox | Pbx VoicemailMailbox

            try
            {
                // Insert pbx voicemailMailbox
                ConversationPbxVoicemailMailboxResponse result = apiInstance.InsertPbxVoicemailMailbox(pbxVoicemailMailbox);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.InsertPbxVoicemailMailbox: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="joinconversation"></a>
# **JoinConversation**
> void JoinConversation (string conversationUuid, ConversationJoinRequest joinRequest = null)

Join a conversation

Join a conversation 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class JoinConversationExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationUuid = conversationUuid_example;  // string | 
            var joinRequest = new ConversationJoinRequest(); // ConversationJoinRequest | Join request (optional) 

            try
            {
                // Join a conversation
                apiInstance.JoinConversation(conversationUuid, joinRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.JoinConversation: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leaveconversation"></a>
# **LeaveConversation**
> void LeaveConversation (string conversationUuid)

Leave a conversation

Leave a conversation 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class LeaveConversationExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationUuid = conversationUuid_example;  // string | 

            try
            {
                // Leave a conversation
                apiInstance.LeaveConversation(conversationUuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.LeaveConversation: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listenedpbxagentvoicemail"></a>
# **ListenedPbxAgentVoicemail**
> void ListenedPbxAgentVoicemail (string recordingSid)

Listened Agent Voicemail

Listened pbx agent Voicemail 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ListenedPbxAgentVoicemailExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var recordingSid = recordingSid_example;  // string | 

            try
            {
                // Listened Agent Voicemail
                apiInstance.ListenedPbxAgentVoicemail(recordingSid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.ListenedPbxAgentVoicemail: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listenedpbxqueuevoicemail"></a>
# **ListenedPbxQueueVoicemail**
> void ListenedPbxQueueVoicemail (string queueUuid, string recordingSid)

Listened Queue Voicemail

Listened pbx queue Voicemail 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ListenedPbxQueueVoicemailExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var queueUuid = queueUuid_example;  // string | 
            var recordingSid = recordingSid_example;  // string | 

            try
            {
                // Listened Queue Voicemail
                apiInstance.ListenedPbxQueueVoicemail(queueUuid, recordingSid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.ListenedPbxQueueVoicemail: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="markreadconversation"></a>
# **MarkReadConversation**
> void MarkReadConversation (string conversationUuid)

Mark a conversation as read

Mark a conversation as read 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class MarkReadConversationExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationUuid = conversationUuid_example;  // string | 

            try
            {
                // Mark a conversation as read
                apiInstance.MarkReadConversation(conversationUuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.MarkReadConversation: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetconversationpbxqueuestatistics"></a>
# **ResetConversationPbxQueueStatistics**
> void ResetConversationPbxQueueStatistics (string queueUuid)

reset statistics within the queue

reset statistics within the queue 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ResetConversationPbxQueueStatisticsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var queueUuid = queueUuid_example;  // string | 

            try
            {
                // reset statistics within the queue
                apiInstance.ResetConversationPbxQueueStatistics(queueUuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.ResetConversationPbxQueueStatistics: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchconversationcannedmessages"></a>
# **SearchConversationCannedMessages**
> ConversationCannedMessagesResponse SearchConversationCannedMessages (ConversationCannedMessagesSearch searchRequest)

Search for canned messages by short_code

Search for canned messages by short_code 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SearchConversationCannedMessagesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var searchRequest = new ConversationCannedMessagesSearch(); // ConversationCannedMessagesSearch | Search request

            try
            {
                // Search for canned messages by short_code
                ConversationCannedMessagesResponse result = apiInstance.SearchConversationCannedMessages(searchRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.SearchConversationCannedMessages: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsunsubscribeconversation"></a>
# **SmsUnsubscribeConversation**
> void SmsUnsubscribeConversation (string conversationUuid)

Unsubscribe any SMS participants in this conversation

Unsubscribe any SMS participants in this conversation 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SmsUnsubscribeConversationExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationUuid = conversationUuid_example;  // string | 

            try
            {
                // Unsubscribe any SMS participants in this conversation
                apiInstance.SmsUnsubscribeConversation(conversationUuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.SmsUnsubscribeConversation: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startconversation"></a>
# **StartConversation**
> ConversationStartResponse StartConversation (ConversationStartRequest startRequest)

Start a conversation

Start a new conversation 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class StartConversationExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var startRequest = new ConversationStartRequest(); // ConversationStartRequest | Start request

            try
            {
                // Start a conversation
                ConversationStartResponse result = apiInstance.StartConversation(startRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.StartConversation: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateagentprofile"></a>
# **UpdateAgentProfile**
> ConversationAgentProfileResponse UpdateAgentProfile (ConversationAgentProfile profileRequest)

Update agent profile

Update agent profile 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateAgentProfileExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var profileRequest = new ConversationAgentProfile(); // ConversationAgentProfile | Profile request

            try
            {
                // Update agent profile
                ConversationAgentProfileResponse result = apiInstance.UpdateAgentProfile(profileRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdateAgentProfile: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateconversationcannedmessage"></a>
# **UpdateConversationCannedMessage**
> ConversationCannedMessageResponse UpdateConversationCannedMessage (int? conversationCannedMessageOid, ConversationCannedMessage cannedMessage)

Update a canned message

Update a canned message 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateConversationCannedMessageExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationCannedMessageOid = 56;  // int? | 
            var cannedMessage = new ConversationCannedMessage(); // ConversationCannedMessage | Canned message

            try
            {
                // Update a canned message
                ConversationCannedMessageResponse result = apiInstance.UpdateConversationCannedMessage(conversationCannedMessageOid, cannedMessage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdateConversationCannedMessage: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationCannedMessageOid** | **int?**|  | 
 **cannedMessage** | [**ConversationCannedMessage**](ConversationCannedMessage.md)| Canned message | 

### Return type

[**ConversationCannedMessageResponse**](ConversationCannedMessageResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateconversationdepartment"></a>
# **UpdateConversationDepartment**
> ConversationDepartmentResponse UpdateConversationDepartment (int? conversationDepartmentOid, ConversationDepartment department)

Update a department

Update a department 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateConversationDepartmentExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationDepartmentOid = 56;  // int? | 
            var department = new ConversationDepartment(); // ConversationDepartment | Department

            try
            {
                // Update a department
                ConversationDepartmentResponse result = apiInstance.UpdateConversationDepartment(conversationDepartmentOid, department);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdateConversationDepartment: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationDepartmentOid** | **int?**|  | 
 **department** | [**ConversationDepartment**](ConversationDepartment.md)| Department | 

### Return type

[**ConversationDepartmentResponse**](ConversationDepartmentResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateconversationengagement"></a>
# **UpdateConversationEngagement**
> ConversationEngagementResponse UpdateConversationEngagement (int? conversationEngagementOid, ConversationEngagement engagement)

Update a engagement

Update a engagement 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateConversationEngagementExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationEngagementOid = 56;  // int? | 
            var engagement = new ConversationEngagement(); // ConversationEngagement | Engagement

            try
            {
                // Update a engagement
                ConversationEngagementResponse result = apiInstance.UpdateConversationEngagement(conversationEngagementOid, engagement);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdateConversationEngagement: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationEngagementOid** | **int?**|  | 
 **engagement** | [**ConversationEngagement**](ConversationEngagement.md)| Engagement | 

### Return type

[**ConversationEngagementResponse**](ConversationEngagementResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateconversationwebchatqueuestatus"></a>
# **UpdateConversationWebchatQueueStatus**
> void UpdateConversationWebchatQueueStatus (string queueName, ConversationWebchatQueueStatusUpdateRequest statusRequest)

Update status within the queue

Update status within the queue 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateConversationWebchatQueueStatusExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var queueName = queueName_example;  // string | 
            var statusRequest = new ConversationWebchatQueueStatusUpdateRequest(); // ConversationWebchatQueueStatusUpdateRequest | Status request

            try
            {
                // Update status within the queue
                apiInstance.UpdateConversationWebchatQueueStatus(queueName, statusRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdateConversationWebchatQueueStatus: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepbxagent"></a>
# **UpdatePbxAgent**
> ConversationPbxAgentResponse UpdatePbxAgent (string conversationPbxAgentUuid, ConversationPbxAgent pbxAgent)

Update pbx agent

Update a pbx agent 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdatePbxAgentExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxAgentUuid = conversationPbxAgentUuid_example;  // string | 
            var pbxAgent = new ConversationPbxAgent(); // ConversationPbxAgent | Pbx Agent

            try
            {
                // Update pbx agent
                ConversationPbxAgentResponse result = apiInstance.UpdatePbxAgent(conversationPbxAgentUuid, pbxAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdatePbxAgent: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepbxaudio"></a>
# **UpdatePbxAudio**
> ConversationPbxAudioResponse UpdatePbxAudio (string conversationPbxAudioUuid, ConversationPbxAudio pbxAudio)

Update pbx audio

Update a pbx audio 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdatePbxAudioExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxAudioUuid = conversationPbxAudioUuid_example;  // string | 
            var pbxAudio = new ConversationPbxAudio(); // ConversationPbxAudio | Pbx Audio

            try
            {
                // Update pbx audio
                ConversationPbxAudioResponse result = apiInstance.UpdatePbxAudio(conversationPbxAudioUuid, pbxAudio);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdatePbxAudio: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepbxmenu"></a>
# **UpdatePbxMenu**
> ConversationPbxMenuResponse UpdatePbxMenu (string conversationPbxMenuUuid, ConversationPbxMenu pbxMenu)

Update pbx menu

Update a pbx menu 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdatePbxMenuExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxMenuUuid = conversationPbxMenuUuid_example;  // string | 
            var pbxMenu = new ConversationPbxMenu(); // ConversationPbxMenu | Pbx Menu

            try
            {
                // Update pbx menu
                ConversationPbxMenuResponse result = apiInstance.UpdatePbxMenu(conversationPbxMenuUuid, pbxMenu);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdatePbxMenu: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepbxphonenumber"></a>
# **UpdatePbxPhoneNumber**
> ConversationPbxPhoneNumberResponse UpdatePbxPhoneNumber (string conversationPbxPhoneNumberUuid, ConversationPbxPhoneNumber pbxPhoneNumber)

Update pbx phoneNumber

Update a pbx phoneNumber 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdatePbxPhoneNumberExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxPhoneNumberUuid = conversationPbxPhoneNumberUuid_example;  // string | 
            var pbxPhoneNumber = new ConversationPbxPhoneNumber(); // ConversationPbxPhoneNumber | Pbx PhoneNumber

            try
            {
                // Update pbx phoneNumber
                ConversationPbxPhoneNumberResponse result = apiInstance.UpdatePbxPhoneNumber(conversationPbxPhoneNumberUuid, pbxPhoneNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdatePbxPhoneNumber: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepbxqueue"></a>
# **UpdatePbxQueue**
> ConversationPbxQueueResponse UpdatePbxQueue (string conversationPbxQueueUuid, ConversationPbxQueue pbxQueue)

Update pbx queue

Update a pbx queue 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdatePbxQueueExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxQueueUuid = conversationPbxQueueUuid_example;  // string | 
            var pbxQueue = new ConversationPbxQueue(); // ConversationPbxQueue | Pbx Queue

            try
            {
                // Update pbx queue
                ConversationPbxQueueResponse result = apiInstance.UpdatePbxQueue(conversationPbxQueueUuid, pbxQueue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdatePbxQueue: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepbxtimebased"></a>
# **UpdatePbxTimeBased**
> ConversationPbxTimeBasedResponse UpdatePbxTimeBased (string conversationPbxTimeBasedUuid, ConversationPbxTimeBased pbxTimeBased)

Update pbx timeBased

Update a pbx timeBased 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdatePbxTimeBasedExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxTimeBasedUuid = conversationPbxTimeBasedUuid_example;  // string | 
            var pbxTimeBased = new ConversationPbxTimeBased(); // ConversationPbxTimeBased | Pbx TimeBased

            try
            {
                // Update pbx timeBased
                ConversationPbxTimeBasedResponse result = apiInstance.UpdatePbxTimeBased(conversationPbxTimeBasedUuid, pbxTimeBased);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdatePbxTimeBased: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepbxtimerange"></a>
# **UpdatePbxTimeRange**
> ConversationPbxTimeRangeResponse UpdatePbxTimeRange (string conversationPbxTimeRangeUuid, ConversationPbxTimeRange pbxTimeRange)

Update pbx timeRange

Update a pbx timeRange 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdatePbxTimeRangeExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxTimeRangeUuid = conversationPbxTimeRangeUuid_example;  // string | 
            var pbxTimeRange = new ConversationPbxTimeRange(); // ConversationPbxTimeRange | Pbx TimeRange

            try
            {
                // Update pbx timeRange
                ConversationPbxTimeRangeResponse result = apiInstance.UpdatePbxTimeRange(conversationPbxTimeRangeUuid, pbxTimeRange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdatePbxTimeRange: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepbxvoicemailmailbox"></a>
# **UpdatePbxVoicemailMailbox**
> ConversationPbxVoicemailMailboxResponse UpdatePbxVoicemailMailbox (string conversationPbxVoicemailMailboxUuid, ConversationPbxVoicemailMailbox pbxVoicemailMailbox)

Update pbx voicemailMailbox

Update a pbx voicemailMailbox 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdatePbxVoicemailMailboxExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var conversationPbxVoicemailMailboxUuid = conversationPbxVoicemailMailboxUuid_example;  // string | 
            var pbxVoicemailMailbox = new ConversationPbxVoicemailMailbox(); // ConversationPbxVoicemailMailbox | Pbx VoicemailMailbox

            try
            {
                // Update pbx voicemailMailbox
                ConversationPbxVoicemailMailboxResponse result = apiInstance.UpdatePbxVoicemailMailbox(conversationPbxVoicemailMailboxUuid, pbxVoicemailMailbox);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdatePbxVoicemailMailbox: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevirtualagentbudget"></a>
# **UpdateVirtualAgentBudget**
> ConversationVirtualAgentBudgetResponse UpdateVirtualAgentBudget (ConversationVirtualAgentBudget virtualAgentBudget)

Update virtual agent budget

Update virtual agent budget 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateVirtualAgentBudgetExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new ConversationApi(simpleKey);

            var virtualAgentBudget = new ConversationVirtualAgentBudget(); // ConversationVirtualAgentBudget | Virtual Agent Budget

            try
            {
                // Update virtual agent budget
                ConversationVirtualAgentBudgetResponse result = apiInstance.UpdateVirtualAgentBudget(virtualAgentBudget);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationApi.UpdateVirtualAgentBudget: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **virtualAgentBudget** | [**ConversationVirtualAgentBudget**](ConversationVirtualAgentBudget.md)| Virtual Agent Budget | 

### Return type

[**ConversationVirtualAgentBudgetResponse**](ConversationVirtualAgentBudgetResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

