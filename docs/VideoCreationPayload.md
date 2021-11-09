# ApiVideo.Model.VideoCreationPayload

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The title of your new video. | 
**Description** | **string** | A brief description of your video. | [optional] 
**Source** | **string** | If you add a video already on the web, this is where you enter the url for the video. | [optional] 
**Public** | **bool** | Whether your video can be viewed by everyone, or requires authentication to see it. A setting of false will require a unique token for each view. Default is true. Tutorials on [private videos](https://api.video/blog/endpoints/private-videos). | [optional] [default to true]
**Panoramic** | **bool** | Indicates if your video is a 360/immersive video. | [optional] [default to false]
**Mp4Support** | **bool** | Enables mp4 version in addition to streamed version. | [optional] [default to true]
**PlayerId** | **string** | The unique identification number for your video player. | [optional] 
**Tags** | **List&lt;string&gt;** | A list of tags you want to use to describe your video. | [optional] 
**Metadata** | [**List&lt;Metadata&gt;**](Metadata.md) | A list of key value pairs that you use to provide metadata for your video. These pairs can be made dynamic, allowing you to segment your audience. Read more on [dynamic metadata](https://api.video/blog/endpoints/dynamic-metadata). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

