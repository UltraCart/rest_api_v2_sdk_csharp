# com.ultracart.admin.v2.Api.ConversationApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAgentWebsocketAuthorization**](ConversationApi.md#getagentwebsocketauthorization) | **PUT** /conversation/agent/auth | Get agent websocket authorization
[**GetConversation**](ConversationApi.md#getconversation) | **GET** /conversation/conversations/{conversation_uuid} | Retrieve a conversation
[**GetConversations**](ConversationApi.md#getconversations) | **GET** /conversation/conversations | Retrieve a list of conversation summaries newest to oldest
[**JoinConversation**](ConversationApi.md#joinconversation) | **PUT** /conversation/conversations/{conversation_uuid}/join | Join a conversation
[**LeaveConversation**](ConversationApi.md#leaveconversation) | **DELETE** /conversation/conversations/{conversation_uuid}/leave | Leave a conversation
[**StartConversation**](ConversationApi.md#startconversation) | **PUT** /conversation/conversations | Start a conversation


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
> Conversation GetConversation (string conversationUuid)

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

            try
            {
                // Retrieve a conversation
                Conversation result = apiInstance.GetConversation(conversationUuid);
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

### Return type

[**Conversation**](Conversation.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversations"></a>
# **GetConversations**
> ConversationsResponse GetConversations (int? limit = null, int? offset = null)

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

            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Max 200) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)

            try
            {
                // Retrieve a list of conversation summaries newest to oldest
                ConversationsResponse result = apiInstance.GetConversations(limit, offset);
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

<a name="joinconversation"></a>
# **JoinConversation**
> void JoinConversation (string conversationUuid)

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

            try
            {
                // Join a conversation
                apiInstance.JoinConversation(conversationUuid);
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

