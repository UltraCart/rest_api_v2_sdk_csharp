# com.ultracart.admin.v2.Api.StorefrontApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArchiveEmailList**](StorefrontApi.md#archiveemaillist) | **POST** /storefront/{storefront_oid}/email/lists/{email_list_uuid}/archive | Archive email list
[**ArchiveEmailSegment**](StorefrontApi.md#archiveemailsegment) | **POST** /storefront/{storefront_oid}/email/segments/{email_segment_uuid}/archive | Archive email segment
[**CloneEmailCampaign**](StorefrontApi.md#cloneemailcampaign) | **POST** /storefront/{storefront_oid}/email/campaigns/{email_campaign_uuid}/clone | Clone email campaign
[**CloneEmailFlow**](StorefrontApi.md#cloneemailflow) | **POST** /storefront/{storefront_oid}/email/flows/{email_flow_uuid}/clone | Clone email flow
[**CreateEmailSendingDomain**](StorefrontApi.md#createemailsendingdomain) | **POST** /storefront/email/sending_domains/{domain}/create | Create email campaign
[**DeleteEmailEmail**](StorefrontApi.md#deleteemailemail) | **DELETE** /storefront/{storefront_oid}/email/emails/{commseq_email_uuid} | Delete email email
[**DeleteEmailListCustomer**](StorefrontApi.md#deleteemaillistcustomer) | **DELETE** /storefront/{storefront_oid}/email/lists/{email_list_uuid}/customers/{email_customer_uuid} | Delete email list customer
[**DeleteEmailSendingDomain**](StorefrontApi.md#deleteemailsendingdomain) | **DELETE** /storefront/email/sending_domains/{domain} | delete email campaign
[**DeleteExperiment**](StorefrontApi.md#deleteexperiment) | **DELETE** /storefront/{storefront_oid}/experiments/{storefront_experiment_oid} | Delete experiment
[**GeocodeAddress**](StorefrontApi.md#geocodeaddress) | **POST** /storefront/{storefront_oid}/email/geocode | Obtain lat/long for an address
[**GetCountries**](StorefrontApi.md#getcountries) | **GET** /storefront/{storefront_oid}/email/countries | Get countries
[**GetEmailBaseTemplates**](StorefrontApi.md#getemailbasetemplates) | **GET** /storefront/{storefront_oid}/email/baseTemplates | Get email communication base templates
[**GetEmailCampaign**](StorefrontApi.md#getemailcampaign) | **GET** /storefront/{storefront_oid}/email/campaigns/{email_campaign_uuid} | Get email campaign
[**GetEmailCampaigns**](StorefrontApi.md#getemailcampaigns) | **GET** /storefront/{storefront_oid}/email/campaigns | Get email campaigns
[**GetEmailCampaignsWithStats**](StorefrontApi.md#getemailcampaignswithstats) | **GET** /storefront/{storefront_oid}/email/campaignsWithStats/{stat_days} | Get email campaigns with stats
[**GetEmailCommseq**](StorefrontApi.md#getemailcommseq) | **GET** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid} | Get email commseq
[**GetEmailCommseqEmailStats**](StorefrontApi.md#getemailcommseqemailstats) | **POST** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/emailStats | Get email communication sequence emails stats
[**GetEmailCommseqStatOverall**](StorefrontApi.md#getemailcommseqstatoverall) | **GET** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/stat | Get communication sequence stats overall
[**GetEmailCommseqStepWaiting**](StorefrontApi.md#getemailcommseqstepwaiting) | **POST** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/waiting | Get email communication sequence customers waiting at each requested step
[**GetEmailCommseqs**](StorefrontApi.md#getemailcommseqs) | **GET** /storefront/{storefront_oid}/email/commseqs | Get email commseqs
[**GetEmailDashboardActivity**](StorefrontApi.md#getemaildashboardactivity) | **GET** /storefront/{storefront_oid}/email/dashboard_activity | Get email dashboard activity
[**GetEmailDashboardStats**](StorefrontApi.md#getemaildashboardstats) | **GET** /storefront/{storefront_oid}/email/dashboard_stats | Get dashboard stats
[**GetEmailEmail**](StorefrontApi.md#getemailemail) | **GET** /storefront/{storefront_oid}/email/emails/{commseq_email_uuid} | Get email email
[**GetEmailEmails**](StorefrontApi.md#getemailemails) | **GET** /storefront/{storefront_oid}/email/emails | Get email emails
[**GetEmailEmailsMultiple**](StorefrontApi.md#getemailemailsmultiple) | **POST** /storefront/{storefront_oid}/email/emails/multiple | Get email emails multiple
[**GetEmailFlow**](StorefrontApi.md#getemailflow) | **GET** /storefront/{storefront_oid}/email/flows/{email_flow_uuid} | Get email flow
[**GetEmailFlows**](StorefrontApi.md#getemailflows) | **GET** /storefront/{storefront_oid}/email/flows | Get email flows
[**GetEmailList**](StorefrontApi.md#getemaillist) | **GET** /storefront/{storefront_oid}/email/lists/{email_list_uuid} | Get email list
[**GetEmailListCustomerEditorUrl**](StorefrontApi.md#getemaillistcustomereditorurl) | **GET** /storefront/{storefront_oid}/email/lists/{email_list_uuid}/customers/{email_customer_uuid}/editor_url | Get email list customers
[**GetEmailListCustomers**](StorefrontApi.md#getemaillistcustomers) | **GET** /storefront/{storefront_oid}/email/lists/{email_list_uuid}/customers | Get email list customers
[**GetEmailLists**](StorefrontApi.md#getemaillists) | **GET** /storefront/{storefront_oid}/email/lists | Get email lists
[**GetEmailSegment**](StorefrontApi.md#getemailsegment) | **GET** /storefront/{storefront_oid}/email/segments/{email_segment_uuid} | Get email segment
[**GetEmailSegmentCustomerEditorUrl**](StorefrontApi.md#getemailsegmentcustomereditorurl) | **GET** /storefront/{storefront_oid}/email/segments/{email_segment_uuid}/customers/{email_customer_uuid}/editor_url | Get email segment customers editor URL
[**GetEmailSegmentCustomers**](StorefrontApi.md#getemailsegmentcustomers) | **GET** /storefront/{storefront_oid}/email/segments/{email_segment_uuid}/customers | Get email segment customers
[**GetEmailSegments**](StorefrontApi.md#getemailsegments) | **GET** /storefront/{storefront_oid}/email/segments | Get email segments
[**GetEmailSendingDomain**](StorefrontApi.md#getemailsendingdomain) | **GET** /storefront/email/sending_domain/{domain} | Get email sending domain
[**GetEmailSendingDomainStatus**](StorefrontApi.md#getemailsendingdomainstatus) | **POST** /storefront/email/sending_domains/{domain}/status | Get email sending domain status
[**GetEmailSendingDomains**](StorefrontApi.md#getemailsendingdomains) | **GET** /storefront/email/sending_domains | Get email sending domains
[**GetEmailTemplate**](StorefrontApi.md#getemailtemplate) | **GET** /storefront/{storefront_oid}/email/templates/{email_template_oid} | Get email template
[**GetEmailTemplates**](StorefrontApi.md#getemailtemplates) | **GET** /storefront/{storefront_oid}/email/templates | Get email templates
[**GetEmailThirdPartyProviders**](StorefrontApi.md#getemailthirdpartyproviders) | **GET** /storefront/{storefront_oid}/email/third_party_providers | Get a list of third party email providers
[**GetExperiments**](StorefrontApi.md#getexperiments) | **GET** /storefront/{storefront_oid}/experiments | Get experiments
[**GetHistogramPropertyNames**](StorefrontApi.md#gethistogrampropertynames) | **GET** /storefront/{storefront_oid}/email/histogram/property_names | Get histogram property names
[**GetHistogramPropertyValues**](StorefrontApi.md#gethistogrampropertyvalues) | **GET** /storefront/{storefront_oid}/email/histogram/property_values | Get histogram property values
[**ImportEmailThirdPartyProviderList**](StorefrontApi.md#importemailthirdpartyproviderlist) | **POST** /storefront/{storefront_oid}/email/third_party_providers/import | Import a third party provider list
[**InsertEmailCampaign**](StorefrontApi.md#insertemailcampaign) | **POST** /storefront/{storefront_oid}/email/campaigns | Insert email campaign
[**InsertEmailCommseq**](StorefrontApi.md#insertemailcommseq) | **POST** /storefront/{storefront_oid}/email/commseqs | Insert email commseq
[**InsertEmailEmail**](StorefrontApi.md#insertemailemail) | **POST** /storefront/{storefront_oid}/email/emails | Insert email email
[**InsertEmailFlow**](StorefrontApi.md#insertemailflow) | **POST** /storefront/{storefront_oid}/email/flows | Insert email flow
[**InsertEmailList**](StorefrontApi.md#insertemaillist) | **POST** /storefront/{storefront_oid}/email/lists | Insert email list
[**InsertEmailSegment**](StorefrontApi.md#insertemailsegment) | **POST** /storefront/{storefront_oid}/email/segments | Insert email segment
[**Search**](StorefrontApi.md#search) | **GET** /storefront/search | Searches for all matching values
[**SearchEmailListCustomers**](StorefrontApi.md#searchemaillistcustomers) | **GET** /storefront/{storefront_oid}/email/lists/{email_list_uuid}/search | Search email list customers
[**SearchEmailSegmentCustomers**](StorefrontApi.md#searchemailsegmentcustomers) | **GET** /storefront/{storefront_oid}/email/segments/{email_segment_uuid}/search | Search email segment customers
[**StartEmailCampaign**](StorefrontApi.md#startemailcampaign) | **PUT** /storefront/{storefront_oid}/email/campaigns/{email_campaign_uuid}/start | Start email campaign
[**SubscribeToEmailList**](StorefrontApi.md#subscribetoemaillist) | **POST** /storefront/{storefront_oid}/email/lists/{email_list_uuid}/subscribe | Subscribe customers to email list
[**UpdateEmailCampaign**](StorefrontApi.md#updateemailcampaign) | **PUT** /storefront/{storefront_oid}/email/campaigns/{email_campaign_uuid} | Update email campaign
[**UpdateEmailCommseq**](StorefrontApi.md#updateemailcommseq) | **PUT** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid} | Update email commseq
[**UpdateEmailEmail**](StorefrontApi.md#updateemailemail) | **PUT** /storefront/{storefront_oid}/email/emails/{commseq_email_uuid} | Update email email
[**UpdateEmailFlow**](StorefrontApi.md#updateemailflow) | **PUT** /storefront/{storefront_oid}/email/flows/{email_flow_uuid} | Update email flow
[**UpdateEmailList**](StorefrontApi.md#updateemaillist) | **PUT** /storefront/{storefront_oid}/email/lists/{email_list_uuid} | Update email list
[**UpdateEmailSegment**](StorefrontApi.md#updateemailsegment) | **PUT** /storefront/{storefront_oid}/email/segments/{email_segment_uuid} | Update email segment
[**UpdateExperiment**](StorefrontApi.md#updateexperiment) | **PUT** /storefront/{storefront_oid}/experiments/{storefront_experiment_oid} | Update experiment


<a name="archiveemaillist"></a>
# **ArchiveEmailList**
> EmailListArchiveResponse ArchiveEmailList (string storefrontOid, string emailListUuid)

Archive email list
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ArchiveEmailListExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailListUuid = emailListUuid_example;  // string | null

            try
            {
                // Archive email list
                EmailListArchiveResponse result = apiInstance.ArchiveEmailList(storefrontOid, emailListUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.ArchiveEmailList: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailListUuid** | **string**| null | 

### Return type

[**EmailListArchiveResponse**](EmailListArchiveResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="archiveemailsegment"></a>
# **ArchiveEmailSegment**
> EmailSegmentArchiveResponse ArchiveEmailSegment (string storefrontOid, string emailSegmentUuid)

Archive email segment
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ArchiveEmailSegmentExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailSegmentUuid = emailSegmentUuid_example;  // string | null

            try
            {
                // Archive email segment
                EmailSegmentArchiveResponse result = apiInstance.ArchiveEmailSegment(storefrontOid, emailSegmentUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.ArchiveEmailSegment: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailSegmentUuid** | **string**| null | 

### Return type

[**EmailSegmentArchiveResponse**](EmailSegmentArchiveResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cloneemailcampaign"></a>
# **CloneEmailCampaign**
> EmailCampaignResponse CloneEmailCampaign (string storefrontOid, string emailCampaignUuid)

Clone email campaign
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class CloneEmailCampaignExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailCampaignUuid = emailCampaignUuid_example;  // string | null

            try
            {
                // Clone email campaign
                EmailCampaignResponse result = apiInstance.CloneEmailCampaign(storefrontOid, emailCampaignUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.CloneEmailCampaign: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailCampaignUuid** | **string**| null | 

### Return type

[**EmailCampaignResponse**](EmailCampaignResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cloneemailflow"></a>
# **CloneEmailFlow**
> EmailFlowResponse CloneEmailFlow (string storefrontOid, string emailFlowUuid)

Clone email flow
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class CloneEmailFlowExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailFlowUuid = emailFlowUuid_example;  // string | null

            try
            {
                // Clone email flow
                EmailFlowResponse result = apiInstance.CloneEmailFlow(storefrontOid, emailFlowUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.CloneEmailFlow: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailFlowUuid** | **string**| null | 

### Return type

[**EmailFlowResponse**](EmailFlowResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createemailsendingdomain"></a>
# **CreateEmailSendingDomain**
> EmailSendingDomainResponse CreateEmailSendingDomain (string domain)

Create email campaign
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class CreateEmailSendingDomainExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var domain = domain_example;  // string | null

            try
            {
                // Create email campaign
                EmailSendingDomainResponse result = apiInstance.CreateEmailSendingDomain(domain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.CreateEmailSendingDomain: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| null | 

### Return type

[**EmailSendingDomainResponse**](EmailSendingDomainResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemailemail"></a>
# **DeleteEmailEmail**
> BaseResponse DeleteEmailEmail (string storefrontOid, string commseqEmailUuid)

Delete email email
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteEmailEmailExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var commseqEmailUuid = commseqEmailUuid_example;  // string | null

            try
            {
                // Delete email email
                BaseResponse result = apiInstance.DeleteEmailEmail(storefrontOid, commseqEmailUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.DeleteEmailEmail: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **commseqEmailUuid** | **string**| null | 

### Return type

[**BaseResponse**](BaseResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemaillistcustomer"></a>
# **DeleteEmailListCustomer**
> BaseResponse DeleteEmailListCustomer (string storefrontOid, string emailListUuid, string emailCustomerUuid)

Delete email list customer
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteEmailListCustomerExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailListUuid = emailListUuid_example;  // string | null
            var emailCustomerUuid = emailCustomerUuid_example;  // string | null

            try
            {
                // Delete email list customer
                BaseResponse result = apiInstance.DeleteEmailListCustomer(storefrontOid, emailListUuid, emailCustomerUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.DeleteEmailListCustomer: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailListUuid** | **string**| null | 
 **emailCustomerUuid** | **string**| null | 

### Return type

[**BaseResponse**](BaseResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemailsendingdomain"></a>
# **DeleteEmailSendingDomain**
> BaseResponse DeleteEmailSendingDomain (string domain)

delete email campaign
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteEmailSendingDomainExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var domain = domain_example;  // string | null

            try
            {
                // delete email campaign
                BaseResponse result = apiInstance.DeleteEmailSendingDomain(domain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.DeleteEmailSendingDomain: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| null | 

### Return type

[**BaseResponse**](BaseResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteexperiment"></a>
# **DeleteExperiment**
> void DeleteExperiment (string storefrontOid, int? storefrontExperimentOid)

Delete experiment
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteExperimentExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var storefrontExperimentOid = 56;  // int? | null

            try
            {
                // Delete experiment
                apiInstance.DeleteExperiment(storefrontOid, storefrontExperimentOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.DeleteExperiment: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **storefrontExperimentOid** | **int?**| null | 

### Return type

void (empty response body)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geocodeaddress"></a>
# **GeocodeAddress**
> GeocodeResponse GeocodeAddress (string storefrontOid, GeocodeRequest geocodeRequest)

Obtain lat/long for an address
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GeocodeAddressExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var geocodeRequest = new GeocodeRequest(); // GeocodeRequest | geocode request

            try
            {
                // Obtain lat/long for an address
                GeocodeResponse result = apiInstance.GeocodeAddress(storefrontOid, geocodeRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GeocodeAddress: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **geocodeRequest** | [**GeocodeRequest**](GeocodeRequest.md)| geocode request | 

### Return type

[**GeocodeResponse**](GeocodeResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcountries"></a>
# **GetCountries**
> CountriesResponse GetCountries (string storefrontOid)

Get countries

Obtain a list of all the countries 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetCountriesExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null

            try
            {
                // Get countries
                CountriesResponse result = apiInstance.GetCountries(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetCountries: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 

### Return type

[**CountriesResponse**](CountriesResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailbasetemplates"></a>
# **GetEmailBaseTemplates**
> EmailBaseTemplateListResponse GetEmailBaseTemplates (string storefrontOid)

Get email communication base templates
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailBaseTemplatesExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null

            try
            {
                // Get email communication base templates
                EmailBaseTemplateListResponse result = apiInstance.GetEmailBaseTemplates(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailBaseTemplates: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 

### Return type

[**EmailBaseTemplateListResponse**](EmailBaseTemplateListResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcampaign"></a>
# **GetEmailCampaign**
> EmailCampaignResponse GetEmailCampaign (string storefrontOid, string emailCampaignUuid)

Get email campaign
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCampaignExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailCampaignUuid = emailCampaignUuid_example;  // string | null

            try
            {
                // Get email campaign
                EmailCampaignResponse result = apiInstance.GetEmailCampaign(storefrontOid, emailCampaignUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCampaign: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailCampaignUuid** | **string**| null | 

### Return type

[**EmailCampaignResponse**](EmailCampaignResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcampaigns"></a>
# **GetEmailCampaigns**
> EmailCampaignsResponse GetEmailCampaigns (string storefrontOid)

Get email campaigns
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCampaignsExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null

            try
            {
                // Get email campaigns
                EmailCampaignsResponse result = apiInstance.GetEmailCampaigns(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCampaigns: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 

### Return type

[**EmailCampaignsResponse**](EmailCampaignsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcampaignswithstats"></a>
# **GetEmailCampaignsWithStats**
> EmailCampaignsResponse GetEmailCampaignsWithStats (string storefrontOid, string statDays)

Get email campaigns with stats
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCampaignsWithStatsExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var statDays = statDays_example;  // string | null

            try
            {
                // Get email campaigns with stats
                EmailCampaignsResponse result = apiInstance.GetEmailCampaignsWithStats(storefrontOid, statDays);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCampaignsWithStats: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **statDays** | **string**| null | 

### Return type

[**EmailCampaignsResponse**](EmailCampaignsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcommseq"></a>
# **GetEmailCommseq**
> EmailCommseqResponse GetEmailCommseq (string storefrontOid, string commseqUuid)

Get email commseq
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCommseqExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var commseqUuid = commseqUuid_example;  // string | null

            try
            {
                // Get email commseq
                EmailCommseqResponse result = apiInstance.GetEmailCommseq(storefrontOid, commseqUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCommseq: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **commseqUuid** | **string**| null | 

### Return type

[**EmailCommseqResponse**](EmailCommseqResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcommseqemailstats"></a>
# **GetEmailCommseqEmailStats**
> EmailStatSummaryResponse GetEmailCommseqEmailStats (string storefrontOid, string commseqUuid, EmailStatSummaryRequest statsRequest)

Get email communication sequence emails stats
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCommseqEmailStatsExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var commseqUuid = commseqUuid_example;  // string | null
            var statsRequest = new EmailStatSummaryRequest(); // EmailStatSummaryRequest | StatsRequest

            try
            {
                // Get email communication sequence emails stats
                EmailStatSummaryResponse result = apiInstance.GetEmailCommseqEmailStats(storefrontOid, commseqUuid, statsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCommseqEmailStats: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **commseqUuid** | **string**| null | 
 **statsRequest** | [**EmailStatSummaryRequest**](EmailStatSummaryRequest.md)| StatsRequest | 

### Return type

[**EmailStatSummaryResponse**](EmailStatSummaryResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcommseqstatoverall"></a>
# **GetEmailCommseqStatOverall**
> EmailCommseqStatResponse GetEmailCommseqStatOverall (string storefrontOid, string commseqUuid)

Get communication sequence stats overall
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCommseqStatOverallExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var commseqUuid = commseqUuid_example;  // string | null

            try
            {
                // Get communication sequence stats overall
                EmailCommseqStatResponse result = apiInstance.GetEmailCommseqStatOverall(storefrontOid, commseqUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCommseqStatOverall: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **commseqUuid** | **string**| null | 

### Return type

[**EmailCommseqStatResponse**](EmailCommseqStatResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcommseqstepwaiting"></a>
# **GetEmailCommseqStepWaiting**
> EmailStepWaitingResponse GetEmailCommseqStepWaiting (string storefrontOid, string commseqUuid, EmailStepWaitingRequest waitingRequest)

Get email communication sequence customers waiting at each requested step
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCommseqStepWaitingExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var commseqUuid = commseqUuid_example;  // string | null
            var waitingRequest = new EmailStepWaitingRequest(); // EmailStepWaitingRequest | WaitingRequest

            try
            {
                // Get email communication sequence customers waiting at each requested step
                EmailStepWaitingResponse result = apiInstance.GetEmailCommseqStepWaiting(storefrontOid, commseqUuid, waitingRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCommseqStepWaiting: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **commseqUuid** | **string**| null | 
 **waitingRequest** | [**EmailStepWaitingRequest**](EmailStepWaitingRequest.md)| WaitingRequest | 

### Return type

[**EmailStepWaitingResponse**](EmailStepWaitingResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcommseqs"></a>
# **GetEmailCommseqs**
> EmailCommseqsResponse GetEmailCommseqs (string storefrontOid)

Get email commseqs
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCommseqsExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null

            try
            {
                // Get email commseqs
                EmailCommseqsResponse result = apiInstance.GetEmailCommseqs(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCommseqs: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 

### Return type

[**EmailCommseqsResponse**](EmailCommseqsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaildashboardactivity"></a>
# **GetEmailDashboardActivity**
> EmailDashboardActivityResponse GetEmailDashboardActivity (string storefrontOid, int? lastRecords = null)

Get email dashboard activity
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailDashboardActivityExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var lastRecords = 56;  // int? | null (optional) 

            try
            {
                // Get email dashboard activity
                EmailDashboardActivityResponse result = apiInstance.GetEmailDashboardActivity(storefrontOid, lastRecords);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailDashboardActivity: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **lastRecords** | **int?**| null | [optional] 

### Return type

[**EmailDashboardActivityResponse**](EmailDashboardActivityResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaildashboardstats"></a>
# **GetEmailDashboardStats**
> EmailDashboardStatsResponse GetEmailDashboardStats (string storefrontOid, int? days = null)

Get dashboard stats
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailDashboardStatsExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var days = 56;  // int? | null (optional) 

            try
            {
                // Get dashboard stats
                EmailDashboardStatsResponse result = apiInstance.GetEmailDashboardStats(storefrontOid, days);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailDashboardStats: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **days** | **int?**| null | [optional] 

### Return type

[**EmailDashboardStatsResponse**](EmailDashboardStatsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailemail"></a>
# **GetEmailEmail**
> EmailCommseqEmailResponse GetEmailEmail (string storefrontOid, string commseqEmailUuid)

Get email email
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailEmailExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var commseqEmailUuid = commseqEmailUuid_example;  // string | null

            try
            {
                // Get email email
                EmailCommseqEmailResponse result = apiInstance.GetEmailEmail(storefrontOid, commseqEmailUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailEmail: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **commseqEmailUuid** | **string**| null | 

### Return type

[**EmailCommseqEmailResponse**](EmailCommseqEmailResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailemails"></a>
# **GetEmailEmails**
> EmailCommseqEmailsResponse GetEmailEmails (string storefrontOid)

Get email emails
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailEmailsExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null

            try
            {
                // Get email emails
                EmailCommseqEmailsResponse result = apiInstance.GetEmailEmails(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailEmails: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 

### Return type

[**EmailCommseqEmailsResponse**](EmailCommseqEmailsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailemailsmultiple"></a>
# **GetEmailEmailsMultiple**
> EmailCommseqEmailsResponse GetEmailEmailsMultiple (string storefrontOid, EmailCommseqEmailsRequest emailCommseqEmailsRequest)

Get email emails multiple
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailEmailsMultipleExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailCommseqEmailsRequest = new EmailCommseqEmailsRequest(); // EmailCommseqEmailsRequest | Request of email uuids

            try
            {
                // Get email emails multiple
                EmailCommseqEmailsResponse result = apiInstance.GetEmailEmailsMultiple(storefrontOid, emailCommseqEmailsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailEmailsMultiple: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailCommseqEmailsRequest** | [**EmailCommseqEmailsRequest**](EmailCommseqEmailsRequest.md)| Request of email uuids | 

### Return type

[**EmailCommseqEmailsResponse**](EmailCommseqEmailsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailflow"></a>
# **GetEmailFlow**
> EmailFlowResponse GetEmailFlow (string storefrontOid, string emailFlowUuid)

Get email flow
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailFlowExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailFlowUuid = emailFlowUuid_example;  // string | null

            try
            {
                // Get email flow
                EmailFlowResponse result = apiInstance.GetEmailFlow(storefrontOid, emailFlowUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailFlow: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailFlowUuid** | **string**| null | 

### Return type

[**EmailFlowResponse**](EmailFlowResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailflows"></a>
# **GetEmailFlows**
> EmailFlowsResponse GetEmailFlows (string storefrontOid)

Get email flows
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailFlowsExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null

            try
            {
                // Get email flows
                EmailFlowsResponse result = apiInstance.GetEmailFlows(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailFlows: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 

### Return type

[**EmailFlowsResponse**](EmailFlowsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaillist"></a>
# **GetEmailList**
> EmailListResponse GetEmailList (string storefrontOid, string emailListUuid)

Get email list
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailListExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailListUuid = emailListUuid_example;  // string | null

            try
            {
                // Get email list
                EmailListResponse result = apiInstance.GetEmailList(storefrontOid, emailListUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailList: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailListUuid** | **string**| null | 

### Return type

[**EmailListResponse**](EmailListResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaillistcustomereditorurl"></a>
# **GetEmailListCustomerEditorUrl**
> EmailCustomerEditorUrlResponse GetEmailListCustomerEditorUrl (string storefrontOid, string emailListUuid, string emailCustomerUuid)

Get email list customers
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailListCustomerEditorUrlExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailListUuid = emailListUuid_example;  // string | null
            var emailCustomerUuid = emailCustomerUuid_example;  // string | null

            try
            {
                // Get email list customers
                EmailCustomerEditorUrlResponse result = apiInstance.GetEmailListCustomerEditorUrl(storefrontOid, emailListUuid, emailCustomerUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailListCustomerEditorUrl: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailListUuid** | **string**| null | 
 **emailCustomerUuid** | **string**| null | 

### Return type

[**EmailCustomerEditorUrlResponse**](EmailCustomerEditorUrlResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaillistcustomers"></a>
# **GetEmailListCustomers**
> EmailListCustomersResponse GetEmailListCustomers (string storefrontOid, string emailListUuid, int? pageNumber = null, int? pageSize = null)

Get email list customers
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailListCustomersExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailListUuid = emailListUuid_example;  // string | null
            var pageNumber = 56;  // int? | null (optional) 
            var pageSize = 56;  // int? | null (optional) 

            try
            {
                // Get email list customers
                EmailListCustomersResponse result = apiInstance.GetEmailListCustomers(storefrontOid, emailListUuid, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailListCustomers: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailListUuid** | **string**| null | 
 **pageNumber** | **int?**| null | [optional] 
 **pageSize** | **int?**| null | [optional] 

### Return type

[**EmailListCustomersResponse**](EmailListCustomersResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaillists"></a>
# **GetEmailLists**
> EmailListsResponse GetEmailLists (string storefrontOid)

Get email lists
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailListsExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null

            try
            {
                // Get email lists
                EmailListsResponse result = apiInstance.GetEmailLists(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailLists: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 

### Return type

[**EmailListsResponse**](EmailListsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailsegment"></a>
# **GetEmailSegment**
> EmailSegmentResponse GetEmailSegment (string storefrontOid, string emailSegmentUuid)

Get email segment
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailSegmentExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailSegmentUuid = emailSegmentUuid_example;  // string | null

            try
            {
                // Get email segment
                EmailSegmentResponse result = apiInstance.GetEmailSegment(storefrontOid, emailSegmentUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailSegment: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailSegmentUuid** | **string**| null | 

### Return type

[**EmailSegmentResponse**](EmailSegmentResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailsegmentcustomereditorurl"></a>
# **GetEmailSegmentCustomerEditorUrl**
> EmailCustomerEditorUrlResponse GetEmailSegmentCustomerEditorUrl (string storefrontOid, string emailSegmentUuid, string emailCustomerUuid)

Get email segment customers editor URL
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailSegmentCustomerEditorUrlExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailSegmentUuid = emailSegmentUuid_example;  // string | null
            var emailCustomerUuid = emailCustomerUuid_example;  // string | null

            try
            {
                // Get email segment customers editor URL
                EmailCustomerEditorUrlResponse result = apiInstance.GetEmailSegmentCustomerEditorUrl(storefrontOid, emailSegmentUuid, emailCustomerUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailSegmentCustomerEditorUrl: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailSegmentUuid** | **string**| null | 
 **emailCustomerUuid** | **string**| null | 

### Return type

[**EmailCustomerEditorUrlResponse**](EmailCustomerEditorUrlResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailsegmentcustomers"></a>
# **GetEmailSegmentCustomers**
> EmailSegmentCustomersResponse GetEmailSegmentCustomers (string storefrontOid, string emailSegmentUuid, int? pageNumber = null, int? pageSize = null)

Get email segment customers
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailSegmentCustomersExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailSegmentUuid = emailSegmentUuid_example;  // string | null
            var pageNumber = 56;  // int? | null (optional) 
            var pageSize = 56;  // int? | null (optional) 

            try
            {
                // Get email segment customers
                EmailSegmentCustomersResponse result = apiInstance.GetEmailSegmentCustomers(storefrontOid, emailSegmentUuid, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailSegmentCustomers: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailSegmentUuid** | **string**| null | 
 **pageNumber** | **int?**| null | [optional] 
 **pageSize** | **int?**| null | [optional] 

### Return type

[**EmailSegmentCustomersResponse**](EmailSegmentCustomersResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailsegments"></a>
# **GetEmailSegments**
> EmailSegmentsResponse GetEmailSegments (string storefrontOid)

Get email segments
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailSegmentsExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null

            try
            {
                // Get email segments
                EmailSegmentsResponse result = apiInstance.GetEmailSegments(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailSegments: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 

### Return type

[**EmailSegmentsResponse**](EmailSegmentsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailsendingdomain"></a>
# **GetEmailSendingDomain**
> EmailSendingDomainResponse GetEmailSendingDomain (string domain)

Get email sending domain
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailSendingDomainExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var domain = domain_example;  // string | null

            try
            {
                // Get email sending domain
                EmailSendingDomainResponse result = apiInstance.GetEmailSendingDomain(domain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailSendingDomain: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| null | 

### Return type

[**EmailSendingDomainResponse**](EmailSendingDomainResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailsendingdomainstatus"></a>
# **GetEmailSendingDomainStatus**
> EmailSendingDomainResponse GetEmailSendingDomainStatus (string domain)

Get email sending domain status
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailSendingDomainStatusExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var domain = domain_example;  // string | null

            try
            {
                // Get email sending domain status
                EmailSendingDomainResponse result = apiInstance.GetEmailSendingDomainStatus(domain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailSendingDomainStatus: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| null | 

### Return type

[**EmailSendingDomainResponse**](EmailSendingDomainResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailsendingdomains"></a>
# **GetEmailSendingDomains**
> EmailSendingDomainsResponse GetEmailSendingDomains ()

Get email sending domains
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailSendingDomainsExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();

            try
            {
                // Get email sending domains
                EmailSendingDomainsResponse result = apiInstance.GetEmailSendingDomains();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailSendingDomains: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**EmailSendingDomainsResponse**](EmailSendingDomainsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailtemplate"></a>
# **GetEmailTemplate**
> EmailTemplate GetEmailTemplate (string storefrontOid, int? emailTemplateOid)

Get email template
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailTemplateExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailTemplateOid = 56;  // int? | null

            try
            {
                // Get email template
                EmailTemplate result = apiInstance.GetEmailTemplate(storefrontOid, emailTemplateOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailTemplate: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailTemplateOid** | **int?**| null | 

### Return type

[**EmailTemplate**](EmailTemplate.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailtemplates"></a>
# **GetEmailTemplates**
> EmailTemplatesResponse GetEmailTemplates (string storefrontOid, string triggerType = null)

Get email templates
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailTemplatesExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var triggerType = triggerType_example;  // string | null (optional) 

            try
            {
                // Get email templates
                EmailTemplatesResponse result = apiInstance.GetEmailTemplates(storefrontOid, triggerType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailTemplates: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **triggerType** | **string**| null | [optional] 

### Return type

[**EmailTemplatesResponse**](EmailTemplatesResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailthirdpartyproviders"></a>
# **GetEmailThirdPartyProviders**
> EmailThirdPartyProvidersResponse GetEmailThirdPartyProviders (string storefrontOid)

Get a list of third party email providers
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailThirdPartyProvidersExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null

            try
            {
                // Get a list of third party email providers
                EmailThirdPartyProvidersResponse result = apiInstance.GetEmailThirdPartyProviders(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailThirdPartyProviders: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 

### Return type

[**EmailThirdPartyProvidersResponse**](EmailThirdPartyProvidersResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexperiments"></a>
# **GetExperiments**
> ExperimentsResponse GetExperiments (string storefrontOid)

Get experiments
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetExperimentsExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null

            try
            {
                // Get experiments
                ExperimentsResponse result = apiInstance.GetExperiments(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetExperiments: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 

### Return type

[**ExperimentsResponse**](ExperimentsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistogrampropertynames"></a>
# **GetHistogramPropertyNames**
> EmailHistogramPropertyNamesResponse GetHistogramPropertyNames (string storefrontOid, string propertyType = null)

Get histogram property names

Obtain a list of property names for a given property type 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetHistogramPropertyNamesExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var propertyType = propertyType_example;  // string | null (optional) 

            try
            {
                // Get histogram property names
                EmailHistogramPropertyNamesResponse result = apiInstance.GetHistogramPropertyNames(storefrontOid, propertyType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetHistogramPropertyNames: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **propertyType** | **string**| null | [optional] 

### Return type

[**EmailHistogramPropertyNamesResponse**](EmailHistogramPropertyNamesResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistogrampropertyvalues"></a>
# **GetHistogramPropertyValues**
> EmailHistogramPropertyValuesResponse GetHistogramPropertyValues (string storefrontOid, string propertyName = null, string propertyType = null, int? limit = null)

Get histogram property values

Obtain a list of property values for a given property name and type 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetHistogramPropertyValuesExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var propertyName = propertyName_example;  // string | null (optional) 
            var propertyType = propertyType_example;  // string | null (optional) 
            var limit = 56;  // int? | null (optional) 

            try
            {
                // Get histogram property values
                EmailHistogramPropertyValuesResponse result = apiInstance.GetHistogramPropertyValues(storefrontOid, propertyName, propertyType, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetHistogramPropertyValues: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **propertyName** | **string**| null | [optional] 
 **propertyType** | **string**| null | [optional] 
 **limit** | **int?**| null | [optional] 

### Return type

[**EmailHistogramPropertyValuesResponse**](EmailHistogramPropertyValuesResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importemailthirdpartyproviderlist"></a>
# **ImportEmailThirdPartyProviderList**
> void ImportEmailThirdPartyProviderList (string storefrontOid, EmailThirdPartyListImportRequest importRequest)

Import a third party provider list
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ImportEmailThirdPartyProviderListExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var importRequest = new EmailThirdPartyListImportRequest(); // EmailThirdPartyListImportRequest | lists to import

            try
            {
                // Import a third party provider list
                apiInstance.ImportEmailThirdPartyProviderList(storefrontOid, importRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.ImportEmailThirdPartyProviderList: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **importRequest** | [**EmailThirdPartyListImportRequest**](EmailThirdPartyListImportRequest.md)| lists to import | 

### Return type

void (empty response body)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertemailcampaign"></a>
# **InsertEmailCampaign**
> EmailCampaignResponse InsertEmailCampaign (string storefrontOid, EmailCampaign emailCampaign)

Insert email campaign
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertEmailCampaignExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailCampaign = new EmailCampaign(); // EmailCampaign | Email campaign

            try
            {
                // Insert email campaign
                EmailCampaignResponse result = apiInstance.InsertEmailCampaign(storefrontOid, emailCampaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.InsertEmailCampaign: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailCampaign** | [**EmailCampaign**](EmailCampaign.md)| Email campaign | 

### Return type

[**EmailCampaignResponse**](EmailCampaignResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertemailcommseq"></a>
# **InsertEmailCommseq**
> EmailCommseqResponse InsertEmailCommseq (string storefrontOid, EmailCommseq emailCommseq)

Insert email commseq
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertEmailCommseqExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailCommseq = new EmailCommseq(); // EmailCommseq | Email commseq

            try
            {
                // Insert email commseq
                EmailCommseqResponse result = apiInstance.InsertEmailCommseq(storefrontOid, emailCommseq);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.InsertEmailCommseq: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailCommseq** | [**EmailCommseq**](EmailCommseq.md)| Email commseq | 

### Return type

[**EmailCommseqResponse**](EmailCommseqResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertemailemail"></a>
# **InsertEmailEmail**
> EmailCommseqEmailResponse InsertEmailEmail (string storefrontOid, EmailCommseqEmail emailCommseqEmail)

Insert email email
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertEmailEmailExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailCommseqEmail = new EmailCommseqEmail(); // EmailCommseqEmail | Email email

            try
            {
                // Insert email email
                EmailCommseqEmailResponse result = apiInstance.InsertEmailEmail(storefrontOid, emailCommseqEmail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.InsertEmailEmail: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailCommseqEmail** | [**EmailCommseqEmail**](EmailCommseqEmail.md)| Email email | 

### Return type

[**EmailCommseqEmailResponse**](EmailCommseqEmailResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertemailflow"></a>
# **InsertEmailFlow**
> EmailFlowResponse InsertEmailFlow (string storefrontOid, EmailFlow emailFlow)

Insert email flow
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertEmailFlowExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailFlow = new EmailFlow(); // EmailFlow | Email flow

            try
            {
                // Insert email flow
                EmailFlowResponse result = apiInstance.InsertEmailFlow(storefrontOid, emailFlow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.InsertEmailFlow: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailFlow** | [**EmailFlow**](EmailFlow.md)| Email flow | 

### Return type

[**EmailFlowResponse**](EmailFlowResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertemaillist"></a>
# **InsertEmailList**
> EmailListResponse InsertEmailList (string storefrontOid, EmailList emailList)

Insert email list
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertEmailListExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailList = new EmailList(); // EmailList | Email list

            try
            {
                // Insert email list
                EmailListResponse result = apiInstance.InsertEmailList(storefrontOid, emailList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.InsertEmailList: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailList** | [**EmailList**](EmailList.md)| Email list | 

### Return type

[**EmailListResponse**](EmailListResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertemailsegment"></a>
# **InsertEmailSegment**
> EmailSegmentResponse InsertEmailSegment (string storefrontOid, EmailSegment emailSegment)

Insert email segment
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertEmailSegmentExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailSegment = new EmailSegment(); // EmailSegment | Email segment

            try
            {
                // Insert email segment
                EmailSegmentResponse result = apiInstance.InsertEmailSegment(storefrontOid, emailSegment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.InsertEmailSegment: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailSegment** | [**EmailSegment**](EmailSegment.md)| Email segment | 

### Return type

[**EmailSegmentResponse**](EmailSegmentResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="search"></a>
# **Search**
> LookupResponse Search (string category = null, string matches = null, int? maxHits = null)

Searches for all matching values
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SearchExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var category = category_example;  // string | null (optional) 
            var matches = matches_example;  // string | null (optional) 
            var maxHits = 56;  // int? | null (optional) 

            try
            {
                // Searches for all matching values
                LookupResponse result = apiInstance.Search(category, matches, maxHits);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.Search: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **category** | **string**| null | [optional] 
 **matches** | **string**| null | [optional] 
 **maxHits** | **int?**| null | [optional] 

### Return type

[**LookupResponse**](LookupResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchemaillistcustomers"></a>
# **SearchEmailListCustomers**
> EmailListCustomersResponse SearchEmailListCustomers (string storefrontOid, string emailListUuid, string startsWith = null)

Search email list customers
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SearchEmailListCustomersExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailListUuid = emailListUuid_example;  // string | null
            var startsWith = startsWith_example;  // string | null (optional) 

            try
            {
                // Search email list customers
                EmailListCustomersResponse result = apiInstance.SearchEmailListCustomers(storefrontOid, emailListUuid, startsWith);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.SearchEmailListCustomers: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailListUuid** | **string**| null | 
 **startsWith** | **string**| null | [optional] 

### Return type

[**EmailListCustomersResponse**](EmailListCustomersResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchemailsegmentcustomers"></a>
# **SearchEmailSegmentCustomers**
> EmailSegmentCustomersResponse SearchEmailSegmentCustomers (string storefrontOid, string emailSegmentUuid, string startsWith = null)

Search email segment customers
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SearchEmailSegmentCustomersExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailSegmentUuid = emailSegmentUuid_example;  // string | null
            var startsWith = startsWith_example;  // string | null (optional) 

            try
            {
                // Search email segment customers
                EmailSegmentCustomersResponse result = apiInstance.SearchEmailSegmentCustomers(storefrontOid, emailSegmentUuid, startsWith);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.SearchEmailSegmentCustomers: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailSegmentUuid** | **string**| null | 
 **startsWith** | **string**| null | [optional] 

### Return type

[**EmailSegmentCustomersResponse**](EmailSegmentCustomersResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startemailcampaign"></a>
# **StartEmailCampaign**
> BaseResponse StartEmailCampaign (string storefrontOid, string emailCampaignUuid)

Start email campaign
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class StartEmailCampaignExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailCampaignUuid = emailCampaignUuid_example;  // string | null

            try
            {
                // Start email campaign
                BaseResponse result = apiInstance.StartEmailCampaign(storefrontOid, emailCampaignUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.StartEmailCampaign: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailCampaignUuid** | **string**| null | 

### Return type

[**BaseResponse**](BaseResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscribetoemaillist"></a>
# **SubscribeToEmailList**
> EmailListSubscribeResponse SubscribeToEmailList (string storefrontOid, string emailListUuid, List<EmailCustomer> customers)

Subscribe customers to email list
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SubscribeToEmailListExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailListUuid = emailListUuid_example;  // string | null
            var customers = new List<EmailCustomer>(); // List<EmailCustomer> | Customers

            try
            {
                // Subscribe customers to email list
                EmailListSubscribeResponse result = apiInstance.SubscribeToEmailList(storefrontOid, emailListUuid, customers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.SubscribeToEmailList: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailListUuid** | **string**| null | 
 **customers** | [**List&lt;EmailCustomer&gt;**](EmailCustomer.md)| Customers | 

### Return type

[**EmailListSubscribeResponse**](EmailListSubscribeResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailcampaign"></a>
# **UpdateEmailCampaign**
> EmailCampaignResponse UpdateEmailCampaign (string storefrontOid, string emailCampaignUuid, EmailCampaign emailCampaign)

Update email campaign
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateEmailCampaignExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailCampaignUuid = emailCampaignUuid_example;  // string | null
            var emailCampaign = new EmailCampaign(); // EmailCampaign | Email campaign

            try
            {
                // Update email campaign
                EmailCampaignResponse result = apiInstance.UpdateEmailCampaign(storefrontOid, emailCampaignUuid, emailCampaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateEmailCampaign: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailCampaignUuid** | **string**| null | 
 **emailCampaign** | [**EmailCampaign**](EmailCampaign.md)| Email campaign | 

### Return type

[**EmailCampaignResponse**](EmailCampaignResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailcommseq"></a>
# **UpdateEmailCommseq**
> EmailCommseqResponse UpdateEmailCommseq (string storefrontOid, string commseqUuid, EmailCommseq emailCommseq)

Update email commseq
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateEmailCommseqExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var commseqUuid = commseqUuid_example;  // string | null
            var emailCommseq = new EmailCommseq(); // EmailCommseq | Email commseq

            try
            {
                // Update email commseq
                EmailCommseqResponse result = apiInstance.UpdateEmailCommseq(storefrontOid, commseqUuid, emailCommseq);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateEmailCommseq: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **commseqUuid** | **string**| null | 
 **emailCommseq** | [**EmailCommseq**](EmailCommseq.md)| Email commseq | 

### Return type

[**EmailCommseqResponse**](EmailCommseqResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailemail"></a>
# **UpdateEmailEmail**
> EmailCommseqEmailResponse UpdateEmailEmail (string storefrontOid, string commseqEmailUuid, EmailCommseqEmail emailCommseqEmail)

Update email email
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateEmailEmailExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var commseqEmailUuid = commseqEmailUuid_example;  // string | null
            var emailCommseqEmail = new EmailCommseqEmail(); // EmailCommseqEmail | Email commseq email

            try
            {
                // Update email email
                EmailCommseqEmailResponse result = apiInstance.UpdateEmailEmail(storefrontOid, commseqEmailUuid, emailCommseqEmail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateEmailEmail: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **commseqEmailUuid** | **string**| null | 
 **emailCommseqEmail** | [**EmailCommseqEmail**](EmailCommseqEmail.md)| Email commseq email | 

### Return type

[**EmailCommseqEmailResponse**](EmailCommseqEmailResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailflow"></a>
# **UpdateEmailFlow**
> EmailFlowResponse UpdateEmailFlow (string storefrontOid, string emailFlowUuid, EmailFlow emailFlow)

Update email flow
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateEmailFlowExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailFlowUuid = emailFlowUuid_example;  // string | null
            var emailFlow = new EmailFlow(); // EmailFlow | Email flow

            try
            {
                // Update email flow
                EmailFlowResponse result = apiInstance.UpdateEmailFlow(storefrontOid, emailFlowUuid, emailFlow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateEmailFlow: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailFlowUuid** | **string**| null | 
 **emailFlow** | [**EmailFlow**](EmailFlow.md)| Email flow | 

### Return type

[**EmailFlowResponse**](EmailFlowResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemaillist"></a>
# **UpdateEmailList**
> EmailListResponse UpdateEmailList (string storefrontOid, string emailListUuid, EmailList emailList)

Update email list
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateEmailListExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailListUuid = emailListUuid_example;  // string | null
            var emailList = new EmailList(); // EmailList | Email list

            try
            {
                // Update email list
                EmailListResponse result = apiInstance.UpdateEmailList(storefrontOid, emailListUuid, emailList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateEmailList: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailListUuid** | **string**| null | 
 **emailList** | [**EmailList**](EmailList.md)| Email list | 

### Return type

[**EmailListResponse**](EmailListResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailsegment"></a>
# **UpdateEmailSegment**
> EmailSegmentResponse UpdateEmailSegment (string storefrontOid, string emailSegmentUuid, EmailSegment emailSegment)

Update email segment
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateEmailSegmentExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var emailSegmentUuid = emailSegmentUuid_example;  // string | null
            var emailSegment = new EmailSegment(); // EmailSegment | Email segment

            try
            {
                // Update email segment
                EmailSegmentResponse result = apiInstance.UpdateEmailSegment(storefrontOid, emailSegmentUuid, emailSegment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateEmailSegment: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **emailSegmentUuid** | **string**| null | 
 **emailSegment** | [**EmailSegment**](EmailSegment.md)| Email segment | 

### Return type

[**EmailSegmentResponse**](EmailSegmentResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateexperiment"></a>
# **UpdateExperiment**
> ExperimentResponse UpdateExperiment (string storefrontOid, int? storefrontExperimentOid, Experiment experiment)

Update experiment
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateExperimentExample
    {
        public void main()
        {

            // This is required.  See https://www.ultracart.com/api/versioning.html
            Configuration.Default.DefaultHeader.Add("X-UltraCart-Api-Version", "2017-03-01");

            // You will need ONE of the authentication methods below.  Most applications will use a Simple API Key
            // https://www.ultracart.com/api/authentication.html

            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartBrowserApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-browser-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            // ------------------------------------------------------------
            // OAUTH AUTHENTICATION
            // Use this authentication method for third party applications,
            // where your application is acting on behalf of numerous merchants.
            // Configure OAuth2 access token for authorization: ultraCartOauth
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            Configuration.Default.AccessToken
                 = "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00";
            // ------------------------------------------------------------


            // ------------------------------------------------------------
            // SIMPLE KEY AUTHENTICATION
            // Configure API key authorization: ultraCartSimpleApiKey
            // TODO - Replace the key below with your own key.  The key below is not a real key.
            // Tutorial for creating a key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            Configuration.Default.AddApiKey("x-ultracart-simple-key", "508052342b482a015d85c69048030a0005a9da7cea5afe015d85c69048030a00");
            // ------------------------------------------------------------
              

            var apiInstance = new StorefrontApi();
            var storefrontOid = storefrontOid_example;  // string | null
            var storefrontExperimentOid = 56;  // int? | null
            var experiment = new Experiment(); // Experiment | Experiment

            try
            {
                // Update experiment
                ExperimentResponse result = apiInstance.UpdateExperiment(storefrontOid, storefrontExperimentOid, experiment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateExperiment: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **string**| null | 
 **storefrontExperimentOid** | **int?**| null | 
 **experiment** | [**Experiment**](Experiment.md)| Experiment | 

### Return type

[**ExperimentResponse**](ExperimentResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

