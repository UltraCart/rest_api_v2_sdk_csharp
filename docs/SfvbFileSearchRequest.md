
# com.ultracart.admin.v2.Model.SfvbFileSearchRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CaseSensitive** | **bool** | Whether the text search is case sensitive.  Defaults to false. | [optional] 
**DynamicHtml** | **bool** | Only dynamic HTML (arbitrary) files. | [optional] 
**FileName** | **string** | Comma separated file name patterns, matched case insensitively with wildcards. | [optional] 
**I18nViolations** | **bool** | Only files with internationalization violations. | [optional] 
**Invalid** | **bool** | Only files that failed Velocity validation. | [optional] 
**MaxResults** | **int** | Maximum results to return.  Clamped to the server maximum. | [optional] 
**MergeConflicts** | **bool** | Only files with unresolved theme merge conflicts. | [optional] 
**MimeType** | **string** | Restrict to a mime type. | [optional] 
**ModifiedMax** | **string** | Only files modified at or before this ISO-8601 timestamp. | [optional] 
**ModifiedMin** | **string** | Only files modified at or after this ISO-8601 timestamp. | [optional] 
**Offset** | **int** | Results to skip.  Send the next_offset from a truncated response to continue.  Ordering is by path with the file oid as a tie breaker, so pages do not overlap or skip entries between calls. | [optional] 
**Path** | **string** | Restrict to a directory path.  Strongly recommended alongside text. | [optional] 
**SizeMax** | **int** | Maximum size in bytes. | [optional] 
**SizeMin** | **int** | Minimum size in bytes. | [optional] 
**SubDirectories** | **bool** | Recurse below path.  Defaults to true. | [optional] 
**Text** | **string** | Text to find inside files.  Only text/_* files are searched.  This is the expensive filter; narrow with path or file_name where possible. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

