# ApiVideo.Model.Video

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VideoId** | **string** | The unique identifier of the video object. | 
**CreatedAt** | **DateTime** | When a video was created, presented in ATOM UTC format. | [optional] 
**Title** | **string** | The title of the video content.  | [optional] 
**Description** | **string** | A description for the video content.  | [optional] 
**PublishedAt** | **DateTime** | The date and time the API created the video. Date and time are provided using ATOM UTC format. | [optional] 
**UpdatedAt** | **DateTime** | The date and time the video was updated. Date and time are provided using ATOM UTC format. | [optional] 
**DiscardedAt** | **DateTime?** | The date and time the video was discarded. The API populates this field only if you have the Video Restore feature enabled and discard a video. Date and time are provided using ATOM UTC format. | [optional] 
**DeletesAt** | **DateTime?** | The date and time the video will be permanently deleted. The API populates this field only if you have the Video Restore feature enabled and discard a video. Discarded videos are pemanently deleted after 90 days. Date and time are provided using ATOM UTC format. | [optional] 
**Discarded** | **bool** | Returns &#x60;true&#x60; for videos you discarded when you have the Video Restore feature enabled. Returns &#x60;false&#x60; for every other video. | [optional] 
**Tags** | **List&lt;string&gt;** | One array of tags (each tag is a string) in order to categorize a video. Tags may include spaces.   | [optional] 
**Metadata** | [**List&lt;Metadata&gt;**](Metadata.md) | Metadata you can use to categorise and filter videos. Metadata is a list of dictionaries, where each dictionary represents a key value pair for categorising a video.  | [optional] 
**Source** | [**VideoSource**](VideoSource.md) |  | [optional] 
**Assets** | [**VideoAssets**](VideoAssets.md) |  | [optional] 
**PlayerId** | **string** | The id of the player that will be applied on the video.  | [optional] 
**Public** | **bool** | Defines if the content is publicly reachable or if a unique token is needed for each play session. Default is true. Tutorials on [private videos](https://api.video/blog/endpoints/private-videos/).  | [optional] 
**Panoramic** | **bool** | Defines if video is panoramic.  | [optional] 
**Mp4Support** | **bool** | This lets you know whether mp4 is supported. If enabled, an mp4 URL will be provided in the response for the video.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

