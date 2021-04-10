# VideoApiClient.Model.VideoAssets
Collection of details about the video object that you can use to work with the video object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hls** | **string** | This is the manifest URL. For HTTP Live Streaming (HLS), when a HLS video stream is initiated, the first file to download is the manifest. This file has the extension M3U8, and provides the video player with information about the various bitrates available for streaming. | [optional] 
**Iframe** | **string** | Code to use video from a third party website | [optional] 
**Player** | **string** | Raw url of the player. | [optional] 
**Thumbnail** | **string** | Poster of the video. | [optional] 
**Mp4** | **string** | Available only if mp4Support is enabled. Raw mp4 url. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

