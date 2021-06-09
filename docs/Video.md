# ApiVideo.Model.Video

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VideoId** | **string** | The unique identifier of the video object. | 
**CreatedAt** | **DateTime** | When an webhook was created, presented in ISO-8601 format. | [optional] 
**Title** | **string** | The title of the video content.  | 
**Description** | **string** | A description for the video content.  | [optional] 
**PublishedAt** | **string** | The date and time the API created the video. Date and time are provided using ISO-8601 UTC format. | [optional] 
**UpdatedAt** | **DateTime** | The date and time the video was updated. Date and time are provided using ISO-8601 UTC format. | [optional] 
**Tags** | **List&lt;string&gt;** | One array of tags (each tag is a string) in order to categorize a video. Tags may include spaces.  | [optional] 
**Metadata** | [**List&lt;Metadata&gt;**](Metadata.md) | Metadata you can use to categorise and filter videos. Metadata is a list of dictionaries, where each dictionary represents a key value pair for categorising a video.  | [optional] 
**Source** | [**VideoSource**](VideoSource.md) |  | [optional] 
**Assets** | [**VideoAssets**](VideoAssets.md) |  | [optional] 
**PlayerId** | **string** | The id of the player that will be applied on the video.  | [optional] 
**Public** | **bool** | Defines if the content is publicly reachable or if a unique token is needed for each play session.  | [optional] 
**Panoramic** | **bool** | Defines if video is panoramic.  | [optional] 
**Mp4Support** | **bool** | This lets you know whether mp4 is supported. If enabled, an mp4 URL will be provided in the response for the video.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

