# ApiVideo.Model.VideoUpdatePayload

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlayerId** | **string** | The unique ID for the player you want to associate with your video. | [optional] 
**Title** | **string** | The title you want to use for your video. | [optional] 
**Description** | **string** | A brief description of the video. | [optional] 
**Public** | **bool** | Whether the video is publicly available or not. False means it is set to private. Default is true. Tutorials on [private videos](https://api.video/blog/endpoints/private-videos/). | [optional] 
**Panoramic** | **bool** | Whether the video is a 360 degree or immersive video. | [optional] 
**Mp4Support** | **bool** | Whether the player supports the mp4 format. | [optional] 
**Tags** | **List&lt;string&gt;** | A list of terms or words you want to tag the video with. Make sure the list includes all the tags you want as whatever you send in this list will overwrite the existing list for the video. | [optional] 
**Metadata** | [**List&lt;Metadata&gt;**](Metadata.md) | A list (array) of dictionaries where each dictionary contains a key value pair that describes the video. As with tags, you must send the complete list of metadata you want as whatever you send here will overwrite the existing metadata for the video. [Dynamic Metadata](https://api.video/blog/endpoints/dynamic-metadata/) allows you to define a key that allows any value pair. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

