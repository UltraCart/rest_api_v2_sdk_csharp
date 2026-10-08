# com.ultracart.admin.v2.Api.SfvbApi

All URIs are relative to *https://secure.ultracart.com/rest/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddSfvbPageBlogPosts**](SfvbApi.md#addsfvbpageblogposts) | **POST** /sfvb/storefronts/{storefront_oid}/pages/blog_posts/add | Assign blog posts to a page
[**AddSfvbPageItems**](SfvbApi.md#addsfvbpageitems) | **POST** /sfvb/storefronts/{storefront_oid}/pages/items/add | Assign items to a page
[**ArchiveSfvbUpsellPath**](SfvbApi.md#archivesfvbupsellpath) | **POST** /sfvb/storefronts/{storefront_oid}/upsell_paths/{upsell_path_oid}/archive | Archive an upsell path
[**AttachSfvbBlogPostImage**](SfvbApi.md#attachsfvbblogpostimage) | **POST** /sfvb/storefronts/{storefront_oid}/blog_posts/{blog_post_oid}/images/attach | Attach an image to a blog post
[**CheckSfvbRedirect**](SfvbApi.md#checksfvbredirect) | **POST** /sfvb/storefronts/{storefront_oid}/redirects/check | Check a redirect rule without creating it
[**ClearSfvbLibraryScreenshot**](SfvbApi.md#clearsfvblibraryscreenshot) | **DELETE** /sfvb/storefronts/{storefront_oid}/library/{library_oid}/screenshot | Remove a library entry&#39;s screenshot
[**CompileSfvbCjson**](SfvbApi.md#compilesfvbcjson) | **POST** /sfvb/cjson/compile | Compile CJSON to Velocity
[**CreateSfvbLibraryEntry**](SfvbApi.md#createsfvblibraryentry) | **POST** /sfvb/storefronts/{storefront_oid}/library | Save a fragment to the library
[**CreateSfvbPreviewAccess**](SfvbApi.md#createsfvbpreviewaccess) | **POST** /sfvb/storefronts/{storefront_oid}/preview_access | One time link that opens a preview in a browser with no UltraCart login
[**CreateSfvbPreviewSession**](SfvbApi.md#createsfvbpreviewsession) | **POST** /sfvb/storefronts/{storefront_oid}/preview_sessions | Create a preview session
[**DeleteSfvbApproval**](SfvbApi.md#deletesfvbapproval) | **DELETE** /sfvb/approvals/{approval_id} | Cancel a pending approval request
[**DeleteSfvbBlogPost**](SfvbApi.md#deletesfvbblogpost) | **DELETE** /sfvb/storefronts/{storefront_oid}/blog_posts/{blog_post_oid} | Delete a blog post
[**DeleteSfvbFile**](SfvbApi.md#deletesfvbfile) | **DELETE** /sfvb/storefronts/{storefront_oid}/files | Delete a storefront file
[**DeleteSfvbItemAttribute**](SfvbApi.md#deletesfvbitemattribute) | **DELETE** /sfvb/storefronts/{storefront_oid}/items/attributes | Delete an attribute from an item
[**DeleteSfvbItemMultimedia**](SfvbApi.md#deletesfvbitemmultimedia) | **DELETE** /sfvb/storefronts/{storefront_oid}/items/multimedia | Detach an image from an item
[**DeleteSfvbLibraryEntry**](SfvbApi.md#deletesfvblibraryentry) | **DELETE** /sfvb/storefronts/{storefront_oid}/library/{library_oid} | Delete or retire a library entry
[**DeleteSfvbPageMultimedia**](SfvbApi.md#deletesfvbpagemultimedia) | **DELETE** /sfvb/storefronts/{storefront_oid}/pages/multimedia | Detach an image from a page
[**DeleteSfvbPreviewSession**](SfvbApi.md#deletesfvbpreviewsession) | **DELETE** /sfvb/storefronts/{storefront_oid}/preview_sessions/{preview_session_id} | Delete a preview session
[**DeleteSfvbRedirect**](SfvbApi.md#deletesfvbredirect) | **DELETE** /sfvb/storefronts/{storefront_oid}/redirects/{redirect_id} | Delete a redirect rule
[**DetachSfvbBlogPostImage**](SfvbApi.md#detachsfvbblogpostimage) | **POST** /sfvb/storefronts/{storefront_oid}/blog_posts/{blog_post_oid}/images/detach | Detach an image from a blog post
[**DisableSfvbI18nLanguage**](SfvbApi.md#disablesfvbi18nlanguage) | **POST** /sfvb/storefronts/{storefront_oid}/i18n/languages/{code}/disable | Disable a language
[**DisableSfvbUpsellOffer**](SfvbApi.md#disablesfvbupselloffer) | **POST** /sfvb/storefronts/{storefront_oid}/upsell_offers/{upsell_offer_oid}/disable | Disable an upsell offer
[**DisableSfvbUpsellPath**](SfvbApi.md#disablesfvbupsellpath) | **POST** /sfvb/storefronts/{storefront_oid}/upsell_paths/{upsell_path_oid}/disable | Disable an upsell path
[**DownloadSfvbFile**](SfvbApi.md#downloadsfvbfile) | **GET** /sfvb/storefronts/{storefront_oid}/files/download | Read a storefront file&#39;s raw bytes
[**DryRunSfvbRedirectImport**](SfvbApi.md#dryrunsfvbredirectimport) | **POST** /sfvb/storefronts/{storefront_oid}/redirects/import/dry_run | Check a redirect import without writing it
[**DuplicateSfvbLibraryEntry**](SfvbApi.md#duplicatesfvblibraryentry) | **POST** /sfvb/storefronts/{storefront_oid}/library/{library_oid}/duplicate | Copy a library entry into a new private entry
[**DuplicateSfvbPage**](SfvbApi.md#duplicatesfvbpage) | **POST** /sfvb/storefronts/{storefront_oid}/pages/duplicate | Copy a page to a new path
[**DuplicateSfvbTheme**](SfvbApi.md#duplicatesfvbtheme) | **POST** /sfvb/storefronts/{storefront_oid}/themes/{theme_oid}/duplicate | Duplicate a theme
[**DuplicateSfvbUpsellOffer**](SfvbApi.md#duplicatesfvbupselloffer) | **POST** /sfvb/storefronts/{storefront_oid}/upsell_offers/{upsell_offer_oid}/duplicate | Duplicate an upsell offer
[**DuplicateSfvbUpsellPath**](SfvbApi.md#duplicatesfvbupsellpath) | **POST** /sfvb/storefronts/{storefront_oid}/upsell_paths/{upsell_path_oid}/duplicate | Duplicate an upsell path or one of its variations
[**EnableSfvbI18nLanguage**](SfvbApi.md#enablesfvbi18nlanguage) | **POST** /sfvb/storefronts/{storefront_oid}/i18n/languages/{code}/enable | Enable a language
[**EndSfvbExperiment**](SfvbApi.md#endsfvbexperiment) | **POST** /sfvb/storefronts/{storefront_oid}/experiments/{experiment_oid}/end | End an experiment
[**FavoriteSfvbLibraryEntry**](SfvbApi.md#favoritesfvblibraryentry) | **PUT** /sfvb/storefronts/{storefront_oid}/library/{library_oid}/favorite | Favorite a library entry
[**GetSfvbApproval**](SfvbApi.md#getsfvbapproval) | **GET** /sfvb/approvals/{approval_id} | Read one approval request
[**GetSfvbApprovals**](SfvbApi.md#getsfvbapprovals) | **GET** /sfvb/approvals | List this sign-in&#39;s approval requests
[**GetSfvbBlogPost**](SfvbApi.md#getsfvbblogpost) | **GET** /sfvb/storefronts/{storefront_oid}/blog_posts/{blog_post_oid} | Read a blog post
[**GetSfvbCjsonUsedElements**](SfvbApi.md#getsfvbcjsonusedelements) | **POST** /sfvb/cjson/elements | Element types used by a container
[**GetSfvbContainer**](SfvbApi.md#getsfvbcontainer) | **GET** /sfvb/storefronts/{storefront_oid}/containers/{owner_type}/{owner_object_id} | Read a container stored outside the file system
[**GetSfvbContainerVersion**](SfvbApi.md#getsfvbcontainerversion) | **GET** /sfvb/storefronts/{storefront_oid}/container_versions/{container_history_oid} | Read the CJSON stored in one container history entry
[**GetSfvbElement**](SfvbApi.md#getsfvbelement) | **GET** /sfvb/elements/{element_type} | Configuration schema and field card for one element type
[**GetSfvbExperiment**](SfvbApi.md#getsfvbexperiment) | **GET** /sfvb/storefronts/{storefront_oid}/experiments/{experiment_oid} | Read one experiment and its statistics
[**GetSfvbExperimentObjectives**](SfvbApi.md#getsfvbexperimentobjectives) | **GET** /sfvb/storefronts/{storefront_oid}/experiments/objectives | List the objectives an experiment can optimize
[**GetSfvbFileContent**](SfvbApi.md#getsfvbfilecontent) | **GET** /sfvb/storefronts/{storefront_oid}/files/content | Read a storefront file
[**GetSfvbFileUploadUrl**](SfvbApi.md#getsfvbfileuploadurl) | **GET** /sfvb/storefronts/{storefront_oid}/files/upload_url/{extension} | Get a URL to upload a binary asset to
[**GetSfvbI18nGlossary**](SfvbApi.md#getsfvbi18nglossary) | **GET** /sfvb/storefronts/{storefront_oid}/i18n/glossary | Read the storefront&#39;s translation glossary
[**GetSfvbI18nLanguages**](SfvbApi.md#getsfvbi18nlanguages) | **GET** /sfvb/storefronts/{storefront_oid}/i18n/languages | List a storefront&#39;s languages
[**GetSfvbI18nMachineTranslations**](SfvbApi.md#getsfvbi18nmachinetranslations) | **GET** /sfvb/storefronts/{storefront_oid}/i18n/machine_translations | Read where a widget setting&#39;s translations come from
[**GetSfvbI18nMessage**](SfvbApi.md#getsfvbi18nmessage) | **GET** /sfvb/storefronts/{storefront_oid}/i18n/messages/{key} | Read one built-in message
[**GetSfvbI18nMessageMachineTranslations**](SfvbApi.md#getsfvbi18nmessagemachinetranslations) | **GET** /sfvb/storefronts/{storefront_oid}/i18n/messages/{key}/machine_translations | Read where a message&#39;s translations come from
[**GetSfvbItem**](SfvbApi.md#getsfvbitem) | **GET** /sfvb/storefronts/{storefront_oid}/items | Read an item&#39;s storefront facing content
[**GetSfvbLibraryEntry**](SfvbApi.md#getsfvblibraryentry) | **GET** /sfvb/storefronts/{storefront_oid}/library/{library_oid} | Read one library entry including its CJSON
[**GetSfvbLibraryHistory**](SfvbApi.md#getsfvblibraryhistory) | **GET** /sfvb/storefronts/{storefront_oid}/library/{library_oid}/history | List a library entry&#39;s published revisions
[**GetSfvbLibraryShareTargets**](SfvbApi.md#getsfvblibrarysharetargets) | **GET** /sfvb/storefronts/{storefront_oid}/library/share_targets | List the accounts a library entry can be shared with
[**GetSfvbLibraryTaxonomy**](SfvbApi.md#getsfvblibrarytaxonomy) | **GET** /sfvb/storefronts/{storefront_oid}/library/taxonomy | List the allowed library tags
[**GetSfvbMenu**](SfvbApi.md#getsfvbmenu) | **GET** /sfvb/storefronts/{storefront_oid}/menus/{code} | Read one store menu and its entries
[**GetSfvbMenus**](SfvbApi.md#getsfvbmenus) | **GET** /sfvb/storefronts/{storefront_oid}/menus | List a storefront&#39;s store menus
[**GetSfvbNotFound**](SfvbApi.md#getsfvbnotfound) | **GET** /sfvb/storefronts/{storefront_oid}/not_found | List the paths that answered 404
[**GetSfvbNotFoundEntry**](SfvbApi.md#getsfvbnotfoundentry) | **GET** /sfvb/storefronts/{storefront_oid}/not_found/{not_found_id} | Read one 404 path with its recent hits
[**GetSfvbNotFoundPage**](SfvbApi.md#getsfvbnotfoundpage) | **GET** /sfvb/storefronts/{storefront_oid}/not_found_page | What renders the storefront&#39;s 404 page
[**GetSfvbPage**](SfvbApi.md#getsfvbpage) | **GET** /sfvb/storefronts/{storefront_oid}/pages | Read a page&#39;s attributes and images
[**GetSfvbPageBlogPosts**](SfvbApi.md#getsfvbpageblogposts) | **GET** /sfvb/storefronts/{storefront_oid}/pages/blog_posts | Read the blog posts assigned to a page
[**GetSfvbPageItems**](SfvbApi.md#getsfvbpageitems) | **GET** /sfvb/storefronts/{storefront_oid}/pages/items | Read the items assigned to a page
[**GetSfvbPageSelectors**](SfvbApi.md#getsfvbpageselectors) | **GET** /sfvb/storefronts/{storefront_oid}/pages/selectors | Read a page&#39;s selectors
[**GetSfvbPreviewUrl**](SfvbApi.md#getsfvbpreviewurl) | **GET** /sfvb/storefronts/{storefront_oid}/preview_sessions/{preview_session_id}/url | URL that renders a preview session
[**GetSfvbRecording**](SfvbApi.md#getsfvbrecording) | **GET** /sfvb/storefronts/{storefront_oid}/recordings/{screen_recording_uuid} | Get a screen recording
[**GetSfvbRecordingPageViewEvents**](SfvbApi.md#getsfvbrecordingpageviewevents) | **GET** /sfvb/storefronts/{storefront_oid}/recordings/{screen_recording_uuid}/page_views/{screen_recording_page_view_uuid}/events | Get one recorded page view&#39;s replay events
[**GetSfvbRecordingSettings**](SfvbApi.md#getsfvbrecordingsettings) | **GET** /sfvb/storefronts/{storefront_oid}/recording_settings | Get the storefront&#39;s screen recording settings
[**GetSfvbRedirect**](SfvbApi.md#getsfvbredirect) | **GET** /sfvb/storefronts/{storefront_oid}/redirects/{redirect_id} | Read one redirect rule
[**GetSfvbRedirects**](SfvbApi.md#getsfvbredirects) | **GET** /sfvb/storefronts/{storefront_oid}/redirects | List the storefront&#39;s redirect rules
[**GetSfvbServerLog**](SfvbApi.md#getsfvbserverlog) | **GET** /sfvb/storefronts/{storefront_oid}/logs/{log_id} | Get one storefront render log
[**GetSfvbSiteAttributes**](SfvbApi.md#getsfvbsiteattributes) | **GET** /sfvb/storefronts/{storefront_oid}/attributes | Read a storefront&#39;s site attributes
[**GetSfvbTestOrders**](SfvbApi.md#getsfvbtestorders) | **GET** /sfvb/storefronts/{storefront_oid}/test_orders | List recent test orders
[**GetSfvbTheme**](SfvbApi.md#getsfvbtheme) | **GET** /sfvb/storefronts/{storefront_oid}/themes/{theme_oid} | Get a theme
[**GetSfvbThemeAttributes**](SfvbApi.md#getsfvbthemeattributes) | **GET** /sfvb/storefronts/{storefront_oid}/themes/{theme_oid}/attributes | Read a theme&#39;s colors, fonts and settings
[**GetSfvbThemeJob**](SfvbApi.md#getsfvbthemejob) | **GET** /sfvb/storefronts/{storefront_oid}/theme_jobs/{job_id} | Status of an asynchronous theme job
[**GetSfvbUpsellOffer**](SfvbApi.md#getsfvbupselloffer) | **GET** /sfvb/storefronts/{storefront_oid}/upsell_offers/{upsell_offer_oid} | Get an upsell offer
[**GetSfvbUpsellPath**](SfvbApi.md#getsfvbupsellpath) | **GET** /sfvb/storefronts/{storefront_oid}/upsell_paths/{upsell_path_oid} | Get an upsell path
[**GetSfvbVersion**](SfvbApi.md#getsfvbversion) | **GET** /sfvb/version | Compiler version for this merchant
[**GetSfvbWhoami**](SfvbApi.md#getsfvbwhoami) | **GET** /sfvb/whoami | Who this token is
[**IgnoreSfvbNotFoundEntry**](SfvbApi.md#ignoresfvbnotfoundentry) | **POST** /sfvb/storefronts/{storefront_oid}/not_found/{not_found_id}/ignore | Ignore a 404 path
[**ImportSfvbRedirects**](SfvbApi.md#importsfvbredirects) | **POST** /sfvb/storefronts/{storefront_oid}/redirects/import | Apply a reviewed redirect import
[**InsertSfvbApproval**](SfvbApi.md#insertsfvbapproval) | **POST** /sfvb/approvals | Request a human approval
[**InsertSfvbBlogPost**](SfvbApi.md#insertsfvbblogpost) | **POST** /sfvb/storefronts/{storefront_oid}/blog_posts | Create a blog post
[**InsertSfvbPage**](SfvbApi.md#insertsfvbpage) | **POST** /sfvb/storefronts/{storefront_oid}/pages | Create a page
[**InsertSfvbRedirect**](SfvbApi.md#insertsfvbredirect) | **POST** /sfvb/storefronts/{storefront_oid}/redirects | Create a 301 redirect rule
[**InsertSfvbUpsellOffer**](SfvbApi.md#insertsfvbupselloffer) | **POST** /sfvb/storefronts/{storefront_oid}/upsell_offers | Create an upsell offer
[**InsertSfvbUpsellPath**](SfvbApi.md#insertsfvbupsellpath) | **POST** /sfvb/storefronts/{storefront_oid}/upsell_paths | Create an upsell path
[**InstallSfvbLibraryEntry**](SfvbApi.md#installsfvblibraryentry) | **POST** /sfvb/storefronts/{storefront_oid}/library/{library_oid}/install | Install a library entry into a storefront
[**ListSfvbBlogPosts**](SfvbApi.md#listsfvbblogposts) | **GET** /sfvb/storefronts/{storefront_oid}/blog_posts | List the storefront&#39;s blog posts
[**ListSfvbContainerVersions**](SfvbApi.md#listsfvbcontainerversions) | **GET** /sfvb/storefronts/{storefront_oid}/container_versions | Version history for a container stored outside the file system
[**ListSfvbElements**](SfvbApi.md#listsfvbelements) | **GET** /sfvb/elements | List every SFVB element type
[**ListSfvbExperiments**](SfvbApi.md#listsfvbexperiments) | **GET** /sfvb/storefronts/{storefront_oid}/experiments | List the storefront&#39;s experiments
[**ListSfvbFileVersions**](SfvbApi.md#listsfvbfileversions) | **GET** /sfvb/storefronts/{storefront_oid}/files/versions | Version history for a storefront file
[**ListSfvbFiles**](SfvbApi.md#listsfvbfiles) | **GET** /sfvb/storefronts/{storefront_oid}/files | List a storefront directory
[**ListSfvbI18nMessages**](SfvbApi.md#listsfvbi18nmessages) | **GET** /sfvb/storefronts/{storefront_oid}/i18n/messages | List built-in messages
[**ListSfvbItemContainers**](SfvbApi.md#listsfvbitemcontainers) | **GET** /sfvb/storefronts/{storefront_oid}/item_containers | List the item containers on the account
[**ListSfvbLibraryInstalls**](SfvbApi.md#listsfvblibraryinstalls) | **GET** /sfvb/storefronts/{storefront_oid}/library/installs | List the library entries installed on a storefront
[**ListSfvbPages**](SfvbApi.md#listsfvbpages) | **GET** /sfvb/storefronts/{storefront_oid}/pages/list | List the storefront&#39;s pages
[**ListSfvbServerLogs**](SfvbApi.md#listsfvbserverlogs) | **GET** /sfvb/storefronts/{storefront_oid}/logs | List recent storefront render logs
[**ListSfvbStorefronts**](SfvbApi.md#listsfvbstorefronts) | **GET** /sfvb/storefronts | List storefronts
[**ListSfvbTemplates**](SfvbApi.md#listsfvbtemplates) | **GET** /sfvb/storefronts/{storefront_oid}/templates | List the active theme&#39;s templates
[**ListSfvbThemes**](SfvbApi.md#listsfvbthemes) | **GET** /sfvb/storefronts/{storefront_oid}/themes | List themes for a storefront
[**ListSfvbUpsellOffers**](SfvbApi.md#listsfvbupselloffers) | **GET** /sfvb/storefronts/{storefront_oid}/upsell_offers | List upsell offers
[**ListSfvbUpsellPaths**](SfvbApi.md#listsfvbupsellpaths) | **GET** /sfvb/storefronts/{storefront_oid}/upsell_paths | List upsell paths
[**MoveSfvbUpsellPath**](SfvbApi.md#movesfvbupsellpath) | **POST** /sfvb/storefronts/{storefront_oid}/upsell_paths/{upsell_path_oid}/move | Move an upsell path
[**PublishSfvbLibraryEntry**](SfvbApi.md#publishsfvblibraryentry) | **POST** /sfvb/storefronts/{storefront_oid}/library/{library_oid}/publish | Publish a library entry&#39;s draft
[**PutSfvbContainer**](SfvbApi.md#putsfvbcontainer) | **PUT** /sfvb/storefronts/{storefront_oid}/containers/{owner_type}/{owner_object_id} | Write a container stored outside the file system
[**PutSfvbExperimentVariation**](SfvbApi.md#putsfvbexperimentvariation) | **PUT** /sfvb/storefronts/{storefront_oid}/experiments/{experiment_oid}/variations/{variation_number} | Pause or resume a variation
[**PutSfvbFileContent**](SfvbApi.md#putsfvbfilecontent) | **PUT** /sfvb/storefronts/{storefront_oid}/files/content | Write a storefront file
[**PutSfvbI18nGlossary**](SfvbApi.md#putsfvbi18nglossary) | **PUT** /sfvb/storefronts/{storefront_oid}/i18n/glossary | Replace the storefront&#39;s translation glossary
[**PutSfvbI18nMessage**](SfvbApi.md#putsfvbi18nmessage) | **PUT** /sfvb/storefronts/{storefront_oid}/i18n/messages/{key} | Change one built-in message
[**PutSfvbItemAttributes**](SfvbApi.md#putsfvbitemattributes) | **PUT** /sfvb/storefronts/{storefront_oid}/items/attributes | Change some of an item&#39;s attributes
[**PutSfvbItemContent**](SfvbApi.md#putsfvbitemcontent) | **PUT** /sfvb/storefronts/{storefront_oid}/items/content | Change an item&#39;s title or long description
[**PutSfvbItemMultimedia**](SfvbApi.md#putsfvbitemmultimedia) | **PUT** /sfvb/storefronts/{storefront_oid}/items/multimedia | Attach an image to an item
[**PutSfvbItemSeo**](SfvbApi.md#putsfvbitemseo) | **PUT** /sfvb/storefronts/{storefront_oid}/items/seo | Change an item&#39;s search metadata
[**PutSfvbMenu**](SfvbApi.md#putsfvbmenu) | **PUT** /sfvb/storefronts/{storefront_oid}/menus/{code} | Replace a store menu&#39;s entries
[**PutSfvbPageAttributes**](SfvbApi.md#putsfvbpageattributes) | **PUT** /sfvb/storefronts/{storefront_oid}/pages/attributes | Change a page&#39;s attributes
[**PutSfvbPageMultimedia**](SfvbApi.md#putsfvbpagemultimedia) | **PUT** /sfvb/storefronts/{storefront_oid}/pages/multimedia | Attach an image to a page
[**PutSfvbPageSelectors**](SfvbApi.md#putsfvbpageselectors) | **PUT** /sfvb/storefronts/{storefront_oid}/pages/selectors | Replace a page&#39;s selectors
[**PutSfvbPageSettings**](SfvbApi.md#putsfvbpagesettings) | **PUT** /sfvb/storefronts/{storefront_oid}/pages/settings | Change a page&#39;s settings
[**PutSfvbPreviewSession**](SfvbApi.md#putsfvbpreviewsession) | **PUT** /sfvb/storefronts/{storefront_oid}/preview_sessions/{preview_session_id} | Push containers into a preview session
[**PutSfvbRecordingSettings**](SfvbApi.md#putsfvbrecordingsettings) | **PUT** /sfvb/storefronts/{storefront_oid}/recording_settings | Turn the storefront&#39;s screen recording on or off
[**PutSfvbSiteAttributes**](SfvbApi.md#putsfvbsiteattributes) | **PUT** /sfvb/storefronts/{storefront_oid}/attributes | Change a storefront&#39;s site attributes
[**PutSfvbThemeAttributes**](SfvbApi.md#putsfvbthemeattributes) | **PUT** /sfvb/storefronts/{storefront_oid}/themes/{theme_oid}/attributes | Change a theme&#39;s colors, fonts and settings
[**RefreshSfvbPage**](SfvbApi.md#refreshsfvbpage) | **POST** /sfvb/storefronts/{storefront_oid}/pages/refresh | Drop one page&#39;s cached copy
[**RemoveSfvbPageBlogPosts**](SfvbApi.md#removesfvbpageblogposts) | **POST** /sfvb/storefronts/{storefront_oid}/pages/blog_posts/remove | Take blog posts off a page
[**RemoveSfvbPageItems**](SfvbApi.md#removesfvbpageitems) | **POST** /sfvb/storefronts/{storefront_oid}/pages/items/remove | Take items off a page
[**RenderSfvbWidgets**](SfvbApi.md#rendersfvbwidgets) | **POST** /sfvb/storefronts/{storefront_oid}/themes/{theme_oid}/render | Render a CJSON node to HTML
[**ReserveSfvbWidgetIds**](SfvbApi.md#reservesfvbwidgetids) | **POST** /sfvb/storefronts/{storefront_oid}/widget_ids | Reserve a block of widget ids
[**ResetSfvbI18nMessage**](SfvbApi.md#resetsfvbi18nmessage) | **DELETE** /sfvb/storefronts/{storefront_oid}/i18n/messages/{key} | Reset one built-in message
[**ResolveSfvbRedirect**](SfvbApi.md#resolvesfvbredirect) | **GET** /sfvb/storefronts/{storefront_oid}/redirects/resolve | What a shopper gets for a path
[**ResolveSfvbTemplate**](SfvbApi.md#resolvesfvbtemplate) | **GET** /sfvb/storefronts/{storefront_oid}/templates/resolve | Resolve a template name to the file a page renders
[**RevertSfvbContainer**](SfvbApi.md#revertsfvbcontainer) | **POST** /sfvb/storefronts/{storefront_oid}/containers/{owner_type}/{owner_object_id}/revert | Revert a container stored outside the file system
[**RevertSfvbFile**](SfvbApi.md#revertsfvbfile) | **POST** /sfvb/storefronts/{storefront_oid}/files/revert | Revert a storefront file to an earlier version
[**SearchSfvbFiles**](SfvbApi.md#searchsfvbfiles) | **POST** /sfvb/storefronts/{storefront_oid}/files/search | Search storefront files
[**SearchSfvbLibrary**](SfvbApi.md#searchsfvblibrary) | **GET** /sfvb/storefronts/{storefront_oid}/library | Search the element library
[**SetSfvbLibraryScreenshot**](SfvbApi.md#setsfvblibraryscreenshot) | **PUT** /sfvb/storefronts/{storefront_oid}/library/{library_oid}/screenshot | Set a library entry&#39;s screenshot
[**ShareSfvbLibraryEntry**](SfvbApi.md#sharesfvblibraryentry) | **POST** /sfvb/storefronts/{storefront_oid}/library/{library_oid}/shares | Share a published library entry with a linked account
[**StartSfvbExperiment**](SfvbApi.md#startsfvbexperiment) | **POST** /sfvb/storefronts/{storefront_oid}/experiments | Start an experiment
[**UnarchiveSfvbUpsellPath**](SfvbApi.md#unarchivesfvbupsellpath) | **POST** /sfvb/storefronts/{storefront_oid}/upsell_paths/{upsell_path_oid}/unarchive | Unarchive an upsell path
[**UnfavoriteSfvbLibraryEntry**](SfvbApi.md#unfavoritesfvblibraryentry) | **DELETE** /sfvb/storefronts/{storefront_oid}/library/{library_oid}/favorite | Remove a library entry from favorites
[**UnignoreSfvbNotFoundEntry**](SfvbApi.md#unignoresfvbnotfoundentry) | **DELETE** /sfvb/storefronts/{storefront_oid}/not_found/{not_found_id}/ignore | Stop ignoring a 404 path
[**UnpublishSfvbLibraryEntry**](SfvbApi.md#unpublishsfvblibraryentry) | **POST** /sfvb/storefronts/{storefront_oid}/library/{library_oid}/unpublish | Narrow who can see a library entry
[**UnshareSfvbLibraryEntry**](SfvbApi.md#unsharesfvblibraryentry) | **DELETE** /sfvb/storefronts/{storefront_oid}/library/{library_oid}/shares/{merchant_id} | Stop sharing a library entry with an account
[**UpdateSfvbBlogPost**](SfvbApi.md#updatesfvbblogpost) | **PUT** /sfvb/storefronts/{storefront_oid}/blog_posts/{blog_post_oid} | Change a blog post
[**UpdateSfvbLibraryEntry**](SfvbApi.md#updatesfvblibraryentry) | **PUT** /sfvb/storefronts/{storefront_oid}/library/{library_oid} | Update a library entry&#39;s draft
[**UpdateSfvbRedirect**](SfvbApi.md#updatesfvbredirect) | **PUT** /sfvb/storefronts/{storefront_oid}/redirects/{redirect_id} | Change a redirect rule
[**UpdateSfvbUpsellOffer**](SfvbApi.md#updatesfvbupselloffer) | **PUT** /sfvb/storefronts/{storefront_oid}/upsell_offers/{upsell_offer_oid} | Update an upsell offer
[**UpdateSfvbUpsellPath**](SfvbApi.md#updatesfvbupsellpath) | **PUT** /sfvb/storefronts/{storefront_oid}/upsell_paths/{upsell_path_oid} | Update an upsell path
[**UploadSfvbFile**](SfvbApi.md#uploadsfvbfile) | **POST** /sfvb/storefronts/{storefront_oid}/files/upload | Store a binary asset that was already uploaded
[**ValidateSfvbCjson**](SfvbApi.md#validatesfvbcjson) | **POST** /sfvb/cjson/validate | Validate CJSON
[**ValidateSfvbVelocity**](SfvbApi.md#validatesfvbvelocity) | **POST** /sfvb/storefronts/{storefront_oid}/themes/{theme_oid}/velocity/validate | Validate a Velocity template against a theme



## AddSfvbPageBlogPosts

> SfvbPageBlogPostsResponse AddSfvbPageBlogPosts (int storefrontOid, string path, SfvbPageBlogPostsRequest pageBlogPostsRequest)

Assign blog posts to a page

Adds posts by blog_post_oid, at most 500 at a time.  Every oid must be a post on this storefront, and one that is not changes nothing.  Refused on a page whose selectors choose its blog posts.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /blog/ | 
 **pageBlogPostsRequest** | [**SfvbPageBlogPostsRequest**](SfvbPageBlogPostsRequest.md)| Blog posts to assign | 

### Return type

[**SfvbPageBlogPostsResponse**](SfvbPageBlogPostsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AddSfvbPageItems

> SfvbPageItemsResponse AddSfvbPageItems (int storefrontOid, string path, SfvbPageItemsAddRequest pageItemsAddRequest)

Assign items to a page

Adds items by item id, at most 500 at a time, or changes the sort order or url part of items already on the page.  Every id is checked first and one unknown id changes nothing.  Refused on a page whose selectors choose its items.  sort_order is refused unless the page sorts its items by a custom order.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /lp/spring-sale/ | 
 **pageItemsAddRequest** | [**SfvbPageItemsAddRequest**](SfvbPageItemsAddRequest.md)| Items to assign | 

### Return type

[**SfvbPageItemsResponse**](SfvbPageItemsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ArchiveSfvbUpsellPath

> SfvbUpsellPath ArchiveSfvbUpsellPath (int storefrontOid, int upsellPathOid)

Archive an upsell path

Files the path out of the default list.  An archived path does not run.  Archiving one that is switched on is a live change and needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **upsellPathOid** | **int**|  | 

### Return type

[**SfvbUpsellPath**](SfvbUpsellPath.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AttachSfvbBlogPostImage

> SfvbBlogPostDetail AttachSfvbBlogPostImage (int storefrontOid, int blogPostOid, SfvbBlogPostImageRequest blogPostImageRequest)

Attach an image to a blog post

Three calls, like the admin blog editor's upload.  Request an upload URL with files/upload_url, send the bytes to it, then attach with the key and a filename.  No storefront file is created, and the key is redeemed, so it cannot be used twice.  default_image replaces the post's default image and code replaces the image with that code; with neither, the image is added for use in the body at the url the response reports.  JPEG, PNG, GIF or WebP, checked by content.  A post that is not a draft needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **blogPostOid** | **int**|  | 
 **blogPostImageRequest** | [**SfvbBlogPostImageRequest**](SfvbBlogPostImageRequest.md)| Image to attach | 

### Return type

[**SfvbBlogPostDetail**](SfvbBlogPostDetail.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **413** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CheckSfvbRedirect

> SfvbRedirectCheckResponse CheckSfvbRedirect (int storefrontOid, SfvbRedirectRequest redirectRequest)

Check a redirect rule without creating it

Runs every check a create runs (loops, chains, duplicates, missing or external targets, system paths, live pages, the rule limit) and returns the findings.  Writes nothing. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **redirectRequest** | [**SfvbRedirectRequest**](SfvbRedirectRequest.md)| The request | 

### Return type

[**SfvbRedirectCheckResponse**](SfvbRedirectCheckResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ClearSfvbLibraryScreenshot

> SfvbLibraryEntry ClearSfvbLibraryScreenshot (int storefrontOid, int libraryOid, string ifMatch)

Remove a library entry's screenshot

Owner only, with the draft's hash_sha256 as If-Match.  Clears the screenshot and thumbnail.  Published revisions and copies that used the image keep it. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **libraryOid** | **int**|  | 
 **ifMatch** | **string**| hash_sha256 from the last read.  Required; 428 when absent, 412 when stale. | 

### Return type

[**SfvbLibraryEntry**](SfvbLibraryEntry.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **428** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CompileSfvbCjson

> SfvbCompileResponse CompileSfvbCjson (SfvbCompileRequest compileRequest)

Compile CJSON to Velocity

Compiles a container document to Velocity without storing anything.  Supply theme_oid to compile with the theme's inherit groups applied; omit it to compile standalone. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **compileRequest** | [**SfvbCompileRequest**](SfvbCompileRequest.md)| CJSON to compile | 

### Return type

[**SfvbCompileResponse**](SfvbCompileResponse.md)

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
| **413** |  |  -  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateSfvbLibraryEntry

> SfvbLibraryEntry CreateSfvbLibraryEntry (int storefrontOid, SfvbLibraryEntryRequest libraryEntry)

Save a fragment to the library

Creates a private draft owned by the calling user.  The fragment is one widget and its children, and it must validate.  Images it references on this storefront are copied into the entry before this returns, so it installs anywhere with its images.  The fragment is scanned; card skimming or obfuscation signals are refused outright.  Nothing other merchants or shoppers see changes, so sfvb_write is enough.  Publish it to share it.  An optional screenshot takes a staged PNG key, exactly as the library screenshot endpoint does; a refused screenshot refuses the whole create. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **libraryEntry** | [**SfvbLibraryEntryRequest**](SfvbLibraryEntryRequest.md)| The entry | 

### Return type

[**SfvbLibraryEntry**](SfvbLibraryEntry.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **413** |  |  -  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateSfvbPreviewAccess

> SfvbPreviewAccessResponse CreateSfvbPreviewAccess (int storefrontOid, SfvbPreviewAccessRequest previewAccess = null)

One time link that opens a preview in a browser with no UltraCart login

The preview URL only works in a browser already signed in to UltraCart on the storefront's own host, and an agent's built in browser never is.  This returns a single use access_url on the storefront host instead.  Opening it gets past the storefront lock, shows the requested theme and applies the requested preview session for the rest of that browser session, then redirects to path.  It expires two minutes after issue or on first use.  Pages opened afterwards carry an X-UltraCart-Preview header of applied or not-applied.  Requires a token that resolves to a user, so use the device authorization flow. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **previewAccess** | [**SfvbPreviewAccessRequest**](SfvbPreviewAccessRequest.md)| What the browser should see | [optional] 

### Return type

[**SfvbPreviewAccessResponse**](SfvbPreviewAccessResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateSfvbPreviewSession

> SfvbPreviewSessionResponse CreateSfvbPreviewSession (int storefrontOid)

Create a preview session

Returns a server generated session id to push containers into, and opens the session so that id exists rather than merely being random.  The id is not caller supplied, because concurrent agents choosing their own would be free to collide, and the browser editor's habit of minting one with Math.random is not a property worth carrying into an API.  Expires after eight hours and can be deleted sooner.  Requires a token that resolves to a user, so use the device authorization flow. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 

### Return type

[**SfvbPreviewSessionResponse**](SfvbPreviewSessionResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteSfvbApproval

> void DeleteSfvbApproval (string approvalId)

Cancel a pending approval request

Withdraws a request nobody has decided yet, which frees one of the five pending slots a sign-in has.  A request that was already decided, used or expired cannot be cancelled. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **approvalId** | **string**|  | 

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
| **204** | No Content |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteSfvbBlogPost

> void DeleteSfvbBlogPost (int storefrontOid, int blogPostOid, string approvalId = null)

Delete a blog post

Takes the post off every page and deletes it.  There is no undo.  A post that is not a draft needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **blogPostOid** | **int**|  | 
 **approvalId** | **string**| The approval_id of an approved blog_post.delete request for this post.  See POST /sfvb/approvals. | [optional] 

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
| **204** | No Content |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **409** |  |  -  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteSfvbFile

> void DeleteSfvbFile (int storefrontOid, string ifMatch, string path = null, string approvalId = null)

Delete a storefront file

Recoverable from the recycle bin. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **ifMatch** | **string**| Content hash of the file being deleted.  Required; 428 when absent, 412 when stale. | 
 **path** | **string**|  | [optional] 
 **approvalId** | **string**| The approval_id of an approved file.delete request for this exact path.  See POST /sfvb/approvals. | [optional] 

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **409** |  |  -  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **428** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteSfvbItemAttribute

> SfvbItemResponse DeleteSfvbItemAttribute (int storefrontOid, string name, string merchantItemId = null, int? merchantItemOid = null)

Delete an attribute from an item

Removes one attribute that no template on the item's pages declares - a test name, a misspelling, one a retired template used.  A declared attribute is refused, because the template would list it again, empty; send an empty value through the attributes update to clear one of those instead. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **name** | **string**| The attribute name, matched without regard to case | 
 **merchantItemId** | **string**|  | [optional] 
 **merchantItemOid** | **int?**|  | [optional] 

### Return type

[**SfvbItemResponse**](SfvbItemResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteSfvbItemMultimedia

> SfvbItemResponse DeleteSfvbItemMultimedia (int storefrontOid, string merchantItemId = null, int? merchantItemOid = null, string code = null, bool? _default = null)

Detach an image from an item

Removes the item's copy of the image in one slot.  The file you uploaded is left where it is, so the same source can be attached again or used elsewhere. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **merchantItemId** | **string**|  | [optional] 
 **merchantItemOid** | **int?**|  | [optional] 
 **code** | **string**| The image code to detach | [optional] 
 **_default** | **bool?**| Detach the default image instead of a coded one | [optional] 

### Return type

[**SfvbItemResponse**](SfvbItemResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteSfvbLibraryEntry

> SfvbLibraryDeleteResult DeleteSfvbLibraryEntry (int storefrontOid, int libraryOid, string ifMatch)

Delete or retire a library entry

Owner only, with the draft's hash_sha256 as If-Match.  An entry that was never published, installed or shared is deleted.  Anything else is retired - kept so the storefronts that installed it still resolve, but out of search and refusing new installs and publishes.  The result says which happened. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **libraryOid** | **int**|  | 
 **ifMatch** | **string**| hash_sha256 from the last read.  Required; 428 when absent, 412 when stale. | 

### Return type

[**SfvbLibraryDeleteResult**](SfvbLibraryDeleteResult.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **428** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteSfvbPageMultimedia

> SfvbPageResponse DeleteSfvbPageMultimedia (int storefrontOid, string path, string code = null, bool? _default = null)

Detach an image from a page

Name exactly one of code or default.  Removes the page's copy of the image; the source file in the page folder is left alone.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /catalog/dispensers/ | 
 **code** | **string**| Image code to detach | [optional] 
 **_default** | **bool?**| True to detach the default image | [optional] 

### Return type

[**SfvbPageResponse**](SfvbPageResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteSfvbPreviewSession

> void DeleteSfvbPreviewSession (int storefrontOid, string previewSessionId)

Delete a preview session

Releases the session before its eight hour expiry.  Without this the only way to free one is to wait, which is a poor answer for a tool that may open a dozen in an afternoon. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **previewSessionId** | **string**|  | 

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteSfvbRedirect

> void DeleteSfvbRedirect (int storefrontOid, int redirectId, string ifMatch)

Delete a redirect rule

Deletes one rule.  The source path answers again as it would without the rule.  Send the hash_sha256 you read as If-Match.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **redirectId** | **int**|  | 
 **ifMatch** | **string**| hash_sha256 from the last read.  428 when absent, 412 when stale. | 

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **428** |  |  -  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DetachSfvbBlogPostImage

> SfvbBlogPostDetail DetachSfvbBlogPostImage (int storefrontOid, int blogPostOid, SfvbBlogPostImageRequest blogPostImageRequest)

Detach an image from a blog post

Name exactly one of default_image, code or blog_post_multimedia_oid.  Removes the image from the post and deletes its stored copy.  Take it out of the body too, or the body keeps a broken image.  A post that is not a draft needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **blogPostOid** | **int**|  | 
 **blogPostImageRequest** | [**SfvbBlogPostImageRequest**](SfvbBlogPostImageRequest.md)| Image to detach | 

### Return type

[**SfvbBlogPostDetail**](SfvbBlogPostDetail.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DisableSfvbI18nLanguage

> SfvbI18nLanguagesResponse DisableSfvbI18nLanguage (int storefrontOid, string code, string ifMatch)

Disable a language

Stops serving a language.  Its hand and machine translations are kept and come back when it is enabled again.  The default language cannot be disabled.  Already disabled answers changed false.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **code** | **string**|  | 
 **ifMatch** | **string**| hash_sha256 from the last read.  Required; 428 when absent, 412 when stale. | 

### Return type

[**SfvbI18nLanguagesResponse**](SfvbI18nLanguagesResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **428** |  |  -  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DisableSfvbUpsellOffer

> SfvbUpsellOffer DisableSfvbUpsellOffer (int storefrontOid, int upsellOfferOid)

Disable an upsell offer

Switches the offer off.  Disabling one that is switched on is a live change and needs sfvb_publish.  An offer that is already off is returned unchanged.  There is no delete. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **upsellOfferOid** | **int**|  | 

### Return type

[**SfvbUpsellOffer**](SfvbUpsellOffer.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DisableSfvbUpsellPath

> SfvbUpsellPath DisableSfvbUpsellPath (int storefrontOid, int upsellPathOid)

Disable an upsell path

Switches the path off.  Disabling a running path is a live change and needs sfvb_publish.  A path that is already off is returned unchanged.  There is no delete. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **upsellPathOid** | **int**|  | 

### Return type

[**SfvbUpsellPath**](SfvbUpsellPath.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DownloadSfvbFile

> void DownloadSfvbFile (int storefrontOid, string path = null)

Read a storefront file's raw bytes

Returns the file itself rather than a JSON envelope, for any type including binaries that files/content refuses.  Use this to verify what you uploaded, and note it is the only way to read a file inside a theme that is not active - such a file is served to nobody until the theme is promoted, so it has no public URL to fetch instead.  On success the body is the file; on failure it is the usual JSON error object, so do not assume the content type without checking the status. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DryRunSfvbRedirectImport

> SfvbRedirectImportResponse DryRunSfvbRedirectImport (int storefrontOid, SfvbRedirectImportRequest redirectImportRequest)

Check a redirect import without writing it

Checks up to 5,000 rows against the existing rules and each other, and returns the findings per row with a plan_hash.  Writes nothing.  Rows are merged with the existing rules; nothing is ever deleted. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **redirectImportRequest** | [**SfvbRedirectImportRequest**](SfvbRedirectImportRequest.md)| The request | 

### Return type

[**SfvbRedirectImportResponse**](SfvbRedirectImportResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **409** |  |  -  |
| **413** |  |  -  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DuplicateSfvbLibraryEntry

> SfvbLibraryEntry DuplicateSfvbLibraryEntry (int storefrontOid, int libraryOid, string name = null)

Copy a library entry into a new private entry

The copy is owned by the calling user and private.  From an entry you own it copies the draft; from one shared with you it copies the published revision.  It is scanned on its own and inherits nothing but content, its images and its screenshot. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **libraryOid** | **int**|  | 
 **name** | **string**| Name for the copy.  Defaults to Copy of and the source name. | [optional] 

### Return type

[**SfvbLibraryEntry**](SfvbLibraryEntry.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DuplicateSfvbPage

> SfvbPageResponse DuplicateSfvbPage (int storefrontOid, SfvbPageDuplicateRequest pageDuplicateRequest)

Copy a page to a new path

Copies what the store admin's duplicate copies - settings, items, blog posts, permissions, attributes, selectors, images and the page folder with its body.  The copy goes to the path you choose, under any existing page, with the same path rules as creating a page, and a 409 with the code sfvb.page_exists when that path is taken.  The root page and pages with pages under them cannot be copied.  A page whose folder holds a started experiment is refused, because the copy would share the experiment - end it first.  Translated title and description text is not copied.  Always needs sfvb_publish, because the copy is live as soon as it exists. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **pageDuplicateRequest** | [**SfvbPageDuplicateRequest**](SfvbPageDuplicateRequest.md)| The page to copy and where | 

### Return type

[**SfvbPageResponse**](SfvbPageResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **201** |  |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DuplicateSfvbTheme

> SfvbThemeJobResponse DuplicateSfvbTheme (int storefrontOid, int themeOid, SfvbThemeDuplicateRequest duplicateRequest)

Duplicate a theme

Copies a theme into a new one and returns a job handle to poll.  Asynchronous, because copying a theme copies every file in it.  Needs sfvb_write rather than sfvb_publish, because the job explicitly does not activate what it creates, so the worst outcome of a mistaken call is a spare theme.  This is how you get somewhere safe to work - duplicate, edit the copy with an ordinary write scope, and let a human promote it. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **themeOid** | **int**|  | 
 **duplicateRequest** | [**SfvbThemeDuplicateRequest**](SfvbThemeDuplicateRequest.md)| Theme duplication details | 

### Return type

[**SfvbThemeJobResponse**](SfvbThemeJobResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DuplicateSfvbUpsellOffer

> SfvbUpsellOffer DuplicateSfvbUpsellOffer (int storefrontOid, int upsellOfferOid)

Duplicate an upsell offer

A copy named Copy of, switched off, with its own copy of the container.  Put it on a path with a path update to have it shown. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **upsellOfferOid** | **int**|  | 

### Return type

[**SfvbUpsellOffer**](SfvbUpsellOffer.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **201** |  |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DuplicateSfvbUpsellPath

> SfvbUpsellPath DuplicateSfvbUpsellPath (int storefrontOid, int upsellPathOid, SfvbUpsellPathDuplicateRequest duplicateRequest = null)

Duplicate an upsell path or one of its variations

Without a variation, copies the whole path right after it, switched off.  With a variation, appends a copy of that variation to the same path, which needs sfvb_publish when the path is running.  Every offer the copy uses is copied too and switched off.  Within this storefront only. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **upsellPathOid** | **int**|  | 
 **duplicateRequest** | [**SfvbUpsellPathDuplicateRequest**](SfvbUpsellPathDuplicateRequest.md)| What to duplicate | [optional] 

### Return type

[**SfvbUpsellPath**](SfvbUpsellPath.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **201** |  |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EnableSfvbI18nLanguage

> SfvbI18nLanguagesResponse EnableSfvbI18nLanguage (int storefrontOid, string code, string ifMatch, SfvbI18nLanguageEnableRequest languageEnableRequest)

Enable a language

Turns a language on.  It is served to shoppers and machine translated, which is billed per character, so acknowledge_cost must be true and the caller must be a person (device authorization).  Records the same billing note as the merchant admin.  Already enabled answers changed false.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **code** | **string**|  | 
 **ifMatch** | **string**| hash_sha256 from the last read.  Required; 428 when absent, 412 when stale. | 
 **languageEnableRequest** | [**SfvbI18nLanguageEnableRequest**](SfvbI18nLanguageEnableRequest.md)| The cost acknowledgement | 

### Return type

[**SfvbI18nLanguagesResponse**](SfvbI18nLanguagesResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **428** |  |  -  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EndSfvbExperiment

> SfvbExperiment EndSfvbExperiment (int storefrontOid, int experimentOid, SfvbExperimentEndRequest experimentEndRequest = null)

End an experiment

Ends a running experiment.  With winner_variation_number the winner gets every visitor, including visitors already assigned to another variation, and a page experiment's winning content is promoted into the page by the completion job on its next run, which also emails the merchant.  Without a winner a page experiment's id is cleared from its page body so the page shows variation 0, and a url experiment sends everyone to variation 0.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **experimentOid** | **int**|  | 
 **experimentEndRequest** | [**SfvbExperimentEndRequest**](SfvbExperimentEndRequest.md)| The winner, if any | [optional] 

### Return type

[**SfvbExperiment**](SfvbExperiment.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## FavoriteSfvbLibraryEntry

> void FavoriteSfvbLibraryEntry (int storefrontOid, int libraryOid)

Favorite a library entry

Bookmarks the entry for the calling user.  Idempotent.  Owner or anyone the entry is shared with. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **libraryOid** | **int**|  | 

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
| **204** | No Content |  -  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbApproval

> SfvbApproval GetSfvbApproval (string approvalId)

Read one approval request

Poll this every interval_seconds after requesting an approval.  status is pending until the person decides, then approved or denied, and expired if nobody acts in 10 minutes.  Once the gated call has used it, status is used and outcome says whether the call succeeded.  Used with no outcome means the result is unknown, so check the target - never repeat the call. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **approvalId** | **string**|  | 

### Return type

[**SfvbApproval**](SfvbApproval.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbApprovals

> SfvbApprovalsResponse GetSfvbApprovals ()

List this sign-in's approval requests

Requests made with this sign-in in the last 24 hours, newest first, at most 50, with their status and outcome.  Use it to find a request whose id was lost, or to see what an earlier run did. 


### Example


(No example for this operation).


### Parameters

This endpoint does not need any parameter.

### Return type

[**SfvbApprovalsResponse**](SfvbApprovalsResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbBlogPost

> SfvbBlogPostDetail GetSfvbBlogPost (int storefrontOid, int blogPostOid)

Read a blog post

The whole post - body, excerpt, tags, images and where it is shown.  An image's url is the address to use for it in the body. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **blogPostOid** | **int**|  | 

### Return type

[**SfvbBlogPostDetail**](SfvbBlogPostDetail.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbCjsonUsedElements

> SfvbElementsResponse GetSfvbCjsonUsedElements (SfvbCompileRequest compileRequest)

Element types used by a container


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **compileRequest** | [**SfvbCompileRequest**](SfvbCompileRequest.md)| CJSON to inspect | 

### Return type

[**SfvbElementsResponse**](SfvbElementsResponse.md)

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
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbContainer

> SfvbContainerResponse GetSfvbContainer (int storefrontOid, string ownerType, string ownerObjectId, string containerName = null)

Read a container stored outside the file system

owner_type is one of upsell, email, postcardfront, postcardback, item or itemid.  It also says how owner_object_id is read - item and upsell take an oid, itemid takes a merchant item id, and the rest take an esp uuid.  itemid reaches the same containers as item and is the way to address one from a storefront, where data-context-item-id carries the merchant item id and the oid appears nowhere.  Item containers also require container_name.  Theme and page containers are files; read those through files/content. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **ownerType** | **string**|  | 
 **ownerObjectId** | **string**|  | 
 **containerName** | **string**|  | [optional] 

### Return type

[**SfvbContainerResponse**](SfvbContainerResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbContainerVersion

> SfvbContainerVersion GetSfvbContainerVersion (int storefrontOid, int containerHistoryOid, string ownerType = null, string ownerObjectId = null, string containerName = null)

Read the CJSON stored in one container history entry

Inspect or diff an earlier version without reverting to it.  The version is addressed through the container that owns it, so a history oid belonging to some other resource cannot be read through this route.  owner_type also says how owner_object_id is read, and itemid addresses an item container by merchant item id. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **containerHistoryOid** | **int**|  | 
 **ownerType** | **string**|  | [optional] 
 **ownerObjectId** | **string**|  | [optional] 
 **containerName** | **string**|  | [optional] 

### Return type

[**SfvbContainerVersion**](SfvbContainerVersion.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbElement

> SfvbElementSchemaResponse GetSfvbElement (string elementType)

Configuration schema and field card for one element type

schema is the draft-07 JSON schema for the element config object and doc is the markdown field card, both as strings.  Either is omitted when none has been published for the element, which is still a 200.  The catalog is published by the visual builder release process, and a republish can take up to an hour to appear here. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **elementType** | **string**|  | 

### Return type

[**SfvbElementSchemaResponse**](SfvbElementSchemaResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbExperiment

> SfvbExperiment GetSfvbExperiment (int storefrontOid, int experimentOid, bool? daily = null)

Read one experiment and its statistics

The experiment, its variations and their statistics, and with daily=true each variation's daily rows.  p95_sessions_needed is estimated only after 1000 sessions, and sessions_needed_computed_dts says when.  For a url experiment, router_url is the address visitors must enter through. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **experimentOid** | **int**|  | 
 **daily** | **bool?**| Include each variation&#39;s daily statistics | [optional] 

### Return type

[**SfvbExperiment**](SfvbExperiment.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbExperimentObjectives

> SfvbExperimentObjectivesResponse GetSfvbExperimentObjectives (int storefrontOid)

List the objectives an experiment can optimize

Each objective with what is measured per session and compared between variations, the usual optimization type, and whether it needs an event name. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 

### Return type

[**SfvbExperimentObjectivesResponse**](SfvbExperimentObjectivesResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbFileContent

> SfvbFileContentResponse GetSfvbFileContent (int storefrontOid, string path = null, int? version = null)

Read a storefront file

Returns the current content, or an earlier version when version is supplied.  Send the body's hash_sha256 back as If-Match when writing.  The ETag header carries the same hash, but a compressing proxy may append a suffix such as -gzip to it, so prefer the body value. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**|  | [optional] 
 **version** | **int?**|  | [optional] 

### Return type

[**SfvbFileContentResponse**](SfvbFileContentResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **413** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbFileUploadUrl

> SfvbFileUploadUrlResponse GetSfvbFileUploadUrl (int storefrontOid, string extension)

Get a URL to upload a binary asset to

Binary content does not travel through this API as JSON, so uploading an image, font, video or PDF is two steps.  Ask here for a URL, PUT the raw bytes straight to it, then call uploadSfvbFile quoting the key you were given.  The bytes never pass through the API server.  The extension is checked against the accepted type list before a URL is issued, so an unsupported type fails here rather than after you have sent the file.  The URL is short lived and the key is bound to your account. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **extension** | **string**|  | 

### Return type

[**SfvbFileUploadUrlResponse**](SfvbFileUploadUrlResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbI18nGlossary

> SfvbI18nGlossary GetSfvbI18nGlossary (int storefrontOid)

Read the storefront's translation glossary

The storefront's glossary, plain markdown with terms not to translate, required translations, tone and words to avoid.  Read it before translating anything.  Empty when none has been saved.  Each storefront has its own, because a storefront is often its own brand. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 

### Return type

[**SfvbI18nGlossary**](SfvbI18nGlossary.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbI18nLanguages

> SfvbI18nLanguagesResponse GetSfvbI18nLanguages (int storefrontOid)

List a storefront's languages

Every language the storefront can be translated into, with UltraCart's three-letter code (ESP for Spanish), the other spellings accepted, whether it is enabled, the default and right to left.  Language maps in CJSON and render take the code.  English is the source of every string.  Also gives the machine translation estimate for one more language, and the hash_sha256 an enable or disable sends back. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 

### Return type

[**SfvbI18nLanguagesResponse**](SfvbI18nLanguagesResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbI18nMachineTranslations

> SfvbI18nMachineTranslationsResponse GetSfvbI18nMachineTranslations (int storefrontOid, int? themeOid = null, string widgetId = null, string property = null)

Read where a widget setting's translations come from

For one multilingual widget setting, named by widget_id and property on a theme (the active theme unless theme_oid is given), each enabled language's text and whether a shopper sees a hand translation from the language map, a machine translation, one still queued (pending) or none yet.  The setting is registered when its container is saved.  Nothing is generated by reading it. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **themeOid** | **int?**|  | [optional] 
 **widgetId** | **string**|  | [optional] 
 **property** | **string**|  | [optional] 

### Return type

[**SfvbI18nMachineTranslationsResponse**](SfvbI18nMachineTranslationsResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbI18nMessage

> SfvbI18nMessage GetSfvbI18nMessage (int storefrontOid, string key, int? themeOid = null)

Read one built-in message

One message by key, with the hash_sha256 a set or reset sends back. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **key** | **string**|  | 
 **themeOid** | **int?**|  | [optional] 

### Return type

[**SfvbI18nMessage**](SfvbI18nMessage.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbI18nMessageMachineTranslations

> SfvbI18nMachineTranslationsResponse GetSfvbI18nMessageMachineTranslations (int storefrontOid, string key, int? themeOid = null)

Read where a message's translations come from

For one message, each enabled language's text and whether a shopper sees a hand translation, a machine translation, one still queued (pending) or none yet.  Nothing is generated by reading it. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **key** | **string**|  | 
 **themeOid** | **int?**|  | [optional] 

### Return type

[**SfvbI18nMachineTranslationsResponse**](SfvbI18nMachineTranslationsResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbItem

> SfvbItemResponse GetSfvbItem (int storefrontOid, string merchantItemId = null, int? merchantItemOid = null)

Read an item's storefront facing content

The attributes, images, title, description and search metadata a StoreFront element can render, reconciled against the templates behind the pages this item sits on.  An attribute a template declares but nothing has set comes back present with an empty value, which is how you discover what the page is asking for.  Pricing, shipping, inventory, tax, variants and kit structure are not here because no element reads them; use the item API for those.  Address by merchant_item_id, the value data-context-item-id carries, or by merchant_item_oid. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **merchantItemId** | **string**| The merchant item id, as a storefront carries it | [optional] 
 **merchantItemOid** | **int?**| The item oid.  Send this or merchant_item_id, not both | [optional] 

### Return type

[**SfvbItemResponse**](SfvbItemResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbLibraryEntry

> SfvbLibraryEntry GetSfvbLibraryEntry (int storefrontOid, int libraryOid, int? revisionNumber = null)

Read one library entry including its CJSON

The owner gets the draft with its hash_sha256, which an update, delete or publish sends back as If-Match.  Everyone else gets the latest published revision.  Pin a published revision with revision_number.  Read content_manifest before installing.  If the fragment references images or other storefront files those paths will not resolve on this storefront until the entry is installed, so use install rather than this when the intent is to place the fragment. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **libraryOid** | **int**|  | 
 **revisionNumber** | **int?**| A published revision to read instead of the default. | [optional] 

### Return type

[**SfvbLibraryEntry**](SfvbLibraryEntry.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbLibraryHistory

> SfvbLibraryHistoryResponse GetSfvbLibraryHistory (int storefrontOid, int libraryOid)

List a library entry's published revisions

Newest first, each with its release notes and hash.  Read one with getSfvbLibraryEntry and revision_number.  The owner and anyone the entry is shared with can list it. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **libraryOid** | **int**|  | 

### Return type

[**SfvbLibraryHistoryResponse**](SfvbLibraryHistoryResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbLibraryShareTargets

> SfvbLibraryShareTargetsResponse GetSfvbLibraryShareTargets (int storefrontOid)

List the accounts a library entry can be shared with

The calling account's linked accounts, each with its merchant id and company.  These are the only merchants a share can name. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 

### Return type

[**SfvbLibraryShareTargetsResponse**](SfvbLibraryShareTargetsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbLibraryTaxonomy

> SfvbLibraryTaxonomyCatalog GetSfvbLibraryTaxonomy (int storefrontOid)

List the allowed library tags

The fixed tag list for purpose, section, industry and style, each tag with a one line description.  Saving an entry refuses any tag not on it with sfvb.library_taxonomy_unknown, naming the closest one.  The same tags are the facet_purpose, facet_section, facet_industry and facet_style search facets. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 

### Return type

[**SfvbLibraryTaxonomyCatalog**](SfvbLibraryTaxonomyCatalog.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbMenu

> SfvbMenu GetSfvbMenu (int storefrontOid, string code)

Read one store menu and its entries

The whole tree, in render order.  Page entries carry the page_path they resolve to and item entries the merchant_item_id, rather than the oids the storage keeps.  Menu item oids are not returned at all because a write regenerates every one of them.  Keep hash_sha256 - it is the If-Match a write needs. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **code** | **string**| Menu code, matched without regard to case | 

### Return type

[**SfvbMenu**](SfvbMenu.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbMenus

> SfvbMenusResponse GetSfvbMenus (int storefrontOid)

List a storefront's store menus

The menus a menu element's menuName can name, sorted by code and without their entries.  A code the active theme's templates ask for but nothing has created is included with unconfigured true - that code renders an empty list today, and writing it creates it.  A menu no template names is marked undeclared, which usually means a menuName is misspelled. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 

### Return type

[**SfvbMenusResponse**](SfvbMenusResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbNotFound

> SfvbNotFoundResponse GetSfvbNotFound (int storefrontOid, string since = null, string sort = null, bool? includeBots = null, bool? includeTokens = null, string q = null, int? limit = null)

List the paths that answered 404

The paths shoppers asked for that answered 404, most hits first or by last_seen.  Paths only, never query strings.  Bots are left out unless include_bots.  Token-like path segments show as {token} unless include_tokens.  limit is 1 to 100, default 50. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **since** | **string**|  | [optional] 
 **sort** | **string**|  | [optional] 
 **includeBots** | **bool?**|  | [optional] 
 **includeTokens** | **bool?**|  | [optional] 
 **q** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**SfvbNotFoundResponse**](SfvbNotFoundResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbNotFoundEntry

> SfvbNotFoundEntryResponse GetSfvbNotFoundEntry (int storefrontOid, string notFoundId, bool? includeTokens = null)

Read one 404 path with its recent hits

One entry with up to 100 recent hits, each with its time, the linking host, the user agent and whether it was a bot.  Client IP addresses are never returned. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **notFoundId** | **string**|  | 
 **includeTokens** | **bool?**|  | [optional] 

### Return type

[**SfvbNotFoundEntryResponse**](SfvbNotFoundEntryResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbNotFoundPage

> SfvbNotFoundPage GetSfvbNotFoundPage (int storefrontOid)

What renders the storefront's 404 page

The site_404.vm the active theme renders for a 404, found the way the storefront finds it, and whether it exists.  Without it the storefront serves a plain fallback.  Edit it with the file endpoints. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 

### Return type

[**SfvbNotFoundPage**](SfvbNotFoundPage.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbPage

> SfvbPageResponse GetSfvbPage (int storefrontOid, string path)

Read a page's attributes and images

What the pageattribute and pageimage elements render for this page.  These are not in any file, which is why a page folder can be empty and its elements still render something.  Attributes and image codes a template declares but nothing has set are included, so the response describes what the page can show rather than only what has been saved. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /catalog/dispensers/ | 

### Return type

[**SfvbPageResponse**](SfvbPageResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbPageBlogPosts

> SfvbPageBlogPostsResponse GetSfvbPageBlogPosts (int storefrontOid, string path)

Read the blog posts assigned to a page

The posts the page shows.  uses_selectors is true when the page's blog post selectors choose them instead. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /blog/ | 

### Return type

[**SfvbPageBlogPostsResponse**](SfvbPageBlogPostsResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbPageItems

> SfvbPageItemsResponse GetSfvbPageItems (int storefrontOid, string path)

Read the items assigned to a page

The items on the page with their sort order and url part.  uses_selectors is true when the page's selectors choose its items instead. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /lp/spring-sale/ | 

### Return type

[**SfvbPageItemsResponse**](SfvbPageItemsResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbPageSelectors

> SfvbPageSelectors GetSfvbPageSelectors (int storefrontOid, string path)

Read a page's selectors

The conditions that choose the page's items and blog posts, and whether each set must all match. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /lp/spring-sale/ | 

### Return type

[**SfvbPageSelectors**](SfvbPageSelectors.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbPreviewUrl

> SfvbPreviewUrlResponse GetSfvbPreviewUrl (int storefrontOid, string previewSessionId, string path = null)

URL that renders a preview session

Refuses a session that does not exist, so a URL you receive is for a session that was really there.  expires_in_seconds is the time actually remaining, not the configured lifetime.  Needs a token that resolves to a user, because a preview session belongs to the person who created it. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **previewSessionId** | **string**|  | 
 **path** | **string**|  | [optional] 

### Return type

[**SfvbPreviewUrlResponse**](SfvbPreviewUrlResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbRecording

> SfvbRecordingResponse GetSfvbRecording (int storefrontOid, string screenRecordingUuid)

Get a screen recording

One recorded visitor session and its page views, with each page view's named events such as rage clicks, script errors and checkout errors, but without the replay data.  Fetch a page view's replay events separately.  Find recordings to look at from the heatmaps or the analytics warehouse.  The visitor's email, IP address and visitor id are not returned, nor what they typed into form fields.  Reading a recording does not mark it watched. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **screenRecordingUuid** | **string**|  | 

### Return type

[**SfvbRecordingResponse**](SfvbRecordingResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbRecordingPageViewEvents

> SfvbRecordingEventsResponse GetSfvbRecordingPageViewEvents (int storefrontOid, string screenRecordingUuid, string screenRecordingPageViewUuid)

Get one recorded page view's replay events

The rrweb events for one page view, as a JSON array in a string, for replaying on the caller's own machine.  Card fields are masked by the recorder, but other text the visitor typed can appear.  Limited per account to 30 page views a minute, 300 an hour and 1000 a day.  Reading the events does not mark the recording watched. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **screenRecordingUuid** | **string**|  | 
 **screenRecordingPageViewUuid** | **string**|  | 

### Return type

[**SfvbRecordingEventsResponse**](SfvbRecordingEventsResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbRecordingSettings

> SfvbRecordingSettingsResponse GetSfvbRecordingSettings (int storefrontOid)

Get the storefront's screen recording settings

Whether real shoppers' sessions on this storefront are being recorded, what recording costs per 1,000 sessions after the 14 day free trial, how long recordings are kept, and how many sessions were recorded in the current and last billing periods.  Recording only collects from the moment it is turned on, so when it is on but was turned on recently, check the analytics warehouse for rows before reporting that there is no data. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 

### Return type

[**SfvbRecordingSettingsResponse**](SfvbRecordingSettingsResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbRedirect

> SfvbRedirect GetSfvbRedirect (int storefrontOid, int redirectId)

Read one redirect rule

One rule, with the hash_sha256 to send as If-Match when updating or deleting it. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **redirectId** | **int**|  | 

### Return type

[**SfvbRedirect**](SfvbRedirect.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbRedirects

> SfvbRedirectsResponse GetSfvbRedirects (int storefrontOid, string q = null, string type = null, string status = null)

List the storefront's redirect rules

Every redirect rule, exact and pattern.  Filter with q (searches source, target and note), type (exact or pattern) and status (301, 302 or rewrite).  count and limit say how close the storefront is to its rule limit. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **q** | **string**|  | [optional] 
 **type** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 

### Return type

[**SfvbRedirectsResponse**](SfvbRedirectsResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbServerLog

> SfvbServerLogDetail GetSfvbServerLog (int storefrontOid, string logId, string minLevel = null)

Get one storefront render log

One render's server log with its lines, each with a level, a category such as VELOCITY or FLOW, and the message.  log_id comes from the list, or from the X-UltraCart-Storefront-Log-Id header a page sends inside an SFVB preview session.  min_level is debug, info, warn or error, default debug. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **logId** | **string**|  | 
 **minLevel** | **string**|  | [optional] 

### Return type

[**SfvbServerLogDetail**](SfvbServerLogDetail.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbSiteAttributes

> SfvbSiteAttributesResponse GetSfvbSiteAttributes (int storefrontOid)

Read a storefront's site attributes

The values the siteattribute element and $site.attr render.  These are not in any file or theme.  Attributes a template declares but nothing has set are included with the template's default, so the response describes what the templates can render rather than only what has been saved.  Credentials stored as site attributes are never included. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 

### Return type

[**SfvbSiteAttributesResponse**](SfvbSiteAttributesResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbTestOrders

> SfvbTestOrdersResponse GetSfvbTestOrders (int storefrontOid, int? limit = null, bool? digitalItems = null, bool? autoOrder = null)

List recent test orders

Test orders on this account only, newest first, with no customer details, so an agent can render the order pages (receipt, order tracking, digital downloads, auto order pages) with one.  Use an order_id as a render's context_order_id; a real customer's order is refused there.  The last 7 days are searched, widening to 30 and then 90 until enough are found.  digital_items and auto_order keep only orders with downloads or an auto order.  limit is 1 to 25, default 10. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **limit** | **int?**|  | [optional] 
 **digitalItems** | **bool?**|  | [optional] 
 **autoOrder** | **bool?**|  | [optional] 

### Return type

[**SfvbTestOrdersResponse**](SfvbTestOrdersResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbTheme

> SfvbTheme GetSfvbTheme (int storefrontOid, int themeOid)

Get a theme


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **themeOid** | **int**|  | 

### Return type

[**SfvbTheme**](SfvbTheme.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbThemeAttributes

> SfvbThemeAttributesResponse GetSfvbThemeAttributes (int storefrontOid, int themeOid)

Read a theme's colors, fonts and settings

The values theme.css and the compiled containers resolve at render time.  These do NOT live in any file.  settings.json contains a palette and looks like the answer, but it is the theme's factory template - it supplies defaults for slots that have never been set and is ignored for slots that have, so editing it will not change a color and reading it will not tell you the current one.  Slots a template declares but nothing has ever set are included here, carrying the default they will render with, so the response describes the whole theme rather than the rows that happen to exist. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **themeOid** | **int**|  | 

### Return type

[**SfvbThemeAttributesResponse**](SfvbThemeAttributesResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbThemeJob

> SfvbThemeJobResponse GetSfvbThemeJob (int storefrontOid, int jobId)

Status of an asynchronous theme job

Poll until complete is true, then check success.  Note that the new theme's oid is not returned.  The job's product is a plain text report rather than a structured result, so once it completes, list themes and match on the target_path the start call gave you. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **jobId** | **int**|  | 

### Return type

[**SfvbThemeJobResponse**](SfvbThemeJobResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbUpsellOffer

> SfvbUpsellOffer GetSfvbUpsellOffer (int storefrontOid, int upsellOfferOid, bool? stats = null, string statsStart = null, string statsEnd = null, string statsWeekdays = null)

Get an upsell offer

The whole offer, with the hash an update sends back in If-Match, which upsell items are out of stock now, and whether loyalty, TowerData and Everflow are set up.  Stats as on the path list. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **upsellOfferOid** | **int**|  | 
 **stats** | **bool?**| Include stats | [optional] 
 **statsStart** | **string**| Stats window start, YYYY-MM-DD | [optional] 
 **statsEnd** | **string**| Stats window end, YYYY-MM-DD | [optional] 
 **statsWeekdays** | **string**| Only these weekdays, comma separated mon to sun | [optional] 

### Return type

[**SfvbUpsellOffer**](SfvbUpsellOffer.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbUpsellPath

> SfvbUpsellPath GetSfvbUpsellPath (int storefrontOid, int upsellPathOid, bool? stats = null, string statsStart = null, string statsEnd = null, string statsWeekdays = null)

Get an upsell path

The whole path, with the hash an update sends back in If-Match.  Stats as on the list. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **upsellPathOid** | **int**|  | 
 **stats** | **bool?**| Include stats | [optional] 
 **statsStart** | **string**| Stats window start, YYYY-MM-DD | [optional] 
 **statsEnd** | **string**| Stats window end, YYYY-MM-DD | [optional] 
 **statsWeekdays** | **string**| Only these weekdays, comma separated mon to sun | [optional] 

### Return type

[**SfvbUpsellPath**](SfvbUpsellPath.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbVersion

> SfvbVersionResponse GetSfvbVersion ()

Compiler version for this merchant

The visual builder release channel is per merchant, so a CLI holding cached schema or element data should compare against this to know when it has gone stale. 


### Example


(No example for this operation).


### Parameters

This endpoint does not need any parameter.

### Return type

[**SfvbVersionResponse**](SfvbVersionResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSfvbWhoami

> SfvbWhoamiResponse GetSfvbWhoami ()

Who this token is

Returns the merchant, user, granted scopes and reachable storefronts for the calling token.  Declared for any scope so an application can always discover which account it is connected to. 


### Example


(No example for this operation).


### Parameters

This endpoint does not need any parameter.

### Return type

[**SfvbWhoamiResponse**](SfvbWhoamiResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **410** | Status Code 410: Your authorized application has been disabled by UltraCart |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IgnoreSfvbNotFoundEntry

> SfvbNotFoundEntry IgnoreSfvbNotFoundEntry (int storefrontOid, string notFoundId)

Ignore a 404 path

Hides one path from the list and stops counting its hits, for example scanner noise.  Reversible. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **notFoundId** | **string**|  | 

### Return type

[**SfvbNotFoundEntry**](SfvbNotFoundEntry.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ImportSfvbRedirects

> SfvbRedirectImportResponse ImportSfvbRedirects (int storefrontOid, SfvbRedirectImportRequest redirectImportRequest)

Apply a reviewed redirect import

Applies exactly the rows of a dry run, given its plan_hash, in one transaction.  Refused with 412 when the rows or the storefront's rules changed since the dry run, and refused when any row has a blocking finding.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **redirectImportRequest** | [**SfvbRedirectImportRequest**](SfvbRedirectImportRequest.md)| The request | 

### Return type

[**SfvbRedirectImportResponse**](SfvbRedirectImportResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **409** |  |  -  |
| **412** |  |  -  |
| **413** |  |  -  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InsertSfvbApproval

> SfvbApproval InsertSfvbApproval (SfvbApprovalCreateRequest approvalRequest, int? storefrontOid = null)

Request a human approval

Asks the person who signed in the CLI to approve one gated action on one exact target.  Name the storefront with the storefront_oid query parameter.  The target is checked the way the action will check it, so nobody is asked to approve a call that would fail.  Show the person approval_url and user_code, poll GET approvals/{approval_id} every interval_seconds, and once it is approved repeat the gated call with the approval_id in the Approval-Id header.  Asking again for the same thing returns the pending request (200) rather than a new one (201).  A request lapses after 10 minutes.  Requires a token that resolves to a user, so use the device authorization flow. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **approvalRequest** | [**SfvbApprovalCreateRequest**](SfvbApprovalCreateRequest.md)| The request | 
 **storefrontOid** | **int?**| The storefront the action runs on.  Required for storefront actions, left out for account-wide ones. | [optional] 

### Return type

[**SfvbApproval**](SfvbApproval.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **201** |  |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InsertSfvbBlogPost

> SfvbBlogPostDetail InsertSfvbBlogPost (int storefrontOid, SfvbBlogPostRequest blogPostRequest)

Create a blog post

title and url_part are required.  The post is a draft unless visibility says otherwise, and anything but a draft needs sfvb_publish.  The body and excerpt are refused with sfvb.unsafe_html if they could run script, and a url_part another post uses is refused with a 409 and sfvb.blog_post_exists.  Assign the post to a page with pages/blog_posts/add, or let the page's selectors choose it. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **blogPostRequest** | [**SfvbBlogPostRequest**](SfvbBlogPostRequest.md)| The blog post to create | 

### Return type

[**SfvbBlogPostDetail**](SfvbBlogPostDetail.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **201** |  |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InsertSfvbPage

> SfvbPageResponse InsertSfvbPage (int storefrontOid, SfvbPageCreateRequest pageCreateRequest)

Create a page

Creates the page and its folder, the way the store admin's add page does.  The parent page must already exist, and the last part of the path may only contain letters, digits, hyphens and underscores - it is refused, not cleaned.  A path that already has a page is refused with a 409 and the code sfvb.page_exists.  Without a group_template the page inherits its parent's templates, or catalog_group.vm directly under the root.  Set attributes and images afterwards with the page attribute and image endpoints, and push the body to the page folder.  Always needs sfvb_publish, because the page is live as soon as it exists.  Deleting, moving and renaming pages stay in the store admin. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **pageCreateRequest** | [**SfvbPageCreateRequest**](SfvbPageCreateRequest.md)| The page to create | 

### Return type

[**SfvbPageResponse**](SfvbPageResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **201** |  |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InsertSfvbRedirect

> SfvbRedirectResponse InsertSfvbRedirect (int storefrontOid, SfvbRedirectRequest redirectRequest)

Create a 301 redirect rule

Creates one permanent (301) redirect, live for shoppers at once.  Refused for a loop, a chain longer than the storefront follows, a duplicate source, a target that is missing or on another site, a system path, a live page (unless over_live_page) and a full storefront.  A chain is allowed with a warning naming the final target.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **redirectRequest** | [**SfvbRedirectRequest**](SfvbRedirectRequest.md)| The request | 

### Return type

[**SfvbRedirectResponse**](SfvbRedirectResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **409** |  |  -  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InsertSfvbUpsellOffer

> SfvbUpsellOffer InsertSfvbUpsellOffer (int storefrontOid, SfvbUpsellOffer upsellOffer)

Create an upsell offer

Every item it names must exist, and every shipping method, payment method and loyalty tier must be one the merchant has.  Put it on a path with a path update to have it shown.  Creating it switched on, or with upsell_item_id_javascript or offsite_content_url, needs sfvb_publish.  Its page content is its container, written with the container endpoints and owner type upsell. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **upsellOffer** | [**SfvbUpsellOffer**](SfvbUpsellOffer.md)| The offer to create | 

### Return type

[**SfvbUpsellOffer**](SfvbUpsellOffer.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **201** |  |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InsertSfvbUpsellPath

> SfvbUpsellPath InsertSfvbUpsellPath (int storefrontOid, SfvbUpsellPath upsellPath)

Create an upsell path

Placed last in path order.  Every offer a step names must be an offer of this storefront, and every item in the item logic must exist.  Creating it switched on needs sfvb_publish; create it with active false to build it without that scope. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **upsellPath** | [**SfvbUpsellPath**](SfvbUpsellPath.md)| The path to create | 

### Return type

[**SfvbUpsellPath**](SfvbUpsellPath.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **201** |  |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InstallSfvbLibraryEntry

> SfvbLibraryInstallReceipt InstallSfvbLibraryEntry (int storefrontOid, int libraryOid, SfvbLibraryInstallRequest installRequest = null)

Install a library entry into a storefront

Copies the fragment's referenced files into the storefront file system and returns a receipt with the CJSON's paths resolved, ready to place.  It never places the CJSON.  Read content_manifest first; executable content needs acknowledge_executable true.  A file that already exists with different content is a conflict - on_conflict fail (the default) refuses with 409 and writes nothing, skip keeps the existing file, overwrite replaces it.  A recipient installs a published revision.  This writes, which is why it is a POST, and it requires sfvb_publish because the files land in the shared storefront file system, which is served to shoppers whichever theme is active. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **libraryOid** | **int**|  | 
 **installRequest** | [**SfvbLibraryInstallRequest**](SfvbLibraryInstallRequest.md)| Revision, conflict handling and acknowledgement | [optional] 

### Return type

[**SfvbLibraryInstallReceipt**](SfvbLibraryInstallReceipt.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbBlogPosts

> SfvbBlogPostsResponse ListSfvbBlogPosts (int storefrontOid, string search = null, int? page = null, int? pageSize = null)

List the storefront's blog posts

One page of blog posts, newest first, without their bodies.  search matches the title, body, excerpt, url part or author, or a tag exactly.  unassigned marks posts no page shows yet.  Use a post's blog_post_oid to assign it to a page. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **search** | **string**| Text to search for | [optional] 
 **page** | **int?**| Page number, starting at 1 | [optional] 
 **pageSize** | **int?**| Posts per page, 1 to 100, default 50 | [optional] 

### Return type

[**SfvbBlogPostsResponse**](SfvbBlogPostsResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbContainerVersions

> SfvbContainerVersionsResponse ListSfvbContainerVersions (int storefrontOid, string ownerType = null, string ownerObjectId = null, string containerName = null)

Version history for a container stored outside the file system

Addressed the same way as the container itself, so owner_type also says how owner_object_id is read and itemid lists the history of the item container that merchant item id names. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **ownerType** | **string**|  | [optional] 
 **ownerObjectId** | **string**|  | [optional] 
 **containerName** | **string**|  | [optional] 

### Return type

[**SfvbContainerVersionsResponse**](SfvbContainerVersionsResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbElements

> SfvbElementsResponse ListSfvbElements ()

List every SFVB element type

The authoritative vocabulary, taken from the same lookup the compiler uses.  A type absent from this list compiles to a literal placeholder line in the page rather than failing, which is why validation treats an unknown type as an error. 


### Example


(No example for this operation).


### Parameters

This endpoint does not need any parameter.

### Return type

[**SfvbElementsResponse**](SfvbElementsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbExperiments

> SfvbExperimentsResponse ListSfvbExperiments (int storefrontOid, string status = null, string type = null, string path = null)

List the storefront's experiments

Every experiment that is not deleted, with its variations and their statistics - the same numbers the store admin shows.  Filter by status, by type (page, url, theme, openai), or by the page an experiment runs on.  auto_ends_at says when the engine will end an experiment by itself, and p_value is a one-way ANOVA across all variations.  Read one experiment for its daily statistics. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **status** | **string**| Running or Ended | [optional] 
 **type** | **string**| page, url, theme or openai | [optional] 
 **path** | **string**| Only experiments on this page, for example /lp/spring-sale/ | [optional] 

### Return type

[**SfvbExperimentsResponse**](SfvbExperimentsResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbFileVersions

> SfvbFileVersionsResponse ListSfvbFileVersions (int storefrontOid, string path = null)

Version history for a storefront file

Version history is the undo for anything in the storefront file system, which is what makes an agent's writes recoverable. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**|  | [optional] 

### Return type

[**SfvbFileVersionsResponse**](SfvbFileVersionsResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbFiles

> SfvbFilesResponse ListSfvbFiles (int storefrontOid, string path = null, int? storefrontFsDirectoryOid = null, int? themeOid = null, int? maxEntries = null)

List a storefront directory

Directories first, then files, each sorted by name.  Address by path or by directory oid; supplying theme_oid also retries a path that does not resolve at the storefront root relative to that theme, so /theme/css/ works without knowing the theme's directory name.  Each file carries its content hash, so a listing is enough to start an If-Match write without a separate read. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**|  | [optional] 
 **storefrontFsDirectoryOid** | **int?**|  | [optional] 
 **themeOid** | **int?**|  | [optional] 
 **maxEntries** | **int?**|  | [optional] 

### Return type

[**SfvbFilesResponse**](SfvbFilesResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbI18nMessages

> SfvbI18nMessagesResponse ListSfvbI18nMessages (int storefrontOid, int? themeOid = null, string q = null, string language = null, bool? overridden = null, int? offset = null, int? limit = null)

List built-in messages

The system text templates render by key, such as checkout labels, for one theme (the active theme unless theme_oid is given).  Each message has its English, whether it was edited, and each enabled language's text with its source (hand, machine, pending or none).  A message appears the first time a page renders it.  q matches the key or the English.  overridden keeps messages with an edited English or a hand translation.  Paged by offset and limit (default 200, at most 500). 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **themeOid** | **int?**|  | [optional] 
 **q** | **string**|  | [optional] 
 **language** | **string**|  | [optional] 
 **overridden** | **bool?**|  | [optional] 
 **offset** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**SfvbI18nMessagesResponse**](SfvbI18nMessagesResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbItemContainers

> SfvbItemContainersResponse ListSfvbItemContainers (int storefrontOid, string merchantItemId = null, int? merchantItemOid = null, string containerName = null, int? maxResults = null, int? offset = null)

List the item containers on the account

An itemcontainer element renders nothing of its own.  It names a slot, and a separate container is resolved per item for that slot, so a catalog of five hundred products with three slots is fifteen hundred containers.  This says which of them exist.  Filter by container_name to find every item carrying one slot, or by merchant_item_id to see what one item has.  Which items are missing a slot is a set difference against pages/items, because a listing can only report containers that exist.  Each row carries hash_sha256, so a listing is enough to start an If-Match write without reading the container first.  Item containers are stored per account rather than per storefront, so storefront_oid identifies the caller's storefront but does not narrow the result. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **merchantItemId** | **string**| Restrict to one item, by the merchant item id a storefront carries | [optional] 
 **merchantItemOid** | **int?**| Restrict to one item, by oid.  Send this or merchant_item_id, not both | [optional] 
 **containerName** | **string**| Restrict to one slot name, matched without regard to case | [optional] 
 **maxResults** | **int?**|  | [optional] 
 **offset** | **int?**|  | [optional] 

### Return type

[**SfvbItemContainersResponse**](SfvbItemContainersResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbLibraryInstalls

> SfvbLibraryInstallsResponse ListSfvbLibraryInstalls (int storefrontOid)

List the library entries installed on a storefront

Each entry's most recently installed revision, its latest published revision and update_available.  Nothing updates automatically.  An entry this account can no longer see is listed without its name. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 

### Return type

[**SfvbLibraryInstallsResponse**](SfvbLibraryInstallsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbPages

> SfvbPageListResponse ListSfvbPages (int storefrontOid, string under = null)

List the storefront's pages

Every page with its settings, sorted by path with the root first.  Hidden pages are included.  Pass under to list one page and everything below it.  Read from the same cached catalog the admin page tree uses, so a page created a moment ago can take a moment to appear here - read it directly with the single-page read to confirm a write. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **under** | **string**| Only this page and the pages below it, for example /lp/ | [optional] 

### Return type

[**SfvbPageListResponse**](SfvbPageListResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbServerLogs

> SfvbServerLogsResponse ListSfvbServerLogs (int storefrontOid, string uri = null, string since = null, bool? errorsOnly = null, int? limit = null)

List recent storefront render logs

The server log the storefront Developer Tools panel shows, one per page render, newest first and without the log text.  Each carries counts of error and warning lines, including Velocity problems such as a null #set, so a failing render stands out without reading every log.  Filter by uri (a case insensitive contains match on the rendered address) and errors_only.  since is 15m, 2h or 1d, or an ISO-8601 time, default 1h; logs are kept for seven days and only the newest 1000.  With a filter the newest 200 logs in the window are searched, and more_available says whether older ones were left unread. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **uri** | **string**|  | [optional] 
 **since** | **string**|  | [optional] 
 **errorsOnly** | **bool?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**SfvbServerLogsResponse**](SfvbServerLogsResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbStorefronts

> SfvbStorefrontsResponse ListSfvbStorefronts ()

List storefronts


### Example


(No example for this operation).


### Parameters

This endpoint does not need any parameter.

### Return type

[**SfvbStorefrontsResponse**](SfvbStorefrontsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbTemplates

> SfvbTemplatesResponse ListSfvbTemplates (int storefrontOid, string pageType = null)

List the active theme's templates

Each template with the page type it declares and what it can render - items, sub-pages, blog posts, pagination, visual builder containers.  A page's group_template names one of these.  The storefront's fixed templates, such as checkout and my account, are flagged system and must never be assigned to a page. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **pageType** | **string**| Only templates declaring this page type, for example group | [optional] 

### Return type

[**SfvbTemplatesResponse**](SfvbTemplatesResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbThemes

> SfvbThemesResponse ListSfvbThemes (int storefrontOid)

List themes for a storefront

Exactly one theme is flagged active.  Writing to the active theme is writing live and requires the sfvb_publish scope. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 

### Return type

[**SfvbThemesResponse**](SfvbThemesResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbUpsellOffers

> SfvbUpsellOffersResponse ListSfvbUpsellOffers (int storefrontOid, bool? stats = null, string statsStart = null, string statsEnd = null, string statsWeekdays = null)

List upsell offers

Every offer on one of this storefront's paths that are not archived, the same list the admin shows, with each offer's full settings but not its container JSON.  An offer on no path yet is still read by oid.  A large container size alongside a small element count is the signature of markup pasted into a single html element.  Stats as on the path list. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **stats** | **bool?**| Include stats | [optional] 
 **statsStart** | **string**| Stats window start, YYYY-MM-DD | [optional] 
 **statsEnd** | **string**| Stats window end, YYYY-MM-DD | [optional] 
 **statsWeekdays** | **string**| Only these weekdays, comma separated mon to sun | [optional] 

### Return type

[**SfvbUpsellOffersResponse**](SfvbUpsellOffersResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSfvbUpsellPaths

> SfvbUpsellPathsResponse ListSfvbUpsellPaths (int storefrontOid, string status = null, string location = null, string search = null, bool? stats = null, string statsStart = null, string statsEnd = null, string statsWeekdays = null, int? maxResults = null, int? offset = null)

List upsell paths

In path order, first to last.  status current (the default) leaves out archived paths.  Stats are computed only with stats=true, over stats_start to stats_end (YYYY-MM-DD, the last 30 days when both are omitted, at most 366 days), because they are the expensive part of the read. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **status** | **string**| current, archived or all | [optional] 
 **location** | **string**| pre checkout or post checkout | [optional] 
 **search** | **string**| Only paths whose name contains this | [optional] 
 **stats** | **bool?**| Include stats | [optional] 
 **statsStart** | **string**| Stats window start, YYYY-MM-DD | [optional] 
 **statsEnd** | **string**| Stats window end, YYYY-MM-DD | [optional] 
 **statsWeekdays** | **string**| Only these weekdays, comma separated mon to sun | [optional] 
 **maxResults** | **int?**| Page size, 1 to 500, default 100 | [optional] 
 **offset** | **int?**| Offset of the first path returned | [optional] 

### Return type

[**SfvbUpsellPathsResponse**](SfvbUpsellPathsResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## MoveSfvbUpsellPath

> SfvbUpsellPath MoveSfvbUpsellPath (int storefrontOid, int upsellPathOid, SfvbUpsellPathMoveRequest moveRequest)

Move an upsell path

Up, down, to the top or to the bottom of the storefront's paths.  Order decides which running path a shopper meets first, so moving a running path needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **upsellPathOid** | **int**|  | 
 **moveRequest** | [**SfvbUpsellPathMoveRequest**](SfvbUpsellPathMoveRequest.md)| Where to move it | 

### Return type

[**SfvbUpsellPath**](SfvbUpsellPath.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PublishSfvbLibraryEntry

> SfvbLibraryEntry PublishSfvbLibraryEntry (int storefrontOid, int libraryOid, string ifMatch, SfvbLibraryPublishRequest publishRequest)

Publish a library entry's draft

Freezes the draft as a published revision at its revision_number and sets who can see it.  Owner only, with the draft's hash_sha256 as If-Match.  Always needs sfvb_publish, because it changes what other merchants can install.  Images, fonts, stylesheets and media must be relative paths, and credential shaped strings are refused.  Public also needs the library publisher property on the account and no executable content at all - no script, html, embed, css or velocity elements.  After those checks an automated AI review reads the fragment, which can take up to about a minute.  A clear violation both of its models agree on refuses any publish with sfvb.library_ai_review_blocked.  A public publish also needs its approval, otherwise sfvb.library_ai_review_inconclusive.  The result is in content_manifest.ai_review. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **libraryOid** | **int**|  | 
 **ifMatch** | **string**| hash_sha256 from the last read.  Required; 428 when absent, 412 when stale. | 
 **publishRequest** | [**SfvbLibraryPublishRequest**](SfvbLibraryPublishRequest.md)| Visibility and release notes | 

### Return type

[**SfvbLibraryEntry**](SfvbLibraryEntry.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **428** |  |  -  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbContainer

> SfvbContainerResponse PutSfvbContainer (int storefrontOid, string ownerType, string ownerObjectId, string ifMatch, SfvbContainerWriteRequest containerWriteRequest, string containerName = null)

Write a container stored outside the file system

Validation is mandatory and runs here regardless of whether the caller validated first.  The previous value is snapshotted before the write, so the change can be reverted.  Side effects the visual builder performs on save, such as upsell screenshot regeneration and email content review flagging, are applied too.  owner_type also says how owner_object_id is read; send itemid to address an item container by merchant item id rather than by oid.  Either way the history records the one canonical address, so a container written under one spelling is listed and reverted under the other. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **ownerType** | **string**|  | 
 **ownerObjectId** | **string**|  | 
 **ifMatch** | **string**| CJSON hash from the last read.  Required; 428 when absent, 412 when stale. | 
 **containerWriteRequest** | [**SfvbContainerWriteRequest**](SfvbContainerWriteRequest.md)| Container CJSON to write | 
 **containerName** | **string**|  | [optional] 

### Return type

[**SfvbContainerResponse**](SfvbContainerResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **428** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbExperimentVariation

> SfvbExperiment PutSfvbExperimentVariation (int storefrontOid, int experimentOid, int variationNumber, SfvbExperimentVariationUpdateRequest experimentVariationUpdateRequest)

Pause or resume a variation

Stops or resumes sending new visitors to one variation of a running experiment.  Visitors already assigned keep seeing it.  Variation 0 cannot be paused, because the split falls back to it, and the last variation still receiving visitors cannot be paused.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **experimentOid** | **int**|  | 
 **variationNumber** | **int**|  | 
 **experimentVariationUpdateRequest** | [**SfvbExperimentVariationUpdateRequest**](SfvbExperimentVariationUpdateRequest.md)| Pause or resume | 

### Return type

[**SfvbExperiment**](SfvbExperiment.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbFileContent

> SfvbFileWriteResponse PutSfvbFileContent (int storefrontOid, string ifMatch, SfvbFileWriteRequest fileWriteRequest, string path = null)

Write a storefront file

Runs the template sandbox, Velocity validation and the internationalization check, records a version, and compiles the sibling .vm when the file is a .cjson under a theme.  Send If-Match with the hash from the last read to avoid clobbering a concurrent change.  Writing into the active theme requires sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **ifMatch** | **string**| Content hash from the last read.  Required; 428 when absent, 412 when stale. | 
 **fileWriteRequest** | [**SfvbFileWriteRequest**](SfvbFileWriteRequest.md)| File content to write | 
 **path** | **string**|  | [optional] 

### Return type

[**SfvbFileWriteResponse**](SfvbFileWriteResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **413** |  |  -  |
| **428** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbI18nGlossary

> SfvbI18nGlossary PutSfvbI18nGlossary (int storefrontOid, SfvbI18nGlossaryRequest glossaryRequest, string ifMatch = null)

Replace the storefront's translation glossary

Replaces the whole glossary, plain markdown up to 64 KB.  The server stores it and never interprets it; the agent follows it.  Send the hash_sha256 you read as If-Match, except for the first save.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **glossaryRequest** | [**SfvbI18nGlossaryRequest**](SfvbI18nGlossaryRequest.md)| The glossary | 
 **ifMatch** | **string**| hash_sha256 from the last read.  Not needed for the first save; otherwise 428 when absent, 412 when stale. | [optional] 

### Return type

[**SfvbI18nGlossary**](SfvbI18nGlossary.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **428** |  |  -  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **413** |  |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbI18nMessage

> SfvbI18nMessage PutSfvbI18nMessage (int storefrontOid, string key, string ifMatch, SfvbI18nMessageWriteRequest messageWriteRequest, int? themeOid = null)

Change one built-in message

Sets one message in any number of languages.  ENG replaces the English, which drops its machine translations so they regenerate.  Any other language becomes a hand translation.  Languages not named are left alone; empty text is refused.  Shoppers see it at once.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **key** | **string**|  | 
 **ifMatch** | **string**| hash_sha256 from the last read.  Required; 428 when absent, 412 when stale. | 
 **messageWriteRequest** | [**SfvbI18nMessageWriteRequest**](SfvbI18nMessageWriteRequest.md)| The languages to change | 
 **themeOid** | **int?**|  | [optional] 

### Return type

[**SfvbI18nMessage**](SfvbI18nMessage.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **428** |  |  -  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbItemAttributes

> SfvbItemResponse PutSfvbItemAttributes (int storefrontOid, SfvbItemAttributeUpdateRequest itemAttributeUpdateRequest, string merchantItemId = null, int? merchantItemOid = null)

Change some of an item's attributes

Partial - only the attributes named change, and an empty value empties one but keeps it on the item.  To remove an attribute no template declares, use the attribute DELETE.  Every entry is validated before any is written, so a refusal leaves the item untouched.  The list types are checked against the shape their renderer actually parses, which matters more than it sounds: a definition list is a bare array with one letter keys, a video list is a wrapper object with keys spelled out, and an item set is comma separated text rather than JSON.  A shape the renderer cannot read is not reported at render time - it renders exactly like an attribute nobody ever set. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **itemAttributeUpdateRequest** | [**SfvbItemAttributeUpdateRequest**](SfvbItemAttributeUpdateRequest.md)| Attributes to change | 
 **merchantItemId** | **string**|  | [optional] 
 **merchantItemOid** | **int?**|  | [optional] 

### Return type

[**SfvbItemResponse**](SfvbItemResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbItemContent

> SfvbItemResponse PutSfvbItemContent (int storefrontOid, SfvbItemContentRequest itemContentRequest, string merchantItemId = null, int? merchantItemOid = null)

Change an item's title or long description

Partial - a field left out is untouched, a field sent empty is cleared, and those are different things.  These are what itemtitle and itemdescription render.  Writing the matching config keys into a container does nothing, because they are dialog buffers bound to the item and the render never reads them.  Both are the catalog's own fields, so a change here reaches the item everywhere, not only on this storefront. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **itemContentRequest** | [**SfvbItemContentRequest**](SfvbItemContentRequest.md)| Title and description to change | 
 **merchantItemId** | **string**|  | [optional] 
 **merchantItemOid** | **int?**|  | [optional] 

### Return type

[**SfvbItemResponse**](SfvbItemResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbItemMultimedia

> SfvbItemResponse PutSfvbItemMultimedia (int storefrontOid, SfvbItemMultimediaRequest itemMultimediaRequest, string merchantItemId = null, int? merchantItemOid = null)

Attach an image to an item

One slot at a time - the default image or one code - and every other image on the item is left alone.  That is the difference from the item API, where images are reachable only through a full item update whose multimedia array is reconciled destructively, so adding one means resending the rest or losing them.  Upload the file with files/upload first and name its storefront path here; unlike a page image it does not have to live in any particular folder, because the bytes are copied into the item's own storage on attach. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **itemMultimediaRequest** | [**SfvbItemMultimediaRequest**](SfvbItemMultimediaRequest.md)| Image to attach | 
 **merchantItemId** | **string**|  | [optional] 
 **merchantItemOid** | **int?**|  | [optional] 

### Return type

[**SfvbItemResponse**](SfvbItemResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbItemSeo

> SfvbItemResponse PutSfvbItemSeo (int storefrontOid, SfvbItemSeoRequest itemSeoRequest, string merchantItemId = null, int? merchantItemOid = null)

Change an item's search metadata

Partial - a field left out is untouched, a field sent empty is cleared and the page falls back to what it fell back to before.  Underneath these are three item attributes with reserved names, so this and the attributes endpoint reach the same storage; it exists separately because the names are not discoverable from the templates.  Two things worth knowing.  A title set here changes the document title only - og:title and twitter:title render the item's description either way.  And there is no canonical or noindex field, because both are site wide switches rather than per item values. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **itemSeoRequest** | [**SfvbItemSeoRequest**](SfvbItemSeoRequest.md)| Search metadata to change | 
 **merchantItemId** | **string**|  | [optional] 
 **merchantItemOid** | **int?**|  | [optional] 

### Return type

[**SfvbItemResponse**](SfvbItemResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbMenu

> SfvbMenu PutSfvbMenu (int storefrontOid, string code, SfvbMenuWriteRequest menuWriteRequest, string ifMatch = null)

Replace a store menu's entries

A whole menu replace, not a merge - what you send is what the menu holds afterwards, so read it, change the tree and send it back.  Omitting items changes only the title; sending an empty array empties the menu.  Writing a code that does not exist creates it.  Every entry is checked before any of it is written, including that a merchant_item_id and a page_path actually resolve, so a tree with one bad entry changes nothing.  Always needs sfvb_publish, because a menu is shared by every theme and there is no dormant copy to change instead. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **code** | **string**| Menu code, matched without regard to case | 
 **menuWriteRequest** | [**SfvbMenuWriteRequest**](SfvbMenuWriteRequest.md)| The menu&#39;s replacement contents | 
 **ifMatch** | **string**| Content hash from the last read.  Required when the menu already exists; 428 when absent, 412 when stale. | [optional] 

### Return type

[**SfvbMenu**](SfvbMenu.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbPageAttributes

> SfvbPageResponse PutSfvbPageAttributes (int storefrontOid, string path, SfvbPageAttributeUpdateRequest pageAttributeUpdateRequest)

Change a page's attributes

A partial update.  Only the attributes you name are changed.  Every entry is checked before any is written.  List, slider, item set, page collection and video list attributes are refused - edit those in the page editor.  Always needs sfvb_publish, because a page's attributes are shared by every theme and there is no dormant copy to change instead. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /catalog/dispensers/ | 
 **pageAttributeUpdateRequest** | [**SfvbPageAttributeUpdateRequest**](SfvbPageAttributeUpdateRequest.md)| Attributes to change | 

### Return type

[**SfvbPageResponse**](SfvbPageResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbPageMultimedia

> SfvbPageResponse PutSfvbPageMultimedia (int storefrontOid, string path, SfvbPageMultimediaRequest pageMultimediaRequest)

Attach an image to a page

Upload the image with files/upload to the page path followed by a filename first, then name that filename here as either the default image or an image code.  The default image is what a pageimage element with no pageImageCode renders, and what a subgroup tile shows.  Replaces whatever that slot held.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /catalog/dispensers/ | 
 **pageMultimediaRequest** | [**SfvbPageMultimediaRequest**](SfvbPageMultimediaRequest.md)| Image to attach | 

### Return type

[**SfvbPageResponse**](SfvbPageResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbPageSelectors

> SfvbPageSelectors PutSfvbPageSelectors (int storefrontOid, string path, SfvbPageSelectors pageSelectorsRequest)

Replace a page's selectors

Each list you send replaces that whole set, and an empty list clears it.  A list you leave out is not touched.  The page's items or blog posts are recalculated from the new selectors straight away.  While a page has item selectors its items cannot be assigned by hand.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /lp/spring-sale/ | 
 **pageSelectorsRequest** | [**SfvbPageSelectors**](SfvbPageSelectors.md)| The selector sets to replace | 

### Return type

[**SfvbPageSelectors**](SfvbPageSelectors.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbPageSettings

> SfvbPageResponse PutSfvbPageSettings (int storefrontOid, string path, SfvbPageSettingsRequest pageSettingsRequest)

Change a page's settings

A partial update.  Only the fields you send change - title, description, templates, visibility, sitemap exclusion, sort orders, items per page and page type.  Unlike the store admin's page save, the page's attributes, images, items, selectors and permissions are left exactly as they are.  Fields that would move or rename the page, and fields this endpoint does not know, are refused.  The root page cannot be hidden.  Always needs sfvb_publish, because page settings are live. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /lp/spring-sale/ | 
 **pageSettingsRequest** | [**SfvbPageSettingsRequest**](SfvbPageSettingsRequest.md)| The settings to change | 

### Return type

[**SfvbPageResponse**](SfvbPageResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbPreviewSession

> SfvbPreviewSessionResponse PutSfvbPreviewSession (int storefrontOid, string previewSessionId, SfvbPreviewSessionRequest previewSession, int? themeOid = null)

Push containers into a preview session

Stores compiled containers against a session created by createSfvbPreviewSession.  Replaces whatever the session held.  The session must exist - this does not create one, so a deleted, expired or never issued id is a 404 rather than a new session.  Nothing durable is written.  Requires a token that resolves to a user, so use the device authorization flow. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **previewSessionId** | **string**|  | 
 **previewSession** | [**SfvbPreviewSessionRequest**](SfvbPreviewSessionRequest.md)| Containers to stage in the preview session | 
 **themeOid** | **int?**|  | [optional] 

### Return type

[**SfvbPreviewSessionResponse**](SfvbPreviewSessionResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbRecordingSettings

> SfvbRecordingSettingsResponse PutSfvbRecordingSettings (int storefrontOid, SfvbRecordingSettingsRequest recordingSettingsRequest)

Turn the storefront's screen recording on or off

Turning it on records real shoppers' sessions from that moment, with no history before it.  The first time starts a 14 day free trial, after which recorded sessions are billed per 1,000.  Only change it when the merchant has asked for it.  Asking for the state it is already in changes nothing, and changed comes back false.  Always needs sfvb_publish, in both directions, because it decides whether live shoppers are recorded.  Limited per storefront to 5 changes a minute, 20 an hour and 50 a day. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **recordingSettingsRequest** | [**SfvbRecordingSettingsRequest**](SfvbRecordingSettingsRequest.md)| Whether to record | 

### Return type

[**SfvbRecordingSettingsResponse**](SfvbRecordingSettingsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbSiteAttributes

> SfvbSiteAttributesResponse PutSfvbSiteAttributes (int storefrontOid, SfvbSiteAttributeUpdateRequest siteAttributeUpdateRequest)

Change a storefront's site attributes

A partial update.  Only the attributes you name are changed.  Every entry is checked before any is written.  List, video list, mailing list and item set attributes are refused, and so are the General screen settings other than the title, the SEO description and keywords and the social account names.  Credentials are refused.  Always needs sfvb_publish, because every theme reads the same attributes and there is no dormant copy to change instead.  The admin General screen saves the whole storefront, so a merchant with it open can still overwrite a change made here. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **siteAttributeUpdateRequest** | [**SfvbSiteAttributeUpdateRequest**](SfvbSiteAttributeUpdateRequest.md)| Attributes to change | 

### Return type

[**SfvbSiteAttributesResponse**](SfvbSiteAttributesResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutSfvbThemeAttributes

> SfvbThemeAttributesResponse PutSfvbThemeAttributes (int storefrontOid, int themeOid, SfvbThemeAttributeUpdateRequest attributeUpdateRequest)

Change a theme's colors, fonts and settings

A partial update.  Only the slots you name are changed and every other slot on the theme keeps its value, so there is no need to send the whole set back to change one color.  Send a whole palette in one call rather than one call per color - they are applied together, so the storefront never renders half of a change.  Needs sfvb_publish when the theme is the one serving live traffic, because a color is referenced by name from every template that uses it and one write repaints the whole storefront at once.  On a dormant theme sfvb_write is enough, which is what makes duplicate-then-restyle work. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **themeOid** | **int**|  | 
 **attributeUpdateRequest** | [**SfvbThemeAttributeUpdateRequest**](SfvbThemeAttributeUpdateRequest.md)| Slots to change | 

### Return type

[**SfvbThemeAttributesResponse**](SfvbThemeAttributesResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RefreshSfvbPage

> SfvbPageRefreshResponse RefreshSfvbPage (int storefrontOid, SfvbPageRefreshRequest pageRefreshRequest)

Drop one page's cached copy

The next request renders the page fresh.  Use it when a write succeeded, a read shows the new value, and the public page still shows the old one.  Writes normally refresh the pages they affect, so a stale page after a write is a bug worth reporting with its URL.  One page per request.  The response says whether the page had a cached copy and whether anything was dropped. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **pageRefreshRequest** | [**SfvbPageRefreshRequest**](SfvbPageRefreshRequest.md)| The page to refresh | 

### Return type

[**SfvbPageRefreshResponse**](SfvbPageRefreshResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RemoveSfvbPageBlogPosts

> SfvbPageBlogPostsResponse RemoveSfvbPageBlogPosts (int storefrontOid, string path, SfvbPageBlogPostsRequest pageBlogPostsRequest)

Take blog posts off a page

Removes posts by blog_post_oid, at most 500 at a time.  Every oid must be on the page, and one that is not changes nothing.  The posts themselves are not touched.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /blog/ | 
 **pageBlogPostsRequest** | [**SfvbPageBlogPostsRequest**](SfvbPageBlogPostsRequest.md)| Blog posts to take off the page | 

### Return type

[**SfvbPageBlogPostsResponse**](SfvbPageBlogPostsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RemoveSfvbPageItems

> SfvbPageItemsResponse RemoveSfvbPageItems (int storefrontOid, string path, SfvbPageItemsRemoveRequest pageItemsRemoveRequest)

Take items off a page

Removes items by item id, at most 500 at a time.  Every id must be on the page, and one that is not changes nothing.  The items themselves are not touched.  Refused on a page whose selectors choose its items.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**| Page path, for example /lp/spring-sale/ | 
 **pageItemsRemoveRequest** | [**SfvbPageItemsRemoveRequest**](SfvbPageItemsRemoveRequest.md)| Items to take off the page | 

### Return type

[**SfvbPageItemsResponse**](SfvbPageItemsResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RenderSfvbWidgets

> SfvbRenderResponse RenderSfvbWidgets (int storefrontOid, int themeOid, SfvbRenderRequest renderRequest)

Render a CJSON node to HTML

Renders one node in the context of a theme and a page.  Unlike compile this is stateful.  Rendering resolves merchant data, so an element bound to an item renders wrongly, and silently, without a context item id.  One node per call, so a node that fails to render fails on its own rather than taking a batch with it, and a failure says why.  By default the node renders as a shopper sees it, with conditions, prices and sale state evaluated against the context item.  Set edit_mode to render every branch the way the builder shows it, for styling content a shopper only sometimes sees. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **themeOid** | **int**|  | 
 **renderRequest** | [**SfvbRenderRequest**](SfvbRenderRequest.md)| Widgets to render | 

### Return type

[**SfvbRenderResponse**](SfvbRenderResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReserveSfvbWidgetIds

> SfvbWidgetIdsResponse ReserveSfvbWidgetIds (int storefrontOid, int? count = null)

Reserve a block of widget ids

Widget ids are allocated by the server, not invented by the caller.  Reserve a block, then form ids as elementType-number.  This is the single most likely thing to get wrong on a first write.  A POST rather than a GET because it consumes a sequence.  A GET that mutates will eventually be prefetched, retried or cached by something that assumed it was safe. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **count** | **int?**|  | [optional] 

### Return type

[**SfvbWidgetIdsResponse**](SfvbWidgetIdsResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ResetSfvbI18nMessage

> SfvbI18nResetResponse ResetSfvbI18nMessage (int storefrontOid, string key, string ifMatch, int? themeOid = null)

Reset one built-in message

Puts a message back to the template's text.  The merchant's English edit and hand translations stop serving at once and every language falls back to machine translation; the message comes back the next time a page renders it.  A message imported from an older theme's locale file is refused.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **key** | **string**|  | 
 **ifMatch** | **string**| hash_sha256 from the last read.  Required; 428 when absent, 412 when stale. | 
 **themeOid** | **int?**|  | [optional] 

### Return type

[**SfvbI18nResetResponse**](SfvbI18nResetResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **428** |  |  -  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ResolveSfvbRedirect

> SfvbRedirectResolveResponse ResolveSfvbRedirect (int storefrontOid, string path = null)

What a shopper gets for a path

Follows the redirect rules for a path exactly as the storefront does and reports each step, the final path, its status and what it lands on (a live page, a hidden page, an item, a 404 or something else).  Read only.  Use it to check every change. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **path** | **string**|  | [optional] 

### Return type

[**SfvbRedirectResolveResponse**](SfvbRedirectResolveResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ResolveSfvbTemplate

> SfvbTemplateResolveResponse ResolveSfvbTemplate (int storefrontOid, string name, int? themeOid = null)

Resolve a template name to the file a page renders

A page stores only its template's file name.  This runs the storefront's own template search for that name and returns the file a page naming it renders, relative to the theme.  It also lists the theme's resource paths in search order with every file of that name below each, so a theme copy overriding a shared core copy, or a copy in a snippets folder that is never used, is visible.  exists is false when a page naming the template cannot render. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **name** | **string**| The template file name, such as catalog.vm | 
 **themeOid** | **int?**| Resolve in this theme instead of the active theme | [optional] 

### Return type

[**SfvbTemplateResolveResponse**](SfvbTemplateResolveResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RevertSfvbContainer

> SfvbContainerResponse RevertSfvbContainer (int storefrontOid, string ownerType, string ownerObjectId, string ifMatch, SfvbContainerRevertRequest containerRevertRequest, string containerName = null)

Revert a container stored outside the file system

The restore is itself snapshotted, so a revert can be undone in turn.  Reverting to an entry recorded before the container existed removes it again.  Addressed through the owning container and guarded by If-Match, because a revert overwrites live content just as much as an ordinary write does.  owner_type also says how owner_object_id is read, so a version written by oid can be reverted by merchant item id and the other way round. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **ownerType** | **string**|  | 
 **ownerObjectId** | **string**|  | 
 **ifMatch** | **string**| CJSON hash of the container being reverted.  Required; 428 when absent, 412 when stale. | 
 **containerRevertRequest** | [**SfvbContainerRevertRequest**](SfvbContainerRevertRequest.md)| Version to revert the container to | 
 **containerName** | **string**|  | [optional] 

### Return type

[**SfvbContainerResponse**](SfvbContainerResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **428** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RevertSfvbFile

> SfvbFileWriteResponse RevertSfvbFile (int storefrontOid, string ifMatch, SfvbFileRevertRequest fileRevertRequest)

Revert a storefront file to an earlier version

The revert lands as a new version, so it is itself undoable. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **ifMatch** | **string**| Content hash of the file being reverted.  Required; 428 when absent, 412 when stale. | 
 **fileRevertRequest** | [**SfvbFileRevertRequest**](SfvbFileRevertRequest.md)| Version to revert the file to | 

### Return type

[**SfvbFileWriteResponse**](SfvbFileWriteResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **428** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SearchSfvbFiles

> SfvbFileSearchResponse SearchSfvbFiles (int storefrontOid, SfvbFileSearchRequest searchRequest)

Search storefront files

Searches names and, when text is supplied, file contents.  For a CLI with no local copy this is the only way to answer where something is defined without walking the whole tree.  Results are capped and truncation is always reported. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **searchRequest** | [**SfvbFileSearchRequest**](SfvbFileSearchRequest.md)| File search | 

### Return type

[**SfvbFileSearchResponse**](SfvbFileSearchResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SearchSfvbLibrary

> SfvbLibraryResponse SearchSfvbLibrary (int storefrontOid, string segment = null, string search = null, int? pageNumber = null, int? resultsPerPage = null)

Search the element library

Known-good CJSON fragments a human already built out of real elements.  This is what a lint warning about a monolithic html element should point at - a warning that names a fragment solving the same problem is an instruction, where a warning on its own is only criticism.  Results are terse; fetch a single entry for its CJSON.  Narrow with a query parameter named after a facet, such as facet_purpose, whose value is the facet name, a colon and one of its options.  Besides element type and author, the facets include purpose, section, industry and style from library/taxonomy, and the search text matches those tags too.  Results follow the same rules as reading one entry, so others see published revisions only. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **segment** | **string**|  | [optional] 
 **search** | **string**|  | [optional] 
 **pageNumber** | **int?**|  | [optional] 
 **resultsPerPage** | **int?**|  | [optional] 

### Return type

[**SfvbLibraryResponse**](SfvbLibraryResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SetSfvbLibraryScreenshot

> SfvbLibraryEntry SetSfvbLibraryScreenshot (int storefrontOid, int libraryOid, string ifMatch, SfvbLibraryScreenshotRequest screenshotRequest)

Set a library entry's screenshot

Three calls, like the other uploads.  Request an upload URL with files/upload_url/png, PUT the PNG bytes to it, then call this with the key, the sha256 of those bytes and where the image came from.  Owner only, with the draft's hash_sha256 as If-Match.  The PNG must be at most 5 MB and 4096 pixels a side; it is re-encoded, which drops any metadata, and a thumbnail is made from it before this returns.  Capture it with test data only.  A refused image leaves the previous screenshot in place.  Other merchants see a new screenshot only after the next publish, whose review checks it. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **libraryOid** | **int**|  | 
 **ifMatch** | **string**| hash_sha256 from the last read.  Required; 428 when absent, 412 when stale. | 
 **screenshotRequest** | [**SfvbLibraryScreenshotRequest**](SfvbLibraryScreenshotRequest.md)| The staged PNG | 

### Return type

[**SfvbLibraryEntry**](SfvbLibraryEntry.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **413** |  |  -  |
| **428** |  |  -  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ShareSfvbLibraryEntry

> SfvbLibraryEntry ShareSfvbLibraryEntry (int storefrontOid, int libraryOid, SfvbLibraryShareRequest shareRequest)

Share a published library entry with a linked account

Owner only, and always needs sfvb_publish.  The merchant must be one share_targets lists, and the entry must have a published revision, which is what the recipient sees.  The published revision is checked again for absolute asset URLs and credentials.  Idempotent. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **libraryOid** | **int**|  | 
 **shareRequest** | [**SfvbLibraryShareRequest**](SfvbLibraryShareRequest.md)| The linked account | 

### Return type

[**SfvbLibraryEntry**](SfvbLibraryEntry.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## StartSfvbExperiment

> SfvbExperiment StartSfvbExperiment (int storefrontOid, SfvbExperimentStartRequest experimentStartRequest)

Start an experiment

type page starts an experiment element already saved in a page body - send path, slot and widget_id, and its name, objective, duration and variations are read from the element with the builder's rules (2 to 5 variations numbered 0 up with no gaps, 3 to 90 days, traffic on all or none adding up to 100).  The new id is written into the element and the body is saved, so pull it again before the next edit.  type url splits visitors between existing pages at router_url, and always ends by itself after duration_days.  Always needs sfvb_publish, because visitors are split as soon as it starts. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **experimentStartRequest** | [**SfvbExperimentStartRequest**](SfvbExperimentStartRequest.md)| The experiment to start | 

### Return type

[**SfvbExperiment**](SfvbExperiment.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **201** |  |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UnarchiveSfvbUpsellPath

> SfvbUpsellPath UnarchiveSfvbUpsellPath (int storefrontOid, int upsellPathOid)

Unarchive an upsell path

Brings the path back into the default list.  Unarchiving one that is switched on starts it, so that needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **upsellPathOid** | **int**|  | 

### Return type

[**SfvbUpsellPath**](SfvbUpsellPath.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UnfavoriteSfvbLibraryEntry

> void UnfavoriteSfvbLibraryEntry (int storefrontOid, int libraryOid)

Remove a library entry from favorites

Removes the calling user's bookmark.  Idempotent. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **libraryOid** | **int**|  | 

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
| **204** | No Content |  -  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UnignoreSfvbNotFoundEntry

> SfvbNotFoundEntry UnignoreSfvbNotFoundEntry (int storefrontOid, string notFoundId)

Stop ignoring a 404 path

The path lists and counts hits again. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **notFoundId** | **string**|  | 

### Return type

[**SfvbNotFoundEntry**](SfvbNotFoundEntry.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UnpublishSfvbLibraryEntry

> SfvbLibraryEntry UnpublishSfvbLibraryEntry (int storefrontOid, int libraryOid, SfvbLibraryPublishRequest unpublishRequest)

Narrow who can see a library entry

Sets visibility to shared or private.  Owner only, and always needs sfvb_publish.  Published revisions are kept and storefronts that already installed the entry keep their copies. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **libraryOid** | **int**|  | 
 **unpublishRequest** | [**SfvbLibraryPublishRequest**](SfvbLibraryPublishRequest.md)| The narrower visibility | 

### Return type

[**SfvbLibraryEntry**](SfvbLibraryEntry.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UnshareSfvbLibraryEntry

> SfvbLibraryUnshareResult UnshareSfvbLibraryEntry (int storefrontOid, int libraryOid, string merchantId)

Stop sharing a library entry with an account

Owner only, and always needs sfvb_publish.  Stops further installs by that account.  Its existing installs keep their copies and are listed in the result.  Idempotent, and still works while the library is turned off. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **libraryOid** | **int**|  | 
 **merchantId** | **string**|  | 

### Return type

[**SfvbLibraryUnshareResult**](SfvbLibraryUnshareResult.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateSfvbBlogPost

> SfvbBlogPostDetail UpdateSfvbBlogPost (int storefrontOid, int blogPostOid, SfvbBlogPostRequest blogPostRequest)

Change a blog post

Only the fields sent change; tags, when sent, replaces every tag.  The post's images and attributes are left alone.  Publish or unpublish with visibility.  A post that is not a draft before or after the change needs sfvb_publish.  The same content rules as create apply. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **blogPostOid** | **int**|  | 
 **blogPostRequest** | [**SfvbBlogPostRequest**](SfvbBlogPostRequest.md)| The fields to change | 

### Return type

[**SfvbBlogPostDetail**](SfvbBlogPostDetail.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateSfvbLibraryEntry

> SfvbLibraryEntry UpdateSfvbLibraryEntry (int storefrontOid, int libraryOid, string ifMatch, SfvbLibraryEntryRequest libraryEntry)

Update a library entry's draft

A full replace of the draft's fields.  Owner only.  Send the hash_sha256 you read as If-Match.  Every save increments revision_number; nothing other merchants see changes until the draft is published.  A changed fragment is re-scanned and its images copied again, and screenshot_stale tells you to retake the screenshot. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **libraryOid** | **int**|  | 
 **ifMatch** | **string**| hash_sha256 from the last read.  Required; 428 when absent, 412 when stale. | 
 **libraryEntry** | [**SfvbLibraryEntryRequest**](SfvbLibraryEntryRequest.md)| The whole entry | 

### Return type

[**SfvbLibraryEntry**](SfvbLibraryEntry.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **413** |  |  -  |
| **428** |  |  -  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateSfvbRedirect

> SfvbRedirectResponse UpdateSfvbRedirect (int storefrontOid, int redirectId, string ifMatch, SfvbRedirectRequest redirectRequest)

Change a redirect rule

Changes the source, target or note, and can turn an admin rule into a 301.  Fields left out keep their value.  A changed source or target is checked like a new rule.  Send the hash_sha256 you read as If-Match.  Always needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **redirectId** | **int**|  | 
 **ifMatch** | **string**| hash_sha256 from the last read.  428 when absent, 412 when stale. | 
 **redirectRequest** | [**SfvbRedirectRequest**](SfvbRedirectRequest.md)| The request | 

### Return type

[**SfvbRedirectResponse**](SfvbRedirectResponse.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **409** |  |  -  |
| **412** |  |  -  |
| **428** |  |  -  |
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateSfvbUpsellOffer

> SfvbUpsellOffer UpdateSfvbUpsellOffer (int storefrontOid, int upsellOfferOid, string ifMatch, SfvbUpsellOffer upsellOffer)

Update an upsell offer

A full replace.  Send back the whole offer you read, changed, with its hash_sha256 in If-Match.  Read only fields are ignored and a writable field left out is cleared.  Changing an offer that is switched on, switching one on, or changing upsell_item_id_javascript or offsite_content_url needs sfvb_publish.  Settings the API does not show, such as the offer's screenshots, are kept. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **upsellOfferOid** | **int**|  | 
 **ifMatch** | **string**| hash_sha256 from the last read.  Required; 428 when absent, 412 when stale. | 
 **upsellOffer** | [**SfvbUpsellOffer**](SfvbUpsellOffer.md)| The whole offer | 

### Return type

[**SfvbUpsellOffer**](SfvbUpsellOffer.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **428** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateSfvbUpsellPath

> SfvbUpsellPath UpdateSfvbUpsellPath (int storefrontOid, int upsellPathOid, string ifMatch, SfvbUpsellPath upsellPath)

Update an upsell path

A full replace.  Send back the whole path you read, changed, with its hash_sha256 in If-Match.  Read only fields are ignored and a writable field left out is cleared.  Order and archived keep their stored values; change them with the move, archive and unarchive calls.  Changing a running path, or switching one on, needs sfvb_publish. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **upsellPathOid** | **int**|  | 
 **ifMatch** | **string**| hash_sha256 from the last read.  Required; 428 when absent, 412 when stale. | 
 **upsellPath** | [**SfvbUpsellPath**](SfvbUpsellPath.md)| The whole path | 

### Return type

[**SfvbUpsellPath**](SfvbUpsellPath.md)

### Authorization

[ultraCartOauth](../README.md#ultraCartOauth), [ultraCartSimpleApiKey](../README.md#ultraCartSimpleApiKey)

### HTTP request headers

- **Content-Type**: application/json; charset=UTF-8
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Status Code 400: bad request input such as invalid json |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **401** | Status Code 401: invalid credentials supplied |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **428** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UploadSfvbFile

> SfvbFileWriteResponse UploadSfvbFile (int storefrontOid, SfvbFileUploadRequest fileUploadRequest, string ifMatch = null)

Store a binary asset that was already uploaded

The second half of the two step upload.  The bytes are fetched from the key, checked against the extension they claim to be, and written exactly as a text write is - so the same If-Match precondition, the same read only refusal and the same publish gate apply.  An SVG is sanitized before it is stored.  Writing outside /themes/ requires sfvb_publish, because anything served off the storefront root is live by definition. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **fileUploadRequest** | [**SfvbFileUploadRequest**](SfvbFileUploadRequest.md)| Where to store the uploaded bytes | 
 **ifMatch** | **string**| Content hash from the last read.  Required when the file already exists; 428 when absent, 412 when stale. | [optional] 

### Return type

[**SfvbFileWriteResponse**](SfvbFileWriteResponse.md)

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
| **403** | Status Code 403: forbidden |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **412** |  |  -  |
| **413** |  |  -  |
| **428** |  |  -  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ValidateSfvbCjson

> SfvbValidationResponse ValidateSfvbCjson (SfvbValidateRequest validateRequest)

Validate CJSON

Runs the structural schema, the contextual business rules for the destination owner type, and the quality lint.  A document that fails returns HTTP 200 with valid false rather than a transport error - the request was well formed, the document was not. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **validateRequest** | [**SfvbValidateRequest**](SfvbValidateRequest.md)| CJSON to validate | 

### Return type

[**SfvbValidationResponse**](SfvbValidationResponse.md)

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
| **429** | Status Code 429: you have exceeded the allowed API call rate limit for your application. |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ValidateSfvbVelocity

> SfvbValidationResponse ValidateSfvbVelocity (int storefrontOid, int themeOid, SfvbVelocityValidateRequest velocityValidateRequest)

Validate a Velocity template against a theme

Theme scoped rather than stateless.  Validation builds a theme template context and evaluates against it.  Also applies the template sandbox, so an agent learns the rule before a write fails. 


### Example


(No example for this operation).


### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storefrontOid** | **int**|  | 
 **themeOid** | **int**|  | 
 **velocityValidateRequest** | [**SfvbVelocityValidateRequest**](SfvbVelocityValidateRequest.md)| Velocity template to validate | 

### Return type

[**SfvbValidationResponse**](SfvbValidationResponse.md)

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
| **404** | Status Code 404: not found |  * UC-REST-ERROR - Contains human readable error message <br>  |
| **500** | Status Code 500: any server side error.  the body will contain a generic server error message |  * UC-REST-ERROR - Contains human readable error message <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

