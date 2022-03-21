# ApiVideo.Model.VideoStatusIngestReceivedParts

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Parts** | **List&lt;int&gt;** | The parts that are have been uploaded, ordered. For example, if part 2 was sent before part 1, and both have been uploaded, the output will be [1, 2]. | [optional] 
**Total** | **int?** | Contains the number of expected parts. The total will be listed as \&quot;null\&quot; until the total number of parts is known. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

