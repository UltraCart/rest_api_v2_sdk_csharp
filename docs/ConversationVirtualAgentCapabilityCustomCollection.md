
# com.ultracart.admin.v2.Model.ConversationVirtualAgentCapabilityCustomCollection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AiDescription** | **string** | Merchant authored description of what is in this collection, which is what the agent sees when deciding whether to search it | [optional] 
**AiEnabled** | **bool** | True if this collection has been enabled for AI access in its own configuration.  A collection that is not enabled cannot be searched even if it is selected here. | [optional] 
**CollectionName** | **string** | Merchant assigned name of the collection | [optional] 
**ErrorMessage** | **string** | Error from the last build, if it failed.  A collection with an error will return nothing to the agent, so this is worth surfacing next to the selection. | [optional] 
**LastUpdateDts** | **string** | Date/time the collection was last rebuilt from the merchant&#39;s BigQuery query | [optional] 
**RecordCount** | **int** | Number of records loaded on the last build | [optional] 
**TypesenseCustomCollectionOid** | **int** | The identifier to place in custom_collection_oids to grant the agent access to this collection | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

