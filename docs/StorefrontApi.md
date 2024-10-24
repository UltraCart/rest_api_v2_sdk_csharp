# com.ultracart.admin.v2.Api.StorefrontApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddToLibrary**](StorefrontApi.md#addtolibrary) | **POST** /storefront/code_library | Add to library
[**ApplyToStoreFront**](StorefrontApi.md#applytostorefront) | **POST** /storefront/code_library/apply | Apply library item to storefront.
[**ArchiveEmailList**](StorefrontApi.md#archiveemaillist) | **POST** /storefront/{storefront_oid}/email/lists/{email_list_uuid}/archive | Archive email list
[**ArchiveEmailSegment**](StorefrontApi.md#archiveemailsegment) | **POST** /storefront/{storefront_oid}/email/segments/{email_segment_uuid}/archive | Archive email segment
[**BackPopulateEmailFlow**](StorefrontApi.md#backpopulateemailflow) | **POST** /storefront/{storefront_oid}/email/flows/{email_flow_uuid}/backfill | Back populate email flow
[**CheckDownloadEmailSegment**](StorefrontApi.md#checkdownloademailsegment) | **POST** /storefront/{storefront_oid}/email/segments/{email_segment_uuid}/downloadPrepare/{email_segment_rebuild_uuid} | Check download of email segment
[**CloneEmailCampaign**](StorefrontApi.md#cloneemailcampaign) | **POST** /storefront/{storefront_oid}/email/campaigns/{email_campaign_uuid}/clone | Clone email campaign
[**CloneEmailFlow**](StorefrontApi.md#cloneemailflow) | **POST** /storefront/{storefront_oid}/email/flows/{email_flow_uuid}/clone | Clone email flow
[**CreateEmailSendingDomain**](StorefrontApi.md#createemailsendingdomain) | **POST** /storefront/email/sending_domains/{domain}/create | Create email campaign
[**CreateEmailSendingDomain2**](StorefrontApi.md#createemailsendingdomain2) | **POST** /storefront/email/sending_domains | Create email sending domain for various providers
[**CreateFsDirectory**](StorefrontApi.md#createfsdirectory) | **POST** /storefront/{id}/fs/dir | Create file manager directory
[**CreateTwilioAccount**](StorefrontApi.md#createtwilioaccount) | **POST** /storefront/twilio/accounts | Create Twilio account
[**DeleteEmailCampaignFolder**](StorefrontApi.md#deleteemailcampaignfolder) | **DELETE** /storefront/{storefront_oid}/email/campaign_folders/{email_campaign_folder_uuid} | Delete email campaignFolder
[**DeleteEmailCommseqStat**](StorefrontApi.md#deleteemailcommseqstat) | **DELETE** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/stat | Delete communication sequence stats
[**DeleteEmailEmail**](StorefrontApi.md#deleteemailemail) | **DELETE** /storefront/{storefront_oid}/email/emails/{commseq_email_uuid} | Delete email email
[**DeleteEmailFlowFolder**](StorefrontApi.md#deleteemailflowfolder) | **DELETE** /storefront/{storefront_oid}/email/flow_folders/{email_flow_folder_uuid} | Delete email flowFolder
[**DeleteEmailListCustomer**](StorefrontApi.md#deleteemaillistcustomer) | **DELETE** /storefront/{storefront_oid}/email/lists/{email_list_uuid}/customers/{email_customer_uuid} | Delete email list customer
[**DeleteEmailListSegmentFolder**](StorefrontApi.md#deleteemaillistsegmentfolder) | **DELETE** /storefront/{storefront_oid}/email/list_segment_folders/{email_list_segment_folder_uuid} | Delete email ListSegmentFolder
[**DeleteEmailPostcard**](StorefrontApi.md#deleteemailpostcard) | **DELETE** /storefront/{storefront_oid}/email/postcards/{commseq_postcard_uuid} | Delete email postcard
[**DeleteEmailSendingDomain**](StorefrontApi.md#deleteemailsendingdomain) | **DELETE** /storefront/email/sending_domains/{domain} | delete email campaign
[**DeleteExperiment**](StorefrontApi.md#deleteexperiment) | **DELETE** /storefront/{storefront_oid}/experiments/{storefront_experiment_oid} | Delete experiment
[**DeleteFsFile**](StorefrontApi.md#deletefsfile) | **DELETE** /storefront/{id}/fs/file | Delete file manager directory
[**DeleteHeatmap**](StorefrontApi.md#deleteheatmap) | **DELETE** /storefront/{storefront_oid}/screen_recordings/heatmap | Delete screen recording heatmap
[**DeleteLibraryItem**](StorefrontApi.md#deletelibraryitem) | **DELETE** /storefront/code_library/{library_item_oid} | Delete library item
[**DeleteLibraryItemPublishedVersions**](StorefrontApi.md#deletelibraryitempublishedversions) | **DELETE** /storefront/code_library/{library_item_oid}/published_versions | Delete all published versions for a library item, including anything in review.
[**DeleteScreenRecordingSegment**](StorefrontApi.md#deletescreenrecordingsegment) | **DELETE** /storefront/{storefront_oid}/screen_recordings/segments/{screen_recording_segment_oid} | Delete screen recording segment
[**DeleteTwilioAccount**](StorefrontApi.md#deletetwilioaccount) | **DELETE** /storefront/twilio/accounts/{esp_twilio_uuid} | delete Twilio account
[**DuplicateLibraryItem**](StorefrontApi.md#duplicatelibraryitem) | **POST** /storefront/code_library/{library_item_oid}/duplicate | Duplicate library item.
[**FavoriteScreenRecording**](StorefrontApi.md#favoritescreenrecording) | **POST** /storefront/{storefront_oid}/screen_recordings/{screen_recording_uuid}/favorite | Update favorite flag on screen recording
[**GeocodeAddress**](StorefrontApi.md#geocodeaddress) | **POST** /storefront/{storefront_oid}/email/geocode | Obtain lat/long for an address
[**GetCountries**](StorefrontApi.md#getcountries) | **GET** /storefront/{storefront_oid}/email/countries | Get countries
[**GetEditorToken**](StorefrontApi.md#geteditortoken) | **GET** /storefront/{storefront_oid}/editor_token | Gets editor token
[**GetEmailBaseTemplates**](StorefrontApi.md#getemailbasetemplates) | **GET** /storefront/{storefront_oid}/email/baseTemplates | Get email communication base templates
[**GetEmailCampaign**](StorefrontApi.md#getemailcampaign) | **GET** /storefront/{storefront_oid}/email/campaigns/{email_campaign_uuid} | Get email campaign
[**GetEmailCampaignFolder**](StorefrontApi.md#getemailcampaignfolder) | **GET** /storefront/{storefront_oid}/email/campaign_folders/{email_campaign_folder_uuid} | Get email campaign folder
[**GetEmailCampaignFolders**](StorefrontApi.md#getemailcampaignfolders) | **GET** /storefront/{storefront_oid}/email/campaign_folders | Get email campaign folders
[**GetEmailCampaignScreenshots**](StorefrontApi.md#getemailcampaignscreenshots) | **GET** /storefront/{storefront_oid}/email/campaigns/{email_campaign_uuid}/screenshots | Get email campaign screenshots
[**GetEmailCampaigns**](StorefrontApi.md#getemailcampaigns) | **GET** /storefront/{storefront_oid}/email/campaigns | Get email campaigns
[**GetEmailCampaignsWithStats**](StorefrontApi.md#getemailcampaignswithstats) | **GET** /storefront/{storefront_oid}/email/campaignsWithStats/{stat_days} | Get email campaigns with stats
[**GetEmailCommseq**](StorefrontApi.md#getemailcommseq) | **GET** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid} | Get email commseq
[**GetEmailCommseqEmailStats**](StorefrontApi.md#getemailcommseqemailstats) | **POST** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/emailStats | Get email communication sequence emails stats
[**GetEmailCommseqPostcardStats**](StorefrontApi.md#getemailcommseqpostcardstats) | **POST** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/postcardStats | Get email communication sequence postcard stats
[**GetEmailCommseqPostcardTracking**](StorefrontApi.md#getemailcommseqpostcardtracking) | **GET** /storefront/{storefront_oid}/email/postcards/{commseq_postcard_uuid}/tracking | Get email communication postcard tracking
[**GetEmailCommseqRateLimiters**](StorefrontApi.md#getemailcommseqratelimiters) | **GET** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/rate_limiters | Get email commseq rate limiters
[**GetEmailCommseqSmsStats**](StorefrontApi.md#getemailcommseqsmsstats) | **POST** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/smsStats | Get email communication sequence sms stats
[**GetEmailCommseqStatOverall**](StorefrontApi.md#getemailcommseqstatoverall) | **GET** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/stat | Get communication sequence stats overall
[**GetEmailCommseqStepStats**](StorefrontApi.md#getemailcommseqstepstats) | **POST** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/stepStats | Get email communication sequence step stats
[**GetEmailCommseqStepWaiting**](StorefrontApi.md#getemailcommseqstepwaiting) | **POST** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/waiting | Get email communication sequence customers waiting at each requested step
[**GetEmailCommseqWebhookEditorValues**](StorefrontApi.md#getemailcommseqwebhookeditorvalues) | **GET** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/webhookEditorValues | Get email webhook editor values
[**GetEmailCommseqs**](StorefrontApi.md#getemailcommseqs) | **GET** /storefront/{storefront_oid}/email/commseqs | Get email commseqs
[**GetEmailCustomerEditorUrl**](StorefrontApi.md#getemailcustomereditorurl) | **GET** /storefront/{storefront_oid}/email/customers/{email_customer_uuid}/editor_url | Get customers editor URL
[**GetEmailCustomers**](StorefrontApi.md#getemailcustomers) | **GET** /storefront/{storefront_oid}/email/customers | Get email customers
[**GetEmailDashboardActivity**](StorefrontApi.md#getemaildashboardactivity) | **GET** /storefront/{storefront_oid}/email/dashboard_activity | Get email dashboard activity
[**GetEmailDashboardStats**](StorefrontApi.md#getemaildashboardstats) | **GET** /storefront/{storefront_oid}/email/dashboard_stats | Get dashboard stats
[**GetEmailDispatchLogs**](StorefrontApi.md#getemaildispatchlogs) | **GET** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/steps/{commseq_step_uuid}/logs | Get email dispatch logs
[**GetEmailEmail**](StorefrontApi.md#getemailemail) | **GET** /storefront/{storefront_oid}/email/emails/{commseq_email_uuid} | Get email email
[**GetEmailEmailClicks**](StorefrontApi.md#getemailemailclicks) | **GET** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/steps/{commseq_step_uuid}/emails/{commseq_email_uuid}/clicks | Get email email clicks
[**GetEmailEmailCustomerEditorUrl**](StorefrontApi.md#getemailemailcustomereditorurl) | **GET** /storefront/{storefront_oid}/email/emails/{commseq_email_uuid}/orders/{order_id}/editor_url | Get email order customer editor url
[**GetEmailEmailOrders**](StorefrontApi.md#getemailemailorders) | **GET** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/steps/{commseq_step_uuid}/emails/{commseq_email_uuid}/orders | Get email email orders
[**GetEmailEmails**](StorefrontApi.md#getemailemails) | **GET** /storefront/{storefront_oid}/email/emails | Get email emails
[**GetEmailEmailsMultiple**](StorefrontApi.md#getemailemailsmultiple) | **POST** /storefront/{storefront_oid}/email/emails/multiple | Get email emails multiple
[**GetEmailFlow**](StorefrontApi.md#getemailflow) | **GET** /storefront/{storefront_oid}/email/flows/{email_flow_uuid} | Get email flow
[**GetEmailFlowFolder**](StorefrontApi.md#getemailflowfolder) | **GET** /storefront/{storefront_oid}/email/flow_folders/{email_flow_folder_uuid} | Get email flow folder
[**GetEmailFlowFolders**](StorefrontApi.md#getemailflowfolders) | **GET** /storefront/{storefront_oid}/email/flow_folders | Get email flow folders
[**GetEmailFlowScreenshots**](StorefrontApi.md#getemailflowscreenshots) | **GET** /storefront/{storefront_oid}/email/flows/{email_flow_uuid}/screenshots | Get email flow screenshots
[**GetEmailFlows**](StorefrontApi.md#getemailflows) | **GET** /storefront/{storefront_oid}/email/flows | Get email flows
[**GetEmailGlobalSettings**](StorefrontApi.md#getemailglobalsettings) | **GET** /storefront/email/global_settings | Get email globalsettings
[**GetEmailList**](StorefrontApi.md#getemaillist) | **GET** /storefront/{storefront_oid}/email/lists/{email_list_uuid} | Get email list
[**GetEmailListCustomerEditorUrl**](StorefrontApi.md#getemaillistcustomereditorurl) | **GET** /storefront/{storefront_oid}/email/lists/{email_list_uuid}/customers/{email_customer_uuid}/editor_url | Get email list customer editor url
[**GetEmailListCustomers**](StorefrontApi.md#getemaillistcustomers) | **GET** /storefront/{storefront_oid}/email/lists/{email_list_uuid}/customers | Get email list customers
[**GetEmailListSegmentFolder**](StorefrontApi.md#getemaillistsegmentfolder) | **GET** /storefront/{storefront_oid}/email/list_segment_folders/{email_list_segment_folder_uuid} | Get email campaign folder
[**GetEmailListSegmentFolders**](StorefrontApi.md#getemaillistsegmentfolders) | **GET** /storefront/{storefront_oid}/email/list_segment_folders | Get email campaign folders
[**GetEmailLists**](StorefrontApi.md#getemaillists) | **GET** /storefront/{storefront_oid}/email/lists | Get email lists
[**GetEmailPerformance**](StorefrontApi.md#getemailperformance) | **GET** /storefront/{storefront_oid}/email/performance | Get email performance
[**GetEmailPlan**](StorefrontApi.md#getemailplan) | **GET** /storefront/{storefront_oid}/email/plan | Get email plan
[**GetEmailPostcard**](StorefrontApi.md#getemailpostcard) | **GET** /storefront/{storefront_oid}/email/postcards/{commseq_postcard_uuid} | Get email postcard
[**GetEmailPostcards**](StorefrontApi.md#getemailpostcards) | **GET** /storefront/{storefront_oid}/email/postcards | Get email postcards
[**GetEmailPostcardsMultiple**](StorefrontApi.md#getemailpostcardsmultiple) | **POST** /storefront/{storefront_oid}/email/postcards/multiple | Get email postcards multiple
[**GetEmailSegment**](StorefrontApi.md#getemailsegment) | **GET** /storefront/{storefront_oid}/email/segments/{email_segment_uuid} | Get email segment
[**GetEmailSegmentCustomerEditorUrl**](StorefrontApi.md#getemailsegmentcustomereditorurl) | **GET** /storefront/{storefront_oid}/email/segments/{email_segment_uuid}/customers/{email_customer_uuid}/editor_url | Get email segment customers editor URL
[**GetEmailSegmentCustomers**](StorefrontApi.md#getemailsegmentcustomers) | **GET** /storefront/{storefront_oid}/email/segments/{email_segment_uuid}/customers | Get email segment customers
[**GetEmailSegments**](StorefrontApi.md#getemailsegments) | **GET** /storefront/{storefront_oid}/email/segments | Get email segments
[**GetEmailSendingDomain**](StorefrontApi.md#getemailsendingdomain) | **GET** /storefront/email/sending_domain/{domain} | Get email sending domain
[**GetEmailSendingDomainStatus**](StorefrontApi.md#getemailsendingdomainstatus) | **POST** /storefront/email/sending_domains/{domain}/status | Get email sending domain status
[**GetEmailSendingDomains**](StorefrontApi.md#getemailsendingdomains) | **GET** /storefront/email/sending_domains | Get email sending domains
[**GetEmailSettings**](StorefrontApi.md#getemailsettings) | **GET** /storefront/{storefront_oid}/email/settings | Get email settings
[**GetEmailSmsOrders**](StorefrontApi.md#getemailsmsorders) | **GET** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/steps/{commseq_step_uuid}/sms/orders | Get email sms orders
[**GetEmailTemplate**](StorefrontApi.md#getemailtemplate) | **GET** /storefront/{storefront_oid}/email/templates/{email_template_oid} | Get email template
[**GetEmailTemplates**](StorefrontApi.md#getemailtemplates) | **GET** /storefront/{storefront_oid}/email/templates | Get email templates
[**GetEmailThirdPartyProviders**](StorefrontApi.md#getemailthirdpartyproviders) | **GET** /storefront/{storefront_oid}/email/third_party_providers | Get a list of third party email providers
[**GetExperiments**](StorefrontApi.md#getexperiments) | **GET** /storefront/{storefront_oid}/experiments | Get experiments
[**GetFsDirectory**](StorefrontApi.md#getfsdirectory) | **GET** /storefront/{id}/fs/dir | Get file manager directory
[**GetHeatmap**](StorefrontApi.md#getheatmap) | **POST** /storefront/{storefront_oid}/screen_recordings/heatmap | Get screen recording heatmap
[**GetHeatmapIndex**](StorefrontApi.md#getheatmapindex) | **POST** /storefront/{storefront_oid}/screen_recordings/heatmap/index | Get screen recording heatmap index
[**GetHistogramPropertyNames**](StorefrontApi.md#gethistogrampropertynames) | **GET** /storefront/{storefront_oid}/email/histogram/property_names | Get histogram property names
[**GetHistogramPropertyValues**](StorefrontApi.md#gethistogrampropertyvalues) | **GET** /storefront/{storefront_oid}/email/histogram/property_values | Get histogram property values
[**GetLibraryFilterValues**](StorefrontApi.md#getlibraryfiltervalues) | **GET** /storefront/code_library/filter_values | Get library values used to populate drop down boxes for filtering.
[**GetLibraryItem**](StorefrontApi.md#getlibraryitem) | **GET** /storefront/code_library/{library_item_oid} | Get library item.
[**GetLibraryItemPublishedVersions**](StorefrontApi.md#getlibraryitempublishedversions) | **GET** /storefront/code_library/{library_item_oid}/published_versions | Get all published versions for a library item.
[**GetScreenRecording**](StorefrontApi.md#getscreenrecording) | **GET** /storefront/{storefront_oid}/screen_recordings/{screen_recording_uuid} | Get screen recording
[**GetScreenRecordingPageViewData**](StorefrontApi.md#getscreenrecordingpageviewdata) | **GET** /storefront/{storefront_oid}/screen_recordings/{screen_recording_uuid}/page_view_data/{screen_recording_page_view_uuid} | Get screen recording page view data
[**GetScreenRecordingSegment**](StorefrontApi.md#getscreenrecordingsegment) | **GET** /storefront/{storefront_oid}/screen_recordings/segments/{screen_recording_segment_oid} | Get screen recording segment
[**GetScreenRecordingSegments**](StorefrontApi.md#getscreenrecordingsegments) | **GET** /storefront/{storefront_oid}/screen_recordings/segments | Get screen recording segments
[**GetScreenRecordingSettings**](StorefrontApi.md#getscreenrecordingsettings) | **GET** /storefront/{storefront_oid}/screen_recordings/settings | Get screen recording settings
[**GetScreenRecordingTags**](StorefrontApi.md#getscreenrecordingtags) | **POST** /storefront/{storefront_oid}/screen_recordings/tags | Get tags used by screen recording
[**GetScreenRecordingsByQuery**](StorefrontApi.md#getscreenrecordingsbyquery) | **POST** /storefront/{storefront_oid}/screen_recordings/query | Query screen recordings
[**GetScreenRecordingsBySegment**](StorefrontApi.md#getscreenrecordingsbysegment) | **POST** /storefront/{storefront_oid}/screen_recordings/segments/{screen_recording_segment_oid}/query | Get screen recordings by segment
[**GetStoreFrontPricingTiers**](StorefrontApi.md#getstorefrontpricingtiers) | **GET** /storefront/pricing_tiers | Retrieve pricing tiers
[**GetStoreFronts**](StorefrontApi.md#getstorefronts) | **GET** /storefront | Get storefronts (internal use only for security reasons)
[**GetThumbnailParameters**](StorefrontApi.md#getthumbnailparameters) | **POST** /storefront/thumbnailParameters | Get thumbnail parameters
[**GetTransactionEmail**](StorefrontApi.md#gettransactionemail) | **GET** /storefront/{storefront_oid}/transaction_email/list/{email_id} | Gets a transaction email object
[**GetTransactionEmailList**](StorefrontApi.md#gettransactionemaillist) | **GET** /storefront/{storefront_oid}/transaction_email/list | Gets a list of transaction email names
[**GetTransactionEmailScreenshots**](StorefrontApi.md#gettransactionemailscreenshots) | **GET** /storefront/{storefront_oid}/transaction_email/list/{email_id}/screenshots | Get transactional email screenshots
[**GetTwilioAccount**](StorefrontApi.md#gettwilioaccount) | **GET** /storefront/twilio/accounts/{esp_twilio_uuid} | Get Twilio account
[**GetTwilioAccounts**](StorefrontApi.md#gettwilioaccounts) | **GET** /storefront/twilio/accounts | Get all Twilio accounts
[**GetUploadFsFileUrl**](StorefrontApi.md#getuploadfsfileurl) | **GET** /storefront/{id}/fs/upload_url/{extension} | Retrieves a S3 url where a file may be uploaded. Once uploaded, use uploadFsFile to trigger the server into reading the S3 bucket and retrieving the file.
[**GlobalUnsubscribe**](StorefrontApi.md#globalunsubscribe) | **POST** /storefront/{storefront_oid}/email/globalUnsubscribe | Globally unsubscribe a customer
[**ImportEmailThirdPartyProviderList**](StorefrontApi.md#importemailthirdpartyproviderlist) | **POST** /storefront/{storefront_oid}/email/third_party_providers/import | Import a third party provider list
[**InsertEmailCampaign**](StorefrontApi.md#insertemailcampaign) | **POST** /storefront/{storefront_oid}/email/campaigns | Insert email campaign
[**InsertEmailCampaignFolder**](StorefrontApi.md#insertemailcampaignfolder) | **POST** /storefront/{storefront_oid}/email/campaign_folders | Insert email campaign folder
[**InsertEmailCommseq**](StorefrontApi.md#insertemailcommseq) | **POST** /storefront/{storefront_oid}/email/commseqs | Insert email commseq
[**InsertEmailEmail**](StorefrontApi.md#insertemailemail) | **POST** /storefront/{storefront_oid}/email/emails | Insert email email
[**InsertEmailFlow**](StorefrontApi.md#insertemailflow) | **POST** /storefront/{storefront_oid}/email/flows | Insert email flow
[**InsertEmailFlowFolder**](StorefrontApi.md#insertemailflowfolder) | **POST** /storefront/{storefront_oid}/email/flow_folders | Insert email flow folder
[**InsertEmailList**](StorefrontApi.md#insertemaillist) | **POST** /storefront/{storefront_oid}/email/lists | Insert email list
[**InsertEmailListSegmentFolder**](StorefrontApi.md#insertemaillistsegmentfolder) | **POST** /storefront/{storefront_oid}/email/list_segment_folders | Insert email campaign folder
[**InsertEmailPostcard**](StorefrontApi.md#insertemailpostcard) | **POST** /storefront/{storefront_oid}/email/postcards | Insert email postcard
[**InsertEmailSegment**](StorefrontApi.md#insertemailsegment) | **POST** /storefront/{storefront_oid}/email/segments | Insert email segment
[**InsertScreenRecordingSegment**](StorefrontApi.md#insertscreenrecordingsegment) | **POST** /storefront/{storefront_oid}/screen_recordings/segments | Insert screen recording segment
[**InsertUpdatePageContentAttribute**](StorefrontApi.md#insertupdatepagecontentattribute) | **POST** /storefront/{storefront_oid}/pages/{page_oid}/content/attributes | Upsert a page content attribute
[**PrepareDownloadEmailSegment**](StorefrontApi.md#preparedownloademailsegment) | **POST** /storefront/{storefront_oid}/email/segments/{email_segment_uuid}/downloadPrepare | Prepare download of email segment
[**PublishLibraryItem**](StorefrontApi.md#publishlibraryitem) | **POST** /storefront/code_library/{library_item_oid}/publish | Publish library item.
[**PurchaseLibraryItem**](StorefrontApi.md#purchaselibraryitem) | **POST** /storefront/code_library/{library_item_oid}/purchase | Purchase public library item, which creates a copy of the item in your personal code library
[**ReleaseEmailCommseqStepWaiting**](StorefrontApi.md#releaseemailcommseqstepwaiting) | **POST** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/waiting/{commseq_step_uuid} | Release email communication sequence customers waiting at the specified step
[**ResetEmailCommseqRateLimiters**](StorefrontApi.md#resetemailcommseqratelimiters) | **DELETE** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/rate_limiters | Reset email commseq rate limiters (only callable by UltraCart Support)
[**Review**](StorefrontApi.md#review) | **POST** /storefront/{storefront_oid}/email/emails/{commseq_email_uuid}/review | Request a review of an email
[**Search**](StorefrontApi.md#search) | **GET** /storefront/search | Searches for all matching values
[**Search2**](StorefrontApi.md#search2) | **POST** /storefront/search | Searches for all matching values (using POST)
[**SearchEmailListCustomers**](StorefrontApi.md#searchemaillistcustomers) | **GET** /storefront/{storefront_oid}/email/lists/{email_list_uuid}/search | Search email list customers
[**SearchEmailSegmentCustomers**](StorefrontApi.md#searchemailsegmentcustomers) | **GET** /storefront/{storefront_oid}/email/segments/{email_segment_uuid}/search | Search email segment customers
[**SearchLibraryItems**](StorefrontApi.md#searchlibraryitems) | **POST** /storefront/code_library/search | Retrieve library items
[**SearchPublishedItems**](StorefrontApi.md#searchpublisheditems) | **POST** /storefront/code_library/search_published | Retrieve library items
[**SearchReviewItems**](StorefrontApi.md#searchreviewitems) | **POST** /storefront/code_library/search_review | Retrieve library items needing review or rejected
[**SearchSharedItems**](StorefrontApi.md#searchshareditems) | **POST** /storefront/code_library/search_shared | Retrieve library items
[**SendEmailTest**](StorefrontApi.md#sendemailtest) | **POST** /storefront/{storefront_oid}/email/emails/{commseq_email_uuid}/test | Send email test
[**SendPostcardTest**](StorefrontApi.md#sendpostcardtest) | **POST** /storefront/{storefront_oid}/email/postcards/{commseq_postcard_uuid}/test | Send postcard test
[**SendSmsTest**](StorefrontApi.md#sendsmstest) | **POST** /storefront/{storefront_oid}/email/sms/{commseq_uuid}/{commseq_step_uuid}/test | Send SMS test
[**SendWebhookTest**](StorefrontApi.md#sendwebhooktest) | **POST** /storefront/{storefront_oid}/email/webhooks/test | Send webhook test
[**SequenceTest**](StorefrontApi.md#sequencetest) | **POST** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid}/test | Sequence test
[**StartEmailCampaign**](StorefrontApi.md#startemailcampaign) | **PUT** /storefront/{storefront_oid}/email/campaigns/{email_campaign_uuid}/start | Start email campaign
[**SubscribeToEmailList**](StorefrontApi.md#subscribetoemaillist) | **POST** /storefront/{storefront_oid}/email/lists/{email_list_uuid}/subscribe | Subscribe customers to email list
[**SunsetEmailSegment**](StorefrontApi.md#sunsetemailsegment) | **PUT** /storefront/{storefront_oid}/email/segments/{email_segment_uuid}/sunset | Sunset email segment
[**UnfavoriteScreenRecording**](StorefrontApi.md#unfavoritescreenrecording) | **DELETE** /storefront/{storefront_oid}/screen_recordings/{screen_recording_uuid}/favorite | Remove favorite flag on screen recording
[**UpdateEmailCampaign**](StorefrontApi.md#updateemailcampaign) | **PUT** /storefront/{storefront_oid}/email/campaigns/{email_campaign_uuid} | Update email campaign
[**UpdateEmailCampaignFolder**](StorefrontApi.md#updateemailcampaignfolder) | **PUT** /storefront/{storefront_oid}/email/campaign_folders/{email_campaign_folder_uuid} | Update email campaign folder
[**UpdateEmailCommseq**](StorefrontApi.md#updateemailcommseq) | **PUT** /storefront/{storefront_oid}/email/commseqs/{commseq_uuid} | Update email commseq
[**UpdateEmailCustomer**](StorefrontApi.md#updateemailcustomer) | **PUT** /storefront/{storefront_oid}/email/customers/{email_customer_uuid} | Update email customer
[**UpdateEmailEmail**](StorefrontApi.md#updateemailemail) | **PUT** /storefront/{storefront_oid}/email/emails/{commseq_email_uuid} | Update email email
[**UpdateEmailFlow**](StorefrontApi.md#updateemailflow) | **PUT** /storefront/{storefront_oid}/email/flows/{email_flow_uuid} | Update email flow
[**UpdateEmailFlowFolder**](StorefrontApi.md#updateemailflowfolder) | **PUT** /storefront/{storefront_oid}/email/flow_folders/{email_flow_folder_uuid} | Update email flow folder
[**UpdateEmailGlobalSettings**](StorefrontApi.md#updateemailglobalsettings) | **POST** /storefront/email/global_settings | Update email global settings
[**UpdateEmailList**](StorefrontApi.md#updateemaillist) | **PUT** /storefront/{storefront_oid}/email/lists/{email_list_uuid} | Update email list
[**UpdateEmailListSegmentFolder**](StorefrontApi.md#updateemaillistsegmentfolder) | **PUT** /storefront/{storefront_oid}/email/list_segment_folders/{email_list_segment_folder_uuid} | Update email campaign folder
[**UpdateEmailPlan**](StorefrontApi.md#updateemailplan) | **POST** /storefront/{storefront_oid}/email/plan | Update email plan
[**UpdateEmailPostcard**](StorefrontApi.md#updateemailpostcard) | **PUT** /storefront/{storefront_oid}/email/postcards/{commseq_postcard_uuid} | Update email postcard
[**UpdateEmailSegment**](StorefrontApi.md#updateemailsegment) | **PUT** /storefront/{storefront_oid}/email/segments/{email_segment_uuid} | Update email segment
[**UpdateEmailSendingDomain**](StorefrontApi.md#updateemailsendingdomain) | **PUT** /storefront/email/sending_domains/{domain} | Update email sending domain
[**UpdateEmailSettings**](StorefrontApi.md#updateemailsettings) | **POST** /storefront/{storefront_oid}/email/settings | Update email settings
[**UpdateExperiment**](StorefrontApi.md#updateexperiment) | **PUT** /storefront/{storefront_oid}/experiments/{storefront_experiment_oid} | Update experiment
[**UpdateLibraryItem**](StorefrontApi.md#updatelibraryitem) | **PUT** /storefront/code_library/{library_item_oid} | Update library item. Note that only certain fields may be updated via this method.
[**UpdateScreenRecordingMerchantNotes**](StorefrontApi.md#updatescreenrecordingmerchantnotes) | **POST** /storefront/{storefront_oid}/screen_recordings/{screen_recording_uuid}/merchant_notes | Update merchant notes on a screen recording
[**UpdateScreenRecordingSegment**](StorefrontApi.md#updatescreenrecordingsegment) | **POST** /storefront/{storefront_oid}/screen_recordings/segments/{screen_recording_segment_oid} | Update screen recording segment
[**UpdateScreenRecordingSettings**](StorefrontApi.md#updatescreenrecordingsettings) | **POST** /storefront/{storefront_oid}/screen_recordings/settings | Update screen recording settings
[**UpdateScreenRecordingTags**](StorefrontApi.md#updatescreenrecordingtags) | **POST** /storefront/{storefront_oid}/screen_recordings/{screen_recording_uuid}/tags | Update tags on a screen recording
[**UpdateTransactionEmail**](StorefrontApi.md#updatetransactionemail) | **PUT** /storefront/{storefront_oid}/transaction_email/list/{email_id} | Updates a transaction email object
[**UpdateTwilioAccount**](StorefrontApi.md#updatetwilioaccount) | **PUT** /storefront/twilio/accounts/{esp_twilio_uuid} | Update Twilio account
[**UploadFsFile**](StorefrontApi.md#uploadfsfile) | **POST** /storefront/{id}/fs/upload | This is the last step in uploading a file after 1) calling getUploadFsFileUrl and 2) uploading a file to the provided url, then finally 3) calling this method and providing the key to trigger the server into reading the S3 bucket and retrieving the file.
[**ValidateRuler**](StorefrontApi.md#validateruler) | **POST** /storefront/ruler/validate | Validate AWS Event Ruler


<a name="addtolibrary"></a>
# **AddToLibrary**
> LibraryItemResponse AddToLibrary (AddLibraryItemRequest addLibraryRequest)

Add to library
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class AddToLibraryExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var addLibraryRequest = new AddLibraryItemRequest(); // AddLibraryItemRequest | New library item request

            try
            {
                // Add to library
                LibraryItemResponse result = apiInstance.AddToLibrary(addLibraryRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.AddToLibrary: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addLibraryRequest** | [**AddLibraryItemRequest**](AddLibraryItemRequest.md)| New library item request | 

### Return type

[**LibraryItemResponse**](LibraryItemResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="applytostorefront"></a>
# **ApplyToStoreFront**
> ApplyLibraryItemResponse ApplyToStoreFront (ApplyLibraryItemRequest applyLibraryRequest)

Apply library item to storefront.
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ApplyToStoreFrontExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var applyLibraryRequest = new ApplyLibraryItemRequest(); // ApplyLibraryItemRequest | New library item

            try
            {
                // Apply library item to storefront.
                ApplyLibraryItemResponse result = apiInstance.ApplyToStoreFront(applyLibraryRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.ApplyToStoreFront: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applyLibraryRequest** | [**ApplyLibraryItemRequest**](ApplyLibraryItemRequest.md)| New library item | 

### Return type

[**ApplyLibraryItemResponse**](ApplyLibraryItemResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="archiveemaillist"></a>
# **ArchiveEmailList**
> EmailListArchiveResponse ArchiveEmailList (int? storefrontOid, string emailListUuid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailListUuid = emailListUuid_example;  // string | 

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
 **storefrontOid** | **int?**|  | 
 **emailListUuid** | **string**|  | 

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
> EmailSegmentArchiveResponse ArchiveEmailSegment (int? storefrontOid, string emailSegmentUuid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailSegmentUuid = emailSegmentUuid_example;  // string | 

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
 **storefrontOid** | **int?**|  | 
 **emailSegmentUuid** | **string**|  | 

### Return type

[**EmailSegmentArchiveResponse**](EmailSegmentArchiveResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="backpopulateemailflow"></a>
# **BackPopulateEmailFlow**
> EmailFlowBackPopulateResponse BackPopulateEmailFlow (int? storefrontOid, string emailFlowUuid, EmailFlowBackPopulateRequest backPopulateRequest)

Back populate email flow
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class BackPopulateEmailFlowExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailFlowUuid = emailFlowUuid_example;  // string | 
            var backPopulateRequest = new EmailFlowBackPopulateRequest(); // EmailFlowBackPopulateRequest | The request to back populate

            try
            {
                // Back populate email flow
                EmailFlowBackPopulateResponse result = apiInstance.BackPopulateEmailFlow(storefrontOid, emailFlowUuid, backPopulateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.BackPopulateEmailFlow: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailFlowUuid** | **string**|  | 
 **backPopulateRequest** | [**EmailFlowBackPopulateRequest**](EmailFlowBackPopulateRequest.md)| The request to back populate | 

### Return type

[**EmailFlowBackPopulateResponse**](EmailFlowBackPopulateResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkdownloademailsegment"></a>
# **CheckDownloadEmailSegment**
> EmailSegmentDownloadPrepareResponse CheckDownloadEmailSegment (int? storefrontOid, string emailSegmentUuid, string emailSegmentRebuildUuid)

Check download of email segment
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class CheckDownloadEmailSegmentExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailSegmentUuid = emailSegmentUuid_example;  // string | 
            var emailSegmentRebuildUuid = emailSegmentRebuildUuid_example;  // string | 

            try
            {
                // Check download of email segment
                EmailSegmentDownloadPrepareResponse result = apiInstance.CheckDownloadEmailSegment(storefrontOid, emailSegmentUuid, emailSegmentRebuildUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.CheckDownloadEmailSegment: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailSegmentUuid** | **string**|  | 
 **emailSegmentRebuildUuid** | **string**|  | 

### Return type

[**EmailSegmentDownloadPrepareResponse**](EmailSegmentDownloadPrepareResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cloneemailcampaign"></a>
# **CloneEmailCampaign**
> EmailCampaignResponse CloneEmailCampaign (int? storefrontOid, string emailCampaignUuid, int? targetStorefrontOid = null)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailCampaignUuid = emailCampaignUuid_example;  // string | 
            var targetStorefrontOid = 56;  // int? |  (optional) 

            try
            {
                // Clone email campaign
                EmailCampaignResponse result = apiInstance.CloneEmailCampaign(storefrontOid, emailCampaignUuid, targetStorefrontOid);
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
 **storefrontOid** | **int?**|  | 
 **emailCampaignUuid** | **string**|  | 
 **targetStorefrontOid** | **int?**|  | [optional] 

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
> EmailFlowResponse CloneEmailFlow (int? storefrontOid, string emailFlowUuid, int? targetStorefrontOid = null)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailFlowUuid = emailFlowUuid_example;  // string | 
            var targetStorefrontOid = 56;  // int? |  (optional) 

            try
            {
                // Clone email flow
                EmailFlowResponse result = apiInstance.CloneEmailFlow(storefrontOid, emailFlowUuid, targetStorefrontOid);
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
 **storefrontOid** | **int?**|  | 
 **emailFlowUuid** | **string**|  | 
 **targetStorefrontOid** | **int?**|  | [optional] 

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var domain = domain_example;  // string | 

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
 **domain** | **string**|  | 

### Return type

[**EmailSendingDomainResponse**](EmailSendingDomainResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createemailsendingdomain2"></a>
# **CreateEmailSendingDomain2**
> EmailSendingDomainResponse CreateEmailSendingDomain2 (EmailDomain emailDomain)

Create email sending domain for various providers
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class CreateEmailSendingDomain2Example
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var emailDomain = new EmailDomain(); // EmailDomain | EmailDomain

            try
            {
                // Create email sending domain for various providers
                EmailSendingDomainResponse result = apiInstance.CreateEmailSendingDomain2(emailDomain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.CreateEmailSendingDomain2: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailDomain** | [**EmailDomain**](EmailDomain.md)| EmailDomain | 

### Return type

[**EmailSendingDomainResponse**](EmailSendingDomainResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfsdirectory"></a>
# **CreateFsDirectory**
> FileManagerPageResponse CreateFsDirectory (int? id, string name = null, int? parentStorefrontFsDirectoryOid = null)

Create file manager directory
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class CreateFsDirectoryExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var id = 56;  // int? | 
            var name = name_example;  // string |  (optional) 
            var parentStorefrontFsDirectoryOid = 56;  // int? |  (optional) 

            try
            {
                // Create file manager directory
                FileManagerPageResponse result = apiInstance.CreateFsDirectory(id, name, parentStorefrontFsDirectoryOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.CreateFsDirectory: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **name** | **string**|  | [optional] 
 **parentStorefrontFsDirectoryOid** | **int?**|  | [optional] 

### Return type

[**FileManagerPageResponse**](FileManagerPageResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtwilioaccount"></a>
# **CreateTwilioAccount**
> TwilioResponse CreateTwilioAccount (Twilio twilio)

Create Twilio account
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class CreateTwilioAccountExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var twilio = new Twilio(); // Twilio | Twilio

            try
            {
                // Create Twilio account
                TwilioResponse result = apiInstance.CreateTwilioAccount(twilio);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.CreateTwilioAccount: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **twilio** | [**Twilio**](Twilio.md)| Twilio | 

### Return type

[**TwilioResponse**](TwilioResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemailcampaignfolder"></a>
# **DeleteEmailCampaignFolder**
> BaseResponse DeleteEmailCampaignFolder (int? storefrontOid, string emailCampaignFolderUuid)

Delete email campaignFolder
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteEmailCampaignFolderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailCampaignFolderUuid = emailCampaignFolderUuid_example;  // string | 

            try
            {
                // Delete email campaignFolder
                BaseResponse result = apiInstance.DeleteEmailCampaignFolder(storefrontOid, emailCampaignFolderUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.DeleteEmailCampaignFolder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailCampaignFolderUuid** | **string**|  | 

### Return type

[**BaseResponse**](BaseResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemailcommseqstat"></a>
# **DeleteEmailCommseqStat**
> void DeleteEmailCommseqStat (int? storefrontOid, string commseqUuid)

Delete communication sequence stats
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteEmailCommseqStatExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 

            try
            {
                // Delete communication sequence stats
                apiInstance.DeleteEmailCommseqStat(storefrontOid, commseqUuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.DeleteEmailCommseqStat: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemailemail"></a>
# **DeleteEmailEmail**
> BaseResponse DeleteEmailEmail (int? storefrontOid, string commseqEmailUuid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqEmailUuid = commseqEmailUuid_example;  // string | 

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
 **storefrontOid** | **int?**|  | 
 **commseqEmailUuid** | **string**|  | 

### Return type

[**BaseResponse**](BaseResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemailflowfolder"></a>
# **DeleteEmailFlowFolder**
> BaseResponse DeleteEmailFlowFolder (int? storefrontOid, string emailFlowFolderUuid)

Delete email flowFolder
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteEmailFlowFolderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailFlowFolderUuid = emailFlowFolderUuid_example;  // string | 

            try
            {
                // Delete email flowFolder
                BaseResponse result = apiInstance.DeleteEmailFlowFolder(storefrontOid, emailFlowFolderUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.DeleteEmailFlowFolder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailFlowFolderUuid** | **string**|  | 

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
> BaseResponse DeleteEmailListCustomer (int? storefrontOid, string emailListUuid, string emailCustomerUuid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailListUuid = emailListUuid_example;  // string | 
            var emailCustomerUuid = emailCustomerUuid_example;  // string | 

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
 **storefrontOid** | **int?**|  | 
 **emailListUuid** | **string**|  | 
 **emailCustomerUuid** | **string**|  | 

### Return type

[**BaseResponse**](BaseResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemaillistsegmentfolder"></a>
# **DeleteEmailListSegmentFolder**
> BaseResponse DeleteEmailListSegmentFolder (int? storefrontOid, string emailListSegmentFolderUuid)

Delete email ListSegmentFolder
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteEmailListSegmentFolderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailListSegmentFolderUuid = emailListSegmentFolderUuid_example;  // string | 

            try
            {
                // Delete email ListSegmentFolder
                BaseResponse result = apiInstance.DeleteEmailListSegmentFolder(storefrontOid, emailListSegmentFolderUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.DeleteEmailListSegmentFolder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailListSegmentFolderUuid** | **string**|  | 

### Return type

[**BaseResponse**](BaseResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemailpostcard"></a>
# **DeleteEmailPostcard**
> BaseResponse DeleteEmailPostcard (int? storefrontOid, string commseqPostcardUuid)

Delete email postcard
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteEmailPostcardExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqPostcardUuid = commseqPostcardUuid_example;  // string | 

            try
            {
                // Delete email postcard
                BaseResponse result = apiInstance.DeleteEmailPostcard(storefrontOid, commseqPostcardUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.DeleteEmailPostcard: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqPostcardUuid** | **string**|  | 

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var domain = domain_example;  // string | 

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
 **domain** | **string**|  | 

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
> void DeleteExperiment (int? storefrontOid, int? storefrontExperimentOid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var storefrontExperimentOid = 56;  // int? | 

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
 **storefrontOid** | **int?**|  | 
 **storefrontExperimentOid** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefsfile"></a>
# **DeleteFsFile**
> FileManagerPageResponse DeleteFsFile (int? id, int? parentStorefrontFsDirectoryOid = null, int? storefrontFsFileOid = null)

Delete file manager directory
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteFsFileExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var id = 56;  // int? | 
            var parentStorefrontFsDirectoryOid = 56;  // int? |  (optional) 
            var storefrontFsFileOid = 56;  // int? |  (optional) 

            try
            {
                // Delete file manager directory
                FileManagerPageResponse result = apiInstance.DeleteFsFile(id, parentStorefrontFsDirectoryOid, storefrontFsFileOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.DeleteFsFile: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **parentStorefrontFsDirectoryOid** | **int?**|  | [optional] 
 **storefrontFsFileOid** | **int?**|  | [optional] 

### Return type

[**FileManagerPageResponse**](FileManagerPageResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteheatmap"></a>
# **DeleteHeatmap**
> void DeleteHeatmap (int? storefrontOid, ScreenRecordingHeatmapReset query)

Delete screen recording heatmap

Delete screen recording heatmap 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteHeatmapExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var query = new ScreenRecordingHeatmapReset(); // ScreenRecordingHeatmapReset | Query

            try
            {
                // Delete screen recording heatmap
                apiInstance.DeleteHeatmap(storefrontOid, query);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.DeleteHeatmap: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **query** | [**ScreenRecordingHeatmapReset**](ScreenRecordingHeatmapReset.md)| Query | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelibraryitem"></a>
# **DeleteLibraryItem**
> void DeleteLibraryItem (int? libraryItemOid)

Delete library item
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteLibraryItemExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var libraryItemOid = 56;  // int? | 

            try
            {
                // Delete library item
                apiInstance.DeleteLibraryItem(libraryItemOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.DeleteLibraryItem: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **libraryItemOid** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelibraryitempublishedversions"></a>
# **DeleteLibraryItemPublishedVersions**
> void DeleteLibraryItemPublishedVersions (int? libraryItemOid)

Delete all published versions for a library item, including anything in review.
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteLibraryItemPublishedVersionsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var libraryItemOid = 56;  // int? | 

            try
            {
                // Delete all published versions for a library item, including anything in review.
                apiInstance.DeleteLibraryItemPublishedVersions(libraryItemOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.DeleteLibraryItemPublishedVersions: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **libraryItemOid** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletescreenrecordingsegment"></a>
# **DeleteScreenRecordingSegment**
> void DeleteScreenRecordingSegment (int? storefrontOid, int? screenRecordingSegmentOid)

Delete screen recording segment
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteScreenRecordingSegmentExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var screenRecordingSegmentOid = 56;  // int? | 

            try
            {
                // Delete screen recording segment
                apiInstance.DeleteScreenRecordingSegment(storefrontOid, screenRecordingSegmentOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.DeleteScreenRecordingSegment: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **screenRecordingSegmentOid** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetwilioaccount"></a>
# **DeleteTwilioAccount**
> BaseResponse DeleteTwilioAccount (string espTwilioUuid)

delete Twilio account
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DeleteTwilioAccountExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var espTwilioUuid = espTwilioUuid_example;  // string | 

            try
            {
                // delete Twilio account
                BaseResponse result = apiInstance.DeleteTwilioAccount(espTwilioUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.DeleteTwilioAccount: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **espTwilioUuid** | **string**|  | 

### Return type

[**BaseResponse**](BaseResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="duplicatelibraryitem"></a>
# **DuplicateLibraryItem**
> LibraryItemResponse DuplicateLibraryItem (int? libraryItemOid)

Duplicate library item.
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class DuplicateLibraryItemExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var libraryItemOid = 56;  // int? | 

            try
            {
                // Duplicate library item.
                LibraryItemResponse result = apiInstance.DuplicateLibraryItem(libraryItemOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.DuplicateLibraryItem: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **libraryItemOid** | **int?**|  | 

### Return type

[**LibraryItemResponse**](LibraryItemResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="favoritescreenrecording"></a>
# **FavoriteScreenRecording**
> void FavoriteScreenRecording (int? storefrontOid, string screenRecordingUuid)

Update favorite flag on screen recording

Update favorite flag on screen recording 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class FavoriteScreenRecordingExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var screenRecordingUuid = screenRecordingUuid_example;  // string | 

            try
            {
                // Update favorite flag on screen recording
                apiInstance.FavoriteScreenRecording(storefrontOid, screenRecordingUuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.FavoriteScreenRecording: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **screenRecordingUuid** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geocodeaddress"></a>
# **GeocodeAddress**
> GeocodeResponse GeocodeAddress (int? storefrontOid, GeocodeRequest geocodeRequest)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
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
 **storefrontOid** | **int?**|  | 
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
> CountriesResponse GetCountries (int? storefrontOid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

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
 **storefrontOid** | **int?**|  | 

### Return type

[**CountriesResponse**](CountriesResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteditortoken"></a>
# **GetEditorToken**
> EmailEditorTokenResponse GetEditorToken (int? storefrontOid)

Gets editor token

Fetches a temporary authentication token for the editor 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEditorTokenExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

            try
            {
                // Gets editor token
                EmailEditorTokenResponse result = apiInstance.GetEditorToken(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEditorToken: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 

### Return type

[**EmailEditorTokenResponse**](EmailEditorTokenResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailbasetemplates"></a>
# **GetEmailBaseTemplates**
> EmailBaseTemplateListResponse GetEmailBaseTemplates (int? storefrontOid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

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
 **storefrontOid** | **int?**|  | 

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
> EmailCampaignResponse GetEmailCampaign (int? storefrontOid, string emailCampaignUuid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailCampaignUuid = emailCampaignUuid_example;  // string | 

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
 **storefrontOid** | **int?**|  | 
 **emailCampaignUuid** | **string**|  | 

### Return type

[**EmailCampaignResponse**](EmailCampaignResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcampaignfolder"></a>
# **GetEmailCampaignFolder**
> EmailCampaignFolderResponse GetEmailCampaignFolder (int? storefrontOid, string emailCampaignFolderUuid)

Get email campaign folder
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCampaignFolderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailCampaignFolderUuid = emailCampaignFolderUuid_example;  // string | 

            try
            {
                // Get email campaign folder
                EmailCampaignFolderResponse result = apiInstance.GetEmailCampaignFolder(storefrontOid, emailCampaignFolderUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCampaignFolder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailCampaignFolderUuid** | **string**|  | 

### Return type

[**EmailCampaignFolderResponse**](EmailCampaignFolderResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcampaignfolders"></a>
# **GetEmailCampaignFolders**
> EmailCampaignFoldersResponse GetEmailCampaignFolders (int? storefrontOid)

Get email campaign folders
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCampaignFoldersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

            try
            {
                // Get email campaign folders
                EmailCampaignFoldersResponse result = apiInstance.GetEmailCampaignFolders(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCampaignFolders: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 

### Return type

[**EmailCampaignFoldersResponse**](EmailCampaignFoldersResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcampaignscreenshots"></a>
# **GetEmailCampaignScreenshots**
> ScreenshotsResponse GetEmailCampaignScreenshots (int? storefrontOid, string emailCampaignUuid)

Get email campaign screenshots
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCampaignScreenshotsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailCampaignUuid = emailCampaignUuid_example;  // string | 

            try
            {
                // Get email campaign screenshots
                ScreenshotsResponse result = apiInstance.GetEmailCampaignScreenshots(storefrontOid, emailCampaignUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCampaignScreenshots: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailCampaignUuid** | **string**|  | 

### Return type

[**ScreenshotsResponse**](ScreenshotsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcampaigns"></a>
# **GetEmailCampaigns**
> EmailCampaignsResponse GetEmailCampaigns (int? storefrontOid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

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
 **storefrontOid** | **int?**|  | 

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
> EmailCampaignsResponse GetEmailCampaignsWithStats (int? storefrontOid, string statDays)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var statDays = statDays_example;  // string | 

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
 **storefrontOid** | **int?**|  | 
 **statDays** | **string**|  | 

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
> EmailCommseqResponse GetEmailCommseq (int? storefrontOid, string commseqUuid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 

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
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 

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
> EmailStatSummaryResponse GetEmailCommseqEmailStats (int? storefrontOid, string commseqUuid, EmailStatSummaryRequest statsRequest)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 
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
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 
 **statsRequest** | [**EmailStatSummaryRequest**](EmailStatSummaryRequest.md)| StatsRequest | 

### Return type

[**EmailStatSummaryResponse**](EmailStatSummaryResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcommseqpostcardstats"></a>
# **GetEmailCommseqPostcardStats**
> EmailStatPostcardSummaryResponse GetEmailCommseqPostcardStats (int? storefrontOid, string commseqUuid, EmailStatPostcardSummaryRequest statsRequest)

Get email communication sequence postcard stats
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCommseqPostcardStatsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 
            var statsRequest = new EmailStatPostcardSummaryRequest(); // EmailStatPostcardSummaryRequest | StatsRequest

            try
            {
                // Get email communication sequence postcard stats
                EmailStatPostcardSummaryResponse result = apiInstance.GetEmailCommseqPostcardStats(storefrontOid, commseqUuid, statsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCommseqPostcardStats: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 
 **statsRequest** | [**EmailStatPostcardSummaryRequest**](EmailStatPostcardSummaryRequest.md)| StatsRequest | 

### Return type

[**EmailStatPostcardSummaryResponse**](EmailStatPostcardSummaryResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcommseqpostcardtracking"></a>
# **GetEmailCommseqPostcardTracking**
> EmailPostcardTrackingResponse GetEmailCommseqPostcardTracking (int? storefrontOid, string commseqPostcardUuid)

Get email communication postcard tracking
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCommseqPostcardTrackingExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqPostcardUuid = commseqPostcardUuid_example;  // string | 

            try
            {
                // Get email communication postcard tracking
                EmailPostcardTrackingResponse result = apiInstance.GetEmailCommseqPostcardTracking(storefrontOid, commseqPostcardUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCommseqPostcardTracking: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqPostcardUuid** | **string**|  | 

### Return type

[**EmailPostcardTrackingResponse**](EmailPostcardTrackingResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcommseqratelimiters"></a>
# **GetEmailCommseqRateLimiters**
> EmailRateLimitersResponse GetEmailCommseqRateLimiters (int? storefrontOid, string commseqUuid)

Get email commseq rate limiters
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCommseqRateLimitersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 

            try
            {
                // Get email commseq rate limiters
                EmailRateLimitersResponse result = apiInstance.GetEmailCommseqRateLimiters(storefrontOid, commseqUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCommseqRateLimiters: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 

### Return type

[**EmailRateLimitersResponse**](EmailRateLimitersResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcommseqsmsstats"></a>
# **GetEmailCommseqSmsStats**
> EmailStatSmsSummaryResponse GetEmailCommseqSmsStats (int? storefrontOid, string commseqUuid, EmailStatSmsSummaryRequest statsRequest)

Get email communication sequence sms stats
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCommseqSmsStatsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 
            var statsRequest = new EmailStatSmsSummaryRequest(); // EmailStatSmsSummaryRequest | StatsRequest

            try
            {
                // Get email communication sequence sms stats
                EmailStatSmsSummaryResponse result = apiInstance.GetEmailCommseqSmsStats(storefrontOid, commseqUuid, statsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCommseqSmsStats: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 
 **statsRequest** | [**EmailStatSmsSummaryRequest**](EmailStatSmsSummaryRequest.md)| StatsRequest | 

### Return type

[**EmailStatSmsSummaryResponse**](EmailStatSmsSummaryResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcommseqstatoverall"></a>
# **GetEmailCommseqStatOverall**
> EmailCommseqStatResponse GetEmailCommseqStatOverall (int? storefrontOid, string commseqUuid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 

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
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 

### Return type

[**EmailCommseqStatResponse**](EmailCommseqStatResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcommseqstepstats"></a>
# **GetEmailCommseqStepStats**
> EmailStepStatResponse GetEmailCommseqStepStats (int? storefrontOid, string commseqUuid, EmailStepStatRequest statsRequest)

Get email communication sequence step stats
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCommseqStepStatsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 
            var statsRequest = new EmailStepStatRequest(); // EmailStepStatRequest | StatsRequest

            try
            {
                // Get email communication sequence step stats
                EmailStepStatResponse result = apiInstance.GetEmailCommseqStepStats(storefrontOid, commseqUuid, statsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCommseqStepStats: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 
 **statsRequest** | [**EmailStepStatRequest**](EmailStepStatRequest.md)| StatsRequest | 

### Return type

[**EmailStepStatResponse**](EmailStepStatResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcommseqstepwaiting"></a>
# **GetEmailCommseqStepWaiting**
> EmailStepWaitingResponse GetEmailCommseqStepWaiting (int? storefrontOid, string commseqUuid, EmailStepWaitingRequest waitingRequest)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 
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
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 
 **waitingRequest** | [**EmailStepWaitingRequest**](EmailStepWaitingRequest.md)| WaitingRequest | 

### Return type

[**EmailStepWaitingResponse**](EmailStepWaitingResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcommseqwebhookeditorvalues"></a>
# **GetEmailCommseqWebhookEditorValues**
> EmailWebhookEditorValuesResponse GetEmailCommseqWebhookEditorValues (int? storefrontOid, string commseqUuid)

Get email webhook editor values
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCommseqWebhookEditorValuesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 

            try
            {
                // Get email webhook editor values
                EmailWebhookEditorValuesResponse result = apiInstance.GetEmailCommseqWebhookEditorValues(storefrontOid, commseqUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCommseqWebhookEditorValues: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 

### Return type

[**EmailWebhookEditorValuesResponse**](EmailWebhookEditorValuesResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcommseqs"></a>
# **GetEmailCommseqs**
> EmailCommseqsResponse GetEmailCommseqs (int? storefrontOid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

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
 **storefrontOid** | **int?**|  | 

### Return type

[**EmailCommseqsResponse**](EmailCommseqsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcustomereditorurl"></a>
# **GetEmailCustomerEditorUrl**
> EmailCustomerEditorUrlResponse GetEmailCustomerEditorUrl (int? storefrontOid, string emailCustomerUuid)

Get customers editor URL
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCustomerEditorUrlExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailCustomerUuid = emailCustomerUuid_example;  // string | 

            try
            {
                // Get customers editor URL
                EmailCustomerEditorUrlResponse result = apiInstance.GetEmailCustomerEditorUrl(storefrontOid, emailCustomerUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCustomerEditorUrl: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailCustomerUuid** | **string**|  | 

### Return type

[**EmailCustomerEditorUrlResponse**](EmailCustomerEditorUrlResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcustomers"></a>
# **GetEmailCustomers**
> EmailCustomersResponse GetEmailCustomers (int? storefrontOid, int? pageNumber = null, int? pageSize = null, string searchEmailPrefix = null)

Get email customers
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailCustomersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var pageNumber = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var searchEmailPrefix = searchEmailPrefix_example;  // string |  (optional) 

            try
            {
                // Get email customers
                EmailCustomersResponse result = apiInstance.GetEmailCustomers(storefrontOid, pageNumber, pageSize, searchEmailPrefix);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailCustomers: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **pageNumber** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 
 **searchEmailPrefix** | **string**|  | [optional] 

### Return type

[**EmailCustomersResponse**](EmailCustomersResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaildashboardactivity"></a>
# **GetEmailDashboardActivity**
> EmailDashboardActivityResponse GetEmailDashboardActivity (int? storefrontOid, int? lastRecords = null)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var lastRecords = 56;  // int? |  (optional) 

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
 **storefrontOid** | **int?**|  | 
 **lastRecords** | **int?**|  | [optional] 

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
> EmailDashboardStatsResponse GetEmailDashboardStats (int? storefrontOid, int? days = null)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var days = 56;  // int? |  (optional) 

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
 **storefrontOid** | **int?**|  | 
 **days** | **int?**|  | [optional] 

### Return type

[**EmailDashboardStatsResponse**](EmailDashboardStatsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaildispatchlogs"></a>
# **GetEmailDispatchLogs**
> EmailCommseqStepLogsResponse GetEmailDispatchLogs (int? storefrontOid, string commseqUuid, string commseqStepUuid)

Get email dispatch logs
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailDispatchLogsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 
            var commseqStepUuid = commseqStepUuid_example;  // string | 

            try
            {
                // Get email dispatch logs
                EmailCommseqStepLogsResponse result = apiInstance.GetEmailDispatchLogs(storefrontOid, commseqUuid, commseqStepUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailDispatchLogs: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 
 **commseqStepUuid** | **string**|  | 

### Return type

[**EmailCommseqStepLogsResponse**](EmailCommseqStepLogsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailemail"></a>
# **GetEmailEmail**
> EmailCommseqEmailResponse GetEmailEmail (int? storefrontOid, string commseqEmailUuid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqEmailUuid = commseqEmailUuid_example;  // string | 

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
 **storefrontOid** | **int?**|  | 
 **commseqEmailUuid** | **string**|  | 

### Return type

[**EmailCommseqEmailResponse**](EmailCommseqEmailResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailemailclicks"></a>
# **GetEmailEmailClicks**
> EmailClicksResponse GetEmailEmailClicks (int? storefrontOid, string commseqUuid, string commseqStepUuid, string commseqEmailUuid, int? days = null)

Get email email clicks
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailEmailClicksExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 
            var commseqStepUuid = commseqStepUuid_example;  // string | 
            var commseqEmailUuid = commseqEmailUuid_example;  // string | 
            var days = 56;  // int? |  (optional) 

            try
            {
                // Get email email clicks
                EmailClicksResponse result = apiInstance.GetEmailEmailClicks(storefrontOid, commseqUuid, commseqStepUuid, commseqEmailUuid, days);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailEmailClicks: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 
 **commseqStepUuid** | **string**|  | 
 **commseqEmailUuid** | **string**|  | 
 **days** | **int?**|  | [optional] 

### Return type

[**EmailClicksResponse**](EmailClicksResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailemailcustomereditorurl"></a>
# **GetEmailEmailCustomerEditorUrl**
> EmailCustomerEditorUrlResponse GetEmailEmailCustomerEditorUrl (int? storefrontOid, string commseqEmailUuid, string orderId)

Get email order customer editor url
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailEmailCustomerEditorUrlExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqEmailUuid = commseqEmailUuid_example;  // string | 
            var orderId = orderId_example;  // string | 

            try
            {
                // Get email order customer editor url
                EmailCustomerEditorUrlResponse result = apiInstance.GetEmailEmailCustomerEditorUrl(storefrontOid, commseqEmailUuid, orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailEmailCustomerEditorUrl: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqEmailUuid** | **string**|  | 
 **orderId** | **string**|  | 

### Return type

[**EmailCustomerEditorUrlResponse**](EmailCustomerEditorUrlResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailemailorders"></a>
# **GetEmailEmailOrders**
> EmailOrdersResponse GetEmailEmailOrders (int? storefrontOid, string commseqUuid, string commseqStepUuid, string commseqEmailUuid, int? days = null)

Get email email orders
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailEmailOrdersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 
            var commseqStepUuid = commseqStepUuid_example;  // string | 
            var commseqEmailUuid = commseqEmailUuid_example;  // string | 
            var days = 56;  // int? |  (optional) 

            try
            {
                // Get email email orders
                EmailOrdersResponse result = apiInstance.GetEmailEmailOrders(storefrontOid, commseqUuid, commseqStepUuid, commseqEmailUuid, days);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailEmailOrders: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 
 **commseqStepUuid** | **string**|  | 
 **commseqEmailUuid** | **string**|  | 
 **days** | **int?**|  | [optional] 

### Return type

[**EmailOrdersResponse**](EmailOrdersResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailemails"></a>
# **GetEmailEmails**
> EmailCommseqEmailsResponse GetEmailEmails (int? storefrontOid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

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
 **storefrontOid** | **int?**|  | 

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
> EmailCommseqEmailsResponse GetEmailEmailsMultiple (int? storefrontOid, EmailCommseqEmailsRequest emailCommseqEmailsRequest)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
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
 **storefrontOid** | **int?**|  | 
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
> EmailFlowResponse GetEmailFlow (int? storefrontOid, string emailFlowUuid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailFlowUuid = emailFlowUuid_example;  // string | 

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
 **storefrontOid** | **int?**|  | 
 **emailFlowUuid** | **string**|  | 

### Return type

[**EmailFlowResponse**](EmailFlowResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailflowfolder"></a>
# **GetEmailFlowFolder**
> EmailFlowFolderResponse GetEmailFlowFolder (int? storefrontOid, string emailFlowFolderUuid)

Get email flow folder
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailFlowFolderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailFlowFolderUuid = emailFlowFolderUuid_example;  // string | 

            try
            {
                // Get email flow folder
                EmailFlowFolderResponse result = apiInstance.GetEmailFlowFolder(storefrontOid, emailFlowFolderUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailFlowFolder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailFlowFolderUuid** | **string**|  | 

### Return type

[**EmailFlowFolderResponse**](EmailFlowFolderResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailflowfolders"></a>
# **GetEmailFlowFolders**
> EmailFlowFoldersResponse GetEmailFlowFolders (int? storefrontOid)

Get email flow folders
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailFlowFoldersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

            try
            {
                // Get email flow folders
                EmailFlowFoldersResponse result = apiInstance.GetEmailFlowFolders(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailFlowFolders: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 

### Return type

[**EmailFlowFoldersResponse**](EmailFlowFoldersResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailflowscreenshots"></a>
# **GetEmailFlowScreenshots**
> ScreenshotsResponse GetEmailFlowScreenshots (int? storefrontOid, string emailFlowUuid)

Get email flow screenshots
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailFlowScreenshotsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailFlowUuid = emailFlowUuid_example;  // string | 

            try
            {
                // Get email flow screenshots
                ScreenshotsResponse result = apiInstance.GetEmailFlowScreenshots(storefrontOid, emailFlowUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailFlowScreenshots: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailFlowUuid** | **string**|  | 

### Return type

[**ScreenshotsResponse**](ScreenshotsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailflows"></a>
# **GetEmailFlows**
> EmailFlowsResponse GetEmailFlows (int? storefrontOid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

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
 **storefrontOid** | **int?**|  | 

### Return type

[**EmailFlowsResponse**](EmailFlowsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailglobalsettings"></a>
# **GetEmailGlobalSettings**
> EmailGlobalSettingsResponse GetEmailGlobalSettings ()

Get email globalsettings
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailGlobalSettingsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);


            try
            {
                // Get email globalsettings
                EmailGlobalSettingsResponse result = apiInstance.GetEmailGlobalSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailGlobalSettings: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**EmailGlobalSettingsResponse**](EmailGlobalSettingsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaillist"></a>
# **GetEmailList**
> EmailListResponse GetEmailList (int? storefrontOid, string emailListUuid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailListUuid = emailListUuid_example;  // string | 

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
 **storefrontOid** | **int?**|  | 
 **emailListUuid** | **string**|  | 

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
> EmailCustomerEditorUrlResponse GetEmailListCustomerEditorUrl (int? storefrontOid, string emailListUuid, string emailCustomerUuid)

Get email list customer editor url
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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailListUuid = emailListUuid_example;  // string | 
            var emailCustomerUuid = emailCustomerUuid_example;  // string | 

            try
            {
                // Get email list customer editor url
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
 **storefrontOid** | **int?**|  | 
 **emailListUuid** | **string**|  | 
 **emailCustomerUuid** | **string**|  | 

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
> EmailListCustomersResponse GetEmailListCustomers (int? storefrontOid, string emailListUuid, int? pageNumber = null, int? pageSize = null)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailListUuid = emailListUuid_example;  // string | 
            var pageNumber = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

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
 **storefrontOid** | **int?**|  | 
 **emailListUuid** | **string**|  | 
 **pageNumber** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 

### Return type

[**EmailListCustomersResponse**](EmailListCustomersResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaillistsegmentfolder"></a>
# **GetEmailListSegmentFolder**
> EmailListSegmentFolderResponse GetEmailListSegmentFolder (int? storefrontOid, string emailListSegmentFolderUuid)

Get email campaign folder
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailListSegmentFolderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailListSegmentFolderUuid = emailListSegmentFolderUuid_example;  // string | 

            try
            {
                // Get email campaign folder
                EmailListSegmentFolderResponse result = apiInstance.GetEmailListSegmentFolder(storefrontOid, emailListSegmentFolderUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailListSegmentFolder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailListSegmentFolderUuid** | **string**|  | 

### Return type

[**EmailListSegmentFolderResponse**](EmailListSegmentFolderResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaillistsegmentfolders"></a>
# **GetEmailListSegmentFolders**
> EmailListSegmentFoldersResponse GetEmailListSegmentFolders (int? storefrontOid)

Get email campaign folders
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailListSegmentFoldersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

            try
            {
                // Get email campaign folders
                EmailListSegmentFoldersResponse result = apiInstance.GetEmailListSegmentFolders(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailListSegmentFolders: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 

### Return type

[**EmailListSegmentFoldersResponse**](EmailListSegmentFoldersResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaillists"></a>
# **GetEmailLists**
> EmailListsResponse GetEmailLists (int? storefrontOid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

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
 **storefrontOid** | **int?**|  | 

### Return type

[**EmailListsResponse**](EmailListsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailperformance"></a>
# **GetEmailPerformance**
> EmailPerformanceResponse GetEmailPerformance (int? storefrontOid)

Get email performance
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailPerformanceExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

            try
            {
                // Get email performance
                EmailPerformanceResponse result = apiInstance.GetEmailPerformance(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailPerformance: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 

### Return type

[**EmailPerformanceResponse**](EmailPerformanceResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailplan"></a>
# **GetEmailPlan**
> EmailPlanResponse GetEmailPlan (int? storefrontOid)

Get email plan
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailPlanExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

            try
            {
                // Get email plan
                EmailPlanResponse result = apiInstance.GetEmailPlan(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailPlan: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 

### Return type

[**EmailPlanResponse**](EmailPlanResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailpostcard"></a>
# **GetEmailPostcard**
> EmailCommseqPostcardResponse GetEmailPostcard (int? storefrontOid, string commseqPostcardUuid)

Get email postcard
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailPostcardExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqPostcardUuid = commseqPostcardUuid_example;  // string | 

            try
            {
                // Get email postcard
                EmailCommseqPostcardResponse result = apiInstance.GetEmailPostcard(storefrontOid, commseqPostcardUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailPostcard: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqPostcardUuid** | **string**|  | 

### Return type

[**EmailCommseqPostcardResponse**](EmailCommseqPostcardResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailpostcards"></a>
# **GetEmailPostcards**
> EmailCommseqPostcardsResponse GetEmailPostcards (int? storefrontOid)

Get email postcards
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailPostcardsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

            try
            {
                // Get email postcards
                EmailCommseqPostcardsResponse result = apiInstance.GetEmailPostcards(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailPostcards: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 

### Return type

[**EmailCommseqPostcardsResponse**](EmailCommseqPostcardsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailpostcardsmultiple"></a>
# **GetEmailPostcardsMultiple**
> EmailCommseqPostcardsResponse GetEmailPostcardsMultiple (int? storefrontOid, EmailCommseqPostcardsRequest emailCommseqPostcardsRequest)

Get email postcards multiple
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailPostcardsMultipleExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailCommseqPostcardsRequest = new EmailCommseqPostcardsRequest(); // EmailCommseqPostcardsRequest | Request of postcard uuids

            try
            {
                // Get email postcards multiple
                EmailCommseqPostcardsResponse result = apiInstance.GetEmailPostcardsMultiple(storefrontOid, emailCommseqPostcardsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailPostcardsMultiple: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailCommseqPostcardsRequest** | [**EmailCommseqPostcardsRequest**](EmailCommseqPostcardsRequest.md)| Request of postcard uuids | 

### Return type

[**EmailCommseqPostcardsResponse**](EmailCommseqPostcardsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailsegment"></a>
# **GetEmailSegment**
> EmailSegmentResponse GetEmailSegment (int? storefrontOid, string emailSegmentUuid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailSegmentUuid = emailSegmentUuid_example;  // string | 

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
 **storefrontOid** | **int?**|  | 
 **emailSegmentUuid** | **string**|  | 

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
> EmailCustomerEditorUrlResponse GetEmailSegmentCustomerEditorUrl (int? storefrontOid, string emailSegmentUuid, string emailCustomerUuid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailSegmentUuid = emailSegmentUuid_example;  // string | 
            var emailCustomerUuid = emailCustomerUuid_example;  // string | 

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
 **storefrontOid** | **int?**|  | 
 **emailSegmentUuid** | **string**|  | 
 **emailCustomerUuid** | **string**|  | 

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
> EmailSegmentCustomersResponse GetEmailSegmentCustomers (int? storefrontOid, string emailSegmentUuid, int? pageNumber = null, int? pageSize = null)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailSegmentUuid = emailSegmentUuid_example;  // string | 
            var pageNumber = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

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
 **storefrontOid** | **int?**|  | 
 **emailSegmentUuid** | **string**|  | 
 **pageNumber** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 

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
> EmailSegmentsResponse GetEmailSegments (int? storefrontOid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

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
 **storefrontOid** | **int?**|  | 

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var domain = domain_example;  // string | 

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
 **domain** | **string**|  | 

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var domain = domain_example;  // string | 

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
 **domain** | **string**|  | 

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);


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

<a name="getemailsettings"></a>
# **GetEmailSettings**
> EmailSettingsResponse GetEmailSettings (int? storefrontOid)

Get email settings
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailSettingsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

            try
            {
                // Get email settings
                EmailSettingsResponse result = apiInstance.GetEmailSettings(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailSettings: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 

### Return type

[**EmailSettingsResponse**](EmailSettingsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailsmsorders"></a>
# **GetEmailSmsOrders**
> EmailSmsOrdersResponse GetEmailSmsOrders (int? storefrontOid, string commseqUuid, string commseqStepUuid, int? days = null)

Get email sms orders
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetEmailSmsOrdersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 
            var commseqStepUuid = commseqStepUuid_example;  // string | 
            var days = 56;  // int? |  (optional) 

            try
            {
                // Get email sms orders
                EmailSmsOrdersResponse result = apiInstance.GetEmailSmsOrders(storefrontOid, commseqUuid, commseqStepUuid, days);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetEmailSmsOrders: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 
 **commseqStepUuid** | **string**|  | 
 **days** | **int?**|  | [optional] 

### Return type

[**EmailSmsOrdersResponse**](EmailSmsOrdersResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailtemplate"></a>
# **GetEmailTemplate**
> EmailTemplate GetEmailTemplate (int? storefrontOid, int? emailTemplateOid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailTemplateOid = 56;  // int? | 

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
 **storefrontOid** | **int?**|  | 
 **emailTemplateOid** | **int?**|  | 

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
> EmailTemplatesResponse GetEmailTemplates (int? storefrontOid, string triggerType = null)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var triggerType = triggerType_example;  // string |  (optional) 

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
 **storefrontOid** | **int?**|  | 
 **triggerType** | **string**|  | [optional] 

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
> EmailThirdPartyProvidersResponse GetEmailThirdPartyProviders (int? storefrontOid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

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
 **storefrontOid** | **int?**|  | 

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
> ExperimentsResponse GetExperiments (int? storefrontOid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

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
 **storefrontOid** | **int?**|  | 

### Return type

[**ExperimentsResponse**](ExperimentsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfsdirectory"></a>
# **GetFsDirectory**
> FileManagerPageResponse GetFsDirectory (int? id, string path = null, int? storefrontFsDirectoryOid = null, int? storefrontThemeOid = null)

Get file manager directory
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetFsDirectoryExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var id = 56;  // int? | 
            var path = path_example;  // string |  (optional) 
            var storefrontFsDirectoryOid = 56;  // int? |  (optional) 
            var storefrontThemeOid = 56;  // int? |  (optional) 

            try
            {
                // Get file manager directory
                FileManagerPageResponse result = apiInstance.GetFsDirectory(id, path, storefrontFsDirectoryOid, storefrontThemeOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetFsDirectory: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **path** | **string**|  | [optional] 
 **storefrontFsDirectoryOid** | **int?**|  | [optional] 
 **storefrontThemeOid** | **int?**|  | [optional] 

### Return type

[**FileManagerPageResponse**](FileManagerPageResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getheatmap"></a>
# **GetHeatmap**
> ScreenRecordingHeatmapResponse GetHeatmap (int? storefrontOid, ScreenRecordingHeatmapRequest query)

Get screen recording heatmap

Get screen recording heatmap 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetHeatmapExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var query = new ScreenRecordingHeatmapRequest(); // ScreenRecordingHeatmapRequest | Query

            try
            {
                // Get screen recording heatmap
                ScreenRecordingHeatmapResponse result = apiInstance.GetHeatmap(storefrontOid, query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetHeatmap: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **query** | [**ScreenRecordingHeatmapRequest**](ScreenRecordingHeatmapRequest.md)| Query | 

### Return type

[**ScreenRecordingHeatmapResponse**](ScreenRecordingHeatmapResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getheatmapindex"></a>
# **GetHeatmapIndex**
> ScreenRecordingHeatmapIndexResponse GetHeatmapIndex (int? storefrontOid, ScreenRecordingHeatmapIndexRequest query, int? limit = null, int? offset = null, string sort = null)

Get screen recording heatmap index

Get screen recording heatmap index 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetHeatmapIndexExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var query = new ScreenRecordingHeatmapIndexRequest(); // ScreenRecordingHeatmapIndexRequest | Query
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Default 100, Max 500) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var sort = sort_example;  // string | The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 

            try
            {
                // Get screen recording heatmap index
                ScreenRecordingHeatmapIndexResponse result = apiInstance.GetHeatmapIndex(storefrontOid, query, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetHeatmapIndex: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **query** | [**ScreenRecordingHeatmapIndexRequest**](ScreenRecordingHeatmapIndexRequest.md)| Query | 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Default 100, Max 500) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **sort** | **string**| The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 

### Return type

[**ScreenRecordingHeatmapIndexResponse**](ScreenRecordingHeatmapIndexResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistogrampropertynames"></a>
# **GetHistogramPropertyNames**
> EmailHistogramPropertyNamesResponse GetHistogramPropertyNames (int? storefrontOid, string propertyType = null)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var propertyType = propertyType_example;  // string |  (optional) 

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
 **storefrontOid** | **int?**|  | 
 **propertyType** | **string**|  | [optional] 

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
> EmailHistogramPropertyValuesResponse GetHistogramPropertyValues (int? storefrontOid, string propertyName = null, string propertyType = null, int? limit = null)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var propertyName = propertyName_example;  // string |  (optional) 
            var propertyType = propertyType_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

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
 **storefrontOid** | **int?**|  | 
 **propertyName** | **string**|  | [optional] 
 **propertyType** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**EmailHistogramPropertyValuesResponse**](EmailHistogramPropertyValuesResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlibraryfiltervalues"></a>
# **GetLibraryFilterValues**
> LibraryFilterValuesResponse GetLibraryFilterValues ()

Get library values used to populate drop down boxes for filtering.
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetLibraryFilterValuesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);


            try
            {
                // Get library values used to populate drop down boxes for filtering.
                LibraryFilterValuesResponse result = apiInstance.GetLibraryFilterValues();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetLibraryFilterValues: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**LibraryFilterValuesResponse**](LibraryFilterValuesResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlibraryitem"></a>
# **GetLibraryItem**
> LibraryItemResponse GetLibraryItem (int? libraryItemOid)

Get library item.
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetLibraryItemExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var libraryItemOid = 56;  // int? | 

            try
            {
                // Get library item.
                LibraryItemResponse result = apiInstance.GetLibraryItem(libraryItemOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetLibraryItem: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **libraryItemOid** | **int?**|  | 

### Return type

[**LibraryItemResponse**](LibraryItemResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlibraryitempublishedversions"></a>
# **GetLibraryItemPublishedVersions**
> LibraryItemsResponse GetLibraryItemPublishedVersions (int? libraryItemOid)

Get all published versions for a library item.
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetLibraryItemPublishedVersionsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var libraryItemOid = 56;  // int? | 

            try
            {
                // Get all published versions for a library item.
                LibraryItemsResponse result = apiInstance.GetLibraryItemPublishedVersions(libraryItemOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetLibraryItemPublishedVersions: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **libraryItemOid** | **int?**|  | 

### Return type

[**LibraryItemsResponse**](LibraryItemsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscreenrecording"></a>
# **GetScreenRecording**
> ScreenRecordingResponse GetScreenRecording (int? storefrontOid, string screenRecordingUuid)

Get screen recording

Get screen recording 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetScreenRecordingExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var screenRecordingUuid = screenRecordingUuid_example;  // string | 

            try
            {
                // Get screen recording
                ScreenRecordingResponse result = apiInstance.GetScreenRecording(storefrontOid, screenRecordingUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetScreenRecording: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **screenRecordingUuid** | **string**|  | 

### Return type

[**ScreenRecordingResponse**](ScreenRecordingResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscreenrecordingpageviewdata"></a>
# **GetScreenRecordingPageViewData**
> ScreenRecordingPageViewDataResponse GetScreenRecordingPageViewData (int? storefrontOid, string screenRecordingUuid, string screenRecordingPageViewUuid)

Get screen recording page view data

Get screen recording page view data 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetScreenRecordingPageViewDataExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var screenRecordingUuid = screenRecordingUuid_example;  // string | 
            var screenRecordingPageViewUuid = screenRecordingPageViewUuid_example;  // string | 

            try
            {
                // Get screen recording page view data
                ScreenRecordingPageViewDataResponse result = apiInstance.GetScreenRecordingPageViewData(storefrontOid, screenRecordingUuid, screenRecordingPageViewUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetScreenRecordingPageViewData: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **screenRecordingUuid** | **string**|  | 
 **screenRecordingPageViewUuid** | **string**|  | 

### Return type

[**ScreenRecordingPageViewDataResponse**](ScreenRecordingPageViewDataResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscreenrecordingsegment"></a>
# **GetScreenRecordingSegment**
> ScreenRecordingSegmentResponse GetScreenRecordingSegment (int? storefrontOid, int? screenRecordingSegmentOid)

Get screen recording segment
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetScreenRecordingSegmentExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var screenRecordingSegmentOid = 56;  // int? | 

            try
            {
                // Get screen recording segment
                ScreenRecordingSegmentResponse result = apiInstance.GetScreenRecordingSegment(storefrontOid, screenRecordingSegmentOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetScreenRecordingSegment: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **screenRecordingSegmentOid** | **int?**|  | 

### Return type

[**ScreenRecordingSegmentResponse**](ScreenRecordingSegmentResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscreenrecordingsegments"></a>
# **GetScreenRecordingSegments**
> ScreenRecordingSegmentsResponse GetScreenRecordingSegments (int? storefrontOid)

Get screen recording segments
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetScreenRecordingSegmentsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

            try
            {
                // Get screen recording segments
                ScreenRecordingSegmentsResponse result = apiInstance.GetScreenRecordingSegments(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetScreenRecordingSegments: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 

### Return type

[**ScreenRecordingSegmentsResponse**](ScreenRecordingSegmentsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscreenrecordingsettings"></a>
# **GetScreenRecordingSettings**
> ScreenRecordingSettingsResponse GetScreenRecordingSettings (int? storefrontOid)

Get screen recording settings
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetScreenRecordingSettingsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

            try
            {
                // Get screen recording settings
                ScreenRecordingSettingsResponse result = apiInstance.GetScreenRecordingSettings(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetScreenRecordingSettings: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 

### Return type

[**ScreenRecordingSettingsResponse**](ScreenRecordingSettingsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscreenrecordingtags"></a>
# **GetScreenRecordingTags**
> ScreenRecordingTagsResponse GetScreenRecordingTags (int? storefrontOid)

Get tags used by screen recording

Get tags used by screen recording 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetScreenRecordingTagsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

            try
            {
                // Get tags used by screen recording
                ScreenRecordingTagsResponse result = apiInstance.GetScreenRecordingTags(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetScreenRecordingTags: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 

### Return type

[**ScreenRecordingTagsResponse**](ScreenRecordingTagsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscreenrecordingsbyquery"></a>
# **GetScreenRecordingsByQuery**
> ScreenRecordingQueryResponse GetScreenRecordingsByQuery (int? storefrontOid, ScreenRecordingQueryRequest query, int? limit = null, int? offset = null, string sort = null)

Query screen recordings

Query screen recordings 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetScreenRecordingsByQueryExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var query = new ScreenRecordingQueryRequest(); // ScreenRecordingQueryRequest | Query
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Default 100, Max 500) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var sort = sort_example;  // string | The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 

            try
            {
                // Query screen recordings
                ScreenRecordingQueryResponse result = apiInstance.GetScreenRecordingsByQuery(storefrontOid, query, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetScreenRecordingsByQuery: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **query** | [**ScreenRecordingQueryRequest**](ScreenRecordingQueryRequest.md)| Query | 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Default 100, Max 500) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **sort** | **string**| The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 

### Return type

[**ScreenRecordingQueryResponse**](ScreenRecordingQueryResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscreenrecordingsbysegment"></a>
# **GetScreenRecordingsBySegment**
> ScreenRecordingQueryResponse GetScreenRecordingsBySegment (int? storefrontOid, int? screenRecordingSegmentOid, int? limit = null, int? offset = null, string sort = null)

Get screen recordings by segment

Get screen recordings by segment 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetScreenRecordingsBySegmentExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var screenRecordingSegmentOid = 56;  // int? | 
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Default 100, Max 500) (optional)  (default to 100)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var sort = sort_example;  // string | The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 

            try
            {
                // Get screen recordings by segment
                ScreenRecordingQueryResponse result = apiInstance.GetScreenRecordingsBySegment(storefrontOid, screenRecordingSegmentOid, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetScreenRecordingsBySegment: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **screenRecordingSegmentOid** | **int?**|  | 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Default 100, Max 500) | [optional] [default to 100]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **sort** | **string**| The sort order of the items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 

### Return type

[**ScreenRecordingQueryResponse**](ScreenRecordingQueryResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorefrontpricingtiers"></a>
# **GetStoreFrontPricingTiers**
> PricingTiersResponse GetStoreFrontPricingTiers (string expand = null)

Retrieve pricing tiers

Retrieves the pricing tiers 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetStoreFrontPricingTiersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var expand = expand_example;  // string | The object expansion to perform on the result.  See documentation for examples (optional) 

            try
            {
                // Retrieve pricing tiers
                PricingTiersResponse result = apiInstance.GetStoreFrontPricingTiers(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetStoreFrontPricingTiers: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expand** | **string**| The object expansion to perform on the result.  See documentation for examples | [optional] 

### Return type

[**PricingTiersResponse**](PricingTiersResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorefronts"></a>
# **GetStoreFronts**
> StoreFrontsResponse GetStoreFronts ()

Get storefronts (internal use only for security reasons)
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetStoreFrontsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);


            try
            {
                // Get storefronts (internal use only for security reasons)
                StoreFrontsResponse result = apiInstance.GetStoreFronts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetStoreFronts: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**StoreFrontsResponse**](StoreFrontsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getthumbnailparameters"></a>
# **GetThumbnailParameters**
> ThumbnailParametersResponse GetThumbnailParameters (ThumbnailParametersRequest thumbnailParameters)

Get thumbnail parameters
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetThumbnailParametersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var thumbnailParameters = new ThumbnailParametersRequest(); // ThumbnailParametersRequest | Thumbnail Parameters

            try
            {
                // Get thumbnail parameters
                ThumbnailParametersResponse result = apiInstance.GetThumbnailParameters(thumbnailParameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetThumbnailParameters: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **thumbnailParameters** | [**ThumbnailParametersRequest**](ThumbnailParametersRequest.md)| Thumbnail Parameters | 

### Return type

[**ThumbnailParametersResponse**](ThumbnailParametersResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionemail"></a>
# **GetTransactionEmail**
> TransactionEmailResponse GetTransactionEmail (int? storefrontOid, string emailId)

Gets a transaction email object

Fetch a transactional email 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetTransactionEmailExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailId = emailId_example;  // string | 

            try
            {
                // Gets a transaction email object
                TransactionEmailResponse result = apiInstance.GetTransactionEmail(storefrontOid, emailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetTransactionEmail: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailId** | **string**|  | 

### Return type

[**TransactionEmailResponse**](TransactionEmailResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionemaillist"></a>
# **GetTransactionEmailList**
> TransactionEmailListResponse GetTransactionEmailList (int? storefrontOid)

Gets a list of transaction email names

Obtain a list of all transactional emails and return back just their names 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetTransactionEmailListExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 

            try
            {
                // Gets a list of transaction email names
                TransactionEmailListResponse result = apiInstance.GetTransactionEmailList(storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetTransactionEmailList: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 

### Return type

[**TransactionEmailListResponse**](TransactionEmailListResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionemailscreenshots"></a>
# **GetTransactionEmailScreenshots**
> ScreenshotsResponse GetTransactionEmailScreenshots (int? storefrontOid, string emailId)

Get transactional email screenshots
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetTransactionEmailScreenshotsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailId = emailId_example;  // string | 

            try
            {
                // Get transactional email screenshots
                ScreenshotsResponse result = apiInstance.GetTransactionEmailScreenshots(storefrontOid, emailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetTransactionEmailScreenshots: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailId** | **string**|  | 

### Return type

[**ScreenshotsResponse**](ScreenshotsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettwilioaccount"></a>
# **GetTwilioAccount**
> TwilioResponse GetTwilioAccount (string espTwilioUuid)

Get Twilio account
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetTwilioAccountExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var espTwilioUuid = espTwilioUuid_example;  // string | 

            try
            {
                // Get Twilio account
                TwilioResponse result = apiInstance.GetTwilioAccount(espTwilioUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetTwilioAccount: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **espTwilioUuid** | **string**|  | 

### Return type

[**TwilioResponse**](TwilioResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettwilioaccounts"></a>
# **GetTwilioAccounts**
> TwiliosResponse GetTwilioAccounts ()

Get all Twilio accounts
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetTwilioAccountsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);


            try
            {
                // Get all Twilio accounts
                TwiliosResponse result = apiInstance.GetTwilioAccounts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetTwilioAccounts: " + e.Message );
            }
        }
    }
}

```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TwiliosResponse**](TwiliosResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuploadfsfileurl"></a>
# **GetUploadFsFileUrl**
> FileManagerUploadUrlResponse GetUploadFsFileUrl (int? id, string extension)

Retrieves a S3 url where a file may be uploaded. Once uploaded, use uploadFsFile to trigger the server into reading the S3 bucket and retrieving the file.
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GetUploadFsFileUrlExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var id = 56;  // int? | 
            var extension = extension_example;  // string | 

            try
            {
                // Retrieves a S3 url where a file may be uploaded. Once uploaded, use uploadFsFile to trigger the server into reading the S3 bucket and retrieving the file.
                FileManagerUploadUrlResponse result = apiInstance.GetUploadFsFileUrl(id, extension);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetUploadFsFileUrl: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **extension** | **string**|  | 

### Return type

[**FileManagerUploadUrlResponse**](FileManagerUploadUrlResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="globalunsubscribe"></a>
# **GlobalUnsubscribe**
> EmailGlobalUnsubscribeResponse GlobalUnsubscribe (int? storefrontOid, EmailGlobalUnsubscribeRequest unsubscribe)

Globally unsubscribe a customer
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class GlobalUnsubscribeExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var unsubscribe = new EmailGlobalUnsubscribeRequest(); // EmailGlobalUnsubscribeRequest | Unsubscribe

            try
            {
                // Globally unsubscribe a customer
                EmailGlobalUnsubscribeResponse result = apiInstance.GlobalUnsubscribe(storefrontOid, unsubscribe);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.GlobalUnsubscribe: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **unsubscribe** | [**EmailGlobalUnsubscribeRequest**](EmailGlobalUnsubscribeRequest.md)| Unsubscribe | 

### Return type

[**EmailGlobalUnsubscribeResponse**](EmailGlobalUnsubscribeResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importemailthirdpartyproviderlist"></a>
# **ImportEmailThirdPartyProviderList**
> void ImportEmailThirdPartyProviderList (int? storefrontOid, EmailThirdPartyListImportRequest importRequest)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
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
 **storefrontOid** | **int?**|  | 
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
> EmailCampaignResponse InsertEmailCampaign (int? storefrontOid, EmailCampaign emailCampaign)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
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
 **storefrontOid** | **int?**|  | 
 **emailCampaign** | [**EmailCampaign**](EmailCampaign.md)| Email campaign | 

### Return type

[**EmailCampaignResponse**](EmailCampaignResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertemailcampaignfolder"></a>
# **InsertEmailCampaignFolder**
> EmailCampaignFolderResponse InsertEmailCampaignFolder (int? storefrontOid, EmailCampaignFolder emailCampaignFolder)

Insert email campaign folder
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertEmailCampaignFolderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailCampaignFolder = new EmailCampaignFolder(); // EmailCampaignFolder | Email campaign folder

            try
            {
                // Insert email campaign folder
                EmailCampaignFolderResponse result = apiInstance.InsertEmailCampaignFolder(storefrontOid, emailCampaignFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.InsertEmailCampaignFolder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailCampaignFolder** | [**EmailCampaignFolder**](EmailCampaignFolder.md)| Email campaign folder | 

### Return type

[**EmailCampaignFolderResponse**](EmailCampaignFolderResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertemailcommseq"></a>
# **InsertEmailCommseq**
> EmailCommseqResponse InsertEmailCommseq (int? storefrontOid, EmailCommseq emailCommseq)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
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
 **storefrontOid** | **int?**|  | 
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
> EmailCommseqEmailResponse InsertEmailEmail (int? storefrontOid, EmailCommseqEmail emailCommseqEmail)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
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
 **storefrontOid** | **int?**|  | 
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
> EmailFlowResponse InsertEmailFlow (int? storefrontOid, EmailFlow emailFlow)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
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
 **storefrontOid** | **int?**|  | 
 **emailFlow** | [**EmailFlow**](EmailFlow.md)| Email flow | 

### Return type

[**EmailFlowResponse**](EmailFlowResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertemailflowfolder"></a>
# **InsertEmailFlowFolder**
> EmailFlowFolderResponse InsertEmailFlowFolder (int? storefrontOid, EmailFlowFolder emailFlowFolder)

Insert email flow folder
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertEmailFlowFolderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailFlowFolder = new EmailFlowFolder(); // EmailFlowFolder | Email flow folder

            try
            {
                // Insert email flow folder
                EmailFlowFolderResponse result = apiInstance.InsertEmailFlowFolder(storefrontOid, emailFlowFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.InsertEmailFlowFolder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailFlowFolder** | [**EmailFlowFolder**](EmailFlowFolder.md)| Email flow folder | 

### Return type

[**EmailFlowFolderResponse**](EmailFlowFolderResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertemaillist"></a>
# **InsertEmailList**
> EmailListResponse InsertEmailList (int? storefrontOid, EmailList emailList)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
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
 **storefrontOid** | **int?**|  | 
 **emailList** | [**EmailList**](EmailList.md)| Email list | 

### Return type

[**EmailListResponse**](EmailListResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertemaillistsegmentfolder"></a>
# **InsertEmailListSegmentFolder**
> EmailListSegmentFolderResponse InsertEmailListSegmentFolder (int? storefrontOid, EmailListSegmentFolder emailListSegmentFolder)

Insert email campaign folder
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertEmailListSegmentFolderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailListSegmentFolder = new EmailListSegmentFolder(); // EmailListSegmentFolder | Email campaign folder

            try
            {
                // Insert email campaign folder
                EmailListSegmentFolderResponse result = apiInstance.InsertEmailListSegmentFolder(storefrontOid, emailListSegmentFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.InsertEmailListSegmentFolder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailListSegmentFolder** | [**EmailListSegmentFolder**](EmailListSegmentFolder.md)| Email campaign folder | 

### Return type

[**EmailListSegmentFolderResponse**](EmailListSegmentFolderResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertemailpostcard"></a>
# **InsertEmailPostcard**
> EmailCommseqPostcardResponse InsertEmailPostcard (int? storefrontOid, EmailCommseqPostcard emailCommseqPostcard)

Insert email postcard
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertEmailPostcardExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailCommseqPostcard = new EmailCommseqPostcard(); // EmailCommseqPostcard | Email postcard

            try
            {
                // Insert email postcard
                EmailCommseqPostcardResponse result = apiInstance.InsertEmailPostcard(storefrontOid, emailCommseqPostcard);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.InsertEmailPostcard: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailCommseqPostcard** | [**EmailCommseqPostcard**](EmailCommseqPostcard.md)| Email postcard | 

### Return type

[**EmailCommseqPostcardResponse**](EmailCommseqPostcardResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertemailsegment"></a>
# **InsertEmailSegment**
> EmailSegmentResponse InsertEmailSegment (int? storefrontOid, EmailSegment emailSegment)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
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
 **storefrontOid** | **int?**|  | 
 **emailSegment** | [**EmailSegment**](EmailSegment.md)| Email segment | 

### Return type

[**EmailSegmentResponse**](EmailSegmentResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertscreenrecordingsegment"></a>
# **InsertScreenRecordingSegment**
> ScreenRecordingSegmentResponse InsertScreenRecordingSegment (int? storefrontOid, ScreenRecordingSegment segment)

Insert screen recording segment
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertScreenRecordingSegmentExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var segment = new ScreenRecordingSegment(); // ScreenRecordingSegment | Segment

            try
            {
                // Insert screen recording segment
                ScreenRecordingSegmentResponse result = apiInstance.InsertScreenRecordingSegment(storefrontOid, segment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.InsertScreenRecordingSegment: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **segment** | [**ScreenRecordingSegment**](ScreenRecordingSegment.md)| Segment | 

### Return type

[**ScreenRecordingSegmentResponse**](ScreenRecordingSegmentResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertupdatepagecontentattribute"></a>
# **InsertUpdatePageContentAttribute**
> void InsertUpdatePageContentAttribute (StoreFrontPageContentAttribute pageAttribute, int? storefrontOid, int? pageOid)

Upsert a page content attribute

Update a page content attribute, creating it new if it does not yet exist. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class InsertUpdatePageContentAttributeExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var pageAttribute = new StoreFrontPageContentAttribute(); // StoreFrontPageContentAttribute | Page content attribute to upsert
            var storefrontOid = 56;  // int? | 
            var pageOid = 56;  // int? | The page oid to modify.

            try
            {
                // Upsert a page content attribute
                apiInstance.InsertUpdatePageContentAttribute(pageAttribute, storefrontOid, pageOid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.InsertUpdatePageContentAttribute: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageAttribute** | [**StoreFrontPageContentAttribute**](StoreFrontPageContentAttribute.md)| Page content attribute to upsert | 
 **storefrontOid** | **int?**|  | 
 **pageOid** | **int?**| The page oid to modify. | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json; charset=UTF-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="preparedownloademailsegment"></a>
# **PrepareDownloadEmailSegment**
> EmailSegmentDownloadPrepareResponse PrepareDownloadEmailSegment (int? storefrontOid, string emailSegmentUuid)

Prepare download of email segment
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class PrepareDownloadEmailSegmentExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailSegmentUuid = emailSegmentUuid_example;  // string | 

            try
            {
                // Prepare download of email segment
                EmailSegmentDownloadPrepareResponse result = apiInstance.PrepareDownloadEmailSegment(storefrontOid, emailSegmentUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.PrepareDownloadEmailSegment: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailSegmentUuid** | **string**|  | 

### Return type

[**EmailSegmentDownloadPrepareResponse**](EmailSegmentDownloadPrepareResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="publishlibraryitem"></a>
# **PublishLibraryItem**
> LibraryItemResponse PublishLibraryItem (int? libraryItemOid, PublishLibraryItemRequest publishLibraryRequest)

Publish library item.
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class PublishLibraryItemExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var libraryItemOid = 56;  // int? | 
            var publishLibraryRequest = new PublishLibraryItemRequest(); // PublishLibraryItemRequest | Publish library item request

            try
            {
                // Publish library item.
                LibraryItemResponse result = apiInstance.PublishLibraryItem(libraryItemOid, publishLibraryRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.PublishLibraryItem: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **libraryItemOid** | **int?**|  | 
 **publishLibraryRequest** | [**PublishLibraryItemRequest**](PublishLibraryItemRequest.md)| Publish library item request | 

### Return type

[**LibraryItemResponse**](LibraryItemResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaselibraryitem"></a>
# **PurchaseLibraryItem**
> LibraryItemResponse PurchaseLibraryItem (int? libraryItemOid, int? storefrontOid = null)

Purchase public library item, which creates a copy of the item in your personal code library
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class PurchaseLibraryItemExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var libraryItemOid = 56;  // int? | 
            var storefrontOid = 56;  // int? |  (optional) 

            try
            {
                // Purchase public library item, which creates a copy of the item in your personal code library
                LibraryItemResponse result = apiInstance.PurchaseLibraryItem(libraryItemOid, storefrontOid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.PurchaseLibraryItem: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **libraryItemOid** | **int?**|  | 
 **storefrontOid** | **int?**|  | [optional] 

### Return type

[**LibraryItemResponse**](LibraryItemResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="releaseemailcommseqstepwaiting"></a>
# **ReleaseEmailCommseqStepWaiting**
> void ReleaseEmailCommseqStepWaiting (int? storefrontOid, string commseqUuid, string commseqStepUuid)

Release email communication sequence customers waiting at the specified step
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ReleaseEmailCommseqStepWaitingExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 
            var commseqStepUuid = commseqStepUuid_example;  // string | 

            try
            {
                // Release email communication sequence customers waiting at the specified step
                apiInstance.ReleaseEmailCommseqStepWaiting(storefrontOid, commseqUuid, commseqStepUuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.ReleaseEmailCommseqStepWaiting: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 
 **commseqStepUuid** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetemailcommseqratelimiters"></a>
# **ResetEmailCommseqRateLimiters**
> void ResetEmailCommseqRateLimiters (int? storefrontOid, string commseqUuid)

Reset email commseq rate limiters (only callable by UltraCart Support)
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ResetEmailCommseqRateLimitersExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 

            try
            {
                // Reset email commseq rate limiters (only callable by UltraCart Support)
                apiInstance.ResetEmailCommseqRateLimiters(storefrontOid, commseqUuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.ResetEmailCommseqRateLimiters: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="review"></a>
# **Review**
> EmailCommseqEmailSendTestResponse Review (int? storefrontOid, string commseqEmailUuid, EmailCommseqEmailSendTestRequest emailCommseqEmailReviewRequest)

Request a review of an email
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ReviewExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqEmailUuid = commseqEmailUuid_example;  // string | 
            var emailCommseqEmailReviewRequest = new EmailCommseqEmailSendTestRequest(); // EmailCommseqEmailSendTestRequest | Email commseq email review request

            try
            {
                // Request a review of an email
                EmailCommseqEmailSendTestResponse result = apiInstance.Review(storefrontOid, commseqEmailUuid, emailCommseqEmailReviewRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.Review: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqEmailUuid** | **string**|  | 
 **emailCommseqEmailReviewRequest** | [**EmailCommseqEmailSendTestRequest**](EmailCommseqEmailSendTestRequest.md)| Email commseq email review request | 

### Return type

[**EmailCommseqEmailSendTestResponse**](EmailCommseqEmailSendTestResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="search"></a>
# **Search**
> LookupResponse Search (string category = null, string matches = null, string storefrontOid = null, int? maxHits = null, string subcategory = null)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var category = category_example;  // string |  (optional) 
            var matches = matches_example;  // string |  (optional) 
            var storefrontOid = storefrontOid_example;  // string |  (optional) 
            var maxHits = 56;  // int? |  (optional) 
            var subcategory = subcategory_example;  // string |  (optional) 

            try
            {
                // Searches for all matching values
                LookupResponse result = apiInstance.Search(category, matches, storefrontOid, maxHits, subcategory);
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
 **category** | **string**|  | [optional] 
 **matches** | **string**|  | [optional] 
 **storefrontOid** | **string**|  | [optional] 
 **maxHits** | **int?**|  | [optional] 
 **subcategory** | **string**|  | [optional] 

### Return type

[**LookupResponse**](LookupResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="search2"></a>
# **Search2**
> LookupResponse Search2 (LookupRequest lookupRequest)

Searches for all matching values (using POST)
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class Search2Example
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var lookupRequest = new LookupRequest(); // LookupRequest | LookupRequest

            try
            {
                // Searches for all matching values (using POST)
                LookupResponse result = apiInstance.Search2(lookupRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.Search2: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lookupRequest** | [**LookupRequest**](LookupRequest.md)| LookupRequest | 

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
> EmailListCustomersResponse SearchEmailListCustomers (int? storefrontOid, string emailListUuid, string startsWith = null)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailListUuid = emailListUuid_example;  // string | 
            var startsWith = startsWith_example;  // string |  (optional) 

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
 **storefrontOid** | **int?**|  | 
 **emailListUuid** | **string**|  | 
 **startsWith** | **string**|  | [optional] 

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
> EmailSegmentCustomersResponse SearchEmailSegmentCustomers (int? storefrontOid, string emailSegmentUuid, string startsWith = null)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailSegmentUuid = emailSegmentUuid_example;  // string | 
            var startsWith = startsWith_example;  // string |  (optional) 

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
 **storefrontOid** | **int?**|  | 
 **emailSegmentUuid** | **string**|  | 
 **startsWith** | **string**|  | [optional] 

### Return type

[**EmailSegmentCustomersResponse**](EmailSegmentCustomersResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchlibraryitems"></a>
# **SearchLibraryItems**
> LibraryItemsResponse SearchLibraryItems (LibraryItemQuery itemQuery, int? limit = null, int? offset = null, string sort = null)

Retrieve library items

Retrieves a library items based on a query object.  If no parameters are specified, the API call will default to the merchant id only.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SearchLibraryItemsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var itemQuery = new LibraryItemQuery(); // LibraryItemQuery | Item query
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Maximum 10000) (optional)  (default to 10000)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var sort = sort_example;  // string | The sort order of the library items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 

            try
            {
                // Retrieve library items
                LibraryItemsResponse result = apiInstance.SearchLibraryItems(itemQuery, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.SearchLibraryItems: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemQuery** | [**LibraryItemQuery**](LibraryItemQuery.md)| Item query | 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Maximum 10000) | [optional] [default to 10000]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **sort** | **string**| The sort order of the library items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 

### Return type

[**LibraryItemsResponse**](LibraryItemsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchpublisheditems"></a>
# **SearchPublishedItems**
> LibraryItemsResponse SearchPublishedItems (LibraryItemQuery itemQuery, int? limit = null, int? offset = null, string sort = null)

Retrieve library items

Retrieves a library items based on a query object.  If no parameters are specified, the API call will default to the merchant id only.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SearchPublishedItemsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var itemQuery = new LibraryItemQuery(); // LibraryItemQuery | Item query
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Maximum 10000) (optional)  (default to 10000)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var sort = sort_example;  // string | The sort order of the library items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 

            try
            {
                // Retrieve library items
                LibraryItemsResponse result = apiInstance.SearchPublishedItems(itemQuery, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.SearchPublishedItems: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemQuery** | [**LibraryItemQuery**](LibraryItemQuery.md)| Item query | 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Maximum 10000) | [optional] [default to 10000]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **sort** | **string**| The sort order of the library items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 

### Return type

[**LibraryItemsResponse**](LibraryItemsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchreviewitems"></a>
# **SearchReviewItems**
> LibraryItemsResponse SearchReviewItems (LibraryItemQuery itemQuery, int? limit = null, int? offset = null, string sort = null)

Retrieve library items needing review or rejected

Retrieves a library items based on a query object.  If no parameters are specified, the API call will default to the merchant id only.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SearchReviewItemsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var itemQuery = new LibraryItemQuery(); // LibraryItemQuery | Item query
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Maximum 10000) (optional)  (default to 10000)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var sort = sort_example;  // string | The sort order of the library items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 

            try
            {
                // Retrieve library items needing review or rejected
                LibraryItemsResponse result = apiInstance.SearchReviewItems(itemQuery, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.SearchReviewItems: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemQuery** | [**LibraryItemQuery**](LibraryItemQuery.md)| Item query | 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Maximum 10000) | [optional] [default to 10000]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **sort** | **string**| The sort order of the library items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 

### Return type

[**LibraryItemsResponse**](LibraryItemsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchshareditems"></a>
# **SearchSharedItems**
> LibraryItemsResponse SearchSharedItems (LibraryItemQuery itemQuery, int? limit = null, int? offset = null, string sort = null)

Retrieve library items

Retrieves a library items based on a query object.  If no parameters are specified, the API call will default to the merchant id only.  You will need to make multiple API calls in order to retrieve the entire result set since this API performs result set pagination. 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SearchSharedItemsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var itemQuery = new LibraryItemQuery(); // LibraryItemQuery | Item query
            var limit = 56;  // int? | The maximum number of records to return on this one API call. (Maximum 10000) (optional)  (default to 10000)
            var offset = 56;  // int? | Pagination of the record set.  Offset is a zero based index. (optional)  (default to 0)
            var sort = sort_example;  // string | The sort order of the library items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. (optional) 

            try
            {
                // Retrieve library items
                LibraryItemsResponse result = apiInstance.SearchSharedItems(itemQuery, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.SearchSharedItems: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemQuery** | [**LibraryItemQuery**](LibraryItemQuery.md)| Item query | 
 **limit** | **int?**| The maximum number of records to return on this one API call. (Maximum 10000) | [optional] [default to 10000]
 **offset** | **int?**| Pagination of the record set.  Offset is a zero based index. | [optional] [default to 0]
 **sort** | **string**| The sort order of the library items.  See Sorting documentation for examples of using multiple values and sorting by ascending and descending. | [optional] 

### Return type

[**LibraryItemsResponse**](LibraryItemsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendemailtest"></a>
# **SendEmailTest**
> EmailCommseqEmailSendTestResponse SendEmailTest (int? storefrontOid, string commseqEmailUuid, EmailCommseqEmailSendTestRequest emailCommseqEmailTestRequest)

Send email test
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SendEmailTestExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqEmailUuid = commseqEmailUuid_example;  // string | 
            var emailCommseqEmailTestRequest = new EmailCommseqEmailSendTestRequest(); // EmailCommseqEmailSendTestRequest | Email commseq email test request

            try
            {
                // Send email test
                EmailCommseqEmailSendTestResponse result = apiInstance.SendEmailTest(storefrontOid, commseqEmailUuid, emailCommseqEmailTestRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.SendEmailTest: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqEmailUuid** | **string**|  | 
 **emailCommseqEmailTestRequest** | [**EmailCommseqEmailSendTestRequest**](EmailCommseqEmailSendTestRequest.md)| Email commseq email test request | 

### Return type

[**EmailCommseqEmailSendTestResponse**](EmailCommseqEmailSendTestResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendpostcardtest"></a>
# **SendPostcardTest**
> EmailCommseqPostcardSendTestResponse SendPostcardTest (int? storefrontOid, string commseqPostcardUuid, EmailCommseqPostcardSendTestRequest emailCommseqPostcardTestRequest)

Send postcard test
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SendPostcardTestExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqPostcardUuid = commseqPostcardUuid_example;  // string | 
            var emailCommseqPostcardTestRequest = new EmailCommseqPostcardSendTestRequest(); // EmailCommseqPostcardSendTestRequest | Email commseq email test request

            try
            {
                // Send postcard test
                EmailCommseqPostcardSendTestResponse result = apiInstance.SendPostcardTest(storefrontOid, commseqPostcardUuid, emailCommseqPostcardTestRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.SendPostcardTest: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqPostcardUuid** | **string**|  | 
 **emailCommseqPostcardTestRequest** | [**EmailCommseqPostcardSendTestRequest**](EmailCommseqPostcardSendTestRequest.md)| Email commseq email test request | 

### Return type

[**EmailCommseqPostcardSendTestResponse**](EmailCommseqPostcardSendTestResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendsmstest"></a>
# **SendSmsTest**
> EmailCommseqSmsSendTestResponse SendSmsTest (int? storefrontOid, string commseqUuid, string commseqStepUuid, EmailCommseqSmsSendTestRequest emailCommseqSmsTestRequest)

Send SMS test
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SendSmsTestExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 
            var commseqStepUuid = commseqStepUuid_example;  // string | 
            var emailCommseqSmsTestRequest = new EmailCommseqSmsSendTestRequest(); // EmailCommseqSmsSendTestRequest | Email commseq sms test request

            try
            {
                // Send SMS test
                EmailCommseqSmsSendTestResponse result = apiInstance.SendSmsTest(storefrontOid, commseqUuid, commseqStepUuid, emailCommseqSmsTestRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.SendSmsTest: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 
 **commseqStepUuid** | **string**|  | 
 **emailCommseqSmsTestRequest** | [**EmailCommseqSmsSendTestRequest**](EmailCommseqSmsSendTestRequest.md)| Email commseq sms test request | 

### Return type

[**EmailCommseqSmsSendTestResponse**](EmailCommseqSmsSendTestResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendwebhooktest"></a>
# **SendWebhookTest**
> EmailCommseqWebhookSendTestResponse SendWebhookTest (int? storefrontOid, EmailCommseqWebhookSendTestRequest emailCommseqWebhookTestRequest)

Send webhook test
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SendWebhookTestExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailCommseqWebhookTestRequest = new EmailCommseqWebhookSendTestRequest(); // EmailCommseqWebhookSendTestRequest | Email commseq webhook test request

            try
            {
                // Send webhook test
                EmailCommseqWebhookSendTestResponse result = apiInstance.SendWebhookTest(storefrontOid, emailCommseqWebhookTestRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.SendWebhookTest: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailCommseqWebhookTestRequest** | [**EmailCommseqWebhookSendTestRequest**](EmailCommseqWebhookSendTestRequest.md)| Email commseq webhook test request | 

### Return type

[**EmailCommseqWebhookSendTestResponse**](EmailCommseqWebhookSendTestResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sequencetest"></a>
# **SequenceTest**
> EmailCommseqSequenceTestResponse SequenceTest (int? storefrontOid, string commseqUuid, EmailCommseqSequenceTestRequest emailCommseqSequenceTestRequest)

Sequence test
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SequenceTestExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 
            var emailCommseqSequenceTestRequest = new EmailCommseqSequenceTestRequest(); // EmailCommseqSequenceTestRequest | Commseq test request

            try
            {
                // Sequence test
                EmailCommseqSequenceTestResponse result = apiInstance.SequenceTest(storefrontOid, commseqUuid, emailCommseqSequenceTestRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.SequenceTest: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 
 **emailCommseqSequenceTestRequest** | [**EmailCommseqSequenceTestRequest**](EmailCommseqSequenceTestRequest.md)| Commseq test request | 

### Return type

[**EmailCommseqSequenceTestResponse**](EmailCommseqSequenceTestResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startemailcampaign"></a>
# **StartEmailCampaign**
> BaseResponse StartEmailCampaign (int? storefrontOid, string emailCampaignUuid)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailCampaignUuid = emailCampaignUuid_example;  // string | 

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
 **storefrontOid** | **int?**|  | 
 **emailCampaignUuid** | **string**|  | 

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
> EmailListSubscribeResponse SubscribeToEmailList (int? storefrontOid, string emailListUuid, List<EmailCustomer> customers)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailListUuid = emailListUuid_example;  // string | 
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
 **storefrontOid** | **int?**|  | 
 **emailListUuid** | **string**|  | 
 **customers** | [**List&lt;EmailCustomer&gt;**](EmailCustomer.md)| Customers | 

### Return type

[**EmailListSubscribeResponse**](EmailListSubscribeResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sunsetemailsegment"></a>
# **SunsetEmailSegment**
> void SunsetEmailSegment (int? storefrontOid, string emailSegmentUuid)

Sunset email segment
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class SunsetEmailSegmentExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailSegmentUuid = emailSegmentUuid_example;  // string | 

            try
            {
                // Sunset email segment
                apiInstance.SunsetEmailSegment(storefrontOid, emailSegmentUuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.SunsetEmailSegment: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailSegmentUuid** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unfavoritescreenrecording"></a>
# **UnfavoriteScreenRecording**
> void UnfavoriteScreenRecording (int? storefrontOid, string screenRecordingUuid)

Remove favorite flag on screen recording

Remove favorite flag on screen recording 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UnfavoriteScreenRecordingExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var screenRecordingUuid = screenRecordingUuid_example;  // string | 

            try
            {
                // Remove favorite flag on screen recording
                apiInstance.UnfavoriteScreenRecording(storefrontOid, screenRecordingUuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UnfavoriteScreenRecording: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **screenRecordingUuid** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailcampaign"></a>
# **UpdateEmailCampaign**
> EmailCampaignResponse UpdateEmailCampaign (int? storefrontOid, string emailCampaignUuid, EmailCampaign emailCampaign)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailCampaignUuid = emailCampaignUuid_example;  // string | 
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
 **storefrontOid** | **int?**|  | 
 **emailCampaignUuid** | **string**|  | 
 **emailCampaign** | [**EmailCampaign**](EmailCampaign.md)| Email campaign | 

### Return type

[**EmailCampaignResponse**](EmailCampaignResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailcampaignfolder"></a>
# **UpdateEmailCampaignFolder**
> EmailCampaignFolderResponse UpdateEmailCampaignFolder (int? storefrontOid, string emailCampaignFolderUuid, EmailCampaignFolder emailCampaignFolder)

Update email campaign folder
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateEmailCampaignFolderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailCampaignFolderUuid = emailCampaignFolderUuid_example;  // string | 
            var emailCampaignFolder = new EmailCampaignFolder(); // EmailCampaignFolder | Email campaign folder

            try
            {
                // Update email campaign folder
                EmailCampaignFolderResponse result = apiInstance.UpdateEmailCampaignFolder(storefrontOid, emailCampaignFolderUuid, emailCampaignFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateEmailCampaignFolder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailCampaignFolderUuid** | **string**|  | 
 **emailCampaignFolder** | [**EmailCampaignFolder**](EmailCampaignFolder.md)| Email campaign folder | 

### Return type

[**EmailCampaignFolderResponse**](EmailCampaignFolderResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailcommseq"></a>
# **UpdateEmailCommseq**
> EmailCommseqResponse UpdateEmailCommseq (int? storefrontOid, string commseqUuid, EmailCommseq emailCommseq)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqUuid = commseqUuid_example;  // string | 
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
 **storefrontOid** | **int?**|  | 
 **commseqUuid** | **string**|  | 
 **emailCommseq** | [**EmailCommseq**](EmailCommseq.md)| Email commseq | 

### Return type

[**EmailCommseqResponse**](EmailCommseqResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailcustomer"></a>
# **UpdateEmailCustomer**
> void UpdateEmailCustomer (int? storefrontOid, string emailCustomerUuid, EmailCustomer emailCustomer)

Update email customer
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateEmailCustomerExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailCustomerUuid = emailCustomerUuid_example;  // string | 
            var emailCustomer = new EmailCustomer(); // EmailCustomer | Email customer

            try
            {
                // Update email customer
                apiInstance.UpdateEmailCustomer(storefrontOid, emailCustomerUuid, emailCustomer);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateEmailCustomer: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailCustomerUuid** | **string**|  | 
 **emailCustomer** | [**EmailCustomer**](EmailCustomer.md)| Email customer | 

### Return type

void (empty response body)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailemail"></a>
# **UpdateEmailEmail**
> EmailCommseqEmailResponse UpdateEmailEmail (int? storefrontOid, string commseqEmailUuid, EmailCommseqEmail emailCommseqEmail)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqEmailUuid = commseqEmailUuid_example;  // string | 
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
 **storefrontOid** | **int?**|  | 
 **commseqEmailUuid** | **string**|  | 
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
> EmailFlowResponse UpdateEmailFlow (int? storefrontOid, string emailFlowUuid, EmailFlow emailFlow)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailFlowUuid = emailFlowUuid_example;  // string | 
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
 **storefrontOid** | **int?**|  | 
 **emailFlowUuid** | **string**|  | 
 **emailFlow** | [**EmailFlow**](EmailFlow.md)| Email flow | 

### Return type

[**EmailFlowResponse**](EmailFlowResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailflowfolder"></a>
# **UpdateEmailFlowFolder**
> EmailFlowFolderResponse UpdateEmailFlowFolder (int? storefrontOid, string emailFlowFolderUuid, EmailFlowFolder emailFlowFolder)

Update email flow folder
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateEmailFlowFolderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailFlowFolderUuid = emailFlowFolderUuid_example;  // string | 
            var emailFlowFolder = new EmailFlowFolder(); // EmailFlowFolder | Email flow folder

            try
            {
                // Update email flow folder
                EmailFlowFolderResponse result = apiInstance.UpdateEmailFlowFolder(storefrontOid, emailFlowFolderUuid, emailFlowFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateEmailFlowFolder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailFlowFolderUuid** | **string**|  | 
 **emailFlowFolder** | [**EmailFlowFolder**](EmailFlowFolder.md)| Email flow folder | 

### Return type

[**EmailFlowFolderResponse**](EmailFlowFolderResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailglobalsettings"></a>
# **UpdateEmailGlobalSettings**
> EmailGlobalSettingsResponse UpdateEmailGlobalSettings (EmailGlobalSettings globalSettings)

Update email global settings
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateEmailGlobalSettingsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var globalSettings = new EmailGlobalSettings(); // EmailGlobalSettings | global settings request

            try
            {
                // Update email global settings
                EmailGlobalSettingsResponse result = apiInstance.UpdateEmailGlobalSettings(globalSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateEmailGlobalSettings: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **globalSettings** | [**EmailGlobalSettings**](EmailGlobalSettings.md)| global settings request | 

### Return type

[**EmailGlobalSettingsResponse**](EmailGlobalSettingsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemaillist"></a>
# **UpdateEmailList**
> EmailListResponse UpdateEmailList (int? storefrontOid, string emailListUuid, EmailList emailList)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailListUuid = emailListUuid_example;  // string | 
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
 **storefrontOid** | **int?**|  | 
 **emailListUuid** | **string**|  | 
 **emailList** | [**EmailList**](EmailList.md)| Email list | 

### Return type

[**EmailListResponse**](EmailListResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemaillistsegmentfolder"></a>
# **UpdateEmailListSegmentFolder**
> EmailListSegmentFolderResponse UpdateEmailListSegmentFolder (int? storefrontOid, string emailListSegmentFolderUuid, EmailListSegmentFolder emailListSegmentFolder)

Update email campaign folder
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateEmailListSegmentFolderExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailListSegmentFolderUuid = emailListSegmentFolderUuid_example;  // string | 
            var emailListSegmentFolder = new EmailListSegmentFolder(); // EmailListSegmentFolder | Email campaign folder

            try
            {
                // Update email campaign folder
                EmailListSegmentFolderResponse result = apiInstance.UpdateEmailListSegmentFolder(storefrontOid, emailListSegmentFolderUuid, emailListSegmentFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateEmailListSegmentFolder: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailListSegmentFolderUuid** | **string**|  | 
 **emailListSegmentFolder** | [**EmailListSegmentFolder**](EmailListSegmentFolder.md)| Email campaign folder | 

### Return type

[**EmailListSegmentFolderResponse**](EmailListSegmentFolderResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailplan"></a>
# **UpdateEmailPlan**
> EmailPlanResponse UpdateEmailPlan (int? storefrontOid, EmailPlan settings)

Update email plan
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateEmailPlanExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var settings = new EmailPlan(); // EmailPlan | plan request

            try
            {
                // Update email plan
                EmailPlanResponse result = apiInstance.UpdateEmailPlan(storefrontOid, settings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateEmailPlan: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **settings** | [**EmailPlan**](EmailPlan.md)| plan request | 

### Return type

[**EmailPlanResponse**](EmailPlanResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailpostcard"></a>
# **UpdateEmailPostcard**
> EmailCommseqPostcardResponse UpdateEmailPostcard (int? storefrontOid, string commseqPostcardUuid, EmailCommseqPostcard emailCommseqPostcard)

Update email postcard
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateEmailPostcardExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var commseqPostcardUuid = commseqPostcardUuid_example;  // string | 
            var emailCommseqPostcard = new EmailCommseqPostcard(); // EmailCommseqPostcard | Email commseq postcard

            try
            {
                // Update email postcard
                EmailCommseqPostcardResponse result = apiInstance.UpdateEmailPostcard(storefrontOid, commseqPostcardUuid, emailCommseqPostcard);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateEmailPostcard: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **commseqPostcardUuid** | **string**|  | 
 **emailCommseqPostcard** | [**EmailCommseqPostcard**](EmailCommseqPostcard.md)| Email commseq postcard | 

### Return type

[**EmailCommseqPostcardResponse**](EmailCommseqPostcardResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailsegment"></a>
# **UpdateEmailSegment**
> EmailSegmentResponse UpdateEmailSegment (int? storefrontOid, string emailSegmentUuid, EmailSegment emailSegment)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailSegmentUuid = emailSegmentUuid_example;  // string | 
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
 **storefrontOid** | **int?**|  | 
 **emailSegmentUuid** | **string**|  | 
 **emailSegment** | [**EmailSegment**](EmailSegment.md)| Email segment | 

### Return type

[**EmailSegmentResponse**](EmailSegmentResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailsendingdomain"></a>
# **UpdateEmailSendingDomain**
> EmailSendingDomainResponse UpdateEmailSendingDomain (string domain, EmailDomain emailDomain)

Update email sending domain
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateEmailSendingDomainExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var domain = domain_example;  // string | 
            var emailDomain = new EmailDomain(); // EmailDomain | EmailDomain

            try
            {
                // Update email sending domain
                EmailSendingDomainResponse result = apiInstance.UpdateEmailSendingDomain(domain, emailDomain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateEmailSendingDomain: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**|  | 
 **emailDomain** | [**EmailDomain**](EmailDomain.md)| EmailDomain | 

### Return type

[**EmailSendingDomainResponse**](EmailSendingDomainResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailsettings"></a>
# **UpdateEmailSettings**
> EmailSettingsResponse UpdateEmailSettings (int? storefrontOid, EmailSettings settings)

Update email settings
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateEmailSettingsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var settings = new EmailSettings(); // EmailSettings | settings request

            try
            {
                // Update email settings
                EmailSettingsResponse result = apiInstance.UpdateEmailSettings(storefrontOid, settings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateEmailSettings: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **settings** | [**EmailSettings**](EmailSettings.md)| settings request | 

### Return type

[**EmailSettingsResponse**](EmailSettingsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateexperiment"></a>
# **UpdateExperiment**
> ExperimentResponse UpdateExperiment (int? storefrontOid, int? storefrontExperimentOid, Experiment experiment)

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

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var storefrontExperimentOid = 56;  // int? | 
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
 **storefrontOid** | **int?**|  | 
 **storefrontExperimentOid** | **int?**|  | 
 **experiment** | [**Experiment**](Experiment.md)| Experiment | 

### Return type

[**ExperimentResponse**](ExperimentResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelibraryitem"></a>
# **UpdateLibraryItem**
> LibraryItemResponse UpdateLibraryItem (int? libraryItemOid, LibraryItem libraryItem)

Update library item. Note that only certain fields may be updated via this method.
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateLibraryItemExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var libraryItemOid = 56;  // int? | 
            var libraryItem = new LibraryItem(); // LibraryItem | Library item

            try
            {
                // Update library item. Note that only certain fields may be updated via this method.
                LibraryItemResponse result = apiInstance.UpdateLibraryItem(libraryItemOid, libraryItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateLibraryItem: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **libraryItemOid** | **int?**|  | 
 **libraryItem** | [**LibraryItem**](LibraryItem.md)| Library item | 

### Return type

[**LibraryItemResponse**](LibraryItemResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatescreenrecordingmerchantnotes"></a>
# **UpdateScreenRecordingMerchantNotes**
> void UpdateScreenRecordingMerchantNotes (int? storefrontOid, string screenRecordingUuid, ScreenRecordingMerchantNotesRequest merchantNotesRequest)

Update merchant notes on a screen recording

Update merchant notes on a screen recording 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateScreenRecordingMerchantNotesExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var screenRecordingUuid = screenRecordingUuid_example;  // string | 
            var merchantNotesRequest = new ScreenRecordingMerchantNotesRequest(); // ScreenRecordingMerchantNotesRequest | Merchant Notes

            try
            {
                // Update merchant notes on a screen recording
                apiInstance.UpdateScreenRecordingMerchantNotes(storefrontOid, screenRecordingUuid, merchantNotesRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateScreenRecordingMerchantNotes: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **screenRecordingUuid** | **string**|  | 
 **merchantNotesRequest** | [**ScreenRecordingMerchantNotesRequest**](ScreenRecordingMerchantNotesRequest.md)| Merchant Notes | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatescreenrecordingsegment"></a>
# **UpdateScreenRecordingSegment**
> ScreenRecordingSegmentResponse UpdateScreenRecordingSegment (int? storefrontOid, int? screenRecordingSegmentOid, ScreenRecordingSegment segment)

Update screen recording segment
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateScreenRecordingSegmentExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var screenRecordingSegmentOid = 56;  // int? | 
            var segment = new ScreenRecordingSegment(); // ScreenRecordingSegment | Segment

            try
            {
                // Update screen recording segment
                ScreenRecordingSegmentResponse result = apiInstance.UpdateScreenRecordingSegment(storefrontOid, screenRecordingSegmentOid, segment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateScreenRecordingSegment: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **screenRecordingSegmentOid** | **int?**|  | 
 **segment** | [**ScreenRecordingSegment**](ScreenRecordingSegment.md)| Segment | 

### Return type

[**ScreenRecordingSegmentResponse**](ScreenRecordingSegmentResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatescreenrecordingsettings"></a>
# **UpdateScreenRecordingSettings**
> ScreenRecordingSettingsResponse UpdateScreenRecordingSettings (int? storefrontOid, ScreenRecordingSettings settings)

Update screen recording settings
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateScreenRecordingSettingsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var settings = new ScreenRecordingSettings(); // ScreenRecordingSettings | Settings

            try
            {
                // Update screen recording settings
                ScreenRecordingSettingsResponse result = apiInstance.UpdateScreenRecordingSettings(storefrontOid, settings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateScreenRecordingSettings: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **settings** | [**ScreenRecordingSettings**](ScreenRecordingSettings.md)| Settings | 

### Return type

[**ScreenRecordingSettingsResponse**](ScreenRecordingSettingsResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatescreenrecordingtags"></a>
# **UpdateScreenRecordingTags**
> void UpdateScreenRecordingTags (int? storefrontOid, string screenRecordingUuid, ScreenRecordingTagsRequest tags)

Update tags on a screen recording

Update tags on a screen recording 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateScreenRecordingTagsExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var screenRecordingUuid = screenRecordingUuid_example;  // string | 
            var tags = new ScreenRecordingTagsRequest(); // ScreenRecordingTagsRequest | Tags

            try
            {
                // Update tags on a screen recording
                apiInstance.UpdateScreenRecordingTags(storefrontOid, screenRecordingUuid, tags);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateScreenRecordingTags: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **screenRecordingUuid** | **string**|  | 
 **tags** | [**ScreenRecordingTagsRequest**](ScreenRecordingTagsRequest.md)| Tags | 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetransactionemail"></a>
# **UpdateTransactionEmail**
> TransactionEmailResponse UpdateTransactionEmail (int? storefrontOid, string emailId, TransactionEmail transactionEmail)

Updates a transaction email object

Updates a transactional email 
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateTransactionEmailExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var storefrontOid = 56;  // int? | 
            var emailId = emailId_example;  // string | 
            var transactionEmail = new TransactionEmail(); // TransactionEmail | TransactionEmail

            try
            {
                // Updates a transaction email object
                TransactionEmailResponse result = apiInstance.UpdateTransactionEmail(storefrontOid, emailId, transactionEmail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateTransactionEmail: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int?**|  | 
 **emailId** | **string**|  | 
 **transactionEmail** | [**TransactionEmail**](TransactionEmail.md)| TransactionEmail | 

### Return type

[**TransactionEmailResponse**](TransactionEmailResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetwilioaccount"></a>
# **UpdateTwilioAccount**
> TwilioResponse UpdateTwilioAccount (string espTwilioUuid, Twilio twilio)

Update Twilio account
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UpdateTwilioAccountExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var espTwilioUuid = espTwilioUuid_example;  // string | 
            var twilio = new Twilio(); // Twilio | Twilio

            try
            {
                // Update Twilio account
                TwilioResponse result = apiInstance.UpdateTwilioAccount(espTwilioUuid, twilio);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateTwilioAccount: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **espTwilioUuid** | **string**|  | 
 **twilio** | [**Twilio**](Twilio.md)| Twilio | 

### Return type

[**TwilioResponse**](TwilioResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadfsfile"></a>
# **UploadFsFile**
> void UploadFsFile (int? id, FileManagerUploadRequest uploadRequest)

This is the last step in uploading a file after 1) calling getUploadFsFileUrl and 2) uploading a file to the provided url, then finally 3) calling this method and providing the key to trigger the server into reading the S3 bucket and retrieving the file.
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class UploadFsFileExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var id = 56;  // int? | 
            var uploadRequest = new FileManagerUploadRequest(); // FileManagerUploadRequest | UploadRequest

            try
            {
                // This is the last step in uploading a file after 1) calling getUploadFsFileUrl and 2) uploading a file to the provided url, then finally 3) calling this method and providing the key to trigger the server into reading the S3 bucket and retrieving the file.
                apiInstance.UploadFsFile(id, uploadRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.UploadFsFile: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **uploadRequest** | [**FileManagerUploadRequest**](FileManagerUploadRequest.md)| UploadRequest | 

### Return type

void (empty response body)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validateruler"></a>
# **ValidateRuler**
> RulerValidationResponse ValidateRuler (RulerValidationRequest rulerValidateRequest)

Validate AWS Event Ruler
### Example
```csharp

using System;
using System.Diagnostics;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace Example
{
    public class ValidateRulerExample
    {
        public void main()
        {

            // Create a Simple Key: https://ultracart.atlassian.net/wiki/spaces/ucdoc/pages/38688545/API+Simple+Key
            const string simpleKey = "109ee846ee69f50177018ab12f008a00748a25aa28dbdc0177018ab12f008a00";
            var api = new StorefrontApi(simpleKey);

            var rulerValidateRequest = new RulerValidationRequest(); // RulerValidationRequest | Ruler Validate Request

            try
            {
                // Validate AWS Event Ruler
                RulerValidationResponse result = apiInstance.ValidateRuler(rulerValidateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorefrontApi.ValidateRuler: " + e.Message );
            }
        }
    }
}

```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rulerValidateRequest** | [**RulerValidationRequest**](RulerValidationRequest.md)| Ruler Validate Request | 

### Return type

[**RulerValidationResponse**](RulerValidationResponse.md)

### Authorization

[ultraCartBrowserApiKey](../README.md#ultraCartBrowserApiKey), [ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

