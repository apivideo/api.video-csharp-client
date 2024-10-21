# ApiVideo.Model.SummaryCreationPayload

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VideoId** | **string** | Create a summary of a video using the video ID. | 
**Origin** | **string** | Use this parameter to define how the API generates the summary. The only allowed value is &#x60;auto&#x60;, which means that the API generates a summary automatically.  If you do not set this parameter, **the API will not generate a summary automatically**.  In this case, &#x60;sourceStatus&#x60; will return &#x60;missing&#x60;, and you have to manually add a summary using the &#x60;PATCH /summaries/{summaryId}/source&#x60; endpoint operation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

