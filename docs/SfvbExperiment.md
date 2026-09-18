
# com.ultracart.admin.v2.Model.SfvbExperiment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoEndsAt** | **string** | When the experiment engine will end this experiment by itself and declare the variation with the best raw objective per session the winner, without a significance check (ISO 8601, UTC).  Set for running url and theme experiments, and for any running experiment whose traffic shifts toward the leader (equal_weighting false).  Null when only ending it deliberately will stop it. | [optional] 
**DaysElapsed** | **int** | Whole days the experiment has run, up to now or to when it ended. | [optional] 
**Experiment** | [**Experiment**](Experiment.md) |  | [optional] 
**Notice** | **string** | Something the caller should know about what this call did or could not do. | [optional] 
**PValueTest** | **string** | The test behind p_value.  one_way_anova across all variations, so a low p_value says some variation differs, not which one is best. | [optional] 
**PageBodyPath** | **string** | Set when this call rewrote a page body - starting a page experiment writes its id there, and ending one without a winner clears it.  Pull the file again before editing it. | [optional] 
**PageBodySha256** | **string** | The rewritten page body&#39;s new hash, for If-Match on the next write. | [optional] 
**RouterUrl** | **string** | For a url experiment, the address visitors must enter through to be split between the pages.  Ads and links must point here, not at the pages. | [optional] 
**SessionsNeededComputedDts** | **string** | When p95_sessions_needed was last estimated (ISO 8601, UTC).  It is estimated only once the experiment has 1000 sessions, and at most hourly.  Null before then. | [optional] 
**Type** | **string** | page for an experiment element inside a page, url for a split between pages, theme for a split between themes, openai for a generated headline experiment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

