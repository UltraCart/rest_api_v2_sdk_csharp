# com.ultracart.admin.v2.Api.WorkflowApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWorkflowAssignmentGroups**](WorkflowApi.md#getworkflowassignmentgroups) | **GET** /workflow/assignment_groups | Retrieve a list of groups that workflow tasks can be assigned to
[**GetWorkflowAssignmentUsers**](WorkflowApi.md#getworkflowassignmentusers) | **GET** /workflow/assignment_users | Retrieve a list of users that workflow tasks can be assigned to
[**GetWorkflowTask**](WorkflowApi.md#getworkflowtask) | **GET** /workflow/tasks/{task_uuid} | Retrieve a workflow task
[**GetWorkflowTaskAttachmentUploadUrl**](WorkflowApi.md#getworkflowtaskattachmentuploadurl) | **GET** /workflow/tasks/attachments/{extension} | Get a presigned workflow task attachment upload URL
[**GetWorkflowTaskByObjectType**](WorkflowApi.md#getworkflowtaskbyobjecttype) | **GET** /workflow/tasks/by/{object_type}/{object_id} | Retrieve a workflow task by object type and id
[**GetWorkflowTasks**](WorkflowApi.md#getworkflowtasks) | **POST** /workflow/tasks/search | Search workflow tasks
[**InsertWorkflowTask**](WorkflowApi.md#insertworkflowtask) | **POST** /workflow/tasks | Insert a workflow task
[**UpdateWorkflowTask**](WorkflowApi.md#updateworkflowtask) | **PUT** /workflow/tasks/{task_uuid} | Update a workflow task


<a name="getworkflowassignmentgroups"></a>
# **GetWorkflowAssignmentGroups**
> WorkflowGroupsResponse GetWorkflowAssignmentGroups (int? limit = null, int? offset = null)

Retrieve a list of groups that workflow tasks can be assigned to

Retrieve a list of groups that workflow tasks can be assigned to 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetWorkflowAssignmentGroupsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new WorkflowApi(simpleKey);

            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Max 200) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)

            try
            {
                // Retrieve a list of groups that workflow tasks can be assigned to
                WorkflowGroupsResponse result = apiInstance.GetWorkflowAssignmentGroups(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.GetWorkflowAssignmentGroups: " + e.Message );
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

[**WorkflowGroupsResponse**](WorkflowGroupsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkflowassignmentusers"></a>
# **GetWorkflowAssignmentUsers**
> WorkflowUsersResponse GetWorkflowAssignmentUsers (int? limit = null, int? offset = null)

Retrieve a list of users that workflow tasks can be assigned to

Retrieve a list of users that workflow tasks can be assigned to 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetWorkflowAssignmentUsersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new WorkflowApi(simpleKey);

            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Max 200) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)

            try
            {
                // Retrieve a list of users that workflow tasks can be assigned to
                WorkflowUsersResponse result = apiInstance.GetWorkflowAssignmentUsers(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.GetWorkflowAssignmentUsers: " + e.Message );
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

[**WorkflowUsersResponse**](WorkflowUsersResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkflowtask"></a>
# **GetWorkflowTask**
> WorkflowTaskResponse GetWorkflowTask (string taskUuid)

Retrieve a workflow task

Retrieve a workflow task 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetWorkflowTaskExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new WorkflowApi(simpleKey);

            var taskUuid = taskUuid_example;  // string | 

            try
            {
                // Retrieve a workflow task
                WorkflowTaskResponse result = apiInstance.GetWorkflowTask(taskUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.GetWorkflowTask: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskUuid** | **string**|  | 

### Return type

[**WorkflowTaskResponse**](WorkflowTaskResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkflowtaskattachmentuploadurl"></a>
# **GetWorkflowTaskAttachmentUploadUrl**
> WorkflowAttachmentUploadUrlResponse GetWorkflowTaskAttachmentUploadUrl (string extension)

Get a presigned workflow task attachment upload URL

Get a presigned workflow task attachment upload URL 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetWorkflowTaskAttachmentUploadUrlExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new WorkflowApi(simpleKey);

            var extension = extension_example;  // string | 

            try
            {
                // Get a presigned workflow task attachment upload URL
                WorkflowAttachmentUploadUrlResponse result = apiInstance.GetWorkflowTaskAttachmentUploadUrl(extension);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.GetWorkflowTaskAttachmentUploadUrl: " + e.Message );
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

[**WorkflowAttachmentUploadUrlResponse**](WorkflowAttachmentUploadUrlResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkflowtaskbyobjecttype"></a>
# **GetWorkflowTaskByObjectType**
> WorkflowTaskResponse GetWorkflowTaskByObjectType (string objectType, string objectId)

Retrieve a workflow task by object type and id

Retrieve a workflow task by object type and id 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetWorkflowTaskByObjectTypeExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new WorkflowApi(simpleKey);

            var objectType = objectType_example;  // string | 
            var objectId = objectId_example;  // string | 

            try
            {
                // Retrieve a workflow task by object type and id
                WorkflowTaskResponse result = apiInstance.GetWorkflowTaskByObjectType(objectType, objectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.GetWorkflowTaskByObjectType: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **objectType** | **string**|  | 
 **objectId** | **string**|  | 

### Return type

[**WorkflowTaskResponse**](WorkflowTaskResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkflowtasks"></a>
# **GetWorkflowTasks**
> WorkflowTasksResponse GetWorkflowTasks (WorkflowTasksRequest workflowTasksQuery, int? limit = null, int? offset = null, string sort = null)

Search workflow tasks

Retrieves a set of workflow tasks from the account based on a query object. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetWorkflowTasksExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new WorkflowApi(simpleKey);

            var workflowTasksQuery = new WorkflowTasksRequest(); // WorkflowTasksRequest | Workflow tasks query
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Default 100, Max 500) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var sort = sort_example;  // string | The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 

            try
            {
                // Search workflow tasks
                WorkflowTasksResponse result = apiInstance.GetWorkflowTasks(workflowTasksQuery, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.GetWorkflowTasks: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workflowTasksQuery** | [**WorkflowTasksRequest**](WorkflowTasksRequest.md)| Workflow tasks query | 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Default 100, Max 500) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **sort** | **string**| The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 

### Return type

[**WorkflowTasksResponse**](WorkflowTasksResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertworkflowtask"></a>
# **InsertWorkflowTask**
> WorkflowTaskResponse InsertWorkflowTask (WorkflowTask workflowTask)

Insert a workflow task

Insert a workflow task 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertWorkflowTaskExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new WorkflowApi(simpleKey);

            var workflowTask = new WorkflowTask(); // WorkflowTask | workflow task

            try
            {
                // Insert a workflow task
                WorkflowTaskResponse result = apiInstance.InsertWorkflowTask(workflowTask);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.InsertWorkflowTask: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workflowTask** | [**WorkflowTask**](WorkflowTask.md)| workflow task | 

### Return type

[**WorkflowTaskResponse**](WorkflowTaskResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateworkflowtask"></a>
# **UpdateWorkflowTask**
> WorkflowTaskResponse UpdateWorkflowTask (string taskUuid, WorkflowTask workflowTask)

Update a workflow task

Update a workflow task 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateWorkflowTaskExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new WorkflowApi(simpleKey);

            var taskUuid = taskUuid_example;  // string | 
            var workflowTask = new WorkflowTask(); // WorkflowTask | Workflow task

            try
            {
                // Update a workflow task
                WorkflowTaskResponse result = apiInstance.UpdateWorkflowTask(taskUuid, workflowTask);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.UpdateWorkflowTask: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskUuid** | **string**|  | 
 **workflowTask** | [**WorkflowTask**](WorkflowTask.md)| Workflow task | 

### Return type

[**WorkflowTaskResponse**](WorkflowTaskResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

